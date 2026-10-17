---
kind: topic
subject: archimate-foundation
slug: application-layer
name: "Application Layer"
order: 5
---

Application Component, Collaboration, Interface; Application Function, Process, Interaction, Event, Service; Data Object.

## Application Layer — přehled prvků {#application-prehled .explain}

**Application Layer** popisuje aplikace, jejich chování, služby, které poskytují byznysu i sobě navzájem, a data, se kterými pracují. Struktura vrstvy kopíruje generický metamodel:

- **aktivní struktura** — interní: Application Component, Application Collaboration; externí: Application Interface;
- **chování** — interní: Application Function, Application Process, Application Interaction; externí: Application Service; navíc Application Event;
- **pasivní struktura** — Data Object.

Application Layer nemá vlastní obdobu Business Actor / Role — „vykonavatelem" je komponenta. Jak aplikace slouží byznysu a na čem běží, řeší vazby mezi vrstvami (samostatné téma). Barva (typicky světle modrá) není normativní.

*Příklad:* `CRM (Application Component) —assignment→ Správa kontaktů (Application Function) —realization→ Vyhledání zákazníka (Application Service)`

### ? Který prvek NEPATŘÍ do Application Layer?

- [x] Application Role
- [ ] Application Collaboration
- [ ] Application Event
- [ ] Data Object

> Application Layer nemá prvek Application Role — chování vykonává přímo Application Component, případně Application Collaboration. Collaboration, Event i Data Object do vrstvy patří.

### ? Který prvek tvoří pasivní strukturu Application Layer?

- [ ] Application Interface
- [ ] Application Service
- [ ] Application Event
- [x] Data Object

> Jediným pasivním prvkem Application Layer je Data Object. Application Interface je externí aktivní struktura, Application Service externí chování a Application Event prvek chování.

## Application Component {#application-component .term}

**Application Component** je samostatně nasaditelný a **vyměnitelný** kus softwaru — celý systém (ERP, CRM) nebo jeho modul; nese určitou část funkcionality. Patří do **interní aktivní struktury**. Komponenta je **přiřazena (assignment)** k aplikačním funkcím a procesům, které vykonává, **skládá se (composition)** z podkomponent a ze svých rozhraní, a služby jiných komponent jí **slouží (serving)**. Ikona: obdélník se dvěma malými obdélníčky na levé straně.

*Příklad:* `ERP (Application Component) —composition→ Modul Fakturace (Application Component)`

### ? Co nejlépe vystihuje Application Component?

- [ ] Automatizované chování seskupené podle potřebných schopností
- [x] Modulární a nahraditelná jednotka zapouzdřující funkcionalitu
- [ ] Data uspořádaná tak, aby je bylo možné strojově zpracovat
- [ ] Přístupový bod, přes který se služby zpřístupňují okolí

> Komponenta je strukturní prvek — zapouzdřená, nahraditelná část aplikace. Seskupené automatizované chování je Application Function, strojově zpracovatelná data Data Object a přístupový bod Application Interface.

### ? Kterým vztahem se vyjádří, že komponenta CRM vykonává aplikační funkci „Správa kontaktů"?

- [ ] Realization od komponenty k funkci
- [ ] Composition od funkce ke komponentě
- [x] Assignment od komponenty k funkci
- [ ] Serving od funkce ke komponentě

> Vztah mezi aktivní strukturou a chováním, které vykonává, je assignment. Realization vede od chování ke službě, composition je vztah celek–část a serving poskytování služby.

### ? Do kterého aspektu patří Application Component?

- [x] Interní aktivní struktura
- [ ] Externí aktivní struktura
- [ ] Interní chování
- [ ] Externí chování

> Komponenta je ten, kdo chování vykonává — interní aktivní struktura. Externí aktivní strukturou je Application Interface, interním chováním Application Function a externím chováním Application Service.

## Granularita komponent {#component-granularita .explain}

Application Component lze použít na **různých úrovních**: celý aplikační systém (ERP), jeho modul (Fakturace) nebo menší logická část (služba v mikroslužbové architektuře). Hierarchii vyjadřuje **composition** (část nemůže existovat bez celku) nebo **aggregation** (část může patřit i jinam). Komponenta je **logický** prvek — její nasazení v podobě souborů (Artifact) a běh na infrastruktuře patří do Technology Layer. Dobrý model drží v jednom pohledu podobnou úroveň detailu.

*Příklad:* `E-shop (Application Component) —composition→ Košík (Application Component)`; `E-shop (Application Component) —composition→ Katalog (Application Component)`

### ? Firma chce ukázat, že její systém ERP se skládá z modulů Sklad, Nákup a Fakturace, které bez ERP nemají samostatnou existenci. Který model je vhodný?

- [ ] ERP jako Application Component a moduly jako Application Function
- [ ] ERP jako Application Collaboration agregující tři Application Interface
- [x] ERP a moduly jako Application Component spojené vztahem composition
- [ ] ERP jako Application Service realizovaná třemi Application Component

> Moduly jsou zapouzdřené části systému, tedy také komponenty, a jejich závislost na celku vyjadřuje composition. Modul není jen chování, kolaborace sdružuje spolupracující komponenty a ERP není služba.

### ? Kam patří spustitelné soubory a balíčky, ve kterých je aplikační komponenta nasazena?

- [ ] Do Application Layer jako Data Object
- [ ] Do Application Layer jako podkomponenta
- [ ] Do Business Layer jako Representation
- [x] Do Technology Layer jako Artifact

> Application Component je logický prvek; jeho fyzickou podobu pro nasazení představuje Artifact v Technology Layer. Data Object jsou data, podkomponenta je opět logická a Representation je podoba business objektu.

## Application Collaboration {#application-collaboration .term}

**Application Collaboration** je spojení (agregace) dvou nebo více aplikačních komponent (případně jiných kolaborací), které **spolupracují na společném chování**. Patří do interní aktivní struktury. Kolaborace **agreguje** své komponenty a je **přiřazena (assignment)** k **Application Interaction**. Hodí se tam, kde je výsledek dílem několika systémů dohromady a žádný ho nezajistí sám. Ikona: dva překrývající se kruhy.

*Příklad:* `Platební řetězec (Application Collaboration) —aggregation→ E-shop (Application Component)`; `Platební řetězec (Application Collaboration) —aggregation→ Platební brána (Application Component)`

### ? Kterými vztahy je Application Collaboration typicky spojena se svými komponentami a se společným chováním?

- [ ] Assignment ke komponentám, aggregation k Application Interaction
- [x] Aggregation ke komponentám, assignment k Application Interaction
- [ ] Composition ke komponentám, realization k Application Service
- [ ] Specialization ke komponentám, serving k Application Interaction

> Kolaborace sdružuje komponenty (aggregation) a vykonává společné chování (assignment k interakci). Ostatní kombinace zaměňují význam vztahů nebo jejich cíl.

### ? Do kterého aspektu patří Application Collaboration?

- [ ] Externí aktivní struktura
- [x] Interní aktivní struktura
- [ ] Interní chování
- [ ] Pasivní struktura

> Kolaborace je stejně jako komponenta interní aktivní strukturou — vykonává chování. Externí aktivní strukturou je Application Interface, interním chováním např. Application Interaction.

## Application Interface {#application-interface .term}

**Application Interface** je „vstup" do aplikace: obrazovka či webový formulář, přes které s ní pracuje **člověk**, nebo API či webová služba, přes které ji volá **jiná komponenta** (případně technologický uzel). Patří do **externí aktivní struktury**. Typicky je **součástí (composition)** komponenty a je **přiřazeno (assignment)** k Application Service, kterou zpřístupňuje. Ikona: „lízátko" (kroužek na krátké čárce).

*Příklad:* `CRM (Application Component) —composition→ REST API CRM (Application Interface) —assignment→ Poskytnutí údajů o zákazníkovi (Application Service)`

### ? Který z pojmů se nejlépe modeluje jako Application Interface?

- [x] REST API, přes které e-shop volá skladový systém
- [ ] Ověření dostupnosti zboží prováděné skladovým systémem
- [ ] Záznam o skladové zásobě uložený ve skladovém systému
- [ ] Okamžik, kdy skladový systém zaznamená pokles zásoby

> API je přístupový bod ke službám komponenty — Application Interface. Ověření dostupnosti je chování (funkce nebo služba), záznam o zásobě je Data Object a okamžik změny stavu Application Event.

### ? Kterým vztahem se Application Interface typicky váže ke komponentě, které patří?

- [ ] Realization od rozhraní ke komponentě
- [ ] Assignment od rozhraní ke komponentě
- [x] Composition od komponenty k rozhraní
- [ ] Access od komponenty k rozhraní

> Rozhraní je součástí komponenty, proto composition od celku (komponenty) k části (rozhraní). Realization, assignment ani access tento vztah celek–část nevyjadřují.

## Uživatelské × programové rozhraní {#interface-druhy .explain}

Application Interface pokrývá dva hlavní případy: **uživatelské rozhraní** (obrazovka, webová aplikace, mobilní aplikace), přes které aplikaci používá člověk, a **programové rozhraní** (API, fronta zpráv, webová služba), přes které ji volá jiná komponenta. Jedna komponenta může mít více rozhraní pro tutéž službu. Uživatelské rozhraní typicky slouží byznysové roli, programové jiné komponentě — tyto vazby se kreslí vztahem **serving** (detail vazeb na Business Layer je v tématu o propojení vrstev).

*Příklad:* `Objednávkový systém (Application Component) —composition→ Webový formulář (Application Interface)`; `Objednávkový systém (Application Component) —composition→ Objednávkové API (Application Interface)`; obě `—assignment→ Přijetí objednávky (Application Service)`

### ? Objednávkový systém zpřístupňuje službu „Přijetí objednávky" zákazníkům přes webový formulář a partnerům přes API. Jak se to nejlépe modeluje?

- [ ] Dvě Application Service a jedno Application Interface, které je realizuje
- [ ] Jedno Application Interface agregující dvě Application Component
- [ ] Jedna Application Function a dvě Data Object, ke kterým přistupuje
- [x] Jedna Application Service a dvě Application Interface přiřazená k ní

> Služba je jedna, liší se jen přístupové body — dvě rozhraní přiřazená k téže službě. Rozhraní službu nerealizuje, rozhraní neagreguje komponenty a data s přístupem zákazníků a partnerů nesouvisejí.

### ? Je API, které volají jen jiné systémy (ne lidé), v ArchiMate také Application Interface?

- [ ] Ne, takové API je vždy Application Service bez rozhraní
- [x] Ano, rozhraní může zpřístupňovat služby i jiné komponentě
- [ ] Ne, programová rozhraní patří výhradně do Technology Layer
- [ ] Ano, ale jen pokud je zároveň modelováno jako Data Object

> Application Interface zpřístupňuje služby uživateli, jiné komponentě i uzlu, takže API je typické aplikační rozhraní. Není to služba samotná, nepatří automaticky do technologie a s Data Object nesouvisí.

## Application Function {#application-function .term}

**Application Function** popisuje, co aplikace **automatizovaně dělá** — činnost komponenty pojmenovanou podle oblasti, které se týká (Správa kontaktů, Zaúčtování dokladů), bez určeného pořadí kroků. Patří do **interního chování**. Komponenta je k funkci **přiřazena (assignment)**, funkce **realizuje** aplikační službu a **přistupuje (access)** k datovým objektům. Funkce lze dekomponovat (composition) a propojovat vztahy flow a triggering. Ikona: chevron (jako u Business Function).

*Příklad:* `Účetní systém (Application Component) —assignment→ Zaúčtování dokladů (Application Function) —access (write)→ Účetní záznam (Data Object)`

### ? Do kterého aspektu patří Application Function?

- [x] Interní chování
- [ ] Externí chování
- [ ] Interní aktivní struktura
- [ ] Pasivní struktura

> Aplikační funkce popisuje, co komponenta vnitřně dělá — interní chování. Externím chováním je Application Service, interní aktivní strukturou komponenta a pasivní strukturou Data Object.

### ? Kterým vztahem Application Function typicky souvisí s Application Service, kterou zpřístupňuje okolí?

- [ ] Assignment od funkce ke službě
- [ ] Serving od funkce ke službě
- [ ] Composition od služby k funkci
- [x] Realization od funkce ke službě

> Interní chování realizuje externí chování, tedy funkce realizuje službu. Assignment vede od aktivní struktury k chování, serving od služby k jejímu uživateli a composition je vztah celek–část.

## Application Process {#application-process .term}

**Application Process** je **posloupnost aplikačních činností** vedoucí k určitému výsledku — automatizovaný postup, např. noční dávka, workflow schválení nebo zpracování přijaté zprávy. Patří do **interního chování**; má **pořadí kroků**, které se řetězí vztahem **triggering**, spouští ho Application Event. Je k němu přiřazena komponenta, realizuje aplikační službu a přistupuje k datovým objektům. Ikona: šipka (jako u Business Process).

*Příklad:* `Import plateb (Application Process) —triggering→ Párování plateb (Application Process) —triggering→ Odeslání upomínek (Application Process)`

### ? Který pojem se nejlépe modeluje jako Application Process?

- [ ] Oblast funkcionality „Správa pohledávek" v účetním systému
- [ ] Rozhraní, přes které banka předává výpisy účetnímu systému
- [x] Noční dávka, která načte platby, spáruje je a odešle upomínky
- [ ] Záznam o platbě uložený v databázi účetního systému

> Automatizovaný postup s pořadím kroků a výsledkem je Application Process. Oblast funkcionality je Application Function, rozhraní Application Interface a záznam Data Object.

### ? Co odlišuje Application Process od Application Function?

- [ ] Proces vykonává člověk, funkci vykonává aplikační komponenta
- [ ] Proces je externí chování, funkce je interní chování vrstvy
- [x] Proces má pořadí kroků a směřuje k výsledku, funkce ne
- [ ] Proces nemůže realizovat službu, funkce službu realizovat může

> Aplikační proces je automatizovaná posloupnost kroků, funkce je seskupení chování bez pořadí. Oba vykonává komponenta, oba jsou interní chování a oba mohou realizovat službu.

## Application Interaction {#application-interaction .term}

**Application Interaction** je jednotka **společného aplikačního chování**, které vykonávají dvě nebo více komponent dohromady — např. synchronizace dat mezi dvěma systémy nebo společné ověření platby. Patří do **interního chování**. Typicky je k ní **přiřazena (assignment) Application Collaboration**; interakce může realizovat aplikační službu a přistupovat k datovým objektům. Ikona: kruh rozdělený na dvě poloviny.

*Příklad:* `E-shop a platební brána (Application Collaboration) —assignment→ Autorizace platby (Application Interaction)`

### ? Který prvek aktivní struktury je typicky přiřazen k Application Interaction?

- [ ] Application Interface
- [x] Application Collaboration
- [ ] Data Object
- [ ] Application Event

> Společné chování více komponent vykonává jejich kolaborace. Application Interface se přiřazuje ke službě, Data Object je pasivní prvek a Application Event není aktivní struktura.

### ? Kdy je vhodné použít Application Interaction?

- [x] Když chování zajišťují společně dvě nebo více komponent
- [ ] Když komponenta zpřístupňuje službu jiné komponentě
- [ ] Když komponenta zapisuje data do datového objektu
- [ ] Když jedna komponenta vykonává kroky v daném pořadí

> Interakce vyjadřuje chování, které nelze přičíst jedné komponentě. Zpřístupnění služby řeší služba a rozhraní, zápis dat vztah access a posloupnost kroků jedné komponenty Application Process.

## Application Process × Function × Interaction {#app-process-function-interaction .compare}

Tři druhy **interního chování** Application Layer — všechny mohou realizovat Application Service a přistupovat k Data Object.

| | Application Function | Application Process | Application Interaction |
|---|---|---|---|
| Podstata | seskupení automatizovaného chování | posloupnost kroků k výsledku | společné chování více komponent |
| Pořadí kroků | ne | ano | není podstatou |
| Kdo vykonává | komponenta | komponenta | kolaborace komponent |
| Příklad | Správa skladových karet | Noční uzávěrka skladu | Synchronizace skladu s e-shopem |

### ? Systém pro správu dokumentů má oblast funkcionality „Verzování dokumentů", která nemá pevně dané kroky. Který prvek je vhodný?

- [ ] Application Process
- [ ] Application Interaction
- [ ] Application Event
- [x] Application Function

> Seskupení automatizovaného chování bez pořadí kroků je Application Function. Proces by vyžadoval posloupnost, interakce spolupráci více komponent a událost je okamžitá změna stavu.

### ? Které tvrzení platí pro Application Function, Application Process i Application Interaction současně?

- [ ] Jsou to externí chování zpřístupněná přes Application Interface
- [ ] Vždy je vykonává kolaborace dvou nebo více komponent
- [ ] Mají vždy pevné pořadí kroků řetězených vztahem triggering
- [x] Jsou to interní chování a mohou realizovat Application Service

> Všechny tři patří do interního chování a realizují aplikační služby. Externím chováním je služba, kolaboraci vyžaduje jen interakce a pořadí kroků je typické pro proces.

## Application Event {#application-event .term}

**Application Event** je **změna stavu v aplikaci** nebo v jejím okolí, která může spustit nebo přerušit aplikační chování — přijetí zprávy, uplynutí času (časovač), překročení limitu, dokončení dávky. Nemá trvání. Typicky `Application Event —triggering→ Application Process / Function`; chování může událost i vyvolat. Řadí se k prvkům chování. Ikona: jako u Business Event (šipka s vykrojeným levým koncem).

*Příklad:* `Přijata platba z banky (Application Event) —triggering→ Párování plateb (Application Process)`

### ? Který pojem se nejlépe modeluje jako Application Event?

- [ ] Dávka načítá a páruje platby v daném pořadí
- [x] Každý den ve 2:00 se spustí časovač noční dávky
- [ ] Rozhraní pro příjem bankovních výpisů
- [ ] Bankovní výpis ve strukturované podobě

> Uplynutí času, které spouští chování, je Application Event. Načítání a párování je Application Process, rozhraní Application Interface a výpis Data Object.

### ? Který fragment modelu správně vyjadřuje, že přijetí zprávy spouští její zpracování?

- [x] `Zpráva přijata (Application Event) —triggering→ Zpracování zprávy (Application Process)`
- [ ] `Zpráva přijata (Application Event) —access→ Zpracování zprávy (Application Process)`
- [ ] `Zpracování zprávy (Application Process) —assignment→ Zpráva přijata (Application Event)`
- [ ] `Zpráva přijata (Application Event) —realization→ Zpracování zprávy (Application Process)`

> Spuštění chování událostí vyjadřuje triggering. Access je vztah k pasivnímu prvku, assignment vede od aktivní struktury k chování a realization ke službě.

### ? Které tvrzení o Application Event je správné?

- [ ] Trvá po celou dobu zpracování, které sama spustila
- [ ] Patří do pasivní struktury jako záznam o změně stavu
- [x] Je okamžitá a může vzniknout uvnitř aplikace i mimo ni
- [ ] Je k ní vždy přiřazena Application Collaboration

> Událost je okamžitá změna stavu, která může přijít zvenku (zpráva) i zevnitř (časovač, limit). Nemá trvání, není pasivním prvkem a nevykonává ji kolaborace.

## Application Service {#application-service .term}

**Application Service** je to, co aplikace **nabízí navenek** svým uživatelům — lidem, byznysovým procesům nebo jiným komponentám —, popsané z jejich pohledu a bez ohledu na to, jak je uvnitř zajištěna. Patří do **externího chování**. Službu **realizuje** aplikační funkce, proces nebo interakce, zpřístupňuje ji **Application Interface** (assignment) a svým uživatelům **slouží (serving)**. Pojmenovává se z pohledu uživatele (Vyhledání zákazníka, Výpočet pojistného). Ikona: malý zaoblený obdélník (tvar pilulky).

*Příklad:* `Výpočet pojistného (Application Function) —realization→ Kalkulace pojistného (Application Service) —serving→ Portál pro makléře (Application Component)`

### ? Do kterého aspektu patří Application Service?

- [x] Externí chování
- [ ] Externí aktivní struktura
- [ ] Interní chování
- [ ] Interní aktivní struktura

> Aplikační služba je chování viditelné okolím — externí chování. Externí aktivní strukturou je Application Interface, interním chováním funkce či proces a interní aktivní strukturou komponenta.

### ? Který vztah vede od Application Service ke komponentě, která službu využívá?

- [ ] Realization
- [ ] Assignment
- [ ] Triggering
- [x] Serving

> Služba slouží svému uživateli, i když je jím jiná komponenta — serving. Realization vede ke službě od chování, assignment od rozhraní ke službě a triggering vyjadřuje časovou návaznost.

### ? Který název nejlépe odpovídá prvku Application Service?

- [ ] Databáze adres zákazníků
- [ ] Adresní modul systému CRM
- [x] Ověření adresy zákazníka
- [ ] Endpoint /adresa/v1 rozhraní AdresaAPI

> Služba se pojmenovává podle toho, co uživatel dostane — „Ověření adresy zákazníka". Databáze adres je Data Object (či technologie), modul je Application Component a endpoint API je přístupový bod, tedy součást Application Interface.

## Služba jako pohled zvenku {#app-service-pohled .explain}

**Application Service** popisuje aplikaci jako „černou skříňku": co nabízí, ne jak to uvnitř dělá. Uživatel (byznysový proces nebo jiná komponenta) se váže na **službu**, ne přímo na interní funkci či proces. Za službou lze vyměnit realizaci — jinou funkci i jinou komponentu — a uživatelé služby se to nedozvědí. Jedna služba může být realizována více funkcemi a jedna funkce může realizovat více služeb.

*Příklad:* `Starý ceník (Application Component) —assignment→ Výpočet ceny (Application Function) —realization→ Cenová kalkulace (Application Service)`; po migraci se změní jen komponenta a funkce, služba `Cenová kalkulace (Application Service)` zůstane.

### ? Proč se jiné komponenty napojují na Application Service, a ne přímo na interní Application Function poskytovatele?

- [ ] Vztah serving mezi funkcí a komponentou jazyk v žádném případě nezná
- [x] Realizaci služby lze změnit, aniž by se to dotklo jejích uživatelů
- [ ] Interní funkce jsou neviditelné, a proto je nelze v modelu nakreslit
- [ ] Služba automaticky určuje technologii, na které komponenta běží

> Služba odděluje „co" od „jak", takže výměna interní funkce či komponenty nemění vazby uživatelů. Funkce se v modelu kreslit dají a služba o technologii nic neříká.

### ? Jaký je typický vztah mezi počtem aplikačních služeb a funkcí, které je realizují?

- [ ] 1:1 — každá funkce realizuje právě jednu službu a služba jednu funkci
- [ ] 1:N — služba realizuje více funkcí, ale funkce patří jedné službě
- [ ] Žádný — služby a funkce spolu v modelu nesmějí být propojeny
- [x] M:N — služba může mít více realizací a funkce realizovat více služeb

> Realizace služby není omezena na jednu funkci a funkce může stát za několika službami. Směr realizace vede od funkce ke službě, ne obráceně, a propojení je naopak typické.

## Application Service × Application Interface {#app-service-vs-interface .compare}

Obojí je **externí** — služba říká **co** aplikace nabízí, rozhraní **kudy** se k tomu přistupuje.

| | Application Service | Application Interface |
|---|---|---|
| Aspekt | externí chování | externí aktivní struktura |
| Příklad | Ověření bonity klienta | REST API, obrazovka „Klient" |
| Vazba na komponentu | realizuje ji funkce / proces komponenty | composition z komponenty |
| Vzájemný vztah | — | interface —assignment→ service |
| K uživateli | serving | serving |

### ? Který fragment modelu správně spojuje rozhraní a službu?

- [ ] `Ověření bonity (Application Service) —assignment→ Bonitní API (Application Interface)`
- [x] `Bonitní API (Application Interface) —assignment→ Ověření bonity (Application Service)`
- [ ] `Bonitní API (Application Interface) —realization→ Ověření bonity (Application Service)`
- [ ] `Ověření bonity (Application Service) —composition→ Bonitní API (Application Interface)`

> Rozhraní zpřístupňuje službu, proto assignment vede od rozhraní ke službě. Službu realizuje chování, ne rozhraní, a služba rozhraní neobsahuje.

### ? Které tvrzení o Application Service a Application Interface je správné?

- [x] Obě jsou externí, služba je chování a rozhraní je struktura
- [ ] Obě jsou interní, služba je struktura a rozhraní je chování
- [ ] Služba je interní chování a rozhraní je pasivní struktura
- [ ] Rozhraní je externí chování a služba je aktivní struktura

> Služba i rozhraní tvoří externí pohled na komponentu: služba jako externí chování, rozhraní jako externí aktivní struktura. Ostatní tvrzení aspekty zaměňují.

## Application Component × Application Function {#component-vs-function .compare}

Častá záměna: komponenta je **kdo / co** (struktura), funkce je **co dělá** (chování).

| | Application Component | Application Function |
|---|---|---|
| Aspekt | interní aktivní struktura | interní chování |
| Otázka | který systém či modul | jakou činnost vykonává |
| Příklad | Skladový systém, Modul Fakturace | Správa zásob, Vystavení faktury |
| Vzájemný vztah | component —assignment→ function | — |
| Ke službě | přes rozhraní (assignment) | realization → service |
| K datům | — | access → Data Object |

### ? Analytik namodeloval „Fakturace" jako Application Component i jako Application Function. Kdy je tento dvojí model správný?

- [ ] Nikdy, stejný název nesmí mít v modelu dva prvky různého typu
- [ ] Jen když jsou oba prvky spojeny vztahem specialization
- [x] Když jde o modul systému i o chování, které modul vykonává
- [ ] Jen když je funkce zároveň modelována jako Data Object

> Modul (struktura) a jeho chování (funkce) jsou různé pojmy a mohou se jmenovat podobně; spojuje je assignment od komponenty k funkci. Specialization se mezi různými typy prvků nepoužívá a s Data Object to nesouvisí.

### ? Který fragment modelu správně spojuje komponentu, funkci a službu?

- [x] `Sklad (Application Component) —assignment→ Správa zásob (Application Function) —realization→ Dostupnost zboží (Application Service)`
- [ ] `Správa zásob (Application Function) —assignment→ Sklad (Application Component) —realization→ Dostupnost zboží (Application Service)`
- [ ] `Sklad (Application Component) —realization→ Správa zásob (Application Function) —assignment→ Dostupnost zboží (Application Service)`
- [ ] `Dostupnost zboží (Application Service) —assignment→ Správa zásob (Application Function) —realization→ Sklad (Application Component)`

> Komponenta je přiřazena k funkci, kterou vykonává, a funkce realizuje službu. Ostatní varianty obracejí směr nebo zaměňují assignment s realization.

## Data Object {#data-object .term}

**Data Object** jsou **data strukturovaná pro automatizované zpracování** — záznam zákazníka, objednávka v databázi, zpráva s fakturou. Patří do **pasivní struktury** Application Layer: sám nic nevykonává, aplikační chování k němu **přistupuje (access)**. Je to logický pojem; jeho fyzickou podobu (soubor, databázová tabulka) představuje Artifact v Technology Layer a jeho byznysový význam Business Object (vazby mezi vrstvami jsou samostatné téma). Může být agregací jiných datových objektů. Ikona: obdélník s pruhem nahoře (jako Business Object).

*Příklad:* `Přijetí objednávky (Application Function) —access (write)→ Objednávka (Data Object)`

### ? Co nejlépe vystihuje Data Object?

- [ ] Fyzický soubor nasazený na serveru, který obsahuje data aplikace
- [ ] Byznysový pojem nezávislý na tom, zda je podporován aplikací
- [ ] Vnímatelná podoba informace, např. tištěný formulář či e-mail
- [x] Data uspořádaná do struktury vhodné pro strojové zpracování

> Data Object je logický pasivní prvek aplikační vrstvy určený ke strojovému zpracování. Fyzický soubor je Artifact, byznysový pojem Business Object a vnímatelná podoba Representation.

### ? Kterým vztahem se vyjádří, že aplikační funkce čte data o zákaznících?

- [ ] Serving od Data Object k funkci
- [x] Access (read) mezi funkcí a Data Object
- [ ] Assignment od Data Object k funkci
- [ ] Realization od funkce k Data Object

> Práci chování s pasivním prvkem vyjadřuje access, zde v režimu read. Data neposkytují službu, nejsou aktivní strukturou a funkce je nerealizuje.

### ? Do kterého aspektu patří Data Object?

- [ ] Interní aktivní struktura
- [ ] Externí aktivní struktura
- [x] Pasivní struktura
- [ ] Interní chování

> Data Object sám nic nevykonává, chování k němu jen přistupuje — pasivní struktura. Aktivní strukturou jsou komponenty, kolaborace a rozhraní, interním chováním funkce, procesy a interakce.

## Data Object × Business Object × Artifact {#data-vs-business-object .compare}

Tři pasivní prvky ze tří vrstev se snadno zaměňují; liší se úrovní abstrakce. Jak se navzájem propojují, patří k vazbám mezi vrstvami.

| | Business Object | Data Object | Artifact |
|---|---|---|---|
| Vrstva | Business | Application | Technology |
| Podstata | byznysový pojem / informace | data pro automatizované zpracování | fyzický soubor, tabulka, balíček |
| Závislost na IT | ne | ano, logicky | ano, fyzicky |
| Příklad | Pojistná smlouva | Záznam smlouvy v pojistném kmeni | Soubor smlouvy.xml, tabulka SMLOUVA |

### ? Pojišťovna eviduje smlouvy v systému Pojistný kmen jako strukturovaný záznam. Který prvek nejlépe vystihuje tento záznam?

- [ ] Business Object
- [ ] Artifact
- [x] Data Object
- [ ] Representation

> Strukturovaný záznam určený pro aplikační zpracování je Data Object. Business Object je byznysový pojem smlouvy nezávislý na IT, Artifact fyzický soubor či tabulka a Representation vnímatelná podoba informace.

### ? Které tvrzení o prvcích Business Object, Data Object a Artifact je správné?

- [ ] Všechny patří do Application Layer, liší se jen detailem
- [ ] Data Object je aktivní prvek, ostatní dva jsou pasivní
- [ ] Artifact je logický prvek, Data Object je jeho fyzická podoba
- [x] Všechny jsou pasivní, každý však patří do jiné vrstvy

> Business Object (Business), Data Object (Application) i Artifact (Technology) jsou pasivní struktura. Fyzickou podobou je Artifact, ne Data Object.

## Přístup k datům (access) {#app-access .explain}

Aplikační chování (funkce, proces, interakce) pracuje s Data Object vztahem **access**. Režim se vyznačuje šipkou, která ukazuje **směr toku dat**: **read** — šipka od datového objektu k chování, **write** — šipka od chování k datovému objektu, **readwrite** — šipky na obou koncích, **access** bez šipky = režim neurčen. Kreslí se tečkovanou čarou. Přístup se typicky modeluje od **chování** (funkce, procesu, interakce); komponenta pracuje s daty prostřednictvím chování, které vykonává.

*Příklad:* `Párování plateb (Application Process) —access (read)→ Bankovní výpis (Data Object)`; `Párování plateb (Application Process) —access (write)→ Úhrada faktury (Data Object)`

### ? Kam ukazuje šipka vztahu access v režimu write?

- [x] Od chování k Data Object, ve směru toku dat
- [ ] Od Data Object k chování, ve směru čtení dat
- [ ] Na oba konce, protože zápis vždy zahrnuje čtení
- [ ] Nikam, režim write se šipkou nevyznačuje

> Šipka u access ukazuje směr toku dat; při zápisu data tečou z chování do datového objektu. Šipka k chování znamená read, šipky na obou koncích readwrite a čára bez šipky neurčený režim.

### ? Funkce „Přepočet cen" načte ceník, upraví ceny a uloží ho zpět. Který režim vztahu access je vhodný?

- [ ] Read
- [x] Readwrite
- [ ] Write
- [ ] Access bez režimu

> Funkce data čte i zapisuje, proto readwrite. Read nebo write by zachytily jen polovinu práce s daty a access bez režimu by informaci o směru vynechal, ač je známá.

## Flow a triggering mezi aplikacemi {#app-flow-triggering .explain}

Dynamické vztahy v Application Layer: **triggering** vyjadřuje, že jedno chování (nebo událost) **spouští** další — časová či příčinná návaznost; **flow** vyjadřuje **předání dat** z jednoho chování do druhého, bez nutnosti přímého spuštění. Kromě funkcí a procesů se flow v praxi často kreslí i přímo mezi **komponentami** (např. v přehledech integrací) jako zkrácený zápis toku dat mezi chováním, které komponenty vykonávají.

*Příklad:* `E-shop (Application Component) —flow→ ERP (Application Component)` s popiskem „objednávky"

### ? E-shop každou hodinu předává nové objednávky do systému ERP, který je zpracuje podle vlastního plánu. Který vztah mezi komponentami nejlépe vyjadřuje předání dat?

- [ ] Triggering od E-shopu k ERP
- [ ] Composition od ERP k E-shopu
- [ ] Specialization od E-shopu k ERP
- [x] Flow od E-shopu k ERP

> Předání dat bez přímého spuštění zpracování vyjadřuje flow. Triggering by znamenal, že e-shop zpracování přímo spouští; composition je vztah celek–část a specialization vztah podtypu.

### ? Čím se liší vztahy triggering a flow mezi dvěma aplikačními procesy?

- [ ] Triggering vyjadřuje předání dat, flow vyjadřuje spuštění
- [ ] Triggering je strukturální vztah, flow je vztah závislosti
- [x] Triggering vyjadřuje spuštění, flow předání dat či informací
- [ ] Triggering je jen mezi událostmi, flow jen mezi procesy

> Triggering zachycuje časovou či příčinnou návaznost (jedno chování spustí další), flow přenos informací. Oba jsou dynamické vztahy a oba lze použít mezi procesy i s událostmi.

## Typické vztahy uvnitř Application Layer {#vztahy-application .explain}

Prvky Application Layer se propojují podle generického metamodelu:

- **struktura:** `Component —composition→ Component`, `Component —composition→ Interface`, `Collaboration —aggregation→ Component`;
- **struktura → chování:** `Component —assignment→ Function / Process`, `Collaboration —assignment→ Interaction`, `Interface —assignment→ Service`;
- **chování → služba → uživatel:** `Function —realization→ Service —serving→ Component`;
- **dynamika:** `Event —triggering→ Process`, `Process —triggering→ Process`, `Function —flow→ Function`;
- **data:** `Function / Process —access→ Data Object`.

Jak aplikační služby slouží byznysu a co komponenty potřebují od technologie, patří k vazbám mezi vrstvami.

*Příklad:* `Portál (Application Component) —assignment→ Zobrazení smluv (Application Function)`; `Kalkulace pojistného (Application Service) —serving→ Portál (Application Component)`

### ? Portál pro makléře potřebuje k výpočtu ceny službu „Kalkulace pojistného" poskytovanou systémem Pojistný kmen. Který fragment modelu to vyjadřuje?

- [x] `Kalkulace pojistného (Application Service) —serving→ Portál pro makléře (Application Component)`
- [ ] `Portál pro makléře (Application Component) —serving→ Kalkulace pojistného (Application Service)`
- [ ] `Kalkulace pojistného (Application Service) —realization→ Portál pro makléře (Application Component)`
- [ ] `Portál pro makléře (Application Component) —access→ Kalkulace pojistného (Application Service)`

> Služba slouží komponentě, která ji využívá, takže serving vede od služby k portálu. Opačný směr ani realizace situaci nevystihují a access smí vést jen k pasivnímu prvku, ne ke službě.

### ? Který fragment modelu je v Application Layer CHYBNÝ?

- [ ] `Objednávkový systém (Application Component) —assignment→ Přijetí objednávky (Application Function)`
- [x] `Objednávka (Data Object) —assignment→ Přijetí objednávky (Application Function)`
- [ ] `Přijetí objednávky (Application Function) —access (write)→ Objednávka (Data Object)`
- [ ] `Přijetí objednávky (Application Function) —realization→ Založení objednávky (Application Service)`

> Assignment vede od aktivní struktury k chování; datový objekt je pasivní a chování nevykonává. Ostatní fragmenty odpovídají metamodelu: komponenta vykonává funkci, funkce zapisuje data a realizuje službu.

## Časté chyby v Application Layer {#chyby-application .explain}

Nejčastější chyby při modelování aplikací:

- **funkce místo komponenty (a naopak)** — systém či modul je komponenta, činnost je funkce;
- **API jako služba** — API je rozhraní; služba je chování, které API zpřístupňuje;
- **datový objekt jako komponenta** — databáze zákazníků jako data je Data Object (databázový systém patří do technologie);
- **serving místo realization** — funkce službu realizuje, ne jí slouží;
- **triggering místo flow** — předání dat bez spuštění je flow;
- **business a data objekt v jednom** — Business Object je byznysový pojem, Data Object jeho strojově zpracovatelná podoba.

*Příklad:* chybně `REST API (Application Service)`, správně `REST API (Application Interface) —assignment→ Poskytnutí ceníku (Application Service)`

### ? Co je chybně v modelu `Platební API (Application Service) —serving→ E-shop (Application Component)`?

- [ ] Serving nikdy nemůže vést od služby ke komponentě
- [ ] E-shop má být modelován jako Application Function
- [ ] Platební API má být modelováno jako Data Object
- [x] API je přístupový bod, tedy Application Interface

> API je rozhraní, přes které se zpřístupňuje služba (např. Autorizace platby). Serving od služby ke komponentě je správný, e-shop je systém, tedy komponenta, a API nejsou data.

### ? Co je chybně v modelu `Výpočet ceny (Application Function) —serving→ Cenová kalkulace (Application Service)`, kde funkce Výpočet ceny službu Cenová kalkulace zajišťuje?

- [ ] Vztah má být assignment od funkce ke službě
- [x] Funkce službu zajišťuje, vztah má být realization
- [ ] Cenová kalkulace má být Application Interface
- [ ] Výpočet ceny má být Application Component

> Interní chování službu realizuje, proto `Výpočet ceny —realization→ Cenová kalkulace`; serving vede od poskytovatele k uživateli. Assignment vede od aktivní struktury k chování, služba není rozhraní a výpočet je činnost, ne komponenta.
