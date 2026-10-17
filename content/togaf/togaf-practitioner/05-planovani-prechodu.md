---
kind: topic
subject: togaf-practitioner
slug: planovani-prechodu
name: "Plánování přechodu (E–F) ve scénářích"
order: 5
---

Transition Architectures, work packages, Implementation Factor Catalog, Consolidated Gaps, Solutions and Dependencies Matrix, Business Value Assessment, prioritizace a roadmapa.

## Phase E × Phase F: na jakou otázku která fáze odpovídá {#e-vs-f .compare}

Obě fáze plánují přechod od výchozí k cílové architektuře, ale každá řeší jinou část úlohy. Typická chyba v praxi je přeskočit Phase E a začít rovnou s harmonogramem projektů.

| | Phase E Opportunities and Solutions | Phase F Migration Planning |
|---|---|---|
| Hlavní otázka | Jakými řešeními a v jakých krocích se dostaneme k cíli? | V jakém pořadí, s jakými zdroji a s jakou hodnotou to provedeme? |
| Klíčové činnosti | konsolidace mezer z Phases B–D, závislosti a interoperabilita, Implementation and Migration Strategy, seskupení work packages, identifikace Transition Architectures | sladění s řídicími rámci podniku, business value pro work packages, odhad zdrojů a termínů, prioritizace (náklady/přínosy, rizika), uzavření cyklu |
| Architecture Roadmap | první úplná verze | finalizovaná verze |
| Implementation and Migration Plan | počáteční verze (hlavně strategie) | dokončený plán |
| Chyba, které se vyvarovat | plánovat termíny dřív, než jsou mezery konsolidované | znovu otevírat definici cílové architektury místo plánování |

### ? Pojišťovna dokončila Phases B, C a D; každá doména předala vlastní seznam mezer a kandidátních komponent Roadmap. Programový manažer chce hned sestavit harmonogram projektů s termíny a rozpočty. Architekt vidí, že se mezery mezi doménami překrývají a vzájemně na sobě závisejí. Co má architekt udělat jako nejlepší další krok?

- [ ] Sestavit harmonogram podle požadavku a překryvy mezer sladit až v průběhu Phase G
- [x] V Phase E konsolidovat mezery ze všech domén, ověřit závislosti a pak seskupit work packages
- [ ] Vrátit se do Phase B a provést Gap Analysis znovu pro všechny domény najednou
- [ ] Předat seznamy mezer přímo PMO, aby z nich podle domén založila jednotlivé projekty a určila termíny

> Konsolidace mezer a závislostí je úkol Phase E a musí předcházet plánování termínů. Harmonogram bez konsolidace by obsahoval duplicity a nerespektoval závislosti; návrat do Phase B není nutný, protože mezery už existují, a projekty po doménách by rozbily mezidoménové vazby.

### ? Architektonický tým má hotovou konsolidaci mezer, seskupené work packages a identifikované dvě Transition Architectures. Ředitel portfolia se ptá, které work packages přinesou nejvíc hodnoty a kolik lidí a peněz budou potřebovat, aby je mohl zařadit do ročního rozpočtu. Kde v ADM a jakou činností se na tuto otázku odpovídá?

- [ ] Ve Phase E identifikací dalších Transition Architectures podle rozpočtu
- [ ] Ve Phase G uzavřením Architecture Contract s implementačními partnery
- [ ] Ve Phase A aktualizací Statement of Architecture Work o rozpočet projektů
- [x] Ve Phase F přiřazením business value a odhadem zdrojů a termínů

> Přiřazení business value a odhad zdrojů, termínů a způsobu dodání jsou kroky Phase F Migration Planning. Transition Architectures už jsou hotové (Phase E), Architecture Contract řeší realizaci ve Phase G a Statement of Architecture Work definuje práci na architektuře, ne rozpočet migračních projektů.

## Změnové atributy, omezení a Implementation Factor Catalog {#implementation-factors .explain}

Než architekt začne skládat work packages, ověří, jak podnik změnu obvykle provádí (corporate change attributes) a jaká obchodní omezení platí pro implementaci (business constraints) — rozpočtové cykly, období zákazu změn, kapacitu organizace pro změnu, regulatorní termíny nebo smlouvy s dodavateli. Zjištění zapisuje do **Implementation Factor Catalog** (ve vydání 9.1 Implementation Factor Assessment and Deduction matrix): u každého faktoru je popis a **dedukce (deduction)**, tedy důsledek, který z faktoru plyne pro migraci. Faktory mohou být rizika, problémy (issues), předpoklady, závislosti nebo akce. Katalog je vstupem pro Implementation and Migration Strategy, seskupení work packages i pro plánování ve Phase F.

*Příklad:* Faktor „hlavní obchodní sezóna listopad–leden" → dedukce „nasazení do produkce jen mimo sezónu; přechod rozdělit do dvou kroků v únoru a v září".

### ? Maloobchodní řetězec dělá 40 % tržeb v prosinci, IT má od poloviny listopadu do poloviny ledna zákaz změn a licence současného ERP vyprší za 18 měsíců. Architekt ve Phase E chce, aby se tyto skutečnosti systematicky promítly do strategie přechodu i do seskupení work packages. Kam a v jaké podobě je má zaznamenat?

- [x] Do Implementation Factor Catalog — u každého faktoru popis a dedukci pro migraci
- [ ] Do Architecture Principles jako nový princip o zákazu změn v obchodní sezóně
- [ ] Do Consolidated Gaps, Solutions, and Dependencies Matrix jako nové mezery
- [ ] Do Architecture Contract s dodavatelem ERP jako smluvní podmínky dodávky

> Implementation Factor Catalog slouží právě k zachycení faktorů ovlivňujících implementaci a jejich důsledků pro plán. Nejde o trvalé zásady (principy), nejde o mezery mezi Baseline a Target a Architecture Contract vzniká až ve Phase G.

### ? Junior architekt vyplňuje Implementation Factor Catalog. U faktoru „dodavatel ukončí podporu současné verze databáze v roce 2027" doplnil popis a ptá se, co patří do sloupce dedukce (deduction). Co tam má uvést?

- [ ] Jméno vlastníka rizika a pravděpodobnost, že se faktor projeví
- [ ] Odhad nákladů na pořízení a zavedení nového databázového systému včetně licencí
- [x] Důsledek pro migraci, např. upgrade databáze už v první Transition Architecture
- [ ] Odkaz na mezeru v Technology Architecture, ze které faktor vznikl

> Dedukce vyjadřuje, co z faktoru vyplývá pro migraci a pořadí kroků. Vlastník a pravděpodobnost patří do řízení rizik, náklady se odhadují ve Phase F a odkaz na mezeru je součástí konsolidační matice mezer.

## Consolidated Gaps, Solutions, and Dependencies Matrix {#konsolidace-mezer .explain}

Ve Phase E architekt sloučí výsledky Gap Analysis ze všech domén do jedné matice. U každé mezery uvede doménu, popis mezery, možná řešení (potential solutions) a závislosti na jiných mezerách. Matice odhalí duplicity (stejný nedostatek vidí Business i Application Architecture), mezidoménové závislosti a příležitosti vyřešit více mezer jedním řešením. Z matice pak vznikají work packages a pořadí jejich realizace.

*Příklad:* Mezera „chybí jednotná evidence zákazníků" (Data) a „portál nezobrazuje historii smluv" (Application) — matice ukáže, že obě pokryje jedno CRM a že portál závisí na migraci zákaznických dat.

### ? V bance předaly tři týmy (Business, Information Systems a Technology Architecture) samostatné seznamy mezer. Nikdo neví, které mezery spolu souvisejí, a dvě domény navrhují pro stejnou potřebu různé nástroje. Architekt potřebuje jeden společný podklad pro tvorbu work packages. Který artefakt je v této situaci nejvhodnější?

- [ ] Architecture Definition Increments Table
- [x] Consolidated Gaps, Solutions, and Dependencies Matrix
- [ ] Transition Architecture State Evolution Table
- [ ] Business Value Assessment matrix (hodnota × riziko)

> Konsolidační matice spojí mezery všech domén, ukáže možná řešení a závislosti a odhalí duplicitní návrhy. Increments Table i State Evolution Table předpokládají, že Transition Architectures už existují, a Business Value Assessment slouží k prioritizaci hotových work packages.

### ? Při tvorbě konsolidační matice mezer architekt zjistí, že mezera „nový platební modul" v Application Architecture závisí na mezeře „upgrade integračního middleware" v Technology Architecture. Platební modul má pro obchod vysokou prioritu. Co z toho má architekt vyvodit pro další plánování?

- [ ] Jednu z mezer odstranit, protože se obsahově překrývají
- [ ] Platební modul přesunout do samostatné iterace ADM, aby na upgrade middleware nemusel čekat
- [ ] Obě mezery dát do jednoho work package bez ohledu na jeho velikost
- [x] Závislost promítnout do work packages a pořadí — upgrade middleware dřív

> Závislost určuje pořadí: platební modul nelze dodat dřív, než bude hotový middleware, na kterém stojí. Mezery se nepřekrývají, jen na sobě závisí; samostatná iterace závislost neodstraní a sloučení do jednoho balíku není automaticky správné — rozhoduje řiditelnost a soudržnost práce.

## Sladění interoperability a závislostí {#interoperabilita-zavislosti .explain}

Řešení navržená v různých doménách musí spolu fungovat nejen v cílovém stavu, ale i v každém mezistavu. Ve Phase E proto architekt konsoliduje a sladí požadavky na interoperabilitu (jak si systémy a organizace vyměňují informace a služby) a zpřesní závislosti mezi budoucími work packages. Zvláštní pozornost patří období, kdy vedle sebe běží staré a nové řešení — často je třeba dočasné rozhraní nebo přechodné řešení, které se musí naplánovat jako práce včetně jeho pozdějšího odstranění. Konflikty se řeší dřív, než se zafixuje pořadí projektů.

*Příklad:* Nový skladový systém se nasadí o rok dřív než nový e-shop, a proto musí přes dočasné rozhraní obsluhovat i e-shop původní.

### ? Výrobní firma nahrazuje systém řízení výroby (MES) postupně ve dvou závodech, nový ERP přijde až ve druhém kroku. Při plánování se ukáže, že nový MES v prvním závodě bude rok komunikovat se starým ERP. Vedení trvá na tom, aby první závod přešel letos. Jaký postup je nejlepší?

- [x] Sladit interoperabilitu a dočasné rozhraní naplánovat jako součást work package
- [ ] Odložit nasazení MES, dokud nebude hotový nový ERP, aby nevzniklo přechodné řešení
- [ ] Ponechat návrh rozhraní na dodavateli MES, který ho vyřeší až během implementace
- [ ] Upravit cílovou architekturu tak, aby nový MES trvale používal rozhraní starého ERP

> Souběh starého a nového řešení je třeba architektonicky vyřešit a naplánovat, včetně pozdějšího odstranění dočasného rozhraní. Odložení jde proti požadavku vedení, ponechání na dodavateli obchází architekturu a trvalé přizpůsobení starému ERP poškodí cílový stav.

### ? Dva work packages běží souběžně: nová identitní služba s jednotným přihlášením (SSO) a nový HR systém. HR tým plánuje vlastní přihlašování, protože SSO bude v provozu až za rok, zatímco HR systém má jít do provozu za šest měsíců. Co má architekt ve Phase E udělat?

- [ ] Nechat HR vytvořit trvalé vlastní přihlašování, aby HR systém nebyl na SSO vůbec závislý
- [x] Zpřesnit závislost: předřadit SSO, nebo naplánovat dočasné řešení a jeho zrušení
- [ ] Odložit HR systém o rok, dokud SSO nebude v provozu, bez ohledu na potřeby HR
- [ ] Ponechat věc projektovým týmům, protože závislosti řeší až řízení projektů

> Závislosti mezi work packages zpřesňuje architekt ve Phase E a volí mezi úpravou pořadí a řízeným přechodným řešením. Trvalé vlastní přihlašování vytvoří nesoulad s cílem, slepé odložení ignoruje business potřebu a přenechání týmům rezignuje na architektonické řízení.

## Posouzení stávajících řešení: Mainstream × Contain × Replace {#mainstream-contain-replace .compare}

Při seskupování work packages architekt u stávajících systémů určí, jakou roli budou hrát v budoucnosti, a u každé mezery zváží, zda ji pokryje nový vývoj, nákup hotového řešení, nebo znovupoužití existujícího (např. SBB z Architecture Repository).

| Klasifikace | Význam | Důsledek pro plán |
|---|---|---|
| Mainstream | systém je součástí budoucího stavu | rozvíjet ho a stavět na něm další work packages |
| Contain | systém se časem nahradí nebo modernizuje, zatím zůstává | omezit rozvoj na nezbytné, nevytvářet na něm nové závislosti |
| Replace | systém je určen k nahrazení | naplánovat náhradu, migraci dat a vyřazení |

### ? Distribuční firma posuzuje tři systémy. Nedávno nasazené CRM je v cílové architektuře základem zákaznických služeb. Starý fakturační systém zatím zůstává a modernizuje se, až na to bude rozpočet. Skladovou aplikaci nahradí nový WMS v první Transition Architecture. Která klasifikace odpovídá situaci?

- [ ] CRM Contain, fakturace Mainstream, skladová aplikace Replace
- [ ] CRM Mainstream, fakturace Replace, skladová aplikace Contain
- [x] CRM Mainstream, fakturace Contain, skladová aplikace Replace
- [ ] CRM Replace, fakturace Contain, skladová aplikace Mainstream

> Mainstream je systém, se kterým počítá budoucí stav (CRM), Contain systém, který zatím zůstává a později se modernizuje či nahradí (fakturace), a Replace systém určený k nahrazení (skladová aplikace). Ostatní kombinace přiřazují kategorie v rozporu s plánem.

### ? Při seskupování work packages řeší architekt mezeru „chybí správa dokumentů". V Architecture Repository je zdokumentovaný SBB podnikového systému správy dokumentů, který už úspěšně používá jiná divize a který pokrývá většinu požadavků. Co je nejlepší doporučení?

- [ ] Vypsat výběrové řízení na nový systém, aby se porovnaly nabídky trhu
- [x] Znovupoužít existující řešení a work package zaměřit na jeho rozšíření
- [ ] Zařadit existující systém mezi Contain a mezeru odložit do další iterace ADM
- [ ] Vyvinout vlastní modul správy dokumentů jako součást nového portálu

> Znovupoužití ověřeného SBB snižuje náklady i riziko a podporuje jednotnost řešení. Nové výběrové řízení ani vlastní vývoj nejsou bez důvodu odůvodnitelné a klasifikace Contain neodpovídá systému, se kterým se do budoucna počítá.

## Implementation and Migration Strategy: Greenfield × Revolutionary × Evolutionary {#strategie-prechodu .compare}

Ve Phase E architekt formuluje celkovou strategii přechodu. Volba vychází ze změnových atributů a omezení podniku, z připravenosti na transformaci a z rizik.

| Přístup | Podstata | Kdy je vhodný |
|---|---|---|
| Greenfield | stavba od začátku, bez výchozího stavu, který by bylo nutné migrovat | nová firma, divize nebo trh, kde zatím nic neexistuje |
| Revolutionary | radikální změna najednou — přepnutí ze starého řešení na nové | změna je nutná rychle (předpis, konec podpory), postupný přechod není možný nebo smysluplný a riziko lze zvládnout |
| Evolutionary | postupná změna v krocích přes Transition Architectures, každý krok přináší hodnotu | velký rozsah, omezená kapacita pro změnu, vysoké riziko, potřeba průběžných přínosů |

Strategii doplňuje volba způsobu realizace; TOGAF zmiňuje např. přístup rychlých přínosů (Quick Win), realisticky dosažitelných cílů (Achievable Targets) a postup podle hodnotového řetězce (Value Chain method).

### ? Banka zakládá samostatnou digitální banku jako novou dceřinou společnost. Ta zatím nemá klienty, data ani systémy a nepřebírá nic od mateřské banky. Cílem je co nejrychleji spustit službu na moderní platformě. Která Implementation and Migration Strategy je nejvhodnější?

- [ ] Evolutionary — přes několik Transition Architectures z existujících systémů mateřské banky
- [ ] Revolutionary — jednorázové přepnutí systémů mateřské banky na novou platformu
- [ ] Contain — omezit stávající systémy mateřské banky a postupně je nahrazovat
- [x] Greenfield — vybudovat řešení od začátku bez migrace jakéhokoli výchozího stavu

> Neexistuje výchozí stav k migraci, proto je vhodný Greenfield. Evolutionary i Revolutionary předpokládají přechod z existujících systémů, které se tu nepřebírají, a Contain je klasifikace stávajícího systému, ne strategie.

### ? Nemocnice provozuje 40 propojených aplikací, má malé IT oddělení a nesmí přerušit péči o pacienty. Vedení chce vidět přínosy transformace každý rok, ne až na konci čtyřletého programu. Jakou strategii má architekt doporučit?

- [x] Evolutionary — rozdělit přechod do Transition Architectures s přínosem v každém kroku
- [ ] Revolutionary — připravit vše paralelně a přepnout všechny aplikace o jednom víkendu
- [ ] Greenfield — postavit novou platformu a historická data pacientů nemigrovat
- [ ] Evolutionary — nejprve dokončit všechny projekty a přínosy vyhodnotit souhrnně na konci

> Velký rozsah, malá kapacita, nutnost nepřerušeného provozu a požadavek na průběžné přínosy ukazují na evoluční přístup s hodnotou v každém mezistavu. Jednorázové přepnutí je zde příliš rizikové, Greenfield ignoruje existující stav a evoluce bez průběžných přínosů nesplní požadavek vedení.

### ? Regulátor nařídil pojišťovně do devíti měsíců ukončit provoz systému, který nesplňuje nový předpis. Náhradní systém je připravený a otestovaný. Data musí být po celou dobu v jediném systému, takže souběžný provoz části agendy ve starém a části v novém systému není přípustný. Jakou strategii má architekt zvolit?

- [ ] Evolutionary — několik Transition Architectures, aby se riziko rozložilo v čase
- [ ] Greenfield — nasadit nový systém bez migrace historických dat ze starého
- [x] Revolutionary — připravit jednorázový přechod a jeho rizika zmírnit plánem
- [ ] Evolutionary — nejdřív migrovat menší pobočky a centrálu až v příštím roce

> Termín, připravené řešení a nemožnost souběhu vedou k revolučnímu přechodu najednou, jehož rizika se řídí důkladnou přípravou. Postupný přechod by porušil podmínku jediného systému a Greenfield by zahodil data, která pojišťovna potřebuje.

## Jak seskupit work packages {#seskupeni-work-packages .explain}

Work package je ucelená sada činností, která řeší jednu nebo více mezer; může se stát projektem, částí projektu nebo programem. Architekt ho tvoří z konsolidované matice mezer: seskupuje mezery se společným řešením, se silnými závislostmi nebo ze stejné business oblasti a respektuje faktory z Implementation Factor Catalog. Každý work package porovná s již běžícími projekty a programy — místo duplicit je lepší upravit nebo rozšířit existující iniciativu. Velikost volí tak, aby šel balík realizovat a řídit: příliš velký zvyšuje riziko, příliš drobné balíky zahltí koordinaci.

*Příklad:* Tři mezery kolem zákaznických dat (jednotný identifikátor, kvalita dat, evidence souhlasů) tvoří jeden work package „Zákaznická data", protože sdílejí řešení i tým.

### ? Telekomunikační operátor je ve Phase E. Architekt zjistí, že navrhovaný work package „samoobslužný portál" se z velké části kryje s projektem, který PMO zahájila před půl rokem mimo architektonickou práci. Projekt je rozpracovaný, ale nepočítá s novou integrační platformou z cílové architektury. Co je nejlepší krok?

- [ ] Založit nový projekt podle architektury a běžící projekt PMO zastavit a odepsat
- [x] Sladit work package s běžícím projektem a upravit jeho rozsah podle cílové architektury
- [ ] Běžící projekt přehlížet, protože nevznikl z ADM a architektuře nepodléhá
- [ ] Vyřadit work package z Roadmap, protože portál už v podniku někdo řeší

> Work packages se mají porovnat s existujícími iniciativami a sladit s nimi, aby nevznikaly duplicity a zachovala se rozpracovaná práce. Zastavení plýtvá investicí, přehlížení vede k nesouladu a vyřazení by ponechalo projekt bez vazby na cílovou integrační platformu.

### ? Po konsolidaci má architekt 25 mezer ze všech domén a potřebuje z nich vytvořit realizovatelné work packages. Který způsob seskupení je nejvhodnější?

- [ ] Podle domény, ve které byla mezera nalezena — Business, Data, Application a Technology zvlášť
- [ ] Podle oddělení, které mezeru nahlásilo, aby měl každý balík jednoho vlastníka
- [ ] Každou mezeru jako samostatný balík, aby šlo přesně sledovat náklady
- [x] Podle společného řešení, závislostí a business oblasti s ohledem na omezení

> Smysluplné work packages spojují mezery, které řeší stejné řešení nebo na sobě závisejí, a respektují omezení z Implementation Factor Catalog. Seskupení po doménách rozbíjí mezidoménové vazby, po oddělení ignoruje řešení a samostatné balíky pro každou mezeru zahltí koordinaci.

## Kdy a jak definovat Transition Architectures {#transition-architectures .explain}

Pokud cílovou architekturu nelze nebo není rozumné dosáhnout jedním krokem, architekt definuje Transition Architectures — architektonicky významné mezistavy mezi Baseline a Target. Každý mezistav má být stabilní, provozuschopný a přinášet business value; jinak sponzorům mizí důvod pokračovat. Hranice mezistavů určují závislosti, kapacita organizace pro změnu, rozpočtová období a rizika. Transition Architectures umožní seskupit work packages do řízených programů a portfolií a ukázat přínos každého kroku. Mezistavů má být jen tolik, kolik je potřeba ke zvládnutí rizika a závislostí; u malé změny nemusí být žádný.

*Příklad:* TA1 (rok 1): jednotná zákaznická data a nové CRM pro call centrum; TA2 (rok 2): samoobslužný portál nad CRM; Target: vyřazení starých systémů.

### ? Architekt navrhl jako první Transition Architecture dvouletou migraci všech dat do nového datového skladu, bez jakékoli nové funkce pro uživatele; přínosy přijdou až s druhým mezistavem. Sponzor programu plán odmítá, protože by dva roky financoval změnu bez viditelného výsledku. Jaká úprava je nejlepší?

- [x] Přeskupit mezistavy, aby už první Transition Architecture přinesla hodnotu
- [ ] Ponechat návrh, protože technické základy musí vždy předcházet business změnám
- [ ] Sloučit všechny kroky do jediné Transition Architecture, aby se plán zkrátil
- [ ] Transition Architectures vypustit a přejít na strategii Revolutionary

> Každá Transition Architecture má přinášet hodnotu, proto je vhodné migraci dat rozdělit a spojit ji s prvními přínosy pro uživatele. Lpění na čistě technickém kroku ignoruje sponzora, sloučení do jednoho kroku zvýší riziko a revoluční přechod ho zvýší ještě víc.

### ? Firma nahrazuje jediný nástroj pro výkaznictví. Změna nemá závislosti na jiných systémech, týká se jednoho oddělení a potrvá tři měsíce. Junior architekt chce ve Phase E navrhnout několik Transition Architectures. Jsou v tomto případě Transition Architectures potřeba?

- [ ] Ano, vždy jsou potřeba alespoň dvě, aby šlo měřit průběžné přínosy
- [ ] Ano, jedna Transition Architecture pro každou doménu B, C a D
- [x] Ne — lze-li cíle dosáhnout bezpečně jedním krokem, mezistavy nejsou nutné
- [ ] Zatím ne, Transition Architectures vznikají až ve Phase G podle průběhu projektů

> Phase E určuje, zda je přírůstkový přístup vůbec potřeba; u malé změny bez závislostí stačí jeden krok. Povinný minimální počet ani rozdělení po doménách TOGAF nepředepisuje a Transition Architectures se identifikují ve Phase E, ne ve Phase G.

## Architecture Definition Increments Table × Transition Architecture State Evolution Table {#increments-state-evolution .compare}

Obě techniky z Migration Planning Techniques popisují vývoj v čase přes Transition Architectures, ale z jiného úhlu.

| | Architecture Definition Increments Table | Transition Architecture State Evolution Table |
|---|---|---|
| Co ukazuje | které projekty dodají jaké přírůstky v jednotlivých Transition Architectures | v jakém stavu budou jednotlivé architektonické oblasti a jejich řešení (SBB) v každé Transition Architecture |
| Uspořádání | projekty × mezistavy; v buňce je přírůstek, který projekt v daném kroku dodá | oblasti/služby × mezistavy; v buňce je použité řešení nebo jeho verze |
| Odpovídá na | „Co přesně který projekt dodá v kterém kroku?" | „Které řešení bude v provozu v kterém kroku?" |
| Typický uživatel | programový manažer, PMO | provoz, technologičtí architekti |

### ? Provozní ředitel potřebuje pro plánování podpory a licencí vědět, která verze databázové platformy a integračního middleware bude v provozu v každém z plánovaných mezistavů. Který podklad mu architekt má připravit?

- [ ] Architecture Definition Increments Table
- [x] Transition Architecture State Evolution Table
- [ ] Implementation Factor Catalog
- [ ] Consolidated Gaps, Solutions, and Dependencies Matrix

> State Evolution Table ukazuje, jaké řešení je v jednotlivých oblastech nasazeno v každé Transition Architecture. Increments Table je zaměřena na příspěvky projektů, Implementation Factor Catalog na faktory implementace a konsolidační matice na mezery.

### ? Programový manažer řídí šest projektů a potřebuje vidět, co přesně každý z nich dodá v první Transition Architecture, ve druhé a v cílovém stavu, aby mohl nastavit milníky programu. Který podklad je nejvhodnější?

- [ ] Transition Architecture State Evolution Table
- [ ] Benefits diagram
- [ ] Business Value Assessment matrix
- [x] Architecture Definition Increments Table

> Increments Table přiřazuje přírůstky jednotlivých projektů k mezistavům, což je přesně podklad pro milníky. State Evolution Table popisuje stav řešení, ne příspěvky projektů, Benefits diagram srovnává příležitosti a Business Value Assessment slouží k prioritizaci.

## Project Context diagram × Benefits diagram {#project-context-benefits .compare}

Oba diagramy patří k artefaktům Phase E a pomáhají předat výsledky architektury lidem, kteří rozhodují o realizaci.

| | Project Context diagram | Benefits diagram |
|---|---|---|
| Účel | vymezit rozsah jednoho work package v rámci širší Roadmap | ukázat příležitosti (opportunities) a jejich přínosy, aby šly porovnat |
| Obsah | organizace, funkce, služby, procesy, aplikace, data a technologie, na které work package působí | příležitosti z definice architektury roztříděné např. podle velikosti, složitosti a přínosu |
| Typický čtenář | vedoucí projektu, portfolio management | sponzor, vedení při rozhodování o prioritách |

### ? Nová vedoucí projektu přebírá work package „elektronický podpis smluv". Potřebuje rychle pochopit, kterých procesů, aplikací, dat a organizačních jednotek se balík dotkne a jak zapadá do celkové Roadmap. Který artefakt jí architekt má předat?

- [x] Project Context diagram
- [ ] Benefits diagram
- [ ] Architecture Definition Increments Table
- [ ] Stakeholder Map matrix

> Project Context diagram vymezuje rozsah work package vůči organizaci, procesům, aplikacím, datům a technologiím. Benefits diagram srovnává příležitosti, Increments Table ukazuje přírůstky projektů v mezistavech a Stakeholder Map se týká zainteresovaných stran, ne rozsahu balíku.

### ? Představenstvo má rozhodnout, kterou z osmi příležitostí identifikovaných v architektuře podpoří v prvním kroku. Chce je vidět přehledně vedle sebe podle velikosti, složitosti a očekávaného přínosu. Který artefakt je nejvhodnější?

- [ ] Project Context diagram
- [ ] Transition Architecture State Evolution Table
- [x] Benefits diagram
- [ ] Implementation Factor Catalog

> Benefits diagram znázorňuje příležitosti a jejich přínosy tak, aby je vedení mohlo porovnat. Project Context diagram popisuje rozsah jednoho balíku, State Evolution Table stav řešení v mezistavech a katalog faktorů omezení implementace.

## Business Value Assessment: hodnota × riziko {#business-value-assessment .explain}

Technika pomáhá prioritizovat work packages a projekty: každý se ohodnotí indexem hodnoty (value index) a indexem rizika (risk index) a zobrazí v matici. Kritéria hodnoty si organizace stanoví sama — typicky přínos pro strategické cíle a výkonnost, kvalitu informací, soulad s předpisy nebo úspory; kritéria rizika např. velikost a složitost, technologii, kapacitu organizace a dopad neúspěchu. Z matice je vidět, které projekty mají vysokou hodnotu s nízkým rizikem (kandidáti na začátek) a které nízkou hodnotu s vysokým rizikem (kandidáti na odložení nebo přepracování). Kritéria a váhy je nutné předem odsouhlasit s klíčovými stakeholdery, jinak výsledek nepřijmou.

*Příklad:* Digitalizace žádostí (vysoká hodnota, nízké riziko) jde do první Transition Architecture; výměna hlavního systému (vysoká hodnota, vysoké riziko) se rozdělí do více kroků s opatřeními ke snížení rizika.

### ? Ministerstvo má 12 work packages, ale rozpočet stačí na pět. Diskuse o prioritách se vedou podle toho, který náměstek je hlasitější, a výsledky se každý týden mění. Architekt chce rozhodování postavit na transparentním podkladu. Co je nejlepší udělat?

- [ ] Seřadit work packages podle odhadovaných nákladů od nejlevnějšího
- [x] Ohodnotit balíky podle dohodnutých kritérií hodnoty a rizika v matici
- [ ] Nechat rozhodnout Architecture Board hlasováním bez dalších podkladů
- [ ] Zahájit všech 12 work packages a financovat je postupně podle průběhu

> Business Value Assessment dává transparentní, opakovatelný podklad založený na dohodnutých kritériích hodnoty a rizika. Samotné náklady ignorují přínos, hlasování bez podkladů problém nevyřeší a zahájení všeho najednou překročí rozpočet i kapacitu.

### ? Při Business Value Assessment vyjde projekt výměny hlavního systému jako vysoce hodnotný, ale také vysoce rizikový: je rozsáhlý, technologicky nový a dotkne se většiny zaměstnanců. Bez něj nelze dosáhnout cílové architektury. Jak s ním má architekt naložit?

- [ ] Odsunout ho na úplný konec Roadmap, protože vysoké riziko ho z priorit vylučuje
- [ ] Zařadit ho celý hned na začátek, protože vysoká hodnota má vždy přednost
- [ ] Vyřadit ho z Roadmap a hodnotu hledat v méně rizikových projektech
- [x] Ponechat ho, rozdělit do menších kroků a naplánovat opatření proti riziku

> Hodnotný a nezbytný projekt se nevyřazuje; riziko se snižuje rozdělením do kroků a opatřeními. Automatické odsunutí nebo vyřazení ohrozí dosažení cíle a zařazení celého projektu najednou ignoruje vysoké riziko.

### ? Architekt sám nastavil kritéria a váhy pro Business Value Assessment a výsledné pořadí představil vedení. Výrobní ředitel výsledek odmítá, protože kritéria nezohledňují dopad projektů na dostupnost výroby, kterou považuje za klíčovou. Co je nejlepší další krok?

- [x] Revidovat kritéria a váhy s klíčovými stakeholdery a hodnocení zopakovat
- [ ] Trvat na výsledku, protože hodnocení proběhlo podle techniky TOGAF
- [ ] Eskalovat spor k Architecture Board, aby řediteli výsledek nařídil
- [ ] Zařadit projekty výrobního ředitele na začátek, aby se předešlo sporu

> Kritéria hodnoty a rizika mají být dohodnutá se stakeholdery, jinak hodnocení nemá legitimitu. Trvání na výsledku ani eskalace nevyřeší chybějící kritérium a ústupek bez hodnocení rezignuje na transparentní prioritizaci.

## Sladění s řídicími rámci podniku {#ridici-ramce .explain}

Implementation and Migration Plan nesmí vzniknout izolovaně. Na začátku Phase F architekt potvrdí, jak plán zapadne do ostatních řídicích rámců podniku: business planningu (strategie, cíle, rozpočet), řízení podnikové architektury, portfolio a project managementu (řízení projektů, zdrojů a investic) a operations managementu (nasazení, provoz, údržba). Prakticky jde o sladění s rozpočtovým cyklem, s metodikou řízení projektů, kterou podnik používá, a s kapacitou provozu převzít nová řešení.

*Příklad:* Firma schvaluje rozpočet v říjnu na další rok — Roadmap proto musí být hotová v září, jinak work packages první Transition Architecture nedostanou peníze.

### ? Architekt připravil detailní plán migrace s vlastním harmonogramem a vlastním způsobem řízení projektů. Firma však řídí všechny změny přes centrální portfolio se čtvrtletními schvalovacími branami a ročním rozpočtovým cyklem. Co má architekt ve Phase F udělat?

- [ ] Prosadit vlastní harmonogram, protože vychází z architektury a závislostí
- [ ] Předat plán portfoliu až po dokončení Phase F jako hotovou věc ke schválení
- [x] Sladit plán s portfoliovým řízením, jeho branami a rozpočtovým cyklem podniku
- [ ] Požádat Architecture Board o výjimku z portfoliového řízení pro tyto projekty

> Phase F začíná potvrzením vazeb na řídicí rámce podniku, aby plán šlo skutečně realizovat. Vlastní harmonogram i výjimka obcházejí zavedené řízení a předání hotové věci na konci riskuje, že plán bude v portfoliu neproveditelný.

### ? Plán počítá s nasazením čtyř nových systémů během jednoho čtvrtletí. Provozní oddělení nebylo při plánování osloveno a dokáže převzít do provozu nejvýše jeden systém za čtvrtletí. Jaký je nejlepší postup?

- [ ] Ponechat plán a provoz posílit externími dodavateli až po nasazení
- [x] Zapojit operations management, ověřit kapacitu převzetí a upravit plán nasazení
- [ ] Ponechat provoz nových systémů projektovým týmům na dobu neurčitou
- [ ] Vrátit se do Phase D a snížit počet systémů v cílové architektuře

> Operations management je jeden z rámců, se kterými se plán ve Phase F sladí; omezení provozu musí ovlivnit pořadí nasazení. Dodatečné posílení po nasazení riziko neřeší, projektové týmy nejsou provozní útvar a zásah do cílové architektury neodpovídá plánovacímu problému.

## Prioritizace migračních projektů ve Phase F {#prioritizace .explain}

Ve Phase F architekt nejdřív přiřadí každému work package business value (např. podle kritických faktorů úspěchu, Measures of Effectiveness, návratnosti a strategické shody) a odhadne potřebné zdroje, trvání a způsob dodání. Potom projekty prioritizuje: posoudí náklady a přínosy, ověří rizika (včetně reziduálního rizika po plánovaných opatřeních) a výsledné pořadí projedná se stakeholdery, aby získal shodu. Pořadí musí respektovat závislosti — hodnotný projekt nemůže předběhnout projekt, na kterém technicky stojí. Výsledkem je potvrzená Architecture Roadmap a aktualizovaný Architecture Definition Document.

*Příklad:* Mobilní aplikace má nejvyšší hodnotu, ale stojí na nové vrstvě API — ta proto jde dřív, přestože sama přímou hodnotu pro zákazníky nemá.

### ? Marketing tlačí, aby nový zákaznický portál s nejvyšším hodnocením business value šel jako první projekt. Portál ale potřebuje integrační platformu, která je samostatným work package s nižším hodnocením a zatím nezačala. Portál potřebuje údaje o smlouvách online a v objemu tisíců požadavků denně, takže ruční přenos dat ani jiné dočasné řešení nepřipadá v úvahu. Co má architekt při prioritizaci udělat?

- [x] Zařadit dřív integrační platformu, na které portál závisí, a vysvětlit proč
- [ ] Zařadit portál jako první a integraci vyřešit dodatečně za provozu bez plánu
- [ ] Spustit portál hned nad dočasnými rozhraními ke stávajícím systémům
- [ ] Vyřadit portál z první Transition Architecture a ponechat ho až pro cílový stav

> Prioritizace musí respektovat závislosti: portál bez integrační platformy fungovat nemůže, proto platforma jde dřív a stakeholderům se vysvětlí proč. Integrace dodatečně bez plánu nerespektuje závislost a dočasná rozhraní zadání výslovně vylučuje; úplné odsunutí portálu do cílového stavu zbytečně oddálí nejvyšší přínos.

### ? Architekt ve Phase F chce okamžitě seřadit work packages do pořadí realizace. Zatím ale nemá přiřazenou business value jednotlivých balíků ani odhady potřebných zdrojů, trvání a způsobu dodání. Co má udělat nejdřív?

- [ ] Odeslat pořadí ke schválení Architecture Board a odhady doplnit později
- [ ] Seřadit balíky podle pořadí mezer v konsolidační matici z Phase E
- [ ] Vrátit se do Phase E a znovu určit hranice Transition Architectures
- [x] Přiřadit balíkům business value a odhadnout zdroje, trvání a způsob dodání

> Prioritizace podle nákladů, přínosů a rizik potřebuje hodnotu a odhady jako vstup. Schválení bez podkladů nemá oporu, pořadí v matici mezer nevyjadřuje hodnotu a návrat do Phase E není potřeba, když jsou Transition Architectures hotové.

### ? Po prioritizaci zůstává u jednoho projektu i po všech plánovaných opatřeních vysoké reziduální riziko. Sponzor ho odmítá akceptovat a říká, že s takovým rizikem projekt nepodpoří. Jaký je nejlepší další krok?

- [ ] Ponechat projekt na místě, protože iniciální riziko už bylo posouzeno dříve
- [ ] Riziko v plánu nezmiňovat, aby se nezdrželo schválení Roadmap
- [x] Přehodnotit pořadí či pojetí projektu a znovu ho projednat se stakeholdery
- [ ] Přenést rozhodnutí o riziku na dodavatele prostřednictvím Architecture Contract

> Ověření rizik a shoda stakeholderů jsou součástí prioritizace ve Phase F; nepřijatelné reziduální riziko vyžaduje změnu plánu. Odkaz na iniciální riziko je nedostatečný, zamlčení je nepřijatelné a Architecture Contract odpovědnost sponzora za riziko nepřenese.

## Architecture Roadmap × Implementation and Migration Plan {#roadmap-vs-plan .compare}

Oba výstupy vznikají ve Phase E a finalizují se ve Phase F, ale slouží jiným čtenářům.

| | Architecture Roadmap | Implementation and Migration Plan |
|---|---|---|
| Pohled | architektonický: co se změní a v jakých krocích | realizační: jak, kdy a s jakými zdroji se změny provedou |
| Obsah | portfolio work packages v čase, Transition Architectures, doporučení k implementaci (měřítka přínosu, rizika a problémy, řešení) | strategie implementace a migrace, projekty, harmonogram, zdroje a náklady, vazba na portfolio a řízení projektů |
| Typický čtenář | sponzoři, vedení, Architecture Board | PMO, programoví a projektoví manažeři, provoz |

### ? Finanční ředitel chce na jedné stránce vidět, jaké změny podnik čekají v příštích třech letech, v jakých krocích a proč. Detailní harmonogramy projektů ani přidělení lidí nepotřebuje. Který výstup je pro něj nejvhodnější?

- [ ] Implementation and Migration Plan
- [x] Architecture Roadmap
- [ ] Architecture Requirements Specification
- [ ] Implementation Governance Model

> Architecture Roadmap ukazuje work packages a Transition Architectures v čase a jejich zdůvodnění. Implementation and Migration Plan je detailní realizační plán, Architecture Requirements Specification popisuje požadavky a Implementation Governance Model řízení implementace.

### ? PMO má na základě architektonické práce založit projekty. Potřebuje rozpad na jednotlivé projekty, jejich harmonogram, potřebné zdroje a náklady a vazbu na schvalovací procesy portfolia. Který výstup jí architekt má předat?

- [x] Implementation and Migration Plan
- [ ] Architecture Roadmap
- [ ] Architecture Definition Document
- [ ] Statement of Architecture Work

> Implementation and Migration Plan obsahuje realizační detail: projekty, harmonogram, zdroje a vazbu na řízení portfolia. Roadmap je architektonický přehled kroků, Architecture Definition Document popisuje samotnou architekturu a Statement of Architecture Work rozsah architektonické práce.

## Uzavření Phase F: governance, poučení a další iterace {#uzavreni-cyklu .explain}

Phase F končí přípravou na implementaci i na další cyklus. Architekt připraví Implementation Governance Model (jak se bude implementace ve Phase G řídit a kontrolovat), uloží znovupoužitelné stavební bloky do Architecture Repository a zdokumentuje poučení (lessons learned) z celého cyklu. Z poučení vznikají Change Requests for Architecture Capability (např. úprava postupů nebo šablon), z potřeb mimo dohodnutý rozsah pak Requests for Architecture Work pro novou iteraci ADM. Výstupy se nechají schválit a teprve potom se přechází k realizaci.

*Příklad:* Tým zjistil, že domény používaly odlišný formát Gap Analysis a konsolidace se zdržela o měsíc — podá změnový požadavek na šablonu pro příští cyklus.

### ? Na konci Phase F tým zjistí, že zástupci provozu byli do plánování zapojeni pozdě, což vedlo k přepracování poloviny plánu. Architekt chce, aby se to v příštích cyklech neopakovalo. Jak má s tímto poznatkem naložit?

- [ ] Zaznamenat ho do Implementation Factor Catalog současného plánu
- [ ] Podat Request for Architecture Work na novou iteraci zaměřenou na provoz
- [ ] Ponechat ho jako ústní dohodu týmu, protože plán je už dokončený
- [x] Zdokumentovat lessons learned a podat Change Request for Architecture Capability

> Poučení o způsobu práce se dokumentuje a promítá do architektonické kapability přes změnový požadavek. Implementation Factor Catalog popisuje faktory konkrétní migrace, Request for Architecture Work zakládá novou architektonickou práci a ústní dohoda se ztratí.

### ? Před zahájením implementace není jasné, kdo bude kontrolovat soulad projektů s architekturou, jak se budou hlásit odchylky a kdo o nich rozhodne. Plán migrace je přitom téměř hotový. Který výstup Phase F má tuto otázku vyřešit?

- [ ] Architecture Roadmap
- [ ] Architecture Requirements Specification
- [x] Implementation Governance Model
- [ ] Transition Architecture State Evolution Table

> Implementation Governance Model připravuje ve Phase F způsob řízení a kontroly implementace, který se pak uplatní ve Phase G. Roadmap plánuje kroky, specifikace požadavků popisuje požadavky a State Evolution Table stav řešení v mezistavech.

### ? Během plánování migrace vyjde najevo, že podnik bude potřebovat architekturu i pro nově koupenou dceřinou firmu v Asii. Ta není součástí dohodnutého rozsahu současné architektonické práce a její potřeby zatím nikdo neanalyzoval. Co má architekt udělat?

- [x] Připravit Request for Architecture Work pro novou iteraci ADM
- [ ] Rozšířit současnou Target Architecture a Roadmap o asijskou dceřinou firmu
- [ ] Zařadit dceřinou firmu jako nový work package do první Transition Architecture
- [ ] Potřebu bez záznamu odložit, protože je mimo Statement of Architecture Work

> Nová potřeba mimo rozsah se řeší novou iterací ADM, kterou spustí Request for Architecture Work. Rozšíření současné architektury nebo Roadmap bez analýzy obchází řízení rozsahu a odložení bez záznamu potřebu ztratí.
