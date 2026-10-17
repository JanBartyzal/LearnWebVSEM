---
kind: topic
subject: togaf-foundation
slug: adm-prehled
name: "Architecture Development Method — přehled"
order: 2
---

Cyklus ADM a jeho fáze, vstupy a výstupy, iterace (Architecture Context, Architecture Definition, Transition Planning, Architecture Governance), úrovně a rozsah architektury (Strategic, Segment, Capability), přizpůsobení ADM.

## ADM (Architecture Development Method) {#adm .term}

**ADM (metoda vývoje architektury)** je jádro TOGAF Standardu: opakovatelný, fázově členěný postup, jak podnikovou architekturu vytvořit, převést do realizace a dál udržovat. Popisuje, **co** se v jednotlivých krocích dělá a jaké výstupy vznikají, ale nepředepisuje konkrétní nástroje, notaci ani odvětví. Je to **obecná (generická) metoda**, kterou organizace přizpůsobuje svým potřebám.

### ? Co je Architecture Development Method (ADM) v rámci TOGAF Standardu?

- [x] Fázový opakovatelný postup tvorby, zavedení a údržby podnikové architektury
- [ ] Modelovací jazyk s grafickou notací pro kreslení architektonických diagramů
- [ ] Katalog hotových referenčních architektur pro jednotlivá průmyslová odvětví
- [ ] Softwarový nástroj pro správu obsahu architektury a jejích verzí

> ADM je metoda — popisuje postup a výstupy jednotlivých fází. Modelovací jazyk (např. ArchiMate), katalog referenčních architektur ani nástroj pro repozitář ADM není.

### ? Které tvrzení o ADM je správné?

- [ ] ADM je určena výhradně pro IT oddělení a řeší jen technologickou infrastrukturu
- [ ] ADM předepisuje povinnou notaci i konkrétní nástroj pro modelování
- [x] ADM je obecná metoda, kterou lze přizpůsobit různým organizacím a odvětvím
- [ ] ADM je jednorázový projektový postup, který se po dokončení už neopakuje

> ADM je generická a záměrně se přizpůsobuje (tailoring). Pokrývá byznys, data, aplikace i technologie, nevnucuje notaci ani nástroj a je navržena jako opakovaný cyklus.

## Cyklus ADM a pořadí fází {#adm-cyklus .explain}

ADM se kreslí jako **kruh fází**, kterým se postupuje opakovaně. Před vlastním cyklem stojí **Preliminary Phase**, potom následují **Phase A Architecture Vision → B Business Architecture → C Information Systems Architectures → D Technology Architecture → E Opportunities and Solutions → F Migration Planning → G Implementation Governance → H Architecture Change Management**. Ve **středu** kruhu je **Requirements Management**, který je s každou fází propojen. Po fázi H se cyklus může znovu otevřít fází A pro další změnu.

*Příklad:* Banka nejprve připraví architektonickou praxi (Preliminary), pak definuje vizi nového digitálního onboardingu (A), rozpracuje byznys, data, aplikace a technologie (B–D), naplánuje realizaci (E–F), dohlíží na ni (G) a dál řídí změny (H).

### ? Která fáze ADM bezprostředně následuje po Phase D Technology Architecture?

- [ ] Phase F Migration Planning
- [x] Phase E Opportunities and Solutions
- [ ] Phase G Implementation Governance
- [ ] Phase C Information Systems Architectures

> Po dokončení architektur v doménách (B, C, D) přichází Phase E Opportunities and Solutions, kde se hledají způsoby realizace. Migration Planning (F) až po ní.

### ? Co je umístěno ve středu cyklu ADM?

- [ ] Preliminary Phase
- [ ] Architecture Board
- [ ] Phase A Architecture Vision
- [x] Requirements Management

> Requirements Management je ve středu kruhu, protože požadavky se řídí průběžně a jsou propojeny se všemi fázemi. Preliminary stojí před cyklem a Architecture Board je governance orgán, ne fáze.

### ? Které pořadí fází ADM je správné?

- [ ] A → B → D → C → E → G → F → H
- [ ] A → C → B → D → F → E → G → H
- [ ] A → B → C → D → F → E → H → G
- [x] A → B → C → D → E → F → G → H

> Standardní pořadí je Architecture Vision (A), Business (B), Information Systems (C), Technology (D), Opportunities and Solutions (E), Migration Planning (F), Implementation Governance (G) a Architecture Change Management (H).

## Smysl fází: Preliminary až D {#faze-smysl-1 .compare}

První část cyklu připravuje architektonickou praxi a definuje architekturu v jednotlivých doménách.

| Fáze | Hlavní smysl |
|---|---|
| Preliminary Phase | připravit organizaci na architektonickou práci: přístup, principy, přizpůsobený rámec, governance |
| Phase A Architecture Vision | vymezit rozsah a stakeholdery, vytvořit vysokoúrovňovou vizi a získat schválení k zahájení práce |
| Phase B Business Architecture | popsat, jak má podnik fungovat (procesy, organizace, kapability), aby dosáhl cílů |
| Phase C Information Systems Architectures | navrhnout architekturu dat a aplikací podporující byznys |
| Phase D Technology Architecture | navrhnout technologickou platformu (infrastrukturu), na které aplikace a data poběží |

### ? Ve které fázi ADM vzniká vysokoúrovňová vize architektury a získává se souhlas k zahájení architektonické práce?

- [x] Phase A Architecture Vision
- [ ] Preliminary Phase
- [ ] Phase B Business Architecture
- [ ] Phase E Opportunities and Solutions

> Phase A vymezí rozsah, identifikuje stakeholdery, vytvoří Architecture Vision a zajistí schválení. Preliminary připravuje obecnou architektonickou kapabilitu, ne vizi konkrétní iniciativy.

### ? Architekt navrhuje, jaké servery, sítě a platformy budou potřeba pro provoz nových aplikací. Ve které fázi ADM se tato práce typicky odehrává?

- [ ] Phase C Information Systems Architectures
- [ ] Phase G Implementation Governance
- [x] Phase D Technology Architecture
- [ ] Phase F Migration Planning

> Technologickou platformu, na které poběží aplikace a data, řeší Phase D Technology Architecture. Phase C se zabývá daty a aplikacemi, F plánováním migrace a G dohledem nad realizací.

## Smysl fází: E až H {#faze-smysl-2 .compare}

Druhá část cyklu převádí definovanou architekturu do realizace a hlídá, aby zůstala aktuální.

| Fáze | Hlavní smysl |
|---|---|
| Phase E Opportunities and Solutions | najít příležitosti a způsoby realizace, seskupit změny do pracovních balíků, určit přechodové architektury |
| Phase F Migration Planning | sestavit a dokončit plán přechodu (Implementation and Migration Plan, Architecture Roadmap) s prioritami |
| Phase G Implementation Governance | dohlížet, aby realizační projekty odpovídaly architektuře |
| Phase H Architecture Change Management | sledovat změny v podniku a okolí a rozhodovat, jak na ně architektura zareaguje |

### ? Ve které fázi ADM se dohlíží na to, aby realizační projekty skutečně odpovídaly schválené architektuře?

- [ ] Phase F Migration Planning
- [ ] Phase H Architecture Change Management
- [ ] Phase E Opportunities and Solutions
- [x] Phase G Implementation Governance

> Dohled nad realizací je smyslem Phase G Implementation Governance. Phase F připravuje plán přechodu, E hledá způsoby realizace a H řídí změny architektury po jejím zavedení.

### ? Ve které fázi ADM se poprvé hledají způsoby realizace a změny se seskupují do pracovních balíků (work packages)?

- [ ] Phase D Technology Architecture
- [x] Phase E Opportunities and Solutions
- [ ] Phase F Migration Planning
- [ ] Phase G Implementation Governance

> Phase E Opportunities and Solutions je první fáze zaměřená na realizaci: hledá příležitosti a seskupuje změny do pracovních balíků. Phase F z nich pak sestaví detailní plán přechodu.

### ? Organizace zjistila, že se jí výrazně změnilo regulatorní prostředí, a potřebuje posoudit, jak se to promítne do zavedené architektury. Která fáze ADM se tím zabývá?

- [x] Phase H Architecture Change Management
- [ ] Phase G Implementation Governance
- [ ] Phase A Architecture Vision
- [ ] Preliminary Phase

> Sledování změn v podniku a okolí a rozhodování o reakci na ně patří do Phase H. Teprve pokud je změna rozsáhlá, může Phase H vyvolat nový cyklus začínající fází A.

## Preliminary Phase vůči cyklu {#preliminary-mimo-cyklus .explain}

**Preliminary Phase** není jednou z fází, které se opakují pro každou architektonickou iniciativu — stojí **před cyklem** a připravuje „jak budeme architekturu dělat": přístup, principy, přizpůsobený rámec, organizaci a governance. Provádí se při zavádění architektonické praxe a znovu tehdy, když se tato praxe podstatně mění. Jednotlivé architektonické iniciativy pak začínají fází **A**.

*Příklad:* Pojišťovna jednou zřídí architektonický tým a pravidla práce (Preliminary); každý další projekt — nový portál, migrace jádra — už začíná vlastní Architecture Vision ve fázi A.

### ? Pojišťovna už má zavedenou architektonickou praxi a nyní zahajuje novou architektonickou iniciativu pro klientský portál. Kterou fází ADM tato iniciativa obvykle začíná?

- [ ] Preliminary Phase
- [ ] Phase B Business Architecture
- [x] Phase A Architecture Vision
- [ ] Requirements Management

> Nová iniciativa v organizaci se zavedenou praxí začíná fází A (rozsah, stakeholdeři, vize, schválení). Preliminary se opakuje jen při zřízení nebo zásadní změně architektonické praxe.

### ? Co je hlavním smyslem Preliminary Phase?

- [ ] Vytvořit detailní cílovou architekturu všech čtyř domén podniku
- [x] Připravit architektonickou praxi, její principy a rámec
- [ ] Sestavit pořadí realizačních projektů podle přínosu a rizika
- [ ] Ověřit soulad dokončených projektů se schválenou architekturou

> Preliminary připravuje „jak" se bude architektura dělat — přístup, principy, přizpůsobený rámec a governance. Detailní architektura patří do B–D, plán projektů do E–F a kontrola souladu do G.

## Requirements Management uprostřed ADM {#requirements-management-stred .explain}

**Requirements Management** není krok, který by přišel na řadu jednou za cyklus. Je to **průběžný proces**, který po celou dobu přijímá, eviduje a vyhodnocuje požadavky na architekturu a předává je fázím, které je potřebují. Každá fáze z něj čerpá a zároveň do něj vrací nové nebo změněné požadavky. Proto je v diagramu ADM ve středu a propojený se všemi fázemi.

*Příklad:* Během Phase C vznikne nový požadavek na archivaci dat; Requirements Management ho zaeviduje, posoudí dopad a zajistí, aby se s ním počítalo i v dalších fázích.

### ? Jak se v ADM zachází s požadavky na architekturu?

- [ ] Sbírají se jen v Phase A a v dalších fázích se už nemění
- [ ] Řeší je výhradně Phase H po dokončení realizace
- [ ] Zpracovává je až Phase F při plánování migrace
- [x] Řídí se průběžně a jsou propojeny se všemi fázemi

> Requirements Management je průběžný proces ve středu ADM. Požadavky vznikají a mění se v kterékoli fázi a všechny fáze z něj čerpají.

### ? Které tvrzení o Requirements Management v ADM NENÍ správné?

- [ ] Do Requirements Management vstupují požadavky z různých fází cyklu
- [x] Requirements Management se provádí jen jednou, mezi Phase D a Phase E
- [ ] Requirements Management je v diagramu ADM umístěn ve středu cyklu
- [ ] Requirements Management podporuje všechny fáze po celou dobu cyklu

> Requirements Management neprobíhá jednorázově mezi dvěma fázemi — je to průběžný proces propojený se všemi fázemi. Ostatní tvrzení platí.

## Phase C: dvě domény {#phase-c-domeny .term}

**Phase C Information Systems Architectures** zahrnuje dvě architektonické domény: **Data Architecture** a **Application Architecture**. Obě se mohou rozpracovávat postupně v libovolném pořadí nebo souběžně — podle toho, co je v dané iniciativě výhodnější. Spolu s Phase B a Phase D tvoří Phase C část cyklu, kde se architektura **definuje**.

### ? Které architektonické domény pokrývá Phase C Information Systems Architectures?

- [ ] Business a Data
- [ ] Application a Technology
- [x] Data a Application
- [ ] Business a Technology

> Phase C se skládá z Data Architecture a Application Architecture. Business Architecture je Phase B, Technology Architecture je Phase D.

### ? Které tvrzení o pořadí práce ve Phase C je v souladu s TOGAF?

- [x] Obě domény lze rozpracovat v libovolném pořadí nebo souběžně
- [ ] Application Architecture se musí vždy dokončit dříve, než se začne s daty
- [ ] Data Architecture se smí začít až po schválení celé Technology Architecture
- [ ] Data Architecture se ve Phase C řeší jen tehdy, když chybí Business Architecture

> TOGAF nechává pořadí datové a aplikační architektury na konkrétní situaci — lze je řešit jednu po druhé v libovolném pořadí nebo souběžně. Ostatní možnosti zavádějí pravidla, která standard nemá.

## Struktura popisu fáze {#struktura-faze .term}

TOGAF popisuje každou fázi ADM jednotně: **Objectives** (čeho má fáze dosáhnout), **Approach** (jak k ní přistupovat), **Inputs** (co do fáze vstupuje), **Steps** (kroky práce) a **Outputs** (co fáze vytvoří nebo aktualizuje). Díky tomu lze fáze snadno porovnávat a vynechat nebo upravit jen to, co v dané situaci nedává smysl.

### ? Které části TOGAF používá pro jednotný popis každé fáze ADM?

- [ ] Purpose, Roles, Tools, Risks, Metrics
- [ ] Scope, Budget, Schedule, Quality, Approval
- [ ] Vision, Mission, Goals, Drivers, Constraints
- [x] Objectives, Approach, Inputs, Steps, Outputs

> Každá fáze ADM je popsána cíli (Objectives), přístupem (Approach), vstupy (Inputs), kroky (Steps) a výstupy (Outputs). Ostatní sady připomínají řízení projektu nebo strategii, ne strukturu fáze ADM.

### ? Ve které části jednotného popisu fáze ADM najdete, co daná fáze vytvoří nebo aktualizuje?

- [x] Outputs
- [ ] Inputs
- [ ] Steps
- [ ] Objectives

> Co fáze vytvoří nebo aktualizuje, popisují Outputs. Inputs jsou vstupy fáze, Steps postup práce a Objectives cíle, kterých má fáze dosáhnout.

## Vstupy a výstupy fází {#vstupy-vystupy .explain}

Fáze ADM na sebe navazují přes **výstupy (deliverables)**: co jedna fáze vytvoří, slouží jako **vstup** dalších fází. Mnoho výstupů nevzniká naráz — v jedné fázi se založí v hrubé podobě a v dalších fázích se **zpřesňují a aktualizují** (např. vize z Phase A se rozpracuje v B–D). Vstupem mohou být i věci mimo cyklus: strategie podniku, principy, požadavky, existující architektury a referenční materiály z Architecture Repository. Výstupy se ukládají a verzují, aby bylo jasné, která podoba je rozpracovaná a která schválená.

*Příklad:* Architecture Vision vytvořená ve fázi A obsahuje jen náčrt cílové byznysové architektury; Phase B z ní vyjde a vytvoří detailní, se stakeholdery odsouhlasenou verzi.

### ? Jak se v ADM obvykle pracuje s výstupy jednotlivých fází?

- [ ] Každý výstup vzniká v jediné fázi kompletní a později se už nemění
- [x] Slouží jako vstupy dalších fází a postupně se zpřesňují
- [ ] Výstupy se tvoří až po fázi H, kdy je architektura definitivně hotová
- [ ] Výstupy jednotlivých fází jsou na sobě nezávislé a navzájem se nepoužívají

> Fáze na sebe navazují přes výstupy, které se postupně rozpracovávají a aktualizují. Představa jednorázově hotových nebo nezávislých výstupů odporuje iterativní povaze ADM.

### ? Phase A vytvořila vysokoúrovňový náčrt cílové byznysové architektury. Co se s ním děje dál v ADM?

- [ ] Uloží se jako hotová cílová architektura a další fáze ho už nemění
- [ ] Zahodí se a Phase B začíná popis byznysu úplně od začátku
- [x] Phase B ho použije jako vstup a rozpracuje do detailní podoby
- [ ] Předá se rovnou do Phase G jako podklad pro kontrolu projektů

> Výstupy z Phase A jsou vstupem dalších fází; Phase B náčrt zpřesní do detailní byznysové architektury. Hrubý náčrt není konečná podoba a nezahazuje se.

## Iterativní povaha ADM {#adm-iterace .explain}

ADM je **iterativní**, nikoli vodopád, a to na několika úrovních: **v rámci celého procesu** (cyklus se opakuje pro nové iniciativy a změny), **mezi fázemi** (lze se vrátit k dřívější fázi, když nové poznatky změní předpoklady) a **uvnitř fáze** (výstupy fáze se zpřesňují v několika kolech). Iterace umožňují postupně zvyšovat detail a průběžně ověřovat výsledky se stakeholdery.

*Příklad:* Při návrhu aplikační architektury (C) se ukáže, že byznysový proces z fáze B nejde podpořit tak, jak byl navržen; architekt se k fázi B vrátí, proces upraví a pokračuje dál.

### ? Které tvrzení nejlépe vystihuje povahu ADM?

- [ ] ADM je přísně sekvenční vodopád a návrat k dokončené fázi není přípustný
- [ ] ADM se provádí jednou za život organizace a pak se už jen udržuje
- [x] ADM je iterativní v rámci celého procesu, mezi fázemi i uvnitř fází
- [ ] ADM je iterativní pouze uvnitř fáze, pořadí fází se nikdy neopakuje

> ADM je iterativní na všech úrovních: cyklus se opakuje, mezi fázemi se lze vracet a výstupy se uvnitř fáze zpřesňují. Vodopádové pojetí ADM neodpovídá.

### ? Architekt při návrhu ve Phase C zjistí, že předpoklady z Phase B neplatí. Jak to ADM řeší?

- [x] Umožňuje vrátit se k Phase B, upravit ji a pak pokračovat
- [ ] Vyžaduje dokončit celý cyklus a chybu opravit až v Phase H
- [ ] Zakazuje změny dokončených fází, chyba se jen zaznamená
- [ ] Nařizuje okamžitě spustit znovu Preliminary Phase

> Iterace mezi fázemi je v ADM výslovně možná — nové poznatky mohou vést k návratu do dřívější fáze. Čekat na Phase H nebo restartovat Preliminary by bylo zbytečně pomalé a neúměrné.

## Rozhodnutí pro každou iteraci {#rozhodnuti-iterace .explain}

Při každém průchodu ADM se znovu rozhoduje, **jak velký kus práce** se dělá: jakou **šíři podniku** pokrýt, do jaké **hloubky detailu** jít, na jaké **časové období** (včetně mezistupňů) architekturu zaměřit a které **existující architektonické prostředky** (assets) využít — dřívější architektury, referenční modely, vzory. Tato rozhodnutí vycházejí z účelu iniciativy, dostupných zdrojů a pravomoci zadavatele.

*Příklad:* První iterace pokryje celou skupinu v nízkém detailu na pět let; další iterace se zaměří jen na divizi retailu, jde do detailu a horizont zkrátí na dva roky.

### ? O čem se podle TOGAF znovu rozhoduje při každé iteraci ADM?

- [ ] O výběru modelovacího nástroje a notace pro diagramy
- [ ] O složení Architecture Board a jeho hlasovacích pravidlech
- [ ] O tom, zda bude cyklus obsahovat Requirements Management
- [x] O šíři, hloubce, časovém období a využitých prostředcích

> Pro každou iteraci se stanoví šíře pokrytí podniku, úroveň detailu, časové období a architektonické prostředky k využití. Nástroje a složení Architecture Board se neurčují znovu v každé iteraci.

### ? První iterace ADM pokryla celou skupinu v nízkém detailu. Druhá iterace se zaměří jen na retailovou divizi, ale půjde do mnohem většího detailu. Která rozhodnutí iterace se tím změnila?

- [x] Šíře pokrytí podniku a hloubka detailu
- [ ] Časové období a využité architektonické prostředky
- [ ] Architektonické domény a časové období
- [ ] Využité prostředky a architektonické domény

> Zúžení na jednu divizi mění šíři (breadth) a větší podrobnost mění hloubku (depth). O časovém období, doménách ani využitých prostředcích zadání nic neříká.

## Čtyři druhy iteračních cyklů {#iteracni-cykly .compare}

TOGAF seskupuje fáze ADM do čtyř druhů iterací, které lze opakovat samostatně, podle toho, co je zrovna potřeba.

| Iterace | Fáze | K čemu slouží |
|---|---|---|
| Architecture Context iterations | Preliminary, A | zahájit architektonickou práci: zřídit nebo upravit přístup, principy, rozsah a vizi |
| Architecture Definition iterations | B, C, D | vytvářet obsah architektury napříč doménami a ověřovat ho se stakeholdery |
| Transition Planning iterations | E, F | vytvářet formální plány přechodu (roadmapy) pro definovanou architekturu |
| Architecture Governance iterations | G, H | řídit realizaci a změny směřující k cílové architektuře |

### ? Které fáze ADM tvoří Transition Planning iterations?

- [ ] Phase B, C a D
- [ ] Phase G a H
- [x] Phase E a F
- [ ] Preliminary a Phase A

> Transition Planning iterations zahrnují Phase E Opportunities and Solutions a Phase F Migration Planning, které připravují plán přechodu. B–D jsou Architecture Definition, G–H Architecture Governance.

### ? Do kterého druhu iterací patří opakované procházení fází B, C a D při tvorbě obsahu architektury?

- [x] Architecture Definition iterations
- [ ] Architecture Context iterations
- [ ] Transition Planning iterations
- [ ] Architecture Governance iterations

> Opakované procházení domén B, C a D vytváří obsah architektury — to jsou Architecture Definition iterations. Architecture Context se týká zahájení práce (Preliminary, A), Transition Planning fází E–F a Governance fází G–H.

### ? K čemu slouží Architecture Governance iterations?

- [ ] K zřízení architektonického týmu a stanovení architektonických principů
- [x] K řízení realizace a změn směřujících k cílové architektuře
- [ ] K vytváření obsahu byznysové, datové a aplikační architektury
- [ ] K sestavení roadmapy a pořadí realizačních projektů

> Architecture Governance iterations (fáze G a H) dohlížejí na realizaci a řídí změny. Stanovení přístupu a principů patří do Architecture Context, obsah domén do Architecture Definition a roadmapa do Transition Planning.

## Baseline First × Target First {#baseline-target-first .compare}

V iteracích tvorby architektury lze začít buď od současného stavu, nebo od cílového.

| | Baseline First | Target First |
|---|---|---|
| Postup | nejprve se popíše výchozí (Baseline) stav a z něj se odvodí problémy a příležitosti | nejprve se rozpracuje cílová (Target) architektura a pak se porovná s výchozím stavem |
| Kdy se hodí | současný stav je složitý, málo známý nebo sporný (např. po letech autonomie útvarů) | cílový stav je na vysoké úrovni dohodnutý a podnik chce efektivně přejít k novému modelu |
| Riziko | dlouhé mapování současnosti bez jasného směru | přehlédnutí omezení skutečného výchozího stavu |

### ? Koncern vznikl spojením několika firem, jejichž útvary léta budovaly systémy samostatně, a nikdo nemá přehled o současném stavu. Který přístup k iteracím tvorby architektury je zde vhodnější?

- [ ] Target First, protože současný stav není pro architekturu důležitý
- [ ] Target First, protože cílový stav je již podrobně dohodnutý
- [ ] Baseline First, protože ho TOGAF předepisuje pro všechny situace
- [x] Baseline First, protože výchozí stav je složitý a málo známý

> Baseline First se hodí, když je výchozí stav složitý, nepřehledný nebo sporný — jeho popis odhalí problémy a příležitosti. TOGAF nepředepisuje jeden přístup pro všechny situace a o cílovém stavu se v zadání nic dohodnutého neříká.

### ? Vedení firmy už schválilo nový provozní model na vysoké úrovni a chce k němu co nejrychleji přejít. Který přístup k iteracím tvorby architektury se hodí nejlépe?

- [ ] Baseline First, protože vždy musí předcházet úplný popis výchozího stavu
- [x] Target First, protože cíl je na vysoké úrovni už dohodnutý
- [ ] Baseline First, protože cílový model se smí řešit až ve fázi H
- [ ] Target First, protože u něj se výchozí stav vůbec nepopisuje

> Target First se hodí, když je cíl na vysoké úrovni odsouhlasený: rozpracuje se cílová architektura a pak se namapuje na výchozí stav, aby vznikl seznam změn. Výchozí stav se i zde porovnává, jen později.

## Rozsah architektury (Scope) {#rozsah-architektury .term}

Rozsah architektonické práce se v TOGAF vymezuje ve **čtyřech dimenzích**: **Breadth** (šíře — jakou část podniku práce pokrývá), **Depth** (hloubka — do jaké úrovně detailu jde), **Time Period** (časové období — na jaký horizont a s kolika mezistupni se architektura plánuje) a **Architecture Domains** (které z domén Business, Data, Application, Technology zahrnuje).

### ? Které čtyři dimenze používá TOGAF k vymezení rozsahu architektury?

- [ ] Cost, Quality, Time, Risk
- [x] Breadth, Depth, Time Period, Architecture Domains
- [ ] Strategy, Process, People, Technology
- [ ] Baseline, Target, Transition, Gap

> Rozsah architektury se vymezuje šíří, hloubkou, časovým obdobím a zahrnutými architektonickými doménami. Ostatní čtveřice patří k řízení projektů, k modelům organizace nebo k analýze mezer.

### ? Architektonický tým se rozhodl, že nová architektura bude řešit jen pobočkovou síť v Česku a na Slovensku, nikoli centrálu. Kterou dimenzi rozsahu tím stanovil?

- [ ] Depth
- [ ] Time Period
- [ ] Architecture Domains
- [x] Breadth

> Určení, jakou část podniku (útvary, regiony) práce pokrývá, je šíře — Breadth. Depth je úroveň detailu, Time Period horizont a Architecture Domains výběr domén.

## Proč a jak omezit rozsah {#omezeni-rozsahu .explain}

Kompletní architektura by v ideálu pokryla celý podnik ve všech doménách a v plném detailu, ale to je v praxi zřídka proveditelné. Rozsah proto omezují **dostupné zdroje a čas**, **pravomoc zadavatele** (architektura nemá zasahovat tam, kam sponzor nedosáhne) a **účel iniciativy**. Dobře zvolený rozsah vede k výsledku, který je použitelný a dá se dokončit; příliš široký rozsah vede k nekonečné práci bez přínosu.

*Příklad:* Sponzor je ředitel logistiky. Architektura proto pokryje logistické procesy a jejich aplikace a technologie, ale ne finanční účetnictví, o kterém ředitel logistiky nerozhoduje.

### ? Proč TOGAF doporučuje rozsah architektonické práce vědomě omezit?

- [ ] Protože TOGAF dovoluje pokrýt vždy jen jednu architektonickou doménu
- [ ] Protože podrobná architektura je podle TOGAF vždy zbytečná
- [x] Kvůli omezeným zdrojům, času a pravomoci zadavatele práce
- [ ] Protože širší rozsah vyžaduje jinou metodu než ADM

> Rozsah se omezuje, aby byla práce proveditelná v rámci zdrojů a pravomoci sponzora. TOGAF nezakazuje více domén ani detail a ADM se používá pro jakýkoli rozsah.

### ? Sponzorem architektury je ředitel logistiky, který nemá pravomoc nad financemi. Jak by měl architekt nastavit šíři rozsahu?

- [x] Zaměřit se na oblast, o které sponzor rozhoduje, tedy logistiku
- [ ] Pokrýt celý podnik, protože architektura má být vždy celopodniková
- [ ] Zahrnout hlavně finance, protože ty ovlivňují všechny útvary
- [ ] Rozsah nestanovovat a nechat ho vyplynout až z realizace

> Rozsah má odpovídat pravomoci sponzora; jinak architektura navrhuje změny, které nikdo neprosadí. Neurčený rozsah vede k nekonečné práci a celopodnikový rozsah zde přesahuje mandát sponzora.

## Úrovně architektury {#urovne-architektury .compare}

Architekturu lze tvořit na různých úrovních detailu a s různým časovým horizontem; ADM se dá použít na každé z nich.

| | Strategic Architecture | Segment Architecture | Capability Architecture |
|---|---|---|---|
| Pokrytí | celý podnik, souhrnně | vybraná oblast podniku (např. divize, produktová řada, doména) | jedna konkrétní kapabilita a její přírůstky |
| Detail | nízký | střední až vysoký | vysoký, blízko realizaci |
| Časový horizont | dlouhý | střední | krátký |
| Hlavní použití | směr a rámec pro změny na úrovni vedení | řízení programů a portfolií | podpora jednotlivých projektů a pracovních balíků |

### ? Která úroveň architektury slouží jako souhrnný dlouhodobý rámec pro celý podnik a určuje směr na úrovni vedení?

- [ ] Segment Architecture
- [x] Strategic Architecture
- [ ] Capability Architecture
- [ ] Transition Architecture

> Strategic Architecture dává souhrnný dlouhodobý pohled na celý podnik a směr pro vedení. Segment se zaměřuje na oblast podniku, Capability na konkrétní kapabilitu a Transition Architecture je mezistav, ne úroveň.

### ? Architektura popisuje oblast zákaznických služeb jedné divize a slouží k řízení programu změn v této oblasti. O jakou úroveň architektury jde?

- [ ] Strategic Architecture
- [ ] Capability Architecture
- [x] Segment Architecture
- [ ] Baseline Architecture

> Detailnější popis vybrané oblasti podniku sloužící na úrovni programu nebo portfolia je Segment Architecture. Strategic pokrývá celý podnik souhrnně, Capability jednu kapabilitu pro projekty.

### ? Která úroveň architektury je nejblíže realizaci a typicky podporuje jednotlivé projekty?

- [ ] Strategic Architecture
- [ ] Segment Architecture
- [ ] Enterprise Architecture
- [x] Capability Architecture

> Capability Architecture popisuje konkrétní kapabilitu ve vysokém detailu a s krátkým horizontem, takže přímo podporuje projekty a pracovní balíky.

## Vztah úrovní architektury {#vztah-urovni .explain}

Úrovně na sebe navazují **shora dolů**: Strategic Architecture určuje směr a rámec, v jeho mezích vznikají Segment Architectures pro jednotlivé oblasti a z nich Capability Architectures pro konkrétní kapability. Každou z nich lze vytvořit **vlastním průchodem ADM** s odpovídajícím rozsahem; architektura vyšší úrovně dává té nižší kontext, principy a omezení. Zpětně poznatky z nižších úrovní mohou vést k úpravě vyšší.

*Příklad:* Strategická architektura banky stanoví přechod na digitální kanály; segmentová architektura retailového bankovnictví tento směr rozpracuje a kapabilitní architektura „online sjednání úvěru" připraví podklad pro konkrétní projekt.

### ? Jak spolu souvisejí Strategic, Segment a Capability Architecture?

- [ ] Jsou na sobě nezávislé a každá se tvoří jinou metodou než ADM
- [ ] Capability Architecture vzniká jako první a strategická se z ní jen sečte
- [x] Vyšší úroveň dává nižší kontext a rámec, každou lze tvořit průchodem ADM
- [ ] Segment Architecture nahrazuje strategickou, jakmile je schválena

> Úrovně jsou hierarchicky propojené: strategická dává rámec segmentové a ta kapabilitní, přičemž každou lze vytvořit vlastním cyklem ADM. Nejsou nezávislé ani se navzájem nenahrazují.

### ? Při tvorbě segmentové architektury divize narazí architekt na princip, který stanovila strategická architektura celé skupiny a který se mu nehodí. Jak má postupovat?

- [x] Držet se strategického rámce, případně navrhnout jeho úpravu
- [ ] Princip ignorovat, protože segmentová úroveň má přednost
- [ ] Zrušit strategickou architekturu a odvodit ji znovu ze segmentu
- [ ] Odložit problém do Phase G jako nesoulad realizačního projektu

> Vyšší úroveň dává nižší rámec a principy, které se respektují; poznatky zdola mohou vést k návrhu úpravy strategické architektury řádnou cestou. Ignorovat ji nebo ji jednostranně rušit odporuje vztahu úrovní a Phase G se týká realizace, ne tvorby architektury.

## Přizpůsobení ADM (tailoring) {#tailoring .term}

**Přizpůsobení (tailoring)** znamená upravit obecný TOGAF a jeho ADM tak, aby odpovídal konkrétní organizaci a situaci. Týká se zejména **terminologie** (sladit pojmy s jazykem podniku), **procesu** (upravit, sloučit, vynechat nebo přeuspořádat fáze a kroky) a **obsahu** (zvolit výstupy a artefakty, které se budou skutečně tvořit). TOGAF tailoring výslovně předpokládá — není to odchylka od standardu.

### ? Co znamená přizpůsobení (tailoring) ADM?

- [ ] Nahrazení ADM jinou metodou, protože TOGAF nelze měnit
- [x] Úprava generické metody pro konkrétní organizaci
- [ ] Doplnění povinných fází, které ve standardním ADM chybí
- [ ] Převod všech výstupů ADM do jednoho jednotného dokumentu

> Tailoring je úprava generické metody — terminologie, procesu a obsahu — pro konkrétní organizaci. TOGAF ho výslovně předpokládá; nejde o náhradu metody ani o povinné doplňování fází.

### ? Které oblasti se přizpůsobení TOGAF a ADM typicky týká?

- [ ] Výhradně barev a grafiky diagramů v nástroji
- [ ] Jen názvů fází, postup a výstupy zůstávají pevné
- [ ] Pouze výběru dodavatelů realizačních projektů
- [x] Terminologie, procesu (fází a kroků) a obsahu výstupů

> Přizpůsobení se týká terminologie, procesu (fáze a kroky lze upravit, sloučit či přeuspořádat) i obsahu výstupů. Grafika diagramů ani výběr dodavatelů tailoring nevystihují.

## Proč se ADM přizpůsobuje {#tailoring-duvody .explain}

Potřeba upravit ADM vychází z okolností organizace. Typické důvody: **zralost architektonické praxe** (začínající tým začne jednodušeji), **velikost a složitost podniku** (malá firma použije zeštíhlenou verzi, velký koncern federovaný přístup s více propojenými architekturami), **souběh s jinými rámci a metodami** (ADM se napojí na jejich výstupy), **zapojení do širšího firemního řízení** (portfolio, projektové řízení, agilní vývoj) a **zásady podniku**, které mohou změnit i pořadí fází. Míra a podoba přizpůsobení se rozhoduje hlavně v Preliminary Phase.

*Příklad:* Firma s 200 zaměstnanci sloučí fáze E a F a vytváří jen několik klíčových výstupů; nadnárodní skupina naopak nechá každou divizi vést vlastní cykly ADM v rámci společných principů.

### ? Které z uvedených okolností NENÍ typickým důvodem pro přizpůsobení ADM?

- [ ] Organizace současně používá jiný rámec s vlastní sadou výstupů
- [ ] Podnik je malý a potřebuje zeštíhlenou verzi metody
- [x] Standard přikazuje, aby každá organizace měla odlišné fáze
- [ ] Architektonická praxe v organizaci teprve začíná

> Souběh s jiným rámcem, velikost podniku i zralost praxe jsou typické důvody tailoringu. Standard ale nikomu nepřikazuje mít odlišné fáze — přizpůsobení je možnost, ne povinnost.

### ? Malá firma chce používat ADM, ale nemá kapacitu tvořit všechny výstupy ve všech fázích. Co je v souladu s TOGAF?

- [ ] Vzdát se ADM, protože je určena jen pro velké organizace
- [ ] Provádět všechny fáze a výstupy v plném rozsahu bez výjimky
- [ ] Přeskočit Requirements Management a ponechat zbytek beze změny
- [x] Přizpůsobit ADM a omezit se na klíčové výstupy

> TOGAF předpokládá přizpůsobení podle velikosti a zralosti organizace, takže zeštíhlená verze je legitimní. Vzdát se metody je zbytečné, plný rozsah neúměrný a vypuštění řízení požadavků by narušilo celé ADM.

### ? Ve které fázi ADM se zejména rozhoduje o tom, jak bude TOGAF a jeho ADM pro organizaci přizpůsoben?

- [x] Preliminary Phase
- [ ] Phase A Architecture Vision
- [ ] Phase F Migration Planning
- [ ] Phase H Architecture Change Management

> O přizpůsobení rámce a metody se rozhoduje při přípravě architektonické praxe v Preliminary Phase. Phase A už řeší vizi konkrétní iniciativy.

## Pořadí fází není dogma {#poradi-fazi-flexibilni .explain}

Standardní pořadí B → C → D je doporučené výchozí uspořádání, ne nepřekročitelné pravidlo. Podle situace lze fáze **přeuspořádat, sloučit nebo pojmout souběžně** — například když se podnik rozhodne přizpůsobit procesy hotovému softwarovému balíku, může být vhodné začít aplikační architekturou. Podobně lze integrovat ADM s agilním vývojem nebo ji použít jen na část cyklu. Podmínkou je, aby změna byla vědomá, zdůvodněná a v souladu s principy organizace.

*Příklad:* Firma nasazuje standardní ERP balík a podle principu „přizpůsobíme se balíku" nejprve vybírá aplikaci (Phase C) a teprve podle ní upravuje byznysové procesy (Phase B).

### ? Firma se rozhodla nasadit hotový softwarový balík a přizpůsobit mu své procesy. Jak to může ovlivnit průběh ADM?

- [ ] Nijak, pořadí B → C → D je závazné a nelze ho měnit
- [ ] ADM nelze použít, protože počítá jen s vývojem na zakázku
- [x] Může být vhodné začít aplikační architekturou a pak upravit byznys
- [ ] Phase B se zcela vynechá, protože procesy určí dodavatel balíku

> Pořadí fází lze vědomě upravit podle principů podniku; při nasazení balíku může dávat smysl začít aplikační architekturou. Byznysovou architekturu ale nelze vynechat — procesy je třeba popsat a sladit s balíkem.
