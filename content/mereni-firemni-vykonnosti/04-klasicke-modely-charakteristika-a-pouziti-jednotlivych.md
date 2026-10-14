---
kind: topic
subject: mereni-firemni-vykonnosti
slug: klasicke-modely-charakteristika-a-pouziti-jednotlivych
name: "Klasické modely, charakteristika a použití jednotlivých nástrojů v klasických modelech"
order: 4
---

Indikátory návratnosti, aktivity, likvidity, zadluženosti a kapitálového trhu, jejich vypovídací hodnota v DuPontově rovnici, trendové analýze, v ROI pyramidovém rozkladu, využití jednotlivých nástrojů v soustavě nerovnosti, soustavě rovnic ekonomického normálu.

## Klasické modely měření výkonnosti {#klasicke-modely .explain}

Klasické (tradiční) modely měří výkonnost podniku z **účetních dat** — rozvahy a výkazu zisku a ztráty. Základním nástrojem jsou **poměrové ukazatele** sdružené do skupin:

- **rentabilita (návratnost)** — ROA, ROE, ROS, ROCE, ROI,
- **aktivita** — obraty a doby obratu majetku a závazků,
- **likvidita** — schopnost hradit krátkodobé závazky,
- **zadluženost** — struktura financování a schopnost obsluhovat dluh,
- **ukazatele kapitálového trhu** — EPS, P/E, dividendový výnos, P/BV, výplatní poměr (kombinují účetní údaje s tržní cenou akcie).

Ukazatele se propojují do **pyramidových rozkladů** (Du Pontova rovnice, ROI pyramida), sledují se v čase (**trendová analýza**) a porovnávají se se žádoucím vývojem (**soustava nerovností**, **ekonomický normál**). Měřítkem výkonnosti je v nich především **účetní zisk** poměřený s majetkem, kapitálem nebo tržbami. Hodnota ukazatele se vždy hodnotí srovnáním — v čase, s oborem či konkurencí a s doporučenou nebo plánovanou hodnotou.

*Příklad:* ROE podniku je 14 %. Teprve srovnání dá výsledku smysl: před třemi lety 18 % (zhoršení), oborový průměr 10 % (nadprůměr), plán 15 % (mírně pod plánem).

### ? Která skupina ukazatelů kombinuje údaje z účetní závěrky s tržní cenou akcie?

- [ ] Ukazatele aktivity
- [ ] Ukazatele likvidity
- [x] Ukazatele kapitálového trhu
- [ ] Ukazatele zadluženosti

> Ukazatele kapitálového trhu (P/E, P/BV, dividendový výnos) dávají do poměru tržní cenu akcie s účetními údaji na akcii. Aktivita, likvidita a zadluženost vycházejí jen z výkazů.

### ? Co je společným znakem klasických modelů měření výkonnosti?

- [x] Poměřují účetní zisk s majetkem, kapitálem nebo tržbami
- [ ] Měří výkonnost diskontovanými peněžními toky po odečtení nákladů kapitálu
- [ ] Opírají se hlavně o nefinanční ukazatele spokojenosti zákazníků
- [ ] Zahrnují do výsledku riziko a náklady vlastního kapitálu

> Klasické modely vycházejí z účetních výkazů a jejich vrcholovými ukazateli jsou rentability. Odečet nákladů kapitálu a práci s peněžními toky přinášejí až hodnotové ukazatele (EVA, CFROI — téma 6).

## Ukazatele rentability (návratnosti) {#rentabilita .compare}

Ukazatele rentability poměřují zisk s tím, co bylo k jeho dosažení vloženo, nebo s tržbami. Druh zisku v čitateli musí odpovídat jmenovateli:

| Ukazatel | Vzorec | Co měří |
|---|---|---|
| **ROA** (Return on Assets) | `EBIT / A` (varianty `EAT / A`, `(EAT + nákladové úroky · (1 − t)) / A`) | výnosnost veškerého majetku bez ohledu na způsob financování |
| **ROE** (Return on Equity) | `EAT / VK` | zhodnocení kapitálu vlastníků |
| **ROS** (Return on Sales) | `EAT / T` (varianta `EBIT / T`) | ziskovost tržeb — kolik zisku přinese 1 Kč tržeb |
| **ROCE** (Return on Capital Employed) | `EBIT / (VK + dlouhodobé cizí zdroje)` | výnosnost dlouhodobého kapitálu vlastníků i věřitelů |
| **ROI** (Return on Investment) | `zisk / investovaný kapitál`; ve finanční analýze často `EBIT / celkový kapitál` | výnosnost vloženého kapitálu; vrchol ROI pyramidy, užívá se i pro divize a projekty |

EAT náleží vlastníkům, proto se poměřuje s VK; EBIT náleží všem poskytovatelům kapitálu (úroky věřitelům i zisk vlastníkům), proto se poměřuje s celkovým nebo dlouhodobým kapitálem. Při srovnávání podniků je nutné použít stejnou variantu výpočtu.

### ? EBIT činí 3 000 tis. Kč, EAT 2 100 tis. Kč, VK 10 000, dlouhodobé cizí zdroje 5 000 a krátkodobé závazky 5 000 tis. Kč. Jaká je ROCE?

- [ ] 15 %
- [x] 20 %
- [ ] 14 %
- [ ] 21 %

> ROCE = EBIT / (VK + dlouhodobé cizí zdroje) = 3 000 / 15 000 = 20 %. Hodnota 15 % je EBIT / celková aktiva (20 000), 14 % vznikne dosazením EAT místo EBIT a 21 % je ROE (2 100 / 10 000).

### ? Proč se v ROCE používá v čitateli EBIT, a ne EAT?

- [ ] Protože EBIT na rozdíl od EAT nezahrnuje odpisy majetku
- [ ] Protože EAT nelze z výkazu zisku a ztráty vůbec zjistit
- [ ] Protože EBIT je vždy nižší než čistý zisk podniku
- [x] Protože z EBIT se hradí výnos vlastníkům i dlouhodobým věřitelům

> Jmenovatel ROCE zahrnuje kapitál vlastníků i dlouhodobých věřitelů, a čitatel proto musí obsahovat výnos obou skupin — zisk před úroky a zdaněním. EBIT je naopak zisk po odpisech a je vyšší než EAT.

## Rentabilita a zadluženost — působení finanční páky {#financni-paka .explain}

Vztah mezi ROE a ROA (ve variantě EBIT / A) ukazuje, jak zadluženost ovlivňuje výnos vlastníků. Pro A = VK + CK a průměrnou úrokovou míru cizího kapitálu i = nákladové úroky / CK platí:

`ROE = [ROA + (ROA − i) · CK / VK] · (1 − t)`

- Je-li **ROA > i**, vydělá každá koruna cizího kapitálu víc, než stojí, a vyšší zadlužení **zvyšuje ROE** (pozitivní působení finanční páky).
- Je-li **ROA < i**, zadlužení ROE **snižuje** — páka působí negativně.
- Člen (ROA − i) · CK / VK je příspěvek finanční páky; s rostoucím poměrem CK / VK zesiluje i výkyvy ROE, a tedy riziko vlastníků.

*Příklad:* A 10 000, VK 4 000, CK 6 000, EBIT 1 200 tis. Kč (ROA 12 %), úroky 360 (i = 6 %), t = 21 % → ROE = [12 % + 6 % · 1,5] · 0,79 = 16,59 %. Kontrola: EBT = 840, EAT = 663,6, ROE = 663,6 / 4 000 = 16,59 %.

### ? ROA (EBIT / A) podniku je 10 %, průměrná úroková míra cizího kapitálu 6 % a poměr CK / VK = 2. Jaká je ROE, pokud abstrahujete od daní?

- [ ] 14 %
- [ ] 22 %
- [x] 18 %
- [ ] 8 %

> ROE = ROA + (ROA − i) · CK / VK = 10 % + 4 % · 2 = 18 %. Hodnota 14 % vznikne opomenutím poměru CK / VK, 22 % dosazením úrokové míry místo rozdílu ROA − i a 8 % je jen příspěvek páky.

### ? Za jaké podmínky vyšší zadlužení SNIŽUJE rentabilitu vlastního kapitálu?

- [x] ROA (EBIT / A) je nižší než úroková míra cizího kapitálu
- [ ] Úroková míra cizího kapitálu je nižší než ROA (EBIT / A)
- [ ] Sazba daně z příjmů je vyšší než nula
- [ ] Podíl cizího kapitálu na pasivech je nižší než polovina

> Když majetek vydělává méně, než stojí cizí kapitál (ROA < i), je rozdíl ROA − i záporný a každá další koruna dluhu ROE snižuje. Daň výsledek jen proporcionálně krátí, směr působení páky nemění.

## Ukazatele aktivity a obratový cyklus peněz {#aktivita .explain}

Ukazatele aktivity měří, jak efektivně podnik **využívá majetek** a jak dlouho jsou v něm vázány prostředky (rok = 360 dní, T / 360 = průměrné denní tržby):

- **obrat aktiv** = T / A — kolikrát za rok se aktiva obrátí v tržbách,
- **doba obratu zásob** = zásoby / (T / 360), **doba obratu pohledávek** = pohledávky / (T / 360),
- **doba obratu závazků** = krátkodobé závazky z obchodních vztahů / (T / 360).

Spojením dob obratu vzniká **obratový cyklus peněz** (cash conversion cycle) = doba obratu zásob + doba obratu pohledávek − doba obratu závazků. Vyjadřuje, kolik dní musí podnik financovat provoz z vlastních nebo úvěrových zdrojů, než se mu peníze vrátí. Zkrácení dob obratu uvolňuje vázaný kapitál, zvyšuje obrat aktiv, a tím i rentabilitu.

*Příklad:* Doba obratu zásob 45 dní, pohledávek 50 dní, závazků 40 dní → obratový cyklus peněz = 45 + 50 − 40 = 55 dní.

### ? Roční tržby činí 72 000 tis. Kč, zásoby 4 000, pohledávky 6 000 a závazky z obchodních vztahů 3 000 tis. Kč (rok = 360 dní). Jak dlouhý je obratový cyklus peněz?

- [ ] 65 dní
- [ ] 50 dní
- [ ] 5 dní
- [x] 35 dní

> Denní tržby = 72 000 / 360 = 200; doba obratu zásob 20, pohledávek 30 a závazků 15 dní. Cyklus = 20 + 30 − 15 = 35 dní. Hodnota 65 vznikne sečtením všech tří dob, 50 neodečtením závazků a 5 záměnou pohledávek a závazků.

### ? Při ročních tržbách 36 000 tis. Kč (rok = 360 dní) zkrátil podnik dobu obratu pohledávek z 60 na 45 dní. Kolik peněz se uvolnilo z pohledávek?

- [x] 1 500 tis. Kč
- [ ] 4 500 tis. Kč
- [ ] 6 000 tis. Kč
- [ ] 5 400 tis. Kč

> Denní tržby = 36 000 / 360 = 100 tis. Kč; zkrácení o 15 dní uvolní 15 · 100 = 1 500 tis. Kč. Hodnoty 4 500 a 6 000 jsou celé stavy pohledávek po a před změnou, 5 400 vznikne chybným násobením 15 · 360.

## Ukazatele likvidity {#likvidita .compare}

Likvidita poměřuje to, čím podnik může platit, s tím, co musí brzy zaplatit (krátkodobé závazky včetně krátkodobých bankovních úvěrů):

| Ukazatel | Vzorec | Orientační doporučení |
|---|---|---|
| **Běžná likvidita** (3. stupně) | oběžná aktiva / krátkodobé závazky | 1,5–2,5 |
| **Pohotová likvidita** (2. stupně) | (oběžná aktiva − zásoby) / krátkodobé závazky | 1–1,5 |
| **Okamžitá likvidita** (1. stupně) | (peněžní prostředky + krátkodobý finanční majetek) / krátkodobé závazky | 0,2–0,5 |

Doporučené hodnoty jsou orientační a liší se podle oboru i autora. Z pohledu výkonnosti platí **konflikt likvidity a rentability**: příliš nízká likvidita ohrožuje platební schopnost, příliš vysoká znamená prostředky vázané v málo výnosných aktivech, což snižuje obrat aktiv i rentabilitu. Velký rozdíl mezi běžnou a pohotovou likviditou ukazuje vysoký podíl zásob.

### ? Oběžná aktiva činí 9 000 tis. Kč (zásoby 4 200, pohledávky 3 600, peníze 1 200), krátkodobé závazky 6 000 tis. Kč. Které hodnoty likvidity jsou správné?

- [ ] Běžná 1,5; pohotová 0,7; okamžitá 0,2
- [ ] Běžná 0,67; pohotová 1,25; okamžitá 5,0
- [x] Běžná 1,5; pohotová 0,8; okamžitá 0,2
- [ ] Běžná 1,5; pohotová 0,8; okamžitá 0,6

> Běžná = 9 000 / 6 000 = 1,5; pohotová = (9 000 − 4 200) / 6 000 = 0,8; okamžitá = 1 200 / 6 000 = 0,2. Hodnota 0,7 vznikne dosazením samotných zásob, 0,6 dosazením pohledávek místo peněz a druhá řada jsou převrácené poměry.

### ? Pohotová likvidita podniku dlouhodobě dosahuje 3,5 při orientačním doporučení 1–1,5. Jak výsledek hodnotíte z pohledu výkonnosti?

- [ ] Ideální stav, protože vyšší likvidita zvyšuje i rentabilitu
- [x] Nadbytek málo výnosných likvidních aktiv snižuje rentabilitu
- [ ] Podniku hrozí platební neschopnost kvůli vysokým zásobám
- [ ] Hodnota ukazuje vysoké zadlužení krátkodobými úvěry

> Příliš vysoká likvidita znamená, že v pohledávkách a penězích leží víc prostředků, než provoz potřebuje. Zvětšují aktiva, aniž by přinášely odpovídající výnos, a snižují obrat aktiv i ROA.

## Ukazatele zadluženosti {#zadluzenost .explain}

Ukazatele zadluženosti (finanční stability) hodnotí strukturu financování a schopnost obsluhovat dluh:

- **celková zadluženost** = cizí zdroje / A; **koeficient samofinancování** = VK / A (doplněk do 100 %, rozdíl tvoří ostatní pasiva),
- **míra zadluženosti vlastního kapitálu** (debt/equity) = cizí zdroje / VK; **finanční páka** (multiplikátor VK) = A / VK,
- **úrokové krytí** = EBIT / nákladové úroky (jako uspokojivá se v literatuře často uvádí hodnota alespoň 3),
- **doba splácení dluhu** = cizí zdroje (případně snížené o peněžní prostředky) / provozní cash flow.

S nimi souvisí **zlaté bilanční pravidlo** (pravidlo financování): dlouhodobý majetek má být kryt dlouhodobými zdroji (VK + dlouhodobé cizí zdroje). Zadluženost není sama o sobě negativní — cizí kapitál bývá levnější a může zvyšovat ROE (finanční páka), roste však riziko a fixní zátěž úroky a splátkami.

*Příklad:* A 10 000, VK 4 000, cizí zdroje 6 000 tis. Kč → celková zadluženost 60 %, koeficient samofinancování 40 %, debt/equity 1,5, multiplikátor VK 2,5.

### ? Aktiva činí 50 000 tis. Kč, VK 20 000, cizí zdroje 30 000, EBIT 6 000 a nákladové úroky 1 500 tis. Kč. Jaké je úrokové krytí a míra zadluženosti VK (cizí zdroje / VK)?

- [ ] Úrokové krytí 3; míra zadluženosti VK 1,5
- [ ] Úrokové krytí 4; míra zadluženosti VK 0,6
- [ ] Úrokové krytí 0,25; míra zadluženosti VK 0,67
- [x] Úrokové krytí 4; míra zadluženosti VK 1,5

> Úrokové krytí = 6 000 / 1 500 = 4; cizí zdroje / VK = 30 000 / 20 000 = 1,5. Krytí 3 vznikne dosazením EBT (4 500) místo EBIT, 0,6 je celková zadluženost (30 000 / 50 000) a 0,25 a 0,67 jsou převrácené poměry.

### ? Co vyjadřuje zlaté bilanční pravidlo financování?

- [ ] Tempo růstu zisku má převyšovat tempo růstu tržeb
- [x] Dlouhodobý majetek má být kryt dlouhodobými zdroji
- [ ] Cizí zdroje nemají přesáhnout polovinu vlastního kapitálu
- [ ] Úrokové krytí má dosahovat alespoň hodnoty 1

> Pravidlo financování požaduje sladit dobu vázanosti majetku a dobu splatnosti zdrojů — dlouhodobý majetek kryjí dlouhodobé zdroje. Relace temp růstu zisku a tržeb patří do zlatého pravidla hospodaření (soustava nerovností).

## Ukazatele kapitálového trhu — přehled {#kapitalovy-trh .compare}

Ukazatele kapitálového trhu (tržní hodnoty) hodnotí podnik očima **investora** a spojují účetní údaje s **tržní cenou akcie** (P). Lze je plně počítat jen u akciových společností, jejichž akcie se obchodují na veřejném trhu:

| Ukazatel | Vzorec | Interpretace |
|---|---|---|
| **EPS** — zisk na akcii | (EAT − prioritní dividendy) / počet kmenových akcií | kolik čistého zisku připadá na 1 akcii |
| **P/E** — poměr ceny a zisku | P / EPS | kolik Kč investoři platí za 1 Kč ročního zisku |
| **DPS** — dividenda na akcii | vyplacené dividendy / počet akcií | kolik dostal akcionář na 1 akcii |
| **Dividendový výnos** | DPS / P | výnosnost akcie z dividend při dané tržní ceně |
| **Výplatní poměr** (payout ratio) | DPS / EPS (= dividendy / EAT) | jaká část zisku se vyplácí; zbytek = míra zadržení |
| **P/BV** — cena k účetní hodnotě | P / (VK / počet akcií) | kolikrát trh oceňuje VK výš než účetnictví |

### ? Který ukazatel kapitálového trhu se počítá BEZ tržní ceny akcie?

- [ ] Dividendový výnos
- [x] Výplatní poměr
- [ ] Poměr P/E
- [ ] Poměr P/BV

> Výplatní poměr = DPS / EPS vychází jen z dividend a čistého zisku. Dividendový výnos, P/E i P/BV mají tržní cenu akcie v čitateli nebo jmenovateli.

### ? Proč se ukazatele kapitálového trhu obtížně uplatní u většiny malých a středních podniků?

- [ ] Malé podniky nesestavují výkaz zisku a ztráty
- [ ] Malé podniky nesmějí vyplácet podíly na zisku
- [x] Jejich podíly se neobchodují na trhu a chybí tržní cena
- [ ] Ukazatele lze počítat jen v cizí měně

> P/E, P/BV i dividendový výnos potřebují tržní cenu akcie, kterou vytváří jen veřejný kapitálový trh. Malé a střední podniky jsou většinou společnosti s ručením omezeným nebo neobchodované akciové společnosti.

## Zisk na akcii (EPS) {#eps .explain}

**Zisk na akcii** (Earnings per Share, EPS) udává, kolik čistého zisku připadá na jednu kmenovou akcii:

`EPS = (EAT − prioritní dividendy) / počet kmenových akcií`

Prioritní dividendy se odečítají, protože tato část zisku kmenovým akcionářům nepatří; při změně počtu akcií během roku se používá vážený průměrný počet akcií v oběhu. EPS je sledováno hlavně **v čase** — trvalý růst EPS je pro investory žádoucí. Mezi podniky se absolutní výše EPS přímo srovnávat nedá, protože závisí na počtu (a nominální hodnotě) vydaných akcií. EPS lze zvýšit i bez růstu zisku, např. zpětným odkupem akcií.

*Příklad:* EAT 12 mil. Kč, prioritní dividendy 2 mil. Kč, 1 mil. kmenových akcií → EPS = (12 − 2) / 1 = 10 Kč.

### ? EAT akciové společnosti činí 45 mil. Kč, prioritní dividendy 6 mil. Kč a v oběhu jsou 3 mil. kmenových akcií. Jaký je zisk na akcii (EPS)?

- [ ] 15 Kč
- [ ] 17 Kč
- [x] 13 Kč
- [ ] 2 Kč

> EPS = (45 − 6) / 3 = 13 Kč. Hodnota 15 Kč vznikne opomenutím prioritních dividend, 17 Kč jejich přičtením a 2 Kč připadají na akcii jen z prioritních dividend.

### ? Proč nelze podle absolutní výše EPS přímo srovnat výkonnost dvou různých akciových společností?

- [x] EPS závisí na počtu a nominální hodnotě vydaných akcií
- [ ] EPS se počítá ze zisku před zdaněním a úroky
- [ ] EPS zahrnuje tržní cenu akcie, která kolísá
- [ ] EPS mohou vykazovat jen banky a pojišťovny

> Stejný čistý zisk dá při 1 mil. akcií desetkrát vyšší EPS než při 10 mil. akcií. EPS se proto hodnotí hlavně ve vývoji v čase a pro srovnání podniků se převádí na P/E.

## Poměr ceny akcie a zisku (P/E) {#pe .explain}

**P/E** (Price/Earnings ratio) vyjadřuje, kolik korun jsou investoři ochotni zaplatit za **1 Kč ročního zisku** připadajícího na akcii:

`P/E = tržní cena akcie / EPS`

Při neměnném zisku lze P/E číst jako počet let, za které by zisk „splatil" cenu akcie. **Vysoké P/E** znamená, že trh očekává růst budoucích zisků (případně je akcie nadhodnocená nebo má podnik dočasně nízký zisk). **Nízké P/E** signalizuje nízká očekávání, vyšší riziko, nebo podhodnocení. P/E se srovnává hlavně v rámci odvětví a s historií podniku; převrácená hodnota E/P je **ziskový výnos** akcie. Při ztrátě (záporném EPS) ukazatel ztrácí smysl.

*Příklad:* Cena akcie 600 Kč, EPS 40 Kč → P/E = 15; investor platí 15 Kč za 1 Kč ročního zisku, ziskový výnos je 1 / 15 ≈ 6,7 %.

### ? Akcie se obchoduje za 840 Kč, EAT společnosti činí 70 mil. Kč a v oběhu jsou 2 mil. akcií (bez prioritních). Jaký je poměr P/E?

- [ ] 12
- [ ] 35
- [ ] 0,042
- [x] 24

> EPS = 70 / 2 = 35 Kč; P/E = 840 / 35 = 24. Hodnota 12 vznikne dělením ceny celým ziskem v milionech (840 / 70), 35 je samotné EPS a 0,042 je převrácený poměr EPS / P.

### ? Dvě společnosti ze stejného odvětví mají P/E 35 a 9. Co z toho nejspíše plyne?

- [ ] Společnost s P/E 35 má vyšší současný zisk na akcii
- [x] Trh očekává u společnosti s P/E 35 rychlejší růst zisku
- [ ] Společnost s P/E 9 vyplácí nižší dividendy
- [ ] Společnost s P/E 9 má nižší zadluženost

> Vysoké P/E znamená, že investoři platí za 1 Kč současného zisku hodně, protože očekávají jeho budoucí růst (nebo akcii přeceňují). O výši současného EPS, dividend či zadluženosti P/E samo nic neříká.

## Dividendový výnos a výplatní poměr {#dividendy .explain}

Dividendové ukazatele popisují, jak podnik dělí zisk mezi výplatu akcionářům a reinvestici:

- **dividenda na akcii** DPS = vyplacené dividendy / počet akcií,
- **dividendový výnos** (dividend yield) = DPS / tržní cena akcie — výnos investora z dividend při současné ceně,
- **výplatní poměr** (payout ratio) = DPS / EPS (= dividendy / EAT) — podíl zisku vyplacený akcionářům,
- **míra zadržení zisku** (retention ratio) = 1 − výplatní poměr — část zisku ponechaná na financování růstu (samofinancování).

Platí `dividendový výnos = výplatní poměr / (P/E)`. Vysoký výplatní poměr je typický pro zralé podniky s malými investičními příležitostmi, nízký pro rostoucí podniky, které zisk reinvestují.

*Příklad:* EPS 40 Kč, DPS 16 Kč, cena 800 Kč → výplatní poměr 40 %, míra zadržení 60 %, dividendový výnos 16 / 800 = 2 % (kontrola: P/E = 20, 40 % / 20 = 2 %).

### ? Dividenda na akcii činí 24 Kč, tržní cena akcie 600 Kč a EPS 60 Kč. Jaký je dividendový výnos a výplatní poměr?

- [ ] Dividendový výnos 10 %, výplatní poměr 40 %
- [ ] Dividendový výnos 4 %, výplatní poměr 250 %
- [ ] Dividendový výnos 40 %, výplatní poměr 4 %
- [x] Dividendový výnos 4 %, výplatní poměr 40 %

> Dividendový výnos = 24 / 600 = 4 %; výplatní poměr = 24 / 60 = 40 %. Hodnota 10 % je EPS / cena (ziskový výnos), 250 % je převrácený výplatní poměr a třetí možnost oba ukazatele zaměňuje.

### ? Čistý zisk akciové společnosti činí 50 mil. Kč a výplatní poměr 30 %. Kolik zisku společnost zadrží pro financování dalšího rozvoje?

- [ ] 15 mil. Kč
- [x] 35 mil. Kč
- [ ] 20 mil. Kč
- [ ] 50 mil. Kč

> Míra zadržení = 1 − 0,30 = 0,70; zadržený zisk = 0,70 · 50 = 35 mil. Kč. 15 mil. Kč je vyplacená část, 20 mil. Kč vznikne chybným odečtením „30" od 50.

### ? Výplatní poměr společnosti je 50 % a její akcie má P/E 20. Jaký je dividendový výnos akcie?

- [x] 2,5 %
- [ ] 5 %
- [ ] 10 %
- [ ] 50 %

> Dividendový výnos = výplatní poměr / (P/E) = 0,5 / 20 = 2,5 %. Hodnota 5 % je ziskový výnos E/P (1 / 20), 10 % vznikne násobením 0,5 · 20 a 50 % je samotný výplatní poměr.

## Poměr tržní a účetní hodnoty (P/BV) {#pbv .explain}

**Účetní hodnota akcie** (book value per share) = VK / počet akcií. **P/BV** (Price to Book Value, market-to-book) ji porovnává s tržní cenou:

`P/BV = tržní cena akcie / (VK / počet akcií)` (= tržní kapitalizace / VK)

- **P/BV > 1** — trh oceňuje podnik výš, než je účetní hodnota VK: očekává tvorbu hodnoty, oceňuje nehmotná aktiva nezachycená v rozvaze (značka, know-how, zákaznické vztahy).
- **P/BV < 1** — trh oceňuje podnik pod účetní hodnotou: pochybuje o schopnosti majetek zhodnotit, případně považuje aktiva za nadhodnocená (nebo jde o podhodnocení akcie).

Platí `P/BV = P/E · ROE` (s ROE = EAT / VK), takže vysoké P/BV je oprávněné jen při vysoké rentabilitě nebo vysokých očekáváních.

*Příklad:* VK 500 mil. Kč, 10 mil. akcií → účetní hodnota akcie 50 Kč; při ceně 75 Kč je P/BV = 1,5.

### ? Vlastní kapitál společnosti činí 1 200 mil. Kč, v oběhu je 8 mil. akcií a akcie se obchoduje za 210 Kč. Jaký je poměr P/BV?

- [ ] 0,71
- [ ] 0,175
- [x] 1,4
- [ ] 26,25

> Účetní hodnota akcie = 1 200 / 8 = 150 Kč; P/BV = 210 / 150 = 1,4. Hodnota 0,71 je převrácený poměr, 0,175 vznikne dělením ceny celým VK v milionech a 26,25 dělením ceny počtem akcií.

### ? Akcie má P/E 12 a ROE společnosti (EAT / VK) je 15 %. Jaký je poměr P/BV?

- [ ] 0,8
- [ ] 80
- [ ] 1,25
- [x] 1,8

> P/BV = P/E · ROE = 12 · 0,15 = 1,8. Hodnota 0,8 vznikne dělením 12 / 15, 80 dělením 12 / 0,15 a 1,25 převrácením 15 / 12.

### ? P/BV akcie dlouhodobě dosahuje 0,6. Jak to nejlépe interpretovat?

- [x] Trh oceňuje podnik pod účetní hodnotou VK a pochybuje o zhodnocení jeho majetku
- [ ] Trh oceňuje nehmotná aktiva podniku, která nejsou zachycena v rozvaze
- [ ] Podnik vyplácí 60 % zisku akcionářům ve formě dividend
- [ ] Investoři platí za 1 Kč zisku na akcii 0,6 Kč

> P/BV < 1 znamená tržní hodnotu nižší než účetní hodnota VK — trh čeká, že podnik majetek nezhodnotí, nebo že jsou aktiva v rozvaze nadhodnocena. Ocenění nehmotných aktiv naopak zvyšuje P/BV nad 1.

## Du Pontova rovnice {#du-pont-rovnice .explain}

**Du Pontova rovnice** rozkládá rentabilitu vlastního kapitálu na tři faktory:

`ROE = EAT / VK = (EAT / T) · (T / A) · (A / VK) = ROS · obrat aktiv · finanční páka`

Její vypovídací hodnota je v tom, že ukazuje **tři páky výkonnosti** a jejich zdroj:

- **ROS** — provozní ziskovost: řízení nákladů a cenová politika,
- **obrat aktiv** — efektivnost využití majetku (ukazatele aktivity),
- **finanční páka** (A / VK = 1 / koeficient samofinancování) — finanční struktura, a tedy i riziko.

Součin prvních dvou faktorů je ROA ve variantě EAT / A. Stejnou ROE lze dosáhnout strategií vysoké marže (kapitálově náročná výroba) i strategií vysokého obratu (obchod). Rovnice slouží k hledání příčin rozdílu oproti konkurenci a k plánování: chceme-li zvýšit ROE, víme, kterou „páku" a o kolik je třeba posunout.

*Příklad:* T 90 000, EAT 3 600, A 60 000, VK 24 000 tis. Kč → ROS 4 %, obrat aktiv 1,5, finanční páka 2,5 → ROE = 0,04 · 1,5 · 2,5 = 15 % (kontrola: 3 600 / 24 000 = 15 %).

### ? Podnik má ROS 5 % a finanční páku (A / VK) 2. Jakého obratu aktiv musí dosáhnout, aby jeho ROE činila 15 %?

- [ ] 3
- [ ] 0,67
- [x] 1,5
- [ ] 0,3

> Obrat aktiv = ROE / (ROS · páka) = 0,15 / (0,05 · 2) = 1,5. Hodnota 3 vznikne opomenutím páky, 0,67 je převrácená správná hodnota a 0,3 vznikne násobením 0,15 · 2.

### ? Který faktor Du Pontovy rovnice zvyšuje ROE za cenu vyššího finančního rizika?

- [ ] Rentabilita tržeb (EAT / T)
- [ ] Obrat aktiv (T / A)
- [ ] Rentabilita aktiv (EAT / A)
- [x] Finanční páka (A / VK)

> Vyšší A / VK znamená nižší podíl vlastního a vyšší podíl cizího kapitálu. ROE sice roste, ale podnik nese vyšší fixní zátěž úroky a splátkami. Růst ROS nebo obratu aktiv zvyšuje ROE bez růstu finančního rizika.

## Analýza změny ROE pomocí Du Pontovy rovnice {#du-pont-zmena .explain}

Protože Du Pontova rovnice je **součinem** faktorů, platí totéž pro jejich indexy (podíl hodnoty běžného a výchozího období):

`I(ROE) = I(ROS) · I(obrat aktiv) · I(finanční páka)`

Index ROE tedy ukáže, o kolik se ROE změnila, a indexy faktorů, **který faktor změnu táhl**. Podíl jednotlivých faktorů na absolutní změně ROE v procentních bodech se kvantifikuje metodami analýzy odchylek (postupné změny, logaritmická či funkcionální metoda — téma 2). Při hodnocení je podstatná **kvalita růstu**: růst ROE tažený ziskovostí nebo obratem je zdravý, růst tažený jen pákou znamená vyšší riziko.

*Příklad:* ROS klesla ze 6 % na 4,5 % (index 0,75), obrat aktiv vzrostl z 1,2 na 1,5 (1,25), páka ze 2,0 na 2,4 (1,2) → I(ROE) = 0,75 · 1,25 · 1,2 = 1,125; ROE vzrostla ze 14,4 % na 16,2 %, ale ne díky ziskovosti.

### ? Rentabilita tržeb podniku meziročně klesla o 10 %, obrat aktiv vzrostl o 10 % a finanční páka se nezměnila. Co se stalo s ROE?

- [x] Klesla o 1 %
- [ ] Zůstala beze změny
- [ ] Vzrostla o 1 %
- [ ] Klesla o 10 %

> I(ROE) = I(ROS) · I(obrat aktiv) · I(páka) = 0,9 · 1,1 · 1,0 = 0,99, tedy pokles o 1 %. Změny o −10 % a +10 % se v součinu nevyruší, protože se násobí indexy, ne sčítají procenta.

### ? Rok 1: ROS 8 %, obrat aktiv 1,0, finanční páka 2,0. Rok 2: ROS 5 %, obrat aktiv 1,2, finanční páka 3,0. Jak hodnotíte vývoj ROE?

- [ ] ROE klesla z 16 % na 12 %, protože se zhoršila ziskovost tržeb
- [ ] ROE vzrostla z 16 % na 18 % díky lepší ziskovosti tržeb
- [x] ROE vzrostla z 16 % na 18 %, ale jen díky vyšší zadluženosti
- [ ] ROE se nezměnila, změny faktorů se navzájem vyrovnaly

> Rok 1: 0,08 · 1,0 · 2,0 = 16 %; rok 2: 0,05 · 1,2 · 3,0 = 18 %. ROS se zhoršila (index 0,625) a obrat aktiv sice vzrostl o 20 % (index 1,2), ale ROA = ROS · obrat přesto klesla z 8 % na 6 %. Růst ROE je tedy dán jen vyšší finanční pákou (index 1,5) — je vykoupen vyšším rizikem.

## ROI pyramidový rozklad {#roi-pyramida .explain}

**ROI pyramida** je původní podoba Du Pontova systému (firma Du Pont de Nemours, počátek 20. století). Vrcholem je rentabilita investovaného kapitálu, která se rozkládá na dvě větve:

`ROI = zisk / investovaný kapitál = (zisk / tržby) · (tržby / investovaný kapitál)`

- **levá větev — ziskové rozpětí**: zisk = tržby − náklady, náklady se dále člení (výrobní, odbytové, správní; případně variabilní a fixní),
- **pravá větev — obrat kapitálu**: investovaný kapitál = dlouhodobý majetek + oběžná aktiva (zásoby, pohledávky, peněžní prostředky).

Horní úrovně jsou spojeny **multiplikativně**, spodní **aditivně**. Vypovídací hodnota: změnu ROI lze sledovat až ke konkrétní nákladové nebo majetkové položce, a ROI pyramida se proto používá k řízení podniku i jeho divizí. Slabinou je krátkodobá účetní orientace a riziko **suboptimalizace** — manažer divize hodnocený podle ROI odmítne projekt s nižší než průměrnou ROI divize, i když projekt vydělává víc než náklady kapitálu (to řeší reziduální zisk a EVA, téma 6).

*Příklad:* Tržby 50 000, náklady 46 000 → zisk 4 000, ziskové rozpětí 8 %; dlouhodobý majetek 15 000 + oběžná aktiva 10 000 = 25 000 → obrat kapitálu 2,0; ROI = 8 % · 2,0 = 16 % (kontrola: 4 000 / 25 000 = 16 %).

### ? Tržby činí 60 000, náklady 55 200, dlouhodobý majetek 18 000, zásoby 6 000, pohledávky 5 000 a peníze 1 000 tis. Kč. Jaká je ROI podle ROI pyramidy?

- [ ] 8 %
- [x] 16 %
- [ ] 26,7 %
- [ ] 20 %

> Zisk = 60 000 − 55 200 = 4 800; ziskové rozpětí = 8 %; investovaný kapitál = 18 000 + 6 000 + 5 000 + 1 000 = 30 000; obrat = 2,0; ROI = 8 % · 2,0 = 16 %. Hodnota 8 % je jen ziskové rozpětí, 26,7 % vznikne dosazením jen dlouhodobého majetku a 20 % opomenutím zásob.

### ? Divize dosahuje ROI 20 %, náklady kapitálu jsou 10 %. Manažer hodnocený podle ROI odmítne projekt s ROI 15 %. Proč je to problém?

- [ ] Projekt by snížil zadluženost divize pod optimum
- [ ] Projekt s ROI 15 % ničí hodnotu, odmítnutí je tedy správné
- [ ] ROI nelze použít k hodnocení výkonnosti divizí
- [x] Projekt výnosem převyšuje náklady kapitálu, ale snížil by průměrné ROI divize

> Projekt vydělává 15 % při nákladech kapitálu 10 %, tedy hodnotu tvoří; manažer ho odmítne jen proto, že by snížil průměrné ROI divize z 20 %. Tuto suboptimalizaci odstraňují ukazatele typu reziduální zisk a EVA.

## Trendová analýza {#trendova-analyza .explain}

**Trendová analýza** (horizontální analýza v čase) sleduje vývoj absolutních položek i poměrových ukazatelů v delší časové řadě, obvykle alespoň 3–5 let. Zjišťuje **směr, tempo a stálost** vývoje a zlomy v něm; slouží i jako východisko pro opatrnou extrapolaci (analýza ex ante).

Vypovídací hodnotu trendu ovlivňují:

- **jednorázové vlivy** (prodej majetku, mimořádné odpisy) — jeden rok netvoří trend,
- **inflace** — nominální růst tržeb nemusí znamenat reálný růst; reálný index = nominální index / cenový index,
- **změny metodiky a struktury** (změna účetních metod, akvizice, prodej části podniku) — narušují srovnatelnost řady.

Trendová analýza se kombinuje se srovnáním s oborem: zlepšování ukazatele, které je pomalejší než v oboru, může znamenat ztrátu konkurenční pozice.

*Příklad:* ROA podniku za pět let: 6 %, 6,5 %, 7,2 %, 4,1 %, 7,6 %. Rostoucí trend přerušuje jediný výkyv ve 4. roce — pokud byl způsoben mimořádným odpisem, trend zůstává příznivý.

### ? Tržby podniku nominálně vzrostly o 4 %, ceny v odvětví vzrostly o 6 %. Jak hodnotíte vývoj tržeb?

- [ ] Reálně vzrostly přibližně o 10 %
- [x] Reálně klesly přibližně o 2 %
- [ ] Reálně vzrostly o 4 %
- [ ] Reálně se nezměnily

> Reálný index = 1,04 / 1,06 ≈ 0,981, tedy reálný pokles asi o 1,9 %. Nominální růst o 4 % nestačil vyrovnat růst cen o 6 %.

### ? Proč má trendová analýza pracovat s řadou alespoň několika let?

- [ ] Účetní závěrka se sestavuje jen jednou za tři roky
- [ ] Poměrové ukazatele nelze počítat pro jediný rok
- [x] Aby šlo odlišit trvalý trend od jednorázových výkyvů
- [ ] Aby se vyloučil vliv oborového průměru

> Meziroční změna mezi dvěma roky může být způsobena jednorázovou událostí. Teprve delší řada ukáže, zda jde o trvalý směr vývoje.

## Indexy a průměrné tempo růstu {#indexy-tempo .explain}

Trendová analýza i soustava nerovností pracují s **indexy**:

- **bazický index** Iₜ/₀ = Uₜ / U₀ — srovnání se stálým výchozím obdobím,
- **řetězový index** Iₜ/ₜ₋₁ = Uₜ / Uₜ₋₁ — srovnání s předchozím obdobím,
- **tempo růstu** = (I − 1) · 100 %; součin řetězových indexů = bazický index.

**Průměrný koeficient růstu** za n období je **geometrický průměr** řetězových indexů: `ⁿ√(Uₙ / U₀)`. Aritmetický průměr temp růstu průměrné tempo nadhodnocuje, protože ignoruje složené (řetězové) působení růstu.

*Příklad:* Tržby 200 → 220 → 242: řetězové indexy 1,1 a 1,1, bazický index 1,21 (růst o 21 %), průměrný koeficient růstu √1,21 = 1,1, tj. průměrné tempo růstu 10 % ročně.

### ? Zisk podniku vzrostl z 500 tis. Kč v roce 2020 na 665,5 tis. Kč v roce 2023. Jaké je průměrné roční tempo růstu zisku?

- [ ] 33,1 %
- [ ] 11,0 %
- [x] 10 %
- [ ] 7,4 %

> Bazický index = 665,5 / 500 = 1,331 za tři meziroční období; průměrný koeficient = ∛1,331 = 1,1, tj. 10 % ročně. 33,1 % je celkový růst, 11,0 % jeho aritmetický průměr a 7,4 % vznikne chybným odmocněním čtvrtou odmocninou (počet let místo počtu období).

### ? Řetězové indexy tržeb za dva po sobě jdoucí roky jsou 1,05 a 1,20. O kolik procent vzrostly tržby celkem za oba roky?

- [ ] O 25 %
- [x] O 26 %
- [ ] O 12,5 %
- [ ] O 20 %

> Bazický index = součin řetězových indexů = 1,05 · 1,20 = 1,26, tj. růst o 26 %. Sečtení temp (25 %) ignoruje řetězení, 12,5 % je jejich aritmetický průměr a 20 % jen růst ve druhém roce.

## Soustava nerovností — zlaté pravidlo hospodaření {#zlate-pravidlo .explain}

**Soustava nerovností** vyjadřuje žádoucí relace mezi **tempy (indexy) růstu** vybraných ukazatelů. Nejznámější je tzv. **zlaté pravidlo hospodaření**:

`I(zisk) > I(tržby) > I(aktiva) > 1`

- **I(aktiva) > 1** — podnik roste, zvětšuje majetek,
- **I(tržby) > I(aktiva)** — tržby rostou rychleji než majetek, roste obrat aktiv (intenzivní využití majetku),
- **I(zisk) > I(tržby)** — zisk roste rychleji než tržby, roste rentabilita tržeb (klesá nákladovost).

Při splnění celé soustavy proto roste i rentabilita aktiv. Obdobnou nerovností je požadavek, aby **produktivita práce rostla rychleji než průměrná mzda**. Vypovídací hodnota: soustava nehodnotí úroveň ukazatelů, ale **dynamiku** — rychle ukáže, ve které vazbě se vývoj odchýlil od žádoucího stavu.

*Příklad:* I(zisk) = 1,12, I(tržby) = 1,08, I(aktiva) = 1,05 → pravidlo je splněno; ROS vzrostla (1,12 / 1,08 ≈ 1,037), obrat aktiv vzrostl (1,08 / 1,05 ≈ 1,029) a ROA vzrostla (1,12 / 1,05 ≈ 1,067).

### ? Které pořadí indexů růstu odpovídá zlatému pravidlu hospodaření?

- [ ] I(aktiva) > I(tržby) > I(zisk) > 1
- [ ] I(tržby) > I(zisk) > I(aktiva) > 1
- [ ] I(zisk) > I(aktiva) > I(tržby) > 1
- [x] I(zisk) > I(tržby) > I(aktiva) > 1

> Zisk má růst rychleji než tržby (roste ROS) a tržby rychleji než aktiva (roste obrat aktiv), přičemž aktiva rostou (podnik se rozvíjí).

### ? Indexy růstu podniku: zisk 1,06, tržby 1,10, aktiva 1,04. Co z toho plyne pro rentabilitu tržeb (ROS) a obrat aktiv?

- [x] ROS klesá, obrat aktiv roste
- [ ] ROS roste, obrat aktiv klesá
- [ ] ROS i obrat aktiv rostou
- [ ] ROS i obrat aktiv klesají

> Index ROS = 1,06 / 1,10 ≈ 0,96 — zisk roste pomaleji než tržby, nerovnost I(zisk) > I(tržby) je porušena. Index obratu aktiv = 1,10 / 1,04 ≈ 1,06 — tato vazba splněna je.

## Matematický základ soustavy nerovností {#indexy-pomerovych-ukazatelu .explain}

Každá nerovnost v soustavě odpovídá vývoji určitého **poměrového ukazatele**, protože index poměru je podílem indexů čitatele a jmenovatele:

- `I(ROS) = I(EAT) / I(T)` → ROS roste, právě když I(EAT) > I(T),
- `I(obrat aktiv) = I(T) / I(A)` → obrat roste, právě když I(T) > I(A),
- `I(ROA) = I(EAT) / I(A) = I(ROS) · I(obrat aktiv)`,
- mzdová náročnost tržeb = mzdové náklady / T = průměrná mzda / produktivita práce (T na pracovníka) → klesá, právě když produktivita roste rychleji než průměrná mzda.

Díky těmto vazbám lze soustavu nerovností číst jako zjednodušenou pyramidu v dynamice: porušená nerovnost ukazuje, který poměrový ukazatel se zhoršil, a tím i směr hledání příčin.

*Příklad:* Tržby vzrostly o 8 % a aktiva o 20 % → I(obrat aktiv) = 1,08 / 1,20 = 0,9; obrat aktiv klesl o 10 %, majetek se využívá méně intenzivně.

### ? Tržby podniku vzrostly o 8 % a aktiva o 20 %. Jak se změnil obrat aktiv?

- [ ] Klesl o 12 %
- [ ] Vzrostl o 11 %
- [x] Klesl o 10 %
- [ ] Nezměnil se

> I(obrat aktiv) = I(T) / I(A) = 1,08 / 1,20 = 0,9, tedy pokles o 10 %. Rozdíl temp (8 − 20 = −12) je jen přibližný a 1,20 / 1,08 ≈ 1,11 je převrácený poměr.

### ? Produktivita práce (tržby na pracovníka) vzrostla o 5 % a průměrná mzda o 8 %. Co se stalo s podílem mzdových nákladů na tržbách?

- [x] Vzrostl přibližně o 2,9 %
- [ ] Klesl přibližně o 2,9 %
- [ ] Nezměnil se
- [ ] Bez počtu pracovníků to nelze určit

> Mzdová náročnost = průměrná mzda / produktivita; její index = 1,08 / 1,05 ≈ 1,029. Počet pracovníků se v podílu zkrátí, takže ho znát nepotřebujeme. Porušení nerovnosti I(produktivita) > I(průměrná mzda) zvyšuje nákladovost tržeb.

## Ekonomický normál {#ekonomicky-normal .explain}

**Ekonomický normál** rozšiřuje soustavu nerovností na více ukazatelů: jde o **normativně stanovené (žádoucí) pořadí temp růstu** vybraných ukazatelů, s nímž se srovnává skutečné pořadí dosažené podnikem. Konkrétní výběr ukazatelů se liší podle autora a účelu analýzy, normál však musí být vnitřně logický — každá dvojice sousedních ukazatelů odpovídá žádoucímu vývoji určitého poměrového ukazatele.

Hodnocení: čím více relací normálu je ve skutečnosti splněno, tím více se vývoj podniku blíží žádoucímu stavu; porušené relace ukazují, kde hledat příčiny (nákladovost, využití majetku, produktivita, mzdový vývoj).

*Příklad (ilustrativní normál):* I(zisk) > I(tržby) > I(aktiva) > 1 a zároveň I(tržby) > I(mzdové náklady) > I(počet pracovníků). Druhá řada znamená klesající mzdovou náročnost tržeb a současně rostoucí průměrnou mzdu.

### ? Co se rozumí ekonomickým normálem při hodnocení výkonnosti podniku?

- [ ] Průměrné hodnoty poměrových ukazatelů v odvětví
- [x] Žádoucí pořadí temp růstu vybraných ukazatelů
- [ ] Orientační doporučené hodnoty ukazatelů likvidity
- [ ] Úroveň ROE odpovídající nákladům vlastního kapitálu

> Ekonomický normál je normativní uspořádání indexů růstu ukazatelů; skutečné pořadí se s ním porovnává a porušené relace ukazují problémové oblasti. Oborové průměry a doporučené hodnoty hodnotí úroveň, ne dynamiku.

### ? Součástí normálu je nerovnost I(mzdové náklady) > I(počet pracovníků). Co splnění této relace znamená?

- [ ] Klesá podíl mzdových nákladů na tržbách
- [ ] Roste produktivita práce podniku
- [x] Roste průměrná mzda na pracovníka
- [ ] Roste počet pracovníků rychleji než mzdy

> Průměrná mzda = mzdové náklady / počet pracovníků; roste právě tehdy, když mzdové náklady rostou rychleji než počet pracovníků. O produktivitě ani o podílu mezd na tržbách tato dvojice bez údaje o tržbách nic neříká.

## Výhody a omezení klasických modelů {#omezeni-klasickych-modelu .compare}

Klasické modely jsou základem každého hodnocení výkonnosti, mají ale meze, které vedly ke vzniku hodnotových ukazatelů (téma 6), predikčních modelů (téma 5) a nefinančních systémů měření (BSC, EFQM):

| Výhody | Omezení |
|---|---|
| data jsou běžně dostupná z účetní závěrky | údaje jsou **historické** (ex post), o budoucnosti vypovídají omezeně |
| výpočet je jednoduchý a srozumitelný | účetní zisk lze ovlivnit účetními metodami (odpisy, oceňování, rezervy) |
| poměry odstraňují vliv velikosti a umožňují srovnání | rozvahové údaje k jednomu dni lze účelově upravit (window dressing) |
| pyramidové rozklady propojují ukazatele a hledají příčiny | **nezohledňují riziko, náklady vlastního kapitálu ani časovou hodnotu peněz** |
| zavedená metodika, oborová srovnávací data | historické ceny a inflace zkreslují aktiva i trendy; chybí nehmotná aktiva a nefinanční faktory |

### ? Co NEPATŘÍ mezi omezení klasických ukazatelů výkonnosti?

- [ ] Vycházejí z historických účetních údajů
- [ ] Neodečítají náklady vlastního kapitálu
- [ ] Účetní zisk lze ovlivnit volbou účetních metod
- [x] Potřebná data jsou běžně dostupná v účetní závěrce

> Dostupnost dat z účetní závěrky je naopak hlavní výhodou klasických modelů. Historičnost, opomenutí nákladů kapitálu a ovlivnitelnost zisku jsou jejich typická omezení.

### ? Podnik vykazuje ROE 8 %, zatímco vlastníci požadují výnos (náklady vlastního kapitálu) 11 %. Jak výsledek hodnotíte?

- [ ] Podnik tvoří hodnotu, protože dosahuje kladného čistého zisku
- [x] Podnik je účetně ziskový, ale hodnotu pro vlastníky netvoří
- [ ] ROE nelze srovnávat s náklady vlastního kapitálu
- [ ] Podnik tvoří hodnotu, protože ROE je kladná

> ROE 8 % je nižší než požadovaný výnos 11 % — vlastníci by alternativní investicí se stejným rizikem získali víc. Kladný účetní zisk to neodhalí, protože náklady vlastního kapitálu v něm nejsou odečteny; to řeší hodnotové ukazatele (EVA, spread ROE − r_VK).
