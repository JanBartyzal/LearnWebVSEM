---
kind: topic
subject: archimate-practitioner
slug: pohledy-pro-stakeholdery
name: "Volba viewpointů a pohledů pro stakeholdery"
order: 8
---

Který viewpoint pro kterého stakeholdera a concern, tvorba vlastního viewpointu.

## Pohled × hledisko v praxi {#view-vs-viewpoint .compare}

V praxi se pojmy často zaměňují — „viewpoint" není konkrétní obrázek.

| | Viewpoint (hledisko) | View (pohled) |
|---|---|---|
| Co to je | předpis: pro koho, k jakým concerns, jaké prvky a vztahy, jaká forma a konvence | konkrétní výřez modelu vytvořený podle viewpointu |
| Vztah k modelu | nezávislý na konkrétním obsahu, znovupoužitelný | obsahuje konkrétní prvky a vztahy jednoho modelu |
| Kolik | podle jednoho viewpointu vzniká mnoho pohledů | každý pohled se řídí jedním viewpointem |
| Příklad | Application Cooperation viewpoint | „Integrace aplikací e-shopu, stav 2026" |

### ? Architekt pojišťovny nakreslil diagram aplikací pro likvidaci pojistných událostí a datových toků mezi nimi, který slouží projektu modernizace. Kolega diagram označuje jako „viewpoint likvidace". Jak ho správně pojmenovat?

- [x] Je to pohled (view); viewpoint je předpis, podle něhož pohled vznikl
- [ ] Je to viewpoint, protože zachycuje hledisko jednoho konkrétního projektu
- [ ] Je to model, protože obsahuje prvky a vztahy uložené v repozitáři
- [ ] Je to concern, protože odpovídá na otázku jednoho stakeholdera

> Diagram s konkrétními aplikacemi a toky je pohled; viewpoint je znovupoužitelný předpis (stakeholdeři, concerns, prvky, forma), podle něhož pohled vznikl. Model je celek, z něhož pohled vybírá, a concern je zájem stakeholdera, ne diagram.

### ? Banka chce, aby všechny pohledy pro provoz infrastruktury napříč projekty obsahovaly jen schválené typy prvků a vztahů a dodržovaly jednotné konvence zobrazení. Co má architekt definovat?

- [ ] Nový pohled pro každý projekt podle uvážení autora
- [ ] Profil s atributy pro všechny prvky Technology Layer
- [x] Viewpoint s povolenými prvky, vztahy a konvencemi
- [ ] Novou vrstvu jazyka vyhrazenou pro provoz infrastruktury

> Jednotná pravidla pro opakovaně tvořené pohledy dává viewpoint. Pohledy „podle uvážení" jednotnost nezaručí, profil jen přidává atributy typům prvků a jazyk se pro takovou potřebu nerozšiřuje o vrstvy.

## Postup volby viewpointu {#postup-volby .explain}

Viewpoint se volí od stakeholdera, ne od nástroje. Postup: (1) kdo je stakeholder, (2) jaké má concerns — co chce vědět nebo rozhodnout, (3) jaký je účel pohledu (Designing, Deciding, Informing) a potřebná úroveň (Details, Coherence, Overview), (4) najít příkladový viewpoint, který concern pokrývá, případně ho upravit nebo definovat vlastní, (5) vytvořit pohled z modelu, (6) ověřit se stakeholderem, že mu odpovídá. Příkladové viewpointy ze specifikace jsou inspirace, ne povinnost.

*Příklad:* finanční ředitel → concern „které aplikace můžeme vyřadit" → Deciding, Overview → přehled aplikací s náklady a podporovanými procesy.

### ? Architekt v energetické firmě má připravit podklad pro nově nastoupivšího ředitele zákaznického centra. O řediteli zatím ví jen to, že „chce mít přehled o systémech". Kterým krokem má začít?

- [ ] Vybrat nejpodrobnější příkladový viewpoint, aby v podkladu nic nechybělo
- [x] Zjistit, jaké concerns ředitel má a k čemu bude pohled používat
- [ ] Vytvořit pohled se všemi prvky modelu, které se zákaznického centra týkají
- [ ] Použít Layered viewpoint, protože se hodí pro všechny manažery

> Volba viewpointu začíná u concerns a účelu — „přehled o systémech" může znamenat rozhodování o investicích stejně jako orientaci v provozu. Nejpodrobnější viewpoint ani pohled se vším concern neřeší a Layered viewpoint není univerzální odpověď pro každého manažera.

## Účel: Designing, Deciding, Informing {#ucel-viewpointu .compare}

Viewpoint Mechanism klasifikuje viewpointy podle účelu — k čemu bude pohled stakeholderovi sloužit.

| Účel | Komu typicky | Co pohled podporuje | Typická forma |
|---|---|---|---|
| Designing | architekti, návrháři procesů, vývojáři | návrh a detailní rozpracování řešení | podrobné diagramy v plné notaci ArchiMate |
| Deciding | manažeři, CIO, CEO | rozhodnutí na základě přehledu a analýzy | přehledové diagramy, křížové tabulky, mapy, reporty |
| Informing | zaměstnanci, zákazníci, partneři, široké publikum | vysvětlení, porozumění, získání podpory | jednoduché ilustrace a obrázky bez odborné notace |

### ? Výrobní firma zavádí nový proces objednávání materiálu. Všech 600 zaměstnanců výroby se má dozvědět, co se pro ně v každodenní práci změní; notaci ArchiMate neznají. Jaký účel má mít pohled, který pro ně architekt připraví?

- [ ] Designing — podrobný diagram procesu v plné notaci ArchiMate
- [ ] Deciding — přehled variant procesu pro výběr ve vedení firmy
- [ ] Coherence — propojení procesu s aplikacemi a infrastrukturou
- [x] Informing — srozumitelná ilustrace změn bez odborné notace

> Široké publikum, které má změně porozumět, odpovídá účelu Informing a jednoduché formě. Designing slouží návrhářům, Deciding rozhodujícím manažerům a Coherence není účel, ale úroveň podrobnosti.

### ? Vedení banky má do měsíce rozhodnout, které ze tří variant konsolidace platebních systémů dá přednost. Potřebuje vidět vedle sebe náklady, dotčené procesy a rizika jednotlivých variant. Jaký účel má mít pohled?

- [x] Deciding — přehledné srovnání variant podle podstatných kritérií
- [ ] Designing — podrobné diagramy integrace každé z variant řešení
- [ ] Informing — jednoduchá ilustrace cílového stavu pro všechny zaměstnance
- [ ] Details — pohled na jednu vrstvu a jeden aspekt každé varianty

> Podklad pro výběr mezi variantami je typický Deciding: přehled, srovnání, analýza. Podrobné diagramy návrhu vedení nepomohou rozhodnout, ilustrace pro zaměstnance nesrovnává varianty a Details je úroveň, ne účel.

### ? Tým architektů řešení v e-shopu rozpracovává integraci nového CRM: aplikační rozhraní, služby, datové objekty a jejich přesné vztahy. Výsledek převezmou vývojáři jako zadání. Jaký účel mají mít pohledy?

- [ ] Informing — zjednodušené obrázky, aby se vývojáři rychle zorientovali
- [ ] Deciding — přehled pro vedení, zda integraci vůbec realizovat
- [x] Designing — podrobné pohledy v plné notaci pro návrh řešení
- [ ] Overview — pohled na všechny vrstvy a aspekty celého e-shopu

> Návrh řešení pro architekty a vývojáře je účel Designing s podrobnou a přesnou notací. Zjednodušené obrázky ztratí potřebné detaily, rozhodování vedení tu není cílem a Overview je úroveň určená pro celkový přehled, ne pro zadání vývoje.

## Úroveň: Details, Coherence, Overview {#uroven-viewpointu .compare}

Druhá osa klasifikace říká, jak široký výřez architektury pohled pokrývá.

| Úroveň | Rozsah | Pro koho typicky |
|---|---|---|
| Details | jedna vrstva a jeden aspekt | softwaroví inženýři, vlastníci procesů |
| Coherence | více vrstev **nebo** více aspektů, zaměřeno na jedno téma | provozní manažeři odpovědní za skupinu služeb nebo procesů |
| Overview | více vrstev **i** aspektů najednou | enterprise architekti, CIO, CEO |

### ? Vývojář potřebuje pro refaktoring pohled jen na vnitřní skladbu jedné aplikace — její dílčí komponenty a vztahy mezi nimi. Procesy, data ani infrastruktura ho teď nezajímají. Kterou úroveň má pohled mít?

- [ ] Overview, protože aplikace je součástí celé architektury firmy
- [x] Details, protože jde o jednu vrstvu a jeden aspekt architektury
- [ ] Coherence, protože pohled propojuje více komponent aplikace
- [ ] Informing, protože vývojář se potřebuje o aplikaci informovat

> Komponenty jedné aplikace a jejich skladba leží v jedné vrstvě (Application) a jednom aspektu (aktivní struktura) — úroveň Details. Coherence a Overview zahrnují více vrstev nebo aspektů a Informing není úroveň, ale účel.

### ? CIO pojišťovny chce na jedné stránce vidět celou firmu napříč vrstvami — hlavní procesy, aplikace, data i infrastrukturu a jejich vzájemné závislosti. Kterou úroveň má viewpoint mít?

- [ ] Details, protože CIO potřebuje přesné vztahy mezi prvky
- [ ] Coherence, protože pohled se soustředí na jedno téma
- [ ] Designing, protože CIO navrhuje celkovou architekturu
- [x] Overview, protože pokrývá více vrstev i aspektů najednou

> Celkový obraz napříč vrstvami i aspekty pro CIO je úroveň Overview. Details pokrývá jen jednu vrstvu a aspekt, Coherence se soustředí na užší téma a Designing je účel, ne úroveň.

## Vedení a CIO: přehled napříč vrstvami {#vedeni-a-cio .explain}

Pro CIO a enterprise architekty je typickým výchozím bodem **Layered viewpoint** — jeden pohled přes více vrstev ukáže, jak procesy závisí na aplikacích a ty na technologii. Riziko je přeplnění: pohled pro vedení má obsahovat jen klíčové prvky, využít Grouping a odvozené vztahy (komponenta přímo slouží procesu) a detail nechat v modelu. Pokud vedení řeší spíš „co firma umí a kam investovat" než „co na čem běží", lépe poslouží viewpointy ze skupiny Strategy (Capability Map, Strategy).

*Příklad:* pohled pro CIO: 8 hlavních procesů, 12 klíčových aplikací seskupených podle domén a 3 platformy, propojené odvozenými vztahy serving.

### ? CIO pojišťovny chce na jedné stránce vidět, jak klíčové business procesy závisejí na aplikacích a ty na infrastruktuře, aby mohl s představenstvem mluvit o rizicích výpadků. Který příkladový viewpoint je nejvhodnějším výchozím bodem?

- [ ] Technology viewpoint
- [ ] Application Structure viewpoint
- [ ] Information Structure viewpoint
- [x] Layered viewpoint

> Závislosti od procesů přes aplikace k infrastruktuře v jednom pohledu ukazuje Layered viewpoint. Technology viewpoint zůstává v technologické vrstvě, Application Structure ukazuje vnitřní skladbu aplikací a Information Structure datové struktury.

### ? Architekt připravil pro CIO pohled podle Layered viewpointu se 250 prvky včetně všech aplikačních funkcí a služeb. CIO se v něm nevyzná a ptá se jen na to, které procesy jsou ohrožené výpadkem klíčových platforem. Jaká úprava je nejlepší?

- [ ] Rozdělit pohled do deseti diagramů Layered se stejnou podrobností
- [x] Ponechat klíčové prvky, seskupit je a použít odvozené vztahy
- [ ] Doplnit k pohledu podrobnou legendu a všechny prvky ponechat
- [ ] Přepracovat pohled pro účel Designing s plnou notací všech prvků

> Pro přehled stačí klíčové procesy, aplikace a platformy, seskupení a odvozené vztahy, které vynechají mezilehlé funkce a služby; detail zůstává v modelu. Deset stejně podrobných diagramů ani legenda přeplnění neřeší a Designing je účel pro návrháře, ne pro CIO.

## Strategické viewpointy {#strategie-viewpointy .compare}

Viewpointy nad prvky Strategy slouží vedení a business architektům.

| Viewpoint | Co ukazuje | Typický concern |
|---|---|---|
| Strategy | přehled strategie: Course of Action, Capability, Value Stream, Resource, Outcome | Kam firma směřuje a čím toho dosáhne? |
| Capability Map | strukturovaný přehled schopností, často jako heat mapa (zralost, výkon, investice) | Které schopnosti jsou slabé a kam investovat? |
| Value Stream | hodnotový tok v etapách, podpůrné schopnosti a hodnotu pro stakeholdery | Jak vzniká hodnota pro zákazníka? |
| Outcome Realization | jak jsou výsledky (Outcome) dosaženy schopnostmi a prvky Core | Přinesou investice slíbený výsledek? |
| Resource Map | strukturovaný přehled zdrojů (Resource) a jejich vazby na schopnosti | Jaké zdroje máme a k čemu slouží? |

### ? Strategický ředitel výrobní firmy chce na jedné stránce vidět všechny schopnosti firmy uspořádané podle oblastí a barevně odlišené podle zralosti, aby určil, kam směřovat investice. Který viewpoint je nejvhodnější?

- [x] Capability Map viewpoint
- [ ] Value Stream viewpoint
- [ ] Resource Map viewpoint
- [ ] Goal Realization viewpoint

> Strukturovaný přehled schopností, typicky jako heat mapa podle zralosti či výkonu, je Capability Map. Value Stream ukazuje etapy tvorby hodnoty, Resource Map zdroje a Goal Realization rozpad cílů na požadavky.

### ? Vedení pojišťovny chce pochopit, jak vzniká hodnota pro klienta od nahlášení škody po výplatu plnění — v jednotlivých etapách a s tím, které schopnosti každou etapu podporují. Který viewpoint je nejvhodnější?

- [ ] Capability Map viewpoint
- [ ] Business Process Cooperation viewpoint
- [x] Value Stream viewpoint
- [ ] Outcome Realization viewpoint

> Etapy tvorby hodnoty a schopnosti, které je podporují, ukazuje Value Stream viewpoint. Capability Map nemá pořadí etap, Business Process Cooperation zachycuje procesy a jejich vazby místo hodnotových etap a Outcome Realization vazbu výsledků na schopnosti.

### ? Sponzor investice do digitalizace úvěrů chce vidět, kterými schopnostmi a aplikacemi bude dosažen slíbený výsledek „doba schválení úvěru do 1 dne". Který viewpoint je nejvhodnější?

- [ ] Resource Map viewpoint
- [x] Outcome Realization viewpoint
- [ ] Capability Map viewpoint
- [ ] Requirements Realization viewpoint

> Vazbu výsledku (Outcome) na schopnosti a prvky Core, které ho přinesou, ukazuje Outcome Realization viewpoint. Resource Map mapuje zdroje, Capability Map dává přehled schopností bez vazby na výsledek a Requirements Realization ukazuje pokrytí požadavků prvky Core, ne cestu schopnostmi k měřitelnému výsledku.

## Motivační viewpointy {#motivace-viewpointy .compare}

Viewpointy nad prvky Motivation propojují „proč" s „co".

| Viewpoint | Co ukazuje | Kdy po něm sáhnout |
|---|---|---|
| Stakeholder | stakeholdery, jejich drivers, assessments a počáteční cíle | na začátku iniciativy: kdo má zájem a proč |
| Goal Realization | zpřesnění cílů na konkrétnější cíle, principy a požadavky | rozpad strategického cíle na zadání |
| Requirements Realization | které prvky Core požadavky realizují | trasovatelnost, kontrola pokrytí požadavků |
| Motivation | motivační aspekt celkově nebo jeho část a vztahy mezi prvky | celkový obraz motivace |

### ? Na začátku programu digitalizace chce architekt s vedením projít, které skupiny (regulátor, zákazníci, odbory) mají na programu zájem, jaké hnací síly za nimi stojí a jak je hodnocen současný stav. Který viewpoint je nejvhodnější?

- [ ] Goal Realization viewpoint
- [ ] Requirements Realization viewpoint
- [ ] Organization viewpoint
- [x] Stakeholder viewpoint

> Stakeholdery, jejich drivers a assessments ukazuje Stakeholder viewpoint. Goal Realization a Requirements Realization navazují až v dalších krocích (cíle a požadavky) a Organization viewpoint zachycuje vnitřní organizační strukturu, ne zájmy a hnací síly.

### ? Vedení e-shopu stanovilo cíl „Zvýšit spokojenost zákazníků". Architekt má s business analytiky tento cíl rozpadnout na konkrétnější cíle, principy a požadavky, z nichž vznikne zadání projektů. Který viewpoint je nejvhodnější?

- [x] Goal Realization viewpoint
- [ ] Stakeholder viewpoint
- [ ] Capability Map viewpoint
- [ ] Requirements Realization viewpoint

> Zpřesňování cílů na konkrétnější cíle, principy a požadavky je náplní Goal Realization viewpointu. Stakeholder viewpoint končí u zájmů a hnacích sil, Capability Map ukazuje schopnosti a Requirements Realization navazuje až potom — ukazuje, které prvky Core už hotové požadavky realizují.

## Auditor a compliance: trasovatelnost {#auditor-trasovatelnost .explain}

Auditor ani compliance officer nenavrhují řešení — potřebují **doložit**, že požadavek (regulace, interní politika) je skutečně pokryt konkrétními prvky architektury. Výchozím bodem je **Requirements Realization viewpoint**: Requirement a prvky Core, které ho realizují. Často je vhodná tabulková forma (požadavek × prvek), kterou lze přiložit k auditní zprávě. Pokud concern spojuje motivaci s daty, technologií a umístěním (např. kde se zpracovávají osobní údaje), je namístě vlastní viewpoint s přesně vybranými typy prvků.

*Příklad:* `Šifrovaná DB (Technology Service) —realization→ Šifrovat osobní údaje při uložení (Requirement)`.

### ? Interní auditor ověřuje, zda je požadavek „Osobní údaje klientů se při uložení šifrují" (Requirement) skutečně pokryt. Chce vidět, které aplikační komponenty a technologické služby tento požadavek realizují. Který viewpoint je nejvhodnější?

- [ ] Goal Realization viewpoint
- [ ] Technology Usage viewpoint
- [x] Requirements Realization viewpoint
- [ ] Implementation and Deployment viewpoint

> Vazbu požadavků na prvky Core, které je realizují, ukazuje Requirements Realization viewpoint. Goal Realization končí u rozpadu cílů na požadavky, Technology Usage ukazuje závislost aplikací na technologii a Implementation and Deployment nasazení aplikací přes artifacty na nody — oba bez vazby na požadavek, který má auditor ověřit.

### ? Auditor ochrany osobních údajů chce vědět, které aplikace zpracovávají osobní údaje (Data Object) a ve kterých zemích (Location) běží servery, na nichž jsou nasazeny. Žádný příkladový viewpoint tuto kombinaci přesně nepokrývá. Jak má architekt postupovat?

- [ ] Použít Layered viewpoint beze změny a ukázat v něm celý model
- [x] Definovat vlastní viewpoint s potřebnými prvky a vhodnou formou
- [ ] Použít Physical viewpoint, protože pracuje se zeměmi a budovami
- [ ] Odmítnout požadavek, protože povolené jsou jen příkladové viewpointy

> Příkladové viewpointy nejsou povinné — pro specifický concern se definuje vlastní viewpoint (Data Object, Application Component, Node, Location a forma, třeba tabulka). Celý model v Layered pohledu concern utopí, Physical viewpoint ukazuje zařízení, budovy a fyzické sítě, ne aplikace a data.

## Organizace a produkt {#organizace-a-produkt .explain}

**Organization viewpoint** ukazuje strukturu organizace — aktéry, role, spolupráce (collaborations), umístění a rozhraní; hodí se pro linové a personální manažery a business architekty při reorganizaci nebo popisu odpovědností. **Product viewpoint** ukazuje, co produkt nabízí: z jakých služeb se skládá, jaký kontrakt (Contract) k němu patří a jakou hodnotu přináší; je určen produktovým a obchodním manažerům. Oba stojí převážně v Business Layer, liší se concernem: „kdo jsme a kdo za co odpovídá" × „co prodáváme a z čeho to je".

*Příklad:* `Rodina+ (Product) —aggregation→ Sdílená data (Business Service)` a `Rodina+ (Product) —aggregation→ Smluvní podmínky Rodina+ (Contract)`.

### ? Personální ředitel logistické firmy připravuje reorganizaci: sloučení dvou divizí, nové týmy a přerozdělení rolí mezi lidmi a odděleními. Potřebuje pohled na organizační uspořádání a odpovědnosti. Který viewpoint je nejvhodnější?

- [x] Organization viewpoint
- [ ] Business Process Cooperation viewpoint
- [ ] Product viewpoint
- [ ] Stakeholder viewpoint

> Organizační strukturu — aktéry, role, spolupráce a jejich vztahy — ukazuje Organization viewpoint. Business Process Cooperation se zaměřuje na vazby procesů, Product viewpoint na skladbu produktu a Stakeholder viewpoint na zájmy a hnací síly.

### ? Produktová manažerka telekomunikační firmy připravuje nový tarif „Rodina+". Chce vedení ukázat, z jakých služeb se tarif skládá, jaké smluvní podmínky k němu patří a jakou hodnotu přináší zákazníkovi. Který viewpoint je nejvhodnější?

- [ ] Service Realization viewpoint
- [ ] Organization viewpoint
- [ ] Value Stream viewpoint
- [x] Product viewpoint

> Skladbu produktu ze služeb, příslušný kontrakt a hodnotu ukazuje Product viewpoint. Service Realization se ptá, jak jsou služby uskutečněny procesy, Organization viewpoint popisuje organizaci a Value Stream etapy tvorby hodnoty, ne skladbu produktu.

## Vlastník procesu a služby {#procesni-viewpointy .explain}

Vlastník procesu se obvykle ptá na tři věci, a každá má jiný viewpoint. „S čím můj proces souvisí?" — **Business Process Cooperation viewpoint**: vazby procesu na ostatní procesy, služby a okolí včetně partnerů. „Které aplikace můj proces používá?" — **Application Usage viewpoint**: jak aplikace podporují procesy a aktéry. „Jak je služba, kterou nabízím, uskutečněna?" — **Service Realization viewpoint**: business služba a procesy (případně aplikace), které ji realizují. Volba se řídí concernem, ne funkcí stakeholdera.

*Příklad:* `CRM (Application Component) —serving→ Vyřízení reklamace (Business Process)` je typický obsah pohledu podle Application Usage viewpointu.

### ? Vlastník procesu „Vyřízení reklamace" v e-shopu chce vidět, na které další procesy jeho proces navazuje, jaké služby od nich přebírá a se kterými externími partnery (dopravce, výrobce) spolupracuje. Který viewpoint je nejvhodnější?

- [ ] Application Usage viewpoint
- [ ] Service Realization viewpoint
- [x] Business Process Cooperation viewpoint
- [ ] Application Cooperation viewpoint

> Vazby procesu na ostatní procesy, služby a okolí zachycuje Business Process Cooperation viewpoint. Application Usage ukazuje aplikační podporu, Service Realization uskutečnění jedné služby a Application Cooperation vazby mezi aplikacemi, ne mezi procesy a partnery.

### ? Vlastnice procesu fakturace plánuje školení a chce vědět, které aplikace její proces v jednotlivých krocích používá a kteří aktéři s nimi pracují. Který viewpoint je nejvhodnější?

- [ ] Application Cooperation viewpoint
- [x] Application Usage viewpoint
- [ ] Technology Usage viewpoint
- [ ] Application Structure viewpoint

> Jak aplikace podporují procesy a aktéry, ukazuje Application Usage viewpoint. Application Cooperation zachycuje vazby mezi aplikacemi navzájem, Technology Usage závislost aplikací na technologii a Application Structure vnitřní skladbu aplikace.

### ? Vlastník služby „Online sjednání pojištění" (Business Service) chce vedení ukázat, kterými procesy a s jakou aplikační podporou je služba zákazníkům skutečně uskutečňována. Který viewpoint je nejvhodnější?

- [ ] Product viewpoint
- [ ] Business Process Cooperation viewpoint
- [ ] Requirements Realization viewpoint
- [x] Service Realization viewpoint

> Jak je business služba realizována procesy (a případně aplikacemi), ukazuje Service Realization viewpoint. Product viewpoint skládá produkt ze služeb, Business Process Cooperation řeší vazby mezi procesy a Requirements Realization pokrytí požadavků.

## Aplikační a informační viewpointy {#aplikacni-viewpointy .compare}

Aplikační a datoví architekti volí podle toho, zda je zajímá jedna aplikace, vazby mezi aplikacemi, nebo data.

| Viewpoint | Co ukazuje | Typický stakeholder |
|---|---|---|
| Application Structure | vnitřní skladbu jedné či více aplikací: komponenty, rozhraní, data | aplikační architekt, vedoucí vývoje |
| Application Cooperation | vazby mezi aplikacemi: toky informací, služby, rozhraní | integrační architekt, správce portfolia aplikací |
| Application Usage | jak aplikace podporují procesy a aktéry | vlastník procesu, aplikační architekt |
| Information Structure | datové struktury: Business Object, Data Object, Artifact a vztahy mezi nimi | datový architekt, správce dat |

### ? Integrační architekt v bance mapuje, které aplikace si vyměňují data o klientech, jakým směrem informace tečou a přes jaké aplikační služby a rozhraní. Který viewpoint je nejvhodnější?

- [x] Application Cooperation viewpoint
- [ ] Application Structure viewpoint
- [ ] Information Structure viewpoint
- [ ] Implementation and Deployment viewpoint

> Toky informací a služby mezi aplikacemi ukazuje Application Cooperation viewpoint. Application Structure se dívá dovnitř aplikace, Information Structure na datové struktury bez toků a Implementation and Deployment na nasazení na technologii.

### ? Vedoucí vývoje v pojišťovně připravuje rozdělení monolitické aplikace „Smlouvy" a potřebuje pohled na její dílčí komponenty, jejich rozhraní a datové objekty, se kterými pracují. Který viewpoint je nejvhodnější?

- [ ] Application Cooperation viewpoint
- [ ] Application Usage viewpoint
- [x] Application Structure viewpoint
- [ ] Technology viewpoint

> Vnitřní skladbu aplikace — komponenty, rozhraní a data — ukazuje Application Structure viewpoint. Application Cooperation řeší vazby mezi aplikacemi, Application Usage podporu procesů a Technology viewpoint infrastrukturu.

### ? Správkyně dat v e-shopu chce ukázat, jak business objekt „Objednávka" souvisí s datovými objekty v aplikacích a se soubory a tabulkami, které je fyzicky ukládají. Který viewpoint je nejvhodnější?

- [ ] Application Structure viewpoint
- [x] Information Structure viewpoint
- [ ] Application Cooperation viewpoint
- [ ] Service Realization viewpoint

> Vztahy mezi Business Object, Data Object a Artifact jsou náplní Information Structure viewpointu. Application Structure se soustředí na komponenty, Application Cooperation na toky mezi aplikacemi a Service Realization na uskutečnění služeb.

## Technické viewpointy pro provoz {#technicke-viewpointy .compare}

Provoz, infrastrukturní architekti a vlastníci aplikací se ptají na různé věci.

| Viewpoint | Co ukazuje | Typický stakeholder |
|---|---|---|
| Technology | technologické prvky: Node, Device, System Software, sítě a cesty | provoz infrastruktury, infrastrukturní architekt |
| Technology Usage | jak aplikace využívají technologické služby a infrastrukturu | vlastník aplikace, provoz, správce kapacit |
| Implementation and Deployment | jak jsou aplikace realizovány artifacty a nasazeny na technologii | release manažer, provoz, vývoj |
| Physical | fyzické prostředí: Equipment, Facility, Distribution Network, Material | vedoucí výroby či logistiky, správa budov |

### ? Tým provozu infrastruktury v nemocnici přebírá nové datové centrum a potřebuje přehled serverů, síťových prvků, operačních systémů a databázových platforem a toho, jak jsou propojeny sítěmi. Který viewpoint je nejvhodnější?

- [ ] Technology Usage viewpoint
- [ ] Physical viewpoint
- [ ] Application Structure viewpoint
- [x] Technology viewpoint

> Technologické prvky (Node, Device, System Software) a sítě mezi nimi ukazuje Technology viewpoint. Technology Usage se zaměřuje na to, jak aplikace technologii využívají, Physical na fyzická zařízení a budovy a Application Structure na aplikace.

### ? Vlastník aplikace „Objednávky" se chystá jednat s provozem o změně databázové platformy. Potřebuje vidět, na kterých technologických službách (databáze, fronta zpráv, úložiště) jeho aplikace závisí. Který viewpoint je nejvhodnější?

- [x] Technology Usage viewpoint
- [ ] Technology viewpoint
- [ ] Application Cooperation viewpoint
- [ ] Information Structure viewpoint

> Závislost aplikací na technologických službách ukazuje Technology Usage viewpoint. Technology viewpoint popisuje infrastrukturu samotnou bez vazby na aplikace, Application Cooperation vazby mezi aplikacemi a Information Structure datové struktury.

### ? Release manažer potřebuje pro nasazení nové verze vědět, které spustitelné soubory a konfigurace (Artifact) realizují jednotlivé aplikační komponenty a na kterých serverech (Node) jsou nasazeny. Který viewpoint je nejvhodnější?

- [ ] Application Structure viewpoint
- [ ] Implementation and Migration viewpoint
- [x] Implementation and Deployment viewpoint
- [ ] Technology Usage viewpoint

> Mapování aplikací na artifacty a jejich nasazení na technologii je náplní Implementation and Deployment viewpointu. Application Structure končí u komponent, Implementation and Migration propojuje projekty s plateaus a prvky architektury (řízení změny, ne nasazení) a Technology Usage ukazuje, které technologické služby aplikace využívají, bez artifactů.

### ? Logistická firma plánuje nové distribuční centrum. Vedoucí logistiky chce vidět sklady (Facility), třídicí linky (Equipment), přepravní trasy mezi sklady (Distribution Network) a tok zboží (Material). Který viewpoint je nejvhodnější?

- [ ] Technology viewpoint
- [x] Physical viewpoint
- [ ] Organization viewpoint
- [ ] Technology Usage viewpoint

> Equipment, Facility, Distribution Network a Material jsou fyzické prvky, které ukazuje Physical viewpoint. Technology viewpoint zachycuje IT infrastrukturu, Organization viewpoint organizační strukturu a Technology Usage závislost aplikací na technologii.

## Projekty a migrace {#migrace-viewpointy .compare}

Viewpointy nad prvky Implementation & Migration slouží řízení změny.

| Viewpoint | Co ukazuje | Typický stakeholder |
|---|---|---|
| Project | řízení změny: Work Package, Deliverable, kdo za ně odpovídá (role, aktéři), případně Implementation Event | projektový a programový manažer |
| Migration | přechod mezi stavy architektury: Plateaus a Gaps mezi nimi | programová rada, enterprise architekt |
| Implementation and Migration | jak programy a projekty dodávají části architektury: Work Package, Deliverable, Plateau a prvky Core | portfolio manažer, enterprise architekt |

### ? Projektová manažerka migrace CRM potřebuje přehled, z jakých Work Packages se projekt skládá, jaké Deliverables vzniknou a které role za jednotlivé balíky odpovídají. Který viewpoint je nejvhodnější?

- [ ] Migration viewpoint
- [x] Project viewpoint
- [ ] Implementation and Deployment viewpoint
- [ ] Organization viewpoint

> Work Packages, Deliverables a odpovědné role jsou obsahem Project viewpointu. Migration viewpoint ukazuje Plateaus a Gaps, Implementation and Deployment nasazení aplikací na technologii a Organization viewpoint organizační strukturu bez projektové práce.

### ? Programová rada banky chce vidět, jakými stabilními mezistavy architektura projde od současného stavu k cílovému a co se mezi jednotlivými stavy mění. Detail projektů ji teď nezajímá. Který viewpoint je nejvhodnější?

- [ ] Project viewpoint
- [ ] Implementation and Migration viewpoint
- [ ] Layered viewpoint
- [x] Migration viewpoint

> Posloupnost Plateaus (Baseline, Transition, Target) a Gaps mezi nimi ukazuje Migration viewpoint. Project viewpoint a Implementation and Migration přidávají práci projektů, kterou rada teď nepotřebuje, a Layered viewpoint popisuje jeden stav, ne přechod.

### ? Portfolio manažer pojišťovny potřebuje vidět, které projekty (Work Packages) dodávají které části cílové architektury a ke kterému Plateau jejich výstupy patří, aby odhalil překryvy a nepokrytá místa. Který viewpoint je nejvhodnější?

- [x] Implementation and Migration viewpoint
- [ ] Project viewpoint
- [ ] Migration viewpoint
- [ ] Implementation and Deployment viewpoint

> Propojení projektů a jejich Deliverables s Plateaus a prvky architektury je náplní Implementation and Migration viewpointu. Project viewpoint zůstává u řízení projektu, Migration viewpoint u stavů bez projektů a Implementation and Deployment u nasazení aplikací na technologii, ne u projektů.

## Tvorba vlastního viewpointu {#vlastni-viewpoint .explain}

Příkladové viewpointy pokrývají běžné situace, ale nejsou povinné. Vlastní viewpoint je namístě, když concern nepokrývá žádný z nich nebo je potřeba některý zúžit či zkombinovat. Definice má obsahovat: stakeholdery a concerns, účel a úroveň, **povolené typy prvků a vztahů** (výběr z existujícího jazyka, případně specializace), **formu reprezentace** (diagram, tabulka, katalog, ilustrace) a konvence (rozložení, barvy, legenda). Vlastní viewpoint nevytváří nový jazyk — vybírá a uspořádává existující koncepty.

*Příklad:* viewpoint „Zpracování osobních údajů": stakeholder pověřenec pro ochranu osobních údajů; prvky Data Object, Application Component, Node, Location; forma tabulka a mapa.

### ? Architekt chce pro opakované posuzování bezpečnosti definovat vlastní viewpoint, aby různí autoři tvořili srovnatelné pohledy. Co má definice viewpointu obsahovat?

- [ ] Seznam konkrétních aplikací a serverů, které v pohledu budou
- [ ] Nové typy prvků a novou vrstvu vyhrazenou pro bezpečnost
- [x] Stakeholdery, concerns, účel, povolené prvky a vztahy a formu
- [ ] Jen název viewpointu a jméno architekta, který ho schválil

> Viewpoint je předpis: pro koho a k čemu, z jakých typů prvků a vztahů a v jaké formě. Seznam konkrétních prvků patří až do pohledu, nová vrstva jazyka se nevytváří (nanejvýš specializace) a samotný název srovnatelnost pohledů nezajistí.

### ? Architekt připravuje pro vedení obchodu viewpoint, který kombinuje produkty, business služby a aplikace, jež je podporují. Kolega namítá, že takový viewpoint mezi příkladovými ve specifikaci není, a proto ho nelze použít. Kdo má pravdu?

- [x] Architekt: příkladové viewpointy nejsou povinné a vlastní je legitimní
- [ ] Kolega: ArchiMate povoluje jen viewpointy uvedené ve specifikaci
- [ ] Kolega: pro kombinaci vrstev je nutné vždy použít Layered viewpoint
- [ ] Architekt, ale jen pokud jazyk rozšíří o novou vrstvu pro produkty

> Viewpoint Mechanism počítá s tím, že si organizace definuje viewpointy podle svých stakeholderů; příkladové jsou jen inspirace. Layered viewpoint není jediná cesta ke kombinaci vrstev a nová vrstva jazyka k tomu potřeba není.

## Forma reprezentace podle účelu {#forma-reprezentace .explain}

Viewpoint určuje nejen obsah, ale i **formu**. Pro Designing je správná plná notace ArchiMate. Pro Deciding bývá lepší tabulka, křížový přehled nebo mapa, kde jsou prvky uspořádané a odlišené podle atributu (náklady, stáří, riziko) — barvu je vhodné doplnit popiskem nebo hodnotou. Pro Informing jsou vhodné zjednodušené obrázky, ikony a krátký text. Pod všemi formami je stále tentýž model; mění se jen výběr a zobrazení.

*Příklad:* stejné aplikace z modelu: pro vývoj diagram Application Cooperation, pro vedení tabulka aplikací s náklady a životním cyklem.

### ? Vedení distribuční firmy má rozhodnout, které ze 40 aplikací vyřadit. Architekt má v modelu u každé aplikace atributy (roční náklady, stáří, počet uživatelů) a vztahy serving k procesům. Jaká forma pohledu nejlépe poslouží?

- [ ] Detailní diagram Application Structure ke každé ze čtyřiceti aplikací
- [x] Přehledná tabulka či mapa aplikací s atributy a podporovanými procesy
- [ ] Jednoduchý leták pro zaměstnance s ikonami nejpoužívanějších aplikací
- [ ] Pohled Implementation and Deployment se všemi servery a artifacty

> Rozhodování (Deciding) podpoří přehled, který vedle sebe ukáže rozhodovací atributy a dopad na procesy. Čtyřicet detailních diagramů je forma pro návrh, leták slouží informování a nasazení na servery na otázku vyřazení přímo neodpovídá.

## Typické chyby při práci s pohledy {#chyby-pohledu .explain}

Nejčastější chyby: **jeden pohled pro všechny** (každý stakeholder v něm hledá něco jiného), **přeplněný pohled** bez výběru podle concernu, **míchání účelů** (návrhový detail v podkladu pro rozhodnutí), volba viewpointu podle toho, co nástroj nabízí, místo podle stakeholdera, a **kopie pohledů mimo model** (obrázky v prezentaci zastarají, protože se neaktualizují s modelem). Správně: jeden model, z něj pro každou skupinu stakeholderů pohled podle odpovídajícího viewpointu.

*Příklad:* z téhož modelu e-shopu vznikne Layered pohled pro CIO, Application Cooperation pro integraci a Technology pro provoz.

### ? Architekt e-shopu připravil jediný velký pohled podle Layered viewpointu a chce ho ukazovat CIO, vývojářům i provozu infrastruktury, „aby všichni viděli totéž". Jaký je nejlepší postup?

- [ ] Ponechat jeden pohled, protože jednotný obraz zabrání nedorozumění
- [ ] Ponechat jeden pohled a doplnit do něj všechny detaily pro každou skupinu
- [x] Z téhož modelu připravit každé skupině pohled podle jejích concerns
- [ ] Vytvořit pro každou skupinu samostatný model s vlastními prvky

> Různí stakeholdeři mají různé concerns, a proto potřebují různé pohledy — ale nad jedním společným modelem, aby zůstaly konzistentní. Jeden pohled pro všechny buď nic neřekne, nebo bude přeplněný, a samostatné modely vytvoří duplicity a rozpory.
