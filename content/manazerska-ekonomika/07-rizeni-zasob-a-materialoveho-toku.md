---
kind: topic
subject: manazerska-ekonomika
slug: rizeni-zasob-a-materialoveho-toku
name: "Řízení zásob a materiálového toku"
order: 7
---

Účel a význam zásob v podniku, řízení zásob a materiálového toku. Metody měření efektivity řízení zásob. Nástroje pro analýzu a optimalizaci zásob JIT, ABC. Řízení dodavatelského řetězce – Supply Chain Management.

## Účel a funkce zásob {#ucel-funkce-zasob .explain}

Zásoby jsou součástí oběžných aktiv. Vznikají proto, že tok vstupů (dodávky) a tok výstupů (spotřeba ve výrobě, prodej) nejsou sladěny v čase, v množství ani v sortimentu. Podle toho, proč je podnik drží, plní zásoby tyto **funkce**:

- **vyrovnávací** (obratová) — vyrovnává nesoulad mezi dodávkami v dávkách a průběžnou spotřebou,
- **pojistná** — chrání před nejistotou: nečekaně vyšší spotřebou, zpožděním nebo nekvalitou dodávky,
- **spekulativní** — nákup nad běžnou potřebu v očekávání růstu cen nebo nedostatku na trhu,
- **technologická** — zásoba je nutnou součástí výrobního procesu (zrání sýrů a vína, sušení dřeva, odležení odlitků).

Zásoby zajišťují plynulost výroby a prodeje, ale vážou kapitál a vytvářejí náklady. Cílem proto není co nejvyšší, ani co nejnižší, ale **optimální** výše zásob.

*Příklad:* Pivovar nakupuje slad jednou za měsíc, ale spotřebovává ho denně (vyrovnávací funkce), drží navíc zásobu na týden pro případ zpoždění dodávky (pojistná funkce) a pivo nechává několik týdnů ležet ve sklepě (technologická funkce).

### ? Výrobce kabelů nakoupí měď nad běžnou potřebu, protože očekává její zdražení. Jakou funkci tato zásoba plní?

- [ ] Pojistnou
- [ ] Vyrovnávací
- [x] Spekulativní
- [ ] Technologickou

> Nákup do zásoby kvůli očekávanému růstu ceny je spekulace. Pojistná zásoba by kryla nejistotu dodávek či spotřeby, ne vývoj ceny.

### ? Jaký je základní důvod, proč podnik vůbec drží zásoby?

- [x] Dodávky a spotřeba nejsou sladěny v čase ani v množství
- [ ] Zásoby jako aktivum vždy zvyšují výsledek hospodaření
- [ ] Účetní předpisy vyžadují minimální stav zásob
- [ ] Vyšší zásoby snižují potřebu kapitálu podniku

> Zásoby vyrovnávají nesoulad mezi tokem vstupů a výstupů. Kapitál naopak vážou a na výsledek hospodaření působí přes skladovací náklady spíše negativně.

## Druhy zásob podle vyhlášky 500/2002 Sb. {#druhy-zasob .compare}

V rozvaze podnikatelů se zásoby (C.I) člení takto:

| Položka | Obsah | Ocenění (zákon o účetnictví) |
|---|---|---|
| **Materiál** | suroviny, základní a pomocný materiál, provozovací látky, náhradní díly, obaly | pořizovací cena |
| **Nedokončená výroba a polotovary** | výrobky, které prošly jen částí výrobního procesu, a polotovary vlastní výroby | vlastní náklady |
| **Výrobky** | hotové výrobky vlastní výroby určené k prodeji | vlastní náklady |
| **Zboží** | věci nakoupené za účelem prodeje beze změny | pořizovací cena |
| **Mladá a ostatní zvířata a jejich skupiny** | zvířata chovaná k produkci nebo prodeji (zejména zemědělství) | pořizovací cena / vlastní náklady |
| **Poskytnuté zálohy na zásoby** | zálohy zaplacené dodavatelům zásob | jmenovitá hodnota |

Výrobky a zboží tvoří v rozvaze jednu souhrnnou položku se dvěma podpoložkami.

### ? Obchodní řetězec nakupuje balenou vodu a prodává ji beze změny. Kam tuto zásobu zařadí?

- [ ] Materiál
- [ ] Výrobky
- [ ] Nedokončená výroba a polotovary
- [x] Zboží

> Zboží jsou věci nakoupené za účelem dalšího prodeje beze změny. Výrobky a polotovary vznikají vlastní výrobou, materiál se spotřebovává ve výrobě.

### ? Strojírna vyrábí vlastní odlitky, které dále opracovává na hotové díly. Kam patří odlitky ležící na skladě?

- [ ] Materiál
- [x] Nedokončená výroba a polotovary
- [ ] Zboží
- [ ] Výrobky

> Odlitky jsou polotovary vlastní výroby — prošly jen částí výrobního procesu a dále se zpracovávají. Oceňují se vlastními náklady.

## Složky zásoby: běžná, pojistná, technologická, strategická {#slozky-zasoby .compare}

| Složka | Účel | Chování v čase |
|---|---|---|
| **Běžná** (obratová, cyklická) | kryje spotřebu mezi dvěma dodávkami | po dodávce je na maximu (velikost dodávky Q), pak klesá k nule; průměrně Q/2 |
| **Pojistná** (PZ) | kryje náhodné výkyvy spotřeby a dodávek | za normálního průběhu zůstává nedotčena |
| **Technologická** | doba nutné přípravy materiálu před použitím (sušení, zrání, temperování) | po dobu přípravy je trvale vázána |
| **Strategická** (havarijní) | mimořádné situace — dlouhodobé přerušení dodávek, krize, válka | drží se dlouhodobě, čerpá se výjimečně |

Pro běžnou a pojistnou zásobu platí: **maximální zásoba = Q + PZ**, **průměrná zásoba = Q/2 + PZ** (případně + technologická zásoba). Někdy se dále vyčleňuje sezónní zásoba nebo zásoba na cestě.

### ? Podnik objednává po 800 ks a drží pojistnou zásobu 150 ks. Jaká je jeho průměrná zásoba?

- [ ] 400 ks
- [ ] 950 ks
- [x] 550 ks
- [ ] 475 ks

> Průměrná zásoba = Q/2 + PZ = 800/2 + 150 = 550 ks. Hodnota 950 ks je maximální zásoba (Q + PZ), 400 ks pomíjí pojistnou zásobu.

### ? Která složka zásoby slouží k překonání dlouhodobého přerušení dodávek, např. při válečném konfliktu?

- [x] Strategická
- [ ] Pojistná
- [ ] Běžná
- [ ] Technologická

> Strategická (havarijní) zásoba je určena pro mimořádné situace. Pojistná zásoba kryje jen běžné náhodné výkyvy spotřeby a dodávek.

## Náklady spojené se zásobami {#naklady-zasob .explain}

Kromě samotné pořizovací ceny vznikají tři skupiny nákladů:

- **objednací (pořizovací) náklady** Co — vznikají s každou objednávkou bez ohledu na její velikost: vystavení a administrativa objednávky, doprava, přejímka, kontrola kvality; u vlastní výroby náklady na seřízení stroje,
- **skladovací náklady** (náklady na držení zásob) Cs — rostou s výší zásoby: **náklady vázaného kapitálu** (úrok, resp. ušlý výnos), provoz skladu, pojištění, ztráty, kažení a zastarávání; často se vyjadřují jako roční procento z hodnoty zásoby,
- **náklady z nedostatku** (deficitu) — ušlý zisk, smluvní pokuty, ztráta zákazníka, prostoje výroby, nákladné mimořádné dodávky.

S rostoucí velikostí objednávky klesá počet objednávek a tedy roční objednací náklady, ale roste průměrná zásoba a s ní skladovací náklady — z tohoto protikladu vychází model EOQ.

*Příklad:* Součástka stojí 500 Kč a roční náklady na držení činí 18 % hodnoty zásoby → Cs = 0,18 · 500 = 90 Kč na kus a rok.

### ? Do které skupiny nákladů patří úrok z kapitálu vázaného v zásobách?

- [ ] Objednací náklady
- [x] Skladovací náklady
- [ ] Náklady z nedostatku
- [ ] Pořizovací cena zásob

> Kapitál vázaný v zásobách má svou cenu (úrok nebo ušlý výnos), která roste s výší držené zásoby — jde tedy o náklad na držení, tj. skladovací náklad.

### ? Jak se při stejné roční spotřebě mění roční náklady se zvětšováním velikosti objednávky?

- [ ] Objednací i skladovací náklady rostou
- [ ] Objednací náklady rostou, skladovací klesají
- [ ] Objednací i skladovací náklady klesají
- [x] Objednací náklady klesají, skladovací rostou

> Větší objednávka znamená méně objednávek za rok (nižší objednací náklady), ale vyšší průměrnou zásobu Q/2 (vyšší skladovací náklady).

### ? Materiál stojí 250 Kč/ks, roční náklady na držení zásob činí 16 % z hodnoty zásoby. Jaké jsou roční skladovací náklady na jednotku Cs?

- [ ] 16 Kč
- [ ] 290 Kč
- [ ] 4 Kč
- [x] 40 Kč

> Cs = 0,16 · 250 = 40 Kč na kus a rok. Hodnota 16 Kč zaměňuje procento za korunovou částku, 290 Kč přičítá náklad k ceně.

## Cíle řízení zásob a konflikt cílů {#cile-rizeni-zasob .explain}

Řízení zásob je součástí řízení **materiálového toku** (logistiky) — od nákupu přes sklady a výrobu po expedici. Cílem je, aby potřebný materiál byl k dispozici ve správném množství, kvalitě, čase a místě, a to při **požadované úrovni obsluhy a minimálních celkových nákladech** (objednacích, skladovacích a z nedostatku). Útvary podniku přitom sledují protichůdné dílčí cíle:

- **nákup** — velké dávky kvůli množstevním slevám a nižším objednacím nákladům,
- **výroba** — dostatek materiálu pro plynulost a dlouhé výrobní série s málo přestavbami,
- **prodej** — vysoké zásoby hotových výrobků pro okamžité dodání zákazníkům,
- **finance** — nízké zásoby a co nejméně vázaného kapitálu.

Úkolem řízení zásob je tyto cíle sladit z pohledu podniku jako celku, ne optimalizovat jednotlivé útvary zvlášť.

*Příklad:* Nákupčí získá 5% slevu za roční objem nakoupený najednou, ale vázaný kapitál a skladovací náklady převýší úsporu — pro podnik jako celek je nákup nevýhodný.

### ? Který požadavek na zásoby typicky prosazuje finanční útvar podniku?

- [ ] Vysoké zásoby výrobků pro okamžité dodání
- [ ] Velké nákupní dávky kvůli množstevním slevám
- [x] Nízké zásoby a málo vázaného kapitálu
- [ ] Dlouhé výrobní série s málo přestavbami

> Finance usilují o minimum kapitálu vázaného v zásobách. Vysoké zásoby výrobků prosazuje prodej, velké dávky nákup a dlouhé série výroba.

### ? Co je hlavním cílem řízení zásob?

- [ ] Snížit zásoby na nulu ve všech položkách
- [ ] Minimalizovat počet objednávek za rok
- [ ] Mít vždy co nejvyšší zásobu všech položek
- [x] Zajistit úroveň obsluhy při minimálních nákladech

> Řízení zásob hledá kompromis mezi dostupností materiálu a náklady. Nulové zásoby ohrožují plynulost, maximální zásoby zbytečně vážou kapitál.

## Optimální velikost objednávky — model Harris–Wilson (EOQ) {#eoq .explain}

Model optimální velikosti objednávky (Economic Order Quantity, EOQ; F. W. Harris 1913, rozšířil R. H. Wilson) hledá takovou velikost objednávky Q, při níž jsou **součtové roční objednací a skladovací náklady minimální**:

- roční objednací náklady = (D/Q) · Co,
- roční skladovací náklady = (Q/2) · Cs,
- celkové relevantní náklady N(Q) = (D/Q) · Co + (Q/2) · Cs.

Minimum nastává tam, kde se obě složky rovnají, z čehož plyne **EOQ = √(2 · D · Co / Cs)**, kde D je roční spotřeba (ks), Co náklady na jednu objednávku (Kč) a Cs roční skladovací náklady na jednotku (Kč/ks/rok). Pořizovací cena není v základním modelu relevantní, protože se za rok nakoupí stejné množství bez ohledu na Q.

*Příklad:* D = 12 000 ks, Co = 600 Kč, Cs = 40 Kč → EOQ = √(2 · 12 000 · 600 / 40) = √360 000 = 600 ks. Objednací náklady 20 · 600 = 12 000 Kč, skladovací 300 · 40 = 12 000 Kč, celkem 24 000 Kč.

### ? Roční spotřeba je 5 000 ks, náklady na jednu objednávku 400 Kč a roční skladovací náklady 16 Kč/ks. Jaká je optimální velikost objednávky?

- [ ] Přibližně 354 ks
- [x] 500 ks
- [ ] 20 ks
- [ ] 250 000 ks

> EOQ = √(2 · 5 000 · 400 / 16) = √250 000 = 500 ks. Bez dvojky vyjde ≈ 354 ks, při prohození Co a Cs 20 ks a bez odmocniny 250 000.

### ? D = 9 000 ks/rok, Co = 800 Kč, cena 200 Kč/ks a roční náklady na držení 20 % z hodnoty zásoby. Jaká je EOQ?

- [ ] Přibližně 268 ks
- [ ] Přibližně 424 ks
- [x] 600 ks
- [ ] Přibližně 8 485 ks

> Cs = 0,2 · 200 = 40 Kč; EOQ = √(2 · 9 000 · 800 / 40) = √360 000 = 600 ks. Dosazení ceny 200 místo Cs dá ≈ 268 ks, dosazení 0,2 dá ≈ 8 485 ks, vynechání dvojky ≈ 424 ks.

### ? Optimální velikost objednávky je 400 ks a Cs = 25 Kč/ks/rok. Jaké jsou celkové roční objednací a skladovací náklady (bez pořizovací ceny)?

- [x] 10 000 Kč
- [ ] 5 000 Kč
- [ ] 20 000 Kč
- [ ] 15 000 Kč

> Skladovací náklady = Q/2 · Cs = 200 · 25 = 5 000 Kč. V optimu EOQ jsou objednací náklady stejné, tedy celkem 10 000 Kč. Hodnota 5 000 Kč je jen jedna složka.

## Předpoklady a citlivost modelu EOQ {#eoq-predpoklady .explain}

Základní model EOQ platí za těchto **předpokladů**: roční spotřeba je známá a **rovnoměrná**, dodávka přichází celá najednou a **okamžitě** (bez postupného doplňování), Co a Cs jsou konstantní, **cena nezávisí na velikosti objednávky** (žádné množstevní slevy), **nedostatek není přípustný**, model řeší jednu položku nezávisle na ostatních a bez omezení skladové kapacity či kapitálu. Pro reálné podmínky existují rozšíření — s množstevními slevami, s postupnou dodávkou (optimální výrobní dávka), s povoleným nedostatkem.

V praxi model funguje i přes zjednodušení, protože křivka celkových nákladů je v okolí optima **plochá**: poměr nákladů při velikosti Q a v optimu je N/N* = ½ · (Q/Q* + Q*/Q). Malá odchylka od EOQ (např. zaokrouhlení na celá balení) tak náklady téměř nezvýší. Protože je ve vzorci odmocnina, EOQ roste jen s odmocninou spotřeby.

*Příklad:* Při objednávce o 20 % větší než EOQ: N/N* = ½ · (1,2 + 1/1,2) ≈ 1,017 — náklady vzrostou jen asi o 1,7 %.

### ? Který předpoklad NENÍ součástí základního modelu EOQ?

- [ ] Spotřeba je známá a rovnoměrná
- [ ] Dodávka přichází celá a okamžitě
- [x] Dodavatel poskytuje množstevní slevy
- [ ] Nedostatek zásoby není přípustný

> Základní model předpokládá cenu nezávislou na velikosti objednávky. Množstevní slevy řeší až rozšířená varianta modelu.

### ? Podnik objednává o 20 % více, než je EOQ. O kolik přibližně vzrostou celkové relevantní náklady oproti optimu?

- [ ] O 20 %
- [x] O 1,7 %
- [ ] O 10 %
- [ ] O 44 %

> N/N* = ½ · (1,2 + 1/1,2) = ½ · (1,2 + 0,833) ≈ 1,017, tedy nárůst asi o 1,7 %. Nákladová křivka je v okolí optima plochá.

### ? Roční spotřeba materiálu vzroste čtyřikrát, Co a Cs se nezmění. Jak se změní optimální velikost objednávky?

- [ ] Vzroste čtyřikrát
- [ ] Nezmění se
- [ ] Vzroste šestnáctkrát
- [x] Vzroste dvakrát

> EOQ = √(2 · D · Co / Cs) roste s odmocninou spotřeby: √4 = 2. Optimální objednávka se tedy zdvojnásobí, počet objednávek za rok také.

## Počet objednávek a interval mezi dodávkami {#eoq-objednavky .explain}

Ze známé optimální velikosti objednávky Q* se odvodí:

- **optimální počet objednávek za rok** n = D / Q*,
- **interval mezi dodávkami** (délka cyklu) t = 360 / n = 360 · Q* / D dní (při konvenci 360 dní v roce; lze použít i 365 nebo počet pracovních dní),
- **průměrná běžná zásoba** Q*/2.

Tyto veličiny slouží k plánování nákupu a skladových kapacit; vypočtený počet objednávek se v praxi zaokrouhluje, což vzhledem k ploché nákladové křivce téměř nezvýší náklady.

*Příklad:* D = 12 000 ks, Q* = 600 ks → n = 20 objednávek ročně, interval 360 / 20 = 18 dní, průměrná běžná zásoba 300 ks.

### ? Roční spotřeba je 7 200 ks a optimální velikost objednávky 600 ks. Jaký je počet objednávek za rok a interval mezi dodávkami (rok = 360 dní)?

- [ ] 6 objednávek, interval 60 dní
- [ ] 24 objednávek, interval 15 dní
- [x] 12 objednávek, interval 30 dní
- [ ] 12 objednávek, interval 15 dní

> n = D / Q* = 7 200 / 600 = 12; t = 360 / 12 = 30 dní. Hodnota 24 vznikne dělením průměrnou zásobou (Q*/2 = 300 ks), hodnota 6 dělením dvojnásobkem Q* (1 200 ks).

### ? D = 4 800 ks/rok, Co = 150 Kč, Cs = 4 Kč/ks/rok. Jaký je optimální počet objednávek za rok a interval mezi nimi (rok = 360 dní)?

- [x] 8 objednávek, interval 45 dní
- [ ] 16 objednávek, interval 22,5 dne
- [ ] 4 objednávky, interval 90 dní
- [ ] 6 objednávek, interval 60 dní

> EOQ = √(2 · 4 800 · 150 / 4) = √360 000 = 600 ks; n = 4 800 / 600 = 8; t = 360 / 8 = 45 dní.

## Pojistná zásoba {#pojistna-zasoba .explain}

Pojistná zásoba (PZ, safety stock) kryje **náhodné odchylky** — vyšší spotřebu během dodací lhůty, než se čekalo, a zpoždění dodávky. Za normálního průběhu se nečerpá. Stanovuje se:

- kvalifikovaným odhadem, např. jako počet dní průměrné spotřeby,
- zjednodušeně jako **průměrná denní spotřeba × očekávané maximální zpoždění dodávky**,
- statisticky jako **PZ = k · σ_L**, kde σ_L je směrodatná odchylka spotřeby za dodací lhůtu. Při stálé dodací lhůtě L (dny) a nezávislé denní spotřebě se směrodatnou odchylkou σ_d platí σ_L = σ_d · √L. Koeficient k odpovídá požadované pravděpodobnosti, že v cyklu nedojde k vyčerpání zásoby: 90 % → 1,28; 95 % → 1,65; 99 % → 2,33.

Vyšší pojistná zásoba znamená méně výpadků, ale více vázaného kapitálu a vyšší skladovací náklady.

*Příklad:* σ_d = 20 ks/den, L = 9 dní, požadovaná úroveň 95 %: σ_L = 20 · √9 = 60 ks, PZ = 1,65 · 60 ≈ 99 ks.

### ? Směrodatná odchylka denní spotřeby je 10 ks, dodací lhůta 16 dní a koeficient bezpečnosti k = 2. Jaká je pojistná zásoba?

- [ ] 320 ks
- [ ] 20 ks
- [ ] 40 ks
- [x] 80 ks

> σ_L = σ_d · √L = 10 · √16 = 40 ks; PZ = k · σ_L = 2 · 40 = 80 ks. Hodnota 320 ks vznikne násobením L místo √L, 40 ks pomíjí koeficient k.

### ? Průměrná denní spotřeba je 50 ks a dodávka se může opozdit až o 4 dny. Jaká je pojistná zásoba při zjednodušeném výpočtu?

- [x] 200 ks
- [ ] 50 ks
- [ ] 12,5 ks
- [ ] 400 ks

> Zjednodušeně PZ = denní spotřeba × maximální zpoždění = 50 · 4 = 200 ks. Tolik se spotřebuje během dnů, o které dodávka může přijít později.

## Objednací bod {#objednaci-bod .explain}

Objednací bod (OB, signální stav, reorder point) je stav zásoby, při jehož dosažení se musí vystavit objednávka, aby nová dodávka dorazila dřív, než podnik začne čerpat pojistnou zásobu. Během dodací lhůty se spotřebuje d · L, proto:

**OB = d · L + PZ**,

kde d je průměrná denní spotřeba a L dodací lhůta ve dnech (od vystavení objednávky po příjem na sklad). V základním modelu **nezávisí na velikosti objednávky**. Je-li dodací lhůta delší než interval mezi dodávkami, porovnává se s objednacím bodem tzv. dispoziční zásoba (skladová zásoba + objednané, dosud nedodané množství).

*Příklad:* D = 18 000 ks/rok (360 dní) → d = 50 ks/den; L = 6 dní, PZ = 100 ks → OB = 50 · 6 + 100 = 400 ks.

### ? Roční spotřeba je 7 200 ks (rok = 360 dní), dodací lhůta 8 dní a pojistná zásoba 60 ks. Jaký je objednací bod?

- [x] 220 ks
- [ ] 160 ks
- [ ] 100 ks
- [ ] 60 ks

> d = 7 200 / 360 = 20 ks/den; OB = 20 · 8 + 60 = 220 ks. Hodnota 160 ks pomíjí pojistnou zásobu, 100 ks ji chybně odečítá.

### ? Dodavatel prodlouží dodací lhůtu z 5 na 8 dní. Denní spotřeba je 40 ks a pojistná zásoba se nemění. Jak se změní objednací bod?

- [x] Zvýší se o 120 ks
- [ ] Sníží se o 120 ks
- [ ] Nezmění se, změní se jen EOQ
- [ ] Zvýší se o 320 ks

> Spotřeba během dodací lhůty vzroste o 3 dny · 40 ks = 120 ks, o tolik se zvýší i OB. Hodnota 320 ks je celá spotřeba za 8 dní, ne změna.

### ? Na které veličině objednací bod v základním modelu NEZÁVISÍ?

- [ ] Na průměrné denní spotřebě
- [ ] Na délce dodací lhůty
- [ ] Na výši pojistné zásoby
- [x] Na velikosti objednávky

> OB = d · L + PZ — velikost objednávky Q ve vzorci nevystupuje. Q určuje, kolik se objedná, OB určuje, kdy se objedná.

## Systémy objednávání (s, Q) a (T, S) {#systemy-objednavani .compare}

Dva základní systémy doplňování zásob se liší tím, co je pevné a co proměnlivé:

| | Systém s pevnou objednací úrovní (s, Q), tzv. Q-systém | Systém s pevnou periodou objednávání (T, S), tzv. T-systém |
|---|---|---|
| Kdy objednat | když zásoba klesne na objednací bod s | v pevných intervalech T (např. každý týden) |
| Kolik objednat | vždy stejné množství Q (často EOQ) | doplnění do cílové úrovně S: S − dispoziční zásoba |
| Interval mezi objednávkami | proměnlivý | pevný |
| Sledování stavu zásob | průběžné (po každém výdeji) | jen v kontrolních okamžicích |
| Pojistná zásoba kryje | výkyvy během dodací lhůty L | výkyvy během T + L (proto je vyšší) |
| Vhodný zejména pro | drahé položky skupiny A, nepravidelnou spotřebu | mnoho položek od jednoho dodavatele, sdružené objednávky, položky C |

Cílová (maximální) úroveň S = očekávaná spotřeba za T + L + pojistná zásoba. Jednoduchou variantou Q-systému je **dvouzásobníkový systém**: po vyprázdnění první přihrádky se objedná a čerpá se z druhé.

### ? V systému (T, S) je cílová úroveň S = 1 200 ks. Při kontrole je na skladě 450 ks a 150 ks je objednáno, ale ještě nedodáno. Kolik se má objednat?

- [ ] 750 ks
- [x] 600 ks
- [ ] 900 ks
- [ ] 1 200 ks

> Objedná se S − dispoziční zásoba = 1 200 − (450 + 150) = 600 ks. Hodnota 750 ks zapomíná na již objednané množství, 900 ks ho chybně přičítá.

### ? Co platí pro systém s pevnou objednací úrovní (s, Q)?

- [x] Objednává se stejné množství v proměnlivých intervalech
- [ ] Objednává se v pevných intervalech proměnlivé množství
- [ ] Stav zásoby se kontroluje jen jednou za periodu
- [ ] Pojistná zásoba musí krýt periodu T i dodací lhůtu

> V systému (s, Q) spouští objednávku pokles na objednací bod; objednávané množství je pevné, interval se mění se spotřebou. Ostatní možnosti popisují systém (T, S).

### ? Proč systém s pevnou periodou (T, S) obvykle vyžaduje vyšší pojistnou zásobu než systém (s, Q)?

- [x] Musí krýt výkyvy spotřeby za periodu i za dodací lhůtu
- [ ] Objednává vždy větší množství než EOQ
- [ ] Dodavatelé v něm mají delší dodací lhůty
- [ ] Neumožňuje sledovat již objednané množství

> Mezi dvěma kontrolami se stav zásoby nesleduje, takže pojistná zásoba musí pokrýt nejistotu za celou dobu T + L. V systému (s, Q) stačí krýt jen dodací lhůtu L.

## Obrátka a doba obratu zásob {#obratka-zasob .explain}

Základní ukazatele efektivnosti vázání kapitálu v zásobách:

- **obrátka zásob** = roční spotřeba (resp. tržby) / průměrná zásoba — kolikrát se zásoba za rok „protočí",
- **doba obratu zásob** = průměrná zásoba / průměrná denní spotřeba = 360 / obrátka — na kolik dní spotřeby zásoba vystačí, resp. jak dlouho je v ní vázán kapitál.

Pro řízení zásob je přesnější čitatel ve stejném ocenění jako zásoby (spotřeba materiálu, náklady na prodané zboží); ve finanční analýze se z dostupnosti dat často používají tržby (téma 5). Průměrná zásoba se počítá alespoň jako průměr počátečního a konečného stavu, přesněji z měsíčních stavů. **Vyšší obrátka a kratší doba obratu** znamenají méně vázaného kapitálu, příliš nízké zásoby však ohrožují úroveň obsluhy. Ukazatele se hodnotí v čase, vůči odvětví a ideálně po skupinách položek.

*Příklad:* Roční spotřeba materiálu 36 mil. Kč, průměrná zásoba 3 mil. Kč → obrátka 12krát za rok, doba obratu 360 / 12 = 30 dní.

### ? Roční spotřeba materiálu je 48 mil. Kč, zásoba na počátku roku 5 mil. Kč a na konci roku 7 mil. Kč. Jaká je obrátka a doba obratu zásob (rok = 360 dní)?

- [ ] Přibližně 6,9krát, 52,5 dne
- [ ] 9,6krát, 37,5 dne
- [ ] 0,125krát, 2 880 dní
- [x] 8krát, 45 dní

> Průměrná zásoba = (5 + 7) / 2 = 6 mil. Kč; obrátka = 48 / 6 = 8; doba obratu = 360 / 8 = 45 dní. Ostatní výsledky používají jen konečný či počáteční stav nebo převrácený poměr.

### ? Průměrná denní spotřeba materiálu je 150 tis. Kč. Doba obratu zásob se zkrátí ze 40 na 30 dní. Kolik kapitálu se uvolní ze zásob?

- [ ] 4,5 mil. Kč
- [ ] 150 tis. Kč
- [x] 1,5 mil. Kč
- [ ] 6 mil. Kč

> Průměrná zásoba = denní spotřeba × doba obratu: 150 · 40 = 6 mil. Kč, po změně 150 · 30 = 4,5 mil. Kč. Uvolní se 150 · 10 = 1,5 mil. Kč.

## Úroveň obsluhy a další ukazatele efektivnosti {#uroven-obsluhy .explain}

Úroveň obsluhy (stupeň vyřízení, service level) měří, jak zásoby plní svou hlavní funkci — uspokojit poptávku. Nejčastěji se používá:

- **α — cyklová úroveň obsluhy** = podíl cyklů doplnění, v nichž nedošlo k vyčerpání zásoby,
- **β — stupeň vyřízení podle množství** (fill rate) = množství dodané ihned ze zásoby / celkové požadované množství,
- **stupeň vyřízení objednávek** = počet včas a úplně vyřízených objednávek / počet všech objednávek.

Dalšími ukazateli jsou obrátka a doba obratu, podíl nepohyblivých (neprodejných) zásob a náklady na zásoby v poměru k jejich hodnotě. Úroveň obsluhy a náklady jsou v protikladu: s blížícím se 100 % roste potřebná pojistná zásoba stále rychleji.

*Příklad:* Ze 2 000 objednávek bylo 1 880 vyřízeno včas a úplně → stupeň vyřízení objednávek 1 880 / 2 000 = 94 %.

### ? Během roku proběhlo 20 cyklů doplnění, ve 2 z nich došlo k vyčerpání zásoby a celkem zůstalo neuspokojeno 1 % požadovaného množství. Jaké jsou úrovně obsluhy α a β?

- [ ] α = 99 %, β = 90 %
- [x] α = 90 %, β = 99 %
- [ ] α = 10 %, β = 1 %
- [ ] α = 90 %, β = 1 %

> α = cykly bez výpadku / všechny cykly = 18 / 20 = 90 %; β = uspokojené množství / požadované = 99 %. Krátké výpadky ve dvou cyklech postihly jen malou část poptávky.

### ? Směrodatná odchylka spotřeby za dodací lhůtu je 100 ks. Podnik chce zvýšit úroveň obsluhy z 95 % (k = 1,65) na 99 % (k = 2,33). O kolik vzroste pojistná zásoba?

- [ ] O 4 ks
- [ ] O 233 ks
- [x] O 68 ks
- [ ] O 4 %

> PZ = k · σ_L: 1,65 · 100 = 165 ks → 2,33 · 100 = 233 ks, tedy o 68 ks (asi o 41 %). Zvýšení obsluhy o 4 procentní body stojí neúměrně více zásob.

## ABC analýza {#abc-analyza .explain}

ABC analýza třídí položky zásob podle jejich podílu na **celkové roční hodnotě spotřeby** (množství × cena), aby se řídicí úsilí soustředilo tam, kde je vázáno nejvíce kapitálu. Vychází z **Paretova pravidla**: malý počet položek představuje většinu hodnoty. Postup:

1. pro každou položku spočítat roční hodnotu spotřeby,
2. seřadit položky sestupně podle této hodnoty,
3. spočítat podíly a kumulativní podíly na hodnotě i na počtu položek (graficky Lorenzova křivka),
4. stanovit hranice skupin a položky zařadit.

Typické (orientační) podíly: **A** ≈ 10–20 % položek a 70–80 % hodnoty, **B** ≈ 20–40 % položek a 15–20 % hodnoty, **C** ≈ 40–70 % položek a 5–10 % hodnoty. Položky **A** se řídí individuálně a přesně (časté menší dodávky, EOQ, průběžné sledování, JIT, vyjednávání s dodavateli), **C** zjednodušeně (větší zásoby, méně časté objednávky, systém (T, S) nebo dvouzásobníkový systém), **B** na střední úrovni.

*Příklad:* Sklad má 1 000 položek; 150 nejhodnotnějších z nich (15 % položek) představuje 75 % roční hodnoty spotřeby — tvoří skupinu A.

### ? Deset položek má roční hodnotu spotřeby (tis. Kč): 500, 250, 100, 50, 40, 25, 15, 10, 6, 4 (celkem 1 000). Do A patří položky do kumulace 75 % hodnoty včetně, do B do 95 % včetně, ostatní do C. Jak vypadá rozdělení?

- [ ] A 1, B 4, C 5 položek
- [ ] A 2, B 4, C 4 položky
- [ ] A 3, B 2, C 5 položek
- [x] A 2, B 3, C 5 položek

> Kumulace: 50 %, 75 % (A); 85 %, 90 %, 94 % (B); šestá položka by kumulaci zvýšila na 96,5 %, proto od ní začíná C. Skupina A: 20 % položek a 75 % hodnoty.

### ? Podle jakého kritéria se položky v ABC analýze zásob řadí?

- [ ] Podle počtu spotřebovaných kusů za rok
- [x] Podle roční hodnoty spotřeby (množství × cena)
- [ ] Podle jednotkové pořizovací ceny položky
- [ ] Podle počtu objednávek za rok

> Rozhoduje kapitál, který položka váže, tedy množství × cena. Levná položka spotřebovávaná ve velkém množství může patřit do A, drahá s minimální spotřebou do C.

### ? Pro kterou skupinu podle ABC analýzy se nejvíce hodí dvouzásobníkový systém a vyšší zásoby s méně častými objednávkami?

- [ ] Pro skupinu A
- [ ] Pro skupinu B
- [x] Pro skupinu C
- [ ] Pro všechny skupiny stejně

> Položky C jsou početné, ale málo hodnotné; podrobné řízení by stálo víc, než by ušetřilo. Vyšší zásoba u nich váže jen málo kapitálu.

## XYZ analýza {#xyz-analyza .term}

XYZ analýza třídí položky podle **pravidelnosti a předvídatelnosti spotřeby**, obvykle podle variačního koeficientu spotřeby (σ / průměr): **X** — stabilní spotřeba s přesnou předpovědí, **Y** — kolísavá spotřeba (trend, sezónnost), **Z** — nepravidelná, sporadická a špatně předvídatelná spotřeba; hranice skupin si podnik stanovuje sám. Kombinuje se s ABC analýzou do matice 3 × 3 — např. položky **AX** jsou vhodné pro JIT, položky **AZ** vyžadují individuální řízení, často nákup až podle konkrétní potřeby.

### ? Náhradní díl se spotřebovává sporadicky, několikrát ročně v nepředvídatelných množstvích. Do které skupiny XYZ patří?

- [ ] X
- [x] Z
- [ ] Y
- [ ] A

> Nepravidelná a špatně předvídatelná spotřeba odpovídá skupině Z. Písmeno A patří ABC analýze, která hodnotí hodnotu, ne pravidelnost spotřeby.

### ? Které položky jsou podle kombinace ABC a XYZ nejvhodnější pro dodávky systémem JIT?

- [x] AX — vysoká hodnota a stabilní spotřeba
- [ ] CZ — nízká hodnota a sporadická spotřeba
- [ ] AZ — vysoká hodnota a sporadická spotřeba
- [ ] CX — nízká hodnota a stabilní spotřeba

> JIT přináší největší úsporu u hodnotných položek (A) a spoléhá na dobře plánovatelnou spotřebu (X). U položek C je úspora malá, u Z nelze dodávky spolehlivě plánovat.

## Just in Time (JIT) {#jit .explain}

Just in Time („právě včas") je koncepce, podle níž se materiál a díly dodávají **přesně v potřebném množství, kvalitě a čase** tam, kde jsou potřeba — ideálně přímo na výrobní linku, bez meziskladování. Vznikla v Toyotě (Taiiči Óno) jako součást Toyota Production System; zásoby považuje za **plýtvání**, které zakrývá problémy. Řízení je **tahové** (pull): impuls k dodávce dává skutečná spotřeba následujícího stupně, ne plán „tlačený" dopředu. Nástrojem tahového řízení je **kanban** (podrobně v tématu 8 — Výrobní činnost). **Předpoklady:** vyrovnaná a stabilní výroba, malé dávky a krátké přestavby (SMED), vysoká a stabilní kvalita (nulové vady), spolehliví a blízcí dodavatelé v dlouhodobém partnerství, rychlé sdílení informací (EDI) a spolehlivá doprava.

*Příklad:* Dodavatel sedadel dodává do automobilky sedadla několikrát denně, a to v pořadí, v jakém se vozy montují (varianta JIS — just in sequence).

### ? Který z uvedených faktorů NENÍ předpokladem úspěšného zavedení JIT?

- [ ] Spolehliví dodavatelé v dlouhodobém partnerství
- [x] Velké dodávky s množstevní slevou a skladem u odběratele
- [ ] Vysoká a stabilní kvalita dodávaných dílů
- [ ] Vyrovnaná výroba a krátké přestavby

> JIT stojí na malých, častých dodávkách bez skladování u odběratele. Velké dávky kvůli slevám jsou typické pro klasický nákup, ne pro JIT.

### ? Co znamená, že JIT je tahový (pull) systém?

- [ ] Výroba se řídí prognózou a hotové výrobky se tlačí na sklad
- [ ] Dodavatel dodává podle svého výrobního plánu
- [ ] Zásoby se doplňují vždy jednou za pevnou periodu
- [x] Dodávku spouští skutečná spotřeba následujícího stupně

> V tahovém systému si následující stupeň „táhne" materiál podle své skutečné spotřeby. Výroba podle prognózy a plánu na sklad je naopak tlačný (push) princip.

## Přínosy a rizika JIT {#jit-prinosy-rizika .compare}

| Přínosy | Rizika a nevýhody |
|---|---|
| nižší zásoby a méně vázaného kapitálu | silná závislost na spolehlivosti dodavatelů a dopravy |
| menší skladové plochy a nižší skladovací náklady | výpadek jedné dodávky může zastavit celou výrobu (povodeň, stávka, pandemie, nedostatek čipů) |
| odhalení skrytých problémů — nízké zásoby nezakrývají vady, prostoje a nespolehlivost | vyšší četnost přeprav, dopravní náklady a zátěž infrastruktury |
| vyšší kvalita a kratší průběžná doba výroby | zásoby se často jen přesunou k dodavateli |
| rychlejší reakce na změny poptávky | náročné zavedení — změna kultury, partnerství, informační propojení |

Toyota přirovnává zásoby k vodě v řece: vysoká hladina zakryje kameny (problémy), snížení hladiny je odhalí, a tím donutí je odstranit.

### ? Povodeň u jediného dodavatele zastaví na tři dny montážní linku automobilky pracující systémem JIT. Které riziko JIT se projevilo?

- [ ] Vysoké náklady na vázaný kapitál v zásobách
- [ ] Odhalení skrytých problémů ve výrobě
- [x] Závislost na spolehlivosti dodávek bez zásob
- [ ] Nedostatek skladových ploch u odběratele

> JIT pracuje téměř bez zásob, takže výpadek dodávky nemá co vyrovnat a linka se zastaví. Vázaný kapitál je naopak u JIT nízký.

### ? Jak vysvětluje filozofie JIT přínos snižování zásob pro zlepšování procesů?

- [x] Nízké zásoby odhalí problémy, které vysoké zásoby zakrývají
- [ ] Nižší zásoby automaticky zvyšují kvalitu dodávek
- [ ] Bez zásob odpadá potřeba plánování výroby
- [ ] Nízké zásoby umožní nakupovat s vyššími slevami

> Podle přirovnání k vodě v řece snížená „hladina" zásob ukáže „kameny" — vady, prostoje a nespolehlivé dodávky —, které je pak nutné odstranit.

## MRP — plánování potřeby materiálu {#mrp .explain}

MRP (Material Requirements Planning; J. Orlicky, 60.–70. léta 20. století) plánuje položky se **závislou poptávkou** — potřeba součástí a materiálu se odvozuje z plánu výroby finálních výrobků, ne z prognózy. **Vstupy:** hlavní plán výroby (MPS — co a kdy vyrobit), kusovník (BOM — z čeho se výrobek skládá) a stav zásob včetně objednaných dodávek. **Výpočet:** hrubá potřeba = plán × počet kusů v kusovníku; čistá potřeba = hrubá potřeba − skladová zásoba − objednané dodávky (případně + pojistná zásoba); termín objednávky se posune zpět o dodací nebo výrobní lhůtu. MRP II (Manufacturing Resource Planning) přidává plánování kapacit a financí a je předchůdcem systémů ERP. Pro nezávislou poptávku (hotové výrobky, náhradní díly pro trh) se naopak používají prognózy a modely jako EOQ či systémy (s, Q) a (T, S).

*Příklad:* Plán je 100 jízdních kol, každé má 2 ráfky → hrubá potřeba 200 ráfků; na skladě je 50 → čistá potřeba 150 ráfků, objednají se s předstihem rovným dodací lhůtě.

### ? Výrobek obsahuje 4 kusy součásti S. Plán výroby je 250 výrobků, na skladě je 300 ks S a dalších 100 ks je objednáno. Jaká je čistá potřeba součásti S?

- [ ] 1 000 ks
- [ ] 700 ks
- [x] 600 ks
- [ ] Žádná, zásoba stačí

> Hrubá potřeba = 250 · 4 = 1 000 ks; čistá = 1 000 − 300 − 100 = 600 ks. Hodnota 700 ks pomíjí objednané dodávky; bez kusovníku by se zdálo, že zásoba stačí.

### ? Pro kterou položku je plánování metodou MRP typicky vhodné?

- [ ] Hotové výrobky prodávané na volném trhu
- [x] Komponenty montované do vyráběného výrobku
- [ ] Náhradní díly prodávané servisům
- [ ] Zboží v maloobchodní prodejně

> MRP řeší závislou poptávku, kterou lze přesně odvodit z plánu výroby a kusovníku — typicky komponenty. Ostatní položky mají nezávislou poptávku, kterou je nutné předpovídat.

## Řízení dodavatelského řetězce (SCM) {#scm .explain}

**Dodavatelský řetězec** (supply chain) je síť organizací a činností od získání surovin přes výrobce, distributory a obchodníky až ke konečnému zákazníkovi; procházejí jím toky materiálu, informací a peněz. **Řízení dodavatelského řetězce** (Supply Chain Management, SCM) koordinuje a **integruje** tyto toky napříč firmami tak, aby řetězec jako celek dosáhl požadované úrovně obsluhy konečného zákazníka při nejnižších celkových nákladech a zásobách — místo optimalizace každého článku zvlášť. Klíčové je **sdílení informací** (prodeje konečným zákazníkům, stavy zásob, prognózy, plány), dlouhodobé partnerství a společné plánování, např. CPFR (Collaborative Planning, Forecasting and Replenishment). Při **VMI** (Vendor Managed Inventory, zásoby řízené dodavatelem) dodavatel sleduje stav zásob a prodeje u odběratele a sám rozhoduje o termínu a velikosti doplnění v dohodnutých mezích (minimum–maximum); VMI se často kombinuje s konsignačním skladem, kde zboží zůstává ve vlastnictví dodavatele až do odběru.

*Příklad:* Výrobce nápojů denně vidí stavy zásob a prodeje v distribučních centrech obchodního řetězce a sám plánuje jejich závozy; řetězec už objednávky nevystavuje.

### ? Co je podstatou VMI (Vendor Managed Inventory)?

- [ ] Odběratel objednává podle prognózy, kterou mu zašle dodavatel
- [ ] Dodavatel drží zásobu ve svém skladu a dodává na výzvu
- [ ] Odběratel řídí zásoby u svého dodavatele surovin
- [x] Dodavatel sám rozhoduje o doplnění zásob odběratele

> Při VMI přebírá rozhodování o doplnění dodavatel na základě sdílených údajů o zásobách a prodejích odběratele, v dohodnutých mezích minima a maxima.

### ? Které tvrzení nejlépe vystihuje princip řízení dodavatelského řetězce?

- [ ] Každý článek minimalizuje své zásoby nezávisle na ostatních
- [x] Řetězec se optimalizuje jako celek se sdílením informací
- [ ] Odběratel přenese všechny zásoby na své dodavatele
- [ ] Podnik volí vždy dodavatele s nejnižší cenou

> SCM integruje toky napříč firmami; součet lokálních optim (každý minimalizuje své zásoby) zpravidla nedává optimum řetězce. Přesun zásob na dodavatele náklady řetězce nesnižuje.

## Efekt biče (bullwhip effect) {#bullwhip .explain}

Efekt biče (bullwhip effect, též Forresterův efekt) je **zesilování výkyvů objednávek směrem proti proudu řetězce** — od maloobchodu k velkoobchodu, výrobci a jeho dodavatelům: malé kolísání poptávky konečných zákazníků vyvolá stále větší výkyvy objednávek a zásob u vzdálenějších článků. Lee, Padmanabhan a Whang (1997) uvádějí čtyři hlavní **příčiny**: 1) každý článek aktualizuje prognózu podle objednávek svého odběratele, ne podle konečné poptávky, 2) objednávání ve velkých dávkách, 3) kolísání cen (akce, slevy → předzásobení), 4) přidělování při nedostatku a „hra na nedostatek" (nadsazené objednávky). Efekt zesilují dlouhé dodací lhůty a větší počet článků. **Omezení:** sdílení údajů o konečné poptávce (data z pokladen, POS) s celým řetězcem, VMI a CPFR, menší a častější dávky, stabilní ceny (EDLP — trvale nízké ceny místo akcí), přidělování při nedostatku podle minulých odběrů, zkracování dodacích lhůt.

*Příklad:* Procter & Gamble zjistil, že spotřeba plenek Pampers je velmi stabilní, ale objednávky distributorů a jeho vlastní nákupy surovin silně kolísaly.

### ? Který z uvedených faktorů NENÍ příčinou efektu biče?

- [ ] Objednávání ve velkých dávkách
- [ ] Časté cenové akce vedoucí k předzásobení
- [x] Sdílení údajů z pokladen s celým řetězcem
- [ ] Nadsazené objednávky při hrozícím nedostatku

> Sdílení údajů o konečné poptávce (POS) efekt biče naopak tlumí, protože všichni články plánují podle skutečné spotřeby, ne podle zkreslených objednávek.

### ? Ve kterém článku dodavatelského řetězce jsou při efektu biče výkyvy objednávek největší?

- [x] U nejvzdálenějšího dodavatele surovin
- [ ] U maloobchodníka nejblíže zákazníkovi
- [ ] U velkoobchodu uprostřed řetězce
- [ ] Ve všech článcích jsou výkyvy stejné

> Výkyvy se zesilují proti proudu řetězce, takže jsou nejsilnější u článků nejvzdálenějších od konečného zákazníka.

### ? Výrobce pořádá časté cenové akce a distributoři se při nich vždy předzásobí. Které opatření efekt biče nejlépe omezí?

- [ ] Prodloužení dodacích lhůt
- [ ] Objednávání ve větších dávkách
- [ ] Přidělování podle aktuálních objednávek
- [x] Stabilní ceny bez akcí (EDLP)

> Příčinou je kolísání cen; trvale nízké ceny (EDLP) odstraní motiv k předzásobení. Delší lhůty a větší dávky efekt naopak zesilují.
