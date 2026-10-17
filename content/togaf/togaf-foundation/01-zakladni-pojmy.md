---
kind: topic
subject: togaf-foundation
slug: zakladni-pojmy
name: "Základní pojmy a struktura TOGAF Standardu"
order: 1
---

Enterprise, architektura, Enterprise Architecture a její přínosy; struktura TOGAF Standardu 10. vydání (Fundamental Content × Series Guides); architektonická doména (Business, Data, Application, Technology); Architecture Framework; role architekta.

## Podnik (Enterprise) {#enterprise .term}

**Enterprise** je v TOGAF nejvyšší úroveň popisu organizace, která zahrnuje všechna její poslání a funkce. Nemusí jít o celou firmu — za enterprise lze vzít i divizi, útvar nebo veřejnou instituci, a naopak může přesahovat hranice jedné organizace a zahrnovat partnery, dodavatele či zákazníky (**rozšířený podnik**, Extended Enterprise). Co je pro danou práci „enterprise", určuje vymezení rozsahu architektury, ne právní forma.

### ? Jak TOGAF chápe pojem „enterprise"?

- [x] Jako celek s posláním a funkcemi, i část firmy či více firem
- [ ] Výhradně jako celou obchodní korporaci jako jeden právní subjekt
- [ ] Jako souhrn všech IT systémů a technologické infrastruktury firmy
- [ ] Jako soubor projektů, které firma právě realizuje nebo plánuje

> Enterprise je v TOGAF celek, jehož poslání a funkce architektura popisuje; může to být jedna divize i síť spolupracujících organizací. Nejde o právní subjekt, IT ani portfolio projektů.

### ? Výrobní firma chce architekturou pokrýt i propojení se svými klíčovými dodavateli a logistickými partnery. Jak se v TOGAF označuje takto vymezený podnik?

- [ ] Segment Architecture
- [ ] Solutions Continuum
- [ ] Organizational Model
- [x] Extended Enterprise

> Rozšířený podnik (Extended Enterprise) zahrnuje kromě vlastní organizace i partnery, dodavatele a zákazníky. Segment Architecture je úroveň architektury, Solutions Continuum část Enterprise Continuum a Organizational Model popisuje organizaci architektonické práce.

## Architektura (Architecture) {#architektura .term}

TOGAF používá pojem **architektura** ve dvou souvisejících významech. Jednak jsou to **základní koncepty či vlastnosti systému v jeho prostředí**, vyjádřené jeho prvky, vztahy mezi nimi a principy jeho návrhu a vývoje (vychází z normy ISO/IEC/IEEE 42010). Jednak je to **struktura komponent, jejich vzájemné vztahy a principy a směrnice**, které řídí jejich návrh a vývoj v čase. Architektura tedy není jen „obrázek" současného stavu, ale i pravidla, podle kterých se systém mění.

### ? Která součást patří podle TOGAF do architektury systému vedle jeho komponent a vztahů mezi nimi?

- [ ] Rozpočet a harmonogram projektů, které systém budují
- [ ] Seznam dodavatelů a licencí použitých produktů
- [x] Principy a směrnice, které řídí jeho návrh a vývoj v čase
- [ ] Pracovní náplně zaměstnanců, kteří systém obsluhují

> Architektura podle TOGAF zahrnuje komponenty, jejich vztahy a principy a směrnice pro návrh a vývoj v čase. Rozpočty, licence a pracovní náplně jsou provozní či projektové údaje, ne podstata architektury.

### ? Ze které mezinárodní normy vychází jeden ze dvou významů pojmu „architektura" v TOGAF?

- [x] ISO/IEC/IEEE 42010
- [ ] ISO/IEC 27001
- [ ] ISO 9001
- [ ] ISO/IEC 20000

> Norma ISO/IEC/IEEE 42010 se zabývá popisem architektury systémů a zavádí i pojmy stakeholder, concern, view a viewpoint. ISO/IEC 27001 je o bezpečnosti informací, ISO 9001 o řízení kvality a ISO/IEC 20000 o řízení IT služeb.

## Podniková architektura (Enterprise Architecture) {#ea .term}

**Podniková architektura** (Enterprise Architecture, EA) je architektura celého vymezeného podniku: popisuje jeho strukturu a fungování napříč byznysem, daty, aplikacemi a technologiemi, **současný stav, žádoucí cílový stav a cestu mezi nimi**. Jejím smyslem je podpořit rozhodování a řídit změnu tak, aby jednotlivé změny a investice směřovaly ke strategii podniku a do sebe zapadaly.

### ? Co nejlépe vystihuje účel podnikové architektury podle TOGAF?

- [ ] Podrobně navrhnout jednu aplikaci včetně jejího zdrojového kódu
- [ ] Nahradit řízení projektů jednotnou architektonickou metodikou
- [ ] Zdokumentovat stávající IT systémy pro potřeby externího auditu
- [x] Podpořit rozhodování a vést změnu podniku směrem ke strategii

> EA popisuje podnik napříč doménami a ukazuje cestu od současného k cílovému stavu, aby změny a investice sledovaly strategii. Detailní návrh jedné aplikace, řízení projektů ani pouhá dokumentace pro audit jejím účelem nejsou.

### ? Které tři časové stavy podniková architektura typicky zachycuje?

- [ ] Plánovaný, schválený a auditovaný stav
- [x] Současný stav, cílový stav a cestu mezi nimi
- [ ] Minulý stav, současný stav a archivní stav
- [ ] Návrhový, testovací a produkční stav

> EA popisuje výchozí (Baseline) a cílovou (Target) architekturu a přechod mezi nimi, často přes přechodové architektury (Transition Architectures). Návrhový, testovací a produkční stav jsou prostředí vývoje softwaru, ne stavy architektury.

## Podniková architektura není jen IT {#ea-neni-it .explain}

Častý omyl je ztotožňovat EA s architekturou IT. TOGAF začíná u **byznysu** — strategie, cílů, organizace, schopností a procesů — a teprve z nich odvozuje, jaká data, aplikace a technologie podnik potřebuje. IT je důležitou, ale ne jedinou částí; architektura bez byznysového kontextu by optimalizovala technologie, které nemusí podporovat to, co podnik skutečně potřebuje. Proto mají v architektonické práci zásadní roli i manažeři a vlastníci procesů, nejen IT.

*Příklad:* Banka chce zkrátit schválení úvěru na jeden den. Architekt nezačne výběrem nové databáze, ale rozborem procesu schvalování, rolí a rozhodovacích pravidel; teprve potom řeší, které aplikace a data je třeba změnit.

### ? Pojišťovna zahajuje architektonickou práci se záměrem zrychlit vyřizování škodních událostí. Kde má podle přístupu TOGAF architektura začít?

- [x] U byznysových cílů, organizace a procesů vyřizování škod
- [ ] U výběru nové technologické platformy pro zpracování škod
- [ ] U inventury serverů a sítí, na kterých běží stávající systémy
- [ ] U návrhu datového modelu pro novou databázi škodních událostí

> TOGAF odvozuje data, aplikace a technologie z byznysových potřeb, proto se začíná u cílů, organizace a procesů. Výběr platformy, inventura infrastruktury či datový model bez byznysového kontextu jsou předčasné kroky.

### ? Které tvrzení o podnikové architektuře je NESPRÁVNÉ?

- [ ] Zahrnuje byznys, data, aplikace i technologie podniku
- [ ] Byznysové cíle jsou výchozím bodem architektonické práce
- [x] Jde v podstatě o jiný název pro architekturu IT systémů
- [ ] Na její tvorbě se podílejí i manažeři a vlastníci procesů

> EA není synonymem IT architektury — pokrývá celý podnik a vychází z byznysu. Ostatní tvrzení odpovídají přístupu TOGAF.

## Přínosy podnikové architektury {#prinosy-ea .explain}

TOGAF uvádí, že účinná podniková architektura přináší zejména:

- **efektivnější byznysový provoz** — nižší náklady provozu, sdílené schopnosti napříč organizací, levnější a pružnější změny;
- **efektivnější digitální transformaci a IT provoz** — méně duplicit, menší složitost, snazší integrace a nižší náklady na vývoj a podporu;
- **lepší návratnost stávajících investic a nižší riziko investic budoucích** — investice se posuzují v kontextu celku;
- **rychlejší, jednodušší a levnější nákup (procurement)** — jasné požadavky a standardy usnadňují výběr řešení a dodavatelů.

Společným jmenovatelem je, že rozhodnutí o změnách se dělají s přehledem o celém podniku, ne izolovaně v jednotlivých útvarech.

*Příklad:* Holding zjistí, že tři dceřiné společnosti platí tři různé systémy pro mzdy. Architektura ukáže duplicitu a podpoří rozhodnutí o sdíleném řešení.

### ? Který z uvedených přínosů TOGAF NEUVÁDÍ mezi typické přínosy podnikové architektury?

- [ ] Rychlejší, jednodušší a levnější pořizování řešení
- [ ] Lepší návratnost stávajících investic do řešení
- [ ] Nižší riziko budoucích investic do změn podniku
- [x] Odstranění potřeby řídit projekty a jejich rizika

> EA přináší efektivnější provoz, lepší návratnost a nižší riziko investic a snazší nákup. Řízení projektů a rizik nenahrazuje — naopak s ním spolupracuje.

### ? Tři divize jedné skupiny si nezávisle pořídily tři různé systémy pro evidenci zákazníků a jejich integrace je drahá. Jaký přínos podnikové architektury tato situace nejlépe ilustruje?

- [ ] Rychlejší nasazování aplikací bez schvalování
- [ ] Nezávislost divizí při volbě vlastních řešení
- [x] Méně duplicit a nižší složitost díky pohledu na celek
- [ ] Přesun odpovědnosti za IT na externí dodavatele

> Architektura dává přehled o celém podniku, takže odhalí duplicitní řešení a umožní sdílet schopnosti. Nezávislé rozhodování divizí je právě příčinou problému, nikoli přínosem EA.

## Architektonický rámec (Architecture Framework) {#architecture-framework .term}

**Architecture Framework** je koncepční struktura pro plánování, vývoj, zavádění, řízení a udržování architektury. Dobrý rámec obsahuje zejména **metodu**, jak navrhnout cílový stav pomocí stavebních bloků, popis toho, **jak bloky do sebe zapadají**, **společný slovník**, sadu **nástrojů a technik** a doporučené **standardy**. Rámec tak zajišťuje, že různí architekti pracují stejným způsobem a jejich výstupy jsou srovnatelné.

### ? Co je hlavním smyslem architektonického rámce (Architecture Framework)?

- [ ] Předepsat jednoho konkrétního dodavatele softwaru a hardwaru
- [x] Dát společnou metodu, slovník a nástroje pro tvorbu architektury
- [ ] Nahradit potřebu stakeholderů schvalovat architektonické návrhy
- [ ] Poskytnout hotovou cílovou architekturu pro každé odvětví

> Rámec dává strukturu práce — metodu, slovník, nástroje a standardy —, aby byla architektura konzistentní. Nevybírá dodavatele, neruší schvalování ani nepřináší hotové řešení pro konkrétní podnik.

### ? Co obvykle NEPATŘÍ mezi součásti architektonického rámce?

- [ ] Metoda návrhu cílového stavu pomocí stavebních bloků
- [ ] Společný slovník pojmů pro architektonickou práci
- [ ] Doporučené standardy a sada nástrojů a technik
- [x] Schválený rozpočet architektonických projektů podniku

> Rámec obsahuje metodu, slovník, nástroje, techniky a standardy. Rozpočet je rozhodnutím konkrétního podniku, ne součástí obecného rámce.

## TOGAF Standard {#togaf .term}

**TOGAF Standard** je otevřený rámec podnikové architektury, který spravuje konsorcium **The Open Group**. Je **obecný** (nezávislý na odvětví), **nezávislý na dodavatelích a nástrojích** a určený k **přizpůsobení** (tailoring) potřebám konkrétního podniku. Jeho jádrem je metoda **ADM** (Architecture Development Method); dále obsahuje techniky, popis obsahu architektury, Enterprise Continuum a Architecture Repository a návod na zřízení architektonické kapability a governance. Aktuální je **10. vydání** (2022).

### ? Která organizace vydává a spravuje TOGAF Standard?

- [ ] Object Management Group
- [ ] International Organization for Standardization
- [x] The Open Group
- [ ] Project Management Institute

> TOGAF vydává konsorcium The Open Group, které spravuje i jazyk ArchiMate. Object Management Group stojí za UML a BPMN, ISO vydává mezinárodní normy a PMI je organizací projektového řízení.

### ? Co je jádrem TOGAF Standardu?

- [ ] Jazyk pro modelování architektury
- [x] Architecture Development Method (ADM)
- [ ] Katalog doporučených softwarových produktů
- [ ] Sada hotových referenčních architektur odvětví

> Jádrem TOGAF je metoda ADM, opakovatelný postup tvorby a řízení architektury. Modelovacím jazykem je ArchiMate, ne TOGAF, a TOGAF je nezávislý na produktech.

### ? Co znamená, že TOGAF je „obecný" rámec?

- [x] Lze ho použít v různých odvětvích a velikostech organizací
- [ ] Musí se vždy použít celý a beze změn v pevném pořadí
- [ ] Je vázán na nástroje jednoho výrobce architektonického softwaru
- [ ] Platí jen pro státní správu a regulovaná odvětví

> TOGAF je obecný a nezávislý na odvětví i dodavatelích a očekává se, že si ho podnik přizpůsobí. Povinnost použít ho celý beze změn ani vazba na nástroj neplatí.

## Struktura TOGAF Standardu, 10. vydání {#struktura-standardu .explain}

TOGAF Standard, 10. vydání, je rozdělen do dvou částí. **TOGAF Fundamental Content** obsahuje stabilní, obecně platné jádro — pojmy, ADM, techniky, obsah architektury a kapabilitu a governance. **TOGAF Series Guides** jsou samostatné průvodce ke konkrétním tématům (např. business capabilities, value streams, agilní přístupy, bezpečnost), které ukazují, jak jádro uplatnit v praxi. Toto modulární členění umožňuje aktualizovat praktické návody častěji, aniž by se měnilo jádro standardu, a usnadňuje orientaci: kdo hledá základní pravidla, čte Fundamental Content, kdo řeší konkrétní situaci, sáhne po příslušném průvodci.

*Příklad:* Architekt potřebuje modelovat schopnosti podniku. Základní zařazení do ADM najde ve Fundamental Content, podrobný návod a příklady v Series Guide o business capabilities.

### ? Z kterých dvou hlavních částí se skládá TOGAF Standard, 10. vydání?

- [ ] Foundation a Practitioner
- [ ] Core Standard a Extensions
- [x] Fundamental Content a Series Guides
- [ ] Architecture Continuum a Solutions Continuum

> 10. vydání tvoří TOGAF Fundamental Content a TOGAF Series Guides. Foundation a Practitioner jsou úrovně certifikace a Architecture/Solutions Continuum jsou části Enterprise Continuum.

### ? Proč je TOGAF Standard, 10. vydání, rozdělen na stabilní jádro a samostatné průvodce?

- [ ] Aby se certifikace dala skládat jen z jedné části standardu
- [x] Aby šlo praktické návody aktualizovat bez změn jádra standardu
- [ ] Aby každá země mohla vydávat vlastní národní verzi jádra
- [ ] Aby se jádro dalo prodávat odděleně od praktických průvodců

> Modulární struktura odděluje stabilní jádro od praktických návodů, které se mohou vyvíjet rychleji. Cílem není dělení certifikace, národní verze ani obchodní model.

## Fundamental Content × Series Guides {#fundamental-vs-series .compare}

Obě části se doplňují — jádro říká *co a proč*, průvodci *jak v konkrétní situaci*.

| | TOGAF Fundamental Content | TOGAF Series Guides |
|---|---|---|
| Obsah | obecně platné jádro: pojmy, ADM, techniky, obsah, kapabilita a governance | návody k vybraným tématům a způsobům použití |
| Stabilita | mění se zřídka | aktualizují se a přibývají častěji |
| Povaha | univerzální, nezávislé na situaci | praktické, zaměřené na konkrétní kontext |
| Příklady | fáze ADM, Architecture Content Framework | business capabilities, value streams, agilita, bezpečnost |

### ? Architekt hledá podrobný praktický návod, jak v podniku modelovat value streams. Ve které části TOGAF Standardu, 10. vydání, ho s největší pravděpodobností najde?

- [ ] V popisu Preliminary Phase ve Fundamental Content
- [ ] V Architecture Requirements Repository podniku
- [ ] V Standards Library v Architecture Repository
- [x] V příslušném TOGAF Series Guide

> Podrobné praktické návody k vybraným tématům, jako jsou value streams, přináší Series Guides. Fundamental Content popisuje obecné jádro a části Architecture Repository jsou úložiště konkrétního podniku, ne součást standardu.

### ? Která charakteristika platí pro TOGAF Fundamental Content, a NE pro Series Guides?

- [ ] Přináší praktické návody k vybraným tématům
- [x] Obsahuje stabilní jádro, které se mění jen zřídka
- [ ] Aktualizuje se a nové části přibývají poměrně často
- [ ] Zaměřuje se na použití v určitém kontextu

> Fundamental Content je stabilní, univerzální jádro standardu. Praktické návody k tématům, častější aktualizace a zaměření na konkrétní kontext jsou typické pro Series Guides.

## Dokumenty TOGAF Fundamental Content {#fundamental-content .explain}

Fundamental Content tvoří šest dokumentů, které na sebe navazují:

1. **Introduction and Core Concepts** — úvod, základní pojmy a definice;
2. **Architecture Development Method** — fáze ADM, jejich cíle, vstupy, kroky a výstupy;
3. **ADM Techniques** — techniky použitelné v ADM (např. architektonické principy, stakeholder management, Gap Analysis);
4. **Applying the ADM** — jak ADM uplatnit v různých situacích, např. iterace a úrovně architektury;
5. **Architecture Content** — obsah architektury: Content Framework, metamodel, artefakty, stavební bloky;
6. **Enterprise Architecture Capability and Governance** — zřízení architektonické praxe a její governance (např. Architecture Board, Architecture Contracts, Architecture Compliance).

*Příklad:* Kdo chce zjistit, jaké kroky má Phase B, otevře dokument Architecture Development Method; kdo hledá, jak sestavit Stakeholder Map, otevře ADM Techniques.

### ? Ve kterém dokumentu TOGAF Fundamental Content se popisuje metamodel obsahu, artefakty a stavební bloky?

- [ ] Introduction and Core Concepts
- [ ] ADM Techniques
- [ ] Applying the ADM
- [x] Architecture Content

> Obsah architektury — Content Framework, metamodel, artefakty a stavební bloky — popisuje dokument Architecture Content. Introduction zavádí pojmy, ADM Techniques techniky a Applying the ADM použití metody v různých situacích.

### ? Architekt hledá popis techniky analýzy mezer (Gap Analysis). Který dokument TOGAF Fundamental Content je pro něj nejvhodnější?

- [x] ADM Techniques
- [ ] Architecture Content
- [ ] Introduction and Core Concepts
- [ ] Enterprise Architecture Capability and Governance

> Techniky používané v ADM, včetně Gap Analysis, shrnuje dokument ADM Techniques. Architecture Content popisuje obsah architektury a dokument o kapabilitě a governance zřízení a řízení architektonické praxe.

### ? Který z uvedených dokumentů NEPATŘÍ do TOGAF Fundamental Content?

- [ ] Applying the ADM
- [x] Business Capabilities
- [ ] Architecture Development Method
- [ ] Enterprise Architecture Capability and Governance

> Business Capabilities je jedním z TOGAF Series Guides; ostatní uvedené patří mezi šest dokumentů Fundamental Content.

## Architektonická doména (Architecture Domain) {#domena .term}

**Architektonická doména** je oblast podniku, kterou architektura popisuje z určitého hlediska. TOGAF pracuje se čtyřmi doménami: **Business**, **Data**, **Application** a **Technology**. Domény Data a Application se společně označují jako **Information Systems Architectures**. Domény na sebe navazují — byznys určuje potřebná data a aplikace a ty určují potřebnou technologii — a architektura je musí řešit v souladu.

### ? Které čtyři architektonické domény TOGAF rozlišuje?

- [ ] Strategic, Segment, Capability a Solution
- [ ] Business, Process, Security a Infrastructure
- [x] Business, Data, Application a Technology
- [ ] Baseline, Target, Transition a Solution

> TOGAF rozlišuje domény Business, Data, Application a Technology. Strategic, Segment a Capability jsou úrovně architektury, Baseline, Target a Transition časové stavy architektury.

### ? Které dvě domény TOGAF společně označuje jako Information Systems Architectures?

- [ ] Business a Data
- [x] Data a Application
- [ ] Application a Technology
- [ ] Business a Technology

> Information Systems Architectures zahrnují datovou a aplikační architekturu. Business a Technology jsou samostatné domény.

## Business Architecture {#business-architecture .term}

**Business Architecture** popisuje byznysovou stránku podniku: **strategii, cíle, governance, organizační strukturu, schopnosti (capabilities) a klíčové byznysové procesy**, případně i value streams. Ukazuje, co podnik dělá, kdo to dělá a proč. Je výchozí doménou — bez ní nelze rozumně odvodit, jaká data, aplikace a technologie podnik potřebuje.

### ? Která architektonická doména popisuje organizační strukturu, schopnosti a klíčové procesy podniku?

- [x] Business Architecture
- [ ] Application Architecture
- [ ] Data Architecture
- [ ] Technology Architecture

> Organizace, schopnosti a procesy jsou obsahem Business Architecture. Aplikační, datová a technologická doména popisují informační systémy a infrastrukturu, které byznys podporují.

### ? Proč se Business Architecture považuje za výchozí doménu?

- [ ] Protože je ze všech domén nejméně náročná na zpracování
- [ ] Protože ji vždy zpracovává útvar IT jako první dodávku
- [ ] Protože nahrazuje potřebu podrobně popisovat ostatní tři domény
- [x] Protože z ní vyplývají potřeby na data, aplikace a technologie

> Byznysové potřeby určují, jaká data, aplikace a technologie má podnik mít. Business Architecture ostatní domény nenahrazuje a nezpracovává ji primárně IT.

## Data Architecture {#data-architecture .term}

**Data Architecture** popisuje **strukturu logických a fyzických datových aktiv** podniku a **zdroje pro správu dat** — jaké hlavní datové entity podnik má, jak spolu souvisí, kde vznikají, kdo je vlastní a jak se s nimi zachází. Spolu s Application Architecture tvoří Information Systems Architectures.

### ? Architekt mapuje, jaké hlavní datové entity podnik používá, jak spolu souvisí a které útvary je vlastní. Ve které architektonické doméně pracuje?

- [ ] Business Architecture
- [ ] Technology Architecture
- [x] Data Architecture
- [ ] Application Architecture

> Struktura datových aktiv a jejich správa je obsahem Data Architecture. Aplikační doména popisuje aplikace a jejich interakce, technologická infrastrukturu.

### ? Co je hlavním obsahem Data Architecture?

- [x] Struktura logických a fyzických datových aktiv a jejich správa
- [ ] Rozmístění serverů a síťových prvků v jednotlivých datových centrech
- [ ] Organizační struktura útvarů, které s daty pracují
- [ ] Seznam aplikací a rozhraní, které si data vyměňují

> Data Architecture popisuje datová aktiva a zdroje pro jejich správu. Servery a sítě patří do Technology, organizační struktura do Business a seznam aplikací s rozhraními do Application Architecture.

## Application Architecture {#application-architecture .term}

**Application Architecture** popisuje **jednotlivé aplikace, jejich vzájemné interakce a vztah ke klíčovým byznysovým procesům**. Ukazuje, které aplikace podporují které procesy, jaká mají rozhraní a jak jsou propojeny. Nejde o detailní návrh vnitřku aplikace, ale o jejich mapu a roli v podniku.

### ? Která doména popisuje aplikace podniku, jejich vzájemná propojení a vazbu na byznysové procesy?

- [ ] Technology Architecture
- [ ] Data Architecture
- [ ] Business Architecture
- [x] Application Architecture

> Aplikace, jejich interakce a vazby na procesy jsou obsahem Application Architecture. Data Architecture řeší datová aktiva a Technology Architecture infrastrukturu.

### ? Co Application Architecture v pojetí TOGAF typicky NEOBSAHUJE?

- [ ] Přehled aplikací, které podnik používá
- [x] Podrobný návrh tříd a zdrojového kódu aplikace
- [ ] Vazby aplikací na klíčové byznysové procesy podniku
- [ ] Rozhraní a interakce mezi aplikacemi

> Application Architecture je mapa aplikací a jejich vztahů na úrovni podniku. Detailní návrh tříd a kódu patří do návrhu softwaru, ne do podnikové architektury.

## Technology Architecture {#technology-architecture .term}

**Technology Architecture** popisuje **softwarové a hardwarové schopnosti** potřebné k provozu byznysových, datových a aplikačních služeb — IT infrastrukturu, middleware, sítě, komunikace, zpracování a technologické standardy. Odpovídá na otázku, na čem a jak aplikace a data běží.

### ? Který obsah patří do Technology Architecture?

- [x] Infrastruktura, middleware, sítě a technologické standardy
- [ ] Byznysové procesy a jejich vlastníci v jednotlivých útvarech
- [ ] Hlavní datové entity podniku a jejich vlastnictví
- [ ] Organizační schopnosti a value streams podniku

> Technology Architecture popisuje technologickou platformu, na níž běží data a aplikace. Procesy a schopnosti patří do Business a datové entity do Data Architecture.

### ? Firma přechází z vlastních serverů do cloudu a mění síťovou infrastrukturu a middleware. Které doméně se tato změna týká především?

- [ ] Business Architecture
- [ ] Data Architecture
- [x] Technology Architecture
- [ ] Application Architecture

> Servery, cloudová platforma, sítě a middleware jsou obsahem Technology Architecture. Změna se může promítnout i do ostatních domén, ale primárně jde o technologii.

## Stakeholder (zainteresovaná strana) {#stakeholder .term}

**Stakeholder** je jednotlivec, tým, organizace nebo jejich skupina, která má **zájem na systému** či na výsledku architektonické práce. Stakeholderem může být vrcholový management, vlastník procesu, uživatel, provozní IT, regulátor, dodavatel i zákazník. Architektura vzniká proto, aby uspokojila jejich zájmy, a proto je architekt musí identifikovat a zapojit.

### ? Kdo je stakeholder v pojetí TOGAF?

- [ ] Pouze akcionář nebo vlastník podniku
- [ ] Pouze člen týmu, který architekturu vytváří a udržuje v podniku
- [x] Kdokoli, kdo má zájem na systému či výsledku architektury
- [ ] Pouze zákazník, který využívá služby podniku

> Stakeholderem je jednotlivec, tým, organizace či jejich skupina se zájmem na systému. Akcionář, člen týmu i zákazník jím být mohou, ale pojem je mnohem širší.

### ? Kdo z uvedených NENÍ při změně systému pro výplatu sociálních dávek typickým stakeholderem?

- [ ] Úřad, který dávky vyplácí a systém provozuje
- [ ] Regulátor, který dohlíží na ochranu osobních údajů
- [ ] Občan, který o dávku žádá a sleduje její vyřízení
- [x] Firma z jiného odvětví bez vazby na systém či jeho výsledky

> Stakeholderem je ten, kdo má na systému zájem — provozovatel, regulátor i uživatel. Subjekt bez jakékoli vazby na systém nebo jeho výsledky stakeholderem není.

## Zájem (Concern) {#concern .term}

**Concern** je **zájem nebo obava stakeholdera týkající se systému** — to, co je pro něj důležité, např. náklady, výkon, bezpečnost, dostupnost, soulad s předpisy nebo použitelnost. Jeden stakeholder má obvykle více concerns a jeden concern může sdílet více stakeholderů. Concerns jsou výchozím bodem pro volbu toho, co a jak architektura ukáže.

### ? Finanční ředitel se u nového systému ptá hlavně na celkové náklady vlastnictví. Jak se tento jeho zájem označuje v TOGAF?

- [ ] View
- [ ] Viewpoint
- [ ] Building block
- [x] Concern

> Zájem stakeholdera na systému, zde náklady, je concern. View a viewpoint slouží k tomu, aby architektura concerns stakeholderů adresovala, a building block je stavební prvek architektury.

### ? Které tvrzení o concerns je SPRÁVNÉ?

- [x] Jeden concern může sdílet i více různých stakeholderů
- [ ] Každý concern patří vždy právě jednomu konkrétnímu stakeholderovi
- [ ] Concerns definuje architekt bez ohledu na stakeholdery
- [ ] Concerns se týkají jen technických vlastností systému

> Concerns jsou zájmy stakeholderů a mohou být sdílené, např. bezpečnost zajímá vedení i regulátora. Nejsou jen technické a architekt je zjišťuje od stakeholderů, nevymýšlí je.

## Pohled (View) × hledisko (Viewpoint) {#view-viewpoint .compare}

**View** a **viewpoint** se často pletou: viewpoint je obecná „šablona", view je její konkrétní naplnění pro daný systém.

| | Viewpoint (hledisko) | View (pohled) |
|---|---|---|
| Co to je | specifikace konvencí, jak určitý druh pohledu sestavit a používat | reprezentace systému z hlediska souvisejících concerns |
| Obecnost | obecný, opakovaně použitelný napříč systémy | konkrétní pro daný systém či architekturu |
| Odpovídá na | pro koho, na jaké concerns a jakými prostředky se díváme | co je z tohoto hlediska na systému vidět |
| Příklad | hledisko „bezpečnost" pro CISO: jaké prvky a notaci použít | bezpečnostní pohled na konkrétní platební systém banky |

### ? Jaký je vztah mezi viewpointem a view?

- [x] Viewpoint je obecná specifikace, podle níž se sestavuje konkrétní view
- [ ] View je obecná šablona, z níž se odvozuje konkrétní viewpoint
- [ ] Jde o synonyma, která TOGAF používá zaměnitelně ve stejném smyslu
- [ ] Viewpoint popisuje současný stav a view stav cílový

> Viewpoint stanoví konvence (pro koho, jaké concerns, jaké prvky a notace) a view je konkrétní reprezentace systému podle nich. Nejde o synonyma ani o rozlišení časových stavů.

### ? Architekt připravil konkrétní diagram infrastruktury e-shopu firmy pro provozní tým, sestavený podle předem dané šablony pro provozní IT. Co je tento diagram v terminologii TOGAF?

- [ ] Viewpoint
- [ ] Concern
- [x] View
- [ ] Stakeholder

> Konkrétní reprezentace daného systému pro určité concerns je view; šablona, podle níž vznikl, je viewpoint. Concern je zájem a stakeholder osoba či skupina, která ho má.

### ? Proč architektura pracuje s více views místo jednoho souhrnného modelu?

- [ ] Protože každá doména musí mít právě jeden povinný pohled
- [ ] Protože views nahrazují nutnost komunikovat se stakeholdery
- [ ] Protože jeden model nelze v nástrojích technicky uložit
- [x] Protože různí stakeholdeři mají různé concerns

> Každý stakeholder potřebuje vidět architekturu z hlediska svých concerns, a proto vzniká více views. Views komunikaci se stakeholdery neruší, ale umožňují.

## Role architekta {#role-architekta .explain}

Architekt v TOGAF **nevytváří řešení sám a v detailu**, ale vede tvorbu architektury tak, aby **adresovala concerns stakeholderů** a byla v souladu se strategií. Typicky identifikuje a zapojuje stakeholdery, převádí jejich potřeby do architektury, hledá **vyvážené kompromisy** (náklady × přínosy × rizika), drží **celistvost a soudržnost** řešení napříč doménami, komunikuje architekturu srozumitelně různým publikům a dohlíží, aby implementace odpovídala schválené architektuře. Vyžaduje to kombinaci byznysových, technických a komunikačních dovedností.

*Příklad:* Obchod chce rychle nový e-shop, bezpečnost trvá na přísných kontrolách a IT provoz na standardní platformě. Architekt najde řešení, které tyto zájmy vyvažuje, a zdůvodní ho všem stranám.

### ? Co je hlavní úlohou architekta podle přístupu TOGAF?

- [ ] Osobně navrhnout a naprogramovat klíčové části nového řešení
- [x] Vést architekturu tak, aby adresovala concerns stakeholderů
- [ ] Rozhodovat o rozpočtu všech projektů v podniku
- [ ] Vybírat dodavatele bez zapojení byznysu a nákupu

> Architekt vede tvorbu architektury, vyvažuje zájmy stakeholderů a drží soudržnost řešení. Programování, rozpočtové rozhodování za celý podnik ani jednostranný výběr dodavatelů jeho úlohou nejsou.

### ? Byznys tlačí na rychlé spuštění nové služby, bezpečnostní útvar požaduje rozsáhlé kontroly. Jak má architekt postupovat?

- [ ] Vyhovět byznysu, protože služba přináší podniku tržby
- [ ] Vyhovět bezpečnosti, protože riziko má vždy přednost
- [x] Navrhnout vyvážené řešení a zdůvodnit kompromis oběma stranám
- [ ] Odložit rozhodnutí, dokud se strany samy nedohodnou

> Architekt hledá kompromis mezi concerns stakeholderů a srozumitelně ho zdůvodní. Jednostranné upřednostnění jedné strany nebo čekání na samovolnou dohodu jeho roli neodpovídá.

## Enterprise architekt × solution architekt {#ea-vs-solution .compare}

Obě role spolupracují, liší se šíří záběru a časovým horizontem.

| | Enterprise architekt | Solution architekt |
|---|---|---|
| Záběr | celý podnik nebo jeho velkou část, napříč doménami | konkrétní řešení, projekt či systém |
| Horizont | dlouhodobý, strategický | horizont projektu nebo vydání řešení |
| Hlavní otázka | jak má podnik vypadat a jak se tam dostat | jak navrhnout toto řešení v souladu s architekturou |
| Výstupy | cílová architektura, principy, roadmapa, standardy | návrh řešení, které využívá standardy a stavební bloky |

### ? Který úkol typicky připadá spíše enterprise architektovi než solution architektovi?

- [ ] Návrh integrace konkrétní aplikace na platební bránu
- [ ] Volba knihoven a rámců pro vývoj jednoho systému
- [ ] Detailní návrh nasazení jednoho systému v cloudu
- [x] Formulace architektonických principů pro celý podnik

> Enterprise architekt pracuje napříč podnikem a dlouhodobě — principy, cílová architektura, roadmapa. Návrh integrace, volba knihoven či nasazení jednoho systému patří solution architektovi.

### ? Jaký je správný vztah mezi enterprise a solution architekturou?

- [x] Řešení se navrhují v souladu s podnikovou architekturou a jejími standardy
- [ ] Solution architektura nahrazuje podnikovou architekturu u velkých projektů
- [ ] Podniková architektura vzniká jako souhrn hotových návrhů jednotlivých řešení
- [ ] Obě architektury jsou na sobě nezávislé a navzájem se neovlivňují

> Podniková architektura dává rámec, principy a standardy a jednotlivá řešení se do ní mají vejít. Solution architektura ji nenahrazuje a podniková architektura není pouhým součtem projektů.

## Vztah TOGAF k jiným rámcům {#jine-ramce .explain}

TOGAF **nevylučuje jiné rámce ani metodiky**, ale je navržen tak, aby se s nimi kombinoval a přizpůsobil prostředí podniku. Typicky se doplňuje s jazykem **ArchiMate** (rovněž od The Open Group), který slouží k **modelování** architektury, zatímco TOGAF poskytuje **metodu a rámec** práce. S rámci řízení IT služeb (např. ITIL), governance IT (např. COBIT) či projektovými metodikami (např. PRINCE2) se TOGAF potkává na rozhraní: architektura dává směr a standardy, ty pak řídí dodání a provoz.

*Příklad:* Firma řídí projekty podle PRINCE2 a IT služby podle ITIL. Zavedením TOGAF tyto metodiky neruší — architektura určí cílový stav a pracovní balíky (work packages), které projekty dodají a provoz převezme.

### ? Jaký je vztah TOGAF a ArchiMate?

- [ ] ArchiMate je novější verze TOGAF, která ho plně nahrazuje
- [ ] TOGAF je modelovací jazyk a ArchiMate metoda vývoje architektury
- [x] TOGAF dává metodu a rámec, ArchiMate jazyk pro modelování architektury
- [ ] Jde o konkurenční rámce, které nelze v jednom podniku kombinovat

> TOGAF poskytuje metodu (ADM) a rámec, ArchiMate notaci pro modelování architektury; oba spravuje The Open Group a vzájemně se doplňují. Žádný z nich druhý nenahrazuje.

### ? Firma, která řídí projekty podle PRINCE2, zavádí TOGAF. Jak má s projektovou metodikou naložit?

- [ ] Opustit ji, protože TOGAF obsahuje vlastní řízení projektů
- [x] Zachovat ji a navázat na architekturu, která určuje cíl
- [ ] Nahradit ji fázemi ADM, které se řídí místo projektů
- [ ] Používat obojí odděleně, bez jakékoli vzájemné vazby

> TOGAF je navržen ke kombinaci s jinými rámci: architektura určí cílový stav a standardy, projektová metodika řídí dodání. TOGAF projektové řízení nenahrazuje a izolované používání by ztratilo provázanost.
