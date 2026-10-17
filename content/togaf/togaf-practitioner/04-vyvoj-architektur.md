---
kind: topic
subject: togaf-practitioner
slug: vyvoj-architektur
name: "Vývoj architektur B–D ve scénářích"
order: 4
---

Výběr artefaktů a technik pro Business, Data, Application a Technology Architecture, Gap Analysis, práce s požadavky a s Building Blocks.

## Jak v praxi postupovat ve fázích B, C a D {#postup-bcd .explain}

Phase B, Phase C i Phase D mají stejnou kostru kroků: výběr referenčních modelů, hledisek (viewpoints) a nástrojů → popis Baseline → popis Target → Gap Analysis → kandidátní komponenty Architecture Roadmap → vyřešení dopadů napříč Architecture Landscape → formální revize se stakeholdery → finalizace → doplnění Architecture Definition Document. Architekt tedy nezačíná kreslením modelů, ale rozhodnutím, **jaká hlediska a artefakty** odpoví na zájmy stakeholderů zjištěné ve Phase A. Kandidátní komponenty roadmapy vznikají už v každé doméně; Phase E je pak jen konsoliduje do pracovních balíků. Hloubku každého kroku určuje rozsah a cíl ze Statement of Architecture Work.

*Příklad:* Ve Phase D si tým nejdřív podle Stakeholder Map vybere, že provoz potřebuje pohled na prostředí a lokality a finance přehled portfolia technologií — teprve potom začne popisovat výchozí stav.

### ? Pojišťovna zahájila Phase C (Application Architecture). Phase A schválila Architecture Vision a Stakeholder Map, kde mají vedení obchodu, provoz IT a bezpečnost odlišné zájmy. Nově přidělený architekt chce okamžitě začít detailně modelovat všech 300 aplikací. Co je nejlepší první krok?

- [ ] Detailně zinventarizovat všech 300 aplikací, aby byl výchozí stav úplný
- [x] Vybrat referenční modely, hlediska a nástroje podle zájmů stakeholderů
- [ ] Navrhnout cílové produkty, které nahradí nejstarší aplikace
- [ ] Sestavit Implementation and Migration Plan pro výměnu aplikací

> Společný postup fází B–D začíná volbou referenčních modelů, viewpointů a nástrojů — ty určí, co a jak podrobně se má modelovat. Plošná inventura bez cíle plýtvá úsilím, volba produktů patří do Phase E a Implementation and Migration Plan do Phase F.

### ? Výrobní firma je ve Phase D. Tým popsal Baseline i Target Technology Architecture a v Gap Analysis zjistil, že stávající úložná platforma nevyhoví cílovým požadavkům na výkon. Sponzor se ptá, co se s tímto zjištěním ve Phase D udělá. Jaká je nejlepší odpověď?

- [ ] Hned se založí implementační projekt a uzavře Architecture Contract
- [ ] Zjištění se odloží a otevře se až při tvorbě plánu ve Phase F
- [ ] Zjištění se zapíše jako výjimka do Governance Log a dál neřeší
- [x] Z mezery se definuje kandidátní komponenta Architecture Roadmap

> Každá z fází B–D z mezer odvozuje kandidátní komponenty roadmapy, které Phase E konsoliduje do work packages. Založení projektu a Architecture Contract je předčasné (Phase E–G), odklad do Phase F by přeskočil konsolidaci v E a zápis výjimky mezeru neřeší.

## Baseline First × Target First {#baseline-target-first .compare}

Pořadí popisu výchozí a cílové architektury se volí podle situace; Baseline se popisuje jen tak podrobně, jak je potřeba pro Gap Analysis a plánování přechodu.

| | Baseline First | Target First |
|---|---|---|
| Kdy zvolit | současný stav je složitý, nepřehledný nebo sporný; útvary mají velkou autonomii | cíl je na vysoké úrovni dohodnutý a podnik chce efektivně přejít k novému modelu |
| Smysl | z analýzy současnosti najít problémy a příležitosti ke zlepšení | nejdřív navrhnout cíl, pak ho zpětně porovnat se současností |
| Riziko | uvíznout v dokumentování současnosti bez jasného směru | podcenění skutečné složitosti přechodu |
| Hloubka Baseline | větší — slouží k hledání problémů | menší — stačí pro identifikaci mezer |

### ? Banka se 40 let starými systémy chce zlepšit zpracování úvěrů. Pobočková síť, call centrum a online kanál si historicky vytvořily vlastní procesy a nikdo nemá úplný obraz o tom, jak úvěr skutečně probíhá. Útvary se ani neshodnou, kde jsou hlavní problémy. Jaký přístup k vývoji Business Architecture je nejvhodnější?

- [ ] Target First, protože cílový stav je pro sponzora důležitější
- [ ] Target First s Baseline popsanou jen na nejvyšší úrovni
- [x] Baseline First, protože současný stav je nejasný a sporný
- [ ] Přeskočit Baseline a rovnou provést Gap Analysis s cílem

> Baseline First se hodí, když je současný stav složitý, neprozkoumaný a útvary se na něm neshodnou — analýza Baseline odhalí problémy a příležitosti. Target First předpokládá na vysoké úrovni dohodnutý cíl, který tu chybí, a Gap Analysis bez Baseline nelze provést.

### ? Pojišťovna zakládá zcela novou digitální značku a cílová architektura se od dnešních procesů radikálně liší. Vedení už cílový model na vysoké úrovni schválilo. Současné prostředí je malé, dobře zdokumentované a všichni se na něm shodnou. Tým navrhuje strávit tři měsíce detailním popisem Baseline ve stejné hloubce jako Target. Co by měl architekt doporučit?

- [x] Postupovat Target First a Baseline popsat jen pro potřeby Gap Analysis
- [ ] Popsat Baseline ve stejné hloubce, protože TOGAF to vyžaduje v každém projektu
- [ ] Baseline vynechat úplně, protože cílový stav je zcela nový
- [ ] Nejdřív popsat Baseline a podle ní teprve vybrat stakeholdery

> Cílový model je na vysoké úrovni schválený a současnost dobře známá, proto je vhodný Target First a Baseline stačí jen v rozsahu potřebném pro identifikaci mezer. Stejná hloubka není povinná, úplné vynechání Baseline by znemožnilo Gap Analysis a stakeholdeři jsou známi už z Phase A.

### ? Architekt ve Phase B postupuje Target First. Jaké riziko tohoto přístupu by měl aktivně řídit?

- [ ] Cílová architektura bude jen mírně vylepšenou kopií současného stavu
- [ ] Stakeholdeři nebudou moci posoudit cílovou architekturu
- [ ] Gap Analysis nebude možné vůbec provést
- [x] Podcenění skutečné složitosti a nákladů přechodu ze současnosti

> Při Target First se Baseline popisuje méně podrobně, takže hrozí, že se přehlédne, jak náročný bude přechod. Vylepšená kopie současnosti rizikem Target First není, protože ten vychází z cíle; stakeholdeři cíl posuzují při formální revizi a Gap Analysis lze provést, jen s jednodušší Baseline.

## Pořadí Data a Application ve Phase C {#poradi-faze-c .explain}

Phase C zahrnuje Data Architecture i Application Architecture a TOGAF je dovoluje vyvíjet **v libovolném pořadí nebo souběžně** — volba závisí na povaze změny a dostupných lidech. Při souběžném vývoji je třeba průběžně sladit obě domény, typicky přes Application/Data matrix. Vývoj B, C a D navíc nemusí být striktně lineární: když pozdější fáze odhalí chybný předpoklad z dřívější, je správné se k ní vrátit (iterace Architecture Definition) místo stavění na chybném základu.

*Příklad:* Tým pro výměnu ERP pracuje na datech a aplikacích souběžně a jednou týdně společně revidují matici, která aplikace vytváří a čte které datové entity.

### ? Telekomunikační firma je pod časovým tlakem a má pro Phase C dva samostatné týmy — datový a aplikační. Architekt navrhuje vyvíjet Data a Application Architecture souběžně. Vedoucí programu namítá, že TOGAF vyžaduje začít daty. Jak má architekt reagovat?

- [ ] Ustoupit a začít daty, protože TOGAF pořadí domén ve Phase C předepisuje
- [ ] Začít aplikacemi, protože data z nich plynou automaticky
- [ ] Odložit Data Architecture až do Phase D spolu s technologií
- [x] Vysvětlit, že pořadí je volné, a obě domény sladit přes matici

> TOGAF dovoluje vyvíjet Data a Application Architecture v libovolném pořadí i souběžně; podmínkou je jejich průběžné sladění, např. přes Application/Data matrix. Žádné pevné pořadí předepsáno není a Data Architecture do Phase D nepatří.

### ? Logistická firma je ve Phase D. Při návrhu cílové technologie se ukáže, že předpoklad z Phase B — centralizované plánování přeprav v jednom místě — neplatí, protože regulace vyžaduje plánování v každé zemi. Co je nejlepší další krok?

- [x] Vrátit se k Business Architecture a předpoklad v ní opravit
- [ ] Dokončit Phase D podle původního předpokladu a opravit to v Phase H
- [ ] Vyřešit problém jen technicky, bez zásahu do Business Architecture
- [ ] Předat rozpor implementačním týmům k vyřešení ve Phase G

> ADM je iterativní: chybný předpoklad z dřívější fáze se opraví návratem do ní, jinak by na něm stály všechny další domény. Dokončení na chybném základu, čistě technická záplata nebo přenesení problému na implementaci vedou k nekonzistentní architektuře.

## Artefakty Business Architecture podle situace {#artefakty-business .compare}

Ve Phase B se nevytváří všechno — vybírají se artefakty, které odpoví na konkrétní zájmy stakeholderů.

| Situace / otázka stakeholdera | Vhodný artefakt |
|---|---|
| Vedení chce na jednom obrázku vidět vazbu cílů na útvary, funkce a podpůrné systémy | Business Footprint diagram |
| Stabilní přehled toho, co podnik dělá, nezávisle na organizační struktuře | Business Capability Map, Functional Decomposition diagram |
| Jak podnik doručuje hodnotu stakeholderovi od začátku do konce | Value Stream Map |
| Kdo jsou aktéři a jaké role hrají | Organization/Actor catalog, Actor/Role matrix |
| Přesný sled kroků procesu včetně událostí a rozhodnutí | Process Flow diagram |
| Závislosti a interakce mezi útvary či funkcemi | Business Interaction matrix |
| Jak se mění stav produktu během jeho životního cyklu | Product Lifecycle diagram |

### ? Představenstvo strojírenské skupiny schvaluje transformační program. Generální ředitel chce na jedné stránce vidět, jak strategické cíle souvisejí s organizačními útvary, obchodními funkcemi a systémy, které je podporují. Detaily procesů ho nezajímají. Který artefakt je nejvhodnější?

- [ ] Process Flow diagram
- [x] Business Footprint diagram
- [ ] Application Communication diagram
- [ ] Organization/Actor catalog

> Business Footprint diagram propojuje cíle, útvary, funkce a podpůrné technické komponenty na jedné úrovni pro vedení. Process Flow je pro detailní procesy, Application Communication diagram ukazuje vazby aplikací a katalog aktérů je jen seznam bez vazby na cíle.

### ? Pojišťovna chce automatizovat likvidaci pojistných událostí. Analytici a vývojáři potřebují přesně vidět, v jakém pořadí jdou jednotlivé kroky, které události je spouštějí a kde se proces větví podle rozhodnutí. Který artefakt Business Architecture jim nejlépe poslouží?

- [ ] Functional Decomposition diagram
- [ ] Business Capability Map
- [ ] Business Interaction matrix
- [x] Process Flow diagram

> Process Flow diagram zachycuje sled kroků, spouštěcí události a rozhodovací body procesu. Functional Decomposition a Business Capability Map ukazují, co podnik dělá, ne v jakém pořadí; Business Interaction matrix ukazuje vztahy mezi útvary.

### ? Po reorganizaci obchodní firmy se změnilo, kdo vykonává které činnosti, a personální útvar potřebuje přehled, které organizační jednotky a osoby zastávají jaké role. Výstup má sloužit i jako podklad pro pozdější nastavení přístupových práv. Co je nejvhodnější vytvořit ve Phase B?

- [x] Organization/Actor catalog a Actor/Role matrix
- [ ] Value Stream Map pro hlavní zákaznické toky
- [ ] Product Lifecycle diagram pro hlavní produkty
- [ ] Technology Standards catalog pro systémy

> Katalog aktérů a matice Actor/Role přímo popisují, kdo zastává jaké role, a jsou podkladem pro práva. Value Stream Map ukazuje tok hodnoty, Product Lifecycle diagram stavy produktu a Technology Standards catalog patří do Phase D.

## Business capabilities a value streams v praxi {#capability-value-stream .explain}

Business capability popisuje, **co** podnik umí dělat, nezávisle na tom, kdo to dělá a jak; value stream ukazuje, **jak** se postupně vytváří hodnota pro konkrétního stakeholdera. V praxi se kombinují: mapa schopností obarvená podle výkonnosti nebo strategické důležitosti ukáže, kam investovat; Value Stream/Capability matrix ukáže, které schopnosti podporují jednotlivé fáze toku hodnoty; Capability/Organization matrix odhalí duplicitní schopnosti v různých útvarech (typicky po fúzi) a Strategy/Capability matrix propojí strategii se schopnostmi. Mapa schopností se proto **neodvozuje od organizační struktury** — ta se mění častěji než schopnosti.

*Příklad:* Po fúzi dvou bank matice schopností a útvarů ukáže, že „Řízení úvěrového rizika" vykonávají tři útvary, a ty se stanou kandidátem na konsolidaci.

### ? Dvě regionální banky se sloučily. Vedení chce zjistit, které obchodní schopnosti jsou dnes zajišťovány duplicitně v různých útvarech obou bank, aby mohlo rozhodnout o jejich konsolidaci. Který artefakt Business Architecture tomu nejlépe odpovídá?

- [ ] Process Flow diagram pro všechny procesy obou bank
- [ ] Organization Decomposition diagram nové banky
- [x] Capability/Organization matrix obou bank
- [ ] Application Portfolio catalog obou bank

> Matice schopností a útvarů nad sjednocenou mapou schopností přímo ukáže, které schopnosti zajišťuje více útvarů. Procesní diagramy jsou zbytečně detailní, rozklad organizace neukazuje schopnosti a portfolio aplikací patří do Phase C a mluví o systémech.

### ? E-shop chce zrychlit proces „od registrace zákazníka po první objednávku", který má pět fází. Vedení potřebuje vědět, které obchodní schopnosti jednotlivé fáze podporují, aby mohlo zacílit investice na ty nejslabší. Co je nejvhodnější použít?

- [x] Value Stream Map s Value Stream/Capability matrix
- [ ] Business Interaction matrix mezi útvary e-shopu
- [ ] Data Lifecycle diagram zákaznických dat
- [ ] Actor/Role matrix pro zaměstnance zákaznické podpory

> Value stream popisuje fáze toku hodnoty a matice Value Stream/Capability k nim přiřadí podporující schopnosti — to je přesně podklad pro cílení investic. Ostatní artefakty řeší vztahy útvarů, životní cyklus dat nebo role, ne vazbu fází na schopnosti.

### ? Při tvorbě Business Capability Map navrhne manažer, aby schopnosti odpovídaly jednotlivým oddělením z aktuálního organizačního schématu, protože „to lidé znají". Firma přitom plánuje reorganizaci. Jak má architekt reagovat?

- [ ] Souhlasit, protože schopnosti mají kopírovat organizační strukturu
- [ ] Souhlasit a po reorganizaci mapu schopností celou znovu překreslit
- [ ] Nahradit mapu schopností organizačním schématem
- [x] Definovat schopnosti nezávisle na útvarech a útvary k nim mapovat

> Schopnosti popisují, co podnik dělá, a mají být stabilní i při změně organizace; útvary se k nim přiřazují např. maticí Capability/Organization. Kopie organizační struktury by po reorganizaci ztratila smysl a schéma útvarů schopnosti neukazuje.

## Artefakty Data Architecture podle situace {#artefakty-data .compare}

| Situace / otázka stakeholdera | Vhodný artefakt |
|---|---|
| Hlavní datové entity a jejich vztahy srozumitelně pro byznys | Conceptual Data diagram |
| Podrobnější logický model pro návrháře | Logical Data diagram |
| Kde jsou data uložena, kam se replikují a který systém je zdrojem | Data Dissemination diagram |
| Kdo a odkud smí ke kterým datům přistupovat (ochrana osobních údajů) | Data Security diagram |
| Přesun dat ze starých systémů do nových včetně čištění a transformace | Data Migration diagram |
| Stavy datové entity od vzniku po archivaci a výmaz | Data Lifecycle diagram |
| Které obchodní funkce data vytvářejí, čtou a mění | Data Entity/Business Function matrix |
| Soupis datových entit a komponent, kde jsou uloženy | Data Entity/Data Component catalog |

### ? Zdravotní pojišťovna se připravuje na audit ochrany osobních údajů. Auditor chce doložit, které role a které aplikace mají přístup k citlivým údajům o pojištěncích a z jakých míst. Který artefakt Data Architecture je nejvhodnější?

- [ ] Data Migration diagram
- [ ] Conceptual Data diagram
- [ ] Data Lifecycle diagram
- [x] Data Security diagram

> Data Security diagram ukazuje, kdo (aktéři, role, aplikace) a odkud přistupuje k jakým datům. Migrační diagram řeší přesun dat, konceptuální model vztahy entit a životní cyklus stavy dat od vzniku po výmaz.

### ? Leasingová společnost musí podle nové regulace uchovávat smluvní data deset let po skončení smlouvy, pak je archivovat mimo provozní systém a nakonec prokazatelně smazat. Architekt potřebuje ukázat, jak se smlouva jako datová entita mění v čase. Který artefakt je nejvhodnější?

- [ ] Data Dissemination diagram
- [x] Data Lifecycle diagram
- [ ] Logical Data diagram
- [ ] Data Entity/Data Component catalog

> Data Lifecycle diagram zachycuje stavy datové entity od vzniku přes archivaci po výmaz — přesně požadavky na uchovávání. Dissemination diagram ukazuje rozmístění dat v systémech, logický model strukturu a katalog jen soupis entit.

### ? Retailová firma má zákaznická data v pěti aplikacích a každá je částečně mění. Nikdo neví, který systém je zdrojem pravdy a kam se data kopírují, a reporty si proto odporují. Který artefakt Data Architecture pomůže situaci nejlépe popsat?

- [x] Data Dissemination diagram
- [ ] Data Security diagram
- [ ] Data Lifecycle diagram
- [ ] Conceptual Data diagram

> Data Dissemination diagram ukazuje, ve kterých aplikacích jsou data uložena, odkud se šíří a který systém je hlavním zdrojem. Bezpečnostní diagram řeší přístupy, životní cyklus stavy dat a konceptuální model jen entity a vztahy bez umístění.

## Artefakty Application Architecture podle situace {#artefakty-aplikace .compare}

| Situace / otázka stakeholdera | Vhodný artefakt |
|---|---|
| Soupis aplikací jako základ racionalizace portfolia | Application Portfolio catalog |
| Soupis rozhraní mezi aplikacemi | Interface catalog |
| Které aplikace podporují které obchodní funkce (duplicity, nepokryté funkce) | Application/Function matrix |
| Které role používají které aplikace (licence, školení, přístupy) | Role/Application matrix |
| Jak spolu aplikace komunikují a jaké toky mezi nimi jdou | Application Communication diagram |
| Kde jsou uživatelé a aplikace geograficky umístěni | Application and User Location diagram |
| Jak jednotlivé kroky procesu realizují aplikace | Process/Application Realization diagram |
| Jak se aplikace přesunou z výchozího do cílového stavu | Application Migration diagram |

### ? Pojišťovna po sérii akvizic provozuje 450 aplikací a CIO chce snížit náklady. Potřebuje zjistit, které obchodní funkce jsou podporovány více aplikacemi současně a které naopak nemají podporu žádnou. Který artefakt je nejvhodnější?

- [ ] Application Communication diagram
- [ ] Role/Application matrix
- [x] Application/Function matrix
- [ ] Application and User Location diagram

> Matice aplikací a funkcí přímo ukáže duplicitně podporované i nepokryté funkce, což je jádro racionalizace. Komunikační diagram řeší toky mezi aplikacemi, matice rolí licence a přístupy a lokační diagram geografii.

### ? Banka nahrazuje zastaralou integrační sběrnici. Než architekt navrhne cílové řešení, potřebuje mít přehled o všech tocích dat mezi aplikacemi, jejich směru a o tom, přes jaká rozhraní jdou. Co je nejvhodnější vytvořit?

- [ ] Application Portfolio catalog a Role/Application matrix
- [ ] Process Flow diagram a Business Interaction matrix
- [ ] Application/Function matrix a Data Lifecycle diagram
- [x] Application Communication diagram a Interface catalog

> Komunikační diagram aplikací ukazuje toky mezi aplikacemi a katalog rozhraní jejich soupis — obojí je podklad pro náhradu sběrnice. Ostatní kombinace popisují portfolio a role, procesy a útvary, nebo podporu funkcí a stavy dat.

### ? Výrobní firma zavádí nový systém plánování výroby pro závody v Česku, Mexiku a Číně. Provoz se obává odezvy pro uživatele ve vzdálených závodech a potřebuje vidět, kde jsou uživatelé a kde budou aplikace hostovány. Který artefakt Application Architecture je nejvhodnější?

- [x] Application and User Location diagram
- [ ] Process/Application Realization diagram
- [ ] Application Migration diagram
- [ ] Interface catalog

> Diagram umístění aplikací a uživatelů ukazuje, kde uživatelé pracují a kde aplikace běží — základ pro posouzení odezvy. Realizační diagram váže procesy na aplikace, migrační diagram přechod do cílového stavu a katalog rozhraní jen soupis vazeb.

## Artefakty Technology Architecture podle situace {#artefakty-technologie .compare}

| Situace / otázka stakeholdera | Vhodný artefakt |
|---|---|
| Které technologie a standardy jsou v podniku schválené | Technology Standards catalog |
| Jaké technologie skutečně používáme a ve kterých verzích | Technology Portfolio catalog |
| Které aplikace běží na kterých platformách | Application/Technology matrix |
| Která prostředí (vývoj, test, produkce) a kde jsou hostována | Environments and Locations diagram |
| Přehled platformních služeb a komponent, které podporují aplikace | Platform Decomposition diagram |
| Nasaditelné jednotky a jejich zpracování | Processing diagram |
| Fyzický hardware a jeho propojení | Networked Computing/Hardware diagram |

### ? Firma do roka opouští vlastní datové centrum a servery se budou postupně vypínat. Plánovač potřebuje vědět, které aplikace jsou na kterých serverech a platformách závislé, aby vypnutí nic nerozbilo. Který artefakt je nejvhodnější?

- [ ] Technology Standards catalog
- [x] Application/Technology matrix
- [ ] Platform Decomposition diagram
- [ ] Application Portfolio catalog

> Matice aplikací a technologií ukazuje, která aplikace běží na které platformě, a tedy dopad vypnutí serverů. Katalog standardů říká, co je povoleno, rozklad platformy ukazuje služby bez vazby na konkrétní aplikace a portfolio aplikací neobsahuje infrastrukturu.

### ? Výrobci operačního systému za 18 měsíců končí podpora verze, kterou firma používá. Architekt potřebuje zjistit, kde všude se tato verze a související middleware v podniku používají. Co je nejvhodnější použít jako výchozí podklad?

- [ ] Technology Standards catalog
- [ ] Environments and Locations diagram
- [x] Technology Portfolio catalog
- [ ] Processing diagram

> Technology Portfolio catalog je soupis technologií, které se v podniku skutečně používají, včetně verzí. Katalog standardů ukazuje, co je schválené, ne kde se co reálně používá; diagram prostředí a lokalit a Processing diagram neposkytují úplný soupis verzí.

### ? Firma přesouvá systémy do veřejného cloudu a právní oddělení vyžaduje, aby produkční data zůstala v EU, zatímco vývojové a testovací prostředí mohou být jinde. Architekt potřebuje stakeholderům ukázat, které prostředí bude hostováno v jaké lokalitě. Který artefakt je nejvhodnější?

- [x] Environments and Locations diagram
- [ ] Networked Computing/Hardware diagram
- [ ] Application/Technology matrix
- [ ] Technology Standards catalog

> Diagram prostředí a lokalit ukazuje, kde jsou jednotlivá prostředí (vývoj, test, produkce) hostována. Hardwarový diagram řeší fyzické propojení, matice aplikací a technologií vazbu na platformy a katalog standardů schválené technologie.

## Gap Analysis v praxi: matice a její výklad {#gap-matice .explain}

Matice Gap Analysis má v řádcích stavební bloky výchozí architektury, ve sloupcích stavební bloky cílové, navíc řádek „nové" a sloupec „vyřazené". Blok přítomný v obou stavech je **zachovaný**. Blok z Baseline, který v Target chybí, je nutné **prověřit**: buď byl vyřazen záměrně (zapíše se jako vyřazený), nebo byl omylem vynechán a musí se do cílové architektury vrátit. Blok z Target, který v Baseline není, je **mezera k vyplnění** — vývojem nebo pořízením. Výsledné mezery se stávají podkladem pro kandidátní komponenty Architecture Roadmap.

*Příklad:* Služba „Objednávky faxem" chybí v cílovém stavu; po ověření s obchodem jde o záměrné vyřazení, takže se zapíše jako vyřazená a do roadmapy se doplní ukončení provozu.

### ? V matici Gap Analysis pro Application Architecture se ukáže, že služba „Ruční korekce faktur" z výchozího stavu v cílové architektuře chybí. Nikdo z týmu neví, zda ji někdo vědomě vyřadil. Co má architekt udělat?

- [ ] Automaticky ji označit jako vyřazenou, protože v cílovém stavu chybí
- [x] Prověřit se stakeholdery, zda jde o záměr, a případně službu vrátit
- [ ] Ponechat rozhodnutí na implementačním týmu ve Phase G
- [ ] Označit ji jako novou mezeru, kterou je nutné pořídit

> Blok, který chybí v cílovém stavu, se musí prověřit — může jít o záměrné vyřazení, nebo o nechtěné opomenutí, které se musí opravit v cílové architektuře. Automatické vyřazení riskuje ztrátu potřebné funkce, odklad do Phase G je pozdě a „nová mezera" je pojem pro bloky chybějící v Baseline.

### ? Cílová architektura banky obsahuje službu „Online skóring podvodů v reálném čase", kterou dnes banka vůbec nemá. Jak se tato skutečnost v matici Gap Analysis zachází a co z ní plyne?

- [ ] Je to zachovaný blok, který se jen přenese do cílového stavu
- [ ] Je to chyba v Baseline, kterou je nutné doplnit zpětně
- [x] Je to mezera k vyplnění a podklad pro Architecture Roadmap
- [ ] Je to vyřazený blok, který stačí zapsat do Governance Log

> Blok přítomný jen v cílové architektuře je mezera, kterou je nutné zaplnit vývojem nebo nákupem; promítne se do kandidátních komponent Architecture Roadmap. Nejde o zachovaný ani vyřazený blok a Baseline popisuje skutečný stav, takže chybou není.

## Na co se v Gap Analysis dívat kromě funkcí {#gap-zdroje .explain}

Gap Analysis neporovnává jen seznamy aplikací nebo funkcí. V Business Architecture se hledají mezery i v **lidech, procesech, nástrojích, informacích, měření výkonnosti, financích a zařízeních**. V Data Architecture jde o data, která nejsou k dispozici, nejsou aktuální, nejsou tam, kde jsou potřeba, nikdo je nevytváří nebo nespotřebovává, či mají chybné vztahy. V Application a Technology Architecture se sleduje, co je dotčeno, co zaniká a co vzniká. Smyslem je zachytit vše, co musí změna řešit, ne jen technologii.

*Příklad:* Nový CRM pokrývá všechny funkce, ale Gap Analysis odhalí, že prodejci nemají odpovídající dovednosti a jejich KPI motivují k opačnému chování — vzniknou mezery „lidé" a „měření".

### ? Distributor zavedl nový systém pro zákaznickou podporu, který funkčně pokryl vše, co Gap Analysis v Application Architecture požadovala. Po spuštění se ale ukázalo, že operátoři nebyli proškoleni a jejich výkon se dál měřil podle starých ukazatelů, které nový způsob práce penalizovaly. Co v Gap Analysis chybělo?

- [ ] Detailnější porovnání funkcí starého a nového systému
- [ ] Porovnání verzí technologií a platforem ve výchozím i cílovém stavu systému
- [ ] Důkladnější prověření vyřazených aplikačních služeb
- [x] Posouzení mezer v lidech a měření výkonnosti v Business Architecture

> Gap Analysis v Business Architecture má zahrnout i mezery v lidech, procesech, nástrojích, informacích, měření, financích a zařízeních. Funkce systému byly pokryté, takže detailnější porovnání funkcí, technologií nebo vyřazených služeb by problém s dovednostmi a KPI neodhalilo.

### ? Cílová Business Architecture pojišťovny předpokládá, že upisovatel uvidí při rozhodování aktuální škodní historii klienta. Data o škodách se ale dnes přenášejí do upisovacího systému jen jednou týdně dávkou. Jaký typ mezery tím architekt zjistil?

- [x] Datovou mezeru — data nejsou aktuální tam, kde jsou potřeba
- [ ] Organizační mezeru — upisovatelé nemají potřebnou roli
- [ ] Finanční mezeru — chybí rozpočet na upisovací systém
- [ ] Žádnou mezeru — data v podniku existují, takže jsou k dispozici

> Data o škodách existují, ale v místě rozhodování nejsou aktuální; to je typická datová mezera. Nejde o chybějící roli ani rozpočet a pouhá existence dat v podniku nestačí, pokud nejsou včas tam, kde se s nimi pracuje.

## Building Blocks ve fázích B–D {#bb-ve-fazich-bcd .explain}

Ve fázích B–D se architektura popisuje převážně pomocí **ABB** — stavebních bloků, které vymezují požadovanou funkčnost, rozhraní a vlastnosti (např. dostupnost, bezpečnost) bez vazby na konkrétní produkt. Konkrétní produkty a řešení (**SBB**) se vybírají až při hledání řešení ve Phase E, kdy se posuzují alternativy, náklady a dodavatelé. Tlak na předčasnou volbu produktu architekt řeší tak, že požadavky zachytí jako vlastnosti ABB, a produkt uvede jen tehdy, je-li opravdu omezením (např. schválený podnikový standard nebo již uzavřená smlouva) — a pak ho jako omezení výslovně zapíše.

*Příklad:* Místo „cílově použijeme produkt X" stojí v Application Architecture blok „Správa zákaznických kontaktů" s požadavky na integraci, dostupnost a ochranu osobních údajů.

### ? Ve Phase C (Application Architecture) obchodní ředitel trvá na tom, aby cílová architektura rovnou uváděla konkrétní CRM produkt, který viděl na konferenci. Žádný podnikový standard ani smlouva tento produkt nepředepisují. Jak má architekt postupovat?

- [ ] Produkt do cílové architektury zapsat, protože si to přeje sponzor
- [ ] Zahájit výběrové řízení na CRM ještě před koncem Phase C
- [x] Popsat potřebu jako ABB a výběr produktu ponechat na Phase E
- [ ] Odmítnout CRM řešit, protože jde o technologii pro Phase D

> Ve fázích B–D se popisují ABB nezávislé na produktu; konkrétní SBB se vybírá ve Phase E při posouzení alternativ. Zapsání produktu bez opodstatnění i předčasné výběrové řízení obchází tento postup a CRM jako aplikační blok do Phase D nepatří.

### ? Architekt ve Phase D popisuje cílový stavební blok „Platforma pro správu identit". Který popis je pro tuto fázi nejvhodnější?

- [ ] Název produktu, verze a cena licencí od vybraného dodavatele
- [x] Požadovaná funkčnost, rozhraní a vlastnosti, např. dostupnost a bezpečnost
- [ ] Harmonogram nasazení po jednotlivých pobočkách
- [ ] Seznam projektů, které platformu budou implementovat

> Ve fázích B–D se stavební blok popisuje jako ABB — co má umět, jaká má rozhraní a vlastnosti, bez vazby na produkt. Produkt a cena patří k SBB ve Phase E, harmonogram a projekty do plánování přechodu ve Phase E a F.

## Architecture Definition Document × Architecture Requirements Specification {#add-vs-ars .compare}

Oba výstupy vznikají a doplňují se ve fázích B–D a jdou ruku v ruce; liší se tím, k čemu slouží.

| | Architecture Definition Document | Architecture Requirements Specification |
|---|---|---|
| Povaha | kvalitativní — popisuje a vysvětluje architekturu | kvantitativní — stanoví, co musí řešení měřitelně splnit |
| Typický obsah | výchozí a cílová architektura domén, zdůvodnění rozhodnutí, výsledky Gap Analysis, posouzení dopadů | měřítka úspěchu, architektonické požadavky, požadavky na interoperabilitu, omezení, předpoklady, kontrakty služeb, implementační pokyny a standardy |
| Kdo to využije | stakeholdeři, kteří potřebují architekturu pochopit a schválit | návrháři a implementátoři, kteří musí doložit soulad |

### ? Provozní ředitel požaduje, aby cílové řešení platebních služeb odpovídalo do 2 sekund u 95 % transakcí a bylo dostupné 99,9 % času. Architekt ve Phase C zvažuje, kam tento požadavek zapsat. Kam patří nejlépe?

- [ ] Do Architecture Vision jako obecný cíl transformace
- [ ] Do Statement of Architecture Work jako součást rozsahu
- [ ] Do Architecture Definition Document jako zdůvodnění cílové architektury
- [x] Do Architecture Requirements Specification jako měřitelný požadavek

> Architecture Requirements Specification obsahuje kvantitativní, měřitelné požadavky, podle kterých se později ověřuje soulad implementace. ADD architekturu popisuje a zdůvodňuje, Architecture Vision je vysokoúrovňový obraz z Phase A a Statement of Architecture Work vymezuje projekt.

### ? Architektonický tým se rozhodl pro centrální integrační platformu místo přímých vazeb mezi aplikacemi. Vedení chce pochopit, proč bylo zvoleno právě toto řešení a jaké mezery oproti dnešku řeší. Ve kterém výstupu má být tato informace?

- [x] V Architecture Definition Document
- [ ] V Architecture Requirements Specification
- [ ] V Architecture Contract
- [ ] V Request for Architecture Work

> ADD je kvalitativní popis architektury včetně zdůvodnění rozhodnutí a výsledků Gap Analysis. ARS obsahuje měřitelné požadavky, Architecture Contract je dohoda o realizaci (Phase G) a Request for Architecture Work spouští celý cyklus.

### ? Dodavatel, který bude ve Phase G implementovat nové řešení, se ptá, podle jakého dokumentu bude jeho řešení posuzováno — které parametry, standardy a omezení musí doložitelně splnit. Na který výstup z fází B–D ho má architekt odkázat jako na hlavní zdroj?

- [ ] Architecture Definition Document
- [x] Architecture Requirements Specification
- [ ] Architecture Vision
- [ ] Business Footprint diagram

> Měřitelné požadavky, standardy, omezení a implementační pokyny, podle kterých se ověřuje soulad, shrnuje Architecture Requirements Specification. ADD vysvětluje architekturu, Architecture Vision je vysokoúrovňová a Business Footprint diagram je jen jeden artefakt Phase B.

## Nové požadavky během fází B–D {#pozadavky-v-bcd .explain}

Ve fázích B–D se běžně objevují nové nebo změněné požadavky. Architekt je nezapracuje potichu, ale předá do procesu Requirements Management (zapíší se do Architecture Requirements Repository), posoudí jejich dopad na právě vyvíjenou i dříve dokončené domény a promítne je do Architecture Requirements Specification. Pokud požadavek **přesahuje rozsah Statement of Architecture Work** (jiné útvary, výrazně jiný cíl, termín či rozpočet), musí se o změně rozsahu rozhodnout se sponzorem — tedy upravit Statement of Architecture Work, ne rozšiřovat práci bez souhlasu. Protichůdné požadavky se řeší se stakeholdery a rozhodnutí se dokumentuje.

*Příklad:* Během Phase D přijde nařízení, že data klientů musí zůstat v EU; architekt požadavek zaregistruje, posoudí dopad na už hotovou Data Architecture a upraví ji.

### ? Pojišťovna je ve Phase D. Právní oddělení oznámí novou regulaci, podle které musí osobní údaje klientů zůstat fyzicky v EU. Data Architecture z Phase C s tímto požadavkem nepočítala. Co je nejlepší další krok?

- [x] Zaregistrovat požadavek a posoudit jeho dopad i na Phase C
- [ ] Řešit požadavek jen v technologii, Data Architecture neměnit
- [ ] Dokončit Phase D a požadavek předat do Phase H jako budoucí změnu
- [ ] Zastavit vývoj architektury, dokud regulace nenabude účinnosti

> Nové požadavky se předávají do Requirements Management a posuzuje se jejich dopad na všechny dotčené fáze, včetně těch dokončených. Řešení jen v technologii by nechalo nekonzistentní Data Architecture, odklad do Phase H ignoruje známý požadavek a zastavení práce je zbytečné.

### ? Během Phase B požádá ředitel jiné divize, aby architektura „když už se to dělá" zahrnula i jeho divizi, která ve Statement of Architecture Work není. Znamenalo by to zhruba dvojnásobný rozsah práce. Jak má architekt postupovat?

- [ ] Divizi do práce zahrnout, protože širší rozsah přinese podniku větší hodnotu
- [ ] Žádost odmítnout, protože rozsah po Phase A nelze nikdy měnit
- [x] Projednat se sponzorem změnu rozsahu ve Statement of Architecture Work
- [ ] Divizi zahrnout jen neformálně a do výstupů ji neuvádět

> Změna rozsahu nad rámec Statement of Architecture Work se musí schválit se sponzorem a promítnout do upraveného dokumentu. Tiché rozšíření ohrožuje termín i rozpočet, rozsah naopak změnit lze a neformální práce mimo výstupy porušuje governance.

## Vyřešení dopadů napříč Architecture Landscape {#dopady-na-krajinu .explain}

Před dokončením domény architekt prověří, jak navržená architektura ovlivní **ostatní architektury a projekty** v podniku: zda nekoliduje s jinými segmenty, nestaví duplicitní řešení, nezneplatní předpoklady jiných iniciativ a zda nelze naopak něco převzít. Podkladem je Architecture Repository (zejména Architecture Landscape) a komunikace s architekty jiných iniciativ. Konflikty se řeší dřív, než se architektura předloží ke schválení.

*Příklad:* Cílová Data Architecture navrhuje nový zákaznický registr; prověrka ukáže, že jiný program staví vlastní, a oba týmy se dohodnou na jednom sdíleném řešení.

### ? Ve Phase C architekt programu „Digitální kanály" navrhuje nový centrální registr zákazníků. Mezitím jiný program v téže firmě, „Věrnostní systém", buduje vlastní zákaznickou databázi. Architekt se to dozvěděl náhodou na chodbě. Co je nejlepší další krok?

- [ ] Pokračovat podle plánu, protože jiný program není v rozsahu
- [ ] Požádat druhý program o zastavení, protože centrální registr je důležitější
- [ ] Zapsat duplicitu jako riziko a řešit ji až po implementaci
- [x] Koordinovat řešení s druhým programem v rámci Architecture Landscape

> Krok vyřešení dopadů napříč Architecture Landscape slouží právě k odhalení překryvů a konfliktů s jinými architekturami a k dohodě na společném či znovupoužitém řešení. Ignorování duplicity, jednostranný požadavek na zastavení nebo odklad po implementaci vedou ke zbytečným nákladům.

## Alternativy, formální revize a finalizace {#revize-a-alternativy .explain}

Když existuje víc rozumných cílových variant, architekt je nevybírá sám: popíše alternativy, porovná je podle kritérií odvozených z principů, požadavků a rizik (náklady, přínosy, dopad na stakeholdery) a rozhodnutí nechá na odpovědných stakeholderech; zvolenou variantu a důvody zapíše do Architecture Definition Document. Formální revize se stakeholdery ověřuje, zda architektura odpovídá **původní motivaci projektu a Statement of Architecture Work** a zda řeší jejich zájmy. Finalizace pak dotáhne dokumentaci stavebních bloků, standardy a provázání s požadavky.

*Příklad:* Pro systém pojistných smluv se porovná SaaS a vlastní vývoj podle souladu s principem „nakupuj před vývojem", nákladů na 5 let a rizika uzamčení u dodavatele.

### ? Ve Phase C existují dvě proveditelné cílové varianty — SaaS řešení a úprava stávajícího interního systému. Finanční ředitel preferuje SaaS kvůli nákladům, ředitel provozu interní systém kvůli kontrole nad daty. Co má architekt udělat?

- [ ] Vybrat variantu sám podle vlastní odborné zkušenosti
- [x] Porovnat varianty a předložit je stakeholderům k rozhodnutí
- [ ] Rozpracovat obě varianty až do implementace a rozhodnout pak
- [ ] Zvolit SaaS, protože finanční argument má vždy přednost

> Alternativy se porovnají podle kritérií z principů, požadavků a rizik a rozhodnou o nich odpovědní stakeholdeři; důvod volby se zapíše do ADD. Samostatné rozhodnutí architekta obchází stakeholdery, souběžná implementace je plýtvání a automatická přednost financí ignoruje ostatní zájmy.

### ? Business Architecture logistické firmy je téměř hotová a architekt připravuje formální revizi se stakeholdery. Vůči čemu má revize architekturu především posoudit?

- [ ] Vůči nabídkám dodavatelů, kteří se o projekt ucházejí
- [ ] Vůči architektuře, kterou loni použil hlavní konkurent
- [x] Vůči původní motivaci projektu a Statement of Architecture Work
- [ ] Vůči harmonogramu implementace z Implementation and Migration Plan

> Formální revize ověřuje, zda architektura plní původní účel projektu, rozsah ve Statement of Architecture Work a zájmy stakeholderů. Nabídky dodavatelů patří do Phase E, konkurenční architektura není závazným měřítkem a Implementation and Migration Plan v tu chvíli ještě neexistuje (vzniká ve Phase F).

## Požadavky na interoperabilitu při návrhu domén {#interoperabilita-v-domenach .explain}

Interoperabilitu je vhodné řešit už při vývoji domén, ne až při integraci. Rozlišuje se rovina **obchodní (operational / business)** — sladění procesů a pravidel mezi organizacemi, **informační** — společný význam a struktura sdílených informací, a **technická** — propojení systémů a technologií. Požadavky se identifikují a zpřesňují ve fázích A–D a dále upřesňují ve Phase E a zapisují se do Architecture Requirements Specification. Typickou chybou je vyřešit jen technické spojení a zapomenout na sjednocení významu dat.

*Příklad:* Dva sloučené úřady propojí systémy přes API, ale každý kóduje typ žadatele jinak; teprve společný datový slovník v Data Architecture zajistí, že si systémy opravdu rozumí.

### ? Dvě nemocnice po sloučení propojily své systémy přes zabezpečené rozhraní a přenos zpráv funguje bez chyb. Lékaři si ale stěžují, že diagnózy a léky se v druhé nemocnici zobrazují s jiným významem, protože každá používá vlastní číselníky. Jak má architekt problém nejlépe řešit?

- [ ] Posílit síťovou infrastrukturu mezi nemocnicemi
- [ ] Nasadit rychlejší integrační platformu s vyšší propustností a nižší latencí
- [ ] Sloučit obě nemocnice do jedné organizační struktury
- [x] Definovat společné datové definice a číselníky v Data Architecture

> Technická interoperabilita už funguje; problém je v informační interoperabilitě — sdílená data nemají stejný význam. Řeší ji společné datové definice v Data Architecture, ne silnější síť, rychlejší platforma ani reorganizace.
