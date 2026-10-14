---
kind: topic
subject: manazerska-ekonomie
slug: cenova-hladina-a-mira-inflace
name: "Cenová hladina a míra inflace"
order: 6
---

Cenové indexy a jejich vypovídací schopnost. Inflace a její důsledky. Cenové rigidity.

## Cenová hladina a cenový index {#cenovy-index .term}

**Cenová hladina** P je vážený průměr cen statků a služeb v ekonomice. Měří se **cenovým indexem**, který porovnává cenu určitého koše statků v běžném období s jeho cenou v základním období, jemuž se přiřadí hodnota 100. **Bazický index** se vztahuje k pevnému základu (např. průměr určitého roku = 100), **řetězový index** vždy k předchozímu období.

### ? Bazický CPI (základní rok = 100) dosáhl v určitém roce hodnoty 140. Co z toho plyne?

- [ ] Ceny vzrostly od základního roku o 140 %
- [ ] Průměrná roční míra inflace byla 40 %
- [x] Cenová hladina je o 40 % vyšší než v základním roce
- [ ] Ceny v daném roce vzrostly meziročně o 40 %

> Bazický index 140 vůči základu 100 znamená růst cenové hladiny o (140 − 100) / 100 = 40 % za celé období od základního roku, nikoli za jediný rok.

## Laspeyresův a Paascheho cenový index {#laspeyres-paasche .explain}

Oba indexy měří změnu ceny koše statků mezi základním obdobím 0 a běžným obdobím t; liší se tím, **čí množství** použijí jako váhy:

- **Laspeyresův index** `P_L = Σ pₜ · q₀ / Σ p₀ · q₀` — množství ze **základního** období, koš je pevný.
- **Paascheho index** `P_P = Σ pₜ · qₜ / Σ p₀ · qₜ` — množství z **běžného** období, koš se každé období mění.
- **Fisherův („ideální") index** je geometrický průměr obou: `P_F = √(P_L · P_P)`.

Výsledek se obvykle násobí 100. Laspeyresův index je prakticky snazší, protože nevyžaduje aktuální údaje o spotřebovaných množstvích.

*Příklad:* Chléb: p₀ = 30 Kč, q₀ = 10, pₜ = 33 Kč, qₜ = 10. Benzin: p₀ = 40 Kč, q₀ = 5, pₜ = 50 Kč, qₜ = 4. Laspeyres = (33 · 10 + 50 · 5) / (30 · 10 + 40 · 5) = 580 / 500 = 1,16 → 116. Paasche = (33 · 10 + 50 · 4) / (30 · 10 + 40 · 4) = 530 / 460 ≈ 1,152 → 115,2.

### ? Statek A: p₀ = 10, q₀ = 5, pₜ = 12, qₜ = 4. Statek B: p₀ = 20, q₀ = 10, pₜ = 22, qₜ = 12. Jaká je hodnota Laspeyresova cenového indexu?

- [ ] 111,4
- [ ] 115,0
- [ ] 124,8
- [x] 112,0

> P_L = (12 · 5 + 22 · 10) / (10 · 5 + 20 · 10) = 280 / 250 = 1,12 → 112. Hodnota 111,4 je Paascheho index (312 / 280), 115 prostý průměr cenových relativů (1,2 a 1,1) a 124,8 poměr nominálních výdajů (312 / 250).

### ? Statek X: p₀ = 5, q₀ = 30, pₜ = 6, qₜ = 15. Statek Y: p₀ = 10, q₀ = 10, pₜ = 11, qₜ = 12. Jaká je hodnota Paascheho cenového indexu (zaokrouhleno)?

- [ ] 116,0
- [x] 113,8
- [ ] 115,0
- [ ] 87,8

> P_P = (6 · 15 + 11 · 12) / (5 · 15 + 10 · 12) = 222 / 195 ≈ 1,138 → 113,8. Hodnota 116 je Laspeyresův index (290 / 250), 115 prostý průměr cenových relativů a 87,8 převrácený poměr (195 / 222).

## Laspeyresův vs. Paascheho index {#laspeyres-vs-paasche .compare}

Rozdílné váhy vedou k opačnému zkreslení vůči skutečnému růstu životních nákladů:

| | Laspeyresův index | Paascheho index |
|---|---|---|
| Váhy (množství) | základní období q₀ | běžné období qₜ |
| Koš | pevný | proměnlivý |
| Substituce spotřebitelů mezi statky | nezachycuje | zachycuje (ex post) |
| Zkreslení vůči životním nákladům | **nadhodnocuje** růst cen | **podhodnocuje** růst cen |
| Náročnost na data | nízká — stačí zjišťovat nové ceny | vysoká — nutná aktuální množství |
| Typické použití | CPI, HICP, PPI | deflátor HDP |

### ? Cena hovězího prudce vzroste a spotřebitelé přejdou na kuřecí. Který index tento přesun zachytí a jak vyjde ve srovnání s druhým?

- [x] Paascheho index; vyjde nižší než Laspeyresův
- [ ] Laspeyresův index; vyjde nižší než Paascheho
- [ ] Paascheho index; vyjde vyšší než Laspeyresův
- [ ] Fisherův index; vyjde vyšší než oba ostatní

> Paascheho index váží množstvími běžného období, takže už počítá s větším nákupem levnějšího kuřecího a vyjde nižší. Laspeyresův index s pevným košem růst cen nadhodnocuje. Fisherův index leží vždy mezi nimi.

### ? Proč se pro měsíční CPI používá index laspeyresovského typu, přestože nadhodnocuje růst životních nákladů?

- [ ] Protože jako jediný zachycuje substituci mezi statky
- [ ] Protože jako jediný zahrnuje dovážené statky
- [x] Protože stačí zjišťovat ceny, váhy jsou předem známé
- [ ] Protože vždy vychází nižší než Paascheho index

> Laspeyresův index pracuje s pevnými váhami ze základního období, takže každý měsíc stačí sebrat ceny. Substituci naopak nezachycuje a obvykle vychází vyšší než Paascheho index.

## Index spotřebitelských cen (CPI) {#cpi .explain}

Index spotřebitelských cen (Consumer Price Index, CPI) měří změnu cen **spotřebního koše** zboží a služeb, které kupují domácnosti. V ČR ho měsíčně sestavuje **ČSÚ**: ceny reprezentantů se zjišťují cenovým šetřením v prodejnách a provozovnách a agregují se pomocí **stálých vah** podle struktury spotřebních výdajů domácností — jde tedy o index **laspeyresovského typu**. Koš obsahuje i **dovážené** spotřební statky, regulované ceny (energie, nájemné) a **imputované nájemné** (náklady vlastnického bydlení). Na CPI je navázán **inflační cíl ČNB**: 2 % s tolerančním pásmem ±1 procentní bod. Váhy se pravidelně aktualizují, aby koš odpovídal měnící se spotřebě.

*Příklad:* Skupina „potraviny a nealkoholické nápoje" má váhu 0,20. Pokud její ceny vzrostou o 10 % a ostatní ceny se nezmění, CPI vzroste přibližně o 0,20 · 10 % = 2 %.

### ? Váha skupiny bydlení a energie v koši je 0,25. Ceny této skupiny vzrostou o 8 %, ostatní ceny se nezmění. O kolik přibližně vzroste CPI?

- [ ] O 8 %
- [x] O 2 %
- [ ] O 0,25 %
- [ ] O 6 %

> Příspěvek skupiny k růstu CPI = váha · změna cen = 0,25 · 8 % = 2 %. 8 % je růst cen samotné skupiny; 6 % by vzniklo chybným použitím váhy ostatních položek (0,75 · 8 %).

### ? Ke kterému cenovému indexu je vztažen inflační cíl ČNB?

- [ ] K deflátoru HDP
- [ ] K indexu cen průmyslových výrobců
- [ ] K harmonizovanému indexu HICP
- [x] K indexu spotřebitelských cen (CPI)

> ČNB cílí meziroční růst CPI ve výši 2 % s tolerančním pásmem ±1 p. b. HICP je referenčním indexem ECB a maastrichtského kritéria.

## CPI vs. HICP {#cpi-vs-hicp .compare}

**Harmonizovaný index spotřebitelských cen** (Harmonised Index of Consumer Prices, HICP) sestavují statistické úřady zemí EU podle jednotné metodiky **Eurostatu**, aby byla inflace mezi státy srovnatelná. Oba indexy jsou laspeyresovského typu.

| | CPI (ČSÚ) | HICP |
|---|---|---|
| Metodika | národní | jednotná v celé EU (Eurostat) |
| Vlastnické bydlení (imputované nájemné) | zahrnuje | nezahrnuje |
| Hlavní použití | inflační cíl ČNB, domácí smlouvy a analýzy | inflační cíl ECB (2 % ve střednědobém horizontu), maastrichtské kritérium cenové stability, mezinárodní srovnání |

### ? Kterým indexem se posuzuje plnění maastrichtského kritéria cenové stability při přijetí eura?

- [x] HICP podle metodiky Eurostatu
- [ ] CPI podle metodiky ČSÚ
- [ ] Deflátorem HDP za eurozónu
- [ ] Indexem cen výrobců (PPI)

> Konvergenční kritérium cenové stability se hodnotí harmonizovaným indexem HICP: inflace nesmí o více než 1,5 p. b. převýšit průměr tří členských států s nejnižší inflací.

### ? Ceny nového bydlení výrazně rostou. Ve kterém indexu se to přímo projeví prostřednictvím nákladů vlastnického bydlení?

- [ ] Pouze v HICP
- [ ] V obou indexech stejně
- [x] V CPI, ne však v HICP
- [ ] Pouze v indexu cen výrobců

> Národní CPI zahrnuje imputované nájemné, které odráží náklady vlastnického bydlení; HICP tuto položku neobsahuje.

## Deflátor HDP {#deflator-hdp .explain}

Deflátor HDP je poměr nominálního a reálného HDP: `deflátor = nominální HDP / reálný HDP · 100`. Reálný HDP je oceněn ve stálých cenách základního roku, takže deflátor měří změnu cen **všech statků vyrobených v ekonomice** (spotřeba, investice, vládní nákupy, vývoz), nikoli jen spotřebního koše. Protože nominální i reálný HDP používají množství **běžného** roku, má deflátor povahu **Paascheho** indexu. Ceny **dovozu** nezahrnuje, protože dovoz není součástí domácí produkce. Míra inflace měřená deflátorem je procentní změna deflátoru.

*Příklad:* Nominální HDP je 6 600 mld. Kč, reálný HDP v cenách základního roku 6 000 mld. Kč → deflátor = 6 600 / 6 000 · 100 = 110; ceny domácí produkce jsou o 10 % vyšší než v základním roce.

### ? V základním roce byl nominální i reálný HDP 5 000 mld. Kč. V následujícím roce je nominální HDP 5 610 mld. Kč a reálný HDP 5 100 mld. Kč. Jaká je míra inflace měřená deflátorem HDP?

- [ ] 12,2 %
- [ ] 2,0 %
- [x] 10,0 %
- [ ] 14,2 %

> Deflátor = 5 610 / 5 100 · 100 = 110 (v základním roce 100), inflace je tedy 10 %. 12,2 % je růst nominálního HDP a 2 % růst reálného HDP; přibližně platí růst nominálního HDP ≈ růst reálného HDP + inflace.

### ? Proč se deflátor HDP řadí k indexům Paascheho typu?

- [ ] Protože používá pevný koš ze základního roku
- [x] Protože váží ceny množstvími běžného roku
- [ ] Protože zahrnuje i ceny dovážených statků
- [ ] Protože se počítá z cen očištěných o DPH

> Nominální i reálný HDP ocení stejná množství běžného roku — jednou běžnými, jednou základními cenami. To odpovídá Paascheho indexu s proměnlivými váhami.

## CPI, deflátor HDP a index cen výrobců (PPI) {#cpi-deflator-ppi .compare}

**Index cen výrobců** (Producer Price Index, PPI) měří ceny, za které výrobci prodávají svou produkci (ČSÚ sleduje ceny průmyslových a zemědělských výrobců, stavebních prací a tržních služeb), bez DPH. Zachycuje ceny v dřívější fázi výrobního řetězce, a proto bývá **předstihovým ukazatelem** vývoje spotřebitelských cen.

| | CPI | Deflátor HDP | PPI |
|---|---|---|---|
| Pokrytí | spotřební zboží a služby kupované domácnostmi, včetně dovozu | veškerá domácí produkce (C, I, G, NX), bez dovozu | produkce domácích výrobců v prvním stupni prodeje |
| Váhy | pevné (Laspeyres) | běžného roku (Paasche) | pevné (Laspeyres) |
| Frekvence | měsíčně | čtvrtletně (z národních účtů) | měsíčně |
| Typické použití | inflační cíl ČNB, valorizace | převod nominálního HDP na reálný | signál nákladových tlaků |

### ? Zdraží dovážené automobily kupované domácnostmi. Jak se to přímo projeví?

- [ ] Vzroste deflátor HDP, CPI se nezmění
- [ ] Vzrostou oba indexy stejně
- [ ] Nezmění se ani CPI, ani deflátor HDP
- [x] Vzroste CPI, deflátor HDP se nezmění

> Dovážené auto je ve spotřebním koši, a proto se promítne do CPI. Deflátor HDP měří jen ceny domácí produkce, dovoz nezahrnuje.

### ? Který index zachycuje ceny všech složek domácí produkce včetně investic, vládních nákupů a vývozu?

- [x] Deflátor HDP
- [ ] Index spotřebitelských cen
- [ ] HICP
- [ ] Index cen výrobců

> Deflátor HDP pokrývá veškerou domácí produkci. CPI a HICP měří jen spotřební koš domácností, PPI ceny výrobců v prvním stupni prodeje, nikoli např. vládní služby.

### ? Proč se růst indexu cen výrobců sleduje jako signál budoucího vývoje CPI?

- [ ] Protože PPI obsahuje stejný koš jako CPI
- [ ] Protože PPI na rozdíl od CPI zahrnuje DPH
- [x] Protože vyšší ceny výrobců se se zpožděním přenášejí do spotřebitelských cen
- [ ] Protože PPI je Paascheho index s běžnými váhami

> PPI měří ceny v dřívější fázi řetězce; dražší vstupy a meziprodukty se postupně promítají do cen pro spotřebitele. PPI je navíc bez DPH a má pevné váhy.

## Zkreslení cenových indexů a Boskinova komise {#zkresleni-indexu .explain}

CPI měří změnu ceny **pevného koše**, nikoli přesně změnu **životních nákladů** (nákladů na dosažení stejného užitku), a proto jejich růst obvykle **nadhodnocuje**. **Boskinova komise** (1996, pro Senát USA) odhadla, že americký CPI nadhodnocoval inflaci přibližně o **1,1 procentního bodu ročně** (pravděpodobné rozpětí 0,8–1,6 p. b.). Zdroje zkreslení:

- **substituční zkreslení** — spotřebitelé nahrazují zdražující statky relativně levnějšími, pevný koš to nezachytí;
- **změna místa nákupu** (outlet substitution) — přesun nákupů do levnějších prodejen (diskonty, hypermarkety) se neprojeví jako pokles ceny;
- **změny kvality** — část růstu ceny je platbou za vyšší kvalitu, ne čistým zdražením;
- **nové produkty** — do koše vstupují se zpožděním, takže index nezachytí pokles jejich cen v raném období ani přínos širší nabídky.

Statistici zkreslení zmírňují častější aktualizací vah, geometrickým průměrem na nejnižší úrovni agregace a hedonickými metodami očišťování o změny kvality.

*Příklad:* Pokud se důchody valorizují podle indexu, který nadhodnocuje růst životních nákladů o 1 p. b. ročně, jejich reálná hodnota ve skutečnosti každý rok mírně roste a veřejné výdaje jsou vyšší, než by odpovídalo udržení kupní síly.

### ? Domácnosti začnou ve velkém nakupovat v diskontních prodejnách, kde je stejné zboží levnější. Jak se nazývá zkreslení, když to CPI nezachytí?

- [ ] Substituční zkreslení mezi statky
- [ ] Zkreslení ze zlepšení kvality produktů
- [x] Zkreslení ze změny místa nákupu
- [ ] Zkreslení z nových produktů v koši

> Jde o tzv. outlet substitution bias: stejný statek je k dispozici levněji v jiném typu prodejny, ale index to jako pokles ceny nezaznamená. Substituční zkreslení se týká přechodu na jiný statek.

### ? Jakým směrem podle Boskinovy komise zkresloval americký CPI míru inflace a přibližně o kolik?

- [x] Nadhodnocoval ji asi o 1,1 p. b. ročně
- [ ] Podhodnocoval ji asi o 1,1 p. b. ročně
- [ ] Nadhodnocoval ji asi o 11 p. b. ročně
- [ ] Podhodnocoval ji méně než o 0,1 p. b. ročně

> Komise došla k nejpravděpodobnějšímu odhadu nadhodnocení o 1,1 p. b. ročně, hlavně kvůli substituci, změnám kvality a novým produktům.

### ? Nový model telefonu stojí stejně jako předchozí, ale má dvojnásobný výkon. Co by měl korektně měřený cenový index ukázat?

- [ ] Nulovou změnu, protože se cena nezměnila
- [ ] Růst ceny, protože jde o nový produkt
- [ ] Vyřazení telefonů z koše jako nesrovnatelných
- [x] Pokles ceny očištěné o změnu kvality

> Za stejnou cenu spotřebitel dostane kvalitnější produkt, takže cena jednotky „kvality" klesla. Hedonické metody tento pokles zachytí; bez nich index inflaci nadhodnocuje.

## Míra inflace a její měření {#mira-inflace .explain}

**Inflace** je růst **cenové hladiny** (ne jednotlivé ceny), míra inflace je procentní změna cenového indexu: `π = (Pₜ − Pₜ₋₁) / Pₜ₋₁ · 100 %`. ČSÚ z CPI publikuje tyto ukazatele:

- **meziměsíční** změnu — index v daném měsíci vůči předchozímu měsíci;
- **meziroční** míru inflace — index v daném měsíci vůči **stejnému měsíci předchozího roku**;
- **míru inflace vyjádřenou přírůstkem průměrného ročního indexu** (průměrná roční míra inflace) — průměr indexů za posledních 12 měsíců vůči průměru za předchozích 12 měsíců.

Hodnota průměrné roční míry za prosinec tak udává inflaci za celý kalendářní rok (průměr roku vůči průměru předchozího roku).

*Příklad:* Bazický CPI byl v březnu 2024 135,0 a v březnu 2025 137,7 → meziroční míra inflace za březen 2025 = (137,7 − 135,0) / 135,0 = 2,7 / 135 = 2 %.

### ? Průměrný CPI vzrostl ze 120 na 126 bodů. Jaká je míra inflace?

- [ ] 6,0 %
- [ ] 4,8 %
- [x] 5,0 %
- [ ] 26,0 %

> π = (126 − 120) / 120 = 6 / 120 = 5 %. 6 % je rozdíl v bodech indexu, ne v procentech; 4,8 % vznikne dělením novou hodnotou (6 / 126) a 26 % je růst vůči základu 100.

### ? Průměr měsíčních bazických indexů CPI za rok 2024 je 128,0, za rok 2023 je 125,0. Index za prosinec 2024 je 129,6, za prosinec 2023 je 126,0. Jaká je průměrná roční míra inflace za rok 2024 podle metodiky ČSÚ?

- [x] 2,4 %
- [ ] 2,9 %
- [ ] 3,0 %
- [ ] 2,3 %

> Průměrná roční míra = 128,0 / 125,0 − 1 = 0,024 = 2,4 %. 2,9 % je meziroční míra za prosinec (129,6 / 126,0 − 1 ≈ 2,86 %), 3,0 % rozdíl bodů a 2,3 % chybné dělení novou hodnotou (3 / 128).

## Meziroční vs. průměrná roční míra inflace {#mezirocni-vs-prumerna .compare}

| | Meziroční míra inflace | Průměrná roční míra inflace |
|---|---|---|
| Co srovnává | cenovou hladinu v daném měsíci se stejným měsícem předchozího roku | průměrnou cenovou hladinu posledních 12 měsíců s průměrem předchozích 12 měsíců |
| Reakce na změny | rychlá — ukazuje aktuální vývoj | pomalá, vyhlazená — obrat se projeví se zpožděním |
| Sezónní výkyvy | eliminuje srovnáním stejných měsíců | eliminuje zprůměrováním |
| Typické použití | inflační cíl ČNB, hodnocení aktuálního vývoje | souhrnná inflace za kalendářní rok (údaj za prosinec), inflační doložky ve smlouvách |

### ? Inflace během roku prudce zpomaluje. Který ukazatel tento obrat zachytí dříve?

- [ ] Průměrná roční míra inflace
- [x] Meziroční míra inflace
- [ ] Oba ukazatele současně a stejně silně
- [ ] Bazický index se základem 2015 = 100

> Meziroční míra porovnává jen dva měsíce, a reaguje proto rychle. Průměrná roční míra v sobě ještě 12 měsíců nese starší vysoké hodnoty a obrat zachytí se zpožděním.

### ? V určitém roce byla průměrná roční míra inflace 10,7 %, ale meziroční inflace v prosinci jen 6,9 %. Co to znamená?

- [ ] Inflace během roku zrychlovala
- [ ] Jeden z údajů musí být chybný
- [ ] Cenová hladina během roku klesala
- [x] Inflace během roku zpomalovala

> Průměrná roční míra zahrnuje i vysoké meziroční přírůstky z počátku roku, prosincová meziroční hodnota ukazuje nižší aktuální tempo. Ceny přitom stále rostly, jen pomaleji (dezinflace).

## Poptávková vs. nákladová inflace {#poptavkova-nakladova .compare}

Podle příčiny se rozlišuje inflace tažená poptávkou a inflace tlačená náklady. Trvalá inflace je v dlouhém období podmíněna růstem peněžní zásoby rychlejším než růst produktu.

| | Poptávková inflace (demand-pull) | Nákladová inflace (cost-push) |
|---|---|---|
| Příčina | růst agregátní poptávky nad potenciál (expanzivní měnová či fiskální politika, boom spotřeby, investic nebo exportu) | růst nákladů — nabídkové šoky (ropa, energie, suroviny), růst mezd nad produktivitu, oslabení měny, vyšší nepřímé daně |
| Posun v modelu AD–AS | AD doprava | AS doleva |
| Produkt Y v krátkém období | roste | klesá |
| Nezaměstnanost | klesá | roste (**stagflace**) |
| Dilema hospodářské politiky | ne — restrikce tlumí inflaci i přehřátí | ano — boj s inflací prohlubuje pokles produktu |

### ? Prudce zdraží ropa na světových trzích. Jaký vývoj v krátkém období odpovídá tomuto typu inflace?

- [ ] Roste cenová hladina i produkt, klesá nezaměstnanost
- [x] Roste cenová hladina, klesá produkt, roste nezaměstnanost
- [ ] Klesá cenová hladina i produkt, roste nezaměstnanost
- [ ] Roste produkt i zaměstnanost, ceny se nemění

> Zdražení ropy je nákladový (nabídkový) šok: AS se posune doleva, ceny rostou a produkt klesá — stagflace. První možnost popisuje poptávkovou inflaci.

### ? Která situace je typickým zdrojem poptávkové inflace?

- [ ] Zvýšení sazby DPH o 2 p. b.
- [ ] Neúroda zvyšující ceny potravin
- [ ] Růst mezd nad růst produktivity
- [x] Silná fiskální expanze při plné zaměstnanosti

> Fiskální expanze v ekonomice na úrovni potenciálu posune AD doprava a táhne ceny vzhůru. Ostatní možnosti zvyšují náklady, jde tedy o nákladovou inflaci.

## Inflace podle tempa: mírná, pádivá, hyperinflace {#tempo-inflace .compare}

| Druh | Typické tempo | Charakteristika |
|---|---|---|
| **Mírná** (plíživá; creeping, moderate) | jednociferná roční míra | ceny jsou relativně stabilní, lidé důvěřují penězům, nominální smlouvy fungují |
| **Pádivá** (cválající; galloping) | dvojciferná až trojciferná roční míra | peníze rychle ztrácejí hodnotu, smlouvy se indexují nebo uzavírají v cizí měně, lidé utíkají do reálných aktiv |
| **Hyperinflace** | podle P. Cagana více než 50 % **měsíčně** | peníze přestávají plnit funkci uchovatele hodnoty i měřítka hodnoty, šíří se barter; příčinou bývá financování rozpočtu tiskem peněz (Německo 1923, Maďarsko 1946, Zimbabwe 2008) |

### ? Podle Caganovy definice nastává hyperinflace, když míra inflace přesáhne:

- [ ] 50 % ročně
- [ ] 100 % ročně
- [x] 50 % měsíčně
- [ ] 10 % měsíčně

> Cagan (1956) vymezil hyperinflaci jako období, kdy ceny rostou o více než 50 % za měsíc, což odpovídá zhruba 13 000 % ročně.

### ? Země má roční inflaci kolem 40 % a obyvatelé uzavírají větší smlouvy v eurech. O jaký druh inflace jde?

- [ ] Mírná inflace
- [x] Pádivá inflace
- [ ] Hyperinflace
- [ ] Dezinflace

> Dvojciferná roční inflace s únikem do cizí měny je typická pro pádivou inflaci. Hyperinflace vyžaduje růst cen přes 50 % měsíčně.

## Deflace vs. dezinflace {#deflace-dezinflace .compare}

| | Deflace | Dezinflace |
|---|---|---|
| Definice | pokles cenové hladiny (záporná míra inflace) | zpomalení inflace — míra inflace klesá, ale zůstává kladná |
| Cenová hladina | klesá | dále roste, jen pomaleji |
| Příklad | míra inflace −1 % | pokles inflace z 6 % na 2 % |
| Rizika | odkládání spotřeby, růst reálné hodnoty dluhů (dluhová deflace podle I. Fishera), nulová dolní mez úrokových sazeb omezuje měnovou politiku | při rychlé dezinflaci hrozí přechodný pokles produktu |

### ? Míra inflace klesne z 6 % na 2 %. Jak tento vývoj označíme?

- [x] Dezinflace — ceny rostou, ale pomaleji
- [ ] Deflace — cenová hladina klesá
- [ ] Hyperinflace — zlom cenového trendu
- [ ] Stagflace — inflace a pokles produktu

> Míra inflace zůstává kladná, cenová hladina tedy dál roste, jen pomaleji — to je dezinflace. O deflaci by šlo až při záporné míře inflace.

### ? Proč je deflace problematická pro zadlužené firmy?

- [ ] Snižuje reálnou hodnotu jejich dluhů
- [ ] Automaticky zvyšuje nominální úrokové sazby
- [ ] Zvyšuje jejich nominální tržby
- [x] Zvyšuje reálnou hodnotu jejich dluhů

> Dluh je sjednán nominálně, ale ceny a tržby firmy klesají, takže splátky jsou reálně dražší. Tento mechanismus popsal I. Fisher jako dluhovou deflaci.

## Fisherova rovnice {#fisherova-rovnice .explain}

Fisherova rovnice spojuje nominální a reálnou úrokovou míru: přesně `(1 + i) = (1 + r) · (1 + πᵉ)`, pro nízké hodnoty přibližně **`i ≈ r + πᵉ`**. Reálná úroková míra se chápe **ex ante** (`r = i − πᵉ`, podle očekávání při uzavření smlouvy — rozhoduje o úsporách a investicích) nebo **ex post** (`r = i − π`, podle skutečné inflace). **Fisherův efekt**: je-li reálná úroková míra v dlouhém období dána reálnými faktory (úspory, investice), zvýšení očekávané inflace o 1 p. b. zvýší nominální úrokovou míru rovněž o 1 p. b.

*Příklad:* i = 7 %, πᵉ = 3 % → r ≈ 7 − 3 = 4 %; přesně r = 1,07 / 1,03 − 1 ≈ 3,88 %.

### ? Nominální úroková míra je 9 % a očekávaná inflace 4 %. Jaká je přibližně ex ante reálná úroková míra?

- [ ] 13 %
- [ ] −5 %
- [ ] 9 %
- [x] 5 %

> r ≈ i − πᵉ = 9 − 4 = 5 %. 13 % vznikne sečtením, −5 % opačným znaménkem a 9 % je samotná nominální sazba.

### ? Očekávaná inflace vzroste ze 2 % na 5 % a reálná úroková míra zůstane 3 %. Jak se podle Fisherova efektu změní nominální úroková míra?

- [x] Vzroste z 5 % na 8 %
- [ ] Vzroste z 3 % na 6 %
- [ ] Klesne z 5 % na 2 %
- [ ] Zůstane 3 %, určuje ji reálný sektor

> i ≈ r + πᵉ: původně 3 + 2 = 5 %, nově 3 + 5 = 8 %. Nominální sazba roste o stejný počet bodů jako očekávaná inflace; reálným sektorem je dána sazba reálná, ne nominální.

### ? Nominální úroková míra je 21 % a očekávaná inflace 10 %. Jaká je přesná reálná úroková míra podle Fisherovy rovnice?

- [ ] 11 %
- [x] 10 %
- [ ] 31 %
- [ ] 2,1 %

> Přesně 1 + r = 1,21 / 1,10 = 1,10, tedy r = 10 %. Aproximace i − πᵉ = 11 % je při vyšších hodnotách nepřesná.

## Náklady očekávané inflace {#naklady-ocekavane .explain}

I plně **očekávaná** (anticipovaná) inflace, se kterou lidé počítají ve smlouvách a úrokových sazbách, přináší náklady:

- **náklady obuvi** (shoe-leather costs) — inflace působí jako daň z držby hotovosti; lidé drží méně peněz a vynakládají čas a úsilí na častější výběry a přesuny mezi účty;
- **náklady jídelníčku** (menu costs) — náklady na přecenění: tisk ceníků, přeznačení zboží, úpravy katalogů a systémů;
- **variabilita relativních cen** — ceny se nemění současně, takže se mezi přeceněními zkreslují relativní ceny a alokace zdrojů;
- **zkreslení daní** — daňový systém je nominální, takže se daní i inflační složka úroků a kapitálových zisků a efektivní zdanění reálného výnosu roste;
- **proměnlivá měrná jednotka** — srovnávání hodnot v čase a účetnictví jsou méně spolehlivé.

*Příklad:* Daň z úroků je 20 %. Při i = 3 % a π = 0 % je reálný výnos po zdanění 3 · 0,8 = 2,4 %. Při π = 5 % a i = 8 % (stejné r = 3 %) je nominální výnos po zdanění 6,4 % a reálný jen 6,4 − 5 = 1,4 %.

### ? Nominální úroková míra je 10 %, inflace 6 % a úroky se daní sazbou 15 %. Jaký je reálný výnos po zdanění?

- [ ] 3,4 %
- [x] 2,5 %
- [ ] 4,0 %
- [ ] 8,5 %

> Nominální výnos po zdanění = 10 · (1 − 0,15) = 8,5 %; reálný = 8,5 − 6 = 2,5 %. 3,4 % by vyšlo při zdanění jen reálného výnosu (4 · 0,85), 4 % je reálný výnos před zdaněním a 8,5 % nominální výnos po zdanění.

### ? Při vysoké inflaci firma drží minimum hotovosti a účetní každý den převádí peníze mezi účty. Jak se tento náklad inflace nazývá?

- [ ] Náklady jídelníčku (menu costs)
- [ ] Inflační zkreslení daní
- [ ] Redistribuce od věřitelů k dlužníkům
- [x] Náklady obuvi (shoe-leather costs)

> Náklady obuvi jsou čas a úsilí vynaložené na snižování držby peněz, které inflace znehodnocuje. Náklady jídelníčku se týkají přeceňování.

## Náklady neočekávané inflace {#naklady-neocekavane .explain}

**Neočekávaná** inflace (odchylka skutečné inflace π od očekávané πᵉ) navíc způsobuje **nahodilou redistribuci bohatství**. Nominální smlouvy (úvěry, mzdy, nájmy, nevalorizované příjmy) se sjednávají podle πᵉ. Je-li **π > πᵉ**, ex post reálná úroková míra je nižší, než se čekalo — **získávají dlužníci, ztrácejí věřitelé** a příjemci pevných nominálních příjmů; je-li π < πᵉ, je tomu naopak. Vysoká a proměnlivá inflace také zvyšuje **nejistotu**: zkracuje horizont smluv, zvyšuje rizikové prémie a brzdí dlouhodobé investice. Ochranou jsou indexace (valorizační doložky) a dluhopisy s výnosem vázaným na inflaci.

*Příklad:* Hypotéka s i = 5 % byla sjednána při πᵉ = 2 % (očekávaná reálná sazba 3 %). Skutečná inflace je 6 %, ex post reálná sazba je tedy −1 % — banka jako věřitel ztrácí, dlužník získává.

### ? Banka poskytla úvěr s nominální sazbou 6 % při očekávané inflaci 2 %. Skutečná inflace byla 5 %. Jaká je ex post reálná úroková míra a kdo získal?

- [ ] 4 %, získal věřitel
- [ ] 3 %, nikdo nezískal ani neztratil
- [x] 1 %, získal dlužník
- [ ] 1 %, získal věřitel

> Ex post r = i − π = 6 − 5 = 1 %, ex ante se čekalo 6 − 2 = 4 %. Inflace byla vyšší, než se čekalo, takže reálná hodnota splátek klesla ve prospěch dlužníka.

### ? Kdo při neočekávaně VYSOKÉ inflaci obvykle ztrácí?

- [x] Držitel dluhopisu s pevným kupónem
- [ ] Firma splácející úvěr s pevnou sazbou
- [ ] Stát s vysokým nominálním dluhem
- [ ] Majitel nemovitosti financované hypotékou

> Držitel dluhopisu je věřitel s pevným nominálním příjmem, jehož reálná hodnota klesá. Ostatní jsou dlužníci, kterým neočekávaná inflace reálně snižuje dluh.

## Cenové rigidity {#cenove-rigidity .explain}

Cenové rigidity (strnulost cen) znamenají, že ceny a mzdy reagují na změny poptávky a nákladů **pomalu**; proto mají poptávkové šoky i měnová politika v krátkém období reálné dopady na produkt. Hlavní vysvětlení:

- **náklady jídelníčku** (menu costs) — i malé náklady na změnu ceny mohou firmu od přecenění odradit, protože její soukromý zisk z přecenění je malý; snížení cen by však mělo velký přínos pro celou ekonomiku (vyšší agregátní poptávka) — N. G. Mankiw (1985): malé náklady jídelníčku, velké hospodářské cykly;
- **dlouhodobé kontrakty** — mzdy, nájmy a dodavatelské ceny jsou sjednány nominálně na delší dobu;
- **rozložené (nesynchronizované) přeceňování** — firmy nemění ceny současně (modely Taylora a Calva), takže cenová hladina se přizpůsobuje postupně;
- **koordinační problém** — žádná firma nechce snížit cenu jako první, protože by snížila svou relativní cenu; kdyby ceny snížily všechny firmy současně, všem by se polepšilo, ale bez koordinace k tomu nedojde.

*Příklad:* Po poklesu poptávky by restauraci prospělo zlevnit o 2 %, ale přetisk jídelních lístků a nejistota, zda zlevní i konkurence, ji od toho odradí — ceny zůstanou a klesne spíše prodávané množství.

### ? Všechny firmy by si polepšily, kdyby při poklesu poptávky současně snížily ceny, ale žádná to neudělá jako první. Které vysvětlení cenové rigidity to popisuje?

- [ ] Náklady jídelníčku
- [x] Koordinační problém
- [ ] Substituční zkreslení
- [ ] Neočekávaná inflace

> Koordinační problém: výsledek, který by byl lepší pro všechny, nenastane, protože jednotlivá firma nemá motivaci jít první. Substituční zkreslení se týká měření cenových indexů.

### ? Proč podle teorie nákladů jídelníčku mohou malé náklady přecenění vyvolat velké výkyvy produktu?

- [ ] Náklady přecenění tvoří významnou část HDP
- [ ] Firmy přeceňují denně, a zvyšují tím nejistotu
- [x] Firmě se přecenění nevyplatí, ač by pomohlo celé ekonomice
- [ ] Regulace firmám zakazuje časté změny cen

> Soukromý zisk firmy ze snížení ceny je malý a nepokryje ani drobné náklady přecenění, společenský přínos (vyšší agregátní poptávka) je však velký. Ceny proto zůstanou a šok se promítne do produktu.

## Taylorův vs. Calvův model rozloženého přeceňování {#taylor-calvo .compare}

Oba modely vysvětlují, proč se cenová hladina po šoku přizpůsobuje postupně: v každém okamžiku mění ceny jen část firem.

| | Taylorův model (J. Taylor, 1980) | Calvův model (G. Calvo, 1983) |
|---|---|---|
| Princip | ceny (mzdy) se sjednávají na pevnou dobu N období | v každém období může firma změnit cenu s pevnou pravděpodobností λ, bez ohledu na to, kdy ji měnila naposledy |
| Kdo přeceňuje | pravidelně 1/N firem (kontraktů) v každém období | náhodně vybraný podíl λ firem |
| Doba platnosti ceny | přesně N období | náhodná, v průměru 1/λ období |
| Důsledek | postupné přizpůsobení cenové hladiny, setrvačnost inflace | totéž; díky jednoduchosti je základem nové keynesiánské Phillipsovy křivky |

### ? V Calvově modelu může firma v každém čtvrtletí změnit cenu s pravděpodobností 0,2. Jak dlouho v průměru platí jedna cena?

- [ ] 4 čtvrtletí
- [ ] 1,25 čtvrtletí
- [ ] 2 čtvrtletí
- [x] 5 čtvrtletí

> Průměrná doba platnosti ceny = 1 / λ = 1 / 0,2 = 5 čtvrtletí. 1,25 by vyšlo záměnou s pravděpodobností, že se cena nezmění (1 / 0,8).

### ? V Taylorově modelu trvají mzdové kontrakty 2 roky a každý rok se obnovuje polovina z nich. Co se stane po trvalém poklesu peněžní zásoby?

- [x] Mzdy a ceny klesají postupně, produkt mezitím klesá
- [ ] Okamžitě klesnou všechny mzdy i ceny v ekonomice
- [ ] Mzdy se nezmění nikdy, protože jsou smluvní
- [ ] Ceny vzrostou, protože se kontrakty prodlouží

> V každém roce se upraví jen polovina kontraktů, a to s ohledem na mzdy v dosud platných smlouvách; cenová hladina proto klesá postupně a mezitím se šok projeví poklesem produktu.
