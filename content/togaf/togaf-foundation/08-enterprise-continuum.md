---
kind: topic
subject: togaf-foundation
slug: enterprise-continuum
name: "Enterprise Continuum a Architecture Repository"
order: 8
---

Enterprise Continuum (Architecture Continuum × Solutions Continuum, od obecného ke konkrétnímu), Architecture Repository a jeho části (Architecture Landscape, Reference Library, Standards Library, Governance Log…), referenční modely jen přehledem.

## Enterprise Continuum {#enterprise-continuum .term}

**Enterprise Continuum** je v TOGAF pohled na obsah Architecture Repository, který nabízí způsob, jak **třídit architektonická aktiva a řešení** — vlastní i převzatá zvenčí — podle toho, jak obecná či specifická jsou. Aktiva se na něm řadí od zcela obecných (použitelných v libovolném podniku) až po aktiva jedné konkrétní organizace.

### ? Co v TOGAF Standardu označuje pojem Enterprise Continuum?

- [ ] Plán postupného přechodu z Baseline do Target Architecture podniku
- [x] Pohled na repozitář, který třídí aktiva od obecných po specifická
- [ ] Cyklus fází ADM opakovaný pro každý nový projekt v podniku
- [ ] Soubor pravidel, jimiž Architecture Board hodnotí projekty

> Enterprise Continuum je klasifikační pohled na obsah Architecture Repository — řadí architektury a řešení od obecných ke specifickým. Plán přechodu popisuje Architecture Roadmap, cyklus fází je ADM a pravidla hodnocení patří do Architecture Governance.

### ? Která aktiva lze podle TOGAF zařadit do Enterprise Continuum?

- [ ] Pouze architektury, které podnik sám vytvořil v cyklech ADM
- [ ] Pouze schválené produkty dodavatelů zavedené v podniku
- [ ] Pouze referenční modely, které publikuje The Open Group
- [x] Interní i externí architektury a řešení všech úrovní

> Enterprise Continuum zahrnuje vlastní i převzatá aktiva (např. oborové referenční modely), a to jak architektury, tak řešení. Omezení na jediný zdroj nebo typ aktiv neodpovídá jeho smyslu.

## K čemu slouží Enterprise Continuum {#ec-ucel .explain}

Enterprise Continuum pomáhá architektům **najít a znovu použít** existující aktiva místo toho, aby vše tvořili od nuly. Dává **společný slovník** pro komunikaci — mezi architekty uvnitř podniku i s dodavateli a partnery — o tom, „na jaké úrovni obecnosti" se daná architektura či řešení nachází. Zároveň zasazuje architektonickou práci do **kontextu** podniku (business drivery a požadavky), takže je zřejmé, proč a pro koho aktivum vzniklo. Při práci v ADM se tak snadněji vybírají vhodné referenční modely a stavební bloky.

*Příklad:* Pojišťovna navrhuje novou architekturu pro správu pojistných událostí. V repozitáři najde oborový referenční model pro pojišťovnictví a vlastní dříve schválenou bezpečnostní architekturu — obojí převezme a přizpůsobí, místo aby je vymýšlela znovu.

### ? Který přínos je hlavním důvodem, proč TOGAF zavádí Enterprise Continuum?

- [x] Podpora znovupoužití aktiv a společný slovník pro jejich třídění
- [ ] Automatické generování cílové architektury z referenčních modelů
- [ ] Nahrazení Architecture Board při rozhodování o souladu projektů
- [ ] Stanovení pořadí, v němž se mají realizovat pracovní balíky

> Enterprise Continuum slouží ke klasifikaci aktiv, a tím k jejich znovupoužití a ke srozumitelné komunikaci. Nic automaticky negeneruje, governance nenahrazuje a pořadí pracovních balíků řeší plánování ve Phase E a F.

### ? Architekt jedná s dodavatelem softwaru a potřebuje vyjasnit, zda nabízený produkt je obecná platforma, nebo řešení šité na míru jednomu oboru. Která koncepce TOGAF mu k tomu dává společný jazyk?

- [ ] Architecture Contract
- [ ] Content Metamodel
- [x] Enterprise Continuum
- [ ] Gap Analysis

> Enterprise Continuum třídí aktiva podle úrovně obecnosti (od Foundation po Organization-Specific), a dává tak společný slovník i pro jednání s dodavateli. Architecture Contract je dohoda o realizaci, Content Metamodel popisuje entity obsahu a Gap Analysis hledá rozdíly mezi Baseline a Target.

## Z čeho se Enterprise Continuum skládá {#ec-slozeni .explain}

Enterprise Continuum tvoří dvě navazující kontinua: **Architecture Continuum** (architektury — logický popis toho, co je potřeba) a **Solutions Continuum** (řešení — konkrétní realizace těchto architektur). Obě jsou zasazena do **kontextu a požadavků podniku**, tedy do business driverů, cílů a omezení, které určují, proč se architektura vůbec vytváří. Každá úroveň Architecture Continuum **vede a podporuje (guides and supports)** odpovídající úroveň Solutions Continuum.

*Příklad:* Oborová architektura pro maloobchod (Architecture Continuum) popisuje, jaké funkce a data pokladní systém potřebuje; konkrétní pokladní software na trhu, který ji realizuje, patří do Solutions Continuum.

### ? Ze kterých dvou hlavních částí se skládá Enterprise Continuum?

- [ ] Z Architecture Landscape a Solutions Landscape
- [ ] Z Baseline Architecture a Target Architecture
- [x] Z Architecture Continuum a Solutions Continuum
- [ ] Z Reference Library a Standards Library

> Enterprise Continuum tvoří Architecture Continuum a Solutions Continuum, zasazené do kontextu podniku. Landscapes, Reference Library a Standards Library jsou části Architecture Repository; Baseline a Target jsou stavy architektury.

### ? Jaký vztah má podle TOGAF Architecture Continuum k Solutions Continuum?

- [x] Architektury vedou a podporují tvorbu odpovídajících řešení
- [ ] Řešení se nejprve nasadí a architektury je zpětně dokumentují
- [ ] Obě kontinua jsou nezávislá a každé spravuje jiná organizace
- [ ] Solutions Continuum je jen starší název pro Architecture Continuum

> Architecture Continuum (co je potřeba) vede a podporuje Solutions Continuum (jak je to realizováno), a to na každé úrovni obecnosti. Nejde o zpětnou dokumentaci, nezávislé celky ani o synonyma.

## Architecture Continuum × Solutions Continuum {#arch-vs-sol .compare}

Obě kontinua mají stejné čtyři úrovně obecnosti, liší se tím, co obsahují.

| | Architecture Continuum | Solutions Continuum |
|---|---|---|
| Obsah | architektury, modely, vzory, ABB | produkty, služby a realizovaná řešení, SBB |
| Povaha | logická — „co je potřeba" | fyzická — „čím a jak se to realizuje" |
| Úrovně | Foundation, Common Systems, Industry, Organization-Specific Architectures | Foundation, Common Systems, Industry, Organization-Specific Solutions |
| Role | vede a podporuje tvorbu řešení | realizuje odpovídající architektury |

### ? Podnik eviduje komerční produkt pro správu identit, který už nasadil, a chce jej zařadit do Enterprise Continuum. Kam produkt patří?

- [ ] Do Architecture Continuum, protože je znovupoužitelný
- [ ] Do Governance Log, protože prošel schválením
- [ ] Do Architecture Metamodel, protože popisuje bezpečnost
- [x] Do Solutions Continuum, protože jde o konkrétní realizaci

> Konkrétní produkty a nasazená řešení patří do Solutions Continuum. Architecture Continuum obsahuje logické architektury; Governance Log a Architecture Metamodel jsou části repozitáře s jiným účelem.

### ? Které tvrzení o Architecture Continuum a Solutions Continuum je SPRÁVNÉ?

- [ ] Architecture Continuum má čtyři úrovně, Solutions Continuum jen dvě
- [x] Obě mají stejné úrovně, od Foundation po Organization-Specific
- [ ] Solutions Continuum obsahuje ABB, Architecture Continuum SBB
- [ ] Architecture Continuum popisuje fyzickou realizaci řešení

> Obě kontinua sdílejí stejné čtyři úrovně (Foundation, Common Systems, Industry, Organization-Specific). Architecture Continuum je logické a pracuje s ABB, Solutions Continuum je fyzické a pracuje s SBB.

## Směr pohybu po kontinuu {#smer-kontinua .explain}

Kontinuum se čte **zleva doprava od obecného ke specifickému**: Foundation → Common Systems → Industry → Organization-Specific. Pohyb doprava znamená **specializaci** — obecná aktiva se přizpůsobují konkrétním potřebám a business požadavkům podniku. Pohyb doleva znamená **zobecnění a využití** — z konkrétní práce se vytahuje to, co lze znovu použít jinde. Mezi oběma kontinui pak platí posun od **logického** (architektury) k **fyzickému** (řešení).

*Příklad:* Banka převezme obecnou síťovou architekturu (Common Systems) a doplní ji o oborové požadavky na platební styk (Industry) a o svá vlastní pravidla (Organization-Specific). Když se později její řešení ukáže jako vzorové, zobecní ho pro další dceřiné společnosti — posun doleva.

### ? Co vyjadřuje pohyb po Architecture Continuum zleva doprava (od Foundation k Organization-Specific)?

- [x] Postupnou specializaci podle potřeb a požadavků konkrétního podniku
- [ ] Postupné zobecnění aktiv tak, aby šla použít v jiných podnicích
- [ ] Časovou posloupnost od Baseline přes Transition k Target
- [ ] Přechod od fyzických řešení k logickým architektonickým modelům

> Zleva doprava se aktiva specializují — od obecných ke specifickým pro podnik. Zobecnění odpovídá opačnému směru, časová posloupnost Baseline–Target s kontinuem nesouvisí a logické → fyzické je vztah Architecture × Solutions Continuum.

### ? Architektonický tým zjistil, že jeho integrační návrh pro jednu divizi lze použít i v ostatních divizích, a upraví ho do obecnější podoby. Jakému pohybu po Enterprise Continuum to odpovídá?

- [ ] Specializaci směrem k Organization-Specific Architectures
- [ ] Přesunu ze Solutions Continuum do Architecture Landscape
- [ ] Přechodu z logické architektury na fyzické řešení
- [x] Zobecnění pro znovupoužití, tedy pohybu doleva

> Vytažení znovupoužitelného jádra z konkrétní práce je pohyb doleva — zobecnění pro další využití. Specializace je opačný směr, Architecture Landscape není součástí kontinua a přechod logické → fyzické se týká vztahu dvou kontinuí.

## Foundation Architecture {#foundation-architecture .term}

**Foundation Architecture** je nejobecnější úroveň Architecture Continuum: architektura obecných služeb a funkcí, která je **použitelná v jakémkoli podniku** a tvoří základ, na němž se staví specifičtější architektury. Typicky obsahuje obecné stavební bloky, jejich vztahy a principy. Jako příklad se v TOGAF tradičně uvádí Technical Reference Model (TRM).

### ? Která úroveň Architecture Continuum obsahuje nejobecnější služby a funkce použitelné v jakémkoli podniku?

- [ ] Common Systems Architectures
- [x] Foundation Architecture
- [ ] Industry Architectures
- [ ] Organization-Specific Architectures

> Foundation Architecture je nejobecnější úroveň — obecné služby a funkce bez vazby na obor či konkrétní podnik. Ostatní úrovně jsou postupně specifičtější.

### ? Která charakteristika NEODPOVÍDÁ Foundation Architecture?

- [ ] Obsahuje obecné stavební bloky a vztahy mezi nimi
- [ ] Slouží jako základ pro specifičtější architektury
- [x] Zachycuje požadavky typické pro jedno odvětví
- [ ] Je použitelná napříč různými podniky a obory

> Požadavky typické pro určité odvětví popisují Industry Architectures. Foundation Architecture je naopak oborově neutrální základ s obecnými stavebními bloky.

## Common Systems Architectures {#common-systems .term}

**Common Systems Architectures** stavějí na Foundation Architecture a vybírají a skládají z ní služby tak, aby vznikla architektura **obecně užitečného systému**, který lze opakovaně nasadit v mnoha podnicích a oborech. Typickými příklady jsou architektury pro **bezpečnost, správu systémů, sítě či komunikaci**. Jako referenční model této úrovně se uvádí Integrated Information Infrastructure Reference Model (III-RM).

### ? Které z uvedených je typickým příkladem Common Systems Architecture?

- [ ] Datový model určený výhradně pro maloobchodní řetězce
- [ ] Architektura logistiky jednoho konkrétního dopravce
- [ ] Obecný katalog služeb platformy bez vazby na systém
- [x] Bezpečnostní architektura použitelná v mnoha oborech

> Common Systems Architectures popisují znovupoužitelné systémy napříč obory, typicky bezpečnost, správu systémů nebo sítě. Oborový datový model je Industry Architecture, architektura jednoho dopravce je Organization-Specific a obecný katalog služeb odpovídá Foundation Architecture.

### ? Jak se Common Systems Architectures liší od Foundation Architecture?

- [x] Skládají obecné služby do architektur běžně užívaných systémů
- [ ] Jsou obecnější a slouží jako základ pro Foundation Architecture
- [ ] Popisují jen řešení jednoho odvětví, například bankovnictví
- [ ] Obsahují konkrétní produkty, a patří proto do Solutions Continuum

> Common Systems Architectures vybírají a kombinují služby z Foundation Architecture do architektur systémů, které jsou užitečné v mnoha podnicích. Jsou specifičtější než Foundation, nejsou oborové a jako architektury patří do Architecture Continuum.

## Industry Architectures {#industry-architecture .term}

**Industry Architectures** spojují obecné komponenty z Common Systems Architectures s komponentami **specifickými pro určité odvětví** (např. bankovnictví, telekomunikace, energetiku či maloobchod). Obvykle obsahují oborové datové a procesní modely, typické aplikace a oborová pravidla. Často je vydávají **oborová konsorcia** a podniky je přejímají jako výchozí bod.

### ? Telekomunikační operátor převezme referenční procesní a datový model, který vydalo oborové sdružení telekomunikačních firem. Na které úrovni Architecture Continuum se tento model nachází?

- [ ] Foundation Architecture
- [ ] Organization-Specific Architectures
- [x] Industry Architectures
- [ ] Common Systems Architectures

> Model platný pro celé odvětví, vydaný oborovým sdružením, je typická Industry Architecture. Foundation a Common Systems jsou oborově neutrální, Organization-Specific se týká jen jednoho podniku.

### ? Co je charakteristické pro Industry Architectures?

- [ ] Platí pro jeden podnik a řídí nasazení jeho řešení
- [x] Doplňují obecné komponenty o prvky specifické pro odvětví
- [ ] Neobsahují datové modely, jen technologickou platformu
- [ ] Vznikají výhradně ve Phase G jako výstup compliance revizí

> Industry Architectures kombinují obecné (common systems) komponenty s oborově specifickými prvky, často včetně datových a procesních modelů. Architektura jednoho podniku je Organization-Specific; s Phase G nemají přímou vazbu.

## Organization-Specific Architectures {#org-specific .term}

**Organization-Specific Architectures** jsou nejspecifičtější úrovní Architecture Continuum: popisují architekturu **jednoho konkrétního podniku** (případně sítě propojených podniků) a vedou finální nasazení řešení v něm. Odrážejí jeho strategii, požadavky, principy a omezení. Právě tyto architektury podnik vytváří při běžných cyklech ADM, přičemž čerpá z obecnějších úrovní.

### ? Která úroveň Architecture Continuum odpovídá architekturám, které podnik vytváří pro sebe v běžných cyklech ADM?

- [x] Organization-Specific Architectures
- [ ] Common Systems Architectures
- [ ] Foundation Architecture
- [ ] Industry Architectures

> Architektury konkrétního podniku, vytvářené v jeho cyklech ADM, jsou Organization-Specific Architectures. Ostatní úrovně jsou obecnější a podnik z nich čerpá.

### ? Proč architekt při tvorbě Organization-Specific Architecture prochází i obecnější úrovně kontinua?

- [ ] Protože TOGAF zakazuje vytvářet vlastní stavební bloky
- [ ] Protože obecné úrovně nahrazují analýzu business požadavků
- [ ] Protože jen obecné úrovně může schválit Architecture Board
- [x] Aby převzal a přizpůsobil hotová aktiva místo tvorby od nuly

> Obecnější úrovně (Foundation, Common Systems, Industry) jsou zdrojem aktiv, která lze převzít a specializovat. Vlastní stavební bloky TOGAF nezakazuje, business požadavky je nutné analyzovat vždy a schvalování na úrovni kontinua nezávisí.

## Úrovně Solutions Continuum {#solutions-urovne .compare}

Solutions Continuum má stejné úrovně jako Architecture Continuum; každá z nich realizuje odpovídající úroveň architektur.

| Úroveň | Co obsahuje | Příklad |
|---|---|---|
| Foundation Solutions | velmi obecné nástroje, produkty a služby, na nichž stojí vše ostatní | programovací jazyky, operační systémy, obecné datové struktury |
| Common Systems Solutions | produkty a služby realizující obecně použitelné systémy | produkt pro správu bezpečnosti nebo pro dohled nad systémy |
| Industry Solutions | řešení pro konkrétní odvětví | oborové databázové schéma, pokladní zařízení pro maloobchod |
| Organization-Specific Solutions | řešení nasazené v jednom podniku podle jeho architektury | konkrétní implementace informačního systému u dané firmy |

### ? Do které úrovně Solutions Continuum patří operační systém nebo programovací jazyk?

- [ ] Common Systems Solutions
- [ ] Industry Solutions
- [ ] Organization-Specific Solutions
- [x] Foundation Solutions

> Operační systémy a programovací jazyky jsou velmi obecná řešení, na kterých stojí ostatní — patří do Foundation Solutions. Vyšší úrovně jsou postupně specifičtější.

### ? Výrobce dodává pokladní terminál navržený speciálně pro maloobchodní prodejny. Do které úrovně Solutions Continuum tento produkt patří?

- [ ] Foundation Solutions
- [x] Industry Solutions
- [ ] Common Systems Solutions
- [ ] Organization-Specific Solutions

> Produkt určený pro jedno odvětví (maloobchod), ale nabízený mnoha firmám, je Industry Solution. Organization-Specific by bylo až jeho konkrétní nasazení v jedné firmě; Foundation a Common Systems jsou oborově neutrální.

### ? Firma nasadila oborový CRM produkt, upravila ho podle svých procesů a propojila s vlastními systémy. Kam toto nasazené řešení patří?

- [x] Organization-Specific Solutions
- [ ] Common Systems Solutions
- [ ] Industry Solutions
- [ ] Foundation Solutions

> Konkrétní nasazení přizpůsobené jednomu podniku je Organization-Specific Solution. Samotný oborový produkt na trhu by byl Industry Solution, ale jeho implementace u dané firmy už je specifická pro organizaci.

## Referenční modely a Enterprise Continuum {#referencni-modely .explain}

Referenční modely jsou obecné, znovupoužitelné popisy, které se v Enterprise Continuum zařazují na obecnější úrovně. TOGAF tradičně uvádí dva vlastní modely: **Technical Reference Model (TRM)** jako příklad **Foundation Architecture** (obecná taxonomie platformních služeb) a **Integrated Information Infrastructure Reference Model (III-RM)** jako příklad **Common Systems Architecture** (zaměřený na tok informací napříč podnikem, tzv. Boundaryless Information Flow). V 10. vydání jsou oba modely popsány v samostatných Series Guides, nikoli ve Fundamental Content. Oborové referenční modely třetích stran odpovídají úrovni Industry Architectures.

*Příklad:* Architekt ve Phase D vyjde z TRM jako obecné taxonomie technologických služeb a doplní ho o konkrétní platformní standardy svého podniku.

### ? Který referenční model se v TOGAF uvádí jako příklad Foundation Architecture?

- [ ] Integrated Information Infrastructure Reference Model (III-RM)
- [ ] Oborový datový model publikovaný konsorciem
- [x] Technical Reference Model (TRM)
- [ ] Architecture Landscape na úrovni Strategic

> TRM je obecná taxonomie platformních služeb, a proto příklad Foundation Architecture. III-RM odpovídá Common Systems Architecture, oborový model Industry Architecture a Architecture Landscape není referenční model.

### ? Na kterou oblast se zaměřuje Integrated Information Infrastructure Reference Model (III-RM)?

- [ ] Na hodnocení zralosti architektonické kapability podniku
- [x] Na infrastrukturu umožňující tok informací napříč podnikem
- [ ] Na oborové procesy a data pro bankovnictví a pojišťovnictví
- [ ] Na plánování a financování migračních projektů

> III-RM je Common Systems Architecture zaměřená na infrastrukturu pro bezbariérový tok informací (Boundaryless Information Flow). Hodnocení zralosti, oborové modely ani plánování migrace jeho náplní nejsou.

## Enterprise Continuum v ADM {#ec-v-adm .explain}

Enterprise Continuum se v ADM uplatňuje dvěma směry. **Na vstupu** fází architektura čerpá z kontinua: zejména ve fázích B, C a D architekt vybírá vhodné referenční modely, vzory a stavební bloky z obecnějších úrovní. **Na výstupu** výsledky práce (nové architektury, stavební bloky, poznatky) se ukládají zpět do repozitáře a zařazují do kontinua, aby je mohly využít další cykly a projekty. Kontinuum tak roste s každou iterací ADM.

*Příklad:* Při vývoji Application Architecture tým převezme oborový model aplikací (Industry) a po dokončení uloží výslednou architekturu podniku jako Organization-Specific Architecture, ze které vyjde příští projekt.

### ? Jak se Enterprise Continuum typicky využívá při vývoji architektur ve Phase B, C a D?

- [x] Jako zdroj referenčních modelů a stavebních bloků k převzetí
- [ ] Jako náhrada kroků Baseline, Target a Gap Analysis
- [ ] Jako seznam schválených výjimek z architektonických principů
- [ ] Jako harmonogram pracovních balíků pro implementaci

> Ve fázích B–D architekt z kontinua vybírá referenční modely, vzory a stavební bloky. Kroky Baseline, Target a Gap Analysis nenahrazuje, výjimky se evidují v rámci governance a harmonogram vzniká až ve Phase E a F.

### ? Co se podle TOGAF děje s výsledky dokončeného cyklu ADM ve vztahu k Enterprise Continuum?

- [ ] Archivují se mimo repozitář, aby neovlivňovaly další cykly
- [ ] Odesílají se The Open Group k zařazení do Foundation Architecture
- [ ] Mažou se, protože kontinuum obsahuje jen externí modely
- [x] Uloží se do repozitáře a zařadí do kontinua k dalšímu použití

> Výsledky práce se vracejí do Architecture Repository a zařazují se do Enterprise Continuum, takže je mohou využít další projekty. Kontinuum obsahuje i interní aktiva a s každou iterací roste.

## Architecture Repository {#architecture-repository .term}

**Architecture Repository** je úložiště všech architektonických výstupů a podkladů podniku — vlastní práce i převzatých referenčních materiálů. Slouží k jejich uchování, správě a sdílení napříč architektonickými projekty a je logicky členěn do několika částí (metamodel, kapabilita, landscape, standardy, referenční knihovna, governance záznamy aj.). Enterprise Continuum je pak způsob, jak jeho obsah klasifikovat.

### ? Co je Architecture Repository?

- [ ] Nástroj pro modelování diagramů v jazyce ArchiMate
- [x] Úložiště architektonických výstupů a podkladů podniku
- [ ] Seznam projektů, které čekají na schválení Architecture Board
- [ ] Dokument, který formálně zadává architektonickou práci

> Architecture Repository uchovává a zpřístupňuje architektonický obsah podniku. Nejde o konkrétní modelovací nástroj, o pouhý seznam projektů ani o Request for Architecture Work.

### ? Jaký je vztah mezi Architecture Repository a Enterprise Continuum?

- [ ] Jde o dvě označení téhož úložiště v různých vydáních TOGAF
- [ ] Enterprise Continuum je jednou z částí Architecture Repository
- [x] Repozitář obsah uchovává, kontinuum jej třídí podle obecnosti
- [ ] Repozitář obsahuje jen řešení, kontinuum jen architektury

> Architecture Repository je úložiště, Enterprise Continuum je pohled, který jeho obsah klasifikuje od obecného ke specifickému. Nejsou synonymy, kontinuum není jednou z jeho částí a obě pracují s architekturami i řešeními.

## Části Architecture Repository {#repo-casti .compare}

Přehled hlavních částí repozitáře a otázky, na kterou každá odpovídá.

| Část | Na co odpovídá |
|---|---|
| Architecture Metamodel | Jak u nás vypadá metoda a obsah architektury (přizpůsobený rámec)? |
| Architecture Capability | Jak je zřízena a řízena architektonická funkce a repozitář? |
| Architecture Landscape | Jaká architektura podniku platí nebo je plánována v určitém čase? |
| Standards Library | Jakým standardům musí nové architektury vyhovět? |
| Reference Library | Z jakých vzorů, šablon a referenčních modelů lze vycházet? |
| Governance Log | Co bylo v rámci governance rozhodnuto a posouzeno? |
| Architecture Requirements Repository | Jaké architektonické požadavky jsou schváleny? |
| Solutions Landscape | Jaká řešení (SBB) podporují architekturu podniku? |

### ? Architekt hledá šablonu dokumentu a vzorový model, ze kterých by mohl vyjít při nové architektuře. Kterou část Architecture Repository použije?

- [ ] Governance Log
- [ ] Architecture Landscape
- [ ] Standards Library
- [x] Reference Library

> Šablony, vzory a referenční modely obsahuje Reference Library. Governance Log zaznamenává rozhodnutí, Architecture Landscape popisuje architekturu podniku v čase a Standards Library standardy, jimž je nutné vyhovět.

### ? Která položka NENÍ částí Architecture Repository?

- [x] Architecture Board
- [ ] Governance Log
- [ ] Architecture Landscape
- [ ] Reference Library

> Governance Log, Architecture Landscape a Reference Library jsou části Architecture Repository. Architecture Board je řídicí orgán architektonické governance, ne část repozitáře — jeho rozhodnutí se však zaznamenávají do Governance Log.

## Architecture Metamodel {#repo-metamodel .term}

**Architecture Metamodel** popisuje, jak podnik **přizpůsobil architektonický rámec svým potřebám** — tedy jakou metodu vývoje architektury používá (přizpůsobené ADM) a jaký metamodel obsahu architektury (jaké entity, vztahy a artefakty) uplatňuje. Je to „návod k použití" ostatního obsahu repozitáře.

### ? Co obsahuje Architecture Metamodel v Architecture Repository?

- [ ] Přehled standardů, jimž musí nová řešení vyhovět
- [ ] Záznamy rozhodnutí a výsledků compliance revizí
- [x] Přizpůsobenou metodu a metamodel obsahu architektury
- [ ] Popis architektury podniku na úrovni Strategic a Segment

> Architecture Metamodel zachycuje přizpůsobený rámec — metodu (tailored ADM) a metamodel obsahu. Standardy patří do Standards Library, rozhodnutí do Governance Log a popis architektury podniku do Architecture Landscape.

### ? Podnik upravil kroky ADM a rozhodl, které entity a artefakty bude v architektuře evidovat. Do které části repozitáře tato rozhodnutí o rámci patří?

- [ ] Architecture Capability
- [x] Architecture Metamodel
- [ ] Reference Library
- [ ] Solutions Landscape

> Přizpůsobená metoda a metamodel obsahu tvoří Architecture Metamodel. Architecture Capability popisuje architektonickou funkci a její procesy, Reference Library obsahuje vzory a šablony a Solutions Landscape nasazená řešení.

## Architecture Capability (v repozitáři) {#repo-capability .term}

Část **Architecture Capability** v repozitáři popisuje, jak je v podniku **zřízena a provozována architektonická praxe** — parametry, struktury a procesy, které podporují správu a governance repozitáře (např. organizační uspořádání architektonického týmu, role, odpovědnosti a procesy). Nezaměňovat s architekturou jednotlivých business capabilities, která patří do Architecture Landscape.

### ? Co popisuje část Architecture Capability v Architecture Repository?

- [x] Strukturu, role a procesy samotné architektonické praxe
- [ ] Schopnosti podniku vůči zákazníkům, např. vyřízení objednávky
- [ ] Seznam produktů nasazených v podniku a jejich vazby na ABB
- [ ] Hodnocení rizik jednotlivých pracovních balíků z Phase E

> Architecture Capability v repozitáři popisuje samotnou architektonickou funkci — její strukturu, role a procesy. Business schopnosti podniku se modelují v architekturách (Landscape), nasazené produkty patří do Solutions Landscape a rizika se řeší technikou Risk Management.

### ? Která informace by patřila do části Architecture Capability v Architecture Repository?

- [ ] Rozhodnutí Architecture Board o výjimce pro projekt CRM
- [ ] Oborový referenční model pro energetické společnosti
- [ ] Popis cílové architektury pro segment zákaznického servisu
- [x] Popis rolí a procesů architektonického týmu podniku

> Role a procesy architektonického týmu popisují architektonickou praxi, tedy Architecture Capability. Rozhodnutí o výjimce patří do Governance Log, oborový model do Reference Library a cílová architektura segmentu do Architecture Landscape.

## Architecture Landscape {#architecture-landscape .explain}

**Architecture Landscape** zachycuje architektonický popis aktiv, která podnik **používá nebo plánuje** v určitých okamžicích — tedy výchozí, přechodové i cílové stavy. Protože podnik nelze popsat v jedné úrovni detailu, člení se landscape podle granularity na **Strategic Architectures** (dlouhodobý pohled na celý podnik), **Segment Architectures** (detailnější popis oblasti či portfolia) a **Capability Architectures** (podrobný popis toho, jak podnik podpoří konkrétní schopnost). Jednotlivé popisy jsou propojené, takže lze sledovat vazbu od strategie až k detailu.

*Příklad:* Výrobní firma má v landscape strategickou architekturu celé firmy na 5 let, segmentovou architekturu pro oblast logistiky a podrobnou capability architekturu pro sledování zásilek, včetně jejího současného i cílového stavu.

### ? Co obsahuje Architecture Landscape?

- [ ] Standardy, produkty a sdílené služby, jimž musí architektury vyhovět
- [ ] Šablony, vzory a referenční modely pro urychlení nové práce
- [x] Popis architektury podniku používané nebo plánované v určitém čase
- [ ] Záznamy o rozhodnutích a compliance revizích napříč podnikem

> Architecture Landscape popisuje architekturu podniku v čase — současné i plánované stavy. Standardy obsahuje Standards Library, šablony Reference Library a rozhodnutí Governance Log.

### ? Podle jakého hlediska se člení Architecture Landscape na Strategic, Segment a Capability Architectures?

- [ ] Podle architektonických domén Business, Data, Application a Technology
- [x] Podle míry detailu a šíře záběru popisované architektury
- [ ] Podle úrovně obecnosti od Foundation po Organization-Specific
- [ ] Podle stavu schválení od návrhu po formální podpis

> Strategic, Segment a Capability Architectures se liší granularitou — od širokého dlouhodobého pohledu po podrobný popis jedné schopnosti. Domény jsou jiné hledisko a úrovně obecnosti patří k Enterprise Continuum.

## Standards Library {#standards-library .term}

**Standards Library** je část repozitáře se **standardy, jimž musí nové architektury a řešení vyhovět** (ve vydání 9.1 se tato část jmenovala Standards Information Base, SIB). Mohou to být právní a regulatorní požadavky, oborové a technické standardy, vybrané produkty a služby dodavatelů nebo sdílené služby, které už podnik provozuje. Soulad s nimi se pak ověřuje v rámci architektonické governance.

### ? Podnik stanovil, že všechny nové aplikace musí používat schválený protokol pro jednotné přihlašování a vyhovět regulaci ochrany osobních údajů. Kde se tyto požadavky v repozitáři evidují?

- [ ] Reference Library
- [ ] Architecture Metamodel
- [ ] Governance Log
- [x] Standards Library

> Standardy a regulace, jimž musí architektury vyhovět, patří do Standards Library. Reference Library obsahuje doporučené vzory, Architecture Metamodel přizpůsobený rámec a Governance Log záznamy governance.

### ? Čím se Standards Library liší od Reference Library?

- [x] Standards Library stanoví závazné standardy, Reference Library nabízí vzory k inspiraci
- [ ] Standards Library obsahuje jen externí materiály, Reference Library jen interní
- [ ] Standards Library patří do Solutions Continuum, Reference Library do Architecture Continuum
- [ ] Standards Library spravují dodavatelé, Reference Library spravuje Architecture Board

> Standards Library obsahuje standardy, s nimiž musí architektury být v souladu; Reference Library poskytuje vzory, šablony a referenční modely, které práci urychlují. Obě mohou obsahovat interní i externí materiály.

## Reference Library {#reference-library .term}

**Reference Library** obsahuje **vodítka, šablony, vzory (patterns), referenční architektury a modely** a další referenční materiály, které lze využít k **urychlení tvorby nových architektur**. Materiály mohou pocházet zvenčí (např. oborové referenční modely) i z vlastní praxe podniku. Její obsah se klasifikuje pomocí Enterprise Continuum.

### ? K čemu slouží Reference Library v Architecture Repository?

- [ ] K evidenci standardů, jejichž porušení vyžaduje výjimku
- [ ] K zaznamenání výsledků hodnocení souladu projektů
- [x] K urychlení práce pomocí vzorů, šablon a referenčních modelů
- [ ] K popisu architektury podniku v jednotlivých časových bodech

> Reference Library poskytuje opakovaně použitelné vzory, šablony a referenční modely. Závazné standardy jsou v Standards Library, hodnocení souladu v Governance Log a architektura v čase v Architecture Landscape.

### ? Který materiál by se typicky uložil do Reference Library?

- [ ] Záznam o udělení výjimky projektu z architektonického principu
- [x] Oborový referenční model a sada šablon pro artefakty
- [ ] Cílová architektura segmentu financí schválená pro tento rok
- [ ] Seznam schválených architektonických požadavků projektu

> Oborové referenční modely a šablony jsou typický obsah Reference Library. Výjimka patří do Governance Log, schválená cílová architektura do Architecture Landscape a požadavky do Architecture Requirements Repository.

## Governance Log {#governance-log .term}

**Governance Log** je **záznam o činnosti architektonické governance** napříč podnikem. Uchovává například rozhodnutí (včetně udělených výjimek), výsledky compliance assessments a hodnocení kapabilit, přehled projektů a další podklady, aby bylo zpětně dohledatelné, co bylo rozhodnuto, kdy a proč.

### ? Architecture Board schválil projektu výjimku z technologického standardu. Kam se toto rozhodnutí v Architecture Repository zaznamená?

- [x] Governance Log
- [ ] Standards Library
- [ ] Architecture Landscape
- [ ] Reference Library

> Rozhodnutí governance, včetně výjimek, se evidují v Governance Log. Standards Library obsahuje samotné standardy, ne rozhodnutí o odchylkách; Landscape popisuje architekturu a Reference Library vzory.

### ? Jaký je hlavní účel Governance Log?

- [ ] Ukládat přizpůsobenou metodu ADM a metamodel obsahu
- [ ] Popisovat nasazená řešení a jejich vazby na architekturu
- [ ] Shromažďovat oborové modely pro opakované použití
- [x] Zajistit dohledatelnost rozhodnutí a hodnocení governance

> Governance Log uchovává záznam o rozhodnutích a hodnoceních, aby byla governance transparentní a dohledatelná. Metoda patří do Architecture Metamodel, nasazená řešení do Solutions Landscape a oborové modely do Reference Library.

## Architecture Requirements Repository × Solutions Landscape {#pozadavky-a-reseni .compare}

Dvě části repozitáře, které navazují na další oblasti ADM.

| | Architecture Requirements Repository | Solutions Landscape |
|---|---|---|
| Obsah | všechny schválené (autorizované) architektonické požadavky | architektonický popis řešení (SBB), která podporují Architecture Landscape |
| Stav | požadavky odsouhlasené pro architektonickou práci | řešení plánovaná nebo již nasazená |
| Vazba v ADM | plní je proces Requirements Management | navazuje na realizaci architektur (Phase E–G) |

### ? Která část Architecture Repository obsahuje přehled všech schválených architektonických požadavků?

- [ ] Governance Log
- [x] Architecture Requirements Repository
- [ ] Standards Library
- [ ] Architecture Landscape

> Schválené architektonické požadavky shromažďuje Architecture Requirements Repository, se kterým pracuje Requirements Management. Governance Log eviduje rozhodnutí, Standards Library standardy a Landscape architekturu podniku.

### ? Co popisuje Solutions Landscape?

- [ ] Logické stavební bloky (ABB) cílové architektury podniku
- [ ] Obecné produkty na trhu zařazené do Foundation Solutions
- [x] Řešení (SBB) plánovaná či nasazená na podporu architektury
- [ ] Hodnocení dodavatelů a jejich nabídek z výběrového řízení

> Solutions Landscape je architektonický popis SBB, které podnik plánuje nebo nasadil na podporu Architecture Landscape. Logické ABB patří do architektur, obecné tržní produkty do Solutions Continuum a hodnocení dodavatelů není jeho náplní.

### ? Architekt chce zjistit, které konkrétní systémy dnes v podniku podporují cílovou architekturu segmentu prodeje. Kterou část repozitáře zkoumá?

- [ ] Reference Library
- [ ] Architecture Metamodel
- [ ] Architecture Capability
- [x] Solutions Landscape

> Konkrétní nasazená či plánovaná řešení (SBB), která podporují architekturu, popisuje Solutions Landscape. Reference Library obsahuje vzory, Architecture Metamodel přizpůsobený rámec a Architecture Capability architektonickou praxi.

## Architecture Landscape × Solutions Landscape × Enterprise Continuum {#landscape-vs-continuum .compare}

Tři pojmy, které se snadno zaměňují: dva popisují **co podnik má či plánuje**, třetí **jak se aktiva třídí**.

| | Architecture Landscape | Solutions Landscape | Enterprise Continuum |
|---|---|---|---|
| Co to je | část repozitáře | část repozitáře | klasifikační pohled na repozitář |
| Obsah | architektury podniku (Baseline, Transition, Target) | řešení (SBB) podporující tyto architektury | aktiva od obecných po specifická |
| Členění | Strategic, Segment, Capability | podle podporovaných architektur | Foundation → Organization-Specific |
| Zdroj obsahu | vlastní podnik | vlastní podnik | vlastní i externí aktiva |

### ? Které tvrzení správně odlišuje Architecture Landscape od Enterprise Continuum?

- [x] Landscape popisuje architekturu podniku v čase, kontinuum třídí aktiva podle obecnosti
- [ ] Landscape obsahuje jen externí modely, kontinuum jen vlastní architektury podniku
- [ ] Landscape je členěn od Foundation po Organization-Specific, kontinuum na Strategic a Segment
- [ ] Landscape je součástí Solutions Continuum, kontinuum součástí Governance Log

> Architecture Landscape popisuje, jakou architekturu podnik má nebo plánuje (členění Strategic, Segment, Capability); Enterprise Continuum třídí vlastní i externí aktiva od Foundation po Organization-Specific. Ostatní možnosti tato členění prohazují nebo vztahy převracejí.

### ? Kde by se v Architecture Repository uložila schválená cílová architektura zákaznického segmentu banky na příští tři roky?

- [ ] Ve Standards Library
- [ ] V Reference Library
- [x] V Architecture Landscape
- [ ] V Architecture Metamodel

> Popis architektury podniku — včetně cílových a přechodových stavů pro segment — patří do Architecture Landscape. Standards Library obsahuje standardy, Reference Library vzory a Architecture Metamodel přizpůsobený rámec.
