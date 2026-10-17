---
kind: topic
subject: togaf-foundation
slug: faze-e-f
name: "ADM — Phases E, F"
order: 5
---

Opportunities and Solutions (work packages, Transition Architectures, konsolidace mezer) a Migration Planning (Implementation and Migration Plan, prioritizace, Architecture Roadmap, Business Value).

## Phase E: Opportunities and Solutions — účel {#faze-e-ucel .explain}

**Phase E: Opportunities and Solutions** je první fáze ADM, která se přímo zabývá **realizací** — neptá se už „jak má cílová architektura vypadat", ale „**jak ji doručit**". Vychází z výstupů fází B, C a D: z Architecture Definition Document, Architecture Requirements Specification a z **kandidátních komponent Architecture Roadmap**, které v jednotlivých doménách vznikly z analýzy mezer.

Hlavní cíle fáze E:
- vytvořit **první úplnou verzi Architecture Roadmap** na základě mezer zjištěných v B–D,
- rozhodnout, zda je potřeba **postupný (inkrementální) přístup**, a pokud ano, navrhnout **přechodové architektury (Transition Architectures)**, z nichž každá přinese obchodní hodnotu,
- určit celkové **Solution Building Blocks** (SBB), které cílovou architekturu dokončí na úrovni řešení.

*Příklad:* Pojišťovna má z fází B–D popsané mezery v obsluze klientů, v datech o smlouvách i v infrastruktuře. Ve fázi E je architekt spojí do jednoho přehledu, seskupí do pracovních balíků a navrhne dvě přechodové etapy.

### ? Která fáze ADM je první, jež se přímo zabývá tím, jak cílovou architekturu prakticky doručit?

- [ ] Phase D: Technology Architecture
- [x] Phase E: Opportunities and Solutions
- [ ] Phase F: Migration Planning
- [ ] Phase H: Architecture Change Management

> Phase E přesouvá pozornost od popisu cílového stavu k jeho realizaci. Fáze D ještě definuje architekturu, fáze F na E navazuje plánem migrace a fáze H řídí změny až po nasazení.

### ? Co NENÍ cílem Phase E: Opportunities and Solutions?

- [ ] Vytvořit první úplnou verzi Architecture Roadmap
- [ ] Posoudit, zda je nutný postupný přístup s přechodovými architekturami
- [ ] Určit Solution Building Blocks, které dokončí cílovou architekturu
- [x] Uzavřít s realizačními týmy Architecture Contract na implementaci

> Architecture Contract s realizátory je typickou záležitostí Phase G: Implementation Governance. Roadmapa, přechodové architektury a SBB jsou naopak hlavními cíli fáze E.

## Atributy změny a obchodní omezení {#atributy-zmeny .explain}

Na začátku fáze E architekt zjišťuje, **jak je podnik na změnu nastaven**: jaká je jeho kultura a schopnost změnu vstřebat, jaké má zkušenosti s velkými projekty, kdo bude realizovat (vlastní IT, dodavatelé, partneři) a jaké jsou zdroje. Zjištění se zapisují do **Implementation Factor Catalog** — přehledu faktorů, které ovlivní realizaci, a závěrů, které z nich plynou.

Zároveň se určují **obchodní omezení pro implementaci (business constraints)** — například termíny navázané na legislativu, rozpočtové cykly, období, kdy se nesmí měnit provoz, nebo strategické priority vedení. Tato omezení pak mají přímý vliv na seskupení práce a na to, kolik přechodových kroků bude potřeba.

*Příklad:* Obchodní řetězec zakáže změny pokladních systémů od listopadu do ledna. Architekt to zapíše jako omezení a plánuje přechod pokladen mimo sezónu.

### ? Kam se ve fázi E zaznamenávají faktory ovlivňující realizaci změny a závěry, které z nich architekt vyvodil?

- [ ] Do Architecture Requirements Repository
- [ ] Do Business Value Assessment Matrix
- [x] Do Implementation Factor Catalog
- [ ] Do Consolidated Gaps, Solutions, and Dependencies Matrix

> Implementation Factor Catalog shrnuje faktory realizace (riziko, kultura, zdroje…) a dedukce z nich. Consolidated Gaps Matrix slučuje mezery s řešeními a Business Value Assessment slouží k hodnocení přínosu.

### ? Banka musí nový systém hlášení spustit do data účinnosti nového regulatorního předpisu. Jak se tato skutečnost ve fázi E typicky zohlední?

- [x] Jako obchodní omezení pro implementaci, které ovlivní plán přechodu
- [ ] Jako nový architektonický princip zapsaný do Tailored Architecture Framework
- [ ] Jako mezera mezi Baseline a Target Architecture v Phase B
- [ ] Jako kritérium souladu pro Compliance Review ve Phase G

> Pevný termín daný regulací je obchodní omezení (business constraint) realizace a určuje, jak a v jakém pořadí se změny doručí. Principy se stanovují v Preliminary Phase, mezery v B–D a compliance se posuzuje až ve fázi G.

## Konsolidace mezer z fází B–D {#konsolidace-mezer .explain}

Fáze B, C a D provádějí analýzu mezer každá ve **své doméně**. Ve fázi E se výsledky **sloučí do jednoho přehledu** napříč celou architekturou: odstraní se duplicity, propojí související mezery a ke každé mezeře se doplní **možné řešení** a **závislosti** na jiných mezerách. Pomůckou je **Consolidated Gaps, Solutions, and Dependencies Matrix**.

Spolu s mezerami se znovu procházejí **požadavky** napříč souvisejícími obchodními funkcemi, aby se ukázalo, kde lze jedním řešením pokrýt potřeby více útvarů. Teprve z konsolidovaného pohledu je vidět skutečný rozsah práce a příležitosti ke sdílení řešení.

*Příklad:* Fáze B zjistila chybějící samoobslužný portál, fáze C chybějící jednotná klientská data a fáze D chybějící API bránu. Konsolidace ukáže, že portál nemůže vzniknout bez obou dalších — jde o jednu provázanou příležitost.

### ? Proč se ve fázi E slučují výsledky analýzy mezer z fází B, C a D?

- [ ] Protože ve fázích B–D se analýza mezer neprovádí a musí se doplnit
- [ ] Aby bylo možné zrušit výsledky domén, které si navzájem odporují
- [x] Aby vznikl jednotný přehled mezer, řešení a vzájemných závislostí
- [ ] Aby se mezery předaly přímo do Architecture Contract pro dodavatele

> Domény zjišťují mezery samostatně; fáze E je spojí, doplní řešení a závislosti, a teprve pak lze práci rozumně seskupit. Analýza mezer v B–D probíhá a Architecture Contract patří do fáze G.

### ? Která pomůcka ve fázi E spojuje mezery ze všech domén s možnými řešeními a závislostmi mezi nimi?

- [ ] Implementation Factor Catalog
- [ ] Architecture Definition Increments Table
- [ ] Business Value Assessment Matrix
- [x] Consolidated Gaps, Solutions, and Dependencies Matrix

> Consolidated Gaps, Solutions, and Dependencies Matrix je přesně tento sloučený přehled. Implementation Factor Catalog zachycuje faktory realizace, Increments Table přírůstky architektury v čase a Business Value Assessment hodnotí přínos a riziko.

## Interoperabilita a závislosti ve fázi E {#interop-zavislosti .explain}

Dva kroky fáze E zpřesňují konsolidovaný pohled:
- **sladění požadavků na interoperabilitu** — ověřuje se, zda si budoucí řešení dokážou vyměňovat informace a služby mezi sebou i s partnery, a rozpory mezi doménami se odstraní ještě před plánováním,
- **zpřesnění a ověření závislostí** — určí se, které změny musí proběhnout před jinými (obchodní, datové, aplikační i technologické závislosti). Závislosti pak určují **pořadí pracovních balíků** a hranice přechodových architektur.

Samotná technika Interoperability Requirements se podrobně probírá mezi technikami ADM; ve fázi E jde o její **použití** na sloučený seznam řešení.

*Příklad:* Nový CRM potřebuje číst klientská data z nového datového skladu. Závislost říká, že sklad musí být hotov dřív, takže patří do dřívější přechodové etapy.

### ? K čemu ve fázi E nejvíce slouží zpřesnění a ověření závislostí mezi změnami?

- [ ] Nahrazuje ohodnocení obchodní hodnoty pracovních balíků prováděné ve fázi F
- [x] Určuje pořadí pracovních balíků a hranice přechodových architektur
- [ ] Slouží jako podklad pro schválení Statement of Architecture Work
- [ ] Určuje, kteří stakeholdeři mají dostat které pohledy (views)

> Závislosti ukazují, co musí být hotovo dřív, a tím určují posloupnost práce i rozdělení do přechodových kroků. Obchodní hodnotu doplňuje až fáze F, Statement of Architecture Work se schvaluje ve fázi A.

### ? Proč se požadavky na interoperabilitu slaďují právě ve fázi E?

- [ ] Protože ve fázích B–D se o propojení systémů vůbec neuvažuje
- [x] Protože až po sloučení řešení ze všech domén lze odhalit jejich rozpory
- [ ] Protože interoperabilitu schvaluje Architecture Board až po fázi G
- [ ] Protože interoperabilita se týká jen nákupu hotových produktů od dodavatelů

> Ve fázi E se poprvé vidí všechna navrhovaná řešení najednou, takže lze ověřit, že spolu budou spolupracovat. Domény interoperabilitu zvažují také, ale jen ze svého úhlu; nejde ani výhradně o nákup produktů.

## Připravenost a rizika transformace ve fázi E {#pripravenost-rizika .explain}

Ve fázi E se znovu prověřuje posouzení připravenosti na změnu (technika **Business Transformation Readiness Assessment**) provedené ve fázi A, jehož výsledky jdou do Capability Assessment: architekt ověří, zda je podnik opravdu schopen změnu v navrhovaném rozsahu zvládnout, a výsledek promítne do strategie realizace. Současně se posuzují **rizika** spojená s realizací — identifikují se, ohodnotí a navrhnou se opatření, po nichž zůstává **reziduální riziko**.

Nízká připravenost nebo vysoké riziko obvykle vedou k **menším krokům** (více přechodových architektur), k pilotům nebo k posílení řízení změny. Obě techniky jako takové patří mezi techniky ADM; zde je podstatné, že **ovlivňují tvar plánu**.

*Příklad:* Hodnocení ukáže, že pobočky nemají zkušenost s digitálními nástroji. Architekt proto místo celoplošného nasazení doporučí pilot na pěti pobočkách jako první přechodovou etapu.

### ? Hodnocení ve fázi E ukáže, že organizace má nízkou připravenost na změnu. Jaký dopad to typicky má na plánování realizace?

- [ ] Fáze E se přeskočí a pokračuje se rovnou fází G
- [ ] Cílová architektura se zruší a celý cyklus začne znovu Preliminary Phase
- [ ] Rizika se přesunou do Architecture Contract a dál neřeší
- [x] Realizace se rozdělí na menší kroky, například piloty a více přechodů

> Nízká připravenost je důvodem pro postupný přístup s menšími a lépe zvládnutelnými kroky. Přeskakování fází ani přenechání rizik smlouvě problém neřeší a zrušení cíle je zbytečně radikální.

### ? Které posouzení provedené ve fázi A se ve fázi E znovu prověřuje, aby se ověřilo, že podnik zvládne změnu v navrženém rozsahu?

- [ ] Architecture Compliance Review realizačních projektů
- [x] Business Transformation Readiness Assessment
- [ ] Gap Analysis mezi Baseline a Target architekturou domén
- [ ] Hodnocení plnění Architecture Contract

> Business Transformation Readiness Assessment je technika, kterou se ve fázi A posoudí připravenost podniku na změnu (výsledky jdou do Capability Assessment); ve fázi E se závěry potvrzují vůči konkrétnímu plánu realizace. Compliance Review i hodnocení Architecture Contract patří do fáze G a Gap Analysis domén do fází B–D.

## Strategie realizace: Greenfield, Revolutionary, Evolutionary {#strategie-realizace .compare}

Součástí fáze E je formulace **Implementation and Migration Strategy** — celkového směru, jakým se cílová architektura zavede. TOGAF rozlišuje tři základní strategické přístupy:

| Přístup | Podstata | Typické použití |
|---|---|---|
| **Greenfield** | zcela nové řešení bez návaznosti na stávající stav | nová firma, nový produkt či trh |
| **Revolutionary** | radikální změna, jednorázové přepnutí ze starého na nové | starý stav je neudržitelný, krátké okno pro přechod |
| **Evolutionary** | postupné sbližování se cílem, např. souběžný provoz nebo fázové zavádění | rozsáhlé změny, vyšší riziko, nutnost průběžné hodnoty |

Evoluční přístup přirozeně vede k **přechodovým architekturám (Transition Architectures)**.

### ? Organizace chce nové jádro systému zavádět postupně a po určitou dobu provozovat starý i nový systém souběžně. Který strategický přístup k realizaci to je?

- [ ] Greenfield
- [ ] Revolutionary
- [x] Evolutionary
- [ ] Big Bang

> Postupné sbližování se cílem, například souběžným provozem nebo po etapách, odpovídá evolučnímu přístupu. Revolutionary znamená radikální přepnutí, Greenfield nové řešení bez návaznosti a Big Bang není jedním ze tří uvedených strategických přístupů TOGAF.

### ? Startup buduje informační systémy od nuly a nemá žádné stávající systémy, na které by musel navazovat. Který strategický přístup k realizaci odpovídá?

- [x] Greenfield
- [ ] Evolutionary
- [ ] Revolutionary
- [ ] Phased

> Greenfield je zcela nová implementace bez vazby na výchozí stav. Evolutionary a Revolutionary předpokládají přechod ze stávajícího stavu a „Phased" je spíše způsob postupného zavádění než samostatný strategický přístup.

## Od příležitostí k řešením (SBB) {#prilezitosti-reseni .explain}

Název fáze vyjadřuje její logiku: ze sloučených mezer se stávají **příležitosti (opportunities)** a k nim se hledají **řešení (solutions)**. Architekt zde převádí **Architecture Building Blocks (ABB)** z fází B–D na konkrétnější **Solution Building Blocks (SBB)** a u každého zvažuje, zda řešení **znovu použít**, **koupit** hotový produkt, nebo **vyvinout**.

Rozhodnutí se opírá o Architecture Repository (co už existuje), o principy a o omezení realizace. Výsledkem je představa, **jakými řešeními** bude cílová architektura naplněna — podklad pro seskupení do pracovních balíků.

*Příklad:* Pro ABB „správa identit" architekt zjistí, že firma už vlastní licenci na produkt pro správu identit. Zvolí znovupoužití místo vývoje nového řešení.

### ? Co se ve fázi E typicky děje se stavebními bloky popsanými ve fázích B–D?

- [ ] Archivují se a dále se pracuje jen s pracovními balíky
- [ ] Předávají se beze změny Architecture Board ke schválení
- [ ] Převádějí se zpět na požadavky pro novou iteraci fáze A
- [x] Z ABB se určují konkrétní SBB a volí se reuse, nákup či vývoj

> Fáze E hledá k architektonickým stavebním blokům konkrétní řešení (SBB) a rozhoduje, zda je znovu použít, koupit, nebo vyvinout. Stavební bloky se nearchivují ani se nevracejí do fáze A.

### ? Co v názvu „Opportunities and Solutions" vyjadřuje slovo „Opportunities"?

- [ ] Nabídky dodavatelů získané ve výběrovém řízení na dodávku řešení
- [x] Sloučené mezery, které lze řešením změnit v obchodní přínos
- [ ] Volné kapacity architektonického týmu pro další projekty
- [ ] Stakeholdery, kteří ještě nebyli zapojeni do fáze A

> Příležitosti vznikají z konsolidovaných mezer — každá mezera je šancí přinést hodnotu vhodným řešením. Výběrová řízení dodavatelů ani kapacity týmu nejsou podstatou fáze.

## Pracovní balík (work package) {#work-package .term}

**Pracovní balík (work package)** je ucelený soubor činností, které společně směřují k dosažení jednoho nebo více obchodních cílů. Může odpovídat části projektu, celému projektu nebo i programu. V ADM se pracovní balíky tvoří ve fázi E z konsolidovaných mezer a řešení a jsou **základní jednotkou Architecture Roadmap**.

### ? Co je v TOGAF pracovní balík (work package)?

- [x] Soubor činností vedoucích k jednomu či více obchodním cílům
- [ ] Balík artefaktů předávaný Architecture Board ke schválení
- [ ] Sada stavebních bloků uložená v Reference Library repozitáře
- [ ] Smlouva mezi architekty a realizátory o rozsahu dodávky

> Pracovní balík je soubor činností směřujících k cílům a může mít velikost části projektu až programu. Nejde o balík artefaktů, obsah knihovny ani o smlouvu (tou je Architecture Contract).

### ? Jaký rozsah může mít jeden pracovní balík (work package)?

- [ ] Vždy právě jeden projekt se samostatným rozpočtem
- [ ] Vždy jedna architektonická doména, např. jen Data
- [x] Může odpovídat části projektu, celému projektu i programu
- [ ] Vždy jedna celá přechodová architektura včetně všech domén

> Velikost pracovního balíku není pevně dána — může jít o část projektu, celý projekt nebo program. Nemusí se krýt s jednou doménou ani s celou přechodovou architekturou.

## Identifikace a seskupení pracovních balíků {#seskupeni-balicku .explain}

Ve fázi E se z konsolidovaného přehledu mezer a řešení **seskupují pracovní balíky**. Související změny se dávají dohromady podle toho, jak spolu souvisejí: podle obchodních funkcí, společných řešení, **závislostí** nebo podle toho, co lze rozumně dodat najednou. Cílem je, aby každý balík tvořil ucelenou dodávku a aby sada balíků pokryla **všechny podstatné mezery**.

Při seskupování se také posuzuje, které aktivity jsou už rozběhnuté v jiných projektech a jak je s nimi sladit. Seskupené balíky jsou základem **portfolia pracovních balíků** v Architecture Roadmap.

*Příklad:* Mezery „chybí klientský portál", „chybí jednotné ověření identity" a „chybí API pro smlouvy" se seskupí do balíku „Digitální samoobsluha", protože se dodávají společně.

### ? Podle čeho se ve fázi E nejčastěji seskupují změny do pracovních balíků?

- [ ] Podle abecedního pořadí dotčených aplikací v katalogu
- [ ] Podle toho, který stakeholder změnu jako první navrhl
- [ ] Podle data, kdy byla mezera zapsána v příslušné fázi
- [x] Podle souvislostí, společných řešení a závislostí

> Balíky mají tvořit ucelené dodávky, proto se seskupují související změny se společným řešením a závislostmi. Pořadí v katalogu, autor návrhu ani datum zápisu nejsou věcná kritéria.

### ? Co by mělo platit pro sadu pracovních balíků vytvořenou ve fázi E?

- [ ] Má obsahovat jen balíky, které lze dokončit do tří měsíců
- [x] Má pokrýt všechny podstatné mezery mezi Baseline a Target
- [ ] Má zahrnovat výhradně technologické změny z fáze D
- [ ] Má být schválena dodavateli ještě před koncem fáze E

> Portfolio pracovních balíků má jako celek dovést podnik z výchozího do cílového stavu, takže musí pokrýt podstatné mezery ze všech domén. Pevný časový limit ani schválení dodavateli TOGAF nepožaduje.

## Přechodová architektura (Transition Architecture) {#transition-architecture .term}

**Přechodová architektura (Transition Architecture)** popisuje podnik v **mezistavu** mezi výchozí (Baseline) a cílovou (Target) architekturou. Používá se, když cíl nelze dosáhnout jedním krokem; každá přechodová architektura je stabilní stav, který lze provozovat a který už **přináší obchodní hodnotu**. Poprvé se určuje ve fázi E; popisuje se v Architecture Definition Document, v Architecture Roadmap je identifikována.

### ? Co popisuje přechodová architektura (Transition Architecture)?

- [ ] Popis výchozího stavu podniku před zahájením cyklu ADM
- [ ] Architekturu dočasně používanou jen během testování řešení
- [x] Stabilní mezistav mezi výchozí a cílovou architekturou
- [ ] Alternativu cílové architektury zamítnutou ve fázi A

> Transition Architecture je provozovatelný mezistav na cestě od Baseline k Target, který už přináší hodnotu. Výchozí stav je Baseline Architecture a nejde ani o testovací prostředí nebo zamítnutou variantu.

### ? Ve které fázi ADM se poprvé identifikují přechodové architektury (Transition Architectures)?

- [ ] Phase H: Architecture Change Management
- [ ] Phase D: Technology Architecture
- [ ] Phase G: Implementation Governance
- [x] Phase E: Opportunities and Solutions

> Přechodové architektury se identifikují ve fázi E na základě seskupených pracovních balíků a závislostí; fáze F je pak ověřuje a dokončuje v plánu. Fáze D cílový stav popisuje, fáze G řídí implementaci a fáze H změny po nasazení.

## Kdy volit postupný přístup {#postupny-pristup .explain}

Fáze E rozhoduje, zda lze cílovou architekturu zavést **najednou**, nebo je třeba **postupný (inkrementální) přístup**. Postupný přístup se volí hlavně tehdy, když je změna rozsáhlá, riziková, závislá na omezených zdrojích nebo když podnik potřebuje **hodnotu průběžně**, ne až na konci.

Každý přechodový krok by měl:
- být **stabilní a provozovatelný**,
- přinést **měřitelnou obchodní hodnotu**,
- respektovat **závislosti** (co musí být dřív).

Přechodové kroky se často vážou na **přírůstky schopností (capability increments)** z Capability-Based Planning — každý přechod zpřístupní další část požadované schopnosti.

*Příklad:* Nemocnice nejdřív zavede elektronickou kartu pacienta na jednom pavilonu (přechod 1), pak v celé nemocnici (přechod 2) a nakonec propojení s externími laboratořemi (cíl).

### ? Co je hlavním požadavkem na každou přechodovou architekturu při postupném přístupu?

- [x] Má být provozovatelná a sama o sobě přinést hodnotu
- [ ] Má obsahovat změny ve všech čtyřech doménách současně
- [ ] Má trvat stejně dlouho jako ostatní přechodové kroky
- [ ] Má být dodána jediným dodavatelem kvůli odpovědnosti

> Smyslem postupného přístupu je průběžná hodnota, proto každý přechod musí být stabilní a přínosný. Stejná délka kroků, změny ve všech doménách najednou ani jeden dodavatel nejsou podmínkou.

### ? Ve které situaci je postupný přístup s přechodovými architekturami nejvíce odůvodněný?

- [ ] Změna je malá, nízkoriziková a dotýká se jediné aplikace
- [ ] Cílová architektura ještě nebyla ve fázích B–D popsána
- [x] Změna je rozsáhlá, riziková a vedení chce hodnotu průběžně
- [ ] Architecture Board už schválil Architecture Contract na celek

> Rozsáhlá a riziková změna s požadavkem na průběžný přínos je typickým důvodem pro přechodové architektury. Malou změnu lze dodat najednou a bez popsané cílové architektury nelze přechody plánovat.

## Architecture Roadmap {#architecture-roadmap .term}

**Architecture Roadmap** uvádí pracovní balíky v **časové posloupnosti**, která povede k realizaci cílové architektury. Obsahuje zejména **portfolio pracovních balíků** (popis, závislosti, vazba na příležitosti a požadavky), **identifikaci přechodových architektur** a **doporučení k realizaci** (kritéria účinnosti, rizika a problémy, Solution Building Blocks). Kandidátní komponenty vznikají ve fázích B–D, **první úplná verze ve fázi E** a **finální verze ve fázi F**.

### ? Jak se postupně vyvíjí Architecture Roadmap v průběhu cyklu ADM?

- [ ] Celá vzniká ve fázi A a ve fázích E a F se už nemění
- [x] Kandidátní komponenty v B–D, úplná verze v E, finální ve F
- [ ] Poprvé vzniká ve fázi F a ve fázi G se teprve dokončuje
- [ ] Vzniká v Preliminary Phase a aktualizuje se pouze ve fázi H

> Roadmapa roste s cyklem: domény B–D navrhují kandidátní komponenty, fáze E sestaví první úplnou verzi a fáze F ji finalizuje. Fáze A a Preliminary Phase ji nevytvářejí.

### ? Co NENÍ typickou součástí Architecture Roadmap?

- [ ] Portfolio pracovních balíků s jejich závislostmi
- [ ] Identifikace přechodových architektur
- [x] Podepsané Architecture Contracts s dodavateli
- [ ] Doporučení k realizaci včetně rizik a SBB

> Architecture Contracts se uzavírají ve fázi G a nejsou obsahem roadmapy. Portfolio balíků, přechodové architektury a doporučení k realizaci do ní naopak patří.

## Výstupy fáze E {#vystupy-e .term}

Fáze E vytváří **první úplnou verzi Architecture Roadmap** (portfolio pracovních balíků, přechodové architektury, doporučení k realizaci) a **počáteční verzi Implementation and Migration Plan** včetně celkové Implementation and Migration Strategy. Zároveň **aktualizuje** dřívější výstupy — Architecture Vision, Architecture Definition Document, Architecture Requirements Specification a Capability Assessment — podle toho, co se zjistilo při hledání řešení.

### ? Který výstup vzniká ve fázi E v první (počáteční) verzi a ve fázi F se dokončuje?

- [ ] Request for Architecture Work
- [ ] Statement of Architecture Work
- [ ] Organizational Model for Enterprise Architecture
- [x] Implementation and Migration Plan

> Implementation and Migration Plan vzniká ve fázi E v počáteční verzi se strategií realizace a ve fázi F se doplní na úplný plán. Request a Statement of Architecture Work patří do Preliminary Phase a fáze A, stejně jako organizační model EA.

### ? Které dokumenty fáze E aktualizuje, přestože vznikly v dřívějších fázích?

- [x] Architecture Vision, Architecture Definition Document a Requirements Specification
- [ ] Jen Request for Architecture Work, protože jej znovu podává sponzor
- [ ] Žádné, dřívější výstupy jsou po fázi D uzavřené a neměnné
- [ ] Jen Architecture Contract a výsledky Compliance Review z fáze G

> Při hledání řešení se zpřesní i vize, definice architektury a požadavky, proto je fáze E aktualizuje. ADM je iterativní, dřívější výstupy tedy nejsou neměnné; Architecture Contract a Compliance Review patří do fáze G.

## Phase F: Migration Planning — účel {#faze-f-ucel .explain}

**Phase F: Migration Planning** navazuje na fázi E a převádí roadmapu do **realizovatelného plánu**. Jejím cílem je **dokončit Architecture Roadmap** a podpůrný **Implementation and Migration Plan**, **sladit plán s tím, jak podnik řídí změny** ve svém portfoliu projektů, a zajistit, aby klíčoví stakeholdeři **rozuměli obchodní hodnotě a nákladům** pracovních balíků a přechodových architektur.

Fáze F tedy přidává ekonomický a řídicí pohled: ohodnocení přínosu, odhad zdrojů a času, prioritizaci a koordinaci s projektovým a provozním řízením. Na jejím konci se uzavírá vývojová část cyklu a sepisují se **poučení (lessons learned)**.

*Příklad:* Fáze E navrhla pět pracovních balíků ve dvou přechodech. Ve fázi F architekt s PMO odhadne náklady a kapacity, seřadí balíky podle přínosu a rizika a výsledek předá do ročního plánu projektů.

### ? Co NENÍ cílem Phase F: Migration Planning?

- [ ] Dokončit Architecture Roadmap a Implementation and Migration Plan
- [ ] Sladit plán s řízením změn a portfoliem projektů podniku
- [ ] Zajistit, aby stakeholdeři chápali hodnotu a náklady balíků
- [x] Poprvé popsat Baseline a Target Architecture v doménách

> Výchozí a cílová architektura se popisují ve fázích B–D. Fáze F naopak dokončuje roadmapu a plán, sladí je s řízením změn a vysvětluje stakeholderům hodnotu a náklady.

### ? Ve které fázi ADM se uzavírá vývojová část cyklu a dokumentují se poučení (lessons learned)?

- [x] Phase F: Migration Planning
- [ ] Phase E: Opportunities and Solutions
- [ ] Phase A: Architecture Vision
- [ ] Requirements Management

> Posledním krokem fáze F je dokončení cyklu vývoje architektury a zápis poučení. Následná fáze G už řídí realizaci a fáze H změny po nasazení.

## Koordinace s řídicími rámci podniku {#ridici-ramce .compare}

Fáze F začíná **potvrzením vazeb na další řídicí rámce (management frameworks)**, protože plán migrace musí zapadnout do způsobu, jakým podnik plánuje, řídí projekty a provozuje systémy. TOGAF uvádí čtyři spolupracující rámce:

| Rámec | Úloha ve vztahu k realizaci |
|---|---|
| **Business Planning** (obchodní plánování) | stanovuje cíle a přiděluje zdroje na změny |
| **Enterprise Architecture** | dává změnám strukturu a kontext |
| **Portfolio / Project Management** | koordinuje, navrhuje a staví řešení |
| **Operations Management** | začleňuje řešení do provozu, provozuje a udržuje je |

Plán migrace, který s těmito rámci nepočítá, hrozí, že nebude financován, zařazen do portfolia ani převzat provozem.

### ? Proč fáze F začíná potvrzením vazeb na další řídicí rámce podniku?

- [ ] Aby architekti mohli převzít řízení projektů místo projektových manažerů
- [ ] Aby se plán migrace mohl schválit bez účasti obchodního vedení
- [ ] Aby se zjistilo, zda podnik vůbec potřebuje Architecture Board
- [x] Aby plán zapadl do plánování, řízení portfolia i provozu podniku

> Plán migrace se realizuje přes obchodní plánování, portfolio projektů a provoz, a proto s nimi musí být sladěn. Architekti projektové řízení nepřebírají a vedení se ze schvalování nevyřazuje.

### ? Který z řídicích rámců, s nimiž se plán migrace koordinuje, odpovídá za začlenění řešení do provozu a jejich údržbu?

- [ ] Business Planning
- [ ] Portfolio / Project Management
- [x] Operations Management
- [ ] Enterprise Architecture

> Operations Management řešení integruje do provozu, provozuje a udržuje. Business Planning stanovuje cíle a zdroje, Portfolio/Project Management řešení staví a Enterprise Architecture jim dává strukturu.

## Přiřazení obchodní hodnoty pracovním balíkům {#obchodni-hodnota .explain}

Ve fázi F se každému pracovnímu balíku **přiřazuje obchodní hodnota (business value)**, aby bylo možné rozhodnout, co se vyplatí dělat dřív. Hodnota se posuzuje podle kritérií, jako jsou **výkonnostní kritéria**, **návratnost investice**, **strategická shoda**, **kritické faktory úspěchu (critical success factors)** a **měřítka účinnosti (measures of effectiveness)**. Současně se u balíků posuzuje **riziko**.

K tomu slouží technika **Business Value Assessment**, která balíky porovnává podle hodnoty a rizika (podrobně viz techniky ADM). Výsledek je klíčovým podkladem pro prioritizaci a pro vysvětlení přínosů stakeholderům.

*Příklad:* Balík „online sjednání pojistky" má vysokou hodnotu a střední riziko, balík „výměna tiskových serverů" nízkou hodnotu i riziko. Ohodnocení ukáže, který z nich podpořit přednostně.

### ? Ve které fázi ADM se pracovním balíkům přiřazuje obchodní hodnota, aby je bylo možné prioritizovat?

- [ ] Phase E: Opportunities and Solutions
- [x] Phase F: Migration Planning
- [ ] Phase G: Implementation Governance
- [ ] Phase H: Architecture Change Management

> Přiřazení obchodní hodnoty je krokem fáze F a předchází prioritizaci migračních projektů. Fáze E balíky vytváří, fáze G a H řídí realizaci a následné změny.

### ? Která technika se ve fázi F používá k porovnání pracovních balíků podle jejich hodnoty a rizika?

- [x] Business Value Assessment
- [ ] Stakeholder Management
- [ ] Architecture Compliance Review
- [ ] Business Transformation Readiness Assessment

> Business Value Assessment hodnotí balíky podle přínosu a rizika a slouží k prioritizaci. Readiness Assessment posuzuje připravenost organizace, Compliance Review soulad realizace ve fázi G.

## Odhad zdrojů a prioritizace migračních projektů {#prioritizace .explain}

Po ohodnocení přínosu se ve fázi F **odhadují zdroje, časování a způsob doručení (delivery vehicle)** — tedy jaké lidi, rozpočet a dobu balíky potřebují a zda budou realizovány jako projekt, program či součást portfolia.

Následuje **prioritizace migračních projektů** pomocí **posouzení nákladů a přínosů (cost/benefit)** a **ověření rizik (risk validation)**. Pořadí ovlivňuje obchodní hodnota, náklady, riziko a **závislosti** mezi balíky; po opatřeních se kontroluje, že zbývající **reziduální riziko** je přijatelné. Prioritizace se odsouhlasuje se stakeholdery, aby měl plán podporu.

*Příklad:* Balík s vysokým přínosem nelze zařadit jako první, protože závisí na datovém skladu z jiného balíku. Prioritizace proto posune sklad dopředu, i když sám přínos nemá.

### ? Jakým způsobem se ve fázi F prioritizují migrační projekty?

- [ ] Losováním mezi projekty se stejným rozpočtem
- [ ] Výhradně podle data zápisu do Architecture Roadmap
- [x] Posouzením nákladů a přínosů a ověřením rizik
- [ ] Jen podle preferencí dodavatele s nejnižší cenou

> TOGAF ve fázi F prioritizuje projekty na základě cost/benefit posouzení a validace rizik, s ohledem na závislosti. Datum zápisu ani preference jednoho dodavatele nejsou věcná kritéria.

### ? Pracovní balík s nejvyšší obchodní hodnotou závisí na datové platformě, kterou dodává jiný balík s malým přímým přínosem. Jak má fáze F pořadí zohlednit?

- [ ] Začít balíkem s nejvyšší hodnotou a platformu doplnit později
- [ ] Balík s malým přínosem z plánu úplně vypustit jako neefektivní
- [ ] Ponechat pořadí na Architecture Board až ve fázi H
- [x] Zařadit datovou platformu dřív, protože na ní hodnotný balík závisí

> Prioritizace musí respektovat závislosti — balík bez přímého přínosu může být nutnou podmínkou balíku hodnotného. Vynechat ho by cíl znemožnilo a odkládat rozhodnutí do fáze H je pozdě.

### ? Co znamená „delivery vehicle" při odhadu zdrojů a časování ve fázi F?

- [x] Způsob, jakým bude pracovní balík realizován, např. projekt či program
- [ ] Technologickou platformu, na které poběží cílová aplikace
- [ ] Dodavatele vybraného na základě výběrového řízení ve fázi G
- [ ] Nástroj pro modelování architektury používaný týmem

> Delivery vehicle říká, v jaké řídicí podobě se balík dodá — jako projekt, program nebo součást portfolia. Nejde o technologickou platformu, konkrétního dodavatele ani modelovací nástroj.

## Implementation and Migration Plan {#implementation-migration-plan .term}

**Implementation and Migration Plan** je plán realizace cílové architektury na úrovni **projektů a portfolia**: rozděluje pracovní balíky do projektů, uvádí milníky, časování, zdroje, náklady a vazby na přechodové architektury a obsahuje **Implementation and Migration Strategy**. Počáteční verze vzniká ve **fázi E**, úplná verze se dokončuje ve **fázi F** a slouží jako podklad pro řízení realizace ve fázi G.

### ? Co obsahuje Implementation and Migration Plan?

- [ ] Popis výchozí a cílové architektury v jednotlivých doménách
- [ ] Seznam architektonických principů s odůvodněním a důsledky
- [x] Rozdělení balíků do projektů s milníky, časováním a zdroji
- [ ] Mapu stakeholderů podle vlivu a zájmu o architekturu

> Implementation and Migration Plan převádí balíky do projektů a určuje milníky, časování a zdroje včetně strategie realizace. Popis architektur patří do Architecture Definition Document, principy a mapa stakeholderů do dřívějších fází.

### ? Pro kterou následující fázi je dokončený Implementation and Migration Plan hlavním podkladem?

- [ ] Preliminary Phase
- [x] Phase G: Implementation Governance
- [ ] Phase B: Business Architecture
- [ ] Phase A: Architecture Vision

> Fáze G řídí realizaci podle dokončeného plánu z fáze F a dohlíží na soulad projektů s architekturou. Preliminary Phase, fáze A a fáze B předcházejí plánování migrace.

## Výstupy fáze F {#vystupy-f .term}

Fáze F předává hlavně **dokončený Implementation and Migration Plan**, **finální Architecture Roadmap**, **finální Architecture Definition Document** a **Architecture Requirements Specification**, znovupoužitelné stavební bloky a **Implementation Governance Model**, podle kterého se bude realizace řídit ve fázi G. Dále může vzniknout **Request for Architecture Work** pro architektonické aspekty implementačních projektů (pokud jsou potřeba); z poučení mohou vzejít **Change Requests** na samotnou architektonickou kapabilitu.

### ? Který výstup fáze F popisuje, jak bude realizace architektury řízena v následující fázi G?

- [x] Implementation Governance Model
- [ ] Architecture Definition Increments Table
- [ ] Statement of Architecture Work
- [ ] Business Transformation Readiness Assessment

> Implementation Governance Model vzniká ve fázi F a připravuje řízení realizace ve fázi G. Statement of Architecture Work je z fáze A a Readiness Assessment hodnotí připravenost organizace na změnu.

### ? Co může fáze F vytvořit, pokud implementační projekty potřebují další architektonickou práci?

- [ ] Architecture Contract podepsaný realizačními týmy
- [ ] Výsledky Compliance Review jednotlivých projektů
- [x] Request for Architecture Work pro architektonické aspekty projektů
- [ ] Hodnocení architektonické zralosti dodavatelů

> Pokud implementační projekty potřebují další architektonickou práci, fáze F může vytvořit Request for Architecture Work pro jejich architektonické aspekty. Podnětem k zahájení nového cyklu ADM je typicky Request for Architecture Work z fáze H. Architecture Contract a Compliance Review patří do fáze G.

### ? K čemu ve fázi F typicky vedou poučení (lessons learned) z dokončeného cyklu vývoje architektury?

- [ ] K okamžitému zrušení Architecture Roadmap a jejímu přepracování
- [x] K Change Requests na zlepšení samotné architektonické kapability
- [ ] K vypsání nového výběrového řízení na všechny dodavatele
- [ ] K přesunu všech pracovních balíků zpět do fáze B

> Poučení slouží ke zlepšování způsobu, jakým podnik architekturu dělá, a proto se promítají do Change Requests na architektonickou kapabilitu. Roadmapa se kvůli nim neruší a balíky se nevracejí do fáze B.

## Architecture Roadmap × Implementation and Migration Plan {#roadmap-vs-plan .compare}

Oba výstupy se tvoří ve fázích E a F a snadno se zaměňují. Roadmapa je **architektonický** pohled na cestu k cíli, plán je její **realizační** rozpracování.

| | Architecture Roadmap | Implementation and Migration Plan |
|---|---|---|
| Otázka | **co** se změní a v jakém pořadí | **jak, kdy a za kolik** se to provede |
| Základní jednotka | pracovní balíky, přechodové architektury | projekty, milníky, zdroje, náklady |
| Obsah navíc | doporučení k realizaci, rizika, SBB | strategie realizace, rozpad na projekty, harmonogram |
| Hlavní uživatel | architekti, Architecture Board, sponzor | PMO, projektoví manažeři, vedení portfolia |
| Vznik | kandidátní komponenty B–D, úplná verze E, finální F | počáteční verze E, úplná F |

### ? Který výstup ADM rozpracovává pracovní balíky do projektů s harmonogramem, zdroji a náklady?

- [ ] Architecture Roadmap
- [ ] Architecture Definition Document
- [ ] Architecture Requirements Specification
- [x] Implementation and Migration Plan

> Implementation and Migration Plan je realizační plán — projekty, milníky, zdroje a náklady. Architecture Roadmap ukazuje pracovní balíky a přechodové architektury v čase, ale bez projektového rozpadu.

### ? Čím se Architecture Roadmap především liší od Implementation and Migration Plan?

- [x] Roadmapa ukazuje balíky a přechody, plán jejich projektovou realizaci
- [ ] Roadmapa vzniká až ve fázi G, plán už v Preliminary Phase
- [ ] Roadmapa je určena dodavatelům, plán výhradně architektům
- [ ] Roadmapa popisuje jen technologie, plán jen obchodní procesy

> Roadmapa je architektonický pohled na posloupnost změn, plán ji převádí do projektů, termínů a zdrojů. Oba vznikají ve fázích E a F a pokrývají všechny domény.

## Phase E × Phase F {#e-vs-f .compare}

Fáze E a F na sebe těsně navazují a v praxi se často provádějí společně; liší se těžištěm práce.

| | Phase E: Opportunities and Solutions | Phase F: Migration Planning |
|---|---|---|
| Hlavní otázka | **jak** cílovou architekturu doručit | **v jakém pořadí, kdy a s jakou hodnotou** |
| Klíčové činnosti | konsolidace mezer, závislosti, řešení (SBB), pracovní balíky, přechodové architektury, strategie realizace | vazby na řídicí rámce, obchodní hodnota, zdroje a časování, prioritizace, poučení |
| Architecture Roadmap | první úplná verze | finální verze |
| Implementation and Migration Plan | počáteční verze se strategií | úplný plán |
| Typické pomůcky | Implementation Factor Catalog, Consolidated Gaps, Solutions, and Dependencies Matrix | Business Value Assessment |

Migration Planning Techniques podporují obě fáze; jejich podrobný výklad patří mezi techniky ADM.

### ? Ve které fázi ADM se seskupují pracovní balíky a identifikují přechodové architektury, a ve které se balíky ohodnocují a prioritizují?

- [ ] Obojí probíhá výhradně ve fázi F
- [ ] Seskupení ve fázi D, prioritizace ve fázi E
- [x] Seskupení ve fázi E, ohodnocení a prioritizace ve fázi F
- [ ] Seskupení ve fázi F, prioritizace ve fázi G

> Fáze E vytváří pracovní balíky a přechodové architektury, fáze F jim přiřazuje hodnotu, odhaduje zdroje a určuje pořadí. Fáze D ještě definuje architekturu a fáze G řídí realizaci.

### ? Jaký je stav Architecture Roadmap na konci fáze E a na konci fáze F?

- [x] Po fázi E první úplná verze, po fázi F finální verze
- [ ] Po fázi E jen kandidátní komponenty, po fázi F první verze
- [ ] Po fázi E finální verze, po fázi F už se nepoužívá
- [ ] Po fázi E se nevytváří, po fázi F jen pracovní návrh

> Fáze E sestaví z kandidátních komponent z B–D první úplnou roadmapu a fáze F ji po ohodnocení a prioritizaci finalizuje. Kandidátní komponenty vznikají už ve fázích B–D.

### ? Architekt sestavuje Implementation Factor Catalog a Consolidated Gaps, Solutions, and Dependencies Matrix. Ve které fázi ADM se pravděpodobně nachází?

- [ ] Phase F: Migration Planning
- [x] Phase E: Opportunities and Solutions
- [ ] Phase C: Information Systems Architectures
- [ ] Phase H: Architecture Change Management

> Obě matice podporují fázi E — faktory realizace a sloučené mezery s řešeními a závislostmi jsou jejím základem. Fáze F na ně navazuje ohodnocením hodnoty a prioritizací.
