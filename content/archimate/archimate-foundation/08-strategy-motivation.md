---
kind: topic
subject: archimate-foundation
slug: strategy-motivation
name: "Strategy a Motivation elements"
order: 8
---

Resource, Capability, Value Stream, Course of Action; Stakeholder, Driver, Assessment, Goal, Outcome, Principle, Requirement, Constraint, Meaning, Value.

## Strategy elements v přehledu {#strategy-prehled .explain}

**Strategy elements** slouží k modelování strategického směřování podniku a jeho schopností na vyšší úrovni abstrakce, než je Core Framework. Patří sem **Resource** (struktura), **Capability** a **Value Stream** (chování) a **Course of Action** (plán jejich využití). Strategické prvky propojují motivaci (proč — Goals, Outcomes) s realizací v Core prvcích (jak — procesy, aplikace, technologie): capabilities a value streamy jsou realizovány Core prvky chování, resources Core prvky struktury. Strategy elements patří do Full Framework.

*Příklad:* `Vyřizování reklamací (Business Function) —realization→ Řízení reklamací (Capability)`

### ? Který Strategy element patří do aspektu struktury, a ne chování?

- [ ] Capability
- [ ] Value Stream
- [x] Resource
- [ ] Course of Action

> Resource je strukturní prvek strategie — aktivum, které podnik vlastní nebo ovládá. Capability a Value Stream popisují chování na strategické úrovni a Course of Action je plán, ne struktura.

### ? Který prvek NEPATŘÍ mezi Strategy elements jazyka ArchiMate 3.2?

- [ ] Capability
- [x] Work Package
- [ ] Resource
- [ ] Value Stream

> Work Package patří do Implementation & Migration. Strategy elements jsou Resource, Capability, Value Stream a Course of Action.

## Zdroj (Resource) {#resource .term}

**Resource** odpovídá na otázku, **s čím** podnik pro své schopnosti počítá: je to aktivum, které má ve vlastnictví nebo pod kontrolou — hmotné (budovy, stroje, peníze), nehmotné (značka, know-how, data, patenty) i lidské (kvalifikovaní zaměstnanci). Zdroj se přiřazuje schopnosti, kterou umožňuje: `Vozový park (Resource) —assignment→ Rozvoz zboží (Capability)`; v Core ho realizují prvky struktury: `Flotila (Equipment) —realization→ Vozový park (Resource)`. Hodí se pro analýzu zdrojů konkurenční výhody nebo pro mapu zdrojů.

### ? Co z následujícího se nejlépe modeluje jako Resource?

- [ ] Schopnost rychle uvést nový produkt na trh
- [x] Silná značka a databáze věrných zákazníků
- [ ] Plán vstupu na slovenský trh v roce 2027
- [ ] Zvýšit podíl na trhu o pět procentních bodů

> Značka a zákaznická databáze jsou aktiva, která firma vlastní či ovládá, tedy Resources. Schopnost je Capability, plán vstupu na trh Course of Action a zvýšení podílu Goal nebo Outcome.

### ? Které tvrzení o Resource je správné?

- [ ] Zahrnuje jen hmotný majetek zapsaný v účetnictví firmy
- [ ] Je to chování popisující, co firma umí dělat
- [ ] Je to žádoucí cílový stav, k němuž firma směřuje
- [x] Může být hmotný, nehmotný i lidský, např. značka

> Resource zahrnuje hmotná, nehmotná i lidská aktiva, která organizace vlastní nebo ovládá. Co firma umí, vyjadřuje Capability, a žádoucí stav Goal.

### ? Který fragment vyjadřuje, že zdroj Vozový park umožňuje schopnost Rozvoz zboží?

- [ ] Rozvoz zboží (Capability) —realization→ Vozový park (Resource)
- [ ] Vozový park (Resource) —serving→ Rozvoz zboží (Capability)
- [x] Vozový park (Resource) —assignment→ Rozvoz zboží (Capability)
- [ ] Vozový park (Resource) —composition→ Rozvoz zboží (Capability)

> Zdroj se ke schopnosti, kterou umožňuje, přiřazuje vztahem assignment od Resource ke Capability. Capability zdroj nerealizuje (Resource realizují prvky struktury Core), serving není vztah, kterým se zdroj ke schopnosti váže, a composition by ze schopnosti dělala součást zdroje.

## Schopnost (Capability) {#capability .term}

**Capability** odpovídá na otázku, **co** podnik umí dělat — „Řízení úvěrového rizika", „Onboarding klientů" — a záměrně neříká, **jak a kým** je to zajištěno. Capabilities jsou v čase stabilní, tvoří hierarchii (capability map; nadřazená capability se skládá z dílčích — composition či aggregation) a hodí se pro strategické plánování a „heat mapy" (kde investovat, kde podnik zaostává). V Core je capability realizována (realization) prvky chování, např. Business Function, Business Process nebo Application Function, a zdroje (Resources) se k ní přiřazují vztahem assignment.

*Příklad:* `Správa objednávek (Business Function) —realization→ Řízení objednávek (Capability)`

### ? Banka chce zmapovat, CO umí dělat (např. „Řízení úvěrového rizika", „Onboarding klientů"), na strategické úrovni pro plánování investic, bez ohledu na to, kdo a čím to zajišťuje. Který prvek použije?

- [x] Capability
- [ ] Business Function
- [ ] Business Service
- [ ] Value Stream

> Capability vyjadřuje, co podnik umí, nezávisle na tom, kdo a jak to zajišťuje. Business Function je konkrétní chování v Business Layer, Business Service navenek nabízená služba a Value Stream sled fází vytvářejících hodnotu.

### ? Který fragment správně vyjadřuje, že capability je zajištěna prvkem Core Framework?

- [ ] Řízení skladu (Capability) —realization→ Skladování (Business Function)
- [ ] Řízení skladu (Capability) —assignment→ Skladování (Business Function)
- [ ] Skladování (Business Function) —triggering→ Řízení skladu (Capability)
- [x] Skladování (Business Function) —realization→ Řízení skladu (Capability)

> Konkrétní chování v Core (zde Business Function) capability realizuje, takže realization vede od funkce k capability. Opačný směr je chybný, assignment vede od aktivní struktury ke chování a triggering vyjadřuje časovou návaznost.

### ? Jak se v capability map obvykle vyjadřuje, že capability „Řízení zákazníků" zahrnuje dílčí capabilities „Akvizice zákazníků" a „Péče o zákazníky"?

- [ ] Vztahem triggering mezi dílčími capabilities
- [x] Vztahem composition či aggregation od celku k části
- [ ] Vztahem realization od celku k dílčí capability
- [ ] Vztahem access z dílčích capabilities na celek

> Hierarchie capabilities je vztah celek–část, proto se modeluje composition nebo aggregation. Triggering vyjadřuje časovou návaznost, realization uskutečnění abstraktnějšího prvku a access přístup k pasivním prvkům.

## Capability × Business Function {#capability-vs-function .compare}

Oba prvky popisují chování podniku, ale na jiné úrovni a s jiným účelem.

| Hledisko | Capability | Business Function |
|---|---|---|
| Vrstva | Strategy (chování) | Business Layer (interní chování) |
| Odpovídá na otázku | co podnik umí a jak dobře | jak je práce seskupena podle dovedností, znalostí a zdrojů |
| Úroveň | abstraktní, stabilní, pro strategické plánování | konkrétní chování vykonávané v organizaci |
| Kdo ji vykonává | neřeší, nezávislá na organizační struktuře | přiřazena (assignment) Business Role nebo Business Actor |
| Vzájemný vztah | je realizována | `Business Function —realization→ Capability` |

### ? Který vztah obvykle vede mezi Business Function a Capability?

- [ ] Capability —assignment→ Business Function
- [ ] Capability —composition→ Business Function
- [x] Business Function —realization→ Capability
- [ ] Business Function —triggering→ Capability

> Business Function je konkrétní chování, které abstraktní capability uskutečňuje, proto vede realization od funkce ke capability. Assignment, composition ani triggering tento vztah nevyjadřují.

### ? Které tvrzení nejlépe vystihuje rozdíl mezi Capability a Business Function?

- [ ] Capability je chování Business Layer, funkce patří do Strategy
- [ ] Capability se přiřazuje roli vztahem assignment, funkce nikdy
- [x] Capability říká, co podnik umí; funkce je chování, které ji realizuje
- [ ] Capability je jen jiný název pro funkci na nejvyšší úrovni

> Capability je abstraktní schopnost ve Strategy, Business Function konkrétní chování v Business Layer, které ji realizuje. Role se přiřazují k funkcím, ne ke capabilities, a nejde o synonyma.

### ? Strategický útvar chce barevně vyznačit, ve kterých oblastech podnik zaostává za konkurencí, a to v mapě nezávislé na organizační struktuře. Které prvky do mapy zakreslí?

- [ ] Business Functions s přiřazenými rolemi
- [ ] Business Roles klíčových pracovníků
- [ ] Application Components podnikových systémů
- [x] Capabilities uspořádané do hierarchie

> Mapa schopností nezávislá na organizační struktuře je capability map; vyhodnocení slabých míst se do ní zakresluje barevně jako „heat map". Business Functions jsou konkrétní chování Business Layer přiřazené rolím; pro strategické hodnocení slabých míst slouží capability map (heat map). Role a aplikace popisují jinou úroveň než schopnosti podniku.

## Hodnotový tok (Value Stream) {#value-stream .term}

**Value Stream** je sled činností (fází, value stream stages), které společně vytvářejí celkový výsledek pro zákazníka, stakeholdera nebo koncového uživatele — „Od objednávky k doručení", „Získání hypotéky", „Vyřízení pojistné události". Fáze se obvykle modelují jako části celého toku a řadí se za sebou; každá přidává hodnotu (Value). Capability slouží fázi, kterou umožňuje: `Hodnocení bonity (Capability) —serving→ Posouzení (Value Stream)`; Core prvky chování (typicky business procesy) value stream realizují. **Notace:** tvar šipky (chevron).

### ? Pojišťovna chce popsat, jakými fázemi prochází klient od nahlášení škody po vyplacení plnění a jakou hodnotu mu každá fáze přináší. Který prvek použije?

- [ ] Business Process
- [x] Value Stream
- [ ] Capability
- [ ] Course of Action

> Sled fází, které vytvářejí hodnotu pro stakeholdera, je Value Stream. Business Process by popisoval konkrétní kroky práce, Capability schopnost podniku a Course of Action strategické rozhodnutí.

### ? Schopnost Hodnocení bonity umožňuje fázi Posouzení v hodnotovém toku Získání hypotéky. Který fragment to správně vyjadřuje?

- [ ] Hodnocení bonity (Capability) —assignment→ Posouzení (Value Stream)
- [ ] Posouzení (Value Stream) —realization→ Hodnocení bonity (Capability)
- [x] Hodnocení bonity (Capability) —serving→ Posouzení (Value Stream)
- [ ] Posouzení (Value Stream) —composition→ Hodnocení bonity (Capability)

> Capability slouží fázi value streamu, kterou umožňuje, proto serving od Capability k Value Stream. Assignment se používá pro přiřazení zdroje ke schopnosti, fáze schopnost nerealizuje a composition by ze schopnosti dělala součást fáze.

### ? Do které části jazyka ArchiMate 3.2 patří Value Stream?

- [ ] Business Layer
- [ ] Motivation elements
- [ ] Implementation & Migration
- [x] Strategy elements

> Value Stream je spolu s Capability strategický prvek chování; ke Strategy elements patří dále Resource a Course of Action. Business procesy, které value stream realizují, patří do Business Layer.

## Value Stream × Business Process {#value-stream-vs-process .compare}

Value stream ukazuje, **jakou hodnotu** podnik vytváří, business process, **jak** se konkrétní práce dělá.

| Hledisko | Value Stream | Business Process |
|---|---|---|
| Vrstva | Strategy | Business Layer |
| Pohled | hodnota pro stakeholdera, fáze od začátku do konce | posloupnost konkrétních kroků, událostí a rozhodnutí |
| Úroveň detailu | hrubá, několik fází | podrobná, včetně výjimek a variant |
| Kdo vykonává | neřeší | přiřazené role a aktéři |
| Stabilita | stabilní v čase | mění se s organizací a systémy |
| Vzájemný vztah | je realizován | `Business Process —realization→ Value Stream` |

### ? Který fragment správně propojuje value stream s prvkem Core Framework?

- [x] Vyřízení pojistné události (Business Process) —realization→ Řešení škody (Value Stream)
- [ ] Řešení škody (Value Stream) —realization→ Vyřízení pojistné události (Business Process)
- [ ] Řešení škody (Value Stream) —assignment→ Vyřízení pojistné události (Business Process)
- [ ] Vyřízení pojistné události (Business Process) —access→ Řešení škody (Value Stream)

> Business process jako konkrétní chování realizuje abstraktnější value stream, proto realization vede od procesu k value streamu. Opačný směr je chybný, assignment vede od aktivní struktury a access k pasivním prvkům.

### ? Čím se Value Stream liší od Business Process?

- [ ] Value stream je podrobnější a obsahuje rozhodovací body a výjimky
- [ ] Value stream je vždy přiřazen jedné Business Role
- [ ] Value stream patří do Business Layer, proces do Strategy elements
- [x] Value stream sleduje hodnotu po fázích, proces konkrétní kroky práce

> Value stream je hrubý strategický pohled na fáze vytvářející hodnotu; business process podrobně popisuje kroky, které vykonávají přiřazené role. Vrstvy jsou opačně: value stream je ve Strategy, proces v Business Layer.

## Postup (Course of Action) {#course-of-action .term}

**Course of Action** zachycuje rozhodnutí, *jakou cestou* podnik ke svému cíli půjde — zvolenou **strategii** nebo **taktiku**, která určuje, které capabilities a resources posílit, vytvořit nebo využít. Příklady: „Přechod na prodej přes vlastní e-shop", „Outsourcing logistiky", „Akvizice regionálního konkurenta". Course of Action směřuje k Goals a Outcomes a pracuje s capabilities a resources, které má posílit, vytvořit nebo využít.

### ? Vedení rozhodlo, že růstu dosáhne převzetím menšího konkurenta a využitím jeho distribuční sítě. Jakým prvkem se toto rozhodnutí modeluje?

- [ ] Goal
- [ ] Capability
- [x] Course of Action
- [ ] Driver

> Zvolený přístup, jak využít capabilities a resources k dosažení cíle, je Course of Action. Růst sám by byl Goal, distribuční síť Resource a podmínka motivující ke změně Driver.

### ? Které tvrzení o Course of Action je správné?

- [x] Popisuje zvolenou strategii či taktiku k dosažení cíle
- [ ] Popisuje konkrétní měřitelný výsledek, kterého podnik dosáhl
- [ ] Popisuje aktivum, které organizace vlastní nebo ovládá
- [ ] Popisuje sled fází vytvářejících hodnotu pro zákazníka

> Course of Action je zvolený postup (strategie nebo taktika). Měřitelný výsledek je Outcome, aktivum Resource a sled fází Value Stream.

## Motivation elements v přehledu {#motivation-prehled .explain}

**Motivation elements** zachycují, **proč** architektura vypadá tak, jak vypadá: kdo má zájem (Stakeholder), co podnik pohání ke změně (Driver), jak je situace vyhodnocena (Assessment), čeho chce dosáhnout (Goal, Outcome), jaká pravidla a potřeby z toho plynou (Principle, Requirement, Constraint) a jaký význam a hodnotu mají prvky (Meaning, Value). Motivation je samostatný aspekt rozšiřující jazyk v rámci Full Framework; s Core se propojuje hlavně tím, že Core prvky realizují Requirements.

*Příklad:* `CFO (Stakeholder) —association→ Provozní náklady (Driver) —association→ Ruční zpracování faktur je drahé (Assessment)`, `Automatické vytěžení faktur (Requirement) —realization→ Snížit náklady na zpracování o 30 % (Outcome) —realization→ Efektivní back office (Goal)`

### ? Na jakou otázku odpovídají Motivation elements v modelu architektury?

- [ ] Jak je chování podniku rozděleno mezi role
- [x] Proč architektura vypadá tak, jak vypadá
- [ ] Kde fyzicky běží aplikace a ukládají se data
- [ ] Kdy se jednotlivé změny nasadí do provozu

> Motivation elements vysvětlují důvody, cíle a omezení, které architekturu utvářejí. Rozdělení chování mezi role je věcí Business Layer, umístění aplikací Technology Layer a načasování změn Implementation & Migration.

### ? Který prvek NEPATŘÍ mezi Motivation elements?

- [ ] Assessment
- [ ] Constraint
- [ ] Meaning
- [x] Capability

> Capability patří mezi Strategy elements. Assessment, Constraint i Meaning jsou Motivation elements.

## Stakeholder {#stakeholder .term}

**Stakeholder** je ten, komu na architektuře záleží — osoba, tým nebo organizace (i celá skupina) v určité roli, jejíž zájmy (concerns) musí architekt vzít v úvahu. Např. „Finanční ředitel", „Regulátor", „Zákazníci". Od **Business Role** se liší účelem: Business Role popisuje odpovědnost při vykonávání chování v provozu, Stakeholder perspektivu zájmů v motivaci. Stakeholder se k Drivers, které odrážejí jeho zájmy, váže vztahem association.

### ? Který prvek použijete pro „Úřad pro ochranu osobních údajů", jehož zájmy musí zohlednit návrh nového CRM?

- [x] Stakeholder
- [ ] Business Role
- [ ] Driver
- [ ] Business Actor

> Subjekt, jehož zájmy na výsledku architektury je třeba zohlednit, je v motivaci Stakeholder. Business Role a Business Actor popisují účastníky provozního chování a Driver je podmínka, která motivuje ke změně.

### ? Čím se Stakeholder liší od Business Role?

- [ ] Stakeholder patří do Business Layer, Business Role do Motivation
- [ ] Stakeholder je vždy osoba, Business Role vždy celá organizace
- [x] Stakeholder má zájmy na architektuře, role odpovídá za chování
- [ ] Stakeholder vykonává procesy, Business Role je jen pasivní objekt

> Stakeholder je motivační prvek popisující zájmy a concerns, Business Role prvek Business Layer, ke kterému se přiřazuje chování. Oba mohou představovat osobu i organizaci.

## Hnací síla (Driver) {#driver .term}

**Driver** je důvod, proč se organizace vůbec dá do pohybu: tlak zvenčí nebo problém uvnitř, kvůli kterému si stanoví cíle a začne se měnit. Vnější: „Nová regulace", „Nástup digitální konkurence"; vnitřní: „Rostoucí provozní náklady", „Zastaralé systémy". Drivers často odpovídají concerns stakeholderů. Typicky: `Stakeholder —association→ Driver`, `Driver —association→ Assessment`.

### ? Co z následujícího je typický Driver?

- [ ] Do roku 2027 zkrátit dobu dodání na 24 hodin
- [ ] Data se zadávají jen jednou na jednom místě
- [x] Nová legislativa vyžadující elektronickou fakturaci
- [ ] Systém musí podporovat přihlášení bankovní identitou

> Nová legislativa je vnější podmínka, která firmu nutí ke změně, tedy Driver. Zkrácení dodání do určitého termínu je Outcome, jednorázové zadávání dat Principle a přihlášení bankovní identitou Requirement.

### ? Které tvrzení o Driver je správné?

- [ ] Je to vždy vnější tlak; vnitřní stav popisuje Assessment
- [x] Může být vnější i vnitřní a motivuje organizaci ke stanovení cílů
- [ ] Je to měřitelný výsledek, kterého chce organizace dosáhnout
- [ ] Je to specializace prvku Stakeholder pro vnější organizace

> Driver může být vnější (trh, regulace) i vnitřní (náklady, kultura) a vede ke stanovení cílů a změn. Měřitelný výsledek je Outcome a Driver není druhem Stakeholder.

## Posouzení (Assessment) {#assessment .term}

**Assessment** je konkrétní zjištění, které vzejde z rozboru situace kolem určitého driveru — co je silnou či slabou stránkou, příležitostí nebo hrozbou. Např. pro driver „Spokojenost zákazníků" assessment „62 % stížností se týká zpožděných dodávek". Assessments často vycházejí ze SWOT analýzy a vedou ke stanovení nebo úpravě cílů. Typicky `Driver —association→ Assessment` a assessment se dále váže (association či influence) na Goals.

### ? Analýza ukázala, že průměrná doba čekání v call centru je 9 minut, tedy dvojnásobek oborového průměru. Jak se toto zjištění modeluje?

- [ ] Goal
- [ ] Driver
- [ ] Constraint
- [x] Assessment

> Výsledek analýzy současného stavu je Assessment. Driver by byl obecnější podnět (např. spokojenost zákazníků), Goal žádoucí stav a Constraint omezení řešení.

### ? Z čeho Assessment obvykle vychází?

- [x] Z analýzy stavu podniku vzhledem k určitému driveru
- [ ] Z rozhodnutí vedení o volbě strategie a taktiky
- [ ] Ze seznamu požadavků na konkrétní informační systém
- [ ] Z plánu Work Packages pro přechodovou architekturu

> Assessment je výsledek analýzy (např. SWOT) ve vztahu k driveru. Rozhodnutí o strategii je Course of Action, požadavky jsou Requirements a Work Packages patří do Implementation & Migration.

## Cíl (Goal) {#goal .term}

**Goal** říká, kam chce organizace dojít — obecný záměr, obvykle bez čísla a termínu: „Zvýšit spokojenost zákazníků", „Snížit provozní náklady", „Stát se jedničkou na trhu". Bývá kvalitativní a nemusí být přímo měřitelný. Cíle lze rozkládat na dílčí (composition, aggregation) a mohou se navzájem ovlivňovat (influence s označením + nebo −). Goal je realizován (realization) Outcomes a Requirements.

### ? Co z následujícího se nejlépe modeluje jako Goal?

- [ ] Do 30. 6. 2027 snížit fluktuaci pod 8 % ročně
- [x] Stát se preferovaným zaměstnavatelem v regionu
- [ ] Mzdové výdaje nesmí meziročně vzrůst o více než 3 %
- [ ] Odchodové pohovory ukazují nespokojenost s vedením

> Obecný záměr bez konkrétní měřitelné hodnoty je Goal. Snížení fluktuace s termínem a číslem je Outcome, limit mzdových výdajů Constraint a zjištění z pohovorů Assessment.

### ? Kterým vztahem a s jakým označením se vyjádří, že dosažení jednoho cíle negativně ovlivňuje dosažení jiného cíle?

- [ ] realization s označením −
- [ ] association s označením „negative"
- [x] influence s označením −
- [ ] triggering s označením −

> Vztah influence vyjadřuje kladný či záporný vliv mezi motivačními prvky a lze jej označit + nebo −. Realization znamená plné naplnění, association je volná vazba bez znaménka a triggering je dynamický vztah mezi chováním.

## Výsledek (Outcome) {#outcome .term}

**Outcome** je konečný výsledek, kterého bylo dosaženo nebo jehož dosažení se plánuje — konkrétní, obvykle měřitelný a časově určený: „Fluktuace pod 8 % do konce 2027", „NPS vyšší o 15 bodů za rok", „Úspora nákladů 10 mil. Kč ročně". Outcomes vyjadřují, co bude skutečně jinak, a realizují (realization) Goals. K jejich dosažení přispívají Requirements a další prvky, které je realizují.

### ? Jaký vztah vede mezi Outcome a Goal, který tento outcome naplňuje?

- [x] Outcome —realization→ Goal
- [ ] Goal —realization→ Outcome
- [ ] Outcome —triggering→ Goal
- [ ] Goal —assignment→ Outcome

> Konkrétní výsledek uskutečňuje obecný cíl, proto realization vede od Outcome ke Goal. Opačný směr je chybný a triggering ani assignment mezi motivačními prvky tento význam nemají.

### ? Co z následujícího je typický Outcome?

- [ ] Být inovativní a zákaznicky orientovanou bankou
- [ ] Mobilní aplikace musí podporovat platby kartou
- [ ] Rostoucí konkurence fintech startupů na trhu
- [x] Podíl plateb přes mobilní aplikaci 40 % do 2027

> Konkrétní měřitelný výsledek s termínem je Outcome. Obecný záměr je Goal, vlastnost aplikace Requirement a rostoucí konkurence Driver.

## Goal × Outcome {#goal-vs-outcome .compare}

Goal říká, kam podnik směřuje, Outcome, jaký konkrétní výsledek tam vede.

| Hledisko | Goal | Outcome |
|---|---|---|
| Povaha | záměr, směr, žádoucí stav | konkrétní dosažený či plánovaný výsledek |
| Měřitelnost | často kvalitativní, obecný | obvykle měřitelný, s cílovou hodnotou |
| Časový rámec | dlouhodobý, často bez termínu | obvykle s termínem |
| Vzájemný vztah | je realizován | `Outcome —realization→ Goal` |
| Příklad | „Spokojení zákazníci" | „NPS alespoň 50 do konce 2027" |

### ? Které tvrzení nejlépe vystihuje rozdíl mezi Goal a Outcome?

- [ ] Goal je měřitelný výsledek, Outcome obecný záměr organizace
- [x] Goal je obecný záměr, Outcome konkrétní měřitelný výsledek
- [ ] Goal patří do Strategy elements, Outcome do Motivation elements
- [ ] Goal formulují stakeholdeři, Outcome výhradně architekti

> Goal vyjadřuje směr a záměr, Outcome konkrétní výsledek, který ho realizuje. Oba jsou Motivation elements a nezáleží na tom, kdo je formuluje.

### ? Ředitel e-shopu řekl: „Chceme, aby se k nám zákazníci vraceli." Analytik doplnil: „Podíl opakovaných nákupů vzroste do konce roku 2027 z 25 % na 35 %." Jak modelovat obě formulace?

- [ ] První jako Outcome, druhou jako Goal
- [ ] Obě jako Goal propojené vztahem composition
- [x] První jako Goal, druhou jako Outcome
- [ ] První jako Driver, druhou jako Assessment

> Obecný záměr je Goal, měřitelný výsledek s termínem je Outcome, který ho realizuje. Opačné přiřazení je chybné, Driver je podnět ke změně a Assessment výsledek analýzy současného stavu.

## Princip (Principle) {#principle .term}

**Principle** je obecná zásada, podle které se v určitém kontextu architektury rozhoduje u **každého** systému: „Data se zadávají jen jednou", „Cloud first", „Hotové řešení má přednost před vývojem na míru". Principle je obecnější než Requirement: neříká, co má splnit konkrétní systém, ale jaká pravidla platí pro všechny. Konkretizují ho Requirements (`Requirement —realization→ Principle`); principles samy přispívají k naplnění cílů.

### ? Co z následujícího se nejlépe modeluje jako Principle?

- [x] Hotové řešení má přednost před vývojem na míru
- [ ] Nový HR systém musí umět export mezd do účetnictví
- [ ] Projekt nesmí přesáhnout rozpočet 12 milionů Kč
- [ ] Do roku 2027 provozovat 80 % aplikací v cloudu

> Obecné pravidlo pro všechna rozhodnutí v daném kontextu je Principle. Export mezd je Requirement na konkrétní systém, rozpočtový limit Constraint a podíl aplikací v cloudu s termínem Outcome.

### ? Požadavek „Zákaznická data spravuje pouze CRM" princip „Každá data mají jediný zdroj pravdy" pro oblast zákaznických dat přímo a úplně naplňuje. Jaký vztah z požadavku na princip vede?

- [ ] influence
- [ ] association
- [ ] specialization
- [x] realization

> Requirement konkretizuje obecný princip pro konkrétní systém, proto ho realizuje (realization). Influence by vyjadřovala jen dílčí vliv, association volnou vazbu a specialization by tvrdila, že jde o podtyp.

## Požadavek (Requirement) {#requirement .term}

**Requirement** říká, co přesně musí splnit **konkrétní** systém, aby architektura dosáhla svého — „Portál musí umožnit přihlášení bankovní identitou", „Systém zpracuje 500 objednávek za minutu". Requirements konkretizují principles a outcomes (realization) a samy jsou realizovány Core prvky — aplikační komponentou, službou, procesem (`Application Component —realization→ Requirement`).

### ? Který fragment správně vyjadřuje, že požadavek naplňuje navržená aplikace?

- [ ] Jednotné přihlášení (Requirement) —realization→ Identity portál (Application Component)
- [x] Identity portál (Application Component) —realization→ Jednotné přihlášení (Requirement)
- [ ] Identity portál (Application Component) —serving→ Jednotné přihlášení (Requirement)
- [ ] Jednotné přihlášení (Requirement) —assignment→ Identity portál (Application Component)

> Core prvek, který požadavek splňuje, ho realizuje, takže realization vede od Application Component k Requirement. Opačný směr je chybný, serving vyjadřuje poskytování služby a assignment přiřazení aktivní struktury ke chování.

### ? Čím se Requirement liší od Principle?

- [ ] Requirement je obecnější a platí pro všechny systémy podniku
- [ ] Requirement nelze propojit s Core prvky, Principle ano
- [x] Requirement platí pro konkrétní systém, Principle obecně
- [ ] Requirement vyjadřuje vnější tlak, Principle vnitřní tlak

> Requirement popisuje potřebnou vlastnost konkrétního systému a realizují ho Core prvky; Principle je obecné pravidlo pro všechny systémy v daném kontextu. Vnější a vnitřní tlak vyjadřují Drivers.

## Omezení (Constraint) {#constraint .term}

**Constraint** je faktor, který omezuje realizaci cílů nebo způsob, jakým lze systém navrhnout a uskutečnit. Na rozdíl od Requirement nepředepisuje požadovanou funkčnost, ale stanoví mantinely: „Rozpočet projektu nejvýše 12 mil. Kč", „Data klientů nesmí opustit EU", „Řešení musí využít stávající databázovou platformu", „Spuštění nejpozději 1. 1. 2027". S Core prvky a dalšími motivačními prvky se propojuje podobně jako requirement.

### ? Co z následujícího je typický Constraint?

- [ ] Systém musí umožnit online objednání termínu
- [ ] Zvýšit počet online objednávek o 30 % za rok
- [ ] Zákazníci chtějí objednávat i mimo pracovní dobu
- [x] Řešení musí běžet na stávající platformě Oracle

> Povinnost použít stávající platformu omezuje způsob realizace, nepředepisuje funkčnost — je to Constraint. Online objednání je Requirement, zvýšení počtu objednávek Outcome a přání zákazníků spíše Driver či Assessment.

### ? Které tvrzení o Constraint je správné?

- [x] Omezuje způsob realizace řešení, nepředepisuje funkčnost
- [ ] Je to kladný vliv jednoho cíle na jiný cíl organizace
- [ ] Je to stakeholder, který může zablokovat schválení projektu
- [ ] Je to fáze value streamu, ve které hodnota nevzniká

> Constraint stanoví mantinely řešení (rozpočet, termín, technologie, legislativa). Vliv mezi cíli vyjadřuje vztah influence, subjekt se zájmy je Stakeholder a fáze patří k Value Stream.

## Principle × Requirement × Constraint {#princip-pozadavek-omezeni .compare}

Všechny tři prvky usměrňují návrh, liší se obecností a tím, co vyjadřují.

| Prvek | Pro co platí | Co vyjadřuje | Příklad |
|---|---|---|---|
| Principle | všechny systémy v daném kontextu | obecné pravidlo či zásadu | „Data se zadávají jen jednou" |
| Requirement | konkrétní systém | potřebnou vlastnost či funkčnost | „CRM předá adresu klienta do fakturace" |
| Constraint | konkrétní řešení nebo projekt | omezení způsobu realizace | „Použít jen software s otevřenou licencí" |

Typické vztahy: `Requirement —realization→ Principle`, `Application Component —realization→ Requirement`.

### ? Městský úřad stanovil pro nový portál tři věty: (1) „Portál umožní vyplnit každý formulář i na mobilu." (2) „Portál musí být spuštěn do 31. 3. 2027." (3) „Všechny služby úřadu jsou ve výchozím stavu digitální." Jak je modelovat?

- [ ] (1) Principle, (2) Requirement, (3) Constraint
- [x] (1) Requirement, (2) Constraint, (3) Principle
- [ ] (1) Constraint, (2) Principle, (3) Requirement
- [ ] (1) Requirement, (2) Principle, (3) Constraint

> Vlastnost konkrétního portálu je Requirement, pevný termín spuštění omezuje realizaci (Constraint) a obecná zásada pro všechny služby úřadu je Principle.

### ? Které tvrzení správně popisuje vazby mezi Principle, Requirement a Core prvkem?

- [x] Requirement realizuje Principle, Core prvek realizuje Requirement
- [ ] Principle realizuje Requirement, Requirement realizuje Core prvek
- [ ] Requirement ovlivňuje Principle, Core prvek slouží Requirement
- [ ] Principle je přiřazen k Requirement, Core prvek ho agreguje

> Směr realization vede od konkrétnějšího k abstraktnějšímu: Core prvek realizuje Requirement a Requirement konkretizuje (realizuje) Principle. Ostatní možnosti mají opačný směr nebo nevhodný typ vztahu.

## Význam (Meaning) {#meaning .term}

**Meaning** vysvětluje, jak se má prvek chápat — co v daném kontextu „znamená" pro toho, kdo s ním pracuje. Nejčastěji se připojuje vztahem association k pasivním prvkům (Business Object, Representation), ale lze ho připojit i k jiným. Např. Business Object „Faktura" má meaning „Daňový doklad pro uplatnění DPH"; Representation „Zelený štítek" má meaning „Zboží prošlo kontrolou kvality".

### ? Výrobce chce zachytit, že červený štítek na krabici (Representation) znamená pro skladníky „zboží určené k reklamaci". Kterým prvkem se tento výklad modeluje?

- [ ] Value
- [x] Meaning
- [ ] Assessment
- [ ] Principle

> Výklad, který prvek nese v určitém kontextu, je Meaning. Value by vyjadřovala přínos, Assessment výsledek analýzy a Principle obecné pravidlo pro rozhodování.

### ? Jakým vztahem se Meaning obvykle připojuje k prvku, jehož výklad popisuje?

- [ ] realization
- [ ] influence
- [x] association
- [ ] composition

> Meaning se k prvku připojuje vztahem association — jen ho dovysvětluje. Prvek význam neuskutečňuje (realization), neovlivňuje (influence) ani ho neobsahuje jako část (composition).

## Hodnota (Value) {#value .term}

**Value** vyjadřuje, co prvek stakeholderovi přináší a proč pro něj stojí za to: „Pohodlné objednání 24/7", „Úspora času", „Nižší celkové náklady". Value se vztahem association připojuje k prvkům, které hodnotu nesou (Product, Business Service, Value Stream, Capability…), a ke stakeholderovi, pro kterého vzniká. Od Meaning se liší tím, že nevysvětluje význam prvku, ale jeho přínos.

### ? Banka chce zachytit, že služba „Okamžité platby" přináší firemním klientům „Rychlejší oběh peněz". Kterým prvkem se tento přínos modeluje?

- [x] Value
- [ ] Meaning
- [ ] Outcome
- [ ] Goal

> Přínos, který prvek má pro stakeholdera, je Value. Meaning je výklad prvku, Outcome konkrétní výsledek organizace a Goal její obecný záměr.

### ? Čím se Value liší od Meaning?

- [ ] Value vyjadřuje výklad prvku, Meaning jeho přínos pro firmu
- [ ] Value se váže jen k produktům, Meaning jen k procesům
- [ ] Value je měřitelný výsledek, Meaning obecný cíl firmy
- [x] Value je přínos pro stakeholdera, Meaning výklad prvku

> Value říká, jaký užitek prvek přináší, Meaning, jak se mu v daném kontextu rozumí. Oba se připojují vztahem association k různým typům prvků; měřitelný výsledek je Outcome a cíl Goal.

## Vztahy mezi Motivation elements {#motivation-vztahy .explain}

Motivation elements se propojují hlavně třemi vztahy:

- **realization** — prvek je plně naplněn jiným, konkrétnějším prvkem: `Outcome —realization→ Goal`, `Requirement —realization→ Outcome`, `Requirement —realization→ Principle`, `Core prvek —realization→ Requirement`;
- **influence** — prvek jiný pozitivně či negativně ovlivňuje, aniž ho plně naplňuje; volitelně se označí + nebo − (čárkovaná čára s otevřenou šipkou);
- **association** — volnější vazby: Stakeholder–Driver, Driver–Assessment, Meaning a Value k prvkům.

Pro rozklad (cíl na dílčí cíle) slouží composition a aggregation. Rozhodující otázka: naplňuje prvek ten druhý (realization), nebo k němu jen přispívá či ho ztěžuje (influence)?

*Příklad:* `Online objednání (Requirement) —realization→ Více online objednávek (Outcome)`, `Rozpočet nejvýše 5 mil. Kč (Constraint) —influence (−)→ Více online objednávek (Outcome)`

### ? Požadavek na jednotné přihlášení zlepší pohodlí uživatelů, ale sám o sobě cíl „Spokojení uživatelé" plně nenaplní. Který vztah z Requirement na Goal je nejvhodnější?

- [ ] realization s označením +
- [x] influence s označením +
- [ ] association s označením +
- [ ] triggering s označením +

> Když prvek k cíli jen přispívá, použije se influence s kladným znaménkem; realization by tvrdila, že požadavek cíl plně naplňuje. Association je volná vazba bez vyjádření vlivu a triggering není vztah pro vazbu motivačních prvků; označení + či − se používá u vztahu influence.

### ? Který řetězec vztahů mezi Motivation elements je správně orientovaný?

- [ ] Goal —realization→ Outcome —realization→ Requirement
- [ ] Requirement —realization→ Goal —realization→ Outcome
- [ ] Outcome —realization→ Requirement —realization→ Goal
- [x] Requirement —realization→ Outcome —realization→ Goal

> Realization vede od konkrétnějšího k abstraktnějšímu: požadavek výsledek naplňuje (realizuje) a výsledek naplňuje cíl. Ostatní řetězce mají obrácený nebo promíchaný směr.

### ? Jakým vztahem se typicky propojuje Stakeholder s Driver, který odráží jeho zájmy?

- [x] association
- [ ] realization
- [ ] influence
- [ ] assignment

> Stakeholder a Driver se propojují volnou vazbou association — driver vyjadřuje, co stakeholdera zajímá. Stakeholder driver neuskutečňuje, neovlivňuje ve smyslu influence ani k němu není přiřazen jako ke chování.
