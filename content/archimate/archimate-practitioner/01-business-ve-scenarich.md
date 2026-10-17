---
kind: topic
subject: archimate-practitioner
slug: business-ve-scenarich
name: "Modelování business architektury ve scénářích"
order: 1
---

Volba mezi procesem, funkcí a interakcí, role × actor, business služby a rozhraní, produkty a smlouvy.

## Jak ve scénáři vybrat business prvek {#vyber-prvku .explain}

Ve scénáři si nejdřív polož pět otázek a ke každé najdi slovo v zadání: **kdo** práci dělá (Business Actor, Business Role, Business Collaboration), **co** se uvnitř dělá (Business Process, Business Function, Business Interaction), **co vidí okolí** (Business Service), **kudy** se ke službě přistupuje (Business Interface) a **s jakými informacemi** se pracuje (Business Object, Contract, Representation). Doplňující otázky: **co** práci spouští (Business Event) a **co se prodává jako celek** (Product). Teprve potom vybírej vztahy: aktivní struktura —assignment→ chování, chování —realization→ služba, služba —serving→ spotřebitel, chování —access→ objekt. Většina chyb ve scénářích vzniká tím, že se tyto otázky smíchají — např. kanál se modeluje jako služba nebo útvar jako funkce.

*Příklad:* `Klientské centrum (Business Actor) —assignment→ Poradce (Business Role) —assignment→ Sjednání hypotéky (Business Process) —realization→ Poskytnutí hypotéky (Business Service)`.

### ? Stavební spořitelna popisuje: „Klient si na pobočce požádá o úvěr. Úvěrový specialista žádost posoudí a zapíše rozhodnutí do úvěrového spisu. Klient vnímá celé vyřízení jako jednu nabídku spořitelny." Který fragment nejlépe zachycuje vnitřní práci a její vztah k tomu, co klient vnímá?

- [ ] `Úvěrový specialista (Business Role) —serving→ Posouzení žádosti (Business Process) —realization→ Poskytnutí úvěru (Business Service)`
- [x] `Úvěrový specialista (Business Role) —assignment→ Posouzení žádosti (Business Process) —realization→ Poskytnutí úvěru (Business Service)`
- [ ] `Úvěrový specialista (Business Role) —assignment→ Posouzení žádosti (Business Service) —realization→ Poskytnutí úvěru (Business Process)`
- [ ] `Úvěrový specialista (Business Role) —assignment→ Posouzení žádosti (Business Process) —serving→ Poskytnutí úvěru (Business Service)`

> Role vykonává proces (assignment) a proces realizuje službu, kterou klient vnímá (realization). Serving od role k procesu nevyjadřuje vykonávání, záměna typů dělá z vnitřní práce službu a serving od procesu ke službě má obrácený smysl — služba slouží spotřebiteli, proces ji realizuje.

### ? Architekt modeluje e-shop s nábytkem. Ve scénáři stojí: „Zákazník zaplatí objednávku. Po připsání platby sklad objednávku vychystá a předá dopravci. Zákazníkovi přijde e-mail s potvrzením." Kterou otázku si má architekt položit, aby správně určil typ prvku pro „připsání platby"?

- [ ] Kdo tuto činnost vykonává a v jaké roli přitom jedná
- [ ] Jaký kanál k ní zákazník používá
- [ ] Jakou informaci při ní sklad zapisuje
- [x] Zda jde o okamžik, který spouští další práci

> „Připsání platby" je okamžik změny stavu, který spouští vychystání — jde tedy o Business Event, který triggeringem spouští proces. Otázky na vykonavatele, kanál či informaci vedou k aktivní struktuře, rozhraní a objektům, ne k události.

## Business Process × Business Function × Business Interaction {#proces-funkce-interakce .compare}

Všechny tři jsou interní chování; liší se tím, podle čeho je práce seskupená a kolik účastníků ji nese.

| | Business Process | Business Function | Business Interaction |
|---|---|---|---|
| Podstata | posloupnost kroků vedoucí k výsledku | seskupení práce podle odbornosti, zdrojů nebo dovedností | společné chování dvou a více účastníků |
| Pořadí a výsledek | ano — začátek (událost), kroky, výsledek | ne — trvalá „škatulka" bez pořadí | výsledek vzniká jen společně |
| Kdo ji vykonává | role / aktér (dílčí kroky mohou mít různé role) | typicky útvar nebo role, dlouhodobě | Business Collaboration (účastníci společně) |
| Stabilita | mění se s optimalizací | dlouhodobě stabilní | po dobu spolupráce |
| Typický název | sloveso + předmět: „Vyřízení reklamace" | oblast: „Řízení zásob", „Marketing" | „Vyjednání smlouvy", „Společné posouzení" |

### ? Distributor elektroniky popisuje práci: „Po přijetí reklamace technik ověří vadu, vedoucí servisu rozhodne o opravě nebo výměně a zákaznický servis oznámí výsledek zákazníkovi. Cílem je uzavřená reklamace do 30 dnů." Jakým prvkem se nejlépe modeluje „Vyřízení reklamace"?

- [x] Business Process, protože jde o posloupnost kroků vedoucí k výsledku
- [ ] Business Function, protože se na ní podílí více útvarů a oddělení firmy
- [ ] Business Interaction, protože se na ní podílí více rolí
- [ ] Business Service, protože výsledek dostává zákazník

> Zadání popisuje spouštěcí událost, pořadí kroků a výsledek — typický Business Process. Funkce nemá pořadí, interakce vyžaduje společné (nikoli postupné) chování a služba je vnější pohled na to, co proces realizuje, ne práce samotná.

### ? Pojišťovna chce v modelu ukázat, jak je práce rozdělena podle odbornosti: „Upisování rizik" zahrnuje vše, co souvisí s oceňováním rizik, napříč produkty a bez ohledu na pořadí činností. Útvar upisování za tuto oblast dlouhodobě odpovídá. Který fragment je nejvhodnější?

- [ ] `Útvar upisování (Business Actor) —assignment→ Upisování rizik (Business Process)`
- [ ] `Útvar upisování (Business Actor) —assignment→ Upisování rizik (Business Interaction)`
- [ ] `Útvar upisování (Business Function) —assignment→ Upisování rizik (Business Actor)`
- [x] `Útvar upisování (Business Actor) —assignment→ Upisování rizik (Business Function)`

> Trvalé seskupení práce podle odbornosti bez pořadí je Business Function a útvar je aktivní struktura (Business Actor), která je k ní přiřazena. Proces by vyžadoval posloupnost s výsledkem, interakce více společně jednajících účastníků a třetí možnost zaměňuje typy i směr přiřazení.

### ? Při prodeji nemovitosti se kupující, prodávající a advokát sejdou a teprve společně odsouhlasí znění kupní smlouvy; žádný z nich to nemůže udělat sám. Jak tuto činnost modelovat?

- [ ] `Advokát (Business Role) —assignment→ Odsouhlasení smlouvy (Business Process)`
- [ ] `Kupující a prodávající (Business Actor) —triggering→ Odsouhlasení smlouvy (Business Event)`
- [x] `Účastníci prodeje (Business Collaboration) —assignment→ Odsouhlasení smlouvy (Business Interaction)`
- [ ] `Účastníci prodeje (Business Collaboration) —realization→ Odsouhlasení smlouvy (Business Function)`

> Chování, které vzniká jen společným jednáním více účastníků, je Business Interaction přiřazená Business Collaboration, jež tyto účastníky agreguje. Přiřazení jen advokátovi zkresluje, kdo výsledek nese, triggering od aktéra k události nepopisuje vykonávání a realization od kolaborace k funkci není vztah vykonavatele k chování.

## Proces napříč funkcemi {#proces-napric-funkcemi .explain}

Funkce popisují **stabilní** rozdělení práce (Prodej, Sklad, Finance), procesy **průchod** práce k výsledku. End-to-end proces (např. od objednávky po zaplacení) se modeluje jako Business Process složený (composition) z dílčích procesů, které na sebe navazují triggeringem; každý dílčí proces je přiřazen roli, kterou zastává příslušný útvar. Funkce může dílčí procesy agregovat, a tím ukázat, do které oblasti práce patří — celý proces se ale nemá „zavřít" do jediné funkce, když ji ve skutečnosti překračuje. Chybou je také modelovat útvary jako funkce, které se navzájem spouštějí: útvar je Business Actor.

*Příklad:* `Objednávka až platba (Business Process) —composition→ Expedice (Business Process)`; `Přijetí objednávky (Business Process) —triggering→ Expedice (Business Process)`; `Skladník (Business Role) —assignment→ Expedice (Business Process)`.

### ? Velkoobchod chce zachytit tok práce „Objednávka až platba": obchod přijme objednávku, sklad ji vyexpeduje a účtárna vystaví fakturu a sleduje úhradu. Vedení chce vidět pořadí kroků i to, kdo který krok dělá. Který přístup je nejvhodnější?

- [ ] Jedna Business Function „Objednávka až platba" přiřazená všem třem útvarům firmy najednou
- [x] Business Process složený z dílčích procesů spojených triggeringem, každý přiřazený roli
- [ ] Tři Business Functions Obchod, Sklad a Účtárna spojené mezi sebou vztahem triggering
- [ ] Business Interaction „Objednávka až platba" přiřazená kolaboraci všech tří útvarů

> Pořadí a výsledek vyjadřuje proces; rozpad na dílčí procesy s triggeringem a přiřazením rolí ukáže i odpovědnost za jednotlivé kroky. Funkce nemá pořadí, útvary nejsou funkce a interakce by tvrdila, že všechny útvary pracují společně na každém kroku, což neplatí.

### ? V modelu výrobní firmy je fragment `Prodej (Business Function) —triggering→ Výroba (Business Function) —triggering→ Expedice (Business Function)` a v popisu stojí, že jde o organizační útvary, které si postupně předávají zakázku. Co je hlavní chyba?

- [ ] Mezi funkcemi se smí kreslit jen vztah flow, nikdy triggering
- [ ] Funkce musí být spojené kompozicí, aby se zachovalo jejich pořadí
- [ ] Chybí Business Event na začátku celého řetězce, jinak je fragment v pořádku
- [x] Útvary jsou aktivní struktura a předání zakázky je posloupnost procesu

> Organizační útvar je Business Actor a předávání zakázky v pořadí je Business Process (resp. jeho dílčí kroky spojené triggeringem). Doplnění události by základní záměnu typů nevyřešilo, kompozice pořadí nevyjadřuje a triggering mezi funkcemi zakázaný není — chyba je v typech prvků.

### ? Banka modeluje funkci „Řízení úvěrových rizik" a proces „Schválení úvěru", jehož dílčí krok „Posouzení bonity" patří odborně do řízení rizik, ostatní kroky do obchodu. Jak nejlépe ukázat, že tento krok patří do oblasti rizik, aniž by se celý proces přesunul do jedné funkce?

- [ ] `Schválení úvěru (Business Process) —composition→ Řízení úvěrových rizik (Business Function)`
- [ ] `Řízení úvěrových rizik (Business Function) —triggering→ Posouzení bonity (Business Process)`
- [ ] `Posouzení bonity (Business Process) —realization→ Řízení úvěrových rizik (Business Function)`
- [x] `Řízení úvěrových rizik (Business Function) —aggregation→ Posouzení bonity (Business Process)`

> Agregace dovolí, aby dílčí proces byl součástí procesu „Schválení úvěru" a zároveň byl zařazen do funkce řízení rizik. Kompozice funkce do procesu obrací vztah celku a části, triggering vyjadřuje časovou návaznost, ne příslušnost, a realization mezi procesem a funkcí zařazení nevyjadřuje.

## Business Event {#business-event .explain}

Business Event je **okamžik** změny stavu, na který organizace reaguje (vnější: „Žádost doručena", vnitřní: „Limit překročen", časový: „Konec měsíce"). Nemá trvání; v modelu je podstatné hlavně to, co spouští. Událost proces **spouští** (`—triggering→`) a proces může událostí končit (proces —triggering→ událost výsledku). Pojmenovává se jako nastalý stav („Objednávka přijata"), ne jako činnost. Typické chyby: modelovat událost jako krok procesu („Přijetí žádosti" místo „Žádost přijata"), nechat proces spouštět Business Object (pasivní struktura nic nespouští) nebo kreslit od události k procesu serving.

*Příklad:* `Konec měsíce (Business Event) —triggering→ Měsíční fakturace (Business Process) —triggering→ Faktury odeslány (Business Event)`.

### ? Energetická firma: „Každý poslední den v měsíci se automaticky zahájí měsíční vyúčtování odběratelů. Jeho výsledkem je odeslání vyúčtování." Který fragment je správný?

- [x] `Konec měsíce (Business Event) —triggering→ Měsíční vyúčtování (Business Process) —triggering→ Vyúčtování odesláno (Business Event)`
- [ ] `Konec měsíce (Business Process) —triggering→ Měsíční vyúčtování (Business Event) —triggering→ Vyúčtování odesláno (Business Process)`
- [ ] `Konec měsíce (Business Event) —serving→ Měsíční vyúčtování (Business Process) —realization→ Vyúčtování odesláno (Business Event)`
- [ ] `Konec měsíce (Business Object) —triggering→ Měsíční vyúčtování (Business Process) —access→ Vyúčtování odesláno (Business Event)`

> Časový okamžik je Business Event, který proces spouští, a proces končí událostí výsledku — obojí triggeringem. Druhá možnost prohazuje typy, třetí používá serving a realization, které časovou příčinnost nevyjadřují, a čtvrtá dělá z okamžiku pasivní objekt, který nic spouštět nemůže.

### ? V modelu úvěrového procesu je `Žádost o úvěr (Business Object) —triggering→ Posouzení žádosti (Business Process)`. Jak fragment nejlépe opravit, aby vyjadřoval, že doručení žádosti spouští posouzení a posouzení žádost čte?

- [ ] `Posouzení žádosti (Business Process) —triggering→ Žádost o úvěr (Business Object)` a obrátit tím směr
- [ ] `Žádost o úvěr (Business Object) —serving→ Posouzení žádosti (Business Process)` místo triggeringu
- [x] `Žádost doručena (Business Event) —triggering→ Posouzení žádosti` a `Posouzení žádosti —access (read)→ Žádost o úvěr`
- [ ] `Žádost o úvěr (Business Event) —access (read)→ Posouzení žádosti (Business Process)` beze změny názvu

> Pasivní struktura nemůže nic spouštět ani obsluhovat; spouštěčem je událost „Žádost doručena" a s dokumentem proces pracuje přes access. Obrácený triggering i serving od objektu zůstávají nesprávné a access se kreslí od chování k objektu, ne od události k procesu.

## Triggering × Flow v business vrstvě {#triggering-flow .compare}

Oba vztahy jsou dynamické a spojují chování (a události); liší se tím, co tvrdí o návaznosti.

| | Triggering | Flow |
|---|---|---|
| Význam | dokončení A (nebo událost) **spouští** B — časová a příčinná návaznost | z A do B se **předává** informace, zboží nebo peníze |
| Tvrdí, kdy B začne? | ano | ne — B může běžet podle vlastního plánu |
| Notace | plná čára s plnou šipkou | čárkovaná čára s plnou šipkou |
| Typické použití | kroky jednoho procesu, událost → proces | předávání podkladů mezi procesy či funkcemi různých útvarů |
| Častá chyba | kreslit triggering, i když B na A nečeká | kreslit flow mezi kroky, které na sebe přímo navazují |

### ? Obchodní oddělení každý měsíc posílá výrobě prodejní předpověď. Výroba plánuje kapacity v pevném čtvrtletním cyklu a předpověď jen použije jako jeden z podkladů. Který vztah mezi „Prognóza prodeje" a „Plánování kapacit" (oba Business Process) je nejvhodnější?

- [ ] Triggering, protože předpověď je vstupem plánování
- [ ] Serving, protože prodej svou předpovědí pomáhá výrobě
- [x] Flow, protože se předává informace bez spouštění
- [ ] Access, protože plánování předpověď pravidelně čte

> Předpověď se předává, ale plánování nespouští — běží ve vlastním cyklu, a proto je správný flow. Triggering by tvrdil příčinnou návaznost, serving by tvrdil, že prognóza plánování poskytuje funkcionalitu, ne že mu předává podklad, a access se kreslí od chování k pasivnímu objektu, nikoli mezi dvěma procesy.

### ? V pojišťovně platí: „Jakmile likvidátor schválí pojistné plnění, okamžitě se zahájí výplata." Model obsahuje `Schválení plnění (Business Process) —flow→ Výplata plnění (Business Process)`. Jak model posoudit?

- [ ] Je správný, protože flow vyjadřuje předání rozhodnutí o plnění
- [x] Lepší je triggering, protože schválení přímo spouští výplatu
- [ ] Lepší je serving, protože schválení slouží výplatě plnění
- [ ] Lepší je composition, protože výplata je součástí schválení

> Zadání tvrdí příčinnou a časovou návaznost („okamžitě se zahájí"), kterou vyjadřuje triggering; flow by říkal jen to, že se něco předává. Serving se mezi navazujícími kroky nepoužívá a výplata není částí schválení, ale následujícím krokem.

## Business Actor × Business Role {#aktor-role .compare}

Aktér říká **kdo** (útvar, organizace, výjimečně osoba), role **v jaké odpovědnosti** jedná. Chování se přiřazuje přednostně **roli**: když se změní, kdo práci dělá, změní se jen přiřazení aktéra k roli.

| | Business Actor | Business Role |
|---|---|---|
| Co vyjadřuje | organizační jednotka, firma, osoba | odpovědnost za určité chování („klobouk") |
| Příklady | „Oddělení likvidace", „AutoExpert s.r.o.", „Odběratel Novák" | „Likvidátor", „Zákazník", „Schvalovatel" |
| Vztah mezi nimi | `Aktér —assignment→ Role` | jeden aktér může mít více rolí, roli může hrát více aktérů |
| Vztah k chování | lze přiřadit přímo, ale méně stabilně | `Role —assignment→ Process / Function` |
| Kdy použít | organizační struktura, smluvní strany | odpovědnosti v procesech, zákazník jako typ účastníka |

### ? Pojišťovna likviduje škody vlastním oddělením likvidace; ve špičkách stejnou práci dělá externí partner AutoExpert s.r.o. Architekt chce, aby model nemusel měnit procesy, když přibude další partner. Který fragment je nejvhodnější?

- [ ] Oddělení likvidace i AutoExpert (Business Actor) —assignment→ přímo Likvidace škody (Business Process)
- [ ] Likvidace škody (Business Process) —assignment→ Likvidátor (Business Role) —assignment→ Oddělení likvidace i AutoExpert
- [ ] Oddělení likvidace i AutoExpert (Business Role) —assignment→ Likvidace škody (Business Process)
- [x] Oddělení likvidace i AutoExpert (Business Actor) —assignment→ Likvidátor (Business Role) —assignment→ Likvidace škody

> Role „Likvidátor" odděluje odpovědnost od konkrétních vykonavatelů: proces je přiřazen roli a nový partner jen převezme roli. Přímé přiřazení aktérů vyžaduje měnit model procesu, druhá možnost obrací směr obou assignmentů a třetí modeluje konkrétní firmy jako role.

### ? E-shop prodává fyzickým osobám i firmám; v procesech vystupuje „Zákazník", který objednává a platí. Konkrétní zákazníky model nesleduje. Jak „Zákazník" modelovat?

- [ ] Jako Business Actor, protože zákazník je vnější subjekt
- [ ] Jako Business Collaboration osob a firem, které nakupují
- [x] Jako Business Role, kterou hrají různé osoby a firmy
- [ ] Jako Business Object s údaji o zákaznících e-shopu

> „Zákazník" zde označuje odpovědnost v procesu, kterou mohou hrát různé subjekty, tedy Business Role. Aktér by se hodil pro konkrétní subjekt (např. jmenovitý odběratel), kolaborace pro společné jednání a Business Object popisuje informace o zákazníkovi, ne jednajícího účastníka.

### ? V modelu je `Schvalovatel faktur (Business Role) —assignment→ Vedoucí účtárny (Business Actor)`. Co je chybně?

- [ ] Role a aktér se mají spojovat vztahem serving, nikoli assignment
- [x] Směr je obrácený — aktér je přiřazen roli, ne role aktérovi
- [ ] Vedoucí účtárny má být Business Role a schvalovatel aktér
- [ ] Mezi rolí a aktérem se má použít specialization místo assignmentu

> Assignment vede od toho, kdo jedná, k tomu, co zastává: `Vedoucí účtárny (Business Actor) —assignment→ Schvalovatel faktur (Business Role)`. Serving ani specialization nevyjadřují, že aktér roli hraje, a typy prvků jsou v modelu zvolené správně.

## Organizační struktura {#organizacni-struktura .explain}

Útvary a vnější organizace jsou **Business Actors**; hierarchie se modeluje **kompozicí** (oddělení je výhradní částí divize) nebo **agregací**, kde část existuje samostatně a může patřit i do jiných celků (např. projektový tým složený z lidí různých útvarů). **Specialization** mezi aktéry znamená „je druhem" a pro hierarchii se nehodí; **assignment** mezi aktéry nevyjadřuje nadřízenost. Jednotlivé osoby se modelují jen tehdy, když je to pro scénář podstatné. Místo, kde aktér působí, lze vyjádřit prvkem Location.

*Příklad:* `Skupina Alfa (Business Actor) —composition→ Divize Retail (Business Actor) —composition→ Oddělení e-commerce (Business Actor)`.

### ? Holding se skládá z divizí, divize z oddělení a žádné oddělení mimo svou divizi neexistuje. Personální ředitel chce v modelu vidět organizační hierarchii. Který fragment je správný?

- [x] `Divize Retail (Business Actor) —composition→ Oddělení e-commerce (Business Actor)`
- [ ] `Divize Retail (Business Actor) —specialization→ Oddělení e-commerce (Business Actor)`
- [ ] `Divize Retail (Business Actor) —assignment→ Oddělení e-commerce (Business Actor)`
- [ ] `Divize Retail (Business Function) —composition→ Oddělení e-commerce (Business Function)`

> Oddělení je částí divize a bez ní neexistuje, proto composition mezi dvěma Business Actors. Specialization vyjadřuje „je druhem", assignment nevyjadřuje hierarchii (vede k chování nebo roli) a útvary nejsou funkce.

### ? Firma vytvořila projektový tým pro výběr nového ERP. Tým ERP tvoří tři zaměstnanci (Business Actor) z IT, Finance a Logistiky, kteří zůstávají ve svých odděleních a po skončení týmu v nich budou dál pracovat. Architekt chce tým zachytit jako organizační jednotku (Business Actor). Který vztah mezi „Tým ERP" a těmito zaměstnanci je nejvhodnější?

- [ ] Composition od týmu k zaměstnancům, protože tým je z nich složený
- [ ] Serving od zaměstnanců k týmu, protože pro tým vykonávají práci
- [x] Aggregation od týmu k zaměstnancům, protože patří i do oddělení
- [ ] Assignment od týmu k zaměstnancům, protože tým jim přiděluje práci

> Agregace vyjadřuje seskupení, v němž části existují samostatně a mohou patřit i do jiných celků — zaměstnanci zůstávají ve svých odděleních a tým přežijí. Composition by tvrdila, že zaměstnanci existují jen v rámci týmu, serving vyjadřuje poskytování funkcionality, ne členství, a assignment mezi dvěma aktéry nevyjadřuje příslušnost k celku.

## Business Collaboration a Interaction v praxi {#kolaborace .explain}

Business Collaboration **agreguje** dvě a více rolí (nebo aktérů), které **společně** vykonávají Business Interaction. Použij ji, jen když výsledek opravdu vzniká společným jednáním (vyjednávání, společné posouzení, komise). Když si účastníci práci jen **postupně předávají**, jde o proces s dílčími kroky přiřazenými různým rolím — kolaborace by zbytečně zamlžila odpovědnost. Kolaborace může být i dlouhodobá (partnerství dvou firem), přesto zůstává seskupením účastníků, ne novým útvarem.

*Příklad:* `Úvěrová komise (Business Collaboration) —aggregation→ Risk manažer (Business Role)`; `Úvěrová komise —assignment→ Schválení velkého úvěru (Business Interaction)`.

### ? Banka a pojišťovna nabízejí hypotéku s pojištěním. Při sjednání poradce banky a agent pojišťovny na schůzce s klientem společně nastaví parametry; ani jeden to nezvládne bez druhého. Který fragment je nejvhodnější?

- [ ] `Poradce banky (Business Role) —triggering→ Agent pojišťovny (Business Role)` a mezi nimi proces sjednání
- [x] `Bankopojišťovací tým (Business Collaboration) —aggregation→ obě role`; `tým —assignment→ Sjednání balíčku (Business Interaction)`
- [ ] `Bankopojišťovací tým (Business Actor) —composition→ obě role`; `tým —realization→ Sjednání balíčku (Business Process)`
- [ ] `Poradce banky (Business Role) —specialization→ Agent pojišťovny (Business Role)` a obě role přiřazené sjednání

> Společné chování dvou rolí z různých organizací zachytí kolaborace, která obě role agreguje a je přiřazena interakci. Triggering mezi rolemi nevyjadřuje společnou práci, realization není vztah vykonavatele k chování a specialization by tvrdila, že agent je druhem poradce banky.

### ? Architekt nakreslil „Vyřízení objednávky" jako Business Interaction přiřazenou kolaboraci obchodu, skladu a účtárny. Ve skutečnosti obchod objednávku přijme a předá skladu, ten ji vyexpeduje a účtárna pak vystaví fakturu. Jak model posoudit?

- [ ] Správně, protože se na výsledku podílejí tři útvary firmy
- [ ] Správně, jen je třeba kolaboraci nahradit jednou Business Function
- [ ] Nesprávně — místo kolaborace má být aktér „Firma" s rolemi
- [x] Nesprávně — jde o proces s kroky přiřazenými jednotlivým rolím

> Práce se mezi útvary postupně předává, nevzniká společným jednáním — správný je Business Process složený z kroků s triggeringem, každý přiřazený roli. Samotná účast více útvarů interakci neopravňuje, funkce nevyjadřuje pořadí a aktér „Firma" by odpovědnost za kroky ještě více zamlžil.

## Business Service v praxi {#business-service .explain}

Business Service popisuje, **co organizace nabízí** okolí (zákazníkům i vlastním útvarům), bez ohledu na to, jak to uvnitř dělá. Pojmenovává se z pohledu spotřebitele („Hlášení pojistné události", „Výplata mezd"). Službu **realizuje** proces, funkce nebo interakce (`chování —realization→ služba`) a služba **slouží** spotřebiteli (`služba —serving→ role / aktér / proces`). Výhoda: vnitřní procesy lze měnit, aniž se mění to, co zákazník vidí. Chyby: službou modelovat každý krok procesu, obracet realization, nebo nechat službu „vykonávat" proces.

*Příklad:* `Vyřízení škody (Business Process) —realization→ Hlášení pojistné události (Business Service) —serving→ Pojištěný (Business Role)`.

### ? Pojišťovna chce klientům ukázat, co jim nabízí při škodě, a schovat interní kroky likvidace, které se budou měnit. Který fragment je správný?

- [ ] `Vyřízení pojistné události (Business Service) —realization→ Likvidace škody (Business Process)`; `Pojištěný —serving→ Vyřízení pojistné události`
- [ ] `Likvidace škody (Business Process) —serving→ Vyřízení pojistné události (Business Service)`; `Vyřízení pojistné události —realization→ Pojištěný`
- [x] `Likvidace škody (Business Process) —realization→ Vyřízení pojistné události (Business Service)`; `Vyřízení pojistné události —serving→ Pojištěný`
- [ ] `Vyřízení pojistné události (Business Service) —assignment→ Likvidace škody (Business Process)`; `Pojištěný —assignment→ Vyřízení pojistné události`

> Proces realizuje službu a služba slouží roli pojištěného; při změně procesu zůstává služba stejná. První možnost obrací realization i serving, druhá používá serving tam, kde má být realization, a čtvrtá assignment, který vede od aktivní struktury k chování, ne od služby.

### ? Mzdové oddělení koncernu zpracovává výplaty pro všechny dceřiné firmy; ty o vnitřních krocích nic nevědí, jen dostávají výplatní pásky a mzdy jsou vyplaceny. Jak nejlépe vyjádřit vztah mezi mzdovým oddělením a dceřinými firmami?

- [x] Vnitřní služba „Zpracování mezd" realizovaná procesem mzdového oddělení slouží dceřiným firmám
- [ ] Dceřiné firmy jsou přiřazeny procesu „Zpracování mezd", protože jsou jeho hlavními a jedinými příjemci
- [ ] Mzdové oddělení a dceřiné firmy tvoří Business Collaboration vykonávající interakci „Mzdy"
- [ ] Proces „Zpracování mezd" je kompozicí přímo součástí procesů jednotlivých dceřiných firem

> Sdílené centrum nabízí ostatním útvarům vnitřní Business Service: proces ji realizuje a služba slouží spotřebitelům. Přiřazení by z příjemců udělalo vykonavatele, kolaborace by tvrdila společnou práci a kompozice by zneviditelnila hranici mezi poskytovatelem a spotřebitelem.

### ? Analytik navrhl pro proces „Vyřízení objednávky" s osmi kroky osm business služeb, jednu za každý krok, přestože kroky využívá jen tento proces a nikdo jiný. Jaké doporučení je nejlepší?

- [ ] Ponechat osm služeb, protože každá činnost musí realizovat službu
- [ ] Nahradit služby osmi Business Interfaces pro jednotlivé kroky
- [ ] Ponechat služby a přidat mezi ně triggering podle pořadí kroků
- [x] Modelovat služby jen tam, kde je skutečný spotřebitel mimo proces

> Služba má smysl tam, kde nabízí chování někomu dalšímu; vnitřní kroky, které nikdo jiný nevyužívá, stačí modelovat jako dílčí procesy. Povinnost „služba za každou činnost" neexistuje, rozhraní jsou přístupové body, ne kroky, a triggering mezi službami by duplikoval tok procesu.

## Business Service × Business Interface {#sluzba-rozhrani .compare}

Služba říká **co** dostanu, rozhraní **kudy** se k tomu dostanu (kanál).

| | Business Service | Business Interface |
|---|---|---|
| Aspekt | externí chování | externí aktivní struktura |
| Příklady | „Sjednání úvěru", „Podání reklamace" | „Pobočka", „Call centrum", „Klientský portál" (jako kanál) |
| Vztah ke službě | — | `Rozhraní —assignment→ Služba` |
| Vztah k poskytovateli | realizuje ji jeho chování | `Role / Aktér —composition→ Rozhraní` |
| Vztah ke spotřebiteli | `Služba —serving→ Role` | `Rozhraní —serving→ Role` |
| Častá chyba | jeden kanál = jedna služba | modelovat kanál jako proces nebo aktéra |

### ? Banka nabízí sjednání spotřebitelského úvěru na pobočce, po telefonu a v internetovém bankovnictví; obsah služby i podmínky jsou ve všech kanálech stejné. Který model je nejvhodnější?

- [ ] Tři Business Services „Úvěr na pobočce", „Úvěr po telefonu" a „Úvěr online"
- [ ] Jedna Business Service a tři Business Processes „Pobočka", „Telefon" a „Online"
- [ ] Jedna Business Service a tři Business Actors pro jednotlivé kanály banky
- [x] Jedna Business Service a tři Business Interfaces přiřazené této službě

> Služba je stejná, liší se jen přístupové body, proto jedna služba a tři rozhraní s assignmentem ke službě. Tři služby by duplikovaly totéž chování, kanály nejsou procesy (nepopisují práci) a nejsou to ani organizační jednotky.

### ? Který fragment správně spojuje kanál „Call centrum" se službou „Hlášení poruchy" a se zákazníkem distribuční společnosti?

- [ ] `Call centrum (Business Interface) —realization→ Hlášení poruchy (Business Service)`; `Zákazník —serving→ Call centrum`
- [x] `Call centrum (Business Interface) —assignment→ Hlášení poruchy (Business Service)`; `Call centrum —serving→ Zákazník`
- [ ] `Hlášení poruchy (Business Service) —assignment→ Call centrum (Business Interface)`; `Call centrum —serving→ Zákazník`
- [ ] `Call centrum (Business Process) —realization→ Hlášení poruchy (Business Service)`; `Hlášení poruchy —serving→ Zákazník`

> Rozhraní je přiřazeno službě, kterou zpřístupňuje, a slouží zákazníkovi. Realization od rozhraní ke službě nevyjadřuje zpřístupnění (a serving od zákazníka má obrácený směr), assignment nemůže vést od služby (chování) k rozhraní a call centrum jako kanál není proces.

### ? Pojišťovna chce v modelu ukázat, že klientský portál (jako obchodní kanál) patří úseku Péče o klienty, který jej provozuje jako svůj přístupový bod. Který vztah mezi „Péče o klienty (Business Actor)" a „Klientský portál (Business Interface)" je nejvhodnější?

- [x] Composition od aktéra k rozhraní
- [ ] Serving od rozhraní k aktérovi
- [ ] Realization od aktéra k rozhraní
- [ ] Specialization od rozhraní k aktérovi

> Rozhraní je přístupovým bodem svého poskytovatele, a proto je jeho částí — composition od aktéra (nebo role) k rozhraní. Serving od rozhraní by z úseku dělal spotřebitele, realization tu nevyjadřuje vlastnictví přístupového bodu a specialization „je druhem" nedává smysl.

## Business Object × Representation × Contract {#objekty .compare}

Pasivní struktura business vrstvy: informace, s nimiž se pracuje, jejich vnímatelná podoba a dohody.

| | Business Object | Representation | Contract |
|---|---|---|---|
| Co je | informace / pojem z pohledu byznysu | vnímatelná forma nesoucí informaci | dohoda s právy a povinnostmi stran |
| Příklady | „Faktura", „Pojistná událost", „Objednávka" | „Tištěná faktura", „Formulář žádosti", „E-mail s potvrzením" | „Pojistná smlouva", „SLA", „Rámcová smlouva" |
| Typický vztah | `Proces —access→ Business Object` | `Representation —realization→ Business Object` | `Product —aggregation→ Contract`; procesy k ní mají access |
| Pozor | není to dokument ani soubor, ale obsah | jeden objekt může mít více forem | je to specializace Business Object |

### ? Úřad přijímá „Žádost o dotaci" papírově na předepsaném formuláři i elektronickým formulářem; obsah žádosti je v obou případech stejný a zpracovává se jedním postupem. Který fragment je nejvhodnější?

- [ ] Dva Business Objects „Papírová žádost" a „Elektronická žádost", každý se svým procesem
- [x] Business Object „Žádost o dotaci" realizovaný dvěma Representations obou formulářů
- [ ] Representation „Žádost o dotaci" realizovaná dvěma Business Objects obou formulářů
- [ ] Business Object „Žádost o dotaci" složený kompozicí ze dvou Business Events podání

> Obsah (informace) je jeden Business Object a dvě vnímatelné podoby jsou Representations, které jej realizují. Dva objekty by duplikovaly stejnou informaci, třetí možnost obrací směr realizace a podání je událost, nikoli součást objektu.

### ? V procesu „Posouzení žádosti o hypotéku" analytik načte žádost klienta a zapíše rozhodnutí. Který fragment správně zachycuje práci s informacemi?

- [ ] `Žádost (Business Object) —access→ Posouzení žádosti (Business Process)`; `Rozhodnutí (Business Object) —access→ Posouzení žádosti`
- [ ] `Posouzení žádosti (Business Process) —access (write)→ Žádost (Business Object)`; `Posouzení žádosti —access (read)→ Rozhodnutí`
- [ ] `Posouzení žádosti (Business Process) —flow→ Žádost (Business Object)`; `Posouzení žádosti —flow→ Rozhodnutí (Business Object)`
- [x] `Posouzení žádosti (Business Process) —access (read)→ Žádost (Business Object)`; `Posouzení žádosti —access (write)→ Rozhodnutí`

> Access vede od chování k pasivnímu objektu a režim říká, zda proces čte (žádost), nebo zapisuje (rozhodnutí). První možnost kreslí access od objektu, druhá má prohozené režimy a flow je dynamický vztah mezi chováními, ne práce s objektem.

## Product v praxi {#produkt .explain}

Product je **balíček**, který organizace nabízí zákazníkům jako celek: agreguje služby (business, ale i aplikační či technologické), případně pasivní struktury a **smlouvu**, která podmínky upravuje. Použij ho, když scénář mluví o „tarifu", „balíčku" či „produktu" s danými podmínkami; samostatně nabízenou činnost bez balíčku a podmínek modeluj jen jako Business Service. Produkt se se svými částmi spojuje **agregací** (služba může být součástí více produktů). Chyby: modelovat produkt jako službu, nebo produkt „realizovat" procesem — procesy realizují služby, které produkt obsahuje.

*Příklad:* `Účet Plus (Product) —aggregation→ Vedení účtu (Business Service)`; `Účet Plus —aggregation→ Internetové bankovnictví (Application Service)`; `Účet Plus —aggregation→ Smlouva o účtu (Contract)`.

### ? Mobilní operátor prodává „Rodinný tarif": volání, mobilní data a zákaznickou podporu za společnou měsíční cenu podle jedné smlouvy. Hlasové i datové služby se prodávají i v jiných tarifech. Který fragment je nejvhodnější?

- [ ] `Rodinný tarif (Business Service) —composition→ Volání, Data, Podpora (Business Service)` a `Smlouva —serving→ Rodinný tarif`
- [ ] `Volání, Data, Podpora (Business Service) —realization→ Rodinný tarif (Product)` a `Smlouva —realization→ Rodinný tarif`
- [x] `Rodinný tarif (Product) —aggregation→ Volání, Data, Podpora (Business Service)` a `Rodinný tarif —aggregation→ Smlouva (Contract)`
- [ ] `Rodinný tarif (Product) —assignment→ Volání, Data, Podpora (Business Service)` a `Rodinný tarif —access→ Smlouva (Contract)`

> Balíček služeb se smlouvou nabízený jako celek je Product, který služby i smlouvu agreguje; agregace dovolí, aby služby byly i v jiných tarifech. Tarif jako služba složená ze služeb ztrácí smluvní rámec (a kompozice by vylučovala sdílení), realization směrem k produktu ani assignment a access z produktu nejsou vztahy balíčku a jeho částí.

### ? Autoservis nabízí „Výměnu pneumatik" jako jednorázovou činnost bez smlouvy a zároveň balíček „Pneuservis Komfort": výměna, uskladnění pneumatik a roční smlouva s pevnou cenou. Jak oba prvky modelovat?

- [x] Výměnu jako Business Service, balíček jako Product agregující služby a Contract
- [ ] Výměnu i balíček jako Product, protože obojí se zákazníkům samostatně prodává
- [ ] Výměnu jako Product, balíček jako Business Service se smlouvou o uskladnění
- [ ] Výměnu jako Business Process, balíček jako Business Function celého autoservisu

> Jednotlivě nabízená činnost bez balíčku a podmínek je Business Service; nabídka více služeb se smlouvou jako celek je Product. Modelovat vše jako produkt ztrácí rozlišení, prohození nedává smysl a proces či funkce popisují vnitřní práci, ne nabídku zákazníkovi.

## Contract a SLA {#smlouva .explain}

Contract je specializace Business Object: zachycuje **dohodu** (formální i neformální) o právech a povinnostech, typicky k produktu. Ve scénáři ji poznáš podle slov smlouva, SLA, obchodní podmínky, dohoda o úrovni služeb. Smlouvu agreguje produkt a procesy s ní pracují přes access (např. „Uzavření smlouvy" ji zapisuje). Nezaměňuj ji s požadavkem: Requirement z motivační oblasti popisuje potřebu, kterou má architektura splnit, Contract je uzavřená dohoda mezi stranami.

*Příklad:* `Podpora 24/7 (Product) —aggregation→ SLA podpory (Contract)`; `Sjednání podpory (Business Process) —access (write)→ SLA podpory (Contract)`.

### ? IT outsourcingová firma nabízí produkt „Podpora 24/7"; se zákazníkem uzavírá podepsanou dohodu o dostupnosti 99,9 % a sankcích za nedodržení. Proces „Uzavření kontraktu" tuto dohodu vytváří. Který fragment je správný?

- [ ] `Podpora 24/7 (Product) —aggregation→ SLA (Requirement)`; `Uzavření kontraktu —realization→ SLA (Requirement)`
- [ ] `SLA (Contract) —aggregation→ Podpora 24/7 (Product)`; `SLA —triggering→ Uzavření kontraktu (Business Process)`
- [ ] `Podpora 24/7 (Business Service) —serving→ SLA (Contract)`; `SLA —access (write)→ Uzavření kontraktu`
- [x] `Podpora 24/7 (Product) —aggregation→ SLA (Contract)`; `Uzavření kontraktu (Business Process) —access (write)→ SLA`

> Podepsaná dohoda s právy a povinnostmi je Contract, který produkt agreguje a proces jej zapisuje přes access. Requirement popisuje potřebu, ne uzavřenou dohodu; obrácená agregace a triggering od pasivního objektu jsou chybné a access se nekreslí od objektu k procesu.

### ? Leasingová společnost zachytila „Leasingovou smlouvu" jako Business Process, protože „se smlouva uzavírá a podepisuje". Jaká oprava je nejlepší?

- [ ] Ponechat proces a přidat k němu Business Event „Smlouva podepsána"
- [ ] Změnit smlouvu na Business Service, kterou leasing nabízí klientům
- [x] Smlouvu modelovat jako Contract a uzavírání jako proces s access k ní
- [ ] Změnit smlouvu na Business Interface, přes který klient leasing čerpá

> Smlouva je dohoda, tedy pasivní struktura (Contract); uzavírání a podpis je chování, které ke smlouvě přistupuje. Událost by chybnou volbu typu neopravila, služba popisuje nabízené chování a rozhraní přístupový kanál.

## Pojmenování podle typu prvku {#pojmenovani .explain}

Název napoví typ prvku — a ve scénářích naopak typ prozradí slovní druh v zadání. **Proces**: děj s výsledkem („Vyřízení reklamace", „Sjednat pojistku"). **Funkce**: oblast odpovědnosti („Řízení skladu", „Účetnictví"). **Událost**: nastalý stav („Objednávka přijata", „Lhůta uplynula"). **Služba**: užitek z pohledu spotřebitele („Hlášení škody", „Výplata mzdy"). **Role**: odpovědnost („Schvalovatel", „Pojištěný"). **Aktér**: konkrétní subjekt („Oddělení IT", „Dopravce PPL"). **Objekt**: informace („Faktura"). Jednotné pojmenování pomáhá čtenáři a odhalí chyby — proces pojmenovaný jako útvar nebo událost pojmenovaná jako činnost je signál špatné volby typu.

*Příklad:* `Lhůta pro odvolání uplynula (Business Event) —triggering→ Vydání pravomocného rozhodnutí (Business Process)`.

### ? Ve scénáři úřadu se objevují pojmy: „Podání doručeno", „Správa spisové služby", „Referent", „Vyřízení žádosti". Které přiřazení typů prvků je nejvhodnější (v uvedeném pořadí)?

- [ ] Business Process, Business Function, Business Actor, Business Event
- [ ] Business Event, Business Process, Business Role, Business Service
- [x] Business Event, Business Function, Business Role, Business Process
- [ ] Business Object, Business Function, Business Actor, Business Process

> Nastalý stav je událost, trvalá oblast odpovědnosti funkce, „Referent" odpovědnost (role, kterou hrají různí úředníci) a děj s výsledkem proces. Ostatní možnosti zaměňují událost za proces či objekt, funkci za proces nebo vyřízení za službu.

### ? V modelu nemocnice je prvek „Příjem pacienta" typu Business Event a spouští proces „Hospitalizace". Popis uvádí, že příjem trvá asi 40 minut: sestra ověří pojištění, lékař pacienta vyšetří a zapíše anamnézu. Jak model opravit?

- [x] „Příjem pacienta" modelovat jako Business Process a před něj dát událost „Pacient dorazil"
- [ ] Ponechat událost a přiřadit jí role sestry a lékaře, které příjem pacienta provádějí
- [ ] Změnit „Příjem pacienta" na Business Function, protože se v něm střídá více rolí
- [ ] Změnit „Příjem pacienta" na Business Service, kterou nemocnice nabízí pacientům

> Činnost s trváním, kroky a vykonavateli je proces; okamžik, který ji spouští, je samostatná událost „Pacient dorazil". Ponechání události s rolemi zachová chybný typ, funkce nemá pořadí kroků a služba by popisovala vnější pohled, ne vlastní práci.

## Vnější účastníci a outsourcing {#outsourcing .explain}

Externí organizace (dodavatel, partner, úřad) je **Business Actor**, který hraje roli („Dodavatel mezd", „Dopravce"). Pokud scénář řeší, co od něj firma **dostává**, modeluj jeho Business Service, která slouží vlastnímu procesu firmy; vnitřní kroky dodavatele obvykle nejsou předmětem modelu. Při outsourcingu se tedy nemění vlastní proces spotřebitele, ale **kdo** službu realizuje — dřív vlastní útvar, nyní externí aktér. Chybou je přiřadit externího aktéra přímo vlastnímu procesu firmy, když ho ve skutečnosti nevykonává, jen mu poskytuje službu.

*Příklad:* `MzdyPro s.r.o. (Business Actor) —assignment→ Poskytovatel mezd (Business Role)`; `Zpracování mezd (Business Service) —serving→ Personální řízení (Business Process)`.

### ? Výrobní firma předala zpracování mezd externí firmě MzdyPro. Vlastní personální oddělení dál řídí proces „Personální administrativa", který na výsledky mezd závisí. Jak vyjádřit závislost firmy na dodavateli?

- [ ] `MzdyPro (Business Actor) —assignment→ Personální administrativa (Business Process)`
- [ ] `Personální administrativa (Business Process) —serving→ Zpracování mezd (Business Service)`
- [x] `Zpracování mezd (Business Service) —serving→ Personální administrativa (Business Process)`
- [ ] `MzdyPro (Business Actor) —composition→ Personální administrativa (Business Process)`

> Dodavatel poskytuje službu, která slouží vlastnímu procesu firmy; směr serving vede od poskytovatele ke spotřebiteli. Přiřazení by tvrdilo, že MzdyPro proces firmy vykonává, druhá možnost obrací směr a composition mezi aktérem a procesem není správný vztah.

### ? Logistická firma dosud doručovala vlastním oddělením rozvozu, nyní doručování převezme externí dopravce. Proces „Vyřízení objednávky" i služba „Doručení zásilky" pro zákazníka zůstávají stejné. Co se má v modelu změnit?

- [ ] Služba „Doručení zásilky" se zruší a zákazníkovi bude nově sloužit přímo dopravce
- [x] Roli doručovatele nově hraje externí dopravce místo vlastního oddělení rozvozu
- [ ] Vznikne Business Collaboration firmy a dopravce pro každé jednotlivé doručení
- [ ] Proces „Vyřízení objednávky" se přiřadí dopravci jako novému vykonavateli

> Mění se jen to, kdo zastává roli doručovatele — přiřazení aktéra k roli; služba i proces zůstávají, což je přesně výhoda oddělení rolí a služeb. Zrušení služby by změnilo pohled zákazníka, kolaborace by tvrdila společnou práci a celý proces dopravce nevykonává.

## Typické chyby v business modelech {#typicke-chyby .compare}

Rychlá kontrola modelu — u každé chyby, proč je špatně a jak ji opravit.

| Chyba | Proč je špatně | Oprava |
|---|---|---|
| útvar jako Business Function | útvar je kdo, funkce co | útvar = Business Actor přiřazený funkci nebo roli |
| kanál jako služba nebo proces | kanál je přístupový bod | Business Interface —assignment→ Business Service |
| proces —serving→ služba | služba se realizuje | proces —realization→ služba |
| objekt —triggering→ proces | pasivní struktura nic nespouští | Business Event —triggering→ proces, proces —access→ objekt |
| role —assignment→ aktér | obrácený směr | aktér —assignment→ role |
| interakce pro postupné předávání | nevzniká společným jednáním | proces s kroky přiřazenými rolím |
| balíček se smlouvou jako služba | chybí celek a smluvní rámec | Product —aggregation→ služby a Contract |

### ? Revidujete model e-shopu: `Zákaznická linka (Business Service) —realization→ Řešení dotazů (Business Process)` a `Oddělení podpory (Business Function) —assignment→ Řešení dotazů`. Zákaznická linka je telefonní kanál. Který soubor oprav je správný?

- [x] Linka jako Business Interface ke službě, kterou proces realizuje; oddělení jako Business Actor
- [ ] Linka zůstane službou s obráceným směrem realizace; oddělení se změní na Business Role
- [ ] Linka jako Business Actor, který proces vykonává; oddělení podpory zůstane funkcí
- [ ] Linka jako Business Event spouštějící proces; oddělení jako Business Collaboration

> Telefonní linka je kanál (Business Interface) ke službě, kterou proces realizuje, a oddělení je útvar, tedy Business Actor přiřazený práci. Ostatní možnosti opraví nanejvýš jednu chybu, nebo vnášejí novou (kanál jako aktér či událost, útvar jako kolaborace).

### ? V modelu pojišťovny je současně: (1) `Pojistník (Business Role) —assignment→ Uzavření pojistky (Business Process)`, (2) `Uzavření pojistky —realization→ Sjednání pojištění (Business Service)`, (3) `Pojistka (Business Object) —triggering→ Výplata plnění (Business Process)`, (4) `Sjednání pojištění —serving→ Pojistník`. Který vztah je v rozporu s pravidly jazyka?

- [ ] Vztah 1, protože role nemůže být přímo přiřazena procesu
- [ ] Vztah 2, protože proces nemůže realizovat službu
- [ ] Vztah 4, protože služba nemůže sloužit roli
- [x] Vztah 3, protože pasivní objekt nemůže spouštět chování

> Triggering je dynamický vztah mezi chováními a událostmi; Business Object nic spouštět nemůže, spouštěčem má být událost (např. „Škoda nahlášena"). Přiřazení role procesu, realizace služby procesem i serving od služby k roli jsou běžné a povolené vztahy.
