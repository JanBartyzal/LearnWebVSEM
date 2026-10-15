# LearnWeb — instrukce pro Claude

Webová aplikace pro přípravu na zkoušky: výukové karty → testové otázky (MCQ) → adaptivní opakování (Leitner),
hravou formou. Obsah je rozdělený do **oblastí** (hlavní záložky): **VŠEM** (16 magisterských předmětů) a certifikace
**TOGAF**, **ArchiMate**, **PRINCE2** (kurzy Foundation a Practitioner). Zadání a funkční návrh: [docs/business-analyza-a-navrh.md](docs/business-analyza-a-navrh.md)
(§1–2 platí; **technické rozhodnutí v §3 nahrazuje tento soubor**). Osnovy předmětů: `docs/vsem/`.

## Stack (závazný)

| Vrstva | Technologie |
|---|---|
| Frontend | React 19 + TypeScript, **Vite** (build/dev), **Fluent UI v9** (`@fluentui/react-components`, `@fluentui/react-icons`), React Router, TanStack Query, react-markdown + remark-gfm |
| Backend | C# **.NET 10** (ASP.NET Core minimal API), EF Core + Npgsql, YamlDotNet; Linux kontejner |
| DB | **PostgreSQL 18** — zdroj pravdy v produkci |
| AI brána | **LiteLLM** proxy → upstream **KiloCode API** (Kilo Gateway, OpenAI-kompatibilní) |
| Nasazení | Docker Compose: `db`, `backend`, `frontend` (nginx se SPA + proxy `/api`), `litellm` |

Nepřidávat jiné UI knihovny (Tailwind, MUI, shadcn…) ani jiný state management — styly přes `makeStyles` + `tokens` z Fluent UI.

## Klíčové principy

1. **Aplikace je deterministická.** Učební engine (Leitner, mastery, výběr otázek, XP) jsou čisté funkce bez LLM,
   s unit testy (`backend/src/LearnWeb.Api/Engine/`). Engine je za rozhraním `IRepetitionStrategy` (vyměnitelné za SM-2).
2. **Obsah píše Claude, ne LLM v aplikaci.** Karty a otázky tvoří Claude Code přímo do `content/*.md`
   (paralelně po tématech se sdíleným značením a rozdělením pojmů mezi témata, pak nezávislá recenze faktů
   a výpočtů), validuje (`dotnet test`) a importuje. Každá otázka musí být **srozumitelná samostatně** — kvíz ji
   zobrazuje bez rubu karty (parser na odkazy typu „příklad na kartě" upozorní varováním).
   Termíny z osnov, jejichž výklad nelze jednoznačně doložit, se **nevymýšlejí** — zapisují se do
   [GAPS-terminy.md](GAPS-terminy.md), uživatel je doplní z přednášek a Claude je pak zapracuje.
   **LiteLLM → KiloCode** je určen pro budoucího **agenta nad aplikací** (kontrola pokroku studenta, doporučení,
   další kontroly). Stávající `ContentDraftService` (AI návrh tématu v UI) je jen volitelný pomocník.
   Učení, kvízy ani žádný běžný request nesmí na LLM záviset; bez LiteLLM musí aplikace plně fungovat.
   Backend volá vždy **alias modelu** z `litellm/config.yaml`, nikdy poskytovatele napřímo.
3. **Obsah: PostgreSQL = pravda, MD = záloha a vstup.** Formát MD je specifikován v [content/README.md](content/README.md).
   - Import (`ContentImporter`) je atomický, idempotentní upsert; chyby hlásí jako `soubor:řádek: zpráva`; podporuje dry run.
   - **Nic se nemaže** — karty/otázky, které zmizí ze souboru, se archivují (`IsArchived`), aby se neztratil progress.
   - Identita: oblast = `slug`, předmět = `slug` (jedinečný napříč oblastmi), téma = (`subject`, `slug`), karta = klíč
     `{#klic}`, otázka = pořadí v kartě. Předmět se k oblasti váže polem `area` v `_predmet.md`.
   - Certifikační kurzy mají v `_predmet.md` formát zkoušky (`exam_questions/minutes/pass`); obsah česky s oficiálními
     anglickými pojmy, vlastní formulace (nepřebírat text standardů ani oficiální zkouškové otázky).
   - Export (`ContentExporter` + `MarkdownContentWriter`) musí být bezztrátový — test round-tripu to hlídá.
   - Při změně formátu upravit **zároveň** parser, writer, `content/README.md`, prompt `Llm/Prompts/topic-draft.md` a testy.
4. **Stav studenta:** všechny progress tabulky mají `UserId` (MVP = 1, bez autentizace). `AttemptLog` se nikdy nemaže
   (zdroj pravdy statistik), `CardProgress` je materializovaný stav pro rychlý výběr fronty. Stav studenta mění
   **jen `StudyService`** (`POST /api/answers`, `POST /api/cards/{id}/learned`); pravidla volá z `Engine/`, sám žádná nemá.
   Klient nikdy nedostane správnou odpověď předem — `POST /api/quiz` vrací zamíchané možnosti s původním indexem.
5. **Čeština** v UI, obsahu i chybových hláškách pro uživatele. Identifikátory v kódu anglicky, komentáře česky.
6. **Mobil first:** Učení/Opakování primárně na mobilu na výšku; ovládání kvízu klávesnicí (1–4, Enter);
   informace nikdy jen barvou.

## Struktura

```
backend/
  src/LearnWeb.Api/
    Program.cs              # DI, migrace + seed prázdné DB z /content při startu
    Data/                   # entity, DbContext (snake_case), Migrations/
    Content/                # MD parser/writer, import, export (ZIP)
    Engine/                 # Leitner, mastery, výběr otázek (50/30/20), denní fronta opakování (ReviewQueue),
                            #   horká fronta (HotQueue), ContinueRule, zkouška (ExamComposer/ExamScoring),
                            #   série dní (Streak), odznaky (Badges), XP a úrovně — čisté funkce
    Study/                  # StudyService (+ .Progress.cs): kvízy, odpovědi, probrání karty, zkouška, seance, odznaky, XP;
                            #   StatsService (jen čtení), ProgressQueries (sdílené dotazy)
    Llm/                    # LiteLLM klient, návrhy obsahu, Prompts/*.md (embedded)
    Endpoints/              # minimal API: StudyEndpoints (/api/subjects, /api/topics, /api/quiz, /api/answers,
                            #   /api/cards/{id}/learned, /api/stats/summary, /api/review[/summary], /api/continue,
                            #   /api/exams[/submit], /api/sessions, /api/stats/overview, /api/stats/subjects/{slug}),
                            #   ContentEndpoints (/api/content/*)
  tests/LearnWeb.Tests/     # xUnit: parser, round-trip, validita content/, engine, výběr otázek, XP
frontend/
  src/api/                  # client.ts + types.ts (zrcadlí DTO z backend/Endpoints)
  src/components/           # FlashCard, QuestionCard (klávesy 1–4/Enter), PracticeSession (horká fronta), ContinueCard,
                            #   charts.tsx (SVG grafy, barvy = tokeny tématu v ThemeProvider), achievements.tsx (odznaky,
                            #   záznam seance), motion.ts (animace + lepicí lišta akcí na mobilu), pwa.tsx/pwaInstall.ts,
                            #   crumbs.ts, useDocumentTitle, SessionSummary, keyboard.ts…
  src/pages/                # Home, Subject, Learn (/uceni/:id), Quiz (/procvicovani?tema=|predmet=),
                            #   Review (/opakovani?predmet=), Exam (/zkouska/:slug), Stats (/statistiky?predmet=),
                            #   Topic (prohlížení), Content
  public/                   # PWA: manifest.webmanifest, sw.js (cachuje jen kostru aplikace, /api nikdy), icons/
  nginx.conf                # SPA fallback + proxy /api → backend:8080; sw.js/manifest/index.html bez cache
content/                    # MD záloha obsahu (bind-mount do backendu jako /content:ro)
  <oblast>/_oblast.md       #   vsem/, togaf/, archimate/, prince2/ — každá oblast: _oblast.md + složky předmětů
  <oblast>/<předmět>/       #   _predmet.md + NN-tema.md
litellm/config.yaml         # aliasy modelů → Kilo Gateway
docs/                       # zadání, BA dokument, osnovy VŠEM
```

## Příkazy

Lokální stroj má jen .NET 8 SDK → backend buildit/testovat přes SDK kontejner (v Git Bash vždy `MSYS_NO_PATHCONV=1`):

```bash
# celá aplikace (web http://localhost:8090, API :8080, LiteLLM :4000, Postgres :5432)
docker compose up -d --build

# testy backendu
MSYS_NO_PATHCONV=1 docker run --rm -v "C:/Docker/LearnWeb:/repo" -v learnweb-nuget:/root/.nuget/packages \
  -w /repo/backend mcr.microsoft.com/dotnet/sdk:10.0 dotnet test

# nová EF migrace (po změně entit)
MSYS_NO_PATHCONV=1 docker run --rm -v "C:/Docker/LearnWeb:/repo" -v learnweb-nuget:/root/.nuget/packages \
  -w /repo/backend mcr.microsoft.com/dotnet/sdk:10.0 bash -c \
  'dotnet tool install -g dotnet-ef --version 10.0.13 >/dev/null; ~/.dotnet/tools/dotnet-ef migrations add <Nazev> -p src/LearnWeb.Api -o Data/Migrations'

# frontend dev server (proxy /api → localhost:8080, tj. backend z docker compose)
cd frontend && npm run dev
cd frontend && npm run build && npm run lint
```

Migrace se aplikují automaticky při startu backendu. Prázdná DB se při startu naplní z `content/`
(`Content:SeedOnEmptyDatabase`). Konfigurace přes env proměnné (`.env.example`); tajné klíče jen v `.env` (není v gitu).

## Stav implementace (fáze dle BA §5)

- [x] **Fáze 1** — kostra, Docker Compose, datový model + migrace, MD import/export/validace, výpis předmětů a témat,
      prohlížení karet, správa obsahu v UI, AI návrh tématu přes LiteLLM. Kostry všech 16 předmětů z osnov.
- [x] Obsah pilotu — Projektový management: 9 témat, 180 karet, 326 otázek (napsáno Claudem, zrecenzováno).
- [x] Obsah: Manažerská ekonomie — 10 témat, 193 karet, 399 otázek (zrecenzováno).
- [x] Obsah: Manažerská ekonomika — 9 témat, 181 karet, 388 otázek (zrecenzováno).
- [x] Obsah: Právo — 8 témat, 163 karet, 359 otázek (právní recenze; stav po novele ZOK 2021 a spotřebitelské novele 2023).
- [x] Obsah: Řízení lidských zdrojů — 6 témat, 130 karet, 284 otázek (zrecenzováno).
- [x] Obsah: Strategický management — 4 témata, 99 karet, 224 otázek (zrecenzováno; rámec Hill & Jones).
- [x] Obsah: Strategický marketing — 12 témat, 197 karet, 421 otázek (zrecenzováno; nejasné formulace osnovy v GAPS, otázky na nich nestojí).
- [x] Obsah: Strategie podniku — 6 témat, 116 karet, 274 otázek (zrecenzováno; sladěno s Manažerskou ekonomikou).
- [x] Obsah: ICT strategie — 11 témat, 191 karet, 385 otázek (zrecenzováno).
- [x] Obsah: Krizový management — 9 témat, 154 karet, 315 otázek (zrecenzováno).
- [x] Obsah: Aplikace podnikové informatiky — 12 témat, 203 karet, 395 otázek (zrecenzováno; sladěno s ICT strategií).
- [x] Obsah: Měření firemní výkonnosti — 12 témat, 207 karet, 446 otázek (zrecenzováno; sladěno s Manažerskou ekonomikou a Strategií podniku).
- [x] Obsah: Systémy řízení — 8 témat, 152 karet, 335 otázek (zrecenzováno; terminologie dle ČSN EN ISO 9000:2016, sladěno s Krizovým managementem a MFV).
- [x] Obsah: Management změny — 6 témat, 164 karet, 358 otázek (zrecenzováno; sladěno s Krizovým managementem, ŘLZ a Strategickým marketingem).
- [x] Obsah: Ekonomické a sociální inovace — 10 témat, 218 karet, 492 otázek (zrecenzováno; navazuje na Management změny 03, sladěno se Strategickým marketingem a SM).
- [x] Obsah: Finanční řízení — 9 témat, 215 karet, 488 otázek (zrecenzováno, výpočty ověřeny skriptem; sladěno s MEK 02/04, SP 03/04 a Právem; sazby daní vždy v zadání).
- [x] **Obsah všech 16 předmětů: 141 témat, 2 763 karet, 5 889 otázek** (po zapracování GAPS 10/2026). Otevřené termíny viz GAPS-terminy.md — po doplnění uživatelem zapracovat.
- [x] **Fáze 2** — režim Učení (mini-kvíz po 5 kartách), Procvičování (téma/předmět, 10 otázek), `POST /api/quiz`,
      `POST /api/answers`, `POST /api/cards/{id}/learned`, `AttemptLog`, XP + úrovně v hlavičce, re-teach po 3+ chybách.
- [x] **Fáze 3** — denní fronta opakování (splatné karty, nejdřív chybované; limit 20 karet/předmět/den, seance 20,
      limit lze vědomě překročit), horká fronta seance (chyba se vrátí na konec seance max. 2×, s jinou otázkou;
      opakování chyby kartu jen ověří, krabici neposune), „pokračovat kde jsi skončil", CTA na domovské stránce,
      počet k opakování v hlavičce. „Dnes" = místní čas backendu (`TZ`, výchozí Europe/Prague).
- [x] **Fáze 4** — zkouška nanečisto (20/25/30 otázek úměrně tématům, volitelný limit 1 min/otázka, bez průběžné
      zpětné vazby, vyhodnocení s rozpadem po tématech; ≥ 85 % +200 XP; zkouška kartu „neprobírá", chyby jdou do
      opakování), `StudySession` (dokončené seance → série dní), statistiky (kalendář, odznaky, mastery témat,
      úspěšnost 30 dní, nejčastější chyby, historie zkoušek), 5 odznaků z BA, série v hlavičce. Grafy vlastní SVG
      (bez knihoven), barvy ověřené validátorem palet pro světlý i tmavý režim.
- [x] **Fáze 5 — PWA a UX:** manifest + ikony (i maskovatelná, Apple), vlastní service worker (jen kostra aplikace),
      „Přidat na plochu", upozornění offline; animace (odhalení karty, zpětná vazba; vypnuté při prefers-reduced-motion),
      na mobilu lepicí lišta hlavní akce a přejetí prstem v Učení, průběh v Procvičování/Opakování, názvy stránek,
      doporučené téma podle sylabu, zalamovaná drobečková navigace (žádné vodorovné přetečení na 390 px).
- [ ] **Fáze 5 — GAPS:** zbylé položky GAPS-terminy.md čekají na skripta VŠEM / zápisky z přednášek.

### Certifikační oblasti (TOGAF, ArchiMate, PRINCE2)

- [x] **Struktura** — entita `Area` + `Subject.AreaId` (migrace `AddAreas` přesunula 16 předmětů pod VŠEM), `kind: area`,
      formát zkoušky podle certifikace, hlavní záložky na domovské stránce, drobečky Oblast › Předmět › Téma.
      Kostry: togaf-foundation (10 témat), togaf-practitioner (8), archimate-foundation (10), archimate-practitioner (8),
      prince2-foundation (13), prince2-practitioner (8) — zatím bez karet.
- [ ] Obsah: TOGAF (Foundation + Practitioner).
- [ ] Obsah: ArchiMate (Foundation + Practitioner).
- [ ] Obsah: PRINCE2 (Foundation + Practitioner).

Každá fáze končí funkčním stavem po `docker compose up`. Nové chování enginu vždy s unit testy.
