---
kind: topic
subject: togaf-foundation
slug: obsah-architektury
name: "Architecture Content Framework"
order: 7
---

Deliverables × Artifacts × Building Blocks (Architecture Building Blocks × Solution Building Blocks); katalogy, matice, diagramy; Content Metamodel (přehled).

## Rámec obsahu architektury (Architecture Content Framework) {#acf .term}

Architecture Content Framework je část TOGAF Standardu, která popisuje, jaké pracovní produkty architektonická práce vytváří, jak jsou strukturované a jak spolu souvisejí. Dává jednotný strukturální model obsahu – výstupy (deliverables), artefakty (artifacts) a stavební bloky (building blocks) – aby se výsledky práce v ADM definovaly, ukládaly a prezentovaly konzistentně.

### ? Co popisuje Architecture Content Framework v TOGAF Standardu?

- [ ] Pořadí fází ADM a podmínky pro přechod mezi nimi
- [x] Strukturu pracovních produktů architektury a vazby mezi nimi
- [ ] Organizační strukturu architektonického týmu a odpovědnosti jeho rolí
- [ ] Úrovně souladu projektu s architekturou při revizích

> Architecture Content Framework dává jednotný strukturální model obsahu (výstupy, artefakty, stavební bloky). Pořadí fází popisuje samotná ADM, organizaci týmu Architecture Capability a soulad projektů Architecture Compliance.

### ? Která trojice tvoří hlavní kategorie obsahu v Architecture Content Framework?

- [ ] Views, viewpoints a stakeholders
- [ ] Principles, requirements a constraints
- [ ] Baseline, Target a Transition Architecture
- [x] Deliverables, artifacts a building blocks

> Rámec obsahu třídí pracovní produkty na výstupy (deliverables), artefakty (artifacts) a stavební bloky (building blocks). Ostatní trojice jsou skutečné pojmy TOGAF, ale nejsou to kategorie obsahu v tomto rámci.

## Proč TOGAF zavádí rámec obsahu {#acf-prinosy .explain}

Bez společného modelu obsahu by každý projekt dokumentoval architekturu po svém a výsledky by nešlo porovnat, sloučit ani znovu použít. Rámec obsahu sjednocuje, jaké produkty v jednotlivých fázích ADM vznikají, a tím usnadňuje kontrolu úplnosti, sledovatelnost (traceability) od motivací a požadavků až k řešení a ukládání do Architecture Repository. Zároveň je dobrým základem pro nástroje na modelování architektury. Organizace může místo něj použít i jiný rámec obsahu, pokud plní stejný účel.

*Příklad:* Dvě divize popisují své aplikace stejným katalogem (Application Portfolio Catalog) se stejnými atributy, takže architekt jejich aplikační krajinu snadno sloučí a najde duplicitní systémy.

### ? Jaký je hlavní přínos jednotného rámce obsahu architektury pro organizaci?

- [x] Výsledky různých projektů jsou srovnatelné a znovupoužitelné
- [ ] Nahrazuje formální schvalování výstupů stakeholdery
- [ ] Určuje, který dodavatel produktu má být vybrán
- [ ] Odstraňuje potřebu iterací ADM v rámci jednoho cyklu

> Jednotná struktura obsahu umožňuje porovnávat, slučovat a znovu používat výsledky architektonické práce. Schvalování výstupů nenahrazuje, výběr dodavatele neurčuje a iterace ADM neruší.

### ? Architekt chce ověřit, že každý business požadavek je pokrytý alespoň jednou aplikační komponentou. Kterou vlastnost strukturovaného obsahu architektury tím využívá?

- [ ] Formální podpis výstupu ze strany Architecture Board
- [x] Sledovatelnost (traceability) mezi prvky architektury
- [ ] Iteraci fáze Phase A Architecture Vision
- [ ] Zpřesnění rozsahu v Request for Architecture Work

> Když jsou prvky architektury a jejich vztahy popsané jednotně, lze dohledat vazbu od požadavku ke komponentě, která ho naplňuje. Podpis, iterace ani Request for Architecture Work na tuto otázku neodpoví.

## Jak spolu souvisejí výstupy, artefakty a stavební bloky {#tri-kategorie .explain}

Tři kategorie obsahu do sebe zapadají jako vrstvy. Výstup (deliverable) je formálně schvalovaný produkt, typicky dokument, a obsahuje řadu artefaktů. Artefakt (artifact) je dílčí popis určitého aspektu architektury – katalog, matice nebo diagram. Artefakty popisují stavební bloky (building blocks), tedy komponenty, ze kterých se architektury a řešení skládají.

*Příklad:* Architecture Definition Document (výstup) obsahuje Application Portfolio Catalog (artefakt), v němž je uvedena komponenta „Fakturační systém" (stavební blok).

### ? Jak spolu podle TOGAF souvisejí tři kategorie obsahu architektury?

- [ ] Artefakty obsahují výstupy a výstupy popisují stavební bloky
- [ ] Stavební bloky obsahují artefakty a ty pak tvoří výstupy
- [x] Výstupy obsahují artefakty a artefakty popisují stavební bloky
- [ ] Výstup a artefakt jsou synonyma, stavební bloky stojí zvlášť

> Výstup je nejširší, formálně schvalovaný celek složený z artefaktů; artefakty pak popisují jednotlivé stavební bloky. Ostatní možnosti vztah obracejí nebo kategorie směšují.

### ? Architecture Definition Document obsahuje mimo jiné Application Portfolio Catalog, v němž je uvedena komponenta „Mzdový systém". Jak tyto tři prvky v uvedeném pořadí zařadit?

- [ ] Artefakt – výstup – stavební blok
- [ ] Výstup – stavební blok – artefakt
- [ ] Stavební blok – artefakt – výstup
- [x] Výstup – artefakt – stavební blok

> Architecture Definition Document je výstup (deliverable), katalog aplikací je artefakt typu katalog a konkrétní mzdová komponenta je stavební blok, který katalog popisuje.

## Výstup (Deliverable) {#deliverable .term}

Výstup (deliverable) je produkt architektonické práce, na kterém se zadavatel a architekti předem dohodnou (obvykle ve Statement of Architecture Work). Stakeholdeři ho posoudí a schválí; většinou jde o dokument. Po skončení projektu se archivuje, nebo se jeho obsah přenese do Architecture Repository k dalšímu použití.

### ? Co odlišuje výstup (deliverable) od ostatních kategorií obsahu architektury?

- [x] Je formálně přezkoumán, odsouhlasen a podepsán stakeholdery
- [ ] Popisuje vždy jen vztahy mezi dvěma typy prvků architektury
- [ ] Je to znovupoužitelná komponenta kapability podniku
- [ ] Vzniká výhradně ve fázi Phase G Implementation Governance

> Výstup je formálně sjednaný a schválený produkt. Vztahy mezi dvěma typy prvků popisuje matice, znovupoužitelná komponenta je stavební blok a výstupy vznikají v celé ADM, ne jen v Phase G.

### ? Co se podle TOGAF typicky děje s výstupem (deliverable) po dokončení projektu?

- [ ] Smaže se, protože ho vždy nahradí další iterace ADM
- [ ] Předá se vybranému dodavateli jako závazná specifikace produktu
- [x] Archivuje se, nebo se převede do Architecture Repository
- [ ] Rozloží se zpět na jednotlivé stavební bloky a zanikne

> Hotový výstup se archivuje, nebo se jeho obsah přenese do Architecture Repository, kde poslouží další práci. Nemaže se, nerozkládá ani se nestává specifikací pro dodavatele.

### ? Který z uvedených prvků je výstupem (deliverable), a ne artefaktem?

- [ ] Application Portfolio Catalog
- [x] Architecture Definition Document
- [ ] Solution Concept Diagram
- [ ] Application/Data Matrix

> Architecture Definition Document je formálně schvalovaný výstup. Katalog, diagram i matice jsou artefakty, které se do výstupů vkládají.

## Artefakt (Artifact) {#artifact .term}

Artefakt (artifact) je jemnější pracovní produkt, který popisuje jeden aspekt architektury. TOGAF artefakty třídí na katalogy (seznamy prvků), matice (vztahy mezi prvky) a diagramy (grafická znázornění). Artefakty se seskupují do výstupů a tvoří obsah Architecture Repository.

### ? Jak TOGAF třídí artefakty (artifacts)?

- [ ] Na logické, fyzické a přechodové
- [x] Na katalogy, matice a diagramy
- [ ] Na principy, požadavky a omezení
- [ ] Na strategické, segmentové a kapabilitní

> Artefakty jsou katalogy, matice nebo diagramy. Logické × fyzické je dělení komponent v metamodelu a strategická, segmentová a kapabilitní jsou úrovně architektury.

### ? Které tvrzení o artefaktu (artifact) je správné?

- [ ] Každý artefakt musí samostatně podepsat Architecture Board
- [ ] Je to fyzický produkt dodavatele, který se nasadí do provozu
- [ ] Vzniká jen v Preliminary Phase při přizpůsobení rámce
- [x] Popisuje jeden aspekt architektury a bývá součástí výstupu

> Artefakt je dílčí popis architektury, který se vkládá do výstupů a ukládá do Architecture Repository. Formálně se schvaluje výstup, ne každý artefakt; produkt dodavatele odpovídá SBB; artefakty vznikají v celé ADM.

## Stavební blok (Building Block) {#building-block .term}

Stavební blok (building block) je díl, ze kterého se skládají architektury a řešení. Představuje část schopností (kapability) podniku – z oblasti byznysu, IT nebo samotné architektury – a dá se spojovat s dalšími bloky; větší blok může zahrnovat menší a popsat ho lze zhruba i velmi podrobně. Ideálně se dá použít opakovaně. TOGAF rozlišuje architektonické stavební bloky (ABB) a stavební bloky řešení (SBB).

### ? Co je stavební blok (building block) v TOGAF?

- [ ] Formálně podepsaný dokument předávaný na konci fáze
- [ ] Seznam prvků jednoho typu, například všech aplikací
- [x] Kombinovatelná, ideálně znovupoužitelná komponenta kapability
- [ ] Pracovní balík (work package) v Implementation and Migration Plan

> Stavební blok je komponenta kapability, ze které se skládají architektury a řešení. Podepsaný dokument je výstup, seznam prvků je katalog a pracovní balík je jednotka plánování realizace.

### ? Které tvrzení o stavebních blocích NENÍ pravdivé?

- [ ] Stavební blok se může skládat z dalších stavebních bloků
- [ ] Stavební blok může být popsán na různé úrovni podrobnosti
- [ ] Stavební blok může představovat i business kapabilitu, nejen IT
- [x] Stavební blok musí být vždy konkrétní produkt dodavatele

> Vazbu na konkrétní produkt mají jen stavební bloky řešení (SBB); architektonické stavební bloky (ABB) jsou na produktech nezávislé. Ostatní tvrzení platí.

## Výstup × artefakt × stavební blok {#deliverable-artifact-bb .compare}

|  | Výstup (deliverable) | Artefakt (artifact) | Stavební blok (building block) |
|---|---|---|---|
| Co to je | formálně sjednaný pracovní produkt | dílčí popis jednoho aspektu architektury | komponenta kapability, ze které se skládá architektura či řešení |
| Schválení | přezkoumán a podepsán stakeholdery | schvaluje se jako součást výstupu | popisuje se v artefaktech |
| Podoba | obvykle dokument | katalog, matice nebo diagram | ABB nebo SBB |
| Příklad | Architecture Definition Document | Application Portfolio Catalog | komponenta „Platební brána" |

### ? Architekt popisuje „platební bránu" jako znovupoužitelnou komponentu s definovanými rozhraními, kterou mohou využít různé projekty. O jakou kategorii obsahu architektury jde?

- [ ] Výstup (deliverable)
- [ ] Artefakt typu diagram
- [x] Stavební blok (building block)
- [ ] Artefakt typu katalog

> Znovupoužitelná komponenta s rozhraními je stavební blok. Katalog nebo diagram by ji mohly popisovat a výstup by takové artefakty obsahoval, ale komponenta sama je stavební blok.

### ? Které tvrzení správně vystihuje rozdíl mezi výstupem (deliverable) a artefaktem (artifact)?

- [x] Výstup je formálně schvalovaný celek, artefakt jeho dílčí popis
- [ ] Artefakt je formálně schvalovaný celek, výstup jeho dílčí popis
- [ ] Výstup popisuje řešení, artefakt jen výchozí architekturu
- [ ] Výstup je vždy diagram, artefakt je vždy textový dokument

> Výstupy se formálně schvalují a obsahují artefakty. Artefakty mohou popisovat výchozí i cílovou architekturu a diagram je jen jeden z typů artefaktu.

## Vlastnosti dobrého stavebního bloku {#vlastnosti-bb .explain}

Dobrý blok řeší konkrétní potřebu byznysu, má zřetelné hranice a rozhraní, spolupracuje s ostatními bloky a dá se znovu použít i vyměnit. Má srozumitelnou specifikaci a už při návrhu se myslí na to, jak se bude implementovat a používat. Bloky lze do sebe vnořovat – jeden může obsahovat další a sám být dílem většího celku – a mohou se postupně měnit, jak se vyvíjejí technologie a standardy.

*Příklad:* Blok „Správa identit" má definované rozhraní pro přihlášení a ověření oprávnění. Využije ho e-shop i interní systémy a lze ho vyměnit za jiné řešení, aniž by se musely přepisovat aplikace, které ho používají.

### ? Která vlastnost je pro dobrý stavební blok podle TOGAF klíčová?

- [ ] Je navržen na míru jen pro jeden konkrétní projekt
- [ ] Skrývá svá rozhraní, aby je nikdo nemohl měnit
- [x] Má jasně definovanou hranici a rozhraní
- [ ] Je vždy vázán na jednu fyzickou lokalitu

> Definovaná hranice a rozhraní umožňují stavební blok kombinovat, znovu použít i nahradit. Vazba na jeden projekt nebo lokalitu znovupoužití brání a skrytá rozhraní znemožňují interoperabilitu.

### ? Proč je u stavebního bloku žádoucí, aby byl nahraditelný (replaceable)?

- [ ] Aby ho mohl Architecture Board schválit bez jakékoli revize
- [x] Aby šlo změnit jeho implementaci bez dopadu na okolní bloky
- [ ] Aby se nemusel evidovat v Architecture Repository
- [ ] Aby se dal použít jen ve výchozí (Baseline) architektuře

> Nahraditelný blok s dobře definovaným rozhraním lze vyměnit (např. za nový produkt), aniž by se měnily bloky, které ho využívají. S governance ani evidencí v repozitáři tato vlastnost nesouvisí.

## Architektonický stavební blok (Architecture Building Block, ABB) {#abb .term}

ABB zachycuje architektonické požadavky (business, datové, aplikační i technologické) a popisuje potřebnou funkcionalitu, atributy, rozhraní a vazby na další bloky – nezávisle na konkrétním produktu či dodavateli. Slouží jako zadání, které usměrňuje a vede vývoj stavebních bloků řešení (SBB). Definuje se hlavně při vývoji architektur v Phases B, C a D.

### ? Co je hlavním účelem Architecture Building Block (ABB)?

- [x] Zachytit požadavky a usměrnit vývoj stavebních bloků řešení
- [ ] Určit konkrétní produkt a dodavatele, který řešení implementuje
- [ ] Naplánovat pořadí nasazení v přechodových architekturách
- [ ] Zaznamenat výsledky revize souladu (Compliance Review)

> ABB popisuje, co je potřeba, a slouží jako vodítko pro SBB. Výběr produktu odpovídá SBB, pořadí nasazení řeší plánování migrace a výsledky revizí patří do governance.

### ? Která část specifikace patří typicky k ABB, a ne k SBB?

- [ ] Verze databázového serveru a licenční model produktu
- [ ] Mapování na konkrétní IT topologii a provozní politiky
- [x] Základní funkcionalita a rozhraní bez vazby na produkt
- [ ] Výkonnostní parametry a konfigurace zvoleného řešení

> ABB se specifikuje funkcionalitou, atributy a rozhraními nezávisle na produktu. Verze, licence, topologie, výkon a konfigurace popisují konkrétní řešení, tedy SBB.

## Stavební blok řešení (Solution Building Block, SBB) {#sbb .term}

SBB popisuje konkrétní komponenty – koupené produkty, balíky nebo vlastní vývoj – které požadovanou funkcionalitu skutečně implementují. Je vázán na produkt nebo dodavatele (product/vendor-aware), definuje způsob implementace a musí naplnit požadavky zachycené v příslušných ABB. Do popředí se dostává ve chvíli, kdy se architektura převádí na řešení, tedy od Phase E dál.

### ? Čím se vyznačuje Solution Building Block (SBB)?

- [ ] Je záměrně nezávislý na produktech a dodavatelích
- [ ] Popisuje jen vztahy mezi business funkcemi a rolemi
- [ ] Nahrazuje ABB, který se po vzniku SBB z architektury ruší
- [x] Je vázán na konkrétní produkt nebo dodavatele

> SBB je „product/vendor-aware" – popisuje konkrétní implementaci. Nezávislost na produktu je vlastnost ABB a ABB se po vzniku SBB neruší, protože zůstává měřítkem, zda řešení požadavky plní.

### ? Firma rozhodla, že potřebu „správy vztahů se zákazníky" naplní konkrétním CRM produktem vybraného dodavatele včetně jeho konfigurace a napojení na stávající systémy. Jak TOGAF tento popis řešení označuje?

- [ ] Architecture Building Block (ABB)
- [x] Solution Building Block (SBB)
- [ ] Architecture Principle
- [ ] Transition Architecture

> Popis konkrétního produktu s konfigurací a integrací je SBB. ABB by potřebu popsal bez vazby na produkt; princip ani přechodová architektura nejsou popisem komponenty.

## ABB × SBB {#abb-sbb .compare}

|  | Architecture Building Block (ABB) | Solution Building Block (SBB) |
|---|---|---|
| Odpovídá na | *co* je potřeba | *čím a jak* se to zajistí |
| Vazba na produkt | nezávislý na produktu a dodavateli | vázán na produkt nebo dodavatele |
| Obsah specifikace | funkcionalita, atributy, rozhraní, vazby na jiné bloky | konkrétní implementace, použité rozhraní, výkon, konfigurace, mapování na topologii |
| Kdy v ADM | hlavně Phases B, C, D | hlavně od Phase E (řešení a implementace) |
| Příklad | „služba elektronického podpisu" | vybraný produkt pro elektronický podpis a jeho nasazení |

### ? Který pár správně ukazuje ABB a k němu odpovídající SBB?

- [ ] „Vybraný ERP produkt v cloudu" (ABB) × „Účetní funkcionalita" (SBB)
- [ ] „Architecture Vision" (ABB) × „Architecture Roadmap" (SBB)
- [x] „Služba elektronického podpisu" (ABB) × „Vybraný produkt pro e-podpis" (SBB)
- [ ] „Katalog aplikací" (ABB) × „Matice aplikací a dat" (SBB)

> ABB popisuje potřebnou schopnost bez vazby na produkt, SBB ji naplňuje konkrétním produktem. První pár je obrácený, Architecture Vision a Roadmap jsou výstupy a katalog s maticí jsou artefakty.

### ? Jaký je vztah mezi ABB a SBB?

- [ ] SBB definují požadavky, podle kterých se teprve navrhují ABB
- [ ] ABB a SBB jsou dva alternativní názvy téhož prvku
- [ ] ABB patří jen do Business Architecture, SBB jen do Technology Architecture
- [x] ABB určují, co je potřeba, a SBB tyto požadavky konkrétně naplňují

> ABB jsou vodítkem pro vývoj SBB; každý SBB má naplnit požadavky příslušných ABB. Oba typy bloků existují ve všech architektonických doménách.

### ? Architekt v Phase C popisuje, že firma potřebuje „komponentu pro správu dokumentů s verzováním a rozhraním pro vyhledávání", ale produkt zatím vybírat nechce. Co tím vytváří?

- [x] Architecture Building Block (ABB)
- [ ] Solution Building Block (SBB)
- [ ] Architecture Contract
- [ ] Pracovní balík (work package)

> Popis potřebné funkcionality a rozhraní bez vazby na produkt je ABB. SBB by vznikl až s výběrem konkrétního řešení; Architecture Contract a work package patří do pozdějších fází.

## Stavební bloky v průběhu ADM {#bb-v-adm .explain}

Stavební bloky se během ADM postupně zpřesňují. V Phase A se budoucí řešení popisuje jen na vysoké úrovni. V Phases B, C a D se pro jednotlivé domény definují ABB a analýzou mezer se zjišťuje, které bloky už existují, které je nutné vytvořit a které zaniknou. V Phase E se hledají řešení – SBB – která požadavky naplní, přednostně znovupoužitím existujících; Phases F a G pak řeší jejich nasazení a soulad s architekturou. Hledání hotových bloků v Architecture Repository šetří čas i peníze a zvyšuje konzistenci.

*Příklad:* Při návrhu nového zákaznického portálu architekt zjistí, že v repozitáři už je popsán blok „Správa identit" i se schváleným produktem, a místo nového návrhu ho znovu použije.

### ? Ve kterých fázích ADM se primárně definují Architecture Building Blocks (ABB) pro jednotlivé domény?

- [ ] Preliminary Phase a Phase A
- [x] Phases B, C a D
- [ ] Phases G a H
- [ ] Jen v Requirements Management

> ABB pro business, datovou, aplikační a technologickou doménu vznikají při vývoji architektur v Phases B, C a D. Phase A pracuje jen na vysoké úrovni a Phases G a H se týkají implementace a změn.

### ? Proč má architekt při vývoji architektury nejprve hledat existující stavební bloky v Architecture Repository?

- [ ] Protože nové stavební bloky smí navrhovat jen Architecture Board
- [ ] Protože TOGAF navrhování nových stavebních bloků zakazuje
- [x] Znovupoužití šetří náklady a zvyšuje konzistenci napříč projekty
- [ ] Protože u existujících bloků se nedělá analýza mezer

> Znovupoužití hotových a ověřených bloků zrychluje práci a sjednocuje řešení. Nové bloky navrhovat lze a analýza mezer se dělá vždy.

## Katalog (Catalog) {#katalog .term}

Katalog je artefakt, který je seznamem stavebních bloků jednoho typu nebo několika souvisejících typů, často s jejich vlastnostmi (vlastník, stav, verze). Slouží jako evidence a jako podklad pro kontrolu úplnosti a analýzu dopadu. Příklady: Principles Catalog, Application Portfolio Catalog, Technology Standards Catalog, Requirements Catalog.

### ? Architekt sestaví seznam všech aplikací firmy s jejich vlastníky a stavem životního cyklu. O jakou kategorii obsahu jde?

- [x] Artefakt typu katalog
- [ ] Výstup typu dokument
- [ ] Stavební blok řešení (SBB)
- [ ] Artefakt typu matice

> Seznam prvků jednoho typu s atributy je katalog. Matice by ukazovala vztahy mezi dvěma typy prvků a výstup by takový katalog teprve obsahoval.

### ? Architekt potřebuje evidovat technologie schválené v organizaci jako standard, např. podporované operační systémy a databáze. Který artefakt k tomu slouží?

- [ ] Application/Technology Matrix
- [ ] Environments and Locations Diagram
- [ ] Platform Decomposition Diagram
- [x] Technology Standards Catalog

> Evidence schválených technologických standardů je katalog – Technology Standards Catalog. Matice ukazuje, které aplikace běží na kterých technologiích, a diagramy znázorňují prostředí a skladbu platformy.

## Matice (Matrix) {#matice .term}

Matice je artefakt, který zobrazuje vztahy mezi dvěma (případně více) typy stavebních bloků ve formě mřížky: řádky odpovídají jednomu typu, sloupce druhému a buňky vyjadřují vztah. Hodí se pro rychlou analýzu dopadu a pro hledání chybějících nebo nadbytečných vazeb. Příklady: Application/Organization Matrix, Data Entity/Business Function Matrix, Application/Technology Matrix.

### ? Co znázorňuje matice (matrix) jako artefakt?

- [ ] Seznam prvků jednoho typu s jejich vlastnostmi
- [x] Vztahy mezi dvěma typy prvků v podobě mřížky
- [ ] Grafický pohled na průběh procesu v čase
- [ ] Formální dohodu mezi architekty a implementátory

> Matice ukazuje vztahy mezi typy prvků (např. aplikace × útvary). Seznam je katalog, grafika je diagram a formální dohodou je Architecture Contract.

### ? Architekt chce zjistit, které organizační útvary používají kterou aplikaci, aby posoudil dopad plánované odstávky. Který artefakt je nejvhodnější?

- [ ] Application Portfolio Catalog
- [ ] Organization Decomposition Diagram
- [x] Application/Organization Matrix
- [ ] Technology Standards Catalog

> Vztah „aplikace × útvar" zachycuje Application/Organization Matrix. Katalog aplikací ani rozpad organizace samy vazbu mezi oběma typy nezobrazují a technologické standardy s otázkou nesouvisejí.

## Diagram {#diagram .term}

Diagram je artefakt, který zobrazuje stavební bloky a vztahy mezi nimi graficky. Je nejvhodnější pro komunikaci se stakeholdery, protože srozumitelně ukazuje souvislosti; pro úplnou evidenci prvků se hodí méně. Příklady: Value Chain Diagram, Solution Concept Diagram, Business Footprint Diagram, Application Communication Diagram, Environments and Locations Diagram.

### ? K čemu se diagramy jako artefakty hodí nejvíce?

- [x] Ke srozumitelné komunikaci architektury se stakeholdery
- [ ] K úplné evidenci všech prvků jednoho typu
- [ ] K formálnímu podpisu výstupů ze strany sponzora projektu
- [ ] K evidenci výsledků revizí souladu s architekturou

> Diagramy vizuálně ukazují souvislosti, a proto slouží hlavně ke komunikaci. Úplnou evidenci poskytují katalogy a podpis se týká výstupů, ne artefaktů.

### ? V Phase A potřebuje architekt sponzorovi na jedné stránce ukázat, jak bude navrhované řešení vypadat na vysoké úrovni. Který artefakt je k tomu určen?

- [ ] Requirements Catalog
- [ ] Application/Data Matrix
- [ ] Interface Catalog
- [x] Solution Concept Diagram

> Solution Concept Diagram je přehledový diagram řešení na vysoké úrovni, typický pro Phase A. Katalogy a matice jsou podrobné podklady, které pro sponzora v této fázi nejsou vhodné.

## Katalog × matice × diagram {#katalog-matice-diagram .compare}

|  | Katalog (catalog) | Matice (matrix) | Diagram (diagram) |
|---|---|---|---|
| Co ukazuje | seznam prvků jednoho typu a jejich vlastnosti | vztahy mezi dvěma typy prvků | prvky a vztahy graficky |
| Podoba | seznam / tabulka | mřížka (řádky × sloupce) | obrázek |
| Hlavní použití | evidence, kontrola úplnosti | analýza dopadu, hledání chybějících vazeb | komunikace se stakeholdery |
| Příklad | Application Portfolio Catalog | Application/Organization Matrix | Application Communication Diagram |

### ? Architekt má pro datovou architekturu tři artefakty: seznam datových entit, mřížku „datová entita × business funkce" a obrázek toků dat mezi systémy. Jak je v uvedeném pořadí správně zařadí?

- [ ] Matice – katalog – diagram
- [x] Katalog – matice – diagram
- [ ] Katalog – diagram – matice
- [ ] Diagram – matice – katalog

> Seznam je katalog, mřížka vztahů je matice a obrázek je diagram.

### ? Jaký je typický přínos katalogů a matic ve srovnání s diagramy?

- [ ] Jsou srozumitelnější pro vrcholové vedení než obrázky
- [ ] Na rozdíl od diagramů se nemusí ukládat do repozitáře
- [ ] Nahrazují formální schválení výstupů stakeholdery
- [x] Dávají úplná a strukturovaná data pro analýzu

> Katalogy a matice evidují prvky a vazby úplně, takže umožňují analýzu úplnosti a dopadu; diagramy stejná data vizuálně komunikují. Do repozitáře patří všechny artefakty a schválení se týká výstupů.

## Příklady artefaktů podle fází ADM {#artefakty-podle-fazi .compare}

Výběr typických artefaktů (není to úplný seznam):

| Fáze | Katalogy | Matice | Diagramy |
|---|---|---|---|
| Preliminary Phase | Principles Catalog | – | – |
| Phase A | – | Stakeholder Map Matrix | Value Chain Diagram, Solution Concept Diagram |
| Phase B | Organization/Actor Catalog, Business Service/Function Catalog | Business Interaction Matrix, Actor/Role Matrix | Business Footprint Diagram, Functional Decomposition Diagram |
| Phase C – Data | Data Entity/Data Component Catalog | Data Entity/Business Function Matrix | Conceptual Data Diagram, Logical Data Diagram |
| Phase C – Application | Application Portfolio Catalog, Interface Catalog | Application/Organization Matrix, Application Interaction Matrix | Application Communication Diagram |
| Phase D | Technology Standards Catalog, Technology Portfolio Catalog | Application/Technology Matrix | Environments and Locations Diagram, Platform Decomposition Diagram |
| Phase E | – | – | Project Context Diagram, Benefits Diagram |
| Requirements Management | Requirements Catalog | – | – |

### ? Ve které fázi ADM se typicky vytváří Application Portfolio Catalog?

- [ ] Phase B (Business Architecture)
- [ ] Phase D (Technology Architecture)
- [x] Phase C (Information Systems Architectures)
- [ ] Phase E (Opportunities and Solutions)

> Katalog aplikačního portfolia popisuje aplikační architekturu, která je součástí Phase C. Phase B popisuje business, Phase D technologie a Phase E řešení a projekty.

### ? Který artefakt patří typicky do Preliminary Phase?

- [x] Principles Catalog
- [ ] Application Communication Diagram
- [ ] Project Context Diagram
- [ ] Technology Portfolio Catalog

> V Preliminary Phase se stanovují architektonické principy, které eviduje Principles Catalog. Aplikační diagram patří do Phase C, Project Context Diagram do Phase E a Technology Portfolio Catalog do Phase D.

### ? Který artefakt se typicky vytváří v Phase D (Technology Architecture)?

- [ ] Business Footprint Diagram
- [ ] Data Entity/Business Function Matrix
- [ ] Value Chain Diagram
- [x] Environments and Locations Diagram

> Environments and Locations Diagram ukazuje, ve kterých prostředích a lokalitách běží technologie – to je Phase D. Business Footprint Diagram patří do Phase B, matice datových entit do Phase C a Value Chain Diagram do Phase A.

## Artefakty a pohledy (views) {#artefakty-a-pohledy .explain}

Artefakty jsou stavebním materiálem pro pohledy (views) na architekturu. Hledisko (viewpoint) určuje, které zájmy (concerns) určité skupiny stakeholderů se mají pokrýt a jakými typy artefaktů; pohled je pak konkrétní výsledek pro danou architekturu. Jeden artefakt se může objevit v několika pohledech pro různé stakeholdery, a proto se vyplatí ho evidovat jednou v repozitáři a znovu používat.

*Příklad:* Pro finančního ředitele se sestaví pohled na náklady aplikační krajiny z Application Portfolio Catalog a Application/Organization Matrix; pro bezpečnostního manažera pohled s diagramem toků citlivých dat.

### ? Jaký je vztah mezi artefakty a pohledy (views) na architekturu?

- [ ] Pohled je formální výstup, který artefakty zcela nahrazuje
- [ ] Artefakt se sestavuje z pohledů podle zvoleného stakeholdera
- [x] Pohled se sestavuje z artefaktů podle zvoleného hlediska
- [ ] Pohledy a artefakty spolu nesouvisejí, slouží různým fázím

> Hledisko (viewpoint) určuje, jaké artefakty pokrývají zájmy stakeholderů, a pohled (view) se z nich skládá. Vztah tedy nejde opačně a artefakty nenahrazuje.

## Metamodel obsahu (Content Metamodel) {#content-metamodel .term}

Content Metamodel formálně definuje typy entit, ze kterých se architektura skládá (např. aktér, business služba, aplikační komponenta, datová entita), jejich atributy a povolené vztahy mezi nimi. Díky tomu jsou katalogy, matice a diagramy vzájemně konzistentní, obsah lze spravovat v nástroji a sledovat vazby napříč doménami. Metamodel má jádro, které lze podle potřeb organizace rozšiřovat.

### ? Co definuje Content Metamodel v TOGAF?

- [ ] Pořadí kroků v jednotlivých fázích ADM
- [x] Typy entit architektury a vztahy mezi nimi
- [ ] Úrovně zralosti architektonické kapability
- [ ] Rozpočet a harmonogram architektonického projektu

> Metamodel obsahu určuje, jaké entity architektura obsahuje a jak spolu smí souviset. Kroky fází popisuje ADM a zralost kapability je samostatné téma.

### ? Proč je pro práci v architektonickém nástroji důležitý formální metamodel obsahu?

- [x] Prvky a vazby se zapisují jednotně a dají se dohledávat
- [ ] Umožní vynechat schvalování výstupů stakeholdery
- [ ] Nahradí analýzu mezer mezi Baseline a Target Architecture
- [ ] Sám určí, které projekty se zařadí do Architecture Roadmap

> Jednotně definované entity a vztahy umožňují konzistentní evidenci, generování katalogů a matic a dohledání vazeb. Schvalování, analýzu mezer ani plánování metamodel nenahrazuje.

## Hlavní entity metamodelu (přehled) {#core-entity .compare}

Přehled typických entit podle oblastí metamodelu (zjednodušeno, ne úplný seznam):

| Oblast | Příklady entit |
|---|---|
| Motivace (Business Architecture) | Driver, Goal, Objective, Measure |
| Principy, vize, požadavky | Principle, Requirement, Constraint, Assumption, Gap |
| Business Architecture (organizace a chování) | Actor, Role, Organization Unit, Function, Process, Business Service |
| Data Architecture | Data Entity, Logical Data Component, Physical Data Component |
| Application Architecture | Logical Application Component, Physical Application Component |
| Technology Architecture | Logical Technology Component, Physical Technology Component |
| Realizace architektury | Capability, Work Package |

### ? Který typ entity metamodelu patří do oblasti Business Architecture?

- [ ] Physical Technology Component
- [ ] Logical Data Component
- [x] Actor
- [ ] Logical Application Component

> Actor (osoba, organizace nebo systém, který má roli v business činnostech) patří do Business Architecture. Ostatní entity patří do technologické, datové a aplikační architektury.

### ? Která entita metamodelu zachycuje podnět (např. novou regulaci nebo tlak konkurence), kvůli kterému si organizace stanovuje cíle?

- [x] Driver
- [ ] Physical Application Component
- [ ] Data Entity
- [ ] Organization Unit

> Driver je motivační entita – podnět, ze kterého vycházejí cíle (Goal) organizace. Ostatní entity popisují aplikace, data a organizační strukturu.

## Logická × fyzická komponenta {#logicka-fyzicka .compare}

Metamodel u dat, aplikací i technologií rozlišuje logické a fyzické komponenty:

|  | Logická komponenta (Logical … Component) | Fyzická komponenta (Physical … Component) |
|---|---|---|
| Co popisuje | potřebnou skupinu funkcí či dat | konkrétní implementaci, nasazení |
| Vazba na produkt | nezávislá na produktu a technologii | konkrétní produkt, verze, instance |
| Stabilita | mění se málo | mění se s technologiemi a dodavateli |
| Příklad | „systém pro řízení skladu" | konkrétní WMS produkt nasazený v datovém centru |

### ? Jaký je rozdíl mezi Logical Application Component a Physical Application Component?

- [ ] Logická je už nasazená aplikace, fyzická je teprve záměr
- [x] Logická je nezávislá na produktu, fyzická je konkrétní implementace
- [ ] Logická patří do Phase D, fyzická do Phase B
- [ ] Fyzická popisuje jen hardware, logická jen software

> Logická komponenta popisuje potřebnou funkcionalitu bez vazby na produkt, fyzická komponenta její konkrétní realizaci. Obě patří k aplikační architektuře (Phase C) a obě se týkají softwaru.

### ? Jako jakou entitu metamodelu lze zařadit „konkrétní instanci systému pro řízení skladu nasazenou v datovém centru v Brně"?

- [ ] Logical Application Component
- [ ] Business Service
- [ ] Data Entity
- [x] Physical Application Component

> Konkrétní nasazená instance aplikace je fyzická aplikační komponenta. Logická komponenta by popisovala jen potřebnou funkcionalitu skladového systému bez vazby na produkt a instanci.
