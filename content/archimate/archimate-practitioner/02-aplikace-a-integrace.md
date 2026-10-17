---
kind: topic
subject: archimate-practitioner
slug: aplikace-a-integrace
name: "Modelování aplikací a integrací ve scénářích"
order: 2
---

Komponenty, služby, rozhraní, datové objekty, toky a spouštění mezi aplikacemi, integrační vzory.

## Jak ve scénáři vybrat aplikační prvek {#vyber-app-prvku .explain}

Aplikační vrstva má stejnou kostru jako business vrstva. **Application Component** je aplikace nebo její samostatně nasaditelná a vyměnitelná část (CRM, ERP, modul fakturace). Co aplikace uvnitř dělá, je **Application Function** (seskupení funkcionality) nebo **Application Process** (automatizovaná posloupnost kroků). Co nabízí ostatním, je **Application Service**, kudy se k tomu přistupuje, je **Application Interface** (API, obrazovka, dávkové rozhraní). S čím pracuje, je **Data Object**, co spouští zpracování, je **Application Event**. Vztahy: komponenta —assignment→ funkce/proces, chování —realization→ služba, služba —serving→ spotřebitel, komponenta —composition→ rozhraní, rozhraní —assignment→ služba, chování —access→ data object. Vazby na business vrstvu (aplikační služba slouží procesu) a na technologii kresli jen tam, kde to scénář vyžaduje.

*Příklad:* `CRM (Application Component) —assignment→ Správa kontaktů (Application Function) —realization→ Vyhledání zákazníka (Application Service) —serving→ Fakturace (Application Component)`.

### ? Ve scénáři pojišťovny stojí: „Systém Policy Admin obsahuje výpočet pojistného. Ten je dostupný ostatním systémům přes webové API a portál jej volá při každé kalkulaci." Které přiřazení typů je správné pro (1) Policy Admin, (2) výpočet pojistného nabízený ostatním, (3) webové API?

- [ ] (1) Application Component, (2) Application Function, (3) Application Service
- [x] (1) Application Component, (2) Application Service, (3) Application Interface
- [ ] (1) Application Collaboration, (2) Application Service, (3) Application Component
- [ ] (1) Application Component, (2) Application Interface, (3) Application Service

> Systém je komponenta, funkcionalita nabízená ostatním je služba a API je přístupový bod, tedy rozhraní. Funkce popisuje vnitřní chování, ne nabízený užitek; kolaborace by vyžadovala více spolupracujících komponent a čtvrtá možnost zaměňuje službu a rozhraní.

### ? Architekt modeluje integraci e-shopu. Ve scénáři stojí: „Když zákazník odešle objednávku, e-shop o tom informuje skladový systém, který okamžitě založí vychystávací úlohu." Jaký prvek nejlépe odpovídá „odeslání objednávky" z pohledu aplikací?

- [ ] Data Object, protože objednávka obsahuje data potřebná pro sklad
- [ ] Application Service, protože e-shop jím slouží skladu
- [x] Application Event, protože jde o okamžik spouštějící zpracování
- [ ] Application Interface, protože tudy jde informace do skladu

> Okamžik změny stavu, na který další zpracování reaguje, je Application Event, který triggeringem spouští proces ve skladovém systému. Data objednávky jsou samostatný Data Object, služba popisuje nabízenou funkcionalitu a rozhraní přístupový bod, nikoli okamžik.

## Application Component v praxi {#komponenta .explain}

Application Component je **samostatně nasaditelná a vyměnitelná** jednotka aplikačního software, ať běží on-premise, nebo jako SaaS — o umístění a provozu vypovídá až technologická vrstva. Velké systémy se rozkládají **kompozicí** na moduly, pokud moduly existují jen jako součást systému (licencované moduly ERP). Komponenta není databáze (obsah dat = Data Object, databázový server = System Software), není to soubor ani instalační balík (Artifact) a není to API (Application Interface). Granularitu volíš podle stakeholdera: vedení stačí „ERP", integrační tým potřebuje moduly.

*Příklad:* `ERP (Application Component) —composition→ Finance (Application Component)`; `ERP —composition→ Logistika (Application Component)`.

### ? Firma používá ERP se samostatně licencovanými a nasazovanými moduly Finance, Logistika a HR; mimo ERP moduly neexistují. Architekt chce ukázat skladbu ERP z modulů. Který fragment je nejvhodnější?

- [ ] `Finance, Logistika, HR (Application Component) —specialization→ ERP (Application Component)`
- [ ] `ERP (Application Component) —composition→ Finance, Logistika, HR (Application Interface)`
- [ ] `ERP (Application Component) —assignment→ Finance, Logistika, HR (Application Component)`
- [x] `ERP (Application Component) —composition→ Finance, Logistika, HR (Application Component)`

> Samostatně nasaditelné moduly, které existují jen v rámci ERP, jsou komponenty složené do celku kompozicí. Specialization znamená „je druhem", ne „je částí"; moduly nejsou přístupové body (rozhraní) a assignment mezi komponentami nevyjadřuje vztah celku a části.

### ? Obchodní firma používá CRM jako SaaS; nemá k němu vlastní servery a stará se o něj interní tým aplikací. Do CRM se integruje vlastní ERP. Architekt kreslí přehled aplikačního portfolia. Jak CRM modelovat?

- [x] Jako Application Component, protože jde o aplikaci bez ohledu na provoz
- [ ] Jako Node, protože běží v cloudu u externího poskytovatele CRM
- [ ] Jako Artifact, protože firma používá jen hotový balík poskytovatele
- [ ] Jako Business Actor, protože jej provozuje externí firma za poplatek

> V aplikačním portfoliu je CRM aplikace, tedy Application Component; způsob provozu (SaaS) může doplnit technologická vrstva. Node popisuje výpočetní prostředek, Artifact fyzický soubor či balík a Business Actor organizaci — dodavatele, ne aplikaci samotnou.

### ? V modelu je `Zákaznická databáze (Application Component) —serving→ CRM (Application Component)`. Popis uvádí, že jde o záznamy zákazníků, které CRM čte a zapisuje. Jak model nejlépe opravit?

- [ ] Ponechat komponentu, jen obrátit serving od CRM k zákaznické databázi
- [x] Záznamy modelovat jako Data Object, ke kterému má funkce CRM access
- [ ] Záznamy modelovat jako Application Interface, které CRM zpřístupňuje
- [ ] Záznamy modelovat jako Application Service, kterou realizuje funkce CRM

> Obsah dat je pasivní struktura — Data Object, s nímž pracuje chování CRM přes access (read i write). Obrácení serving chybnou volbu typu neopraví a rozhraní ani služba nejsou data, ale přístupový bod a nabízená funkcionalita.

## Application Function × Process × Interaction {#app-chovani .compare}

Automatizované chování uvnitř aplikací — stejné rozlišení jako v business vrstvě.

| | Application Function | Application Process | Application Interaction |
|---|---|---|---|
| Podstata | seskupení funkcionality komponenty | automatizovaná posloupnost kroků s výsledkem | společné chování dvou a více komponent |
| Spouštění | bez pořadí, trvale k dispozici | událostí nebo jiným procesem (triggering) | společně, výsledek nevznikne jednou komponentou |
| Vykonavatel | Application Component (assignment) | Application Component (assignment) | Application Collaboration (assignment) |
| Příklady | „Správa kontaktů", „Účtování" | „Zpracování došlé faktury", „Noční uzávěrka" | „Potvrzení distribuované transakce" |
| Kdy použít | mapa funkcionality aplikace | workflow, dávky, orchestrace kroků | výjimečně — jen u skutečně společného chování |

### ? Účetní systém zpracovává došlé faktury automaticky: po načtení skenu provede vytěžení údajů, kontrolu proti objednávce a zaúčtování; výsledkem je zaúčtovaný doklad. Jakým prvkem modelovat „Zpracování došlé faktury"?

- [ ] Application Function přiřazená účetnímu systému
- [ ] Application Interaction účetního systému a skeneru
- [ ] Application Service účetního systému pro účtárnu
- [x] Application Process přiřazený účetnímu systému

> Automatizovaná posloupnost kroků s výsledkem je Application Process vykonávaný komponentou. Funkce nemá pořadí kroků, interakce by vyžadovala společné chování dvou komponent a služba je vnější pohled na nabízenou funkcionalitu, ne vnitřní průběh.

### ? Architekt připravuje mapu funkcionality CRM pro vedoucího obchodu: co všechno CRM umí (správa kontaktů, evidence příležitostí, kampaně), bez pořadí a bez vazby na konkrétní spouštěče. Který fragment je nejvhodnější?

- [x] `CRM (Application Component) —assignment→ Správa kontaktů, Evidence příležitostí, Kampaně (Application Function)`
- [ ] `CRM (Application Component) —assignment→ Správa kontaktů, Evidence příležitostí, Kampaně (Application Process)`
- [ ] `Správa kontaktů, Evidence příležitostí, Kampaně (Application Function) —assignment→ CRM (Application Component)`
- [ ] `CRM (Application Component) —triggering→ Správa kontaktů, Evidence příležitostí, Kampaně (Application Function)`

> Trvalé seskupení funkcionality bez pořadí jsou Application Functions přiřazené komponentě. Procesy by naznačovaly posloupnost a spouštěče, které scénář nemá, třetí možnost obrací směr assignmentu a triggering nevyjadřuje, kdo chování vykonává.

## Application Service v praxi {#aplikacni-sluzba .explain}

Application Service vyjadřuje **funkcionalitu, kterou aplikace nabízí** jiným aplikacím nebo uživatelům, bez ohledu na vnitřní implementaci. Realizuje ji Application Function nebo Process (`—realization→`) a slouží spotřebiteli (`—serving→` komponentě, aplikačnímu chování nebo business procesu). Jedna služba může sloužit více spotřebitelům — to je hlavní důvod ji modelovat: ukáže závislosti a dopady změn. Pojmenovává se podle užitku pro spotřebitele („Ověření bonity", „Zaslání SMS"), ne podle technologie („REST endpoint").

*Příklad:* `Scoring (Application Function) —realization→ Výpočet skóre (Application Service) —serving→ Úvěrový systém (Application Component)`.

### ? Banka má scoringový systém, jehož výpočet skóre klienta využívá úvěrový systém i online žádost o kartu. Architekt chce ukázat, co scoring nabízí, a oddělit to od vnitřního výpočtu, který se bude měnit. Který fragment je nejvhodnější?

- [ ] `Výpočet skóre (Application Service) —realization→ Scoring (Application Function)`; služba —serving→ oběma spotřebitelům
- [ ] `Scoring (Application Function) —serving→ Výpočet skóre (Application Service)`; služba —realization→ oběma spotřebitelům
- [x] `Scoring (Application Function) —realization→ Výpočet skóre (Application Service)`; služba —serving→ oběma spotřebitelům
- [ ] `Scoring (Application Function) —realization→ dvě Application Services, každá —serving→ jednomu ze spotřebitelů`

> Funkce realizuje službu a jedna služba slouží oběma spotřebitelům; vnitřní výpočet lze měnit bez dopadu na ně. První možnost obrací realizaci, druhá zaměňuje serving a realization a dvě služby by duplikovaly stejnou funkcionalitu.

### ? Analytik pojmenoval aplikační služby e-shopu „REST /orders POST", „SOAP CustomerWS" a „Kafka topic payments". Jaké doporučení je nejlepší?

- [ ] Ponechat názvy, protože služba má vždy nést název použité technologie
- [ ] Přejmenovat je na názvy komponent, které služby poskytují
- [ ] Změnit je na Data Objects, protože popisují přenášené zprávy
- [x] Pojmenovat služby podle užitku a technické body dát do rozhraní

> Služba se pojmenovává podle toho, co spotřebiteli přináší („Založení objednávky", „Vyhledání zákazníka"); konkrétní endpointy a protokoly patří k Application Interface. Technologické názvy nejsou povinné, název komponenty by smazal rozdíl poskytovatele a služby a služby nejsou data.

## Application Service × Application Interface {#sluzba-rozhrani-app .compare}

Služba = **co** aplikace nabízí, rozhraní = **kudy** se k tomu spotřebitel dostane.

| | Application Service | Application Interface |
|---|---|---|
| Aspekt | externí chování | externí aktivní struktura |
| Příklady | „Ověření adresy", „Stav zásob" | „REST API zásob", „Webový formulář", „Dávkové SFTP rozhraní" |
| Vztah k poskytovateli | realizuje ji funkce / proces komponenty | `Komponenta —composition→ Rozhraní` |
| Vztah ke službě | — | `Rozhraní —assignment→ Služba` |
| Vztah ke spotřebiteli | `Služba —serving→ spotřebitel` | `Rozhraní —serving→ spotřebitel` |
| Pro uživatele | — | GUI je také Application Interface |

### ? Skladový systém WMS nabízí „Stav zásob" e-shopu přes REST API a skladníkům přes obrazovku v terminálu; obsah informace je stejný. Který model je nejvhodnější?

- [ ] Dvě Application Services „Stav zásob API" a „Stav zásob GUI" bez rozhraní
- [x] Jedna Application Service a dvě Application Interfaces přiřazené této službě
- [ ] Jedna Application Interface a dvě Application Services, které jí slouží
- [ ] Dvě Application Components „API" a „GUI" složené do WMS kompozicí

> Funkcionalita je jedna, liší se přístupové body — jedna služba a dvě rozhraní (API a GUI) s assignmentem ke službě. Dvě služby by duplikovaly totéž chování, služba rozhraní neslouží (je mu přiřazena) a API ani obrazovka nejsou samostatně nasaditelné komponenty.

### ? Který fragment správně zachycuje, že platební brána poskytuje e-shopu službu „Autorizace platby" přes své API?

- [ ] `E-shop (Application Component) —composition→ Platební API (Application Interface) —assignment→ Autorizace platby (Application Service)`
- [ ] `Platební brána (Application Component) —composition→ Platební API (Application Interface) —realization→ Autorizace platby (Application Service)`
- [ ] `Platební brána (Application Component) —composition→ Autorizace platby (Application Service) —assignment→ Platební API (Application Interface)`
- [x] `Platební brána (Application Component) —composition→ Platební API (Application Interface) —assignment→ Autorizace platby (Application Service)`

> Rozhraní patří poskytovateli (composition od platební brány) a je přiřazeno službě, kterou zpřístupňuje. API není součástí e-shopu, který je spotřebitelem; realization od rozhraní ke službě nevyjadřuje zpřístupnění a třetí možnost obrací role služby a rozhraní.

## Směr serving v integraci {#smer-serving .explain}

Serving vede vždy **od poskytovatele ke spotřebiteli**: od služby nebo rozhraní toho, kdo funkcionalitu nabízí, k tomu, kdo ji využívá. Směr volání je obvykle opačný než serving: volající je spotřebitel a šipka serving vede k němu. Neplést se směrem dat: když e-shop „stahuje" ceník z ERP, data tečou z ERP do e-shopu a ERP zároveň e-shopu slouží. Rozhraní je součástí poskytovatele, ne spotřebitele. Kontrolní otázka: „Kdo by přestal fungovat, kdyby druhý vypadl?" — ten je spotřebitel.

*Příklad:* `ERP (Application Component) —composition→ Ceníkové API (Application Interface) —serving→ E-shop (Application Component)`.

### ? V modelu je `E-shop (Application Component) —serving→ Doprava (Application Service)`, kde služba „Doprava" patří systému dopravce a e-shop ji volá pro výpočet ceny doručení. Co je chybně?

- [ ] Služba nesmí být spotřebitelem, a proto se má změnit na Application Function
- [ ] Mezi komponentou a službou dopravce se má použít triggering místo serving
- [x] Směr je obrácený — služba dopravce má sloužit e-shopu, který ji využívá
- [ ] E-shop má službu realizovat, protože výpočet ceny doručení iniciuje sám

> Poskytovatelem je systém dopravce, e-shop je spotřebitel, proto `Doprava (Application Service) —serving→ E-shop`. Změna typu ani triggering problém směru neřeší a realizaci provádí chování poskytovatele, ne volající e-shop.

### ? E-shop každou hodinu sám stahuje aktuální ceník z ERP přes ceníkové API, které ERP nabízí. Architekt váhá se směrem vztahu. Který fragment je správný?

- [x] `Ceníkové API (Application Interface)` je součástí ERP a `—serving→ E-shop`
- [ ] `Ceníkové API (Application Interface)` je součástí e-shopu a `—serving→ ERP`
- [ ] `E-shop (Application Component) —serving→ ERP`, protože e-shop ceník stahuje
- [ ] `E-shop (Application Component) —realization→ Ceníkové API (Application Interface)`

> ERP funkcionalitu nabízí a jeho API slouží e-shopu, který ceník využívá — iniciativa stahování na tom nic nemění. API nepatří spotřebiteli, serving od e-shopu k ERP obrací vztah a e-shop rozhraní neposkytuje, a proto ho ani nerealizuje.

### ? Mobilní aplikace banky volá API core bankingu pro zobrazení zůstatku. Při výpadku core bankingu přestane zobrazení zůstatku fungovat; při výpadku mobilní aplikace core banking běží dál. Který vztah vyjadřuje závislost správně?

- [ ] `Mobilní aplikace (Application Component) —serving→ Zůstatek účtu (Application Service)`
- [ ] `Zůstatek účtu (Application Service) —assignment→ Mobilní aplikace (Application Component)`
- [ ] `Zůstatek účtu (Application Service) —realization→ Mobilní aplikace (Application Component)`
- [x] `Zůstatek účtu (Application Service) —serving→ Mobilní aplikace (Application Component)`

> Na službě core bankingu závisí mobilní aplikace, je tedy spotřebitelem a serving vede od služby k ní. Obrácený serving tvrdí opak, assignment nevede od služby (chování) k aktivní struktuře a mobilní aplikace službu nerealizuje.

## Data Object v praxi {#data-object .explain}

Data Object jsou **data strukturovaná pro automatizované zpracování** — logický obsah („Objednávka", „Zákazník", „Pohyb na účtu"), nezávislý na úložišti. Pracuje s ním chování přes **access** (read, write, readwrite). Nezaměňuj: databázový server je System Software, konkrétní soubor nebo tabulkový prostor je Artifact (obojí technologická vrstva), informace z pohledu byznysu je Business Object (Data Object ji může realizovat — vazba patří do modelů napříč vrstvami). Data Object sám nic nespouští ani nikomu neslouží; přenášená data se v integraci vyjadřují tokem mezi chováními nebo komponentami, ne vztahem od objektu.

*Příklad:* `Fakturace (Application Function) —access (read)→ Zákazník (Data Object)`; `Fakturace —access (write)→ Faktura (Data Object)`.

### ? Systém věrnostního programu při každém nákupu načte údaje o členovi a zapíše přičtené body. Architekt modeluje tuto práci s daty. Který fragment je správný?

- [ ] `Člen (Data Object) —flow→ Připsání bodů (Application Process)`; `Připsání bodů —flow→ Body (Data Object)`
- [x] `Připsání bodů (Application Process) —access (read)→ Člen (Data Object)`; `Připsání bodů —access (write)→ Body`
- [ ] `Připsání bodů (Application Process) —access (write)→ Člen (Data Object)`; `Připsání bodů —access (read)→ Body`
- [ ] `Člen (Data Object) —serving→ Připsání bodů (Application Process)`; `Připsání bodů —realization→ Body`

> Access vede od chování k datům a režim říká, co se čte a co zapisuje. Flow je dynamický vztah mezi chováními (nikoli k datovému objektu), třetí možnost má prohozené režimy a pasivní Data Object nikomu neslouží ani se realizací „nevyrábí".

### ? Architekt aplikační vrstvy má zachytit „Smlouvy klientů", které systém správy smluv eviduje jako strukturované záznamy a zpracovává je automaticky. O databázovém serveru ani souborech zatím nerozhoduje. Jaký prvek je nejvhodnější?

- [ ] Application Component „Databáze smluv" spojená se systémem kompozicí
- [ ] Artifact „Smlouvy klientů", protože data jsou uložena v databázi
- [x] Data Object „Smlouvy klientů" s access od chování systému smluv
- [ ] Business Object „Smlouvy klientů" s access od komponenty systému

> Logická data pro automatizované zpracování jsou Data Object, ke kterému přistupuje aplikační chování. Databáze není aplikační komponenta, Artifact popisuje fyzické uložení v technologické vrstvě, o němž se zatím nerozhoduje, a Business Object je pohled byznysu, ne aplikační data.

## Vlastnictví dat mezi aplikacemi {#vlastnictvi-dat .explain}

V integračních scénářích je klíčové, **která aplikace data zapisuje** (je jejich zdrojem pravdy) a které je jen **čtou**. Vyjadřuje se to režimem access: vlastník má `access (write)` nebo `(readwrite)`, ostatní `access (read)`. Když více aplikací zapisuje stejný Data Object, model tím odhalí riziko nekonzistence — typický podnět pro master data management (MDM). Pokud mají spotřebitelé vlastní kopie, modeluj kopii jako samostatný Data Object a přenos jako flow nebo replikační proces.

*Příklad:* `Správa kmenových dat (Application Function) —access (write)→ Zákazník (Data Object)`; `Fakturace (Application Function) —access (read)→ Zákazník`.

### ? Firma zavádí MDM: kmenová data zákazníka smí zakládat a měnit jen systém MDM, CRM i fakturace je pouze čtou přímo z MDM. Který fragment to vyjadřuje?

- [ ] Funkce MDM, CRM i fakturace mají `—access (readwrite)→ Zákazník (Data Object)`, aby se data dala opravit kdekoli
- [ ] Funkce MDM má `—access (read)→ Zákazník (Data Object)`; funkce CRM i fakturace mají `—access (write)→ Zákazník`
- [ ] Funkce MDM má `—access (write)→ Zákazník (Data Object)`; `Zákazník —flow→` funkcím CRM i fakturace
- [x] Funkce MDM má `—access (write)→ Zákazník (Data Object)`; funkce CRM i fakturace mají `—access (read)→ Zákazník`

> Zdroj pravdy zapisuje a ostatní čtou — režimy access přesně vystihují pravidlo MDM. Zápis odkudkoli je stav, který MDM odstraňuje, druhá možnost obrací role a flow od datového objektu není povolený — tok se kreslí mezi chováními či komponentami.

### ? Analýza současného stavu zjistila, že adresu zákazníka zapisují e-shop, CRM i call centrum, každý po svém, a adresy se rozcházejí. Jak to v modelu současného stavu zachytit nejvěrněji?

- [ ] Jeden Data Object „Adresa" s access (read) od všech tří aplikací
- [x] Jeden Data Object „Adresa" s access (write) od všech tří aplikací
- [ ] Tři Application Services „Adresa", každá patřící jiné z aplikací
- [ ] Jedna Application Interaction „Správa adresy" všech tří aplikací

> Současný stav má ukázat, že tři aplikace zapisují stejná data — to je zdroj nekonzistence. Pouhé čtení by problém zakrylo, služby nejsou data a interakce by tvrdila koordinovanou společnou práci, kterou aplikace nedělají.

## Flow × Triggering mezi aplikacemi {#flow-triggering-app .compare}

Oba vztahy jsou dynamické; v integraci se kreslí mezi aplikačními procesy či funkcemi, mezi událostmi a procesy, a v přehledových modelech i přímo mezi komponentami.

| | Flow | Triggering |
|---|---|---|
| Význam | z A do B se **přenášejí data** | A **spouští** B (příčina a časová návaznost) |
| Spouští příjemce? | ne — příjemce data zpracuje podle svého | ano |
| Typický scénář | noční přenos zákazníků do fakturace, replikace | událost „Objednávka vytvořena" spustí vychystání |
| Notace | čárkovaná čára s plnou šipkou | plná čára s plnou šipkou |
| Popis | název přenášených dat na vztahu | název spouštěče nebo podmínky |

### ? CRM každou noc předává fakturaci aktualizované údaje zákazníků. Fakturace je použije až při měsíčním vyúčtování, které spouští její vlastní plán. Který fragment je nejvhodnější?

- [x] `CRM (Application Component) —flow→ Fakturace (Application Component)` s popisem „Údaje zákazníků"
- [ ] `CRM (Application Component) —triggering→ Fakturace (Application Component)` s popisem „Údaje zákazníků"
- [ ] `Fakturace (Application Component) —flow→ CRM (Application Component)` s popisem „Údaje zákazníků"
- [ ] `CRM (Application Component) —serving→ Fakturace (Application Component)` s popisem „Noční spuštění"

> Data se přenášejí, ale fakturaci nic nespouští — správný je flow z CRM do fakturace. Triggering by tvrdil, že příjem dat zahájí vyúčtování, třetí možnost má obrácený směr toku a serving s popisem spouštění míchá závislost na službě s časovou návazností.

### ? Po vytvoření objednávky v e-shopu musí skladový systém okamžitě zahájit proces vychystání. Který fragment nejlépe vyjadřuje tuto návaznost?

- [ ] `Vytvoření objednávky (Application Process) —flow→ Vychystání (Application Process)`
- [x] `Vytvoření objednávky (Application Process) —triggering→ Vychystání (Application Process)`
- [ ] `Vytvoření objednávky (Application Process) —serving→ Vychystání (Application Process)`
- [ ] `Vychystání (Application Process) —triggering→ Vytvoření objednávky (Application Process)`

> Dokončení vytvoření objednávky přímo spouští vychystání, což je triggering. Flow by vyjadřoval jen přenos dat bez spuštění, serving není časová návaznost a poslední možnost obrací příčinu a následek.

### ? Model obsahuje `Objednávka (Data Object) —triggering→ Vychystání (Application Process)`. Co je chybně a jak to opravit?

- [ ] Nic, data mohou spouštět zpracování, pokud jde o integraci
- [ ] Má být flow, protože objednávka se do skladu přenáší jako data
- [x] Spouštět smí událost nebo chování; data mají access od procesu
- [ ] Má být serving, protože objednávka slouží procesu vychystání

> Pasivní Data Object nemůže být zdrojem triggering ani flow; spouštěčem je Application Event (např. „Objednávka vytvořena") nebo předchozí proces a s daty proces pracuje přes access. Flow i serving od datového objektu jsou stejně nepřípustné.

## Application Event v integraci {#app-event .explain}

Application Event je okamžik, na který aplikace reaguje: přijatá notifikace („Platba potvrzena"), interní změna stavu („Zásoba pod minimem") nebo čas („Půlnoc"). Událost **spouští** aplikační proces (`—triggering→`) a proces může událostí končit. V událostmi řízené integraci (publish/subscribe) jedna událost spouští procesy ve více aplikacích; prostředník (message broker) se modeluje podle potřeby scénáře — viz middleware. Událost není zpráva jako data: obsah zprávy je Data Object, ke kterému má proces access.

*Příklad:* `Platba potvrzena (Application Event) —triggering→ Vystavení faktury (Application Process) —access (write)→ Faktura (Data Object)`.

### ? Platební brána pošle e-shopu notifikaci „Platba potvrzena"; e-shop na ni reaguje automatickým vystavením faktury. Který fragment je správný?

- [ ] `Platba potvrzena (Data Object) —triggering→ Vystavení faktury (Application Process)`
- [ ] `Platba potvrzena (Application Service) —triggering→ Vystavení faktury (Application Process)`
- [ ] `Vystavení faktury (Application Process) —triggering→ Platba potvrzena (Application Event)`
- [x] `Platba potvrzena (Application Event) —triggering→ Vystavení faktury (Application Process)`

> Notifikace představuje okamžik, který spouští zpracování — Application Event s triggeringem k procesu. Data Object nic spouštět nemůže, služba popisuje nabízenou funkcionalitu, ne okamžik, a třetí možnost obrací pořadí příčiny a následku.

### ? Událost „Objednávka vytvořena" v e-shopu musí spustit vychystání ve skladovém systému i odeslání potvrzení v notifikačním systému; oba procesy běží nezávisle na sobě. Který fragment je nejvhodnější?

- [x] `Objednávka vytvořena (Application Event) —triggering→` oba procesy, každý přiřazený své komponentě
- [ ] `Objednávka vytvořena (Application Event) —serving→` oba procesy, každý přiřazený své komponentě
- [ ] `Objednávka vytvořena (Application Event) —triggering→ Vychystání (Application Process) —triggering→ Odeslání potvrzení (Application Process)`
- [ ] `Objednávka vytvořena (Data Object) —flow→` oba procesy, každý přiřazený své komponentě

> Jedna událost může spouštět více procesů v různých aplikacích. Serving nevyjadřuje spouštění, řetězení procesů by odeslání potvrzení učinilo závislým na vychystání, což ve scénáři není, a datový objekt nemůže být zdrojem flow.

## Integrační vzor: API {#integrace-api .explain}

Synchronní integrace přes API se modeluje řetězcem na straně **poskytovatele** a vazbou ke **spotřebiteli**: komponenta poskytovatele —composition→ rozhraní (API) —assignment→ služba, funkce poskytovatele —realization→ služba a služba (nebo rozhraní) —serving→ komponentě či chování spotřebitele. Volitelně se doplní data, která služba vrací (access od chování poskytovatele k Data Object). Pro přehled stačí `služba —serving→ spotřebitel`; rozhraní kresli, když na něm záleží (verze API, protokol, více kanálů). API gateway či integrační platformu mezi stranami modeluj jen tehdy, když ji stakeholder potřebuje vidět.

*Příklad:* `WMS (Application Component) —composition→ API zásob (Application Interface) —assignment→ Stav zásob (Application Service) —serving→ E-shop (Application Component)`.

### ? Skladový systém WMS zpřístupňuje REST API pro dotaz na stav zásob. E-shop ho volá při zobrazení produktu. Integrační architekt chce vidět poskytovatele, přístupový bod, službu i spotřebitele. Který fragment je správný?

- [ ] `E-shop (Application Component) —composition→ API zásob (Application Interface) —assignment→ Stav zásob (Application Service) —serving→ WMS`
- [ ] `WMS (Application Component) —composition→ Stav zásob (Application Service) —assignment→ API zásob (Application Interface) —serving→ E-shop`
- [x] `WMS (Application Component) —composition→ API zásob (Application Interface) —assignment→ Stav zásob (Application Service) —serving→ E-shop`
- [ ] `WMS (Application Component) —composition→ API zásob (Application Component) —realization→ Stav zásob (Application Service) —serving→ E-shop`

> API je součástí poskytovatele WMS, je přiřazeno službě a služba slouží e-shopu. První možnost umisťuje API ke spotřebiteli a obrací serving, druhá prohazuje službu a rozhraní a čtvrtá dělá z API komponentu, která službu realizuje.

### ? Pojišťovna nabízí partnerům (srovnávačům) API pro kalkulaci pojistného. Vedení chce přehled, kteří partneři na kalkulaci závisejí; protokoly ani verze API ho nezajímají. Který model je pro tento účel nejvhodnější?

- [ ] Podrobný řetězec s rozhraním pro každou verzi API a každým endpointem
- [x] `Kalkulace pojistného (Application Service) —serving→` aplikace jednotlivých partnerů
- [ ] `Aplikace partnerů (Application Component) —serving→ Kalkulace pojistného (Application Service)`
- [ ] `Kalkulace pojistného (Application Interface) —realization→` aplikace jednotlivých partnerů

> Pro přehled závislostí stačí služba se serving ke spotřebitelům; detaily rozhraní by čtenáře zahltily. Třetí možnost obrací směr závislosti a rozhraní partnerské aplikace nerealizuje.

## Middleware jako komponenta nebo služba {#middleware .compare}

Integrační platforma (ESB, iPaaS, message broker) se modeluje podle toho, **co z ní scénář potřebuje vidět**.

| Situace | Jak modelovat | Příklad |
|---|---|---|
| platforma obsahuje firemní integrační logiku (mapování, orchestrace, pravidla) a spravuje ji integrační tým jako aplikaci | **Application Component** s vlastními funkcemi a službami; toky vedou přes ni | `CRM —flow→ ESB (Application Component) —flow→ ERP` |
| podstatné je, co platforma nabízí ostatním aplikacím | **Application Service** platformy sloužící komponentám | `Směrování zpráv (Application Service) —serving→ CRM` |
| jde o obecný infrastrukturní produkt bez firemní logiky | **System Software** s Technology Service pro aplikace (technologická vrstva) | `Doručování zpráv (Technology Service) —serving→ CRM` |
| prostředník je pro čtenáře nepodstatný | vynechat, kreslit tok mezi aplikacemi | přehled pro vedení |

### ? Firma provozuje ESB, ve kterém integrační tým vyvíjí mapování objednávek z CRM do formátu ERP a pravidla směrování. Při výpadku ESB se objednávky do ERP nedostanou. Architekt chce tuto závislost ukázat. Který fragment je nejvhodnější?

- [ ] `CRM (Application Component) —flow→ ERP (Application Component)` a ESB vynechat jako technický detail
- [ ] `CRM (Application Component) —flow→ ESB (Application Interface) —flow→ ERP (Application Component)`
- [ ] `ESB (Application Component) —specialization→ CRM` a `ESB —specialization→ ERP (Application Component)`
- [x] `CRM (Application Component) —flow→ ESB (Application Component) —flow→ ERP (Application Component)`

> ESB s vlastní integrační logikou je aplikační komponenta a toky vedou přes ni, takže závislost CRM→ERP na ESB je vidět. Vynechání by ji skrylo, ESB není přístupový bod jedné aplikace (rozhraní) a specialization „je druhem" nemá s integrací nic společného.

### ? Integrační platforma nabízí všem aplikacím službu „Transformace formátů" (např. XML na JSON). Architekt chce ukázat, které aplikace na této službě závisejí, bez vnitřních detailů platformy. Který fragment je nejvhodnější?

- [x] `Transformace formátů (Application Service) —serving→` CRM, ERP a e-shopu; službu realizuje funkce platformy
- [ ] CRM, ERP a e-shop `—serving→ Transformace formátů (Application Service)`; službu realizuje funkce platformy
- [ ] `Transformace formátů (Data Object) —flow→` CRM, ERP a e-shopu; objekt zapisuje funkce platformy
- [ ] `Transformace formátů (Application Event) —triggering→` CRM, ERP a e-shopu; událost vyvolává platforma

> Funkcionalita nabízená platformou je Application Service, která slouží aplikacím-spotřebitelům. Obrácený serving tvrdí opačnou závislost, transformace není data a není to ani okamžik, který by aplikace spouštěl.

### ? Banka používá obecný message broker jako sdílenou infrastrukturu; žádnou firemní logiku neobsahuje a spravuje ho tým provozu jako ostatní systémový software. Aplikační architekt chce zachytit, že na něm CRM a core banking závisejí. Který přístup odpovídá situaci nejlépe?

- [ ] Broker jako Application Component s funkcí „Směrování" a toky přes něj
- [ ] Broker jako Application Interface CRM, které je přiřazené core bankingu
- [x] Broker jako System Software, jehož Technology Service slouží oběma aplikacím
- [ ] Broker jako Data Object, ke kterému mají CRM i core banking access (write)

> Obecný infrastrukturní produkt bez firemní logiky patří do technologické vrstvy: System Software nabízí Technology Service, která slouží aplikačním komponentám. Modelovat ho jako aplikaci by zkreslilo odpovědnost, rozhraní CRM to není a broker není data.

## Point-to-point × integrační hub {#p2p-hub .explain}

Při **point-to-point** integraci si aplikace předávají data přímo — v modelu flow mezi dvojicemi komponent; s počtem aplikací rychle roste počet vazeb. Při **hub** integraci vede každá aplikace jen jeden tok k integrační platformě (komponentě) a ta data směruje dál — model ukáže centrální závislost i místo, kde se dá změna udělat jednou. Při posuzování modelu hledej: přímé toky, které ve skutečnosti jdou přes hub (skrývají závislost), a hub modelovaný jako rozhraní jedné aplikace (zkresluje vlastnictví). Model současného stavu má zachytit skutečné toky, i když jsou nepřehledné — právě to bývá argument pro změnu.

*Příklad:* Současný stav `E-shop —flow→ ERP`, `E-shop —flow→ CRM`, `CRM —flow→ ERP`; cílový stav `E-shop —flow→ Integrační platforma (Application Component) —flow→ ERP, CRM`.

### ? Firma má pět aplikací, které si dnes data předávají každá s každou přímo. Architekt připravuje cílový stav, kde veškerá výměna půjde přes novou integrační platformu s mapováním dat. Jak se liší model cílového stavu?

- [ ] Přímé toky zůstanou a integrační platforma se k nim jen přidá jako Data Object
- [ ] Přímé toky se nahradí vztahy serving mezi každou dvojicí aplikací navzájem
- [ ] Integrační platforma se modeluje jako Application Interface každé z aplikací
- [x] Každá aplikace má tok k platformě (komponentě) a ta data směruje dál

> V hub architektuře vedou toky přes integrační komponentu, takže přímé toky v cíli zmizí. Platforma není data ani rozhraní jednotlivých aplikací a serving mezi dvojicemi by zachoval point-to-point uspořádání, jen s jiným vztahem.

### ? Při revizi modelu současného stavu architekt zjistí, že model ukazuje `CRM —flow→ ERP`, ale provozní dokumentace uvádí, že data jdou přes integrační platformu s vlastní transformační logikou, jejíž výpadek tok zastaví. Co doporučit?

- [x] Doplnit platformu jako komponentu a tok vést přes ni, aby byla závislost vidět
- [ ] Ponechat přímý tok, protože model současného stavu má být co nejjednodušší
- [ ] Nahradit flow vztahem triggering, protože tok řídí integrační platforma
- [ ] Doplnit platformu jako Data Object, ke kterému mají CRM i ERP access

> Platforma s vlastní logikou a dopadem na dostupnost toku je podstatná komponenta a model současného stavu ji má ukázat. Zjednodušení by skrylo klíčovou závislost, triggering nemění přenos dat ve spouštění a platforma nejsou data.

## Integrační vzor: ETL a dávkové přenosy {#etl .explain}

ETL (extract–transform–load) je **dávkový** přenos dat, typicky do datového skladu. Modeluje se jako **Application Process** (posloupnost extrakce, transformace a nahrání) přiřazený ETL komponentě, spuštěný časovou **Application Event** („Každou noc v 1:00"). Proces má **access (read)** ke zdrojovým Data Objects a **access (write)** k cílovým; pro přehled stačí flow od zdrojových komponent k datovému skladu. Chyby: modelovat ETL jako službu datového skladu, kreslit triggering mezi zdrojem a skladem (zdroj nic nespouští, spouští plán) nebo zaměnit zdrojová a cílová data.

*Příklad:* `Noční běh (Application Event) —triggering→ Načtení prodejů (Application Process)`; `Načtení prodejů —access (read)→ Objednávky (Data Object)`; `Načtení prodejů —access (write)→ Fakta prodejů (Data Object)`.

### ? Každou noc v 1:00 ETL nástroj načte objednávky z ERP, převede je a zapíše do datového skladu jako fakta prodejů. Který fragment je nejvhodnější?

- [ ] `ERP (Application Component) —triggering→ Načtení prodejů (Application Process)`; proces má access (read) k Objednávkám a access (write) k Faktům
- [ ] `Noční běh (Application Event) —triggering→ Načtení prodejů (Application Process)`; proces má access (write) k Objednávkám a access (read) k Faktům
- [x] `Noční běh (Application Event) —triggering→ Načtení prodejů (Application Process)`; proces má access (read) k Objednávkám a access (write) k Faktům
- [ ] `Noční běh (Application Event) —serving→ Načtení prodejů (Application Service)`; služba má access (read) k Objednávkám a access (write) k Faktům

> Časová událost spouští dávkový proces, který čte zdrojová data a zapisuje cílová. ERP proces nespouští (spouští ho plán), druhá možnost má prohozené režimy přístupu a ETL není služba, kterou by událost obsluhovala.

### ? Manažer BI chce jednoduchý přehled, odkud datový sklad bere data (ERP, CRM, e-shop), bez detailu jednotlivých dávek. Který model je pro něj nejvhodnější?

- [ ] Detail každého ETL procesu s událostmi a všemi přístupy k datovým objektům
- [ ] `Datový sklad (Application Component) —flow→` ERP, CRM a e-shopu, pro každý zdroj
- [x] `ERP, CRM a e-shop (Application Component) —flow→ Datový sklad` s popisem dat
- [ ] `Datový sklad (Application Component) —serving→` ERP, CRM a e-shopu, pro každý zdroj

> Pro přehled stačí toky od zdrojových komponent k datovému skladu s popisem přenášených dat. Detail dávek manažera zahltí, toky od skladu ke zdrojům mají obrácený směr a serving vyjadřuje závislost na službě, ne odkud data přicházejí.

## Application Collaboration a Interaction {#app-kolaborace .explain}

Application Collaboration **agreguje** dvě a více komponent, které **společně** vykonávají Application Interaction — výsledek nevznikne činností jedné z nich (např. potvrzení distribuované transakce, společné párování). Je to výjimečný prvek: běžná integrace, kde jedna aplikace druhé data posílá nebo volá její službu, se modeluje tokem, triggeringem nebo serving, ne kolaborací. Kolaborace také není integrační platforma — ta je samostatná komponenta.

*Příklad:* `Převodní tandem (Application Collaboration) —aggregation→ Core banking, Platební systém (Application Component)`; `Převodní tandem —assignment→ Potvrzení převodu (Application Interaction)`.

### ? Při mezibankovním převodu musí core banking a platební systém v jedné distribuované transakci společně potvrdit odepsání a odeslání peněz; když jeden z nich selže, nepotvrdí se nic. Který fragment je nejvhodnější?

- [x] Application Collaboration agreguje obě komponenty a je přiřazena interakci „Potvrzení převodu"
- [ ] Core banking `—flow→` platební systém s popisem „Potvrzení převodu" a bez dalšího chování
- [ ] Core banking `—triggering→` platební systém, který pak sám provede „Potvrzení převodu"
- [ ] Integrační platforma jako Application Collaboration, které jsou obě komponenty přiřazeny

> Výsledek vzniká jen společným chováním dvou komponent, proto kolaborace agregující obě komponenty s přiřazenou Application Interaction. Flow ani triggering nevyjadřují společné potvrzení a integrační platforma není kolaborace, ale samostatná komponenta.

### ? Architekt modeluje „Předání objednávky" jako Application Interaction přiřazenou kolaboraci e-shopu a ERP. Ve skutečnosti e-shop objednávku jen uloží jako zprávu do fronty, žádnou službu ERP nevolá, a ERP ji samostatně zpracuje. Jak model posoudit?

- [ ] Správně, protože na předání objednávky se podílejí dvě aplikace
- [ ] Správně, jen je třeba kolaboraci nahradit jednou Application Function
- [x] Nesprávně — stačí tok (flow) z e-shopu do ERP s popisem objednávky
- [ ] Nesprávně — správně má ERP sloužit e-shopu vztahem serving bez toku

> Jednostranné předání dat se modeluje tokem; kolaborace a interakce patří jen ke skutečně společnému chování. Účast dvou aplikací kolaboraci neopravňuje, funkce by odstranila jednu ze stran a serving od ERP by tvrdil, že e-shop využívá službu ERP, což scénář vylučuje.

## Typické chyby v aplikačních modelech {#typicke-chyby-app .compare}

Kontrolní seznam pro revizi aplikačního a integračního modelu.

| Chyba | Proč je špatně | Oprava |
|---|---|---|
| API jako Application Component nebo Service | API je přístupový bod | Application Interface (composition v poskytovateli) —assignment→ služba |
| databáze jako Application Component | obsah dat je pasivní struktura | Data Object (DBMS je System Software) |
| serving od spotřebitele k poskytovateli | obrácená závislost | služba / rozhraní poskytovatele —serving→ spotřebitel |
| Data Object —triggering / flow→ | pasivní struktura je v dynamických vztazích nepřípustná | Application Event —triggering→; chování —access→ data |
| triggering pro pouhý přenos dat | tvrdí spouštění, které neexistuje | flow |
| kolaborace pro jednostranné předání | nejde o společné chování | flow, triggering nebo serving |
| skrytý prostředník s vlastní logikou | zakrývá závislost | integrační komponenta v cestě toku |

### ? Revidujete model: (1) `CRM —composition→ API kontaktů (Application Interface)`, (2) `API kontaktů —assignment→ Vyhledání kontaktu (Application Service)`, (3) `Kontakt (Data Object) —flow→ Fakturace (Application Component)`, (4) `Vyhledání kontaktu —serving→ Fakturace`. Který vztah je v rozporu s pravidly jazyka?

- [ ] Vztah 1, protože rozhraní nesmí být kompozicí součástí komponenty
- [ ] Vztah 2, protože rozhraní nesmí být přiřazeno aplikační službě
- [x] Vztah 3, protože datový objekt nemůže být zdrojem toku (flow)
- [ ] Vztah 4, protože aplikační služba nesmí sloužit jiné komponentě

> Flow je dynamický vztah mezi chováními (případně aktivní strukturou); pasivní Data Object jeho zdrojem být nemůže — přenos se kreslí mezi aplikacemi a data se k němu mohou přidat přes access. Vztahy 1, 2 a 4 jsou běžné a povolené.

### ? Integrační analytik předložil model: `Objednávkové API (Application Component) —serving→ ERP` a `Objednávky (Application Component)` jako databáze, kterou API čte. API patří e-shopu a ERP ho volá. Který soubor oprav je správný?

- [ ] API jako Application Service e-shopu; databázi ponechat jako samostatnou komponentu e-shopu
- [x] API jako Application Interface e-shopu; databázi modelovat jako Data Object e-shopu
- [ ] API jako Application Interface ERP; databázi modelovat jako Application Function
- [ ] API ponechat jako komponentu; databázi modelovat jako Application Event e-shopu

> API je přístupový bod poskytovatele (e-shopu), proto Application Interface v jeho kompozici, a obsah databáze je Data Object. Ostatní možnosti opraví jen jednu chybu, přiřadí API spotřebiteli (ERP), nebo zavádějí nevhodné typy (funkce, událost) pro data.
