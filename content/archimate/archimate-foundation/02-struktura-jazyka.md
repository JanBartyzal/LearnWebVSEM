---
kind: topic
subject: archimate-foundation
slug: struktura-jazyka
name: "Struktura jazyka a generický metamodel"
order: 2
---

Vrstvy (Strategy, Business, Application, Technology, Physical, Implementation & Migration) a aspekty (Active Structure, Behavior, Passive Structure, Motivation); interní × externí prvky; Core × Full Framework.

## Vrstvy jazyka (Layers) {#vrstvy .term}

ArchiMate 3.2 třídí prvky do **vrstev**: **Strategy**, **Business**, **Application**, **Technology**, **Physical** a **Implementation & Migration**. Jádro tvoří Business, Application a Technology Layer; mezi nimi platí, že nižší vrstva typicky **poskytuje služby** vyšší (technologie slouží aplikacím, aplikace byznysu). Prvky **Motivation** nejsou samostatnou vrstvou, ale **aspektem**, který vysvětluje důvody architektury napříč vrstvami.

### ? Která z položek NENÍ vrstvou jazyka ArchiMate 3.2?

- [ ] Strategy
- [ ] Physical
- [x] Data
- [ ] Implementation & Migration

> ArchiMate nemá samostatnou datovou vrstvu — data se modelují pasivními prvky (Business Object, Data Object, Artifact) v ostatních vrstvách. Strategy, Physical i Implementation & Migration vrstvami jsou.

### ? Jakým směrem typicky směřují služby mezi jádrovými vrstvami Business, Application a Technology?

- [x] Technologie slouží aplikacím a aplikace slouží byznysu
- [ ] Byznys slouží aplikacím a aplikace slouží technologii
- [ ] Aplikace slouží technologii i byznysu stejnou měrou
- [ ] Mezi vrstvami služby nevedou, každá stojí samostatně

> Nižší vrstva poskytuje služby vyšší: technologické služby podporují aplikace a aplikační služby podporují business procesy a role. Opačný směr není typický a vrstvy jsou právě službami propojené.

## Business Layer {#business-layer .term}

**Business Layer** popisuje byznys podniku: **kdo** v něm jedná (Business Actor, Business Role, Business Collaboration), **co dělá** (Business Process, Business Function, Business Interaction, Business Event), jaké **služby** nabízí zákazníkům a partnerům (Business Service, přes Business Interface) a s jakými **informacemi** pracuje (Business Object, Contract, Representation). Patří sem i kompozitní prvek **Product**. Jednotlivé prvky podrobně rozebírá téma Business Layer.

### ? Který prvek patří do Business Layer?

- [ ] Application Component
- [ ] Work Package
- [ ] Node
- [x] Business Role

> Business Role je prvek aktivní struktury v Business Layer. Application Component patří do Application Layer, Node do Technology Layer a Work Package do Implementation & Migration.

### ? Co popisuje Business Layer?

- [ ] Softwarové komponenty a datové objekty, se kterými pracují
- [x] Služby nabízené zákazníkům a aktéry a procesy, kteří je zajišťují
- [ ] Servery, sítě a systémový software, na nichž běží aplikace
- [ ] Projekty a mezistavy, kterými podnik přechází k cílovému stavu

> Business Layer zachycuje byznys: aktéry, role, procesy, funkce, business služby a business objekty. Software popisuje Application Layer, infrastrukturu Technology Layer a projekty s mezistavy Implementation & Migration.

## Application Layer {#application-layer .term}

**Application Layer** popisuje **softwarové aplikace** a to, jak podporují byznys: aplikační komponenty a jejich spolupráce (Application Component, Application Collaboration), rozhraní (Application Interface), chování (Application Function, Application Process, Application Interaction, Application Event), **aplikační služby** (Application Service) a **data** (Data Object). Prvky podrobně rozebírá téma Application Layer.

### ? Do které vrstvy patří prvek Data Object?

- [ ] Business Layer
- [ ] Technology Layer
- [ ] Strategy Layer
- [x] Application Layer

> Data Object je pasivní prvek Application Layer — data, se kterými pracují aplikace. Byznysovým protějškem je Business Object, technologickým (fyzickým souborem) Artifact.

### ? Co popisuje Application Layer?

- [x] Aplikace, jejich funkce, služby a data, která podporují byznys
- [ ] Organizační jednotky, role a jejich odpovědnosti v podniku
- [ ] Hardwarová zařízení a síťová spojení mezi datovými centry
- [ ] Schopnosti podniku a strategické kroky k jejich rozvoji

> Application Layer zachycuje software: komponenty, rozhraní, aplikační chování, aplikační služby a data. Organizaci popisuje Business Layer, hardware Technology Layer a schopnosti se strategickými kroky Strategy.

## Technology Layer {#technology-layer .term}

**Technology Layer** popisuje **infrastrukturu**, na které aplikace běží: výpočetní a úložné prostředky (Node, Device, System Software), jejich spolupráci a rozhraní (Technology Collaboration, Technology Interface), spojení (Path, Communication Network), technologické chování a **technologické služby** (zpracování, ukládání, komunikace) a **Artifact** — fyzický soubor, například spustitelný program, skript či databázový soubor. Prvky podrobně rozebírá téma Technology Layer.

### ? Který prvek patří do Technology Layer?

- [ ] Business Object
- [x] System Software
- [ ] Application Interface
- [ ] Plateau

> System Software (operační systém, databázový systém, middleware) je prvek Technology Layer. Business Object patří do Business Layer, Application Interface do Application Layer a Plateau do Implementation & Migration.

### ? Do které vrstvy patří prvek Artifact, například soubor objednavky.jar?

- [ ] Application Layer
- [ ] Physical
- [x] Technology Layer
- [ ] Business Layer

> Artifact je pasivní prvek Technology Layer — fyzický soubor nasazovaný na infrastrukturu. Aplikační komponenta, kterou realizuje, patří do Application Layer; fyzické prvky (Physical) popisují stroje, zařízení a materiál, ne soubory.

## Fyzické prvky (Physical) {#physical .term}

**Physical** prvky rozšiřují Technology Layer o **fyzický svět**: **Equipment** (stroje, výrobní linky, vozidla), **Facility** (továrna, sklad, datové centrum jako fyzické zařízení), **Distribution Network** (železnice, potrubí, rozvodná síť) a **Material** (suroviny, palivo, díly). Hodí se pro výrobu, logistiku, energetiku či IoT — tam, kde vedle informací proudí i hmota a energie.

### ? Výrobní firma chce v architektuře zachytit výrobní linky, sklad hotových výrobků a dodávky surovin. Které prvky k tomu použije?

- [ ] Prvky Business Layer, zejména Business Object a Contract
- [ ] Prvky Implementation & Migration, zejména Deliverable
- [x] Fyzické prvky, zejména Equipment, Facility a Material
- [ ] Prvky Application Layer, zejména Data Object a Artifact

> Výrobní linky (Equipment), sklad (Facility) a suroviny (Material) jsou typické fyzické prvky. Business Object a Data Object popisují informace, Deliverable výstup projektu a Artifact soubor.

### ? Který prvek NEPATŘÍ mezi fyzické prvky (Physical)?

- [ ] Equipment
- [ ] Facility
- [x] Device
- [ ] Material

> Device je prvek Technology Layer (hardware, na kterém běží software). Fyzickými prvky jsou Equipment, Facility, Distribution Network a Material.

## Strategy, Motivation a Implementation & Migration {#rozsirujici-casti .compare}

Kromě jádra má jazyk tři části, které odpovídají na jiné otázky než „jak podnik funguje":

| Část | Na co odpovídá | Příklady prvků |
|---|---|---|
| Strategy | co podnik umí a jak chce svou strategii naplnit | Capability, Resource, Value Stream, Course of Action |
| Motivation (aspekt) | proč — důvody, cíle a požadavky | Stakeholder, Driver, Goal, Principle, Requirement |
| Implementation & Migration | jak a kdy se změna uskuteční | Work Package, Deliverable, Implementation Event, Plateau, Gap |

Prvky všech tří částí podrobně rozebírají samostatná témata.

### ? Který prvek patří do vrstvy Strategy?

- [ ] Goal
- [x] Capability
- [ ] Work Package
- [ ] Business Function

> Capability (schopnost podniku) je prvek Strategy. Goal patří do Motivation, Work Package do Implementation & Migration a Business Function do Business Layer.

### ? Architekt chce zachytit, PROČ podnik architekturu mění — hybatele změny, cíle a požadavky. Které prvky použije?

- [ ] Prvky Implementation & Migration
- [ ] Prvky Strategy
- [ ] Prvky Physical
- [x] Prvky Motivation

> Důvody architektury (Driver, Goal, Requirement…) vyjadřuje aspekt Motivation. Strategy popisuje schopnosti a strategické kroky, Implementation & Migration realizaci změny v čase a Physical fyzický svět.

### ? Která dvojice prvků patří do Implementation & Migration?

- [x] Work Package a Plateau
- [ ] Capability a Resource
- [ ] Driver a Assessment
- [ ] Equipment a Material

> Work Package (realizační práce) a Plateau (stabilní stav architektury v čase) jsou prvky Implementation & Migration. Capability a Resource patří do Strategy, Driver a Assessment do Motivation, Equipment a Material mezi fyzické prvky.

## Aspekty (Aspects) {#aspekty .term}

**Aspekty** třídí prvky podle toho, jakou otázku o podniku zodpovídají, a procházejí napříč vrstvami: **Active Structure** (aktivní struktura — kdo nebo co jedná), **Behavior** (chování — co se děje), **Passive Structure** (pasivní struktura — s čím se pracuje) a **Motivation** (proč). Některé prvky, například kompozitní Product, mohou spojovat více aspektů.

### ? Který aspekt odpovídá na otázku „proč" architektura vypadá tak, jak vypadá?

- [ ] Active Structure
- [ ] Behavior
- [x] Motivation
- [ ] Passive Structure

> Motivation zachycuje důvody — hybatele, cíle, principy a požadavky. Active Structure odpovídá na „kdo", Behavior na „co se děje" a Passive Structure na „s čím se pracuje".

### ? Do kterého aspektu patří prvek Business Process?

- [x] Behavior
- [ ] Active Structure
- [ ] Passive Structure
- [ ] Motivation

> Proces je chování (Behavior) — sled činností, které někdo vykonává. Kdo ho vykonává, je aktivní struktura (např. Business Role), s čím pracuje, je pasivní struktura (Business Object).

## Aktivní struktura (Active Structure) {#active-structure .term}

Prvky **aktivní struktury** jsou ty, které **mohou vykonávat chování** — „subjekty" architektury. V každé vrstvě mají svůj protějšek: Business Actor a Business Role, Application Component, Node, Device či System Software; patří sem i rozhraní (interface) jako externí aktivní struktura. Chování se k nim váže vztahem **assignment**.

### ? Který prvek patří do aktivní struktury?

- [ ] Business Object
- [ ] Application Service
- [ ] Business Event
- [x] Application Component

> Application Component je prvek aktivní struktury — vykonává aplikační chování. Business Object je pasivní struktura, Application Service a Business Event jsou chování.

### ? Čím se vyznačuje prvek aktivní struktury?

- [ ] Je to objekt, který chování čte, mění nebo vytváří
- [x] Může vykonávat chování, které je k němu přiřazeno
- [ ] Popisuje okamžitou změnu stavu, která něco spustí
- [ ] Vyjadřuje důvod nebo cíl, kvůli němuž změna vzniká

> Aktivní struktura chování vykonává (vztah assignment). Objekt, se kterým chování pracuje, je pasivní struktura, změna stavu je event a důvody či cíle patří do Motivation.

## Chování (Behavior) {#behavior .term}

Prvky **chování** vyjadřují **dynamiku** podniku — činnosti, které se v něm odehrávají. Patří sem procesy, funkce a interakce (interní chování), služby (externí chování) a události (event). Chování samo nic „nevlastní" — vždy ho **vykonává** nějaký prvek aktivní struktury a často při tom pracuje s pasivní strukturou.

### ? Který prvek patří do aspektu Behavior?

- [ ] Node
- [ ] Artifact
- [x] Technology Service
- [ ] Technology Interface

> Technology Service je externí chování Technology Layer. Node je aktivní struktura, Technology Interface externí aktivní struktura a Artifact pasivní struktura.

### ? Který výrok o prvcích chování je správný?

- [ ] Chování je samostatný subjekt, který žádnou aktivní strukturu nepotřebuje
- [ ] Chování patří jen do Business Layer, v ostatních vrstvách se nemodeluje
- [ ] Chování je pasivní objekt, se kterým aktivní prvky pouze pracují
- [x] Chování vykonávají prvky aktivní struktury a může pracovat s pasivními

> Chování je vždy něčí činnost: vykonává ho aktivní struktura (assignment) a může číst či měnit pasivní objekty (access). Chování existuje ve všech jádrových vrstvách a samo pasivním objektem není.

## Pasivní struktura (Passive Structure) {#passive-structure .term}

Prvky **pasivní struktury** jsou **objekty, se kterými chování pracuje** — čte je, vytváří nebo mění; samy nic nevykonávají. Příklady: Business Object, Contract a Representation v Business Layer, Data Object v Application Layer, Artifact v Technology Layer (a Material mezi fyzickými prvky). Chování se k nim váže vztahem **access**.

### ? Který prvek představuje pasivní strukturu?

- [ ] Application Function
- [x] Data Object
- [ ] Application Interface
- [ ] Application Collaboration

> Data Object je pasivní struktura — data, se kterými aplikace pracuje. Application Function je chování, Application Interface a Application Collaboration jsou aktivní struktura.

### ? Proč NELZE modelovat, že Faktura (Business Object) vykonává proces Schválení platby (Business Process)?

- [ ] Business Object smí pracovat jen s procesy v Application Layer
- [ ] Proces smí vykonávat jen Business Actor, nikdy ne Business Role
- [ ] Faktura by musela být modelována jako Contract, ne jako objekt
- [x] Pasivní struktura chování nevykonává, chování s ní jen pracuje

> Pasivní prvky jsou předmětem činnosti, ne jejím vykonavatelem; proces ji vykonává aktivní struktura (např. Business Role) a k faktuře přistupuje vztahem access. Contract je také pasivní a proces může vykonávat i role.

## ArchiMate Framework {#framework .explain}

**ArchiMate Framework** je matice, která třídí typy prvků: **řádky jsou vrstvy**, **sloupce jsou aspekty**. Každá buňka obsahuje typy prvků dané vrstvy a aspektu. Jádro (Core Framework) tvoří 3 × 3 buňky — Business, Application, Technology × Active Structure, Behavior, Passive Structure; úplný rámec (Full Framework) přidává řádky Strategy, Physical a Implementation & Migration a sloupec Motivation. Rámec slouží k orientaci a klasifikaci; pohled smí prvky z různých buněk libovolně kombinovat.

*Příklad:* Buňka Application × Behavior obsahuje Application Process, Application Function, Application Interaction, Application Event a Application Service; buňka Technology × Passive Structure obsahuje Artifact.

### ? Co tvoří řádky a sloupce matice ArchiMate Framework?

- [ ] Řádky tvoří viewpointy, sloupce stakeholdeři
- [ ] Řádky tvoří fáze ADM, sloupce vrstvy jazyka
- [x] Řádky tvoří vrstvy, sloupce aspekty
- [ ] Řádky tvoří aspekty, sloupce typy vztahů

> Framework je matice vrstev (řádky) a aspektů (sloupce). Viewpointy, stakeholdeři, fáze ADM ani typy vztahů jeho osy netvoří.

### ? Do které buňky ArchiMate Framework patří prvek Application Interface?

- [x] Application Layer × Active Structure
- [ ] Application Layer × Behavior
- [ ] Technology Layer × Active Structure
- [ ] Application Layer × Passive Structure

> Interface je externí aktivní struktura, a Application Interface proto patří do buňky Application × Active Structure. Do Behavior patří služby a procesy, do Passive Structure data.

## Core Framework × Full Framework {#core-full .compare}

| | Core Framework | Full Framework |
|---|---|---|
| Vrstvy | Business, Application, Technology | navíc Strategy, Physical, Implementation & Migration |
| Aspekty | Active Structure, Behavior, Passive Structure | navíc Motivation |
| Velikost | 3 × 3 = 9 buněk | celý jazyk |
| Na co odpovídá | jak podnik funguje (byznys, aplikace, infrastruktura) | navíc proč, jakou má strategii, fyzický svět a jak se mění v čase |

### ? Které vrstvy tvoří Core Framework jazyka ArchiMate?

- [ ] Strategy, Business a Application
- [ ] Business, Application a Implementation & Migration
- [ ] Application, Technology a Physical
- [x] Business, Application a Technology

> Core Framework tvoří tři jádrové vrstvy Business, Application a Technology. Strategy, Physical a Implementation & Migration přidává až Full Framework.

### ? Která část jazyka NENÍ součástí Core Framework?

- [ ] Aspekt Passive Structure
- [x] Aspekt Motivation
- [ ] Technology Layer
- [ ] Aspekt Behavior

> Core Framework se skládá ze tří vrstev a tří aspektů — Active Structure, Behavior a Passive Structure. Motivation patří až do Full Framework.

### ? Kolik buněk má matice Core Framework?

- [ ] 6
- [x] 9
- [ ] 12
- [ ] 24

> Core Framework kombinuje tři vrstvy (Business, Application, Technology) se třemi aspekty (Active Structure, Behavior, Passive Structure), tedy 3 × 3 = 9 buněk.

## Generický metamodel {#genericky-metamodel .explain}

Všechny jádrové vrstvy sdílejí stejný **generický metamodel**: **interní aktivní struktura** (kdo jedná) vykonává **interní chování** (process, function, interaction), které **realizuje službu** (service — externí chování nabízené okolí); služba je okolí dostupná přes **interface** (externí aktivní struktura); chování pracuje s **pasivní strukturou** a může ho spustit **event**. Často se to přirovnává k větě přirozeného jazyka: aktivní struktura je **podmět**, chování **sloveso** a pasivní struktura **předmět**. Typické vazby: aktivní struktura —assignment→ chování, chování —realization→ služba, interface —assignment→ služba, chování —access→ pasivní struktura, event —triggering→ chování.

*Příklad:* `Fakturant (Business Role) —assignment→ Vystavení faktury (Business Process) —realization→ Fakturace (Business Service)` a `Vystavení faktury (Business Process) —access (write)→ Faktura (Business Object)`.

### ? Které tři základní druhy prvků rozlišuje generický metamodel ArchiMate (vedle událostí a kompozitních prvků)?

- [ ] Vrstvy, aspekty a příkladové viewpointy
- [ ] Prvky, vztahy a spojovníky typu Junction
- [x] Aktivní struktura, chování a pasivní struktura
- [ ] Stakeholdeři, jejich zájmy a konkrétní pohledy

> Generický metamodel staví na aktivní struktuře (kdo), chování (co dělá) a pasivní struktuře (s čím). Vrstvy a aspekty jsou osy rámce, prvky a vztahy druhy konceptů a stakeholdeři se zájmy pojmy popisu architektury.

### ? Struktura jazyka ArchiMate se přirovnává k větě přirozeného jazyka. Čemu ve větě odpovídá prvek aktivní struktury?

- [ ] Slovesu
- [ ] Předmětu
- [ ] Příslovečnému určení
- [x] Podmětu

> Aktivní struktura je podmět (kdo jedná), chování sloveso (co dělá) a pasivní struktura předmět (s čím se pracuje).

### ? Který fragment modelu odpovídá obecnému vzoru „aktivní struktura vykonává chování, které pracuje s pasivní strukturou"?

- [ ] `Objednávka (Business Object) —assignment→ Vychystání zásilky (Business Process) —access→ Skladník (Business Role)`
- [x] `Skladník (Business Role) —assignment→ Vychystání zásilky (Business Process) —access→ Objednávka (Business Object)`
- [ ] `Vychystání zásilky (Business Process) —assignment→ Skladník (Business Role) —access→ Objednávka (Business Object)`
- [ ] `Skladník (Business Role) —access→ Vychystání zásilky (Business Process) —assignment→ Objednávka (Business Object)`

> Role je přiřazena (assignment) k procesu, který ji vykonává, a proces přistupuje (access) k business objektu. Pasivní objekt nemůže být zdrojem assignment, assignment nevede od chování k roli a access nesměřuje na proces.

## Interní aktivní struktura {#internal-active .term}

**Interní aktivní struktura** jsou prvky, které chování skutečně **vykonávají** — Business Actor a Business Role, Application Component, Node, Device, System Software. Zvláštním případem je **collaboration** (Business Collaboration, Application Collaboration, Technology Collaboration): seskupení dvou či více aktivních prvků, které **spolupracují** a společně vykonávají kolektivní chování — **interakci**.

### ? Který prvek představuje interní aktivní strukturu?

- [ ] Technology Interface
- [ ] Technology Service
- [ ] Artifact
- [x] Node

> Node je interní aktivní struktura — výpočetní prostředek, který vykonává technologické chování. Technology Interface je externí aktivní struktura, Technology Service externí chování a Artifact pasivní struktura.

### ? Co v ArchiMate představuje collaboration, například Business Collaboration?

- [x] Seskupení dvou či více aktivních prvků, které společně vykonávají chování
- [ ] Smlouva mezi dvěma stranami o poskytování služby za úplatu a za podmínek
- [ ] Posloupnost činností dvou útvarů, seřazená podle času a s daným výsledkem
- [ ] Přístupový kanál, přes který spolupracující partneři využívají služby

> Collaboration je aktivní struktura složená ze spolupracujících prvků, které společně vykonávají interakci. Smlouva je Contract, posloupnost činností proces a přístupový kanál interface.

## Rozhraní (Interface) {#interface .term}

**Interface** je **externí aktivní struktura**: přístupový bod, přes který prvek zpřístupňuje své služby okolí — uživatelům nebo jiným systémům. V Business Layer je to např. pobočka, call centrum či webový portál (Business Interface), v Application Layer obrazovka nebo API (Application Interface), v Technology Layer síťový port či protokolové rozhraní (Technology Interface). Rozhraní bývá součástí komponenty (composition) a je přiřazeno ke službě (assignment). Ikonou je kroužek na krátké čárce („lízátko").

### ? Co v ArchiMate představuje interface?

- [ ] Vnitřní činnost komponenty, kterou okolí přímo nevidí
- [ ] Datový objekt, který si dva systémy navzájem předávají
- [x] Přístupový bod, přes který prvek zpřístupňuje služby okolí
- [ ] Okamžik, kdy se změní stav prvku a něco se tím spustí

> Interface je externí aktivní struktura — místo, kudy se okolí dostane ke službám. Vnitřní činnost je interní chování, předávaná data pasivní struktura a změna stavu event.

### ? Banka nabízí službu „Založení účtu" přes pobočku, call centrum a internetové bankovnictví. Čím jsou tyto kanály z hlediska generického metamodelu?

- [x] Rozhraními (interface) — externí aktivní strukturou
- [ ] Službami (service) — externím chováním banky
- [ ] Procesy (process) — interním chováním banky
- [ ] Objekty (passive structure) — předmětem činnosti

> Kanály, přes které zákazník službu využívá, jsou rozhraní (interface). Služba je samotné „Založení účtu", proces je vnitřní postup banky a pasivní objekty jsou např. smlouva či žádost.

## Interní chování (Process, Function, Interaction) {#internal-behavior .term}

**Interní chování** je činnost, kterou vykonává interní aktivní struktura. ArchiMate rozlišuje tři druhy: **process** — posloupnost kroků směřující k určitému výsledku (je v ní časové pořadí); **function** — seskupení chování podle společného kritéria, např. potřebných dovedností, znalostí či zdrojů, bez daného pořadí; **interaction** — chování, které společně vykonává více aktivních prvků (typicky collaboration). Každá jádrová vrstva má svou verzi (Business Process, Application Function, Technology Interaction…).

### ? Čím se process liší od function?

- [ ] Process je externí chování, function interní chování
- [ ] Process patří jen do Business, function jen do Application Layer
- [x] Process má posloupnost kroků a výsledek, function seskupuje chování
- [ ] Process vykonávají role, function výhradně aplikační komponenty

> Process je sled kroků vedoucí k výsledku, function seskupuje chování podle společného kritéria (dovednosti, zdroje) bez daného pořadí. Obojí je interní chování, existuje ve všech jádrových vrstvách a vykonávat ho mohou různé aktivní prvky.

### ? Útvar účetnictví a útvar controllingu společně provádějí měsíční uzávěrku, kterou žádný z nich nezvládne sám. Který druh interního chování to nejlépe vystihuje?

- [ ] Function
- [ ] Event
- [ ] Service
- [x] Interaction

> Chování vykonávané společně více aktivními prvky (collaboration) je interaction. Function je chování seskupené podle kritéria, event změna stavu a service externí chování.

## Služba (Service) {#service .term}

**Service** je **externí chování**: explicitně vymezené chování, které prvek nabízí svému okolí. Popisuje, **co** okolí dostane a jakou hodnotu mu to přináší, nikoli **jak** se to uvnitř provádí. Službu **realizuje** interní chování (realization), zpřístupňuje ji interface (assignment) a uživatelům **slouží** (serving). Každá jádrová vrstva má svou službu: Business Service, Application Service, Technology Service. Kreslí se jako obdélník se zaoblenými rohy; ikona: malý zaoblený obdélník (tvar pilulky), případně se služba nakreslí jen tímto tvarem.

### ? Co nejlépe vystihuje službu (service) v ArchiMate?

- [x] Externě viditelné chování nabízené okolí, bez detailu provedení
- [ ] Interní posloupnost kroků, kterou okolí vidí do posledního detailu
- [ ] Organizační jednotka, která zákazníkům poskytuje podporu a poradenství
- [ ] Datový objekt, který obsahuje popis nabízených produktů a jejich cen

> Služba je externí chování — vymezuje, co okolí dostane, a skrývá, jak se to provádí. Interní posloupnost kroků je proces, organizační jednotka aktivní struktura a popis produktů pasivní struktura.

### ? Který vztah typicky spojuje interní chování (např. Business Process) se službou, kterou poskytuje?

- [ ] Assignment
- [ ] Composition
- [x] Realization
- [ ] Triggering

> Interní chování službu realizuje: `Vyřízení pojistné události (Business Process) —realization→ Likvidace škod (Business Service)`. Assignment váže aktivní strukturu k chování, composition celek s částí a triggering časovou návaznost.

## Událost (Event) {#event .term}

**Event** (událost) je prvek chování, který vyjadřuje, že se **něco stalo** — změnu stavu. Událost může chování **spustit** (vztah triggering) nebo z něj **vzejít** jako výsledek; může přicházet zvenčí (zákazník podal reklamaci) i zevnitř (uplynula lhůta). Na rozdíl od procesu nemá trvání — jde o okamžik. Existuje v jádrových vrstvách (Business/Application/Technology Event) a v Implementation & Migration jako Implementation Event.

### ? Co v ArchiMate představuje event?

- [ ] Dlouhodobou činnost, která probíhá po celou dobu provozu
- [x] Změnu stavu, která může chování spustit nebo z něj vzejít
- [ ] Hranici mezi dvěma vrstvami, kterou je nutné překročit
- [ ] Plánovaný projekt, který převádí podnik do cílového stavu

> Event je okamžitá změna stavu — spouštěč nebo výsledek chování. Dlouhodobá činnost by byla funkce, projekt je Work Package a hranice vrstev prvkem není.

### ? Která z následujících situací se v ArchiMate modeluje jako event (událost), a ne jako proces?

- [x] Uplynula zákonná lhůta pro podání odvolání
- [ ] Posouzení odvolání komisí v několika krocích
- [ ] Vyřizování podaného odvolání úředníkem
- [ ] Doručení rozhodnutí o odvolání účastníkům

> Uplynutí lhůty je okamžitá změna stavu bez trvání, tedy event, na který může navázat další chování. Posouzení, vyřizování i doručení jsou činnosti s trváním a kroky, tedy procesy.

## Interní × externí pohled {#internal-external .compare}

Generický metamodel odděluje, **co** prvek nabízí okolí (externí pohled), od toho, **jak** to uvnitř zajišťuje (interní pohled):

| | Interní | Externí |
|---|---|---|
| Aktivní struktura | Business Actor, Role, Application Component, Node… | Interface (Business / Application / Technology Interface) |
| Chování | Process, Function, Interaction | Service (Business / Application / Technology Service) |
| Perspektiva | jak to funguje uvnitř (realizace) | co dostane okolí („černá skříňka") |
| Komu je určen | vlastníkovi a provozovateli | uživateli, zákazníkovi, jiné vrstvě |

Díky oddělení lze změnit vnitřní realizaci, aniž se změní služba, na které uživatelé závisejí.

### ? Která dvojice prvků představuje externí pohled na aplikační vrstvu?

- [ ] Application Component a Application Function
- [ ] Application Process a Data Object
- [x] Application Interface a Application Service
- [ ] Application Collaboration a Application Event

> Externí pohled tvoří rozhraní (externí aktivní struktura) a služba (externí chování). Komponenta, funkce, proces a collaboration jsou interní prvky, Data Object pasivní struktura a event událost.

### ? Jaká je hlavní výhoda oddělení služby od interního chování, které ji realizuje?

- [ ] Služby pak není nutné v modelu vůbec pojmenovávat
- [x] Realizaci lze měnit, aniž se změní služba pro uživatele
- [ ] Interní chování pak nemusí vykonávat žádný aktivní prvek
- [ ] Všechny služby lze zobrazit jen v pohledech Technology Layer

> Uživatel závisí na službě, ne na tom, jak je uvnitř zajištěna; vnitřní proces či komponentu lze vyměnit, dokud služba zůstává stejná. Pojmenování služeb i aktivní struktura jsou dál potřeba a služby existují ve všech vrstvách.

## Grouping {#grouping .term}

**Grouping** je kompozitní prvek, který **seskupuje libovolné koncepty** — prvky i vztahy, z různých vrstev i aspektů — podle nějakého společného hlediska (iniciativa, doména, odpovědnost…). K obsaženým konceptům se váže vztahem aggregation nebo composition, v diagramu obvykle vnořením. Kreslí se jako obdélník s **čárkovaným** okrajem a záložkou s názvem nahoře. Sám o sobě nepředstavuje žádnou věc z reálného světa — jen logické seskupení.

### ? K čemu slouží prvek Grouping?

- [ ] K vyznačení fyzického místa, kde se prvky nacházejí
- [ ] K popisu nabídky služeb a smluv, které firma prodává
- [ ] K vyjádření, že více aktivních prvků spolupracuje
- [x] K seskupení libovolných konceptů podle společného hlediska

> Grouping logicky seskupuje prvky i vztahy z libovolných vrstev a aspektů. Fyzické místo vyjadřuje Location, nabídku služeb a smluv Product a spolupráci aktivních prvků collaboration.

### ? Architekt chce v modelu označit všechny procesy, aplikace a servery, které patří k iniciativě „Digitální onboarding". Který prvek je pro to nejvhodnější?

- [ ] Location
- [ ] Product
- [x] Grouping
- [ ] Business Collaboration

> Grouping sdružuje koncepty různých typů a vrstev podle společného hlediska, např. iniciativy. Location vyjadřuje místo, Product nabídku zákazníkům a Business Collaboration spolupracující aktivní prvky.

## Location {#location .term}

**Location** vyjadřuje **místo či polohu** — fyzickou (pobočka, město, datové centrum) i konceptuální (region, trh) —, kde se nacházejí strukturní prvky nebo kde se vykonává chování. Spolu s Grouping patří do skupiny kompozitních prvků („Other"); k prvkům na daném místě se váže zpravidla vztahem aggregation. Ikonou je špendlík na mapě. Pozor na rozdíl od **Facility** — ta je fyzickým zařízením (budova, závod), Location jen udává umístění.

### ? Firma chce v modelu vyznačit, které servery a týmy působí v Praze a které v Brně — jen jako jejich umístění. Který prvek použije?

- [x] Location
- [ ] Grouping
- [ ] Facility
- [ ] Business Actor

> Umístění prvků vyjadřuje Location. Grouping seskupuje podle libovolného hlediska bez vazby na místo, Facility je fyzické zařízení (budova, závod) a Business Actor organizační subjekt.

### ? Do které skupiny prvků patří Location?

- [ ] Mezi fyzické prvky (Physical)
- [ ] Mezi prvky aspektu Motivation
- [ ] Mezi pasivní prvky Business Layer
- [x] Mezi kompozitní prvky (Other)

> Location je spolu s Grouping kompozitní prvek v kategorii „Other", použitelný napříč vrstvami. Fyzickým prvkem je Facility; Location nepatří do Motivation ani mezi pasivní strukturu.

## Obecná notace prvků {#notace-prvku .explain}

Prvek se kreslí jako **obdélník s ikonou** typu v pravém horním rohu, případně jen samotnou ikonou. **Tvar rohů** napoví aspekt: **hranaté rohy** = struktura (aktivní i pasivní), **zaoblené rohy** = chování, **seříznuté rohy** = prvky Motivation; pasivní objekty (Business Object, Data Object) mívají navíc vodorovný pruh v horní části. **Barvy nejsou normativní** — konvenčně se používá žlutá pro Business, modrá pro Application a zelená pro Technology Layer, ale význam nesou typ a ikona, ne barva; vrstvu lze volitelně vyznačit i písmenem v rohu.

*Příklad:* Application Service se kreslí jako obdélník se zaoblenými rohy s ikonou malého zaobleného obdélníku (tvar pilulky), Application Component jako obdélník s hranatými rohy s ikonou komponenty.

### ? Prvek je nakreslen jako obdélník se zaoblenými rohy. Ke kterému aspektu nejspíš patří?

- [ ] Passive Structure
- [x] Behavior
- [ ] Active Structure
- [ ] Motivation

> Zaoblené rohy označují prvky chování (procesy, funkce, služby, události). Strukturní prvky mají rohy hranaté a prvky Motivation seříznuté.

### ? Který výrok o barvách prvků v ArchiMate je správný?

- [ ] Barva je normativní a určuje typ prvku jednoznačně
- [ ] Prvky Business Layer musí být vždy žluté, jinak model neplatí
- [x] Barvy nejsou normativní, význam nese typ prvku a jeho ikona
- [ ] Barvou se povinně odlišují interní prvky od externích

> Specifikace barvy nepředepisuje; žlutá, modrá a zelená pro jádrové vrstvy jsou jen zvyklost. Význam prvku nese jeho typ (a ikona), ne barva.

### ? Jak se v notaci ArchiMate obvykle odlišují prvky aspektu Motivation (např. Goal, Requirement)?

- [ ] Kruhovým tvarem bez jakékoli ikony
- [ ] Obdélníkem s čárkovaným okrajem
- [ ] Obdélníkem s vodorovným pruhem nahoře
- [x] Obdélníkem se seříznutými rohy

> Prvky Motivation se kreslí jako obdélník se seříznutými (zkosenými) rohy. Čárkovaný okraj se záložkou má Grouping a vodorovný pruh nahoře pasivní objekty.
