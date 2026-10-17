---
kind: topic
subject: togaf-practitioner
slug: prizpusobeni-adm
name: "Přizpůsobení a iterace ADM v praxi"
order: 1
---

Tailoring ADM podle organizace, úrovně architektury a iterace; kdy kterou iteraci použít; vazba na jiné rámce a agilní přístup (jen podle Series Guides).

## Kdy a proč ADM přizpůsobit (tailoring) {#proc-prizpusobit .explain}

ADM je **obecná metoda** — TOGAF počítá s tím, že ji každá organizace přizpůsobí, a ne že ji převezme mechanicky krok po kroku. Přizpůsobení se rozhoduje hlavně v **Preliminary Phase** a jeho výsledkem je **Tailored Architecture Framework**. Co při tom zvážit:

- **zralost** organizace a její architektonické praxe, firemní kulturu a ochotu ke změně,
- **velikost a strukturu** (centralizovaná × federovaná), regulatorní a právní požadavky,
- **existující procesy a rámce** (řízení portfolia a projektů, provoz IT, governance), na které je třeba ADM napojit,
- **účel architektury** — podpora strategie, portfolia, projektu, nebo dodávky řešení.

Přizpůsobení není jednorázové: když se organizace nebo její praxe změní, rámec se upraví znovu.

*Příklad:* Malá pojišťovna bez architektonického týmu nepotřebuje plný katalog artefaktů; zvolí několik klíčových výstupů a napojí ADM na svůj stávající projektový proces.

### ? Středně velká logistická firma se rozhodla zavést podnikovou architekturu podle TOGAF. Vedení IT navrhuje převzít ADM přesně ve znění standardu, se všemi kroky a všemi artefakty, „aby se nic nezanedbalo". Firma přitom už má zavedený projektový i portfoliový proces. Jak by měl architekt reagovat?

- [ ] Souhlasit, protože úplné převzetí standardu je podmínkou souladu s TOGAF
- [x] V Preliminary Phase přizpůsobit ADM a napojit ji na stávající procesy
- [ ] Odložit zavedení, dokud firma nezruší vlastní projektový a portfoliový proces
- [ ] Převzít ADM beze změn a přizpůsobovat jej až po dokončení první iterace

> TOGAF výslovně počítá s přizpůsobením ADM podmínkám organizace a toto rozhodnutí patří do Preliminary Phase. Mechanické převzetí není podmínkou souladu, rušení fungujících procesů je zbytečné a odkládání tailoringu jen zvyšuje režii první iterace.

### ? Výrobní podnik před dvěma lety přizpůsobil ADM svým potřebám. Mezitím se sloučil s jinou firmou, přibyly dvě nové divize a změnil se způsob řízení IT investic. Architekti zjišťují, že dohodnutý postup už neodpovídá realitě. Co je nejvhodnější udělat?

- [ ] Pokračovat podle původního rámce, protože tailoring se provádí jen jednou
- [ ] Nechat každou novou divizi zvolit si vlastní metodu bez společných pravidel
- [ ] Zahájit rovnou Phase B pro novou organizaci a rámec ponechat beze změny
- [x] Znovu posoudit a upravit Tailored Architecture Framework podle nové situace

> Přizpůsobení rámce není jednorázové; při podstatné změně organizace se Tailored Architecture Framework revidovat má. Setrvání u starého rámce i skok do Phase B ignorují změněný kontext a rozdrobení na vlastní metody rozbíjí jednotnou architektonickou praxi.

## Terminologické × procesní × obsahové přizpůsobení {#druhy-tailoringu .compare}

Přizpůsobení rámce se obvykle týká tří oblastí, které lze kombinovat:

| | Terminologické (Terminology Tailoring) | Procesní (Process Tailoring) | Obsahové (Content Tailoring) |
|---|---|---|---|
| Co se mění | názvy pojmů, rolí a výstupů | fáze, kroky a jejich pořadí, vazby na jiné procesy | struktura výstupů, artefakty, metamodel |
| Proč | aby architektura mluvila jazykem organizace | aby ADM zapadla do způsobu řízení změn | aby se tvořilo jen to, co organizace využije |
| Typický příklad | „Architecture Board" se ve firmě jmenuje „Rada pro technologie" | Phase G se napojí na schvalovací brány projektového procesu | vybere se jen několik katalogů a diagramů, metamodel se rozšíří o vlastní entitu |
| Na co dát pozor | zachovat převodník na pojmy TOGAF | nevypustit governance a práci s požadavky | zachovat návaznost výstupů mezi fázemi |

### ? Banka zavádí ADM. Interní auditoři i manažeři jsou zvyklí na vlastní názvosloví: „Technologická rada" místo Architecture Board a „Záměr změny" místo Request for Architecture Work. Architekt chce, aby rámec byl v bance srozumitelný. Který druh přizpůsobení použije?

- [x] Terminologické přizpůsobení s převodníkem mezi interními názvy a pojmy TOGAF
- [ ] Procesní přizpůsobení, při kterém se Architecture Board z ADM úplně vypustí
- [ ] Obsahové přizpůsobení, při kterém se změní struktura metamodelu architektury
- [ ] Žádné, protože názvy rolí a výstupů TOGAF se v organizaci měnit nesmějí

> Jde jen o názvy, tedy o terminologické přizpůsobení; převodník na pojmy TOGAF udrží návaznost na standard a literaturu. Vypuštění Architecture Board by oslabilo governance a změna metamodelu problém názvosloví neřeší. Přejmenování v rámci tailoringu TOGAF připouští.

### ? Softwarová firma s 80 zaměstnanci má malý architektonický tým. Po první iteraci ADM si vývojáři stěžují, že architekti vytvářejí desítky katalogů, matic a diagramů, které nikdo nečte. Projektoví manažeři přitom oceňují jen několik z nich. Co by měl hlavní architekt změnit?

- [ ] Zrušit Architecture Repository, protože ukládání artefaktů je zbytečná režie
- [ ] Vynechat Phases B až D a navrhovat rovnou řešení v rámci projektů
- [x] Obsahově přizpůsobit rámec a tvořit jen artefakty, které stakeholdeři využijí
- [ ] Pokračovat beze změny, protože úplná sada artefaktů je povinná pro každou iteraci

> Problém je v rozsahu výstupů, proto pomůže obsahové přizpůsobení — výběr artefaktů podle skutečných zájmů stakeholderů. Úplná sada artefaktů povinná není, zrušení repozitáře by znemožnilo znovupoužití a vypuštění architektonických fází by odstranilo samotný návrh architektury.

### ? Telekomunikační operátor má zavedený proces řízení projektů se schvalovacími branami. Architekti zatím kontrolují projekty samostatně a nezávisle na branách, takže vedoucí projektů chodí na dvě různá schvalování. Jaké přizpůsobení je nejvhodnější?

- [ ] Terminologické — přejmenovat Compliance Review, aby lépe znělo vedoucím projektů
- [x] Procesní — napojit kontroly souladu v Phase G na existující schvalovací brány
- [ ] Obsahové — přidat do Architecture Definition Document kapitolu o branách projektu
- [ ] Žádné — kontrola souladu musí vždy probíhat odděleně od řízení projektů

> Jde o vazbu ADM na jiný proces, tedy o procesní přizpůsobení: kontroly souladu se zařadí do bran, které už existují. Přejmenování ani nová kapitola dokumentu duplicitní schvalování neodstraní a TOGAF oddělenou kontrolu nevyžaduje.

## Úprava průběhu ADM: slučování, vynechání, vstupní bod {#uprava-procesu .explain}

Procesní přizpůsobení může fáze **sloučit**, **zjednodušit**, změnit jejich **pořadí** nebo zahájit cyklus v **jiném místě** než v Preliminary Phase — podle toho, co už organizace má. Každá změna by měla být vědomá, zdůvodněná a zapsaná v rámci.

- **Slučování** se hodí u menšího rozsahu, např. Phases B, C a D zpracované společně jedním týmem.
- **Jiný vstupní bod**: pokud cílová architektura už existuje a je schválená, přizpůsobení může Phases A–D **zkrátit** na potvrzení zadání ve Statement of Architecture Work a ověření převzaté vize a architektury (odkazem na ně, bez nového rozpracování) a těžiště práce přesunout do plánování přechodu (Phases E a F); pokud jde o řízení změn existující architektury, pracuje se v Phase H.
- **Nevypouštět** činnosti, které chrání hodnotu architektury: zapojení stakeholderů, governance a průběžné **Requirements Management**.

*Příklad:* Úřad převzal od ministerstva schválenou cílovou architekturu agend. Phases B–D znovu nerozpracovává: v krátké Phase A potvrdí zadání ve Statement of Architecture Work, ověří platnost převzaté architektury a těžiště práce přesune do Phase E.

### ? Pobočka nadnárodní firmy dostala od centrály hotovou a schválenou cílovou architekturu pro svůj region. Úkolem pobočky je naplánovat, v jakém pořadí a v jakých projektech změny zavést. Výchozí stav pobočky je dobře zdokumentovaný. Jak má architekt pobočky průběh ADM nejlépe přizpůsobit?

- [ ] Začít Preliminary Phase a pro region nově definovat architektonické principy
- [ ] Projít znovu Phase B a cílovou obchodní architekturu regionu přepracovat
- [ ] Začít Phase G a okamžitě kontrolovat soulad probíhajících projektů
- [x] Phases A–D zkrátit na ověření převzatého cíle, těžiště dát do Phases E a F

> Cílová architektura existuje a je schválená a úkolem je naplánovat realizaci, takže těžiště práce leží ve Phases E a F; Phases A–D se nevypouštějí, ale zkrátí na potvrzení zadání (Statement of Architecture Work) a ověření, že převzatý cíl platí pro region. Nové principy ani přepracování Phase B nejsou potřeba a Phase G bez plánu přechodu nemá co řídit.

### ? Projekt v malé e-commerce firmě má omezený rozsah: nová platební služba, jeden tým, tři měsíce. Architekt chce postup zjednodušit, aby architektura nezdržovala dodávku. Která úprava ADM je v této situaci nejrozumnější?

- [x] Zpracovat Phases B, C a D společně, se stakeholdery i požadavky
- [ ] Vynechat Requirements Management, protože u malého projektu se požadavky nemění
- [ ] Vynechat schválení Architecture Vision, protože tým zná zadání z porady
- [ ] Zpracovat jen Phase D, protože platební služba je čistě technologická záležitost

> Sloučení architektonických fází je legitimní zjednodušení pro malý rozsah, pokud se zachová zapojení stakeholderů a správa požadavků. Vypuštění Requirements Management nebo schválení vize odstraňuje právě kontrolní prvky, které chrání hodnotu architektury, a platební služba má i obchodní a aplikační dopady.

### ? Architekt v pojišťovně navrhuje, aby se pro všechny malé změny vynechala Phase G, protože kontroly souladu „zdržují vývoj". Vedení se ptá, zda je to v souladu s rozumným přizpůsobením ADM. Jak zní nejlepší doporučení?

- [ ] Ano, Phase G je volitelná a lze ji vynechat u jakéhokoli projektu
- [ ] Ne, každá změna musí projít plným formálním jednáním Architecture Board
- [x] Zjednodušit governance úměrně riziku, ne ji úplně vypustit
- [ ] Přesunout kontroly souladu až do Phase H, kdy je změna v provozu

> Přizpůsobení má být úměrné — u malých změn lze kontrolu zlehčit (např. kontrolní seznam místo jednání), ale úplné vypuštění governance odstraní kontrolu, že realizace odpovídá architektuře. Plné jednání pro každou drobnost je naopak neúměrné a dodatečná kontrola v provozu přichází pozdě.

## Přizpůsobení podle zralosti organizace {#zralost .explain}

Organizace, která s podnikovou architekturou **začíná**, by neměla hned budovat úplnou praxi pro celý podnik. Lepší je zvolit **užší rozsah s viditelným přínosem**, lehčí governance a malou sadu výstupů, a praxi rozšiřovat postupně v dalších iteracích (**Architecture Context iterations** — Preliminary Phase a Phase A). **Zralá** organizace si naopak může dovolit širší rozsah, formální compliance a bohatší repozitář. Míra formálnosti má odpovídat tomu, co organizace dokáže udržet.

*Příklad:* Nemocnice začne jednou oblastí — objednávání pacientů — a teprve po prvním úspěchu rozšíří architektonickou praxi na celou nemocnici.

### ? Ministerstvo poprvé zakládá architektonický tým se třemi lidmi. Náměstek požaduje, aby tým do půl roku popsal úplnou výchozí i cílovou architekturu všech agend ministerstva a zavedl formální compliance pro všechny projekty. Co je nejlepší doporučení architekta?

- [ ] Přijmout zadání a rozdělit všechny agendy rovnoměrně mezi tři architekty
- [x] Začít užším rozsahem s viditelným přínosem a praxi rozšiřovat v dalších iteracích
- [ ] Odmítnout práci, dokud ministerstvo nezíská plně zralou architektonickou praxi
- [ ] Zavést formální compliance hned a popis architektury odložit na příští rok

> Při nízké zralosti je rozumné zvolit omezený rozsah, ukázat přínos a kapabilitu budovat postupně. Úplný popis všech agend třemi lidmi je nerealistický, čekat na zralost bez práce nelze a compliance bez popsané architektury nemá podle čeho kontrolovat.

### ? Velká banka má desetiletou architektonickou praxi, plně obsazený Architecture Board a rozsáhlý Architecture Repository. Nový ředitel IT navrhuje zrušit formální kontroly souladu a „začít s architekturou od nuly lehce, jako start-up". Jaký je nejlepší argument architekta?

- [ ] Formální kontroly jsou v TOGAF povinné ve stejné podobě pro každou organizaci
- [ ] Lehký přístup je vždy lepší, a proto je vhodné repozitář i Board zrušit
- [ ] Banka má začít znovu Preliminary Phase a zahodit všechny dosavadní výstupy
- [x] Míra formálnosti má odpovídat zralosti a riziku; zavedenou praxi spíš zeštíhlit

> Zralá organizace v regulovaném prostředí může a má využívat vyšší formálnost; případné zjednodušení se dělá úpravou existující praxe, ne jejím zrušením. TOGAF nepředepisuje jednotnou podobu kontrol, ale ani nedoporučuje zahodit fungující kapabilitu a hodnotné výstupy.

## Strategic × Segment × Capability Architecture v praxi {#uroven-architektury .compare}

Úroveň architektury se volí podle toho, **kdo rozhoduje** a **jak velkou změnu** architektura podporuje:

| | Strategic Architecture | Segment Architecture | Capability Architecture |
|---|---|---|---|
| Typický spouštěč | nová strategie, fúze, transformace celého podniku | program nebo portfolio v jedné oblasti podniku | konkrétní schopnost dodávaná projekty |
| Hlavní příjemce | vrcholové vedení | vlastník portfolia / programu, vedení divize | vedoucí projektu a realizační týmy |
| Detail | nízký, směr a principy | střední, cílový stav oblasti | vysoký, podklad pro realizaci |
| Časový horizont | dlouhý (roky) | střední | krátký, jednotlivé přírůstky |

### ? Generální ředitel pojišťovny oznámil pětiletou strategii přechodu na digitální prodej. Chce vědět, které oblasti podniku se změní, jaké jsou hlavní směry a v jakém pořadí se do nich bude investovat. Podrobné návrhy řešení zatím nepotřebuje. Jakou úroveň architektury má architekt zpracovat?

- [ ] Capability Architecture pro první prodejní aplikaci
- [ ] Segment Architecture pro oddělení životního pojištění
- [x] Strategic Architecture pro celý podnik
- [ ] Solution Building Blocks pro nový prodejní portál

> Dlouhodobý směr pro celý podnik určený vrcholovému vedení odpovídá Strategic Architecture s nízkým detailem. Segmentová a kapabilitní úroveň řeší jen část podniku a ve větším detailu; konkrétní SBB jsou na takové rozhodnutí předčasné.

### ? Vedoucí programu „Moderní reklamace" v obchodním řetězci řídí pět projektů za dva roky. Potřebuje ucelený cílový stav procesů, dat a aplikací pro oblast reklamací, aby projekty na sebe navazovaly. Strategie celé firmy už existuje. Jaká úroveň architektury je nejvhodnější?

- [x] Segment Architecture pro oblast reklamací
- [ ] Strategic Architecture pro celý řetězec
- [ ] Capability Architecture pro každý projekt zvlášť
- [ ] Transition Architecture bez cílového stavu

> Program v jedné oblasti podniku s ucelením několika projektů je typický případ Segment Architecture. Strategická úroveň už existuje a je pro program příliš obecná, samostatné kapabilitní architektury by projekty neprovázaly a přechodová architektura předpokládá definovaný cíl.

### ? Projektový tým v bance dodává v příštím čtvrtletí funkci online podpisu smluv. Segmentová architektura pro oblast smluv je hotová a schválená. Tým potřebuje přesný podklad: které komponenty se změní, jaká rozhraní vzniknou a jaké standardy použít. Jakou architekturu má architekt připravit?

- [ ] Strategic Architecture, aby podpis smluv odpovídal strategii banky
- [ ] Novou Segment Architecture pro oblast smluv s jiným cílovým stavem
- [ ] Žádnou, protože detailní návrh je výhradně záležitostí vývojového týmu
- [x] Capability Architecture s detailem potřebným pro realizaci projektu

> Konkrétní schopnost dodávaná projektem v krátkém horizontu s vysokým detailem odpovídá Capability Architecture, která vychází ze schválené segmentové architektury. Nová strategická ani segmentová architektura není potřeba a bez architektonického podkladu by se ztratila vazba na cílový stav.

## Vnořené cykly ADM napříč úrovněmi {#hierarchie-cyklu .explain}

Architekturu na různých úrovních nelze obvykle vytvořit jedním cyklem. ADM se proto spouští **hierarchicky**: cyklus na vyšší úrovni (typicky strategické) v plánování přechodu vymezí oblasti a práci, které vyžadují podrobnější architekturu, a z nich vznikají **nové Request for Architecture Work** pro cykly na nižší úrovni (segmentové, kapabilitní). Nižší cyklus pracuje **v mantinelech** vyššího — přebírá jeho principy, cíle a omezení — a zpětně hlásí zjištění, která mohou vyšší architekturu změnit.

*Příklad:* Strategická architektura energetické skupiny určí tři segmenty (výroba, distribuce, zákaznický servis); pro každý se spustí samostatný cyklus ADM.

### ? Strategický cyklus ADM ve skupině dopravních podniků dospěl k plánu, podle kterého je třeba podrobně navrhnout segment „Odbavení cestujících". Architekt chce zahájit samostatnou podrobnější práci pro tento segment. Jak má postupovat?

- [ ] Rozšířit Strategic Architecture o veškerý detail segmentu v rámci téhož cyklu
- [x] Spustit pro segment nový cyklus ADM s novým Request for Architecture Work
- [ ] Předat segment rovnou projektovým týmům bez další architektonické práce
- [ ] Počkat, až strategický cyklus projde Phase H, a teprve potom segment otevřít

> Podrobnější architektura segmentu vzniká v samostatném cyklu ADM, který se zahajuje novým Request for Architecture Work a pracuje v mantinelech strategické architektury. Doplňovat detail do strategického cyklu je nepřehledné, předání bez architektury ztrácí ucelenost a čekání na Phase H zbytečně zdržuje.

### ? Při práci na segmentové architektuře „Péče o zákazníka" tým zjistí, že jeden ze strategických principů (všechna zákaznická data v jednom centrálním systému) je v praxi neproveditelný kvůli regulaci jiného státu. Co je nejlepší další krok?

- [ ] Princip v segmentu tiše ignorovat a navrhnout vlastní řešení
- [ ] Zastavit práci na segmentu do konce platnosti strategické architektury
- [x] Zjištění eskalovat přes governance k přehodnocení na strategické úrovni
- [ ] Upravit strategický princip přímo v segmentové architektuře

> Nižší cyklus pracuje v mantinelech vyššího, a když narazí na jejich neproveditelnost, má zjištění vrátit k rozhodnutí na vyšší úrovni přes governance. Tiché ignorování ani jednostranná změna principu nejsou legitimní a zastavení práce problém neřeší.

## Volba rozsahu cyklu ADM {#rozsah-cyklu .explain}

Rozsah cyklu se volí podle účelu a dostupných zdrojů ve čtyřech dimenzích: **šíře** (jaká část podniku), **hloubka** (jak podrobně), **časový horizont** (jak daleko do budoucnosti) a **domény** (Business, Data, Application, Technology). Pravidlo zní: **tolik architektury, kolik je potřeba k rozhodnutí** — širší rozsah znamená obvykle menší hloubku. Pokud je zadání příliš široké na zdroje, je lepší rozsah zúžit nebo rozdělit do více cyklů než vše zpracovat povrchně.

*Příklad:* Pro rozhodnutí o outsourcingu datového centra stačí Technology Architecture v hloubce potřebné pro porovnání variant; obchodní architektura se popíše jen tam, kde ji změna ovlivní.

### ? Leasingová společnost má do tří let přejít na prodej přes partnerské prodejce. Vedení potřebuje architekturu, podle které rozhodne o pořadí investic v tomto období. Jeden architekt navrhuje popsat jen stav za šest měsíců, druhý cílový stav za patnáct let včetně technologií, které dnes neexistují. Jak má architekt stanovit časový horizont cyklu?

- [x] Cílový stav za tři roky s mezikroky podle plánovaných investic
- [ ] Jen stav za šest měsíců, protože delší výhled architektura neřeší
- [ ] Patnáct let, protože delší výhled vede vždy k lepšímu rozhodnutí
- [ ] Bez horizontu, protože čas není dimenzí rozsahu architektury

> Časový horizont se volí podle účelu: vedení rozhoduje o investicích do tříleté změny, takže cílový stav má pokrýt právě toto období. Šestiměsíční výhled nepokryje rozhodované investice, patnáctiletý je spekulativní a přesahuje potřebu rozhodnutí a časový horizont je jednou ze čtyř dimenzí rozsahu.

### ? Vedení distribuční firmy se má do měsíce rozhodnout, zda vybudovat vlastní sklad, nebo využít externího logistického partnera. Architekt plánuje rozsah architektonické práce. Který rozsah je nejvhodnější?

- [ ] Úplný detailní popis všech aplikací firmy včetně nesouvisejících oblastí
- [ ] Detailní technický návrh skladového systému před rozhodnutím o variantě
- [ ] Desetiletý strategický plán celé firmy ve všech čtyřech doménách
- [x] Dopady obou variant na dotčené procesy, data a aplikace v hloubce pro rozhodnutí

> Architektura má podpořit konkrétní rozhodnutí, takže rozsah se omezí na dotčené oblasti a hloubku potřebnou k porovnání variant. Popis nesouvisejících aplikací je zbytečný, detailní návrh před volbou varianty předčasný a desetiletý plán celé firmy přesahuje potřebu i termín.

### ? Při plánování cyklu ADM pro modernizaci zákaznického portálu energetické firmy architekt zvažuje, zda zahrnout Data Architecture. Portál bude nově zobrazovat spotřebu ze smart metrů, která dnes leží v jiném systému a v jiné struktuře. Jak má rozsah stanovit?

- [ ] Data Architecture vynechat, protože jde především o změnu uživatelského rozhraní
- [x] Data Architecture zahrnout, protože změna zasahuje do zdrojů a struktury dat
- [ ] Zahrnout jen Business Architecture a datové otázky přenechat dodavateli portálu
- [ ] Zahrnout Data Architecture pro celou firmu bez ohledu na rozsah změny portálu

> Domény se do rozsahu zařazují podle toho, kam změna skutečně zasahuje; nová data z jiného systému jsou jasný důvod zahrnout Data Architecture. Vynechání nebo přenechání dodavateli by přehlédlo podstatný dopad a celofiremní rozsah je naopak neúměrný.

## Účel architektury: Strategy × Portfolio × Project × Solution Delivery {#ucel-architektury .compare}

Podle toho, **k čemu** má architektura sloužit, se liší její detail, příjemci i způsob použití ADM:

| Účel | Co architektura podporuje | Typický detail a výstup |
|---|---|---|
| Strategy (strategie) | rozhodnutí vedení o směru a investicích | nízký detail, širší rozsah, roadmapa pro roky dopředu |
| Portfolio | výběr a provázání programů a projektů | střední detail, cílový stav oblasti, závislosti mezi iniciativami |
| Project (projekt) | ucelený návrh pro jeden projekt | vyšší detail, rozhodnutí o řešení v rámci projektu |
| Solution Delivery (dodávka řešení) | konkrétní realizaci a provoz řešení | nejvyšší detail, specifikace pro dodavatele a týmy |

Účel se má vyjasnit dřív, než se zvolí rozsah, výstupy a míra formálnosti cyklu.

### ? Investiční výbor holdingu každý rok vybírá z padesáti návrhů projektů ty, které se budou financovat. Výbor chce vědět, které návrhy se překrývají, které na sobě závisejí a které nejlépe přispívají k cílovému stavu. Jaký účel architektury nejlépe odpovídá této potřebě?

- [ ] Architektura pro dodávku řešení se specifikací pro dodavatele
- [ ] Architektura pro jeden projekt s detailním návrhem řešení
- [x] Architektura pro portfolio s vazbami a závislostmi iniciativ
- [ ] Architektura pro strategii bez vazby na konkrétní iniciativy

> Výběr a provázání mnoha iniciativ je typický účel architektury pro portfolio. Dodávka řešení a projektová architektura jsou pro takové rozhodnutí příliš podrobné a úzké a strategie bez vazby na iniciativy výboru neřekne, co financovat.

### ? Dodavatel staví pro nemocnici nový laboratorní systém. Strategie i cílová architektura oblasti jsou schválené a projekt běží. Dodavatel potřebuje přesně vědět, jaká rozhraní, standardy a omezení musí jeho řešení splnit. Jakému účelu má architektura v této fázi sloužit?

- [x] Dodávce řešení, s podrobnou specifikací požadavků a omezení
- [ ] Strategii, s přehledem směrů rozvoje celé nemocnice
- [ ] Portfoliu, se srovnáním všech projektů nemocnice
- [ ] Žádnému, protože po schválení cíle architektura končí

> Dodavatel konkrétního řešení potřebuje nejvyšší detail — architekturu pro dodávku řešení. Strategický ani portfoliový pohled mu nedá rozhraní a omezení a architektura po schválení cíle nekončí, ale řídí realizaci.

## Čtyři druhy iterací ADM {#typy-iteraci .compare}

Fáze ADM lze seskupit do iterací, které se opakují nezávisle na sobě (názvy podle TOGAF 9.2 a 10; ve vydání 9.1 Architecture Capability / Architecture Development):

| Iterace | Fáze | Účel | Kdy ji opakovat |
|---|---|---|---|
| Architecture Context | Preliminary, A | nastavit přístup, principy, rozsah, vizi a governance | zakládání nebo úprava architektonické praxe, nové zadání |
| Architecture Definition | B, C, D | vytvořit a zpřesnit obsah architektury | když se architektura postupně zpřesňuje nebo se řeší domény společně |
| Transition Planning | E, F | sestavit roadmapu a plán přechodu | když se ladí pořadí, hodnota a proveditelnost změn |
| Architecture Governance | G, H | řídit realizaci a změny architektury | průběžně během realizace a provozu |

### ? Firma má schválenou cílovou architekturu, ale návrh plánu přechodu narazil na omezený rozpočet a závislosti mezi projekty. Architekti chtějí několikrát za sebou přeskládat pořadí balíků práce a přechodových architektur, než najdou proveditelný plán. Který druh iterace provádějí?

- [ ] Architecture Context iterace
- [ ] Architecture Definition iterace
- [ ] Architecture Governance iterace
- [x] Transition Planning iterace

> Opakované ladění pořadí, hodnoty a proveditelnosti změn mezi Phases E a F je Transition Planning iterace. Context iterace řeší nastavení přístupu a vize, Definition iterace obsah architektury a Governance iterace dohled nad realizací.

### ? Nově jmenovaný hlavní architekt zjistil, že architektonický tým nemá dohodnuté principy, nejasně vymezené role a jeho práce nemá podporu vedení. Než začne tým tvořit další architektury, chce tyto základy napravit. Který druh iterace je vhodný?

- [ ] Architecture Definition iterace přes Phases B, C a D
- [x] Architecture Context iterace přes Preliminary Phase a Phase A
- [ ] Transition Planning iterace přes Phases E a F
- [ ] Architecture Governance iterace přes Phases G a H

> Nastavení principů, rolí, governance a podpory vedení je obsahem Architecture Context iterace. Ostatní iterace předpokládají, že tyto základy už fungují.

### ? Během realizace programu přicházejí každý měsíc žádosti o výjimky a drobné změny, které je třeba posoudit vůči architektuře, a občas se ukáže, že architekturu je potřeba upravit. Architekti chtějí tuto práci zorganizovat jako opakující se cyklus. Který druh iterace to je?

- [x] Architecture Governance iterace
- [ ] Transition Planning iterace
- [ ] Architecture Context iterace
- [ ] Architecture Definition iterace

> Dohled nad realizací a posuzování změn architektury patří do Phases G a H, tedy do Architecture Governance iterace. Plánování přechodu, nastavení praxe ani tvorba obsahu architektury tento průběžný dohled nepokrývají.

## Iterace uvnitř cyklu a návrat k předchozí fázi {#iterace-v-cyklu .explain}

ADM **není vodopád**. Když pozdější fáze odhalí skutečnost, která mění dříve přijatá rozhodnutí, architekt se **vrátí** k dotčené fázi a výstupy aktualizuje, místo aby chybu přenášel dál. Zjištění se zapíše jako požadavek do **Requirements Management**, posoudí se dopad a podle potřeby se znovu zapojí dotčení stakeholdeři. Návrat má být **cílený** — opravit to, co se změnilo, ne opakovat celý cyklus.

*Příklad:* V Phase D se zjistí, že navržená cloudová platforma neumí ukládat data v EU; architekt se vrací do Phase C k úpravě Data Architecture a zapíše nový požadavek.

### ? Během Phase C v pojišťovně architekt zjistí, že obchodní proces likvidace škod, schválený v Phase B, předpokládá ruční krok, který nová aplikace úplně odstraní. Proces v Business Architecture tedy neodpovídá navrhovanému řešení. Co je nejlepší další krok?

- [ ] Pokračovat do Phase D a rozpor vyřešit až při implementaci
- [ ] Zahájit celý cyklus ADM znovu od Preliminary Phase
- [x] Cíleně se vrátit k Business Architecture a zapsat požadavek
- [ ] Upravit aplikační architekturu tak, aby ruční krok zůstal zachován

> ADM počítá s návratem k dotčené fázi, když nové poznání mění dřívější rozhodnutí; změna se eviduje v Requirements Management. Odklad do implementace rozpor zvětší, restart celého cyklu je neúměrný a zachování zbytečného ručního kroku jde proti přínosu řešení.

### ? Ve Phase F se ukáže, že jeden z plánovaných balíků práce nelze kvůli licenčním podmínkám realizovat a cílová architektura musí na jednom místě použít jinou technologii. Projektový manažer chce změnu prostě zapsat do plánu. Jak má architekt postupovat?

- [ ] Souhlasit, protože ve Phase F už se cílová architektura nemění
- [ ] Ponechat plán beze změny a problém předat Architecture Board až po realizaci
- [ ] Zrušit celou cílovou architekturu a začít novou Phase A
- [x] Vrátit se k dotčené části cílové architektury, posoudit dopad a aktualizovat ji

> Změna cílové technologie mění cílovou architekturu, a ta se má cíleně aktualizovat s posouzením dopadů, než se promítne do plánu. Pouhý zápis do plánu vytváří nesoulad, odložení problému až po realizaci je pozdě a nová Phase A je neúměrná jedné změně.

## Souběžné cykly a dělení architektury {#soubezne-cykly .explain}

Ve větší organizaci běží **více cyklů ADM současně** — na různých úrovních, pro různé segmenty nebo v různých fázích. Aby si neodporovaly, architektura se **dělí** (partitioning) na zvládnutelné části, např. podle oblasti podniku, časového horizontu nebo úrovně detailu, a cykly se koordinují přes:

- sdílené **architektonické principy** a standardy,
- **Architecture Repository** (zejména Architecture Landscape), kde každý cyklus vidí aktuální stav ostatních,
- **Architecture Board**, který řeší konflikty a překryvy.

*Příklad:* Segmenty „Online prodej" a „Logistika" navrhují každý vlastní evidenci zákazníků; Architecture Board rozhodne o jedné sdílené komponentě.

### ? V telekomunikační firmě běží současně tři cykly ADM pro různé segmenty. Při revizi se ukáže, že dva z nich nezávisle navrhují vlastní systém pro správu identit zákazníků s odlišnými standardy. Co je nejlepší krok?

- [ ] Nechat oba návrhy, protože segmenty mají plnou autonomii
- [ ] Zastavit oba cykly a sloučit je do jednoho velkého cyklu ADM
- [ ] Rozhodnout ve prospěch segmentu, který dokončí návrh dříve
- [x] Předložit překryv Architecture Board a sladit řešení se standardy

> Konflikty mezi souběžnými cykly řeší governance — Architecture Board rozhodne o sdílené komponentě v souladu se standardy. Ponechání duplicity zvyšuje náklady, sloučení do jednoho cyklu ruší výhody dělení a rozhodnutí podle rychlosti není věcné.

### ? Architekt nového cyklu ADM pro oblast „Mzdy a personalistika" chce zjistit, jaké změny v aplikační krajině už naplánovaly jiné běžící architektonické práce, aby jim neodporoval. Kde má tuto informaci primárně hledat?

- [x] V Architecture Landscape v Architecture Repository
- [ ] V osobních poznámkách vedoucích jednotlivých projektů
- [ ] V Business Scenarios jiných oddělení firmy
- [ ] V Architecture Contract nejbližšího dodavatele

> Architecture Landscape v repozitáři eviduje architektury různých úrovní a horizontů, a proto slouží právě ke koordinaci souběžných cyklů. Osobní poznámky nejsou spolehlivý zdroj, Business Scenarios popisují potřeby, ne plánované změny krajiny, a jednotlivá smlouva pokrývá jen jednu realizaci.

## Přizpůsobení pro federovanou organizaci {#federace .explain}

Ve **federované** organizaci (holding, nadnárodní skupina s autonomními divizemi) není realistické řídit veškerou architekturu centrálně. Osvědčené přizpůsobení: **centrum** určuje společné principy, standardy pro sdílené oblasti a strategickou architekturu; **divize** vytvářejí vlastní segmentové a kapabilitní architektury v těchto mantinelech. Rozhodovací práva a rozsah centrální governance se definují v Preliminary Phase, aby bylo jasné, co je **povinné pro všechny** a co je na divizi.

*Příklad:* Skupina s pivovary v pěti zemích sdílí standardy pro finanční výkaznictví a identitu zákazníka, ale výrobní systémy si každá země volí sama.

### ? Nadnárodní potravinářská skupina má osm národních společností s vlastním IT. Centrála chce společnou podnikovou architekturu, ale národní ředitelé odmítají, aby o každém jejich systému rozhodovala centrála. Jaké přizpůsobení ADM je nejvhodnější?

- [ ] Plně centralizovat architekturu i rozhodování o všech systémech v centrále
- [x] Centrum určí společné principy a standardy, země tvoří segmenty v jejich mezích
- [ ] Nechat každou zemi pracovat s vlastním rámcem a společnou architekturu nezavádět
- [ ] Vynechat Preliminary Phase a dohodnout pravidla až podle prvních konfliktů

> Federované uspořádání odpovídá rozdělení: společné principy a standardy z centra, vlastní segmentové architektury v zemích. Plná centralizace naráží na autonomii, úplná decentralizace popírá cíl společné architektury a rozhodovací práva se mají vymezit předem v Preliminary Phase.

### ? Ve federované bankovní skupině chce dceřiná banka zavést vlastní řešení pro správu klientských identit. Skupinové principy přitom stanovují jednotný standard identit pro všechny dceřiné společnosti kvůli sdíleným klientům. Jak má architekt dceřiné banky postupovat?

- [ ] Zavést vlastní řešení, protože ve federaci má každá dceřiná banka plnou volnost
- [ ] Požádat o zrušení skupinových principů, protože omezují místní inovace
- [x] Dodržet skupinový standard, nebo požádat skupinovou governance o výjimku
- [ ] Zavést vlastní řešení a skupinu informovat až po jeho spuštění do provozu

> Federace neznamená volnost ve všem — oblasti stanovené jako společné jsou závazné a odchylka se řeší formální žádostí o výjimku. Jednostranné zavedení obchází governance a zrušení principů kvůli jednomu řešení je neúměrné.

## TOGAF s jinými rámci a metodami {#jine-ramce .explain}

TOGAF se v praxi kombinuje s dalšími rámci; přizpůsobení má určit **rozhraní** mezi nimi, aby se činnosti nezdvojovaly a nevznikaly mezery:

- **jazyk modelování** — ArchiMate pro zápis artefaktů ADM,
- **řízení projektů a programů** (např. PRINCE2, PMBOK) — realizace work packages, napojení Phase G na řízení projektů,
- **řízení IT služeb** (např. ITIL) — provoz a změny v provozu, napojení na Phase H,
- **governance IT** (např. COBIT) — rámec odpovědností, do kterého zapadá Architecture Governance,
- **klasifikační schémata** (např. Zachman) — kontrola úplnosti popisu.

TOGAF tyto rámce **nenahrazuje**; dodává metodu vývoje architektury a navazuje na ně.

*Příklad:* Úřad řídí projekty podle PRINCE2; Architecture Contract se stává vstupem do Project Initiation a soulad se kontroluje v projektových fázích.

### ? Logistická firma řídí všechny projekty podle PRINCE2 a provoz IT podle ITIL. Architekti se obávají, že TOGAF „přidá třetí byrokracii". Co je nejlepší doporučení k přizpůsobení?

- [ ] Nahradit PRINCE2 i ITIL procesy ADM, aby firma měla jeden rámec
- [ ] Používat TOGAF jen v architektonickém týmu bez vazby na projekty a provoz
- [ ] Zrušit ITIL, protože Phase H řízení změn v provozu plně pokrývá
- [x] Definovat rozhraní ADM na PRINCE2 a ITIL a činnosti nezdvojovat

> TOGAF se má napojit na existující rámce a vymezit rozhraní, ne je nahrazovat. Izolovaný TOGAF bez vazby na projekty a provoz nemá vliv a Phase H řeší změny architektury, nikoli řízení IT služeb v provozu.

### ? Architektonický tým v pojišťovně tvoří diagramy v různých nástrojích s nejednotnou notací a stakeholdeři si je vykládají rozdílně. Tým se ptá, zda má TOGAF předepsat vlastní notaci, nebo použít jiný standard. Co je nejlepší doporučení?

- [x] Použít ArchiMate jako jazyk modelování pro artefakty vytvářené v ADM
- [ ] Nahradit ADM metodou ArchiMate, protože obsahuje vlastní fáze vývoje
- [ ] Ponechat různé notace, protože TOGAF žádné sjednocení nedoporučuje
- [ ] Zavést Zachman Framework jako notaci místo diagramů ADM

> ArchiMate je modelovací jazyk, který doplňuje TOGAF a sjednotí zápis artefaktů. ArchiMate metodu vývoje nenahrazuje, nejednotná notace je právě problém a Zachman je klasifikační schéma, ne notace.

### ? Banka zavádí TOGAF a zároveň má COBIT jako rámec governance IT. Architekt navrhuje, jak umístit Architecture Board a kontroly souladu do existující struktury výborů a odpovědností. Která formulace nejlépe vystihuje vztah obou rámců?

- [ ] COBIT nahrazuje Architecture Governance, takže Architecture Board není potřeba
- [ ] Architecture Governance stojí mimo governance IT a má vlastní nezávislé výbory
- [x] Architecture Governance se začlení do širšího rámce governance IT podle COBIT
- [ ] COBIT se použije místo ADM pro vývoj Business a Technology Architecture

> Architecture Governance je součástí širší governance IT a podniku; přizpůsobení ji má zapojit do existujících výborů a odpovědností. COBIT ji nenahrazuje ani neobsahuje metodu vývoje architektury a paralelní nezávislé struktury by vedly ke zdvojení.

## ADM a agilní dodávka {#agilni-pristup .explain}

TOGAF Series Guides popisují, jak ADM používat v organizaci, která dodává agilně. Hlavní myšlenky:

- **Strategická a segmentová architektura** dává směr, principy a mantinely (guardrails) a mění se pomaleji.
- **Architektura na úrovni kapabilit** vzniká **iterativně a průběžně** spolu s dodávkou — „tolik architektury, kolik je potřeba" pro nejbližší přírůstky, žádný rozsáhlý návrh předem.
- Architekt pracuje **s týmy**, ne nad nimi; governance je **lehká a průběžná** (principy, standardy, včasné konzultace) místo jednorázových bran na konci.
- Cykly ADM jsou **kratší** a mohou běžet souběžně s dodávkou.

*Příklad:* Fintech má schválené principy a cílový stav platformy; týmy v každém sprintu doplňují detail architektury komponent a architekt jej s nimi průběžně sladuje.

### ? E-commerce firma přechází na agilní vývoj s dvoutýdenními sprinty. Architektonický tým zatím vždy půl roku zpracovával úplnou detailní architekturu, než mohly týmy začít. Vývojáři tvrdí, že architekturu v agilním světě nepotřebují vůbec. Co je nejlepší doporučení?

- [ ] Zrušit architektonickou práci, protože agilní týmy si architekturu navrhnou samy
- [x] Ponechat směr a mantinely na vyšších úrovních a detail tvořit průběžně s týmy
- [ ] Zachovat půlroční detailní návrh a sprinty spustit až po jeho schválení
- [ ] Přesunout celou architektonickou práci až do Phase H po dodání řešení

> Agilní pojetí ADM zachovává strategickou a segmentovou architekturu jako mantinely a detail na úrovni kapabilit tvoří iterativně s dodávkou. Zrušení architektury vede k nesourodým řešením, rozsáhlý návrh předem popírá agilitu a architektura až po dodání nemá na řešení vliv.

### ? V agilní organizaci si týmy stěžují, že architekt se objevuje až na konci každého čtvrtletí a „vrací" už hotovou práci kvůli nesouladu se standardy. Jaká změna způsobu governance nejlépe odpovídá agilnímu použití TOGAF?

- [ ] Zrušit standardy, aby týmy nemusely nic vracet
- [ ] Zavést schvalování architektem u každého jednotlivého commitu
- [ ] Prodloužit kontrolní cyklus na rok, aby bylo kontrol méně
- [x] Průběžně konzultovat s týmy a opřít se o jasné principy a standardy

> Agilní governance je lehká a průběžná: jasné principy a standardy a včasná spolupráce s týmy, aby se nesoulad zachytil dřív, než vznikne. Zrušení standardů odstraní mantinely, schvalování commitů je neúměrné a delší cyklus problém pozdního zjištění zhorší.

### ? Fintech plánuje novou platformu pro investice. Architekt chce postup sladit s agilní dodávkou, ale zároveň zajistit, aby týmy nepostavily nekompatibilní řešení. Které rozhodnutí je jako první krok nejvhodnější?

- [x] Dohodnout cílový směr a principy platformy, detail doplňovat průběžně
- [ ] Nechat týmy dodat první verze a architekturu popsat až zpětně podle výsledku
- [ ] Nejprve detailně specifikovat všechny komponenty platformy na tři roky dopředu
- [ ] Rozdělit platformu mezi týmy a nechat každý tým zvolit vlastní standardy

> Bez společného směru a principů týmy postaví nekompatibilní části, takže prvním krokem je dohodnout mantinely a detail doplňovat iterativně. Zpětný popis už nic neusměrní, tříletá detailní specifikace popírá agilitu a vlastní standardy každého týmu vedou právě k nekompatibilitě.

## Situace → doporučené přizpůsobení (shrnutí) {#rozhodovani .compare}

Přehled typických situací a toho, co v nich zvolit:

| Situace | Doporučená volba |
|---|---|
| organizace s EA začíná, má málo lidí | úzký rozsah s viditelným přínosem, lehká governance, rozšiřovat v Architecture Context iteracích |
| cílová architektura je už schválená | Phases A–D zkrátit na ověření schváleného cíle, těžiště ve Phases E a F |
| výchozí stav je nejasný nebo sporný | Baseline First |
| cíl je dohodnutý, výchozí stav známý | Target First |
| rozhodnutí vedení o směru celé firmy | Strategic Architecture, nízký detail |
| program v jedné oblasti podniku | Segment Architecture |
| konkrétní projekt nebo přírůstek | Capability Architecture |
| federovaná skupina | společné principy a standardy z centra, segmenty v divizích |
| zavedené jiné rámce (PRINCE2, ITIL, COBIT) | vymezit rozhraní, nezdvojovat |
| agilní dodávka | mantinely shora, detail průběžně s týmy, lehká průběžná governance |

### ? Nemocniční síť má schválenou strategickou architekturu. Nyní chce v příštích dvou letech sjednotit objednávání pacientů ve všech nemocnicích v rámci jednoho programu. Výchozí stav objednávání se v každé nemocnici liší a nikdo nemá jeho úplný přehled. Jaká kombinace voleb je nejvhodnější?

- [ ] Capability Architecture s přístupem Target First
- [ ] Strategic Architecture s přístupem Baseline First
- [x] Segment Architecture s přístupem Baseline First
- [ ] Segment Architecture s přístupem Target First

> Program v jedné oblasti podniku odpovídá Segment Architecture a nejasný, v každé nemocnici odlišný výchozí stav je důvodem pro Baseline First. Strategická úroveň už existuje, kapabilitní je pro celý program příliš úzká a Target First by navrhoval cíl bez znalosti rozdílných výchozích podmínek.

### ? Malá rodinná firma s jedním IT pracovníkem chce poprvé použít TOGAF při výměně ERP. Majitel má jasnou představu o cílovém stavu a současné systémy jsou jednoduché a dobře známé. Projekt má trvat devět měsíců. Jaký přístup k přizpůsobení ADM je nejvhodnější?

- [ ] Úplný ADM se všemi artefakty a formálním Architecture Board ze tří lidí
- [x] Odlehčený ADM s malou sadou výstupů, Target First a lehkou governance
- [ ] Vynechat ADM úplně a nechat výběr ERP výhradně na dodavateli systému
- [ ] Baseline First s podrobným popisem současného stavu před jakýmkoli návrhem

> Malá organizace, jasný cíl a známý výchozí stav vedou k odlehčenému ADM s Target First a úměrnou governance. Úplný formální aparát je neúměrný, přenechání všeho dodavateli ztrácí kontrolu nad cílem a podrobný popis jednoduchého, známého stavu je zbytečná práce.
