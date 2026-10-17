---
kind: topic
subject: archimate-foundation
slug: vazby-vrstev
name: "Vztahy mezi vrstvami"
order: 7
---

Business–Application (serving, realization, access), Application–Technology, vazba na fyzickou vrstvu; typické vzory propojení vrstev.

## Princip propojení vrstev {#princip-propojeni .explain}

Vrstvy Business, Application a Technology se propojují dvěma hlavními způsoby. **Serving** — nižší vrstva poskytuje vyšší vrstvě služby a rozhraní, které ta využívá („aplikace slouží byznysu", „infrastruktura slouží aplikacím"). **Realization** — prvek nižší vrstvy uskutečňuje prvek vyšší vrstvy: data realizují informace, artefakt realizuje aplikaci, aplikační proces automatizuje business proces. Pasivní prvky se mezi vrstvami propojují realizací (Artifact → Data Object → Business Object). Oba typy vztahů tak typicky míří „nahoru": Serving k uživateli, Realization k abstraktnějšímu prvku.

*Příklad:* Evidence pojistek (Application Service) —serving→ Sjednání pojistky (Business Process); Smlouva (Data Object) —realization→ Pojistná smlouva (Business Object).

### ? Jakými dvěma hlavními typy vztahů se v ArchiMate propojují vrstvy Business, Application a Technology?

- [x] Serving a Realization
- [ ] Composition a Aggregation
- [ ] Triggering a Flow
- [ ] Specialization a Influence

> Nižší vrstva vyšší vrstvě slouží (Serving) a její prvky realizují prvky vyšší vrstvy (Realization). Composition a Aggregation popisují skladbu, Triggering a Flow dynamiku chování a Specialization s Influence vrstvy nepropojují.

### ? Kterým směrem typicky vedou vztahy Serving mezi vrstvami Business, Application a Technology?

- [ ] Od vyšší vrstvy k nižší, protože byznys aplikace řídí
- [x] Od nižší vrstvy k vyšší, protože nižší vrstva poskytuje služby
- [ ] Oběma směry stejně často, u Serving se směr nerozlišuje
- [ ] Jen mezi sousedními vrstvami, Technology neslouží Business

> Služby nižší vrstvy slouží prvkům vyšší vrstvy, proto Serving vede zdola nahoru. Směr je u Serving podstatný a technologická služba může sloužit i přímo business chování.

### ? Kterým vztahem se mezi vrstvami Business, Application a Technology typicky propojují pasivní prvky (např. Data Object a Business Object)?

- [ ] Serving
- [x] Realization
- [ ] Assignment
- [ ] Flow

> Konkrétnější pasivní prvek nižší vrstvy realizuje abstraktnější prvek vyšší vrstvy (Artifact → Data Object → Business Object). Serving ani Assignment k pasivním prvkům nevedou a Flow spojuje prvky chování.

## Přehled typických vazeb mezi vrstvami {#prehled-vazeb .compare}

| Zdroj | Vztah | Cíl | Význam |
|---|---|---|---|
| Application Service | serving | Business Process, Function, Interaction; Business Actor, Role | aplikace podporuje byznys |
| Application Interface | serving | Business Role, Business Actor | uživatel pracuje s aplikací přes rozhraní |
| Application Process, Function | realization | Business Process, Function | aplikace business chování automatizuje |
| Data Object | realization | Business Object | data jsou digitální podobou informace |
| Technology Service | serving | Application Component | infrastruktura podporuje aplikaci |
| Technology Service | serving | Business Process, Function | technologie podporuje byznys přímo |
| Artifact | realization | Data Object, Application Component | fyzická podoba dat a softwaru |
| Node, System Software | assignment | Artifact | nasazení (deployment) |

### ? Který z uvedených zápisů NENÍ v ArchiMate platnou vazbou mezi vrstvami?

- [ ] Application Service —serving→ Business Process
- [ ] Artifact —realization→ Application Component
- [x] Data Object —assignment→ Business Object
- [ ] Technology Service —serving→ Application Component

> Assignment vede od aktivní struktury k chování nebo k nasazenému artefaktu; pasivní Data Object nemůže být jeho zdrojem. Data Object se k Business Object váže vztahem Realization, ostatní zápisy jsou typické mezivrstvové vazby.

### ? Který prvek Technology Layer typicky realizuje Data Object?

- [ ] Node
- [ ] System Software
- [ ] Technology Service
- [x] Artifact

> Fyzickou podobu dat (soubor, databázové schéma) představuje Artifact, který Data Object realizuje. Node a System Software artefakty hostí (Assignment) a Technology Service slouží aplikacím.

## Aplikační služba slouží byznysu {#app-service-business .explain}

Nejčastější vazba Business–Application je **Application Service —serving→** business chování (Business Process, Business Function, Business Interaction) nebo business aktivní struktura (Business Actor, Business Role). Služba popisuje, co aplikace byznysu nabízí, bez detailů implementace, takže byznys není svázán s konkrétní komponentou. Komponentu lze s byznysem propojit i odvozeně: komponenta realizuje službu, služba slouží procesu, tedy komponenta slouží procesu.

*Příklad:* Výpočet pojistného (Application Service) —serving→ Sjednání pojistky (Business Process).

### ? Proces Sjednání pojistky využívá aplikační službu Výpočet pojistného. Který zápis je správný?

- [ ] Sjednání pojistky (Business Process) —serving→ Výpočet pojistného (Application Service)
- [x] Výpočet pojistného (Application Service) —serving→ Sjednání pojistky (Business Process)
- [ ] Výpočet pojistného (Application Service) —realization→ Sjednání pojistky (Business Process)
- [ ] Sjednání pojistky (Business Process) —access→ Výpočet pojistného (Application Service)

> Aplikační služba poskytuje funkcionalitu procesu, proto Serving vede od služby k procesu. Opačný Serving má chybný směr, Realization by znamenala automatizaci procesu a Access vede jen k pasivním prvkům.

### ? Proč se byznys v modelu obvykle napojuje na Application Service, a ne přímo na Application Component?

- [ ] Application Component nesmí mít žádný vztah k prvkům Business Layer
- [ ] Služba je jediný aplikační prvek, který lze vnořit do business procesu
- [x] Služba vyjadřuje, co aplikace nabízí, bez vazby na její implementaci
- [ ] Application Component se smí propojit jen s prvky Technology Layer

> Služba odděluje to, co byznys potřebuje, od toho, čím je to implementováno, takže výměna komponenty nemění vazbu na byznys. Komponenta s byznysem propojena být může, přinejmenším odvozeně přes službu.

### ? Který prvek Business Layer NEMŮŽE být cílem vztahu Serving od Application Service?

- [ ] Business Process
- [ ] Business Role
- [ ] Business Function
- [x] Business Object

> Serving vede k prvku, který funkcionalitu využívá, tedy k chování nebo aktivní struktuře. Business Object je pasivní a s informacemi se pracuje přes Access.

## Aplikační rozhraní a uživatelé {#app-interface-business .explain}

**Application Interface —serving→ Business Role** (případně Business Actor): přes rozhraní — obrazovku, portál, mobilní aplikaci — pracuje uživatel v určité roli s aplikací. Rozhraní je externí stránkou komponenty (je její součástí) a zpřístupňuje aplikační služby; podrobněji viz téma Application Layer. Zatímco Application Service říká, **co** aplikace byznysu nabízí, Application Interface říká, **kudy** se k tomu uživatel dostane.

*Příklad:* Klientský portál (Application Interface) —serving→ Klient (Business Role).

### ? Bankovní klient pracuje s mobilní aplikací banky. Který zápis vystihuje vazbu rozhraní na uživatele?

- [ ] Klient (Business Role) —serving→ Mobilní bankovnictví (Application Interface)
- [ ] Mobilní bankovnictví (Application Interface) —assignment→ Klient (Business Role)
- [x] Mobilní bankovnictví (Application Interface) —serving→ Klient (Business Role)
- [ ] Mobilní bankovnictví (Application Interface) —realization→ Klient (Business Role)

> Rozhraní slouží roli, která jej používá, proto vede Serving od Application Interface k Business Role. Opačný směr je chybný, Assignment by z rozhraní dělal vykonavatele role a Realization by tvrdila, že rozhraní roli uskutečňuje.

### ? Který aplikační prvek typicky slouží (Serving) Business Role jako místo, kudy uživatel s aplikací pracuje?

- [x] Application Interface
- [ ] Application Event
- [ ] Data Object
- [ ] Application Collaboration

> Přístupový bod, přes který uživatel s aplikací pracuje, je Application Interface. Application Event je událost, Data Object pasivní data a Application Collaboration spolupráce komponent.

## Automatizace business chování {#automatizace .explain}

Když aplikace business proces nebo funkci **sama vykonává** (bez člověka), modeluje se to **realizací**: **Application Process / Application Function —realization→ Business Process / Business Function**. Rozdíl proti Serving: při Serving proces vykonává člověk a aplikace mu pomáhá; při Realization je aplikační chování provedením business chování.

*Příklad:* Automatické párování (Application Process) —realization→ Párování plateb (Business Process).

### ? Párování plateb probíhá zcela automaticky v aplikaci, bez zásahu účetní. Který zápis to nejlépe vystihuje?

- [ ] Párování (Application Process) —serving→ Párování plateb (Business Process)
- [x] Párování (Application Process) —realization→ Párování plateb (Business Process)
- [ ] Párování plateb (Business Process) —realization→ Párování (Application Process)
- [ ] Párování (Application Process) —assignment→ Párování plateb (Business Process)

> Plně automatizované business chování realizuje aplikační proces, proto Realization od aplikačního k business procesu. Serving by znamenal jen podporu člověka, obrácená realizace má chybný směr a Assignment vede od aktivní struktury.

### ? Čím se zápis Application Service —serving→ Business Process liší od zápisu Application Process —realization→ Business Process?

- [x] Serving znamená podporu člověka, Realization že proces provádí aplikace
- [ ] Serving znamená, že proces běží sám, Realization jen podporu uživatele
- [ ] Oba zápisy jsou rovnocenné a liší se pouze grafickou notací čáry
- [ ] Serving je mezi vrstvami zakázán, proto se vždy použije Realization

> Při Serving proces vykonávají lidé a aplikace jim poskytuje služby; Realization vyjadřuje, že business chování je provedeno aplikačním chováním. Zápisy tedy nejsou rovnocenné a Serving je nejběžnější mezivrstvovou vazbou.

### ? Který aplikační prvek typicky realizuje Business Process, když aplikace tento proces plně automatizuje?

- [ ] Application Interface
- [x] Application Process
- [ ] Data Object
- [ ] Application Event

> Business chování realizuje aplikační chování, typicky Application Process (nebo Application Function). Application Interface je přístupový bod, Data Object pasivní data a Application Event událost.

## Informace a data {#data-business-object .explain}

**Data Object —realization→ Business Object**: data v aplikaci jsou digitální podobou informace, se kterou pracuje byznys. Jeden Business Object může být realizován více datovými objekty (údaje o zákazníkovi v CRM i v ERP) a některé Business Objects nemusí mít digitální podobu vůbec (papírový formulář). Směr vede od konkrétnějšího (data) k abstraktnějšímu (informace).

*Příklad:* Zákazník CRM (Data Object) —realization→ Zákazník (Business Object).

### ? Který vztah se v ArchiMate typicky používá mezi Data Object a Business Object?

- [ ] Data Object —serving→ Business Object
- [ ] Business Object —realization→ Data Object
- [ ] Data Object —specialization→ Business Object
- [x] Data Object —realization→ Business Object

> Data Object je konkrétní digitální podobou Business Object, a proto jej realizuje. Opačná realizace má chybný směr, Serving k pasivnímu prvku nevede a Specialization smí spojovat jen prvky stejného typu.

### ? Informace o zákazníkovi je v CRM i v ERP uložena jako dva různé datové objekty. Jak to v modelu vyjádřit?

- [x] Oba Data Objects —realization→ jeden Business Object Zákazník
- [ ] Business Object Zákazník —realization→ oba Data Objects
- [ ] Oba Data Objects —composition→ jeden Business Object Zákazník
- [ ] Business Object Zákazník —serving→ oba Data Objects

> Jedna informace může mít více datových podob; každý Data Object ji realizuje. Obrácená realizace má chybný směr, Composition by z dat dělala části informace a Serving mezi pasivními prvky nedává smysl.

## Práce s informacemi v jednotlivých vrstvách {#access-napric .explain}

S pasivními prvky pracuje chování **ve své vrstvě**: Business Process —access→ Business Object, Application Function —access→ Data Object, technologické chování —access→ Artifact. Vrstvy se pak propojí **realizací pasivních prvků** (Artifact —realization→ Data Object —realization→ Business Object). Tak je vidět, kdo s informací pracuje, v jaké aplikaci jsou data a kde jsou fyzicky uložena.

*Příklad:* Fakturace (Business Process) —access (write)→ Faktura (Business Object); Vystavení faktury (Application Function) —access (write)→ Faktura (Data Object); Faktura (Data Object) —realization→ Faktura (Business Object).

### ? Aplikační funkce Vystavení faktury vytváří datový objekt Faktura. Který zápis je správný?

- [ ] Faktura (Data Object) —access (write)→ Vystavení faktury (Application Function)
- [ ] Vystavení faktury (Application Function) —realization→ Faktura (Data Object)
- [x] Vystavení faktury (Application Function) —access (write)→ Faktura (Data Object)
- [ ] Vystavení faktury (Application Function) —serving→ Faktura (Data Object)

> Chování pracuje s pasivním prvkem přes Access vedený od chování k objektu; zápis vyjadřuje režim write. Pasivní prvek nemůže být zdrojem Access, chování data nerealizuje a Serving k pasivnímu prvku nevede.

### ? Která trojice prvků se v ArchiMate typicky řetězí vztahem Realization od fyzické podoby k informaci?

- [ ] Business Object → Data Object → Artifact
- [ ] Data Object → Artifact → Business Object
- [x] Artifact → Data Object → Business Object
- [ ] Artifact → Business Object → Data Object

> Artifact (soubor, tabulka) realizuje Data Object a ten realizuje Business Object. Realizace vede od konkrétního k abstraktnímu, proto ostatní pořadí neodpovídají.

## Vzor propojení Business–Application {#vzor-business-app .explain}

Typický vzor spojuje „kdo co dělá" s tím, „čím mu aplikace pomáhá" a „co to v aplikaci zajišťuje":

- Business Actor —assignment→ Business Role —assignment→ Business Process
- Application Service —serving→ Business Process (případně —serving→ Business Role)
- Application Interface —serving→ Business Role
- Application Component —assignment→ Application Function —realization→ Application Service
- Application Function —access→ Data Object —realization→ Business Object, s nímž pracuje Business Process (access)

*Příklad:* Referent (Business Role) —assignment→ Posouzení žádosti (Business Process); Kontrola údajů (Application Service) —serving→ Posouzení žádosti; Registr žadatelů (Application Component) —assignment→ Validace (Application Function) —realization→ Kontrola údajů.

### ? Který řetězec správně zachycuje, jak aplikace podporuje business proces?

- [ ] Application Component —serving→ Application Function —realization→ Application Service —assignment→ Business Process
- [x] Application Component —assignment→ Application Function —realization→ Application Service —serving→ Business Process
- [ ] Business Process —serving→ Application Service —realization→ Application Function —assignment→ Application Component
- [ ] Application Component —realization→ Application Function —assignment→ Application Service —serving→ Business Process

> Komponenta funkci vykonává (Assignment), funkce realizuje službu (Realization) a služba slouží procesu (Serving). Ostatní řetězce mají prohozené vztahy nebo obrácený směr.

### ? Jan Novák (Business Actor) zastává roli Referent (Business Role), která vykonává proces Posouzení žádosti (Business Process). Referent při práci využívá aplikační službu Kontrola údajů (Application Service). Který další vztah odpovídá typickému vzoru?

- [ ] Referent (Business Role) —realization→ Kontrola údajů (Application Service)
- [ ] Kontrola údajů (Application Service) —assignment→ Posouzení žádosti (Business Process)
- [ ] Jan Novák (Business Actor) —composition→ Kontrola údajů (Application Service)
- [x] Kontrola údajů (Application Service) —serving→ Referent (Business Role)

> Aplikační služba může sloužit nejen procesu, ale i roli, která ji využívá. Role službu nerealizuje, služba proces nevykonává (Assignment vede od aktivní struktury) a aktér se ze služby neskládá.

## Technologická služba slouží aplikaci {#tech-service-app .explain}

Hlavní vazba Application–Technology je **Technology Service —serving→ Application Component**: infrastruktura (databáze, hosting, fronty zpráv, úložiště) poskytuje aplikaci služby, které potřebuje k běhu. Technologickou službu realizuje technologické chování vykonávané Node nebo System Software. Stejně jako byznys se i aplikace váže na službu, ne na konkrétní server, takže výměna infrastruktury nemusí měnit vazbu.

*Příklad:* Databázová služba (Technology Service) —serving→ CRM (Application Component).

### ? Aplikace CRM potřebuje ke svému běhu databázovou službu poskytovanou infrastrukturou. Který zápis je správný?

- [x] Databázová služba (Technology Service) —serving→ CRM (Application Component)
- [ ] CRM (Application Component) —serving→ Databázová služba (Technology Service)
- [ ] Databázová služba (Technology Service) —realization→ CRM (Application Component)
- [ ] CRM (Application Component) —access→ Databázová služba (Technology Service)

> Technologická služba poskytuje funkcionalitu aplikaci, proto Serving vede od služby ke komponentě. Opačný Serving má chybný směr, služba komponentu nerealizuje a Access vede jen k pasivním prvkům.

### ? Která dvojice prvků je typicky spojena vztahem Serving mezi vrstvami Technology a Application (ve směru zdroj → cíl)?

- [ ] Application Component → Technology Service
- [ ] Artifact → Application Component
- [ ] Node → Data Object
- [x] Technology Service → Application Component

> Technologická služba slouží aplikační komponentě. Artifact komponentu realizuje (ne Serving), Data Object je pasivní a Serving k němu nevede a obrácený směr od komponenty ke službě je chybný.

### ? Proč je vhodné napojit aplikaci na Technology Service, a ne přímo na konkrétní Node?

- [x] Služba popisuje, co aplikace od infrastruktury potřebuje, nezávisle na serveru
- [ ] Node nesmí mít v ArchiMate žádný vztah k prvkům Application Layer
- [ ] Technology Service je jediný technologický prvek, který smí mít název
- [ ] Vztah Serving od Node k aplikaci je v ArchiMate 3.2 výslovně zakázán

> Služba odděluje potřebu aplikace od konkrétní implementace; když se server vymění, vazba aplikace na službu zůstává. Node s aplikací propojen být může, např. nasazením artefaktu nebo odvozeným vztahem.

## Artefakt realizuje aplikaci a data {#artifact-realizace .explain}

**Artifact** (spustitelný soubor, instalační balík, databázové schéma, datový soubor) je technologickou podobou prvků aplikační vrstvy: **Artifact —realization→ Application Component** a **Artifact —realization→ Data Object**. Díky tomu lze dohledat, který soubor odpovídá které aplikaci a kde jsou data fyzicky uložena. Definice Artifact patří do tématu Technology Layer.

*Příklad:* crm-server.jar (Artifact) —realization→ CRM (Application Component); zakaznici.db (Artifact) —realization→ Zákazníci (Data Object).

### ? Soubor eshop.war obsahuje sestavenou aplikaci E-shop. Jak se vazba zapíše?

- [ ] E-shop (Application Component) —realization→ eshop.war (Artifact)
- [ ] eshop.war (Artifact) —assignment→ E-shop (Application Component)
- [x] eshop.war (Artifact) —realization→ E-shop (Application Component)
- [ ] eshop.war (Artifact) —serving→ E-shop (Application Component)

> Artefakt je fyzickou podobou aplikace, proto ji realizuje. Opačný směr je chybný, Assignment vyjadřuje vykonavatele či nasazení a Serving poskytování funkcionality.

### ? Které dva aplikační prvky typicky realizuje Artifact?

- [ ] Application Service a Application Interface
- [x] Application Component a Data Object
- [ ] Application Function a Application Event
- [ ] Application Process a Application Collaboration

> Artifact je fyzickou podobou softwaru (Application Component) a dat (Data Object). Služby, rozhraní, chování a události aplikační vrstvy artefaktem typicky realizovány nejsou.

## Nasazení (deployment) {#nasazeni .explain}

Že je artefakt nainstalován či uložen na určité infrastruktuře, vyjadřuje **Assignment**: **Node —assignment→ Artifact** nebo **System Software —assignment→ Artifact** (aplikační server, na kterém běží soubor aplikace; databázový systém s uloženým schématem). Spolu s Artifact —realization→ Application Component vzniká řetěz „server → soubor → aplikace", který ukazuje, kde aplikace běží. Vztahy uvnitř Technology Layer (např. Device —assignment→ System Software) patří do tématu Technology Layer.

*Příklad:* Tomcat (System Software) —assignment→ eshop.war (Artifact); eshop.war (Artifact) —realization→ E-shop (Application Component).

### ? V modelu platí Server01 (Node) —assignment→ eshop.war (Artifact) a eshop.war —realization→ E-shop (Application Component). Jaký přímý vztah lze z Server01 k E-shopu odvodit?

- [x] Realization
- [ ] Assignment
- [ ] Serving
- [ ] Composition

> Z řetězce strukturálních vztahů se odvodí nejslabší z nich; Realization je slabší než Assignment. Serving ani Composition v řetězci nejsou.

## Vzor propojení Application–Technology {#vzor-app-tech .explain}

Typický vzor odpovídá na otázky „kde a v jaké podobě aplikace běží" a „co jí infrastruktura poskytuje":

- Node (nebo System Software) —assignment→ Artifact —realization→ Application Component
- Node —assignment→ Technology Function —realization→ Technology Service —serving→ Application Component
- Artifact —realization→ Data Object (kde jsou data fyzicky uložena)

Odvozeně platí Node —realization→ Application Component (přes artefakt) a Node —serving→ Application Component (přes službu).

*Příklad:* DB01 (Node) —assignment→ Správa databáze (Technology Function) —realization→ Databázová služba (Technology Service) —serving→ CRM (Application Component).

### ? Které dva vztahy typicky propojují aplikační a technologickou vrstvu?

- [ ] Application Component —serving→ Technology Service a Data Object —realization→ Artifact
- [ ] Node —composition→ Application Component a Data Object —realization→ Artifact
- [x] Technology Service —serving→ Application Component a Artifact —realization→ Application Component
- [ ] Application Component —assignment→ Node a Artifact —specialization→ Data Object

> Infrastruktura aplikaci slouží (Technology Service —serving→ Application Component) a artefakt je její fyzickou podobou (Artifact —realization→ Application Component). Ostatní dvojice mají obrácený směr nebo spojují prvky nevhodným typem vztahu.

### ? Server DB01 (Node) vykonává technologickou funkci Správa databáze, která realizuje službu Databázová služba; ta slouží aplikaci CRM (Application Component). Jaký přímý vztah lze z DB01 k CRM platně odvodit?

- [ ] Realization
- [x] Serving
- [ ] Assignment
- [ ] Flow

> Řetěz Assignment → Realization → Serving končí závislostním vztahem Serving, který se po strukturálních vztazích přenese až k Node. Strukturální vztah se neodvodí, protože řetěz nekončí strukturálním vztahem, a Flow v řetězci není.

## Technologie přímo pro byznys {#tech-business-primo .explain}

Ne každá technologie potřebuje mezi sebou a byznysem aplikaci. ArchiMate 3 umožňuje, aby **Technology Service —serving→ business chování** (Business Process, Business Function) přímo — např. hlasová telefonie pro call centrum, tisk, Wi-Fi v prodejně nebo řízení strojů ve výrobě. Kde technologie podporuje byznys prostřednictvím aplikace, modeluje se vazba raději přes Application Layer, aby bylo vidět, která aplikace je mezi nimi.

*Příklad:* Hlasová telefonie (Technology Service) —serving→ Vyřízení hovoru (Business Process).

### ? Call centrum využívá k vyřizování hovorů telefonní službu, bez jakékoli zákaznické aplikace. Který zápis je v ArchiMate 3.2 správný?

- [ ] Vyřízení hovoru (Business Process) —serving→ Hlasová telefonie (Technology Service)
- [x] Hlasová telefonie (Technology Service) —serving→ Vyřízení hovoru (Business Process)
- [ ] Hlasová telefonie (Technology Service) —realization→ Vyřízení hovoru (Business Process)
- [ ] Hlasová telefonie (Technology Service) —assignment→ Vyřízení hovoru (Business Process)

> Technologická služba může business procesu sloužit přímo, Serving vede od služby k procesu. Opačný směr je chybný, Realization by znamenala, že telefonie proces provádí, a Assignment vede od aktivní struktury.

### ? Které tvrzení o vazbě Technology Layer na Business Layer v ArchiMate 3.2 platí?

- [ ] Technologie smí byznysu sloužit jen prostřednictvím aplikační vrstvy
- [ ] Technologie se k prvkům byznysu váže výhradně vztahem Association
- [x] Technologická služba může sloužit business chování i přímo
- [ ] Business proces smí realizovat pouze technologický proces

> ArchiMate 3 dovoluje přímou vazbu Technology Service —serving→ business chování, např. pro telefonii či tisk. Vazba přes aplikační vrstvu není povinná a není omezena na Association.

### ? Ve kterém případě je přímá vazba Technology Service —serving→ Business Process nejvhodnější?

- [x] Prodejna používá Wi-Fi a tiskárny bez zvláštní aplikace
- [ ] Obchodníci evidují nabídky v aplikaci CRM na serveru
- [ ] Účetní zadává faktury do ERP běžícího v datovém centru
- [ ] Klient zadává žádost o úvěr v internetovém bankovnictví

> Přímá vazba se hodí, když byznys využívá technologii bez prostředníka v podobě aplikace. V ostatních případech pracují lidé s aplikací (CRM, ERP, bankovnictví), a vazba se proto modeluje přes Application Layer.

## Fyzické prvky a jejich chování {#physical-chovani .explain}

Physical elements (Equipment, Facility, Distribution Network, Material) **nemají vlastní prvky chování**. Činnost strojů a zařízení se modeluje **technologickým chováním** (Technology Process, Technology Function, Technology Event), které je k fyzickému prvku přiřazeno vztahem **Assignment**. Fyzická vrstva tak se zbytkem modelu sdílí technologické chování a služby — a technologická služba může výrobnímu procesu sloužit i přímo, bez aplikace mezi nimi. Definice fyzických prvků patří do tématu Technology Layer.

*Příklad:* Balicí linka (Equipment) —assignment→ Balení zásilek (Technology Process); Řízení strojů (Technology Service) —serving→ Montáž podvozků (Business Process).

### ? Výrobní proces Montáž podvozků (Business Process) přímo využívá technologickou službu Řízení strojů (Technology Service), kterou poskytuje řídicí systém dílny; žádná aplikace mezi nimi není. Který zápis je správný?

- [ ] Montáž podvozků (Business Process) —serving→ Řízení strojů (Technology Service)
- [ ] Řízení strojů (Technology Service) —realization→ Montáž podvozků (Business Process)
- [x] Řízení strojů (Technology Service) —serving→ Montáž podvozků (Business Process)
- [ ] Řízení strojů (Technology Service) —triggering→ Montáž podvozků (Business Process)

> Technologická služba může business procesu sloužit přímo, bez aplikační vrstvy, proto Serving od služby k procesu. Opačný směr je chybný, Realization by tvrdila, že služba proces sama provádí, a Triggering vyjadřuje časovou návaznost chování, ne poskytování služby.

### ? Balicí linka ve skladu automaticky balí zásilky. Který zápis je správný?

- [x] Balicí linka (Equipment) —assignment→ Balení zásilek (Technology Process)
- [ ] Balení zásilek (Technology Process) —assignment→ Balicí linka (Equipment)
- [ ] Balicí linka (Equipment) —realization→ Balení zásilek (Technology Process)
- [ ] Balicí linka (Equipment) —specialization→ Balení zásilek (Technology Process)

> Stroj vykonává technologické chování, proto Assignment od Equipment k Technology Process. Obrácený směr je chybný, Realization nevyjadřuje vykonavatele a Specialization smí spojovat jen prvky stejného typu.

## Vazby technologické a fyzické vrstvy {#physical-vazby .explain}

Typické vazby mezi Technology a Physical:

- **Equipment —assignment→ System Software** — na stroji běží řídicí software (Equipment se zde chová podobně jako Device).
- **technologické chování —access→ Material** — proces zpracovává, mění nebo přemisťuje materiál (suroviny, díly, zboží); Material je pasivní prvek.
- **Facility** (hala, sklad, továrna) vybavení obsahuje a **Distribution Network** propojuje zařízení a místa při přepravě materiálu či energie — obdoba Communication Network.

*Příklad:* Řídicí jednotka (Equipment) —assignment→ Firmware linky (System Software); Lisování (Technology Process) —access→ Plech (Material).

### ? Řídicí jednotka lisovací linky je stroj (Equipment), na kterém běží firmware řídící lis (System Software). Který zápis to správně vyjadřuje?

- [ ] Firmware lisu (System Software) —assignment→ Řídicí jednotka (Equipment)
- [x] Řídicí jednotka (Equipment) —assignment→ Firmware lisu (System Software)
- [ ] Řídicí jednotka (Equipment) —access→ Firmware lisu (System Software)
- [ ] Firmware lisu (System Software) —realization→ Řídicí jednotka (Equipment)

> Software běžící na stroji se k Equipment váže vztahem Assignment od stroje k System Software, stejně jako u Device. Obrácený směr je chybný, Access vede jen k pasivním prvkům a firmware stroj nerealizuje.

## Celý vrstvený řetězec {#vrstveny-retezec .explain}

Propojením vzorů vznikne řetězec od infrastruktury až k byznysu:

- Business Role —assignment→ Business Process
- Application Service —serving→ Business Process
- Application Component —assignment→ Application Function —realization→ Application Service
- Technology Service —serving→ Application Component
- Node —assignment→ Artifact —realization→ Application Component

Takový řetězec umožňuje **analýzu dopadů**: při výpadku Node je vidět, které aplikace na něm běží, které jejich služby přestanou fungovat a které business procesy a role budou zasaženy — a naopak, na čem závisí daný proces.

### ? Server SRV1 (Node) má výpadek. Které prvky modelu lze sledováním vrstveného řetězce označit za zasažené?

- [ ] Pouze artefakty nasazené na serveru, vyšší vrstvy zůstávají beze změny
- [x] Aplikace na serveru nasazené, jejich služby a business procesy, jimž slouží
- [ ] Pouze business procesy, protože aplikace na serveru nijak nezávisí
- [ ] Žádné, protože ArchiMate vztahy mezi vrstvami nedovoluje modelovat

> Řetěz nasazení, realizace a obsluhy vede od Node přes artefakty a aplikace k jejich službám a business procesům, takže dopad lze sledovat až k byznysu. Vztahy mezi vrstvami jsou v ArchiMate běžné a právě kvůli takové analýze užitečné.

### ? Který řetězec čte vrstvy správně od infrastruktury k byznysu?

- [ ] Node —realization→ Artifact —assignment→ Application Component —serving→ Business Process
- [ ] Artifact —assignment→ Node —realization→ Application Component —serving→ Business Process
- [ ] Node —assignment→ Artifact —serving→ Application Component —realization→ Business Process
- [x] Node —assignment→ Artifact —realization→ Application Component —serving→ Business Process

> Node artefakt hostí (Assignment), artefakt realizuje komponentu (Realization) a komponenta (odvozeně přes svou službu) slouží procesu. Ostatní řetězce prohazují vztahy nebo směr.

## Serving × Realization napříč vrstvami {#serving-vs-realization .compare}

| Hledisko | Serving | Realization |
|---|---|---|
| Otázka | Čím nižší vrstva pomáhá vyšší? | Čím je prvek vyšší vrstvy uskutečněn? |
| Vztah vrstev | vyšší vrstva službu nižší vrstvy využívá | prvek nižší vrstvy je provedením či podobou prvku vyšší vrstvy |
| Typické dvojice | Application Service → Business Process; Application Interface → Business Role; Technology Service → Application Component | Application Process → Business Process; Data Object → Business Object; Artifact → Application Component, Data Object |
| Kdo činnost vykonává | člověk či vyšší vrstva, nižší vrstva podporuje | samotná nižší vrstva (např. automatizace) |

### ? Účetní ručně kontroluje faktury a pomáhá si aplikační službou Vyhledání dokladu. Jak se aplikace váže na business proces Kontrola faktur?

- [ ] Realization od Application Service k procesu, aplikace jej provádí
- [ ] Assignment od Application Service k procesu, služba jej vykonává
- [x] Serving od Application Service k procesu, proces vykonává člověk
- [ ] Access od procesu k Application Service, proces z aplikace čte

> Proces vykonává účetní a aplikace ji podporuje, proto Serving od služby k procesu. Realization by znamenala plnou automatizaci, Assignment vede od aktivní struktury a Access k pasivním prvkům.

### ? Ve kterém případě je mezi vrstvami správně Realization, a NE Serving?

- [ ] Mobilní aplikace poskytuje službu, kterou obchodník využívá v terénu
- [ ] Databázová služba je potřebná pro běh aplikace CRM
- [ ] Portál umožňuje klientovi zadat žádost o úvěr online
- [x] Soubor crm.jar je spustitelnou podobou aplikace CRM

> Artefakt, který je fyzickou podobou aplikace, ji realizuje. Ve zbylých případech nižší vrstva vyšší vrstvě poskytuje službu nebo rozhraní, tedy Serving.

## Odvozené vazby napříč vrstvami {#odvozene-napric .explain}

V přehledových pohledech se mezilehlé prvky vynechávají a kreslí se **odvozené vztahy** (pravidla viz téma Vztahy a jejich odvozování):

- Application Component —assignment→ Application Function —realization→ Application Service —serving→ Business Process ⇒ Application Component —serving→ Business Process
- Node —assignment→ Artifact —realization→ Application Component ⇒ Node —realization→ Application Component
- Artifact —realization→ Data Object —realization→ Business Object ⇒ Artifact —realization→ Business Object

Odvozený vztah pohled zjednoduší, ale nenahradí detail — pro analýzu dopadů a odpovědností se vyplatí mít v modelu úplný řetězec.

### ? V modelu platí zakaznici.csv (Artifact) —realization→ Zákazník (Data Object) a Zákazník (Data Object) —realization→ Zákazník (Business Object). Jaký přímý vztah lze z artefaktu k Business Object odvodit?

- [ ] Serving
- [ ] Assignment
- [ ] Composition
- [x] Realization

> Řetěz dvou vztahů Realization dává opět Realization (nejslabší článek řetězce strukturálních vztahů). Serving, Assignment ani Composition v řetězci nejsou.

### ? Manažer chce jednoduchý obrázek „které aplikace podporují které procesy". V modelu je úplný řetězec komponenta → funkce → služba → proces. Jaký vztah mezi Application Component a Business Process v přehledu použijete?

- [x] Odvozený Serving od komponenty k procesu
- [ ] Odvozený Assignment od komponenty k procesu
- [ ] Odvozenou Realization od procesu ke komponentě
- [ ] Triggering od komponenty k procesu

> Řetěz Assignment → Realization → Serving dává odvozený Serving od komponenty k procesu. Assignment by z komponenty dělal vykonavatele business procesu, realizace od procesu má obrácený směr a Triggering vyjadřuje časovou návaznost.

## Product napříč vrstvami {#product-napric .explain}

**Product** (definovaný v tématu Business Layer) seskupuje to, co zákazník dostává jako celek, a to **napříč vrstvami**: může agregovat business služby, **aplikační služby** i **technologické služby**, spolu s Contract a pasivními prvky. Produkt tak propojuje obchodní nabídku s tím, co pro ni zajišťují aplikace a infrastruktura.

*Příklad:* Účet Plus (Product) —aggregation→ Mobilní platby (Application Service); Účet Plus (Product) —aggregation→ Smlouva o účtu (Contract).

### ? Banka nabízí produkt Účet Plus, jehož součástí je aplikační služba Mobilní platby. Který zápis je správný?

- [ ] Mobilní platby (Application Service) —aggregation→ Účet Plus (Product)
- [ ] Účet Plus (Product) —realization→ Mobilní platby (Application Service)
- [x] Účet Plus (Product) —aggregation→ Mobilní platby (Application Service)
- [ ] Účet Plus (Product) —assignment→ Mobilní platby (Application Service)

> Product je celek, který služby seskupuje, proto Aggregation od produktu ke službě. Obrácený směr by ze služby dělal celek, produkt službu nerealizuje ani nevykonává.

### ? Které služby může Product v ArchiMate seskupovat?

- [ ] Pouze business služby, protože Product patří do Business Layer
- [ ] Pouze business a aplikační služby, technologické nikoli
- [x] Business, aplikační i technologické služby
- [ ] Pouze technologické služby zajišťující běh aplikací

> Product může agregovat služby ze všech tří vrstev Core Framework, spolu s Contract a pasivními prvky. Omezení na jednu nebo dvě vrstvy neplatí.

## Typické chyby ve vazbách vrstev {#typicke-chyby .compare}

| Chybně | Správně | Proč |
|---|---|---|
| Business Process —serving→ Application Service | Application Service —serving→ Business Process | služba slouží svému uživateli |
| Business Object —realization→ Data Object | Data Object —realization→ Business Object | realizuje konkrétnější prvek |
| Node —realization→ Artifact | Node —assignment→ Artifact | nasazení je přiřazení |
| Artifact —serving→ Application Component | Artifact —realization→ Application Component | artefakt je fyzickou podobou komponenty |
| Application Component —serving→ Data Object | Application Function (či komponenta) —access→ Data Object | s pasivním prvkem se pracuje přes Access |

### ? Model má zachytit: proces Prodej využívá aplikační službu Ceník; datový objekt Zákazník je digitální podobou informace Zákazník; crm.war je nasazen na serveru Tomcat; crm.war je souborem aplikace CRM. Který zápis má chybný SMĚR?

- [ ] Zákazník (Data Object) —realization→ Zákazník (Business Object)
- [ ] Tomcat (System Software) —assignment→ crm.war (Artifact)
- [ ] crm.war (Artifact) —realization→ CRM (Application Component)
- [x] Prodej (Business Process) —serving→ Ceník (Application Service)

> Služba slouží procesu, takže Serving musí vést od Ceníku k Prodeji. Ostatní zápisy odpovídají zadání: data realizují informaci, server hostí artefakt a artefakt realizuje aplikaci.

### ? Analytik zapsal Server01 (Node) —realization→ crm.war (Artifact), aby vyjádřil, že je soubor na serveru nasazen. Jak model opravit?

- [x] Nahradit vztah zápisem Server01 —assignment→ crm.war
- [ ] Nahradit vztah zápisem crm.war —realization→ Server01
- [ ] Nahradit vztah zápisem Server01 —serving→ crm.war
- [ ] Nahradit vztah zápisem crm.war —specialization→ Server01

> Nasazení artefaktu na Node se modeluje vztahem Assignment od Node k artefaktu. Artefakt server nerealizuje, Serving k pasivnímu prvku nevede a Specialization smí spojovat jen prvky stejného typu.

### ? Analytik zapsal CRM (Application Component) —serving→ Zákazník (Data Object), aby vyjádřil, že CRM údaje o zákaznících ukládá. Co je chybně?

- [ ] Směr: vztah má vést od Data Object k Application Component
- [ ] Typ prvku: místo Data Object má být použit Business Object
- [ ] Vrstva: komponenta a data musí ležet v různých vrstvách
- [x] Typ vztahu: s pasivním prvkem se pracuje vztahem Access

> Serving vede k prvku, který funkcionalitu využívá, a pasivní Data Object nic nevyužívá; ukládání dat se modeluje vztahem Access (write). Data Object i komponenta správně patří do Application Layer.
