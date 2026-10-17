---
kind: topic
subject: archimate-practitioner
slug: strategie-a-motivace-praxe
name: "Strategie a motivace ve scénářích"
order: 5
---

Capability mapping, value streams, odvození požadavků z driverů a cílů, vazba na TOGAF Phase A.

## Kdy modelovat Capability {#capability-kdy .explain}

Capability (schopnost) vyjadřuje, **co** podnik umí nebo potřebuje umět, bez ohledu na to, kdo a jak to dělá. Hodí se tam, kde vedení plánuje investice, porovnává zralost oblastí nebo hledá duplicity napříč útvary — tedy na strategické úrovni, která má přežít reorganizace i výměnu systémů. Název bývá podstatné jméno („Správa pojistných smluv"), ne popis kroků. Pokud scénář popisuje spouštěč, posloupnost činností a výsledek, jde o Business Process; pokud popisuje, co podnik vlastní (lidi, data, peníze), jde o Resource. Capability v modelu realizují prvky chování z Core vrstev.

*Příklad:* Likvidace škody (Business Process) —realization→ Správa pojistných událostí (Capability)

### ? Pojišťovna připravuje pětiletou investiční strategii. Představenstvo chce vidět, které oblasti činnosti jsou pro konkurenceschopnost klíčové a kde je nízká zralost, a to nezávisle na tom, které oddělení je dnes zajišťuje. Organizační struktura se má příští rok změnit. Který typ prvku je pro oblasti jako „Upisování rizik" nebo „Správa pojistných událostí" nejvhodnější?

- [x] Capability, protože vyjadřuje, co podnik umí, nezávisle na organizaci a procesech
- [ ] Business Function, protože seskupuje činnosti podle útvarů, které je dnes vykonávají
- [ ] Business Process, protože každá oblast končí výsledkem pro klienta pojišťovny
- [ ] Resource, protože jde o aktiva, která pojišťovna vlastní a jejichž využití řídí

> Capability je stabilní, na organizaci nezávislý popis toho, co podnik umí — ideální pro investiční plánování a hodnocení zralosti. Business Function je konkrétní chování Business Layer přiřazené rolím a aktérům (a funkce neseskupují činnosti podle útvarů, ale podle kompetencí), proces popisuje posloupnost kroků a Resource zachycuje aktiva, ne schopnosti.

### ? Architekt banky zapsal do mapy schopností capability „Ověřit totožnost klienta, zkontrolovat sankční seznamy a založit účet". Kolega namítá, že prvek v této podobě do mapy schopností nepatří. Jaká úprava je nejlepší?

- [ ] Ponechat prvek jako Capability a jednotlivé kroky k ní připojit jako části vztahem composition
- [x] Kroky modelovat jako Business Process, který realizuje capability „Onboarding klienta"
- [ ] Prvek převést na Value Stream, protože popisuje posloupnost kroků až k výsledku
- [ ] Prvek převést na Course of Action, protože popisuje postup, jak dosáhnout cíle

> Popis s posloupností kroků je chování, tedy Business Process; do mapy patří stabilní schopnost „Onboarding klienta", kterou proces realizuje. Kroky jako části capability by mapu zaplnily procesy, Value Stream popisuje fáze tvorby hodnoty pro stakeholdera na strategické úrovni (ne kontrolu sankčních seznamů) a Course of Action je strategická volba, ne pracovní postup.

## Capability × Business Function × Business Process {#capability-vs-function .compare}

Tři prvky se ve scénářích často pletou. Rozhoduje, zda popisujeme strategickou schopnost, trvalé seskupení chování v organizaci, nebo průběh s výsledkem.

| | Capability | Business Function | Business Process |
|---|---|---|---|
| Vrstva | Strategy | Business | Business |
| Otázka | Co podnik umí (a jak dobře)? | Jaké chování organizace trvale vykonává podle kompetencí? | Jak probíhá posloupnost kroků k výsledku? |
| Časový průběh | žádný, stabilní v čase | žádný, průběžná činnost | začátek, pořadí kroků, konec |
| Typické použití | capability map, heatmapa zralosti, investice | funkční rozklad, přiřazení rolí a aplikací | optimalizace, automatizace, spouštění událostmi |
| Vazba na strategii | realizují ji Core prvky chování | může realizovat capability | může realizovat capability |
| Typická chyba | pojmenovat ji jako postup | zaměnit ji za útvar organizace | modelovat ho bez spouštěče a výsledku |

### ? Výrobní firma má v modelu Business Function „Nákup", ke které je přiřazena role Nákupčí. Strategický tým chce hodnotit, jak dobře firma zvládá „Řízení dodavatelů", a plánovat investice do této oblasti nezávisle na tom, jak je nákup organizován. Funkce Nákup tuto schopnost dnes zajišťuje. Který fragment modelu to zachytí nejlépe?

- [x] Nákup (Business Function) —realization→ Řízení dodavatelů (Capability)
- [ ] Řízení dodavatelů (Capability) —realization→ Nákup (Business Function)
- [ ] Nákup (Business Function) —composition→ Řízení dodavatelů (Business Function)
- [ ] Řízení dodavatelů (Capability) —assignment→ Nákup (Business Function)

> Capability realizují prvky chování z Core vrstev, takže realizace vede od funkce ke capability. Opačný směr nedává smysl, další Business Function by nebyla strategickým prvkem nezávislým na organizaci a assignment přiřazuje aktivní strukturu k chování, ne capability k funkci.

### ? Logistická firma popisuje „Vychystání objednávky": přijde objednávka, skladník vychystá zboží, kontrolor zkontroluje balení a zásilka se předá dopravci. Firma chce tento průběh zrychlit a částečně automatizovat. Jaký typ prvku je pro „Vychystání objednávky" nejvhodnější?

- [ ] Capability, protože jde o schopnost, kterou firma potřebuje pro svůj provoz
- [ ] Business Function, protože ji role skladu vykonávají průběžně každý den
- [x] Business Process, protože má spouštěč, pořadí kroků a jasný výsledek
- [ ] Value Stream, protože popisuje cestu zboží od skladu až k zákazníkovi

> Scénář popisuje spouštěč (příchod objednávky), posloupnost kroků a výsledek (předaná zásilka) a cílem je optimalizace průběhu — to je Business Process. Capability ani funkce nemají časový průběh a Value Stream modeluje fáze tvorby hodnoty na strategické úrovni, ne operativní kroky skladu.

## Capability map v praxi {#capability-mapa .explain}

Capability map rozkládá schopnosti podniku do úrovní (typicky 2–3): vyšší capability se skládá z dílčích vztahem composition, případně aggregation, pokud dílčí schopnost sdílí více nadřazených. V mapě jsou jen capabilities; procesy, aplikace a útvary patří do jiných pohledů nebo se k mapě připojují realizací. Hodnocení (zralost, strategický význam) se zachycuje vlastnostmi capability (profilem) nebo prvkem Assessment, který je s capability asociován; barevná heatmapa je jen způsob zobrazení — barvy v ArchiMate nemají normativní význam. Pro takový pohled slouží příkladový Capability Map viewpoint.

*Příklad:* Řízení vztahů se zákazníky (Capability) —composition→ Segmentace zákazníků (Capability); Nízká kvalita zákaznických dat (Assessment) —association→ Segmentace zákazníků (Capability)

### ? Telekomunikační operátor vytváří mapu schopností pro strategický workshop. Capability „Řízení zákaznické péče" má mít dílčí schopnosti „Obsluha požadavků", „Řešení stížností" a „Věrnostní program". Architekt chce rozklad zachytit tak, aby mapa zůstala čistě strategická. Který fragment je nejvhodnější?

- [ ] Řízení zákaznické péče (Business Function) —composition→ Řešení stížností (Business Process)
- [x] Řízení zákaznické péče (Capability) —composition→ Řešení stížností (Capability)
- [ ] Řešení stížností (Capability) —composition→ Řízení zákaznické péče (Capability)
- [ ] Řízení zákaznické péče (Capability) —triggering→ Řešení stížností (Capability)

> Hierarchie mapy schopností se modeluje kompozicí (nebo agregací) od celku k části mezi prvky Capability. Funkce a proces patří do Business Layer, obrácený směr by z celku udělal část a triggering vyjadřuje časovou návaznost, nikoli rozklad.

### ? CIO banky chce v mapě schopností vyznačit, že capability „Správa úvěrů" má nízkou zralost, protože běží na zastaralém systému. Zjištění má být v modelu dohledatelné pro další analýzy, ne jen jako barva v prezentaci. Jaké řešení je nejlepší?

- [ ] Obarvit capability červeně a do legendy pohledu dopsat význam barvy
- [ ] Vytvořit Goal „Nízká zralost správy úvěrů" a asociovat ho s capability
- [ ] Rozdělit capability na dvě části: zralou a nezralou správu úvěrů
- [x] Asociovat s capability Assessment „Nízká zralost – zastaralý systém"

> Zjištění z analýzy je Assessment a jeho asociace s capability ho činí součástí modelu (alternativou je atribut zralosti v profilu capability). Barva sama nemá v ArchiMate normativní význam, Goal vyjadřuje žádoucí stav, ne zjištění, a dělení capability podle zralosti rozbíjí stabilní mapu.

## Propojení capability s Core vrstvami {#capability-realizace .explain}

Capability je abstraktní, a proto se do architektury „ukotvuje" realizací: prvky chování z Business, Application i Technology Layer (proces, funkce, aplikační funkce…) capability realizují. Prvky struktury (aktér, aplikační komponenta, data object, node) se ke strategické úrovni vážou přes Resource, který realizují; Resource je pak přiřazen ke capability vztahem assignment. Vznikne tak řetězec od strategie k implementaci, na kterém je vidět, které systémy podporují kterou schopnost a kam investice dopadnou. Ve scénářích se nejčastěji chybuje obráceným směrem (capability „realizuje" proces) nebo záměnou realizace za assignment či composition.

*Příklad:* Výpočet skóre (Application Function) —realization→ Posuzování úvěrového rizika (Capability); Scoringový systém (Application Component) —realization→ Scoringové modely (Resource) —assignment→ Posuzování úvěrového rizika (Capability)

### ? Banka chce na strategickém pohledu ukázat, že capability „Posuzování úvěrového rizika" je v praxi zajištěna aplikační funkcí „Výpočet skóre" scoringového systému. Investiční výbor se podle modelu rozhoduje, kam směřovat peníze. Který fragment je správný?

- [ ] Posuzování úvěrového rizika (Capability) —realization→ Výpočet skóre (Application Function)
- [ ] Posuzování úvěrového rizika (Capability) —assignment→ Výpočet skóre (Application Function)
- [ ] Výpočet skóre (Application Function) —access→ Posuzování úvěrového rizika (Capability)
- [x] Výpočet skóre (Application Function) —realization→ Posuzování úvěrového rizika (Capability)

> Capability realizují prvky chování z Core vrstev, včetně aplikačních funkcí, a vztah vede od realizujícího prvku ke capability. Obrácený směr i assignment jsou chybné a access se používá jen pro přístup chování k pasivním prvkům (datům, objektům).

### ? Architekt e-shopu modeluje, jak se strategie promítá do architektury. Capability „Personalizace nabídky" potřebuje zákaznická data a doporučovací engine; engine i data už v modelu existují jako Application Component a Data Object. Jak nejlépe zachytit, že tyto Core prvky jsou zdroje, o které se capability opírá?

- [x] Engine a data realizují Resource a ten je přiřazen ke capability
- [ ] Engine a data připojit ke capability vztahem composition jako části
- [ ] Engine a data namodelovat jako Capability nižší úrovně v mapě
- [ ] Engine a data připojit ke capability vztahem triggering jako vstupy

> Prvky struktury z Core vrstev se ke strategii vážou přes Resource, který realizují, a Resource je pak ke capability přiřazen (Resource —assignment→ Capability). Kompozice by z aplikace udělala součást abstraktní schopnosti, převod na capability míchá strategii s implementací a triggering je dynamický vztah mezi prvky chování.

## Resource ve scénářích {#resource-kdy .explain}

Resource je aktivum, které podnik vlastní nebo ovládá a které capabilities potřebují: lidé a jejich know-how, data, značka, licence, finance, stroje. Modeluje se tehdy, když strategická otázka zní „máme na to zdroje?" — při plánování kapacit, investic nebo rizika ztráty klíčového aktiva. Konkrétní Core prvky (Business Actor, Application Component, Data Object, Equipment…) mohou Resource realizovat, takže jeden Resource „Zákaznická data" může být realizován několika databázemi. Ke capability, která zdroj potřebuje, se Resource přiřazuje vztahem assignment. Typická chyba je modelovat jako Resource činnost („Údržba strojů" je capability nebo funkce) nebo budoucí stav („Nové datové centrum za dva roky" patří do plánu přechodu).

*Příklad:* Flotila nákladních vozů (Equipment) —realization→ Přepravní kapacita (Resource) —assignment→ Distribuce zboží (Capability)

### ? Dopravní společnost zvažuje expanzi do Polska. Strategický tým potřebuje zjistit, zda má dost řidičů s mezinárodní licencí, a tuto kapacitu porovnat s potřebami capability „Mezinárodní přeprava". Řidiči jsou v modelu jako Business Actor a Resource „Kapacita řidičů s licencí" je ke capability už přiřazen vztahem assignment. Jak k němu připojit řidiče?

- [ ] Řidiči (Business Actor) —assignment→ Mezinárodní přeprava (Capability)
- [ ] Kapacita řidičů s licencí (Resource) —realization→ Řidiči (Business Actor)
- [x] Řidiči (Business Actor) —realization→ Kapacita řidičů s licencí (Resource)
- [ ] Kapacita řidičů s licencí (Resource) —serving→ Řidiči (Business Actor)

> Prvek struktury z Core vrstev se ke strategii váže tak, že realizuje Resource: řidiči realizují kapacitu, která je přiřazena ke capability a lze ji porovnat s jejími potřebami. Assignment aktéra rovnou ke capability obchází zdroj, ke kterému se mají řidiči připojit, obrácená realizace by z konkrétních řidičů udělala abstrakci zdroje a serving od zdroje k aktérovi nevyjadřuje, že řidiči kapacitu tvoří.

### ? Ve výrobní firmě odcházejí do důchodu tři technologové, kteří jako jediní znají receptury speciálních slitin. Vedení chce v modelu zachytit riziko ztráty tohoto know-how a jeho dopad na capability „Výroba speciálních slitin". Který typ prvku je pro „know-how receptur" nejvhodnější?

- [ ] Business Object, protože receptury jsou informace pro výrobní procesy
- [x] Resource, protože jde o aktivum, které firma ovládá a capability ho potřebuje
- [ ] Capability, protože znalost receptur je schopnost, kterou firma potřebuje
- [ ] Business Role, protože know-how je vázáno na roli technologa ve výrobě

> Know-how je nehmotné aktivum, na kterém capability stojí — to vyjadřuje Resource, ke kterému lze asociovat Assessment o riziku. Business Object by zachytil jen dokument s recepturou, ne znalosti lidí; capability je samotná výroba slitin a role popisuje odpovědnost, ne aktivum.

## Value Stream ve scénářích {#value-stream-kdy .explain}

Value Stream zachycuje na strategické úrovni posloupnost fází (stages), kterými podnik vytváří hodnotu pro konkrétního stakeholdera — od jeho podnětu po výsledek, který ocení. Fáze se zpravidla modelují jako vnořené prvky Value Stream (composition) a jejich pořadí vztahem triggering, případně flow, pokud mezi nimi putuje hodnota. Jednotlivým fázím mohou sloužit (serving) capabilities, takže vznikne propojení „kde vzniká hodnota" × „co k tomu musíme umět". S Core vrstvami se fáze propojují realizací: proces může fázi realizovat přímo (Business Process —realization→ Value Stream), nebo realizovat capability, která fázi slouží. Fáze se pojmenovávají na vysoké úrovni (Posouzení, Sjednání); dobrou praxí je nevnořovat do nich detailní kroky, role ani systémy.

*Příklad:* Sjednání pojistky (Value Stream) —composition→ Posouzení rizika (Value Stream); Upisování rizik (Capability) —serving→ Posouzení rizika (Value Stream)

### ? Hypoteční banka chce pro představenstvo ukázat, jak vzniká hodnota pro klienta od žádosti o hypotéku po čerpání peněz. Pohled má mít čtyři fáze (Poptávka, Posouzení, Schválení, Čerpání) a u každé ukázat, které capabilities ji podporují. Detailní kroky a systémy nejsou žádoucí. Který fragment tomu nejlépe odpovídá?

- [x] Získání hypotéky (Value Stream) —composition→ Posouzení (Value Stream); Hodnocení bonity (Capability) —serving→ Posouzení (Value Stream)
- [ ] Získání hypotéky (Business Process) —composition→ Posouzení (Business Process); Hodnocení bonity (Capability) —realization→ Posouzení (Business Process)
- [ ] Získání hypotéky (Capability) —composition→ Posouzení (Capability); Hodnocení bonity (Capability) —triggering→ Posouzení (Capability)
- [ ] Získání hypotéky (Value Stream) —composition→ Posouzení (Value Stream); Posouzení (Value Stream) —serving→ Hodnocení bonity (Capability)

> Fáze tvorby hodnoty se modelují jako Value Stream rozložený na fáze a capabilities jednotlivým fázím slouží. Procesy jsou zbytečně detailní a capability procesy nerealizuje (je to naopak), rozklad capabilities nepopisuje tok hodnoty a varianta, kde fáze slouží capability, má obrácený směr vztahu serving.

### ? Architekt pojišťovny namodeloval Value Stream „Vyřízení škody" s fázemi Nahlášení, Posouzení a Výplata. Do fáze Posouzení vnořil prvky Likvidátor (Business Role), Systém likvidace (Application Component) a Kontrola dokumentů (Business Process). Co je na modelu nejvíc chybné?

- [ ] Fáze Value Streamu se mají modelovat jako samostatné prvky Capability, ne Value Stream
- [ ] Value Stream nemá mít fáze; má být jediným prvkem navázaným na stakeholdera
- [x] Fáze zůstávají strategické; procesy je realizují, role a aplikace do nich nepatří
- [ ] Fáze Výplata má být Business Event, protože jí celý tok hodnoty končí

> Value Stream je strategický prvek a dobrou praxí je nevnořovat do jeho fází role, aplikace ani procesy; proces může fázi realizovat (Business Process —realization→ Value Stream) nebo realizovat capability, která jí slouží, a role a aplikace se k procesu vážou až v Business a Application Layer. Fáze se modelují jako vnořené Value Streamy, rozklad na fáze je obvyklý a poslední fáze zůstává fází, ne událostí.

## Value Stream × Business Process {#value-stream-vs-process .compare}

Oba prvky mají pořadí a vedou k výsledku, ale odpovídají na jinou otázku a slouží jinému publiku.

| | Value Stream | Business Process |
|---|---|---|
| Vrstva | Strategy | Business |
| Pohled | hodnota pro stakeholdera, co každá fáze „přidá" | jak se práce skutečně provádí |
| Granularita | několik málo fází end-to-end | libovolně detailní kroky, rozhodování, výjimky |
| Kdo a čím | neuvádí role ani systémy | role, aktéři a aplikace jsou přiřazeni nebo slouží |
| Stabilita | mění se zřídka, nezávisí na organizaci | mění se s reorganizací a automatizací |
| Typické použití | strategie, Phase A, prioritizace capabilities | analýza, optimalizace, návrh automatizace |

### ? Ředitel e-shopu chce na workshopu se zakladateli probrat, ve kterých fázích cesty zákazníka „od výběru po vrácení zboží" firma ztrácí hodnotu a do kterých schopností investovat. Nechce vidět systémy ani konkrétní oddělení. Který přístup k modelování je nejvhodnější?

- [ ] Detailní Business Process s rolemi a aplikacemi pro každý krok objednávky
- [ ] Capability map bez vazby na cestu zákazníka, seřazená podle oddělení
- [ ] Business Function „Prodej" rozložená na podfunkce podle útvarů e-shopu
- [x] Value Stream s fázemi cesty zákazníka a capabilities, které jim slouží

> Otázka „kde vzniká a kde se ztrácí hodnota a do čeho investovat" je strategická — Value Stream s fázemi a capabilities, které jim slouží, na ni odpoví přímo. Proces s rolemi a aplikacemi je příliš detailní, samotná mapa schopností neukazuje cestu zákazníka a rozklad podle útvarů odporuje přání nevidět oddělení.

### ? Procesní analytik dostal Value Stream „Pořízení vozidla na leasing" a má na jeho základě navrhnout automatizaci schvalování žádostí včetně rozhodovacích bodů a přiřazení rolí. Jak má v modelu postupovat?

- [ ] Rozšířit fáze Value Streamu o rozhodovací body a přiřadit k nim role a aplikace
- [x] Navrhnout Business Process se spouštěči, kroky a rolemi a navázat ho přes capability
- [ ] Nahradit Value Stream prvkem Course of Action, který popisuje celý plán automatizace schvalování
- [ ] Vytvořit pro každou fázi Value Streamu samostatnou Business Function s rolemi

> Automatizace s rozhodovacími body a rolemi je úloha pro Business Process; se strategickou úrovní ho propojí capability (proces ji realizuje, capability slouží fázi), nebo proces fázi přímo realizuje. Value Stream nemá obsahovat role ani rozhodování, Course of Action je strategická volba a funkce nemají pořadí kroků.

## Course of Action ve scénářích {#course-of-action .explain}

Course of Action zachycuje zvolený přístup nebo plán, jak podnik nasadí své capabilities a resources, aby dosáhl cíle — strategii („Růst přes akvizice") nebo taktiku („Sleva za elektronickou fakturu"). Je to rozhodnutí *jak* jít k cíli, nikoli cíl sám (Goal) ani projekt, který ho provede (Work Package). V modelu se Course of Action navazuje na Goal nebo Outcome, ke kterému má vést, a na capabilities a resources, o které se opírá. Zvažuje-li vedení alternativní strategie, modeluje se každá jako samostatný Course of Action a porovnává se jejich dopad na tytéž cíle.

*Příklad:* Course of Action „Přechod zákazníků na samoobsluhu" vede k Outcome „Náklady na obsluhu nižší o 15 %" a opírá se o capability „Digitální obsluha zákazníků".

### ? Regionální banka chce snížit provozní náklady poboček o 20 %. Vedení zvolilo strategii „Převést běžné transakce do mobilní aplikace", ze které v příštím roce vzejdou dva projekty. Architekt má zvolenou strategii zachytit jako samostatný prvek modelu a navázat ji na cílový výsledek. Jakým typem prvku má strategie být?

- [ ] Work Package, protože ze strategie vzejdou konkrétní projekty s termíny
- [ ] Goal, protože strategie vyjadřuje, čeho chce banka v pobočkách dosáhnout
- [x] Course of Action, protože jde o zvolený přístup, jak cíle dosáhnout
- [ ] Capability, protože převod transakcí je schopnost, kterou banka získá

> Zvolený přístup, jak dosáhnout cíle, je Course of Action. Work Package je až konkrétní projekt, který ze strategie vzejde, Goal by zaměnil cestu za cíl (tím je snížení nákladů o 20 %) a Capability popisuje, co banka umí, ne rozhodnutí o tom, jak postupovat.

### ? Výrobce nábytku zvažuje dvě strategie, jak zvýšit podíl na trhu: „Otevřít vlastní e-shop" a „Prodávat přes velké retailové řetězce". Architekt má pro rozhodnutí vedení připravit model, který obě varianty porovná podle dopadu na stejný cíl a podle capabilities, které každá vyžaduje. Jak je nejlépe zachytit?

- [x] Jako dva Course of Action se společným Goal a potřebnými capabilities
- [ ] Jako dva prvky Goal spojené vztahem influence se záporným znaménkem
- [ ] Jako dva Work Packages v plánu přechodu, z nichž se jeden později zruší
- [ ] Jako dvě Capability v mapě schopností, které se ohodnotí podle zralosti

> Alternativní strategie jsou dva Course of Action; porovnat je proti stejnému cíli a potřebným capabilities je přesně účel tohoto prvku. Nejde o cíle, ale o cesty k cíli, projekty (Work Packages) přicházejí až po rozhodnutí a mapa schopností hodnotí schopnosti, ne strategické varianty.

## Motivační řetězec od stakeholdera k architektuře {#motivacni-retezec .explain}

Motivační prvky se v praxi řetězí od „proč" k „co": **Stakeholder** má zájem na **Driver** (vnější nebo vnitřní hnací síle), analýza driveru dá **Assessment** (zjištění, např. slabinu), z něj vyplyne **Goal** (žádoucí stav), který zpřesní měřitelný **Outcome**. K dosažení cílů se formulují obecné **Principle** a konkrétní **Requirement** (nebo **Constraint**) a ty nakonec realizují Core prvky. Stakeholder, Driver a Assessment se propojují asociací, vliv zjištění na cíl vyjadřuje influence a směrem k cílům vede realization: Outcome realizuje Goal, Principle realizuje Goal, Requirement realizuje Outcome nebo Principle a Core prvek realizuje Requirement. Díky řetězci lze u každého požadavku dohledat, kterému cíli a kterému stakeholderovi slouží (traceability).

*Příklad:* Compliance officer (Stakeholder) —association→ Regulace AML (Driver) —association→ Ruční kontroly nestíhají (Assessment) —influence→ Automatizovat AML kontroly (Goal); AML kontroly automaticky do 6 měsíců (Outcome) —realization→ Automatizovat AML kontroly (Goal); Screening transakcí v reálném čase (Requirement) —realization→ AML kontroly automaticky do 6 měsíců (Outcome); AML engine (Application Component) —realization→ Screening transakcí v reálném čase (Requirement)

### ? Generální ředitel pojišťovny se obává rostoucí konkurence insurtech startupů. Analýza ukázala, že 40 % odcházejících klientů uvádí jako důvod pomalé vyřízení škod. Vedení stanovilo cíl „Zrychlit vyřízení škod" a měřitelný výsledek „90 % škod vyřízeno do 5 dnů". Který řetězec (šipka = další článek motivačního řetězce) situaci zachycuje správně?

- [ ] Generální ředitel (Business Actor) → Konkurence insurtechů (Goal) → Odchody klientů (Driver) → Zrychlit vyřízení (Outcome) → 90 % do 5 dnů (Requirement)
- [x] Generální ředitel (Stakeholder) → Konkurence insurtechů (Driver) → Odchody klientů (Assessment) → Zrychlit vyřízení (Goal) → 90 % do 5 dnů (Outcome)
- [ ] Generální ředitel (Stakeholder) → Konkurence insurtechů (Assessment) → Odchody klientů (Driver) → Zrychlit vyřízení (Goal) → 90 % do 5 dnů (Outcome)
- [ ] Generální ředitel (Stakeholder) → Konkurence insurtechů (Driver) → Odchody klientů (Assessment) → Zrychlit vyřízení (Outcome) → 90 % do 5 dnů (Goal)

> Ředitel se zájmem na architektuře je Stakeholder, konkurence je hnací síla (Driver), zjištění z analýzy je Assessment, žádoucí stav je Goal a měřitelný konečný výsledek Outcome. Ostatní řetězce zaměňují aktéra za stakeholdera, driver za assessment nebo goal za outcome.

### ? Architekt banky namodeloval: Rychlé schvalování úvěrů (Goal) —realization→ Schválení do 24 hodin (Requirement) a Úvěrový portál (Application Component) —realization→ Rychlé schvalování úvěrů (Goal). Auditor architektury upozorňuje na chybu v řetězci a žádá úplnou dohledatelnost od cíle přes požadavek k aplikaci. Jaká oprava je nejlepší?

- [ ] Požadavek změnit na Driver a portál připojit k cíli vztahem influence
- [ ] Cíl změnit na Outcome a portál připojit k němu vztahem serving
- [ ] Ponechat směry a realization mezi cílem a požadavkem nahradit vztahem composition
- [x] Obrátit směr mezi cílem a požadavkem a portál připojit realizací k požadavku

> Realizace v motivačním řetězci vede od konkrétního k abstraktnímu: Requirement realizuje Goal a Core prvek realizuje Requirement, čímž vznikne dohledatelný řetězec cíl–požadavek–aplikace. Driver není požadavek, serving se k motivačním prvkům nepoužívá a kompozice by z požadavku udělala součást cíle místo prostředku k jeho dosažení.

### ? Výrobní firma má cíl „Snížit energetickou náročnost výroby" a z něj odvozený požadavek „Monitorovat spotřebu každé linky v reálném čase". Architekt chce ukázat, že požadavek naplní nový IoT systém sběru dat, který je v modelu jako Application Component. Který fragment je správný?

- [ ] Monitorovat spotřebu linek (Requirement) —realization→ IoT sběr dat (Application Component)
- [x] IoT sběr dat (Application Component) —realization→ Monitorovat spotřebu linek (Requirement)
- [ ] IoT sběr dat (Application Component) —serving→ Monitorovat spotřebu linek (Requirement)
- [ ] IoT sběr dat (Application Component) —influence→ Snížit energetickou náročnost (Driver)

> Core prvky požadavky realizují, takže realization vede od komponenty k Requirement. Obrácený směr je chybný, serving se k motivačním prvkům nepoužívá a „Snížit energetickou náročnost" je žádoucí stav, tedy Goal, ne Driver.

## Driver × Assessment × Goal {#driver-vs-assessment .compare}

Tři prvky na začátku motivačního řetězce se liší tím, zda pojmenovávají oblast zájmu, hodnotí současný stav, nebo říkají, kam chceme dojít.

| | Driver | Assessment | Goal |
|---|---|---|---|
| Co vyjadřuje | vnější nebo vnitřní faktor, který motivuje ke změně | výsledek analýzy driveru (silná či slabá stránka, příležitost, hrozba) | žádoucí stav, kterého chce podnik dosáhnout |
| Typická formulace | „Regulace", „Konkurence", „Spokojenost zákazníků" | „Incidenty hlásíme regulátorovi pozdě" | „Hlásit incidenty včas a úplně" |
| Hodnotí stav? | ne, jen pojmenovává oblast zájmu | ano, říká, jak na tom jsme | ne, říká, kam chceme |
| Typické vztahy | asociace se Stakeholder a Assessment | asociace s Driver, influence na Goal | realizují ho Outcome, Principle, Requirement |
| Typická chyba | psát ho jako problém s čísly | psát ho jako cíl („Zrychlit…") | psát ho jako zjištění nebo řešení |

### ? Energetická firma provedla analýzu a zjistila, že „62 % reklamací vzniká chybným odečtem elektroměrů". Zjištění souvisí s hnací silou „Spokojenost zákazníků", o kterou se zajímá obchodní ředitel. Jakým prvkem má být zjištění o reklamacích v modelu?

- [ ] Driver, protože motivuje firmu ke změně způsobu odečtu elektroměrů
- [ ] Goal, protože z něj plyne, že je třeba snížit počet reklamací
- [x] Assessment, protože jde o výsledek analýzy, který popisuje současný stav
- [ ] Constraint, protože omezuje, jak lze proces odečtů navrhnout

> Konkrétní zjištění z analýzy současného stavu je Assessment, asociovaný s driverem „Spokojenost zákazníků". Driver je obecnější hnací síla, Goal by vyjadřoval žádoucí stav (ten ze zjištění teprve vznikne) a Constraint omezuje realizaci řešení.

### ? Architekt zapsal do modelu prvek Driver s názvem „Snížit počet chyb ve fakturaci o 30 % do konce roku". Kolega namítá, že prvek je špatně typovaný. Jaká oprava je nejlepší?

- [x] Jde o měřitelný žádoucí výsledek — patří do Outcome; driverem je např. „Kvalita fakturace"
- [ ] Jde o zjištění o současném stavu — patří do Assessment; driverem je např. „Chyby ve fakturaci"
- [ ] Jde o obecnou zásadu pro návrh systémů — patří do Principle; driverem je např. „Fakturace"
- [ ] Jde o pracovní úkol na příští rok — patří do Work Package; driverem je např. „Projekt fakturace"

> „Snížit o 30 % do konce roku" je měřitelný výsledek s termínem, tedy Outcome; Driver jen pojmenovává hnací sílu. Formulace nepopisuje současný stav (Assessment), není to obecná zásada (Principle) ani projekt (Work Package).

## Goal × Outcome {#goal-vs-outcome .compare}

Goal i Outcome vyjadřují, čeho chce podnik dosáhnout; liší se konkrétností. Outcome je konečný výsledek, který Goal realizuje (zpřesňuje).

| | Goal | Outcome |
|---|---|---|
| Povaha | obecný žádoucí stav nebo směr | konkrétní, měřitelný konečný výsledek |
| Formulace | „Zvýšit loajalitu zákazníků" | „Odchodovost pod 8 % do konce roku 2027" |
| Měřitelnost | často kvalitativní | kvantifikovaný, často s termínem |
| Vztahy | realizují ho Outcome, Principle, Requirement | realizuje Goal; realizuje ho Requirement |
| Kdy použít | vize a směr (Phase A) | KPI, ověření přínosu, Outcome Realization viewpoint |

### ? Nemocnice si stanovila směr „Zkrátit čekání pacientů na urgentním příjmu" a ředitel chce sledovat konkrétní výsledek „Medián čekání pod 30 minut do konce roku 2027". Architekt má obě formulace zachytit v modelu i se vztahem mezi nimi. Který fragment je správný?

- [ ] Zkrátit čekání (Outcome) —realization→ Medián pod 30 minut (Goal)
- [ ] Medián pod 30 minut (Requirement) —influence→ Zkrátit čekání (Driver)
- [ ] Zkrátit čekání (Goal) —composition→ Medián pod 30 minut (Assessment)
- [x] Medián pod 30 minut (Outcome) —realization→ Zkrátit čekání (Goal)

> Měřitelný výsledek s termínem je Outcome a realizuje obecnější Goal. Ostatní fragmenty zaměňují typy i směr, dělají z cíle hnací sílu (Driver) nebo z výsledku zjištění o současném stavu (Assessment).

### ? Architekt připravuje pro finančního ředitele pohled, který má ukázat, zda investice do nového skladového systému přinese slíbené „Snížení zásob o 15 % do 12 měsíců". Ředitel chce vidět, které prvky architektury k tomuto výsledku vedou. Na který motivační prvek má být pohled zaměřen?

- [ ] Na Goal „Efektivní řízení zásob", protože udává obecný směr skladování
- [x] Na Outcome „Snížení zásob o 15 % do 12 měsíců" a prvky, které ho realizují
- [ ] Na Driver „Vázaný kapitál ve skladu" a stakeholdery, kteří se o něj zajímají
- [ ] Na Principle „Zásoby se plánují podle poptávky" a požadavky, které ho realizují

> Přínos investice se ověřuje na měřitelném výsledku — Outcome — a na prvcích, které ho realizují (tomu odpovídá i Outcome Realization viewpoint). Goal je příliš obecný, Driver vysvětluje, proč se změna dělá, a Principle je zásada návrhu, ne měřený přínos.

## Principle × Requirement × Constraint {#principle-requirement-constraint .compare}

Všechny tři usměrňují návrh řešení, ale liší se obecností a tím, zda něco požadují, nebo omezují.

| | Principle | Requirement | Constraint |
|---|---|---|---|
| Povaha | obecná zásada platná pro více systémů nebo celý podnik | konkrétní potřeba, kterou musí splnit určité řešení | omezení, které zužuje možné způsoby realizace |
| Formulace | „Data se zadávají jen jednou" | „Portál předvyplní údaje z CRM" | „Řešení musí běžet v datovém centru v EU" |
| Vztah k cílům | realizuje Goal | realizuje Goal, Outcome nebo Principle | stejné vztahy jako Requirement |
| Navazuje | zpřesňují ho Requirements | realizují ho Core prvky | realizují ho Core prvky, které omezení respektují |
| Typická chyba | psát ho pro jeden konkrétní systém | psát ho tak obecně, že nejde ověřit | zaměnit ho za funkční požadavek |

### ? Ředitel IT vyhlásil zásadu „Pro nové systémy dáváme přednost SaaS řešením před vlastním vývojem". Zásada platí pro všechny projekty v podniku a slouží cíli „Zkrátit dobu zavedení nových služeb". Jakým prvkem a vztahem ji modelovat?

- [ ] Jako Requirement, který realizuje Driver „Rychlost zavádění služeb"
- [ ] Jako Constraint, který realizuje Assessment „Vlastní vývoj trvá dlouho"
- [x] Jako Principle, který realizuje Goal „Zkrátit dobu zavedení služeb"
- [ ] Jako Goal, který realizuje Principle „Zkrátit dobu zavedení služeb"

> Obecná zásada platná napříč projekty je Principle a realizuje Goal. Requirement je konkrétní potřeba jednoho řešení, Constraint je tvrdé omezení a realizace nevede k Driver ani k Assessment; varianta s Goal zaměňuje typy i směr.

### ? Při návrhu nového klientského portálu pojišťovny vznikly tři formulace: (1) „Klient vidí stav své škody online", (2) „Portál musí využít stávající licenci databáze Oracle", (3) „Každá informace má v podniku jediný zdroj pravdy". Jak je nejlépe typovat?

- [x] (1) Requirement, (2) Constraint, (3) Principle
- [ ] (1) Requirement, (2) Principle, (3) Constraint
- [ ] (1) Goal, (2) Requirement, (3) Principle
- [ ] (1) Outcome, (2) Constraint, (3) Requirement

> Konkrétní potřeba, kterou portál musí splnit, je Requirement; povinnost použít existující licenci zužuje možnosti realizace, tedy Constraint; obecná zásada platná pro celý podnik je Principle. Ostatní kombinace zaměňují omezení za zásadu, požadavek za cíl nebo zásadu za požadavek.

### ? Pojišťovna patří do skupiny, jejíž pravidla určují, že všechny nové systémy musí běžet výhradně v datovém centru skupiny ve Frankfurtu. Pro nové kontaktní centrum to vylučuje SaaS variantu nabízenou dodavatelem. Architekt chce zachytit toto omezení i komponentu, která ho respektuje. Který fragment je nejvhodnější?

- [ ] Kontaktní centrum (Application Component) —influence→ Provoz jen ve Frankfurtu (Driver)
- [ ] Provoz jen ve Frankfurtu (Constraint) —realization→ Kontaktní centrum (Application Component)
- [x] Kontaktní centrum (Application Component) —realization→ Provoz jen ve Frankfurtu (Constraint)
- [ ] Kontaktní centrum (Application Component) —serving→ Provoz jen ve Frankfurtu (Principle)

> Pravidlo, které zužuje možnosti realizace, je Constraint a Core prvek, který ho respektuje, ho realizuje — stejně jako u Requirement. Driver je hnací síla, ne konkrétní omezení, obrácený směr realizace je chybný a serving se k motivačním prvkům nepoužívá.

## Realizace požadavků Core prvky {#realizace-pozadavku .explain}

Požadavek je v architektuře „pokrytý", když ho realizuje některý Core prvek: aplikační komponenta, služba, proces, node i business object. Realizace vede vždy od konkrétního prvku k požadavku, nikdy opačně. Jeden požadavek může realizovat více prvků z různých vrstev a jeden prvek může realizovat více požadavků — vzniká matice dohledatelnosti, se kterou pracuje Requirements Realization viewpoint i TOGAF Requirements Management. Požadavek, který nic nerealizuje, je nepokrytá mezera; Core prvek, který nerealizuje žádný požadavek, je kandidát na zdůvodnění nebo zrušení. Typické chyby: serving místo realization („aplikace slouží požadavku") a připojení Core prvku rovnou ke Goal: vztah je přípustný, ale ztratí se ověřitelný mezičlánek (Requirement).

*Příklad:* Platební brána (Application Service) —realization→ Platba kartou online (Requirement) —realization→ Zvýšit konverzi e-shopu (Goal)

### ? Architekt e-shopu kontroluje pokrytí 40 požadavků z Phase A. Po namodelování realizačních vztahů zjistí, že požadavek „Zákazník může vrátit zboží online" nerealizuje žádný Core prvek, zatímco aplikace „Legacy reporting" nerealizuje žádný požadavek. Jaký závěr je nejlepší?

- [ ] Oba nálezy jsou v pořádku, protože realizační vztahy jsou v modelu volitelné
- [ ] Požadavek na vrácení zboží převést na Goal, aby ho nebylo nutné realizovat
- [x] Požadavek je nepokrytá mezera a u aplikace je třeba doplnit zdůvodnění nebo zvážit zrušení
- [ ] Aplikaci Legacy reporting připojit realizací k požadavku na vrácení, aby bylo pokryto obojí

> Analýza realizace odhalí nepokryté požadavky (mezery, které musí řešení zaplnit) i prvky bez zdůvodnění. Ignorovat nálezy popírá účel dohledatelnosti, přetypování na Goal problém jen schová a umělé propojení nesouvisející aplikace by byl nepravdivý model.

### ? V modelu je fragment: CRM (Application Component) —serving→ Jednotný pohled na zákazníka (Requirement). Architekt, který model reviduje, žádá opravu. Která úprava je správná?

- [ ] Změnit typ CRM na Application Service, protože požadavkům smějí sloužit jen služby
- [ ] Změnit požadavek na Goal, protože aplikační komponenty slouží jen cílům
- [ ] Ponechat serving, jen obrátit jeho směr od požadavku ke komponentě CRM
- [x] Změnit vztah na realization: CRM —realization→ Jednotný pohled na zákazníka

> Core prvky požadavky realizují; serving vyjadřuje poskytování funkčnosti jinému prvku a k motivačním prvkům se nepoužívá. Změna typu prvku ani přetypování požadavku na cíl chybu neodstraní a obrácený serving je stejně chybný.

## Stakeholder × Business Actor × Business Role {#stakeholder-modelovani .explain}

Stakeholder je motivační prvek: role osoby, skupiny nebo organizace, která má **zájem** na architektuře nebo jejích výsledcích. Business Actor a Business Role jsou prvky aktivní struktury, které v podniku **něco vykonávají** (jsou přiřazeny k chování). Řeší-li scénář obavy, priority a cíle (typicky ve Phase A), modeluje se Stakeholder a asociují se k němu drivers; řeší-li, kdo vykonává proces, modeluje se actor nebo role. Tatáž skutečnost (např. Finanční ředitel) může být v modelu obojím — jako Stakeholder v motivačním pohledu a jako Business Role v procesním pohledu; nejde o duplicitu a oba prvky lze propojit asociací.

*Příklad:* Finanční ředitel (Stakeholder) —association→ Návratnost investic (Driver); Finanční ředitel (Business Role) —assignment→ Schválení rozpočtu (Business Process)

### ? Na úvodním workshopu Phase A architekt zjišťuje, kdo se o program digitalizace zajímá a proč: obchodní ředitel kvůli rychlosti prodeje, compliance kvůli regulaci, odbory kvůli dopadům na zaměstnance. Tyto zájmy chce zachytit v modelu. Který přístup je nejvhodnější?

- [ ] Každou skupinu modelovat jako Business Role a přiřadit ji k procesům, které program mění
- [x] Každou skupinu modelovat jako Stakeholder a asociovat ji s Driver, který ji motivuje
- [ ] Každou skupinu modelovat jako Business Actor a připojit ji ke Goal vztahem assignment
- [ ] Každou skupinu modelovat jako Goal a připojit k ní požadavky vztahem realization

> Zájmy a motivace zúčastněných stran zachycuje Stakeholder asociovaný s drivers — typický výstup Phase A. Role a aktéři popisují, kdo vykonává chování, assignment k cíli není správný vztah a skupiny lidí nejsou cíle.

### ? Architekt použil v jednom modelu „Vedoucí skladu" jako Stakeholder v motivačním pohledu (zájem o bezpečnost práce) a zároveň jako Business Role přiřazenou k procesu Inventura. Kolega to označil za duplicitu, kterou je třeba odstranit. Jak situaci nejlépe posoudit?

- [ ] Je to chyba; Business Role je třeba smazat a proces přiřadit ke stakeholderovi
- [ ] Je to chyba; obě skutečnosti je třeba sloučit do jednoho prvku Business Actor
- [ ] Je to chyba; stakeholderem smí být jen vnější subjekt, ne interní zaměstnanec
- [x] Je to v pořádku; jde o dva pohledy na tutéž skutečnost, propojitelné asociací

> Stakeholder (zájmy a motivace) a Business Role (kdo vykonává chování) mají v jazyce různý účel, takže mít oba prvky je správné; vazbu mezi nimi vyjádří asociace. Stakeholder se k procesu nepřiřazuje, sloučením by se ztratil jeden z pohledů a stakeholder může být i interní.

## Influence × realization v motivaci {#influence-vs-realization .explain}

Realization se použije, když prvek cíl nebo požadavek skutečně **naplňuje** (Outcome realizuje Goal, aplikace realizuje Requirement). Influence se použije, když prvek cíl jen **ovlivňuje** — přispívá k němu částečně či nepřímo, nebo naopak působí proti němu; volitelně se značí + / −. Influence je proto vhodný pro konflikty cílů („Snížit náklady" × „Zvýšit kvalitu služeb") a pro vliv zjištění na cíle. Typická chyba je kreslit realization tam, kde prvek cíl splní jen zčásti, nebo influence tam, kde jde o přímé naplnění požadavku.

*Příklad:* Omezit počet operátorů (Requirement) —realization→ Snížit náklady call centra (Goal); Omezit počet operátorů (Requirement) —influence (−)→ Zvýšit spokojenost zákazníků (Goal)

### ? Telekomunikační operátor má dva cíle: „Snížit náklady na zákaznickou péči" a „Zvýšit spokojenost zákazníků". Požadavek „Přesunout 70 % hovorů na chatbota" naplňuje první cíl, ale podle průzkumu zhoršuje druhý. Který fragment situaci zachycuje nejlépe?

- [ ] Chatbot 70 % (Requirement) —realization→ Snížit náklady; Chatbot 70 % (Requirement) —realization→ Zvýšit spokojenost
- [x] Chatbot 70 % (Requirement) —realization→ Snížit náklady; Chatbot 70 % (Requirement) —influence (−)→ Zvýšit spokojenost
- [ ] Chatbot 70 % (Requirement) —influence (−)→ Snížit náklady; Chatbot 70 % (Requirement) —realization→ Zvýšit spokojenost
- [ ] Chatbot 70 % (Requirement) —association→ Snížit náklady; Chatbot 70 % (Requirement) —association→ Zvýšit spokojenost

> Požadavek naplňuje cíl snížit náklady (realization), ale na spokojenost působí negativně, což vyjadřuje influence se znaménkem minus. Dvojí realizace by tvrdila, že požadavek naplňuje i spokojenost, prohozené vztahy obracejí skutečnost a asociace by konflikt cílů vůbec nezachytila.

### ? Úřad má cíl „Zkrátit dobu vyřízení žádostí na 10 dnů". Podle analýzy ho nový workflow systém přímo naplní, zatímco zavedení home office k němu jen mírně přispěje. Obojí je v modelu jako Requirement. Jak oba požadavky k cíli připojit?

- [x] Workflow připojit vztahem realization, home office vztahem influence (+)
- [ ] Oba připojit vztahem realization, protože oba k cíli přispívají
- [ ] Oba připojit vztahem influence (+), protože žádný cíl nezajistí sám
- [ ] Workflow vztahem influence (+), home office vztahem realization

> Přímé naplnění cíle vyjadřuje realization, dílčí příspěvek influence se znaménkem plus. Dvojí realizace přeceňuje home office, dvojí influence podceňuje workflow, který cíl podle analýzy naplní, a prohození vztahů obrací zjištění analýzy.

## Phase A Architecture Vision v jazyce ArchiMate {#phase-a-archimate .explain}

Ve Phase A TOGAF ADM architekt identifikuje stakeholdery a jejich zájmy, potvrdí business goals a drivers, posoudí business capabilities a vytvoří Architecture Vision s hodnotou pro podnik. ArchiMate k tomu nabízí motivační a strategické prvky: Stakeholder, Driver a Assessment (kdo má zájem a proč, analýza situace), Goal a Outcome (cíle a měřítka úspěchu), Principle a Requirement (zásady a počáteční požadavky), Capability, Value Stream a Course of Action (strategický obraz cílového stavu). Hodí se pohledy na úrovni přehledu (Overview), ne detail procesů a nasazení — ty přicházejí ve Phases B–D. Dokumenty jako Statement of Architecture Work se jako prvky nemodelují; model je podkladem pro jejich obsah. Konflikty zájmů je dobré zviditelnit už zde (influence se znaménkem minus mezi cíli).

*Příklad:* Sponzor (Stakeholder) —association→ Tlak konkurence (Driver) —association→ Pomalé uvádění produktů (Assessment) —influence→ Zkrátit time-to-market (Goal); Nový produkt do 3 měsíců (Outcome) —realization→ Zkrátit time-to-market (Goal)

### ? Architekt zahajuje Phase A programu „Digitální pojišťovna". Sponzor chce na jedné stránce vidět, kdo má na programu zájem, co ho motivuje a jakých cílů má program dosáhnout. Na detailní architekturu zatím nejsou čas ani podklady. Které prvky ArchiMate jsou pro tento výstup nejvhodnější?

- [ ] Business Process, Application Component a Node propojené vztahy serving
- [x] Stakeholder, Driver, Assessment, Goal a Outcome propojené motivačními vztahy
- [ ] Work Package, Deliverable a Plateau seřazené v čase vztahem triggering
- [ ] Business Actor, Business Role a Business Collaboration propojené vztahy assignment

> Kdo má zájem, co ho motivuje a jakých cílů se má dosáhnout, zachycují motivační prvky — jádro Architecture Vision. Core prvky patří do detailní architektury ve Phases B–D, prvky Implementation & Migration do plánování ve Phases E–F a organizační struktura neodpovídá na otázku „proč".

### ? Ve Phase A pro logistickou firmu architekt sestavuje vizi. Vedení se shodlo, že chce do tří let nabízet ve velkých městech doručení do 2 hodin, a ptá se, jaké schopnosti k tomu musí firma posílit. Který obsah modelu tomu nejlépe odpovídá?

- [ ] Detailní proces doručení s rolemi kurýrů a aplikacemi pro plánování tras
- [ ] Target Plateau s aplikacemi a nody, které budou provozovány za tři roky
- [ ] Seznam Work Packages s termíny a odpovědnými aktéry pro tříletý program
- [x] Outcome „Doručení do 2 hodin" a mapa schopností, které je třeba posílit

> Phase A potřebuje strategický obraz: měřitelný výsledek (Outcome) a capabilities, které je třeba posílit. Detailní procesy a technologie přicházejí ve Phases B–D, Target Plateau s nody je detailní cílová architektura a seznam Work Packages patří do plánování ve Phases E–F.

### ? Během Phase A architekt zjistí, že sponzor programu a ředitel provozu mají protichůdné cíle: rychlost uvedení novinek na trh a stabilitu provozu. Chce konflikt zviditelnit ještě před schválením Statement of Architecture Work. Co je nejvhodnější?

- [ ] Odložit konflikt do Phase B, kde se namodelují procesy obou útvarů
- [ ] Vytvořit Work Package „Vyřešení konfliktu" a přiřadit k němu oba aktéry
- [x] Namodelovat oba cíle u příslušných stakeholderů a mezi nimi influence (−)
- [ ] Zapsat do modelu jediný Goal, který oba zájmy spojí do jedné formulace

> Konflikt cílů se v motivačním modelu vyjádří vztahem influence se znaménkem minus mezi cíli navázanými na stakeholdery — a Phase A je správné místo, kde ho otevřít. Odklad do Phase B ani založení projektu konflikt nezviditelní a jediný společný cíl ho jen zakryje.
