---
kind: topic
subject: archimate-foundation
slug: technology-layer
name: "Technology Layer a Physical elements"
order: 6
---

Node, Device, System Software, Technology Collaboration a Interface, Path, Communication Network; technologické chování; Artifact; fyzické prvky (Equipment, Facility, Distribution Network, Material).

## Technology Layer v přehledu {#tech-prehled .explain}

**Technology Layer** popisuje technologickou infrastrukturu, na které běží aplikace a data: hardware, systémový software, sítě a nasazené soubory. Prvky se dělí podle stejných aspektů jako v ostatních vrstvách Core Framework:

- **aktivní struktura** — Node, Device, System Software, Technology Collaboration, Technology Interface (externí), Path, Communication Network;
- **chování** — Technology Function, Technology Process, Technology Interaction, Technology Event a Technology Service (externí);
- **pasivní struktura** — Artifact.

Fyzické prvky (Equipment, Facility, Distribution Network, Material) technologickou vrstvu rozšiřují o fyzický svět a patří do Full Framework.

*Příklad:* `DB server (Node) —assignment→ Správa databáze (Technology Function) —realization→ Hosting databáze (Technology Service)`

### ? Který prvek Technology Layer patří do aspektu pasivní struktury?

- [ ] Technology Service
- [ ] System Software
- [x] Artifact
- [ ] Communication Network

> Artifact je jediný pasivní prvek technologické vrstvy — je to datový celek, se kterým se pracuje. System Software a Communication Network jsou aktivní struktura, Technology Service je externí chování.

### ? Kam v rámci jazyka ArchiMate patří fyzické prvky Equipment, Facility, Distribution Network a Material?

- [ ] Do Core Framework jako součást aspektu pasivní struktury
- [ ] Do Implementation & Migration jako hmotné výstupy projektů
- [ ] Do Business Layer jako hmotné zdroje podnikových procesů
- [x] Do Full Framework jako fyzické rozšíření Technology Layer

> Fyzické prvky rozšiřují Technology Layer o stroje, budovy, přepravní sítě a materiál; nejsou součástí Core Framework, ale Full Framework. Nejde o výstupy projektů ani o prvky Business Layer.

## Uzel (Node) {#node .term}

**Node** odpovídá na otázku „kde to běží": je to prostředí, na kterém se spouští software a ukládají data. Jde o obecný prvek aktivní struktury — jedním Node může být samostatný server i celé prostředí složené z hardwaru a systémového softwaru (aplikační server, databázový cluster, kontejnerová platforma). **Notace:** trojrozměrný kvádr (nebo obdélník s ikonou kvádru). Node bývá složen (composition) z Device a System Software, je přiřazen (assignment) k technologickému chování a hostí nasazené Artifacts.

### ? Který prvek použijete pro „produkční aplikační server", pokud v pohledu nechcete rozlišovat, co je v něm hardware a co systémový software?

- [x] Node
- [ ] Device
- [ ] Technology Collaboration
- [ ] Facility

> Node je obecný výpočetní prostředek a může zahrnovat hardware i systémový software najednou. Device by vyjadřoval jen hardware, Technology Collaboration seskupení více uzlů a Facility fyzickou stavbu.

### ? Jak se v notaci ArchiMate obvykle zobrazuje Node?

- [ ] Jako zaoblený obdélník s ikonou šipky
- [x] Jako trojrozměrný kvádr s viditelnou hloubkou
- [ ] Jako obdélník s přeloženým pravým horním rohem
- [ ] Jako kruh s názvem prvku uprostřed

> Node se kreslí jako trojrozměrný kvádr (případně obdélník s ikonou kvádru). Zaoblený obdélník je typický pro chování a přeložený roh pro Artifact.

## Zařízení (Device) {#device .term}

**Device** je kus IT hardwaru, na kterém poběží systémový software a nasazené artifacts — server, notebook, mobilní telefon, router, platební terminál. Device je specializací Node a zachycuje právě hardwarovou část infrastruktury. **Notace:** obdélník s ikonou připomínající klávesnici a monitor. Typicky `Device —assignment→ System Software`; Device bývá součástí (composition) Node a zařízení se propojují přes Communication Network.

### ? Co z následujícího se typicky modeluje jako Device?

- [ ] Operační systém Linux na serveru
- [ ] Konfigurační soubor aplikace
- [x] Notebook obchodního zástupce
- [ ] Databázový systém PostgreSQL

> Device je fyzický hardware, na kterém běží software — notebook je typický příklad. Operační systém a databázový systém jsou System Software, konfigurační soubor je Artifact.

### ? Na fyzickém serveru (Device) je nainstalován operační systém Linux (System Software). Který vztah z Device na System Software to vyjadřuje?

- [ ] realization
- [ ] serving
- [ ] access
- [x] assignment

> Systémový software, který na zařízení běží, se k němu váže vztahem assignment ve směru od Device k System Software. Realization by tvrdila, že hardware software „uskutečňuje", serving by vyjadřoval jen poskytování služby a access je vztah k pasivním prvkům.

## Systémový software (System Software) {#system-software .term}

**System Software** je software, na kterém stojí jiný software: připravuje prostředí, ve kterém aplikace běží a data se ukládají — operační systém, databázový systém (DBMS), aplikační server, kontejnerový runtime, middleware. Je specializací Node. **Notace:** obdélník s ikonou kruhu (připomíná disk). Typicky je přiřazen (assignment) od Device, na kterém běží, a sám je přiřazen k Artifacts, které jsou v něm nasazeny.

### ? Co z následujícího NENÍ System Software?

- [ ] Databázový systém (DBMS)
- [x] Fyzický server v datovém centru
- [ ] Operační systém serveru
- [ ] Aplikační server pro webové aplikace

> Fyzický server je hardware, tedy Device. Databázový systém, operační systém i aplikační server vytvářejí prostředí pro běh jiného softwaru a dat, proto jsou System Software.

### ? Firma provozuje databázový systém PostgreSQL, ve kterém jsou uložena data několika aplikací. Jakým prvkem se PostgreSQL modeluje?

- [ ] Application Component
- [ ] Artifact
- [ ] Device
- [x] System Software

> Databázový systém je prostředí pro uložení a používání dat, tedy System Software. Application Component by byl jen v případě, že jde o samotnou aplikaci s byznysovou funkčností, Artifact je nasazený soubor a Device hardware.

## Node × Device × System Software {#node-device-sw .compare}

Device i System Software jsou specializace prvku Node; obecný Node se použije, když na rozdělení nezáleží nebo když prostředí tvoří několik prvků dohromady.

| Prvek | Co představuje | Příklad | Typické vztahy |
|---|---|---|---|
| Node | obecný výpočetní či fyzický prostředek, často složený | „Aplikační server PROD" | composition z Device a System Software; assignment k technologickému chování a k Artifacts |
| Device | hardware | „Server v racku", „tablet" | assignment → System Software |
| System Software | softwarové prostředí pro běh softwaru a dat | „Linux", „PostgreSQL", „Tomcat" | assignment → Artifact |

*Příklad:* `Aplikační server PROD (Node) —composition→ HW server (Device)`, `Aplikační server PROD (Node) —composition→ Linux (System Software)`, `HW server (Device) —assignment→ Linux (System Software)`

### ? Architekt modeluje databázový server jako Node, který obsahuje fyzický stroj a databázový systém. Který fragment modelu je správný?

- [ ] DB server (Node) —composition→ PostgreSQL (Artifact)
- [x] DB server (Node) —composition→ PostgreSQL (System Software)
- [ ] DB server (Node) —serving→ PostgreSQL (Application Component)
- [ ] DB server (Node) —realization→ PostgreSQL (Device)

> Databázový systém je System Software a jako součást uzlu se k Node váže vztahem composition. Ostatní fragmenty PostgreSQL chybně typují (Artifact, Application Component, Device), skladbu uzlu proto nevystihují.

### ? Které tvrzení o vztahu prvků Node, Device a System Software je správné?

- [ ] Node je specializací Device a nese jen hardware
- [ ] System Software je pasivní struktura na Device
- [ ] Device a System Software patří do aspektu chování
- [x] Device i System Software jsou specializacemi prvku Node

> Device (hardware) i System Software (softwarové prostředí) jsou zvláštní druhy obecného Node a všechny patří do aktivní struktury. Pasivní strukturou technologické vrstvy je Artifact.

### ? Kdy je vhodné modelovat infrastrukturu jen obecným prvkem Node místo rozlišení na Device a System Software?

- [x] Když pro pohled nezáleží na rozlišení hardwaru a softwaru
- [ ] Když jde o virtualizované prostředí, které Device nepřipouští
- [ ] Když je server umístěn mimo vlastní datové centrum firmy
- [ ] Když na serveru běží více než jeden operační systém

> Node se používá, když stačí říct, kde co běží, a detail skladby není pro stakeholdera podstatný. Umístění serveru, virtualizace ani počet operačních systémů o volbě mezi Node a jeho specializacemi nerozhodují.

## Technology Collaboration a Technology Interaction {#tech-collaboration .term}

**Technology Collaboration** je seskupení dvou nebo více uzlů (Node a jeho specializací), které spolupracují na společném technologickém chování. Toto společné chování se modeluje jako **Technology Interaction**, ke které je kolaborace přiřazena (assignment). Kolaborace obvykle agreguje (aggregation) zúčastněné uzly.

*Příklad:* `Replikační dvojice (Technology Collaboration) —aggregation→ DB primár (Node)`, `Replikační dvojice (Technology Collaboration) —aggregation→ DB replika (Node)`, `Replikační dvojice (Technology Collaboration) —assignment→ Replikace dat (Technology Interaction)`

### ? Dva databázové servery spolu průběžně synchronizují data, aby jeden mohl okamžitě převzít provoz druhého. Kterým prvkem se nejlépe modeluje samotné společné chování obou serverů?

- [ ] Technology Process
- [ ] Technology Event
- [x] Technology Interaction
- [ ] Technology Service

> Chování, které vykonávají dva nebo více uzlů společně, je Technology Interaction (přiřazená k Technology Collaboration). Technology Process vykonává jeden uzel, Technology Event je okamžitá změna stavu a Technology Service je navenek nabízené chování.

### ? Co je Technology Collaboration?

- [ ] Rozhraní, přes které uzel nabízí své služby
- [x] Seskupení uzlů pro společné technické chování
- [ ] Logický spoj mezi uzly umožňující výměnu dat
- [ ] Sled technologických kroků s určeným výsledkem

> Technology Collaboration seskupuje dva nebo více uzlů, které spolu vykonávají Technology Interaction. Rozhraní je Technology Interface, logický spoj je Path a sled kroků je Technology Process.

## Technology Interface {#tech-interface .term}

**Technology Interface** je externí aktivní struktura: místo přístupu, přes které jsou technologické služby uzlu dostupné jiným uzlům nebo aplikačním komponentám. Představuje např. síťový port s protokolem, API platformy nebo konzoli pro připojení. Rozhraní je součástí (composition) Node a je přiřazeno (assignment) k Technology Service, kterou zpřístupňuje.

*Příklad:* `DB server (Node) —composition→ SQL rozhraní na portu 5432 (Technology Interface) —assignment→ Hosting databáze (Technology Service)`

### ? Databázový server zpřístupňuje své služby aplikacím přes databázový protokol na síťovém portu 5432. Jakým prvkem se tento přístupový bod modeluje?

- [x] Technology Interface
- [ ] Path
- [ ] Technology Service
- [ ] Communication Network

> Přístupový bod, přes který jsou služby uzlu dostupné, je Technology Interface (externí aktivní struktura). Technology Service je samotné nabízené chování, Path logický spoj mezi uzly a Communication Network fyzická síť.

### ? Jaký vztah typicky vede z Technology Interface na Technology Service, kterou rozhraní zpřístupňuje?

- [ ] realization
- [ ] composition
- [ ] triggering
- [x] assignment

> Rozhraní je ke službě, kterou zpřístupňuje, přiřazeno vztahem assignment. Službu realizuje (realization) technologické chování, ne rozhraní; composition a triggering zde nedávají smysl.

## Path {#path .term}

**Path** říká, že spolu dva nebo více uzlů komunikují nebo si něco předávají — data, energii nebo materiál. Je to **logická** cesta komunikace či přepravy — co s čím komunikuje —, která neřeší, po jaké fyzické síti přenos probíhá. K propojeným uzlům se Path váže vztahem association a může být realizována (realization) jednou nebo více Communication Networks (u přepravy materiálu či energie Distribution Networks).

*Příklad:* `Pokladna na pobočce (Node) —association→ Spoj pobočka–centrála (Path)`, `Centrální server (Node) —association→ Spoj pobočka–centrála (Path)`

### ? Architekt chce vyjádřit, že pokladní systém na pobočce komunikuje s centrálním serverem, ale zatím neřeší, přes jakou síťovou infrastrukturu. Který prvek použije?

- [ ] Communication Network
- [ ] Technology Interface
- [x] Path
- [ ] vztah flow

> Path zachycuje logické spojení uzlů bez ohledu na fyzickou síť. Communication Network by už popisovala konkrétní síť, Technology Interface je přístupový bod jednoho uzlu a flow je dynamický vztah mezi chováním, ne spoj mezi uzly.

### ? Co může podle ArchiMate přenášet Path mezi uzly?

- [ ] Pouze data mezi IT zařízeními
- [ ] Pouze materiál mezi stroji
- [ ] Pouze řídicí signály událostí
- [x] Data, energii nebo materiál

> Path je obecné spojení uzlů, přes které lze vyměňovat data, energii nebo materiál. Proto ji lze použít v IT i ve fyzickém světě.

## Komunikační síť (Communication Network) {#communication-network .term}

**Communication Network** je konkrétní síť, po které data mezi uzly skutečně putují — LAN, WAN, Wi-Fi, mobilní síť, internetové připojení. Na rozdíl od Path jde o **fyzickou**, konkrétní infrastrukturu. Síť se s uzly spojuje vztahem association a může realizovat (realization) jednu nebo více Paths.

*Příklad:* `Firemní síť MPLS (Communication Network) —realization→ Spoj pobočka–centrála (Path)`

### ? Které tvrzení o prvku Communication Network je správné?

- [x] Je to konkrétní síť, která může realizovat Path
- [ ] Je to logický spoj nezávislý na fyzické síti
- [ ] Je to druh Technology Service pro přenos dat
- [ ] Je to pasivní struktura, kterou uzly čtou a zapisují

> Communication Network je fyzická síťová infrastruktura a může realizovat jednu či více Paths. Logický spoj je naopak Path; síť není služba ani pasivní prvek.

### ? Pobočky firmy jsou s centrálou propojeny pronajatou sítí MPLS od telekomunikačního operátora. Jak se tato síť nejlépe modeluje?

- [ ] Jako Path spojující pobočky s centrálou
- [ ] Jako Distribution Network mezi budovami
- [x] Jako Communication Network propojující uzly
- [ ] Jako Technology Collaboration všech poboček

> Konkrétní síť pro přenos dat je Communication Network. Path by byla jen logická cesta, Distribution Network přepravuje materiál či energii a Technology Collaboration seskupuje uzly kvůli společnému chování.

## Path × Communication Network {#path-vs-network .compare}

Path se hodí do přehledových pohledů (kdo s kým komunikuje), Communication Network do detailních pohledů na infrastrukturu.

| Hledisko | Path | Communication Network |
|---|---|---|
| Povaha | logická cesta komunikace či přepravy | fyzická síťová infrastruktura |
| Odpovídá na otázku | které uzly spolu komunikují | po čem data fyzicky putují |
| Co přenáší | data, energii nebo materiál | data |
| Vzájemný vztah | je realizována sítí | `Communication Network —realization→ Path` |
| Vazba na uzly | association | association |

### ? Jaký vztah typicky vede mezi Communication Network a Path?

- [ ] Path —realization→ Communication Network
- [ ] Communication Network —serving→ Path
- [ ] Path —composition→ Communication Network
- [x] Communication Network —realization→ Path

> Konkrétní síť uskutečňuje logickou cestu, proto vede realization od Communication Network k Path. Opačný směr realization, serving ani composition tento vztah nevyjadřují.

### ? Které přiřazení prvku k otázce, na kterou v modelu odpovídá, je správné?

- [x] Path: které uzly spolu logicky komunikují
- [ ] Path: po jaké fyzické síti a kabeláži data tečou
- [ ] Communication Network: jaká data uzly ukládají
- [ ] Communication Network: jaké služby uzel nabízí

> Path vyjadřuje logické spojení uzlů, Communication Network fyzickou síť, po které přenos probíhá. Ukládaná data popisují Artifacts a nabízené služby Technology Services.

## Technologická funkce (Technology Function) {#tech-function .term}

**Technology Function** je soubor technologického chování, který uzel vykonává, seskupený podle potřebných dovedností či prostředků — např. „Správa databáze", „Zálohování", „Monitorování". Je to interní chování bez daného pořadí kroků, bez jasného začátku a konce; trvá, dokud ji uzel vykonává. K uzlu se váže vztahem assignment (`Node —assignment→ Technology Function`) a realizuje (realization) Technology Services.

### ? Kterým prvkem se nejlépe modeluje trvale vykonávané chování serveru „Monitorování dostupnosti", které nemá určené pořadí kroků ani konec?

- [ ] Technology Process
- [x] Technology Function
- [ ] Technology Event
- [ ] Technology Interaction

> Trvalé chování seskupené podle schopností uzlu, bez pořadí kroků, je Technology Function. Process má začátek, konec a posloupnost kroků, Event je okamžitá změna stavu a Interaction vykonává více uzlů společně.

### ? Jaký vztah vede z Node na Technology Function, kterou uzel vykonává?

- [ ] realization
- [ ] serving
- [x] assignment
- [ ] access

> Aktivní struktura je ke chování, které vykonává, přiřazena vztahem assignment. Realization vede od chování ke službě, serving od služby k uživateli a access od chování k pasivnímu prvku.

## Technologický proces (Technology Process) {#tech-process .term}

**Technology Process** je sled technologických kroků, který vede k určenému výsledku — noční dávkové zpracování, zálohovací úloha, nasazovací pipeline. Má začátek a konec a bývá spouštěn (triggering) Technology Event. Uzel je k procesu přiřazen (assignment); proces může číst a zapisovat (access) Artifacts a realizovat Technology Service.

*Příklad:* `Plánovač 02:00 (Technology Event) —triggering→ Noční záloha (Technology Process) —access (write)→ zaloha.tar.gz (Artifact)`

### ? Každou noc ve 2:00 server spustí úlohu: pozastaví zápisy, vytvoří kopii databáze, uloží ji na úložiště a odešle hlášení. Kterým prvkem se tato úloha modeluje?

- [x] Technology Process
- [ ] Technology Function
- [ ] Technology Service
- [ ] Technology Collaboration

> Posloupnost kroků s jasným začátkem, koncem a výsledkem je Technology Process. Function nemá pořadí kroků, Service je navenek nabízené chování a Collaboration seskupení uzlů.

### ? Jaký vztah vede z Technology Event „Plánovač 02:00" na Technology Process „Noční záloha", který tato událost spouští?

- [ ] flow
- [ ] serving
- [ ] access
- [x] triggering

> Spuštění chování událostí vyjadřuje triggering. Flow znamená předání informací či objektů mezi chováním, serving poskytování služby a access práci chování s pasivním prvkem.

## Technologická služba (Technology Service) {#tech-service .term}

**Technology Service** je explicitně definované, navenek nabízené technologické chování — to, co infrastruktura poskytuje svému okolí, aniž by uživatel musel znát, jak je zajištěno: hosting databází, úložiště souborů, zasílání zpráv, síťové připojení, virtuální servery. Je to externí chování. Realizuje ji Technology Function nebo Technology Process (realization), zpřístupňuje ji Technology Interface (assignment) a slouží (serving) aplikačním komponentám i jiným uzlům; vazbami na vyšší vrstvy se podrobně zabývá téma o propojení vrstev.

*Příklad:* `Správa databáze (Technology Function) —realization→ Hosting databáze (Technology Service) —serving→ CRM (Application Component)`

### ? Co z následujícího se nejlépe modeluje jako Technology Service?

- [ ] Operační systém Windows Server
- [ ] Konfigurační soubor databáze
- [x] Úložiště souborů nabízené aplikacím
- [ ] Noční dávka přepočtu skladových zásob

> Úložiště souborů, které infrastruktura nabízí aplikacím, je navenek viditelné technologické chování, tedy Technology Service. Operační systém je System Software, konfigurační soubor Artifact a noční dávka Technology Process.

### ? Který fragment modelu správně zachycuje, jak se technologická služba realizuje?

- [ ] Hosting databáze (Technology Service) —realization→ Správa databáze (Technology Function)
- [x] Správa databáze (Technology Function) —realization→ Hosting databáze (Technology Service)
- [ ] Správa databáze (Technology Function) —serving→ Hosting databáze (Technology Service)
- [ ] Hosting databáze (Technology Service) —assignment→ Správa databáze (Technology Function)

> Interní chování (Technology Function) realizuje externí chování (Technology Service), takže realization vede od funkce ke službě. Opačný směr je chybný, serving vyjadřuje poskytování služby uživateli a assignment vede od aktivní struktury ke chování.

### ? Které tvrzení o Technology Service je správné?

- [ ] Je to interní chování, které popisuje kroky práce uzlu
- [ ] Je to aktivní struktura, přes kterou se uzel připojuje
- [ ] Je to pasivní objekt, který procesy zpracovávají
- [x] Je to externí chování, které infrastruktura nabízí okolí

> Technology Service je externí chování — to, co uzel nabízí navenek. Kroky práce popisuje Technology Process, přístupový bod Technology Interface a pasivní objekt Artifact.

## Technologická událost (Technology Event) {#tech-event .term}

**Technology Event** je technologická změna stavu, na kterou se reaguje nebo kterou chování vyvolá — „Disk zaplněn na 90 %", „Vypršel certifikát", „Čas 02:00 v plánovači", „Výpadek uzlu". Nemá trvání, jde o okamžik. Typicky spouští (triggering) Technology Process nebo Technology Function, případně ji proces na svém konci vyvolá.

### ? Monitorovací systém zaznamená, že zaplnění disku překročilo 90 %, a tím spustí úklid starých logů. Jakým prvkem se modeluje samotné překročení hranice zaplnění?

- [ ] Technology Function
- [ ] Technology Process
- [x] Technology Event
- [ ] Artifact

> Okamžitá změna stavu, která spouští další chování, je Technology Event. Úklid logů by byl Technology Process, Function trvalé chování uzlu a Artifact datový soubor.

### ? Čím se Technology Event liší od Technology Process?

- [x] Událost nastane v okamžiku, proces má kroky a trvání
- [ ] Událost je externí chování, proces je interní struktura
- [ ] Událost patří do Physical, proces do Technology Layer
- [ ] Událost musí mít přiřazený uzel, proces nikdy nesmí

> Technology Event nemá trvání — je to okamžik, kdy se něco stane; Technology Process je posloupnost kroků v čase. Obě patří do chování technologické vrstvy.

## Artifact {#artifact .term}

**Artifact** zachycuje software a data „v podobě souborů": to, co se při vývoji vytvoří, na infrastrukturu nasadí a v provozu používá — spustitelný soubor, knihovna, skript, konfigurační soubor, databázové schéma, datový export. Je to pasivní struktura Technology Layer (specializace obecného Technology Object). **Notace:** obdélník s přeloženým rohem (jako list papíru), případně s takovou ikonou. Artifact se nasazuje na uzel (`System Software —assignment→ Artifact`), technologické chování k němu přistupuje (access) a artifact realizuje prvky vyšších vrstev, např. Data Object nebo Application Component.

### ? Co z následujícího je typický Artifact?

- [ ] Databázový server PostgreSQL
- [ ] Služba ukládání souborů pro aplikace
- [ ] Síťové rozhraní HTTPS na portu 443
- [x] Instalační soubor objednavky.war

> Instalační soubor je soubor vzniklý při vývoji a nasazovaný na uzel, tedy Artifact. Databázový server je Node nebo System Software, služba ukládání je Technology Service a síťové rozhraní Technology Interface.

### ? Do kterého aspektu patří Artifact?

- [ ] Externí aktivní struktura
- [ ] Interní chování
- [x] Pasivní struktura
- [ ] Externí chování

> Artifact je pasivní struktura — data, se kterými technologické chování pracuje. Externí aktivní strukturou je Technology Interface, interním chováním Technology Function či Process a externím chováním Technology Service.

### ? Jak se v notaci ArchiMate obvykle znázorňuje Artifact?

- [x] Obdélník s přeloženým rohem jako list papíru
- [ ] Trojrozměrný kvádr s viditelnou hloubkou
- [ ] Zaoblený obdélník s ikonou šipky vpravo
- [ ] Obdélník s ikonou kruhu připomínajícího disk

> Artifact připomíná list papíru s přeloženým rohem. Kvádr je Node, kruhová ikona disku patří System Software a zaoblený obdélník se šipkou je typický pro procesy (chování).

## Nasazení (deployment) {#nasazeni .explain}

Nasazení softwaru se v ArchiMate modeluje přiřazením Artifact k prvku, na kterém běží nebo je uložen. Typický postup zdola nahoru:

1. Device nese System Software (`Device —assignment→ System Software`), oba mohou být součástí jednoho Node.
2. Artifact je nasazen na System Software nebo Node (`System Software —assignment→ Artifact`).
3. Artifact pak realizuje prvek aplikační vrstvy, který „zhmotňuje" (podrobně viz propojení vrstev).

Vztah assignment tu tedy znamená „je nasazen na / běží na". Access se pro nasazení nepoužívá — vyjadřuje jen čtení či zápis dat chováním.

*Příklad:* `HW server (Device) —assignment→ Tomcat (System Software) —assignment→ objednavky.war (Artifact) —realization→ Objednávky (Application Component)`

### ? Webová aplikace je zabalena do souboru eshop.war, který je nasazen na aplikačním serveru Tomcat. Který fragment správně vyjadřuje nasazení?

- [ ] eshop.war (Artifact) —assignment→ Tomcat (System Software)
- [x] Tomcat (System Software) —assignment→ eshop.war (Artifact)
- [ ] Tomcat (System Software) —access (read)→ eshop.war (Artifact)
- [ ] eshop.war (Artifact) —realization→ Tomcat (System Software)

> Nasazení vyjadřuje assignment od System Software (nebo Node) k Artifact. Opačný směr assignment je chybný, access popisuje čtení dat chováním a realization by tvrdila, že soubor uskutečňuje aplikační server.

### ? Který vztah ArchiMate vyjadřuje, že artifact je nasazen na uzlu?

- [ ] realization z artifactu na uzel
- [ ] serving z uzlu na artifact
- [x] assignment z uzlu na artifact
- [ ] composition z artifactu na uzel

> Uzel (Node, System Software) je k nasazenému artifactu přiřazen vztahem assignment. Realization, serving ani composition s artifactem jako celkem nasazení nevyjadřují.

## Fyzické prvky (Physical elements) {#physical-prehled .explain}

**Physical elements** rozšiřují Technology Layer o modelování fyzického světa — výrobních zařízení, budov, přepravních sítí a hmotných materiálů. Uplatní se tam, kde IT řídí nebo podporuje fyzické procesy (výroba, logistika, energetika, IoT). Aktivní strukturou jsou **Equipment**, **Facility** a **Distribution Network**, pasivní strukturou **Material**. Samostatné „fyzické chování" jazyk nemá: chování fyzických prvků se modeluje technologickým chováním (Technology Process, Technology Function, Technology Event). Fyzické prvky patří do Full Framework.

*Příklad:* `Svařovací robot (Equipment) —assignment→ Svařování karoserie (Technology Process) —access→ Ocelový díl (Material)`

### ? Jak se v ArchiMate modeluje chování výrobní linky, například „Lisování dílů"?

- [ ] Zvláštním prvkem fyzického chování vyhrazeným strojům
- [x] Prvkem Technology Process přiřazeným k Equipment
- [ ] Prvkem Business Event napojeným na Material
- [ ] Prvkem Work Package, který Equipment realizuje

> Pro fyzické prvky jazyk nemá vlastní prvky chování; používá se technologické chování, ke kterému je Equipment přiřazeno (assignment). Business Event je událost Business Layer a Work Package patří do Implementation & Migration.

### ? Který fyzický prvek patří do pasivní struktury?

- [ ] Equipment
- [ ] Facility
- [ ] Distribution Network
- [x] Material

> Material je hmota, se kterou se pracuje, tedy pasivní struktura. Equipment, Facility a Distribution Network jsou aktivní struktura.

## Zařízení (Equipment) {#equipment .term}

**Equipment** jsou stroje, nástroje a přístroje fyzického světa, které s materiálem něco dělají — vyrábějí ho, zpracovávají, skladují nebo převážejí: výrobní linka, robot, lis, čerpadlo, vozidlo, senzor. Je to aktivní struktura; v metamodelu je chápána jako zvláštní druh Node, takže na ní může běžet i System Software (např. řídicí firmware stroje). **Notace:** ikona ozubených kol. Equipment bývá umístěno ve Facility a k chování, které vykonává, se váže vztahem assignment.

### ? Mlékárna modeluje pasterizační linku, která ohřívá a chladí mléko. Jakým prvkem se linka modeluje?

- [x] Equipment
- [ ] Facility
- [ ] Device
- [ ] Material

> Stroj, který zpracovává materiál, je Equipment. Facility by byla budova mlékárny, Device IT hardware pro běh softwaru a Material samotné mléko.

### ? Čím se Equipment liší od Device?

- [ ] Equipment je pasivní struktura, Device aktivní struktura
- [ ] Equipment patří do Core Framework, Device do Full Framework
- [x] Equipment zpracovává materiál, Device nese software a data
- [ ] Equipment smí obsahovat jen software, Device jen hardware

> Equipment je fyzický stroj, který vytváří, přemísťuje či přetváří materiál; Device je IT hardware, na kterém běží software a data. Oba prvky jsou aktivní struktura, přičemž Equipment patří k fyzickým prvkům Full Framework.

## Objekt (Facility) {#facility .term}

**Facility** je fyzická stavba nebo prostředí, které poskytuje prostor a podmínky pro činnost — továrna, sklad, laboratoř, budova datového centra, čistírna odpadních vod. Je to aktivní struktura (rovněž zvláštní druh Node) a obvykle zahrnuje Equipment (composition nebo aggregation). Od prvku **Location** se liší tím, že Facility je stavba se schopností něco vykonávat, zatímco Location jen označuje místo (zeměpisné či logické), kde se prvky nacházejí. **Notace:** ikona tovární budovy.

### ? Distribuční firma modeluje centrální sklad jako budovu s regály a vychystávacími linkami, ve které probíhá skladování. Který prvek je pro sklad nejvhodnější?

- [ ] Location
- [ ] Equipment
- [x] Facility
- [ ] Business Actor

> Fyzická stavba, ve které probíhá činnost a která obsahuje zařízení, je Facility. Location jen označuje místo, Equipment by byly jednotlivé linky a Business Actor je organizační jednotka nebo osoba.

### ? Jaký je rozdíl mezi Facility a Location?

- [ ] Facility je zeměpisné místo, Location budova se stroji
- [x] Facility je aktivní stavba, Location jen označuje místo
- [ ] Facility patří do Business, Location do Technology
- [ ] Facility je pasivní, Location aktivní struktura

> Facility je fyzická stavba v aktivní struktuře, která může vykonávat chování a obsahovat zařízení. Location je kompozitní prvek, který jen říká, kde se jiné prvky nacházejí.

## Distribuční síť (Distribution Network) {#distribution-network .term}

**Distribution Network** je síť, po které se fyzicky přepravuje materiál nebo energie — železniční či silniční síť, potrubí, elektrická rozvodná síť, vodovod, dopravníkový systém mezi halami. Je to aktivní struktura fyzických prvků; propojuje Equipment a Facilities (association) a podobně jako Communication Network může realizovat Path — zde cestu materiálu či energie.

### ? Rafinerie dopravuje ropu potrubím mezi terminálem a zpracovatelskými jednotkami. Kterým prvkem se potrubí modeluje?

- [ ] Communication Network
- [ ] Material
- [ ] Path
- [x] Distribution Network

> Fyzická síť pro přepravu materiálu nebo energie je Distribution Network. Communication Network přenáší data, Path by byla jen logická cesta a Material je samotná ropa.

### ? Co přenáší Distribution Network?

- [x] Materiál nebo energii
- [ ] Data a zprávy mezi uzly
- [ ] Události mezi procesy
- [ ] Artifacts mezi servery

> Distribution Network je fyzickým protějškem Communication Network: místo dat přepravuje materiál nebo energii (zboží, ropu, elektřinu, vodu).

## Materiál (Material) {#material .term}

**Material** je hmotná fyzická látka nebo předmět — surovina, palivo, díl, hotový výrobek, obal. Je to pasivní struktura fyzických prvků (stejně jako Artifact specializace Technology Object). Technologické chování k materiálu přistupuje (access), Equipment ho zpracovává a Distribution Network přepravuje. **Notace:** ikona šestiúhelníku.

### ? Co z následujícího se modeluje jako Material?

- [ ] Vysokozdvižný vozík v expedičním skladu
- [x] Paleta hotových výrobků k expedici
- [ ] Sklad hotových výrobků v Kolíně
- [ ] Rozvodná síť stlačeného vzduchu

> Hotové výrobky jsou hmota, se kterou se pracuje, tedy Material. Vozík je Equipment, sklad Facility a rozvodná síť stlačeného vzduchu Distribution Network.

### ? Lisovací linka zpracovává ocelové plechy na díly. Jaký vztah vede z prvku Lisování (Technology Process) na Ocelový plech (Material)?

- [ ] assignment
- [ ] serving
- [ ] realization
- [x] access

> Chování pracuje s pasivním prvkem vztahem access, stejně jako proces s Artifact. Assignment vede od aktivní struktury ke chování, serving od služby k uživateli a realization by tvrdila, že proces plech uskutečňuje.

## Fyzické × IT prvky {#fyzicke-vs-it .compare}

Fyzické prvky mají v IT části Technology Layer zřetelné protějšky.

| IT prvek | Fyzický protějšek | Co mají společné | Rozdíl |
|---|---|---|---|
| Device | Equipment | aktivní struktura, „stroj" vykonávající chování | Device pracuje s daty a nese software, Equipment s materiálem |
| Node (prostředí) | Facility | prostředí, ve kterém další prvky fungují | Facility je fyzická stavba |
| Communication Network | Distribution Network | síť propojující uzly, může realizovat Path | data × materiál či energie |
| Artifact | Material | pasivní struktura (Technology Object) | data × hmota |

### ? Který fyzický prvek je obdobou prvku Artifact z IT části Technology Layer?

- [x] Material
- [ ] Equipment
- [ ] Facility
- [ ] Distribution Network

> Artifact i Material jsou pasivní struktura technologické vrstvy (Technology Object): Artifact jsou data, Material hmota. Ostatní prvky jsou aktivní struktura.

### ? Energetická společnost modeluje přenosovou soustavu vysokého napětí i datovou síť pro dálkové řízení rozvoden. Které přiřazení prvků je správné?

- [ ] Přenosová soustava = Communication Network, datová síť = Distribution Network
- [x] Přenosová soustava = Distribution Network, datová síť = Communication Network
- [ ] Obě sítě = Distribution Network, protože obě slouží energetice
- [ ] Obě sítě = Path, protože obě propojují rozvodny a elektrárny

> Přenos energie je úlohou Distribution Network, přenos dat Communication Network. O typu prvku rozhoduje, co se přenáší, ne obor podnikání; Path by byla jen logická cesta bez popisu konkrétní sítě.
