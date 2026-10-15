---
kind: topic
subject: ict-strategie
slug: rozvojove-cile-a-aplikacni-architektura-is
name: "Rozvojové cíle a aplikační architektura IS"
order: 7
---

Definování rozvojových cílů, požadovaných efektů dalšího rozvoje informatiky, návrh nových konceptů, resp. tzv. aplikačních architektur informačního systému, tj. specifikace požadovaných aplikací, jejich klíčových parametrů, vzájemných vazeb, řešení podstatných integračních aspektů na úrovni aplikací i poskytovaných služeb.

## Rozvojové cíle informatiky {#rozvojove-cile .term}

Cíle, kterých má informatika (IS/ICT) dosáhnout v horizontu informační strategie. **Odvozují se z cílů firmy** a z výsledků analýzy současného stavu IS, mají být **měřitelné a termínované** (např. podle principu SMART) a slouží jako **vstup pro návrh cílové architektury** a následně pro definici rozvojových projektů.

### ? Ze kterého zdroje se rozvojové cíle informatiky primárně odvozují?

- [ ] Z nabídky nových produktů dodavatelů softwaru
- [x] Z cílů firmy a analýzy současného stavu IS
- [ ] Z technických preferencí pracovníků útvaru IT
- [ ] Z rozpočtu, který IT dostalo v minulém roce

> Rozvoj informatiky má podporovat byznys, proto rozvojové cíle vycházejí z cílů firmy a ze zjištěných slabin a příležitostí současného IS. Nabídka dodavatelů nebo preference IT jsou nanejvýš doplňkové vstupy.

### ? Který z uvedených rozvojových cílů informatiky je formulován nejlépe?

- [ ] Postupně modernizovat celý informační systém firmy a jeho infrastrukturu
- [ ] Zavést co nejvíce moderních technologií
- [ ] Zlepšit spokojenost uživatelů s IT
- [x] Do konce roku 2027 zkrátit vyřízení objednávky ze 3 dnů na 1 den

> Dobře formulovaný cíl je konkrétní, měřitelný a termínovaný — má výchozí hodnotu, cílovou hodnotu a termín. Ostatní formulace nelze objektivně vyhodnotit.

## Požadované efekty rozvoje informatiky {#pozadovane-efekty .explain}

Ke každému rozvojovému cíli se specifikuje **požadovaný efekt** — změna v byznysu, kterou má rozvoj informatiky přinést. Efekt není technický výstup („nasadit nový CRM"), ale **přínos pro firmu**: úspora nákladů, zrychlení procesu, vyšší tržby, lepší kvalita rozhodování, nižší riziko. Efekty se dělí na **přímé, dobře měřitelné** (úspora práce, nižší zásoby) a **nepřímé, obtížně vyčíslitelné** (lepší informovanost, image). Pro každý efekt se určí **ukazatel, výchozí a cílová hodnota a vlastník** na straně byznysu, aby šlo po realizaci ověřit, zda bylo dosaženo. Řetězec pak vypadá takto: cíl firmy → rozvojový cíl IS → požadovaný efekt → změna aplikační architektury → projekt.

*Příklad:* Cíl „zvýšit podíl opakovaných nákupů" vede k efektu „růst opakovaných nákupů o 10 % za 2 roky"; prostředkem je nový CRM s věrnostním programem, vlastníkem efektu ředitel obchodu.

### ? Firma plánuje rozvoj IS. Která z položek je požadovaným EFEKTEM rozvoje, nikoli jen prostředkem?

- [x] Snížení průměrné výše skladových zásob o 15 %
- [ ] Nasazení nového modulu řízení skladu
- [ ] Přechod databází na novější verzi
- [ ] Propojení skladového systému s e-shopem a dopravci

> Efekt je měřitelná změna v byznysu — zde nižší zásoby. Nasazení modulu, upgrade databáze nebo propojení systémů jsou technické prostředky, kterými se efektu má dosáhnout.

### ? Proč se ke každému požadovanému efektu rozvoje informatiky určuje vlastník na straně byznysu?

- [ ] Aby útvar IT nemusel sledovat náklady projektů
- [ ] Protože vlastník efektu schvaluje technické řešení
- [x] Aby za přínos a jeho ověření někdo odpovídal
- [ ] Protože efekty IT jsou vždy jen nehmotné

> Přínos se projeví v byznysových procesech, které IT samo neřídí. Vlastník efektu z byznysu odpovídá za využití řešení a za to, že plánovaný přínos skutečně nastane a je změřen.

## Podniková architektura (Enterprise Architecture) {#podnikova-architektura .term}

Celkový popis firmy jako systému — jejích **procesů, informací, aplikací a technologií a vazeb mezi nimi** — v současném i cílovém stavu, včetně principů, které řídí jejich návrh a rozvoj. Slouží k **propojení strategie s realizací IT**: ukazuje, jak mají aplikace a technologie podporovat byznys a jaké změny jsou k tomu potřeba.

### ? Jaký je hlavní účel podnikové architektury (enterprise architecture)?

- [ ] Detailní popis zdrojového kódu všech aplikací firmy
- [x] Propojit strategii firmy s návrhem a rozvojem IS/ICT
- [ ] Nahradit informační strategii podrobnou technickou dokumentací
- [ ] Určit organizační strukturu útvaru IT

> Podniková architektura popisuje byznys, data, aplikace a technologie a jejich vazby, a tím převádí strategické záměry do konkrétní podoby IS/ICT. Nejde o detailní technickou dokumentaci ani o organizaci útvaru IT.

## Vrstvy podnikové architektury {#vrstvy-architektury .explain}

Podniková architektura se obvykle člení do čtyř vrstev (domén), které na sebe navazují shora dolů:

1. **Byznys architektura** — strategie, procesy, organizace, role, produkty a služby.
2. **Datová (informační) architektura** — klíčové datové entity, jejich vlastníci, toky a uložení.
3. **Aplikační architektura** — aplikace, jejich funkce, rozhraní a vzájemné vazby.
4. **Technologická architektura** — infrastruktura: servery, sítě, platformy, cloud, middleware.

Každá vyšší vrstva klade požadavky na nižší a nižší vrstva vyšší podporuje; změna procesu se proto promítne do dat, aplikací i infrastruktury.

*Příklad:* Firma zavádí online prodej (byznys) → potřebuje jednotná data o zákaznících a zásobách (data) → e-shop napojený na ERP (aplikace) → škálovatelný hosting e-shopu v cloudu (technologie).

### ? Architekt popisuje, které servery, databázové platformy a síťové prvky firma používá. Do které vrstvy podnikové architektury tento popis patří?

- [ ] Do byznys architektury
- [ ] Do datové architektury
- [ ] Do aplikační architektury
- [x] Do technologické architektury

> Technologická architektura popisuje infrastrukturu — hardware, sítě, platformy a middleware, na kterých aplikace běží.

### ? Ve které vrstvě podnikové architektury se popisuje, kdo je vlastníkem kmenových dat o zákazníkovi a kudy tato data tečou mezi systémy?

- [ ] V technologické architektuře
- [x] V datové (informační) architektuře
- [ ] V byznys architektuře
- [ ] V aplikační architektuře

> Datová architektura popisuje klíčové datové entity, jejich vlastnictví, toky a uložení. Aplikační architektura řeší aplikace a jejich rozhraní, nikoli samotná data.

## TOGAF a metoda ADM {#togaf-adm .explain}

**TOGAF** (The Open Group Architecture Framework) je rozšířený rámec pro tvorbu a řízení podnikové architektury, spravovaný konsorciem The Open Group. Jeho jádrem je **ADM (Architecture Development Method)** — opakující se cyklus fází: přípravná fáze, **A** vize architektury, **B** byznys architektura, **C** architektura informačních systémů (data a aplikace), **D** technologická architektura, **E** příležitosti a řešení, **F** plánování migrace, **G** řízení implementace, **H** řízení změn architektury. Uprostřed cyklu stojí **řízení požadavků**, které je s fázemi trvale propojeno. V každé doménové fázi se porovná výchozí a cílový stav a z rozdílů vznikají návrhy projektů.

*Příklad:* Banka v rámci ADM nejprve schválí vizi digitálního bankovnictví (A), popíše cílové procesy (B), cílové aplikace a data (C) a infrastrukturu (D), poté z rozdílů sestaví projekty (E) a plán jejich postupné realizace (F).

### ? Ve které fázi TOGAF ADM se navrhuje cílová aplikační a datová architektura?

- [ ] Ve fázi A — vize architektury
- [ ] Ve fázi B — byznys architektura
- [x] Ve fázi C — architektura informačních systémů
- [ ] Ve fázi D — technologická architektura

> Fáze C (Information Systems Architectures) zahrnuje datovou i aplikační architekturu. Fáze B řeší byznys a fáze D technologii.

### ? Co v metodě TOGAF ADM stojí uprostřed cyklu a je propojeno se všemi fázemi?

- [x] Řízení požadavků
- [ ] Plánování migrace
- [ ] Řízení implementace
- [ ] Vize architektury

> Řízení požadavků (Requirements Management) je ve středu ADM — požadavky se průběžně sbírají a promítají do všech fází. Plánování migrace (F), řízení implementace (G) a vize (A) jsou samostatné fáze cyklu.

## TOGAF × Zachmanův rámec {#togaf-vs-zachman .compare}

Oba rámce se používají při práci s podnikovou architekturou, ale každý k jinému účelu.

| | TOGAF | Zachmanův rámec |
|---|---|---|
| Podstata | metoda a rámec pro tvorbu a řízení architektury | klasifikační schéma (taxonomie) architektonických popisů |
| Jádro | cyklus ADM (fáze A–H, řízení požadavků) | matice: otázky co, jak, kde, kdo, kdy, proč × pohledy zúčastněných |
| Odpovídá na | **jak** architekturu vytvořit a udržovat | **co** všechno má popis architektury obsahovat a jak ho třídit |
| Původ | The Open Group | John Zachman (článek z roku 1987) |

### ? Firma hledá postup, jak krok za krokem vytvořit cílovou architekturu a naplánovat přechod na ni. Který rámec tomu odpovídá lépe a proč?

- [ ] Zachmanův rámec, protože definuje fáze migrace
- [ ] Zachmanův rámec, protože obsahuje cyklus ADM
- [ ] TOGAF, protože je to matice otázek co, jak, kde
- [x] TOGAF, protože obsahuje metodu ADM

> TOGAF nabízí procesní metodu ADM včetně plánování migrace. Zachmanův rámec je klasifikační matice, která neříká, jak postupovat.

### ? Co je Zachmanův rámec podnikové architektury?

- [ ] Metoda řízení IT služeb s procesy podpory provozu
- [x] Matice pro třídění popisů architektury
- [ ] Cyklus fází pro vývoj a migraci architektury
- [ ] Model úrovní zralosti procesů vývoje softwaru

> Zachmanův rámec je taxonomie — matice, jejíž sloupce tvoří otázky (co, jak, kde, kdo, kdy, proč) a řádky pohledy různých zúčastněných. Cyklus fází je ADM z TOGAF, úrovně zralosti patří CMMI.

## Výchozí a cílová architektura, analýza mezer {#vychozi-cilova-architektura .explain}

Návrh rozvoje IS vychází ze srovnání dvou stavů: **výchozí architektury** (as-is, baseline) — jak IS vypadá dnes — a **cílové architektury** (to-be, target) — jak má vypadat, aby naplnil rozvojové cíle. **Analýza mezer** (gap analysis) identifikuje rozdíly: co je třeba nově pořídit, upravit, nahradit nebo vyřadit. Z mezer se odvozují **rozvojové projekty** a často i **přechodové architektury** (mezistavy), protože cílový stav se obvykle nedosahuje najednou.

*Příklad:* Dnes firma eviduje zákazníky ve třech systémech (as-is), cílem je jeden CRM jako zdroj zákaznických dat (to-be). Mezera: chybí CRM, migrace dat a rozhraní na fakturaci — z toho vzniknou projekty.

### ? Co je výstupem analýzy mezer (gap analysis) mezi výchozí a cílovou architekturou?

- [ ] Popis současných aplikací bez hodnocení
- [ ] Výpočet celkových nákladů vlastnictví infrastruktury
- [x] Seznam změn, z nichž vzniknou rozvojové projekty
- [ ] Smlouva o úrovni služeb s dodavatelem

> Analýza mezer porovnává as-is a to-be a určuje, co je potřeba pořídit, změnit nebo vyřadit. Tyto rozdíly jsou základem pro definici rozvojových projektů.

### ? Proč se při rozvoji IS často definují přechodové architektury?

- [x] Cílového stavu se dosahuje postupně
- [ ] Cílová architektura se po schválení už nesmí měnit
- [ ] Výchozí architekturu nelze zdokumentovat
- [ ] Přechodová architektura nahrazuje analýzu mezer

> Rozsáhlou změnu IS nelze provést najednou, proto se plánují mezistavy, které jsou samy funkční a postupně vedou k cílové architektuře.

## Aplikační architektura IS {#aplikacni-architektura .term}

Specifikace **aplikací**, které má informační systém firmy obsahovat, jejich **klíčových parametrů** (funkční rozsah, uživatelé, požadavky na provoz), **vzájemných vazeb a datových toků** a způsobu **integrace**. Vychází z byznys a datové architektury a sama klade požadavky na technologickou infrastrukturu.

### ? Co je předmětem aplikační architektury informačního systému?

- [ ] Popis podnikových procesů, organizačních rolí a útvarů
- [ ] Konfigurace serverů a síťových prvků
- [ ] Rozpočet útvaru IT na příští rok
- [x] Aplikace, jejich parametry, vazby a integrace

> Aplikační architektura specifikuje, jaké aplikace firma potřebuje, s jakými parametry a jak spolu komunikují. Procesy patří do byznys architektury, servery a sítě do technologické.

## Typy aplikací v portfoliu {#portfolio-aplikaci .compare}

Aplikační portfolio firmy obvykle tvoří tyto skupiny aplikací:

| Typ | Účel | Typické funkce |
|---|---|---|
| **ERP** (Enterprise Resource Planning) | integrované jádro podnikových transakcí | finance, nákup, sklad, prodej, výroba, personalistika |
| **CRM** (Customer Relationship Management) | řízení vztahů se zákazníky | obchodní příležitosti, kampaně, zákaznický servis |
| **SCM** (Supply Chain Management) | plánování a koordinace dodavatelského řetězce | plánování poptávky a zásob, spolupráce s dodavateli, logistika |
| **BI** (Business Intelligence) | analýzy a podpora rozhodování | reporting, dashboardy, analýzy nad datovým skladem |
| **E-commerce** | elektronický prodejní kanál | e-shop, B2B portál, online platby |
| **Kancelářské a kolaborační** | běžná práce s dokumenty a komunikace | dokumenty, e-mail, sdílení souborů, videohovory |
| **Oborové (branžové)** | specifika konkrétního odvětví | např. řízení výroby v dílně (MES), nemocniční IS |

### ? Obchodní ředitel chce evidovat obchodní příležitosti, historii kontaktů se zákazníky a řídit marketingové kampaně. Jaký typ aplikace firma potřebuje?

- [ ] SCM
- [x] CRM
- [ ] ERP
- [ ] BI

> Evidence příležitostí, kontaktů a kampaní je typická funkcionalita CRM. ERP pokrývá transakce (fakturace, sklad), SCM dodavatelský řetězec a BI analýzy.

### ? Která aplikace tvoří v typickém aplikačním portfoliu transakční jádro propojující finance, nákup, sklad a prodej?

- [x] ERP
- [ ] CRM
- [ ] BI
- [ ] E-commerce

> ERP je integrovaný systém pokrývající hlavní podnikové transakce nad sdílenou databází. Ostatní aplikace se na něj zpravidla napojují.

### ? Výrobní firma chce plánovat zásoby na základě předpovědi poptávky a sdílet plány se svými dodavateli. Která kategorie aplikací to primárně pokrývá?

- [ ] CRM
- [ ] Kancelářské a kolaborační aplikace
- [x] SCM
- [ ] BI

> Plánování poptávky a zásob a koordinace s dodavateli jsou jádrem řízení dodavatelského řetězce (SCM). BI by data jen analyzovalo, plánovací spolupráci s dodavateli neřídí.

## Klíčové parametry aplikací {#parametry-aplikaci .explain}

Při specifikaci aplikace v architektuře se uvádějí zejména:

- **funkční parametry** — jaké procesy a funkce pokrývá, jaká data spravuje;
- **nefunkční parametry** — dostupnost, výkon a doba odezvy, bezpečnost, škálovatelnost, počet uživatelů;
- **integrační parametry** — rozhraní, se kterými aplikacemi a jak vyměňuje data;
- **způsob pořízení a provozu** — vlastní vývoj, standardní (krabicový) software, SaaS v cloudu; interní nebo externí provoz;
- **kritičnost a vlastnictví** — jak důležitá je pro byznys, kdo je jejím vlastníkem;
- **ekonomické parametry** — náklady na pořízení a provoz, licenční model.

*Příklad:* E-shop: funkce objednávky a platby; dostupnost 24/7 a odezva do 2 s; rozhraní na ERP (sklad, faktury) a platební bránu; SaaS řešení; vysoká kritičnost; vlastník ředitel e-commerce.

### ? Který z uvedených požadavků na aplikaci je NEFUNKČNÍ?

- [ ] Aplikace vystaví fakturu z potvrzené objednávky
- [ ] Aplikace eviduje reklamace zákazníků
- [ ] Aplikace vypočítá slevu podle pravidel věrnostního programu firmy
- [x] Aplikace zvládne 500 souběžných uživatelů s odezvou do 2 s

> Nefunkční parametry popisují vlastnosti, s jakými aplikace pracuje (výkon, dostupnost, bezpečnost), nikoli co dělá. Ostatní možnosti jsou funkční požadavky.

### ? Firma u každé aplikace v portfoliu vyhodnocuje, jak vážný dopad by měl její výpadek na byznys. Který parametr aplikace tím určuje?

- [ ] Licenční model
- [ ] Integrační rozhraní
- [x] Kritičnost pro byznys
- [ ] Funkční rozsah

> Kritičnost vyjadřuje, jak moc na aplikaci závisí byznys, a ovlivňuje požadavky na dostupnost, zálohování i prioritu podpory.

## Integrace aplikací a její úrovně {#integrace-aplikaci .explain}

**Integrace** propojuje aplikace tak, aby spolu sdílely data a funkce a podporovaly procesy jako celek, bez ručního přepisování dat. Obvykle se rozlišují úrovně:

- **datová** — sdílená databáze, replikace nebo přenos dat (dávky, soubory);
- **aplikační (funkční)** — jedna aplikace volá funkce jiné přes rozhraní (API, služby);
- **procesní** — řízení obchodního procesu, který prochází více aplikacemi (orchestrace);
- **prezentační (uživatelská)** — jednotný přístup uživatele k více aplikacím, např. portál.

Neintegrované aplikace vedou k duplicitám, nekonzistentním datům a chybám při ručním přenosu.

*Příklad:* Objednávka z e-shopu se automaticky předá do ERP (aplikační integrace), ERP vrátí stav skladu a proces „objednávka → expedice → faktura" běží napříč systémy bez ručního zásahu (procesní integrace).

### ? Zaměstnanci se přihlašují do jednoho intranetového portálu, ve kterém vidí údaje z HR systému, CRM i ERP. O jakou úroveň integrace jde především?

- [ ] Datovou
- [ ] Procesní
- [x] Prezentační (uživatelskou)
- [ ] Technologickou

> Portál sjednocuje přístup uživatele k více aplikacím — jde o integraci na úrovni uživatelského rozhraní. Data i procesy přitom mohou zůstat v původních systémech.

### ? Co je typickým důsledkem nedostatečné integrace aplikací?

- [x] Ruční přepisování dat a jejich nekonzistence
- [ ] Nutnost pořídit centrální integrační server a licence
- [ ] Vyšší vytížení síťové infrastruktury
- [ ] Závislost na jediném dodavateli softwaru

> Bez integrace se táž data zadávají do více systémů ručně, vznikají chyby a rozpory. Závislost na jednom dodavateli je spíše riziko integrovaného systému.

## Point-to-point × hub (centrální integrace) {#point-to-point-vs-hub .compare}

Při integraci mnoha aplikací lze každou propojit s každou přímo, nebo je napojit na společný integrační uzel.

| | Point-to-point (bod–bod) | Hub (hub-and-spoke, centrální uzel) |
|---|---|---|
| Princip | přímé rozhraní mezi každou dvojicí aplikací | každá aplikace má jedno napojení na centrální uzel |
| Počet propojení při plném propojení n aplikací | až `n(n − 1)/2` | `n` |
| Výhody | jednoduché pro málo aplikací, bez další vrstvy | přehlednost, snazší změny, centrální transformace a monitoring |
| Nevýhody | „špagetová" architektura, drahá údržba, každá změna ovlivní více rozhraní | centrální uzel je kritický bod a stojí peníze na pořízení i provoz |

### ? Firma má 8 aplikací a každá má vyměňovat data s každou. Kolik obousměrných rozhraní (jedno mezi každou dvojicí aplikací) je potřeba při přímém propojení point-to-point a kolik napojení při použití centrálního hubu?

- [ ] 16 rozhraní × 8 napojení
- [ ] 56 rozhraní × 8 napojení
- [x] 28 rozhraní × 8 napojení
- [ ] 28 rozhraní × 1 napojení

> Point-to-point: n(n − 1)/2 = 8 · 7 / 2 = 28 rozhraní. U hubu má každá z 8 aplikací jedno napojení na centrální uzel, tedy 8 napojení.

### ? Co je hlavní nevýhodou centrální integrace přes hub ve srovnání s point-to-point?

- [ ] Počet rozhraní roste kvadraticky s počtem aplikací
- [x] Výpadek centrálního uzlu ovlivní všechny integrace
- [ ] Nelze centrálně sledovat toky zpráv
- [ ] Každá změna aplikace vyžaduje úpravu mnoha rozhraní

> Hub je jediný centrální bod, přes který jdou všechny toky, proto jeho výpadek zastaví integraci celé firmy. Kvadratický růst rozhraní a náročné změny jsou naopak slabiny point-to-point.

## EAI (Enterprise Application Integration) {#eai .term}

Přístup a skupina technologií (**middleware**) pro integraci podnikových aplikací přes **centrální integrační vrstvu** — typicky integrační broker v uspořádání hub-and-spoke. Aplikace se napojují pomocí **adaptérů**, broker zajišťuje **transformaci formátů dat, směrování zpráv** a často i řízení jednoduchých procesních toků, takže aplikace o sobě navzájem nemusí vědět.

### ? Jakou roli mají v řešení EAI adaptéry?

- [ ] Ukládají kopii všech dat pro analytické účely
- [ ] Nahrazují uživatelské rozhraní aplikací
- [ ] Zajišťují jednotné přihlášení uživatele do všech aplikací
- [x] Napojují konkrétní aplikaci na integrační vrstvu

> Adaptér převádí rozhraní a formát konkrétní aplikace na podobu, které rozumí integrační broker. Ukládání dat pro analýzy je úlohou datového skladu, jednotné přihlášení řeší SSO.

## ESB (Enterprise Service Bus) {#esb .explain}

**Podniková sběrnice služeb** je integrační platforma, přes kterou si aplikace vyměňují **zprávy** a volají **služby**. Na rozdíl od klasického centrálního EAI brokeru je koncipována spíše jako **distribuovaná sběrnice** postavená na standardech; zajišťuje **směrování, transformaci zpráv, převod protokolů**, spolehlivé doručení a monitoring. Podporuje komunikaci **synchronní** (volající čeká na odpověď) i **asynchronní** (zpráva se uloží do fronty a zpracuje později), čímž **volně provazuje** (loose coupling) aplikace. ESB bývá technickým základem pro architekturu SOA.

*Příklad:* Pojišťovna posílá událost „nová smlouva" na ESB; sběrnice ji doručí do účetnictví, CRM i systému provizí, každému v jeho formátu. Pokud je účetnictví zrovna nedostupné, zpráva počká ve frontě.

### ? Účetní systém je v noci kvůli údržbě nedostupný, ale objednávky z e-shopu se do něj nesmějí ztratit. Který způsob komunikace přes ESB je vhodný?

- [ ] Synchronní volání, při kterém e-shop čeká na odpověď
- [x] Asynchronní zasílání zpráv přes frontu
- [ ] Ruční export objednávek do tabulky
- [ ] Přímý zápis e-shopu do databáze účetnictví

> Asynchronní komunikace uloží zprávu do fronty a ta se doručí, jakmile je příjemce dostupný. Synchronní volání by při nedostupnosti selhalo, přímý zápis do cizí databáze porušuje oddělení aplikací.

### ? Co znamená volné provázání (loose coupling) aplikací v integraci přes ESB?

- [ ] Aplikace sdílejí jednu společnou databázi
- [ ] Aplikace běží na stejném serveru
- [x] Aplikace znají jen rozhraní a zprávy, ne vnitřek ostatních
- [ ] Integrace probíhá jen jednou denně formou dávkového přenosu souborů

> Volně provázané aplikace znají jen dohodnuté rozhraní či formát zprávy, takže jednu lze změnit nebo vyměnit bez zásahu do ostatních.

## SOA (Service-Oriented Architecture) {#soa .explain}

**Architektura orientovaná na služby** je koncept, v němž se funkce aplikací zpřístupňují jako **služby** s jasně definovaným **rozhraním (kontraktem)**. Služba odpovídá ucelené byznysové funkci (např. „ověř bonitu zákazníka"), je **znovupoužitelná** v různých procesech a aplikacích a uživatel služby nezná její vnitřní implementaci. Ze služeb se pak **skládají (orchestrují) procesy**. SOA se často realizuje pomocí webových služeb a ESB. Přínosem je pružnost při změnách procesů a menší duplicita funkcí, rizikem vysoká náročnost správy služeb a jejich rozhraní.

*Příklad:* Banka vytvoří službu „výpočet splátky úvěru", kterou volá internetové bankovnictví, aplikace na pobočce i call centrum — logika výpočtu je na jednom místě.

### ? Co je hlavním principem architektury orientované na služby (SOA)?

- [x] Znovupoužitelné služby s definovaným rozhraním
- [ ] Všechny funkce firmy pokrývá jediný integrovaný systém
- [ ] Každá dvojice aplikací má vlastní přímé rozhraní
- [ ] Data se pro analýzy pravidelně kopírují do datového skladu

> SOA staví na službách s kontraktem, které lze opakovaně používat a skládat do procesů. Jeden integrovaný systém je koncept ERP, přímá rozhraní jsou point-to-point.

### ? Pojišťovna chce, aby výpočet pojistného prováděla stejná logika na webu, v mobilní aplikaci i na pobočce. Který přínos SOA tím využije?

- [ ] Vyšší výkon databází
- [ ] Odstranění potřeby jakékoli integrační vrstvy a rozhraní
- [ ] Nižší nároky na zabezpečení
- [x] Znovupoužitelnost služby v různých kanálech

> Výpočet pojistného jako jedna služba je volán ze všech kanálů, takže logika není duplikovaná a změna se provede na jednom místě.

## API a mikroslužby {#api-mikrosluzby .compare}

**API** (Application Programming Interface) je zveřejněné rozhraní, přes které aplikace nabízí svá data a funkce jiným aplikacím — dnes typicky **REST API přes HTTP**. **Mikroslužby** jsou architektonický styl, v němž se aplikace skládá z **malých, samostatně nasaditelných služeb**, z nichž každá pokrývá jednu oblast a komunikuje přes API nebo zprávy.

| | Monolitická aplikace | Mikroslužby |
|---|---|---|
| Struktura | jeden celek, společná databáze | mnoho malých služeb, každá obvykle s vlastními daty |
| Nasazení | celá aplikace najednou | každá služba samostatně |
| Škálování | celá aplikace | jen zatížené služby |
| Výhody | jednodušší vývoj a provoz v malém | rychlé a nezávislé změny, odolnost, škálovatelnost |
| Nevýhody | změny pomalé, riziko při každém nasazení | složitější provoz, monitoring a konzistence dat |

### ? E-shop má v předvánočním období extrémní zatížení katalogu a košíku, ostatní části (reklamace, věrnostní program) běží beze změny. Jaká výhoda mikroslužeb se tu uplatní?

- [ ] Všechny části sdílejí jednu databázi
- [x] Lze škálovat jen zatížené služby
- [ ] Odpadá potřeba monitorovat provoz
- [ ] Celá aplikace se nasazuje najednou

> V mikroslužbách lze navýšit kapacitu pouze katalogu a košíku. Monolit by bylo nutné škálovat celý; společná databáze a společné nasazení jsou rysy monolitu.

### ? Co je typickou nevýhodou architektury mikroslužeb oproti monolitu?

- [ ] Nemožnost nasadit změnu bez odstávky celé aplikace
- [ ] Nutnost používat jeden programovací jazyk
- [ ] Nelze ji provozovat v cloudu
- [x] Složitější provoz a udržení konzistence dat mezi službami

> Mnoho samostatných služeb s vlastními daty zvyšuje nároky na provoz, monitoring a konzistenci dat. Nasazení celé aplikace najednou je naopak slabina monolitu.

## Integrační aspekty na úrovni služeb {#integracni-aspekty-sluzeb .explain}

Kromě technického propojení aplikací je třeba v architektuře vyřešit, aby IS fungoval jako celek z pohledu **poskytovaných služeb** uživatelům a zákazníkům:

- **kmenová data** (master data — zákazníci, produkty, dodavatelé) mají mít jasně určený **zdrojový systém a vlastníka**; sjednocení řeší **MDM** (Master Data Management);
- **jednotná identita a přístup** — správa uživatelů a oprávnění napříč aplikacemi, jednotné přihlášení **SSO** (Single Sign-On);
- **služba z pohledu uživatele** vzniká často spoluprací více aplikací a jejich rozhraní, proto se dostupnost a podpora musí řešit pro celý řetězec, ne pro jednotlivé aplikace zvlášť;
- **monitoring integrací** — sledování toků zpráv, chyb a jejich řešení.

*Příklad:* Služba „vyřízení objednávky" závisí na e-shopu, ESB, ERP a dopravci; výpadek kteréhokoli článku znamená pro zákazníka nefunkční službu.

### ? Adresa zákazníka se liší v CRM, ERP a e-shopu a nikdo neví, která je správná. Jaké řešení architektura nabízí?

- [ ] Zavedení jednotného přihlášení SSO
- [ ] Přechod všech tří aplikací do cloudu
- [ ] Nahrazení REST API dávkovými přenosy
- [x] Správa kmenových dat (MDM)

> Nekonzistentní kmenová data řeší MDM — určí, který systém je pro zákaznická data zdrojem pravdy, kdo je vlastníkem a jak se změny šíří do ostatních aplikací.

### ? Uživatelé si stěžují, že se musejí do každé z pěti firemních aplikací přihlašovat zvlášť. Co jim pomůže?

- [x] Jednotné přihlášení (SSO)
- [ ] Správa kmenových dat (MDM)
- [ ] Asynchronní fronta zpráv
- [ ] Přechodová architektura

> SSO umožní jedním přihlášením přistupovat do více aplikací. MDM řeší konzistenci kmenových dat, fronty zpráv výměnu dat mezi aplikacemi.

## Best of breed × integrovaný systém {#best-of-breed-vs-integrovany .compare}

Základní volba aplikační architektury: skládat IS z nejlepších specializovaných aplikací, nebo použít jeden integrovaný systém (typicky ERP s moduly od jednoho dodavatele).

| | Best of breed | Integrovaný systém |
|---|---|---|
| Princip | pro každou oblast nejlepší specializovaná aplikace | jeden systém s moduly nad společnou databází |
| Pokrytí funkcí | vysoké, přizpůsobené oboru | standardní, někdy kompromis |
| Integrace | nutná, náročná a drahá | z velké části zajištěna uvnitř systému |
| Konzistence dat | nutno řešit napříč aplikacemi | jedna databáze, data konzistentní |
| Dodavatelé | více, složitější koordinace | jeden, riziko závislosti (vendor lock-in) |
| Vhodné, když | oblast je pro firmu konkurenční výhodou | firma chce standardní procesy a nižší složitost |

### ? Středně velká firma chce co nejrychleji sjednotit data a nemá silný vlastní IT tým na údržbu rozhraní. Funkčně jí stačí standardní procesy. Který přístup je vhodnější?

- [ ] Best of breed, protože poskytuje nejširší funkce
- [x] Integrovaný systém, protože omezuje integraci a sjednotí data
- [ ] Best of breed, protože snižuje počet dodavatelů
- [ ] Integrovaný systém, protože zaručuje nejlepší funkce v každé oblasti

> Integrovaný systém pracuje nad společnou databází a nevyžaduje rozsáhlou integraci, což odpovídá slabému IT týmu a standardním procesům. Best of breed naopak znamená více dodavatelů a náročnou integraci.

### ? Co je typickým rizikem přístupu best of breed?

- [ ] Silná závislost na jediném dodavateli
- [ ] Nedostatečné funkční pokrytí specifických oblastí firmy a oboru
- [x] Vysoké náklady a složitost integrace mezi aplikacemi
- [ ] Nemožnost využít specializovaný software

> Kombinace specializovaných aplikací od různých dodavatelů vyžaduje mnoho rozhraní a sjednocování dat. Závislost na jediném dodavateli je naopak riziko integrovaného systému.
