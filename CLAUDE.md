# LearnWeb — instrukce pro Claude

Webová aplikace pro přípravu studenta VŠEM na zkoušky: výukové karty → testové otázky (MCQ) → adaptivní
opakování (Leitner), hravou formou. Zadání a funkční návrh: [docs/business-analyza-a-navrh.md](docs/business-analyza-a-navrh.md)
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
   - Identita: předmět = `slug`, téma = (`subject`, `slug`), karta = klíč `{#klic}`, otázka = pořadí v kartě.
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
    Engine/                 # Leitner, mastery, výběr otázek (50/30/20), XP a úrovně — čisté funkce
    Study/                  # StudyService: kvízy, vyhodnocení odpovědí, probrání karty, XP
    Llm/                    # LiteLLM klient, návrhy obsahu, Prompts/*.md (embedded)
    Endpoints/              # minimal API: StudyEndpoints (/api/subjects, /api/topics, /api/quiz, /api/answers,
                            #   /api/cards/{id}/learned, /api/stats/summary), ContentEndpoints (/api/content/*)
  tests/LearnWeb.Tests/     # xUnit: parser, round-trip, validita content/, engine, výběr otázek, XP
frontend/
  src/api/                  # client.ts + types.ts (zrcadlí DTO z backend/Endpoints)
  src/components/           # FlashCard, QuestionCard (klávesy 1–4/Enter), SessionSummary, keyboard.ts…
  src/pages/                # Home, Subject, Learn (/uceni/:id), Quiz (/procvicovani?tema=|predmet=), Topic (prohlížení), Content
  nginx.conf                # SPA fallback + proxy /api → backend:8080
content/                    # MD záloha obsahu (bind-mount do backendu jako /content:ro)
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
- [x] Obsah pilotu — Projektový management: 9 témat, 178 karet, 320 otázek (napsáno Claudem, zrecenzováno).
- [x] Obsah: Manažerská ekonomie — 10 témat, 193 karet, 399 otázek (zrecenzováno).
- [x] Obsah: Manažerská ekonomika — 9 témat, 181 karet, 387 otázek (zrecenzováno).
- [x] Obsah: Právo — 8 témat, 161 karet, 352 otázek (právní recenze; stav po novele ZOK 2021 a spotřebitelské novele 2023).
- [ ] Obsah zbylých 12 předmětů. Otevřené termíny všech předmětů viz GAPS-terminy.md.
- [x] **Fáze 2** — režim Učení (mini-kvíz po 5 kartách), Procvičování (téma/předmět, 10 otázek), `POST /api/quiz`,
      `POST /api/answers`, `POST /api/cards/{id}/learned`, `AttemptLog`, XP + úrovně v hlavičce, re-teach po 3+ chybách.
- [ ] **Fáze 3** — denní fronta opakování, horká fronta seance, „pokračovat kde jsi skončil".
- [ ] **Fáze 4** — simulace zkoušky, statistiky, streak, odznaky, úrovně.
- [ ] **Fáze 5** — obsah zbylých předmětů, UX ladění, PWA.

Každá fáze končí funkčním stavem po `docker compose up`. Nové chování enginu vždy s unit testy.
