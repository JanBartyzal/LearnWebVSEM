---
kind: topic
subject: archimate-practitioner
slug: migrace-ve-scenarich
name: "Implementace a migrace ve scénářích"
order: 6
---

Plateaus, gaps, work packages a deliverables při plánování přechodu.

## Plateau: Baseline, Transition, Target {#plateau-kdy .explain}

Plateau je relativně stabilní stav architektury, který trvá určitou dobu: výchozí (Baseline), přechodný (Transition) a cílový (Target). Obsah plateau se modeluje agregací prvků architektury (aplikací, procesů, nodů…), které v daném stavu existují; jeden prvek může patřit do více plateaus (např. CRM je v Transition i v Target), proto se volí aggregation, ne composition. Přechodné plateau má smysl jen tehdy, když jde o provozovatelný stav, který přináší hodnotu — ne o „půlku projektu". Typická chyba je modelovat plateau jako datum nebo milník (to je Implementation Event) nebo jako projekt (to je Work Package).

*Příklad:* Transition 2027 (Plateau) —aggregation→ Nový CRM (Application Component); Transition 2027 (Plateau) —aggregation→ Starý fakturační systém (Application Component)

### ? Distributor energií nahrazuje tři zákaznické systémy jedním CRM. V roce 2027 bude nový CRM obsluhovat domácnosti, zatímco firemní zákazníci zůstanou ve starém systému; od roku 2028 poběží vše v CRM. Architekt chce zachytit stav roku 2027. Který fragment je nejvhodnější?

- [x] Stav 2027 (Plateau) —aggregation→ Nový CRM (Application Component) a Starý firemní systém (Application Component)
- [ ] Stav 2027 (Work Package) —realization→ Nový CRM (Application Component) a Starý firemní systém (Application Component)
- [ ] Stav 2027 (Implementation Event) —triggering→ Nový CRM (Application Component) a Starý firemní systém (Application Component)
- [ ] Stav 2027 (Plateau) —composition→ Nový CRM (Application Component) a Starý firemní systém (Application Component)

> Přechodný stav architektury je Plateau, který agreguje prvky v něm existující; agregace dovolí, aby tentýž CRM patřil i do cílového plateau 2028. Work Package je práce, ne stav, Implementation Event je okamžik a kompozice by vázala existenci prvků na jediné plateau, přestože CRM zůstává i v dalším stavu.

### ? Architekt banky namodeloval Plateau „Spuštění nového core bankingu 15. 3. 2027". Kolega namítá, že prvek je špatně typovaný. Jaká oprava je nejlepší?

- [ ] Ponechat Plateau, jen z názvu odstranit datum a uvést ho jako atribut
- [x] Okamžik spuštění modelovat jako Implementation Event; Plateau je stav po něm
- [ ] Okamžik spuštění modelovat jako Business Event, protože mění chování celé banky
- [ ] Okamžik spuštění modelovat jako Deliverable, protože je výsledkem projektu

> Spuštění k určitému datu je okamžik, tedy Implementation Event; Plateau je až stabilní stav architektury, který po něm následuje. Business Event patří do běžného provozu podniku, ne do plánu změny, a Deliverable je výsledek práce, nikoli okamžik.

## Pořadí plateaus a alternativní cesty {#plateau-sekvence .explain}

Plateaus tvoří posloupnost: Baseline —triggering→ Transition 1 —triggering→ … —triggering→ Target. Triggering mezi plateaus vyjadřuje, který stav následuje po kterém; konkrétní data a milníky zachycují Implementation Events a práci, která přechod umožní, Work Packages. Mezi dvěma po sobě jdoucími plateaus se obvykle vymezí Gap. Zvažuje-li podnik alternativní cesty (např. „nejdřív konsolidace" × „rovnou do cloudu"), lze namodelovat dvě různá přechodová plateaus, která obě vedou ke společnému cílovému stavu, a porovnat je. Typická chyba je propojit plateaus vztahem flow (mezi stavy nic nepřenášíme) nebo composition (stav není součástí jiného stavu).

*Příklad:* Baseline 2026 (Plateau) —triggering→ Transition 2027 (Plateau) —triggering→ Target 2028 (Plateau)

### ? Pojišťovna plánuje přechod ve dvou krocích: dnešní stav, mezistav po migraci dat do cloudu a cílový stav s novou platformou. Architekt chce v migračním pohledu vyjádřit pořadí těchto stavů. Který fragment je správný?

- [ ] Dnešní stav (Plateau) —flow→ Data v cloudu (Plateau) —flow→ Nová platforma (Plateau)
- [ ] Nová platforma (Plateau) —composition→ Data v cloudu (Plateau) —composition→ Dnešní stav (Plateau)
- [ ] Dnešní stav (Work Package) —triggering→ Data v cloudu (Work Package) —triggering→ Nová platforma (Work Package)
- [x] Dnešní stav (Plateau) —triggering→ Data v cloudu (Plateau) —triggering→ Nová platforma (Plateau)

> Následnost stavů architektury se mezi plateaus vyjadřuje vztahem triggering. Flow znamená přenos něčeho mezi prvky chování, kompozice by ze stavů udělala části jiného stavu a Work Packages jsou projekty, ne stavy architektury.

### ? Telekomunikační firma zvažuje dvě cesty k cílové architektuře: nejdřív konsolidovat vlastní datová centra, nebo rovnou migrovat do veřejného cloudu. Cílový stav je v obou případech stejný. Řídicí výbor chce vidět obě varianty vedle sebe, než rozhodne. Jak je v modelu nejlépe zachytit?

- [x] Jako dvě alternativní Transition Plateaus, z nichž každé vede k Target Plateau
- [ ] Jako jedno Transition Plateau, které agreguje prvky obou variant současně
- [ ] Jako dvě Target Plateaus, protože každá varianta vede k jinému konečnému stavu
- [ ] Jako dva Gaps mezi Baseline a Target, každý pojmenovaný podle jedné varianty

> Alternativní cesty k témuž cíli se modelují jako různé přechodové stavy vedoucí ke společnému Target Plateau, což umožní porovnat jejich obsah i rozdíly. Jedno plateau s oběma variantami by bylo nekonzistentní, cílový stav je podle zadání společný a Gap popisuje rozdíl mezi stavy, ne celou alternativní cestu.

## Gap ve scénářích {#gap-kdy .explain}

Gap vyjadřuje rozdíl mezi dvěma plateaus — co v pozdějším stavu přibude, co zanikne a co se změní. Modeluje se jako samostatný prvek asociovaný s oběma plateaus a obvykle i s prvky architektury, kterých se rozdíl týká. Gap je výsledek gap analysis, ne úkol: odpovídá na otázku „čím se stavy liší", zatímco Work Package na otázku „co uděláme". K uzavření jednoho gapu může přispět více work packages a jeden work package může přispět k uzavření více gaps. Typická chyba je pojmenovat gap jako činnost („Implementovat CRM") nebo ho asociovat jen s jedním plateau.

*Příklad:* Chybí online podpis smluv (Gap) —association→ Baseline 2026 (Plateau); Chybí online podpis smluv (Gap) —association→ Target 2028 (Plateau); Chybí online podpis smluv (Gap) —association→ Elektronický podpis (Application Service)

### ? Architekt porovnal výchozí a cílovou architekturu leasingové firmy a zjistil, že cílový stav obsahuje službu „Online schválení smlouvy", která dnes neexistuje. Rozdíl chce zachytit tak, aby bylo zřejmé, mezi kterými stavy vzniká a čeho se týká. Který fragment je nejvhodnější?

- [ ] Online schválení (Work Package) —association→ Baseline (Plateau), Target (Plateau), Online schválení (Business Service)
- [ ] Chybí online schválení (Gap) —association→ Target (Plateau), Online schválení (Business Service)
- [x] Chybí online schválení (Gap) —association→ Baseline (Plateau), Target (Plateau), Online schválení (Business Service)
- [ ] Chybí online schválení (Assessment) —influence→ Baseline (Plateau), Target (Plateau), Online schválení (Business Service)

> Gap se asociuje s oběma plateaus, mezi nimiž rozdíl vzniká, a s prvky, kterých se týká. Work Package je práce, která rozdíl uzavře, ne rozdíl sám, i když je asociovaný se stejnými prvky; gap navázaný jen na cílový stav neříká, vůči čemu se rozdíl měří, a Assessment s vlivem na plateaus je motivační zjištění, ne rozdíl mezi stavy architektury.

### ? V migračním modelu je prvek Gap pojmenovaný „Nasadit nový skladový systém do konce roku". Hlavní architekt ho vrátil k přepracování. Jaká úprava je nejlepší?

- [ ] Gap přejmenovat na „Skladový systém" a nechat ho realizovat work packagem
- [ ] Gap přetypovat na Deliverable, protože popisuje výsledek, který má být dodán
- [x] Gap pojmenovat jako rozdíl („Chybí řízení skladu online") a práci dát do Work Package
- [ ] Gap přetypovat na Implementation Event, protože jeho název obsahuje termín „do konce roku"

> Gap popisuje rozdíl mezi stavy, ne činnost; „nasadit… do konce roku" je práce s termínem, tedy Work Package (termín může doplnit Implementation Event). Realizace gapu work packagem ani přetypování na Deliverable či Implementation Event rozdíl mezi výchozím a cílovým stavem nezachytí.

## Plateau × Gap × Work Package × Deliverable × Implementation Event {#gap-vs-wp .compare}

Pět prvků Implementation & Migration odpovídá na pět různých otázek. Při revizi modelu pomáhá u každého prvku se zeptat: je to stav, rozdíl, práce, výsledek, nebo okamžik?

| Prvek | Odpovídá na otázku | Typická formulace | Typická chyba |
|---|---|---|---|
| Plateau | V jakém stavu bude architektura? | „Transition 2027 – CRM pro domácnosti" | modelovat ho jako datum nebo projekt |
| Gap | Čím se dva stavy liší? | „Chybí jednotná evidence zákazníků" | pojmenovat ho jako úkol |
| Work Package | Jakou práci provedeme? | „Projekt migrace zákaznických dat" | modelovat ho jako Business Process |
| Deliverable | Co práce konkrétně vydá? | „Migrovaná databáze zákazníků v1" | zaměnit ho za Artifact nebo Business Object |
| Implementation Event | Kdy nastane významný okamžik plánu? | „Regulátor schválil spuštění" | modelovat ho jako Plateau |

### ? Programový manažer předal architektovi seznam: (1) „Projekt Nový e-banking", (2) „Stav po spuštění e-bankingu, kdy pobočkový systém ještě běží", (3) „Chybí mobilní ověření plateb", (4) „Otestovaná mobilní aplikace verze 1.0". Jak položky nejlépe typovat?

- [ ] (1) Work Package, (2) Gap, (3) Plateau, (4) Deliverable
- [x] (1) Work Package, (2) Plateau, (3) Gap, (4) Deliverable
- [ ] (1) Deliverable, (2) Plateau, (3) Gap, (4) Work Package
- [ ] (1) Work Package, (2) Plateau, (3) Gap, (4) Artifact

> Projekt je Work Package, stabilní mezistav architektury Plateau, rozdíl mezi stavy Gap a konkrétní výsledek práce Deliverable. Ostatní kombinace prohazují stav a rozdíl, práci a výsledek, nebo zaměňují výsledek projektu za technologický Artifact.

### ? Na workshopu k migraci zazní: „Abychom se ze současného stavu dostali do stavu po konsolidaci datových center, musíme vyřešit, že dnes nemáme jednotný monitoring." Architekt sestavuje plán přechodu. Který prvek nejlépe zachytí část „dnes nemáme jednotný monitoring"?

- [x] Gap asociovaný s Baseline Plateau a s plateau po konsolidaci center
- [ ] Work Package „Jednotný monitoring" přiřazený oddělení provozu IT
- [ ] Assessment asociovaný s driverem „Spolehlivost provozu IT"
- [ ] Deliverable „Jednotný monitoring" realizovaný projektem konsolidace center

> Věta popisuje rozdíl mezi dvěma stavy architektury, tedy Gap asociovaný s oběma plateaus. Work Package a Deliverable už představují řešení, ne rozdíl; Assessment by se hodil v motivační analýze, ale v plánu přechodu jde o rozdíl mezi plateaus.

### ? Architekt chce v jednom pohledu ukázat, jakou práci program provede a co přesně předá do provozu. Má k dispozici prvky Plateau, Gap, Work Package a Deliverable. Který vztah má být v jádru tohoto pohledu?

- [ ] Gap —realization→ Plateau, protože uzavření rozdílu vytvoří nový stav
- [ ] Plateau —triggering→ Deliverable, protože stav architektury spustí předání
- [x] Work Package —realization→ Deliverable, protože práce vytváří konkrétní výsledky
- [ ] Deliverable —assignment→ Work Package, protože výsledek určuje vykonavatele práce

> Práci a její konkrétní výstupy spojuje Work Package —realization→ Deliverable. Gap nic nerealizuje, plateau nespouští deliverable a assignment vede od aktéra nebo role k work package, ne od výsledku.

## Work Package ve scénářích {#work-package-kdy .explain}

Work Package je jednorázová, časově ohraničená práce s určeným cílem: program, projekt, fáze nebo úkol. Jde o prvek chování v Implementation & Migration, takže ho lze skládat (program —composition→ projekty), řadit (triggering) a přiřadit mu odpovědnost (Business Actor nebo Business Role —assignment→ Work Package). Výsledek práce se modeluje jako Deliverable, který work package realizuje. Typická chyba je modelovat projekt jako Business Process — proces se opakuje a patří k provozu, kdežto work package skončí, jakmile je cíl splněn.

*Příklad:* Program Digitalizace (Work Package) —composition→ Projekt Nový portál (Work Package)

### ? Pojišťovna spouští dvouletý program „Moderní likvidace", který se skládá z projektů „Mobilní hlášení škody" a „Automatické posouzení". Architekt má zachytit strukturu programu. Který fragment je nejvhodnější?

- [ ] Moderní likvidace (Business Process) —composition→ Mobilní hlášení škody (Business Process)
- [ ] Moderní likvidace (Plateau) —aggregation→ Mobilní hlášení škody (Work Package)
- [ ] Mobilní hlášení škody (Work Package) —composition→ Moderní likvidace (Work Package)
- [x] Moderní likvidace (Work Package) —composition→ Mobilní hlášení škody (Work Package)

> Program i projekty jsou časově ohraničená práce, tedy Work Packages, a program se z projektů skládá kompozicí od celku k části. Business Process je opakované provozní chování, Plateau je stav architektury, ne program, a obrácená kompozice by udělala z programu část projektu.

### ? V modelu výrobní firmy je Business Process „Zavedení systému MES" přiřazený roli Projektový manažer; vede od analýzy po spuštění a má trvat 14 měsíců. Hlavní architekt ho označil za chybně typovaný. Jak to opravit?

- [x] Zavedení MES je jednorázová ohraničená práce, takže patří do Work Package
- [ ] Zavedení MES je stav po spuštění systému, takže patří do Plateau
- [ ] Zavedení MES je výsledek předávaný do provozu, takže patří do Deliverable
- [ ] Zavedení MES je schopnost, kterou firma získá, takže patří do Capability

> Jednorázová práce s cílem a termínem je Work Package a role projektového manažera k ní zůstane přiřazena. Business Process je opakované provozní chování; Plateau by byl stav po spuštění, Deliverable výstup projektu a Capability schopnost, kterou výsledky práce posílí.

## Work Package × Business Process {#wp-vs-process .compare}

Oba prvky jsou chování a oba mohou mít přiřazené role, ale jeden mění architekturu a druhý v ní běží.

| | Work Package | Business Process |
|---|---|---|
| Účel | provést změnu (program, projekt, úkol) | vykonávat běžnou činnost podniku |
| Opakovanost | jednorázový, s cílem a termínem | opakuje se pro každý případ |
| Výsledek | Deliverable, který realizuje prvky architektury | business výsledek (služba, produkt, objekt) |
| Kdo | Business Actor / Role —assignment→ Work Package | Business Actor / Role —assignment→ Business Process |
| Kde se objevuje | Project, Migration, Implementation and Migration pohledy | procesní a vrstvené pohledy |
| Pořadí | triggering mezi work packages | triggering nebo flow mezi procesy |

### ? Banka má činnost „Roční aktualizace KYC údajů klienta", která probíhá každý rok pro každého klienta, a zároveň projekt „Zavedení automatické aktualizace KYC", který má skončit v březnu 2027. Jak oba prvky nejlépe typovat?

- [ ] Obě jako Work Package, protože obě mají určený termín
- [ ] Aktualizaci jako Work Package a projekt jako Business Process
- [ ] Obě jako Business Process, protože je vykonávají zaměstnanci banky
- [x] Aktualizaci jako Business Process a projekt jako Work Package

> Opakovaná činnost pro každého klienta je Business Process, jednorázová změna s termínem je Work Package. Roční termín u procesu znamená periodicitu, ne konec práce, a to, kdo práci vykonává, typ prvku neurčuje.

### ? Architekt potřebuje ukázat, že projekt „Nový e-shop" (Work Package) dodá novou verzi procesu „Vyřízení objednávky". Model má zachytit, že projekt proces mění prostřednictvím svého výstupu, nikoli že ho spouští nebo vykonává. Který fragment je nejvhodnější?

- [x] Nový e-shop (Work Package) —realization→ E-shop release 1 (Deliverable) —realization→ Vyřízení objednávky v2 (Business Process)
- [ ] Nový e-shop (Work Package) —triggering→ Vyřízení objednávky v2 (Business Process) —realization→ E-shop release 1 (Deliverable)
- [ ] Nový e-shop (Work Package) —assignment→ Vyřízení objednávky v2 (Business Process) —realization→ E-shop release 1 (Deliverable)
- [ ] Nový e-shop (Work Package) —composition→ Vyřízení objednávky v2 (Business Process) —realization→ E-shop release 1 (Deliverable)

> Work Package realizuje Deliverable a Deliverable realizuje nový nebo změněný prvek architektury — změna je dohledatelná bez míchání práce s provozem. Triggering by tvrdil, že projekt spouští každý běh procesu, assignment by z projektu udělal vykonavatele, kompozice by udělala z procesu součást projektu a ve všech třech navíc proces „realizuje" výstup projektu, což logiku obrací.

## Pořadí práce, závislosti a milníky {#wp-poradi .explain}

Závislost „B může začít až po dokončení A" se mezi work packages vyjadřuje vztahem triggering (A —triggering→ B). Významné okamžiky plánu — schválení rozpočtu, podpis smlouvy s dodavatelem, go-live, ukončení starého systému — se modelují jako Implementation Event, který work package spouští, nebo který work package svým dokončením vyvolá. Z modelu se tak dá vyčíst roadmapa bez Ganttova diagramu. Typická chyba je vyjadřovat pořadí jen rozmístěním prvků v diagramu (umístění nemá v ArchiMate význam) nebo použít composition, která vyjadřuje rozklad, ne návaznost.

*Příklad:* Smlouva s dodavatelem podepsána (Implementation Event) —triggering→ Implementace CRM (Work Package) —triggering→ Migrace dat (Work Package) —triggering→ CRM v provozu (Implementation Event)

### ? Projekt „Migrace dat do nového ERP" může začít až po dokončení projektu „Čištění kmenových dat"; oba jsou součástí programu Nové ERP. Architekt chce závislost zachytit v Project pohledu. Který fragment je správný?

- [ ] Migrace dat (Work Package) —triggering→ Čištění kmenových dat (Work Package)
- [ ] Čištění kmenových dat (Deliverable) —realization→ Migrace dat (Work Package)
- [ ] Čištění kmenových dat (Work Package) —composition→ Migrace dat (Work Package)
- [x] Čištění kmenových dat (Work Package) —triggering→ Migrace dat (Work Package)

> Časová návaznost práce se vyjadřuje triggeringem od předchozího work package k navazujícímu. Obrácený směr by tvrdil, že čištění čeká na migraci, kompozice vyjadřuje rozklad, ne pořadí, a deliverable work package nerealizuje — je to naopak.

### ? Projekt „Nová fakturace" nemůže začít, dokud není podepsána smlouva s dodavatelem. Jeho dokončení má formálně potvrdit milník „Fakturace v provozu", na který navazuje další projekt. Architekt chce tento sled zachytit v plánu přechodu. Který fragment je nejlepší?

- [ ] Smlouva podepsána (Business Event) —triggering→ Nová fakturace (Business Process) —triggering→ Fakturace v provozu (Business Event)
- [ ] Smlouva podepsána (Plateau) —triggering→ Nová fakturace (Work Package) —triggering→ Fakturace v provozu (Plateau)
- [x] Smlouva podepsána (Implementation Event) —triggering→ Nová fakturace (Work Package) —triggering→ Fakturace v provozu (Implementation Event)
- [ ] Smlouva podepsána (Implementation Event) —triggering→ Nová fakturace (Deliverable) —triggering→ Fakturace v provozu (Implementation Event)

> Okamžiky významné pro plán změny jsou Implementation Events a práce mezi nimi je Work Package. Business Event a Business Process patří do provozního chování, Plateau je stav, ne okamžik, a Deliverable je výsledek práce, který nic nespouští.

## Deliverable ve scénářích {#deliverable-kdy .explain}

Deliverable je přesně vymezený výsledek work package: softwarová verze, migrovaná data, dokumentace, smlouva, metodika nebo zaškolení uživatelů. Work Package —realization→ Deliverable a Deliverable —realization→ prvky architektury, které vznikají nebo se mění (aplikace, služby, procesy, nody), případně Plateau, ke kterému výsledek vede. Vznikne tak dohledatelnost „projekt → výstup → změněná architektura → stav". Deliverable se modeluje hlavně tehdy, když je třeba řídit předání a akceptaci výstupů; samotné prvky architektury (např. Application Component) deliverables nejsou — deliverable je realizuje.

*Příklad:* Projekt CRM (Work Package) —realization→ CRM release 2.0 (Deliverable) —realization→ CRM (Application Component)

### ? Projekt „Zákaznický portál" má dodat portál ve verzi 1.0, který se stane součástí cílové architektury jako Application Component „Zákaznický portál". Řídicí výbor chce vidět, který výstup projektu vytvoří kterou část architektury. Který fragment je správný?

- [ ] Zákaznický portál (Work Package) —realization→ Zákaznický portál (Application Component) —realization→ Portál v1.0 (Deliverable)
- [ ] Zákaznický portál (Work Package) —assignment→ Portál v1.0 (Deliverable) —serving→ Zákaznický portál (Application Component)
- [ ] Portál v1.0 (Deliverable) —realization→ Zákaznický portál (Work Package) —realization→ Zákaznický portál (Application Component)
- [x] Zákaznický portál (Work Package) —realization→ Portál v1.0 (Deliverable) —realization→ Zákaznický portál (Application Component)

> Řetězec vede od práce k výstupu a od výstupu k prvku architektury, který vzniká: Work Package realizuje Deliverable a ten realizuje Application Component. Fragmenty, kde komponenta realizuje deliverable nebo deliverable realizuje projekt, obracejí směr, a assignment ani serving nejsou vztahy mezi prací, výstupem a architekturou.

### ? Projekt „Zavedení BIM" ve stavební firmě předá tři výstupy: nastavený software, metodiku práce a proškolené projektanty. Architekt váhá, zda výstupy modelovat jako Deliverables. Kdy je to nejpřínosnější?

- [ ] Vždy, když existuje Application Component, protože ji deliverable v modelu nahradí
- [ ] Jen u softwarových výstupů, protože metodika a školení se v modelu nezachycují
- [x] Když je třeba řídit předání a akceptaci výstupů a dohledat jejich dopad na architekturu
- [ ] Jen u cílového plateau, protože při cestě k přechodným plateaus žádné výstupy nevznikají

> Deliverable má smysl tam, kde se sleduje předání a akceptace výsledků práce a jejich vazba na architekturu — a může být i nesoftwarový (metodika, proškolení). Deliverable komponentu nenahrazuje, ale realizuje, a výstupy vznikají i na cestě k přechodným plateaus.

## Deliverable × Artifact × Business Object × Contract {#deliverable-vs-artifact .compare}

Všechny čtyři mohou vypadat jako „dokument" nebo „soubor"; rozhoduje, k čemu v modelu slouží.

| | Deliverable | Artifact | Business Object | Contract |
|---|---|---|---|---|
| Vrstva | Implementation & Migration | Technology | Business | Business |
| Význam | výsledek práce na změně, který se předává a akceptuje | fyzický soubor nasazený nebo používaný v technologii | informace, se kterou pracuje business | formální dohoda o podmínkách (specializace Business Object) |
| Příklad | „Schválený datový model CRM" | „crm-app.war" | „Objednávka" | „SLA s poskytovatelem cloudu" |
| Typická vazba | Work Package —realization→ Deliverable | Artifact —realization→ Application Component nebo Data Object | Business Process —access→ Business Object | Contract je součástí Product nebo upravuje Business Service |

### ? Projekt výměny účetního systému má předat „Schválený návrh účtové osnovy" — dokument, který sponzor formálně akceptuje a podle kterého se systém nastaví. Architekt chce výstup zachytit v plánu přechodu. Jaký typ prvku je nejvhodnější?

- [ ] Artifact, protože jde o soubor uložený na serveru projektu
- [ ] Business Object, protože obsahuje účetní informace podniku
- [x] Deliverable, protože je to výsledek práce, který se předává
- [ ] Contract, protože ho sponzor formálně podepisuje a schvaluje

> Výstup projektu, jehož předání a akceptace se řídí, je Deliverable realizovaný work packagem. Artifact je technologický soubor nasazený v infrastruktuře, Business Object informace v běžném provozu a Contract dohoda o podmínkách mezi stranami, ne schválení výstupu.

### ? Dodavatel předá v rámci projektu soubor „billing-2.4.jar", který bude nasazen na aplikační server a realizuje aplikační komponentu Billing. Architekt chce zachytit obojí: že jde o předávaný výstup projektu i že v technologii jde o nasazený soubor. Které řešení je nejlepší?

- [ ] Jen Deliverable „billing-2.4.jar" přiřazený vztahem assignment k aplikačnímu serveru, kde poběží
- [x] Deliverable „Billing 2.4" realizuje Artifact „billing-2.4.jar" a ten komponentu Billing
- [ ] Jen Artifact „billing-2.4.jar" realizovaný work packagem, bez dalšího prvku pro předání
- [ ] Business Object „billing-2.4.jar", ke kterému má projekt přístup vztahem access

> Předávaný výstup a nasazený soubor jsou dva pohledy na tutéž věc: Deliverable (řízení změny) realizuje Artifact (technologie), který realizuje komponentu Billing. Assignment deliverable k serveru nedává smysl, samotný artifact ztrácí stránku předání a akceptace a Business Object není technologický soubor.

## Implementation Event × Business Event {#implementation-event .compare}

Obě jsou události, ale každá patří do jiného světa: jedna do plánu změny, druhá do běžného provozu.

| | Implementation Event | Business Event |
|---|---|---|
| Kontext | plán změny (programy, projekty, plateaus) | provoz podniku |
| Příklady | podpis smlouvy, schválení rozpočtu, go-live, ukončení podpory starého systému | přijetí objednávky, nahlášení škody, konec měsíce |
| Opakování | jednorázový milník plánu | opakuje se pro každý případ nebo období |
| Typické vztahy | triggering s Work Package | triggering Business Process |
| Typická chyba | modelovat ho jako Plateau | použít ho pro milník projektu |

### ? Program migrace do cloudu má milník „Ukončení smlouvy se stávajícím hostingem 30. 6. 2027", po kterém musí začít projekt vypnutí starého datového centra. Jak milník nejlépe modelovat?

- [ ] Jako Business Event, který spouští Business Process „Vypnutí datového centra"
- [ ] Jako Plateau, který agreguje prvky architektury platné k 30. 6. 2027
- [ ] Jako Deliverable, který realizuje projekt vypnutí starého datového centra
- [x] Jako Implementation Event, který spouští Work Package „Vypnutí datového centra"

> Jednorázový milník v plánu změny je Implementation Event a navazující práci spouští triggeringem. Business Event a Business Process patří do běžného provozu, Plateau je stav trvající delší dobu a Deliverable je výstup práce, ne okamžik.

### ? Architekt pojišťovny namodeloval Implementation Event „Klient nahlásí pojistnou událost", který spouští proces likvidace. Revize modelu to označila za chybu. Proč?

- [x] Jde o opakovaný provozní okamžik, takže patří do Business Event
- [ ] Jde o výsledek práce předávaný do provozu, takže patří do Deliverable
- [ ] Jde o stabilní stav architektury, takže patří do Plateau
- [ ] Jde o zjištění z analýzy současného stavu, takže patří do Assessment

> Nahlášení události klientem se opakuje v běžném provozu a spouští Business Process — to je Business Event. Implementation Event slouží pro milníky plánu změny; Deliverable, Plateau a Assessment popisují úplně jiné skutečnosti.

## Odpovědnost za práci {#prirazeni-odpovednosti .explain}

Kdo práci provádí nebo za ni odpovídá, se modeluje vztahem assignment od Business Actor nebo Business Role k Work Package — např. interní tým, externí dodavatel nebo role Programový manažer. Role je vhodnější, když se konkrétní osoba či firma může změnit; aktér, když jde o konkrétní subjekt (dodavatel ABC s.r.o.). Stakeholder se k work package nepřiřazuje — vyjadřuje zájem, ne práci, a jeho vazba vede přes motivační prvky. Typická chyba je obrácený směr (Work Package —assignment→ Role) nebo serving („dodavatel slouží projektu").

*Příklad:* Dodavatel ABC (Business Actor) —assignment→ Implementace ERP (Work Package)

### ? Projekt „Implementace ERP" provádí externí dodavatel ABC Consulting a za výsledek odpovídá interní role Vlastník produktu. Architekt chce obojí zachytit v Project pohledu. Který fragment je správný?

- [ ] Implementace ERP (Work Package) —assignment→ ABC Consulting (Business Actor) a Vlastník produktu (Business Role)
- [ ] ABC Consulting (Business Actor) a Vlastník produktu (Business Role) —serving→ Implementace ERP (Work Package)
- [ ] ABC Consulting (Stakeholder) a Vlastník produktu (Stakeholder) —association→ Implementace ERP (Work Package)
- [x] ABC Consulting (Business Actor) a Vlastník produktu (Business Role) —assignment→ Implementace ERP (Work Package)

> Provádění práce a odpovědnost za ni vyjadřuje assignment od aktéra nebo role k Work Package. Obrácený směr je chybný, serving vyjadřuje poskytování funkčnosti, ne provádění práce, a Stakeholder vyjadřuje zájem, nikoli vykonavatele.

### ? Program digitalizace má sponzora z představenstva, kterému záleží na návratnosti investice, ale na projektech sám nepracuje. Projekty provádí interní tým IT. Architekt chce správně zachytit sponzora i tým. Které řešení je nejlepší?

- [ ] Sponzora i tým přiřadit k Work Package vztahem assignment jako dva vykonavatele
- [x] Tým přiřadit k Work Package vztahem assignment; sponzora jako Stakeholder s Driver
- [ ] Sponzora přiřadit k Work Package vztahem assignment; tým modelovat jen jako Stakeholder
- [ ] Sponzora i tým modelovat jako Stakeholder a k Work Package je vůbec nepřipojovat

> Vykonavatel práce (tým) je přiřazen k Work Package, kdežto sponzor má na výsledku zájem — to vyjadřuje Stakeholder s motivačními prvky. Přiřadit sponzora jako vykonavatele zkresluje, kdo práci dělá, a tým bez vazby na práci by z modelu odpovědnost úplně vypustil.

## Celý řetězec plánu přechodu {#retezec-migrace .explain}

Úplný migrační model spojuje čtyři roviny: **stavy** (Plateau —triggering→ Plateau, Gap asociovaný se dvěma plateaus), **obsah stavů** (Plateau —aggregation→ prvky architektury), **práci** (Business Role —assignment→ Work Package, Work Package —triggering→ Work Package) a **výstupy** (Work Package —realization→ Deliverable —realization→ prvky architektury nebo Plateau). Z takového modelu lze odpovědět na otázky „který projekt dodá tento stav?", „co se posune, když se projekt zpozdí?" a „který gap zůstane neuzavřený?". Při revizi se hledají díry: plateau, ke kterému nevede žádný deliverable, gap, kterého se netýká žádná práce, nebo deliverable bez vazby na architekturu.

*Příklad:* Migrace do cloudu (Work Package) —realization→ Data v cloudu (Deliverable) —realization→ Transition 2027 (Plateau); Transition 2027 (Plateau) —triggering→ Target 2028 (Plateau)

### ? Ředitel IT se ptá, které projekty musejí být dokončeny, aby firma dosáhla přechodného stavu „Transition 2027". Architekt chce, aby odpověď šla přímo vyčíst z modelu. Který řetězec je pro to nejvhodnější?

- [x] Projekt (Work Package) —realization→ Výstup (Deliverable) —realization→ Transition 2027 (Plateau)
- [ ] Projekt (Work Package) —triggering→ Transition 2027 (Plateau) —realization→ Výstup (Deliverable)
- [ ] Transition 2027 (Plateau) —realization→ Výstup (Deliverable) —realization→ Projekt (Work Package)
- [ ] Projekt (Work Package) —assignment→ Výstup (Deliverable) —aggregation→ Transition 2027 (Plateau)

> Z realizačního řetězce Work Package → Deliverable → Plateau je vidět, které projekty svými výstupy daný stav vytvářejí. Řetězec, kde plateau realizuje deliverable, i řetězec obrácený od plateau k projektu mají chybný směr a assignment ani agregace nevyjadřují, že výstup stav realizuje.

### ? Při revizi migračního modelu architekt najde Gap „Chybí jednotná správa identit", asociovaný s Baseline i Target Plateau, ke kterému se ale nevztahuje žádný Work Package ani Deliverable. Ostatní gaps jsou pokryté. Jaký závěr je nejlepší?

- [ ] Model je v pořádku, protože gap má vazbu na obě plateaus
- [ ] Gap smazat, protože nemá vazbu na žádný projekt
- [x] Plán rozdíl neřeší; chybí work package, který ho uzavře
- [ ] Gap převést na Requirement, aby ho pokryla motivace

> Gap bez navazující práce znamená, že plán přechodu rozdíl mezi stavy neuzavře — chybí work package, nebo je třeba rozšířit existující. Smazání by problém skrylo, samotná vazba na plateaus nestačí a převod na požadavek mezeru v plánu neodstraní.

### ? Projekt „Konsolidace skladů" se zpozdí o půl roku. Vedení se ptá, které další projekty a které stavy architektury budou zasaženy. Model obsahuje vztahy Work Package —triggering→ Work Package, Work Package —realization→ Deliverable a Deliverable —realization→ Plateau. Jak má architekt postupovat?

- [ ] Projít agregace Target Plateau a vybrat aplikace, které se zpožděním změní nejvíc
- [ ] Najít v modelu Implementation Events a posunout jejich data o půl roku
- [ ] Projít motivační prvky a zjistit, které cíle se zpozdí nejvíc
- [x] Sledovat triggering k navazující práci a realizaci přes deliverables k plateaus

> Dopad zpoždění se dohledá po vztazích modelu: triggering ukáže navazující work packages a realizační řetězec přes deliverables ukáže, která plateaus budou dosažena později. Agregace Target Plateau o projektu nic neříká, posun událostí bez analýzy je kosmetika a motivační prvky dopad na plán přímo neukážou.

## Volba přechodových plateaus {#prechodove-plateau .explain}

Kolik přechodových plateaus a s jakým obsahem? Každé Transition Plateau má být stav, který lze provozovat a který už přináší hodnotu — typicky po dokončení logického celku (např. jeden zákaznický segment kompletně na novém systému). Hranice se volí podle závislostí (co musí být dřív), rizika (velký skok rozdělit), rozpočtových cyklů a období zákazu změn. Příliš mnoho plateaus zahltí model i plán; žádné plateau mezi Baseline a Target znamená „velký třesk" s vysokým rizikem. Stejnou úvahu dělá TOGAF ve Phase E při identifikaci Transition Architectures.

*Příklad:* Baseline 2026 (Plateau) —triggering→ Transition 2027: domácnosti v novém CRM, firmy ve starém (Plateau) —triggering→ Target 2028: vše v novém CRM (Plateau)

### ? Banka nahrazuje core banking a chce přechod rozdělit do mezistavů. Tým navrhl čtyři formulace přechodového stavu. Která nejlépe odpovídá smyslu Transition Plateau?

- [ ] „Polovina migračních skriptů je napsána a otestována v testovacím prostředí"
- [ ] „Rozpočet programu na příští rok je schválen představenstvem banky"
- [ ] „Dodavatel je vybrán a smlouva o implementaci nového systému je podepsána"
- [x] „Spotřebitelské účty běží na novém systému, firemní účty zatím na původním"

> Transition Plateau má být provozovatelný stav architektury, který už přináší hodnotu — např. jeden segment na novém systému. Rozpracované skripty jsou stav práce, ne architektury, a výběr dodavatele či schválení rozpočtu jsou milníky (Implementation Events).

### ? Výrobní firma chce vyměnit ERP, MES a skladový systém najednou během jednoho víkendu, bez mezistavů. Architekt upozorňuje na vysoké riziko a na to, že nový MES vyžaduje nové ERP. Co má v modelu navrhnout?

- [ ] Ponechat jen Target Plateau a riziko zapsat jako Assessment u programu
- [x] Vložit Transition Plateau podle závislostí: nové ERP, starý MES
- [ ] Rozdělit Target Plateau na tři cílové stavy, jeden pro každý systém
- [ ] Přidat Implementation Event „Víkend přechodu" a plán jinak neměnit

> Rozdělení velkého skoku do přechodových plateaus podle závislostí (ERP dřív než MES) snižuje riziko a každý mezistav lze provozovat. Zapsání rizika ani přidání milníku riziko nesníží a tři cílové stavy by rozbily společný cíl.

## TOGAF Phases E–F × ArchiMate {#togaf-e-f .compare}

Výstupy plánování přechodu v TOGAF ADM mají v ArchiMate přímé protějšky v Implementation & Migration.

| TOGAF (Phases E–F) | ArchiMate |
|---|---|
| Baseline / Target Architecture | Baseline / Target Plateau |
| Transition Architecture | Transition Plateau |
| mezery z gap analysis, konsolidovaná matice mezer, řešení a závislostí | Gap asociovaný s plateaus a s dotčenými prvky |
| work packages v Architecture Roadmap | Work Package (composition, triggering) |
| výstupy projektů, přírůstky architektury | Deliverable realizující prvky architektury nebo Plateau |
| milníky a rozhodovací body plánu | Implementation Event |
| Architecture Roadmap, Implementation and Migration Plan | Project, Migration a Implementation and Migration pohledy |

### ? Architekt dokončuje Phase E a má identifikované dvě Transition Architectures mezi Baseline a Target. Chce je zachytit v modelu ArchiMate, aby na ně ve Phase F navázal plánování projektů. Který prvek pro ně použije?

- [ ] Work Package, protože každá přechodová architektura je jeden projekt
- [ ] Gap, protože přechodová architektura je rozdíl mezi Baseline a Target Architecture
- [x] Plateau, protože přechodová architektura je stabilní mezistav architektury
- [ ] Implementation Event, protože přechodová architektura nastává k datu

> Transition Architecture z TOGAF odpovídá v ArchiMate prvku Plateau (Transition). Work Package je práce vedoucí k mezistavu, Gap rozdíl mezi dvěma stavy a Implementation Event okamžik, ne stav.

### ? Ve Phase E architekt sestavil konsolidovanou matici mezer, řešení a závislostí. Nyní chce mezery a jejich řešení převést do modelu ArchiMate, aby je mohl propojit s architekturou. Které mapování je nejvhodnější?

- [x] Mezery jako Gap mezi plateaus, řešení jako Work Package a Deliverable
- [ ] Mezery jako Assessment, řešení jako Course of Action a Capability
- [ ] Mezery jako Requirement, řešení jako Application Component a Node
- [ ] Mezery jako Plateau, řešení jako Implementation Event a Work Package

> Mezery z gap analysis odpovídají prvku Gap a jejich řešení se v plánu přechodu stávají Work Packages a Deliverables. Assessment a Course of Action patří do motivace a strategie, požadavky a Core prvky nejsou plán řešení a Plateau je stav, ne mezera.

### ? Ve Phase F programová kancelář prioritizuje work packages a potřebuje vědět, který z nich je nutný pro dosažení kterého přechodového stavu. Architekt má k dispozici model z Phase E. Které vztahy použije?

- [ ] Assignment od rolí k work packages, protože ukazuje vlastníky jednotlivých projektů
- [ ] Aggregation od plateau k Core prvkům, protože ukazuje obsah stavu
- [ ] Association od gap k plateaus, protože ukazuje rozdíly mezi stavy
- [x] Realization od work package přes deliverable k plateau, tedy příspěvek ke stavu

> Který work package je nutný pro který stav, ukazuje realizační řetězec Work Package → Deliverable → Plateau. Assignment ukazuje odpovědnost, agregace obsah stavu bez vazby na projekty a asociace gapu jen rozdíl mezi stavy.

## Pohledy pro plánování přechodu {#migracni-pohledy .compare}

Obsah pohledu na plán přechodu se vybírá podle otázky, kterou má zodpovědět; který příkladový viewpoint takový pohled předepisuje, řeší volba viewpointů pro stakeholdery.

| Otázka pohledu | Prvky a vztahy v pohledu |
|---|---|
| Přes jaké stavy půjdeme a čím se liší? | Plateaus spojené triggeringem, Gaps asociované s dvojicemi plateaus |
| Jakou práci uděláme, kdo a v jakém pořadí? | Work Packages, Deliverables, Implementation Events, assignment rolí, triggering |
| Co práce změní v architektuře? | řetězec Work Package → Deliverable → prvky architektury a Plateau (realization) |

### ? Člen představenstva chce na jedné stránce vidět jen stavy architektury, přes které podnik půjde od současné k cílové, a rozdíly mezi nimi. Projekty ani systémy ho nezajímají. Které prvky a vztahy má pohled obsahovat?

- [ ] Work Packages s Deliverables, které realizují, a role přiřazené k práci
- [x] Plateaus spojené triggeringem a Gaps asociované s dvojicemi plateaus
- [ ] Core prvky agregované do plateaus vztahem aggregation, bez dalších vazeb
- [ ] Implementation Events spojené triggeringem s navazujícími milníky plánu

> Stavy architektury jsou Plateaus, jejich pořadí vyjadřuje triggering a rozdíly mezi nimi Gaps asociované vždy s dvojicí plateaus. Work packages s deliverables a rolemi jsou projektová práce, která člena představenstva nezajímá, agregované Core prvky ukážou systémy v jednotlivých stavech, ale ne pořadí ani rozdíly, a implementation events jsou milníky plánu, ne stavy.

### ? Programový manažer potřebuje přehled, které projekty program obsahuje, kdo za ně odpovídá, jaké výstupy předají, kdy nastanou klíčové milníky a v jakém pořadí na sebe projekty navazují. Vazby na konkrétní aplikace nepotřebuje. Které prvky a vztahy má pohled obsahovat?

- [x] Work Packages, Deliverables, Implementation Events, assignment a triggering
- [ ] Plateaus spojené triggeringem a Gaps asociované s dvojicemi plateaus
- [ ] Deliverables, které realizují Application Components nasazené na Nodes
- [ ] Course of Action a Capabilities, které má program podle strategie posílit

> Projekty jsou Work Packages, výstupy Deliverables, milníky Implementation Events, odpovědnost vyjadřuje assignment od rolí a pořadí triggering. Plateaus a gaps ukazují stavy architektury místo práce, vazba deliverables na aplikace a nody je právě to, co manažer nepotřebuje, a Course of Action s capabilities je strategický obsah.

## Typické chyby v migračních modelech {#chyby-migrace .explain}

Nejčastější chyby při revizi: projekt jako Business Process místo Work Package; milník jako Plateau místo Implementation Event; Gap pojmenovaný jako činnost nebo asociovaný jen s jedním plateau; obrácený směr realizace (Deliverable —realization→ Work Package); Plateau skládající prvky kompozicí, ačkoli tytéž prvky patří do více stavů; Work Package, který přímo „obsahuje" aplikaci, místo řetězce přes Deliverable; plateaus bez určeného pořadí (chybí triggering). Pomáhá kontrolní otázka u každého prvku: je to stav, rozdíl, práce, výsledek, nebo okamžik?

*Příklad:* Chybně: Schválení rozpočtu (Plateau) —triggering→ Migrace (Business Process). Správně: Schválení rozpočtu (Implementation Event) —triggering→ Migrace (Work Package).

### ? Architekt reviduje model: Projekt CRM (Work Package) —realization→ CRM release 1 (Deliverable); CRM release 1 (Deliverable) —realization→ CRM (Application Component); Baseline (Plateau) —triggering→ Target (Plateau); Chybí jednotný pohled na zákazníka (Gap) —association→ Target (Plateau). Co je v modelu chybně?

- [ ] Deliverable nesmí realizovat Application Component, jen Plateau
- [ ] Mezi plateaus má být vztah flow, nikoli triggering
- [x] Gap je asociován jen s jedním plateau, chybí vazba na Baseline
- [ ] Work Package má realizovat komponentu přímo, bez Deliverable

> Gap vyjadřuje rozdíl mezi dvěma stavy, takže má být asociován s oběma plateaus. Deliverable prvky architektury realizovat smí, triggering je správný vztah pro pořadí plateaus a mezičlánek přes Deliverable je dobrá praxe.

### ? V migračním modelu nemocnice je: Nový NIS (Work Package) —composition→ Nový NIS (Application Component) a Nový NIS (Application Component) —realization→ Target (Plateau). Hlavní architekt model vrátil. Jaká oprava je nejlepší?

- [ ] Nahradit composition vztahem assignment vedoucím od Work Package k aplikační komponentě NIS
- [x] Work Package realizuje Deliverable, ten realizuje komponentu a Target ji agreguje
- [ ] Ponechat composition a jen změnit typ komponenty NIS na Deliverable
- [ ] Nahradit Work Package prvkem Business Process, který komponentu vytvoří

> Práce není celek, jehož součástí je aplikace: Work Package realizuje Deliverable, ten realizuje komponentu a Target Plateau komponentu agreguje jako svůj obsah. Assignment od work package ke komponentě nedává smysl, přetypování komponenty by ztratilo prvek architektury a projekt není provozní proces.
