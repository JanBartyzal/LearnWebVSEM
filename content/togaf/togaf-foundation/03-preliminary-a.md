---
kind: topic
subject: togaf-foundation
slug: preliminary-a
name: "ADM — Preliminary a Phase A (Architecture Vision)"
order: 3
---

Cíle a kroky přípravné fáze (Architecture Capability, principy, Tailored Architecture Framework); Architecture Vision, Statement of Architecture Work, Request for Architecture Work, Business Scenarios, identifikace stakeholderů.

## Cíle Preliminary Phase {#preliminary-cile .explain}

Preliminary Phase připravuje organizaci na to, aby podnikovou architekturu vůbec uměla dělat: ujasní, **kde, co, proč, kdo a jak** se bude architektura tvořit. Má dva hlavní cíle:

1. **Určit požadovanou Architecture Capability** — posoudit organizační kontext, vymezit dotčené části podniku, zmapovat existující rámce, metody a procesy, se kterými se architektonická práce potká, a stanovit cílovou úroveň zralosti.
2. **Tuto Architecture Capability zřídit** — definovat organizační model pro EA, procesy a zdroje architektonické governance, vybrat a nasadit nástroje a stanovit architektonické principy.

Neprobíhá znovu u každého projektu: dělá se při zakládání architektonické praxe a vrací se k ní, když se podstatně změní podmínky. Její výstupy pak využívají všechny následné cykly ADM.

*Příklad:* Pojišťovna zakládá architektonický tým. V Preliminary Phase určí, které divize architektura pokrývá, kdo v ní rozhoduje, jak se upraví TOGAF a jaký nástroj se použije — teprve pak spouští první konkrétní architektonické projekty.

### ? Co je hlavním cílem Preliminary Phase?

- [ ] Vytvořit Architecture Vision pro konkrétní projekt
- [x] Určit a zřídit Architecture Capability organizace
- [ ] Sestavit Implementation and Migration Plan
- [ ] Provést analýzu mezer mezi Baseline a Target

> Preliminary Phase připravuje organizaci na architektonickou práci — určuje požadovanou Architecture Capability a zřizuje ji. Architecture Vision vzniká ve Phase A, migrační plán ve Phase F a analýza mezer hlavně ve Phases B–D.

### ? Které tvrzení o Preliminary Phase je správné?

- [ ] Probíhá jen jednou a později se k ní už nelze vrátit.
- [ ] Jejím hlavním výstupem je schválený Statement of Architecture Work projektu.
- [ ] Navazuje na Phase H a uzavírá tak celý cyklus ADM.
- [x] Její výstupy využívají další cykly ADM, neopakuje se u každého projektu.

> Preliminary Phase zakládá architektonickou praxi a její výstupy (rámec, principy, organizační model) slouží dalším cyklům; při podstatné změně podmínek se k ní lze vrátit. Statement of Architecture Work je výstupem Phase A.

## Kroky Preliminary Phase {#preliminary-kroky .explain}

Preliminary Phase se skládá z těchto kroků:

1. **Scope the Enterprise Organizations Impacted** — vymezit, kterých částí podniku a okolí se architektonická práce týká.
2. **Confirm Governance and Support Frameworks** — ověřit, jak se architektura napojí na existující řízení (IT governance, portfolio, projekty).
3. **Define and Establish Enterprise Architecture Team and Organization** — posoudit zralost, rozdělit role a odpovědnosti, určit omezení a rozpočet.
4. **Identify and Establish Architecture Principles** — stanovit principy, kterými se budou řídit architektonická rozhodnutí.
5. **Tailor the TOGAF Framework** (a případně další zvolené rámce) — přizpůsobit metodu, obsah a terminologii.
6. **Develop Strategy and Implementation Plan for Tools and Techniques** — vybrat a zavést nástroje (repozitář, modelování) a techniky.

Kroky na sebe logicky navazují, v praxi se ale často řeší souběžně.

*Příklad:* Architektonický tým nejdřív zjistí, kterých divizí se jeho práce týká, pak se dohodne s IT governance na schvalovacím procesu, a nakonec vybere modelovací nástroj a nastaví ho podle přizpůsobeného rámce.

### ? Který krok NEPATŘÍ do Preliminary Phase?

- [ ] Scope the Enterprise Organizations Impacted
- [ ] Tailor the TOGAF Framework
- [x] Develop Statement of Architecture Work; Secure Approval
- [ ] Identify and Establish Architecture Principles

> Vypracování a schválení Statement of Architecture Work je posledním krokem Phase A. Ostatní tři kroky patří do Preliminary Phase.

### ? Ve kterém kroku Preliminary Phase se rozhoduje o výběru nástroje pro architektonický repozitář a modelování?

- [x] Develop Strategy and Implementation Plan for Tools and Techniques
- [ ] Confirm Governance and Support Frameworks
- [ ] Define and Establish Enterprise Architecture Team and Organization
- [ ] Scope the Enterprise Organizations Impacted

> Výběr a zavedení nástrojů (repozitář, modelování) a technik je obsahem kroku Develop Strategy and Implementation Plan for Tools and Techniques. Ostatní kroky řeší napojení na governance, tým a role a vymezení dotčených organizací.

## Vymezení dotčených organizací (core, soft, extended enterprise) {#rozsah-podniku .compare}

V kroku Scope the Enterprise Organizations Impacted se části podniku a jeho okolí třídí podle toho, jak silně se jich architektonická práce dotkne:

| Kategorie | Koho zahrnuje |
|---|---|
| **Core enterprise** | jednotky, kterých se změna týká nejvíc a které z architektury získají největší hodnotu |
| **Soft enterprise** | jednotky, jejichž kapabilita se změní a které s core enterprise spolupracují, ale nejsou přímo hlavním předmětem změny |
| **Extended enterprise** | jednotky mimo vymezený podnik (partneři, dodavatelé, zákazníci), na které změna dopadne |
| **Communities** | zapojená společenství, např. komunity uživatelů nebo odborná sdružení |
| **Governance** | zapojené řídicí orgány včetně právních rámců a geografií |

### ? Banka zavádí architektonickou praxi pro divizi retailového bankovnictví. Změna dopadne i na externí dodavatele platebních služeb. Do které kategorie je zařadíte při vymezení dotčených organizací v Preliminary Phase?

- [ ] Core enterprise
- [ ] Soft enterprise
- [ ] Communities
- [x] Extended enterprise

> Extended enterprise zahrnuje jednotky mimo vymezený podnik, na které změna dopadne, typicky partnery a dodavatele. Core enterprise je hlavní předmět změny, soft enterprise jsou spolupracující interní jednotky a communities zapojená společenství.

### ? Jak se v Preliminary Phase označují organizační jednotky, kterých se změna týká nejvíc a které z architektury získají největší hodnotu?

- [x] Core enterprise
- [ ] Extended enterprise
- [ ] Soft enterprise
- [ ] Federated enterprise

> Core enterprise jsou jednotky nejvíce dotčené změnou s největším přínosem z architektury. Soft enterprise je změnou dotčena nepřímo a extended enterprise leží mimo vymezený podnik; „federated enterprise" není kategorie tohoto kroku.

## Organizational Model for Enterprise Architecture {#organizacni-model .term}

Výstup Preliminary Phase, který popisuje, jak bude architektonická práce v organizaci uspořádaná: **rozsah dotčených organizací**, **posouzení zralosti** včetně mezer a způsobu jejich řešení, **role a odpovědnosti** architektonických týmů, **omezení** architektonické práce, **rozpočtové požadavky** a **strategii governance a podpory**.

### ? Který výstup Preliminary Phase popisuje role a odpovědnosti architektonického týmu, rozpočtové požadavky a omezení architektonické práce?

- [ ] Statement of Architecture Work
- [x] Organizational Model for Enterprise Architecture
- [ ] Communications Plan
- [ ] Architecture Vision

> Organizational Model for Enterprise Architecture zachycuje organizaci architektonické práce — rozsah, zralost, role, omezení, rozpočet a governance. Statement of Architecture Work, Communications Plan a Architecture Vision jsou výstupy Phase A pro konkrétní projekt.

### ? Co typicky NENÍ obsahem Organizational Model for Enterprise Architecture?

- [ ] Posouzení zralosti architektonické praxe a jejích mezer
- [ ] Role a odpovědnosti architektonických týmů
- [x] Cílová Technology Architecture vybraného projektu
- [ ] Rozpočtové požadavky na architektonickou práci

> Organizační model popisuje, jak je architektonická praxe uspořádaná, ne obsah konkrétní architektury. Cílová Technology Architecture projektu vzniká až ve Phase D.

## Tailored Architecture Framework {#tailored-framework .term}

Obecný TOGAF přizpůsobený potřebám konkrétní organizace — klíčový výstup Preliminary Phase. Zahrnuje **přizpůsobenou metodu** (které fáze a kroky se použijí a jak podrobně), **přizpůsobený obsah** (které výstupy a artefakty se budou tvořit), **nakonfigurované a nasazené nástroje** a **napojení na další rámce** organizace (projektové řízení, IT governance); přizpůsobit lze i terminologii. Ve Phase A se podle potřeby dále zpřesní pro konkrétní projekt.

### ? Organizace se rozhodla vynechat některé artefakty TOGAF, sladit názvosloví s interní metodikou projektového řízení a nasadit vybraný modelovací nástroj. Ve kterém výstupu Preliminary Phase se tato rozhodnutí zachytí?

- [ ] Architecture Vision
- [ ] Request for Architecture Work
- [x] Tailored Architecture Framework
- [ ] Capability Assessment

> Přizpůsobená metoda, obsah (výstupy a artefakty), terminologie a nasazené nástroje tvoří Tailored Architecture Framework. Architecture Vision a Capability Assessment jsou výstupy Phase A, Request for Architecture Work je žádost sponzora.

### ? Co NENÍ součástí Tailored Architecture Framework?

- [ ] Přizpůsobená metoda, tj. použité fáze a kroky ADM
- [ ] Přizpůsobený obsah, tj. tvořené výstupy a artefakty
- [ ] Nakonfigurované a nasazené architektonické nástroje
- [x] Schválený rozsah a harmonogram konkrétního projektu

> Rozsah a harmonogram konkrétního architektonického projektu definuje Statement of Architecture Work ve Phase A. Tailored Architecture Framework popisuje, jak se architektura v organizaci dělá obecně.

## Architektonické principy v Preliminary Phase {#principy-preliminary .explain}

V Preliminary Phase se stanovují **architektonické principy (Architecture Principles)** — trvalá pravidla, kterými se řídí architektonická rozhodnutí v celé organizaci. Vycházejí z **business principles** (zásad, které organizace uplatňuje v podnikání) a ze strategie; architektonické principy na business principles navazují, ne naopak. Zaznamenávají se v katalogu principů (Principles catalog). Phase A je pro konkrétní projekt potvrdí a případně doplní v kroku Confirm and Elaborate Architecture Principles, including Business Principles.

*Příklad:* Z business principu „Zákazník má jedno místo kontaktu" odvodí tým architektonický princip „Zákaznická data se vedou v jednom zdroji", který pak omezuje návrh všech projektů.

### ? Ve které fázi ADM se architektonické principy organizace primárně stanovují?

- [ ] Phase A
- [ ] Phase B
- [x] Preliminary Phase
- [ ] Requirements Management

> Architektonické principy se stanovují v Preliminary Phase (krok Identify and Establish Architecture Principles). Phase A je pro konkrétní projekt jen potvrzuje a zpřesňuje.

### ? Z čeho architektonické principy organizace především vycházejí?

- [ ] Z technických standardů hlavních dodavatelů IT
- [x] Z business principles a strategie organizace
- [ ] Z požadavků jednoho konkrétního projektu
- [ ] Z výsledků Gap Analysis ve Phases B–D

> Architektonické principy navazují na business principles a strategii, aby architektura sloužila cílům podniku. Požadavky jednoho projektu ani výsledky Gap Analysis nejsou základem trvalých principů a standardy dodavatelů jsou jen jedním z možných omezení.

## Architecture Governance Framework {#governance-framework .term}

Výstup Preliminary Phase (z kroku Confirm Governance and Support Frameworks), který určuje, **jak bude architektonická práce řízena a kontrolována**: kdo rozhoduje, jak se schvalují výstupy a výjimky a jak se architektonická governance napojí na existující řízení podniku a IT (portfolio, projekty, provoz). Zavedení architektonické kapability obvykle vyžaduje úpravu stávajících governance procesů.

### ? Při zakládání architektonické praxe architekt zjišťuje, jak se schvalování architektury napojí na stávající řízení IT portfolia a projektů. O který krok Preliminary Phase jde?

- [ ] Scope the Enterprise Organizations Impacted
- [ ] Identify and Establish Architecture Principles
- [ ] Develop Strategy and Implementation Plan for Tools and Techniques
- [x] Confirm Governance and Support Frameworks

> Napojení architektonické governance na existující rámce řízení řeší krok Confirm Governance and Support Frameworks; jeho výsledkem je Architecture Governance Framework. Ostatní kroky řeší rozsah organizací, principy a nástroje.

## Vstupy × výstupy Preliminary Phase {#preliminary-vstupy-vystupy .compare}

| Vstupy (příklady) | Výstupy |
|---|---|
| TOGAF a případně další architektonické rámce | **Organizational Model for Enterprise Architecture** |
| strategie a business plány vedení, business strategie, IT strategie | **Tailored Architecture Framework** včetně architektonických principů |
| business principles, business goals, business drivers | **počáteční Architecture Repository** naplněný obsahem rámce |
| hlavní rámce fungující v podniku (portfolio a projektové řízení), governance a právní rámce | zopakování business principles, goals a drivers (nebo odkaz na ně) |
| partnerské a smluvní dohody | **Request for Architecture Work** (volitelně) |
| existující organizační model EA, rámec, principy a repozitář (pokud jsou) | **Architecture Governance Framework** |

### ? Který z uvedených dokumentů může být volitelným výstupem Preliminary Phase?

- [x] Request for Architecture Work
- [ ] Statement of Architecture Work
- [ ] Architecture Vision
- [ ] Communications Plan

> Preliminary Phase může volitelně vyprodukovat Request for Architecture Work, který spustí první projekt. Statement of Architecture Work, Architecture Vision a Communications Plan jsou výstupy Phase A.

### ? Co NEPATŘÍ mezi výstupy Preliminary Phase?

- [ ] Organizational Model for Enterprise Architecture
- [x] Approved Statement of Architecture Work
- [ ] Initial Architecture Repository
- [ ] Architecture Governance Framework

> Schválený Statement of Architecture Work je klíčovým výstupem Phase A. Organizační model, počáteční repozitář a governance framework vznikají v Preliminary Phase.

### ? Co je typickým vstupem Preliminary Phase?

- [ ] Schválený Statement of Architecture Work
- [ ] Architecture Roadmap s přechodovými architekturami
- [x] Business strategie, business principles a governance rámce
- [ ] Návrh Architecture Definition Document

> Preliminary Phase vychází ze strategie, business principles, goals a drivers a z existujících rámců řízení. Ostatní dokumenty vznikají až v pozdějších fázích ADM.

## Request for Architecture Work {#rfaw .term}

Dokument, kterým **sponzorující organizace** žádá architektonickou organizaci o zahájení architektonické práce — **spouští nový cyklus ADM** a je klíčovým vstupem Phase A. Typicky uvádí sponzory, poslání organizace, business cíle a jejich změny, strategické plány, časové limity, změny v prostředí, organizační, rozpočtová a vnější omezení a popis současných business a IT systémů i dostupných zdrojů. Může být výstupem Preliminary Phase (volitelně), Phase F (požadavky na architektonickou práci v implementačních projektech) nebo Phase H (podnět k novému cyklu).

### ? Kdo obvykle vystavuje Request for Architecture Work?

- [ ] Architecture Board po ukončení implementace v Phase G
- [ ] Implementační tým dodávající řešení
- [x] Sponzorující organizace architektonické práce
- [ ] Architekt na konci Phase A jako souhrn vize

> Request for Architecture Work posílá sponzorující organizace architektonické organizaci, aby zahájila práci. Architekt na konci Phase A připravuje Statement of Architecture Work, ne žádost.

### ? Jakou roli má Request for Architecture Work v ADM?

- [ ] Uzavírá cyklus ADM a potvrzuje dodání řešení
- [ ] Definuje rozsah a plán projektu ke schválení
- [ ] Popisuje cílovou architekturu ve všech doménách
- [x] Spouští nový cyklus ADM a je vstupem Phase A

> Request for Architecture Work je podnět sponzora, kterým cyklus začíná, a hlavní vstup Phase A. Rozsah a plán projektu ke schválení definuje Statement of Architecture Work.

### ? Ve které dvojici fází ADM se Request for Architecture Work může objevit mezi výstupy?

- [ ] Phase A a Phase B
- [x] Preliminary Phase a Phase H
- [ ] Phase C a Phase D
- [ ] Phase G a Requirements Management

> Request for Architecture Work je volitelným výstupem Preliminary Phase a výstupem Phase H, když změna vyžaduje nový cyklus ADM. Phase A ho naopak přijímá jako vstup.

## Cíle a vstupy Phase A {#phase-a-cile .explain}

Phase A Architecture Vision zahajuje konkrétní cyklus ADM. Má dva cíle:

1. **Vyvinout vysokoúrovňovou, aspirační vizi** kapabilit a business hodnoty, které navrhovaná architektura přinese (Architecture Vision).
2. **Získat schválení Statement of Architecture Work**, který definuje program prací na vývoj a nasazení architektury popsané ve vizi.

Hlavním vstupem je **Request for Architecture Work**. Dále Phase A využívá business principles, goals a drivers a výstupy Preliminary Phase — Organizational Model for EA, Tailored Architecture Framework, architektonické principy a Architecture Repository s existující dokumentací.

*Příklad:* Vedení e-shopu požádá o architekturu pro expanzi do zahraničí. Architekt ve Phase A sestaví krátkou vizi „jedna platforma pro pět zemí" s hlavními přínosy a k ní plán architektonického projektu, který sponzor podepíše.

### ? Jaké jsou dva hlavní cíle Phase A?

- [ ] Stanovit principy a zřídit Architecture Capability
- [ ] Provést Gap Analysis a navrhnout Transition Architectures
- [x] Vytvořit Architecture Vision a získat schválení SoAW
- [ ] Uzavřít Architecture Contract a dohlížet na implementaci

> Phase A vytváří Architecture Vision a získává schválení Statement of Architecture Work. Principy a kapabilita patří do Preliminary Phase, Gap Analysis do Phases B–D, přechodové architektury do Phase E a Architecture Contract do Phase G.

### ? Který dokument je klíčovým vstupem, kterým Phase A začíná?

- [ ] Architecture Contract
- [ ] Implementation and Migration Plan
- [ ] Compliance Assessment
- [x] Request for Architecture Work

> Phase A je spuštěna Request for Architecture Work od sponzora. Architecture Contract a Compliance Assessment patří k implementační governance, Implementation and Migration Plan vzniká ve Phase F.

## Kroky Phase A {#phase-a-kroky .explain}

Phase A má tyto kroky:

1. **Establish the Architecture Project** — zajistit uznání a podporu projektu vedením a jeho zařazení do projektového a programového řízení podniku.
2. **Identify Stakeholders, Concerns, and Business Requirements**
3. **Confirm and Elaborate Business Goals, Business Drivers, and Constraints**
4. **Evaluate Capabilities** — porovnat současné a požadované kapability.
5. **Assess Readiness for Business Transformation**
6. **Define Scope** — vymezit šíři, hloubku, časový horizont a domény architektury a využitelná architektonická aktiva.
7. **Confirm and Elaborate Architecture Principles, including Business Principles**
8. **Develop Architecture Vision**
9. **Define the Target Architecture Value Propositions and KPIs**
10. **Identify the Business Transformation Risks and Mitigation Activities**
11. **Develop Statement of Architecture Work; Secure Approval**

*Příklad:* Než architekt začne kreslit vizi, ověří, kdo jsou stakeholdeři, co sponzor chce dosáhnout a zda je organizace na změnu připravená — vize pak řeší skutečné potřeby.

### ? Který krok Phase A je posledním krokem této fáze?

- [ ] Develop Architecture Vision
- [x] Develop Statement of Architecture Work; Secure Approval
- [ ] Define Scope
- [ ] Identify the Business Transformation Risks and Mitigation Activities

> Phase A končí vypracováním Statement of Architecture Work a získáním jeho formálního schválení. Vize, rozsah i rizika se řeší v předchozích krocích.

### ? Který krok NEPATŘÍ do Phase A?

- [ ] Assess Readiness for Business Transformation
- [ ] Define the Target Architecture Value Propositions and KPIs
- [ ] Establish the Architecture Project
- [x] Perform Gap Analysis

> Gap Analysis je společným krokem Phases B, C a D, kde se porovnávají podrobné výchozí a cílové architektury. Ostatní kroky do Phase A patří.

### ? Co je smyslem kroku Establish the Architecture Project ve Phase A?

- [x] Zajistit podporu vedení a zařadit projekt do řízení projektů
- [ ] Vybrat dodavatele, který řešení podle architektury implementuje
- [ ] Zřídit architektonický tým a rozdělit mu role a rozpočet
- [ ] Nastavit modelovací nástroj a strukturu Architecture Repository

> Krok Establish the Architecture Project zajišťuje uznání a podporu projektu vedením a jeho napojení na projektové řízení podniku. Zřízení týmu a výběr nástrojů patří do Preliminary Phase, výběr implementačního dodavatele do pozdějších fází.

## Stakeholdeři, zájmy a Communications Plan {#stakeholdri-a .explain}

Krok **Identify Stakeholders, Concerns, and Business Requirements** zjistí, kdo jsou klíčoví stakeholdeři projektu, jaké mají zájmy (concerns) a požadavky a jak velký mají vliv. Z toho plyne, koho je třeba zapojit a jaké pohledy (views) budou stakeholdeři potřebovat. Výsledek se zachytí v artefaktu **Stakeholder Map matrix**. Na analýzu navazuje **Communications Plan** — výstup Phase A, který určuje, komu, co, kdy a jakým kanálem se bude o architektonické práci sdělovat. Klíčové vysokoúrovňové požadavky stakeholderů se zpřesní a zapíší do Architecture Vision.

*Příklad:* Finanční ředitel se zajímá o náklady a návratnost, provoz IT o stabilitu a bezpečnost. Communications Plan pro ně naplánuje různé formáty: řediteli čtvrtletní souhrn přínosů, provozu technické workshopy.

### ? Ve které fázi ADM se poprvé systematicky identifikují stakeholdeři konkrétního architektonického projektu a jejich zájmy?

- [ ] Preliminary Phase
- [x] Phase A
- [ ] Phase B
- [ ] Phase G

> Identifikace stakeholderů, jejich zájmů a business požadavků je druhým krokem Phase A. Preliminary Phase se zabývá architektonickou praxí obecně, ne konkrétním projektem.

### ? Který výstup Phase A určuje, jak, kdy a jakým kanálem budou jednotlivé skupiny stakeholderů informovány o architektonické práci?

- [ ] Stakeholder Map matrix
- [ ] Capability Assessment
- [x] Communications Plan
- [ ] Architecture Governance Framework

> Communications Plan plánuje komunikaci se skupinami stakeholderů — obsah, načasování a kanály. Stakeholder Map matrix zachycuje stakeholdery, jejich zájmy a vliv, ale komunikaci neplánuje.

## Business goals × business drivers × constraints {#cile-hnaci-sily .compare}

Krok **Confirm and Elaborate Business Goals, Business Drivers, and Constraints** ověří s vedením, proč a čeho chce podnik dosáhnout a co ho omezuje.

| Pojem | Co vyjadřuje | Příklad |
|---|---|---|
| **Business driver** (hnací síla) | vnější nebo vnitřní faktor, který podnik tlačí ke změně | rostoucí konkurence online prodejců |
| **Business goal** (cíl) | stav, kterého chce podnik dosáhnout, ideálně měřitelný | 40 % tržeb z online kanálu do tří let |
| **Constraint** (omezení) | limit, který musí architektura i projekt respektovat; celopodnikový nebo specifický pro projekt | rozpočet, termín, regulace, povinná platforma |

### ? Pojišťovna ztrácí zákazníky, protože konkurenti nabízejí sjednání pojistky přes mobil během několika minut. Jak tuto skutečnost v Phase A klasifikujete?

- [ ] Jako business goal
- [ ] Jako architektonický princip
- [ ] Jako constraint
- [x] Jako business driver

> Tlak konkurence je faktor, který podnik žene ke změně, tedy business driver. Business goal by byl požadovaný výsledek (např. podíl online sjednání), constraint limit, který je třeba respektovat.

### ? Vedení stanovilo, že do tří let má 40 % tržeb pocházet z online kanálu. Čím tato formulace je z pohledu Phase A?

- [x] Business goal
- [ ] Business driver
- [ ] Constraint
- [ ] Concern

> Požadovaný měřitelný stav, kterého chce podnik dosáhnout, je business goal. Business driver je příčina změny, constraint limit a concern zájem konkrétního stakeholdera.

## Capability Assessment {#capability-assessment .term}

Výstup Phase A (z kroku Evaluate Capabilities a navazujícího posouzení připravenosti), který zachycuje **výchozí a cílovou úroveň kapabilit** podniku: business kapabilit, IT kapabilit (zralost změnových a provozních procesů, kapacita IT), **zralosti architektonické praxe** a výsledky **Business Transformation Readiness Assessment**. Pomáhá pochopit, co musí architektura změnit a co organizace zvládne.

### ? Který výstup Phase A shrnuje výchozí a cílovou úroveň business a IT kapabilit a zralost architektonické praxe?

- [ ] Organizational Model for Enterprise Architecture
- [ ] Architecture Vision
- [x] Capability Assessment
- [ ] Statement of Architecture Work

> Posouzení výchozích a cílových kapabilit a zralosti zachycuje Capability Assessment. Organizational Model je výstup Preliminary Phase, Architecture Vision popisuje cílový stav a jeho přínosy, ne úroveň kapabilit.

### ? Co NENÍ obvyklou součástí Capability Assessment?

- [ ] Posouzení výchozích a cílových business kapabilit
- [x] Podrobný harmonogram pracovních balíků implementace
- [ ] Posouzení zralosti IT procesů a kapacity IT
- [ ] Výsledky Business Transformation Readiness Assessment

> Capability Assessment posuzuje úroveň kapabilit a připravenost na změnu. Harmonogram pracovních balíků (work packages) vzniká až při plánování migrace ve Phases E a F.

## Připravenost na transformaci a rizika ve Phase A {#pripravenost-rizika .explain}

Krok **Assess Readiness for Business Transformation** posoudí, zda je organizace připravená změnu přijmout (jasná vize, sponzorství, kapacita, kultura, schopnost změnu provést); používá se technika Business Transformation Readiness Assessment. Zjištění ovlivní rozsah, tempo i rizika projektu. Krok **Identify the Business Transformation Risks and Mitigation Activities** pak určí rizika spojená s vizí, klasifikuje je a navrhne zmírňující opatření, která se promítnou do Statement of Architecture Work. Vážná rizika mohou vést k úpravě rozsahu, nebo i k rozhodnutí v projektu nepokračovat.

*Příklad:* Klíčové oddělení nemá kapacitu na souběžné zavádění dvou systémů. Architekt to zaznamená jako riziko a do plánu zapracuje postupné nasazení.

### ? Sponzor chce rozsáhlou transformaci, ale architekt zjišťuje, že klíčová oddělení nemají kapacitu ani motivaci změnu přijmout. Který krok Phase A se tímto zjištěním zabývá?

- [x] Assess Readiness for Business Transformation
- [ ] Define Scope
- [ ] Develop Architecture Vision
- [ ] Confirm and Elaborate Architecture Principles, including Business Principles

> Posouzení, zda je organizace schopna a ochotna změnu přijmout, je obsahem kroku Assess Readiness for Business Transformation. Vymezení rozsahu, tvorba vize ani principy připravenost neposuzují.

### ? Kam se ve Phase A promítnou zmírňující opatření pro identifikovaná rizika business transformace?

- [ ] Do Architecture Contract uzavřeného před Phase G
- [x] Do Statement of Architecture Work a jeho plánu
- [ ] Do Organizational Model for Enterprise Architecture
- [ ] Do Tailored Architecture Framework organizace

> Opatření ke zmírnění rizik se zahrnou do Statement of Architecture Work, aby byla součástí schváleného plánu projektu. Organizational Model a Tailored Architecture Framework jsou výstupy Preliminary Phase a Architecture Contract patří k implementaci.

## Architecture Vision {#architecture-vision .term}

Vysokoúrovňový, aspirační popis toho, **jak se podnik po nasazení cílové architektury změní a jakou hodnotu to přinese**. Slouží jako „elevator pitch" — prodává přínosy sponzorovi a rozhodovatelům a dává všem společný cíl. Je stručná a přehledová; detailní architektury vznikají až ve Phases B–D.

### ? Které tvrzení nejlépe vystihuje Architecture Vision?

- [ ] Detailní specifikace cílových aplikací a technologií
- [x] Stručný popis cílového stavu a přínosů pro získání podpory
- [ ] Smlouva mezi architekty a implementačním týmem
- [ ] Plán přechodových architektur seřazených podle priorit

> Architecture Vision je vysokoúrovňový popis cílového stavu a jeho hodnoty, který pomáhá získat podporu stakeholderů. Detailní specifikace vzniká ve Phases B–D, smlouvou je Architecture Contract a plán přechodu vzniká ve Phases E a F.

### ? Proč se Architecture Vision drží na vysoké úrovni a nezabíhá do detailu?

- [ ] Protože detailní modely zakazují architektonické principy
- [ ] Protože ji schvaluje jen Architecture Board, ne sponzor
- [ ] Protože detail doplní až implementační projekty v Phase G
- [x] Protože má rychle získat shodu a podporu stakeholderů

> Vize má stakeholderům a sponzorovi srozumitelně ukázat cíl a přínosy, aby podpořili další práci. Detail se doplňuje v architektonických fázích B–D, ne až při implementaci.

## Tvorba Architecture Vision, hodnota a KPI {#vision-obsah .explain}

V kroku **Develop Architecture Vision** se z business cílů, požadavků stakeholderů a vymezeného rozsahu vytvoří **vysokoúrovňové pohledy výchozí a cílové architektury** pro domény v rozsahu. Pro odhalení a ověření business požadavků lze použít techniku **Business Scenarios**. Vize obsahuje popis problému, stakeholdery a jejich zájmy, zpřesněné klíčové požadavky a souhrnné pohledy. Navazující krok **Define the Target Architecture Value Propositions and KPIs** doplní hodnotové propozice pro jednotlivé skupiny stakeholderů a **KPI**, podle kterých se změří úspěch. Typickými artefakty Phase A jsou **Stakeholder Map matrix**, **Value Chain diagram** (jak podnik vytváří hodnotu a jak se napojuje na okolí) a **Solution Concept diagram** (zjednodušený obraz navrhovaného řešení).

*Příklad:* Vize nemocnice „pacient vidí své výsledky online do 24 hodin" je doplněna jedním Solution Concept diagramem a KPI „80 % výsledků zpřístupněno online".

### ? Který artefakt Phase A poskytuje zjednodušený, vysokoúrovňový obraz navrhovaného řešení pro komunikaci vize?

- [ ] Value Chain diagram
- [ ] Stakeholder Map matrix
- [ ] Principles catalog
- [x] Solution Concept diagram

> Solution Concept diagram ukazuje v hrubých rysech, jak bude navrhované řešení vypadat. Value Chain diagram zachycuje tvorbu hodnoty v podniku, Stakeholder Map matrix stakeholdery a jejich zájmy a Principles catalog principy z Preliminary Phase.

### ? Ve kterém kroku Phase A se definují KPI, podle kterých se bude měřit úspěch cílové architektury?

- [ ] Evaluate Capabilities
- [x] Define the Target Architecture Value Propositions and KPIs
- [ ] Develop Architecture Vision
- [ ] Establish the Architecture Project

> KPI a hodnotové propozice pro stakeholdery se definují v kroku Define the Target Architecture Value Propositions and KPIs, který navazuje na tvorbu vize.

### ? Kterou techniku lze ve Phase A použít k odhalení a ověření business požadavků při tvorbě Architecture Vision?

- [x] Business Scenarios
- [ ] Gap Analysis
- [ ] Migration Planning Techniques
- [ ] Interoperability Requirements

> Business Scenarios pomáhají odhalit a popsat business požadavky a ověřit vizi se stakeholdery. Gap Analysis se uplatní hlavně ve Phases B–D, plánovací techniky migrace a interoperabilita až při plánování řešení.

## Statement of Architecture Work {#soaw .term}

Dokument, který **definuje rozsah a přístup architektonického projektu**. Po schválení je měřítkem, podle kterého se posuzuje úspěšnost projektu, a může tvořit základ smluvního vztahu mezi dodavatelem a odběratelem architektonických služeb. Vzniká a schvaluje se ve Phase A; v dalších fázích se podle potřeby aktualizuje.

### ? Podle kterého dokumentu se typicky posuzuje, zda byl architektonický projekt úspěšně proveden?

- [ ] Request for Architecture Work
- [ ] Architecture Vision
- [ ] Communications Plan
- [x] Statement of Architecture Work

> Statement of Architecture Work definuje rozsah, přístup a kritéria přijetí projektu, a proto je měřítkem jeho úspěchu. Request for Architecture Work je jen žádost, Architecture Vision popisuje cíl, ne závazek projektu.

### ? Čím se Phase A formálně uzavírá?

- [x] Schválením Statement of Architecture Work
- [ ] Podpisem Architecture Contract s implementátorem
- [ ] Dokončením Architecture Definition Document
- [ ] Zveřejněním Architecture Roadmap v repozitáři

> Posledním krokem Phase A je vypracovat Statement of Architecture Work a získat jeho schválení. Architecture Contract patří do Phase G, Architecture Definition Document se v Phase A zakládá jen jako vysokoúrovňový draft a podrobně se rozpracovává ve Phases B–D, Roadmap ve Phases B–F.

## Obsah a schválení Statement of Architecture Work {#soaw-obsah .explain}

Statement of Architecture Work typicky obsahuje: název a pozadí požadavku, **popis projektu a jeho rozsah**, přehled Architecture Vision, postupy pro **změnu rozsahu**, **role, odpovědnosti a výstupy**, **kritéria a postupy přijetí**, plán a harmonogram architektonického projektu a schválení (podpisy). V posledním kroku Phase A se plány projednají se sponzorem a SoAW se formálně schválí podle governance postupů organizace. **Bez schválení se do Phases B–D nepokračuje** — schválení potvrzuje, že vize i plán mají podporu.

*Příklad:* SoAW projektu „Online kanál" stanoví, že se řeší Business a Application Architecture pro prodej v ČR, výstupy převezme ředitel obchodu do tří měsíců a změnu rozsahu schvaluje řídicí výbor.

### ? Co typicky NENÍ obsahem Statement of Architecture Work?

- [ ] Popis architektonického projektu a jeho rozsahu
- [ ] Role, odpovědnosti a výstupy architektonického projektu
- [x] Implementation and Migration Plan s pracovními balíky
- [ ] Kritéria a postupy přijetí výstupů

> Implementation and Migration Plan vzniká až ve Phase F. Statement of Architecture Work popisuje rozsah, role, výstupy, kritéria přijetí a plán architektonického projektu.

### ? Architekt dokončil Architecture Vision, ale sponzor ještě nepodepsal Statement of Architecture Work. Tým navrhuje rovnou začít s detailním modelováním Business Architecture. Jaký je správný postup?

- [ ] Začít Phase B a schválení SoAW doplnit zpětně
- [ ] Vynechat SoAW, protože vize už je hotová
- [x] Nejdřív získat schválení SoAW, pak zahájit Phase B
- [ ] Předat vizi rovnou do Phase E k plánování implementace řešení

> Schválení Statement of Architecture Work je podmínkou pro pokračování do Phases B–D — potvrzuje rozsah, plán a podporu sponzora. Práce bez schválení riskuje, že tým bude řešit něco, co sponzor nechce, a přeskočení do Phase E vynechá vývoj architektur.

## Request for Architecture Work × Statement of Architecture Work {#rfaw-vs-soaw .compare}

| | Request for Architecture Work | Statement of Architecture Work |
|---|---|---|
| Kdo ho tvoří | sponzorující organizace | architektonická organizace (architekt) se sponzorem |
| Kdy | před Phase A (výstup Preliminary, F nebo H) | ve Phase A |
| Účel | žádost, která spouští cyklus ADM | definice rozsahu, přístupu a plánu projektu |
| Obsah | cíle, omezení, rozpočet, popis současného stavu | rozsah, vize v přehledu, role, výstupy, kritéria přijetí, plán |
| Vztah | vstup Phase A | výstup Phase A, po schválení měřítko úspěchu |

### ? Jaký je hlavní rozdíl mezi Request for Architecture Work a Statement of Architecture Work?

- [ ] SoAW spouští cyklus ADM, RfAW je schválený plán projektu z Phase A
- [ ] Oba vznikají v Preliminary Phase a liší se jen úrovní detailu
- [x] RfAW je žádost sponzora o práci, SoAW schvalovaný plán z Phase A
- [ ] RfAW se týká implementace, SoAW jen vývoje architektonických principů

> Request for Architecture Work je podnět sponzora, kterým cyklus začíná; Statement of Architecture Work vzniká ve Phase A jako definice rozsahu a plánu a schvaluje se. První možnost role obrací.

## Výstupy Phase A {#phase-a-vystupy .explain}

Hlavní výstupy Phase A:

- **schválený Statement of Architecture Work**,
- zpřesněné business principles, business goals a business drivers,
- architektonické principy (potvrzené či doplněné),
- **Capability Assessment**,
- Tailored Architecture Framework (pokud byl pro projekt zpřesněn),
- **Architecture Vision** včetně zpřesněných klíčových požadavků stakeholderů a **prvních vysokoúrovňových verzí výchozí a cílové architektury** (Business, Data, Application, Technology podle rozsahu),
- **draft Architecture Definition Document** s prvními vysokoúrovňovými Baseline a Target architekturami domén v rozsahu,
- **Communications Plan**,
- další obsah uložený do Architecture Repository.

*Příklad:* Po Phase A má tým podepsaný SoAW, dvoustránkovou vizi s hrubými obrysy současného a cílového stavu, první draft ADD a plán komunikace; detailní modely domén začne do ADD doplňovat ve Phase B.

### ? Co NEPATŘÍ mezi výstupy Phase A?

- [ ] Approved Statement of Architecture Work
- [ ] Capability Assessment
- [ ] Communications Plan
- [x] Architecture Contract

> Architecture Contract se uzavírá v rámci implementační governance (Phase G). Schválený SoAW, Capability Assessment a Communications Plan jsou výstupy Phase A.

### ? Které tvrzení o výchozí a cílové architektuře na konci Phase A je správné?

- [ ] Jsou hotové v plném detailu pro všechny čtyři domény a ve Phases B–D se už nemění.
- [x] Existují jen jako vysokoúrovňové první verze ve vizi a v draftu ADD.
- [ ] Ve Phase A se nevytvářejí vůbec, poprvé vznikají až ve Phase E.
- [ ] Popisuje se jen výchozí stav, cílový stav vzniká až ve Phase F.

> Phase A vytváří první vysokoúrovňové verze výchozí i cílové architektury — v Architecture Vision a v draftu Architecture Definition Document. Podrobně je rozpracují Phases B, C a D; Phases E a F s nimi pracují, ale nevytvářejí je poprvé.

## Preliminary Phase × Phase A {#preliminary-vs-a .compare}

| | Preliminary Phase | Phase A Architecture Vision |
|---|---|---|
| Otázka | jak bude organizace architekturu dělat | co a proč bude tento architektonický projekt řešit |
| Četnost | při zakládání praxe a při zásadních změnách | na začátku každého cyklu ADM |
| Spouštěč | rozhodnutí zřídit nebo změnit Architecture Capability | Request for Architecture Work |
| Hlavní výstupy | Organizational Model for EA, Tailored Architecture Framework, principy, Architecture Governance Framework, počáteční repozitář | Architecture Vision, schválený Statement of Architecture Work, Capability Assessment, Communications Plan |

### ? Organizace už má zavedenou architektonickou praxi, principy i přizpůsobený rámec. Vedení nyní žádá architekturu pro nový online kanál. Kterou fází ADM práce na tomto požadavku začíná?

- [ ] Znovu Preliminary Phase
- [ ] Phase B Business Architecture
- [x] Phase A Architecture Vision
- [ ] Requirements Management

> Nový architektonický požadavek se zpracovává v novém cyklu ADM, který začíná Phase A; zavedená praxe a rámec z Preliminary Phase se jen využijí. Phase B bez schválené vize a SoAW by byla předčasná.

### ? Který výstup patří k Preliminary Phase, nikoli k Phase A?

- [x] Organizational Model for Enterprise Architecture
- [ ] Capability Assessment
- [ ] Communications Plan
- [ ] Architecture Vision

> Organizational Model for Enterprise Architecture popisuje uspořádání architektonické praxe a vzniká v Preliminary Phase. Capability Assessment, Communications Plan a Architecture Vision jsou výstupy Phase A.
