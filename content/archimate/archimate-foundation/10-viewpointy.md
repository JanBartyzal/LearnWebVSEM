---
kind: topic
subject: archimate-foundation
slug: viewpointy
name: "Viewpointy, pohledy a notace"
order: 10
---

Viewpoint mechanismus, příklady základních viewpointů (Organization, Application Cooperation, Layered, Technology Usage, Motivation, Migration…), přizpůsobení jazyka (atributy, specializace).

## Viewpoint Mechanism {#viewpoint-mechanism .term}

**Viewpoint Mechanism** je část ArchiMate, která popisuje, jak **definovat a používat hlediska (viewpoints)**. Jazyk nepředepisuje pevnou sadu diagramů: architekt si pro konkrétní **stakeholdery** a jejich **zájmy (concerns)** určí, jaké prvky a vztahy bude pohled (view) obsahovat a jak se zobrazí. Každý view je pak výřezem jednoho modelu vytvořeným podle zvoleného viewpointu. Specifikace k tomu přidává sadu **příkladových viewpointů**, které lze převzít, upravit nebo nahradit vlastními.

*Příklad:* viewpoint „Přehled aplikací pro vedení IT" — stakeholder CIO, zájem duplicity aplikací, obsah Application Component a Application Service s vazbami na Business Process.

### ? Co umožňuje Viewpoint Mechanism jazyka ArchiMate?

- [ ] Automaticky vygenerovat úplný model architektury ze zdrojového kódu aplikací
- [x] Definovat viewpointy podle stakeholderů, jejich zájmů a potřebného obsahu
- [ ] Převést libovolný ArchiMate model do diagramů UML a BPMN
- [ ] Předepsat jedinou povinnou sadu diagramů pro všechny podniky

> Viewpoint Mechanism říká, jak vymezit hledisko: pro koho je, jaké zájmy řeší, které prvky a vztahy obsahuje a jak se zobrazí. Generování z kódu ani převod do jiných notací neřeší a žádnou povinnou sadu diagramů nepředepisuje.

### ? Smí architekt v souladu s ArchiMate použít viewpoint, který mezi příkladovými viewpointy specifikace není?

- [ ] Ne, povolené jsou jen viewpointy uvedené ve specifikaci
- [ ] Ano, ale jen pokud obsahuje prvky z jediné vrstvy jazyka
- [ ] Ne, vlastní viewpoint vyžaduje zvláštní certifikaci nástroje
- [x] Ano, viewpointy lze upravovat i definovat úplně nové

> Příkladové viewpointy jsou jen nabídkou; Viewpoint Mechanism výslovně počítá s úpravou a definicí vlastních hledisek podle potřeb stakeholderů. Omezení na jednu vrstvu ani certifikace nástroje se nevyžaduje.

## Jak vzniká view: výběr a reprezentace {#vyber-a-reprezentace .explain}

Vytvoření view podle viewpointu má dva kroky. Nejprve **výběr (selection)** — z modelu se vyberou prvky a vztahy, které jsou pro zájmy stakeholdera relevantní (viewpoint určuje, které typy smějí být použity). Poté **reprezentace (representation)** — vybraný obsah se zobrazí formou vhodnou pro daného čtenáře. Tou nemusí být jen diagram v notaci ArchiMate: view může mít i podobu tabulky, katalogu, matice, seznamu nebo zjednodušeného obrázku. Model je jeden, views jsou jeho různé výřezy a podoby.

*Příklad:* tentýž výběr `Application Component —serving→ Business Process` lze pro architekta ukázat jako diagram a pro vedení jako matici „aplikace × procesy".

### ? Jaké dva kroky tvoří podle Viewpoint Mechanism vytvoření view?

- [x] Výběr relevantních prvků a vztahů z modelu a reprezentace
- [ ] Sběr požadavků od stakeholderů a jejich formální schválení
- [ ] Návrh výchozí architektury a následně cílové architektury
- [ ] Nakreslení diagramu a jeho převod do textové dokumentace

> View vzniká výběrem obsahu z modelu a jeho reprezentací vhodnou pro stakeholdera. Sběr a schvalování požadavků, návrh stavů architektury ani převod do dokumentace nejsou kroky tvorby view.

### ? Musí být view vždy zobrazen jako diagram v notaci ArchiMate?

- [ ] Ano, jiná podoba by porušila specifikaci jazyka
- [ ] Ano, kromě views určených pro auditory a regulátory
- [x] Ne, může mít i podobu tabulky, matice či obrázku
- [ ] Ne, ale jen views s prvky z jediné vrstvy jazyka

> Reprezentace se volí podle čtenáře — kromě diagramu přichází v úvahu tabulka, katalog, matice nebo zjednodušená ilustrace. Žádná výjimka pro auditory ani omezení na jednu vrstvu se neuplatňuje.

## Účel viewpointu: Designing, Deciding, Informing {#ucel-viewpointu .compare}

První dimenze klasifikace viewpointů — **k čemu** view slouží.

| Účel | Komu pomáhá | K čemu | Typická podoba |
|---|---|---|---|
| **Designing** | architektům a návrhářům | návrh od prvního náčrtu po detail | diagramy v notaci ArchiMate (podobně jako UML, BPMN) |
| **Deciding** | manažerům a rozhodovatelům | rozhodnutí na základě vazeb napříč doménami | křížové tabulky, mapy krajiny, seznamy, reporty |
| **Informing** | libovolným stakeholderům, i neodborníkům | porozumění, získání podpory, přesvědčení | ilustrace, plakáty, animace, jednoduché obrázky |

### ? CIO má rozhodnout, které aplikace vyřadit, a potřebuje přehled, jaké procesy na nich závisejí. Jaký účel má view, který pro něj architekt připraví?

- [ ] Designing
- [x] Deciding
- [ ] Informing
- [ ] Overview

> View na podporu rozhodnutí manažera má účel Deciding. Designing slouží návrhu architektům, Informing vysvětlení a získání podpory; Overview je úroveň obsahu, ne účel.

### ? Která podoba view je typická pro účel Informing?

- [ ] Podrobný diagram jedné aplikační komponenty s rozhraními
- [ ] Křížová tabulka aplikací a procesů pro investiční výbor
- [ ] Úplný seznam všech vztahů v modelu pro kontrolu konzistence
- [x] Jednoduchý plakát cílového stavu pro zaměstnance firmy

> Informing má širokému publiku vysvětlit architekturu a získat podporu, proto volí jednoduché ilustrace a plakáty. Podrobný diagram slouží návrhu (Designing), křížová tabulka rozhodování (Deciding).

### ? Pro koho jsou primárně určeny views s účelem Designing?

- [x] Pro architekty a návrháře během návrhu řešení
- [ ] Pro členy představenstva při schvalování rozpočtu
- [ ] Pro zákazníky, kteří chtějí poznat nabídku firmy
- [ ] Pro všechny zaměstnance při zavádění změny

> Designing views podporují práci architektů a návrhářů od náčrtu po detailní návrh. Představenstvo potřebuje views pro rozhodování (Deciding), zaměstnanci a zákazníci spíše views informující (Informing).

## Úroveň viewpointu: Details, Coherence, Overview {#uroven-viewpointu .compare}

Druhá dimenze klasifikace — **jak široký obsah** view zahrnuje.

| Úroveň | Rozsah obsahu | Typický stakeholder |
|---|---|---|
| **Details** | jedna vrstva a jeden aspekt, do hloubky | vývojář komponenty, vlastník procesu |
| **Coherence** | více vrstev nebo více aspektů, důraz na vazby mezi nimi | provozní manažer odpovědný za skupinu služeb či procesů |
| **Overview** | více vrstev i aspektů najednou, celkový obraz | enterprise architekt, CIO, CEO |

### ? View podrobně ukazuje strukturu jedné aplikační komponenty, její podkomponenty a rozhraní, nic z jiných vrstev. Jakou má úroveň?

- [ ] Overview
- [ ] Coherence
- [x] Details
- [ ] Designing

> Jedna vrstva a jeden aspekt do hloubky odpovídají úrovni Details. Coherence propojuje více vrstev nebo aspektů, Overview dává celkový obraz; Designing je účel, ne úroveň.

### ? View ukazuje, které aplikační služby používají vybrané business procesy, a soustředí se na vazby mezi oběma vrstvami. Jakou má úroveň?

- [ ] Details
- [x] Coherence
- [ ] Overview
- [ ] Deciding

> Zaměření na vazby mezi dvěma vrstvami je typické pro úroveň Coherence. Details zůstává v jedné vrstvě a aspektu, Overview zahrnuje celek napříč vrstvami a aspekty; Deciding je účel.

### ? Pro koho jsou typicky určeny views na úrovni Overview?

- [ ] Pro programátora, který implementuje jednu komponentu
- [ ] Pro vlastníka jednoho procesu, který ladí jeho kroky
- [ ] Pro správce databáze, který navrhuje datové tabulky
- [x] Pro enterprise architekty a vrcholové vedení podniku

> Overview kombinuje více vrstev i aspektů a slouží celkovému pohledu enterprise architektů a vedení. Programátor, vlastník procesu nebo správce databáze potřebují podrobné views (Details).

## Kombinace účelu a úrovně {#ucel-a-uroven .explain}

Účel a úroveň jsou **dvě nezávislé dimenze** — každý viewpoint lze zařadit do kombinace „účel × úroveň". Například podrobný návrh jednoho procesu je *Designing + Details*, mapa aplikační krajiny s vazbami na procesy pro investiční rozhodnutí je *Deciding + Overview* a jednoduchý obrázek cílového stavu pro zaměstnance je *Informing + Overview*. Klasifikace pomáhá architektovi zvolit správnou míru detailu a formu podle toho, kdo view čte a co s ním udělá.

*Příklad:* pohled pro vývojový tým: `Objednávky (Application Component) —composition→ Validace (Application Component)` a rozhraní komponenty — *Designing + Details*.

### ? Architekt připravuje pro všechny zaměstnance jednoduchý obrázek, jak bude firma po transformaci fungovat napříč procesy, aplikacemi a technologiemi. Která kombinace účelu a úrovně to vystihuje?

- [ ] Designing + Details
- [ ] Deciding + Coherence
- [x] Informing + Overview
- [ ] Designing + Coherence

> Cílem je vysvětlit a získat podporu (Informing) a obsah zahrnuje celek napříč vrstvami (Overview). Designing slouží návrhářům a Deciding rozhodovatelům; Details a Coherence jsou užší rozsahy.

### ? Vývojový tým potřebuje přesný návrh jedné aplikační komponenty včetně jejích částí a rozhraní. Která kombinace účelu a úrovně to vystihuje?

- [x] Designing + Details
- [ ] Informing + Overview
- [ ] Deciding + Overview
- [ ] Informing + Coherence

> Návrh pro vývojáře má účel Designing a jedna komponenta v jedné vrstvě odpovídá úrovni Details. Informing a Deciding slouží jiným čtenářům a Overview či Coherence jsou širší, než tým potřebuje.

## Příkladové viewpointy {#prikladove-viewpointy .explain}

Specifikace uvádí sadu **příkladových (example) viewpointů**. Nejsou povinné ani úplné — jsou to osvědčené vzory, ze kterých lze vyjít, kombinovat je nebo je přizpůsobit. U každého je uvedeno, pro které stakeholdery je určen, jaké zájmy řeší, jaký má účel a úroveň a které prvky a vztahy obsahuje. Viewpointy jsou rozdělené do skupin: **Basic** (základní pohledy na Core vrstvy), **Motivation**, **Strategy** a **Implementation and Migration**.

*Příklad:* Capability Map (skupina Strategy) ukazuje schopnosti podniku; Migration (skupina Implementation and Migration) ukazuje posloupnost plateaus.

### ? Jaký status mají příkladové viewpointy ve specifikaci ArchiMate?

- [ ] Jsou povinné; každý model musí mít view pro každý z nich
- [x] Jsou doporučené vzory, které lze použít, upravit nebo nahradit
- [ ] Jsou závazné jen pro modely, které vznikají podle TOGAF ADM
- [ ] Jsou povinné pro Core vrstvy, jinde jen doporučené

> Příkladové viewpointy jsou ukázky dobré praxe, ne povinnost. Architekt je může převzít, kombinovat, upravit nebo definovat vlastní; žádná vazba na TOGAF ani na vrstvy jejich závaznost nemění.

### ? Do které skupiny příkladových viewpointů patří Capability Map?

- [ ] Basic
- [ ] Motivation
- [x] Strategy
- [ ] Implementation and Migration

> Capability Map zobrazuje schopnosti podniku, a patří proto do skupiny Strategy. Basic viewpointy pracují s Core vrstvami, Motivation s cíli a požadavky a Implementation and Migration s projekty a plateaus.

## Kategorie základních (Basic) viewpointů {#kategorie-basic .compare}

Basic viewpointy se dělí do čtyř kategorií podle toho, na jaký druh vazeb se dívají.

| Kategorie | Na co se dívá | Příklady viewpointů |
|---|---|---|
| **Composition** | z čeho se něco skládá, struktura | Organization, Application Structure, Information Structure, Technology, Layered, Physical |
| **Support** | jak jedny prvky podporují jiné | Product, Application Usage, Technology Usage |
| **Cooperation** | vzájemná spolupráce rovnocenných prvků | Business Process Cooperation, Application Cooperation |
| **Realization** | jak je něco uskutečněno prvky „pod ním" | Service Realization, Implementation and Deployment |

### ? Na co se zaměřují Basic viewpointy v kategorii Cooperation?

- [ ] Na skladbu jednoho prvku z jeho částí a podčástí
- [ ] Na to, jak služby realizují prvky nižších vrstev
- [x] Na vzájemnou spolupráci rovnocenných prvků
- [ ] Na motivaci stakeholderů a jejich cíle změny

> Cooperation viewpointy ukazují spolupráci prvků stejného druhu — procesů mezi sebou nebo aplikací mezi sebou. Skladba je Composition, realizace Realization a motivace patří do skupiny Motivation.

### ? Co mají společné viewpointy Application Usage a Technology Usage?

- [x] Ukazují, jak jedny prvky podporují jiné (Support)
- [ ] Ukazují posloupnost plateaus a rozdíly mezi nimi
- [ ] Ukazují jen vnitřní strukturu jedné aplikace či uzlu
- [ ] Ukazují cíle a požadavky stakeholderů na technologie

> Oba „usage" viewpointy patří do kategorie Support — jak aplikace podporují business, resp. jak technologie podporuje aplikace. Plateaus jsou doménou migračních viewpointů, vnitřní struktura kategorie Composition a cíle Motivation viewpointů.

## Organization viewpoint {#organization .term}

**Organization viewpoint** ukazuje **strukturu organizace**: Business Actors (podnik, útvary, oddělení), Business Roles, Business Collaborations, Locations a Business Interfaces. Často se kreslí vnořením (útvar uvnitř divize), podobně jako organigram. Je určen manažerům, procesním a enterprise architektům i zaměstnancům; řeší zájmy jako kompetence, pravomoci a odpovědnosti.

*Příklad:* `Obchodní divize (Business Actor) —composition→ Oddělení B2B (Business Actor) —assignment→ Key account manažer (Business Role)`

### ? Personální ředitel chce vidět útvary firmy, jejich role a pobočky, na kterých působí. Který příkladový viewpoint je nejvhodnější?

- [ ] Business Process Cooperation
- [ ] Application Usage
- [ ] Stakeholder
- [x] Organization

> Organization viewpoint zobrazuje Business Actors, Roles, Collaborations a Locations — tedy strukturu útvarů a jejich působení. Business Process Cooperation řeší návaznost procesů, Application Usage podporu aplikacemi a Stakeholder motivaci.

### ? Který prvek se v Organization viewpointu typicky NEOBJEVUJE?

- [ ] Business Role
- [x] Node
- [ ] Location
- [ ] Business Collaboration

> Node je prvek Technology Layer, který do pohledu na organizační strukturu nepatří. Business Role, Location a Business Collaboration jsou typickým obsahem Organization viewpointu.

## Application Structure × Information Structure {#struktura-aplikaci-dat .compare}

Oba viewpointy patří do kategorie Composition a ukazují strukturu — jeden aplikací, druhý informací.

| | Application Structure | Information Structure |
|---|---|---|
| Co ukazuje | skladbu aplikací: komponenty, jejich části, rozhraní a data, se kterými pracují | informační model: Business Objects, Data Objects, Artifacts a vztahy mezi nimi |
| Typické vztahy | composition, aggregation, assignment, access | specialization, aggregation, composition, realization |
| Pro koho | architekti aplikací a informačních systémů | informační a doménoví architekti |
| Řeší | strukturu aplikací, snížení složitosti | strukturu a závislosti dat, konzistenci informací |

### ? Datový architekt chce ukázat, jak se Business Object „Smlouva" realizuje Data Objects a jak je dále uložen v Artifacts. Který viewpoint zvolí?

- [x] Information Structure
- [ ] Application Structure
- [ ] Application Cooperation
- [ ] Implementation and Deployment

> Struktura a realizace informací napříč vrstvami (Business Object → Data Object → Artifact) je obsahem Information Structure. Application Structure se dívá na skladbu aplikací, Application Cooperation na toky mezi nimi a Implementation and Deployment na nasazení aplikací.

### ? Architekt chce rozložit aplikaci „ERP" na podkomponenty a jejich rozhraní. Který viewpoint je nejvhodnější?

- [ ] Information Structure
- [ ] Technology Usage
- [x] Application Structure
- [ ] Service Realization

> Vnitřní skladbu aplikace (komponenty, části, rozhraní) zobrazuje Application Structure. Information Structure se týká dat, Technology Usage technologické podpory a Service Realization realizace služeb.

## Technology × Physical viewpoint {#technology-physical .compare}

Oba viewpointy patří do kategorie Composition a popisují „spodní" vrstvy architektury.

| | Technology viewpoint | Physical viewpoint |
|---|---|---|
| Co ukazuje | IT infrastrukturu: Nodes, Devices, System Software, Communication Networks, Paths, technologické služby a rozhraní, Artifacts | fyzické prostředí: Equipment, Facilities, Distribution Networks, Material (a jejich vazby na Nodes a Devices) |
| Pro koho | infrastrukturní architekti, provoz IT | architekti a manažeři výroby, logistiky, provozu budov |
| Řeší | stabilitu, bezpečnost, závislosti a náklady infrastruktury | rozmístění zařízení, toky materiálu, fyzické kapacity |

### ? Vedoucí provozu IT chce vidět servery, systémový software a sítě, které je propojují. Který viewpoint je nejvhodnější?

- [ ] Physical
- [ ] Application Cooperation
- [ ] Organization
- [x] Technology

> IT infrastrukturu (Nodes, Devices, System Software, sítě) zobrazuje Technology viewpoint. Physical se týká výrobních zařízení a materiálu, Application Cooperation aplikací a Organization organizační struktury.

### ? Výrobní ředitel chce vidět výrobní linky, sklady a cesty, kterými mezi nimi putuje materiál. Který viewpoint je nejvhodnější?

- [ ] Technology
- [x] Physical
- [ ] Information Structure
- [ ] Product

> Equipment, Facility, Distribution Network a Material jsou obsahem Physical viewpointu. Technology se týká IT infrastruktury, Information Structure dat a Product nabídky zákazníkům.

## Layered viewpoint {#layered .term}

**Layered viewpoint** ukazuje **několik vrstev a aspektů v jednom pohledu** — typicky vrstvy nad sebou (zákazník, Business, Application, Technology) propojené službami, které nižší vrstva poskytuje vyšší. Smí obsahovat všechny prvky Core Framework a všechny vztahy, proto slouží jako **přehled**. Pomáhá enterprise a dalším architektům posoudit konzistenci a dopady změn napříč vrstvami.

*Příklad:* `Server (Node) —serving→ CRM (Application Component) —serving→ Prodej (Business Process) —realization→ Prodej pojištění (Business Service)`

### ? Architekt chce v jednom pohledu ukázat řetězec od služby pro zákazníka přes procesy a aplikace až po infrastrukturu. Který viewpoint je nejvhodnější?

- [x] Layered
- [ ] Application Structure
- [ ] Technology
- [ ] Organization

> Layered viewpoint spojuje více vrstev a aspektů do jednoho přehledu. Application Structure zůstává u skladby aplikací, Technology u infrastruktury a Organization u organizační struktury.

### ? Proč je Layered viewpoint vhodný pro posouzení dopadů změny?

- [ ] Ukazuje jen jednu vrstvu, a je proto snadno čitelný
- [ ] Zachycuje plán projektů a jejich termíny dokončení
- [x] Ukazuje vazby a závislosti napříč několika vrstvami
- [ ] Automaticky počítá náklady všech zobrazených prvků

> Díky vazbám mezi vrstvami je vidět, které procesy a služby zasáhne změna aplikace nebo infrastruktury. Layered nezůstává v jedné vrstvě, neplánuje projekty (to dělají I&M viewpointy) a nic nepočítá.

## Business Process Cooperation × Application Cooperation {#cooperation .compare}

Oba viewpointy ukazují **spolupráci rovnocenných prvků** — jednou procesů, podruhé aplikací.

| | Business Process Cooperation | Application Cooperation |
|---|---|---|
| Co ukazuje | vztahy business procesů mezi sebou a s okolím (návaznosti, toky, sdílené objekty, události) | vztahy aplikačních komponent: toky informací, služby, které si poskytují, rozhraní |
| Typické vztahy | triggering, flow, serving, access | flow, serving, realization, composition |
| Pro koho | procesní a doménoví architekti, provozní manažeři | architekti aplikací a integrací, enterprise architekti |
| Řeší | závislosti mezi procesy, odpovědnosti, konzistenci | aplikační krajinu, integrace, závislosti aplikací |

### ? Integrační architekt chce mapu aplikací firmy a informačních toků mezi nimi. Který viewpoint je nejvhodnější?

- [ ] Business Process Cooperation
- [ ] Application Usage
- [ ] Information Structure
- [x] Application Cooperation

> Vzájemné vztahy a toky informací mezi aplikačními komponentami zobrazuje Application Cooperation. Business Process Cooperation se týká procesů, Application Usage podpory procesů aplikacemi a Information Structure struktury dat.

### ? Procesní architekt chce ukázat, jak na sebe navazují hlavní procesy objednávky, výroby a fakturace a co si předávají. Který viewpoint je nejvhodnější?

- [ ] Application Cooperation
- [x] Business Process Cooperation
- [ ] Service Realization
- [ ] Organization

> Návaznosti a předávání mezi business procesy jsou obsahem Business Process Cooperation. Application Cooperation se týká aplikací, Service Realization realizace služby procesy a Organization struktury útvarů.

## Product viewpoint {#product .term}

**Product viewpoint** ukazuje **hodnotu, kterou produkt nabízí zákazníkům** nebo jiným externím stranám, a z čeho se produkt skládá: Product, jeho business (i aplikační či technologické) služby, Contract, Value, případně rozhraní, kterými se nabízí, a role, které ho využívají. Je určen produktovým manažerům a vývojářům produktů, procesním a doménovým architektům.

*Příklad:* `Cestovní pojištění (Product) —aggregation→ Asistenční služba (Business Service)`; `Cestovní pojištění (Product) —aggregation→ Pojistné podmínky (Contract)`

### ? Produktový manažer pojišťovny chce ukázat, ze kterých služeb a smluvních podmínek se skládá nový produkt a jakou hodnotu přináší klientovi. Který viewpoint je nejvhodnější?

- [x] Product
- [ ] Service Realization
- [ ] Capability Map
- [ ] Organization

> Skladbu produktu ze služeb a smluv a jeho hodnotu pro zákazníka zobrazuje Product viewpoint. Service Realization ukazuje, jak se služba uskutečňuje procesy, Capability Map schopnosti podniku a Organization strukturu útvarů.

### ? Který prvek je pro Product viewpoint typický?

- [ ] Path
- [ ] Equipment
- [x] Contract
- [ ] Plateau

> Produkt se typicky skládá ze služeb a smlouvy (Contract), která upravuje podmínky. Path a Equipment patří do technologie a fyzického prostředí, Plateau do migrace.

## Application Usage × Technology Usage {#usage .compare}

Oba viewpointy patří do kategorie Support — ukazují, **kdo koho podporuje**.

| | Application Usage | Technology Usage |
|---|---|---|
| Co ukazuje | jak aplikace (komponenty, služby, rozhraní) podporují business procesy, funkce a role | jak technologie (uzly, systémový software, technologické služby) podporuje aplikace |
| Typická vazba | Application Service —serving→ Business Process | Technology Service —serving→ Application Component |
| Pro koho | procesní a aplikační architekti, provozní manažeři | aplikační a infrastrukturní architekti, provoz |
| Řeší | konzistenci a úplnost podpory procesů | závislosti, výkon, škálovatelnost |

### ? Vlastník procesu „Vyřízení reklamace" chce vědět, které aplikační služby jeho proces používá. Který viewpoint je nejvhodnější?

- [ ] Technology Usage
- [x] Application Usage
- [ ] Application Structure
- [ ] Business Process Cooperation

> Podporu business procesů aplikacemi zobrazuje Application Usage. Technology Usage ukazuje podporu aplikací technologií, Application Structure skladbu aplikací a Business Process Cooperation návaznost procesů.

### ? Provozní manažer řeší výkon a chce vidět, na kterých technologických službách a uzlech závisí aplikace „E-shop". Který viewpoint je nejvhodnější?

- [ ] Application Usage
- [ ] Physical
- [ ] Application Cooperation
- [x] Technology Usage

> Závislost aplikací na technologii (služby, uzly) zobrazuje Technology Usage. Application Usage se dívá o vrstvu výš na procesy, Physical na fyzická zařízení a Application Cooperation na vztahy mezi aplikacemi.

## Service Realization × Implementation and Deployment {#realization-vp .compare}

Oba viewpointy patří do kategorie Realization — ukazují, **jak je něco uskutečněno**.

| | Service Realization | Implementation and Deployment |
|---|---|---|
| Co ukazuje | jak jsou business služby realizovány procesy (případně s podporou aplikací) | jak jsou aplikace a data mapovány na Artifacts a nasazeny na infrastrukturu |
| Typické vztahy | Business Process —realization→ Business Service | Artifact —realization→ Application Component, System Software —assignment→ Artifact |
| Pro koho | procesní a doménoví architekti, produktoví a provozní manažeři | aplikační a doménoví architekti |
| Pozor | — | nezaměňovat s viewpointem Implementation and Migration (projekty a plateaus) |

### ? Architekt chce ukázat, které procesy a aplikace stojí za službou „Vyřízení pojistné události". Který viewpoint je nejvhodnější?

- [x] Service Realization
- [ ] Implementation and Deployment
- [ ] Product
- [ ] Goal Realization

> Uskutečnění služby procesy a aplikacemi zobrazuje Service Realization. Implementation and Deployment řeší nasazení aplikací na infrastrukturu, Product skladbu produktu a Goal Realization zjemnění cílů.

### ? Architekt chce ukázat, ve kterých souborech je aplikace „Fakturace" nasazena a na kterém systémovém softwaru běží. Který viewpoint je nejvhodnější?

- [ ] Implementation and Migration
- [ ] Service Realization
- [x] Implementation and Deployment
- [ ] Application Structure

> Mapování aplikace na Artifacts a jejich nasazení na System Software je obsahem Implementation and Deployment. Implementation and Migration se týká projektů a plateaus, Service Realization služeb a Application Structure vnitřní skladby aplikací.

## Motivation viewpointy {#motivation-vp .compare}

Skupina Motivation pracuje s prvky motivace (Stakeholder, Driver, Assessment, Goal, Outcome, Principle, Requirement, Constraint).

| Viewpoint | Co ukazuje |
|---|---|
| **Stakeholder** | stakeholdery, jejich vnitřní a vnější drivery, hodnocení (assessments, např. SWOT) a první cíle |
| **Goal Realization** | zjemnění obecných cílů na konkrétnější cíle a dále na outcomes, principy a požadavky |
| **Requirements Realization** | jak jsou požadavky realizovány prvky architektury (procesy, služby, aplikace…) |
| **Motivation** | ucelený nebo dílčí pohled na celý motivační aspekt a vztahy mezi jeho prvky |

### ? Analytik chce ukázat, které aplikace a procesy splňují požadavek „Klient podepíše smlouvu online". Který viewpoint je nejvhodnější?

- [ ] Stakeholder
- [ ] Goal Realization
- [x] Requirements Realization
- [ ] Application Usage

> Realizaci požadavků prvky architektury zobrazuje Requirements Realization. Stakeholder ukazuje drivery a hodnocení, Goal Realization zjemnění cílů a Application Usage podporu procesů aplikacemi bez vazby na požadavky.

### ? Architekt chce na začátku iniciativy ukázat stakeholdery, jejich drivery a výsledky SWOT hodnocení. Který viewpoint je nejvhodnější?

- [x] Stakeholder
- [ ] Requirements Realization
- [ ] Strategy
- [ ] Organization

> Stakeholdery, drivery a assessments (např. SWOT) zobrazuje Stakeholder viewpoint. Requirements Realization se týká plnění požadavků, Strategy strategických prvků a Organization organizační struktury.

## Strategy viewpointy {#strategy-vp .compare}

Skupina Strategy pracuje s prvky Capability, Resource, Value Stream, Course of Action a jejich vazbou na outcomes.

| Viewpoint | Co ukazuje |
|---|---|
| **Strategy** | přehled strategie: courses of action, schopnosti, toky hodnoty, zdroje a zamýšlené výsledky |
| **Capability Map** | strukturovaný přehled schopností podniku (obvykle ve dvou až třech úrovních), často jako „heat map" |
| **Value Stream** | fáze toku hodnoty, schopnosti, které je podporují, a stakeholdery, kteří hodnotu získávají |
| **Outcome Realization** | jak k výsledkům (outcomes) přispívají schopnosti a prvky architektury |
| **Resource Map** | strukturovaný přehled zdrojů podniku a jejich vazby na schopnosti |

### ? Ředitel strategie chce strukturovaný přehled schopností firmy ve dvou úrovních, obarvený podle jejich vyspělosti. Který viewpoint je nejvhodnější?

- [ ] Value Stream
- [ ] Resource Map
- [ ] Goal Realization
- [x] Capability Map

> Strukturovaný přehled schopností, často jako heat map, je Capability Map. Value Stream ukazuje fáze toku hodnoty, Resource Map zdroje a Goal Realization zjemnění cílů.

### ? Architekt chce ukázat fáze, kterými zákazník prochází od zájmu o hypotéku po její čerpání, a které schopnosti jednotlivé fáze podporují. Který viewpoint je nejvhodnější?

- [ ] Capability Map
- [x] Value Stream
- [ ] Business Process Cooperation
- [ ] Outcome Realization

> Fáze toku hodnoty a podpůrné schopnosti zobrazuje Value Stream viewpoint. Capability Map ukazuje schopnosti bez fází toku hodnoty, Business Process Cooperation návaznost konkrétních procesů a Outcome Realization přínos k výsledkům.

## Implementation and Migration viewpointy {#im-vp .compare}

Tři viewpointy pro plánování a řízení změny (prvky I&M popisuje téma Implementation & Migration).

| Viewpoint | Co ukazuje | Typičtí stakeholdeři |
|---|---|---|
| **Project** | řízení změny: Work Packages, Deliverables, odpovědné role a aktéry | manažeři projektů a programů, architekti |
| **Migration** | přechody mezi stavy architektury: Plateaus a Gaps | enterprise a další architekti |
| **Implementation and Migration** | vazbu programů a projektů na části architektury, které realizují (Work Packages, Deliverables, Plateaus a Core prvky) | programoví a projektoví manažeři, enterprise architekti |

### ? Architekt chce ukázat posloupnost stavů architektury od výchozího přes přechodový k cílovému a rozdíly mezi nimi. Který viewpoint je nejvhodnější?

- [ ] Project
- [ ] Layered
- [x] Migration
- [ ] Implementation and Deployment

> Plateaus a Gaps mezi nimi jsou obsahem Migration viewpointu. Project ukazuje práci a výsledky, Layered vrstvy jednoho stavu a Implementation and Deployment nasazení aplikací.

### ? Programový manažer chce vidět, které projekty realizují které aplikace a k jakému cílovému stavu přispívají. Který viewpoint je nejvhodnější?

- [x] Implementation and Migration
- [ ] Implementation and Deployment
- [ ] Migration
- [ ] Application Cooperation

> Propojení projektů a jejich výsledků s prvky architektury a plateaus je obsahem Implementation and Migration. Implementation and Deployment řeší nasazení softwaru, Migration jen stavy a rozdíly a Application Cooperation vztahy aplikací.

### ? Který obsah je typický pro Project viewpoint?

- [ ] Plateaus a Gaps mezi výchozím a cílovým stavem
- [ ] Nodes, System Software a nasazené Artifacts
- [ ] Stakeholdery, drivery a výsledky hodnocení
- [x] Work Packages, Deliverables a odpovědné role

> Project viewpoint slouží řízení změny — ukazuje práci, její výsledky a kdo za ni odpovídá. Plateaus a Gaps patří do Migration, infrastruktura do Technology a stakeholdeři s drivery do Stakeholder viewpointu.

## Výběr viewpointu pro stakeholdera {#vyber-viewpointu .explain}

Výběr viewpointu začíná u čtenáře, ne u modelu: (1) určit **stakeholdera** a jeho **zájmy (concerns)** — na co potřebuje odpověď; (2) určit **účel** (Designing, Deciding, Informing) a **úroveň** (Details, Coherence, Overview); (3) najít vhodný příkladový viewpoint, a pokud žádný nesedí, **upravit ho nebo definovat vlastní**; (4) do view zahrnout jen to, co k odpovědi potřebuje — jeden view má mít jeden hlavní „příběh". Přeplněný view se všemi prvky modelu nikomu neslouží.

*Příklad:* CFO se ptá, kolik stojí podpora prodeje IT → stakeholder CFO, zájem náklady, účel Deciding, úroveň Coherence → upravený Application Usage s náklady aplikací v tabulce.

### ? Čím má architekt začít při výběru viewpointu?

- [ ] Výběrem nejpodrobnějšího viewpointu v modelu
- [x] Určením stakeholdera a zájmů, na které hledá odpověď
- [ ] Zobrazením všech prvků modelu, aby nic nechybělo
- [ ] Výběrem barev a tvarů firemních prezentací

> Viewpoint se volí podle stakeholdera a jeho zájmů; teprve z nich plyne účel, úroveň a obsah. Nejpodrobnější nebo úplný view zahltí čtenáře a barvy jsou až otázkou reprezentace.

### ? Žádný příkladový viewpoint přesně neodpovídá potřebě stakeholdera. Jaký postup je v souladu s ArchiMate?

- [ ] Použít Layered viewpoint, který smí obsahovat celý Core Framework
- [ ] Vynechat view a předat stakeholderovi celý model k prohlédnutí
- [x] Upravit příkladový viewpoint nebo definovat vlastní pro jeho zájmy
- [ ] Zvolit nejbližší viewpoint beze změn, protože úpravy nejsou dovoleny

> Viewpoint Mechanism počítá s úpravou příkladových viewpointů i s definicí vlastních. Univerzální Layered view ani celý model zájmy konkrétního stakeholdera neřeší a úpravy viewpointů dovoleny jsou.

## Přizpůsobení jazyka {#prizpusobeni-jazyka .explain}

ArchiMate záměrně obsahuje jen **obecné pojmy** použitelné v libovolném odvětví — jazyk tak zůstává malý a srozumitelný. Pro potřeby konkrétní organizace, odvětví nebo analýzy jej lze přizpůsobit dvěma mechanismy: **přidáním atributů** k typům prvků a vztahů (**profily**) a **specializací** prvků a vztahů (nové podtypy). Přizpůsobení nemění význam ani pravidla základního jazyka; specializovaný prvek se pořád chová jako svůj obecný typ. Přizpůsobovat se má s mírou — každé rozšíření musí ostatní uživatelé modelu pochopit.

*Příklad:* pojišťovna přidá k Application Component atributy „roční náklady" a „vlastník" (profil) a zavede podtyp „Microservice" (specializace Application Component).

### ? Které dva mechanismy přizpůsobení jazyka ArchiMate nabízí?

- [ ] Přidání nových vrstev a definici vlastních typů vztahů
- [x] Profily s atributy a specializaci prvků a vztahů
- [ ] Import stereotypů z UML a převzetí notace z BPMN
- [ ] Volbu vlastních barev a změnu tvarů všech prvků

> ArchiMate se přizpůsobuje profily (atributy navíc) a specializací pojmů. Nové vrstvy ani nové typy vztahů mimo specializaci jazyk nedefinuje, stereotypy UML nepřebírá a barvy nejsou normativní.

### ? Proč ArchiMate obsahuje jen obecné pojmy a odvětvové detaily nechává na přizpůsobení?

- [ ] Protože odvětvové pojmy definuje až certifikační zkouška
- [ ] Protože podrobné pojmy jsou vyhrazeny pro TOGAF ADM
- [ ] Protože modely se mají kreslit výhradně na úrovni Overview
- [x] Aby jazyk zůstal malý, srozumitelný a použitelný všude

> Malý obecný jazyk je snazší naučit a použít v libovolném odvětví; specifika se doplní profily a specializací. Certifikace, TOGAF ani úroveň Overview s tímto návrhovým rozhodnutím nesouvisí.

## Profil (Profile) {#profil .term}

**Profil** je pojmenovaná sada **atributů** (vlastností s datovým typem), kterou lze připojit k typu prvku nebo vztahu — např. profil „Náklady" s atributy roční náklad a měna pro Application Component a Node. Profily se definují odděleně od samotného jazyka a k prvkům se přiřazují podle potřeby. Umožňují do modelu uložit údaje pro analýzy (náklady, rizika, výkon, vlastnictví) a z nich pak sestavit například tabulková views nebo heat mapy.

*Příklad:* `CRM (Application Component)` s profilem „Náklady": roční náklad = 1 200 000, měna = CZK.

### ? Architekt chce u každé Application Component evidovat roční náklady na licence a jméno vlastníka. Který mechanismus použije?

- [x] Profil s atributy připojený k Application Component
- [ ] Specialization relationship mezi aplikacemi a vlastníky
- [ ] Grouping, do kterého vloží všechny drahé aplikace
- [ ] Nový typ vztahu „vlastní" mezi aktérem a aplikací

> Doplňkové vlastnosti prvků se do modelu přidávají profily s atributy. Specialization relationship vyjadřuje obecné × zvláštní, Grouping seskupení a nové typy vztahů jazyk nepřipouští.

### ? Co je v ArchiMate profil?

- [ ] Podtyp prvku se stejnou notací, např. „Microservice"
- [ ] Hledisko určené pro konkrétní skupinu stakeholderů a jejich zájmy
- [x] Pojmenovaná sada atributů připojitelná k typům prvků či vztahů
- [ ] Popis role uživatele v nástroji pro modelování architektury

> Profil přidává k typům prvků a vztahů atributy (např. náklady, vlastník). Podtyp prvku je specializace, hledisko pro stakeholdery je viewpoint a role v nástroji s jazykem nesouvisí.

## Specializace (Specialization) prvků a vztahů {#specializace .term}

**Specializace** vytváří z existujícího typu prvku nebo vztahu **nový podtyp** pro konkrétní potřebu — např. z Application Component „Microservice", z Node „Databázový server", z Business Actor „Pobočka". Podtyp **dědí** význam i povolené vztahy obecného typu a nesmí přidat vztah, který obecný typ povolený nemá. Zobrazuje se stejnou notací jako obecný typ, volitelně s názvem podtypu v lomených uvozovkách (např. «Microservice») nebo s vlastní ikonou. Ke specializaci lze připojit i profil s atributy.

*Příklad:* `Platby «Microservice» (Application Component) —serving→ Objednávky «Microservice» (Application Component)`

### ? Jak se standardně zobrazí prvek specializovaného typu „Microservice" odvozeného od Application Component?

- [ ] Zcela novým tvarem, který musí být definován ve specifikaci
- [x] Stejnou notací jako Application Component, se «Microservice»
- [ ] Notací Node, protože mikroslužby vždy běží na infrastruktuře
- [ ] Prvkem Grouping s názvem „Microservice" a vnořenou komponentou

> Specializace přebírá notaci obecného typu; podtyp lze odlišit názvem v lomených uvozovkách nebo vlastní ikonou. Nový tvar ve specifikaci není potřeba, Node je jiný typ a Grouping by specializaci nevyjádřil.

### ? Může specializovaný typ „Microservice" (od Application Component) mít vztah, který Application Component povolený nemá?

- [ ] Ano, specializace je právě způsob, jak rozšířit povolené vztahy
- [ ] Ano, pokud je nový vztah popsán v profilu daného podtypu
- [ ] Ne, specializovaný typ nesmí mít vůbec žádné vztahy
- [x] Ne, podtyp dědí povolené vztahy a nesmí přidávat nové

> Specializace zužuje význam, ale nerozšiřuje pravidla jazyka — podtyp smí jen vztahy povolené obecnému typu. Profil přidává atributy, ne vztahy, a podtyp samozřejmě vztahy obecného typu mít smí.

## Profil × specializace × Specialization relationship {#profil-specializace-vztah .compare}

Tři pojmy, které se snadno pletou — dva jsou přizpůsobením jazyka, třetí je obyčejný vztah v modelu.

| | Profil | Specializace typu | Specialization relationship |
|---|---|---|---|
| Úroveň | jazyk (rozšíření typů) | jazyk (nový podtyp) | model (vztah mezi dvěma prvky) |
| Co přidává | atributy k prvkům/vztahům | nový podtyp se zděděnou notací a vztahy | tvrzení „prvek A je zvláštním případem prvku B" |
| Příklad | „Náklady" s atributem roční náklad | Application Component → «Microservice» | `Online objednávka (Business Process) —specialization→ Objednávka (Business Process)` |
| Notace | žádná vlastní, atributy jsou v nástroji | jako obecný typ, volitelně «název» či ikona | plná čára s prázdným trojúhelníkem u obecnějšího prvku |

### ? Model obsahuje `Online objednávka (Business Process) —specialization→ Objednávka (Business Process)`. Co tento zápis vyjadřuje?

- [x] V modelu je online objednávka zvláštním případem procesu Objednávka
- [ ] V jazyce vzniká nový typ prvku „Online objednávka" pro všechny modely
- [ ] Proces Objednávka dostává nové atributy převzaté z online objednávky
- [ ] Online objednávka je součástí procesu Objednávka a bez něj neexistuje

> Specialization relationship spojuje dva prvky v modelu a říká, že jeden je zvláštním případem druhého. Nový typ by vznikl specializací v rámci přizpůsobení jazyka, atributy přidává profil a část celku vyjadřuje composition.

### ? Firma chce u všech mikroslužeb evidovat stejné atributy a odlišit je od ostatních aplikačních komponent vlastním označením. Jaké řešení je nejvhodnější?

- [ ] Jen Specialization relationship od každé mikroslužby k prvku „Aplikace"
- [ ] Grouping „Mikroslužby", do kterého se všechny komponenty vloží
- [x] Specializace „Microservice" od Application Component s profilem
- [ ] Nová vrstva „Microservice Layer" s vlastními typy prvků a vztahů

> Nový podtyp s vlastním označením vznikne specializací a společné atributy k němu připojí profil. Specialization relationship ani Grouping nový typ ani atributy nezavádějí a nové vrstvy jazyk přizpůsobením nepřipouští.
