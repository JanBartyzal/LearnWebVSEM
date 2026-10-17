---
kind: topic
subject: togaf-foundation
slug: techniky-adm
name: "Techniky ADM"
order: 10
---

Architecture Principles (struktura principu), Stakeholder Management (power/interest, stakeholder map), Business Scenarios, Gap Analysis, Interoperability, Business Transformation Readiness, Risk Management, Capability-Based Planning, Migration Planning Techniques.

## Techniky ADM (ADM Techniques) {#techniky-adm .explain}

TOGAF Standard kromě samotných fází ADM popisuje sadu **technik**, které architektovi pomáhají fáze provést — např. Architecture Principles, Stakeholder Management, Gap Analysis, Migration Planning Techniques, Interoperability Requirements, Business Transformation Readiness Assessment, Risk Management nebo Capability-Based Planning. Techniky **nejsou povinné kroky**: vybírají se a přizpůsobují podle potřeb organizace a konkrétního úkolu, podobně jako se přizpůsobuje celé ADM. Jedna technika se často používá ve více fázích (např. Gap Analysis ve fázích B, C, D a E).

*Příklad:* Malá firma s jednoduchou zakázkou použije jen analýzu mezer a jednoduchou mapu stakeholderů; velký státní úřad využije i formální hodnocení připravenosti na transformaci a podrobné řízení rizik.

### ? Jak TOGAF Standard pohlíží na techniky ADM (např. Gap Analysis nebo Risk Management)?

- [ ] Jako povinné kroky, které se musí provést v každé fázi ADM beze změny
- [ ] Jako certifikované nástroje dodávané externími dodavateli
- [x] Jako pomůcky, které se vybírají a přizpůsobují podle potřeby
- [ ] Jako náhradu fází ADM v malých organizacích

> Techniky podporují provádění fází ADM a organizace je volí a přizpůsobuje podle svých potřeb. Nejsou to povinné kroky, nenahrazují fáze a nejde o produkty dodavatelů.

## Struktura architektonického principu {#struktura-principu .compare}

Každý architektonický princip se v TOGAF zapisuje ve **standardní šabloně o čtyřech částech**:

| Část | Co obsahuje |
|---|---|
| **Name** | krátký, snadno zapamatovatelný název vystihující podstatu pravidla; bez konkrétních produktů a technologií |
| **Statement** | stručné a jednoznačné vyjádření samotného pravidla |
| **Rationale** | zdůvodnění — jaký přínos má dodržování principu pro byznys, často s odkazem na jiné principy |
| **Implications** | důsledky — co dodržení principu vyžaduje od byznysu i IT (zdroje, náklady, úkoly), včetně dopadů na stávající stav |

### ? Která část zápisu architektonického principu popisuje, co jeho dodržení vyžaduje od organizace (náklady, zdroje, nové úkoly)?

- [ ] Name
- [ ] Statement
- [ ] Rationale
- [x] Implications

> Implications popisují důsledky principu — požadavky na byznys a IT, které z jeho dodržování plynou. Rationale naopak vysvětluje, proč je princip pro byznys přínosný.

### ? Která část zápisu architektonického principu vysvětluje, proč je jeho dodržování pro organizaci přínosné?

- [x] Rationale
- [ ] Implications
- [ ] Statement
- [ ] Name

> Rationale je zdůvodnění principu: uvádí jeho přínos pro byznys. Statement formuluje samotné pravidlo a Implications jeho důsledky.

### ? Která čtyři pole tvoří standardní šablonu architektonického principu v TOGAF?

- [ ] Name, Owner, Statement, Priority
- [x] Name, Statement, Rationale, Implications
- [ ] Name, Purpose, Scope, Constraints
- [ ] Statement, Rationale, Metrics, Exceptions

> Šablona principu má části Name, Statement, Rationale a Implications. Vlastník, priorita, metriky ani výjimky nejsou její standardní součástí.

## Kritéria kvality principů {#kvalita-principu .explain}

TOGAF uvádí pět vlastností dobré sady principů: **Understandable** (srozumitelné celé organizaci, bez nejasností), **Robust** (dost přesné, aby umožnily konzistentní rozhodnutí i ve složitých situacích, a byly vymahatelné), **Complete** (pokrývají všechny důležité oblasti řízení informací a technologií), **Consistent** (vzájemně se nevylučují — přísné uplatnění jednoho může vyžadovat volnější výklad jiného, sada tedy musí umožnit vyvážení) a **Stable** (trvalé, ale s procesem pro jejich změnu). Principů má být spíše méně a obecných, aby architekturu zbytečně nesvazovaly. Kolidují-li v konkrétním rozhodnutí (např. dostupnost dat × bezpečnost dat), architekt musí jejich váhu vyvážit a rozhodnutí zdůvodnit.

*Příklad:* Princip „Data jsou sdílená" a princip „Data jsou chráněná" mohou v konkrétním projektu kolidovat; dobře sestavená sada umožní najít vyvážené řešení, místo aby jeden princip automaticky přebil druhý.

### ? Která vlastnost dobré sady principů požaduje, aby byly principy dost přesné pro konzistentní rozhodování i ve složitých situacích?

- [ ] Understandable
- [ ] Stable
- [x] Robust
- [ ] Complete

> Robust znamená, že principy umožňují kvalitní a konzistentní rozhodnutí a jsou vymahatelné. Understandable se týká srozumitelnosti, Stable trvanlivosti a Complete pokrytí všech důležitých oblastí.

### ? Co NEPATŘÍ mezi kritéria kvality architektonických principů v TOGAF?

- [ ] Consistent
- [x] Measurable
- [ ] Understandable
- [ ] Stable

> Kritérii dobré sady principů jsou Understandable, Robust, Complete, Consistent a Stable. Měřitelnost (Measurable) se požaduje spíše u cílů, ne u principů.

### ? Organizace má principy „Data jsou dostupná všem oprávněným uživatelům" a „Citlivá data musí být chráněna". V konkrétním projektu se dostaly do sporu. Jak má architekt postupovat?

- [ ] Princip přijatý dříve vždy automaticky přebije ten pozdější
- [ ] Jeden z principů zrušit, protože sada principů musí být bezrozporná
- [ ] Spor ignorovat, principy jsou jen doporučení bez vlivu na rozhodnutí
- [x] Oba principy vyvážit pro danou situaci a rozhodnutí zdůvodnit

> Principy mohou v konkrétní situaci soupeřit; kritérium Consistent požaduje, aby sada umožnila jejich vyvážení. Rušit platný princip kvůli jednomu sporu nebo rozhodovat podle data přijetí není správné.

## Hierarchie principů {#hierarchie-principu .explain}

Principy existují na více úrovních: **podnikové principy (Enterprise Principles)** dávají základ rozhodování v celé organizaci, z nich vycházejí **IT principy** pro využívání informací a technologií a z obou se odvozují **architektonické principy (Architecture Principles)**, které řídí samotnou tvorbu a vývoj architektury. Nižší úroveň má být s vyšší v souladu. Architektonické principy se ustavují v Preliminary Phase a ve Phase A se mohou upřesnit; slouží jako měřítko pro posuzování alternativ, výběr řešení i soulad projektů s architekturou.

*Příklad:* Podnikový princip „Zákazník na prvním místě" vede k IT principu „Snadné použití" a ten k architektonickému principu, že nové aplikace mají jednotné uživatelské rozhraní.

### ? Z čeho se v hierarchii principů podle TOGAF odvozují architektonické principy?

- [x] Z podnikových principů a IT principů
- [ ] Z požadavků jednotlivých projektových týmů
- [ ] Z doporučení dodavatelů technologií
- [ ] Z výsledků analýzy mezer (Gap Analysis)

> Architektonické principy vycházejí z podnikových (Enterprise) a IT principů a mají být s nimi v souladu. Požadavky projektů ani doporučení dodavatelů nejsou jejich zdrojem.

## Stakeholder Management {#stakeholder-management .explain}

Řízení stakeholderů je technika, která pomáhá včas zjistit, kdo má na architekturu vliv nebo zájem, a získat jeho podporu. TOGAF ji popisuje ve čtyřech krocích: **Identify Stakeholders** (zjistit, koho architektura ovlivní nebo kdo ji může ovlivnit), **Classify Stakeholder Positions** (posoudit jejich vliv, porozumění a podporu), **Determine Stakeholder Management Approach** (určit, jak s kterou skupinou pracovat) a **Tailor Engagement Deliverables** (zjistit zájmy jednotlivých skupin a zvolit pro ně hlediska (viewpoints) a artefakty). Technika se uplatní hlavně ve Phase A, ale stakeholdery je třeba sledovat po celý cyklus ADM.

*Příklad:* Architekt zjistí, že vedoucí logistiky může projekt zablokovat, ale o architekturu se nezajímá — zařadí ho mezi ty, které je třeba „udržet spokojené", a připraví pro něj stručný přehled dopadů na sklad.

### ? Který krok Stakeholder Management následuje po identifikaci stakeholderů (Identify Stakeholders)?

- [x] Classify Stakeholder Positions
- [ ] Tailor Engagement Deliverables
- [ ] Determine Stakeholder Management Approach
- [ ] Define Stakeholder Requirements

> Pořadí kroků je Identify Stakeholders → Classify Stakeholder Positions → Determine Stakeholder Management Approach → Tailor Engagement Deliverables. Krok „Define Stakeholder Requirements" v technice není.

### ? Ve kterém kroku Stakeholder Management architekt určuje, jaká hlediska (viewpoints) a artefakty připraví pro jednotlivé skupiny stakeholderů?

- [ ] Identify Stakeholders
- [ ] Classify Stakeholder Positions
- [x] Tailor Engagement Deliverables
- [ ] Determine Stakeholder Management Approach

> V kroku Tailor Engagement Deliverables se k zájmům stakeholderů přiřazují hlediska, katalogy, matice a diagramy. Předchozí kroky stakeholdery vyhledají, ohodnotí a určí způsob práce s nimi.

## Power/Interest Grid {#power-interest-grid .compare}

Pro určení přístupu ke stakeholderům se používá mřížka **moci (power)** a **zájmu (interest)**. Podle umístění se stakeholder zařadí do jedné ze čtyř skupin:

| | Nízký zájem | Vysoký zájem |
|---|---|---|
| **Vysoká moc** | **Keep Satisfied** — udržovat spokojené, nezahlcovat detaily | **Key Players** — plně zapojit, intenzivně spolupracovat |
| **Nízká moc** | **Minimal Effort** — sledovat s minimálním úsilím | **Keep Informed** — pravidelně informovat |

### ? Finanční ředitel má velkou moc nad schválením rozpočtu, ale o samotnou architekturu se příliš nezajímá. Jaký přístup mu přiřadí power/interest grid?

- [ ] Key Players
- [x] Keep Satisfied
- [ ] Keep Informed
- [ ] Minimal Effort

> Vysoká moc a nízký zájem odpovídá kvadrantu Keep Satisfied — stakeholdera je třeba udržet spokojeného bez zahlcování detaily. Key Players mají moc i vysoký zájem.

### ? Do kterého kvadrantu power/interest grid patří stakeholder s vysokou mocí i vysokým zájmem o architekturu?

- [ ] Keep Satisfied
- [ ] Keep Informed
- [ ] Minimal Effort
- [x] Key Players

> Stakeholdery s vysokou mocí i zájmem je třeba plně zapojit — jsou to Key Players. Keep Satisfied má vysokou moc, ale nízký zájem.

### ? Koncoví uživatelé nového systému se o změnu velmi zajímají, ale o projektu nerozhodují. Jaký přístup je podle power/interest grid vhodný?

- [x] Keep Informed — pravidelně je informovat
- [ ] Key Players — plně je zapojit do rozhodování
- [ ] Keep Satisfied — udržet je spokojené bez detailů
- [ ] Minimal Effort — jen je občas sledovat

> Nízká moc a vysoký zájem odpovídá kvadrantu Keep Informed. Plné zapojení patří Key Players a přístup Keep Satisfied stakeholderům s velkou mocí.

## Klasifikace pozic stakeholderů {#pozice-stakeholderu .explain}

V kroku Classify Stakeholder Positions architekt pro každého stakeholdera posoudí zejména jeho **schopnost změnu narušit (Ability to Disrupt Change)**, **současné a požadované porozumění** architektuře a **současné a požadované nasazení (commitment)** pro změnu. Rozdíl mezi současným a požadovaným stavem ukazuje, kam napřít komunikaci. Smyslem je včas odhalit, kdo může úsilí podpořit a kdo ho naopak může ohrozit.

*Příklad:* Ředitel provozu má velkou schopnost změnu narušit, změně rozumí málo a podporuje ji vlažně — architekt proto naplánuje osobní schůzku a vysvětlení přínosů pro provoz.

### ? Co architekt v kroku Classify Stakeholder Positions u stakeholdera posuzuje?

- [ ] Jeho pracovní výkon a odborné kompetence
- [x] Vliv na změnu, porozumění a nasazení
- [ ] Jeho finanční podíl na rozpočtu architektury
- [ ] Počet artefaktů, které má schválit

> Klasifikace pozic hodnotí vliv stakeholdera (schopnost změnu narušit) a rozdíl mezi současným a požadovaným porozuměním a nasazením. Výkon zaměstnanců ani počet schvalovaných artefaktů se v ní nehodnotí.

## Stakeholder Map {#stakeholder-map .term}

**Stakeholder Map** je matice (artefakt vznikající hlavně ve Phase A), která pro každého stakeholdera shrnuje jeho **zapojení a klíčové zájmy (concerns)**, **zařazení** podle power/interest grid a **relevantní hlediska a artefakty**, které se mu budou předkládat. Slouží jako podklad pro komunikační plán a pro výběr pohledů na architekturu.

### ? Které informace obsahuje Stakeholder Map v TOGAF?

- [ ] Organizační strukturu podniku s počty zaměstnanců
- [ ] Harmonogram schůzek Architecture Board
- [x] Zájmy stakeholderů, jejich zařazení a relevantní artefakty
- [ ] Seznam rizik projektu a opatření k jejich zmírnění a sledování

> Stakeholder Map shrnuje pro každého stakeholdera jeho zapojení a zájmy, třídu podle power/interest grid a artefakty či hlediska, které ho zajímají. Rizika ani harmonogramy nejsou jejím obsahem.

### ? Ve které fázi ADM se Stakeholder Map typicky sestavuje?

- [ ] Phase E: Opportunities and Solutions
- [x] Phase A: Architecture Vision
- [ ] Phase G: Implementation Governance
- [ ] Phase H: Architecture Change Management

> Stakeholdeři se identifikují a mapují ve Phase A, kdy se vymezuje vize a rozsah práce. V dalších fázích se mapa jen aktualizuje.

## Business Scenarios {#business-scenarios .explain}

**Business Scenario** je technika pro zjištění a popis **obchodních požadavků** na architekturu. Popisuje obchodní problém a prostředí, žádoucí výsledky, **lidské aktéry** (účastníky) a **počítačové aktéry** (systémy), jejich role a odpovědnosti a měřítka úspěchu. Postup se opakuje v krocích *Gather* (sběr), *Analyze* (analýza) a *Review* (ověření se stakeholdery). Technika se využívá hlavně ve **Phase A** (a podle potřeby ve Phase B), aby architektura řešila skutečný byznysový problém. V 10. vydání je popsána v samostatném Series Guide.

*Příklad:* Pojišťovna popíše scénář „klient nahlásí pojistnou událost mobilem": problém (dlouhé vyřízení), aktéry (klient, likvidátor, mobilní aplikace, systém škod) a cíl (výplata do 5 dnů).

### ? K čemu slouží technika Business Scenarios?

- [ ] K výběru dodavatele technologií pro cílovou architekturu
- [ ] K měření vyspělosti architektonické kapability organizace
- [ ] K sestavení harmonogramu migračních projektů
- [x] K odhalení a popisu obchodních požadavků na architekturu

> Business Scenario popisuje obchodní problém, aktéry a žádoucí výsledky, a tím odhaluje požadavky na architekturu. Výběr dodavatele, měření vyspělosti ani plánování migrace jejím účelem nejsou.

### ? Které prvky popisuje Business Scenario?

- [x] Problém, prostředí, cíle, lidské a počítačové aktéry a jejich role
- [ ] Rozpočet, harmonogram, dodavatele a smluvní podmínky celého projektu
- [ ] Výchozí a cílové stavební bloky a mezery mezi nimi
- [ ] Rizika, jejich pravděpodobnost a opatření k jejich zmírnění

> Business Scenario zachycuje problém, obchodní a technické prostředí, cíle, lidské i počítačové aktéry, jejich role a měřítka úspěchu. Mezery mezi stavy řeší Gap Analysis a rizika Risk Management.

## SMART cíle {#smart-cile .term}

Cíle v Business Scenario se mají formulovat jako **SMART**: **Specific** (konkrétní), **Measurable** (měřitelné), **Actionable** (lze podle nich jednat), **Realistic** (dosažitelné) a **Time-bound** (časově ohraničené). Jen tak lze poznat, zda architektura problém skutečně vyřešila.

### ? Který z uvedených cílů nejlépe splňuje kritéria SMART?

- [ ] Zlepšit spokojenost zákazníků s našimi službami
- [ ] Modernizovat informační systémy podle trendů trhu
- [x] Do konce roku 2027 zkrátit vyřízení reklamace na 3 dny
- [ ] Stát se během pár let nejinovativnější firmou v celém odvětví

> Cíl se zkrácením reklamace je konkrétní, měřitelný, realistický a časově ohraničený. Ostatní možnosti jsou vágní, bez měřítka i termínu.

### ? Co v akronymu SMART používaném u Business Scenarios znamená písmeno „A"?

- [ ] Approved
- [ ] Aligned
- [ ] Architectural
- [x] Actionable

> TOGAF rozvádí SMART jako Specific, Measurable, Actionable, Realistic a Time-bound. Actionable znamená, že cíl dává jasný podnět k jednání.

## Gap Analysis — matice {#gap-analysis-matice .explain}

Analýza mezer (Gap Analysis) porovnává výchozí (Baseline) a cílovou (Target) architekturu. Používá se **matice**: v řádcích jsou stavební bloky (ABB) výchozí architektury, ve sloupcích stavební bloky cílové architektury; přidá se **poslední řádek „New"** a **poslední sloupec „Eliminated"**. Blok, který je v obou stavech, se na průsečíku označí jako **Included**. Blok výchozího stavu, který v cíli chybí, se dostane do sloupce Eliminated; blok cílového stavu, který ve výchozím stavu není, se dostane do řádku New — a to je **mezera**, kterou je třeba vyvinout nebo pořídit. Technika se používá ve Phases B, C a D a výsledky konsoliduje Phase E.

*Příklad:* Výchozí stav má „Ruční fakturaci", cílový stav „Elektronickou fakturaci" a oba mají „Evidenci zákazníků" — evidence je Included, ruční fakturace Eliminated a elektronická fakturace je nová mezera.

### ? Co je v matici Gap Analysis umístěno v řádcích a co ve sloupcích?

- [ ] Řádky: projekty; sloupce: přechodové architektury
- [ ] Řádky: stakeholdeři; sloupce: jejich zájmy (concerns)
- [ ] Řádky: rizika; sloupce: dopad a pravděpodobnost
- [x] Řádky: bloky Baseline; sloupce: bloky Target

> Matice analýzy mezer má v řádcích stavební bloky výchozí architektury a ve sloupcích bloky cílové architektury, doplněné o řádek New a sloupec Eliminated.

### ? Stavební blok existuje ve výchozí i cílové architektuře. Jak se zapíše do matice Gap Analysis?

- [x] Na průsečík jako Included
- [ ] Do posledního řádku New
- [ ] Do posledního sloupce Eliminated
- [ ] Nezapisuje se, matice zachycuje jen změny

> Blok přítomný v obou stavech se na průsečíku řádku a sloupce označí jako Included. Do řádku New patří nové bloky a do sloupce Eliminated vypuštěné.

### ? Které fáze ADM analýzu mezer (Gap Analysis) běžně využívají?

- [ ] Jen Preliminary Phase a Phase A
- [ ] Jen Phase G a Phase H
- [x] Phases B–D, konsolidace v E
- [ ] Jen Requirements Management

> Analýza mezer je součástí vývoje architektur ve Phases B, C a D a jejich mezery konsoliduje Phase E. Preliminary, A, G ani H ji nemají jako hlavní techniku.

## Výsledky Gap Analysis {#gap-vysledky .compare}

Každý rozdíl v matici je třeba vyhodnotit; zvlášť pozor na bloky, které v cíli chybějí **nechtěně**:

| Situace v matici | Význam | Co udělat |
|---|---|---|
| blok v Baseline i Target (Included) | zůstává, případně s úpravou | ověřit, zda nepotřebuje změnu |
| blok jen v Baseline, záměrně vypuštěný | **Eliminated** — v cíli se už nepočítá | naplánovat ukončení a případnou migraci dat |
| blok jen v Baseline, omylem vynechaný | chyba v návrhu cílové architektury | **doplnit ho do Target** |
| blok jen v Target (řádek New) | **mezera (gap)** | vyvinout, pořídit nebo zajistit jinak |

### ? Při analýze mezer architekt zjistí, že funkce „Správa reklamací" z výchozí architektury v cílové architektuře chybí, ačkoli ji firma dál potřebuje. Co má udělat?

- [ ] Zapsat ji do sloupce Eliminated a naplánovat její postupné ukončení
- [x] Doplnit ji do cílové architektury, protože byla vynechána omylem
- [ ] Zapsat ji do řádku New jako mezeru k vývoji
- [ ] Nechat ji beze změny, matice zachycuje jen nové bloky

> Blok z výchozí architektury, který v cíli chybí nechtěně, je chyba návrhu a musí se do cílové architektury vrátit. Sloupec Eliminated je jen pro záměrně vypuštěné bloky.

### ? Co v analýze mezer představuje stavební blok, který je v cílové architektuře, ale ve výchozí chybí?

- [ ] Záměrně vypuštěný blok (Eliminated)
- [ ] Blok se shodou v obou stavech (Included)
- [ ] Riziko, které je třeba zmírnit
- [x] Mezeru k vyvinutí nebo pořízení

> Nový blok cílového stavu je mezera — něco, co organizace zatím nemá a musí to vytvořit nebo získat. Eliminated a Included popisují bloky výchozího stavu.

## Zdroje mezer podle domén {#zdroje-mezer .explain}

Mezery nejsou jen chybějící systémy. V **Business Architecture** mohou jít o lidi (např. potřeba přeškolení), procesy, nástroje, informace, měření výkonu, financování nebo prostory. V **Data Architecture** jde např. o data, která nejsou dost aktuální, nejsou k dispozici tam nebo tehdy, kdy jsou potřeba, nebo je nikdo nevytváří či nespotřebovává. V **Application** a **Technology Architecture** jde o komponenty, které je třeba nově vytvořit, upravit nebo vyřadit. Dobrá analýza mezer proto zkoumá všechny tyto zdroje, ne jen technologie.

*Příklad:* Nový CRM systém je pořízen, ale obchodníci s ním neumějí pracovat — přehlédnutá mezera byla v oblasti lidí (školení), ne v technologii.

### ? Firma zavádí nový systém pro plánování výroby, ale mistři s ním neumějí pracovat. Jaký druh mezery analýza mezer přehlédla?

- [ ] Mezeru v technologické infrastruktuře
- [x] Mezeru v oblasti lidí (people gap)
- [ ] Mezeru v aplikačním portfoliu
- [ ] Mezeru v aktuálnosti dat

> Nedostatek dovedností uživatelů je mezera v oblasti lidí, kterou řeší např. školení. Systém samotný i infrastruktura jsou v tomto případě k dispozici.

### ? Která situace představuje mezeru v datové architektuře (Data Architecture)?

- [x] Data nejsou tam, kde je proces potřebuje
- [ ] Zaměstnanci potřebují přeškolení
- [ ] Server nemá dostatečnou výpočetní kapacitu
- [ ] Chybí rozpočet na pořízení nových licencí

> Nedostupnost dat tam, kde jsou potřeba, je typická datová mezera. Školení je mezera v oblasti lidí, kapacita serveru technologická a rozpočet finanční mezera.

## Interoperability Requirements {#interoperabilita .compare}

**Interoperabilita** je schopnost systémů, organizačních jednotek nebo organizací **sdílet informace a služby**. Požadavky na ni se zpravidla určují už ve Phase A, upřesňují ve Phases B–D a řeší ve Phase E. TOGAF rozlišuje tři kategorie:

| Kategorie | Co se sdílí | Příklad |
|---|---|---|
| **Operational (Business) Interoperability** | obchodní procesy | společný proces objednávky mezi firmou a dodavatelem |
| **Information Interoperability** | informace | jednotný formát a význam dat o zákazníkovi |
| **Technical Interoperability** | technické služby a spojení | společné komunikační protokoly a rozhraní |

### ? Firma a její dodavatel chtějí sladit sdílený proces vyřizování objednávek napříč oběma organizacemi. O jakou kategorii interoperability jde?

- [ ] Technical Interoperability
- [ ] Information Interoperability
- [x] Operational (Business) Interoperability
- [ ] Infrastructure Interoperability

> Sdílení obchodních procesů je Operational (Business) Interoperability. Information Interoperability se týká sdílení informací a Technical Interoperability technických služeb.

### ? Co se podle TOGAF rozumí interoperabilitou?

- [ ] Schopnost systému běžet na různých operačních systémech a platformách
- [x] Schopnost systémů a organizací sdílet informace a služby
- [ ] Soulad projektů s architektonickými principy organizace
- [ ] Schopnost architektury přizpůsobit se změnám v byznysu

> Interoperabilita je schopnost sdílet informace a služby mezi systémy, jednotkami či organizacemi. Soulad s principy je Architecture Compliance a přizpůsobivost řeší Phase H.

## Stupně interoperability {#stupne-interoperability .explain}

Pro sdílení informací TOGAF uvádí jako příklad klasifikaci do **čtyř stupňů**: **Degree 1 — Unstructured Data Exchange** (výměna nestrukturovaných dat určených člověku, např. volný text), **Degree 2 — Structured Data Exchange** (strukturovaná data, jejichž zpracování ale vyžaduje ruční zásah), **Degree 3 — Seamless Sharing of Data** (automatické sdílení dat mezi systémy na základě společného modelu výměny) a **Degree 4 — Seamless Sharing of Information** (navíc jednotný výklad informací spolupracujícími aplikacemi). Vyšší stupeň znamená více automatizace a společného významu.

*Příklad:* Posílání objednávek e-mailem ve volném textu je stupeň 1; automatický přenos objednávek mezi systémy podle společného datového modelu je stupeň 3.

### ? Dvě aplikace si automaticky vyměňují data o objednávkách podle společného modelu výměny dat. Kterému stupni interoperability to odpovídá?

- [ ] Degree 1 — Unstructured Data Exchange
- [ ] Degree 2 — Structured Data Exchange
- [ ] Degree 4 — Seamless Sharing of Information
- [x] Degree 3 — Seamless Sharing of Data

> Automatické sdílení dat podle společného modelu výměny je Degree 3. Degree 4 jde dál ke společnému výkladu informací a Degree 1 a 2 vyžadují lidské zpracování.

### ? Oddělení si posílají měsíční zprávy jako volný text v dokumentech, které čte a přepisuje člověk. Jaký stupeň interoperability to je?

- [x] Degree 1 — Unstructured Data Exchange
- [ ] Degree 2 — Structured Data Exchange
- [ ] Degree 3 — Seamless Sharing of Data
- [ ] Degree 4 — Seamless Sharing of Information

> Výměna nestrukturovaného textu určeného člověku je nejnižší stupeň — Unstructured Data Exchange. Vyšší stupně vyžadují strukturu a automatické zpracování.

## Business Transformation Readiness Assessment {#btra .explain}

**Business Transformation Readiness Assessment** hodnotí, **jak je organizace připravená** na změnu, kterou architektura přináší. Posuzují se **faktory připravenosti (readiness factors)**, např. Vision, Need, Business Case, Funding, Sponsorship and Leadership, Governance, Accountability nebo IT Capacity to Execute. Technika vychází z kanadského vládního programu BTEP (Business Transformation Enablement Program). Hodnocení se provádí ve **Phase A** (obvykle formou workshopů se stakeholdery) a jeho výsledky se promítají do plánování ve Phases E a F.

*Příklad:* Hodnocení ukáže, že vedení má jasnou vizi, ale chybí schválené financování a IT nemá kapacitu — architekt to zapíše jako rizika připravenosti a navrhne opatření.

### ? K čemu slouží Business Transformation Readiness Assessment?

- [ ] K ocenění finanční návratnosti jednotlivých projektů
- [x] K posouzení, nakolik je organizace připravená na změnu
- [ ] K porovnání výchozí a cílové architektury
- [ ] K výběru vhodného rámce podnikové architektury

> Technika hodnotí připravenost organizace na transformaci pomocí faktorů jako vize, potřeba, financování nebo vedení. Porovnání stavů je Gap Analysis.

### ? Ve které fázi ADM se Business Transformation Readiness Assessment provádí poprvé?

- [ ] Preliminary Phase
- [ ] Phase D: Technology Architecture
- [x] Phase A: Architecture Vision
- [ ] Phase G: Implementation Governance

> Hodnocení připravenosti se provádí ve Phase A, aby se rizika změny poznala včas; jeho výsledky pak využívají Phases E a F při plánování.

### ? Co NENÍ faktorem připravenosti (readiness factor) v Business Transformation Readiness Assessment?

- [ ] Sponsorship and Leadership
- [ ] Funding
- [ ] IT Capacity to Execute
- [x] Technology Independence

> Funding, Sponsorship and Leadership i IT Capacity to Execute jsou faktory připravenosti. Technology Independence je název typického architektonického principu, ne faktoru připravenosti.

## Postup hodnocení připravenosti {#btra-postup .explain}

Hodnocení připravenosti probíhá v krocích: **určit faktory připravenosti** relevantní pro organizaci, **znázornit je** (často pomocí modelů vyspělosti — maturity models), **ohodnotit je**, **určit rizika připravenosti a opatření** a zapracovat je do **Implementation and Migration Plan**. Každý faktor se hodnotí z několika hledisek — **naléhavost (Urgency)**, **stav připravenosti (Readiness Status)** a **obtížnost nápravy (Degree of Difficulty to Fix)**. Tak je vidět, které slabiny řešit přednostně.

*Příklad:* Faktor „Governance" má nízkou připravenost, je naléhavý a jeho náprava je snadná — dostane přednost před faktorem, jehož náprava zabere roky.

### ? Podle jakých hledisek se hodnotí jednotlivý faktor připravenosti v Business Transformation Readiness Assessment?

- [x] Naléhavost, stav připravenosti a obtížnost nápravy
- [ ] Moc, zájem a postoj příslušného stakeholdera
- [ ] Hodnota, riziko a náklady příslušného projektu či pracovního balíku
- [ ] Pravděpodobnost, dopad a reziduální riziko

> Faktor připravenosti se hodnotí podle Urgency, Readiness Status a Degree of Difficulty to Fix. Moc a zájem patří k řízení stakeholderů, hodnota a riziko k Business Value Assessment.

### ? Kam se zapracují rizika a opatření zjištěná při Business Transformation Readiness Assessment?

- [ ] Do Architecture Contract s dodavatelem
- [ ] Do Stakeholder Map ve Phase A
- [x] Do Implementation and Migration Plan
- [ ] Do Governance Log Architecture Board

> Rizika připravenosti a opatření k nim se promítají do plánování přechodu, tedy do Implementation and Migration Plan ve Phases E a F.

## Risk Management {#risk-management .explain}

Řízení rizik v TOGAF zachycuje rizika architektonické transformace a postupuje v pěti krocích: **Risk Classification** (zařazení rizik do kategorií, např. časová, nákladová, rozsahová), **Risk Identification** (zjištění rizik, mimo jiné z hodnocení připravenosti), **Initial Risk Assessment** (ohodnocení rizik před opatřeními), **Risk Mitigation and Residual Risk Assessment** (návrh opatření a ohodnocení zbylého rizika) a **Risk Monitoring** (sledování rizik a účinnosti opatření, zejména během Phase G). Rizika se identifikují už ve Phase A a provázejí celý cyklus.

*Příklad:* Riziko „klíčový dodavatel nedodá včas" se zařadí jako časové, ohodnotí, zmírní smluvní pokutou a záložním dodavatelem a během implementace se sleduje.

### ? Který krok Risk Management v TOGAF následuje po Initial Risk Assessment?

- [ ] Risk Classification
- [ ] Risk Identification
- [ ] Risk Monitoring
- [x] Risk Mitigation and Residual Risk Assessment

> Po ohodnocení rizik před opatřeními se navrhují zmírňující opatření a hodnotí reziduální riziko; teprve potom se rizika sledují (Risk Monitoring).

### ? Ve které fázi ADM se nejvíce uplatní krok Risk Monitoring?

- [ ] Preliminary Phase
- [x] Phase G: Implementation Governance
- [ ] Phase B: Business Architecture
- [ ] Phase C: Information Systems Architectures

> Sledování rizik a účinnosti opatření probíhá hlavně během implementace, kterou řídí Phase G. Identifikace a hodnocení rizik začínají dřív, už ve Phase A.

## Initial × Residual Risk {#initial-residual .compare}

TOGAF rozlišuje dvě úrovně rizika podle toho, zda už byla přijata opatření:

| | Iniciální riziko (initial risk) | Reziduální riziko (residual risk) |
|---|---|---|
| Kdy se hodnotí | před zmírňujícími opatřeními | po zavedení zmírňujících opatření |
| Co vyjadřuje | „surovou" úroveň rizika | riziko, které zbývá a organizace ho nese |
| K čemu slouží | rozhodnout, které riziko vyžaduje opatření | ověřit, že zbylé riziko je přijatelné |

### ? Co v Risk Management TOGAF označuje reziduální riziko (residual risk)?

- [x] Riziko, které zbývá po zavedení zmírňujících opatření
- [ ] Riziko ohodnocené před přijetím jakýchkoli opatření
- [ ] Riziko přenesené na dodavatele v Architecture Contract
- [ ] Riziko, které se v projektu dosud neprojevilo

> Reziduální riziko je úroveň rizika po opatřeních, kterou organizace nese. Riziko před opatřeními je iniciální (initial) riziko.

### ? Projekt má riziko výpadku dat ohodnocené jako vysoké. Po zavedení zálohování a záložního datového centra je hodnoceno jako nízké. Jak se označuje toto nižší hodnocení?

- [ ] Iniciální riziko (initial risk)
- [ ] Přijaté riziko projektu
- [x] Reziduální riziko (residual risk)
- [ ] Riziko připravenosti

> Hodnocení po zavedení zmírňujících opatření je reziduální riziko. Původní vysoké hodnocení před opatřeními je iniciální riziko.

## Hodnocení rizika {#hodnoceni-rizika .explain}

Pro ohodnocení rizika TOGAF navrhuje kombinovat dvě veličiny: **účinek (effect)** — jak vážné by byly následky (např. Catastrophic, Critical, Marginal, Negligible) — a **četnost (frequency)** — jak pravděpodobně riziko nastane (např. Frequent, Likely, Occasional, Seldom, Unlikely). Jejich kombinace dává **dopad (impact)** rizika, např. extrémně vysoký, vysoký, střední nebo nízký. Stupnice si organizace může přizpůsobit; podstatné je hodnotit rizika jednotně, aby šla porovnat.

*Příklad:* Riziko s kritickým účinkem, které nastane jen zřídka, může vyjít jako střední, zatímco riziko s katastrofálním účinkem a častým výskytem jako extrémně vysoké.

### ? Z jakých dvou veličin se v Risk Management TOGAF odvozuje dopad (impact) rizika?

- [ ] Z nákladů a přínosů opatření
- [ ] Z moci a zájmu stakeholdera
- [x] Z účinku (effect) a četnosti (frequency)
- [ ] Z naléhavosti a obtížnosti nápravy

> Dopad rizika vzniká kombinací účinku (jak vážné jsou následky) a četnosti (jak pravděpodobně nastane). Moc a zájem patří ke stakeholderům, naléhavost a obtížnost nápravy k hodnocení připravenosti.

## Capability-Based Planning {#capability-based-planning .explain}

**Capability-Based Planning** je přístup k plánování, který se soustředí na **plánování, návrh a dodání strategických obchodních schopností (business capabilities)**, ne na jednotlivé projekty. Schopnosti jsou typicky **napříč organizačními útvary**, zatímco organizace i rozpočty bývají členěné svisle — proto je potřeba jasný vlastník schopnosti a koordinace více projektů. Schopnost se dodává **postupně po přírůstcích (capability increments)**, které se sladí s přechodovými architekturami (Transition Architectures), a přínosy se měří na úrovni celé schopnosti. Přístup pochází z obranného a vládního sektoru a je řízen byznysem.

*Příklad:* Schopnost „Omnikanálová obsluha zákazníka" zasahuje obchod, marketing i IT; dodává se ve třech přírůstcích (jednotná evidence zákazníka, mobilní kanál, personalizované nabídky) napříč několika projekty.

### ? Na co se zaměřuje Capability-Based Planning?

- [ ] Na plánování kapacit serverů a sítí v datovém centru
- [ ] Na řízení jednoho projektu podle jeho harmonogramu a rozpočtu
- [ ] Na hodnocení dovedností jednotlivých architektů
- [x] Na plánování a dodání strategických obchodních schopností

> Capability-Based Planning plánuje dodání obchodních schopností, které obvykle přesahují útvary i jednotlivé projekty. Nejde o kapacitní plánování IT ani o řízení jednoho projektu.

### ? Jak se v Capability-Based Planning typicky dodává rozsáhlá obchodní schopnost?

- [ ] Najednou, jediným projektem na konci cyklu ADM
- [x] Postupně po přírůstcích sladěných s Transition Architectures
- [ ] Výhradně nákupem hotového řešení od dodavatele
- [ ] Samostatně v každém útvaru, bez společného vlastníka schopnosti

> Schopnost se dodává po přírůstcích (capability increments), které odpovídají přechodovým architekturám a obvykle zahrnují více projektů. Útvarové dodání bez vlastníka by popřelo průřezovou povahu schopnosti.

### ? Proč Capability-Based Planning vyžaduje koordinaci napříč útvary organizace?

- [ ] Protože schopnosti smí vlastnit jen IT oddělení
- [ ] Protože každou schopnost dodává právě jeden útvar
- [x] Protože schopnosti přesahují hranice útvarů
- [ ] Protože TOGAF zakazuje rozpočty útvarů

> Obchodní schopnosti jsou typicky průřezové, zatímco organizace a rozpočty jsou členěné svisle podle útvarů. Proto je potřeba vlastník schopnosti a koordinace projektů.

## Migration Planning Techniques {#migration-planning .compare}

Pro Phases E a F TOGAF nabízí sadu technik plánování migrace:

| Technika | K čemu slouží |
|---|---|
| **Implementation Factor Catalog** (v 9.1 Implementation Factor Assessment and Deduction matrix) | zachycuje faktory ovlivňující implementaci (rizika, předpoklady, závislosti…) — sloupce Factor, Description, Deduction |
| **Consolidated Gaps, Solutions, and Dependencies Matrix** | sdružuje mezery ze všech domén, navrhuje k nim řešení a zachycuje závislosti |
| **Architecture Definition Increments Table** | rozkládá architekturu do přírůstků — co který projekt dodá v jednotlivých přechodových architekturách |
| **Transition Architecture State Evolution Table** | ukazuje, v jakém stavu budou jednotlivé architektonické prvky v každé přechodové architektuře |
| **Business Value Assessment Technique** | porovnává projekty podle obchodní hodnoty a rizika |

### ? Která technika plánování migrace sdružuje mezery ze všech architektonických domén, přiřazuje k nim možná řešení a zachycuje závislosti?

- [x] Consolidated Gaps, Solutions, and Dependencies Matrix
- [ ] Transition Architecture State Evolution Table
- [ ] Architecture Definition Increments Table
- [ ] Implementation Factor Catalog

> Konsolidovaná matice mezer, řešení a závislostí slučuje mezery z Phases B–D a navrhuje jejich řešení. Ostatní techniky plánují přírůstky, stavy prvků nebo faktory implementace.

### ? Jaké sloupce má Implementation Factor Catalog?

- [ ] Gap, Solution, Dependency
- [ ] Value, Risk, Priority
- [x] Factor, Description, Deduction
- [ ] Project, Increment, Transition

> Matice zachycuje faktor ovlivňující implementaci (Factor), jeho popis (Description) a z něj plynoucí závěr či opatření (Deduction).

### ? Ve kterých fázích ADM se techniky plánování migrace (Migration Planning Techniques) používají především?

- [ ] Phase A a Phase B
- [ ] Phase C a Phase D
- [ ] Phase G a Phase H
- [x] Phase E a Phase F

> Techniky plánování migrace podporují konsolidaci mezer, návrh přechodových architektur a tvorbu Implementation and Migration Plan, což je náplň Phases E a F.

## Business Value Assessment Technique {#business-value-assessment .term}

**Business Value Assessment Technique** zakresluje projekty (nebo pracovní balíky) do **matice hodnoty a rizika**: jedna osa vyjadřuje **index hodnoty** (např. přínos ke strategii, finanční přínos, soulad s principy, konkurenční pozice), druhá **index rizika** (např. velikost a složitost, technologie, kapacita organizace, dopad selhání). Projekty s vysokou hodnotou a nízkým rizikem jsou kandidáty na brzké zařazení do plánu.

### ? Podle kterých dvou hledisek porovnává projekty Business Value Assessment Technique?

- [ ] Podle nákladů a délky trvání
- [x] Podle obchodní hodnoty a rizika
- [ ] Podle moci a zájmu stakeholderů
- [ ] Podle naléhavosti a připravenosti

> Technika zakresluje projekty do matice indexu hodnoty a indexu rizika. Moc a zájem jsou osami power/interest grid a naléhavost s připraveností patří k hodnocení připravenosti.

### ? Projekt má podle Business Value Assessment vysokou obchodní hodnotu a nízké riziko. Jak se s ním při plánování migrace obvykle naloží?

- [ ] Odloží se až za všechny rizikovější projekty
- [ ] Zruší se, protože nepřináší dost inovací
- [ ] Převede se do Phase H jako změnový požadavek
- [x] Je kandidátem na brzké zařazení do plánu

> Kombinace vysoké hodnoty a nízkého rizika je nejvýhodnější, proto takové projekty bývají zařazeny brzy. Odklad nebo zrušení by šly proti smyslu hodnocení.

## Architecture Alternatives and Trade-Offs {#alternativy-trade-offs .explain}

Vývoj architektury často vede k **více možným cílovým architekturám**. Technika **Architecture Alternatives and Trade-Offs** pomáhá alternativy **popsat, porovnat podle kritérií** (např. náklady, přínos, riziko, soulad s principy, dopad na stakeholdery) a **zachytit kompromisy (trade-offs)** mezi nimi. Výběr alternativy se dělá **společně se stakeholdery** a zdůvodnění se dokumentuje, aby bylo rozhodnutí dohledatelné. Uplatní se hlavně při vývoji architektur ve Phases B, C a D a při výběru řešení ve Phase E.

*Příklad:* Architekt předloží tři varianty — vlastní vývoj, nákup balíku, cloudová služba — s porovnáním nákladů, rizika a pružnosti; stakeholdeři zvolí cloudovou službu a důvod se zapíše.

### ? Architekt připravil dvě realistické varianty cílové architektury s rozdílnými náklady a riziky. Jaký je podle techniky Architecture Alternatives and Trade-Offs správný postup?

- [x] Porovnat varianty podle kritérií a výběr provést se stakeholdery
- [ ] Vybrat sám levnější variantu, stakeholdery informovat až po schválení
- [ ] Rozpracovat obě varianty až do implementace a pak rozhodnout
- [ ] Předat rozhodnutí dodavateli, který nabídne nižší cenu

> Technika vyžaduje porovnat alternativy podle dohodnutých kritérií, ukázat kompromisy a rozhodnout spolu se stakeholdery. Jednostranný výběr nebo odklad rozhodnutí do implementace jsou horší.

## Architecture Patterns {#architecture-patterns .term}

**Architektonický vzor (architecture pattern)** je osvědčené řešení opakujícího se problému v určitém kontextu, které lze znovu použít. Zatímco **stavební blok** je balík funkčnosti, vzor ukazuje, **jak stavební bloky zasadit do kontextu a zkombinovat** pro daný problém. Popis vzoru typicky obsahuje např. Name, Problem, Context, Forces, Solution a Resulting Context.

### ? Jaký je vztah mezi architektonickým vzorem (pattern) a stavebním blokem (building block)?

- [ ] Vzor je jiný název pro SBB konkrétního dodavatele
- [ ] Vzor je seznam všech bloků v repozitáři
- [ ] Blok popisuje, jak vzory zkombinovat pro problém
- [x] Vzor ukazuje, jak bloky zkombinovat v kontextu

> Stavební blok je balík funkčnosti, kdežto vzor popisuje osvědčený způsob, jak bloky zasadit do kontextu a vyřešit opakující se problém.

### ? Co NEPATŘÍ mezi typické části popisu architektonického vzoru?

- [ ] Problem
- [ ] Context
- [x] Budget
- [ ] Solution

> Popis vzoru obsahuje např. Name, Problem, Context, Forces, Solution a Resulting Context. Rozpočet do popisu vzoru nepatří.
