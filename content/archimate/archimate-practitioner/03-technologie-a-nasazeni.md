---
kind: topic
subject: archimate-practitioner
slug: technologie-a-nasazeni
name: "Modelování technologie a nasazení ve scénářích"
order: 3
---

Nody, zařízení, systémový software, artefakty a jejich realizace, sítě a cesty, cloud a infrastruktura.

## Node × Device × System Software {#node-device-sw .compare}

Všechny tři prvky jsou aktivní struktura Technology Layer; Device i System Software jsou specializace Node. Volba závisí na tom, jaký detail stakeholder potřebuje.

| | Node | Device | System Software |
|---|---|---|---|
| Co představuje | výpočetní zdroj, který hostí a zpracovává jiné zdroje; často spojení hardwaru a softwaru v jeden celek | fyzický IT prostředek (hardware), na kterém běží software a jsou uložené artefakty | softwarové prostředí, ve kterém běží jiný software (operační systém, DBMS, aplikační server, middleware) |
| Kdy použít | logický celek typu „produkční databázový server", když rozdělení na HW a SW nikoho nezajímá, nebo jako kompozit | záleží na konkrétním hardwaru: server, notebook, mobil, terminál, síťový prvek, senzor | záleží na platformě a verzi: Linux, PostgreSQL 16, Tomcat, hypervisor |
| Typická chyba | jeden Node na každou knihovnu nebo službu | operační systém nebo virtuální stroj jako Device | vlastní aplikace (CRM) jako System Software — aplikace je Application Component |

### ? Logistická firma dokumentuje sklad. Skladníci používají ruční čtečky čárových kódů s operačním systémem Android, na kterých běží aplikace Sklad Mobile. Provozní tým potřebuje v modelu vidět konkrétní hardware i jeho operační systém. Který fragment modelu je správný?

- [x] `Ruční čtečka (Device) —assignment→ Android (System Software)`
- [ ] `Ruční čtečka (Equipment) —assignment→ Android (System Software)`
- [ ] `Android (Device) —assignment→ Ruční čtečka (System Software)`
- [ ] `Ruční čtečka (Device) —assignment→ Android (Application Component)`

> Čtečka je fyzický IT hardware, tedy Device, a Android je System Software, který na něm běží. Equipment je fyzické vybavení (stroje, nástroje) z Physical elements, ne výpočetní zařízení; prohozené typy obracejí význam a Android není aplikace, ale softwarové prostředí.

### ? Banka připravuje přehled infrastruktury pro CIO. U produkčního databázového serveru nikoho nezajímá, jaký je v něm hardware, operační systém a databázový stroj — stačí jeden prvek, na kterém jsou nasazené databázové artefakty. Který typ prvku je nejvhodnější?

- [ ] Device, protože server je vždy fyzický stroj
- [ ] System Software, protože hlavní je databázový stroj
- [x] Node, protože představuje celek bez rozlišení HW a SW
- [ ] Technology Collaboration, protože server spojuje více částí

> Node je obecný výpočetní zdroj a hodí se právě tehdy, když se nemá rozlišovat hardware a software. Device by zdůraznil jen hardware, System Software jen software a Technology Collaboration je seskupení více nodů pro společné chování, ne jeden server.

### ? Tým pojišťovny namodeloval tento fragment: `Server DB01 (Device) —assignment→ RHEL 9 (System Software)`; `Oracle Database 19c (Device) —assignment→ Databáze smluv (Artifact)`; `Databáze smluv (Artifact) —realization→ Smlouva (Data Object)`. Co je v modelu chybně?

- [ ] RHEL 9 má být Device, protože operační systém je součást serveru
- [ ] Artifact nemůže realizovat Data Object, jen Application Component
- [ ] Nasazení artefaktu se má modelovat vztahem realization
- [x] Oracle Database 19c je System Software, ne Device

> Databázový stroj je softwarové prostředí, tedy System Software; Device je jen hardware. Operační systém je také System Software, Artifact smí realizovat Data Object (fyzická podoba dat) a nasazení artefaktu se modeluje vztahem assignment.

## Node jako kompozit {#node-kompozit .explain}

Node lze složit (composition) z Device a System Software — vznikne jeden prvek, který lze v přehledu ukázat jako celek a v detailu rozbalit. Že software běží na konkrétním hardwaru, vyjadřuje vztah assignment od Device k System Software. Oba pohledy (views) jsou výřezy **téhož modelu**: přehled ukáže jen Node, detailní pohled pro provoz i jeho části. Prvky se nezdvojují — stejný server má být v modelu jednou a různé pohledy ho jen různě podrobně zobrazují.

*Příklad:* `Platební server (Node) —composition→ Dell R750 (Device)`; `Platební server (Node) —composition→ JBoss EAP (System Software)`; `Dell R750 (Device) —assignment→ JBoss EAP (System Software)`.

### ? Provoz e-shopu chce mít jeden prvek „Platební server", který lze v přehledu ukázat jako celek, ale v detailu má být vidět, že ho tvoří hardware Dell R750 a aplikační server JBoss EAP. Který fragment modelu to správně zachycuje?

- [ ] `Platební server (Node) —realization→ Dell R750 (Device)`; `Platební server (Node) —realization→ JBoss EAP (System Software)`
- [ ] `Dell R750 (Device) —composition→ Platební server (Node)`; `JBoss EAP (System Software) —composition→ Platební server (Node)`
- [x] `Platební server (Node) —composition→ Dell R750 (Device)`; `Platební server (Node) —composition→ JBoss EAP (System Software)`
- [ ] `Platební server (Node) —serving→ Dell R750 (Device)`; `Platební server (Node) —serving→ JBoss EAP (System Software)`

> Vztah celek–část se modeluje composition od celku (Node) k částem. Opačný směr by tvrdil, že hardware se skládá ze serveru, realization vyjadřuje uskutečnění abstraktnějšího prvku a serving poskytování služby, nikoli skladbu.

### ? V nemocnici potřebuje vedení přehled „aplikační server pro NIS" a bezpečnostní tým zároveň přesné verze operačního systému a databázového stroje kvůli záplatování. Jak má architekt model uspořádat?

- [ ] Vytvořit dva samostatné modely, jeden pro vedení a jeden pro bezpečnost
- [x] Jeden Node složený z Device a System Software a dva různě podrobné pohledy
- [ ] Verze operačního systému a databáze namodelovat jako Device uvnitř Node
- [ ] Pro bezpečnost vytvořit druhý Node se stejným názvem a doplnit do něj verze

> Pohledy jsou výřezy jednoho modelu, takže Node s částmi stačí zobrazit v přehledu bez detailu a v pohledu pro bezpečnost i s částmi. Dva modely nebo zdvojený Node vedou k nekonzistenci a operační systém ani databáze nejsou hardware, tedy ne Device.

## Typické chyby v typech technologických prvků {#chyby-typu .explain}

Nejčastější chyby v technologickém modelu jsou záměny typu: **operační systém nebo databáze jako Device** (jde o System Software), **server jako Technology Service** (server je aktivní struktura, služba je chování, které server nabízí), **databázový soubor jako Data Object** (fyzický soubor je Artifact, Data Object je logická datová entita aplikační vrstvy) a **vlastní aplikace jako System Software** (aplikace s obchodní funkcionalitou je Application Component, i když běží na serveru). Pomůcka: technologická vrstva poskytuje obecné prostředí, aplikační vrstva obchodně specifickou funkcionalitu.

*Příklad:* `Fakturace (Application Component)` běží v prostředí `Tomcat 10 (System Software)` a data ukládá do `PostgreSQL 16 (System Software)`.

### ? Nemocniční IT provozuje zálohovací server, který zálohuje data nemocničního informačního systému. Tým namodeloval: `Zálohovací server (Technology Service) —serving→ NIS (Application Component)`. Co je na fragmentu nejzásadněji chybně?

- [x] Server je aktivní struktura (Node), která má nabízet službu „Zálohování"
- [ ] Mezi technologickou službou a aplikační komponentou má být realization
- [ ] NIS je software, a proto má být modelován jako System Software
- [ ] Technologická vrstva nesmí aplikační vrstvě nic poskytovat

> Server je strukturní prvek (Node nebo Device), služba je chování, které nabízí — správně je server poskytující Technology Service „Zálohování", která slouží NIS. Serving technologické služby aplikaci je správný vztah, NIS je Application Component a technologie aplikacím služby poskytovat smí.

## Artifact a jeho realizace {#artifact-realizace .explain}

Artifact je fyzický kus dat, který vzniká při vývoji nebo se používá při nasazení a provozu: spustitelný soubor, JAR/WAR, kontejnerový image, skript, konfigurační soubor, databáze. Vztahem **realization** váže fyzickou podobu na logický prvek: `Artifact —realization→ Application Component` (balík, kterým se aplikace uskutečňuje) a `Artifact —realization→ Data Object` (soubor či databáze, ve které jsou logická data uložena). Jednu komponentu může realizovat více artefaktů (frontend a backend) a jeden artefakt může realizovat více datových objektů. Směr vždy vede od fyzického k logickému.

*Příklad:* `pojistky-api.jar (Artifact) —realization→ Správa pojistek (Application Component)`; `POJ_PROD (Artifact) —realization→ Pojistná smlouva (Data Object)`.

### ? E-shop eviduje logický datový objekt Objednávka. Fyzicky jsou objednávky uložené v produkční databázi ESHOP_PROD. Architekt chce zachytit, kde jsou logická data fyzicky uložena. Který fragment je správný?

- [ ] `Objednávka (Data Object) —realization→ ESHOP_PROD (Artifact)`
- [x] `ESHOP_PROD (Artifact) —realization→ Objednávka (Data Object)`
- [ ] `ESHOP_PROD (Data Object) —realization→ Objednávka (Artifact)`
- [ ] `ESHOP_PROD (Artifact) —access→ Objednávka (Data Object)`

> Fyzická databáze je Artifact a realizuje logický Data Object — směr vede od fyzického k logickému. Opačný směr nebo prohozené typy význam převracejí a access je vztah od chování k pasivnímu prvku; artefakt sám nic nečte ani nezapisuje.

### ? Pojišťovna vyvíjí aplikaci Správa pojistek. Build pipeline z ní vytváří soubor pojistky-api.jar, který se nasazuje na servery. Jak modelovat vztah tohoto souboru k aplikaci?

- [ ] `pojistky-api.jar (System Software) —realization→ Správa pojistek (Application Component)`
- [ ] `pojistky-api.jar (Application Component) —composition→ Správa pojistek (Application Component)`
- [ ] `pojistky-api.jar (Data Object) —realization→ Správa pojistek (Application Component)`
- [x] `pojistky-api.jar (Artifact) —realization→ Správa pojistek (Application Component)`

> Nasaditelný balík je Artifact a aplikační komponentu realizuje. Není to System Software (neposkytuje prostředí pro jiný software), není to část logické komponenty a Data Object je logická data, ne spustitelný soubor.

### ? Aplikaci Rezervace tvoří dva nasaditelné balíky: webový frontend rezervace-web.zip a backend rezervace-api.jar. Architekt chce ukázat, které soubory aplikaci fyzicky tvoří. Který fragment je správný?

- [x] `rezervace-web.zip (Artifact) —realization→ Rezervace (Application Component)`; `rezervace-api.jar (Artifact) —realization→ Rezervace (Application Component)`
- [ ] `Rezervace (Application Component) —realization→ rezervace-web.zip (Artifact)`; `Rezervace (Application Component) —realization→ rezervace-api.jar (Artifact)`
- [ ] `rezervace-web.zip (Artifact) —assignment→ Rezervace (Application Component)`; `rezervace-api.jar (Artifact) —assignment→ Rezervace (Application Component)`
- [ ] `rezervace-web.zip (Application Component) —realization→ Rezervace (Artifact)`; `rezervace-api.jar (Application Component) —realization→ Rezervace (Artifact)`

> Jednu komponentu může realizovat více artefaktů a směr vede od fyzického souboru k logické komponentě. Opačný směr i prohozené typy význam převracejí a assignment vychází z aktivní struktury, ne z pasivního artefaktu.

## Nasazení: assignment z Node na Artifact {#nasazeni .explain}

Že je artefakt nasazený (deployed) na určitém prostředí, se modeluje vztahem **assignment** od hostitele k artefaktu: `Node / Device / System Software —assignment→ Artifact`. Hostitele volíme podle potřebné přesnosti: pro přehled stačí Node, pro provoz konkrétní aplikační server (System Software), na kterém balík běží. Typické chyby jsou obrácený směr (od artefaktu k serveru), použití realization (server artefakt „neuskutečňuje") a serving (artefakt není služba ani její uživatel).

*Příklad:* `WildFly 27 (System Software) —assignment→ crm.war (Artifact)`.

### ? Webová aplikace CRM se nasazuje jako soubor crm.war na aplikační server WildFly 27. Provozní tým chce v modelu vidět, kde balík běží. Který fragment je správný?

- [ ] `crm.war (Artifact) —assignment→ WildFly 27 (System Software)`
- [ ] `WildFly 27 (System Software) —realization→ crm.war (Artifact)`
- [x] `WildFly 27 (System Software) —assignment→ crm.war (Artifact)`
- [ ] `crm.war (Artifact) —serving→ WildFly 27 (System Software)`

> Nasazení je assignment od hostitele (zde System Software) k artefaktu. Obrácený směr neodpovídá významu, realization by tvrdila, že server artefakt uskutečňuje, a pasivní artefakt nemůže nic obsluhovat vztahem serving.

### ? Maloobchodní řetězec nasazuje na pokladní terminály soubor pokladna.exe. Architekt chce zachytit, že soubor je nainstalovaný na terminálech typu POS-200. Který vztah z terminálu na soubor je správný?

- [ ] Realization, protože terminál soubor fyzicky uskutečňuje
- [x] Assignment, protože terminál soubor hostí a spouští
- [ ] Composition, protože soubor je na terminálu uložený
- [ ] Serving, protože terminál souboru poskytuje výkon

> Nasazení artefaktu na Device (nebo Node či System Software) se modeluje assignment. Realization váže fyzický prvek na logický, composition by z artefaktu dělala stavební část hardwaru a serving vyjadřuje poskytování služby, ne hostování.

### ? Tým výrobní firmy namodeloval: `skladova-app.exe (Artifact) —assignment→ Terminál ve skladu (Device)`. Co je chybně?

- [ ] Terminál má být System Software, protože hostí aplikaci
- [x] Assignment má opačný směr — vede od terminálu k artefaktu
- [ ] Mezi artefaktem a terminálem má být realization
- [ ] Soubor skladova-app.exe má být Application Component

> Assignment vychází z hostitele (aktivní struktura) a míří na nasazený artefakt, takže správně je `Terminál ve skladu (Device) —assignment→ skladova-app.exe (Artifact)`. Terminál je hardware, tedy Device, spustitelný soubor je Artifact a realization nasazení nevyjadřuje.

## Řetězec nasazení od serveru k aplikaci {#retezec-nasazeni .explain}

Úplný řetězec nasazení vede z technologie do aplikační vrstvy: `Node —assignment→ Artifact —realization→ Application Component`. Na něm je vidět, na kterém prostředí běží konkrétní soubor a kterou aplikaci uskutečňuje — to potřebuje provoz, plánování kapacit i analýza dopadu výpadku. Běží-li tentýž balík na více serverech (vysoká dostupnost), každý server má vlastní assignment na stejný artefakt. Když stakeholdera zajímá jen to, na jakých technologických službách aplikace závisí, stačí kratší vzor `Technology Service —serving→ Application Component` bez artefaktů.

*Příklad:* `HR server (Node) —assignment→ hr.war (Artifact) —realization→ HR systém (Application Component)`.

### ? Provoz chce u personálního systému vidět, na kterém serveru běží a který soubor je na něm nasazený. Který řetězec to správně zachycuje?

- [ ] `HR systém (Application Component) —realization→ hr.war (Artifact) —assignment→ HR server (Node)`
- [ ] `HR server (Node) —realization→ hr.war (Artifact) —assignment→ HR systém (Application Component)`
- [ ] `HR server (Node) —serving→ hr.war (Artifact) —serving→ HR systém (Application Component)`
- [x] `HR server (Node) —assignment→ hr.war (Artifact) —realization→ HR systém (Application Component)`

> Server hostí artefakt (assignment) a artefakt realizuje aplikační komponentu (realization). Obrácený řetězec převrací směr obou vztahů, prohozené vztahy nedávají smysl (server artefakt neuskutečňuje) a pasivní artefakt nemůže nic obsluhovat.

### ? Rezervační aplikace hotelového řetězce běží kvůli dostupnosti ve dvou instancích na serverech A a B; na obou je nasazený stejný balík rezervace.jar. Který fragment situaci správně zachycuje?

- [x] `Server A (Node) —assignment→ rezervace.jar (Artifact)`; `Server B (Node) —assignment→ rezervace.jar (Artifact)`
- [ ] `rezervace.jar (Artifact) —composition→ Server A (Node)`; `rezervace.jar (Artifact) —composition→ Server B (Node)`
- [ ] `Server A (Node) —realization→ rezervace.jar (Artifact)`; `Server B (Node) —realization→ rezervace.jar (Artifact)`
- [ ] `Server A (Node) —flow→ Server B (Node)`; `Server B (Node) —assignment→ rezervace.jar (Artifact)`

> Každý hostitel má vlastní assignment na nasazený artefakt, takže stejný balík může být nasazený na více serverech. Artefakt se ze serverů neskládá, realization nasazení nevyjadřuje a flow mezi servery by ukazovala jen přenos, přičemž nasazení na server A by chybělo.

## Technology Service × Technology Function × Technology Process {#tech-chovani .compare}

Technologické chování se modeluje stejně jako v ostatních vrstvách: aktivní struktura je přiřazena (assignment) k internímu chování a to realizuje externí službu.

| | Technology Service | Technology Function | Technology Process |
|---|---|---|---|
| Pohled | externí — co technologie nabízí ostatním | interní — schopnost seskupená podle zdrojů a dovedností | interní — sled kroků s výsledkem |
| Typický název | „Hostování databází", „Úložiště souborů", „Fronty zpráv" | „Správa databází", „Monitoring" | „Noční záloha", „Nasazení nové verze" |
| Kdo je napojen | slouží (serving) aplikacím, případně business vrstvě | Node je k ní přiřazen (assignment), realizuje službu | Node je k němu přiřazen, spouští ho událost (triggering) |
| Typická chyba | pojmenovat službu jako server („DB server") | modelovat ji jako službu, i když ji nikdo zvenku nevolá | použít ji tam, kde nejde o pořadí kroků |

### ? IT oddělení poskytuje aplikačním týmům hostování databází. Uvnitř to zajišťuje databázový cluster, který vykonává správu databází. Který fragment je správný?

- [ ] `DB cluster (Node) —assignment→ Hostování databází (Technology Service) —realization→ Správa databází (Technology Function)`
- [x] `DB cluster (Node) —assignment→ Správa databází (Technology Function) —realization→ Hostování databází (Technology Service)`
- [ ] `DB cluster (Node) —realization→ Správa databází (Technology Function) —assignment→ Hostování databází (Technology Service)`
- [ ] `Hostování databází (Technology Service) —assignment→ Správa databází (Technology Function) —realization→ DB cluster (Node)`

> Aktivní struktura je přiřazena k internímu chování (function) a to realizuje externí službu. První možnost prohazuje službu a funkci, třetí prohazuje vztahy a čtvrtá staví službu do role vykonavatele a realizuje strukturu chováním.

### ? Telekomunikační firma popisuje svou platformu. Aplikace mohou přes API ukládat soubory; dále platforma interně přeorganizovává indexy, což žádná aplikace nevolá ani nevidí. Jak tyto dvě věci nejlépe modelovat?

- [ ] Obě jako Technology Service, protože je obě vykonává platforma
- [ ] Ukládání jako Technology Function a údržbu indexů jako Technology Service
- [x] Ukládání jako Technology Service a údržbu indexů jako Technology Function
- [ ] Obě jako Technology Interface, protože aplikace platformu volají přes API

> Ukládání souborů je chování nabízené ostatním, tedy služba; údržba indexů je interní činnost, kterou nikdo zvenku nevolá, tedy funkce. Služba znamená, že ji někdo konzumuje, a Technology Interface je přístupový bod (API), ne samotné chování.

## Technologie slouží aplikacím {#tech-slouzi-aplikaci .explain}

Aplikace se na technologii napojuje přes služby: `Technology Service —serving→ Application Component` (nebo Application Function / Application Process, chceme-li ukázat, které chování službu využívá). Služba odstiňuje aplikaci od konkrétního hardwaru — když se vymění servery, model závislosti aplikace se nemění, mění se jen to, který Node službu realizuje. Směr serving vede od poskytovatele k uživateli; obrácený směr (aplikace slouží technologii) je typická chyba.

*Příklad:* `Úložiště souborů (Technology Service) —serving→ Fakturace (Application Component)`; `Souborový cluster (Node) —realization→ Úložiště souborů (Technology Service)`.

### ? Architekt plánuje kapacity a chce zachytit, že aplikace CRM závisí na databázové platformě, kterou provozuje IT. Konkrétní servery a nasazené soubory ho teď nezajímají. Který fragment je nejvhodnější?

- [ ] `CRM (Application Component) —serving→ Databázová služba (Technology Service)`
- [ ] `Databázová služba (Technology Service) —realization→ CRM (Application Component)`
- [ ] `CRM (Application Component) —assignment→ Databázová služba (Technology Service)`
- [x] `Databázová služba (Technology Service) —serving→ CRM (Application Component)`

> Technologická služba slouží aplikační komponentě; směr vede od poskytovatele k uživateli. Obrácený serving tvrdí, že aplikace slouží platformě, služba aplikaci nerealizuje a assignment by z aplikace dělal vykonavatele technologické služby.

### ? Pět aplikací pojišťovny používá centrální úložiště souborů. Servery úložiště se mají příští rok vyměnit a architekt chce, aby se kvůli tomu nemusel měnit popis závislostí aplikací. Jak závislosti nejlépe modelovat?

- [x] Úložiště jako Technology Service, která slouží každé z pěti aplikací
- [ ] Servery úložiště jako Device se vztahem serving ke každé aplikaci
- [ ] Každá aplikace se vztahem assignment ke všem serverům úložiště
- [ ] Úložiště jako Artifact realizující všech pět aplikací najednou

> Závislost přes technologickou službu odstíní aplikace od konkrétních serverů — při výměně se změní jen to, kdo službu realizuje. Vazba přímo na servery by se při výměně musela přepsat, assignment od aplikace k serverům nedává smysl a úložiště není artefakt realizující aplikace.

### ? Funkce aplikace Generování faktur vytváří PDF dokumenty a k jejich převodu používá centrální konverzní službu technologické platformy. Tým namodeloval: `Generování faktur (Application Function) —serving→ Konverze do PDF (Technology Service)`. Co je chybně?

- [ ] Application Function nemůže využívat technologickou službu, jen komponenta
- [ ] Konverze do PDF má být Application Service, protože vytváří dokument
- [x] Serving má opačný směr — služba slouží aplikační funkci, ne naopak
- [ ] Mezi funkcí a službou má být místo serving vztah access

> Poskytovatelem je technologická služba, uživatelem aplikační funkce, takže správně `Konverze do PDF (Technology Service) —serving→ Generování faktur (Application Function)`. Technologická služba smí sloužit i aplikačnímu chování, obecná konverze formátu je technologická služba a access vede k pasivním prvkům.

## Technology Interface {#tech-interface .term}

Přístupový bod, přes který technologie zpřístupňuje své služby aplikacím nebo jiným nodům — například síťový endpoint, protokolové rozhraní databáze, rozhraní message brokeru nebo administrační konzole platformy. Bývá částí nodu (composition) a je přiřazen (assignment) ke službě, kterou zpřístupňuje. Modeluje se, když záleží na tom, *jak* se ke službě přistupuje (protokol, port, kanál); jinak stačí samotná Technology Service.

### ? Databázová platforma nabízí aplikacím službu Hostování databází přes SQL endpoint na portu 5432 a správcům přes webovou konzoli. Bezpečnostní tým chce v modelu vidět oba přístupové body. Který typ prvku pro ně použít?

- [ ] Path, protože jde o spojení mezi aplikací a databází
- [x] Technology Interface, protože jde o přístupové body služby
- [ ] Communication Network, protože se přistupuje po síti
- [ ] Technology Service, protože každý přístup je samostatná služba

> Přístupové body, přes které se služba technologie zpřístupňuje, jsou Technology Interface. Path je logické spojení mezi nody, Communication Network síťová infrastruktura a služba vyjadřuje chování, ne místo přístupu — jedna služba může mít více rozhraní.

### ? Message broker (System Software) nabízí aplikacím službu Fronty zpráv přes rozhraní AMQP. Architekt chce ukázat, že rozhraní je částí brokeru a zpřístupňuje tuto službu. Který fragment je správný?

- [ ] `Broker (System Software) —composition→ AMQP (Path)`; `AMQP (Path) —assignment→ Fronty zpráv (Technology Service)`
- [ ] `Broker (System Software) —composition→ AMQP (Technology Interface)`; `Fronty zpráv (Technology Service) —assignment→ AMQP (Technology Interface)`
- [x] `Broker (System Software) —composition→ AMQP (Technology Interface)`; `AMQP (Technology Interface) —assignment→ Fronty zpráv (Technology Service)`
- [ ] `Broker (System Software) —composition→ AMQP (Application Interface)`; `AMQP (Application Interface) —assignment→ Fronty zpráv (Technology Service)`

> Technologické rozhraní je částí nodu (composition) a je přiřazeno ke službě, kterou zpřístupňuje (assignment od rozhraní ke službě). Path je spojení mezi nody, opačný assignment staví službu do role aktivní struktury a broker patří do technologické vrstvy, takže jeho rozhraní není Application Interface.

## Path × Communication Network {#path-network .compare}

Oba prvky propojují nody, ale na jiné úrovni: Path je logické spojení, Communication Network skutečná síť, která ho uskutečňuje.

| | Path | Communication Network |
|---|---|---|
| Co představuje | logický komunikační kanál mezi dvěma či více nody, po kterém si vyměňují data | fyzická či skutečná síťová infrastruktura (LAN, WAN, MPLS, internet, mobilní síť) |
| Kdy použít | zajímá nás, *mezi kterými* nody komunikace probíhá (VPN tunel, replikační kanál) | zajímá nás, *přes jakou* síť komunikace jde |
| Vztah mezi nimi | je realizována sítí | `Communication Network —realization→ Path` |
| Typická chyba | Path mezi dvěma aplikacemi místo flow v aplikační vrstvě | síť modelovaná jako Node |

### ? Pobočky pojišťovny komunikují s centrálou šifrovaným VPN tunelem, který vede přes veřejný internet. Síťový architekt chce zachytit logické spojení i síť, přes kterou fyzicky jde. Který fragment je správný?

- [ ] `VPN pobočka–centrála (Path) —realization→ Internet (Communication Network)`
- [ ] `Internet (Path) —realization→ VPN pobočka–centrála (Path)`
- [ ] `Internet (Communication Network) —realization→ VPN pobočka–centrála (Technology Interface)`
- [x] `Internet (Communication Network) —realization→ VPN pobočka–centrála (Path)`

> Logické spojení mezi nody je Path a skutečná síť, která ho uskutečňuje, je Communication Network realizující Path. Opačný směr převrací význam, internet není logický kanál a VPN tunel není přístupový bod služby.

### ? Síťový tým chce v datovém centru ukázat lokální síť, která propojuje databázové a aplikační servery. Který typ prvku pro tuto síť použít?

- [x] Communication Network
- [ ] Path
- [ ] Technology Collaboration
- [ ] Node

> Skutečná síťová infrastruktura propojující servery je Communication Network. Path je jen logický kanál mezi nody, Technology Collaboration je seskupení nodů pro společné chování a síť není výpočetní zdroj, tedy ani Node.

### ? Tým e-shopu chtěl ukázat, že aplikace Objednávky posílá data aplikaci Sklad, a namodeloval mezi oběma Application Component prvek Path. Co je nejlepší oprava?

- [ ] Nahradit Path prvkem Communication Network mezi oběma aplikacemi
- [ ] Ponechat Path a doplnit k ní Technology Interface na obou stranách
- [ ] Nahradit Path vztahem serving od aplikace Sklad k aplikaci Objednávky
- [x] Nahradit Path vztahem flow od aplikace Objednávky k aplikaci Sklad

> Přenos dat mezi aplikacemi se v aplikační vrstvě modeluje vztahem flow ve směru toku dat; Path i Communication Network propojují nody v technologické vrstvě. Serving by vyjadřoval poskytování služby v opačném smyslu, ne předávání dat.

## Technology Collaboration a Technology Interaction {#tech-kolaborace .explain}

Když dva nebo více nodů vykonává chování **společně** a toto společné chování chceme ukázat, použijeme **Technology Collaboration**, která nody seskupuje (aggregation), a k ní přiřazenou (assignment) **Technology Interaction**. Typicky jde o replikaci mezi primárním a záložním serverem nebo o synchronizaci mezi datovými centry. Interakce z definice vyjadřuje chování aspoň dvou účastníků, proto ji nepřiřazujeme jedinému nodu. Pokud je společné chování nezajímavé a cluster se navenek chová jako jeden celek, stačí Node složený z dalších nodů.

*Příklad:* `Replikační dvojice (Technology Collaboration) —aggregation→ DB primární (Node)`; `Replikační dvojice (Technology Collaboration) —aggregation→ DB záložní (Node)`; `Replikační dvojice (Technology Collaboration) —assignment→ Synchronní replikace (Technology Interaction)`.

### ? Banka má primární databázový server v Praze a záložní v Brně. Oba servery společně provádějí synchronní replikaci dat a architekt chce právě toto společné chování v modelu ukázat. Který fragment je nejvhodnější?

- [ ] `DB Praha (Node) —assignment→ Synchronní replikace (Technology Process)`; `DB Brno (Node) —serving→ DB Praha (Node)`
- [x] `Replikační dvojice (Technology Collaboration) —aggregation→ DB Praha, DB Brno (Node)`; `Replikační dvojice —assignment→ Synchronní replikace (Technology Interaction)`
- [ ] `Synchronní replikace (Technology Collaboration) —aggregation→ DB Praha, DB Brno (Node)`; `Synchronní replikace —assignment→ Replikační dvojice (Technology Interaction)`
- [ ] `Replikační dvojice (Path) —aggregation→ DB Praha, DB Brno (Node)`; `Replikační dvojice —assignment→ Synchronní replikace (Technology Interaction)`

> Společné chování více nodů je Technology Interaction přiřazená Technology Collaboration, která nody seskupuje. Proces přiřazený jen pražskému serveru neukazuje společné vykonávání, třetí možnost zaměňuje strukturu a chování a Path je komunikační kanál, ne vykonavatel chování.

### ? Tým namodeloval: `DB primární (Node) —assignment→ Replikace dat (Technology Interaction)` a záložní server do modelu nezahrnul. Replikaci přitom provádějí oba servery společně. Co je chybně?

- [ ] Replikace má být Technology Service, protože ji servery nabízejí
- [ ] Mezi nodem a interakcí má být realization, ne assignment
- [ ] Replikace má být Technology Event, protože probíhá průběžně
- [x] Interakci vykonávají oba servery, záložní server jako účastník chybí

> Technology Interaction je chování, které vykonávají společně dva či více nodů, proto musí být v modelu oba servery — obvykle jako Technology Collaboration, ke které je interakce přiřazena. Replikace mezi servery není nabízená služba, aktivní struktura se k chování váže assignment a událost je okamžik, ne probíhající činnost.

## Technology Process a Technology Event {#tech-proces-udalost .explain}

Plánované a dávkové činnosti infrastruktury (zálohy, noční dávky, nasazení verze, rotace logů) se modelují jako **Technology Process** spuštěný **Technology Event** (triggering). Proces pracuje s artefakty vztahem access: čte zálohovanou databázi (`read`), zapisuje archiv (`write`). Vykonavatel (Node, System Software) je k procesu přiřazen (assignment). Událost je okamžik nebo podnět (čas, poplach, dokončení jiné úlohy), ne činnost.

*Příklad:* `Čas 2:00 (Technology Event) —triggering→ Noční záloha (Technology Process)`; `Noční záloha (Technology Process) —access (read)→ DB_PROD (Artifact)`; `Noční záloha (Technology Process) —access (write)→ zaloha.tar (Artifact)`.

### ? Každou noc ve 2:00 se v e-shopu automaticky spustí záloha, která čte produkční databázi DB_PROD. Provoz chce v modelu vidět spouštěč i práci s daty. Který fragment je správný?

- [x] `Čas 2:00 (Technology Event) —triggering→ Noční záloha (Technology Process)`; `Noční záloha —access (read)→ DB_PROD (Artifact)`
- [ ] `Čas 2:00 (Technology Event) —flow→ Noční záloha (Technology Process)`; `Noční záloha —realization→ DB_PROD (Artifact)`
- [ ] `Čas 2:00 (Technology Service) —triggering→ Noční záloha (Technology Process)`; `Noční záloha —access (read)→ DB_PROD (Artifact)`
- [ ] `Čas 2:00 (Technology Event) —triggering→ Noční záloha (Technology Process)`; `DB_PROD (Artifact) —serving→ Noční záloha`

> Spouštěč je Technology Event, který proces spouští vztahem triggering, a proces databázi čte vztahem access (read). Flow vyjadřuje předání informace, ne spuštění, a záloha databázi nerealizuje; okamžik není služba a pasivní artefakt nic neobsluhuje.

### ? Proces Noční záloha (Technology Process) vytváří každou noc nový soubor archivu zaloha.tar. Který vztah mezi procesem a archivem je správný?

- [ ] `Noční záloha (Technology Process) —access (read)→ zaloha.tar (Artifact)`
- [ ] `Noční záloha (Technology Process) —access (write)→ zaloha.tar (Data Object)`
- [x] `Noční záloha (Technology Process) —access (write)→ zaloha.tar (Artifact)`
- [ ] `Noční záloha (Technology Process) —assignment→ zaloha.tar (Artifact)`

> Proces archiv vytváří, tedy do něj zapisuje (access write), a fyzický soubor je Artifact. Režim read by znamenal jen čtení, Data Object je logická data aplikační vrstvy a assignment vychází z aktivní struktury, ne z procesu.

## Cloud: IaaS, PaaS a SaaS {#cloud-modely .compare}

ArchiMate nemá zvláštní prvky pro cloud; v praxi se cloudové modely skládají z běžných prvků. Rozhoduje, co dodává poskytovatel a co zůstává na firmě.

| | IaaS | PaaS | SaaS |
|---|---|---|---|
| Poskytovatel dodává | virtuální výpočetní kapacitu, úložiště, síť | spravovanou platformu (databáze, běhové prostředí, fronty) | hotovou aplikační funkcionalitu |
| Jak modelovat nabídku | Technology Service (např. „Virtuální servery") | Technology Service, kterou realizuje platforma poskytovatele (System Software / Node) | Application Service (případně Application Interface) aplikace poskytovatele |
| Co modeluje firma jako své | operační systém, platformy a artefakty na pronajatých nodech | jen vlastní artefakty nasazené na platformě (schéma, balík aplikace) | business prvky, které službu používají; žádné vlastní artefakty ani nody |
| Typická chyba | zapomenout, že operační systém spravuje firma | modelovat spravovanou databázi jako vlastní Device | modelovat SaaS jako Technology Service |

### ? Obchodní oddělení firmy používá cloudový CRM v modelu SaaS — přihlašuje se přes prohlížeč a o servery ani software se nestará. Architekt chce ukázat, jak tato nabídka podporuje proces Prodej. Který fragment je nejvhodnější?

- [ ] `Správa příležitostí (Technology Service) —serving→ Prodej (Business Process)`
- [ ] `Cloud CRM (Device) —assignment→ Prodej (Business Process)`
- [ ] `Prodej (Business Process) —serving→ Správa příležitostí (Application Service)`
- [x] `Správa příležitostí (Application Service) —serving→ Prodej (Business Process)`

> SaaS dodává aplikační funkcionalitu, proto se nabídka modeluje jako Application Service, která slouží business procesu. Technology Service by z obchodní funkcionality dělala obecnou infrastrukturu, hardware k procesu přiřadit nelze a obrácený serving převrací směr závislosti.

### ? Firma přesouvá databázi objednávek do spravované cloudové databáze (PaaS). Poskytovatel se stará o servery, operační systém i databázový stroj; firma do platformy nasazuje jen své schéma OBJ_SCHEMA. Který fragment nejlépe vystihuje stranu firmy?

- [x] `Spravovaná SQL (Technology Service) —serving→ Objednávky (Application Component)`; `OBJ_SCHEMA (Artifact) —realization→ Objednávka (Data Object)`
- [ ] `DB server (Device) —assignment→ OBJ_SCHEMA (Artifact)`; `DB server (Device) —serving→ Objednávky (Application Component)`
- [ ] `Spravovaná SQL (Application Component) —serving→ Objednávky (Application Component)`; `OBJ_SCHEMA (Data Object) —realization→ Objednávka (Artifact)`
- [ ] `Objednávky (Application Component) —serving→ Spravovaná SQL (Technology Service)`; `Objednávka (Data Object) —realization→ OBJ_SCHEMA (Artifact)`

> U PaaS firma využívá technologickou službu poskytovatele a modeluje jen vlastní artefakt, který realizuje její data. Vlastní Device popírá, že hardware spravuje poskytovatel, databázová platforma není aplikační komponenta s obchodní funkcionalitou a čtvrtá možnost obrací směr obou vztahů.

### ? Firma nahrazuje vlastní mzdový systém mzdovou aplikací v modelu SaaS. Co se v cílovém modelu typicky změní?

- [ ] Vlastní nody zůstanou a jen se přejmenují na cloudové servery
- [x] Vlastní nody a artefakty mezd zmizí; mzdy podporuje služba poskytovatele
- [ ] Mzdová aplikace se přesune z Application Layer do Technology Layer
- [ ] Mzdový proces se změní na Application Process poskytovatele

> U SaaS firma neprovozuje infrastrukturu ani nasazené soubory, takže vlastní nody a artefakty mezd z modelu odpadnou a proces podporuje Application Service poskytovatele. Přejmenování nodů by zkreslilo odpovědnost, aplikace zůstává aplikací a business proces mezd zůstává procesem firmy.

## Hranice odpovědnosti v cloudu {#cloud-hranice .explain}

Interní uspořádání poskytovatele (datová centra, disky, jeho servery) firma obvykle nezná a nemá ho pod kontrolou, proto se modeluje jako **černá skříňka**: jen služby, které poskytovatel nabízí, a případně jejich rozhraní. Hranici odpovědnosti lze vyznačit prvkem **Grouping** (např. „Poskytovatel cloudu"), který prvky na straně poskytovatele seskupuje (aggregation). **Location** je pro geografické umístění (region, datové centrum), ne pro hranici odpovědnosti. Detailně se modeluje to, co firma sama spravuje a za co odpovídá.

*Příklad:* `Poskytovatel cloudu (Grouping) —aggregation→ Objektové úložiště (Technology Service)`; `Objektové úložiště (Technology Service) —serving→ Archiv dokumentů (Application Component)`.

### ? Pojišťovna začne ukládat dokumenty do objektového úložiště veřejného cloudu. Junior architekt chce do modelu zakreslit datová centra, disková pole a servery poskytovatele. Co je nejlepší doporučení?

- [ ] Namodelovat všechny servery a disky poskytovatele jako Device, aby byl model úplný
- [ ] Úložiště do modelu nezahrnovat, protože ho firma neprovozuje
- [x] Modelovat úložiště jako službu poskytovatele, která slouží aplikacím firmy
- [ ] Namodelovat úložiště jako vlastní Device firmy umístěný v cloudu

> Infrastrukturu poskytovatele firma nezná ani neřídí, proto se modeluje jako černá skříňka — nabízená Technology Service se vztahem serving k vlastním aplikacím. Detail poskytovatele by byl nepodložený, vynechání by skrylo závislost a vlastní Device by zkreslil odpovědnost.

### ? Architekt chce v modelu vizuálně i logicky vyznačit, které technologické služby zajišťuje externí cloudový poskytovatel a které vlastní IT, bez ohledu na to, kde služby fyzicky běží. Který prvek je pro to nejvhodnější?

- [ ] Location „Cloud" seskupující služby poskytovatele
- [x] Grouping „Poskytovatel cloudu" seskupující jeho služby
- [ ] Communication Network „Cloud" propojující služby poskytovatele
- [ ] Technology Collaboration „Cloud" seskupující služby poskytovatele

> Grouping seskupuje prvky podle libovolného hlediska, zde podle odpovědnosti. Location vyjadřuje geografické umístění, Technology Collaboration seskupuje nody pro společné chování (ne služby) a Communication Network je síťová infrastruktura.

## Virtualizace {#virtualizace .explain}

Ve virtualizovaném prostředí je fyzický hostitel **Device** a hypervizor (VMware ESXi, Hyper-V, KVM) **System Software**. Virtuální stroj není fyzický hardware, proto se nemá modelovat jako Device — běžný vzor je **Node** (případně jeho specializace „Virtual Machine"), složený z hostovaného operačního systému (System Software), na který se nasazují artefakty. Jakým vztahem přesně spojit hypervizor a virtuální stroj, specifikace nepředepisuje; zvolte jednu konvenci a dodržujte ji v celém modelu.

*Příklad:* `ESX-01 (Device) —assignment→ VMware ESXi (System Software)`; `VM-ERP (Node) —composition→ Windows Server 2022 (System Software)`.

### ? Datové centrum výrobní firmy běží na fyzických serverech s hypervizorem VMware ESXi, nad kterým běží desítky virtuálních strojů. Jaký typ prvku je pro VMware ESXi správný?

- [ ] Device, protože je nainstalovaný přímo na hardwaru
- [x] System Software, protože poskytuje prostředí pro jiný software
- [ ] Technology Function, protože vykonává virtualizaci
- [ ] Communication Network, protože propojuje virtuální stroje

> Hypervizor je software, který poskytuje běhové prostředí pro virtuální stroje, tedy System Software. Instalace přímo na hardware z něj Device nedělá, virtualizace je jeho chování, ne on sám, a síť to není.

### ? Tým namodeloval virtuální stroje jako `VM-ERP (Device)` a `VM-CRM (Device)` běžící na fyzickém serveru ESX-01. Co je nejlepší oprava?

- [ ] Ponechat Device, protože virtuální stroj se chová jako hardware
- [ ] Modelovat virtuální stroje jako Artifact nasazené na ESX-01
- [ ] Modelovat virtuální stroje jako Technology Service serveru ESX-01
- [x] Modelovat virtuální stroje jako Node složené z hostovaného OS

> Device je vyhrazen fyzickému IT hardwaru, virtuální stroj jím není; běžný vzor je Node složený z hostovaného operačního systému. Image disku virtuálního stroje by sice byl artefakt, ale běžící stroj hostí další software, a Technology Service je chování, ne výpočetní zdroj.

## Kontejnery {#kontejnery .explain}

U kontejnerů se drží jasné jádro: **kontejnerový image** je Artifact, který realizuje Application Component; **běhové prostředí kontejnerů** (Docker Engine, containerd) je System Software, které image hostí (assignment); stroje, na kterých běží, jsou Node nebo Device. Jak modelovat orchestraci (cluster, pody, jmenné prostory), specifikace neupravuje — v praxi se používá Node, System Software nebo specializace; zvolte jednu konvenci. Typická chyba je modelovat image jako Application Component (to je logická aplikace, image je její fyzický balík) nebo jako Data Object.

*Příklad:* `objednavky:1.4 (Artifact) —realization→ Objednávky (Application Component)`; `containerd (System Software) —assignment→ objednavky:1.4 (Artifact)`.

### ? Vývojový tým balí aplikaci Objednávky do kontejnerového image objednavky:1.4, který se nasazuje do produkce. Jak modelovat vztah image k aplikaci?

- [ ] `objednavky:1.4 (Data Object) —realization→ Objednávky (Application Component)`
- [ ] `objednavky:1.4 (System Software) —realization→ Objednávky (Application Component)`
- [x] `objednavky:1.4 (Artifact) —realization→ Objednávky (Application Component)`
- [ ] `Objednávky (Application Component) —realization→ objednavky:1.4 (Artifact)`

> Image je fyzický nasaditelný balík, tedy Artifact, a logickou aplikaci realizuje. Data Object jsou logická data, image sám neposkytuje prostředí pro jiný software (není System Software) a realization vede od fyzického k logickému, ne obráceně.

### ? Image objednavky:1.4 běží v běhovém prostředí containerd na produkčním serveru. Provoz chce zachytit, kde je image nasazený. Který fragment je správný?

- [x] `containerd (System Software) —assignment→ objednavky:1.4 (Artifact)`
- [ ] `objednavky:1.4 (Artifact) —assignment→ containerd (System Software)`
- [ ] `containerd (Application Component) —assignment→ objednavky:1.4 (Artifact)`
- [ ] `containerd (System Software) —realization→ objednavky:1.4 (Artifact)`

> Nasazení se modeluje assignment od hostitele k artefaktu a běhové prostředí kontejnerů je System Software. Obrácený směr význam převrací, containerd není aplikace s obchodní funkcionalitou a realization nasazení nevyjadřuje.
