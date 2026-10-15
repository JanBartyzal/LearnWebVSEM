---
kind: topic
subject: ict-strategie
slug: vztah-firemni-a-informacni-strategie
name: "Vztah firemní a informační strategie"
order: 3
---

Řešení vztahu firemní nebo podnikatelské strategie na informační strategii, nezbytné respektování vstupů z firemní strategie do informační strategie, uplatnění metod Balanced Scorecard, SWOT analýzy, CMM, analýzy potenciálních zlepšení atd. Možnosti exaktních specifikací požadovaných efektů z rozvoje informatiky do podnikání a zvyšování kvality řízení firmy.

## Sladění podnikání a informatiky (business–IT alignment) {#business-it-alignment .term}

Stav, kdy cíle, priority a kapacity IS/ICT odpovídají **firemní strategii** a obchodním cílům a informatika je zároveň brána v úvahu už při jejich tvorbě. Nejde o jednorázový akt, ale o **trvalý proces**, protože se mění firemní strategie i technologie. Nesladění se projevuje IT projekty bez jasného přínosu, duplicitami a tím, že informatika obchodní změny spíše brzdí, než umožňuje.

### ? Které tvrzení nejlépe vystihuje business–IT alignment?

- [ ] Jednorázové schválení ročního rozpočtu IT vedením firmy
- [ ] Převedení útvaru IT pod finančního ředitele
- [x] Trvalý soulad cílů a priorit IT s firemní strategií
- [ ] Sjednocení všech aplikací u jednoho dodavatele

> Sladění je průběžný proces, při kterém se cíle a priority informatiky udržují v souladu s firemní strategií. Rozpočet, organizační podřízenost ani volba dodavatele samy o sobě sladění nezajistí.

### ? Útvar IT každoročně dodá všechny plánované projekty včas a v rozpočtu, ale obchodní ředitel tvrdí, že mu informatika nepomáhá vstoupit na nové trhy. Co to naznačuje?

- [x] Nedostatečné sladění IT s firemní strategií
- [ ] Nízkou technickou kvalitu dodaných systémů
- [ ] Příliš vysoký rozpočet útvaru IT
- [ ] Chybějící outsourcing provozu IT

> IT pracuje efektivně („dělá věci správně"), ale zjevně nedělá ty projekty, které firemní strategie potřebuje („dělá správné věci"). To je typický projev nesladění IT s byznysem.

## Vstupy z firemní strategie do informační strategie {#vstupy-firemni-strategie .explain}

Informační strategie se **odvozuje z firemní (podnikatelské) strategie** a musí respektovat její vstupy. Klíčové jsou: **vize, poslání a strategické cíle** firmy; **kritické faktory úspěchu**; obchodní model, cíloví zákazníci, trhy a produkty; **podnikové procesy** a jejich plánované změny; organizační struktura a plánované změny (akvizice, fúze, expanze); finanční a personální možnosti firmy; legislativní a regulatorní požadavky. Pokud firemní strategie není formalizovaná, musí ji tvůrci informační strategie nejprve **vyjasnit s vedením** (např. řízenými rozhovory s manažery) — jinak hrozí, že si informatika cíle „domyslí" sama.

*Příklad:* Firemní strategie počítá do dvou let s expanzí na německý trh. Informační strategie proto musí zahrnout vícejazyčný e-shop, platby v cizí měně a účetnictví podle místních pravidel.

### ? Který z následujících podkladů NEPATŘÍ mezi typické vstupy z firemní strategie do informační strategie?

- [ ] Strategické cíle a kritické faktory úspěchu firmy
- [ ] Plánované změny podnikových procesů
- [ ] Záměr expandovat na nové zahraniční trhy
- [x] Výběr konkrétního databázového serveru

> Volba databázového serveru je technické rozhodnutí, které je až důsledkem informační strategie a architektury. Cíle, kritické faktory úspěchu, změny procesů a expanze jsou vstupy z firemní strategie.

### ? Firma chce připravit informační strategii, ale vedení nemá firemní strategii písemně formulovanou. Jaký je správný postup?

- [ ] Odvodit cíle informatiky jen z technologických trendů
- [x] Vyjasnit cíle firmy s vedením, např. rozhovory
- [ ] Odložit informační strategii o několik let
- [ ] Převzít strategické cíle od konkurenční firmy

> Bez vstupů z firemní strategie nelze informační strategii sladit s byznysem. Chybějící cíle je proto nutné nejprve vyjasnit s vedením, nikoli je nahradit technologickými trendy nebo cizí strategií.

## Informatika jako podpora × jako hnací síla {#it-podpora-vs-enabler .compare}

Vztah firemní a informační strategie může být jednosměrný (IT strategie se odvozuje z firemní), nebo obousměrný (informatika také přináší nové obchodní možnosti a ovlivňuje firemní strategii).

| | IT jako podpora (reaktivní) | IT jako hnací síla (proaktivní, enabler) |
|---|---|---|
| Směr vlivu | firemní strategie → IT | firemní strategie ↔ IT |
| Role informatiky | realizuje požadavky byznysu | navrhuje nové obchodní příležitosti |
| Typické cíle | efektivita, úspora nákladů, stabilní provoz | nové produkty, kanály, obchodní modely |
| Postavení CIO | správce IT služeb | partner vedení při tvorbě strategie |
| Příklad | automatizace fakturace | prodej přes mobilní aplikaci, datové služby |

### ? Banka zavede mobilní aplikaci, díky které začne nabízet nový produkt a získá novou skupinu zákazníků. Jak se zde informatika projevuje vůči firemní strategii?

- [ ] Jako čistě podpůrná nákladová funkce
- [ ] Jako náhrada za firemní strategii
- [x] Jako hnací síla (enabler) obchodních změn
- [ ] Jako vhodný předmět outsourcingu

> Informatika zde neplní jen požadavky byznysu, ale umožňuje nový produkt a oslovení nových zákazníků — působí jako hnací síla, která firemní strategii spoluutváří.

## Henderson–Venkatramanův model strategického sladění (SAM) {#sam-model .explain}

Model strategického sladění (Strategic Alignment Model, SAM; J. C. Henderson a N. Venkatraman, IBM Systems Journal, 1993) popisuje sladění jako vztah **čtyř domén** uspořádaných ve dvou dimenzích: **externí (strategická) × interní (infrastrukturní)** úroveň a **byznys × IT**. Vznikají domény **podniková strategie**, **IT strategie**, **organizační infrastruktura a procesy** a **IS infrastruktura a procesy**. Sladění vyžaduje dva typy vazeb: **strategický soulad (strategic fit)** mezi externí a interní úrovní a **funkční integraci** mezi byznysem a IT. Hlavní myšlenka: nestačí sladit jednu dvojici domén, přínos dává provázání všech čtyř; IT strategie je přitom samostatná strategická doména (jak se firma prostřednictvím IT postaví na trhu), nikoli jen interní záležitost.

*Příklad:* Výrobce přejde na prodej „stroj jako služba". Podle SAM musí upravit organizaci a procesy (servis, fakturace), IT strategii (sledování provozu strojů u zákazníků) i IS infrastrukturu (sběr dat ze strojů, předplatné).

### ? Které dvě dimenze tvoří Henderson–Venkatramanův model strategického sladění (SAM)?

- [ ] Náklady × přínosy a krátkodobé × dlouhodobé cíle
- [ ] Silné × slabé stránky a příležitosti × hrozby
- [ ] Zákazníci × procesy a finance × rozvoj
- [x] Externí × interní úroveň a byznys × IT

> SAM kombinuje strategickou (externí) a infrastrukturní (interní) úroveň se stranou byznysu a IT, čímž vznikají čtyři domény. Silné a slabé stránky patří do SWOT, zákazníci a finance do Balanced Scorecard.

### ? Kolik domén obsahuje Henderson–Venkatramanův model strategického sladění?

- [x] Čtyři
- [ ] Dvě
- [ ] Pět
- [ ] Šest

> Domény jsou čtyři: podniková strategie, IT strategie, organizační infrastruktura a procesy, IS infrastruktura a procesy — vznikají kombinací dvou dimenzí (externí × interní, byznys × IT).

## Domény modelu SAM {#sam-domeny .compare}

Každou ze čtyř domén popisují autoři třemi složkami.

| Doména | Úroveň a strana | Složky |
|---|---|---|
| Podniková strategie | externí, byznys | rozsah podnikání (business scope), rozlišující kompetence, řízení podniku (business governance) |
| IT strategie | externí, IT | rozsah technologií (technology scope), systémové kompetence, IT governance |
| Organizační infrastruktura a procesy | interní, byznys | organizační (administrativní) uspořádání, procesy, dovednosti |
| IS infrastruktura a procesy | interní, IT | architektura IS, procesy (vývoj, provoz), dovednosti pracovníků IT |

### ? Do které domény modelu SAM patří rozhodnutí, jaké technologie firma využije a jakými systémovými kompetencemi se odliší od konkurence?

- [ ] Organizační infrastruktura a procesy
- [x] IT strategie
- [ ] IS infrastruktura a procesy
- [ ] Podniková strategie

> Rozsah technologií, systémové kompetence a IT governance jsou složky domény IT strategie, která je na externí (strategické) úrovni na straně IT.

### ? Firma řeší, jak uspořádá datová centra a aplikační architekturu a jaké dovednosti potřebují pracovníci provozu IT. Které doméně modelu SAM to odpovídá?

- [ ] IT strategii
- [ ] Podnikové strategii
- [x] IS infrastruktuře a procesům
- [ ] Organizační infrastruktuře a procesům

> Architektura, procesy a dovednosti na straně informatiky tvoří interní doménu IS infrastruktura a procesy. Organizační infrastruktura řeší totéž na straně byznysu.

## Strategický soulad (strategic fit) {#strategicka-integrace .term}

V modelu SAM **vertikální vazba** mezi externí (strategickou) a interní (infrastrukturní) úrovní — na straně byznysu mezi podnikovou strategií a organizační infrastrukturou, na straně IT mezi IT strategií a IS infrastrukturou. Vyjadřuje, že vnitřní uspořádání (struktura, procesy, dovednosti, architektura) musí odpovídat tomu, jak se firma rozhodla postavit na trhu.

### ? Firma vyhlásila IT strategii „všechny nové aplikace jako cloudové služby", ale stále rozšiřuje vlastní datové centrum a správci nemají cloudové dovednosti. Která vazba modelu SAM je narušená?

- [x] Strategický soulad na straně IT
- [ ] Funkční integrace na strategické úrovni
- [ ] Funkční integrace na operativní úrovni
- [ ] Strategický soulad na straně byznysu

> Rozpor je mezi IT strategií (externí úroveň) a IS infrastrukturou a dovednostmi (interní úroveň) — jde tedy o vertikální strategický soulad na straně IT.

## Funkční integrace (functional integration) {#funkcni-integrace .term}

V modelu SAM **horizontální vazba** mezi stranou byznysu a stranou IT. Probíhá na dvou úrovních: na **strategické** (podniková strategie × IT strategie) a na **operativní** (organizační infrastruktura a procesy × IS infrastruktura a procesy). Pozor na terminologii: v původním článku se horizontální vazba na strategické úrovni nazývá *strategic integration*, proto zde pro vertikální vazbu používáme pojem strategický soulad; české překlady se liší — podstatné je rozlišovat vertikální a horizontální směr.

### ? Obchodní útvar zavedl nový proces objednávek, ale informační systém ho nepodporuje, takže pracovníci vedou objednávky v tabulkách mimo systém. Která vazba modelu SAM selhala?

- [ ] Strategický soulad na straně IT
- [ ] Strategický soulad na straně byznysu
- [x] Funkční integrace na operativní úrovni
- [ ] Funkční integrace na strategické úrovni

> Nesoulad je mezi procesy na straně byznysu a IS infrastrukturou, tedy horizontálně na interní (operativní) úrovni — jde o funkční integraci.

### ? Jaký je rozdíl mezi strategickým souladem (strategic fit) a funkční integrací v modelu SAM?

- [ ] Strategický soulad spojuje byznys a IT, funkční integrace externí a interní úroveň
- [x] Strategický soulad je vertikální, funkční integrace horizontální
- [ ] Strategický soulad se týká jen IT, funkční integrace jen byznysu
- [ ] Obě vyjadřují totéž, liší se jen časovým horizontem

> Strategic fit propojuje strategickou a infrastrukturní úroveň uvnitř byznysu i uvnitř IT, funkční integrace propojuje byznys s IT na strategické i operativní úrovni.

## Perspektivy sladění v modelu SAM {#sam-perspektivy .compare}

Henderson a Venkatraman popisují čtyři typické perspektivy sladění — postup od výchozí domény přes klíčovou doménu k doméně, která se přizpůsobuje. První dvě vycházejí z podnikové strategie, druhé dvě z IT strategie.

| Perspektiva | Výchozí doména | Klíčová doména | Ovlivněná doména |
|---|---|---|---|
| Realizace strategie (strategy execution) | podniková strategie | organizační infrastruktura | IS infrastruktura |
| Technologická transformace | podniková strategie | IT strategie | IS infrastruktura |
| Konkurenční potenciál | IT strategie | podniková strategie | organizační infrastruktura |
| Úroveň služeb (service level) | IT strategie | IS infrastruktura | organizační infrastruktura |

### ? Firma zjistí, že nová technologie (analýza dat ze senzorů ve strojích) umožňuje nabídnout zákazníkům zcela nový servis, a podle toho upraví svou podnikovou strategii. O kterou perspektivu sladění v modelu SAM jde?

- [ ] Realizace strategie
- [ ] Technologická transformace
- [ ] Úroveň služeb
- [x] Konkurenční potenciál

> Výchozím bodem je IT strategie (nová technologická možnost), která mění podnikovou strategii a následně organizaci — to je perspektiva konkurenčního potenciálu.

### ? Vedení zvolí podnikovou strategii, podle ní upraví organizaci a procesy a informatika pak dodá infrastrukturu, která je podporuje. O kterou perspektivu sladění v modelu SAM jde?

- [x] Realizace strategie
- [ ] Konkurenční potenciál
- [ ] Technologická transformace
- [ ] Úroveň služeb

> Postup podniková strategie → organizační infrastruktura → IS infrastruktura odpovídá perspektivě realizace strategie, v níž informatika strategii následuje.

## Balanced Scorecard (BSC) {#balanced-scorecard .explain}

Balanced Scorecard (vyvážený systém ukazatelů; R. S. Kaplan a D. P. Norton, 1992) převádí strategii na měřitelné cíle a ukazatele ve **čtyřech perspektivách**: **finanční**, **zákaznické**, **interních procesů** a **učení se a růstu**. Vyváženost znamená, že vedle finančních ukazatelů sleduje i nefinanční faktory, které budoucí výkonnost teprve vytvářejí. Cíle v perspektivách jsou propojeny **vztahy příčin a následků** (znázorňuje je strategická mapa): dovednosti a systémy → lepší procesy → spokojení zákazníci → finanční výsledky. Ke každému cíli se stanoví ukazatel, cílová hodnota a iniciativa. Pro informatiku je BSC užitečný dvojím způsobem: IT podporuje měření firemního BSC a útvar IT si může sestavit vlastní BSC navázaný na firemní.

*Příklad:* Cíl „zkrátit dodací lhůtu" (perspektiva procesů) je podmíněn zavedením nového skladového systému a zaškolením lidí (učení se a růst) a má vést k vyšší spokojenosti zákazníků i tržbám.

### ? Která perspektiva NEPATŘÍ mezi čtyři perspektivy klasického Balanced Scorecard?

- [ ] Zákaznická
- [x] Konkurenční
- [ ] Interních procesů
- [ ] Učení se a růstu

> Klasický BSC má perspektivy finanční, zákaznickou, interních procesů a učení se a růstu. Samostatná „konkurenční" perspektiva v něm není.

### ? Co znamená „vyváženost" v Balanced Scorecard?

- [ ] Rozpočet je rovnoměrně rozdělen mezi všechny útvary
- [ ] Každá perspektiva má přesně stejný počet ukazatelů
- [ ] Krátkodobé a dlouhodobé cíle se střídají po letech
- [x] Kombinuje finanční i nefinanční ukazatele výkonnosti

> BSC vyvažuje finanční výsledky (které ukazují minulost) nefinančními ukazateli zákazníků, procesů a rozvoje, které budoucí výkonnost vytvářejí.

## IT Balanced Scorecard {#it-balanced-scorecard .compare}

IT Balanced Scorecard (W. Van Grembergen) přizpůsobuje čtyři perspektivy útvaru informatiky a umožňuje měřit jeho příspěvek k firemním cílům.

| Klasický BSC | Perspektiva IT BSC | Klíčová otázka | Příklad ukazatele |
|---|---|---|---|
| finanční | přínos pro firmu (corporate contribution) | Jak informatiku vnímá vedení? | podíl IT projektů s doloženým přínosem, náklady IT vůči plánu |
| zákaznická | orientace na uživatele (user orientation) | Jak informatiku vnímají uživatelé? | spokojenost uživatelů, plnění SLA |
| interních procesů | provozní dokonalost (operational excellence) | Jak efektivní jsou procesy IT? | dostupnost systémů, doba řešení incidentů, projekty v termínu |
| učení se a růstu | orientace na budoucnost (future orientation) | Je IT připraveno na budoucí potřeby? | hodiny školení na pracovníka, výzkum nových technologií |

### ? Útvar IT sleduje ukazatel „průměrná spokojenost uživatelů s helpdeskem". Do které perspektivy IT Balanced Scorecard patří?

- [ ] Přínos pro firmu
- [ ] Provozní dokonalost
- [ ] Orientace na budoucnost
- [x] Orientace na uživatele

> Spokojenost uživatelů odpovídá zákaznické perspektivě klasického BSC, která se v IT BSC nazývá orientace na uživatele.

### ? Do které perspektivy IT Balanced Scorecard zařadíte ukazatel „počet hodin odborného školení na jednoho pracovníka IT za rok"?

- [x] Orientace na budoucnost
- [ ] Orientace na uživatele
- [ ] Přínos pro firmu
- [ ] Provozní dokonalost

> Rozvoj dovedností pracovníků IT připravuje informatiku na budoucí potřeby, odpovídá tedy perspektivě učení se a růstu, v IT BSC orientaci na budoucnost.

## Kaskádování cílů a předstihové ukazatele {#kaskadovani-cilu .explain}

Aby IT BSC sloužil sladění, jeho cíle se **kaskádují** z firemních: každý cíl informatiky má být dohledatelně navázán na konkrétní firemní cíl a u každého firemního cíle je vidět, jak k němu IT přispívá. Na stejném principu stojí kaskáda cílů v COBIT 2019 (cíle podniku → cíle sladění → cíle governance a managementu). Ukazatele se dělí na **zpožděné (lag)**, které měří výsledek, až nastane (tržby, zisk, spokojenost), a **předstihové (lead)**, které měří hybné síly výsledku předem (dostupnost systému, počet zaškolených uživatelů). Dobrý scorecard kombinuje oba typy — samotné zpožděné ukazatele upozorní na problém pozdě.

*Příklad:* Firemní cíl „zvýšit podíl online prodeje na 40 %" se promítne do cílů IT „dostupnost e-shopu 99,9 %" a „nasazení doporučovacího modulu do června".

### ? Který z ukazatelů je předstihový (lead) vzhledem k cíli „zvýšit tržby z e-shopu"?

- [ ] Celkové roční tržby e-shopu za uplynulý rok
- [ ] Zisk z online prodeje
- [x] Průměrná doba načtení stránky e-shopu
- [ ] Meziroční růst tržeb e-shopu

> Rychlost e-shopu ovlivňuje nákupní chování dřív, než se projeví v tržbách, je to tedy hybná síla výsledku. Tržby, zisk a jejich růst jsou zpožděné ukazatele samotného výsledku.

### ? Co je hlavním účelem kaskádování cílů z firemního BSC do IT BSC?

- [ ] Snížit celkový počet ukazatelů, které IT sleduje
- [x] Navázat každý cíl IT na konkrétní firemní cíl
- [ ] Přenést odpovědnost za informatiku na finanční útvar
- [ ] Nahradit informační strategii souborem ukazatelů

> Kaskádování zajišťuje dohledatelnost: ke každému cíli IT je jasné, kterému firemnímu cíli slouží, a tím podporuje business–IT alignment.

## SWOT analýza pro informatiku {#swot-informatiky .explain}

SWOT analýza informatiky hodnotí **vnitřní** silné (S) a slabé (W) stránky IS/ICT a **vnější** příležitosti (O) a hrozby (T). Vnitřní faktory: kvalita a stáří aplikací, architektura a integrace, kompetence pracovníků IT, procesy řízení IT, náklady, spolupráce s byznysem. Vnější faktory: technologické trendy, nabídka dodavatelů a cloudových služeb, trh práce IT specialistů, kybernetické hrozby, legislativa, informatika konkurentů a obchodních partnerů. SWOT se má posuzovat **vzhledem k cílům firemní strategie** — tatáž vlastnost (např. vlastní vývojový tým) může být silnou stránkou pro jednu strategii a slabinou pro jinou.

*Příklad:* Silná stránka: integrovaný ERP systém; slabá stránka: zastaralý e-shop bez rozhraní API; příležitost: rozvoj B2B online tržišť; hrozba: vyděračské útoky (ransomware) na výrobní firmy.

### ? Firma zjistí, že na trhu práce chybí specialisté na kybernetickou bezpečnost a jejich mzdy rychle rostou. Kam to ve SWOT analýze informatiky patří?

- [ ] Mezi slabé stránky
- [x] Mezi hrozby
- [ ] Mezi silné stránky
- [ ] Mezi příležitosti

> Situace na trhu práce je vnější faktor, který firma neovlivní a který ji může ohrozit — patří proto mezi hrozby. Slabé stránky jsou vnitřní vlastnosti samotné informatiky firmy.

### ? Který faktor patří ve SWOT analýze informatiky mezi SLABÉ stránky?

- [ ] Rostoucí nabídka cloudových služeb na trhu
- [ ] Nová legislativa o elektronické fakturaci
- [ ] Útoky na dodavatelský řetězec softwaru
- [x] Zastaralé aplikace bez možnosti integrace

> Zastaralé aplikace jsou vnitřní nedostatek informatiky firmy. Nabídka cloudu je vnější příležitost, legislativa a útoky jsou vnější faktory (příležitost či hrozba).

## Strategie z matice SWOT (TOWS) {#swot-strategie .compare}

Spojením vnitřních a vnějších faktorů vznikají čtyři typy strategií (matice TOWS).

| | Příležitosti (O) | Hrozby (T) |
|---|---|---|
| **Silné stránky (S)** | **SO** — využít silné stránky k využití příležitostí | **ST** — využít silné stránky k odvrácení hrozeb |
| **Slabé stránky (W)** | **WO** — překonat slabiny využitím příležitostí | **WT** — omezit slabiny a vyhnout se hrozbám (obranná) |

### ? Útvar IT má zkušený tým datových analytiků a na trhu roste poptávka po personalizovaných nabídkách. Firma proto spustí projekt doporučovacího systému. O jaký typ strategie podle matice SWOT jde?

- [x] SO
- [ ] WO
- [ ] ST
- [ ] WT

> Firma využívá svou silnou stránku (analytický tým) k využití vnější příležitosti (poptávka po personalizaci), jde tedy o strategii SO.

### ? Firma má zastaralou vlastní serverovou infrastrukturu a rozhodne se ji nahradit využitím dostupných cloudových služeb. O jaký typ strategie podle matice SWOT jde?

- [ ] SO
- [ ] ST
- [x] WO
- [ ] WT

> Slabou stránku (zastaralá infrastruktura) firma překonává využitím vnější příležitosti (nabídka cloudu) — to je strategie WO.

## CMM a CMMI {#cmm-cmmi .term}

**CMM** (Capability Maturity Model) je model zralosti procesů vývoje softwaru vytvořený v Software Engineering Institute (SEI) při Carnegie Mellon University. Jeho nástupce **CMMI** (Capability Maturity Model Integration) sjednocuje modely pro vývoj, nákup a poskytování služeb. Oba hodnotí, jak jsou procesy organizace definované, opakovatelné a měřené, a popisují **pět úrovní zralosti** jako cestu postupného zlepšování.

### ? Co primárně hodnotí model CMM / CMMI?

- [ ] Finanční výkonnost IT projektů
- [ ] Soulad IT s legislativou o ochraně osobních údajů
- [x] Zralost procesů organizace
- [ ] Technickou kvalitu hardwarové infrastruktury

> CMM a CMMI jsou modely zralosti procesů (původně vývoje softwaru) — hodnotí, jak jsou procesy organizace definované, řízené a měřené, nikoli finance, legislativu nebo hardware.

## Úrovně zralosti CMMI {#cmmi-urovne .compare}

CMMI rozlišuje pět úrovní zralosti; každá vyšší staví na praktikách předchozí.

| Úroveň | Název (CMMI) | Charakteristika |
|---|---|---|
| 1 | Počáteční (Initial) | procesy ad hoc a nepředvídatelné, úspěch závisí na jednotlivcích |
| 2 | Řízená (Managed) | projekty se plánují a řídí (požadavky, rozsah, náklady), úspěchy lze opakovat |
| 3 | Definovaná (Defined) | standardní procesy pro celou organizaci, projekty je přizpůsobují |
| 4 | Kvantitativně řízená (Quantitatively Managed) | výkonnost procesů se měří a řídí kvantitativními (statistickými) metodami |
| 5 | Optimalizující (Optimizing) | soustavné zlepšování procesů na základě kvantitativní zpětné vazby a inovací |

V původním CMM se úroveň 2 nazývala opakovatelná (Repeatable) a úroveň 4 řízená (Managed).

### ? Firma má pro celou organizaci zdokumentované standardní procesy vývoje, které jednotlivé projekty přizpůsobují svým potřebám, ale výkonnost procesů zatím kvantitativně neměří. Na které úrovni zralosti CMMI se nachází?

- [ ] 2 — Řízená
- [x] 3 — Definovaná
- [ ] 4 — Kvantitativně řízená
- [ ] 5 — Optimalizující

> Organizační standardní procesy přizpůsobované projekty jsou znakem úrovně 3. Kvantitativní řízení výkonnosti procesů by odpovídalo až úrovni 4.

### ? Jak se nazývá nejvyšší, pátá úroveň zralosti podle CMMI?

- [ ] Kvantitativně řízená
- [ ] Definovaná
- [ ] Řízená
- [x] Optimalizující

> Úroveň 5 je optimalizující — organizace soustavně zlepšuje procesy na základě kvantitativní zpětné vazby. Kvantitativně řízená je úroveň 4.

### ? Vývoj softwaru ve firmě funguje díky několika zkušeným jednotlivcům, procesy nejsou popsané a výsledky projektů se nedají předvídat. Na které úrovni zralosti CMMI firma je?

- [x] 1 — Počáteční
- [ ] 2 — Řízená
- [ ] 3 — Definovaná
- [ ] 4 — Kvantitativně řízená

> Ad hoc procesy a závislost úspěchu na jednotlivcích jsou typické pro úroveň 1. Na úrovni 2 se již projekty plánují a řídí.

## Model zralosti v informační strategii {#zralost-v-ict-strategii .explain}

V informační strategii se model zralosti používá k **posouzení současného stavu** procesů řízení informatiky (vývoj, provoz, řízení projektů, bezpečnost) a ke **stanovení cílové úrovně**, kterou firma potřebuje pro naplnění své strategie. Rozdíl mezi oběma stavy určuje rozvojová opatření. Úrovně se nepřeskakují — každá staví na praktikách předchozí. Cílová úroveň **nemusí být nejvyšší**: vyšší zralost stojí čas i peníze a musí odpovídat významu informatiky pro firmu. Princip úrovní převzaly i další rámce (např. COBIT pracuje s úrovněmi schopnosti procesů).

*Příklad:* Hodnocení ukáže, že řízení IT projektů je na úrovni 1. Firma si stanoví cíl dosáhnout do dvou let úrovně 3 zavedením jednotné projektové metodiky a projektové kanceláře.

### ? Firma je podle hodnocení na úrovni zralosti 1 a chce rychle dosáhnout úrovně 4 tím, že zavede statistické měření procesů, které zatím nejsou ani popsané. Proč je to problematické?

- [ ] Úrovně 4 lze dosáhnout jen s externím certifikátem
- [ ] Statistické měření procesů patří až do úrovně 5
- [x] Úrovně na sebe navazují a nelze je přeskakovat
- [ ] Model zralosti se na řízení IT nedá použít

> Kvantitativní řízení předpokládá, že procesy jsou nejprve řízené (úroveň 2) a definované (úroveň 3). Měřit nepopsané ad hoc procesy nemá smysl.

### ? Proč cílová úroveň zralosti v informační strategii NEMUSÍ být vždy nejvyšší (5)?

- [x] Vyšší zralost je nákladná a má odpovídat potřebám firmy
- [ ] Úroveň 5 je v CMMI vyhrazena pouze pro státní správu
- [ ] Úroveň 5 se v současných verzích CMMI už nepoužívá
- [ ] Na nejvyšší úrovni se procesy už nesmějí nijak měnit

> Dosažení a udržení vysoké zralosti vyžaduje značné úsilí a náklady. Cílová úroveň se proto volí podle toho, jak důležitá je daná oblast pro firemní strategii.

## Analýza potenciálních zlepšení {#analyza-zlepseni .explain}

Analýza potenciálních zlepšení hledá místa, kde může informatika nejvíce zvýšit výkonnost firmy nebo kvalitu řízení. Typický postup: (1) popis **současného stavu** procesů a jejich podpory IS (např. z hodnocení zralosti, SWOT nebo auditu); (2) definice **cílového stavu** odvozeného z firemní strategie; (3) **analýza rozdílů (gap analysis)** a identifikace příležitostí — úzká místa procesů, ruční a duplicitní práce, chybějící informace pro rozhodování, nekvalitní data; (4) **ocenění a prioritizace** zlepšení podle přínosu, nákladů, rizika a souladu se strategií; (5) promítnutí do rozvojových cílů a projektů.

*Příklad:* Analýza odhalí, že obchodníci tráví jeden den v týdnu ručním sestavováním reportů z několika systémů. Navrženým zlepšením je automatizovaný reporting z jednoho zdroje dat.

### ? Co je jádrem analýzy rozdílů (gap analysis) při hledání potenciálních zlepšení informatiky?

- [ ] Porovnání cen nabídek několika dodavatelů
- [x] Srovnání současného a cílového stavu
- [ ] Výpočet odpisů stávajícího hardwaru
- [ ] Sestavení organizačního schématu útvaru IT

> Gap analysis porovnává, kde firma je a kde potřebuje být podle své strategie. Z rozdílu vyplývají potenciální zlepšení a rozvojová opatření.

### ? Který z nálezů analýzy nejvíce signalizuje potenciál zlepšení podporou informačního systému?

- [x] Stejná data zákazníka se ručně zadávají do tří systémů
- [ ] Firma má v posledních letech stabilní a věrný okruh zákazníků
- [ ] Útvar IT sídlí v jiné budově než obchodní oddělení
- [ ] Ceny licencí jsou smluvně stanoveny na tři roky

> Opakované ruční zadávání stejných dat je duplicitní práce a zdroj chyb, kterou lze odstranit integrací systémů. Ostatní zjištění žádný problém v procesech nesignalizují.

## Exaktní specifikace požadovaných efektů {#specifikace-efektu .explain}

Požadované efekty z rozvoje informatiky je třeba specifikovat **exaktně** — měřitelně a kontrolovatelně, jinak nelze posoudit, zda investice splnila účel. Dobře formulovaný cíl splňuje kritéria **SMART** (specifický, měřitelný, dosažitelný, relevantní, časově vymezený) a obsahuje: **ukazatel (KPI)** navázaný na obchodní cíl, **výchozí hodnotu**, **cílovou hodnotu**, **termín** a **vlastníka z byznysu** odpovědného za dosažení přínosu. Efekt se vyjadřuje v řeči byznysu (doba procesu, chybovost, tržby, náklady), ne jen technicky („nasadit systém"). Po realizaci se skutečný stav porovná s plánem. Ekonomické ukazatele jako ROI nebo TCO se počítají v ekonomických analýzách informatiky.

*Příklad:* Místo „zlepšit CRM" zní cíl: „zkrátit průměrnou dobu vyřízení reklamace z 10 na 5 pracovních dnů do 30. 6. 2027; vlastník: vedoucí zákaznického servisu".

### ? Který z cílů rozvoje informatiky je formulován nejvíce exaktně (měřitelně)?

- [ ] Modernizovat informační systém skladu podle nejnovějších trendů
- [ ] Výrazně zlepšit práci obchodníků s novým systémem CRM
- [ ] Zavést nový reportingový nástroj co nejdříve v příštím roce
- [x] Zkrátit inventuru skladu ze 3 dnů na 1 den do 12/2027

> Jen poslední cíl má měřitelný ukazatel, výchozí i cílovou hodnotu a termín. Ostatní formulace („modernizovat", „výrazně zlepšit", „co nejdříve") nelze objektivně vyhodnotit.

### ? Proč má být u požadovaného efektu IT projektu uveden vlastník z byznysu?

- [ ] Aby mohl schvalovat technickou architekturu řešení
- [x] Protože odpovídá za skutečné dosažení přínosu v procesu
- [ ] Protože hradí licence výhradně ze svého rozpočtu
- [ ] Aby nahradil projektového manažera projektu

> Informatika dodá nástroj, ale přínos (kratší proces, méně chyb) vzniká až jeho využitím v byznysu. Proto za dosažení efektu odpovídá vlastník procesu.

### ? Firma má cíl rozvoje informatiky „snížit chybovost fakturace". Co k jeho exaktní specifikaci ještě CHYBÍ?

- [ ] Název dodavatele softwaru a typ licence
- [ ] Seznam serverů, na kterých systém poběží
- [x] Výchozí a cílová hodnota ukazatele a termín
- [ ] Popis organizační struktury útvaru IT

> Měřitelný cíl potřebuje výchozí stav, cílovou hodnotu (např. z 4 % na 1 % chybných faktur) a termín. Dodavatel, servery či organizace IT jsou podrobnosti realizace, ne specifikace efektu.
