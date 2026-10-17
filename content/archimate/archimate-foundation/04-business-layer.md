---
kind: topic
subject: archimate-foundation
slug: business-layer
name: "Business Layer"
order: 4
---

Business Actor, Role, Collaboration, Interface; Process, Function, Interaction, Event, Service; Business Object, Contract, Representation, Product.

## Business Layer — přehled prvků {#business-prehled .explain}

**Business Layer** popisuje, jak podnik funguje z pohledu byznysu: kdo co dělá, jaké chování vykonává, jaké služby nabízí navenek a s jakými informacemi pracuje — nezávisle na tom, jak je to podpořeno IT. Prvky se dělí podle aspektů:

- **aktivní struktura** — interní: Business Actor, Business Role, Business Collaboration; externí: Business Interface;
- **chování** — interní: Business Process, Business Function, Business Interaction; externí: Business Service; navíc Business Event;
- **pasivní struktura** — Business Object, Contract, Representation;
- **kompozitní prvek** — Product.

Location od verze 3 nepatří do Business Layer, ale mezi obecné prvky (kategorie „Other"); Value a Meaning patří k Motivation prvkům. Barva (typicky žlutá) není normativní.

*Příklad:* `Pojišťovna (Business Actor) —assignment→ Pojistitel (Business Role) —assignment→ Vyřízení pojistné události (Business Process) —realization→ Likvidace škod (Business Service)`

### ? Který prvek NEPATŘÍ do Business Layer podle ArchiMate 3.2?

- [ ] Business Collaboration
- [ ] Representation
- [ ] Product
- [x] Location

> Location je od ArchiMate 3 obecný prvek v kategorii „Other", použitelný ve všech vrstvách. Business Collaboration, Representation i Product jsou prvky Business Layer.

### ? Do kterého aspektu Business Layer patří Business Interface?

- [ ] Interní aktivní struktura
- [x] Externí aktivní struktura
- [ ] Externí chování
- [ ] Pasivní struktura

> Business Interface je přístupový bod, přes který role nebo aktér zpřístupňuje služby okolí — je to externí aktivní struktura. Interní aktivní strukturou jsou Actor, Role a Collaboration, externím chováním je Business Service.

## Business Actor {#business-actor .term}

**Business Actor** je „kdo" v byznysu: konkrétní člověk, útvar, celá firma nebo skupina firem, ať uvnitř podniku, nebo mimo něj (zákazník, dodavatel, úřad) — zkrátka někdo, kdo může něco dělat. Patří do **interní aktivní struktury**. Typicky je **přiřazen (assignment) k Business Role**, kterou hraje; přímo může být přiřazen i k chování. Ikona: panáček (stick figure).

*Příklad:* `Jan Novák (Business Actor) —assignment→ Pojištěnec (Business Role)`

### ? Který z následujících pojmů se v Business Layer nejlépe modeluje jako Business Actor?

- [x] Oddělení likvidace škod pojišťovny
- [ ] Vyřizování reklamací zákazníků
- [ ] Zákaznická linka jako kanál služby
- [ ] Pojistná smlouva uzavřená s klientem

> Organizační jednotka je entita schopná vykonávat chování, tedy Business Actor. Vyřizování reklamací je chování (Process nebo Function), zákaznická linka je Business Interface a pojistná smlouva je Contract.

### ? Do kterého aspektu patří Business Actor?

- [ ] Externí aktivní struktura
- [ ] Interní chování
- [x] Interní aktivní struktura
- [ ] Pasivní struktura

> Business Actor je ten, kdo chování vykonává — interní prvek aktivní struktury. Externí aktivní strukturou je Business Interface, interním chováním např. Business Process.

## Business Role {#business-role .term}

**Business Role** je „klobouk", který si aktér nasazuje: pojmenovaná odpovědnost (Pojištěnec, Schvalovatel, Prodejce), kterou mohou podle potřeby převzít různí aktéři. Patří do **interní aktivní struktury**. Aktér se k roli váže vztahem **assignment** (aktér → role), role se pak přiřazuje k procesům a funkcím (role → chování). Ikona: ležící válec.

*Příklad:* `Schvalovatel úvěru (Business Role) —assignment→ Schválení úvěru (Business Process)`

### ? Jakým vztahem a v jakém směru se v ArchiMate vyjádří, že konkrétní aktér hraje určitou roli?

- [x] Assignment od Business Actor k Business Role
- [ ] Realization od Business Role k Business Actor
- [ ] Specialization od Business Actor k Business Role
- [ ] Composition od Business Role k Business Actor

> Aktér roli „vykonává", proto assignment směřuje od aktéra k roli. Realization se používá u realizace služeb a objektů, specialization vyjadřuje podtyp téhož druhu prvku a composition vztah celek–část.

### ? Firma chce modelovat odpovědnost „Schvalovatel faktur", kterou může podle situace převzít vedoucí oddělení nebo jeho zástupce. Který prvek je vhodný?

- [ ] Business Actor
- [x] Business Role
- [ ] Business Function
- [ ] Business Collaboration

> Odpovědnost, kterou mohou převzít různí aktéři, je typicky Business Role; vedoucí a zástupce jsou aktéři přiřazení k této roli. Business Function je chování, Business Collaboration spojení více rolí pro společné chování.

## Proč oddělovat aktéra a roli {#actor-vs-role .explain}

Oddělení **Business Actor** a **Business Role** zvyšuje stabilitu modelu. Chování (procesy, funkce) se přiřazuje k **rolím**, ne přímo ke konkrétním lidem či útvarům; když se změní organizace, stačí přepojit aktéry na role a procesy zůstanou beze změny. Vztah je **M:N** — jeden aktér hraje více rolí a jednu roli může hrát více aktérů. Přiřadit chování přímo k aktérovi jazyk dovoluje, ale model pak je méně pružný.

*Příklad:* `Pobočka Brno (Business Actor) —assignment→ Prodejce (Business Role)` a zároveň `Call centrum (Business Actor) —assignment→ Prodejce (Business Role)`; `Prodejce (Business Role) —assignment→ Uzavření smlouvy (Business Process)`

### ? Proč se v ArchiMate doporučuje přiřazovat procesy k rolím a ne přímo ke konkrétním aktérům?

- [ ] Jazyk přímé přiřazení procesu k aktérovi vůbec nedovoluje
- [ ] Role jsou pasivní prvky, a proto je lze libovolně sdílet
- [x] Při reorganizaci se jen přepojí aktéři a procesy zůstanou
- [ ] Proces přiřazený aktérovi nelze dále dekomponovat na kroky

> Role odděluje chování od konkrétní organizační struktury, takže změna organizace nemění model procesů. Přímé přiřazení k aktérovi jazyk dovoluje, role nejsou pasivní a dekompozice procesu na přiřazení nezávisí.

### ? Jaká je kardinalita vztahu mezi Business Actor a Business Role?

- [ ] Každý aktér hraje právě jednu roli a role patří jednomu aktérovi
- [ ] Aktér může hrát více rolí, ale každá role patří jednomu aktérovi
- [ ] Role může mít více aktérů, ale aktér smí hrát jen jednu roli
- [x] Aktér může hrát více rolí a roli může hrát více aktérů

> Vztah aktér–role je M:N: jeden útvar může hrát roli prodejce i reklamačního místa a prodejce může hrát pobočka i call centrum. Jazyk žádné omezení na jednu roli neklade.

## Business Collaboration {#business-collaboration .term}

**Business Collaboration** vznikne, když se dvě či více rolí, aktérů (nebo i jiných kolaborací) spojí, aby **společně** dělali něco, co by sami nezvládli — např. makléř a pojistitel při sjednávání pojištění. Patří do interní aktivní struktury. Kolaborace **agreguje** své účastníky a je **přiřazena (assignment) k Business Interaction**, tedy ke společnému chování. Může být trvalá (partnerství) i dočasná (projektový tým). Ikona: dva překrývající se kruhy.

*Příklad:* `Pojištění přes makléře (Business Collaboration) —aggregation→ Makléř (Business Role)`; `Pojištění přes makléře (Business Collaboration) —aggregation→ Pojistitel (Business Role)`

### ? Kterým vztahem je Business Collaboration typicky spojena se svými účastníky (rolemi)?

- [ ] Assignment
- [x] Aggregation
- [ ] Realization
- [ ] Serving

> Kolaborace sdružuje dvě nebo více rolí či aktérů, proto se k nim váže agregací. Assignment ji naopak spojuje s chováním, které vykonává — s Business Interaction.

### ? Ke kterému prvku chování se Business Collaboration typicky přiřazuje vztahem assignment?

- [x] Business Interaction
- [ ] Business Event
- [ ] Business Service
- [ ] Business Object

> Společné chování více účastníků vyjadřuje Business Interaction a vykonává ji právě kolaborace. Business Event je událost, Business Service externí chování a Business Object pasivní prvek.

## Actor × Role × Collaboration {#actor-role-collaboration .compare}

Tři prvky interní aktivní struktury Business Layer se liší tím, co vyjadřují.

| | Business Actor | Business Role | Business Collaboration |
|---|---|---|---|
| Co vyjadřuje | kdo (osoba, útvar, organizace) | odpovědnost, „klobouk" | spolupráce více účastníků |
| Příklad | Jan Novák, Oddělení IT | Schvalovatel, Pojištěnec | Konsorcium dodavatelů |
| Typický vztah k chování | assignment k roli, případně k chování | assignment k Process / Function | assignment k Interaction |
| Vazba na ostatní | assignment → Role | aktér je k ní přiřazen | aggregation → Role / Actor |

### ? Pojišťovna a banka společně nabízejí bankopojištění; obě strany se podílejí na sjednání smlouvy. Který prvek nejlépe vystihuje jejich společné vystupování?

- [ ] Business Role
- [ ] Business Interface
- [x] Business Collaboration
- [ ] Business Actor

> Dvě strany, které společně vykonávají chování, se modelují jako Business Collaboration agregující jejich role. Jediná role ani jediný aktér spolupráci nevystihne a Business Interface je jen přístupový bod ke službě.

### ? Které tvrzení o prvcích Business Actor, Business Role a Business Collaboration je správné?

- [ ] Role patří do chování, aktér a kolaborace do struktury
- [ ] Kolaborace patří do externí aktivní struktury vrstvy
- [ ] Aktér je externí prvek, role a kolaborace jsou interní
- [x] Všechny tři patří do interní aktivní struktury

> Actor, Role i Collaboration jsou interní prvky aktivní struktury — vykonávají chování. Externí aktivní strukturou Business Layer je pouze Business Interface.

## Business Interface {#business-interface .term}

**Business Interface** je přístupový bod, přes který role nebo aktér **zpřístupňuje své služby okolí** — kanál jako pobočka, telefonní linka, web, e-mail. Patří do **externí aktivní struktury**. Typicky je **součástí (composition)** role či aktéra, je **přiřazen (assignment) k Business Service**, kterou zpřístupňuje, a **slouží (serving)** roli zákazníka. Ikona: „lízátko" (kroužek na krátké čárce).

*Příklad:* `Pojistitel (Business Role) —composition→ Klientská linka (Business Interface) —assignment→ Hlášení škody (Business Service)`

### ? Banka nabízí službu „Otevření účtu" na pobočce, přes internet i po telefonu. Jak se nejlépe modelují pobočka, internet a telefon?

- [ ] Jako tři samostatné Business Service se stejným názvem
- [x] Jako tři Business Interface přiřazené k jedné službě
- [ ] Jako tři Business Process realizující službu účtu
- [ ] Jako tři Business Object, ke kterým služba přistupuje

> Pobočka, web a telefon jsou kanály, tedy Business Interface; služba zůstává jedna a každé rozhraní je k ní přiřazeno. Duplikace služby by zakryla, že jde o totéž chování, a kanál není ani proces, ani pasivní objekt.

### ? Kterým vztahem se Business Interface typicky váže ke službě, kterou zpřístupňuje?

- [ ] Realization
- [ ] Aggregation
- [x] Assignment
- [ ] Triggering

> Rozhraní je aktivní struktura, která službu „poskytuje", proto se k ní váže assignment. Službu realizuje interní chování (proces, funkce) vztahem realization.

## Business Process {#business-process .term}

**Business Process** popisuje, jak se v podniku něco udělá krok za krokem — od spouštěcího podnětu k výsledku (produktu, službě, stavu), třeba od přijetí žádosti po rozhodnutí o ní. Patří do **interního chování**. Má **časové pořadí** kroků, začátek a konec; spouští ho událost a jeho části se řetězí vztahem **triggering**, předávání informací vyjadřuje **flow**. Proces **realizuje** službu, je k němu přiřazena role a **přistupuje (access)** k business objektům. Pojmenovává se obvykle slovesem a předmětem (Vyřídit objednávku). Ikona: šipka.

*Příklad:* `Přijetí žádosti (Business Process) —triggering→ Posouzení žádosti (Business Process) —triggering→ Rozhodnutí o žádosti (Business Process)`

### ? Co nejlépe charakterizuje Business Process?

- [x] Uspořádaná posloupnost činností vedoucí k výsledku
- [ ] Seskupení činností podle potřebných schopností a zdrojů
- [ ] Chování, které role zpřístupňuje okolí jako hodnotu
- [ ] Okamžitá změna stavu, která spouští další chování

> Proces má pořadí kroků a směřuje k výsledku. Seskupení podle schopností je Business Function, chování zpřístupněné okolí je Business Service a okamžitá změna stavu je Business Event.

### ? Kterým vztahem se v modelu vyjádří, že po dokončení procesu „Posouzení žádosti" následuje proces „Rozhodnutí o žádosti"?

- [ ] Flow
- [ ] Serving
- [ ] Composition
- [x] Triggering

> Časovou nebo příčinnou návaznost chování vyjadřuje triggering. Flow znamená předání informace či materiálu, serving poskytování služby a composition vztah celek–část.

### ? Proces „Zpracování objednávky" předává procesu „Expedice" údaje o objednaném zboží, ale expedice začíná až podle denního plánu. Který vztah mezi procesy je vhodný?

- [ ] Triggering
- [x] Flow
- [ ] Assignment
- [ ] Realization

> Jde o předání informace bez přímého spuštění, tedy flow. Triggering by tvrdil, že dokončení prvního procesu přímo spouští druhý; assignment a realization mezi dvěma procesy nevyjadřují návaznost.

## Business Function {#business-function .term}

**Business Function** je trvalá oblast činnosti podniku, vymezená tím, jaké **schopnosti, znalosti a zdroje** vyžaduje — Marketing, Účetnictví, Řízení skladu. Patří do **interního chování**. Na rozdíl od procesu **nemá časové pořadí** ani začátek a konec, je dlouhodobě stabilní a nemusí odpovídat organizační jednotce. Přiřazuje se k ní role (assignment), může **realizovat** službu a **přistupovat** k business objektům. Funkce se dekomponuje na podfunkce (composition). Ikona: šipka ve tvaru „krokve" (chevron).

*Příklad:* `Finanční řízení (Business Function) —composition→ Účetnictví (Business Function)`

### ? Co odlišuje Business Function od Business Process?

- [ ] Funkce vždy odpovídá právě jednomu útvaru v organizační struktuře
- [ ] Funkce je externí chování, které je vidět zvenku organizace
- [x] Funkce seskupuje chování podle schopností a nemá pořadí kroků
- [ ] Funkce je vždy kratší než proces a trvá jen okamžik

> Funkce je stabilní seskupení chování podle schopností či zdrojů, bez pořadí kroků. Nemusí se krýt s útvarem, je interní (externí je služba) a okamžitá je jen událost.

### ? Který název nejlépe odpovídá prvku Business Function?

- [x] Řízení vztahů se zákazníky
- [ ] Odeslat upomínku dlužníkovi
- [ ] Faktura byla zaplacena
- [ ] Objednávka zákazníka

> „Řízení vztahů se zákazníky" je trvalé seskupení schopností bez pořadí kroků — typická funkce. „Odeslat upomínku" zní jako proces, „Faktura byla zaplacena" jako událost a „Objednávka zákazníka" jako business objekt.

## Business Interaction {#business-interaction .term}

**Business Interaction** je činnost, kterou dělá **několik účastníků naráz a společně** (role, aktéři, kolaborace) — např. jednání o smlouvě nebo společné posouzení; žádný z nich by ji sám neodvedl. Patří do **interního chování**. Typicky je k ní přiřazena **Business Collaboration** (assignment); interakce může **realizovat** službu a přistupovat k business objektům. Ikona: kruh rozdělený na dvě poloviny.

*Příklad:* `Klient a poradce (Business Collaboration) —assignment→ Sjednání hypotéky (Business Interaction)`

### ? Kdy je vhodné použít Business Interaction místo Business Process?

- [ ] Když chování nemá žádný začátek ani konec v čase
- [ ] Když chování probíhá výhradně mezi dvěma IT systémy
- [ ] Když chování zpřístupňuje službu externím zákazníkům
- [x] Když chování vykonávají společně dva nebo více účastníků

> Interakce je společné chování více účastníků, typicky přiřazené kolaboraci. Chování bez začátku a konce odpovídá spíše funkci, chování IT systémů patří do Application Layer a zpřístupnění okolí je služba.

### ? Který prvek aktivní struktury je typicky přiřazen (assignment) k Business Interaction?

- [ ] Business Interface
- [ ] Business Object
- [x] Business Collaboration
- [ ] Business Event

> Společné chování vykonává spojení více účastníků, tedy Business Collaboration. Business Interface se přiřazuje ke službě, Business Object je pasivní a Business Event není aktivní struktura.

## Process × Function × Interaction {#process-function-interaction .compare}

Tři druhy **interního chování** Business Layer — všechny mohou realizovat službu a přistupovat k objektům.

| | Business Process | Business Function | Business Interaction |
|---|---|---|---|
| Podstata | posloupnost kroků k výsledku | seskupení podle schopností / zdrojů | společné chování více účastníků |
| Čas a pořadí | ano, začátek–konec | ne, trvalé | může mít, není podstatou |
| Kdo vykonává | role / aktér | role / aktér | kolaborace |
| Typický název | Vyřídit pojistnou událost | Řízení pohledávek | Vyjednání smlouvy |
| Řetězení | triggering, flow | spíše flow | triggering, flow |

### ? Firma popisuje „Nákup" jako trvalou oblast činnosti se znalostí dodavatelského trhu, bez určeného pořadí kroků. Který prvek je vhodný?

- [ ] Business Process
- [x] Business Function
- [ ] Business Interaction
- [ ] Business Service

> Trvalá oblast činností podle schopností bez pořadí kroků je Business Function. Proces by vyžadoval posloupnost kroků, interakce více spolupracujících účastníků a služba pohled zvenku.

### ? Pojišťovna popisuje „Vyřízení pojistné události" od nahlášení škody přes posouzení až po výplatu. Který prvek je vhodný?

- [ ] Business Function
- [ ] Business Event
- [ ] Business Interaction
- [x] Business Process

> Postup s pořadím kroků od spouštěcí události po výsledek je Business Process. Funkce nemá pořadí, událost je okamžik (např. nahlášení škody) a interakce by vyžadovala společné chování více účastníků.

### ? Které tvrzení platí pro Business Process, Business Function i Business Interaction současně?

- [x] Všechny jsou interní chování a mohou realizovat službu
- [ ] Všechny mají pevně dané pořadí kroků a výsledek
- [ ] Všechny vykonává vždy kolaborace více účastníků
- [ ] Všechny jsou externí chování viditelné zákazníkem

> Všechny tři jsou interní chování a realizují Business Service. Pořadí kroků má hlavně proces, kolaboraci vyžaduje jen interakce a externím chováním je služba.

## Business Event {#business-event .term}

**Business Event** zachycuje okamžik, kdy se v podniku nebo kolem něj něco stane — „Přijata objednávka", „Konec měsíce" — a na který může navázat (**triggering**) další chování, případně ho přerušit. Nemá trvání (je okamžitá), může pocházet zvenku i zevnitř. Řadí se k prvkům chování (není to aktivní ani pasivní struktura). Typicky `Event —triggering→ Process`, ale proces může také událost vyvolat (`Process —triggering→ Event`). Ikona: šipka s vykrojeným levým koncem.

*Příklad:* `Škoda nahlášena (Business Event) —triggering→ Vyřízení pojistné události (Business Process)`

### ? Čím se Business Event liší od Business Process?

- [x] Událost je okamžitá změna stavu a nemá trvání
- [ ] Událost je vždy vyvolána pouze mimo organizaci
- [ ] Událost vždy patří do pasivní struktury vrstvy
- [ ] Událost se nemůže účastnit vztahu triggering

> Událost je okamžik, kdy nastane změna stavu, zatímco proces trvá a má kroky. Událost může vzniknout uvnitř i vně organizace, patří k chování a právě triggering je její typický vztah.

### ? Který fragment modelu správně vyjadřuje, že přijetí objednávky spouští její zpracování?

- [ ] `Objednávka přijata (Business Event) —serving→ Zpracování objednávky (Business Process)`
- [x] `Objednávka přijata (Business Event) —triggering→ Zpracování objednávky (Business Process)`
- [ ] `Zpracování objednávky (Business Process) —realization→ Objednávka přijata (Business Event)`
- [ ] `Objednávka přijata (Business Event) —assignment→ Zpracování objednávky (Business Process)`

> Spuštění chování událostí vyjadřuje triggering od události k procesu. Serving je poskytování služby, realization vyjadřuje uskutečnění abstraktnějšího prvku, ne spuštění, a assignment vede od aktivní struktury k chování.

## Business Service {#business-service .term}

**Business Service** je to, co podnik (jeho role, aktér či kolaborace) **nabízí navenek**, popsané očima toho, kdo službu využívá: co dostane a v čem je to pro něj užitečné, bez pohledu do vnitřního fungování. Patří do **externího chování**. Službu **realizuje** interní chování (proces, funkce, interakce), zpřístupňuje ji **Business Interface** (assignment) a **slouží (serving)** rolím, aktérům a procesům, které ji využívají. Pojmenovává se z pohledu uživatele (Pojištění vozidla, Vyřízení reklamace). Ikona: malý zaoblený obdélník (tvar pilulky).

*Příklad:* `Posouzení žádosti (Business Process) —realization→ Poskytnutí úvěru (Business Service) —serving→ Žadatel (Business Role)`

### ? Do kterého aspektu patří Business Service?

- [ ] Interní chování
- [ ] Externí aktivní struktura
- [x] Externí chování
- [ ] Pasivní struktura

> Služba je chování viditelné zvenku, tedy externí chování. Interním chováním jsou proces, funkce a interakce, externí aktivní strukturou je Business Interface.

### ? Který vztah vede od Business Service k roli zákazníka, který službu využívá?

- [ ] Realization
- [ ] Assignment
- [ ] Access
- [x] Serving

> Služba slouží svým uživatelům vztahem serving. Realization vede k službě od chování, které ji realizuje, assignment od rozhraní ke službě a access od chování k pasivním objektům.

## Business Service × Business Interface {#service-vs-interface .compare}

Obě jsou **externí**, ale jedna je chování a druhá struktura — „co" se nabízí × „kudy" se k tomu přistupuje.

| | Business Service | Business Interface |
|---|---|---|
| Aspekt | externí chování | externí aktivní struktura |
| Otázka | co okolí dostává | kde / jakým kanálem to dostává |
| Příklad | Hlášení škody | Klientská linka, webový portál |
| Vztah mezi nimi | — | interface —assignment→ service |
| K uživateli | serving | serving |
| Co ji / ho tvoří | realizuje ji proces / funkce / interakce | je součástí (composition) role / aktéra |

### ? Pojišťovna umožňuje „Hlášení škody", které klient může provést na webovém portálu. Který model je správný?

- [ ] `Hlášení škody (Business Service) —assignment→ Webový portál (Business Interface)`
- [ ] `Webový portál (Business Service) —realization→ Hlášení škody (Business Interface)`
- [x] `Webový portál (Business Interface) —assignment→ Hlášení škody (Business Service)`
- [ ] `Hlášení škody (Business Interface) —composition→ Webový portál (Business Service)`

> Kanál je Business Interface a hlášení škody je služba; assignment vede od rozhraní ke službě. Ostatní varianty obracejí směr vztahu nebo zaměňují typy prvků.

### ? Který pár správně přiřazuje pojem k typu prvku?

- [ ] Telefonní linka = Business Service, Sjednání pojištění = Business Interface
- [ ] Telefonní linka = Business Role, Sjednání pojištění = Business Function
- [ ] Telefonní linka = Business Object, Sjednání pojištění = Business Event
- [x] Telefonní linka = Business Interface, Sjednání pojištění = Business Service

> Kanál, přes který se k něčemu přistupuje, je rozhraní; to, co klient dostává, je služba. Linka není role ani objekt a sjednání pojištění není z pohledu klienta funkce ani okamžitá událost.

## Služba × proces: pohled zvenku a zevnitř {#service-vs-process .explain}

Služba a proces popisují totéž chování z různých stran. **Business Service** říká, co zákazník dostane (pohled zvenku, „černá skříňka"), **Business Process** jak to organizace uvnitř zajistí. Proces službu **realizuje** (realization), jedna služba může být realizována více procesy a jeden proces může realizovat více služeb. Díky službám lze měnit vnitřní procesy, aniž by se změnilo, co okolí vidí. Proto zákazník ani jiné procesy nemají být napojeny přímo na interní proces, ale na službu (serving).

*Příklad:* `Vyřízení reklamace (Business Process) —realization→ Reklamace zboží (Business Service) —serving→ Zákazník (Business Role)`

### ? Který fragment modelu správně spojuje proces, službu a jejího uživatele?

- [ ] `Reklamace zboží (Business Service) —realization→ Vyřízení reklamace (Business Process) —serving→ Zákazník (Business Role)`
- [x] `Vyřízení reklamace (Business Process) —realization→ Reklamace zboží (Business Service) —serving→ Zákazník (Business Role)`
- [ ] `Vyřízení reklamace (Business Process) —serving→ Reklamace zboží (Business Service) —realization→ Zákazník (Business Role)`
- [ ] `Zákazník (Business Role) —realization→ Reklamace zboží (Business Service) —serving→ Vyřízení reklamace (Business Process)`

> Interní chování realizuje službu a služba slouží svému uživateli. Ostatní varianty obracejí směr realizace, služba nemůže realizovat roli a poslední varianta dělá ze zákazníka poskytovatele služby a z procesu jejího uživatele.

### ? Jaký je hlavní přínos modelování Business Service odděleně od procesu, který ji realizuje?

- [x] Vnitřní proces lze změnit, aniž by se změnilo, co vidí okolí
- [ ] Služba nahrazuje proces, takže procesy už není nutné modelovat
- [ ] Služba umožňuje přiřadit proces přímo konkrétnímu zaměstnanci
- [ ] Služba určuje časové pořadí kroků, které proces nemá

> Služba je stabilní vnější „smlouva" o chování, za kterou lze vnitřní realizaci měnit. Proces nenahrazuje, s přiřazením zaměstnanců nesouvisí a pořadí kroků má naopak proces.

## Business Object {#business-object .term}

**Business Object** je pojem nebo informace, se kterou se v byznysu pracuje — Objednávka, Faktura, Pojistná událost, Zákazník (jako údaje o zákazníkovi). Patří do **pasivní struktury**: sám nic nevykonává, ale chování k němu **přistupuje (access)** — čte, vytváří, mění. Jde o informační pojem nezávislý na médiu a IT; fyzické předměty se modelují jinde (Material v Physical). Může být agregací jiných objektů. Ikona: obdélník s pruhem nahoře.

*Příklad:* `Vystavení faktury (Business Process) —access (write)→ Faktura (Business Object)`

### ? Kterým vztahem se v Business Layer vyjádří, že proces vytváří fakturu?

- [ ] Realization od procesu k Business Object
- [x] Access (write) od procesu k Business Object
- [ ] Assignment od Business Object k procesu
- [ ] Triggering od procesu k Business Object

> Práci chování s pasivním objektem (čtení, zápis) vyjadřuje access, zde v režimu write. Realization, assignment ani triggering vztah chování k pasivnímu objektu nevyjadřují.

### ? Co z následujícího je nejvhodnější modelovat jako Business Object?

- [ ] Papírový formulář žádosti vyplněný klientem na pobočce
- [ ] Posouzení žádosti o úvěr úvěrovým specialistou
- [ ] Úvěrový specialista posuzující žádosti klientů
- [x] Žádost o úvěr jako soubor údajů o žadateli a úvěru

> Žádost jako informační pojem nezávislý na médiu je Business Object. Konkrétní papírový formulář je jeho Representation, posouzení je chování a specialista je role nebo aktér.

## Contract {#contract .term}

**Contract** použijeme pro dohodu — psanou smlouvu i ústní ujednání —, v níž si poskytovatel a odběratel produktu nebo služby stanoví vzájemná **práva a povinnosti**, často i garantovanou kvalitu (SLA). V ArchiMate je **specializací Business Object** — patří tedy do pasivní struktury a chování k němu přistupuje stejně jako k business objektu. Typicky bývá součástí **produktu** (Product —aggregation→ Contract). Ikona: jako business object, s dalším vodorovným pruhem.

*Příklad:* `Hypotéka (Product) —aggregation→ Úvěrová smlouva (Contract)`

### ? Jak je Contract zařazen v metamodelu ArchiMate?

- [ ] Jako specializace Business Service v externím chování
- [ ] Jako samostatný prvek aktivní struktury Business Layer
- [x] Jako specializace Business Object v pasivní struktuře
- [ ] Jako Motivation prvek odvozený od prvku Requirement

> Contract je zvláštní druh business objektu — pasivní prvek, ke kterému chování přistupuje. Není službou, aktivní strukturou ani Motivation prvkem, přestože obsahuje závazky.

### ? Ve kterém případě je nejvhodnější použít prvek Contract místo obecného Business Object?

- [x] Dohoda o úrovni služeb s garantovanou dobou odezvy
- [ ] Interní seznam zboží na skladě s aktuálními počty
- [ ] Údaje o zákazníkovi vedené v zákaznické kartotéce
- [ ] Přehled přijatých objednávek za uplynulý měsíc

> Contract je určen pro dohody stanovující práva, povinnosti a parametry plnění, typicky SLA. Seznamy zboží, údaje o zákaznících a přehledy objednávek jsou běžné business objekty.

## Representation {#representation .term}

**Representation** je to, co lze skutečně vidět nebo vzít do ruky — tištěná faktura, PDF, vyplněný formulář, e-mail —, tedy **konkrétní, vnímatelná podoba**, v níž se předává informace business objektu. Patří do **pasivní struktury**. S business objektem se váže vztahem **realization**: `Representation —realization→ Business Object`; jeden objekt může mít více reprezentací (faktura v PDF i na papíře). Ikona: obdélník se zvlněným spodním okrajem.

*Příklad:* `Faktura v PDF (Representation) —realization→ Faktura (Business Object)`

### ? Kterým vztahem se Representation váže k Business Object, jehož informaci nese?

- [ ] Composition od Representation k Business Object
- [x] Realization od Representation k Business Object
- [ ] Access od Business Object k Representation
- [ ] Specialization od Representation k Business Object

> Reprezentace je konkrétní podoba, která business objekt realizuje. Nejde o část objektu, access je vztah chování k pasivnímu prvku a specialization by tvrdila, že reprezentace je podtypem objektu.

### ? Faktura se zákazníkovi posílá jako PDF e-mailem a na přání i tištěná poštou. Jak se to nejlépe modeluje?

- [ ] Dva Business Object Faktura, každý pro jeden způsob doručení faktury
- [ ] Jeden Contract Faktura a dva Business Interface, které ho realizují
- [x] Jeden Business Object Faktura a dvě Representation, které ho realizují
- [ ] Jedna Representation Faktura a dva Business Object, které ji realizují

> Informace je jedna (business objekt), liší se jen vnímatelná podoba — dvě reprezentace realizující týž objekt. Faktura není smlouva, rozhraní objekty nerealizují a směr realizace vede od reprezentace k objektu.

## Business Object × Representation × Contract {#object-representation-contract .compare}

Tři prvky **pasivní struktury** Business Layer.

| | Business Object | Contract | Representation |
|---|---|---|---|
| Podstata | informační pojem byznysu | dohoda o právech a povinnostech | vnímatelná podoba informace |
| Vztah k ostatním | základní prvek | specializace Business Object | realization → Business Object |
| Závislost na médiu | ne | ne | ano (papír, PDF, e-mail) |
| Příklad | Objednávka | Rámcová smlouva, SLA | Objednávkový formulář |

### ? Který pár je správně namodelován?

- [x] `Objednávkový formulář (Representation) —realization→ Objednávka (Business Object)`
- [ ] `Objednávka (Business Object) —realization→ Objednávkový formulář (Representation)`
- [ ] `Objednávkový formulář (Contract) —realization→ Objednávka (Representation)`
- [ ] `Objednávka (Business Object) —composition→ Objednávkový formulář (Contract)`

> Formulář je vnímatelná podoba objednávky, proto reprezentace realizuje business objekt. Ostatní varianty obracejí směr nebo zaměňují formulář se smlouvou.

### ? Které tvrzení o prvcích Business Object, Contract a Representation je NESPRÁVNÉ?

- [ ] Všechny tři patří do pasivní struktury vrstvy
- [ ] Contract je specializací prvku Business Object
- [ ] Representation realizuje prvek Business Object
- [x] Representation je specializací Business Object

> Specializací Business Object je Contract; Representation je samostatný pasivní prvek, který business objekt realizuje. Ostatní tvrzení platí.

## Product {#product .term}

**Product** je balíček, který podnik zákazníkovi (internímu i externímu) nabízí jako celek: několik **služeb** (případně i informační prvky) spolu s podmínkami ve **smlouvě**. Je to **kompozitní prvek** Business Layer: **agreguje** (případně skládá) Business Service, Contract a business objekty, může zahrnovat i služby jiných vrstev (např. Application Service). Produkt bývá spojen s hodnotou (Value) pro zákazníka. Ikona: obdélník s malou „záložkou" vlevo nahoře.

*Příklad:* `Cestovní pojištění (Product) —aggregation→ Úhrada léčebných výloh (Business Service)`; `Cestovní pojištění (Product) —aggregation→ Pojistné podmínky (Contract)`

### ? Které prvky typicky agreguje Product?

- [x] Služby, smlouvu a případně business objekty
- [ ] Procesy, události a role, které produkt tvoří
- [ ] Aktéry, rozhraní a kolaborace poskytovatele
- [ ] Výhradně business objekty a jejich reprezentace

> Product je soubor služeb a pasivních prvků doprovázený smlouvou, které se nabízejí jako celek. Interní chování, události ani aktivní struktura nejsou typickým obsahem produktu.

### ? Do které kategorie prvků patří Product?

- [ ] Externí chování Business Layer
- [x] Kompozitní prvek Business Layer
- [ ] Pasivní struktura Business Layer
- [ ] Prvek vrstvy Strategy a kapabilit

> Product je kompozitní prvek, který sdružuje služby, smlouvy a objekty. Není službou (externí chování), není jen pasivním objektem a s prvky Strategy nesouvisí.

### ? Banka nabízí „Běžný účet Plus" — vedení účtu, platební kartu a internetové bankovnictví za měsíční poplatek podle sazebníku. Který model nejlépe vystihuje tuto nabídku?

- [ ] Business Service realizovaná třemi Product a jedním Contract
- [ ] Business Process spouštěný třemi Business Event a sazebníkem
- [ ] Business Collaboration agregující tři Business Interface a smlouvu
- [x] Product agregující tři Business Service a Contract se sazebníkem

> Nabídka služeb prodávaná jako celek s podmínkami je Product, který agreguje služby a smlouvu. Produkt službu nerealizuje, proces s událostmi popisuje vnitřní chování a kolaborace sdružuje role či aktéry.

## Typické vztahy uvnitř Business Layer {#vztahy-business .explain}

Prvky Business Layer se propojují podle generického metamodelu:

- **aktivní struktura → chování:** `Actor —assignment→ Role —assignment→ Process / Function`, `Collaboration —assignment→ Interaction`, `Interface —assignment→ Service`;
- **struktura:** `Collaboration —aggregation→ Role / Actor`, `Role —composition→ Interface`, `Product —aggregation→ Service / Contract`;
- **chování → služba → uživatel:** `Process —realization→ Service —serving→ Role / Process`;
- **dynamika:** `Event —triggering→ Process`, `Process —triggering→ Process`, `Process —flow→ Process`;
- **pasivní struktura:** `Process —access→ Business Object`, `Representation —realization→ Business Object`.

Vazby na Application a Technology Layer (např. aplikační služba slouží procesu) jsou samostatné téma.

*Příklad:* `Prodejce (Business Role) —assignment→ Uzavření smlouvy (Business Process) —access (write)→ Smlouva (Contract)`

### ? Který fragment modelu je v Business Layer správný?

- [ ] `Posouzení reklamace (Business Process) —assignment→ Reklamační technik (Business Role)`
- [ ] `Reklamační technik (Business Role) —composition→ Posouzení reklamace (Business Process)`
- [x] `Reklamační technik (Business Role) —assignment→ Posouzení reklamace (Business Process)`
- [ ] `Reklamační technik (Business Role) —access→ Posouzení reklamace (Business Process)`

> Assignment vede od aktivní struktury k chování, které vykonává. Opačný směr je chybný, composition by z procesu dělala součást role a access smí vést jen k pasivnímu prvku.

### ? Který vztah se v Business Layer typicky používá mezi Business Service a Business Process, který službu využívá?

- [x] Serving od služby k využívajícímu procesu
- [ ] Realization od služby k využívajícímu procesu
- [ ] Assignment od využívajícího procesu ke službě
- [ ] Access od využívajícího procesu ke službě

> Služba slouží procesu, který ji využívá — serving. Realization vede od chování ke službě, kterou realizuje, assignment od struktury k chování a access k pasivním prvkům.

### ? Který vztah se v Business Layer typicky používá mezi Business Role a Business Interface, přes které role zpřístupňuje své služby?

- [ ] Realization od rozhraní k roli
- [x] Composition od role k rozhraní
- [ ] Specialization od rozhraní k roli
- [ ] Access od rozhraní k roli

> Rozhraní je součástí role nebo aktéra, který přes ně služby zpřístupňuje, proto composition. Realization ani access se pro vztah role a jejího rozhraní nepoužívají a specialization smí spojit jen prvky stejného typu.

## Časté chyby v Business Layer {#chyby-business .explain}

Nejčastější chyby při modelování byznysu:

- **kanál jako služba** — pobočka nebo web jsou Business Interface, ne Business Service;
- **služba pojmenovaná jako interní krok** — služba má popisovat, co dostane uživatel, ne vnitřní činnost;
- **funkce místo procesu (a naopak)** — má-li chování pořadí kroků a výsledek, je to proces;
- **dokument jako business objekt** — konkrétní papír či PDF je Representation, informace je Business Object;
- **triggering místo flow** — pouhé předání informace bez spuštění je flow;
- **chování přímo u aktéra** — dovolené, ale pružnější je přiřadit ho roli.

*Příklad:* chybně `Webové stránky (Business Service)`, správně `Webové stránky (Business Interface) —assignment→ Objednání zboží (Business Service)`

### ? Co je chybně v modelu `Pobočka (Business Service) —serving→ Klient (Business Role)`?

- [ ] Serving nemůže vést od služby k roli klienta
- [ ] Klient má být vždy Business Actor, ne role
- [x] Pobočka je kanál, má být Business Interface
- [ ] Pobočka má být modelována jako Business Event

> Pobočka je přístupový bod ke službám, tedy Business Interface. Serving od služby k roli je správný vztah a klienta lze modelovat jako roli; pobočka není okamžitá událost.

### ? Analytik namodeloval „Odeslaná objednávka v PDF" jako Business Object. Jak model opravit?

- [ ] Použít Contract, který je specializací Business Object Objednávka
- [ ] Použít Business Event, který spouští Business Object Objednávka
- [ ] Použít Product, který agreguje Business Object Objednávka
- [x] Použít Representation, která realizuje Business Object Objednávka

> Konkrétní soubor PDF je vnímatelná podoba informace, tedy Representation realizující business objekt. Objednávka není smlouva o právech a povinnostech, událost objekt nespouští a produkt by byl nabídka služeb.
