---
kind: topic
subject: archimate-foundation
slug: implementation-migration
name: "Implementation & Migration"
order: 9
---

Work Package, Deliverable, Implementation Event, Plateau, Gap; vazba na Phases E–F TOGAF ADM.

## Účel prvků Implementation & Migration {#ucel-im .explain}

Prvky **Implementation & Migration** (I&M) doplňují ArchiMate o modelování **změny architektury**. Core prvky (Business, Application, Technology) popisují, *jak podnik vypadá* v určitém okamžiku; prvky I&M popisují, *jak se mezi stavy přechází*: jakou prací (programy, projekty), s jakými výsledky, přes jaké mezistavy a s jakými rozdíly mezi nimi. Patří sem pět prvků: **Work Package**, **Deliverable**, **Implementation Event**, **Plateau** a **Gap**. I&M je součástí Full Framework (ne Core Framework) a slouží hlavně plánování migrace — v TOGAF ADM odpovídá Phases E a F.

*Příklad:* `Zavedení CRM (Work Package) —realization→ Nasazené CRM (Deliverable) —realization→ CRM (Application Component)`

### ? Co se v ArchiMate modeluje prvky Implementation & Migration?

- [x] Práce na změně, její výsledky a mezistavy architektury v čase
- [ ] Fyzické nasazení softwaru na servery, zařízení a sítě
- [ ] Cíle, principy a požadavky, které změnu architektury motivují
- [ ] Schopnosti podniku a toky hodnoty, které přináší svým zákazníkům

> I&M popisuje provedení změny: práci (Work Package), výsledky (Deliverable), milníky (Implementation Event), stavy architektury (Plateau) a rozdíly mezi nimi (Gap). Nasazení softwaru patří do Technology Layer, cíle a požadavky do Motivation, schopnosti a toky hodnoty do Strategy.

### ? Který prvek NEPATŘÍ mezi prvky Implementation & Migration?

- [ ] Plateau
- [ ] Deliverable
- [ ] Implementation Event
- [x] Course of Action

> Course of Action je prvek Strategy — způsob, jak podnik dosáhne strategického cíle. Plateau, Deliverable a Implementation Event patří spolu s Work Package a Gap do Implementation & Migration.

### ? Jakou otázku o architektuře pomáhají zodpovědět hlavně prvky Implementation & Migration?

- [ ] Které aplikační služby používá daný business proces
- [ ] Na kterých uzlech a systémovém softwaru aplikace běží
- [ ] Které cíle a požadavky stakeholderů architektura splňuje
- [x] Jakými kroky a přes jaké mezistavy se dojde k cíli

> Prvky I&M popisují cestu ze současného do cílového stavu — práci, výsledky a mezistavy. Využití aplikačních služeb a nasazení na uzly popisují Core vrstvy, plnění cílů a požadavků Motivation prvky.

## Přehled prvků Implementation & Migration {#prehled-prvku .compare}

Pět prvků se dá rozdělit na ty, které popisují **práci** (Work Package, Deliverable, Implementation Event), a ty, které popisují **stavy architektury** (Plateau, Gap).

| Prvek | Povaha | Význam | Notace (slovy) |
|---|---|---|---|
| Work Package | obdoba chování | jednorázová práce s cílem, začátkem a koncem | zaoblený obdélník s ikonou kruhové šipky |
| Deliverable | obdoba pasivní struktury | konkrétní dohodnutý výstup práce | obdélník se zvlněným dolním okrajem |
| Implementation Event | obdoba události | změna stavu během realizace (zahájení, milník, schválení) | tvar události jako u ostatních eventů |
| Plateau | stav architektury | stav architektury, který po určité období platí | obdélník s ikonou tří stupňovitě posunutých čar |
| Gap | rozdíl stavů | rozdíl mezi dvěma plateaus | obdélník s ikonou elipsy protnuté dvěma vodorovnými čarami |

### ? Které dva prvky Implementation & Migration jsou svou povahou obdobou chování a pasivní struktury?

- [x] Work Package a Deliverable
- [ ] Plateau a Gap
- [ ] Implementation Event a Plateau
- [ ] Gap a Deliverable

> Work Package je práce (obdoba chování), Deliverable její výsledek (obdoba pasivní struktury). Plateau a Gap popisují stavy architektury a rozdíly mezi nimi, Implementation Event je obdobou události.

### ? Který prvek Implementation & Migration se zakresluje jako obdélník se zvlněným dolním okrajem?

- [ ] Work Package
- [ ] Plateau
- [x] Deliverable
- [ ] Gap

> Deliverable má tvar „dokumentu" se zvlněným dolním okrajem. Work Package je zaoblený obdélník s ikonou kruhové šipky, Plateau má ikonu stupňovitě posunutých čar a Gap ikonu elipsy protnuté dvěma čarami.

## Work Package {#work-package .term}

**Work Package** je naplánovaná práce, kterou se změna architektury skutečně provede, s vlastním cílem, termíny a zdroji. Na rozdíl od business procesu je **jednorázový** — má jasný začátek, konec a cíl. Může jím být program, projekt, fáze projektu i dílčí úkol: větší Work Package se skládá z menších (composition / aggregation), pořadí se vyjadřuje vztahem **triggering**. Výsledky vyjadřuje vztah **realization** k Deliverable a odpovědnost vztah **assignment** od Business Actor nebo Business Role. Notace: zaoblený obdélník s ikonou kruhové šipky.

*Příklad:* `Projektový tým (Business Role) —assignment→ Migrace dat do nového ERP (Work Package)`

### ? Čím se Work Package odlišuje od běžného chování v Core vrstvách?

- [ ] Je vždy přiřazen aplikační komponentě, která ho automatizuje
- [ ] Opakuje se pravidelně pro každý nový případ nebo zákazníka
- [ ] Popisuje externě viditelnou funkcionalitu nabízenou okolí
- [x] Je jednorázový a má definovaný začátek, konec a cíl

> Work Package je jednorázová práce s cílem a časovým vymezením. Opakované chování je business proces, externě viditelná funkcionalita je služba; automatizace aplikací není jeho definiční znak.

### ? Jak se v ArchiMate vyjádří, že za projekt odpovídá role vedoucího projektu?

- [ ] `Vedoucí projektu (Business Role) —serving→ Projekt (Work Package)`
- [x] `Vedoucí projektu (Business Role) —assignment→ Projekt (Work Package)`
- [ ] `Projekt (Work Package) —realization→ Vedoucí projektu (Business Role)`
- [ ] `Vedoucí projektu (Business Role) —triggering→ Projekt (Work Package)`

> Kdo práci provádí nebo za ni odpovídá, vyjadřuje assignment od Business Role (nebo Business Actor) k Work Package. Serving znamená poskytování služby, realization by tvrdila, že projekt vytváří roli, a triggering je časová návaznost chování.

### ? Program „Digitalizace" se skládá ze tří projektů, které existují jen jako jeho součásti. Jak to správně namodelovat?

- [x] `Digitalizace (Work Package) —composition→ každý projekt (Work Package)`
- [ ] `Digitalizace (Plateau) —aggregation→ každý projekt (Work Package)`
- [ ] `Každý projekt (Deliverable) —realization→ Digitalizace (Work Package)`
- [ ] `Digitalizace (Grouping) —triggering→ každý projekt (Work Package)`

> Program i projekty jsou Work Packages a vztah celek–část bez samostatné existence částí je composition. Plateau je stav architektury, ne program; projekty nejsou Deliverables a triggering vyjadřuje pořadí, ne skladbu.

## Work Package × Business Process {#wp-vs-process .compare}

Oba prvky popisují činnost, ale jeden *mění* podnik, druhý popisuje jeho *běžné fungování*.

| | Work Package | Business Process |
|---|---|---|
| Charakter | jednorázová práce na změně | opakované fungování podniku |
| Čas | pevný začátek, konec a termín | běží průběžně, každý případ znovu |
| Výsledek | Deliverable (zpráva, release, nový proces…) | business služba, produkt, změna Business Object |
| Kde v jazyce | Implementation & Migration | Business Layer |
| Typický vztah | `—realization→ Deliverable` | `—realization→ Business Service` |
| Příklad | Zavedení nového e-shopu (březen–září) | Vyřízení objednávky |

### ? Firma zavádí nový e-shop; práce poběží od března do září a skončí jeho spuštěním. Jakým prvkem se tato práce modeluje?

- [ ] Business Process
- [x] Work Package
- [ ] Business Function
- [ ] Implementation Event

> Jednorázová práce s pevným začátkem, koncem a cílem je Work Package. Business Process a Business Function popisují opakované fungování podniku, Implementation Event je jen okamžik (např. spuštění), ne celá práce.

### ? Zákaznické centrum vyřizuje reklamace každý den a činnost nemá datum ukončení. Který prvek je pro ni správný?

- [ ] Work Package
- [ ] Implementation Event
- [ ] Deliverable
- [x] Business Process

> Opakovaná činnost bez data ukončení patří do běžného fungování podniku, tedy Business Process. Work Package by znamenal jednorázový projekt, Implementation Event okamžik a Deliverable výsledek projektu.

## Deliverable {#deliverable .term}

**Deliverable** je to, co po Work Package „zůstane na stole" — konkrétní, předem dohodnutý výstup, například zpráva, smlouva, dokumentace, softwarový release, zavedený proces nebo plán. Work Package jej **realizuje** (`realization`) a Deliverable sám **realizuje prvky architektury**, které díky změně vzniknou nebo se změní (Application Component, Business Process, Node…); realizovat lze i Plateau jako celek. Deliverables lze skládat (composition / aggregation). Notace: obdélník se zvlněným dolním okrajem.

*Příklad:* `Release 2.0 portálu (Deliverable) —realization→ Zákaznický portál (Application Component)`

### ? Jaký vztah vede od Work Package k výsledku, který vytváří (Deliverable)?

- [ ] assignment
- [ ] triggering
- [x] realization
- [ ] composition

> Work Package realizuje Deliverable — práce „uskutečňuje" výsledek. Assignment vede od role nebo aktéra k Work Package, triggering vyjadřuje časovou návaznost a composition skladbu celku z částí.

### ? Výstupem projektu je „Platební platforma v1" (Deliverable), díky níž vznikne aplikace „Platby" (Application Component). Který fragment je správně?

- [ ] `Platby (Application Component) —realization→ Platební platforma v1 (Deliverable)`
- [ ] `Platební platforma v1 (Deliverable) —serving→ Platby (Application Component)`
- [x] `Platební platforma v1 (Deliverable) —realization→ Platby (Application Component)`
- [ ] `Platební platforma v1 (Deliverable) —assignment→ Platby (Application Component)`

> Deliverable realizuje prvek architektury, který díky změně vzniká — směr vede od Deliverable k aplikaci. Obrácený směr nedává smysl, serving by znamenal poskytování služby a assignment přiřazení aktivní struktury k chování.

### ? Co z následujícího je typickým Deliverable?

- [ ] Role vedoucího projektu
- [x] Schválená studie proveditelnosti
- [ ] Měsíční uzávěrka účetnictví
- [ ] Stav architektury platný ke konci roku 2027

> Deliverable je konkrétní dohodnutý výstup práce, např. studie, dokumentace nebo release. Role je Business Role, opakovaná uzávěrka je business chování a stav architektury je Plateau.

## Deliverable × Artifact {#deliverable-vs-artifact .compare}

Oba prvky mohou vypadat jako „soubor", ale patří do různých částí jazyka. (Pozor: **artefakt v TOGAF** — katalog, matice, diagram — je ještě jiný pojem; TOGAF deliverable se z takových artefaktů skládá.)

| | Deliverable | Artifact |
|---|---|---|
| Část jazyka | Implementation & Migration | Technology Layer |
| Co představuje | výsledek práce projektu (dokument, release, plán, zavedená změna) | konkrétní data nebo soubor pro vývoj a provoz softwaru (spustitelný soubor, skript, konfigurace) |
| Typické vztahy | Work Package —realization→ Deliverable; Deliverable —realization→ prvky architektury | System Software / Node —assignment→ Artifact; Artifact —realization→ Application Component, Data Object |
| Vazba na čas | vzniká v rámci projektu | existuje v provozované architektuře |
| Příklad | „Release 2.0 portálu" | `portal-2.0.war` |

### ? Architekt potřebuje zachytit soubor `objednavky.war`, který je nasazen na aplikační server. Který prvek použije?

- [x] Artifact
- [ ] Deliverable
- [ ] Data Object
- [ ] Work Package

> Konkrétní soubor nasazovaný na infrastrukturu je Artifact (Technology Layer), na který je přiřazen System Software nebo Node. Deliverable je výsledek projektu, Data Object logická data aplikace a Work Package práce.

### ? Který výrok o prvcích Deliverable a Artifact v ArchiMate je správný?

- [ ] Oba patří do Technology Layer a liší se jen velikostí souboru
- [ ] Artifact je výsledek Work Package, Deliverable se nasazuje na Node
- [ ] Deliverable je jiný název pro artefakt TOGAF, tedy katalog či matici
- [x] Deliverable je výsledek projektu, Artifact provozovaný technický soubor

> Deliverable patří do Implementation & Migration jako výsledek Work Package, Artifact do Technology Layer jako soubor nebo data nasazená na infrastrukturu. Role jsou zaměněné ve druhé možnosti a artefakt TOGAF (katalog, matice, diagram) je jiný pojem.

## Implementation Event {#implementation-event .term}

**Implementation Event** je okamžik, kdy se v průběhu změny něco podstatného stane: zahájení či ukončení projektu, dosažení milníku, schválení, předání výsledku, pevný termín. Vztahem **triggering** může spouštět Work Package (`Implementation Event —triggering→ Work Package`) a sám může být vyvolán dokončením práce (`Work Package —triggering→ Implementation Event`). Od Business Event se liší tím, že se týká *průběhu změny*, ne běžného provozu podniku (objednávka, reklamace). Notace: tvar události, stejně jako u ostatních eventů.

*Příklad:* `Schválení rozpočtu (Implementation Event) —triggering→ Výběrové řízení na dodavatele (Work Package)`

### ? Co je typickým příkladem Implementation Event?

- [x] Schválení projektového záměru řídicím výborem
- [ ] Přijetí nové objednávky od zákazníka e-shopu
- [ ] Výpadek databázového serveru v produkci
- [ ] Doručení faktury od dodavatele kancelářských potřeb

> Implementation Event se týká průběhu změny — schválení, milník, zahájení či ukončení projektu. Objednávka a faktura jsou události běžného provozu (Business Event), výpadek serveru je technologická událost.

### ? Jak vyjádřit, že dokončení Work Package „Analýza" vyvolá milník „Analýza schválena"?

- [ ] `Analýza schválena (Implementation Event) —realization→ Analýza (Work Package)`
- [ ] `Analýza (Work Package) —realization→ Analýza schválena (Implementation Event)`
- [ ] `Analýza (Work Package) —access→ Analýza schválena (Implementation Event)`
- [x] `Analýza (Work Package) —triggering→ Analýza schválena (Implementation Event)`

> Časovou a příčinnou návaznost mezi prací a událostí vyjadřuje triggering, zde od Work Package k Implementation Event. Realization vyjadřuje uskutečnění výsledku a access přístup k pasivní struktuře, ani jeden nepopisuje vyvolání události.

### ? Čím se Implementation Event liší od Business Event?

- [ ] Implementation Event nesmí spouštět žádné chování
- [ ] Business Event lze použít jen v Motivation prvcích
- [x] Týká se průběhu změny, ne běžného provozu podniku
- [ ] Má vždy přesné datum, Business Event nikdy nemá

> Implementation Event zachycuje okamžiky realizace změny (milník, schválení, zahájení). Business Event je událost běžného provozu; spouštět chování mohou obě a datum není rozlišovacím znakem.

## Plateau {#plateau .term}

**Plateau** je „zastávka" na cestě změny: stav architektury, který nějakou dobu platí beze změn. Plateau **seskupuje prvky architektury**, které v tomto stavu existují, typicky vztahem **aggregation**: tentýž prvek (např. stávající ERP) může patřit do více plateaus. Pořadí plateaus se vyjadřuje vztahem **triggering** od dřívějšího k pozdějšímu, rozdíl mezi dvěma plateaus popisuje **Gap**. Notace: obdélník s ikonou tří vodorovných čar posunutých do schodů.

*Příklad:* `Stav 2027 (Plateau) —aggregation→ Nový e-shop (Application Component)`; `Stav 2026 (Plateau) —triggering→ Stav 2027 (Plateau)`

### ? Co v ArchiMate představuje Plateau?

- [x] Stav architektury, který po určité období platí
- [ ] Jednorázový projekt s pevným termínem zahájení i dokončení
- [ ] Rozdíl mezi současnou a cílovou architekturou
- [ ] Logické seskupení prvků bez jakékoli vazby na čas

> Plateau je stav architektury platný po určité období. Projekt je Work Package, rozdíl mezi stavy je Gap a seskupení bez časového významu je Grouping.

### ? Proč se prvky architektury k Plateau obvykle připojují vztahem aggregation, a ne composition?

- [x] Tentýž prvek může patřit do více plateaus, např. do výchozího i cílového
- [ ] Aggregation vyjadřuje časové pořadí, v jakém prvky v plateau vznikají
- [ ] Aggregation zajistí, že prvek zanikne spolu s koncem daného plateau
- [ ] Composition je v ArchiMate vyhrazena jen pro vztahy mezi Work Packages

> Aggregation dovoluje, aby část patřila do více celků — stávající systém je součástí výchozího i přechodového stavu. Časové pořadí aggregation nevyjadřuje, zánik spolu s celkem je naopak vlastnost composition a ta se používá v celém jazyce.

### ? Jak se zapíše, že Plateau „Přechod 2027" následuje po Plateau „Současný stav"?

- [ ] `Současný stav (Plateau) —realization→ Přechod 2027 (Plateau)`
- [x] `Současný stav (Plateau) —triggering→ Přechod 2027 (Plateau)`
- [ ] `Současný stav (Plateau) —composition→ Přechod 2027 (Plateau)`
- [ ] `Současný stav (Plateau) —access→ Přechod 2027 (Plateau)`

> Posloupnost plateaus se vyjadřuje vztahem triggering od dřívějšího stavu k pozdějšímu. Realization ani composition časový sled nevyjadřují a access je vztah chování k pasivní struktuře.

## Baseline, Transition a Target {#typy-plateau .explain}

ArchiMate nemá zvláštní typy prvků pro současný a cílový stav — **všechny stavy jsou Plateau** a liší se jen pojmenováním a místem v řetězci: **Baseline** (výchozí, současný stav), jeden či více **Transition** plateaus (mezistavy) a **Target** (cílový stav). Mezistavy se zavádějí, když je změna příliš velká nebo riziková na to, aby proběhla najednou, a každý mezistav musí být sám o sobě provozuschopný. Řetězec plateaus spojený vztahem triggering tvoří kostru roadmapy; mezi sousedními plateaus leží Gaps a Work Packages, jejichž Deliverables realizují prvky dalšího stavu.

*Příklad:* `Baseline 2026 (Plateau) —triggering→ Transition 2027 (Plateau) —triggering→ Target 2028 (Plateau)`

### ? Jak ArchiMate rozlišuje výchozí, přechodovou a cílovou architekturu?

- [ ] Každá má vlastní typ prvku: Baseline, Transition a Target
- [ ] Výchozí a cílová jsou Plateau, přechodové se modelují jako Gap
- [x] Všechny jsou Plateau a liší se pojmenováním a pořadím v řetězci
- [ ] Výchozí stav se nemodeluje, zakreslují se jen cílová Plateau

> Pro všechny stavy architektury se používá jediný prvek Plateau; baseline, transition a target jsou jen jeho role v plánu. Gap je rozdíl mezi stavy, ne stav, a výchozí stav se běžně modeluje, aby bylo s čím porovnávat.

### ? Kdy je vhodné zavést mezi baseline a target jeden či více přechodových plateaus?

- [ ] Vždy, ArchiMate mezi nimi vyžaduje aspoň jedno Plateau
- [ ] Jen tehdy, když se mění výhradně prvky Technology Layer a nic jiného
- [x] Když změnu nelze provést najednou a mezistav musí fungovat
- [ ] Když chybí dokumentace výchozího stavu architektury

> Přechodové plateaus rozdělují velkou nebo rizikovou změnu na provozuschopné kroky. ArchiMate je nevyžaduje, nejsou vázány na jednu vrstvu a chybějící dokumentace výchozího stavu je jiný problém.

## Gap {#gap .term}

**Gap** vyjadřuje rozdíl mezi dvěma plateaus — co se mezi nimi přidává, odstraňuje nebo mění. Vztahem **association** se napojuje na **dvě plateaus**, které porovnává, a dále na prvky architektury, kterých se rozdíl týká (nový systém, rušený proces, měněné rozhraní). Gap je zachycený výsledek gap analýzy a podkladem pro vymezení Work Packages, které rozdíl odstraní. Notace: obdélník s ikonou elipsy protnuté dvěma vodorovnými čarami.

*Příklad:* `Náhrada billingu (Gap) —association→ Baseline 2026 (Plateau)`; `Náhrada billingu (Gap) —association→ Target 2028 (Plateau)`; `Náhrada billingu (Gap) —association→ Starý billing (Application Component)`

### ? Jakým vztahem se Gap napojuje na plateaus, mezi nimiž popisuje rozdíl?

- [ ] triggering
- [ ] realization
- [x] association
- [ ] aggregation

> Gap se k porovnávaným plateaus (i k dotčeným prvkům) připojuje vztahem association. Triggering mezi plateaus vyjadřuje jejich pořadí, realization a aggregation by vyjadřovaly uskutečnění nebo skladbu, ne rozdíl.

### ? Co Gap v modelu typicky propojuje?

- [ ] Jeden Work Package s jeho Deliverables a odpovědnou rolí
- [x] Dvě porovnávaná plateaus a prvky, kterých se rozdíl týká
- [ ] Všechna plateaus roadmapy do jednoho souhrnného stavu
- [ ] Implementation Event se všemi Work Packages, které spouští

> Gap porovnává právě dva stavy architektury a ukazuje, kterých prvků se rozdíl týká. Práci a její výsledky popisují Work Package a Deliverable, spouštění práce Implementation Event.

## Gap × Gap Analysis {#gap-vs-gap-analysis .compare}

Gap analýza je **postup**, Gap je **prvek modelu**, do kterého se zapíše jeden její výsledek.

| | Gap (prvek ArchiMate) | Gap Analysis (technika TOGAF) |
|---|---|---|
| Co to je | prvek modelu vyjadřující jeden rozdíl dvou stavů | postup porovnání výchozí a cílové architektury |
| Kde se používá | v modelu a pohledech na migraci | v TOGAF ADM ve Phases B, C a D, výsledky se konsolidují v Phase E |
| Podoba výstupu | prvek s asociacemi na dvě plateaus a dotčené prvky | seznam či matice rozdílů (nové, vyřazené, změněné, chybějící) |
| Navazuje | Work Packages, které rozdíl odstraní | návrh Work Packages a Transition Architectures |

### ? Jaký je vztah mezi technikou gap analýzy v TOGAF a prvkem Gap v ArchiMate?

- [ ] Jde o totéž — Gap je jen zkrácený anglický název techniky
- [x] Gap analýza je postup, Gap je prvek zachycující její výsledek
- [ ] Gap je postup a gap analýza je jeho diagram v jazyce ArchiMate
- [ ] Prvek Gap nahrazuje gap analýzu, kterou ArchiMate nepřipouští

> Gap analýza porovná výchozí a cílový stav; každý zjištěný rozdíl lze v modelu zachytit prvkem Gap. Nejsou to synonyma a jeden pojem druhý nenahrazuje.

### ? Ve kterých fázích TOGAF ADM se gap analýza typicky provádí?

- [ ] V Preliminary Phase a Phase A
- [ ] Jen v Requirements Management
- [ ] Ve Phases G a H
- [x] Ve Phases B, C a D, konsolidace v Phase E

> Gap analýza se dělá při vývoji architektur Business, Information Systems a Technology (Phases B–D) a v Phase E se výsledky konsolidují do Work Packages. Preliminary a A připravují práci, G a H řídí realizaci a změny.

## Vztahy mezi prvky Implementation & Migration {#vztahy-im .explain}

Uvnitř I&M se používá jen několik vztahů:

- `Work Package —realization→ Deliverable` — práce vytváří výsledek;
- `Work Package —composition/aggregation→ Work Package` — program a projekty; obdobně skladba Deliverables;
- `Implementation Event —triggering→ Work Package`, `Work Package —triggering→ Implementation Event`, `Work Package —triggering→ Work Package` — časová návaznost práce a milníků;
- `Plateau —triggering→ Plateau` — pořadí stavů architektury;
- `Gap —association→ Plateau` — rozdíl mezi dvěma stavy.

*Příklad:* `Kick-off (Implementation Event) —triggering→ Analýza (Work Package) —triggering→ Vývoj (Work Package) —realization→ Release 1.0 (Deliverable)`

### ? Projekt B smí začít až po dokončení projektu A. Který fragment to správně vyjadřuje?

- [x] `A (Work Package) —triggering→ B (Work Package)`
- [ ] `A (Work Package) —realization→ B (Work Package)`
- [ ] `A (Work Package) —serving→ B (Work Package)`
- [ ] `A (Work Package) —aggregation→ B (Work Package)`

> Časovou návaznost práce vyjadřuje triggering. Realization by tvrdila, že A uskutečňuje B, serving poskytování služby a aggregation by z B udělala součást A.

### ? Který vztah NEPATŘÍ mezi typické vztahy prvků Implementation & Migration?

- [ ] `Work Package —realization→ Deliverable`
- [ ] `Plateau —triggering→ Plateau`
- [x] `Deliverable —assignment→ Work Package`
- [ ] `Gap —association→ Plateau`

> Deliverable je výsledek práce, ne aktivní struktura — nemůže být přiřazen k Work Package. Work Package realizuje Deliverable, plateaus se řadí triggeringem a Gap se asociuje s plateaus.

## Vazby Implementation & Migration na Core prvky {#vazby-na-core .explain}

Prvky I&M se s architekturou propojují čtyřmi typickými způsoby:

- `Business Actor / Business Role —assignment→ Work Package` — kdo práci provádí nebo za ni odpovídá;
- `Deliverable —realization→ Core prvek` — co výsledek projektu uvádí do života (aplikace, proces, uzel, data…);
- `Plateau —aggregation→ Core prvek` — které prvky v daném stavu architektury existují;
- `Gap —association→ Core prvek` — kterých prvků se rozdíl mezi stavy týká.

Díky tomu lze sledovat celý řetězec od projektu přes výsledek až k prvku cílového stavu.

*Příklad:* `IT oddělení (Business Actor) —assignment→ Nasazení CRM (Work Package) —realization→ CRM v provozu (Deliverable) —realization→ CRM (Application Component)`; `Target 2028 (Plateau) —aggregation→ CRM (Application Component)`

### ? Jak se v modelu vyjádří, že nová aplikace CRM bude součástí cílového stavu „Target 2028"?

- [ ] `CRM (Application Component) —triggering→ Target 2028 (Plateau)`
- [ ] `Target 2028 (Plateau) —serving→ CRM (Application Component)`
- [ ] `CRM (Application Component) —assignment→ Target 2028 (Plateau)`
- [x] `Target 2028 (Plateau) —aggregation→ CRM (Application Component)`

> Plateau seskupuje prvky, které v daném stavu existují, vztahem aggregation. Triggering by vyjadřoval časovou návaznost, serving službu a assignment přiřazení aktivní struktury k chování.

### ? Který Core prvek se typicky přiřazuje vztahem assignment k Work Package?

- [ ] Application Component
- [x] Business Role
- [ ] Technology Service
- [ ] Business Object

> Za práci odpovídají lidé a organizační jednotky — Business Actor nebo Business Role přiřazené k Work Package. Aplikační komponenta, technologická služba ani business objekt práci na změně neprovádějí.

### ? Rozdíl mezi výchozím a cílovým stavem spočívá ve vyřazení aplikace „Starý billing". Jak se Gap na tuto aplikaci napojí?

- [ ] `Starý billing (Application Component) —realization→ Gap`
- [ ] `Gap —triggering→ Starý billing (Application Component)`
- [x] `Gap —association→ Starý billing (Application Component)`
- [ ] `Gap —composition→ Starý billing (Application Component)`

> Gap se k dotčeným prvkům architektury (stejně jako k plateaus) připojuje vztahem association. Realization ani composition nevyjadřují „týká se" a triggering je časová návaznost chování.

## Vazba na TOGAF Phases E a F {#togaf-e-f .explain}

Prvky I&M přímo podporují plánovací fáze TOGAF ADM. Ve **Phase E (Opportunities and Solutions)** se konsolidují rozdíly zjištěné ve Phases B–D, seskupí se do **Work Packages**, určí se realizační nástroje (projekty, programy) a rozhodne se, zda jsou potřeba **Transition Architectures**; vzniká první verze Architecture Roadmap. Ve **Phase F (Migration Planning)** se práce seřadí a ocení a dokončí se Architecture Roadmap a Implementation and Migration Plan. Mapování: Work Package ≈ balík práce či projekt, Plateau ≈ Baseline / Transition / Target Architecture, Gap ≈ výsledek gap analýzy, Deliverable ≈ výstup projektu. Realizaci pak řídí Phase G (Implementation Governance).

*Příklad:* `Target (Plateau)` z Phase B–D, `Transition 1 (Plateau)` a `Work Package` „Konsolidace skladů" z Phase E, jejich pořadí (triggering) dořešené v Phase F.

### ? Které fáze TOGAF ADM nejvíce podporují prvky Implementation & Migration?

- [ ] Phases B a C
- [x] Phases E a F
- [ ] Preliminary Phase a Phase A
- [ ] Phase H a Requirements Management

> Phase E (Opportunities and Solutions) a Phase F (Migration Planning) plánují cestu k cíli — Work Packages, Transition Architectures a roadmapu. Phases B a C vytvářejí architektury, Preliminary a A připravují práci a H řídí změny architektury.

### ? Ve Phase E architekt seskupuje zjištěné rozdíly do realizovatelných celků práce. Který prvek ArchiMate tyto celky představuje?

- [ ] Gap
- [ ] Plateau
- [x] Work Package
- [ ] Deliverable

> Celky práce, které rozdíly odstraní, jsou Work Packages. Gap je samotný rozdíl, Plateau stav architektury a Deliverable výsledek, který Work Package vytvoří.

## Plateau × Transition Architecture (TOGAF) {#plateau-vs-transition .compare}

Transition Architecture lze v ArchiMate zachytit jako Plateau, ale Plateau je **širší pojem** — použije se i pro výchozí a cílový stav.

| | Plateau (ArchiMate) | Transition Architecture (TOGAF) |
|---|---|---|
| Co to je | prvek modelovacího jazyka | formální popis architektury v mezistavu |
| Rozsah | jakýkoli stav: baseline, mezistav i target | jen mezistav (výchozí a cílový stav mají vlastní pojmy Baseline / Target Architecture) |
| Obsah | seskupuje (aggregation) prvky platné v daném stavu | popis všech dotčených domén včetně zdůvodnění a přínosů |
| Kde vzniká | v modelu, v pohledu na migraci | ve Phase E, potvrzení ve Phase F |

### ? Který výrok o vztahu Plateau a TOGAF Transition Architecture je správný?

- [ ] Jsou to synonyma a Plateau nelze použít pro výchozí ani pro cílový stav
- [ ] Transition Architecture odpovídá v ArchiMate prvku Gap, ne Plateau
- [ ] Plateau odpovídá Architecture Roadmap jako celku se všemi projekty
- [x] Mezistav TOGAF je Plateau, ale Plateau může být i baseline či target

> Mezistav z TOGAF se v ArchiMate zachytí jako Plateau, stejný prvek však slouží i pro výchozí a cílový stav. Gap je rozdíl mezi stavy a roadmapu tvoří celý řetězec plateaus a Work Packages, ne jedno Plateau.

### ? Architekt chce v modelu zachytit TOGAF Baseline Architecture jako stav, s nímž bude porovnávat cíl. Který prvek použije?

- [ ] Grouping
- [x] Plateau
- [ ] Work Package
- [ ] Location

> Stav architektury v určitém období je Plateau. Grouping je seskupení bez časového významu, Work Package práce na změně a Location místo.

## Modelování roadmapy {#roadmapa .explain}

Typický postup při modelování migrace: (1) vytvořit **baseline** a **target** Plateau a agregovat do nich prvky, které v nich existují; (2) zachytit **Gaps** mezi nimi; (3) případně vložit **transition** plateaus a seřadit je vztahem triggering; (4) definovat **Work Packages** s přiřazenými rolemi; (5) jejich **Deliverables** napojit vztahem realization na prvky dalšího stavu; (6) milníky a schválení doplnit jako **Implementation Events**.

*Příklad:*
- `Baseline 2026 (Plateau) —triggering→ Target 2027 (Plateau)`
- `Migrace klientů (Work Package) —realization→ Migrovaný registr (Deliverable) —realization→ Klientský registr (Application Component)`
- `Target 2027 (Plateau) —aggregation→ Klientský registr (Application Component)`

### ? Projekt „Migrace klientů" vytvoří výstup „Migrovaný registr", díky kterému vznikne aplikace „Klientský registr". Který řetězec je správný?

- [ ] `Migrovaný registr (Deliverable) —realization→ Migrace klientů (Work Package) —realization→ Klientský registr (Application Component)`
- [x] `Migrace klientů (Work Package) —realization→ Migrovaný registr (Deliverable) —realization→ Klientský registr (Application Component)`
- [ ] `Migrace klientů (Work Package) —assignment→ Migrovaný registr (Deliverable) —serving→ Klientský registr (Application Component)`
- [ ] `Migrace klientů (Work Package) —triggering→ Migrovaný registr (Deliverable) —composition→ Klientský registr (Application Component)`

> Práce realizuje výsledek a výsledek realizuje prvek architektury: Work Package → Deliverable → Application Component. První možnost obrací pořadí, assignment ani triggering nevedou od práce k výsledku a serving či composition nevyjadřují uskutečnění aplikace.

### ? Model obsahuje `Baseline (Plateau) —triggering→ Target (Plateau)` a Gap asociovaný s oběma. Co typicky chybí k tomu, aby bylo vidět, kdo a čím rozdíl odstraní?

- [x] Work Packages s rolemi a Deliverables realizujícími cíl
- [ ] Druhý Gap asociovaný se stejnou dvojicí plateaus
- [ ] Grouping, který obě plateaus spojí do jednoho společného celku
- [ ] Vztah serving mezi oběma plateaus v opačném směru

> Kdo a čím změnu provede, ukazují Work Packages s přiřazenými rolemi a jejich Deliverables, které realizují prvky cílového stavu. Další Gap, Grouping ani serving mezi plateaus tuto informaci nepřidají.

## Typické chyby v Implementation & Migration {#typicke-chyby .explain}

Nejčastější chyby při modelování změny:

- projekt namodelovaný jako **Business Process** (proces je opakovaný, projekt jednorázový);
- stav architektury namodelovaný jako **Grouping** (nemá časový význam, nelze ho řadit ani porovnávat Gapem);
- **obrácený směr realization** (aplikace „realizuje" Deliverable místo opačně);
- Deliverable zaměněný s **Artifact** z Technology Layer;
- příslušnost prvku k Plateau vyjádřená jiným vztahem než **aggregation** (např. triggering);
- milník projektu zakreslený jako **Business Event** místo Implementation Event.

*Příklad chyby:* `Portál (Application Component) —realization→ Release 2.0 (Deliverable)` — správně je `Release 2.0 (Deliverable) —realization→ Portál (Application Component)`.

### ? Model obsahuje: `Implementace (Work Package) —realization→ Release 2.0 (Deliverable)`, `Release 2.0 (Deliverable) —realization→ Portál (Application Component)` a `Portál (Application Component) —triggering→ Target (Plateau)`. Co je chybně?

- [ ] Work Package nesmí realizovat Deliverable, jen ho spouštět
- [ ] Deliverable nesmí realizovat prvek typu Application Component přímo
- [ ] Release 2.0 se má modelovat jako Implementation Event
- [x] Příslušnost portálu k Target má vyjádřit aggregation od Plateau

> Prvky patřící do stavu architektury seskupuje Plateau vztahem aggregation; triggering z aplikace na Plateau nemá smysl. Realizace Deliverable prací i realizace aplikace Deliverablem jsou správně a release je výsledek, ne událost.

### ? Architekt zakreslil „Současný stav" a „Cílový stav" jako dva prvky Grouping. Proč je vhodnější Plateau?

- [x] Plateau nese časový význam, lze ho řadit a porovnávat Gapem
- [ ] Grouping nesmí obsahovat prvky z Application Layer
- [ ] Plateau je povinnou součástí každého modelu ArchiMate
- [ ] Grouping lze použít jen uvnitř Business Layer

> Plateau je stav architektury v čase — plateaus se řadí vztahem triggering a rozdíly mezi nimi zachycuje Gap. Grouping může seskupovat prvky z libovolných vrstev, ale časový význam nemá; povinný v modelu není žádný prvek.
