---
kind: topic
subject: manazerska-ekonomie
slug: menovy-kurz
name: "Měnový kurz"
order: 5
---

Poptávka a nabídka na devizovém trhu. Nekrytá teorie parity úrokových sazeb. Krytá teorie parity úrokových sazeb. Absolutní verze parity kupní síly. Relativní verze parity kupní síly. Koeficient ERDI. Syntéza teorie nekryté úrokové parity a paritních kupních sil.

## Devizový trh {#devizovy-trh .term}

Devizový trh (foreign exchange market, forex) je trh, na kterém se obchoduje s cizími měnami a kde se tvoří měnový kurz. Obchoduje se hlavně s **devizami** (bezhotovostní prostředky v cizí měně — zůstatky na účtech, platební příkazy), s hotovostí v cizí měně (**valutami**) jen okrajově. Rozlišují se **promptní (spotové)** obchody s vypořádáním do dvou pracovních dnů a **termínové (forwardové)** obchody s kurzem dohodnutým dnes pro vypořádání v budoucnu.

### ? Co jsou devizy?

- [ ] Hotovost (bankovky a mince) v cizí měně
- [x] Bezhotovostní prostředky v cizí měně, např. zůstatky na účtech
- [ ] Zlaté rezervy centrální banky
- [ ] Státní dluhopisy denominované v domácí měně

> Devizy jsou bezhotovostní peníze v cizí měně; tvoří převážnou část obratu devizového trhu. Hotovost v cizí měně se označuje jako valuty.

### ? Firma dnes uzavře s bankou dohodu, že za 3 měsíce koupí 100 000 EUR za kurz 25,20 CZK/EUR. O jaký obchod jde?

- [ ] Promptní (spotový) obchod
- [ ] Devizovou intervenci
- [ ] Valutový obchod
- [x] Termínový (forwardový) obchod

> Kurz je sjednán dnes, ale vypořádání proběhne až v budoucnu — jde o termínový (forwardový) obchod. Spotový obchod se vypořádá do dvou pracovních dnů.

## Přímé a nepřímé kotování {#kotovani .compare}

V tomto předmětu se používá přímé kotování: E = počet korun za 1 euro.

| | Přímé kotování | Nepřímé kotování |
|---|---|---|
| Definice | počet jednotek domácí měny za 1 (nebo 100) jednotek cizí měny | počet jednotek cizí měny za 1 jednotku domácí měny |
| Příklad z pohledu ČR | 25,00 CZK/EUR | 0,04 EUR/CZK |
| Růst kurzu znamená | **depreciaci** domácí měny | **apreciaci** domácí měny |
| Kde se používá | ČR (kurzovní lístek ČNB) a většina zemí | např. britská libra, euro (ECB kotuje 1 EUR = x USD) |

### ? Kurz se změní z 0,0400 na 0,0420 EUR/CZK. Co to znamená pro korunu?

- [x] Koruna apreciovala, za 1 CZK se dostane více eur
- [ ] Koruna depreciovala, protože číslo kurzu vzrostlo
- [ ] Kurz se nezměnil, změnil se jen způsob kotování
- [ ] Euro vůči koruně apreciovalo

> V nepřímém kotování znamená růst kurzu zhodnocení domácí měny. V přímém kotování by šlo o pokles z 25,00 na 1 / 0,042 ≈ 23,81 CZK/EUR.

### ? Kurz 25 CZK/EUR v přímém kotování odpovídá v nepřímém kotování kurzu:

- [ ] 25 EUR/CZK
- [ ] 0,25 EUR/CZK
- [x] 0,04 EUR/CZK
- [ ] 0,4 EUR/CZK

> Nepřímé kotování je převrácená hodnota přímého: 1 / 25 = 0,04 EUR za 1 korunu.

## Apreciace a depreciace {#apreciace-depreciace .explain}

**Apreciace** (zhodnocení) domácí měny znamená, že se za jednotku cizí měny platí méně domácí měny — v přímém kotování E **klesá**. **Depreciace** (znehodnocení) znamená, že E **roste**. Tyto pojmy se používají u plovoucího kurzu, kde změnu určuje trh; při fixním kurzu měnu zhodnocuje nebo znehodnocuje rozhodnutí měnové autority — mluví se o **revalvaci** a **devalvaci**. Procentní zhodnocení jedné měny není přesně rovno procentnímu znehodnocení druhé, protože se počítá z jiného základu.

*Příklad:* Kurz klesne z 25,00 na 24,00 CZK/EUR. Euro oslabilo o 1/25 = 4 %, koruna posílila o 25/24 − 1 ≈ 4,17 % (hodnota koruny vzrostla z 0,0400 na 0,0417 EUR). Pozor: v UIP a PPP se depreciace koruny aproximuje jako procentní změna samotného E, tedy (E₁ − E₀)/E₀.

### ? Kurz vzroste z 24 na 25 CZK/EUR. Jak se změnila hodnota koruny vyjádřená v eurech (1/E)?

- [ ] Apreciovala o 4 %
- [x] Depreciovala o 4 %
- [ ] Depreciovala o 4,17 %
- [ ] Apreciovala o 4,17 %

> Růst E v přímém kotování je depreciace koruny. Hodnota koruny klesla z 1/24 na 1/25 EUR, tj. o 1 − 24/25 = 4 %. O 25/24 − 1 ≈ 4,17 % naopak posílilo euro.

### ? ČNB v listopadu 2013 vyhlásila, že bude intervencemi udržovat kurz koruny poblíž hladiny 27 CZK/EUR (kurzový závazek trval do dubna 2017). Jakým směrem tím kurz koruny posunula?

- [ ] K apreciaci koruny prodejem eur
- [ ] K revalvaci koruny zvýšením sazeb
- [x] K depreciaci koruny nákupem eur
- [ ] K apreciaci koruny nákupem eur

> Před závazkem byl kurz kolem 25,5–26 CZK/EUR; posun ke 27 CZK/EUR znamená růst E, tedy oslabení koruny. ČNB jej zajišťovala nákupem eur za koruny, který zvyšuje poptávku po devizách.

## Nominální a reálný kurz {#nominalni-realny-kurz .explain}

**Nominální kurz E** udává cenu cizí měny v domácí měně (CZK/EUR). **Reálný kurz** ε = E · P* / P udává relativní cenu zahraničního zboží vůči domácímu vyjádřenou ve společné měně — kolik jednotek domácího koše je třeba obětovat za jeden stejný zahraniční koš. Růst ε je **reálná depreciace** koruny: české zboží zlevňuje oproti zahraničnímu, roste cenová konkurenceschopnost a obvykle i čistý export NX. Pokles ε je **reálná apreciace**. Pro změny platí přibližně **%Δε ≈ %ΔE + π* − π**, takže koruna může reálně apreciovat i při stálém nominálním kurzu, je-li inflace v ČR vyšší než v zahraničí.

*Příklad:* Spotřební koš stojí v eurozóně P* = 100 EUR, v ČR P = 2 000 Kč a kurz je E = 25 CZK/EUR → ε = 25 · 100 / 2 000 = 1,25. Zahraniční koš stojí 2 500 Kč, je tedy o 25 % dražší než domácí.

### ? E = 25 CZK/EUR, zahraniční koš stojí P* = 80 EUR a domácí P = 2 500 Kč. Jaký je reálný kurz ε?

- [ ] 1,25
- [x] 0,8
- [ ] 0,032
- [ ] 2 000

> ε = E · P* / P = 25 · 80 / 2 500 = 2 000 / 2 500 = 0,8 — domácí koš je dražší než zahraniční. Hodnota 1,25 je převrácený zlomek, 2 000 je jen cena zahraničního koše v korunách.

### ? Nominální kurz se za rok nezmění, inflace v ČR je 5 % a v eurozóně 2 %. Co se stalo s reálným kurzem koruny?

- [ ] Reálná depreciace přibližně o 3 %
- [ ] Reálný kurz se nezměnil
- [ ] Reálná apreciace přibližně o 7 %
- [x] Reálná apreciace přibližně o 3 %

> %Δε ≈ %ΔE + π* − π = 0 + 2 − 5 = −3 %. Pokles ε je reálná apreciace: české zboží zdražilo vůči zahraničnímu o 3 %, ačkoli nominální kurz stojí.

### ? Co obvykle způsobí reálná depreciace koruny (růst ε)?

- [x] Zlepšení cenové konkurenceschopnosti českého vývozu
- [ ] Zdražení českého zboží pro zahraniční odběratele
- [ ] Pokles cen dovozů přepočtených na koruny
- [ ] Automatický pokles inflace v ČR

> Růst ε znamená, že zahraniční zboží je relativně dražší a české levnější. Vývoz se stává konkurenceschopnějším, dovoz v korunách naopak zdražuje.

## Poptávka po devizách {#poptavka-deviz .explain}

Poptávku po devizách (např. po eurech za koruny) tvoří ti, kdo potřebují platit v cizí měně: **dovozci** zboží a služeb, **čeští turisté** v zahraničí, **rezidenti investující v zahraničí** (nákup zahraničních akcií a dluhopisů, přímé investice), dlužníci **splácející zahraniční úvěry**, firmy vyplácející **dividendy zahraničním vlastníkům** a spekulanti sázející na oslabení koruny. V grafu je na svislé ose kurz E (CZK/EUR) a na vodorovné množství eur. Křivka poptávky je **klesající**: při vyšším E je zahraniční zboží v korunách dražší, dováží se méně a eur je potřeba méně. Změna kurzu znamená pohyb po křivce, změny ostatních faktorů ji posouvají.

*Příklad:* Zdraží-li euro z 25 na 27 Kč, dovozové auto za 20 000 EUR podraží z 500 000 na 540 000 Kč; dovozci objednají méně vozů a poptávané množství eur klesne.

### ? Který subjekt na devizovém trhu NEPOPTÁVÁ eura za koruny?

- [ ] Český dovozce strojů z Německa
- [ ] Česká rodina na dovolené v Rakousku
- [x] Český vývozce, který inkasoval tržby v eurech
- [ ] Český penzijní fond kupující německé dluhopisy

> Vývozce eura získal a směňuje je za koruny, takže eura nabízí. Dovozce, turisté i investor kupující zahraniční aktiva eura poptávají.

### ? Proč je křivka poptávky po devizách v přímém kotování klesající?

- [ ] Vyšší E zlevňuje dovoz, a proto se dováží více
- [ ] Centrální banka při vyšším E vždy prodává devizy
- [ ] Vyšší E automaticky zvyšuje úrokové sazby v ČR
- [x] Vyšší E zdražuje dovoz v korunách, a dováží se méně

> Při vyšším kurzu stojí stejné zahraniční zboží více korun, dovoz klesá a s ním i poptávané množství eur. První možnost obrací směr účinku.

## Nabídka deviz {#nabidka-deviz .explain}

Nabídku deviz tvoří ti, kdo získali cizí měnu a chtějí ji směnit za koruny: **vývozci** inkasující tržby v eurech, **zahraniční turisté** v ČR, **zahraniční investoři** kupující česká aktiva (přímé investice, české dluhopisy a akcie), subjekty čerpající **úvěry ze zahraničí**, příjemci transferů (např. prostředků z fondů EU) a centrální banka při intervencích. Křivka nabídky deviz je obvykle **rostoucí**: při vyšším E dostane vývozce za každé euro více korun, české zboží je pro cizince levnější, vývoz roste a nabízí se více eur (předpokládá to dostatečně pružnou zahraniční poptávku po českém vývozu). Při plovoucím kurzu určuje průsečík poptávky a nabídky **rovnovážný kurz**; převis poptávky po eurech kurz zvyšuje, převis nabídky snižuje.

*Příklad:* Láhev českého piva za 50 Kč stojí německého odběratele při kurzu 25 CZK/EUR 2,00 EUR, při kurzu 26 CZK/EUR jen asi 1,92 EUR — odběratel jí koupí více a za vývoz přitéká více eur.

### ? Při kurzu 24 CZK/EUR, který leží pod rovnovážnou úrovní, je poptávané množství eur vyšší než nabízené. Co nastane při plovoucím kurzu?

- [ ] Kurz klesne ještě níž a koruna apreciuje
- [x] Kurz vzroste k rovnováze a koruna depreciuje
- [ ] Kurz se nezmění, převis vyrovná vyšší dovoz
- [ ] Koruna devalvuje rozhodnutím vlády

> Převis poptávky po eurech zvyšuje jejich cenu, E roste, dokud se poptávané a nabízené množství nevyrovná. Růst E je depreciace koruny; devalvace se týká fixního kurzu.

### ? Který subjekt přispívá k NABÍDCE eur na devizovém trhu?

- [ ] Česká firma splácející úvěr u rakouské banky
- [ ] Český student platící školné v Nizozemsku
- [ ] Česká dceřiná firma vyplácející dividendy zahraniční matce
- [x] Německý investor kupující české státní dluhopisy

> Zahraniční investor musí na nákup korunových dluhopisů eura směnit za koruny, a eura tedy nabízí. Ostatní subjekty potřebují eura získat — poptávají je.

## Posuny poptávky a nabídky deviz {#posuny-krivek .compare}

Faktory, které **posouvají** křivky (plovoucí kurz, ostatní podmínky beze změny):

| Změna | Posun křivek | Kurz E | Koruna |
|---|---|---|---|
| Růst důchodu v ČR | poptávka po devizách doprava (více dovozu) | roste | depreciace |
| Růst důchodu v zahraničí | nabídka deviz doprava (více vývozu) | klesá | apreciace |
| Zvýšení domácí sazby i | nabídka deviz doprava (příliv kapitálu), poptávka doleva | klesá | apreciace |
| Zvýšení zahraniční sazby i* | poptávka po devizách doprava (odliv kapitálu) | roste | depreciace |
| Vyšší inflace v ČR než v zahraničí | poptávka doprava, nabídka doleva (české zboží dražší) | roste | depreciace |
| Očekávané oslabení koruny | poptávka doprava (spekulativní nákup eur), nabídka doleva | roste | depreciace |
| Intervence ČNB nákupem eur | poptávka po devizách doprava | roste | depreciace |

### ? ČNB zvýší úrokové sazby, zahraniční sazby se nezmění. Co se stane na devizovém trhu při plovoucím kurzu?

- [x] Příliv kapitálu zvýší nabídku eur a koruna apreciuje
- [ ] Odliv kapitálu zvýší poptávku po eurech a koruna depreciuje
- [ ] Nabídka eur klesne a kurz E vzroste
- [ ] Křivky se neposunou, změní se jen obchodované množství

> Vyšší výnos korunových aktiv přiláká zahraniční kapitál; investoři směňují eura za koruny, nabídka eur roste a E klesá — koruna posiluje.

### ? Eurozóna se dostane do recese a sníží dovoz zboží z ČR. Jak to ovlivní kurz koruny?

- [ ] Poptávka po eurech klesne a koruna apreciuje
- [ ] Nabídka eur vzroste a koruna apreciuje
- [x] Nabídka eur klesne, E vzroste a koruna depreciuje
- [ ] Nabídka eur klesne, E klesne a koruna apreciuje

> Nižší český vývoz znamená méně eur, která vývozci směňují za koruny — nabídka deviz se posune doleva, rovnovážný kurz E vzroste a koruna oslabí.

## Nekrytá parita úrokových sazeb (UIP) {#uip .explain}

Nekrytá parita úrokových sazeb (uncovered interest parity, UIP) vychází z rozhodování investora mezi vkladem v korunách s úrokem i a vkladem v eurech s úrokem i*, **bez zajištění** kurzového rizika. V rovnováze musí oba vklady přinášet stejný očekávaný výnos v korunách: `(1 + i) = (1 + i*) · Eᵉ / E`, přibližně **i ≈ i* + (Eᵉ − E) / E**, kde Eᵉ je očekávaný budoucí kurz. Vyšší domácí úroková sazba tedy musí být vyvážena **očekávanou depreciací** domácí měny. UIP předpokládá dokonalou mobilitu kapitálu, dokonalou zaměnitelnost aktiv a investory neutrální k riziku; v praxi se k ní přidává **riziková prémie** a empiricky v krátkém období často neplatí.

*Příklad:* i* = 2 % a trh očekává oslabení koruny o 1 % za rok → aby byli investoři mezi oběma vklady indiferentní, musí být i ≈ 2 + 1 = 3 %.

### ? E = 25,00 CZK/EUR, roční sazba v ČR i = 4 %, v eurozóně i* = 2 %. Jaký kurz za rok trh podle UIP přibližně očekává?

- [ ] 24,50 CZK/EUR
- [x] 25,50 CZK/EUR
- [ ] 26,00 CZK/EUR
- [ ] 25,00 CZK/EUR

> Očekávaná depreciace ≈ i − i* = 4 − 2 = 2 %, tedy Eᵉ ≈ 25 · 1,02 = 25,50 (přesně 25 · 1,04 / 1,02 ≈ 25,49). Hodnota 24,50 vznikne opačným znaménkem, 26,00 použitím celé domácí sazby.

### ? Podle UIP je v ČR i = 5 % a v eurozóně i* = 3 %. Jak interpretovat úrokový diferenciál?

- [ ] Trh očekává apreciaci koruny přibližně o 2 %
- [ ] Koruna je o 2 % podhodnocená vůči paritě kupní síly
- [ ] Investor v korunách získá jistě o 2 % vyšší výnos
- [x] Trh očekává depreciaci koruny přibližně o 2 %

> (Eᵉ − E) / E ≈ i − i* = 2 %: vyšší korunový úrok kompenzuje očekávané oslabení koruny. Jistý vyšší výnos to není, protože kurzové riziko je nezajištěné.

## UIP a okamžitá reakce kurzu {#uip-reakce-kurzu .explain}

Z UIP lze vyjádřit dnešní kurz: `E = Eᵉ · (1 + i*) / (1 + i)`, přibližně E ≈ Eᵉ · (1 − (i − i*)). Při daných očekáváních Eᵉ a zahraniční sazbě i* vede **zvýšení domácí sazby** okamžitě k **apreciaci** koruny (E klesne): kapitál proudí do korun, dokud nevznikne očekávaná depreciace, která vyšší úrok vyrovná. Naopak zvýšení i* nebo **očekávání slabší koruny** (vyšší Eᵉ) vede k okamžité depreciaci. Očekávání trhu se tak do kurzu promítají hned, ne až v budoucnu.

*Příklad:* Eᵉ = 25,00 CZK/EUR, i* = 2 %; ČNB zvýší i ze 2 % na 4 % → E ≈ 25 · 1,02 / 1,04 ≈ 24,52 CZK/EUR, koruna okamžitě posílí přibližně o 2 %.

### ? Eᵉ = 25,00 CZK/EUR, i* = 2 % a ČNB zvýší domácí sazbu ze 2 % na 5 %. Co se podle UIP stane s kurzem okamžitě?

- [x] Koruna posílí přibližně na 24,29 CZK/EUR
- [ ] Koruna oslabí přibližně na 25,75 CZK/EUR
- [ ] Kurz zůstane 25,00 CZK/EUR, protože Eᵉ se nezměnil
- [ ] Koruna posílí přibližně na 23,75 CZK/EUR

> E = Eᵉ · (1 + i*) / (1 + i) = 25 · 1,02 / 1,05 ≈ 24,29 — koruna posílí asi o 3 % (o úrokový diferenciál). Hodnota 23,75 vznikne odečtením celé domácí sazby 5 %.

### ? Platí i = i* = 3 % a Eᵉ = 26,00 CZK/EUR. Trh náhle začne očekávat kurz Eᵉ = 26,52 (o 2 % slabší koruna), sazby se nemění. Co se podle UIP stane s dnešním kurzem?

- [ ] Zůstane 26,00, změna se projeví až za rok
- [ ] Klesne přibližně na 25,48
- [x] Vzroste přibližně na 26,52
- [ ] Vzroste přibližně na 27,04

> Při i = i* platí E = Eᵉ · (1 + i*) / (1 + i) = Eᵉ, takže dnešní kurz okamžitě vzroste na 26,52 — očekávané oslabení se naplní hned. Hodnota 25,48 má opačné znaménko.

## Krytá parita úrokových sazeb (CIP) {#cip .explain}

Krytá parita úrokových sazeb (covered interest parity, CIP) platí pro investora, který kurzové riziko **zajistí forwardovým kontraktem**: dnes koupí eura spotově za kurz E, uloží je na úrok i* a zároveň prodá budoucí eura za dnes dohodnutý **forwardový kurz F**. Protože výnos obou variant je jistý, každý rozdíl by umožnil bezrizikovou **krytou úrokovou arbitráž**, a proto musí platit `(1 + i) = (1 + i*) · F / E`, tedy **F = E · (1 + i) / (1 + i*)**, přibližně (F − E) / E ≈ i − i*. Na rozdíl od UIP neobsahuje očekávání a na likvidních trzích za běžných podmínek platí velmi přesně (odchylky se objevují hlavně v obdobích finančního stresu).

*Příklad:* E = 25,00 CZK/EUR, roční i = 4 %, i* = 2 % → roční forwardový kurz F = 25 · 1,04 / 1,02 ≈ 25,49 CZK/EUR.

### ? E = 24,00 CZK/EUR, roční sazba v ČR i = 5 %, v eurozóně i* = 2 %. Jaký je podle CIP roční forwardový kurz?

- [x] Přibližně 24,71 CZK/EUR
- [ ] Přibližně 23,31 CZK/EUR
- [ ] Přesně 25,20 CZK/EUR
- [ ] Přesně 24,00 CZK/EUR

> F = E · (1 + i) / (1 + i*) = 24 · 1,05 / 1,02 = 25,20 / 1,02 ≈ 24,71. Hodnota 23,31 vznikne prohozením sazeb, 25,20 zapomenutím na zahraniční úrok.

### ? E = 25,00 CZK/EUR, roční sazby i = i* = 2 %, ale banka kotuje roční forwardový kurz F = 25,50 CZK/EUR. Jak lze dosáhnout bezrizikového zisku?

- [x] Půjčit si koruny, koupit eura spotově, uložit je na i* a prodat forwardově
- [ ] Půjčit si eura, prodat je spotově, uložit koruny na i a eura koupit forwardově
- [ ] Koupit eura spotově bez zajištění a vyčkat na oslabení koruny
- [ ] Nelze, protože úrokové sazby jsou v obou zemích stejné

> Podle CIP má být F = 25 · 1,02 / 1,02 = 25,00, euro je na forwardu příliš drahé. Půjčka 25 Kč → 1 EUR → za rok 1,02 EUR → prodej za 25,50 = 26,01 Kč; splátka 25,50 Kč, zisk 0,51 Kč bez rizika. Druhá možnost by vedla ke ztrátě, třetí není bezriziková.

## Forwardová prémie a diskont {#forwardova-premie .term}

**Forwardová prémie** nastává, když je forwardový kurz měny vyšší než spotový, **forwardový diskont**, když je nižší. V přímém kotování při F > E se euro obchoduje s prémií a koruna s diskontem. Podle CIP je relativní forwardová prémie `(F − E) / E ≈ i − i*`, takže měna s **vyšší** úrokovou sazbou se obchoduje s forwardovým **diskontem**.

### ? E = 25,00 CZK/EUR, roční forwardový kurz F = 24,75 CZK/EUR a i* = 3 %. Jaká je podle CIP přibližně roční sazba v ČR?

- [ ] 4 %
- [x] 2 %
- [ ] 1 %
- [ ] 3 %

> (F − E) / E = (24,75 − 25) / 25 = −1 %, tedy i ≈ i* − 1 % = 2 %. Euro se obchoduje s diskontem, protože má vyšší sazbu. Hodnota 4 % vznikne opačným znaménkem.

### ? Úrokové sazby v ČR jsou vyšší než v eurozóně. Co platí podle CIP?

- [ ] Koruna se obchoduje s forwardovou prémií
- [ ] Forwardový kurz CZK/EUR je nižší než spotový
- [ ] Forwardový a spotový kurz jsou stejné
- [x] Euro se obchoduje s forwardovou prémií vůči koruně

> Při i > i* je F = E · (1 + i) / (1 + i*) > E: za euro se na forwardu platí více korun než spotově, euro má prémii a koruna diskont.

## UIP vs. CIP {#uip-vs-cip .compare}

| | Nekrytá parita (UIP) | Krytá parita (CIP) |
|---|---|---|
| Zajištění kurzového rizika | ne, investor riziko nese | ano, forwardovým kontraktem |
| Vztah | i ≈ i* + (Eᵉ − E) / E | i ≈ i* + (F − E) / E |
| Klíčová veličina | očekávaný kurz Eᵉ (nepozorovatelný) | forwardový kurz F (kotovaný trhem) |
| Mechanismus | vyrovnání očekávaných výnosů, spekulace | bezriziková arbitráž |
| Empirická platnost | v krátkém období často neplatí, riziková prémie | za běžných podmínek velmi přesná |

Platí-li obě parity současně, je **F = Eᵉ**: forwardový kurz je nestranným odhadem budoucího spotového kurzu.

### ? Platí současně UIP i CIP. Co z toho plyne pro forwardový kurz?

- [x] Rovná se očekávanému budoucímu spotovému kurzu
- [ ] Rovná se dnešnímu spotovému kurzu
- [ ] Převyšuje očekávaný kurz o rizikovou prémii
- [ ] Rovná se kurzu podle parity kupní síly

> Obě parity mají na levé straně stejný úrokový diferenciál i − i*, proto (F − E) / E = (Eᵉ − E) / E, tedy F = Eᵉ. Riziková prémie by znamenala, že UIP neplatí.

### ? Čím se nekrytá parita úrokových sazeb liší od kryté?

- [ ] UIP pracuje s forwardovým kurzem, CIP s očekávaným
- [ ] UIP platí jen při fixním měnovém kurzu
- [ ] UIP předpokládá nulovou mobilitu kapitálu
- [x] Investor v UIP kurzové riziko nezajišťuje

> V UIP investor nese kurzové riziko a rozhoduje podle očekávaného kurzu Eᵉ; v CIP je riziko zajištěno forwardem F. První možnost oba kurzy prohazuje.

## Zákon jediné ceny {#zakon-jedine-ceny .term}

Zákon jediné ceny (law of one price) říká, že **stejné obchodovatelné zboží** má po přepočtu stejným kurzem stejnou cenu ve všech zemích: `Pᵢ = E · Pᵢ*`. Platí díky arbitráži (levně koupit, draze prodat) za předpokladu nulových dopravních nákladů a obchodních bariér a dokonalé konkurence.

### ? Tuna pšenice stojí v Německu 200 EUR, kurz je 25 CZK/EUR. Kolik by měla podle zákona jediné ceny stát v ČR?

- [ ] 8 Kč
- [ ] 225 Kč
- [x] 5 000 Kč
- [ ] 50 000 Kč

> Pᵢ = E · Pᵢ* = 25 · 200 = 5 000 Kč. Hodnota 8 vznikne dělením místo násobení.

### ? U kterého statku zákon jediné ceny platí NEJHŮŘE?

- [ ] Ropa obchodovaná na světových burzách
- [x] Kadeřnické služby
- [ ] Zlato
- [ ] Měď

> Kadeřnické služby jsou neobchodovatelné — nelze je levně koupit v jedné zemi a prodat v jiné, takže arbitráž nefunguje. Suroviny a zlato se obchodují globálně.

## Absolutní parita kupní síly {#absolutni-ppp .explain}

Absolutní parita kupní síly (purchasing power parity, PPP) aplikuje zákon jediné ceny na celé **cenové hladiny** (stejné spotřební koše): **E = P / P***. Kurz podle PPP je takový, při kterém má koruna stejnou kupní sílu doma i v zahraničí, a reálný kurz ε = E · P* / P se pak rovná **1**. V praxi absolutní PPP přesně neplatí: existují dopravní náklady, cla a jiné bariéry, **neobchodovatelné statky** (bydlení, služby), rozdílné spotřební koše a nedokonalá konkurence; kurz v krátkém období navíc ovlivňují toky kapitálu. Chápe se proto jako dlouhodobá kotva kurzu. Známou ilustrací je **index Big Mac** časopisu The Economist.

*Příklad:* Stejný spotřební koš stojí v ČR 2 750 Kč a v eurozóně 110 EUR → kurz podle PPP = 2 750 / 110 = 25 CZK/EUR.

### ? Big Mac stojí v ČR 135 Kč a v eurozóně 5,40 EUR. Jaký je kurz podle absolutní PPP?

- [ ] 0,04 CZK/EUR
- [ ] 729 CZK/EUR
- [ ] 129,60 CZK/EUR
- [x] 25 CZK/EUR

> E = P / P* = 135 / 5,40 = 25 CZK/EUR. Hodnota 0,04 je převrácená (EUR/CZK), 729 vznikne násobením cen.

### ? Proč absolutní parita kupní síly v praxi přesně NEPLATÍ?

- [ ] Ceny obchodovatelného zboží se kurzem nepřepočítávají
- [x] Kvůli neobchodovatelným statkům, dopravním nákladům a bariérám
- [ ] Centrální banky vždy drží kurz fixní
- [ ] Inflace je ve všech zemích stejná

> Arbitráž, na které PPP stojí, nefunguje u neobchodovatelných statků a brzdí ji dopravní náklady, cla a jiné bariéry. Odchylky od PPP proto mohou trvat dlouho.

## Relativní parita kupní síly {#relativni-ppp .explain}

Relativní parita kupní síly netvrdí nic o úrovni kurzu, ale o jeho **změnách**: procentní změna nominálního kurzu se přibližně rovná **rozdílu inflací** doma a v zahraničí, **%ΔE ≈ π − π***. Měna země s vyšší inflací v čase depreciuje. Relativní PPP může platit, i když absolutní neplatí — stačí, aby odchylka od absolutní PPP (např. kvůli dopravním nákladům) byla v čase stálá. Platnost relativní PPP je totéž co **konstantní reálný kurz** (%Δε ≈ %ΔE + π* − π = 0). Empiricky platí lépe v dlouhém období a u zemí s vysokou inflací.

*Příklad:* Inflace v ČR je 5 %, v eurozóně 2 % → koruna by měla ročně depreciovat přibližně o 3 %, z 25,00 na asi 25,75 CZK/EUR.

### ? E = 24,00 CZK/EUR, očekávaná inflace v ČR je 1 % a v eurozóně 3 %. Jaký kurz za rok předpovídá relativní PPP?

- [x] Přibližně 23,5 CZK/EUR
- [ ] Přibližně 24,5 CZK/EUR
- [ ] Stále 24,0 CZK/EUR, PPP určuje jen úroveň kurzu
- [ ] Přibližně 23,0 CZK/EUR

> %ΔE ≈ π − π* = 1 − 3 = −2 %, tedy E ≈ 24 · 0,98 ≈ 23,5 — koruna s nižší inflací posiluje. Hodnota 24,5 vznikne opačným znaménkem.

### ? Po celý rok platí relativní PPP. Co platí o reálném kurzu ε?

- [ ] Rovná se vždy 1
- [ ] Roste o rozdíl inflací
- [x] Zůstává konstantní
- [ ] Klesá o domácí inflaci

> Relativní PPP znamená %ΔE ≈ π − π*, takže %Δε ≈ %ΔE + π* − π = 0. Hodnotu ε = 1 vyžaduje až absolutní PPP.

## Absolutní vs. relativní PPP {#absolutni-vs-relativni-ppp .compare}

| | Absolutní PPP | Relativní PPP |
|---|---|---|
| Tvrzení | E = P / P* | %ΔE ≈ π − π* |
| Co vysvětluje | úroveň kurzu | změnu kurzu v čase |
| Reálný kurz | ε = 1 | ε je konstantní (nemusí být 1) |
| Vzájemný vztah | platí-li absolutní, platí i relativní | může platit i bez absolutní |
| Typické použití | srovnání cenových hladin a HDP, koeficient ERDI | odhad dlouhodobého trendu kurzu |

### ? Může platit relativní PPP, když absolutní PPP neplatí?

- [ ] Ne, relativní PPP je jen zvláštní případ absolutní
- [ ] Ano, ale jen při fixním měnovém kurzu
- [ ] Ne, protože obě verze vyžadují ε = 1
- [x] Ano, pokud je odchylka od absolutní PPP v čase stálá

> Je-li E = k · P / P* se stálým k ≠ 1, absolutní PPP neplatí, ale změny kurzu se stále rovnají rozdílu inflací. Naopak z absolutní PPP relativní plyne vždy.

## Koeficient ERDI {#erdi .explain}

Koeficient ERDI (Exchange Rate Deviation Index) měří odchylku tržního kurzu od kurzu podle parity kupní síly: **ERDI = E / E_PPP**, kde E_PPP = P / P*. Protože ERDI = E · P* / P, jde vlastně o reálný kurz počítaný z cenových hladin. V přímém kotování znamená **ERDI > 1**, že tržní kurz je slabší než kurz podle PPP: domácí měna je vůči PPP **podhodnocená** a ceny v ČR přepočtené tržním kurzem jsou nižší než v zahraničí; ERDI = 1 odpovídá absolutní PPP, ERDI < 1 nadhodnocení. Pro ČR i další transformující se ekonomiky je ERDI dlouhodobě **větší než 1** a v čase klesá, jak se cenová hladina přibližuje vyspělým zemím (reálná konvergence). Pokles ERDI může nastat nominální apreciací koruny i vyšší inflací v ČR než v zahraničí.

*Příklad:* E = 24 CZK/EUR a E_PPP = 16 CZK/EUR → ERDI = 24 / 16 = 1,5. Cenová hladina ČR přepočtená tržním kurzem činí 1 / 1,5 ≈ 67 % úrovně eurozóny.

### ? Tržní kurz je 25 CZK/EUR a kurz podle PPP 20 CZK/EUR. Jaký je ERDI a co vyjadřuje?

- [ ] 0,8 — koruna je vůči PPP nadhodnocená
- [x] 1,25 — koruna je vůči PPP podhodnocená
- [ ] 1,25 — koruna je vůči PPP nadhodnocená
- [ ] 5 — tržní kurz převyšuje PPP o 5 Kč

> ERDI = E / E_PPP = 25 / 20 = 1,25 > 1: za euro se na trhu platí více korun, než odpovídá kupní síle, koruna je tedy podhodnocená. Hodnota 0,8 je převrácený poměr, 5 jen rozdíl kurzů.

### ? ERDI koruny je 1,25. Jaká je cenová hladina ČR vůči eurozóně při přepočtu tržním kurzem?

- [ ] 125 %
- [ ] 25 %
- [ ] 75 %
- [x] 80 %

> Cenová hladina ČR v eurech vůči eurozóně je P / (E · P*) = 1 / ERDI = 1 / 1,25 = 0,8, tj. 80 %. Hodnota 75 % vznikne chybným odečtením 1 − 0,25.

### ? Jak se může ERDI koruny snížit směrem k 1?

- [x] Nominální apreciací koruny nebo vyšší inflací v ČR
- [ ] Nominální depreciací koruny při stálých cenách
- [ ] Nižší inflací v ČR než v eurozóně při nezměněném kurzu
- [ ] Výhradně přijetím eura

> ERDI = E · P* / P klesá, když klesá E (apreciace) nebo když P roste rychleji než P* (vyšší domácí inflace). Obě cesty znamenají reálnou apreciaci koruny.

## Balassův–Samuelsonův efekt {#balassa-samuelson .explain}

Balassův–Samuelsonův efekt vysvětluje, proč mají chudší země nižší cenovou hladinu (ERDI > 1) a proč jejich měna při dohánění reálně apreciuje. Ekonomika se dělí na sektor **obchodovatelných** statků (průmysl), kde ceny určuje zákon jediné ceny, a **neobchodovatelných** statků (služby). Dohánějící země zvyšuje produktivitu v obchodovatelném sektoru rychleji než zahraničí, a proto tam rostou mzdy. Mzdy se mezi sektory vyrovnávají (mobilita práce), takže rostou i ve službách, kde produktivita roste pomalu — ceny služeb, a tím i celková cenová hladina, rostou rychleji než v zahraničí. Výsledkem je **reálná apreciace** (vyšší inflací nebo nominální apreciací) a pokles ERDI, aniž by průmysl ztrácel konkurenceschopnost.

*Příklad:* Produktivita v průmyslu roste v ČR o 5 % a v eurozóně o 2 % ročně, ve službách v obou o 1 %. Mzdy rostou zhruba jako produktivita v průmyslu (5 % vs. 2 %), ceny služeb proto v ČR rostou asi o 5 − 1 = 4 %, v eurozóně o 2 − 1 = 1 %.

### ? Co je podle Balassova–Samuelsonova efektu prvotní příčinou reálné apreciace měny dohánějící země?

- [x] Rychlejší růst produktivity v sektoru obchodovatelných statků
- [ ] Rychlejší růst produktivity v sektoru služeb
- [ ] Pokles úrokových sazeb v zahraničí
- [ ] Expanzivní měnová politika a nízké sazby domácí centrální banky

> Rychlý růst produktivity v obchodovatelném sektoru zvyšuje mzdy v celé ekonomice a tím ceny neobchodovatelných služeb, kde produktivita roste pomalu. Celková cenová hladina se tak přibližuje zahraničí.

### ? Kurz koruny je fixní a v ČR působí Balassův–Samuelsonův efekt. Jak se reálná apreciace projeví?

- [ ] Nominální apreciací koruny
- [ ] Nijak, při fixním kurzu nastat nemůže
- [ ] Nižší inflací v ČR než v zahraničí
- [x] Vyšší inflací v ČR než v zahraničí

> Při fixním E může reálný kurz ε = E · P* / P klesat jen rychlejším růstem domácích cen P. Při plovoucím kurzu by se část efektu projevila nominální apreciací.

## Syntéza UIP a PPP — reálná úroková parita {#synteza-uip-ppp .explain}

Spojením nekryté úrokové parity a relativní PPP (vyjádřené v očekáváních) vzniká **reálná úroková parita**. UIP: i − i* ≈ očekávaná depreciace (Eᵉ − E) / E. Relativní PPP: očekávaná depreciace ≈ πᵉ − π*ᵉ. Z toho **i − i* ≈ πᵉ − π*ᵉ** — úrokový diferenciál odráží rozdíl očekávaných inflací (**Fisherův efekt v otevřené ekonomice**, tzv. mezinárodní Fisherův efekt). Po úpravě i − πᵉ ≈ i* − π*ᵉ, a podle Fisherovy rovnice tedy **r ≈ r***: při dokonalé mobilitě kapitálu a platnosti obou parit se reálné úrokové sazby mezi zeměmi vyrovnávají. Protože PPP platí hlavně dlouhodobě, jde o dlouhodobý vztah; v krátkém období ho narušují odchylky reálného kurzu a rizikové prémie.

*Příklad:* πᵉ = 4 %, π*ᵉ = 2 %, i* = 3 % → očekávaná depreciace koruny ≈ 2 %, i ≈ 3 + 2 = 5 %; reálné sazby r ≈ 5 − 4 = 1 % a r* ≈ 3 − 2 = 1 % se rovnají.

### ? Očekávaná inflace v ČR je 3 %, v eurozóně 2 % a zahraniční sazba i* = 4 %. Jaká domácí sazba i odpovídá syntéze UIP a PPP?

- [ ] 3 %
- [x] 5 %
- [ ] 6 %
- [ ] 7 %

> i ≈ i* + (πᵉ − π*ᵉ) = 4 + (3 − 2) = 5 %; reálné sazby jsou pak shodné: r ≈ 5 − 3 = 2 % a r* ≈ 4 − 2 = 2 %. Hodnota 3 % vznikne opačným znaménkem.

### ? Co vyplývá ze současné platnosti UIP a relativní PPP?

- [ ] Nominální úrokové sazby jsou ve všech zemích stejné
- [ ] Nominální měnový kurz je v čase konstantní
- [x] Reálné úrokové sazby se mezi zeměmi vyrovnávají
- [ ] Inflace je ve všech zemích stejná

> Úrokový diferenciál se rovná rozdílu očekávaných inflací, takže i − πᵉ ≈ i* − π*ᵉ, tj. r ≈ r*. Nominální sazby, inflace i kurz se mezi zeměmi lišit mohou.
