---
kind: topic
subject: archimate-foundation
slug: uvod-a-pojmy
name: "Úvod a základní pojmy"
order: 1
---

Účel jazyka ArchiMate, architektura × model × pohled (view) × viewpoint, stakeholder a concern, vztah k TOGAF.

## ArchiMate {#archimate .term}

**ArchiMate** je otevřený a na dodavatelích nástrojů nezávislý **modelovací jazyk pro podnikovou architekturu**, spravovaný jako standard konsorcia **The Open Group**. Nabízí ustálenou sadu prvků a vztahů, kterou lze architekturu popsat, analyzovat a vizualizovat napříč byznysem, aplikacemi a technologiemi — včetně vazeb mezi nimi. ArchiMate je **jazyk** (co a jak zapsat), nikoli **metoda** (jak postupovat při tvorbě architektury).

### ? Co je ArchiMate?

- [ ] Metoda řízení vývoje podnikové architektury v cyklu fází
- [x] Otevřený modelovací jazyk pro popis podnikové architektury
- [ ] Modelovací nástroj s vlastní notací od jednoho dodavatele
- [ ] Notace pro detailní návrh softwarových tříd a jejich metod

> ArchiMate je modelovací jazyk (standard The Open Group) pro popis, analýzu a vizualizaci podnikové architektury. Metodou s cyklem fází je TOGAF ADM, ArchiMate není produkt jednoho dodavatele a na detailní návrh softwaru slouží UML.

### ? Která organizace spravuje ArchiMate jako standard?

- [ ] Object Management Group (OMG)
- [ ] ISO/IEC JTC 1
- [ ] IEEE Computer Society
- [x] The Open Group

> ArchiMate (stejně jako TOGAF) je standardem The Open Group. OMG spravuje UML a BPMN; ISO a IEEE stojí za normou ISO/IEC/IEEE 42010, z níž ArchiMate přebírá pojmy, ale jazyk samotný nespravují.

## Účel jazyka ArchiMate {#ucel-jazyka .explain}

Bez společného jazyka kreslí architekti „krabičky a čáry" s nejasným významem a každý diagram je třeba dlouze vysvětlovat. ArchiMate dává prvkům a vztahům **přesně definovaný význam**, takže model lze sdílet mezi lidmi i nástroji a lze nad ním dělat analýzy. Hlavní přínosy jsou: **propojení domén** (který proces využívá kterou aplikaci a na jaké technologii běží), **analýza dopadů** změn, **komunikace se stakeholdery** pomocí pohledů šitých na míru a přenositelnost modelů mezi nástroji.

*Příklad:* Z modelu `Fakturační systém (Application Component) —serving→ Fakturace (Business Process)` lze při plánované odstávce systému ihned zjistit, který business proces bude zasažen.

### ? Firma plánuje odstavit starý server a chce zjistit, které business procesy tím budou zasaženy. Který přínos jazyka ArchiMate tím využívá?

- [x] Analýzu dopadů díky propojení prvků napříč vrstvami
- [ ] Automatické generování zdrojového kódu z modelu
- [ ] Simulaci výkonu serveru při zvýšené zátěži uživatelů
- [ ] Výpočet návratnosti investice do nové technologie

> Model ArchiMate propojuje technologii s aplikacemi a ty s business procesy, takže lze sledovat, co na čem závisí (analýza dopadů). Generování kódu, výkonové simulace ani výpočet ROI nejsou účelem jazyka.

### ? Proč je výhodné, že prvky a vztahy v ArchiMate mají přesně definovaný význam?

- [ ] Diagramy pak nepotřebují žádné popisky ani názvy prvků
- [ ] Model lze přímo spustit jako workflow v procesním enginu
- [x] Model čtou lidé i nástroje stejně a lze ho analyzovat
- [ ] Každý architekt si může notaci volně upravit podle sebe

> Jednoznačná sémantika znamená, že stejný diagram čtou různí lidé i nástroje stejně a model lze analyzovat. Názvy prvků jsou dál potřeba, spustitelnost je doménou BPMN a volné úpravy notace by přínos jednotného jazyka popřely.

## Standard ArchiMate a jeho verze {#verze-standardu .term}

ArchiMate vznikl na počátku 2000. let v **Nizozemsku** ve výzkumném projektu firem, státních institucí a výzkumných pracovišť; od roku 2008 jej rozvíjí **The Open Group** (ArchiMate Forum). Řada **3.x** (od roku 2016) přidala mimo jiné prvky **Strategy** (např. Capability, Resource, Course of Action) a **fyzické prvky** (Equipment, Facility…). Tento kurz vychází z verze **ArchiMate 3.2** (2022).

### ? Ze které verze specifikace ArchiMate vychází tento výukový kurz?

- [ ] ArchiMate 2.1
- [ ] ArchiMate 3.0
- [x] ArchiMate 3.2
- [ ] ArchiMate 1.0

> Kurz vychází z ArchiMate 3.2 vydané v roce 2022. Verze 1.0 a 2.1 jsou starší řady, 3.0 byla prvním vydáním řady 3.x.

### ? Které prvky přibyly v jazyce ArchiMate s řadou verzí 3.x?

- [x] Strategy prvky jako Capability a fyzické prvky jako Equipment
- [ ] Prvky samostatné datové vrstvy, oddělené od aplikační i technologické
- [ ] Rozhodovací brány a smyčky převzaté z jazyka BPMN 2.0
- [ ] Třídy, atributy a metody převzaté z diagramů tříd UML

> Řada 3.x doplnila strategické prvky (Capability, Resource, Course of Action) a fyzické prvky (Equipment, Facility, Distribution Network, Material). Samostatnou datovou vrstvu ArchiMate nemá a konstrukty BPMN či UML nepřebírá.

## Architektura (Architecture) {#architektura .term}

**Architektura** je to podstatné, z čeho se systém skládá a podle čeho se chová: hlavní **koncepty a vlastnosti systému v jeho prostředí**, tedy z jakých prvků je složen, jak spolu souvisejí a jakými principy se řídí jeho návrh a další vývoj. ArchiMate vychází z pojetí normy ISO/IEC/IEEE 42010. Architekturu má každý systém, i když ji nikdo nepopsal — **popis architektury** je až dokument nebo model, který ji zachycuje.

### ? Co tvoří architekturu systému v pojetí, které ArchiMate přebírá z ISO/IEC/IEEE 42010?

- [ ] Kompletní zdrojový kód a konfigurace všech informačních systémů podniku
- [x] Základní koncepty a vlastnosti systému, jeho prvky, vztahy a principy
- [ ] Organizační schéma útvaru IT a popis pracovních pozic architektů
- [ ] Plán projektů na nejbližší rok včetně rozpočtu a harmonogramu

> Architekturu tvoří to podstatné o systému v jeho prostředí: jeho prvky, jejich vzájemné vztahy a principy, jimiž se řídí návrh a vývoj. Zdrojový kód, organizační schéma ani projektový plán architekturou v tomto smyslu nejsou.

### ? Který výrok o architektuře systému je správný?

- [ ] Architekturu má systém až tehdy, když ji někdo formálně zdokumentuje
- [ ] Architektura vzniká teprve tím, že se o ní nakreslí diagram v ArchiMate
- [ ] Architekturu mají jen informační systémy, nikoli celé organizace
- [x] Architekturu má každý systém, popis architektury ji jen zachycuje

> Architektura je vlastností systému; popis architektury (modely, pohledy) ji pouze vyjadřuje. Architekturu má i nezdokumentovaný systém a pojem se týká i organizace jako celku, nejen IT.

## Podniková architektura (Enterprise Architecture) {#ea .term}

**Podniková architektura** je celostní pohled na podnik: zásady, postupy a modely, podle nichž se navrhuje a mění jeho organizace, procesy, informační systémy a infrastruktura. **Podnik** (enterprise) přitom nemusí být jedna firma: může jít o divizi, veřejnou instituci i o více spolupracujících organizací se společnými cíli. ArchiMate je jazyk právě pro tuto úroveň — pro celek a vazby mezi jeho částmi.

### ? Co zahrnuje podniková architektura v pojetí ArchiMate?

- [x] Zásady, postupy a modely pro návrh a změnu organizace, procesů a IT
- [ ] Výhradně inventář aplikací a serverů, který vede oddělení IT podniku
- [ ] Účetní a finanční plánování podniku na úrovni celé skupiny
- [ ] Návrh budov a kancelářských prostor podle potřeb zaměstnanců

> Podniková architektura propojuje organizaci, procesy, informační systémy i infrastrukturu a opírá se přitom o zásady, postupy a modely. Inventář IT je jen její malá část; finanční plánování a návrh budov jejím předmětem nejsou.

### ? Architekti mají popsat jen nákupní divizi velké skupiny včetně jejího napojení na klíčové dodavatele. Může být tento celek „podnikem" (enterprise) ve smyslu podnikové architektury?

- [ ] Ne, podnikem je vždy jen celá firma jako jeden právní subjekt
- [ ] Ne, dodavatelé jako externí subjekty do podniku patřit nesmějí
- [x] Ano, podnikem je jakýkoli celek organizací se společnými cíli
- [ ] Ano, ale jen pokud má divize vlastní samostatné IT oddělení

> Podnik (enterprise) je v podnikové architektuře vymezen cíli a rozsahem práce, ne právní formou: může jít o divizi i o síť partnerů. Vlastní IT oddělení podmínkou není.

## Popis architektury (Architecture Description) {#popis-architektury .term}

**Popis architektury** je pracovní produkt — soubor modelů, pohledů a doprovodných informací — který architekturu určitého systému vyjadřuje a sdílí se stakeholdery. ArchiMate je jazyk, kterým se popisy architektury **vytvářejí**: dodává prvky a vztahy pro modely a mechanismus viewpointů pro pohledy. Architektura sama je vlastností systému, popis je její zachycení.

### ? Jaký je vztah mezi architekturou a popisem architektury?

- [ ] Jde o synonyma, oba pojmy označují tentýž diagram
- [x] Popis architektury je produkt, který architekturu zachycuje
- [ ] Architektura je jedna z kapitol popisu architektury
- [ ] Popis architektury vzniká až po ukončení všech projektů

> Architektura je vlastnost systému, popis architektury (modely, pohledy, doprovodné texty) ji vyjadřuje a sdílí. Nejde o synonyma ani o kapitolu dokumentu a popis se tvoří průběžně, ne až na konci.

### ? K čemu slouží jazyk ArchiMate z hlediska popisu architektury?

- [ ] K řízení schvalování architektonických rozhodnutí v boardu
- [ ] K měření vyspělosti architektonické praxe v organizaci
- [ ] K plánování kapacit a rozpočtu architektonického týmu
- [x] K vytváření modelů a pohledů, z nichž se popis skládá

> ArchiMate poskytuje prvky a vztahy pro modely a viewpointy pro pohledy — tedy stavební materiál popisu architektury. Řízení rozhodnutí (governance), měření vyspělosti ani plánování týmu jazyk neřeší.

## Prvek a vztah (Element, Relationship) {#prvek-vztah .term}

Model v ArchiMate se skládá z **konceptů**: **prvků** (elements) a **vztahů** (relationships); vztahy lze navíc spojovat spojovníkem **Junction** (podrobně v tématu o vztazích). Každý prvek má **typ** (např. Business Actor, Application Component, Node), který určuje jeho význam, a **jméno** konkrétní věci v podniku. Vztah vždy spojuje zdroj a cíl a jeho typ (např. serving, realization) říká, jak spolu souvisejí.

### ? Ze kterých dvou hlavních druhů konceptů se skládá model v ArchiMate?

- [ ] Z vrstev a fází
- [ ] Z diagramů a tabulek
- [x] Z prvků a vztahů
- [ ] Z tříd a instancí

> Model tvoří prvky (elements) a vztahy (relationships) mezi nimi. Vrstvy jsou způsob třídění prvků, diagramy jsou pohledy na model a třídy s instancemi jsou pojmy UML.

### ? Co v modelu ArchiMate určuje význam prvku, například zda jde o proces, nebo o aplikaci?

- [x] Typ prvku, např. Business Process či Application Component
- [ ] Barva, kterou je prvek v diagramu vybarven podle zvyklostí
- [ ] Umístění prvku v horní či dolní části konkrétního diagramu
- [ ] Délka a styl názvu, který prvku přidělí autor modelu

> Význam prvku je dán jeho typem, který definuje specifikace. Barva ani poloha v diagramu význam nenesou a jméno jen identifikuje konkrétní věc.

## Model {#model .term}

**Model** je ucelený soubor prvků a vztahů, který popisuje architekturu; v praxi bývá uložen v **repozitáři** modelovacího nástroje. Každá věc (např. aplikace CRM) je v modelu jako prvek **jen jednou**, ale může se objevit v libovolném počtu pohledů. Diagram tedy není model — je to jen jeden pohled na jeho část; změna prvku v modelu se projeví všude, kde je prvek zobrazen.

### ? V nástroji, který pracuje s jedním společným modelem, architekt přejmenuje prvek „CRM" (Application Component) v jednom z diagramů. Co se stane?

- [ ] Vznikne nový prvek a původní zůstane v ostatních diagramech
- [ ] Změna platí jen v tomto diagramu, ostatní zůstanou beze změny
- [ ] Přejmenování není dovoleno, prvek lze měnit jen v repozitáři
- [x] Nový název se projeví ve všech pohledech, kde je prvek zobrazen

> Diagram je jen pohled na model; prvek v něm je tentýž prvek modelu, takže změna se projeví ve všech pohledech. Kopie prvků by model rozdrobily a způsob úpravy (v diagramu či v repozitáři) na podstatě nic nemění.

### ? Který výrok o vztahu modelu a pohledů je správný?

- [x] Jeden prvek modelu se může objevit v libovolném počtu pohledů
- [ ] Každý pohled je samostatný model s vlastními kopiemi prvků
- [ ] Model vzniká sloučením všech diagramů na konci projektu
- [ ] Prvek, který není v žádném diagramu, v modelu existovat nesmí

> Model je jediný zdroj prvků a vztahů, pohledy z něj vybírají. Pohledy nejsou samostatné modely, model se nesestavuje dodatečně z diagramů a prvek může v modelu existovat, i když ho zrovna žádný pohled nezobrazuje.

## Pohled (View) {#view .term}

**Pohled** (view) je zobrazení **vybrané části modelu** — určitých prvků a vztahů — z perspektivy konkrétní sady zájmů (concerns) určitých stakeholderů. Nejčastěji jde o diagram, ale pohled může mít i jinou podobu (např. seznam či matici). Pohled se tvoří podle pravidel nějakého **viewpointu** a neukazuje „vše", ale jen to, co daný stakeholder potřebuje.

### ? Co je v ArchiMate pohled (view)?

- [ ] Úplný výpis všech prvků a vztahů, které model obsahuje
- [ ] Předpis, které typy prvků smí určitý druh diagramu použít
- [x] Zobrazení vybrané části modelu pro určitou sadu zájmů
- [ ] Samostatný model jedné vrstvy, oddělený od ostatních

> Pohled ukazuje vybranou část modelu tak, aby odpověděl na zájmy určitých stakeholderů. Předpisem pro druh pohledu je viewpoint; úplný výpis ani oddělený model jedné vrstvy pohledem v tomto smyslu nejsou.

### ? Architekt připravuje pro finančního ředitele diagram, který ukazuje jen aplikace a jejich podporu klíčových business procesů. Proč v něm nejsou servery a síťové prvky?

- [ ] Servery nelze v jednom diagramu kombinovat s business procesy
- [x] Pohled obsahuje jen část modelu podle zájmů daného stakeholdera
- [ ] Technologické prvky smí vidět jen provozní tým oddělení IT
- [ ] Model ArchiMate servery a síťové prvky vůbec neobsahuje

> Pohled záměrně vybírá jen prvky relevantní pro zájmy stakeholdera — finančního ředitele servery nezajímají. Kombinovat vrstvy v jednom pohledu lze, technologické prvky model obsahuje a přístup k nim nijak omezen není.

## Hledisko (Viewpoint) {#viewpoint .term}

**Viewpoint** (hledisko) je **předpis pro určitý druh pohledů**: pro které stakeholdery a jaké jejich zájmy je určen, které typy prvků a vztahů smí pohled obsahovat a jak se má znázornit. Viewpoint tedy neobsahuje konkrétní prvky modelu — je to šablona, podle níž vzniká mnoho konkrétních pohledů. Mechanismus viewpointů a příkladové viewpointy ArchiMate rozebírá samostatné téma.

### ? Co definuje viewpoint?

- [x] Komu a jakým zájmům druh pohledu slouží a co smí obsahovat
- [ ] Konkrétní prvky a vztahy, které jsou v daném diagramu nakresleny
- [ ] Pořadí fází, v nichž architekt postupuje při tvorbě architektury
- [ ] Seznam stakeholderů a jejich kontaktů v celé organizaci podniku

> Viewpoint je předpis pro druh pohledů: cílové stakeholdery a zájmy, povolené typy prvků a vztahů a způsob znázornění. Konkrétní prvky nese až pohled, pořadí fází je věcí metody a pouhý seznam stakeholderů viewpointem není.

### ? Které přirovnání nejlépe vystihuje vztah viewpointu a pohledu (view)?

- [ ] Viewpoint je k pohledu jako kapitola ke knize, jíž je součástí
- [ ] Viewpoint je k pohledu jako starší verze k verzi aktualizované
- [ ] Viewpoint je k pohledu jako celý model k jednomu jeho prvku
- [x] Viewpoint je k pohledu jako šablona k dokumentu z ní vzniklému

> Viewpoint určuje pravidla (šablonu) a pohled je konkrétní výsledek podle nich vytvořený; podle jednoho viewpointu vzniká mnoho pohledů. Nejde o vztah části a celku ani o verze.

## Model × pohled × viewpoint {#model-view-viewpoint .compare}

Tři pojmy, které se snadno pletou:

| | Model | Pohled (view) | Viewpoint |
|---|---|---|---|
| Co to je | ucelený soubor prvků a vztahů | zobrazení vybrané části modelu | předpis pro druh pohledů |
| Obsahuje konkrétní prvky? | ano, všechny | ano, jen vybrané | ne, jen typy a pravidla |
| Počet | typicky jeden sdílený | mnoho | menší sada, opakovaně používaná |
| Otázka, na kterou odpovídá | „Jak podnik vypadá?" | „Co z toho potřebuje vidět tento stakeholder?" | „Jak má vypadat pohled pro tento typ zájmů?" |

### ? Architekt má v repozitáři všechny prvky a vztahy popisující podnik. Pro finančního ředitele z nich vytvořil diagram podle předem dané šablony, která určuje povolené typy prvků. Jak se postupně nazývají repozitář s prvky, diagram a šablona?

- [ ] Viewpoint, model, pohled (view)
- [ ] Pohled (view), viewpoint, model
- [x] Model, pohled (view), viewpoint
- [ ] Model, viewpoint, pohled (view)

> Soubor všech prvků a vztahů je model, konkrétní diagram pro stakeholdera je pohled (view) a šablona s pravidly je viewpoint.

### ? Který výrok o modelu, pohledech a viewpointech je správný?

- [ ] Ke každému modelu existuje právě jeden pohled a jeden viewpoint
- [x] Z jednoho modelu i podle jednoho viewpointu vzniká mnoho pohledů
- [ ] Viewpoint obsahuje konkrétní prvky, pohled jen typy prvků
- [ ] Pohled je nadřazený modelu a model z něj čerpá své prvky

> Model je sdílený zdroj, z něhož vzniká mnoho pohledů; jeden viewpoint lze použít pro mnoho pohledů (např. pro různé části podniku). Konkrétní prvky nese model a pohled, viewpoint jen typy a pravidla.

### ? Co NENÍ součástí definice viewpointu?

- [ ] Stakeholdeři, pro které je druh pohledu určen
- [ ] Zájmy (concerns), na které má pohled odpovědět
- [ ] Typy prvků a vztahů, které pohled smí obsahovat
- [x] Konkrétní prvek „CRM systém" a jeho vztahy

> Viewpoint je obecný předpis: stakeholdeři, zájmy, povolené typy konceptů a způsob znázornění. Konkrétní prvky jako „CRM systém" patří do modelu a zobrazují se v pohledech.

## Stakeholder {#stakeholder .term}

**Stakeholder** je osoba, tým nebo organizace (případně jejich skupina či role), která má **zájem na architektuře** — na jejím výsledku nebo na systému, který popisuje. Typicky: generální ředitel, CIO, vlastník procesu, bezpečnostní manažer, auditor, provozní tým, dodavatel. Stakeholdeři se liší tím, **co** potřebují vědět; proto pro ně vznikají různé pohledy. V ArchiMate je **Stakeholder** zároveň prvkem aspektu Motivation (viz téma Strategy a Motivation).

### ? Kdo je stakeholder architektury?

- [ ] Pouze člen architektonického týmu, který model sám vytváří
- [ ] Pouze akcionář, který vlastní podíl ve společnosti
- [ ] Pouze zákazník, který využívá produkty podniku
- [x] Kdokoli, kdo má zájem na architektuře nebo jejím výsledku

> Stakeholderem je každá osoba, tým či organizace se zájmem na architektuře — od vedení přes vlastníky procesů po provoz a auditory. Nejde jen o architekty, akcionáře ani zákazníky.

### ? Která z uvedených položek je stakeholder (a nikoli concern)?

- [x] Vedoucí provozu IT
- [ ] Dostupnost systémů
- [ ] Náklady na licence
- [ ] Ochrana osobních údajů

> Stakeholder je osoba nebo role — zde vedoucí provozu IT. Dostupnost, náklady a ochrana osobních údajů jsou zájmy (concerns), které stakeholdeři mají.

## Zájem (Concern) {#concern .term}

**Concern** (zájem) je téma nebo otázka, na které stakeholderovi ve vztahu k systému či architektuře **záleží** — např. náklady, bezpečnost, dostupnost, soulad s regulací, dopad plánované změny, rychlost uvedení produktu na trh. Mezi stakeholdery a zájmy je vztah **M:N**: jeden stakeholder má více zájmů a jeden zájem může sdílet více stakeholderů. Pohledy se tvoří právě proto, aby na zájmy odpověděly.

### ? Co je v architektuře concern (zájem)?

- [ ] Riziko, které se při realizaci projektu již skutečně projevilo
- [x] Téma, na kterém stakeholderovi ve vztahu k systému záleží
- [ ] Formální požadavek zapsaný ve smlouvě s dodavatelem řešení
- [ ] Organizační útvar, který odpovídá za provoz konkrétní aplikace

> Concern je oblast zájmu stakeholdera — bezpečnost, náklady, dostupnost, dopad změny. Nejde o riziko, které nastalo, o smluvní požadavek ani o organizační útvar.

### ? Bezpečnostní manažerka se ptá: „Ve kterých aplikacích a databázích jsou uložena osobní data zákazníků?" Co tato otázka v terminologii popisu architektury představuje?

- [ ] Viewpoint
- [ ] Stakeholdera
- [ ] Pohled (view)
- [x] Zájem (concern)

> Otázka vyjadřuje zájem (concern) stakeholdera — bezpečnostní manažerky. Viewpoint je předpis pro pohled, který na zájem odpoví, a pohled je konkrétní výsledek.

### ? Který výrok o vztahu stakeholderů a zájmů (concerns) je správný?

- [x] Jeden stakeholder má více zájmů a jeden zájem může sdílet více stakeholderů
- [ ] Každý stakeholder má právě jeden zájem a každý zájem jen jednoho stakeholdera
- [ ] Zájmy mají jen vrcholoví manažeři, ostatní stakeholdeři žádné zájmy nemají
- [ ] Zájem vzniká až tehdy, když pro něj architekt vytvoří konkrétní pohled

> Vztah je M:N — např. zájem „náklady" sdílí finanční ředitel i CIO a CIO má zároveň zájmy bezpečnost a dostupnost. Zájmy mají všichni stakeholdeři a existují nezávisle na pohledech.

## Od stakeholdera k pohledu {#od-stakeholdera-k-view .explain}

Typický postup tvorby pohledu: (1) určit **stakeholdera**, (2) zjistit jeho **zájmy** (concerns), (3) zvolit nebo definovat **viewpoint**, který na tyto zájmy odpovídá, (4) podle viewpointu vytvořit z modelu **pohled** a (5) s jeho pomocí komunikovat či rozhodovat. Pohled, který vznikl bez ohledu na zájmy, bývá přeplněný a nikdo ho nečte.

*Příklad:* Vedoucí provozu (stakeholder) zajímá, na čem běží platební brána (concern). Zvolí se viewpoint zaměřený na nasazení a pohled ukáže fragment `platba.war (Artifact) —realization→ Platební brána (Application Component)` a `Aplikační server (Node) —assignment→ platba.war (Artifact)`.

### ? V jakém pořadí se při tvorbě pohledu pro stakeholdera typicky postupuje?

- [ ] Pohled → viewpoint → zájmy → stakeholder
- [ ] Viewpoint → stakeholder → pohled → zájmy
- [x] Stakeholder → zájmy → viewpoint → pohled
- [ ] Zájmy → pohled → stakeholder → viewpoint

> Nejdřív je třeba vědět, pro koho pohled je a co ho zajímá; podle toho se zvolí viewpoint a teprve podle něj se z modelu vytvoří pohled.

### ? Pohled připravený pro provozního manažera nikdo nepoužívá, protože obsahuje stovky prvků ze všech vrstev. Co bylo při jeho tvorbě nejspíš zanedbáno?

- [ ] Použití správných barev pro jednotlivé vrstvy jazyka
- [ ] Zapsání všech prvků modelu do jednoho repozitáře
- [ ] Rozdělení pohledu do několika samostatných modelů
- [x] Výběr viewpointu podle zájmů daného stakeholdera

> Pohled má odpovídat zájmům stakeholdera, a to zajistí volba vhodného viewpointu, který omezí obsah na podstatné. Barvy nejsou normativní, jeden repozitář je správně a rozdělení na více modelů by problém nevyřešilo.

## ISO/IEC/IEEE 42010 {#iso-42010 .term}

**ISO/IEC/IEEE 42010** je mezinárodní norma pro **popis architektury** systémů a softwaru. Zavádí konceptuální rámec pojmů **architecture description, stakeholder, concern, viewpoint a view**, který ArchiMate přebírá (jeho mechanismus viewpointů na něm stojí). Norma předepisuje, **co** má dobrý popis architektury obsahovat, ale **nepředepisuje žádnou konkrétní notaci** — tu dodává například právě ArchiMate.

### ? Ze které normy pocházejí pojmy stakeholder, concern, view a viewpoint, s nimiž ArchiMate pracuje?

- [ ] ISO/IEC 27001
- [x] ISO/IEC/IEEE 42010
- [ ] ISO/IEC 20000-1
- [ ] ISO 9001

> Konceptuální rámec popisu architektury (stakeholder, concern, view, viewpoint) definuje ISO/IEC/IEEE 42010. Ostatní normy se týkají bezpečnosti informací, řízení IT služeb a řízení kvality.

### ? Co norma ISO/IEC/IEEE 42010 NEDEFINUJE?

- [ ] Pojmy stakeholder a concern pro popis architektury
- [ ] Vztah mezi pohledem (view) a viewpointem
- [x] Konkrétní grafickou notaci prvků a vztahů
- [ ] Pojem popis architektury (architecture description)

> Norma 42010 je na notaci nezávislá — říká, co má popis architektury obsahovat, ne jak kreslit. Konkrétní notaci dodávají jazyky jako ArchiMate.

## ArchiMate × UML × BPMN {#archimate-uml-bpmn .compare}

ArchiMate jiné jazyky nenahrazuje, ale doplňuje — každý míří na jinou úroveň detailu:

| | ArchiMate | BPMN | UML |
|---|---|---|---|
| Správce standardu | The Open Group | OMG | OMG |
| Hlavní účel | podniková architektura napříč doménami | detailní průběh business procesů | návrh a dokumentace softwaru |
| Úroveň | přehled, vazby mezi byznysem, aplikacemi a technologiemi | podrobný tok: brány, události, výjimky | třídy, komponenty, sekvence volání |
| Typický čtenář | architekt, management, vlastníci domén | analytik procesů, procesní engine | softwarový architekt, vývojář |

### ? Analytik potřebuje podrobně popsat průběh schvalování faktury včetně rozhodovacích bran, souběžných větví a ošetření výjimek. Který jazyk je pro to nejvhodnější?

- [x] BPMN
- [ ] ArchiMate
- [ ] UML diagram tříd
- [ ] UML diagram nasazení

> Detailní tok procesu s branami a výjimkami je doménou BPMN. ArchiMate proces zachytí jen přehledově v kontextu architektury a UML diagramy tříd či nasazení popisují software, ne průběh business procesu.

### ? Pro který úkol je ArchiMate vhodnější než UML a BPMN?

- [ ] Návrh tříd a metod nové softwarové komponenty
- [ ] Popis přesného pořadí kroků procesu včetně všech výjimek
- [ ] Návrh sekvence volání mezi objekty aplikace
- [x] Přehled vazeb mezi byznysem, aplikacemi a technologiemi

> Síla ArchiMate je v šíři: propojuje domény a ukazuje závislosti napříč podnikem. Návrh tříd a sekvencí je doménou UML, detailní průběh procesu doménou BPMN.

## Šíře místo hloubky {#sire-vs-hloubka .explain}

ArchiMate záměrně pokrývá **šíři** podniku s menší hloubkou detailu. Detailní návrh — průběh procesu s větvením, datový model s atributy, třídy a sekvence volání — patří do specializovaných jazyků (BPMN, UML, datové modely). Prvky modelu ArchiMate pak slouží jako „kotvy", na které lze detailní modely navázat: proces v ArchiMate se zpřesní v BPMN, aplikační komponenta v UML.

*Příklad:* `Vyřízení reklamace (Business Process)` je v ArchiMate jen s hlavními kroky a vazbou `Reklamační systém (Application Component) —serving→ Vyřízení reklamace (Business Process)`; podrobný postup s rozhodováním je v samostatném BPMN diagramu.

### ? Architekt chce v modelu ArchiMate zachytit všechny atributy databázových tabulek a pořadí volání metod mezi třídami. Jaké je nejlepší doporučení?

- [ ] Vytvořit pro každý atribut samostatný prvek Grouping
- [x] Detail popsat v UML či datovém modelu a navázat na ArchiMate
- [ ] Rozšířit model o nové vrstvy pro databáze a pro zdrojový kód
- [ ] Nakreslit vše do jednoho velkého pohledu Technology Layer

> ArchiMate je jazykem pro přehled napříč doménami; detailní návrh dat a softwaru patří do specializovaných jazyků, na které se model ArchiMate odkazuje. Grouping, nové vrstvy ani přeplněný pohled nejsou správné řešení.

### ? Jak se ArchiMate typicky používá společně s BPMN?

- [ ] BPMN nahrazuje Business Layer, ArchiMate se pak pro byznys nepoužívá
- [ ] Oba jazyky se nikdy nekombinují, protože mají odlišného správce
- [x] ArchiMate ukazuje proces v kontextu architektury, BPMN jeho detailní tok
- [ ] ArchiMate popisuje detailní tok procesu, BPMN jen jeho souvislosti

> Jazyky se doplňují: ArchiMate zasazuje proces do souvislostí (kdo ho vykonává, které aplikace ho podporují), BPMN popisuje jeho podrobný průběh. Kombinace je běžná a role nejsou obrácené.

## ArchiMate a TOGAF {#archimate-togaf .explain}

ArchiMate i TOGAF jsou standardy **The Open Group** a vzájemně se doplňují. **TOGAF** je **metoda a rámec** — říká, jak architekturu vytvářet a řídit (cyklus ADM, obsah architektury, governance), ale nepředepisuje modelovací notaci. **ArchiMate** je **jazyk** — říká, jak architekturu zapsat a zobrazit, ale nepředepisuje postup. ArchiMate lze použít s TOGAF (nejčastěji) i s jinými rámci a metodami a pojmy obou standardů jsou sladěné, i když nejsou totožné.

*Příklad:* Ve fázi Application Architecture cyklu ADM architekt zachytí cílový stav modelem s fragmentem `Objednávkový portál (Application Component) —realization→ Správa objednávek (Application Service)`.

### ? Jak se k sobě mají TOGAF a ArchiMate?

- [ ] Jde o dvě konkurenční metody tvorby podnikové architektury
- [x] TOGAF je metoda a rámec, ArchiMate jazyk pro zápis architektury
- [ ] ArchiMate je jedna z fází cyklu ADM definovaná ve standardu TOGAF
- [ ] TOGAF je notace a ArchiMate metoda, která ji používá v praxi

> TOGAF popisuje, jak architekturu vytvářet a řídit; ArchiMate dodává jazyk, kterým ji zapsat. Nekonkurují si a ArchiMate není fází ADM.

### ? Který výrok o vztahu ArchiMate a TOGAF je správný?

- [ ] ArchiMate lze použít jedině v organizaci, která zavedla TOGAF
- [ ] TOGAF předepisuje ArchiMate jako jedinou povolenou notaci
- [ ] Pojmy obou standardů jsou zcela totožné, liší se jen jazyk
- [x] ArchiMate lze používat i s jinými rámci a metodami než TOGAF

> ArchiMate je na metodě nezávislý, i když s TOGAF spolupracuje nejtěsněji. TOGAF žádnou notaci nepředepisuje a pojmy obou standardů jsou sladěné, ale ne identické.

### ? Firma používá cyklus TOGAF ADM a hledá jednotnou standardní notaci pro modely ve fázích Business, Application a Technology Architecture. Co jí ArchiMate nabízí?

- [x] Společný jazyk pro modely a pohledy všech tří domén
- [ ] Novou sadu fází, která nahradí fáze B až D v cyklu ADM
- [ ] Hotové cílové architektury pro typická odvětví a typy firem
- [ ] Postup pro řízení architektonických požadavků a změn v ADM

> ArchiMate dodává jednotný jazyk, kterým lze zachytit business, aplikační i technologickou architekturu a vazby mezi nimi. Nenahrazuje fáze ADM, nedodává hotové architektury a řízení požadavků je věcí metody.

## Vrstvy ArchiMate × domény TOGAF {#vrstvy-domeny .compare}

Vrstvy jazyka zhruba odpovídají architektonickým doménám TOGAF:

| Vrstva / část ArchiMate | Doména či oblast TOGAF |
|---|---|
| Business Layer | Business Architecture |
| Application Layer | Application Architecture; data pokrývají hlavně Data Object (a Business Object v Business Layer) |
| Technology Layer a fyzické prvky | Technology Architecture |
| Strategy prvky | strategické části Architecture Vision a Business Architecture |
| Motivation prvky | Preliminary, Architecture Vision, Requirements Management |
| Implementation & Migration | Opportunities and Solutions, Migration Planning |

ArchiMate **nemá samostatnou datovou vrstvu** — Data Architecture se modeluje pasivními prvky v ostatních vrstvách.

### ? Která vrstva ArchiMate odpovídá doméně Technology Architecture v TOGAF?

- [ ] Application Layer
- [ ] Implementation & Migration
- [x] Technology Layer
- [ ] Business Layer

> Technology Architecture odpovídá Technology Layer (doplněné o fyzické prvky). Application Layer odpovídá Application Architecture, Business Layer Business Architecture a Implementation & Migration plánování přechodu.

### ? TOGAF rozlišuje samostatnou doménu Data Architecture. Jak ji pokrývá ArchiMate?

- [ ] Samostatnou vrstvou Data Layer mezi aplikační a technologickou
- [ ] Nijak, datovou architekturu ArchiMate záměrně nemodeluje
- [ ] Výhradně prvky Motivation, které popisují požadavky na data
- [x] Pasivními prvky, zejména Data Object v Application Layer

> ArchiMate nemá samostatnou datovou vrstvu; data zachycuje pasivními strukturními prvky, hlavně Data Object (logická data) a Business Object (byznysové informace). Motivation prvky data samy nepopisují.

## ArchiMate v cyklu ADM {#archimate-v-adm .explain}

Jeden model ArchiMate se v cyklu ADM postupně rozšiřuje. Ve fázích **Preliminary** a **Architecture Vision** se uplatní hlavně prvky **Motivation** (stakeholdeři, drivery, cíle, principy) a přehledové pohledy. Ve fázích **B, C a D** se modeluje **Baseline** a **Target** architektura pomocí prvků Business, Application a Technology Layer. Ve fázích **E a F** (Opportunities and Solutions, Migration Planning) přicházejí na řadu prvky **Implementation & Migration** — Work Package, Deliverable, Plateau a Gap. Požadavky z **Requirements Management** lze zachytit prvky Requirement a Constraint.

*Příklad:* Cíl z fáze A `Zkrátit dobu vyřízení objednávky (Goal)` je ve fázi C navázán na aplikační prvky, které k němu přispívají, a ve fázi F na Work Package, který je realizuje.

### ? Ve fázi Architecture Vision architekt zachycuje stakeholdery, jejich drivery a cíle podniku. Které prvky ArchiMate k tomu použije především?

- [ ] Prvky Implementation & Migration
- [ ] Prvky Technology Layer
- [x] Prvky aspektu Motivation
- [ ] Prvky Application Layer

> Stakeholdery, drivery a cíle zachycují prvky Motivation (Stakeholder, Driver, Goal…), které se uplatní hlavně v Preliminary a Architecture Vision. Ostatní vrstvy popisují samotnou architekturu nebo její realizaci.

### ? Ve kterých fázích TOGAF ADM se uplatní hlavně prvky Implementation & Migration (Work Package, Plateau, Gap)?

- [x] Opportunities and Solutions a Migration Planning
- [ ] Preliminary a Architecture Vision
- [ ] Business Architecture a Application Architecture
- [ ] Technology Architecture a Requirements Management

> Plánování přechodu — projekty (Work Package), mezistavy (Plateau) a mezery (Gap) — se odehrává ve fázích E a F. Ostatní uvedené fáze pracují hlavně s motivačními prvky nebo s prvky jednotlivých vrstev.

## Principy návrhu jazyka {#principy-navrhu .explain}

ArchiMate je navržen podle několika zásad: (1) **jednoduchost** — co nejmenší počet konceptů, aby se jazyk dal rychle naučit a modely byly srozumitelné; (2) **pokrytí běžných potřeb** — jazyk míří na většinu typických modelovacích situací podnikové architektury, ne na každou výjimku (často se uvádí pravidlo 80/20); (3) **ucelenost a jednotnost** — ve všech vrstvách se opakuje stejná struktura konceptů a vztahů, takže kdo zná jednu vrstvu, rychle pochopí další; (4) **rozšiřitelnost** — speciální potřeby se řeší specializací prvků a profily, ne nafukováním standardu; (5) **nezávislost** na nástrojích a metodách.

*Příklad:* Stejný vzor platí v Business i Application Layer: `Zákaznická podpora (Business Role) —assignment→ Řešení dotazu (Business Process) —realization→ Podpora zákazníka (Business Service)` odpovídá `Helpdesk (Application Component) —assignment→ Evidence tiketů (Application Function) —realization→ Správa tiketů (Application Service)`.

### ? Proč má ArchiMate záměrně omezený počet typů prvků?

- [ ] Protože starší modelovací nástroje víc typů prvků nezvládnou
- [ ] Protože detailnější prvky jsou vyhrazeny pro placenou verzi
- [x] Aby byl snadno naučitelný a přitom pokryl většinu běžných potřeb
- [ ] Protože další typy prvků lze vytvářet jen v rámci jazyka UML

> Jednoduchost je vědomý princip návrhu: málo konceptů znamená snadné učení a srozumitelné modely, a přesto jazyk pokryje většinu typických situací. Omezení nástrojů ani licenční důvody za tím nejsou a rozšíření se řeší specializací v samotném ArchiMate.

### ? Co znamená, že je jazyk ArchiMate napříč vrstvami jednotný (uniformní)?

- [x] Každá vrstva opakuje stejnou strukturu typů prvků a vztahů
- [ ] Všechny vrstvy musí být vždy zobrazeny v každém pohledu
- [ ] Všechny prvky všech vrstev mají stejný tvar i stejnou barvu
- [ ] Každá vrstva smí obsahovat jen prvky jednoho jediného typu

> Business, Application i Technology Layer mají obdobné druhy prvků (aktivní struktura, chování, služba, rozhraní, pasivní objekt) a vztahy, takže znalost jedné vrstvy se přenáší na další. Jednotnost neznamená stejný vzhled ani povinnost zobrazovat všechny vrstvy.

## Certifikace ArchiMate 3 {#certifikace .term}

The Open Group nabízí dvě úrovně certifikace ArchiMate 3: **Foundation** (úroveň 1) ověřuje **znalost jazyka** — pojmy, prvky, vztahy, strukturu a viewpointy — formou otázek s výběrem odpovědi; **Practitioner** (úroveň 2) ověřuje **schopnost jazyk použít** na scénářích z praxe (volba správného modelu, vztahu a viewpointu). Zkoušky jsou v angličtině, proto se oficiální anglické názvy prvků a vztahů vyplatí znát přesně. Aktuální podmínky (počet otázek, čas, hranice úspěchu) je vhodné ověřit u The Open Group.

### ? Čím se zaměření certifikace ArchiMate 3 Practitioner liší od Foundation?

- [ ] Practitioner ověřuje jen historii a verze standardu ArchiMate
- [ ] Practitioner se zaměřuje výhradně na metodu TOGAF ADM
- [ ] Practitioner ověřuje znalost modelovacích nástrojů dodavatelů
- [x] Practitioner ověřuje použití jazyka na scénářích z praxe

> Foundation ověřuje znalost jazyka, Practitioner jeho aplikaci na scénářích — volbu správných prvků, vztahů a viewpointů. Historie standardu, TOGAF ADM ani konkrétní nástroje nejsou těžištěm zkoušky.
