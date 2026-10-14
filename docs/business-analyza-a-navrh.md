# LearnWeb — Business analýza a návrh aplikace

> **Určení dokumentu:** Zadání pro implementaci (Opus). Popisuje co aplikace dělá, proč, jaké má funkce a chování, datový model a doporučenou architekturu. Zdrojové podklady: `zadání.txt` a sylaby předmětů v `docs/vsem/`.

---

## 1. Business analýza

### 1.1 Cíl produktu

Webová aplikace pro přípravu studenta VŠEM na zkoušky. Student si zvolí předmět a aplikace ho **hravou formou** provede celou látkou:

1. **Výuka** — postupné procházení látky formou citací a výukových karet (flashcards), členěných podle témat sylabu.
2. **Testování** — otázky s výběrem z více možností (multiple choice), generované z probraných karet.
3. **Adaptivní opakování** — aplikace si pamatuje špatné odpovědi a na základě zpětné vazby vrací problematické karty do oběhu, dokud je student neovládá.

**Měřítko úspěchu:** student zvládne látku předmětu natolik, aby obstál u zkoušky. Proxy metrika v aplikaci: „zvládnutost" (mastery) všech témat předmětu ≥ cílová hranice (např. 85 %).

### 1.2 Cílový uživatel

- Primárně **jeden student VŠEM** (osobní nástroj, self-hosted v Dockeru). Žádná registrace ani přihlašování v MVP; datový model ale připravit na více profilů (sloupec `user_id`), aby šlo později rozšířit.
- Používá aplikaci v krátkých seancích (10–30 min), často na mobilu → **responzivní UI je povinné**.
- Jazyk UI i obsahu: **čeština**.

### 1.3 Rozsah obsahu

16 předmětů dle `docs/vsem/seznam-prednetu.md`. Každý soubor předmětu obsahuje:
- odstavec s **cílem předmětu** (první řádek),
- odrážky s **tématy osnovy** (každá odrážka = jedno téma, obsahuje název a výčet pojmů).

**Klíčové zjištění:** sylaby jsou pouze osnova — neobsahují učební texty, definice ani otázky. Součástí řešení proto musí být **obsahová pipeline** (viz §4), která z osnovy vytvoří karty a testové otázky. Bez ní aplikace nemá co zobrazovat.

### 1.4 Hlavní principy (z nich plynou všechna rozhodnutí)

| Princip | Důsledek pro návrh |
|---|---|
| Hravost, ne biflování | Gamifikace (XP, série dnů, odznaky, mapa pokroku), krátké seance, okamžitá zpětná vazba s vysvětlením |
| Pamatuje si chyby | Spaced repetition (Leitnerovy krabice), fronta „k opakování", chybné karty se vracejí častěji |
| Postupné procházení všech detailů | Lineární průchod tématy s odemykáním, ale s možností přeskočit (student není vězněm pořadí) |
| Cíl = uspět u zkoušky | Režim „simulace zkoušky" nad celým předmětem, přehled slabin po tématech |

### 1.5 Mimo rozsah (MVP)

- Více uživatelů, autentizace, synchronizace mezi zařízeními.
- Otevřené (textové) odpovědi a jejich AI hodnocení.
- Tvorba obsahu přímo v UI (editor karet) — obsah se dodává jako soubory, UI má jen import.
- Nativní mobilní aplikace (stačí responzivní web / PWA).

---

## 2. Funkční návrh

### 2.1 Struktura učiva

```
Předmět (16×)
 └─ Téma (odrážka sylabu, typicky 8–10 na předmět)
     └─ Karta (výuková jednotka: pojem/citace/princip; typicky 10–25 na téma)
         └─ Otázky (1–3 MCQ na kartu, 4 možnosti, právě 1 správná)
```

Typy karet:
- **Pojem** — termín + definice (rub/líc, otočitelná karta).
- **Citace/výklad** — krátký výukový text (3–6 vět) k principu či metodě, s příkladem.
- **Srovnání** — tabulka/kontrast dvou pojmů (např. CPM vs. PERT, Project Manager vs. PTL).

Každá otázka má povinné **vysvětlení správné odpovědi** (zobrazí se po zodpovězení — to je hlavní učební moment) a vazbu na kartu, ze které vychází.

### 2.2 Režimy aplikace

**A) Domů / výběr předmětu**
- Dlaždice 16 předmětů s ukazatelem pokroku (% zvládnutí, kroužkový graf).
- Globální prvky gamifikace: denní série (streak), XP, poslední odznak.
- Výrazné CTA: „Pokračovat tam, kde jsi skončil" + „Dnešní opakování (N karet)".

**B) Učení (Learn)**
- Průchod tématem karta po kartě. Karta pojmu se otáčí (otázka → odpověď), výkladová karta se čte.
- Po každých ~5 kartách krátký **kontrolní kvíz** (2–3 MCQ z právě probraných karet) — rytmus „nauč se → ověř", ne dlouhá četba.
- Na konci tématu shrnutí: co ses naučil, skóre kvízů, získané XP.
- Témata se doporučují v pořadí sylabu; další téma se vizuálně „odemyká", ale lze otevřít libovolné.

**C) Procvičování (Quiz)**
- Kvíz nad zvoleným tématem nebo celým předmětem; výchozí délka 10 otázek.
- Výběr otázek řídí engine (§2.3): priorita chybovaným kartám a kartám „k opakování".
- Okamžitá zpětná vazba: správně/špatně + vysvětlení + odkaz „zobrazit kartu".
- Míchat pořadí možností při každém zobrazení otázky.

**D) Opakování (Review) — srdce aplikace**
- Denní fronta karet splatných podle Leitnerova plánu + všechny karty s nedávnou chybou.
- Formát: MCQ otázka z karty; u karet-pojmů volitelně samohodnocení („věděl jsem / nevěděl") po otočení.
- Správně → karta postupuje do vyšší krabice (delší interval). Špatně → návrat do krabice 1 (opakuje se zítra).
- Prázdná fronta = pochvala a nabídka pokračovat v učení.

**E) Simulace zkoušky**
- Test nad celým předmětem: 20–30 otázek napříč tématy, časový limit (volitelný), bez průběžné zpětné vazby.
- Výsledek až na konci: celkové skóre, rozpad po tématech (kde jsou slabiny), seznam chyb s vysvětleními.
- Chybované karty se automaticky zařadí do opakovací fronty.

**F) Statistiky / pokrok**
- Na předmět: mastery po tématech (heatmapa/sloupce), křivka úspěšnosti v čase, nejčastěji chybované karty.
- Globálně: streak kalendář, XP, odznaky.

### 2.3 Učební engine (chování)

**Stav karty na uživatele** (`card_progress`):
- `box` (1–5, Leitner): intervaly opakování 1 / 2 / 4 / 7 / 14 dní,
- `due_date`, `correct_count`, `wrong_count`, `last_result`, `seen_at`.

**Pravidla:**
1. Nová karta po prvním probrání v režimu Učení → krabice 1, splatná zítra.
2. Správná odpověď v Opakování → box+1 (max 5), `due_date = dnes + interval(box)`.
3. Špatná odpověď kdekoli (kvíz, opakování, zkouška) → box = 1, `due_date = zítra`, karta navíc vstoupí do „horké fronty" aktuální seance (zopakuje se ještě tentýž den na konci seance).
4. **Mastery tématu** = podíl karet tématu v krabici ≥ 3 (vážené: box 3 = 0.6, box 4 = 0.8, box 5 = 1.0). Mastery předmětu = průměr témat.
5. Výběr otázek do kvízu: 50 % karty s chybami / nízkým boxem, 30 % splatné karty, 20 % náhodné z probraných (udržování).
6. U otázek s opakovanou chybou (3+) zobrazit kartu znovu celou (re-teach), ne jen vysvětlení.

**Deterministická pravidla, žádná ML magie** — Leitner je jednoduchý na implementaci, transparentní pro uživatele a pro tento účel plně dostačuje. (SM-2 lze doplnit později, rozhraní enginu navrhnout jako vyměnitelnou strategii.)

### 2.4 Gamifikace

- **XP:** probraná karta +5, správná odpověď +10 (v opakování +15), dokončené téma +50, simulace zkoušky ≥ 85 % +200.
- **Streak:** den se počítá při ≥ 1 dokončené seanci opakování nebo učení; zobrazit kalendář.
- **Odznaky (příklady):** „První téma", „7 dní v řadě", „Předmět zvládnut", „Zkouška nanečisto ≥ 90 %", „50 karet za den".
- **Úrovně:** prostá XP křivka (level = f(XP)), vizuální, bez herních mechanik navíc.
- Tón: povzbuzující, krátké hlášky, žádné penalizace — chyba je informace, ne trest.

---

## 3. Technický návrh

> **Překonáno:** Stack a technická rozhodnutí této kapitoly (Next.js, SQLite, JSON obsah) byla nahrazena —
> platí [CLAUDE.md](../CLAUDE.md): React + Vite + Fluent UI, backend .NET 10, PostgreSQL, obsah v MD (záloha/import),
> LiteLLM brána na KiloCode API. Datový model (§3.2) a API (§3.3) zůstávají věcně platné jako výchozí bod.

### 3.1 Doporučený stack (původní návrh)

| Vrstva | Volba | Zdůvodnění |
|---|---|---|
| Aplikace | **Next.js (App Router, TypeScript)** — full-stack, API routes | Jedna služba, SSR + API pohromadě, snadný Docker |
| UI | React + Tailwind CSS, komponenty shadcn/ui | Rychlý vývoj, responzivita, animace otáčení karet |
| DB | **SQLite** přes Prisma ORM (soubor ve volume) | Single-user, zero-ops, zálohování = kopie souboru; Prisma umožní pozdější přechod na Postgres |
| Nasazení | Docker Compose: 1 kontejner `app` + volume `data` (SQLite) a bind-mount `content/` | Odpovídá prostředí uživatele (c:\Docker) |
| Stav na klientu | Server state přes API; žádný složitý state management (stačí React Query nebo fetch v server components) | Jednoduchost |

Alternativa, pokud by Opus preferoval: SvelteKit se stejnou DB vrstvou. Nevolit oddělený backend+frontend — zbytečná složitost pro single-user nástroj.

### 3.2 Datový model (Prisma schéma — jádro)

```prisma
model Subject  { id, slug, name, goal(Text), order, topics Topic[] }
model Topic    { id, subjectId, name, description(Text), order, cards Card[] }
model Card     { id, topicId, type(enum: TERM|EXPLAIN|COMPARE), front(Text), back(Text), order, questions Question[] }
model Question { id, cardId, text, options(Json: string[4]), correctIndex, explanation(Text) }

model CardProgress { id, cardId, userId(default 1), box(1..5), dueDate, correctCount, wrongCount, lastResult, seenAt
                     @@unique([cardId, userId]) }
model AttemptLog   { id, questionId, userId, mode(enum: LEARN|QUIZ|REVIEW|EXAM), isCorrect, answeredAt }
model ExamResult   { id, subjectId, userId, score, total, breakdown(Json per-topic), finishedAt }
model UserStats    { userId, xp, level, streakDays, lastActiveDate, badges(Json) }
```

`AttemptLog` je zdroj pravdy pro statistiky; `CardProgress` je materializovaný stav pro rychlý výběr fronty.

### 3.3 API (interní, REST přes Next.js routes)

- `GET /api/subjects`, `GET /api/subjects/:slug` (včetně mastery)
- `GET /api/topics/:id/cards` (učení)
- `POST /api/quiz` body `{subjectId|topicId, mode, count}` → vybrané otázky dle enginu
- `POST /api/answers` body `{questionId, selectedIndex, mode}` → vyhodnocení + aktualizace progress/XP (jediné místo, kde se mění stav enginu)
- `GET /api/review/queue` → dnešní splatné karty
- `GET /api/stats`, `GET /api/stats/:subjectId`
- `POST /api/import` → načtení/obnovení obsahu z `content/` (idempotentní upsert dle slug/order)

### 3.4 Struktura obsahu na disku

Obsah žije jako verzovatelné soubory mimo DB, DB je jen importuje:

```
content/
  projektovy-management/
    subject.json            # name, goal, order
    01-uvod-do-pmg.json     # téma: {name, description, cards:[{type, front, back, questions:[...]}]}
    02-organizace-projektu.json
    ...
```

JSON (ne Markdown) kvůli validaci schématem (zod) při importu. Import hlásí chyby srozumitelně (soubor + pole).

---

## 4. Obsahová pipeline (nutná podmínka projektu)

Sylaby v `docs/vsem` jsou jen osnovy. Obsah vznikne takto:

1. **Skript/prompt pro generování obsahu** (součást repa, např. `scripts/generate-content.md` jako šablona promptu): pro každé téma sylabu vygenerovat pomocí Claude 15–25 karet a ke každé 1–3 MCQ s vysvětlením, výstup přímo ve formátu `content/*.json`. Šablona musí vyžadovat: fakticky správný obsah na úrovni VŠ učebnice, českou terminologii, vysvětlení u každé otázky, distraktory věrohodné (ne absurdní).
2. **Validace importem** (`POST /api/import` nebo `npm run import`) — schéma + kontrola duplicit.
3. **Pilotní předmět: Projektový management** (nejbohatší sylabus) — na něm se odladí formát i UX, pak teprve generovat zbylých 15 předmětů.
4. Student může kterýkoli soubor ručně opravit/doplnit (např. z vlastních skript) a znovu importovat — import je upsert, progress se neztrácí (vazba přes stabilní `order`/slug karty).

---

## 5. Plán implementace (fáze)

**Fáze 1 — Kostra + obsah pilotu**
Scaffold Next.js + Prisma + Docker Compose; datový model; import pipeline; vygenerovaný obsah pro Projektový management; výpis předmětů a témat.

**Fáze 2 — Učení a kvíz**
Režim Učení (karty + mini-kvízy), režim Procvičování, vyhodnocování odpovědí, `AttemptLog`, základní XP.

**Fáze 3 — Opakovací engine**
Leitner, denní fronta, horká fronta seance, mastery výpočty, obrazovka Opakování, „Pokračovat kde jsi skončil".

**Fáze 4 — Zkouška + statistiky + gamifikace**
Simulace zkoušky s rozpadem po tématech, statistiky, streak, odznaky, úrovně.

**Fáze 5 — Zbylý obsah + ladění**
Generování obsahu zbylých 15 předmětů, UX ladění (animace, mobil), PWA manifest (ikona na ploše telefonu).

Každá fáze končí funkčním, nasaditelným stavem (`docker compose up`).

---

## 6. Nefunkční požadavky

- **Čeština** všude (UI, obsah, chybové hlášky).
- **Responzivita:** mobil na výšku je primární layout pro Učení/Opakování; desktop pro statistiky.
- **Výkon:** vše lokální, odezvy < 100 ms; žádné externí služby za běhu (AI se používá jen offline při tvorbě obsahu).
- **Perzistence:** SQLite ve volume; záloha = kopie souboru; `AttemptLog` nikdy nemazat.
- **Přístupnost:** ovládání kvízu klávesnicí (1–4, Enter), dostatečný kontrast, žádné informace jen barvou.
- **Bez autentizace** v MVP, ale všechny progress tabulky mají `userId`.

## 7. Rizika a otevřené body

| Riziko | Mitigace |
|---|---|
| Kvalita AI-generovaného obsahu (fakticky chybné karty) | Pilot na 1 předmětu, ruční kontrola vzorku, možnost editace souborů + reimport |
| Sylaby jsou heslovité — AI může téma vyložit jinak než přednášky VŠEM | Umožnit studentovi vložit vlastní materiály do promptu šablony; obsah je soubor, snadno se opraví |
| Příliš mnoho karet → demotivace | Limit seance (max ~20 karet opakování/den na předmět), zbytek se rozloží na další dny |
| Gamifikace přeroste učení | XP/odznaky jen jako koření; jádro je fronta opakování |
