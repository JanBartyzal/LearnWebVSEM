# Obsah LearnWeb — formát MD souborů

Tato složka je **záloha a zdroj pro import** obsahu. Za běhu aplikace je zdrojem pravdy PostgreSQL;
změny se do DB dostanou importem (UI → Správa obsahu, nebo `POST /api/content/import*`).
Aktuální stav DB lze kdykoli exportovat zpět do MD (`GET /api/content/export` → ZIP se stejnou strukturou).

```
content/
  <slug-predmetu>/
    _predmet.md            # předmět: název, pořadí, cíl
    01-<slug-tematu>.md    # téma: popis z osnovy + karty + otázky
    02-...
```

Název souboru je jen pro orientaci — identitu určuje hlavička (`subject` + `slug`).

## Předmět (`_predmet.md`)

```markdown
---
kind: subject
slug: projektovy-management     # malá písmena bez diakritiky, číslice, pomlčky
name: "Projektový management"
order: 6                        # pořadí na úvodní obrazovce
---

Cíl předmětu (libovolný Markdown).
```

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

- **Upsert:** předmět dle `slug`, téma dle (`subject`, `slug`), karta dle klíče, otázka dle pořadí.
- **Nic se nemaže:** karta/otázka, která ze souboru zmizí, se archivuje (skryje); pokrok a historie zůstávají.
  Vrácením do souboru se znovu aktivuje.
- Import je atomický — při jakékoli chybě se neuloží nic. Volba „jen ověřit" (dry run) ukáže chyby
  ve tvaru `soubor:řádek: zpráva` a souhrn změn.
- Lze nahrát jednotlivé soubory, celou složku i ZIP z exportu. Téma, které v importu není, zůstane beze změny.

### Tvorba obsahu

Kostry (předměty + témata s popisem z osnovy) jsou vygenerované z `docs/vsem/`. Karty se doplňují
ručně nebo návrhem přes LLM (UI → Správa obsahu → Návrh tématu přes AI). Návrh z AI se vždy
nejdřív zkontroluje a teprve pak importuje.
