---
kind: topic
subject: togaf-foundation
slug: governance-kapabilita
name: "Architecture Governance a Architecture Capability"
order: 9
---

Principy a struktura governance, Architecture Board, Architecture Compliance, Architecture Contracts; zřízení architektonické kapability (organizace, role, dovednosti); Architecture Maturity jen přehledem.

## Architecture Governance {#architecture-governance .term}

Architecture Governance je **řízení a kontrola architektur v celém podniku**: kontrolní mechanismy, soulad se standardy a regulací, procesy a jasná odpovědnost. TOGAF ji chápe spíš jako **vedení (guidance)** a rozumné, férové hospodaření se zdroji než jako tvrdý dozor nad dodržováním pravidel.

### ? Co nejlépe vystihuje Architecture Governance podle TOGAF?

- [ ] Jednorázové schválení cílové architektury sponzorem na konci Phase A
- [x] Řízení a kontrola architektur v celém podniku včetně souladu a odpovědnosti
- [ ] Technická správa nástroje, v němž je uložen Architecture Repository
- [ ] Metodika řízení projektů, která nahrazuje řízení implementačních projektů

> Architecture Governance je trvalá praxe řízení a kontroly architektur v celém podniku — kontroly, soulad se standardy a regulací, procesy a odpovědnost. Nejde o jednorázové schválení, správu nástroje ani o náhradu projektového řízení.

### ? Který přístup NEODPOVÍDÁ pojetí governance v TOGAF?

- [ ] Důraz na vedení a na efektivní a spravedlivé využití zdrojů
- [ ] Zajištění odpovědnosti vůči jasně určeným stakeholderům
- [ ] Systém kontrol nad vznikem a sledováním architektonických činností
- [x] Především striktní kontrola a mechanické lpění na pravidlech

> TOGAF výslovně staví governance spíš na vedení a efektivním, spravedlivém využití zdrojů než na tvrdé kontrole a doslovném dodržování pravidel. Ostatní tři možnosti k pojetí governance patří.

## Úrovně governance v podniku (Levels of Governance) {#urovne-governance .explain}

Architecture governance není izolovaná — je jednou z vrstev hierarchie řízení podniku. Nejširší je **corporate governance** (správa a řízení společnosti), v jejím rámci **technology governance** a **IT governance** a v nich **architecture governance**. Každá nižší úroveň musí respektovat pravidla úrovní nadřazených. Jednotlivé druhy governance se navíc mohou uplatňovat na více geografických či organizačních úrovních podniku — globálně, regionálně i lokálně.

*Příklad:* Architektonický standard, který by byl v rozporu s pravidly corporate governance pro ochranu osobních údajů, Architecture Board neschválí — nadřazená úroveň má přednost.

### ? Jak TOGAF zařazuje architecture governance mezi ostatní druhy governance v podniku?

- [x] Je vnořenou úrovní v rámci corporate, technology a IT governance
- [ ] Stojí nad corporate governance a určuje pravidla pro vedení firmy
- [ ] Je samostatná a na ostatních druzích governance v podniku zcela nezávislá
- [ ] Nahrazuje IT governance v organizacích, které zavedly metodu ADM

> Architecture governance je součástí hierarchie governance: corporate → technology → IT → architecture governance. Musí respektovat nadřazené úrovně, takže nad nimi nestojí, není na nich nezávislá a IT governance nenahrazuje.

### ? Mezinárodní skupina má centrální i regionální IT. Co platí podle TOGAF pro uplatnění governance v takovém podniku?

- [ ] Governance se smí uplatňovat jen na jediné, centrální úrovni podniku
- [ ] Regionální jednotky si governance nastavují bez ohledu na centrálu
- [x] Governance může působit na více úrovních, globálně i regionálně
- [ ] Na regionální úrovni se místo governance používá jen Phase H

> Druhy governance se mohou uplatňovat na několika geografických či organizačních úrovních (globální, regionální, lokální), přičemž nižší úroveň respektuje pravidla vyšší. Úplná nezávislost regionů by hierarchii popřela a Phase H governance nenahrazuje.

## Charakteristiky governance (Characteristics of Governance) {#charakteristiky-governance .compare}

TOGAF uvádí šest vlastností, které má dobrá governance mít:

| Charakteristika | Co znamená |
|---|---|
| **Discipline** | dodržování dohodnutých postupů a pravomocí |
| **Transparency** | rozhodnutí i podklady otevřené k nahlédnutí |
| **Independence** | rozhodování bez střetů zájmů |
| **Accountability** | rozhodující skupiny jasně určené a odpovědné |
| **Responsibility** | každá strana jedná odpovědně |
| **Fairness** | nikdo nezíská nespravedlivou výhodu |

### ? Která charakteristika governance znamená, že rozhodovací mechanismy jsou nastavené tak, aby omezily střety zájmů?

- [ ] Transparency
- [x] Independence
- [ ] Accountability
- [ ] Discipline

> Independence znamená, že procesy a rozhodování jsou uspořádány tak, aby se minimalizovaly střety zájmů. Transparency se týká dostupnosti informací, Accountability jasně určené odpovědnosti a Discipline dodržování dohodnutých postupů.

### ? Rozhodnutí Architecture Boardu i podklady k nim jsou k dispozici k nahlédnutí všem oprávněným stranám. Kterou charakteristiku governance to naplňuje?

- [ ] Accountability
- [ ] Responsibility
- [ ] Independence
- [x] Transparency

> Transparency znamená, že kroky governance a podklady pro rozhodnutí lze oprávněnými stranami zkontrolovat. Accountability se týká jasně určené odpovědnosti rozhodujících skupin, ne zpřístupnění informací.

### ? Která z následujících vlastností NEPATŘÍ mezi charakteristiky governance uváděné v TOGAF?

- [ ] Discipline
- [ ] Fairness
- [x] Flexibility
- [ ] Accountability

> Šest charakteristik governance tvoří Discipline, Transparency, Independence, Accountability, Responsibility a Fairness. Flexibility mezi ně nepatří — flexibilita podnikové architektury je jedním z cílů Architecture Boardu, ne vlastnost governance.

## Architecture Governance Framework {#governance-framework .explain}

TOGAF popisuje rámec governance koncepčně ve třech částech: **procesy (process)**, **obsah (content)** — informace spravované v governance repozitáři — a **kontext (context)** — organizační struktury, role a vazby na zbytek podniku. Rámec je **orientovaný na procesy a oddělený od obsahu**: stejné procesy (posouzení souladu, výjimky, sledování) lze použít pro jakékoli architektonické informace a lze je napojit na procesy, které už organizace má (např. řízení IT služeb). Organizace tak může začít s malým rozsahem a postupně ho rozšiřovat.

*Příklad:* Firma používá stejný postup schvalování výjimek pro aplikační standardy i pro bezpečnostní politiky — mění se obsah, proces zůstává stejný.

### ? Proč je Architecture Governance Framework v TOGAF orientovaný na procesy a oddělený od obsahu?

- [ ] Aby každá architektonická doména měla vlastní, odlišný schvalovací proces
- [ ] Aby se governance týkala jen technologické vrstvy, a ne byznysu
- [ ] Aby se obsah architektury nemusel ukládat do žádného repozitáře
- [x] Aby šel napojit na existující procesy a použít pro různý obsah

> Oddělení procesů od obsahu umožňuje použít stejné governance procesy pro libovolné architektonické informace a začlenit je do stávajících řídicích procesů organizace. Neznamená to různé procesy pro domény, omezení na technologie ani rezignaci na repozitář.

### ? Které tři části tvoří koncepční strukturu Architecture Governance Framework?

- [x] Process, Content, Context
- [ ] Principles, Standards, Contracts
- [ ] Baseline, Target, Transition
- [ ] Board, Sponsor, Architect

> Rámec governance tvoří procesy (process), obsah spravovaný v repozitáři (content) a kontext, tedy organizační struktury a role (context). Ostatní trojice jsou pojmy z jiných částí TOGAF (např. Baseline/Target/Transition jsou stavy architektury).

## Klíčové procesy governance {#procesy-governance .compare}

Procesy, z nichž se Architecture Governance Framework skládá:

| Proces | Úloha |
|---|---|
| **Policy Management and Take-On** | nové politiky, změny architektury a Architecture Contracts se ověří, schválí a zaevidují do rámce governance, který je pak spravuje |
| **Compliance** | posuzování souladu se standardy, dohodami o úrovni služeb a regulací; průběžné revize |
| **Dispensation** | při negativním posouzení souladu lze požádat o časově omezenou výjimku |
| **Monitoring and Reporting** | sledování a vykazování výkonu governance i stavu souladu a výjimek |
| **Business Control** | zajišťuje dodržování firemních politik a pravidel |
| **Environment Management** | zajišťuje, aby rámec governance sám efektivně fungoval — repozitář, nástroje, administrace |

### ? Který proces Architecture Governance Framework zajišťuje, že nové politiky, změny architektury a kontrakty se ověří, schválí a zaevidují do rámce governance?

- [ ] Monitoring and Reporting
- [x] Policy Management and Take-On
- [ ] Environment Management
- [ ] Business Control

> Policy Management and Take-On je vstupní proces: architektonické změny, kontrakty a podpůrné informace se v něm ověří, schválí a převezmou do správy rámce governance. Monitoring and Reporting sleduje výkon, Environment Management provoz rámce a Business Control dodržování firemních politik.

### ? Který proces governance se stará o to, aby samotný rámec governance efektivně fungoval — o repozitář, nástroje a jejich administraci?

- [ ] Compliance
- [ ] Dispensation
- [x] Environment Management
- [ ] Policy Management and Take-On

> Environment Management zajišťuje fungování prostředí governance — repozitáře, nástrojů a administrace. Compliance posuzuje soulad, Dispensation řeší výjimky a Policy Management and Take-On přijímá nové politiky a změny.

## Výjimka (Dispensation) {#dispensation .term}

Formálně schválená **výjimka z architektury nebo standardu**, o kterou může dotčená oblast požádat, když posouzení souladu (compliance assessment) dopadne negativně. Uděluje se **na omezenou dobu** a pro konkrétně určené nesouladné části řešení; po uplynutí lhůty se situace znovu posoudí. Výjimky se evidují a sledují, aby se z nich nestal trvalý stav — a jejich opakování může signalizovat, že je potřeba upravit samotný standard nebo architekturu.

### ? Projekt nedokáže včas splnit standard pro šifrování databází a posouzení souladu proto dopadlo negativně. Jak s tím governance podle TOGAF typicky naloží?

- [ ] Projekt se automaticky ukončí, dokud standard nesplní
- [x] Lze požádat o časově omezenou výjimku (dispensation)
- [ ] Architekt standard potichu upraví, aby projekt vyhověl
- [ ] Nesoulad se jen zapíše a dál se již nesleduje

> Při negativním posouzení souladu existuje proces Dispensation — formální, časově omezená výjimka pro určené části, která se dál sleduje. Automatické ukončení není pravidlem, tichá úprava standardu obchází governance a nesledovaný nesoulad popírá smysl compliance.

### ? Co platí pro dispensation v rámci Architecture Governance?

- [ ] Trvale vyjímá projekt ze všech architektonických standardů
- [ ] Uděluje si ji vedoucí projektu sám bez dalšího schvalování
- [ ] Nahrazuje Architecture Contract mezi projektem a sponzorem
- [x] Uděluje se na omezenou dobu a pro určené nesouladné části

> Dispensation je časově omezená výjimka pro konkrétně vymezené nesouladné části, schválená v rámci governance a dále sledovaná. Není trvalá, není to rozhodnutí samotného projektu a Architecture Contract nenahrazuje.

## Obsah governance repozitáře {#governance-repozitar .term}

Část „content" rámce governance tvoří informace ve třech skupinách: **Reference Data** — pokyny a popisy governance postupů, podle nichž projekty postupují; **Process Status** — stav všech běžících governance procesů (otevřené žádosti o posouzení souladu a o výjimky, probíhající posouzení); **Audit Information** — záznam všech dokončených procesních kroků a rozhodnutí, který podkládá klíčová rozhodnutí a umožňuje dohledat odpovědnost.

### ? Kam v obsahu governance repozitáře patří záznam o všech dokončených procesních krocích a rozhodnutích, který slouží k dohledání odpovědnosti?

- [ ] Reference Data
- [ ] Process Status
- [ ] Architecture Landscape
- [x] Audit Information

> Audit Information uchovává záznam dokončených kroků a rozhodnutí pro dohledatelnost. Reference Data obsahuje pokyny a popisy postupů, Process Status stav běžících procesů; Architecture Landscape je část Architecture Repository s popisy architektur, ne governance záznamů.

### ? Kde v obsahu governance repozitáře architekt najde přehled otevřených žádostí o výjimky a právě probíhajících posouzení souladu?

- [x] Process Status
- [ ] Reference Data
- [ ] Audit Information
- [ ] Standards Library

> Process Status popisuje aktuální stav běžících governance procesů, včetně otevřených žádostí a probíhajících posouzení. Audit Information zachycuje už dokončené kroky, Reference Data pokyny a postupy; Standards Library obsahuje standardy, ne stav procesů.

## Architecture Board {#architecture-board .term}

Řídicí orgán **napříč organizací**, zřízený s **podporou vrcholového vedení**, který dohlíží na uplatňování architektonické strategie a na soulad realizovaných řešení s architekturou. Je klíčovým prvkem úspěšné architecture governance: rozhoduje o architekturách, vymáhá soulad a slouží jako eskalační místo pro rozhodnutí, která překračují stanovené mantinely. Bývá záměrně malý — několik stálých členů z vedení byznysu i IT — aby zůstal akceschopný.

### ? Co je Architecture Board?

- [ ] Tým architektů, který kreslí diagramy pro jednotlivé projekty
- [ ] Externí certifikační orgán, který schvaluje použití TOGAF
- [x] Celopodnikový orgán dohlížející na architekturu a její dodržování
- [ ] Řídicí výbor jediného projektu, který nahrazuje jeho sponzora

> Architecture Board je interní, celopodnikový řídicí orgán architecture governance. Není to výkonný tým architektů, externí certifikační autorita ani projektový řídicí výbor.

### ? Čí podpora je podle TOGAF předpokladem úspěšného zřízení Architecture Boardu?

- [ ] Externího dodavatele hlavního podnikového systému
- [x] Vrcholového vedení organizace
- [ ] Projektových manažerů jednotlivých projektů
- [ ] Uživatelů, kteří řešení každodenně používají

> Architecture Board má celopodnikovou autoritu a vymáhá soulad napříč projekty, proto musí být zřízen s podporou vrcholového vedení. Bez ní by jeho rozhodnutí projekty ani dodavatelé nerespektovali.

## Odpovědnosti Architecture Boardu {#board-odpovednosti .explain}

Architecture Board obvykle odpovídá za to, že:

- poskytuje **základ pro všechna rozhodnutí** týkající se architektur;
- zajišťuje **konzistenci mezi dílčími architekturami** (sub-architectures);
- stanovuje **cíle pro znovupoužití** komponent;
- udržuje podnikovou architekturu **flexibilní** vůči měnícím se potřebám byznysu a novým technologiím;
- **vymáhá Architecture Compliance** a dohlíží na plnění **Architecture Contracts**;
- zvyšuje **vyspělost (maturity)** architektonické disciplíny a prosazuje vývoj řízený architekturou;
- slouží jako viditelné **eskalační místo** pro rozhodnutí mimo stanovené mantinely a řeší nejasnosti a konflikty.

*Příklad:* Dva programy chtějí každý jinou integrační platformu. Board posoudí obě varianty vůči principům a rozhodne o jedné, aby se krajina netříštila.

### ? Která činnost NENÍ typickou odpovědností Architecture Boardu?

- [x] Každodenní řízení harmonogramu a rozpočtu projektů
- [ ] Zajištění konzistence mezi dílčími architekturami
- [ ] Vymáhání Architecture Compliance a dohled nad kontrakty
- [ ] Eskalační místo pro rozhodnutí mimo stanovené mantinely

> Board rozhoduje o architektuře, vymáhá soulad a slouží k eskalaci; operativní řízení harmonogramu a rozpočtu projektů zůstává na projektovém řízení. Ostatní tři činnosti k odpovědnostem Boardu patří.

### ? Dva programy navrhly vzájemně nekompatibilní integrační řešení a nedokážou se dohodnout. Kdo má podle TOGAF konflikt rozhodnout?

- [x] Architecture Board jako eskalační místo
- [ ] Každý vedoucí programu sám za sebe
- [ ] Dodavatel platformy podle svých doporučení
- [ ] Architecture Sponsor bez posouzení architektury

> Řešení konfliktů a nejasností mezi architekturami a eskalace rozhodnutí mimo mantinely patří Architecture Boardu. Samostatná rozhodnutí programů by vedla k nekonzistenci, dodavatel nemá rozhodovací pravomoc a sponzor nemá rozhodovat bez architektonického posouzení.

## Architecture Compliance {#architecture-compliance .term}

Posuzování, **nakolik implementace (projekt, systém) odpovídá architektonické specifikaci**. Pro governance je to jedna z nejdůležitějších funkcí — architektura, jejíž dodržování nikdo neověřuje, skutečně budovaná řešení neovlivní. Soulad se ověřuje systematicky, typicky formou Architecture Compliance Reviews v klíčových milnících projektu, a TOGAF pro vyjádření míry souladu používá škálu úrovní (Irrelevant, Consistent, Compliant, Conformant, Fully Conformant a Non-conformant).

### ? Co je předmětem Architecture Compliance?

- [ ] Shoda architektonického týmu s pracovním řádem organizace
- [ ] Ověření, že dodavatel má platnou certifikaci TOGAF
- [x] Ověření souladu implementace s architektonickou specifikací
- [ ] Porovnání výchozí a cílové architektury v analýze mezer

> Architecture Compliance posuzuje vztah mezi implementací a architektonickou specifikací. Nejde o pracovní řád, certifikaci dodavatele ani o Gap Analysis mezi Baseline a Target.

### ? Proč je Architecture Compliance pro architecture governance zásadní?

- [x] Protože bez ověřování se architektura do řešení nepromítne
- [ ] Protože nahrazuje potřebu Architecture Boardu a kontraktů
- [ ] Protože jejím výstupem je vždy nová cílová architektura
- [ ] Protože ji provádí výhradně externí auditor mimo organizaci

> Smysl governance je, aby se architektura skutečně promítla do budovaných řešení — a to bez ověřování souladu nelze zajistit. Compliance Board ani kontrakty nenahrazuje, nevytváří novou cílovou architekturu a neprovádí ji výhradně externí auditor.

## Úrovně souladu (Levels of Architecture Conformance) {#urovne-souladu .compare}

TOGAF popisuje vztah implementace a specifikace těmito úrovněmi:

| Úroveň | Co znamená |
|---|---|
| **Irrelevant** | implementace nemá se specifikací žádné společné rysy |
| **Consistent** | společné rysy jsou implementovány podle specifikace, ale část specifikace chybí a implementace má i rysy, které specifikace neřeší |
| **Compliant** | vše, co je implementováno, je specifikací pokryto a odpovídá jí, ale ne vše ze specifikace je implementováno |
| **Conformant** | vše ze specifikace je implementováno a implementace má navíc rysy mimo specifikaci |
| **Fully Conformant** | plná shoda — vše ze specifikace je implementováno a nic navíc |
| **Non-conformant** | některý implementovaný rys je v rozporu se specifikací (může nastat v kterékoli z předchozích situací) |

### ? Systém implementuje celou architektonickou specifikaci a navíc obsahuje několik funkcí, které specifikace neřeší. Jakou úroveň souladu má?

- [ ] Compliant
- [ ] Consistent
- [x] Conformant
- [ ] Fully Conformant

> Conformant znamená, že je implementováno vše ze specifikace, ale implementace obsahuje i rysy navíc. Fully Conformant by vyžadoval, aby nic navíc nebylo; Compliant a Consistent znamenají, že část specifikace chybí.

### ? Implementace neobsahuje vše, co specifikace požaduje, ale vše, co implementuje, je specifikací pokryto a odpovídá jí. Jakou úroveň souladu má?

- [ ] Conformant
- [x] Compliant
- [ ] Irrelevant
- [ ] Consistent

> Compliant: nic implementovaného nejde mimo specifikaci, jen část specifikace není implementována. Consistent by navíc obsahoval rysy mimo specifikaci, Conformant by implementoval celou specifikaci a Irrelevant nemá se specifikací nic společného.

### ? Kdy se implementace označí jako Non-conformant?

- [ ] Když nemá se specifikací žádné společné rysy
- [ ] Když obsahuje rysy, které specifikace vůbec neřeší
- [ ] Když neimplementuje všechny rysy ze specifikace
- [x] Když některý implementovaný rys odporuje specifikaci

> Non-conformant znamená, že něco implementovaného je v rozporu se specifikací. Žádné společné rysy odpovídají úrovni Irrelevant; rysy navíc nebo chybějící části specifikace samy o sobě nesoulad neznamenají.

## Smysl Architecture Compliance Review {#compliance-review-smysl .explain}

Compliance review je plánované posouzení konkrétního projektu vůči architektuře podniku. Jeho cíle: **zachytit odchylky co nejdřív**, kdy je oprava levná; prosadit osvědčené postupy; **odhalit, kde je třeba upravit nebo doplnit standardy či architekturu** (zpětná vazba z projektů); sdílet řešení mezi projekty a dát vedení přehled o stavu souladu. Výsledky jsou podkladem pro rozhodnutí Architecture Boardu, např. o udělení výjimky. Konkrétní průběh revizí při implementaci patří do Phase G.

*Příklad:* Revize ukáže, že tři projekty nezávisle obcházejí tentýž zastaralý standard. Board místo tří výjimek nechá standard aktualizovat.

### ? Který z uvedených cílů NENÍ cílem Architecture Compliance Review?

- [ ] Odhalit odchylky od architektury včas, kdy je oprava levná
- [x] Nahradit uživatelské akceptační testování řešení
- [ ] Zjistit, kde je potřeba upravit nebo doplnit standardy
- [ ] Dát vedení přehled o stavu souladu projektů s architekturou

> Compliance review posuzuje soulad s architekturou, zachytává odchylky včas, dává zpětnou vazbu standardům a přehled vedení. Akceptační testování funkčnosti uživateli je jiná činnost, kterou review nenahrazuje.

### ? Revize několika projektů ukáže, že všechny obcházejí stejný standard, protože je technicky zastaralý. Jaký je nejvhodnější závěr v duchu governance?

- [ ] Udělit všem projektům trvalé výjimky ze standardu
- [ ] Nález ignorovat, protože standard je formálně platný
- [x] Podnítit aktualizaci standardu přes governance procesy
- [ ] Zastavit všechny dotčené projekty do vydání nového standardu

> Compliance review slouží i jako zpětná vazba pro architekturu: opakovaný nesoulad s jedním standardem signalizuje, že je potřeba standard změnit řádnou cestou. Trvalé výjimky popírají smysl výjimek, ignorování nález zahazuje a plošné zastavení projektů je nepřiměřené.

## Architecture Contract {#architecture-contract .term}

Společná **dohoda mezi partnery na vývoji a sponzory o výstupech, kvalitě a vhodnosti (fitness-for-purpose)** architektury. Kontrakty jsou nástrojem, jímž se governance prakticky prosazuje: stanoví, co se má dodat a jakým architektonickým požadavkům musí řešení vyhovět; jejich plnění sleduje Architecture Board. Kontrakt je třeba řídit průběžně, nejen podepsat — jeho změny procházejí governance. V ADM se uzavírá typicky v Phase G.

### ? Co je Architecture Contract?

- [ ] Obchodní smlouva o nákupu licencí nástroje pro modelování
- [ ] Interní směrnice popisující strukturu Architecture Repository
- [x] Dohoda partnerů a sponzorů o výstupech a kvalitě architektury
- [ ] Pracovní smlouva architekta s vymezením jeho pravomocí

> Architecture Contract je dohoda mezi partnery na vývoji a sponzory o tom, co se dodá a v jaké kvalitě a vhodnosti vůči architektuře. Nejde o licenční ani pracovní smlouvu ani o směrnici k repozitáři.

### ? Jakou roli má Architecture Contract v architecture governance?

- [x] Je prostředkem k vymáhání souladu s architekturou
- [ ] Nahrazuje Architecture Board v jeho dohledu nad projekty
- [ ] Slouží jen jako archivní záznam a po podpisu se nesleduje
- [ ] Určuje pořadí fází ADM pro konkrétní iteraci architektury

> Kontrakty převádějí architektonické požadavky na závazky, jejichž plnění governance (zejména Architecture Board) sleduje. Board nenahrazují, po podpisu se dál řídí a s pořadím fází ADM nesouvisejí.

## Typy Architecture Contracts {#typy-kontraktu .compare}

TOGAF uvádí tři typické druhy kontraktů:

| Kontrakt | Mezi kým | Účel |
|---|---|---|
| **Statement of Architecture Work** | architektonická funkce × sponzor | vymezuje rozsah a přístup k architektonické práci (vzniká v Phase A) |
| **Contract between Architecture Design and Development Partners** | architektonická funkce × partneři na návrhu a vývoji řešení | závazek dodat řešení v souladu s architekturou, s fázemi výstupů a metrikami |
| **Contract between Architecting Function and Business Users** | architektonická funkce (IT governance) × uživatelé z byznysu, kteří řešení nasazují a provozují | zajišťuje soulad i během provozu; může obsahovat i architekturu služeb a úroveň služeb (SLA) |

### ? Který dokument TOGAF chápe jako kontrakt mezi architektonickou funkcí a sponzorem architektonické práce?

- [ ] Architecture Definition Document
- [ ] Request for Architecture Work
- [ ] Implementation and Migration Plan
- [x] Statement of Architecture Work

> Statement of Architecture Work je dohodou mezi architektonickou funkcí a sponzorem o rozsahu a přístupu k práci. Request for Architecture Work je jen žádost sponzora, Architecture Definition Document a Implementation and Migration Plan jsou výstupy, ne kontrakty.

### ? Který typ Architecture Contract zajišťuje soulad řešení s architekturou i během jeho provozu u uživatelů?

- [ ] Statement of Architecture Work
- [x] Contract between Architecting Function and Business Users
- [ ] Contract between Architecture Design and Development Partners
- [ ] Request for Architecture Work

> Kontrakt mezi architektonickou funkcí a uživateli z byznysu pokrývá řešení, která uživatelé nasazují a provozují, a drží jejich soulad i v provozu. Kontrakt s partnery na návrhu a vývoji se týká dodání řešení, Statement of Architecture Work architektonické práce a Request for Architecture Work kontraktem není.

## Typický obsah Architecture Contractu {#obsah-kontraktu .explain}

Kontrakt mezi partnery na návrhu a vývoji typicky obsahuje: úvod a pozadí, povahu dohody, **rozsah architektury**, architektonické a strategické **principy a požadavky**, **požadavky na soulad (conformance requirements)**, proces vývoje a řízení architektury a role, **měřítka cílové architektury**, definované fáze výstupů, **prioritizovaný společný pracovní plán**, časová okna a **metriky dodání a přínosu pro byznys**. Kontrakt tak propojuje architekturu s měřitelnými závazky, které lze při compliance reviews objektivně ověřit.

*Příklad:* Kontrakt na nový e-shop určuje, že řešení musí používat podnikovou identitní službu (conformance requirement), být hotové ve dvou fázích a snížit dobu vyřízení objednávky o 30 % (metrika).

### ? Který prvek NEPATŘÍ do typického obsahu Architecture Contractu mezi partnery na návrhu a vývoji?

- [x] Hodnocení výkonu jednotlivých vývojářů
- [ ] Požadavky na soulad (conformance requirements)
- [ ] Rozsah architektury a strategické principy
- [ ] Prioritizovaný společný pracovní plán

> Kontrakt obsahuje mimo jiné rozsah, principy, požadavky na soulad, pracovní plán a metriky. Hodnocení výkonu vývojářů je personální záležitost dodavatele a do architektonického kontraktu nepatří.

### ? Proč Architecture Contract obsahuje metriky, např. měřítka cílové architektury a metriky dodání?

- [ ] Aby šlo odměňovat architekty podle počtu vytvořených diagramů
- [x] Aby šlo objektivně ověřit splnění dohodnutých cílů
- [ ] Aby se během realizace nemusely konat compliance reviews
- [ ] Aby šlo kontrakt měnit bez projednání v rámci governance

> Metriky dávají governance objektivní měřítko, zda dodané řešení splnilo, co bylo dohodnuto. Compliance reviews nenahrazují, nesouvisejí s odměňováním architektů a změny kontraktu dál procházejí governance.

## Architecture Capability {#architecture-capability .term}

**Trvalá schopnost organizace provozovat podnikovou architekturu.** Tvoří ji organizační struktura (architektonická funkce či praxe, Architecture Board), role a odpovědnosti, dovednosti lidí, procesy (ADM, governance), Architecture Repository a nástroje. TOGAF chápe architektonickou kapabilitu jako **průběžnou praxi, ne jednorázový projekt** — zřizuje a řídí se podobně jako kterákoli jiná schopnost podniku.

### ? Co TOGAF rozumí pojmem Architecture Capability?

- [ ] Jednorázový projekt, jehož výstupem je cílová architektura
- [ ] Byznysovou schopnost podniku, kterou architekti modelují
- [ ] Licenci k používání TOGAF udělenou organizací The Open Group
- [x] Trvalou schopnost organizace provozovat podnikovou architekturu

> Architecture Capability je trvalá praxe — organizace, role, dovednosti, procesy, repozitář a nástroje — umožňující dělat podnikovou architekturu. Není to jednorázový projekt ani licence; byznysová schopnost (business capability) je jiný pojem, který architekti modelují.

### ? Co z následujícího NEPATŘÍ mezi složky architektonické kapability organizace?

- [ ] Architecture Board a governance procesy
- [x] Cílová architektura jednoho projektu
- [ ] Role, odpovědnosti a dovednosti architektů
- [ ] Architecture Repository a podpůrné nástroje

> Kapabilitu tvoří struktura, governance, role a dovednosti, procesy, repozitář a nástroje. Cílová architektura konkrétního projektu je výsledek práce kapability, ne její složka.

## Zřízení kapability pomocí ADM {#kapabilita-pomoci-adm .explain}

TOGAF doporučuje zřizovat architektonickou kapabilitu jako kteroukoli jinou změnu — **pomocí ADM, kde předmětem architektury je sama architektonická praxe**. Preliminary Phase a Phase A vymezí rámec, rozsah a vizi kapability; **Phase B** popisuje „byznys" architektonické praxe (organizační strukturu, procesy, role, governance, dovednosti); **Phase C** řeší data (obsah a strukturu Architecture Repository) a aplikace (nástroje pro práci s architekturou); **Phase D** technologickou infrastrukturu pro tyto nástroje; Phases E–H plánují, zavádějí a řídí změny kapability.

*Příklad:* Banka v Phase B své architektonické praxe určí, kdo schvaluje standardy a jaké role architektů potřebuje; v Phase C vybere nástroj pro správu repozitáře.

### ? Jak TOGAF doporučuje postupovat při zřizování architektonické kapability?

- [ ] Nejprve koupit modelovací nástroj a podle něj nastavit procesy
- [ ] Převzít organizační model jiné firmy beze změn a přizpůsobení
- [x] Projít ADM, kde předmětem architektury je samotná praxe
- [ ] Odložit ji, dokud nebude hotová cílová architektura celého podniku

> Kapabilita se buduje jako jakákoli jiná změna — iterací ADM, v níž je „podnikem" samotná architektonická praxe. Začínat nástrojem, kopírovat cizí model bez přizpůsobení nebo čekat na hotovou cílovou architekturu je v rozporu s tímto přístupem.

### ? Při zřizování architektonické kapability pomocí ADM tým vybírá nástroj pro tvorbu a správu obsahu Architecture Repository. Které fázi ADM to nejlépe odpovídá?

- [ ] Phase H
- [ ] Phase B
- [ ] Phase F
- [x] Phase C

> Při aplikaci ADM na architektonickou praxi řeší Phase C data (obsah repozitáře) a aplikace — tedy nástroje pro práci s architekturou. Phase B popisuje organizaci a procesy praxe, Phase F plánuje migraci a Phase H řídí změny.

### ? Při zřizování architektonické kapability pomocí ADM se popisuje organizační struktura architektonické praxe, její procesy, role a governance. Která fáze ADM to řeší?

- [x] Phase B (Business Architecture)
- [ ] Phase D (Technology Architecture)
- [ ] Phase E (Opportunities and Solutions)
- [ ] Phase G (Implementation Governance)

> Organizace, procesy, role a governance architektonické praxe tvoří její „byznys" architekturu, a proto patří do Phase B. Phase D řeší technologickou infrastrukturu, Phase E příležitosti a řešení a Phase G dohled nad implementací.

## Role v architektonické kapabilitě {#role-kapabilita .explain}

Architektonická praxe obvykle zahrnuje tyto role: **Architecture Sponsor** (zadavatel a garant architektonické práce, zajišťuje podporu a zdroje), **Architecture Board** (dohled, rozhodování o souladu a výjimkách), vedoucí architektonické funkce (Enterprise Architecture Manager) a architekty podle zaměření — **Enterprise, Business, Data, Application a Technology Architect**. Na straně realizace spolupracují programoví a projektoví manažeři a návrháři řešení. Podstatné je **oddělení odpovědností**: architekti architekturu navrhují a udržují, Board rozhoduje a dohlíží, projekty realizují.

*Příklad:* Datový architekt navrhne standard pro kmenová data, Architecture Board ho schválí a projekt CRM ho při implementaci uplatní.

### ? Kdo v architektonické kapabilitě typicky rozhoduje o souladu projektů a o výjimkách — na rozdíl od architektů, kteří architekturu navrhují?

- [ ] Projektový manažer realizujícího projektu
- [ ] Návrhář konkrétního IT řešení
- [x] Architecture Board
- [ ] Datový architekt (Data Architect)

> Rozhodování o souladu, výjimkách a eskalacích patří Architecture Boardu. Architekti architekturu navrhují a udržují a projektový manažer s návrhářem řešení realizují — o vlastním souladu rozhodovat nemají.

### ? Která role v architektonické praxi zadává architektonickou práci, zajišťuje pro ni podporu a zdroje a odpovídá za její přínos?

- [x] Architecture Sponsor
- [ ] Technology Architect
- [ ] Enterprise Architecture Manager
- [ ] Projektový manažer implementace

> Architecture Sponsor je zadavatel a garant architektonické práce. Enterprise Architecture Manager vede architektonickou funkci, Technology Architect navrhuje technologickou architekturu a projektový manažer řídí realizaci.

## Architecture Skills Framework {#skills-framework .explain}

Rámec, který pro jednotlivé **role** v architektonické praxi popisuje potřebné **dovednosti** a **požadovanou úroveň jejich zvládnutí**. Dovednosti jsou seskupené do kategorií (např. obecné dovednosti, byznysové dovednosti a metody, dovednosti podnikové architektury, řízení programů a projektů, znalosti IT a právního prostředí) a u každé role je určeno, jak hluboko je má ovládat. Přínosy: jednotné vymezení rolí, cílený nábor a vzdělávání, snazší posouzení kandidátů i dodavatelů a rychlejší a levnější vybudování architektonického týmu.

*Příklad:* Firma podle rámce zjistí, že její datoví architekti potřebují hlubší znalost byznysových procesů, a naplánuje jim školení.

### ? K čemu slouží Architecture Skills Framework?

- [ ] K hodnocení vyspělosti architektonických procesů celé organizace
- [x] K vymezení dovedností a jejich úrovní pro jednotlivé role
- [ ] K výběru stavebních bloků řešení ukládaných do repozitáře
- [ ] K posouzení souladu implementace s architektonickou specifikací

> Architecture Skills Framework definuje, jaké dovednosti a v jaké hloubce potřebují jednotlivé role. Vyspělost praxe hodnotí modely vyspělosti, soulad implementace Architecture Compliance a stavební bloky jsou téma Architecture Content Frameworku.

### ? Firma buduje architektonický tým a chce nabírat a školit lidi podle jednotných požadavků na jednotlivé role. Co z TOGAF jí nejvíce pomůže?

- [ ] Architecture Maturity Model
- [ ] Architecture Contract
- [ ] Architecture Compliance Review
- [x] Architecture Skills Framework

> Jednotné požadavky na dovednosti rolí pro nábor a vzdělávání poskytuje Architecture Skills Framework. Model vyspělosti hodnotí praxi jako celek, kontrakt upravuje závazky dodávky a compliance review posuzuje soulad projektu.

## Modely vyspělosti (Architecture Maturity Models) {#maturity-modely .term}

Modely, které hodnotí, **jak vyspělá je architektonická praxe organizace**, na stupnici úrovní od počáteční (ad hoc) po řízenou a průběžně zlepšovanou. Vycházejí z myšlenky **Capability Maturity Model (CMM)**; příkladem určeným pro podnikovou architekturu je **ACMM (Architecture Capability Maturity Model)**. Hodnocení ukáže současnou úroveň, slabá místa a další krok zlepšení; zvyšování vyspělosti architektonické disciplíny je i jedním z cílů Architecture Boardu.

### ? K čemu organizace používá model vyspělosti architektury, např. ACMM?

- [x] K posouzení vyspělosti architektonické praxe a cest zlepšení
- [ ] K určení úrovně souladu konkrétního projektu s architekturou
- [ ] K rozhodnutí, kterou žádost o výjimku z architektury schválit
- [ ] K seřazení pracovních balíků podle jejich hodnoty a rizika

> Model vyspělosti hodnotí architektonickou praxi jako celek a ukazuje cestu ke zlepšení. Úroveň souladu projektu určuje Architecture Compliance, výjimky řeší proces Dispensation a prioritizace pracovních balíků patří do plánování migrace.

### ? Z jakého konceptu modely vyspělosti architektury (Architecture Maturity Models) vycházejí?

- [ ] Z Balanced Scorecard
- [ ] Z Enterprise Continuum
- [x] Z Capability Maturity Model (CMM)
- [ ] Z analýzy mezer (Gap Analysis) mezi architekturami

> Architektonické modely vyspělosti přebírají princip stupňovitých úrovní vyspělosti z Capability Maturity Model (CMM). Balanced Scorecard je systém měření výkonnosti, Enterprise Continuum klasifikuje architektury a Gap Analysis porovnává Baseline a Target.

## Nástroje governance v praxi {#nastroje-governance .compare}

Jak spolu hlavní nástroje architecture governance souvisejí:

| Nástroj | Otázka, na kterou odpovídá | Kdo / kdy |
|---|---|---|
| **Architecture Contract** | Co se dodá a jakým architektonickým požadavkům musí vyhovět? | partneři a sponzoři; před realizací, typicky Phase G |
| **Architecture Compliance Review** | Odpovídá řešení architektuře? | architekti s projektem; v milnících projektu |
| **Dispensation** | Smí se řešení dočasně odchýlit? | schvaluje governance; po negativním posouzení, časově omezeně |
| **Architecture Board** | Kdo rozhoduje a kam se eskaluje? | celopodnikový orgán; průběžně |

### ? Dodavatel má dodat nový CRM v souladu s architektonickými principy firmy, ve dvou fázích a s dohodnutými metrikami. Jak se takový závazek v TOGAF formálně zachycuje?

- [ ] Záznamem v Governance Log po dokončení projektu
- [x] Architecture Contractem mezi dodavatelem a firmou
- [ ] Udělením výjimky (dispensation) pro dodavatele
- [ ] Aktualizací Architecture Maturity Modelu firmy

> Závazek dodat řešení v souladu s architekturou, s fázemi a metrikami, je obsahem Architecture Contractu. Výjimka slouží k dočasné odchylce, záznam po skončení projektu závazek nevytváří a model vyspělosti se týká praxe jako celku.

### ? V milníku projektu chce architekt ověřit, zda návrh řešení odpovídá podnikové architektuře. Který nástroj governance je k tomu určen?

- [ ] Architecture Skills Framework
- [ ] Business Transformation Readiness Assessment
- [ ] Policy Management and Take-On
- [x] Architecture Compliance Review

> Ověření souladu návrhu s architekturou v milníku projektu je úkolem Architecture Compliance Review. Skills Framework popisuje dovednosti rolí, Business Transformation Readiness Assessment hodnotí připravenost na změnu a Policy Management and Take-On přijímá nové politiky do rámce governance.
