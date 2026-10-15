---
kind: topic
subject: ict-strategie
slug: analyza-informacnich-zdroju-a-sluzeb-cobit
name: "Analýza informačních zdrojů a služeb (COBIT)"
order: 6
---

Analýza informačních zdrojů a služeb, tj. interních i externích. Zahrnuje např. analýzu (audit) stavu vlastního informačního systému s využitím metodiky a modelů COBIT, analýzu informatiky obchodních partnerů s dopady na řešení elektronických obchodních a komunikačních kanálů, principy analýzy řízení informatiky ve vazbě na řízení celé organizace s identifikací klíčových problémů a jejich kategorizace, analýzy obchodního a smluvního zajištění poskytování informačních služeb uživatelským útvarům apod.

## Interní × externí informační zdroje a služby {#interni-externi-zdroje .compare}

Analýza pokrývá jak zdroje a služby, které firma vytváří a spravuje sama, tak ty, které získává z okolí.

| | Interní | Externí |
|---|---|---|
| Původ | vznikají a jsou spravovány uvnitř firmy | pocházejí z okolí firmy (trh, stát, partneři, poskytovatelé) |
| Příklady zdrojů | data z ERP, CRM a účetnictví, interní dokumenty, znalosti zaměstnanců | veřejné registry, statistiky, komerční databáze, otevřená data, data partnerů |
| Příklady služeb | služby vlastního útvaru IT (provoz aplikací, helpdesk, správa sítě) | cloudové služby (SaaS), outsourcing, telekomunikační služby |
| Kontrola nad kvalitou | vysoká, firma ji řídí sama | omezená, závisí na poskytovateli a smlouvě |
| Typická rizika | neúplná a roztříštěná data, duplicity | závislost na dodavateli, licenční podmínky, ochrana osobních údajů |

Hodnotí se zejména relevance, kvalita, dostupnost, spolehlivost, náklady a právní a bezpečnostní podmínky využití.

### ? Firma zařadí do analýzy informačních zdrojů údaje z veřejného obchodního rejstříku o svých odběratelích. O jaký zdroj jde?

- [ ] Interní zdroj z transakčního systému
- [x] Externí veřejný zdroj
- [ ] Interní znalostní zdroj
- [ ] Interní služba útvaru IT

> Obchodní rejstřík je veřejný registr mimo firmu, jde tedy o externí informační zdroj. Interní zdroje vznikají a jsou spravovány uvnitř firmy.

### ? Proč analýza u externích informačních služeb (např. pronajaté cloudové aplikace) klade velký důraz na smluvní podmínky?

- [x] Kvalitu služby neřídí firma, ale poskytovatel podle smlouvy
- [ ] Externí služby nelze nikdy využít pro klíčové podnikové procesy
- [ ] Smluvní podmínky určují, jak útvar IT nastaví interní helpdesk
- [ ] U externích služeb odpadá povinnost chránit osobní údaje

> U externí služby firma nemůže kvalitu řídit sama — dostupnost, podporu i nakládání s daty určuje poskytovatel v rámci sjednané smlouvy. Ochrana osobních údajů přitom zůstává povinností firmy i u externí služby.

## Analýza výchozího stavu jako vstup informační strategie {#analyza-vychoziho-stavu .explain}

Před formulací nebo aktualizací informační strategie firma zjišťuje **výchozí stav (as-is)**: jaké informační zdroje a služby má, jak dobře podporují podnikové procesy a cíle, kolik stojí a jaká nesou rizika. Analýza zahrnuje vlastní IS (aplikace, data, infrastrukturu, lidi, řízení informatiky), externí zdroje a služby, informatiku obchodních partnerů a smluvní zajištění služeb. Porovnáním výchozího stavu s požadovaným cílovým stavem (to-be) vzniká **analýza mezer (gap analysis)**, z níž plynou rozvojové cíle a projekty. Jako měřítko se často používá referenční rámec, např. COBIT.

*Příklad:* Distributor před novou informační strategií zmapuje svých 40 aplikací, zjistí, že tři z nich nezávisle evidují zákazníky, a sjednocení zákaznických dat zařadí mezi rozvojové cíle.

### ? Firma porovnává zjištěný současný stav informatiky s cílovým stavem odvozeným ze strategie a hledá rozdíly. Jak se tento krok nazývá?

- [ ] Benchmarking
- [ ] Analýza citlivosti
- [x] Analýza mezer (gap analysis)
- [ ] Analýza SWOT

> Analýza mezer porovnává stav as-is s požadovaným stavem to-be a pojmenovává rozdíly, které je třeba odstranit. Benchmarking srovnává s jinými firmami, SWOT hodnotí silné a slabé stránky, příležitosti a hrozby.

### ? Jaký je hlavní účel analýzy informačních zdrojů a služeb v rámci strategického řízení informatiky?

- [ ] Vybrat konkrétní dodavatele pro všechny rozvojové projekty
- [ ] Vyhodnotit pracovní výkon jednotlivých zaměstnanců útvaru IT
- [ ] Nahradit formulaci firemní strategie
- [x] Poznat výchozí stav jako vstup pro informační strategii

> Analýza zdrojů a služeb popisuje výchozí stav informatiky; z jeho srovnání s požadovaným stavem vycházejí cíle a projekty informační strategie. Výběr dodavatelů nebo hodnocení lidí jsou až dílčí navazující činnosti.

## Audit informačního systému {#audit-is .term}

**Audit IS (IT audit)** je nezávislé a systematické posouzení stavu informačního systému a řízení informatiky vůči **předem stanoveným kritériím** — referenčnímu rámci (např. COBIT), normám (např. ISO/IEC 27001 pro bezpečnost informací), právním požadavkům a interním pravidlům. Zjišťuje, zda IS podporuje cíle organizace, je efektivní, bezpečný a v souladu s požadavky, a navrhuje zlepšení. Provádí ho interní audit nebo externí auditor; ISACA pro auditory IS nabízí certifikaci CISA.

### ? Co je pro audit informačního systému podstatné?

- [x] Stav IS se posuzuje vůči předem stanoveným kritériím
- [ ] Audit vždy provádí dodavatel hlavního podnikového systému
- [ ] Výsledkem auditu je vždy nákup nového systému
- [ ] Audit hodnotí výhradně hardware a síťovou infrastrukturu

> Podstatou auditu je nezávislé posouzení vůči kritériím (rámec, norma, předpis, interní pravidla). Dodavatel by nebyl nezávislý a audit pokrývá i procesy, řízení, data a bezpečnost, nejen techniku.

## Postup auditu stavu IS {#postup-auditu .explain}

Audit (analýza) stavu IS má obvykle tyto kroky:

1. **Vymezení cílů, rozsahu a kritérií** — co se posuzuje (celý IS, bezpečnost, konkrétní proces) a podle čeho (např. vybrané cíle COBIT).
2. **Sběr informací** — studium dokumentace, rozhovory, dotazníky, prohlídky, **testy kontrol** na vzorcích a měření.
3. **Vyhodnocení** — porovnání zjištění s kritérii, posouzení úrovně schopnosti procesů a rizik.
4. **Zjištění a doporučení** — pojmenování nedostatků, jejich příčin a návrh opatření s prioritami.
5. **Zpráva a projednání** s vedením, následně **ověření realizace** doporučení (follow-up).

*Příklad:* Auditor si u 20 náhodně vybraných odchodů zaměstnanců v systému ověří, zda jim byla včas odebrána přístupová práva, místo aby se spokojil se směrnicí.

### ? Který krok by v auditu stavu IS měl předcházet sběru informací?

- [ ] Vypracování doporučení a jejich priorit
- [ ] Ověření realizace doporučení
- [ ] Projednání závěrečné zprávy s vedením
- [x] Vymezení cílů, rozsahu a kritérií auditu

> Nejprve je nutné určit, co a podle jakých kritérií se bude posuzovat; teprve pak má smysl sbírat informace. Doporučení, zpráva a follow-up následují až po vyhodnocení.

### ? Auditor chce ověřit, zda firma skutečně odebírá přístupová práva odcházejícím zaměstnancům. Který postup poskytne nejpřesvědčivější důkaz?

- [ ] Rozhovor s vedoucím útvaru IT
- [x] Kontrola vzorku odchodů přímo v systému
- [ ] Prostudování směrnice o přístupových právech
- [ ] Dotazník rozeslaný vedoucím útvarů

> Test kontroly na vzorku ukazuje, jak kontrola skutečně funguje. Směrnice, rozhovor či dotazník dokládají jen to, jak by kontrola fungovat měla nebo jak ji vnímají lidé.

## COBIT {#cobit .term}

**COBIT** je rámec organizace **ISACA** pro **governance a management podnikových informací a technologií** (enterprise I&T). Vznikl v 90. letech jako soubor kontrolních cílů pro audit (původně Control Objectives for Information and Related Technology; od COBIT 5 se používá jen zkratka) a postupně se rozšířil na celkové řízení informatiky. Aktuální verzí je **COBIT 2019**, předchozí byl COBIT 5 (2012). COBIT popisuje hlavně, **co** má být řízeno a kontrolováno, nikoli podrobné postupy, jak to dělat.

### ? Firma hledá rámec, který jí pomůže nastavit řízení a kontrolu informatiky jako celku včetně vazby na podnikové cíle. Který je nejvhodnější?

- [ ] ITIL
- [ ] TOGAF
- [x] COBIT
- [ ] Scrum

> COBIT je rámec pro governance a management podnikové informatiky jako celku. ITIL se soustředí na správu IT služeb, TOGAF na podnikovou architekturu a Scrum na agilní vývoj.

### ? Která organizace vydává rámec COBIT?

- [x] ISACA
- [ ] AXELOS
- [ ] The Open Group
- [ ] ISO

> COBIT vydává profesní asociace ISACA. AXELOS je spojen s ITIL, The Open Group s TOGAF a ISO vydává mezinárodní normy.

## Principy COBIT 2019 {#principy-cobit .explain}

COBIT 2019 formuluje **šest principů systému governance**: (1) poskytovat hodnotu zainteresovaným stranám, (2) holistický přístup — systém tvoří více komponent různého druhu, (3) dynamický systém governance — reaguje na změny design factors, (4) oddělení governance od managementu, (5) přizpůsobení potřebám podniku, (6) komplexní pokrytí podniku (end-to-end) — nejen útvaru IT, ale všech informací a technologií v podniku. Dále má **tři principy rámce governance**: založení na koncepčním modelu, otevřenost a flexibilitu a soulad s hlavními standardy, rámci a předpisy. Předchozí COBIT 5 měl pět principů (mj. naplnění potřeb zainteresovaných stran, pokrytí podniku end-to-end, jednotný integrovaný rámec, holistický přístup, oddělení governance od managementu).

*Příklad:* Výrobce do systému governance zahrne i data a aplikace, které si spravuje obchodní oddělení mimo útvar IT — uplatňuje tak princip end-to-end pokrytí.

### ? Který z uvedených NENÍ principem systému governance podle COBIT 2019?

- [ ] Oddělení governance od managementu
- [ ] Přizpůsobení potřebám podniku
- [ ] Komplexní pokrytí podniku (end-to-end)
- [x] Řízení informatiky výhradně útvarem IT

> COBIT 2019 naopak zdůrazňuje, že governance pokrývá informace a technologie v celém podniku, nejen útvar IT. Ostatní tři možnosti jsou principy systému governance.

### ? Co vyjadřuje princip holistického přístupu v COBIT 2019?

- [ ] Každý proces musí dosáhnout nejvyšší úrovně schopnosti
- [x] Systém governance tvoří více spolupracujících komponent různého druhu
- [ ] Rámec se zavádí najednou v celé firmě bez přizpůsobení
- [ ] O informatice rozhoduje jediný orgán bez účasti byznysu

> Holistický přístup znamená, že nestačí procesy — systém governance tvoří také organizační struktury, informace, kultura, lidé, služby a další komponenty, které musí spolupracovat.

## Governance × management {#governance-vs-management .compare}

COBIT jasně odděluje dvě disciplíny s odlišnými činnostmi, organizačními strukturami a účelem.

| | Governance (správa) | Management (řízení) |
|---|---|---|
| Kdo | vrcholný orgán — představenstvo, správní rada | výkonné vedení v čele s generálním ředitelem (CEO) |
| Činnosti | vyhodnocuje potřeby zainteresovaných stran, **určuje směr** (priority, rozhodnutí), **monitoruje** výkonnost a soulad | **plánuje, buduje, provozuje a monitoruje** činnosti v souladu se směrem daným governance |
| Domény COBIT 2019 | EDM | APO, BAI, DSS, MEA |
| Výstup | cíle, priority, pravidla, dohled | realizace — plány, řešení, služby, měření |

### ? Představenstvo (board) banky rozhoduje, které ze tří navržených IT iniciativ dostanou prioritu, a pravidelně sleduje, zda přinášejí očekávaný přínos. O jakou činnost podle COBIT jde?

- [x] Governance (doména EDM)
- [ ] Management (doména APO)
- [ ] Management (doména BAI)
- [ ] Management (doména DSS)

> Stanovení priorit a dohled nad přínosy vrcholným orgánem je governance — vyhodnocení, usměrnění a monitorování (EDM). Management by priority realizoval plány, projekty a provozem.

### ? Která doména COBIT 2019 obsahuje cíle governance?

- [ ] APO
- [ ] MEA
- [x] EDM
- [ ] DSS

> Cíle governance jsou soustředěny v doméně EDM (Evaluate, Direct and Monitor). APO, BAI, DSS a MEA jsou domény managementu.

## Domény COBIT 2019 {#domeny-cobit .compare}

Cíle governance a managementu jsou seskupeny do pěti domén — jedné pro governance a čtyř pro management.

| Doména | Význam | Zaměření | Počet cílů |
|---|---|---|---|
| **EDM** | Evaluate, Direct and Monitor (vyhodnocovat, usměrňovat, monitorovat) | governance: rámec governance, přínosy, rizika, zdroje, zainteresované strany | 5 |
| **APO** | Align, Plan and Organize (sladit, plánovat, organizovat) | strategie, architektura, rozpočet a náklady, lidé, vztahy, dohody o službách, dodavatelé, kvalita, rizika, bezpečnost, data | 14 |
| **BAI** | Build, Acquire and Implement (budovat, pořizovat, implementovat) | programy a projekty, požadavky, řešení, změny, znalosti, konfigurace | 11 |
| **DSS** | Deliver, Service and Support (dodávat, poskytovat služby, podporovat) | provoz, požadavky na služby a incidenty, problémy, kontinuita, bezpečnostní služby | 6 |
| **MEA** | Monitor, Evaluate and Assess (monitorovat, vyhodnocovat, posuzovat) | výkonnost a soulad, vnitřní kontrolní systém, soulad s externími požadavky, ujištění (assurance) | 4 |

Celkem 5 + 14 + 11 + 6 + 4 = **40 cílů**.

### ? Výpadek e-shopu je zaevidován jako incident a servisní tým ho řeší a obnovuje provoz. Do které domény COBIT 2019 tato činnost patří?

- [ ] BAI
- [x] DSS
- [ ] APO
- [ ] MEA

> Řízení požadavků na služby a incidentů i každodenní provoz patří do domény DSS (Deliver, Service and Support).

### ? Firma vybírá a pořizuje nový CRM systém a řídí jeho implementaci a nasazení. Do které domény COBIT 2019 tato činnost patří?

- [ ] DSS
- [ ] EDM
- [ ] MEA
- [x] BAI

> Pořízení, vybudování a implementace řešení včetně řízení změn spadají do domény BAI (Build, Acquire and Implement).

### ? Útvar compliance pravidelně ověřuje, zda informatika plní požadavky regulátora a zákonů o ochraně osobních údajů. Do které domény COBIT 2019 tato činnost patří?

- [ ] APO
- [ ] DSS
- [x] MEA
- [ ] BAI

> Monitorování výkonnosti, vnitřní kontroly a souladu s externími požadavky patří do domény MEA (Monitor, Evaluate and Assess).

## Cíle governance a managementu {#cile-cobit .explain}

COBIT 2019 obsahuje **40 cílů governance a managementu** (governance and management objectives): 5 cílů governance v doméně EDM a 35 cílů managementu v doménách APO, BAI, DSS a MEA. Každý cíl má kód (např. EDM03, APO12) a účel a vztahuje se k jednomu procesu i k dalším komponentám systému governance. Oproti 37 procesům COBIT 5 přibyly tři nové cíle: **APO14 Řízená data**, **BAI11 Řízené projekty** a **MEA04 Řízené ujištění (assurance)**. Firma obvykle nezavádí všechny cíle stejně intenzivně, ale podle svých priorit volí cílové úrovně schopnosti.

*Příklad:* Pojišťovna po sérii bezpečnostních incidentů posílí cíle APO13 Řízená bezpečnost a DSS05 Řízené bezpečnostní služby a stanoví pro ně vyšší cílovou úroveň schopnosti.

### ? Kolik cílů governance a managementu obsahuje COBIT 2019?

- [x] 40
- [ ] 37
- [ ] 34
- [ ] 5

> COBIT 2019 má 40 cílů (5 governance v EDM a 35 managementu). Číslo 37 odpovídá počtu procesů v COBIT 5, 5 je počet cílů jen v doméně EDM.

### ? Firma chce posílit řízení kvality, vlastnictví a životního cyklu dat napříč svými systémy. Který cíl COBIT 2019 se toho týká přímo?

- [ ] DSS01 Řízený provoz
- [x] APO14 Řízená data
- [ ] BAI06 Řízené IT změny
- [ ] EDM05 Zajištěné zapojení zainteresovaných stran

> Řízení dat jako podnikového aktiva pokrývá cíl APO14 Řízená data, nově zařazený v COBIT 2019. Ostatní cíle se týkají provozu, změn a komunikace se zainteresovanými stranami.

## Komponenty systému governance {#komponenty-governance .term}

Podle COBIT 2019 tvoří systém governance **sedm komponent** (v COBIT 5 nazývaných enablers): **procesy**; **organizační struktury**; **principy, politiky a postupy**; **informace**; **kultura, etika a chování**; **lidé, dovednosti a kompetence**; **služby, infrastruktura a aplikace**. Aby byl cíl governance či managementu naplněn, musí spolupracovat všechny potřebné komponenty, nejen procesy.

### ? Firma zavedla proces řízení změn, ale zaměstnanci ho běžně obcházejí, protože „se to tu tak nedělá". Na kterou komponentu systému governance se má zaměřit?

- [ ] Informace
- [ ] Služby, infrastruktura a aplikace
- [x] Kultura, etika a chování
- [ ] Organizační struktury

> Proces formálně existuje, ale selhává chování lidí a zažité zvyklosti. Jde o komponentu kultura, etika a chování.

### ? Která z možností NENÍ komponentou systému governance podle COBIT 2019?

- [ ] Procesy
- [ ] Organizační struktury
- [ ] Lidé, dovednosti a kompetence
- [x] Strategické cíle podniku

> Podnikové cíle jsou součástí kaskády cílů, ne komponentou systému governance. Procesy, organizační struktury a lidé, dovednosti a kompetence patří mezi sedm komponent.

## Kaskáda cílů {#kaskada-cilu .explain}

**Kaskáda cílů (goals cascade)** převádí potřeby zainteresovaných stran na konkrétní priority informatiky: **potřeby zainteresovaných stran** → **podnikové cíle** (enterprise goals) → **cíle sladění** (alignment goals; v COBIT 5 „cíle související s IT") → **cíle governance a managementu**. Podnikové cíle a cíle sladění jsou uspořádány podle dimenzí **Balanced Scorecard** (finanční, zákaznická, interní, učení a růst). Kaskáda tak propojuje firemní a informační strategii a ukazuje, které cíle COBIT jsou pro firmu důležité.

*Příklad:* Podnikový cíl „spokojenost zákazníků" vede k cíli sladění „poskytování IT služeb v souladu s požadavky byznysu" a ten k prioritě cílů pro řízení dohod o službách a incidentů.

### ? Na co se v kaskádě cílů COBIT 2019 převádějí podnikové cíle (enterprise goals)?

- [x] Na cíle sladění (alignment goals)
- [ ] Na faktory návrhu (design factors)
- [ ] Na osobní cíle zaměstnanců útvaru IT
- [ ] Na úrovně schopnosti procesů

> Kaskáda pokračuje od podnikových cílů k cílům sladění a od nich k cílům governance a managementu. Design factors a úrovně schopnosti jsou samostatné nástroje přizpůsobení a hodnocení.

### ? Podle jakých dimenzí jsou podnikové cíle a cíle sladění v COBIT 2019 uspořádány?

- [ ] Podle vrstev podnikové architektury
- [x] Podle dimenzí Balanced Scorecard
- [ ] Podle domén EDM, APO, BAI, DSS, MEA
- [ ] Podle fází životního cyklu aplikace

> Podnikové cíle i cíle sladění se člení podle čtyř dimenzí BSC: finanční, zákaznické, interní a učení a růstu. Domény slouží ke členění cílů governance a managementu.

## Faktory návrhu (design factors) {#design-factors .explain}

COBIT 2019 se **přizpůsobuje konkrétnímu podniku** pomocí **faktorů návrhu (design factors)**. Rámec jich uvádí 11: podniková strategie, podnikové cíle, rizikový profil, problémy související s I&T, prostředí hrozeb, požadavky na soulad (compliance), role IT, model sourcingu IT, metody implementace IT (např. agilní, DevOps, tradiční), strategie přijímání technologií a velikost podniku. Podle nich se stanoví priority cílů governance a managementu a jejich cílové úrovně schopnosti. Doplňkem jsou **oblasti zaměření (focus areas)**, např. malé a střední podniky, kybernetická bezpečnost či DevOps.

*Příklad:* Malá e-commerce firma s veškerou infrastrukturou v cloudu klade vyšší prioritu na řízení dodavatelů a dohod o službách než na vlastní provoz datového centra.

### ? Banka v silně regulovaném prostředí upraví systém governance podle COBIT tak, aby měly vyšší prioritu cíle v oblasti rizik a souladu s předpisy. Který nástroj COBIT 2019 tím využívá?

- [ ] Úrovně schopnosti procesů
- [ ] Praktiky správy služeb ITIL
- [ ] Domény managementu
- [x] Faktory návrhu (design factors)

> Faktory návrhu (zde rizikový profil a požadavky na compliance) slouží k přizpůsobení systému governance konkrétnímu podniku a určení priorit cílů.

### ? Který z uvedených NENÍ faktorem návrhu (design factor) podle COBIT 2019?

- [ ] Model sourcingu IT
- [ ] Rizikový profil
- [x] Programovací jazyk hlavních aplikací
- [ ] Velikost podniku

> Faktory návrhu popisují strategický a organizační kontext podniku (strategie, rizika, sourcing, velikost…). Konkrétní programovací jazyk mezi ně nepatří.

## Úrovně schopnosti procesů {#urovne-schopnosti .compare}

COBIT 2019 hodnotí procesy na škále **úrovní schopnosti (capability levels) 0–5** vycházející z **CMMI** (COBIT 5 vycházel z normy ISO/IEC 15504).

| Úroveň | Charakteristika procesu |
|---|---|
| 0 | chybí základní schopnost, přístup je neúplný |
| 1 | účel dosahován neúplnou sadou činností, spíše intuitivně a neorganizovaně |
| 2 | účel dosahován základní, ale úplnou sadou činností (proces se provádí) |
| 3 | proces je dobře definován a dosahuje účelu organizovaně s využitím podnikových standardů |
| 4 | definovaný proces s kvantitativně měřenou výkonností |
| 5 | měřený proces se neustále zlepšuje |

Pro oblasti zaměření se obdobně používají úrovně vyspělosti (maturity levels).

### ? Proces řízení incidentů je zdokumentován a jednotně definován v celé firmě, jeho výkonnost se ale zatím kvantitativně neměří. Jakou úroveň schopnosti podle COBIT 2019 nejspíše má?

- [ ] Úroveň 2
- [x] Úroveň 3
- [ ] Úroveň 4
- [ ] Úroveň 5

> Dobře definovaný a standardizovaný proces odpovídá úrovni 3. Úroveň 4 by vyžadovala kvantitativní měření výkonnosti, úroveň 5 navíc soustavné zlepšování.

### ? Ze kterého modelu vychází škála úrovní schopnosti procesů v COBIT 2019?

- [x] CMMI
- [ ] ISO/IEC 15504
- [ ] ITIL 4
- [ ] TOGAF

> COBIT 2019 používá škálu 0–5 založenou na CMMI. Norma ISO/IEC 15504 byla základem hodnocení procesů v předchozím COBIT 5.

## COBIT × ITIL {#cobit-vs-itil .compare}

Rámce se navzájem doplňují: COBIT určuje, co má být v informatice řízeno a kontrolováno, ITIL podrobně popisuje, jak poskytovat a spravovat IT služby.

| | COBIT | ITIL |
|---|---|---|
| Zaměření | governance a management celé podnikové informatiky | správa IT služeb (IT service management) |
| Hlavní otázka | **co** řídit a kontrolovat, vazba na podnikové cíle | **jak** služby navrhovat, poskytovat a zlepšovat |
| Hlavní prvky (aktuální verze) | 40 cílů governance a managementu, komponenty, design factors | systém hodnoty služeb, hodnotový řetězec služeb, praktiky (např. řízení incidentů, změn, úrovně služeb) |
| Typický uživatel | vedení, CIO, auditoři, řízení rizik | útvar IT, service desk, provoz |

### ? Útvar IT chce podle osvědčených postupů zlepšit každodenní řízení incidentů a práci service desku. Který rámec mu nabízí nejpodrobnější praktická doporučení?

- [ ] COBIT
- [ ] TOGAF
- [x] ITIL
- [ ] Balanced Scorecard

> ITIL je zaměřen na správu IT služeb a obsahuje podrobné praktiky jako řízení incidentů či service desk. COBIT stanoví, co má být řízeno, ale detailní postupy přenechává jiným rámcům.

### ? Jaký je typický vztah rámců COBIT a ITIL?

- [ ] ITIL nahradil COBIT a COBIT se dnes již nepoužívá
- [ ] COBIT je určen pro malé firmy, ITIL pro velké
- [ ] Oba popisují totéž a firma si musí vybrat jeden z nich
- [x] Doplňují se — COBIT určuje co řídit, ITIL jak spravovat služby

> COBIT a ITIL se používají společně: COBIT jako zastřešující rámec governance a managementu, ITIL jako podrobný návod pro správu IT služeb.

## Analýza informatiky obchodních partnerů {#analyza-partneru .explain}

Firma zkoumá, jaké informační systémy, standardy a kanály používají její **odběratelé, dodavatelé a další partneři**: zda podporují elektronickou výměnu dokladů (EDI, elektronické faktury), mají API nebo B2B portály, jak vyspělá je jejich informatika a jaký objem transakcí s nimi probíhá. Důležité jsou i **požadavky dominantních partnerů** (např. obchodní řetězec vyžaduje určitý formát objednávek). Z výsledků plyne návrh **elektronických obchodních a komunikačních kanálů** — často různých pro různé skupiny partnerů — a požadavky na integraci a bezpečnost vlastního IS. Samotné interorganizační systémy (EDI, B2B integrace) podrobně rozebírá téma 2.

*Příklad:* Výrobce potravin zjistí, že velké obchodní řetězce vyžadují objednávky a faktury přes EDI, zatímco drobní odběratelé objednávají e-mailem. Zavede EDI pro řetězce a webový B2B portál pro malé odběratele.

### ? Velký odběratel oznámí, že od příštího roku bude přijímat faktury pouze elektronicky ve svém standardním formátu. Co to znamená pro analýzu informatiky obchodních partnerů?

- [x] Je to vstup pro návrh vlastních elektronických kanálů
- [ ] Jde o interní záležitost odběratele bez vlivu na firmu
- [ ] Firma musí převzít celý informační systém odběratele
- [ ] Analýza partnerů se týká jen dodavatelů, nikoli odběratelů

> Analýza partnerů zjišťuje právě takové požadavky a standardy; jejich dopad se promítne do návrhu elektronických obchodních kanálů a integrace vlastního IS.

### ? Firma má stovky malých odběratelů bez vlastních IT kapacit a chce od nich přijímat objednávky elektronicky. Jaké řešení je pro tuto skupinu typicky nejvhodnější?

- [ ] Přímé napojení EDI na informační systém každého odběratele
- [x] Webový B2B portál pro zadávání objednávek
- [ ] Samostatná API integrace vyvinutá pro každého odběratele
- [ ] Vyhrazená pronajatá datová linka ke každému odběrateli

> Malí partneři bez IT kapacit obvykle nezvládnou EDI ani API integraci; webový portál jim stačí prohlížeč. EDI a API se vyplácejí u velkých partnerů s velkým objemem transakcí.

## Analýza řízení informatiky ve vazbě na řízení organizace {#analyza-rizeni-informatiky .explain}

Analýza zkoumá, jak je řízení informatiky **zapojeno do řízení celé organizace**: kdo o informatice rozhoduje a jak se zapojuje vrcholové vedení, zda jsou cíle IT odvozeny z firemní strategie, jak se IT plánuje, financuje a měří a jak spolupracují útvar IT a byznys. Postupuje se od **symptomů** (stížnosti uživatelů, incidenty, zjištění auditu, rostoucí náklady) k jejich **příčinám** a k identifikaci **klíčových problémů**, které se pak kategorizují a prioritizují. Inspirací je seznam typických problémů souvisejících s I&T, který COBIT 2019 používá jako jeden z design factors (např. napětí mezi byznysem a IT, závažné incidenty, problémy s outsourcery, opakovaná zjištění auditu, skryté výdaje na IT, duplicitní iniciativy, nedostatek IT zdrojů).

*Příklad:* Stížnosti obchodníků na pomalé dodání úprav CRM ukážou jako příčinu chybějící prioritizaci požadavků na úrovni vedení, nikoli nízký výkon programátorů.

### ? Při analýze řízení informatiky se zjistí, že obchodní oddělení si samo kupuje a provozuje cloudové aplikace bez vědomí útvaru IT. Jak se tento jev nazývá?

- [ ] Outsourcing informatiky
- [ ] Selektivní sourcing
- [ ] Interní chargeback
- [x] Stínové IT (shadow IT)

> Stínové IT jsou aplikace a služby pořízené mimo kontrolu útvaru IT. Bývá symptomem nedostatečného sladění IT s potřebami byznysu a zdrojem skrytých nákladů a rizik.

### ? Proč se při analýze řízení informatiky odlišují symptomy od příčin?

- [ ] Aby bylo možné snadno určit viníka problému
- [ ] Protože symptomy lze z analýzy úplně vynechat
- [x] Aby opatření řešila skutečný kořen problému, ne jen jeho projevy
- [ ] Protože příčiny se vždy nacházejí jen v útvaru IT

> Odstranění symptomu bez řešení příčiny vede k opakování problému. Příčiny navíc často leží mimo útvar IT — např. v rozhodování vedení nebo v organizaci.

## Kategorizace klíčových problémů informatiky {#kategorizace-problemu .compare}

Identifikované problémy se třídí do kategorií, aby šlo určit odpovědnost a navrhnout opatření; následně se prioritizují podle **dopadu na cíle organizace a naléhavosti**. Jde o jedno z možných členění:

| Kategorie | Příklady problémů |
|---|---|
| Strategická (sladění s byznysem) | IT projekty nenaplňují potřeby byznysu, chybí aktuální informační strategie |
| Organizační a řídicí | nejasné rozhodovací pravomoci, vedení se nezapojuje, stínové IT |
| Procesní | neřízené změny, opakující se incidenty, chybějící katalog služeb |
| Aplikační a technologická | duplicitní aplikace, zastaralé systémy, slabá integrace |
| Lidské zdroje | nedostatek kapacit a odborných dovedností |
| Ekonomická | skryté náklady na IT, neprokázané přínosy investic |
| Rizika, bezpečnost, soulad | bezpečnostní incidenty, nesplnění regulatorních požadavků |
| Dodavatelská | nízká kvalita služeb dodavatelů, závislost na dodavateli |

### ? Firma provozuje tři různé systémy pro evidenci zákazníků, které si navzájem nepředávají data. Do které kategorie problému to nejlépe patří?

- [x] Aplikační a technologická
- [ ] Lidské zdroje
- [ ] Dodavatelská
- [ ] Ekonomická

> Duplicitní a neintegrované aplikace jsou problémem aplikační architektury a technologií. Mohou mít ekonomické důsledky, ale jejich podstata je aplikační.

### ? Podle čeho se kategorizované klíčové problémy informatiky typicky prioritizují?

- [ ] Podle abecedního pořadí kategorií
- [x] Podle dopadu na cíle organizace a naléhavosti
- [ ] Podle toho, který útvar problém nahlásil první
- [ ] Podle počtu dotčených serverů

> Prioritu určuje, jak silně problém ohrožuje cíle organizace a jak rychle je třeba ho řešit. Technické ukazatele bez vazby na byznys o prioritě nevypovídají.

## Analýza obchodního a smluvního zajištění IT služeb {#smluvni-zajisteni .explain}

Analýza zjišťuje, jak je zajištěno poskytování informačních služeb uživatelským útvarům. Zahrnuje **inventuru smluv** (outsourcing, cloud, licence, údržba a podpora, telekomunikace) a **přiřazení služeb ke smlouvám** — které služby jsou kryty smlouvou s dodavatelem a které interní dohodou útvaru IT s uživateli (katalog služeb, dohody o úrovni služeb; podrobně téma 9). Hodnotí se úplnost pokrytí, sjednané parametry a sankce, doba trvání a výpovědní podmínky, **exit strategie** (vrácení dat, převod služby), dodržování licencí, přiměřenost cen a **závislost na dodavateli** (vendor lock-in). V COBIT 2019 tuto oblast pokrývají zejména **APO09 Řízené dohody o službách** a **APO10 Řízení dodavatelů**.

*Příklad:* Firma zjistí, že kritický mzdový systém provozuje externí dodavatel na základě smlouvy bez definované doby obnovy po výpadku, a smlouvu doplní.

### ? Analýza smluv ukázala, že smlouva s poskytovatelem cloudového ERP neřeší, jak a v jakém formátu firma získá svá data po ukončení spolupráce. Jaké riziko tím nejvíce roste?

- [ ] Riziko nedostatečné výpočetní kapacity
- [ ] Riziko porušení licenčních podmínek
- [x] Závislost na dodavateli (vendor lock-in)
- [ ] Riziko nízké spokojenosti uživatelů

> Bez sjednané exit strategie a vrácení dat je odchod k jinému dodavateli obtížný a drahý — roste závislost na stávajícím dodavateli.

### ? Který cíl COBIT 2019 se přímo týká řízení vztahů s dodavateli IT?

- [ ] DSS02 Řízené požadavky na služby a incidenty
- [ ] BAI03 Řízená identifikace a vytváření řešení
- [ ] EDM02 Zajištěné dodání přínosů
- [x] APO10 Řízení dodavatelů

> Výběr dodavatelů, řízení smluv, vztahů a jejich výkonnosti pokrývá cíl APO10 v doméně APO. Ostatní cíle se týkají incidentů, vytváření řešení a přínosů.

### ? Útvar IT zajišťuje obchodnímu oddělení provoz CRM, ale nikde není stanoveno, jakou dostupnost a podporu má poskytovat. Co analýza smluvního zajištění typicky doporučí?

- [x] Popsat službu v katalogu služeb a sjednat s uživateli interní dohodu o úrovni služby
- [ ] Ponechat stav beze změny, protože jde o interní vztah
- [ ] Převést provoz CRM bez dalšího posouzení k externímu dodavateli
- [ ] Zrušit podporu CRM, dokud obchodní oddělení nezaplatí licenci

> I interní služby potřebují definované parametry — katalog služeb a dohoda o úrovni služby určují, co má útvar IT uživatelům zajistit. Bez nich nelze kvalitu služby měřit ani vymáhat.
