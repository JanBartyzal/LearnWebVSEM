---
kind: topic
subject: togaf-foundation
slug: faze-b-c-d
name: "ADM — Phases B, C, D"
order: 4
---

Business Architecture, Information Systems Architectures (Data, Application), Technology Architecture: cíle, Baseline × Target, Gap Analysis, kandidátní Architecture Roadmap Components, Architecture Definition Document a Architecture Requirements Specification.

## Fáze vývoje architektur domén (Phases B, C, D) {#faze-bcd-prehled .explain}

Fáze **B (Business Architecture)**, **C (Information Systems Architectures — Data a Application)** a **D (Technology Architecture)** převádějí vysokoúrovňovou Architecture Vision z Phase A na podrobný popis jednotlivých architektonických domén. Každá z nich postupuje **stejnou kostrou kroků**: popíše výchozí (Baseline) a cílovou (Target) architekturu své domény, porovná je analýzou mezer (Gap Analysis) a z mezer odvodí kandidátní komponenty Architecture Roadmap. Výsledky se průběžně zapisují do Architecture Definition Document a Architecture Requirements Specification, které v těchto fázích existují jako **pracovní verze (draft)**: ADD existuje jako draft už od Phase A a ve fázích B–D se doplňuje o detailní architektury domén; ARS vzniká jako draft v Phase B. Oba se finalizují v Phase F. Plánování realizace (sloučení mezer do work packages, přechodové architektury) už není jejich úkolem — to přichází ve fázích E a F.

*Příklad:* Pojišťovna chce prodávat pojistky online. Phase B popíše nový prodejní proces a role, Phase C potřebná data o klientech a aplikace pro online sjednání, Phase D platformu a infrastrukturu, na které poběží.

### ? Které fáze ADM rozpracovávají podrobné architektury jednotlivých domén (business, data, aplikace, technologie)?

- [ ] Phase A, Phase B a Phase E
- [ ] Phase E, Phase F a Phase G
- [x] Phase B, Phase C a Phase D
- [ ] Preliminary Phase, Phase A a Phase H

> Architektury domén vznikají ve fázích B (Business), C (Data a Application) a D (Technology). Phase A tvoří jen vysokoúrovňovou vizi, fáze E–G se věnují plánování a řízení realizace.

### ? Co mají Phases B, C a D v ADM společné?

- [ ] Každá z nich končí podpisem Architecture Contract s realizačním týmem
- [x] Postupují stejnými kroky od Baseline a Target přes Gap Analysis k roadmapě
- [ ] Každá z nich sestavuje vlastní Implementation and Migration Plan své domény
- [ ] Všechny tři vytvářejí nový Statement of Architecture Work pro svou doménu

> Fáze B, C i D sdílejí stejnou strukturu kroků: popis Baseline a Target, Gap Analysis, kandidátní komponenty roadmapy, posouzení dopadů, revize a finalizace. Architecture Contract patří do Phase G, Implementation and Migration Plan do Phase F a Statement of Architecture Work vzniká v Phase A.

## Phase B: Business Architecture — cíle {#faze-b-cile .term}

Phase B vytváří **cílovou Business Architecture**, tedy popis, jak má podnik fungovat (organizace, schopnosti, procesy, služby, informace), aby dosáhl svých business cílů a reagoval na strategické podněty (business drivers) z Architecture Vision — v souladu s Request for Architecture Work a se zájmy stakeholderů. Druhým cílem je najít **kandidátní komponenty Architecture Roadmap** na základě mezer mezi Baseline a Target Business Architecture.

### ? Co je hlavním cílem Phase B?

- [ ] Vybrat technologickou platformu, na které budou provozovány podnikové aplikace
- [ ] Sestavit harmonogram projektů, které převedou podnik do cílového stavu
- [ ] Stanovit organizační model architektonické funkce a přizpůsobit rámec TOGAF
- [x] Popsat, jak má podnik fungovat, aby splnil cíle z Architecture Vision

> Phase B vyvíjí cílovou Business Architecture — jak má podnik fungovat, aby splnil své cíle. Volba platformy patří do Phase D, harmonogram projektů do Phase F a organizační model architektury do Preliminary Phase.

### ? Na základě čeho Phase B identifikuje kandidátní komponenty Architecture Roadmap?

- [x] Na základě mezer mezi Baseline a Target Business Architecture
- [ ] Na základě výsledků Compliance Review probíhajících projektů
- [ ] Na základě požadavků na změnu evidovaných v Phase H
- [ ] Na základě rozpočtu schváleného v Architecture Contract

> Kandidátní komponenty roadmapy se v každé z fází B, C a D odvozují z mezer mezi výchozím a cílovým stavem dané domény. Compliance Review a Architecture Contract patří do Phase G, požadavky na změnu do Phase H.

## Proč je Business Architecture první {#business-prvni .explain}

Znalost Business Architecture je **předpokladem** architektonické práce ve všech ostatních doménách — data, aplikace i technologie mají smysl jen tehdy, když podporují to, co podnik skutečně potřebuje dělat. Proto ADM zařazuje Phase B před fáze C a D. Phase B zároveň slouží k ověření, že vize je reálná: **validuje business principy, business cíle a business drivers** z Phase A a v případě potřeby je zpřesní. Pokud podnik už aktuální popis byznysu má (např. z dřívějších strategických prací), Phase B na něj naváže a doplní jen to, co chybí.

*Příklad:* Banka chce nový core systém. Než architekti začnou řešit databáze a servery, musí v Phase B ujasnit, jaké produkty a procesy bude banka provozovat — jinak hrozí technicky dokonalé řešení pro nesprávný byznys.

### ? Proč ADM zařazuje Phase B (Business Architecture) před Phases C a D?

- [ ] Protože Phase B je jediná fáze, ve které se provádí Gap Analysis
- [ ] Protože v Phase B se schvaluje rozpočet na celou iteraci ADM
- [x] Protože znalost byznysu podmiňuje práci v ostatních doménách
- [ ] Protože Phase B nahrazuje Phase A, je-li vize už schválená

> Data, aplikace i technologie mají podporovat potřeby byznysu, proto je Business Architecture předpokladem ostatních domén. Gap Analysis se provádí ve všech fázích B, C a D a Phase B Phase A nenahrazuje.

### ? Co Phase B typicky validuje a případně zpřesňuje z výstupů Phase A?

- [ ] Technologické principy a standardy infrastruktury
- [x] Business principy, business cíle a business drivers
- [ ] Podmínky Architecture Contract a kritéria souladu
- [ ] Organizační model a Tailored Architecture Framework

> Výstupem Phase B jsou mimo jiné validované business principy, cíle a drivers. Technologické principy validuje Phase D, Architecture Contract je věcí Phase G a organizační model i Tailored Architecture Framework vznikají v Preliminary Phase.

## Obsah Business Architecture {#business-obsah .term}

Business Architecture popisuje podnik z pohledu byznysu, bez ohledu na konkrétní IT. Typicky zahrnuje **business capabilities** (co podnik umí dělat), **value streams** (jak dodává hodnotu zákazníkovi), organizační strukturu a role, business funkce, procesy a služby a informace, se kterými byznys pracuje. Popisuje „co a kdo", nikoli „na čem to běží".

### ? Který prvek typicky NEPATŘÍ do Business Architecture?

- [ ] Value streams, kterými podnik dodává hodnotu zákazníkovi
- [ ] Organizační jednotky a role, které vykonávají činnosti
- [ ] Business capabilities, které podnik potřebuje k plnění cílů
- [x] Konfigurace serverů a sítí pro provoz informačních systémů

> Servery a sítě jsou předmětem Technology Architecture (Phase D). Value streams, organizace a role i business capabilities jsou typickým obsahem Business Architecture.

## Phase C: Information Systems Architectures {#faze-c-struktura .explain}

Phase C pokrývá dvě domény — **Data Architecture** a **Application Architecture** — a obě dohromady se označují jako Information Systems Architectures. TOGAF nepředepisuje, kterou z nich začít: lze je rozpracovat **v libovolném pořadí, postupně i souběžně**, podle povahy projektu (datově orientované iniciativy obvykle začínají daty, nasazení aplikačních balíků aplikacemi). Obě části však musí být navzájem sladěné a obě musí podporovat Business Architecture z Phase B. Každá doména prochází stejnými kroky jako ostatní fáze (Baseline, Target, Gap Analysis, kandidátní komponenty roadmapy…).

*Příklad:* Při zavádění datového skladu tým začne Data Architecture (jaká data, odkud, v jaké kvalitě) a teprve poté navrhne aplikace pro reporting.

### ? Které dvě architektonické domény pokrývá Phase C (Information Systems Architectures)?

- [ ] Business Architecture a Technology Architecture
- [ ] Application Architecture a Technology Architecture
- [ ] Data Architecture a Security Architecture
- [x] Data Architecture a Application Architecture

> Phase C se skládá z Data Architecture a Application Architecture. Business Architecture je Phase B, Technology Architecture Phase D; bezpečnost se v TOGAF prolíná všemi doménami, není samostatnou částí Phase C.

### ? Jak TOGAF určuje pořadí vývoje Data a Application Architecture v Phase C?

- [x] Pořadí je volné, lze je vyvíjet postupně v libovolném pořadí i souběžně
- [ ] Vždy se nejdřív dokončí Application Architecture, teprve pak Data Architecture
- [ ] Vždy se nejdřív dokončí Data Architecture, teprve pak Application Architecture
- [ ] Data Architecture se vyvíjí v Phase C, Application Architecture až v Phase D

> TOGAF nechává pořadí na architektovi — obě domény lze vyvíjet postupně v libovolném pořadí nebo paralelně, podle povahy práce. Obě přitom patří do Phase C.

## Phase C: Data Architecture — cíle {#data-cile .term}

Data Architecture v Phase C vytváří **cílovou Data Architecture**, která umožní realizovat Business Architecture a Architecture Vision (v souladu s Request for Architecture Work a zájmy stakeholderů), a identifikuje kandidátní komponenty roadmapy z mezer mezi Baseline a Target Data Architecture. Popisuje hlavní **typy a zdroje dat** potřebných pro podporu byznysu, a to tak, aby byl popis srozumitelný stakeholderům, úplný, konzistentní a stabilní.

### ? Co je předmětem cílové Data Architecture vyvíjené v Phase C?

- [ ] Konkrétní databázové servery a jejich umístění v datových centrech
- [x] Hlavní typy a zdroje dat potřebné pro podporu byznysu a jejich vztahy
- [ ] Organizační struktura útvarů, které s daty v podniku pracují
- [ ] Harmonogram migrace dat sestavený pro jednotlivé work packages

> Data Architecture popisuje logická a fyzická datová aktiva podniku — hlavní typy a zdroje dat potřebné pro byznys. Servery patří do Phase D, organizační struktura do Phase B a harmonogram migrace do Phases E a F.

## Klíčová témata Data Architecture {#data-temata .explain}

Při vývoji Data Architecture TOGAF zdůrazňuje tři oblasti úvah. **Data management** — jak podnik data vytváří, ukládá, sdílí a udržuje napříč aplikacemi (např. které aplikace jsou zdrojem kmenových dat). **Data migration** — při nahrazování stávajících aplikací je třeba převést data ze starých systémů do nových a počítat s jejich čištěním a transformací. **Data governance** — podnik musí mít strukturu, procesy a lidi, kteří za data odpovídají (vlastnictví dat, pravidla kvality).

*Příklad:* Výrobce slučuje tři ERP systémy do jednoho. Data Architecture musí řešit, který systém bude zdrojem kmenových dat zákazníků (management), jak se převedou historická data (migration) a kdo rozhodne o pravidlech kvality (governance).

### ? Firma nahrazuje dva starší CRM systémy jedním novým. Která oblast úvah Data Architecture se zabývá převodem a vyčištěním dat ze starých systémů?

- [ ] Data governance
- [ ] Data management
- [x] Data migration
- [ ] Data modeling

> Převod dat ze stávajících systémů do nových (včetně čištění a transformace) je předmětem data migration. Data governance řeší odpovědnost a pravidla, data management obecné vytváření, ukládání a sdílení dat.

### ? Která oblast úvah Data Architecture zajišťuje, že podnik má strukturu, procesy a lidi odpovědné za data?

- [x] Data governance
- [ ] Data migration
- [ ] Data integration
- [ ] Data warehousing

> Data governance zajišťuje, že za data někdo odpovídá — vlastnictví, pravidla kvality, rozhodovací procesy. Data migration se týká převodu dat mezi systémy; integrace a datové sklady nejsou mezi třemi hlavními oblastmi úvah, které TOGAF u Data Architecture uvádí.

## Phase C: Application Architecture — cíle {#aplikace-cile .term}

Application Architecture v Phase C vytváří **cílovou Application Architecture**, která umožní realizovat Business Architecture a Architecture Vision, a identifikuje kandidátní komponenty roadmapy z mezer mezi Baseline a Target Application Architecture. Určuje, **jaké druhy aplikačních systémů** podnik potřebuje a co musí dělat, aby spravovaly data a poskytovaly informace lidem i jiným systémům. Aplikace se zde popisují jako **logické skupiny schopností**, ne jako konkrétní softwarové produkty — nejde o návrh aplikací.

### ? Jak Application Architecture v Phase C typicky popisuje aplikace?

- [ ] Jako konkrétní softwarové produkty včetně dodavatelů, verzí a licencí
- [ ] Jako zdrojový kód a technický návrh jednotlivých modulů
- [x] Jako logické skupiny schopností pro správu dat a podporu byznysu
- [ ] Jako servery a sítě, na kterých jsou aplikace nasazeny

> Application Architecture určuje, jaké druhy aplikací podnik potřebuje a co mají dělat; popisuje je logicky, ne jako konkrétní produkty ani návrh softwaru. Servery a sítě patří do Technology Architecture.

### ? Co NENÍ cílem Application Architecture v Phase C?

- [ ] Určit, jaké druhy aplikačních systémů podnik potřebuje
- [x] Navrhnout podrobný vnitřní design jednotlivých aplikací
- [ ] Identifikovat kandidátní komponenty Architecture Roadmap
- [ ] Popsat, jak aplikace spravují data a poskytují informace

> Application Architecture se nezabývá detailním návrhem aplikací — to je práce realizačních projektů. Jejím cílem je určit potřebné druhy aplikací, jejich úlohu vůči datům a byznysu a kandidátní komponenty roadmapy.

## Phase D: Technology Architecture — cíle {#faze-d-cile .term}

Phase D vytváří **cílovou Technology Architecture**, která umožní nasadit logické i fyzické aplikační a datové komponenty a naplnit Architecture Vision (v souladu s Request for Architecture Work a zájmy stakeholderů), a identifikuje kandidátní komponenty roadmapy z mezer mezi Baseline a Target Technology Architecture. Popisuje softwarové a hardwarové schopnosti potřebné pro provoz byznysových, datových a aplikačních služeb — infrastrukturu, middleware, sítě, komunikace, zpracování a technologické standardy.

### ? Co je hlavním cílem Phase D (Technology Architecture)?

- [ ] Popsat procesy a role, kterými podnik dodává hodnotu zákazníkům
- [ ] Určit druhy aplikací a data, která mají tyto aplikace spravovat
- [ ] Rozdělit mezery do work packages a definovat přechodové architektury
- [x] Popsat technologie pro nasazení aplikačních a datových komponent

> Phase D popisuje infrastrukturu a technologické schopnosti, na kterých poběží aplikace a data. Procesy a role patří do Phase B, druhy aplikací do Phase C a work packages s přechodovými architekturami do Phase E.

### ? Architekt v rámci ADM popisuje servery, síťovou infrastrukturu, middleware a technologické standardy. Ve které fázi pracuje?

- [x] Phase D
- [ ] Phase C
- [ ] Phase E
- [ ] Phase G

> Infrastruktura, middleware a technologické standardy jsou obsahem Technology Architecture, kterou vyvíjí Phase D. Phase C řeší data a aplikace, Phase E příležitosti a řešení, Phase G governance realizace.

## Společné kroky fází B, C a D {#spolecne-kroky .explain}

Každá z fází B, C (Data i Application) a D postupuje stejnými kroky; jejich pořadí lze podle potřeby přizpůsobit:

1. **Select Reference Models, Viewpoints, and Tools** — výběr referenčních modelů, hledisek a nástrojů.
2. **Develop Baseline Architecture Description** — popis výchozího stavu domény.
3. **Develop Target Architecture Description** — popis cílového stavu domény.
4. **Perform Gap Analysis** — porovnání výchozího a cílového stavu.
5. **Define Candidate Roadmap Components** — kandidátní komponenty roadmapy.
6. **Resolve Impacts Across the Architecture Landscape** — dopady na celou architektonickou krajinu.
7. **Conduct Formal Stakeholder Review** — formální revize se stakeholdery.
8. **Finalize the Architecture** — dokončení architektury domény.
9. **Create the Architecture Definition Document** — zapracování výsledků do ADD.

*Příklad:* V Phase D architekt nejprve zvolí referenční model a hlediska pro provozní tým, popíše stávající a cílovou infrastrukturu, najde mezery, sestaví z nich kandidátní komponenty roadmapy, ověří dopady na jiné projekty a nechá výsledek schválit.

### ? Který krok je prvním ze společných kroků fází B, C a D?

- [ ] Perform Gap Analysis
- [ ] Develop Baseline Architecture Description
- [ ] Conduct Formal Stakeholder Review
- [x] Select Reference Models, Viewpoints, and Tools

> Společné kroky začínají výběrem referenčních modelů, hledisek (viewpoints) a nástrojů; teprve pak následuje popis Baseline a Target a Gap Analysis. Formální revize se stakeholdery přichází až ke konci.

### ? Který krok NEPATŘÍ mezi společné kroky fází B, C a D?

- [ ] Define Candidate Roadmap Components
- [ ] Resolve Impacts Across the Architecture Landscape
- [x] Formulate the Implementation and Migration Plan
- [ ] Conduct Formal Stakeholder Review

> Implementation and Migration Plan se sestavuje v Phase F. Kandidátní komponenty roadmapy, řešení dopadů na krajinu i formální revize se stakeholdery jsou společnými kroky fází B, C a D.

### ? Který krok ve fázích B, C a D bezprostředně navazuje na popis Baseline a Target Architecture?

- [x] Perform Gap Analysis
- [ ] Finalize the Architecture
- [ ] Conduct Formal Stakeholder Review
- [ ] Select Reference Models, Viewpoints, and Tools

> Jakmile je popsán výchozí i cílový stav, porovnají se v Gap Analysis. Výběr referenčních modelů a nástrojů je krokem prvním, revize se stakeholdery a finalizace přicházejí až po definici kandidátních komponent roadmapy a řešení dopadů.

## Výběr referenčních modelů, hledisek a nástrojů {#krok-vyber .explain}

Prvním krokem každé z fází B–D je připravit si „pracovní výbavu". Architekt určí, které **referenční modely** a další zdroje (z Architecture Repository, z odvětví nebo veřejně dostupné) využije, aby nemusel začínat od nuly. Vybere **viewpoints**, které ukážou, jak architektura řeší zájmy (concerns) jednotlivých stakeholderů, a podle nich i artefakty, které vytvoří. Nakonec zvolí **nástroje a techniky** pro zachycení, modelování a analýzu architektury. Tím se určí i celkový způsob modelování v dané doméně.

*Příklad:* Při Technology Architecture tým využije technický referenční model jako kontrolní seznam platformních služeb a pro bezpečnostní oddělení zvolí hledisko zaměřené na umístění a ochranu dat.

### ? Proč architekt v prvním kroku fází B, C a D vybírá viewpoints?

- [x] Aby ukázal, jak architektura řeší zájmy jednotlivých stakeholderů
- [ ] Aby určil, kteří stakeholdeři budou podepisovat Architecture Contract
- [ ] Aby stanovil pořadí, ve kterém budou realizovány work packages
- [ ] Aby nahradil formální revizi architektury se stakeholdery

> Hlediska (viewpoints) se volí tak, aby výsledné pohledy ukázaly, jak architektura řeší zájmy (concerns) stakeholderů. Architecture Contract a pořadí work packages jsou věcí pozdějších fází a formální revizi nenahrazují.

### ? K čemu slouží referenční modely vybrané na začátku Phases B, C a D?

- [ ] Nahrazují popis výchozího stavu, který pak není třeba zpracovat
- [ ] Určují, kteří dodavatelé budou realizovat cílovou architekturu
- [x] Poskytují ověřený výchozí rámec, takže se nezačíná od nuly
- [ ] Slouží jako smluvní podklad pro Architecture Compliance Review

> Referenční modely jsou opakovaně použitelný výchozí rámec (např. seznam typických služeb či prvků domény), který urychluje práci a zlepšuje úplnost. Popis Baseline nenahrazují a s výběrem dodavatelů ani s Compliance Review přímo nesouvisejí.

## Popis výchozí architektury (Baseline) {#krok-baseline .explain}

Ve druhém kroku se popisuje **současný stav** domény (Baseline Architecture), ale jen **v rozsahu nezbytném pro podporu cílové architektury**. Míra detailu závisí na tom, kolik stávajících prvků se do cílového stavu přenese a zda už existují použitelné popisy. Architekt proto nejprve využije, co je k dispozici v **Architecture Repository** (dřívější architektury, stavební bloky), a dokumentuje jen to, co chybí. Podrobné mapování všeho, co se stejně zruší, je plýtvání úsilím.

*Příklad:* Firma kompletně ruší starý systém pro správu skladů a nahrazuje ho cloudovou službou. Stačí stručně popsat, jaké funkce a data starý systém poskytuje, aby se nic neztratilo — jeho vnitřní detaily popisovat není třeba.

### ? Jak podrobně se ve fázích B, C a D popisuje Baseline Architecture?

- [ ] Vždy úplně a do posledního detailu, aby vznikla kompletní dokumentace
- [ ] Vůbec, protože ADM pracuje pouze s cílovou architekturou
- [ ] Jen tehdy, pokud to výslovně požaduje Architecture Board
- [x] V rozsahu potřebném pro podporu cílové architektury a Gap Analysis

> Baseline se popisuje jen do té míry, jaká je potřebná pro cílovou architekturu a porovnání stavů. Bez výchozího stavu by nešlo provést Gap Analysis, úplná dokumentace všeho by naopak byla zbytečně nákladná.

### ? Odkud má architekt při popisu Baseline Architecture nejprve čerpat?

- [ ] Z nabídek dodavatelů, kteří se ucházejí o realizaci řešení
- [x] Z existujících popisů a stavebních bloků v Architecture Repository
- [ ] Z Implementation and Migration Plan předchozího cyklu ADM
- [ ] Z Architecture Contract uzavřeného s realizačním projektem

> Existující architektonické popisy a stavební bloky v Architecture Repository je vhodné znovu použít, aby se nedokumentovalo duplicitně. Nabídky dodavatelů ani smlouvy výchozí stav nepopisují.

## Popis cílové architektury (Target) {#krok-target .term}

Třetí krok vytváří popis **cílového stavu** domény (Target Architecture) v rozsahu potřebném k naplnění Architecture Vision. Popis vychází ze zájmů stakeholderů, z architektonických principů a z požadavků; v doménách C a D navíc musí podporovat cílovou Business Architecture. Kde je to možné, opírá se o referenční modely a znovu použitelné stavební bloky.

### ? Čemu musí odpovídat Target Technology Architecture vyvinutá v Phase D?

- [x] Cílovým architekturám byznysu, dat a aplikací a Architecture Vision
- [ ] Výhradně stávající infrastruktuře, kterou podnik už vlastní
- [ ] Nabídce dodavatele, který vyhrál výběrové řízení na řešení
- [ ] Rozpočtu stanovenému v Implementation and Migration Plan

> Technologie má umožnit nasazení aplikačních a datových komponent, které podporují byznys, a naplnit Architecture Vision. Omezení na stávající infrastrukturu nebo nabídku dodavatele by porušilo princip, že architektura vychází z potřeb podniku; Implementation and Migration Plan vzniká až v Phase F.

## Gap Analysis ve fázích B, C a D {#gap-ve-fazich .explain}

Analýza mezer (Gap Analysis) je čtvrtým krokem každé z fází B–D: porovná Baseline a Target dané domény a ukáže, co je třeba **přidat, změnit nebo zrušit** — a také co se mohlo v cílovém stavu omylem vynechat. Výsledky se zapisují do Architecture Requirements Specification a Architecture Definition Document a jsou přímým podkladem pro **kandidátní komponenty Architecture Roadmap**. Mezery ze všech domén se pak v Phase E **konsolidují** a seskupují do work packages. Samotný postup techniky (matice mezer) je výkladem samostatné techniky ADM.

*Příklad:* Gap Analysis v Phase C ukáže, že cílová architektura potřebuje aplikaci pro elektronický podpis, která dnes neexistuje (nová položka), a že stávající faxový modul se zruší.

### ? Co je výsledkem Gap Analysis ve fázích B, C a D a k čemu slouží?

- [ ] Seznam smluvních pokut za nedodržení architektury v realizačních projektech
- [x] Rozdíly mezi Baseline a Target, z nichž vznikají komponenty roadmapy
- [ ] Ohodnocení zralosti architektonické funkce podle modelu vyspělosti
- [ ] Mapa stakeholderů rozdělená podle jejich vlivu a zájmu o projekt

> Gap Analysis zjišťuje rozdíly mezi Baseline a Target a z nich se odvozují kandidátní komponenty Architecture Roadmap. Hodnocení zralosti a mapa stakeholderů jsou jiné techniky; smluvní sankce s Gap Analysis nesouvisejí.

### ? Ve které fázi ADM se mezery identifikované ve fázích B, C a D konsolidují a seskupují do work packages?

- [ ] Phase A
- [ ] Phase D
- [ ] Phase G
- [x] Phase E

> Phase E (Opportunities and Solutions) slučuje výsledky Gap Analysis ze všech domén a seskupuje je do work packages. Fáze B–D mezery jen identifikují v rámci své domény.

## Kandidátní komponenty Architecture Roadmap {#kandidatni-roadmap .term}

Kandidátní komponenty roadmapy (Candidate Roadmap Components) jsou předběžné stavební kameny budoucí Architecture Roadmap: změny a aktivity odvozené z mezer dané domény, které je třeba provést, aby se podnik dostal z Baseline do Target. Ve fázích B, C a D je to výstup za každou doménu zvlášť (např. Business Architecture components of an Architecture Roadmap); v Phases E a F se sloučí, seřadí a rozpracují do konečné Architecture Roadmap.

### ? Proč se komponenty Architecture Roadmap vzniklé ve fázích B, C a D označují jako „kandidátní"?

- [ ] Protože je musí ještě schválit hlasování všech zaměstnanců podniku
- [x] Protože se teprve v Phases E a F sloučí, seřadí a dopracují
- [ ] Protože jsou volitelné a realizační projekty je mohou ignorovat
- [ ] Protože je architekt nahradí přímo podepsaným Architecture Contract

> Komponenty roadmapy z jednotlivých domén jsou předběžné — konečná Architecture Roadmap vzniká až jejich konsolidací a prioritizací v Phases E a F. Nejde o volitelné položky ani o náhradu smluv.

### ? Ze kterého podkladu se ve fázích B, C a D přímo odvozují kandidátní komponenty Architecture Roadmap?

- [ ] Z Request for Architecture Work, který zahájil cyklus ADM
- [ ] Z výsledků Business Transformation Readiness Assessment
- [x] Z výsledků Gap Analysis mezi Baseline a Target dané domény
- [ ] Z Architecture Contract uzavřeného v předchozím cyklu ADM

> Kandidátní komponenty roadmapy popisují změny potřebné k překonání mezer, takže vycházejí přímo z Gap Analysis. Request for Architecture Work iniciuje práci, ale konkrétní změny neobsahuje; Readiness Assessment hodnotí připravenost na změnu.

## Řešení dopadů na celou architektonickou krajinu {#dopady-krajina .explain}

Krok **Resolve Impacts Across the Architecture Landscape** zkoumá, jak navrhované změny v dané doméně působí **mimo vlastní projekt**. Architekt si klade otázky: Zasahuje návrh do již existujících architektur? Změnilo se nedávno něco, co by návrh měl zohlednit? Lze výsledky této práce využít jinde v podniku? Ovlivní návrh jiné projekty, nebo jiné projekty ovlivní tento návrh? Cílem je předejít konfliktům a duplicitám mezi architekturami a využít příležitosti ke sdílení.

*Příklad:* Při návrhu nové Data Architecture pro e-shop architekt zjistí, že jiný program právě zavádí centrální správu zákaznických dat. Místo vlastní databáze zákazníků návrh přizpůsobí tak, aby ji využil.

### ? Architekt v Phase C zjistí, že navrhovaná aplikace pro zákaznický servis se překrývá s aplikací, kterou souběžně zavádí jiný projekt. Který společný krok fází B–D se právě takovými zjištěními zabývá?

- [ ] Select Reference Models, Viewpoints, and Tools
- [x] Resolve Impacts Across the Architecture Landscape
- [ ] Develop Baseline Architecture Description
- [ ] Create the Architecture Definition Document

> Posouzení vazeb na jiné projekty a existující architektury je úkolem kroku Resolve Impacts Across the Architecture Landscape. Výběr modelů a popis Baseline mu předcházejí, ADD jen zaznamenává výsledky.

### ? Kterou otázku si architekt klade v kroku Resolve Impacts Across the Architecture Landscape?

- [x] Ovlivní navržená změna jiné projekty nebo existující architektury?
- [ ] Jaký je aktuální stav infrastruktury, která v podniku dnes běží?
- [ ] Kteří dodavatelé nabízejí nejnižší cenu za realizaci řešení?
- [ ] Jaké kompetence potřebují členové architektonického týmu?

> Krok zkoumá dopady návrhu mimo projekt — na jiné projekty a existující architektury — a příležitosti k opětovnému využití. Popis současného stavu je krokem Baseline, výběr dodavatelů ani kompetence týmu sem nepatří.

## Formální revize se stakeholdery {#stakeholder-revize .term}

Krok **Conduct Formal Stakeholder Review** ověřuje navrženou architekturu domény se stakeholdery dříve, než se dokončí. Porovnává ji s původní motivací architektonické práce a se Statement of Architecture Work a ptá se, zda je **vhodná pro daný účel** (fit for purpose). Případné nedostatky se vrací k dopracování do předchozích kroků.

### ? Co je smyslem formální revize se stakeholdery ve fázích B, C a D?

- [ ] Získat souhlas dodavatele s cenou a termínem realizace řešení
- [ ] Ověřit soulad dokončeného a nasazeného řešení s cílovou architekturou
- [x] Ověřit, že návrh odpovídá účelu a Statement of Architecture Work
- [ ] Rozdělit mezi stakeholdery odpovědnost za jednotlivé work packages

> Formální revize kontroluje navrženou architekturu proti původní motivaci a Statement of Architecture Work — zda je fit for purpose. Kontrola souladu nasazeného řešení je Compliance Review v Phase G; work packages vznikají v Phase E.

### ? Při formální revizi Business Architecture stakeholdeři upozorní, že návrh neřeší jeden z business cílů uvedených ve Statement of Architecture Work. Jak by měl architekt postupovat?

- [ ] Návrh přesto finalizovat a chybějící cíl přesunout do Phase H
- [ ] Odstranit cíl ze Statement of Architecture Work, aby revize prošla
- [ ] Postoupit chybějící cíl k vyřešení přímo do Technology Architecture
- [x] Vrátit se k dopracování návrhu, aby cíl ze zadání pokrýval

> Revize slouží právě k odhalení nedostatků, které se vracejí k dopracování v předchozích krocích fáze. Přesun do Phase H nebo do jiné domény problém nevyřeší a jednostranná změna zadání by obešla dohodu se stakeholdery.

## Dokončení architektury domény {#finalizace .explain}

Krok **Finalize the Architecture** uzavírá práci na doméně. Architekt pro každý stavební blok zvolí **standardy** (přednostně z referenčních modelů a podnikových standardů), stavební bloky plně zdokumentuje, provede **závěrečnou kontrolu** celé architektury proti business cílům, zaznamená **zdůvodnění** rozhodnutí, sestaví závěrečnou zprávu o **sledovatelnosti požadavků** (requirements traceability) a zmapuje výsledky vůči Architecture Repository včetně stavebních bloků vhodných k opětovnému použití. Navazujícím krokem je zapracování výsledků do Architecture Definition Document.

*Příklad:* Po revizi Technology Architecture tým určí pro integrační vrstvu podnikový standard, dopíše zdůvodnění volby a označí nový logovací stavební blok jako znovu použitelný pro další projekty.

### ? Která činnost patří do kroku Finalize the Architecture ve fázích B, C a D?

- [ ] Uzavření Architecture Contract s vývojovým týmem projektu
- [x] Doložení sledovatelnosti požadavků a zdůvodnění rozhodnutí
- [ ] Rozhodnutí, který dodavatel dostane zakázku na realizaci
- [ ] Sestavení podrobného harmonogramu nasazení přechodových stavů

> Finalizace zahrnuje výběr standardů, plnou dokumentaci stavebních bloků, závěrečnou kontrolu proti cílům, zdůvodnění rozhodnutí a zprávu o sledovatelnosti požadavků. Architecture Contract patří do Phase G a harmonogram nasazení do Phase F.

## Architecture Definition Document (ADD) {#add .term}

Architecture Definition Document je výstup (deliverable), který **sdružuje hlavní architektonické artefakty** vytvořené v projektu a popisuje architekturu **napříč doménami** (business, data, aplikace, technologie) — výchozí, cílový a případně přechodový stav. Poskytuje **kvalitativní** pohled na řešení a sděluje záměr architektů: rozsah, cíle a omezení, principy, modely, zdůvodnění, výsledky Gap Analysis a posouzení dopadů. Jako draft existuje už od Phase A a ve fázích B, C a D se postupně rozšiřuje o detailní architektury jednotlivých domén.

### ? Který výstup ADM sdružuje hlavní architektonické artefakty a popisuje výchozí i cílovou architekturu napříč doménami?

- [ ] Architecture Requirements Specification
- [ ] Statement of Architecture Work
- [x] Architecture Definition Document
- [ ] Architecture Roadmap

> Architecture Definition Document zachycuje architekturu všech domén — výchozí, cílový a přechodový stav. Architecture Requirements Specification obsahuje měřitelné požadavky, Statement of Architecture Work vymezuje zakázku a Architecture Roadmap plán změn.

### ? Jaký pohled na řešení poskytuje Architecture Definition Document?

- [x] Kvalitativní pohled, který sděluje záměr architektů
- [ ] Kvantitativní soubor měřitelných kritérií pro realizaci
- [ ] Finanční pohled na náklady a přínosy řešení
- [ ] Časový pohled s termíny nasazení jednotlivých projektů

> ADD dává kvalitativní pohled na řešení a sděluje záměr architektů. Měřitelná kritéria obsahuje Architecture Requirements Specification, harmonogram vzniká v Implementation and Migration Plan.

## Architecture Requirements Specification (ARS) {#ars .term}

Architecture Requirements Specification je výstup, který doprovází Architecture Definition Document a poskytuje **kvantitativní** pohled: soubor **měřitelných požadavků**, které musí realizační projekt splnit, aby byl v souladu s architekturou. Typicky obsahuje měřítka úspěchu (success measures), architektonické požadavky, servisní kontrakty, implementační směrnice, specifikace a standardy, požadavky na interoperabilitu a na řízení IT služeb, omezení a předpoklady. Ve fázích B–D se do něj zapisují mimo jiné výsledky Gap Analysis a technické a aktualizované business požadavky.

### ? Který výstup ADM obsahuje měřitelné požadavky, které musí realizační projekt splnit, aby byl v souladu s architekturou?

- [ ] Architecture Definition Document
- [x] Architecture Requirements Specification
- [ ] Request for Architecture Work
- [ ] Architecture Vision

> Architecture Requirements Specification poskytuje kvantitativní, měřitelná kritéria pro realizaci. ADD popisuje architekturu kvalitativně, Request for Architecture Work iniciuje práci a Architecture Vision je vysokoúrovňová vize z Phase A.

### ? Co typicky NEOBSAHUJE Architecture Requirements Specification?

- [ ] Měřítka úspěchu (success measures)
- [ ] Požadavky na interoperabilitu
- [ ] Omezení a předpoklady
- [x] Mapu stakeholderů s jejich vlivem

> Mapa stakeholderů je výstupem řízení stakeholderů, nikoli součástí ARS. Měřítka úspěchu, požadavky na interoperabilitu i omezení a předpoklady jsou typickým obsahem Architecture Requirements Specification.

## ADD × ARS {#add-vs-ars .compare}

ADD existuje jako draft už od Phase A a ve fázích B–D se doplňuje o detailní architektury domén; ARS vzniká jako draft v Phase B. Oba se finalizují v Phase F a navzájem se doplňují.

| | Architecture Definition Document | Architecture Requirements Specification |
|---|---|---|
| Pohled | kvalitativní — co a proč architekti navrhují | kvantitativní — co přesně musí realizace splnit |
| Obsah | rozsah, principy, modely Baseline/Target/Transition, zdůvodnění, dopady | měřítka úspěchu, požadavky, standardy, interoperabilita, omezení, předpoklady |
| Komu slouží | sdělení záměru architektury stakeholderům | podklad pro realizační projekty a kontrolu souladu |
| Ve fázích B–D | doplňuje se o architektury jednotlivých domén | doplňuje se o výsledky Gap Analysis a požadavky domén |

### ? Realizační tým potřebuje vědět, jakou maximální dobu odezvy musí nový systém splnit, aby byl v souladu s architekturou. Ve kterém výstupu takový požadavek hledá?

- [ ] V Architecture Definition Document
- [ ] V Architecture Vision
- [ ] V Statement of Architecture Work
- [x] V Architecture Requirements Specification

> Měřitelné požadavky jako doba odezvy patří do Architecture Requirements Specification. ADD popisuje architekturu kvalitativně, Architecture Vision a Statement of Architecture Work vznikají v Phase A a takové detailní požadavky neobsahují.

### ? Jaký je vztah mezi Architecture Definition Document a Architecture Requirements Specification?

- [ ] ARS nahrazuje ADD poté, co Architecture Board schválí cílovou architekturu
- [ ] ADD vzniká pouze v Phase B, zatímco ARS vzniká pouze v Phase D
- [x] ADD popisuje architekturu kvalitativně, ARS dodává měřitelné požadavky
- [ ] ADD je určen pro technické týmy, ARS pro vrcholové vedení podniku

> Oba výstupy se doplňují: ADD sděluje záměr a popis architektury, ARS stanoví měřitelná kritéria pro realizaci. Rozpracovávají se souběžně ve všech fázích B, C a D a jeden druhý nenahrazuje.

## Výstupy fází B, C a D {#vystupy-bcd .explain}

Každá z fází B, C a D má obdobnou sadu výstupů:

- **zpřesněné výstupy Phase A**, kde je to potřeba — aktualizovaný Statement of Architecture Work a validované principy dané domény (v B business principy, cíle a drivers; v C datové a aplikační principy; v D technologické principy),
- **draft Architecture Definition Document** doplněný o Baseline a Target architekturu domény a pohledy pro stakeholdery,
- **draft Architecture Requirements Specification** s výsledky Gap Analysis a požadavky domény,
- **komponenty Architecture Roadmap** za danou doménu (např. Business Architecture components of an Architecture Roadmap).

ADD i ARS zůstávají v těchto fázích pracovní verzí; Phase E je aktualizuje a Phase F finalizuje.

*Příklad:* Po Phase C má tým v ADD doplněny datové a aplikační modely, v ARS požadavky na integraci a kvalitu dat a seznam kandidátních změn aplikací pro roadmapu.

### ? Který výstup je typickým výstupem Phases B, C a D?

- [ ] Podepsaný Architecture Contract
- [ ] Schválený Request for Architecture Work
- [ ] Finální Implementation and Migration Plan
- [x] Draft Architecture Definition Document

> Phases B, C a D vytvářejí draft Architecture Definition Document (a draft ARS). Request for Architecture Work je vstupem Phase A, Implementation and Migration Plan se dokončuje v Phase F a Architecture Contract patří do Phase G.

### ? Které principy jsou typicky validovány jako výstup Phase D?

- [x] Technologické principy
- [ ] Business principy
- [ ] Datové principy
- [ ] Principy governance

> Každá doménová fáze validuje principy své domény: Phase D technologické principy, Phase B business principy a Phase C datové a aplikační principy.

### ? V jakém stavu jsou Architecture Definition Document a Architecture Requirements Specification na konci Phase D?

- [ ] Jsou finální a podepsané jako součást Architecture Contract
- [x] Jsou to pracovní verze, které Phase E aktualizuje a Phase F finalizuje
- [ ] Jsou archivovány, protože je nahradila Architecture Roadmap
- [ ] Ještě neexistují, vytvoří se až na začátku Phase E

> Na konci Phase D jsou ADD i ARS stále draft (ADD existuje od Phase A, ARS od Phase B); Phase E je aktualizuje a Phase F finalizuje. Architecture Roadmap je nenahrazuje a Architecture Contract je samostatný výstup Phase G.
