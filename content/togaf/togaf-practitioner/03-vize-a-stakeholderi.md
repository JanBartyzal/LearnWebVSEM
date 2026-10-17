---
kind: topic
subject: togaf-practitioner
slug: vize-a-stakeholderi
name: "Vize architektury a stakeholdeři ve scénářích"
order: 3
---

Volba postupu ve Phase A, Business Scenarios, Stakeholder Map, viewpointy a pohledy pro konkrétní stakeholdery, Statement of Architecture Work.

## Kdy a jak zahájit Phase A {#zahajeni-faze-a .explain}

Phase A Architecture Vision se spouští formálním zadáním — **Request for Architecture Work** od sponzora. Bez jmenovaného sponzora, zadání a představy o rozpočtu nemá architekt podle čeho vymezit rozsah ani komu vizi předložit, proto si zadání nejdřív vyžádá. Dále ověří, že existují výstupy Preliminary Phase (přizpůsobený rámec — Tailored Architecture Framework, architektonické principy, governance); pokud chybějí, doplní je dřív, než začne vizi rozvíjet. Prvním krokem samotné fáze je založit architektonický projekt v souladu s tím, jak podnik řídí projekty.

*Příklad:* Ředitel IT na chodbě požádá „nakresli nám cílovou architekturu e-shopu". Architekt nezačne kreslit, ale připraví s ním Request for Architecture Work se sponzorem, cílem, omezeními a termínem.

### ? Ředitel IT pojišťovny neformálně na poradě požádá podnikového architekta, aby „rychle udělal cílovou architekturu" pro nový klientský portál. Není jasné, kdo práci financuje, jaký má rozpočet ani kdo bude výsledek schvalovat. Architekt chce postupovat podle TOGAF ADM. Co je nejlepší další krok?

- [ ] Ihned začít modelovat Target Business Architecture, aby se neztrácel čas
- [x] Vyžádat si formální Request for Architecture Work se sponzorem
- [ ] Sestavit Implementation and Migration Plan podle odhadovaného rozpočtu
- [ ] Svolat Architecture Board ke schválení Architecture Contract na portál

> Phase A začíná formálním zadáním od sponzora; bez něj nelze vymezit rozsah, omezení ani schvalovatele. Modelování cílové architektury je předčasné, Implementation and Migration Plan patří do Phase F a Architecture Contract do Phase G.

### ? Výrobní firma poprvé zavádí podnikovou architekturu. Architekt právě obdržel Request for Architecture Work na sjednocení objednávkových systémů. Zjistí však, že firma nemá definované žádné architektonické principy ani dohodnutý způsob, jak bude architektonická práce řízena a schvalována. Co má udělat nejdřív?

- [ ] Vytvořit Architecture Vision a principy z ní později odvodit zpětně
- [ ] Převzít principy jiné firmy z oboru beze změny a pokračovat ve vizi
- [ ] Principy vynechat, protože pro Phase A nejsou podstatným vstupem
- [x] Doplnit chybějící výstupy Preliminary Phase ještě před tvorbou vize

> Principy a governance z Preliminary Phase jsou měřítkem, podle kterého se vize posuzuje a schvaluje — bez nich chybí kritéria rozhodování. Zpětné odvozování principů z hotové vize je obrací, převzaté cizí principy nemusejí odpovídat firmě a vynechat je nelze.

## Postup ve Phase A v praxi {#postup-faze-a .explain}

Phase A má logický sled: založení projektu → identifikace stakeholderů, jejich zájmů a business požadavků → potvrzení business cílů, driverů a omezení → zhodnocení schopností (capabilities) a připravenosti na změnu → vymezení rozsahu → potvrzení architektonických principů → vytvoření Architecture Vision → definice hodnoty (value propositions) a KPI → identifikace rizik transformace → **Statement of Architecture Work** a jeho schválení. V praxi se kroky překrývají a iterují, ale platí, že **vize vzniká až po porozumění stakeholderům a cílům** a že fáze končí **schváleným** Statement of Architecture Work — teprve pak se přechází do Phases B–D.

*Příklad:* Sponzor chce „obrázek vize" do týdne. Architekt nejdřív během pár rozhovorů zjistí klíčové stakeholdery a jejich zájmy, jinak by vize odpovídala jen jeho vlastním předpokladům.

### ? Architekt logistické firmy má schválený Request for Architecture Work a založený architektonický projekt. Sponzor naléhá, aby už příští týden viděl návrh Architecture Vision. Zatím však nikdo nezjistil, koho se změna týká a jaké mají dotčené útvary požadavky. Co je nejlepší další krok?

- [x] Identifikovat stakeholdery, jejich zájmy (concerns) a business požadavky
- [ ] Nakreslit vizi podle vlastní zkušenosti a stakeholdery oslovit až v Phase B
- [ ] Rovnou zpracovat Statement of Architecture Work a nechat ho podepsat
- [ ] Provést analýzu mezer (Gap Analysis) mezi Baseline a Target architekturou

> Vize má odpovídat zájmům stakeholderů, proto se nejdřív zjišťuje, kdo jsou a co potřebují. Vize bez nich stojí na předpokladech architekta, SoAW bez vize nemá co popsat a Gap Analysis patří do Phases B–D.

### ? Tým dokončil Architecture Vision pro modernizaci skladů, klíčoví stakeholdeři s ní souhlasí a jsou definované KPI i hlavní rizika transformace. Vedoucí týmu chce hned zítra začít s detailní Business Architecture. Co má podle ADM ještě předcházet zahájení Phase B?

- [ ] Uzavřít Architecture Contract s dodavatelem skladového systému
- [ ] Provést Compliance Review rozpracovaných implementačních projektů
- [x] Zpracovat Statement of Architecture Work a získat jeho schválení
- [ ] Navrhnout přechodové architektury (Transition Architectures) skladů

> Phase A končí schváleným Statement of Architecture Work, který potvrzuje rozsah, plán a role pro další práci. Architecture Contract a Compliance Review jsou nástroje Phase G, přechodové architektury vznikají v Phases E–F.

### ? Firma zahajuje Phase A rozsáhlé změny distribučního modelu. Architekt už identifikoval stakeholdery a potvrdil business cíle. Sponzor se ptá, zda organizace i její IT vůbec zvládnou takovou změnu provést, a chce to vědět dřív, než se schválí rozsah. Co je v této situaci nejvhodnější?

- [ ] Odložit otázku až do Phase G, kdy se změna skutečně implementuje
- [ ] Rozhodnout o rozsahu hned a připravenost ověřit až po schválení SoAW
- [ ] Požádat dodavatele o nabídku, z níž bude schopnost firmy zřejmá
- [x] Zhodnotit schopnosti podniku a jeho připravenost na změnu

> Zhodnocení schopností a připravenosti na business transformaci je krokem Phase A a ovlivňuje vymezení rozsahu i rizika. Odkládat ho na implementaci nebo až po schválení je pozdě a nabídka dodavatele schopnost samotné firmy neposoudí.

## Vymezení rozsahu (scope) v praxi {#rozsah-v-praxi .explain}

Rozsah se ve Phase A dohaduje se sponzorem v několika dimenzích: **šíře** (které části podniku), **hloubka** (míra detailu), **časový horizont** a **architektonické domény** (Business, Data, Application, Technology); patří sem i to, které existující architektonické prostředky lze znovu použít. Rozsah musí odpovídat zdrojům, termínům a úrovni architektury (Strategic, Segment, Capability). Je-li požadavek nad možnosti týmu, architekt rozsah zúží nebo práci rozloží do více cyklů ADM — a dohodu zapíše do Statement of Architecture Work.

*Příklad:* Místo „celá skupina, všechny domény, 10 let" se dohodne Segment Architecture pro jednu divizi s horizontem 3 let; ostatní divize přijdou v dalších cyklech.

### ? Sponzor nadnárodního holdingu chce, aby Architecture Vision pokryla všech 40 dceřiných společností, všechny čtyři architektonické domény a horizont deseti let. K dispozici jsou tři architekti a dva měsíce. Co má architekt udělat?

- [ ] Přijmout zadání a mezery v kvalitě vysvětlit až při předání výsledku
- [ ] Vynechat stakeholdery dceřiných firem, aby se práce stihla v termínu
- [ ] Zpracovat jen Technology Architecture, protože ji lze udělat nejrychleji
- [x] Dohodnout se sponzorem zúžení rozsahu, případně rozložení do více cyklů

> Rozsah musí odpovídat zdrojům a termínu; architekt ho proto vyjedná se sponzorem a zapíše do SoAW. Slibovat nesplnitelné, vynechat stakeholdery nebo libovolně zvolit jedinou doménu jsou horší — nic z toho neřeší nesoulad mezi zadáním a kapacitou.

### ? Sponzor a architekt pojišťovny se shodli, kterých divizí se architektonická práce týká a že horizont je tři roky. Na prvním workshopu se ale stakeholdeři přou, zda se mají modelovat jednotlivá rozhraní aplikací, nebo jen hlavní systémy a toky mezi nimi. Kterou dimenzi rozsahu je třeba se sponzorem vyjasnit?

- [ ] Šíři (breadth), tedy které části podniku do práce spadají
- [x] Hloubku (depth), tedy jakou míru detailu má architektura mít
- [ ] Časový horizont, tedy k jakému období se cílový stav vztahuje
- [ ] Architektonické domény, tedy Business, Data, Application, Technology

> Spor o to, jak podrobně modelovat, je otázkou hloubky. Šíře a časový horizont už jsou dohodnuté a výběr domén neříká nic o míře detailu uvnitř domény.

## Business cíle, drivery a omezení {#cile-drivery-omezeni .explain}

Ve Phase A architekt **potvrdí a upřesní** business cíle, drivery (co změnu vyvolává — trh, regulace, konkurence) a omezení (rozpočet, termín, legislativa, smluvní závazky). Pokud jsou cíle zdokumentované, ověří, že jsou aktuální; pokud ne, získá je od stakeholderů. **Protichůdné cíle** se řeší se sponzorem a klíčovými stakeholdery prioritizací ještě před tvorbou vize — architekt je nerozhoduje sám. Omezení se promítnou do rozsahu, plánu a rizik ve Statement of Architecture Work.

*Příklad:* Nová regulace s pevnou účinností je driver i omezení — určuje, co musí být hotové do daného data, a tedy i pořadí prací.

### ? Při rozhovorech ve Phase A uvede finanční ředitel banky, že hlavním cílem je snížení provozních nákladů o 15 %. Obchodní ředitel naopak požaduje expanzi do dvou nových zemí, která bude náklady zvyšovat. Sponzorem projektu je generální ředitel. Jak má architekt postupovat?

- [x] Předložit rozpor sponzorovi a stakeholderům k prioritizaci cílů
- [ ] Zvolit cíl finančního ředitele, protože úspora nákladů je měřitelnější
- [ ] Zahrnout oba cíle beze změny a rozpor nechat na implementační projekty
- [ ] Rozhodnout podle architektonických principů bez účasti vedení firmy

> Prioritu protichůdných business cílů určuje sponzor s klíčovými stakeholdery, architekt rozpor zviditelní a podloží. Volit sám (ať podle měřitelnosti, nebo podle principů) mu nepřísluší a přenechat rozpor implementaci znamená vizi bez jasného směru.

### ? Energetická společnost zahajuje Phase A projektu nového zákaznického účtování. Během zjišťování vyjde najevo, že nová legislativa vyžaduje změnu způsobu fakturace s pevným datem účinnosti za 14 měsíců. Jak má architekt tuto skutečnost ve Phase A zpracovat?

- [ ] Odložit ji do Phase G, kde se kontroluje soulad implementace s architekturou
- [ ] Zapsat ji pouze jako nový architektonický princip podniku
- [x] Zaznamenat ji jako driver i omezení a promítnout ji do rozsahu a plánu
- [ ] Ponechat ji stranou až do sestavení roadmapy ve Phase F

> Legislativa s pevným termínem změnu vyvolává (driver) a zároveň ji omezuje (termín), proto musí ovlivnit rozsah, plán a rizika už ve Phase A. Odklad do pozdějších fází hrozí nesplněním termínu a princip vyjadřuje trvalé pravidlo, ne konkrétní termín.

## Capability Assessment ve Phase A {#capability-assessment .explain}

**Capability Assessment** je výstup Phase A, kterým architekt zjistí, co podnik dnes umí a co bude potřebovat: business schopnosti (capabilities) dotčené změnou, schopnosti IT a zralost samotné architektonické funkce. Výsledek pomáhá realisticky nastavit rozsah a ambice vize a upozorní na schopnosti, které je nutné vybudovat nebo nakoupit. Nezaměňovat s pozdějším plánováním implementace — ve Phase A jde o přehled na vysoké úrovni.

*Příklad:* Banka chce nabízet digitální úvěry. Capability Assessment ukáže, že schopnost „hodnocení bonity" existuje, ale „online ověření identity" chybí — vize s tím musí počítat.

### ? Banka chce zavést zcela digitální poskytování spotřebitelských úvěrů. Vedení si není jisté, zda dnešní procesy, systémy a také malý architektonický tým tento záměr unesou. Architekt je ve Phase A. Který výstup této fáze odpovídá na otázku vedení nejlépe?

- [ ] Architecture Contract mezi architekty a implementačním týmem
- [x] Capability Assessment pokrývající business, IT i EA schopnosti
- [ ] Implementation Factor Catalog se seznamem faktorů pro migraci
- [ ] Compliance Assessment hotových projektů vůči cílové architektuře

> Capability Assessment ve Phase A zhodnotí, co podnik a jeho architektonická funkce umí a co bude třeba vybudovat. Architecture Contract a Compliance Assessment patří k implementační governance a Implementation Factor Catalog k Phase E.

## Architecture Vision jako nástroj {#vize-jako-nastroj .explain}

**Architecture Vision** je stručný, vysokoúrovňový obraz cílového stavu a jeho přínosů — slouží sponzorovi k „prodeji" změny vedení a stakeholderům a k získání souhlasu a financování. Obsahuje popis problému, souhrnné pohledy (např. Solution Concept Diagram), upřesněné klíčové požadavky stakeholderů a **hodnotu pro jednotlivé skupiny stakeholderů s KPI**, podle nichž se pozná úspěch. Detail (konkrétní rozhraní, produkty, datové modely) do vize nepatří — vzniká v Phases B–D.

*Příklad:* Pro představenstvo vize ukazuje, jak nový portál zkrátí vyřízení žádosti ze 14 dní na 2 dny a jaké schopnosti k tomu podnik potřebuje — ne seznam serverů.

### ? Představenstvo pojišťovny je k připravované transformaci skeptické a váhá s uvolněním rozpočtu. Architekt má krátký prostor na jeho zasedání, aby získal podporu. Všechny požadavky jsou zatím jen na vysoké úrovni. Co je nejvhodnější předložit?

- [ ] Kompletní Architecture Definition Document se všemi diagramy domén
- [ ] Detailní Technology Architecture s konkrétními produkty a servery
- [ ] Architecture Requirements Specification k připomínkování členy
- [x] Architecture Vision s přínosy pro stakeholdery a měřitelnými KPI

> Architecture Vision je určena právě k získání podpory a financování — stručně ukazuje hodnotu a úspěch měřený KPI. Kompletní ADD, detailní technologie ani specifikace požadavků se pro rozhodování představenstva nehodí a v této chvíli ještě ani neexistují.

### ? Architektonický tým maloobchodního řetězce strávil ve Phase A už šest týdnů detailním modelováním všech rozhraní mezi 120 aplikacemi. Sponzor zatím neviděl žádný výstup a ptá se, kdy bude moci rozhodnout o pokračování. Co má vedoucí architekt udělat?

- [x] Omezit vizi na vysokou úroveň a detail přesunout do Phases B–D
- [ ] Pokračovat v modelování, protože bez úplného detailu nelze vizi schválit
- [ ] Předat sponzorovi model rozhraní jako Statement of Architecture Work
- [ ] Ukončit Phase A bez vize a přejít rovnou do Phase C Application

> Vize má být rychlá a vysokoúrovňová, aby sponzor mohl rozhodnout; detail rozhraní patří do Information Systems Architectures. Model rozhraní není SoAW a přeskočit vizi by znamenalo pokračovat bez schváleného směru.

### ? Sponzor projektu digitalizace nemocnice schvaluje koncept Architecture Vision a ptá se: „Jak za dva roky poznáme, že se transformace povedla, a co z ní bude mít která skupina zaměstnanců?" Architekt je stále ve Phase A. Co má doplnit?

- [ ] Plán Compliance Reviews jednotlivých implementačních projektů
- [ ] Seznam work packages s odhadem nákladů pro každý z nich
- [ ] Architecture Contract pro každou dotčenou skupinu zaměstnanců
- [x] Value propositions pro skupiny stakeholderů a KPI úspěchu

> Definice hodnoty pro jednotlivé skupiny stakeholderů a KPI je krokem Phase A a odpovídá přesně na otázku sponzora. Compliance Reviews a Architecture Contracts patří do Phase G a work packages s náklady se tvoří až v Phases E–F.

## Artefakty Phase A — kdy který {#artefakty-faze-a .compare}

Typické artefakty, které Phase A vytváří nebo zahajuje:

| Artefakt | Co ukazuje | Kdy ho použít |
|---|---|---|
| Stakeholder Map Matrix | stakeholdery, jejich zapojení, zájmy a artefakty, které je řeší | vždy na začátku — základ řízení stakeholderů |
| Value Chain Diagram | hlavní činnosti, jimiž podnik vytváří hodnotu, a kam změna zasahuje | zasazení změny do kontextu podniku pro vedení |
| Solution Concept Diagram | hrubý koncept řešení a jeho hlavní části | jednostránkový obraz „jak to bude vypadat" pro sponzora |
| Business Capability Map, Value Stream Map | schopnosti podniku a toky hodnoty k zákazníkovi | kde je třeba ukázat, kterých schopností a toků se změna týká |

### ? Sponzor potřebuje na jedné stránce srozumitelně ukázat vedení, jak bude navrhované řešení pro sdílené zákaznické služby zhruba vypadat a z jakých hlavních částí se bude skládat. Detailní architektura zatím neexistuje, firma je ve Phase A. Který artefakt je nejvhodnější?

- [ ] Stakeholder Map Matrix se zapojením jednotlivých stakeholderů
- [x] Solution Concept Diagram s hrubým konceptem navrhovaného řešení
- [ ] Application Communication Diagram s rozhraními mezi systémy
- [ ] Environments and Locations Diagram s umístěním infrastruktury

> Solution Concept Diagram je vysokoúrovňový obraz řešení určený právě pro vizi. Stakeholder Map Matrix řeší stakeholdery, ne řešení, a diagramy komunikace aplikací či prostředí jsou detailní artefakty Phases C a D.

### ? Architekt výrobního podniku chce vedení na začátku Phase A ukázat, jakými hlavními činnostmi firma vytváří hodnotu (od nákupu přes výrobu po servis) a do kterých z nich navrhovaná změna zasáhne. Který artefakt se k tomu hodí nejlépe?

- [ ] Data Entity/Business Function Matrix s vazbami dat na funkce
- [ ] Solution Concept Diagram s komponentami navrhovaného řešení
- [ ] Process Flow Diagram s jednotlivými kroky všech výrobních procesů
- [x] Value Chain Diagram s hlavními hodnototvornými činnostmi firmy

> Value Chain Diagram ukazuje na vysoké úrovni, jak podnik vytváří hodnotu a kde se ho změna dotkne. Solution Concept Diagram popisuje řešení, ne podnik, a matice dat či podrobné procesní toky jsou příliš detailní a patří do Phases B–C.

## Business Scenarios — kdy je použít {#business-scenarios-kdy .explain}

Technika **Business Scenarios** (v 10. vydání popsaná v samostatném Series Guide) pomáhá, když jsou business požadavky **nejasné nebo nesouvisle formulované**: popíše skutečný business problém, prostředí, v němž vzniká, měřitelné cíle a lidi i systémy, kteří se na něm podílejí. Tím propojí potřeby businessu s architekturou a pomůže získat souhlas stakeholderů. Typicky se používá ve Phase A k odvození vize a klíčových požadavků, ale lze ji použít i později, kde je potřeba požadavky upřesnit. Začíná se **problémem, ne technologií**.

*Příklad:* Manažeři říkají „potřebujeme lepší IT", dodavatelé nabízejí produkty. Business Scenario ukáže, že problémem je ve skutečnosti tři dny trvající schvalování objednávek.

### ? Vedení obchodního řetězce opakovaně říká, že „potřebuje lepší IT". Nikdo však neumí konkrétně popsat, jaký problém se má řešit, a dodavatelé už nabízejí různé produkty. Architekt je na začátku Phase A a potřebuje získat jasné business požadavky pro vizi. Která technika je nejvhodnější?

- [ ] Gap Analysis mezi současnými systémy a nabízenými produkty dodavatelů
- [x] Business Scenario popisující problém, prostředí, cíle a aktéry
- [ ] Compliance Review nabídek dodavatelů vůči standardům podniku
- [ ] Interoperability Requirements mezi dnešními systémy řetězce

> Business Scenario je určen právě k odhalení a popisu skutečného business problému a měřitelných cílů, z nichž vzniknou požadavky. Ostatní techniky předpokládají, že je už jasné, co se řeší, a srovnávat produkty před definicí problému je předčasné.

### ? Tým logistické firmy připravuje Business Scenario pro novou plánovací platformu. První workshop začal sestavením seznamu cloudových služeb a databází, které by se mohly použít. Popis toho, co firmu dnes trápí, zatím chybí. Co má architekt změnit?

- [ ] Doplnit k seznamu technologií odhad nákladů a pokračovat dál
- [ ] Nechat seznam schválit Architecture Board jako cílový standard
- [x] Začít popisem business problému a teprve z něj odvodit cíle a aktéry
- [ ] Přesunout workshop do Phase D, kam technologie logicky patří

> Business Scenario stojí na skutečném business problému — technologie jsou až důsledkem. Doplnit náklady či schvalovat seznam jako standard nic nemění na chybějícím problému a přesun do Phase D by požadavky pro vizi vůbec nezískal.

## Obsah Business Scenario a SMART cíle {#obsah-business-scenario .explain}

Business Scenario popisuje: **business problém**; **business a technické prostředí**, v němž problém vzniká; **cíle a měřítka úspěchu**; **lidské aktéry** (human actors) a **systémové aktéry** (computer actors); jejich **role a odpovědnosti**; a vše se se stakeholdery **iterativně upřesňuje**. Cíle mají být **SMART** — konkrétní (Specific), měřitelné (Measurable), lze podle nich jednat (Actionable), realistické (Realistic) a časově ohraničené (Time-bound); jinak z nich nelze odvodit požadavky ani KPI.

*Příklad:* Ne „zlepšit spokojenost zákazníků", ale „zkrátit vyřízení reklamace z 10 na 3 pracovní dny do konce roku 2027".

### ? V Business Scenario e-shopu zní hlavní cíl „zlepšit spokojenost zákazníků s reklamacemi". Architekt ví, že z takto formulovaného cíle nepůjde odvodit požadavky ani KPI. Která formulace cíle nejlépe odpovídá požadavku SMART?

- [x] Zkrátit vyřízení reklamace z 10 na 3 pracovní dny do konce roku 2027
- [ ] Výrazně zlepšit spokojenost zákazníků s reklamacemi v příštích letech
- [ ] Zavést moderní reklamační systém, který zákazníky potěší a zaujme
- [ ] Zvýšit kvalitu reklamačního procesu na úroveň nejlepších firem v oboru

> SMART cíl je konkrétní (Specific), měřitelný (Measurable), lze podle něj jednat (Actionable), je realistický (Realistic) a časově ohraničený (Time-bound) — to splňuje jen zkrácení na 3 dny do konce roku 2027. Ostatní formulace postrádají měřítko nebo termín, případně popisují prostředek (systém), ne cíl.

### ? Business Scenario pro elektronické předepisování léků už jasně popisuje problém, prostředí a SMART cíle. Při revizi se stakeholdery se ale ukáže, že nikdo neví, kdo v procesu co dělá — lékař, lékárník, pojišťovna — a které informační systémy se ho účastní. Co je třeba do scénáře doplnit?

- [ ] Podrobný Technology Architecture model všech dotčených serverů
- [x] Lidské a systémové aktéry a jejich role a odpovědnosti
- [ ] Architecture Contract mezi lékaři, lékárnami a pojišťovnami
- [ ] Seznam work packages a přechodových architektur projektu

> Business Scenario popisuje lidské i systémové aktéry a jejich role a odpovědnosti — právě to chybí. Technologický model je příliš detailní, Architecture Contract slouží implementační governance a work packages vznikají až v Phases E–F.

## Řízení stakeholderů — postup {#rizeni-stakeholderu-postup .explain}

Technika **Stakeholder Management** se uplatňuje hned na začátku Phase A a průběžně v celém ADM: (1) **identifikovat** stakeholdery — i ty, kteří mohou změnu zablokovat; (2) **klasifikovat jejich postoje** — schopnost změnu narušit, současné × potřebné porozumění a současná × potřebná podpora; (3) **určit přístup** k řízení (např. podle mřížky moc/zájem); (4) **přizpůsobit výstupy pro zapojení** — které pohledy a artefakty komu a kdy předložit. Výsledky se zapisují do Stakeholder Map Matrix a promítají do Communications Plan. Stakeholdeři se v čase mění, proto se analýza aktualizuje.

*Příklad:* Vedoucí provozu, kterého nikdo neoslovil, zablokuje projekt až ve Phase B — chyba vznikla už v kroku identifikace a klasifikace.

### ? Architektonický projekt v telekomunikační firmě dospěl do Phase B, když ředitel provozu, kterého nikdo předtím nekonzultoval, odmítl navržené změny a projekt zastavil. Při retrospektivě tým hledá, co podle TOGAF zanedbal. Co mělo nejlépe předejít této situaci?

- [ ] Podrobnější Gap Analysis v Business Architecture během celé Phase B
- [ ] Častější Compliance Reviews během implementačních projektů
- [ ] Rychlejší podpis Architecture Contract s ředitelem provozu
- [x] Identifikace a klasifikace stakeholderů včetně vlivu už ve Phase A

> Stakeholdery s vlivem je třeba identifikovat a klasifikovat hned ve Phase A, aby se s nimi pracovalo od začátku. Gap Analysis ani Compliance Reviews chybějícího stakeholdera neodhalí a Architecture Contract je dohoda o souladu implementace, ne nástroj získání podpory.

### ? Architekt univerzity sestavil seznam všech stakeholderů projektu nového studijního systému — vedení, fakulty, studijní oddělení, studenty, IT a ministerstvo. Teď chce zjistit, jak jednotlivé skupiny změně rozumějí, jak ji podporují a nakolik ji mohou narušit. Který krok řízení stakeholderů tím provádí?

- [x] Klasifikaci postojů stakeholderů (Classify Stakeholder Positions)
- [ ] Přizpůsobení výstupů pro zapojení jednotlivých stakeholderů do práce
- [ ] Vytvoření Communications Plan s kanály a frekvencí sdělení
- [ ] Definici value propositions a KPI pro cílovou architekturu

> Hodnocení porozumění, podpory a schopnosti narušit změnu je klasifikace postojů, druhý krok techniky. Přizpůsobení výstupů a komunikační plán na ni teprve navazují a value propositions s KPI se týkají přínosů vize, ne postojů.

## Mřížka moc × zájem (Power/Interest Grid) {#mrizka-moc-zajem .compare}

Podle moci (vlivu na rozhodnutí) a zájmu o změnu se zvolí přístup ke stakeholderovi:

| | Nízký zájem | Vysoký zájem |
|---|---|---|
| **Vysoká moc** | **Keep Satisfied** — udržovat spokojené, informovat o tom, co je pro ně podstatné, nezahlcovat | **Key Players** — plně zapojit, konzultovat rozhodnutí, řídit nejpečlivěji |
| **Nízká moc** | **Minimal Effort** — sledovat, obecná informace | **Keep Informed** — pravidelně informovat, vtáhnout jejich znalosti |

Postavení není trvalé — změna organizace nebo regulace může stakeholdera přesunout do jiného kvadrantu, proto se mřížka aktualizuje.

### ? Finanční ředitel výrobní firmy rozhoduje o rozpočtu transformace, ale o architektonické detaily se nezajímá a na workshopy nechodí. Architekt potřebuje zvolit vhodný přístup k němu podle mřížky moc × zájem. Který přístup je nejvhodnější?

- [ ] Key Players — zvát ho na všechny pracovní workshopy architektů
- [ ] Keep Informed — posílat mu pravidelně všechny pracovní výstupy
- [x] Keep Satisfied — informovat ho o tom, co je pro něj podstatné
- [ ] Minimal Effort — pouze ho sledovat, protože nemá o změnu zájem

> Vysoká moc a nízký zájem odpovídají kvadrantu Keep Satisfied: je třeba udržet jeho podporu bez zahlcování detaily. Plné zapojení by ho obtěžovalo, zasílání všech výstupů je přístup pro zájemce bez moci a pouhé sledování ignoruje jeho rozhodující vliv.

### ? Vedoucí směn zákaznického centra nemají vliv na rozhodnutí o novém CRM, ale změna zásadně ovlivní jejich každodenní práci a o projekt se živě zajímají. Mají navíc cenné znalosti o tom, kde dnešní systém selhává. Jaký přístup je podle mřížky moc × zájem nejvhodnější?

- [ ] Minimal Effort — sledovat je a informovat jen obecně
- [x] Keep Informed — pravidelně je informovat a využít jejich znalosti
- [ ] Keep Satisfied — informovat je pouze o tom, co se jich přímo týká
- [ ] Key Players — svěřit jim schvalování klíčových rozhodnutí

> Nízká moc a vysoký zájem odpovídají kvadrantu Keep Informed; jejich znalosti je navíc vhodné vtáhnout do práce. Minimal Effort by podcenil jejich zájem, Keep Satisfied je přístup pro vlivné, ale nezaujaté a schvalovací pravomoc jim nepřísluší.

### ? Provozní ředitel železničního dopravce je zároveň hlavním sponzorem projektu nového řízení údržby, rozhoduje o jeho financování a sám se aktivně účastní řídicích výborů. Jaký přístup k němu je podle mřížky moc × zájem nejvhodnější?

- [x] Key Players — plně ho zapojit a konzultovat s ním klíčová rozhodnutí
- [ ] Keep Satisfied — informovat ho jen o souhrnných výsledcích projektu
- [ ] Keep Informed — posílat mu zprávy, ale rozhodovat bez jeho účasti
- [ ] Minimal Effort — sledovat ho, protože sponzor podporu už vyjádřil

> Vysoká moc i vysoký zájem znamenají kvadrant Key Players, s nímž se pracuje nejintenzivněji. Ostatní přístupy by omezily zapojení člověka, který o projektu rozhoduje a o výsledek se aktivně zajímá.

### ? Ve Phase A byl úřad dozoru nad trhem zařazen mezi stakeholdery s nízkou mocí a nízkým zájmem. Uprostřed projektu vyjde nová regulace, podle níž bude úřad schvalovat klíčové změny zákaznických systémů. Co má architekt udělat?

- [ ] Ponechat zařazení beze změny, protože klasifikace proběhla ve Phase A
- [ ] Vyřadit úřad ze stakeholderů, protože není součástí organizace
- [x] Přehodnotit postavení úřadu v mřížce a upravit přístup k jeho zapojení
- [ ] Počkat s reakcí do Phase H, kdy se řeší změny architektury

> Postavení stakeholderů se v čase mění, a proto se analýza aktualizuje — úřad nově získal výraznou moc. Trvat na původním zařazení, vyřadit externího stakeholdera nebo čekat do Phase H by vedlo k riziku zablokování projektu.

## Stakeholder Map Matrix a Communications Plan {#stakeholder-map-komunikace .explain}

**Stakeholder Map Matrix** zachycuje pro každého stakeholdera, proč je pro práci důležitý (zapojení), do které třídy patří (např. kvadrant mřížky), jaké má zájmy a **které pohledy či artefakty jeho zájmy řeší**. Slouží jako most mezi analýzou stakeholderů a výběrem viewpointů. **Communications Plan** je výstup Phase A, který určuje, komu, co, kdy a jakým kanálem sdělovat — zvlášť důležitý u velkých nebo geograficky rozptýlených organizací, kde se jinak informace šíří neřízeně. Obojí se v průběhu ADM aktualizuje.

*Příklad:* V matici je u ředitele logistiky uvedeno „Key Player — zájem: dostupnost zásob — artefakty: Value Chain Diagram, Business Capability Map"; komunikační plán mu určuje měsíční osobní briefing.

### ? Architekt potřebuje na jednom místě evidovat pro každého stakeholdera projektu, proč je pro práci podstatný, do které skupiny podle mřížky moc × zájem patří, jaké má zájmy a které artefakty mu budou předkládány. Který artefakt TOGAF k tomu slouží?

- [ ] Architecture Principles
- [x] Stakeholder Map Matrix
- [ ] Requirements Impact Assessment
- [ ] Implementation Factor Catalog

> Stakeholder Map Matrix spojuje stakeholdery s jejich zájmy, zařazením a artefakty, které je řeší. Principy jsou pravidla rozhodování, Requirements Impact Assessment hodnotí dopad změny požadavků a Implementation Factor Catalog patří do Phase E.

### ? Nadnárodní potravinářská firma s pobočkami ve 30 zemích zahajuje transformaci dodavatelského řetězce. Sponzor se obává, že se zaměstnanci o změnách dozvědí z neoficiálních zdrojů a vzniknou zbytečné obavy. Stakeholdeři už jsou identifikovaní a klasifikovaní. Který výstup Phase A má architekt připravit?

- [ ] Architecture Contract se všemi pobočkami o dodržení architektury
- [ ] Architecture Roadmap s pořadím nasazení v jednotlivých zemích
- [ ] Architecture Requirements Specification pro komunikační systémy
- [x] Communications Plan určující komu, co, kdy a jak sdělovat

> Communications Plan je výstup Phase A, který řídí, jak a kdy se jednotlivým skupinám komunikuje. Architecture Contract slouží implementační governance, roadmapa vzniká až v Phases E–F a specifikace požadavků na komunikační systémy neřeší komunikaci se stakeholdery.

## Volba viewpointu a tvorba pohledu {#volba-viewpointu .explain}

Postup je vždy od stakeholdera: zjistit jeho **zájmy (concerns)** → zvolit **hledisko (viewpoint)**, které tyto zájmy řeší (přednostně znovu použít existující, např. z Architecture Repository, jinak vytvořit nové) → podle něj vytvořit **pohled (view)** na konkrétní architekturu → **ověřit** se stakeholderem, že jeho zájmy pokrývá. Viewpoint je znovupoužitelná šablona (pro koho, jaké zájmy, jaké konvence), view je její konkrétní naplnění. Jeden stakeholder obvykle potřebuje několik pohledů a jeden pohled může sloužit více stakeholderům se stejnými zájmy — nikdy však nemá smysl ukazovat všem tentýž detailní diagram.

*Příklad:* Bezpečnostní manažer chce v každém projektu vidět, kde se zpracovávají osobní údaje. Architekt definuje jeden viewpoint „ochrana osobních údajů" a podle něj vytváří pohledy v jednotlivých projektech.

### ? Architekt předložil představenstvu banky podrobný diagram síťové infrastruktury s desítkami serverů, aby ukázal přínos nové architektury. Členové představenstva byli zmatení a ptali se hlavně na náklady, rizika a dopad na klienty. Jak má architekt postupovat příště?

- [ ] Doplnit diagram o legendu a podrobnější popis jednotlivých serverů
- [x] Zvolit viewpoint řešící jejich zájmy a vytvořit podle něj pohled
- [ ] Předložit jim stejný diagram, ale rozdělený do několika menších částí
- [ ] Přenechat prezentaci provoznímu týmu, který infrastrukturu zná nejlépe

> Pohled se vytváří podle viewpointu odvozeného ze zájmů konkrétního stakeholdera — tady nákladů, rizik a dopadu na klienty. Legenda, rozdělení ani jiný prezentující nic nemění na tom, že infrastrukturní pohled tyto zájmy neřeší.

### ? Bezpečnostní manažerka pojišťovny chce, aby každý architektonický projekt jednotně ukazoval, kde se zpracovávají osobní údaje a jaká opatření je chrání. Architekt má připravit něco, co se bude opakovaně používat ve všech projektech se stejnými konvencemi zápisu. Co má vytvořit?

- [ ] Pohled (view) na architekturu aktuálně běžícího projektu
- [ ] Architecture Contract s každým týmem o ochraně údajů
- [x] Hledisko (viewpoint) definující zájmy, konvence a notaci
- [ ] Pracovní balík (work package) se zavedením ochrany údajů

> Znovupoužitelná šablona s určením zájmů a konvencí je viewpoint; konkrétní pohledy se pak podle něj tvoří v jednotlivých projektech. Jediný view platí jen pro jednu architekturu, Architecture Contract řeší soulad implementace a work package je jednotka plánování.

### ? Architekt nastupuje do firmy, která má zavedené Architecture Repository s hledisky (viewpoints) z předchozích projektů. Pro nový projekt potřebuje ukázat vedoucím prodejen, jak se změní jejich procesy. Podobný zájem už v minulosti řešil jiný projekt. Jak má postupovat?

- [ ] Vytvořit zcela nové hledisko, aby odpovídalo jen tomuto projektu
- [ ] Použít libovolný hotový pohled z dřívějšího projektu beze změny
- [ ] Vynechat výběr hlediska a kreslit diagramy podle vlastního uvážení
- [x] Znovu použít existující hledisko, případně ho upravit, a ověřit pohled

> TOGAF doporučuje přednostně znovu použít existující viewpointy a podle potřeby je přizpůsobit; výsledný pohled se ověří se stakeholdery. Nové hledisko od nuly plýtvá prací, starý pohled popisuje jinou architekturu a kreslení bez hlediska ztrácí vazbu na zájmy.

## Pohledy pro typické stakeholdery {#pohledy-pro-stakeholdery .compare}

Orientační přiřazení — vždy rozhodují skutečné zájmy konkrétního stakeholdera:

| Stakeholder | Typické zájmy | Vhodné pohledy / artefakty |
|---|---|---|
| Vrcholové vedení, sponzor | strategie, hodnota, náklady, rizika | Architecture Vision, Value Chain, Business Capability Map, Solution Concept |
| Vedoucí business útvarů, koncoví uživatelé | změna procesů a každodenní práce | procesní pohledy (Process Flow, Business Use-Case), Organization/Actor |
| Programový a projektový manažer | rozsah, harmonogram, závislosti | Architecture Roadmap, work packages, přechodové architektury |
| IT provoz, infrastruktura | dostupnost, výkon, hosting | technologické pohledy (např. Environments and Locations) |
| Bezpečnost, compliance | ochrana dat, soulad s regulací | bezpečnostní pohledy, matice dat a přístupů |

### ? Personální ředitelka se ptá, jak nový HR systém změní každodenní práci personalistek — které kroky odpadnou a co budou dělat jinak. Architekt potřebuje zvolit pohled, který na tuto otázku nejlépe odpoví. Který je nejvhodnější?

- [ ] Environments and Locations Diagram s umístěním serverů HR systému
- [ ] Architecture Roadmap s harmonogramem nasazení jednotlivých modulů
- [x] Procesní pohled (Process Flow) na budoucí personální procesy
- [ ] Data Lifecycle Diagram se stavy záznamů o zaměstnancích v databázi

> Zájmem je změna každodenní práce, kterou nejlépe ukazuje procesní pohled. Infrastrukturní diagram řeší hosting, roadmapa harmonogram a životní cyklus dat technické stavy záznamů — žádný z nich neodpovídá na otázku ředitelky.

### ? Vedoucí IT provozu nemocnice má obavy, zda nový laboratorní systém zvládne nepřetržitý provoz, kde poběží a jak bude zálohovaný. Architekt chce jeho zájmy pokrýt vhodným pohledem. Co je nejlepší volba?

- [x] Technologický pohled s prostředími, umístěním a provozními vazbami
- [ ] Value Chain Diagram s hlavními činnostmi nemocnice a jejich vazbami
- [ ] Business Capability Map se schopnostmi laboratorního úseku nemocnice
- [ ] Stakeholder Map Matrix se zapojením lékařů a laborantů do projektu

> Dostupnost, umístění a zálohování jsou zájmy, které řeší technologické pohledy. Value Chain a Capability Map jsou určené vedení a Stakeholder Map Matrix eviduje stakeholdery, nepopisuje provoz systému.

## Statement of Architecture Work v praxi {#soaw-v-praxi .explain}

**Statement of Architecture Work** (SoAW) je dohoda mezi architektonickým týmem a sponzorem o tom, co se v cyklu ADM udělá. Obsahuje mimo jiné: podnět a pozadí práce, popis a **rozsah**, přehled vize, způsob řízení, **postup při změně rozsahu**, role, odpovědnosti a výstupy, **kritéria a postup převzetí**, plán a harmonogram a schválení. Schvaluje ho sponzor (a podle zavedené governance případně další orgány, např. Architecture Board). Požaduje-li sponzor později rozšíření rozsahu, nepostupuje se neformálně, ale podle postupu změny rozsahu — SoAW se aktualizuje a znovu schválí.

*Příklad:* Uprostřed Phase B chce sponzor přidat další divizi. Architekt posoudí dopad na harmonogram a zdroje, upraví SoAW a nechá ho znovu schválit.

### ? Statement of Architecture Work pro modernizaci účetnictví byl schválen a tým pracuje ve Phase B. Sponzor nyní žádá, aby architektura zahrnula i mzdovou agendu, která původně v rozsahu nebyla. Termín dokončení se nemá měnit. Co má architekt udělat?

- [ ] Mzdy tiše zahrnout a chybějící kapacitu dohnat přesčasy týmu
- [ ] Požadavek odmítnout, protože schválený SoAW už nelze nikdy měnit
- [ ] Mzdy zpracovat až v Phase H jako změnu hotové architektury
- [x] Použít postup změny rozsahu a upravený SoAW znovu schválit

> SoAW obsahuje postup při změně rozsahu; architekt posoudí dopad na termín a zdroje a upravený SoAW nechá schválit. Tiché rozšíření ohrožuje kvalitu i termín, SoAW měnit lze a Phase H řeší změny již zavedené architektury, ne rozšíření rozpracované práce.

### ? Na konci cyklu ADM se sponzor a architektonický tým přou, zda je architektura „hotová" — sponzor očekával další pohledy, tým má za to, že dodal vše dohodnuté. Při dalším projektu chtějí podobnému sporu předejít. Kterou část Statement of Architecture Work by měli pečlivě dohodnout?

- [ ] Popis podnětu a pozadí architektonické práce
- [x] Kritéria a postup převzetí (acceptance criteria)
- [ ] Přehled Architecture Vision a jejích přínosů
- [ ] Seznam architektonických principů podniku

> Kritéria a postup převzetí určují, kdy je práce dokončená a jak se převezme — přesně to v tomto sporu chybělo. Pozadí, přehled vize ani principy hranici „hotovo" nevymezují.

### ? Architekt dopracoval Statement of Architecture Work pro konsolidaci datových center včetně rozsahu, plánu a rolí. Organizace má zavedený Architecture Board. Kdo by měl dokument především schválit, aby mohla začít práce na Phases B–D?

- [ ] Vedoucí dodavatele, který bude datová centra stěhovat
- [ ] Zástupci koncových uživatelů dotčených aplikací
- [x] Sponzor práce, případně i Architecture Board podle governance
- [ ] Architektonický tým sám, protože dokument sám připravil

> SoAW je dohoda se sponzorem, který ho schvaluje; podle zavedené governance se může přidat i Architecture Board. Dodavatel ani koncoví uživatelé schvalovací roli nemají a tým nemůže schvalovat vlastní zadání.

## Request × Statement × Vision × Contract {#rfaw-soaw-vize-contract .compare}

Čtyři dokumenty, které se ve scénářích snadno zamění:

| Dokument | Kdo ho tvoří | Kdy | K čemu slouží |
|---|---|---|---|
| Request for Architecture Work | sponzor (s architekty) | spouští Phase A | zadání: cíle, omezení, rozpočet, termíny |
| Architecture Vision | architekt se stakeholdery | Phase A | vysokoúrovňový obraz cíle a přínosů pro získání podpory |
| Statement of Architecture Work | architekt, schvaluje sponzor | závěr Phase A | dohoda o rozsahu, plánu, rolích a převzetí architektonické práce |
| Architecture Contract | architekti s implementátory | Phase G | závazek implementace dodržet architekturu |

### ? Dodavatel, který bude implementovat nový bankovní systém, se má formálně zavázat, že jeho řešení bude v souladu se schválenou cílovou architekturou a že bude podléhat kontrolám souladu. Který dokument je k tomu určen?

- [ ] Statement of Architecture Work
- [ ] Request for Architecture Work
- [x] Architecture Contract
- [ ] Architecture Vision

> Architecture Contract je dohoda s implementátory o dodržení architektury, používaná v Phase G. SoAW je dohoda architektů se sponzorem o architektonické práci, Request for Architecture Work je zadání a vize je vysokoúrovňový obraz cíle.

### ? Ve Phase A potřebuje architekt dohledat, jaký rozpočet, časové limity a podnikatelská omezení stanovil sponzor ve chvíli, kdy architektonickou práci inicioval. Který dokument tyto informace obsahuje jako výchozí zadání?

- [ ] Architecture Contract
- [ ] Communications Plan
- [ ] Compliance Assessment
- [x] Request for Architecture Work

> Request for Architecture Work je zadání od sponzora, které spouští Phase A a obsahuje cíle, omezení, rozpočet a termíny. Architecture Contract a Compliance Assessment patří do Phase G a Communications Plan řídí komunikaci se stakeholdery.
