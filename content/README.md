# Obsah LearnWeb — formát MD souborů

Tato složka je **záloha a zdroj pro import** obsahu. Za běhu aplikace je zdrojem pravdy PostgreSQL;
změny se do DB dostanou importem (UI → Správa obsahu, nebo `POST /api/content/import*`).
Aktuální stav DB lze kdykoli exportovat zpět do MD (`GET /api/content/export` → ZIP se stejnou strukturou).

```
content/
  <slug-oblasti>/              # hlavní záložka: vsem, togaf, archimate, prince2…
    _oblast.md                 # oblast: název, pořadí, popis
    <slug-predmetu>/
      _predmet.md              # předmět / kurz: oblast, název, pořadí, cíl, formát zkoušky
      01-<slug-tematu>.md      # téma: popis z osnovy + karty + otázky
      02-...
```

Názvy souborů a složek jsou jen pro orientaci — identitu určuje hlavička (`slug`, u tématu `subject` + `slug`).
Předmět se k oblasti váže polem `area`, téma k předmětu polem `subject`. Slug předmětu je jedinečný napříč oblastmi.

## Oblast (`_oblast.md`)

```markdown
---
kind: area
slug: togaf                     # malá písmena bez diakritiky, číslice, pomlčky
name: "TOGAF"
order: 2                        # pořadí záložek na úvodní obrazovce
---

Popis oblasti (libovolný Markdown).
```

## Předmět (`_predmet.md`)

```markdown
---
kind: subject
area: vsem                      # oblast (výchozí vsem, pokud chybí)
slug: projektovy-management     # malá písmena bez diakritiky, číslice, pomlčky
name: "Projektový management"
order: 6                        # pořadí v rámci oblasti
exam_questions: 40              # volitelné — formát zkoušky nanečisto podle certifikace:
exam_minutes: 60                #   počet otázek, časový limit v minutách
exam_pass: 60                   #   a hranice úspěchu v %; buď všechna tři pole, nebo žádné
---

Cíl předmětu (libovolný Markdown).
```

Bez `exam_*` má zkouška nanečisto výchozí formát (20–30 otázek dle volby, 1 minuta na otázku, hranice 85 %).

## Téma (`NN-slug.md`)

```markdown
---
kind: topic
subject: projektovy-management  # slug předmětu
slug: uvod-do-pmg               # unikátní v rámci předmětu
name: "Úvod do projektového managementu"
order: 1
---

Popis tématu (text z osnovy) — vše až po první kartu.

## Projekt {#projekt .term}

Rub karty: definice / výklad / tabulka (Markdown).

### ? Který znak NENÍ atributem projektu?

- [ ] Jedinečnost
- [ ] Časová ohraničenost
- [x] Opakovatelnost
- [ ] Definovaný cíl

> Vysvětlení správné odpovědi (povinné, může mít více řádků začínajících '>').
```

### Pravidla

| Prvek | Pravidlo |
|---|---|
| Karta | `## Líc karty {#klic .typ}` — typ `.term` (pojem), `.explain` (výklad), `.compare` (srovnání, rub s tabulkou) |
| Klíč karty | `[a-z0-9-]`, unikátní v tématu, **neměnit** — váže se na něj pokrok studenta |
| Rub karty | vše mezi nadpisem karty a první otázkou; nesmí být prázdný |
| Otázka | `### ? Text` — 2–6 možností (doporučeno 4), právě jedna `- [x]`, povinné vysvětlení `> ` |
| Soběstačnost | otázka se v kvízu zobrazuje **bez rubu karty a bez ostatních otázek** — nesmí odkazovat na „příklad na kartě" ani na „předchozí otázku"; potřebná data patří do zadání |
| Pořadí otázek | identita otázky = pořadí v kartě; nové otázky přidávej na konec |

### Chování importu

- **Upsert:** oblast dle `slug`, předmět dle `slug`, téma dle (`subject`, `slug`), karta dle klíče, otázka dle pořadí.
  Přesun předmětu do jiné oblasti (změna `area`) zachová pokrok.
- **Nic se nemaže:** karta/otázka, která ze souboru zmizí, se archivuje (skryje); pokrok a historie zůstávají.
  Vrácením do souboru se znovu aktivuje.
- Import je atomický — při jakékoli chybě se neuloží nic. Volba „jen ověřit" (dry run) ukáže chyby
  ve tvaru `soubor:řádek: zpráva` a souhrn změn.
- Lze nahrát jednotlivé soubory, celou složku i ZIP z exportu. Téma, které v importu není, zůstane beze změny.

### Tvorba obsahu

Kostry předmětů VŠEM (předměty + témata s popisem z osnovy) jsou vygenerované z `docs/vsem/`, kostry
certifikačních kurzů (TOGAF, ArchiMate, PRINCE2 — úrovně Foundation a Practitioner) podle struktury
certifikací. Karty a otázky píše Claude Code (viz CLAUDE.md); volitelně lze použít návrh přes LLM
(UI → Správa obsahu → Návrh tématu přes AI), který se vždy nejdřív zkontroluje a teprve pak importuje.

U certifikačních kurzů platí navíc: výklad česky, oficiální anglické pojmy vždy uvedené (zkoušky jsou
anglicky); vlastní formulace — nepřebírat text standardů ani oficiální zkouškové otázky. Practitioner
otázky jsou krátké scénáře, které obsahují všechna potřebná fakta přímo v zadání.
