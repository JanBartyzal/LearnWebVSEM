---
kind: topic
subject: ict-strategie
slug: business-intelligence-a-dimenzionalni-modelovani
name: "Business Intelligence a dimenzionální modelování"
order: 10
---

Projektování a využití aplikací Business Intelligence, tj. aplikací a programových nástrojů pro podporu rozhodování ve firmě realizaci firemních analýz a plánů na bázi speciálně organizovaných a připravených informačních zdrojů. Principy dimenzionálního modelování, analýza a návrh požadavků na extrakce a transformace dat, řešení problematiky kvality dat a jejího řízení. Metodologie řešení úloh Business Intelligence, rozlišení koncepcí Kimbal, Inmon, hlavní orientace na přírůstkové postupy.

## Business Intelligence (BI) {#business-intelligence .term}

Soubor přístupů, aplikací a technologií IS/ICT, které podporují **analytické, plánovací a rozhodovací činnosti** firmy. Nepracují přímo nad transakčními daty, ale nad **speciálně připravenými a integrovanými daty** (typicky v datovém skladu) a jsou postaveny na principu **multidimenzionality** — pohledu na ukazatele podle více dimenzí současně (čas, produkt, region, zákazník…).

### ? Která činnost je typickým úkolem aplikace Business Intelligence?

- [ ] Zaúčtování přijaté faktury dodavatele do hlavní knihy účetnictví
- [x] Analýza marže podle produktů, regionů a měsíců
- [ ] Vystavení dodacího listu a výdejky při expedici zboží zákazníkovi
- [ ] Rezervace zasedací místnosti v kalendáři

> BI slouží k analýzám a podpoře rozhodování nad připravenými daty, typicky pohledem podle více dimenzí. Zaúčtování faktury nebo vystavení dodacího listu jsou transakční operace provozních systémů.

### ? Na jakých datech BI aplikace typicky pracují?

- [ ] Výhradně na datech, která analytici ručně zadávají do tabulek
- [ ] Přímo na tabulkách produkčního ERP během zpracování transakcí
- [ ] Na datech získávaných v reálném čase jen z externích zdrojů
- [x] Na integrovaných datech připravených z více zdrojů

> Podstatou BI je práce nad speciálně organizovanými a připravenými daty — vyčištěnými, integrovanými z více zdrojů a uloženými pro analýzy, nejčastěji v datovém skladu.

## Architektura BI {#architektura-bi .explain}

Architektura BI popisuje cestu dat od vzniku po rozhodnutí. **Zdrojové systémy** (ERP, CRM, e-shop, externí data) poskytují data, která **ETL** procesy extrahují, transformují a čistí; data přitom procházejí **dočasným úložištěm** (data staging area). Integrovaná data se ukládají do **datového skladu** (DWH) a z něj do tematických **datových tržišť** (data marts). Nad uloženými daty pracují analytické nástroje — **OLAP**, **reporting**, **dashboardy** a **data mining**. Celou architekturu prochází **metadata** (popis zdrojů, transformací a významu ukazatelů).

*Příklad:* Obchodní firma denně stahuje prodeje z pokladen a e-shopu, v noci je ETL sjednotí a uloží do skladu a ráno vedení vidí aktuální dashboard tržeb.

### ? Ve kterém pořadí typicky procházejí data architekturou BI?

- [ ] Datové tržiště → ETL → zdrojový systém → reporting
- [ ] Reporting → datový sklad → ETL → zdrojový systém
- [x] Zdrojový systém → ETL → datový sklad → datové tržiště → reporting
- [ ] Zdrojový systém → reporting → ETL → datový sklad

> Data vznikají ve zdrojových systémech, ETL je přenese a upraví do datového skladu, z něj se plní datová tržiště a nad nimi pracují analytické a reportingové nástroje.

### ? Která součást NEPATŘÍ do vrstvy analytických nástrojů BI?

- [ ] Interaktivní OLAP analýzy nad kostkami
- [ ] Manažerské dashboardy s klíčovými ukazateli
- [ ] Data mining
- [x] Dočasné úložiště (staging)

> Dočasné úložiště je součástí vrstvy přípravy a ukládání dat — slouží ETL procesům. OLAP, dashboardy a data mining jsou nástroje pro analýzu a prezentaci dat.

## ETL (Extract, Transform, Load) {#etl .explain}

ETL je proces, který data **extrahuje** ze zdrojových systémů, **transformuje** je (čištění, sjednocení kódů a formátů, převody jednotek, odvozování ukazatelů, agregace) a **nahrává** do datového skladu. Bývá nejpracnější částí BI projektu. Návrh ETL začíná **analýzou požadavků**: které zdroje a tabulky se použijí, jak se pole mapují na cílový model, jak často se data načítají (denně, hodinově, téměř online), zda se načítá vše, nebo jen změny (přírůstkové načítání), a jak se ošetří chybné záznamy. Varianta **ELT** nejprve data nahraje a transformuje je až v cílové databázi.

*Příklad:* Dva zdrojové systémy kódují pohlaví jako „M/Ž" a „1/2" — transformace je převede na jednotné hodnoty, aby šly v reportu sčítat dohromady.

### ? Firma slučuje zákazníky z CRM a z e-shopu, přičemž oba systémy používají jiné kódy zemí. Ve které fázi ETL se kódy sjednotí?

- [x] Transformace
- [ ] Extrakce
- [ ] Nahrání (load)
- [ ] Prezentace

> Sjednocení kódů, čištění a převody formátů jsou úkolem transformace. Extrakce data jen získává ze zdrojů a nahrání je ukládá do cíle.

### ? Čím se liší přístup ELT od klasického ETL?

- [ ] ELT vynechává extrakci a pracuje přímo se zdrojovými systémy
- [ ] ELT data pouze extrahuje a nikdy je netransformuje
- [x] ELT data nejdřív nahraje do cíle a transformuje až tam
- [ ] ELT transformuje data již ve zdrojovém systému před extrakcí

> Při ELT se surová data nejprve nahrají do cílového úložiště a transformace probíhají až ve výkonné cílové databázi. Transformace se tedy neruší, jen se mění pořadí kroků.

### ? Datový sklad se každou noc plní jen záznamy, které od posledního běhu ve zdroji vznikly nebo se změnily. Jak se tento způsob načítání nazývá?

- [ ] Úplné načítání všech tabulek
- [x] Přírůstkové (inkrementální) načítání
- [ ] Ruční načítání
- [ ] Zpětné načítání

> Přírůstkové načítání přenáší jen nové a změněné záznamy, takže je rychlejší a méně zatěžuje zdroje. Úplné načítání by pokaždé přeneslo všechna data znovu.

## Dočasné úložiště a ODS {#staging-a-ods .compare}

Mezi zdroji a datovým skladem se používají pomocná úložiště, která mají odlišný účel.

| | Dočasné úložiště (data staging area, DSA) | Operativní úložiště dat (operational data store, ODS) |
|---|---|---|
| Účel | mezikrok ETL — odložení extrahovaných dat před transformací | integrovaná aktuální data pro operativní reporting |
| Uživatelé | jen ETL procesy, ne koncoví uživatelé | i koncoví uživatelé (operativní dotazy) |
| Historie | zpravidla žádná, obsah se po zpracování maže | malá, data se průběžně aktualizují |
| Aktuálnost | podle běhu ETL | vysoká, blízko provozním systémům |

### ? Do kterého úložiště se odkládají surová data vyextrahovaná ze zdrojů, aby je ETL mohlo dál zpracovat, a které koncoví uživatelé nepoužívají?

- [ ] Tematické datové tržiště
- [ ] Operativní úložiště dat (ODS)
- [ ] Předpočítaná OLAP kostka
- [x] Staging area

> Dočasné úložiště je technický mezikrok ETL, kde se data připravují před transformací; po zpracování se obvykle maže. ODS naopak slouží uživatelům k operativnímu reportingu nad aktuálními daty.

## Datový sklad (data warehouse, DWH) {#datovy-sklad .term}

Centrální úložiště integrovaných dat pro analýzy a rozhodování. Podle W. H. Inmona je datový sklad **subjektově orientovaný** (podle oblastí jako zákazník, produkt, prodej), **integrovaný** (sjednocené kódy a formáty z různých zdrojů), **časově proměnný** (uchovává historii a data jsou vztažena k času) a **stálý** (non-volatile — data se nahrávají a čtou, ale běžně se nemění ani nemažou).

### ? Data o prodejích se v datovém skladu po nahrání už nepřepisují ani nemažou, pouze se čtou a přidávají nová. Kterou vlastnost datového skladu to popisuje?

- [ ] Subjektovou orientaci podle oblastí
- [x] Stálost (non-volatile)
- [ ] Integrovanost
- [ ] Normalizaci

> Stálost znamená, že data se do skladu nahrávají a čtou, ale běžnými transakcemi se nemění. Integrovanost se týká sjednocení dat z různých zdrojů, subjektová orientace členění podle oblastí.

### ? Čím se datový sklad typicky liší od databáze transakčního systému?

- [x] Drží dlouhou historii a slouží hlavně ke čtení a analýzám
- [ ] Je optimalizován pro velké množství drobných souběžných zápisů v reálném čase
- [ ] Obsahuje vždy jen aktuální stav bez historie
- [ ] Slouží k pořizování dokladů obsluhou na pokladnách

> Datový sklad drží historická integrovaná data a je určen pro čtení a analýzy. Rychlé drobné zápisy a aktuální stav jsou doménou transakčních (OLTP) databází.

## Datové tržiště (data mart) {#datove-trziste .term}

Menší, **tematicky zaměřené úložiště** dat pro určitý útvar nebo oblast (prodej, finance, logistika). **Závislé** datové tržiště se plní z centrálního datového skladu, **nezávislé** vzniká přímo ze zdrojových systémů bez centrálního skladu — hrozí u něj nekonzistence mezi tržišti („různé verze pravdy").

### ? Marketing si nechal postavit vlastní datové tržiště plněné přímo z CRM a finance jiné přímo z ERP, bez společného skladu. Jaké riziko tím vzniká?

- [ ] Data nebude možné vůbec analyzovat podle času
- [ ] Tržiště nebudou moci obsahovat agregovaná data
- [x] Stejné ukazatele mohou v obou tržištích vycházet různě
- [ ] Tržiště bude nutné normalizovat do 3NF

> Nezávislá tržiště vznikají odděleně, s vlastními definicemi a transformacemi, a proto mohou ukazovat odlišná čísla pro tentýž ukazatel. Proti tomu se bojuje centrálním skladem nebo sdílenými (konformními) dimenzemi.

## Fakta a dimenze {#fakta-a-dimenze .explain}

Dimenzionální model dělí data na **fakta** a **dimenze**. **Tabulka faktů** obsahuje měřitelné číselné hodnoty (**ukazatele, míry** — tržba, množství, počet) a cizí klíče na dimenze. **Tabulky dimenzí** obsahují popisný kontext, podle něhož se fakta filtrují a seskupují (čas, produkt, zákazník, prodejna) — atributy jako název, kategorie, město. Dimenze mají obvykle vlastní umělý **náhradní klíč** (surrogate key), nezávislý na klíčích zdrojových systémů. Ukazatele mohou být **aditivní** (sčítatelné přes všechny dimenze, např. tržba), **semiaditivní** (nesčítatelné přes čas, např. zůstatek na účtu či stav zásob) a **neaditivní** (např. procento marže či jednotková cena).

*Příklad:* Fakt „prodej" nese množství a tržbu; dimenze říkají, kdy, co, komu a v jaké prodejně se prodalo.

### ? V modelu prodejů je údaj „kategorie výrobku (elektro, potraviny, drogerie)". Jde o fakt, nebo o dimenzi?

- [ ] O fakt, protože se podle něj počítají tržby
- [ ] O aditivní ukazatel v tabulce faktů
- [ ] O semiaditivní ukazatel v tabulce faktů
- [x] O atribut dimenze Produkt

> Kategorie výrobku je popisný údaj, podle kterého se fakta seskupují a filtrují — patří tedy do dimenze Produkt. Fakty jsou měřitelné číselné hodnoty jako tržba či množství.

### ? Banka eviduje měsíční zůstatky na účtech. Jaký typ ukazatele je zůstatek?

- [ ] Aditivní — lze jej sčítat přes všechny dimenze včetně času
- [x] Semiaditivní — lze jej sčítat přes účty, ale ne přes čas
- [ ] Neaditivní — nelze jej sčítat přes žádnou dimenzi
- [ ] Nejde o ukazatel, ale o atribut dimenze

> Součet zůstatků všech účtů k jednomu dni dává smysl, ale sečíst zůstatky jednoho účtu za leden, únor a březen nedává smysl — zůstatek je stavová veličina, tedy semiaditivní ukazatel.

## Granularita a postup dimenzionálního návrhu {#granularita .explain}

**Granularita (grain)** určuje, co přesně představuje jeden řádek tabulky faktů — např. „jedna položka účtenky" nebo „denní souhrn prodejů produktu v prodejně". Jemnější granularita (vyšší detail; terminologie „nižší × vyšší" se v literatuře liší) umožňuje podrobnější analýzy, ale znamená více dat; z jemných dat lze agregovat, z hrubých se k detailu zpětně dostat nelze. R. Kimball doporučuje návrh ve **čtyřech krocích**: 1) zvolit obchodní proces, 2) určit granularitu, 3) určit dimenze, 4) určit fakta.

*Příklad:* Řetězec ukládá do skladu jen měsíční součty tržeb za prodejnu — pak už nezjistí, které výrobky se prodávají v pátek odpoledne.

### ? Tabulka faktů obsahuje řádek za každou položku na každé účtence. Jak se nazývá tato vlastnost modelu?

- [ ] Hierarchie
- [ ] Kardinalita dimenze
- [x] Granularita
- [ ] Konformita

> Granularita vymezuje, co představuje jeden řádek tabulky faktů — zde jedna položka účtenky, tedy velmi jemná úroveň detailu.

### ? Který krok je podle Kimballa v dimenzionálním návrhu PRVNÍ?

- [x] Zvolit obchodní proces
- [ ] Určit fakta (číselné ukazatele procesu)
- [ ] Určit dimenze
- [ ] Navrhnout OLAP kostku a předpočítané agregace

> Kimballův postup začíná výběrem obchodního procesu (např. prodej, objednávky), pak následuje granularita, dimenze a nakonec fakta.

## Hierarchie v dimenzích {#hierarchie .term}

Uspořádání atributů dimenze do **úrovní od podrobných po souhrnné**, např. den → měsíc → čtvrtletí → rok nebo prodejna → město → region → stát. Hierarchie určují, jak lze data agregovat a jak se v analýze pohybovat mezi úrovněmi detailu (drill-down, roll-up).

### ? Která posloupnost představuje hierarchii dimenze Čas od nejpodrobnější úrovně?

- [ ] Rok → čtvrtletí → měsíc → den
- [ ] Měsíc → den → rok → čtvrtletí
- [ ] Den → rok → měsíc → čtvrtletí
- [x] Den → měsíc → čtvrtletí → rok

> Hierarchie času vede od nejjemnější úrovně (den) přes měsíc a čtvrtletí k nejhrubší úrovni (rok); po těchto úrovních se pak data agregují.

## Hvězda × sněhová vločka {#hvezda-vs-vlocka .compare}

Dvě základní schémata dimenzionálního modelu v relační databázi; obě mají uprostřed tabulku faktů.

| | Schéma hvězdy (star schema) | Schéma sněhové vločky (snowflake schema) |
|---|---|---|
| Dimenze | jedna denormalizovaná tabulka na dimenzi | dimenze normalizované do více navazujících tabulek |
| Hierarchie | všechny úrovně v jedné tabulce (produkt, kategorie, skupina) | každá úroveň ve vlastní tabulce (produkt → kategorie → skupina) |
| Počet spojení (join) | malý, dotazy jsou jednodušší a rychlejší | větší, dotazy složitější |
| Redundance | vyšší (opakované názvy kategorií) | nižší, úspornější na místo |
| Srozumitelnost | vysoká, doporučuje Kimball | nižší |

### ? Dimenze Produkt je uložena ve třech tabulkách: Produkt odkazuje na Kategorii a Kategorie na Skupinu. O jaké schéma jde?

- [ ] Schéma hvězdy
- [x] Schéma sněhové vločky
- [ ] Normalizovaný transakční model
- [ ] Operativní úložiště dat

> Rozložení dimenze do více navazujících normalizovaných tabulek je znakem sněhové vločky. Ve hvězdě by produkt, kategorie i skupina byly v jedné tabulce dimenze.

### ? Jaká je hlavní výhoda schématu hvězdy oproti sněhové vločce?

- [ ] Nižší redundance dat v dimenzích
- [ ] Úplná normalizace všech tabulek
- [x] Méně spojení tabulek a jednodušší dotazy
- [ ] Více tabulek faktů v jednom modelu

> Denormalizované dimenze hvězdy vyžadují méně spojení, takže dotazy jsou jednodušší a obvykle rychlejší. Nižší redundance je naopak výhodou sněhové vločky.

## Pomalu se měnící dimenze (SCD) {#scd .compare}

Atributy dimenzí se v čase mění (zákazník se přestěhuje, produkt změní kategorii). Způsob ošetření změny určuje, zda zůstane zachována historie.

| Typ | Způsob ošetření změny | Historie |
|---|---|---|
| SCD 1 | stará hodnota se **přepíše** novou | žádná — vše se jeví, jako by platila vždy nová hodnota |
| SCD 2 | přidá se **nový řádek** s novým náhradním klíčem a obdobím platnosti (případně příznakem aktuálnosti) | úplná — stará fakta zůstávají u staré verze |
| SCD 3 | přidá se **nový sloupec** s předchozí hodnotou | omezená — jen aktuální a předchozí hodnota |

### ? Zákazník se přestěhoval z Brna do Prahy a firma chce, aby jeho dřívější nákupy zůstaly v reportech přiřazeny Brnu a nové Praze. Jaký typ SCD použije?

- [ ] SCD typ 1
- [ ] SCD typ 3
- [ ] Žádný, stačí změnit záznam v tabulce faktů
- [x] SCD typ 2

> SCD 2 vytvoří pro zákazníka nový řádek dimenze s novým náhradním klíčem; staré nákupy zůstanou navázány na verzi „Brno", nové na verzi „Praha". Uchovává tak úplnou historii.

### ? Ve firmě se opravuje překlep v názvu produktu a historii původního chybného názvu není třeba uchovávat. Který typ SCD je vhodný?

- [x] SCD typ 1
- [ ] SCD typ 2
- [ ] SCD typ 3
- [ ] Kombinace typů 2 a 3

> Při opravě chyby nemá stará hodnota žádnou informační hodnotu, proto stačí ji přepsat (SCD 1). Typy 2 a 3 by zbytečně uchovávaly chybnou historii.

### ? Co je charakteristické pro SCD typu 3?

- [ ] Každá změna vytvoří nový řádek dimenze s obdobím platnosti
- [x] Předchozí hodnota se uchová v dalším sloupci
- [ ] Stará hodnota se bez náhrady přepíše
- [ ] Změny se ukládají do tabulky faktů

> SCD 3 přidává sloupec pro předchozí hodnotu, takže uchovává jen omezenou historii (aktuální a předchozí stav). Nový řádek je princip SCD 2, přepis princip SCD 1.

## OLAP a multidimenzionální kostka {#olap-kostka .explain}

**OLAP (Online Analytical Processing)** je technologie pro rychlou interaktivní analýzu dat z více pohledů. Data si představujeme jako **multidimenzionální kostku** (datovou krychli): osy tvoří dimenze (čas, produkt, region), v buňkách jsou hodnoty ukazatelů (tržba, množství). Pro rychlé odpovědi se často **předpočítávají agregace** na vyšších úrovních hierarchií. Uživatel tak bez znalosti SQL přepíná pohledy, mění úroveň detailu a porovnává období.

*Příklad:* Obchodní ředitel v kostce prodejů rozkliká tržby za rok na čtvrtletí, pak vybere jen region Morava a srovná produktové skupiny.

### ? Co představuje buňka OLAP kostky s dimenzemi Čas, Produkt a Region?

- [ ] Jeden řádek zdrojové tabulky objednávek v ERP systému
- [ ] Popis atributu dimenze Produkt
- [x] Hodnotu ukazatele pro kombinaci období, produktu a regionu
- [ ] Definici transformace prováděné procesem ETL

> Osy kostky tvoří dimenze a každá buňka obsahuje hodnotu ukazatele (např. tržbu) pro jednu kombinaci členů dimenzí.

### ? Proč OLAP nástroje často předpočítávají agregace?

- [x] Aby souhrnné dotazy odpovídaly rychle
- [ ] Aby nebylo nutné uchovávat žádná detailní data
- [ ] Aby se data vůbec nemusela načítat ze zdrojových systémů
- [ ] Aby bylo možné data měnit přímo v kostce

> Předpočítané součty (např. za měsíce a regiony) zrychlují odpovědi na typické souhrnné dotazy. Detailní data se tím nenahrazují.

## OLAP operace {#olap-operace .compare}

Základní operace, kterými uživatel prochází multidimenzionální data.

| Operace | Co dělá | Příklad |
|---|---|---|
| Drill-down (rozpad do detailu) | přechod na podrobnější úroveň hierarchie | tržby za rok → za čtvrtletí |
| Roll-up (agregace, sbalení) | přechod na souhrnnější úroveň | tržby za prodejny → za regiony |
| Slice (řez) | pevná hodnota **jedné** dimenze | jen rok 2025 |
| Dice (výřez kostky) | omezení na vybrané hodnoty **více** dimenzí — podkostka | roky 2024–2025, regiony Čechy a Morava, jen elektro |
| Pivot (rotace) | záměna os pohledu | regiony z řádků do sloupců |

### ? Manažer vidí tržby za jednotlivé měsíce a chce je zobrazit souhrnně za čtvrtletí. Kterou operaci provede?

- [ ] Drill-down
- [x] Roll-up
- [ ] Slice
- [ ] Pivot

> Přechod z měsíců na čtvrtletí je posun na souhrnnější úroveň hierarchie času, tedy roll-up. Drill-down by vedl opačně, k větším detailům.

### ? Analytik z kostky Čas × Produkt × Region vybere pouze data za rok 2025 a ostatní dimenze ponechá celé. Jde o kterou operaci?

- [ ] Dice
- [ ] Roll-up
- [x] Slice
- [ ] Drill-down

> Slice zafixuje jednu hodnotu jedné dimenze a vytvoří „řez" kostkou. Dice by omezoval více dimenzí současně.

### ? Uživatel v reportu prohodí regiony z řádků do sloupců a produkty ze sloupců do řádků. Kterou OLAP operaci použil?

- [ ] Slice
- [ ] Dice
- [ ] Drill-down
- [x] Pivot

> Pivot (rotace) mění uspořádání os pohledu, aniž by měnil data nebo úroveň detailu.

## MOLAP × ROLAP × HOLAP {#molap-rolap-holap .compare}

Varianty OLAP se liší tím, kde a jak jsou data a agregace fyzicky uloženy.

| | MOLAP (multidimenzionální) | ROLAP (relační) | HOLAP (hybridní) |
|---|---|---|---|
| Uložení dat | ve speciálních multidimenzionálních strukturách | v relačních tabulkách (hvězda, vločka) | detail v relační DB, agregace v multidimenzionálních strukturách |
| Rychlost dotazů | velmi vysoká díky předpočítaným agregacím | nižší, dotazy se překládají do SQL | rychlé pro souhrny, pomalejší pro detail |
| Objem dat | omezenější, kostky mohou rychle růst | dobře škáluje i na velké objemy | kompromis |

### ? Firma má velmi velký objem detailních dat v relační databázi a chce nad nimi OLAP analýzy bez ukládání do speciálních kostek. Která varianta odpovídá?

- [x] ROLAP
- [ ] MOLAP
- [ ] HOLAP
- [ ] OLTP (transakční zpracování)

> ROLAP pracuje přímo nad relačními tabulkami a dobře škáluje na velké objemy. MOLAP data ukládá do speciálních multidimenzionálních struktur.

### ? Která varianta OLAP ukládá detailní data relačně a předpočítané agregace v multidimenzionálních strukturách?

- [ ] MOLAP
- [ ] ROLAP
- [x] HOLAP
- [ ] DOLAP (desktopový OLAP)

> HOLAP (hybridní OLAP) kombinuje oba přístupy: souhrnné dotazy obslouží rychle z multidimenzionálních agregací, pro detail sahá do relační databáze.

## Reporting a dashboardy {#reporting-a-dashboardy .term}

**Reporting** je tvorba a distribuce sestav — **standardních** (předem připravené, pravidelné, např. měsíční výsledovka) i **ad hoc** (sestavených uživatelem podle aktuální potřeby). **Dashboard** (manažerský přehled) zobrazuje na jedné obrazovce klíčové ukazatele (KPI) v grafické podobě, často s porovnáním proti plánu a s možností prokliku do detailu.

### ? Obchodní ředitel chce na jedné obrazovce vidět aktuální tržby, marži a plnění plánu v grafech a semaforech. Jaký nástroj BI tomu odpovídá?

- [ ] Ad hoc dotaz v SQL
- [ ] Data mining
- [x] Dashboard
- [ ] ETL proces

> Dashboard soustředí klíčové ukazatele na jednu obrazovku v přehledné grafické podobě. Ad hoc dotaz je jednorázový a data mining hledá skryté vzory.

## Data mining (dolování dat) {#data-mining .term}

Hledání **dosud neznámých vzorů, souvislostí a trendů** ve velkých objemech dat pomocí statistických metod a strojového učení — např. **klasifikace**, **shlukování** (segmentace), **asociační pravidla** (co se kupuje společně) a predikce. Na rozdíl od OLAP, kde uživatel ověřuje vlastní hypotézy, data mining vzory sám vyhledává.

### ? Řetězec chce zjistit, které výrobky zákazníci často kupují společně, aniž by měl předem hypotézu. Jaký přístup použije?

- [ ] Měsíční reporting prodejů
- [x] Data mining (asociační pravidla)
- [ ] Roll-up v OLAP kostce
- [ ] SCD typu 2

> Hledání neznámých souvislostí v datech, jako jsou společně kupované výrobky, je typická úloha data miningu (analýza nákupního košíku pomocí asociačních pravidel).

## Kimball × Inmon {#kimball-vs-inmon .compare}

Dvě klasické koncepce budování datového skladu.

| | Inmon | Kimball |
|---|---|---|
| Postup | **top-down** — nejdřív podnikový sklad, pak tržiště | **bottom-up** — postupně dimenzionální tržiště podle procesů |
| Centrální sklad | podnikový DWH v **normalizované** podobě (3. normální forma) | „sklad" je souhrn tržišť propojených **sdílenými (konformními) dimenzemi** |
| Datová tržiště | závislá, odvozená z centrálního skladu | dimenzionální (hvězdy), jádro řešení |
| Integrace | zajišťuje centrální sklad | zajišťují konformní dimenze (sběrnicová architektura — bus) |
| První výsledky | později, vyšší počáteční náklady | rychleji, menší počáteční investice |

### ? Firma začne jedním dimenzionálním tržištěm pro prodej, pak přidá nákup a sklady, přičemž dimenze Čas a Produkt sdílí všechna tržiště. Jde o který přístup?

- [ ] Inmonův top-down přístup
- [ ] Nezávislá datová tržiště jednotlivých útvarů
- [ ] Operativní úložiště dat
- [x] Kimballův bottom-up přístup

> Postupné budování dimenzionálních tržišť propojených sdílenými (konformními) dimenzemi je jádrem Kimballovy koncepce. Konformní dimenze odlišují tento přístup od nekoordinovaných nezávislých tržišť.

### ? Co je typické pro Inmonovu koncepci datového skladu?

- [x] Normalizovaný podnikový sklad, z něhož se plní tržiště
- [ ] Sklad vzniká jen jako souhrn tržišť propojených konformními dimenzemi
- [ ] Datová tržiště se plní přímo ze zdrojových systémů bez centrálního skladu
- [ ] Data se ukládají výhradně ve schématu sněhové vločky a jen v kostkách

> Inmon prosazuje top-down přístup: nejprve integrovaný normalizovaný podnikový sklad, z něhož se odvozují závislá datová tržiště.

### ? Co jsou konformní (sdílené) dimenze v Kimballově koncepci?

- [ ] Dimenze, které se nikdy nemění
- [ ] Dimenze uložené jen v dočasném úložišti
- [x] Dimenze se stejným významem ve více tržištích
- [ ] Dimenze bez hierarchií

> Konformní dimenze (např. jednotný Čas, Produkt, Zákazník) mají ve všech tržištích stejné klíče, atributy i význam, takže výsledky z různých tržišť jde porovnávat a kombinovat.

## Kvalita dat {#kvalita-dat .explain}

Kvalita dat vyjadřuje, nakolik jsou data **vhodná k zamýšlenému použití**. Posuzuje se v několika **dimenzích kvality**: **přesnost** (odpovídají skutečnosti), **úplnost** (nechybí povinné hodnoty), **konzistence** (shodují se mezi systémy), **aktuálnost/včasnost**, **jedinečnost** (bez duplicit) a **validita** (odpovídají pravidlům a formátům). Nekvalitní data v BI vedou ke špatným rozhodnutím a ke ztrátě důvěry uživatelů. Problémy je lepší řešit **u zdroje** (kontroly při pořízení dat) než jen opravovat v ETL; řízení kvality zahrnuje měření (profilování dat), čištění, sledování ukazatelů kvality a odstraňování příčin.

*Příklad:* Stejný zákazník je v CRM zapsán třikrát s drobně odlišným názvem — report pak nadhodnocuje počet zákazníků.

### ? Firma zjistila, že pětině zákazníků v CRM chybí e-mail, který je pro kampaň povinný. Kterou dimenzi kvality dat problém narušuje?

- [ ] Jedinečnost
- [ ] Konzistenci
- [x] Úplnost
- [ ] Aktuálnost

> Chybějící povinné hodnoty jsou problém úplnosti. Jedinečnost by se týkala duplicit, konzistence rozporů mezi systémy.

### ? Kde je z dlouhodobého hlediska nejúčinnější řešit chyby v datech?

- [ ] Ručně v hotových reportech
- [ ] Pouze v transformacích ETL
- [ ] V OLAP kostce před každou analýzou ručními úpravami buněk
- [x] U zdroje, při pořízení dat

> Oprava u zdroje odstraňuje příčinu a prospěje všem systémům. Čištění v ETL je užitečné, ale chyby se pak stále znovu objevují a provozní systémy zůstávají nekvalitní.

## Data governance {#data-governance .term}

Systém **řízení dat jako firemního aktiva** — pravidla, odpovědnosti a procesy pro kvalitu, definice, bezpečnost a využívání dat. Zahrnuje role jako **vlastník dat** (data owner, odpovídá za datovou oblast z pohledu byznysu) a **správce dat** (data steward, pečuje o definice a kvalitu v praxi), jednotné definice ukazatelů (business glosář) a souvisí se správou **kmenových dat** (master data management).

### ? Firma zjistila, že „počet aktivních zákazníků" počítá obchod jinak než marketing. Které opatření data governance problém řeší?

- [x] Jednotná definice ukazatele a jeho vlastník
- [ ] Zrychlení nočního běhu ETL
- [ ] Přechod ze schématu hvězdy na sněhovou vločku
- [ ] Přidání samostatného dashboardu s vlastním výpočtem pro marketing

> Data governance zavádí jednotné definice pojmů a ukazatelů a určuje, kdo za ně odpovídá. Technická opatření rozdílnou definici nevyřeší.

### ? Jaká je typická role správce dat (data steward)?

- [ ] Programuje ETL procesy a spravuje databázové servery skladu
- [x] Pečuje o definice a kvalitu dat své oblasti
- [ ] Schvaluje rozpočet celého BI projektu
- [ ] Navrhuje grafiku dashboardů

> Data steward je odpovědný za každodenní péči o data dané oblasti — definice, pravidla a kvalitu. Programování ETL a správa serverů jsou technické role.

## Metodologie BI projektů a přírůstkový postup {#prirustkovy-postup .explain}

BI projekty se doporučuje řešit **přírůstkově (inkrementálně)**: místo jednorázového budování celého skladu se v krátkých iteracích dodávají ucelené části — např. jedna oblast nebo jedno datové tržiště — které mají hned **přínos pro uživatele**. Projekt vychází z **požadavků byznysu** (jaká rozhodnutí a ukazatele uživatelé potřebují), ne z dostupných dat. Typické fáze iterace: analýza požadavků → analýza zdrojů a návrh ETL → dimenzionální model → realizace ETL a úložiště → analytické aplikace a reporty → nasazení a ověření s uživateli. Celé řešení přitom drží společný rámec (architektura, konformní dimenze, standardy), aby jednotlivé přírůstky do sebe zapadaly.

*Příklad:* Firma nejdřív za tři měsíce dodá tržiště prodejů s dashboardem pro obchod, teprve pak navazuje finančními a skladovými analýzami.

### ? Proč se u BI projektů doporučuje přírůstkový postup?

- [ ] Umožňuje vynechat analýzu požadavků
- [ ] Odstraňuje potřebu ETL procesů
- [x] Uživatelé dříve dostanou přínos a klesá riziko
- [ ] Celý datový sklad je hotov v jediné rozsáhlé etapě najednou

> Iterace dodávají brzy ucelené části s přínosem pro uživatele, zpětná vazba se promítá do dalších kroků a selhání jedné iterace neohrozí celý projekt.

### ? Čím by měl BI projekt začínat?

- [ ] Nákupem OLAP serveru a licencí
- [x] Analýzou požadavků uživatelů na informace a ukazatele
- [ ] Načtením všech dat ze všech systémů do skladu
- [ ] Návrhem grafiky dashboardů

> Řešení BI má vycházet z toho, jaká rozhodnutí a ukazatele byznys potřebuje; teprve podle toho se hledají zdroje, navrhuje model a ETL. Bezcílné načítání všech dat vede k drahému a nepoužívanému skladu.
