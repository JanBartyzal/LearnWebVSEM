---
kind: topic
subject: manazerska-ekonomie
slug: model-is-lm-bp
name: "Model IS-LM-BP"
order: 4
---

Jednoduchý model determinace rovnovážného produktu rozšířený o vliv úrokové míry. Rovnováha na trhu produktů a služeb a křivka IS. Rovnováha na trhu peněz a ostatních finančních aktiv a křivka LM. Rovnováha platební bilance a křivka BP. Vnitřní a vnější rovnováha ekonomiky v modelu IS-LM-BP. Účinnost fiskální a monetární politiky při fixním a flexibilním měnovém kurzu v situacích dokonalé kapitálové mobility, dokonalé kapitálové imobility a nedokonalé kapitálové mobility.

## Investice závislé na úrokové míře {#investice-a-urok .explain}

Jednoduchý model důchod–výdaje bere investice jako autonomní. Model IS-LM ho rozšiřuje o vliv **úrokové míry**: investice s rostoucí i klesají, protože roste cena kapitálu (náklad financování) a méně projektů má kladnou čistou současnou hodnotu. Investiční funkce má tvar `I = I₀ − b·i`, kde I₀ jsou autonomní investice a b > 0 citlivost investic na úrokovou míru. Plánované výdaje AE = C + I(i) + G + NX pak závisejí na i a rovnovážný produkt už není určen jen autonomními výdaji, ale i úrokovou mírou z trhu peněz. Pokles i → růst I → posun AE nahoru → růst Y o multiplikátor × ΔI.

*Příklad:* C = 100 + 0,8·Y, I = 200 − 20·i, G = 100 (uzavřená ekonomika bez důchodové daně). Při i = 5 je I = 100 a Y = (100 + 100 + 100) / 0,2 = 1 500. Pokles i na 4 zvýší I o 20 a Y o 5 · 20 = 100 na 1 600.

### ? Investiční funkce je I = 300 − 25·i a výdajový multiplikátor je 4. O kolik vzroste rovnovážný produkt, klesne-li úroková míra o 2 procentní body?

- [ ] O 50
- [ ] O 100
- [x] O 200
- [ ] O 12,5

> ΔI = 25 · 2 = 50, ΔY = 4 · 50 = 200. Hodnota 50 je jen změna investic bez multiplikátoru, hodnota 100 vznikne, pokud se zapomene, že i klesla o 2 body.

### ? Proč investice v modelu IS-LM klesají s růstem úrokové míry?

- [x] Zdraží se financování a méně projektů je výnosných
- [ ] Klesne disponibilní důchod domácností
- [ ] Centrální banka sníží nabídku peněz
- [ ] Zhodnotí se domácí měna a klesne vývoz

> Úroková míra je cenou kapitálu: při vyšší i má kladnou čistou současnou hodnotu méně investičních projektů. Disponibilní důchod ani kurz nejsou v investiční funkci přímo.

## Křivka IS {#krivka-is .explain}

Křivka IS (investment–saving) je množina kombinací produktu Y a úrokové míry i, při kterých je **trh zboží a služeb v rovnováze**: plánované výdaje se rovnají produktu (AE = Y), v uzavřené ekonomice bez státu ekvivalentně I = S, ve čtyřsektorové ekonomice I + G + X = S + (T − TR) + Z. Odvozuje se z keynesiánského kříže: pro každou úrokovou míru se určí investice, z nich AE a rovnovážné Y. Nižší i znamená vyšší investice a vyšší rovnovážný produkt, proto je IS v grafu (vodorovně Y, svisle i) **klesající**. Body vpravo nad IS značí převis nabídky zboží (AE < Y, firmám rostou neplánované zásoby), body vlevo pod IS převis poptávky.

*Příklad:* C = 100 + 0,8·Y, I = 200 − 20·i, G = 100. Z podmínky Y = AE: Y = 0,8·Y + 400 − 20·i ⇒ 0,2·Y = 400 − 20·i ⇒ **IS: Y = 2 000 − 100·i**. Při i = 5 je Y = 1 500, při i = 3 je Y = 1 700.

### ? C = 50 + 0,75·Y, I = 250 − 10·i, G = 100 (bez důchodové daně, uzavřená ekonomika). Jaká je rovnice křivky IS?

- [ ] Y = 400 − 10·i
- [ ] Y = 1 600 − 10·i
- [ ] Y = 533 − 13,3·i
- [x] Y = 1 600 − 40·i

> Y = 0,75·Y + 400 − 10·i ⇒ 0,25·Y = 400 − 10·i ⇒ Y = 4 · (400 − 10·i) = 1 600 − 40·i. Multiplikátor 1/(1 − c) = 4 násobí i člen s úrokovou mírou; dělení c místo s dá 533 − 13,3·i.

### ? Bod leží vpravo nad křivkou IS. Co platí na trhu zboží?

- [ ] Plánované výdaje převyšují produkt
- [x] Plánované výdaje jsou nižší než produkt
- [ ] Trh zboží je v rovnováze, nerovnováha je na trhu peněz
- [ ] Investice převyšují úspory

> Nad IS je při daném Y úroková míra příliš vysoká, investice jsou nízké, a proto AE < Y (I < S) — vzniká převis nabídky zboží a neplánované zásoby rostou.

## Sklon křivky IS {#sklon-is .explain}

Obecně lze IS zapsat jako `Y = α·(A₀ − b·i)`, kde A₀ jsou autonomní výdaje a α výdajový multiplikátor (v tématu Model důchod–výdaje značený k); v otevřené ekonomice s důchodovou daní `α = 1/(1 − c·(1 − t) + m)`. Reakce produktu na úrokovou míru je `ΔY = −α·b·Δi`. IS je tím **plošší**, čím je **vyšší multiplikátor** (vyšší c, nižší t, nižší m) a čím **citlivější jsou investice na úrok** (vyšší b). Strmá IS naopak znamená, že změny úrokové míry produkt téměř neovlivní; v krajním případě b = 0 (investice necitlivé na úrok, tzv. investiční past) je IS svislá. Strmou IS zdůrazňují keynesiánci, plochou monetaristé.

*Příklad:* c = 0,8, t = 0, m = 0, b = 20 → α = 5 a pokles i o 1 p. b. zvýší Y o 100. Při c = 0,9 (α = 10) by stejný pokles i zvýšil Y o 200 — IS je plošší.

### ? c = 0,75, t = 0, m = 0 a citlivost investic na úrok b = 40. O kolik vzroste rovnovážný produkt, klesne-li i o 1 procentní bod?

- [ ] O 40
- [x] O 160
- [ ] O 10
- [ ] O 30

> α = 1/(1 − 0,75) = 4, ΔY = α · b · Δi = 4 · 40 · 1 = 160. Hodnota 40 ignoruje multiplikátor, 10 vznikne násobením s = 0,25 místo dělení, 30 násobením c.

### ? Co způsobí, že křivka IS bude STRMĚJŠÍ?

- [ ] Zvýšení mezního sklonu ke spotřebě c
- [ ] Vyšší citlivost investic na úrokovou míru
- [ ] Zvýšení vládních nákupů G
- [x] Zvýšení sazby důchodové daně t

> Vyšší t snižuje multiplikátor, takže stejná změna i vyvolá menší změnu Y — IS je strmější. Vyšší c i vyšší b IS zplošťují; růst G IS jen posune doprava.

## Posuny křivky IS {#posuny-is .explain}

Změna kterékoli autonomní složky výdajů při dané úrokové míře posune IS **vodorovně o α·ΔA**: doprava při růstu G, autonomní spotřeby, autonomních investic (optimismus firem) nebo autonomního čistého exportu, doleva při jejich poklesu. Zvýšení autonomních daní o ΔT posune IS doleva o c·α·ΔT (daňový multiplikátor). V otevřené ekonomice IS posouvá i **měnový kurz**: depreciace koruny (růst E) zlevní domácí zboží v zahraničí, zvýší NX a posune IS doprava, apreciace (pokles E) ji posune doleva (za předpokladu splnění Marshallovy–Lernerovy podmínky). Změna úrokové míry je pohyb **po** křivce IS, ne její posun.

*Příklad:* c = 0,8, t = 0,25, m = 0 → α = 1/(1 − 0,8 · 0,75) = 1/0,4 = 2,5. Zvýšení G o 40 posune IS doprava o 2,5 · 40 = 100.

### ? c = 0,8, t = 0,25, m = 0. Vláda sníží nákupy G o 20. Jak se posune křivka IS?

- [x] Doleva o 50
- [ ] Doleva o 100
- [ ] Doprava o 50
- [ ] Doleva o 20

> α = 1/(1 − 0,8 · (1 − 0,25)) = 2,5, posun = 2,5 · (−20) = −50. Hodnota 100 vznikne, když se zapomene na daň (α = 5).

### ? Který z následujících jevů posune křivku IS DOLEVA?

- [ ] Snížení autonomních daní
- [ ] Pokles úrokové míry
- [x] Zhodnocení koruny (pokles kurzu E)
- [ ] Růst optimismu firem a autonomních investic

> Apreciace zdraží domácí zboží pro zahraničí, sníží NX a posune IS doleva. Nižší daně a vyšší autonomní investice ji posouvají doprava, pokles i je pohyb po IS.

## Křivka LM {#krivka-lm .explain}

Křivka LM (liquidity preference – money supply) je množina kombinací Y a i, při kterých je **trh peněz v rovnováze**: reálná nabídka peněz se rovná poptávce po penězích, `M/P = L(Y, i) = k·Y − h·i`. Nabídku peněz určuje centrální banka, poptávka roste s Y (transakční a opatrnostní motiv, citlivost k) a klesá s i (náklad obětované příležitosti držby peněz, spekulační motiv, citlivost h). Při dané M/P zvýší růst Y poptávku po penězích; aby trh zůstal v rovnováze, musí úroková míra vzrůst a poptávku opět snížit — proto je LM **rostoucí**. Body vpravo pod LM značí převis poptávky po penězích, body nad LM převis nabídky. Podle Walrasova zákona je při rovnováze na trhu peněz v rovnováze i trh ostatních finančních aktiv (obligací).

*Příklad:* M/P = 250, L = 0,25·Y − 25·i ⇒ 250 = 0,25·Y − 25·i ⇒ **LM: i = 0,01·Y − 10**. Při Y = 1 500 je i = 5, při Y = 1 700 je i = 7.

### ? Reálná nabídka peněz je M/P = 400, poptávka po penězích L = 0,5·Y − 40·i. Jaká úroková míra vyrovná trh peněz při Y = 1 000?

- [ ] 22,5
- [ ] 10
- [ ] 12,5
- [x] 2,5

> 400 = 0,5 · 1 000 − 40·i ⇒ 40·i = 100 ⇒ i = 2,5. Hodnota 22,5 vznikne sečtením 500 + 400 místo odečtení, 12,5 vydělením celé transakční poptávky 500 / 40.

### ? Bod leží vpravo pod křivkou LM. Co platí na trhu peněz?

- [ ] Nabídka peněz převyšuje poptávku po penězích
- [x] Poptávka po penězích převyšuje nabídku peněz
- [ ] Plánované výdaje převyšují produkt
- [ ] Trh peněz je v rovnováze a úroková míra je stabilní

> Pod LM je při daném Y úroková míra příliš nízká (nebo při dané i produkt příliš vysoký), takže poptávka po penězích převyšuje nabídku a úroková míra má tendenci růst.

## Sklon křivky LM {#sklon-lm .explain}

Z rovnice LM `i = (k·Y − M/P)/h` plyne sklon `Δi/ΔY = k/h`. LM je tím **strmější**, čím je poptávka po penězích **citlivější na důchod** (vyšší k) a čím je **méně citlivá na úrokovou míru** (nižší h): k obnovení rovnováhy po růstu Y je pak potřeba velký růst i. Vysoká citlivost poptávky po penězích na úrok (vysoké h) naopak dělá LM plochou — malá změna i stačí vyrovnat velkou změnu transakční poptávky. Keynesiánci zdůrazňují vysoké h (plochá LM), monetaristé a klasici nízké h (strmá LM).

*Příklad:* k = 0,25, h = 25 → sklon 0,01: růst Y o 100 vyžaduje růst i o 1 p. b. Při h = 50 by stačil růst o 0,5 p. b.

### ? Poptávka po penězích je L = 0,2·Y − 50·i a nabídka peněz se nemění. O kolik musí vzrůst i, aby trh peněz zůstal v rovnováze, vzroste-li Y o 500?

- [ ] O 10 p. b.
- [ ] O 100 p. b.
- [x] O 2 p. b.
- [ ] O 0,5 p. b.

> Δi = k · ΔY / h = 0,2 · 500 / 50 = 2 p. b. Hodnota 100 je jen nárůst poptávky po penězích k · ΔY, hodnota 10 ignoruje k.

### ? Poptávka po penězích se stane citlivější na úrokovou míru (h vzroste). Jak se změní křivka LM?

- [x] Bude plošší
- [ ] Bude strmější
- [ ] Posune se doprava beze změny sklonu
- [ ] Stane se svislou

> Sklon LM je k/h; vyšší h ho snižuje. Svislá LM odpovídá opačnému krajnímu případu h = 0.

## Krajní úseky křivky LM {#useky-lm .compare}

Podle citlivosti poptávky po penězích na úrokovou míru h se rozlišují tři úseky LM:

| Úsek | Tvar LM | Citlivost h | Příčina | Fiskální politika | Monetární politika |
|---|---|---|---|---|---|
| **Keynesiánský** (likviditní past) | vodorovná | h → ∞ | při velmi nízké i subjekty drží jakékoli dodatečné peníze (očekávají růst i, tj. pokles cen obligací) | plně účinná, i neroste, žádné vytěsnění | neúčinná — růst M nesníží i |
| **Mezilehlý** | rostoucí | 0 < h < ∞ | běžný případ | částečně účinná, částečné vytěsnění | částečně účinná |
| **Klasický** | svislá | h = 0 | peníze se drží jen k transakcím (kvantitativní teorie) | neúčinná — úplné vytěsnění | plně účinná |

### ? Ekonomika je v likviditní pasti. Centrální banka zvýší nabídku peněz. Co se stane s Y a i?

- [ ] i klesne, Y vzroste
- [ ] i vzroste, Y klesne
- [x] Y ani i se nezmění
- [ ] i se nezmění, Y vzroste

> V likviditní pasti je LM vodorovná: dodatečné peníze subjekty jen drží, úroková míra neklesne, investice se nezmění a produkt také ne.

### ? LM je svislá (klasický případ). Vláda zvýší nákupy G. Co se stane?

- [ ] Y vzroste o plný multiplikátor, i se nezmění
- [ ] Y i i vzrostou, vytěsnění je jen částečné
- [ ] Y klesne, protože se sníží nabídka peněz
- [x] i vzroste, Y se nezmění (úplné vytěsnění)

> Se svislou LM je Y dáno trhem peněz. Posun IS doprava jen zvýší i, investice klesnou přesně o ΔG a produkt zůstane stejný.

## Posuny křivky LM {#posuny-lm .explain}

LM se posouvá při změně **reálné nabídky peněz M/P** nebo autonomní poptávky po penězích. Zvýšení nominální nabídky peněz (expanzivní monetární politika) nebo pokles cenové hladiny zvýší M/P a posune LM **doprava (dolů)**: při daném Y je rovnovážná i nižší o ΔM/(P·h), při dané i je rovnovážné Y vyšší o ΔM/(P·k). Snížení M, růst P nebo autonomní růst poptávky po penězích (např. vyšší preference likvidity v krizi) posunou LM **doleva (nahoru)**. Změna Y je pohyb po LM, ne její posun.

*Příklad:* L = 0,25·Y − 25·i, M/P vzroste o 50 → LM se při dané i posune doprava o 50 / 0,25 = 200; při daném Y klesne i o 50 / 25 = 2 p. b.

### ? Poptávka po penězích je L = 0,5·Y − 20·i, cenová hladina P = 1. Centrální banka zvýší M o 40. O kolik se LM posune doprava (při dané i)?

- [ ] O 20
- [x] O 80
- [ ] O 2
- [ ] O 40

> Při dané i musí růst Y pohltit dodatečné peníze: ΔY = ΔM / k = 40 / 0,5 = 80. Hodnota 20 vznikne násobením k, hodnota 2 je pokles i při daném Y (40 / 20).

### ? Co posune křivku LM DOLEVA (nahoru)?

- [x] Růst cenové hladiny P při nezměněné M
- [ ] Pokles cenové hladiny P
- [ ] Nákup státních dluhopisů centrální bankou
- [ ] Růst produktu Y

> Vyšší P sníží reálnou nabídku peněz M/P, a LM se proto posune doleva. Pokles P a nákup dluhopisů ji posouvají doprava, růst Y je pohyb po LM.

## Rovnováha v modelu IS-LM {#rovnovaha-is-lm .explain}

Průsečík IS a LM určuje jedinou kombinaci Y a i, při níž jsou **současně v rovnováze trh zboží a trh peněz** (a tedy i trh obligací). Model popisuje krátké období s **fixní cenovou hladinou P** a nevyužitými kapacitami, takže produkt je určen poptávkou. Mimo průsečík se ekonomika přizpůsobuje: na trhu peněz rychle přes úrokovou míru (ceny obligací), na trhu zboží pomaleji přes změnu produkce a zásob. Rovnovážný produkt nemusí odpovídat potenciálnímu produktu Y*.

*Příklad:* IS: Y = 2 000 − 100·i, LM: i = 0,01·Y − 10. Dosazením: Y = 2 000 − 100 · (0,01·Y − 10) = 3 000 − Y ⇒ Y = 1 500, i = 5.

### ? IS: Y = 3 000 − 200·i, LM: Y = 1 000 + 200·i. Jaký je rovnovážný produkt a úroková míra?

- [ ] Y = 2 000, i = 10
- [ ] Y = 1 500, i = 7,5
- [ ] Y = 3 000, i = 0
- [x] Y = 2 000, i = 5

> 3 000 − 200·i = 1 000 + 200·i ⇒ 400·i = 2 000 ⇒ i = 5; Y = 1 000 + 200 · 5 = 2 000. Kontrola v IS: 3 000 − 1 000 = 2 000.

### ? Ekonomika je v bodě na křivce LM, ale vpravo nad křivkou IS. Jak se bude přizpůsobovat?

- [ ] Produkt vzroste a úroková míra se zvýší
- [ ] Úroková míra klesne, produkt se nezmění
- [x] Produkt klesne a úroková míra se po LM sníží
- [ ] Produkt klesne, úroková míra vzroste

> Nad IS je AE < Y, firmám rostou zásoby a snižují produkci. S nižším Y klesá poptávka po penězích, takže se ekonomika posouvá po LM dolů k nižší i.

## Vytěsňování a účinek politik v IS-LM {#vytesnovani .explain}

**Fiskální expanze** (růst G) posune IS doprava. Vyšší produkt zvýší transakční poptávku po penězích, a protože M je dána, roste úroková míra; ta sníží investice — **vytěsňovací efekt** (crowding out). Výsledný růst Y je proto menší než α·ΔG. **Monetární expanze** posune LM doprava: úroková míra klesne, investice vzrostou a přes multiplikátor i produkt. Fiskální expanze tedy zvyšuje Y i i, monetární zvyšuje Y a snižuje i.

*Příklad:* IS: Y = 2 000 − 100·i (α = 5, b = 20), LM: i = 0,01·Y − 10, výchozí Y = 1 500, i = 5.

- G + 20: IS: Y = 2 100 − 100·i ⇒ Y = 1 550, i = 5,5. Bez vytěsnění by Y vzrostlo o 100; investice klesly o 20 · 0,5 = 10, takže ΔY = 5 · (20 − 10) = 50.
- M/P + 25: LM: i = 0,01·Y − 11 ⇒ Y = 1 550, i = 4,5.

### ? IS: Y = 1 800 − 50·i, LM: Y = 1 000 + 50·i, multiplikátor α = 4. Vláda zvýší G o 50. Jaký bude nový rovnovážný produkt?

- [ ] 1 600
- [x] 1 500
- [ ] 1 450
- [ ] 1 400

> Výchozí stav: 1 800 − 50·i = 1 000 + 50·i ⇒ i = 8, Y = 1 400. IS se posune o 4 · 50 = 200: Y = 2 000 − 50·i ⇒ i = 10, Y = 1 500. Hodnota 1 600 by platila bez vytěsnění; růst i o 2 body vytěsnil polovinu efektu.

### ? Jak se v uzavřené ekonomice (IS-LM) změní Y a i po expanzivní monetární politice?

- [x] Y vzroste, i klesne
- [ ] Y vzroste, i vzroste
- [ ] Y se nezmění, i klesne
- [ ] Y klesne, i klesne

> LM se posune doprava, úroková míra klesne, investice vzrostou a s nimi přes multiplikátor i produkt. Y i i současně roste po fiskální expanzi.

## Účinnost politik podle sklonů IS a LM {#sklony-a-ucinnost .compare}

Účinnost politik na produkt v uzavřené ekonomice (IS-LM) závisí na sklonech křivek:

| | Fiskální politika účinnější | Monetární politika účinnější |
|---|---|---|
| **Křivka LM** | plochá (vysoké h) — malý růst i, malé vytěsnění | strmá (nízké h) — růst M výrazně sníží i |
| **Křivka IS** | strmá (nízké b) — investice málo reagují na růst i | plochá (vysoké b, vysoký α) — pokles i výrazně zvýší Y |
| **Krajní případ** | likviditní past (vodorovná LM) nebo b = 0 (svislá IS) | klasická (svislá) LM |
| **Dopad na i** | i roste | i klesá |

### ? Investice jsou téměř necitlivé na úrokovou míru (IS je velmi strmá). Která politika ovlivní produkt výrazněji?

- [ ] Monetární, protože pokles i silně zvýší investice
- [ ] Obě stejně, sklon IS na účinnost vliv nemá
- [ ] Monetární, protože LM se posune doprava
- [x] Fiskální, protože vytěsnění investic je malé

> Při nízkém b růst i po fiskální expanzi investice téměř nesníží (malé vytěsnění), zatímco pokles i po monetární expanzi je téměř nezvýší.

## Platební bilance {#platebni-bilance .explain}

Platební bilance zaznamenává transakce mezi rezidenty a nerezidenty za dané období. Podle metodiky MMF (BPM6) ji tvoří **běžný účet** (zboží a služby, prvotní a druhotné důchody), **kapitálový účet** (kapitálové transfery) a **finanční účet** (přímé, portfoliové a ostatní investice, finanční deriváty a rezervní aktiva). Díky podvojnému zápisu je jako celek vždy vyrovnaná. V modelu IS-LM-BP se zjednodušeně sleduje saldo `BP = NX(Y, E) + KF(i − i*)` bez změny devizových rezerv: čistý export klesá s domácím Y (dovoz) a roste s E, čistý příliv kapitálu KF roste s rozdílem domácí a zahraniční úrokové míry. Přebytek BP znamená převis nabídky deviz — růst devizových rezerv nebo tlak na zhodnocení koruny; deficit naopak.

*Příklad:* Česká ekonomika roste rychleji než zahraničí, roste dovoz a zhoršuje se saldo zboží a služeb. Pokud jsou úrokové sazby ČNB nad sazbami ECB, přitéká portfoliový kapitál, který deficit běžného účtu financuje.

### ? Domácí produkt Y vzroste při nezměněných i, i* a E. Co se stane s platební bilancí?

- [ ] Vzroste vývoz a saldo se zlepší
- [ ] Saldo se nezmění, závisí jen na úrokových mírách
- [x] Vzroste dovoz a saldo se zhorší směrem k deficitu
- [ ] Přiteče kapitál a vznikne přebytek

> Dovoz roste s domácím důchodem (mezní sklon k dovozu m), čistý export klesá. Kapitálové toky závisí na i − i*, které se nezměnilo.

### ? Zahraniční fond koupí akcie české firmy jako portfoliovou investici. Do kterého účtu platební bilance transakce patří?

- [ ] Běžný účet — prvotní důchody
- [x] Finanční účet
- [ ] Kapitálový účet
- [ ] Běžný účet — služby

> Nákup cenných papírů nerezidentem je portfoliová investice ve finančním účtu. Kapitálový účet zahrnuje jen kapitálové transfery, prvotní důchody by byly až vyplacené dividendy.

## Křivka BP {#krivka-bp .explain}

Křivka BP je množina kombinací Y a i, při kterých je **platební bilance vyrovnaná** (při daném E a i*). Při nedokonalé mobilitě kapitálu je **rostoucí**: vyšší Y zvýší dovoz a zhorší čistý export, a vyrovnání proto vyžaduje vyšší úrokovou míru, která přiláká kapitál. Body **nad** BP značí **přebytek** (při daném Y je i vysoká, kapitál přitéká), body **pod** BP **deficit**. BP se posouvá **doprava (dolů)** při depreciaci koruny (růst E zvýší NX) nebo poklesu i*, **doleva (nahoru)** při apreciaci koruny nebo růstu zahraniční úrokové míry i*.

*Příklad:* NX = 300 − 0,1·Y, KF = 50·(i − i*), i* = 4. BP: 300 − 0,1·Y + 50·(i − 4) = 0 ⇒ i = 0,002·Y − 2. Při Y = 3 000 je NX = 0 a stačí i = i* = 4; při Y = 4 000 je NX = −100 a vyrovnání vyžaduje i = 6.

### ? NX = 200 − 0,2·Y, KF = 100·(i − i*), i* = 3. Jakou úrokovou míru vyžaduje vyrovnaná platební bilance při Y = 1 500?

- [x] 4
- [ ] 3
- [ ] 2
- [ ] 5

> NX = 200 − 300 = −100, takže je potřeba čistý příliv kapitálu 100: 100·(i − 3) = 100 ⇒ i = 4. Hodnota 3 je jen i*, hodnota 2 vznikne opačným znaménkem.

### ? Ekonomika se nachází v bodě pod křivkou BP. Co platí?

- [ ] PB je v přebytku a devizové rezervy rostou
- [ ] PB je vyrovnaná, nerovnováha je jen na trhu peněz
- [ ] PB je v přebytku díky vysokému čistému exportu
- [x] PB je v deficitu, i je pro dané Y příliš nízká

> Pod BP je při daném produktu úroková míra nižší, než je nutné k přilákání kapitálu, který by pokryl saldo běžného účtu — platební bilance je v deficitu.

### ? Co posune křivku BP doprava (dolů)?

- [ ] Růst zahraniční úrokové míry i*
- [x] Depreciace koruny, tj. růst kurzu E
- [ ] Apreciace koruny, tj. pokles kurzu E
- [ ] Růst domácího produktu Y

> Depreciace zvýší čistý export, takže vyrovnaná PB je možná při vyšším Y nebo nižší i. Růst i* a apreciace posouvají BP nahoru, růst Y je pohyb po BP.

## Sklon křivky BP a mobilita kapitálu {#sklon-bp .compare}

Sklon BP je dán poměrem mezního sklonu k dovozu m a citlivosti kapitálových toků na úrokový diferenciál f: `Δi/ΔY = m/f`.

| Mobilita kapitálu | Citlivost f | Tvar BP | Interpretace |
|---|---|---|---|
| **Dokonalá** | f → ∞ | vodorovná na úrovni i = i* | nepatrný rozdíl i − i* vyvolá neomezený tok kapitálu; jakékoli saldo NX se vyrovná při i = i* |
| **Nedokonalá** | 0 < f < ∞ | rostoucí; tím plošší, čím vyšší mobilita | vyšší Y (dovoz) vyžaduje vyšší i pro příliv kapitálu |
| **Nulová** (dokonalá imobilita) | f = 0 | svislá při Y, kdy NX = 0 | kapitál na i nereaguje; PB = běžný účet a závisí jen na Y a E |

Pro výsledky politik při nedokonalé mobilitě je podstatné, zda je BP **plošší** než LM (vyšší mobilita), nebo **strmější** (nízká mobilita).

### ? Kapitálové toky přestanou reagovat na úrokový diferenciál (f = 0). Jaký tvar bude mít křivka BP?

- [ ] Vodorovná na úrovni zahraniční úrokové míry i*
- [ ] Rostoucí, strmější než LM
- [x] Svislá při produktu, kdy je čistý export nulový
- [ ] Klesající, rovnoběžná s IS

> Bez kapitálových toků je PB tvořena jen běžným účtem, který je vyrovnaný při jediné úrovni Y (pro dané E) bez ohledu na i.

### ? V malé otevřené ekonomice je mobilita kapitálu dokonalá. Jaká bude domácí úroková míra v rovnováze?

- [x] Rovná zahraniční úrokové míře i*
- [ ] Vyšší než i*, aby kapitál přitékal
- [ ] Určená jen domácí nabídkou peněz
- [ ] Nižší než i*, aby kapitál odtékal

> Při dokonalé mobilitě by jakýkoli rozdíl i − i* vyvolal neomezené toky kapitálu, proto je BP vodorovná a v rovnováze platí i = i*.

## Vnitřní a vnější rovnováha {#vnitrni-vnejsi-rovnovaha .explain}

V modelu IS-LM-BP je **vnitřní rovnováha** stav současné rovnováhy na trhu zboží a na trhu peněz (průsečík IS a LM), **vnější rovnováha** stav vyrovnané platební bilance (bod na BP). **Celková rovnováha** nastává, když se IS, LM i BP protínají v jednom bodě. Leží-li průsečík IS-LM **nad** BP, má ekonomika přebytek PB; leží-li **pod** BP, deficit. Taková situace není trvalá — přizpůsobí se buď nabídka peněz (fixní kurz), nebo měnový kurz (plovoucí kurz). V hospodářské politice se vnitřní rovnováha chápe i šířeji jako produkt na úrovni potenciálu Y* při stabilních cenách a vnější jako udržitelné saldo běžného účtu.

*Příklad:* Průsečík IS a LM je při Y = 1 500 a i = 5, ale vyrovnaná PB vyžaduje při Y = 1 500 jen i = 4. Ekonomika je nad BP, kapitál přitéká a PB je v přebytku.

### ? Průsečík IS a LM leží pod křivkou BP. V jaké situaci ekonomika je?

- [ ] V celkové rovnováze, protože se protínají IS a LM
- [x] Ve vnitřní rovnováze, ale s deficitem platební bilance
- [ ] Ve vnitřní rovnováze a s přebytkem platební bilance
- [ ] Ve vnější rovnováze bez rovnováhy na trhu peněz

> Průsečík IS-LM znamená vnitřní rovnováhu; pod BP je úroková míra pro daný produkt příliš nízká a platební bilance je v deficitu.

## Přizpůsobení při fixním a plovoucím kurzu {#prizpusobeni-pb .compare}

Nerovnováhu platební bilance ekonomika odstraní podle kurzového režimu:

| | Fixní kurz | Plovoucí kurz |
|---|---|---|
| **Kdo vyrovnává PB** | centrální banka devizovými intervencemi | trh změnou kurzu E |
| **Přebytek PB** | CB nakupuje devizy za korunu → rezervy a **M rostou** → LM doprava | poptávka po koruně → **apreciace (E klesá)** → NX klesá → IS a BP doleva |
| **Deficit PB** | CB prodává devizy a stahuje korunu → rezervy a **M klesají** → LM doleva | **depreciace (E roste)** → NX roste → IS a BP doprava |
| **Nabídka peněz** | **endogenní** — CB ji nemůže samostatně řídit | exogenní — řízena CB |
| **Hlavní kanál** | změna M (posun LM) | kurzový kanál přes NX (posun IS a BP) |

### ? Při fixním kurzu má ekonomika přebytek platební bilance. Co udělá centrální banka a co se stane s LM?

- [ ] Prodává devizy, M klesá, LM se posune doleva
- [ ] Nakupuje devizy, M klesá, LM se posune doleva
- [ ] Nezasahuje, koruna posílí a IS se posune doleva
- [x] Nakupuje devizy, M roste, LM se posune doprava

> Přebytek znamená převis nabídky deviz; aby koruna neposílila, CB devizy skupuje za korunu, měnová báze a M rostou a LM se posouvá doprava.

### ? Při plovoucím kurzu má ekonomika deficit platební bilance. Co se stane?

- [ ] Koruna posílí (E klesne), NX klesne a IS se posune doleva
- [ ] Centrální banka prodá devizy a M klesne
- [x] Koruna oslabí (E vzroste), NX vzroste a IS se posune doprava
- [ ] Kurz se nezmění, sníží se devizové rezervy

> Při deficitu převyšuje poptávka po devizách nabídku, koruna oslabí. Depreciace zvýší čistý export a posune IS (i BP) doprava. Intervence a změna rezerv patří k fixnímu kurzu.

## Sterilizace devizových intervencí {#sterilizace .term}

Sterilizace je operace centrální banky, kterou kompenzuje dopad devizových intervencí na měnovou bázi a nabídku peněz — např. při nákupu deviz (růst M) současně prodá cenné papíry na volném trhu nebo stáhne likviditu z bank, takže M se nezmění. Umožňuje dočasně spojit fixní kurz s vlastní monetární politikou, ale při deficitu ji omezuje výše devizových rezerv a při dokonalé mobilitě kapitálu je prakticky neproveditelná, protože kapitálové toky by byly neomezené.

### ? Centrální banka nakupuje devizy, aby zabránila posílení koruny, a zároveň stahuje z bank přebytečnou likviditu. Jak se tato kombinace nazývá?

- [x] Sterilizovaná devizová intervence
- [ ] Nesterilizovaná devizová intervence
- [ ] Kvantitativní uvolňování
- [ ] Devalvace měny

> Stažením likvidity CB neutralizuje růst měnové báze vyvolaný nákupem deviz — intervence je sterilizovaná. Bez stažení likvidity by šlo o nesterilizovanou intervenci.

### ? Proč je sterilizace při fixním kurzu a dokonalé mobilitě kapitálu dlouhodobě neudržitelná?

- [ ] Centrální banka nesmí obchodovat s cennými papíry
- [x] Úrokový diferenciál vyvolá neomezené toky kapitálu
- [ ] Sterilizace automaticky mění měnový kurz
- [ ] Při fixním kurzu se nabídka peněz nemění

> Sterilizace udrží i ≠ i*, a při dokonalé mobilitě to vyvolá neomezený příliv či odliv kapitálu, který by CB musela neustále intervencemi a sterilizací pokrývat.

## Model Mundell–Fleming: předpoklady {#mundell-fleming .explain}

Model Mundell–Fleming (R. Mundell a J. M. Fleming, počátek 60. let) je model IS-LM-BP pro **malou otevřenou ekonomiku**: zahraniční úroková míra i* a zahraniční důchod jsou dané, **cenová hladina je fixní** (krátké období), kurzová očekávání jsou statická (nečeká se změna kurzu) a čistý export závisí na kurzu E a domácím Y. Výsledky politik závisí na **kurzovém režimu** (fixní / plovoucí) a na **mobilitě kapitálu** (dokonalá / nedokonalá / nulová). Klíčové mechanismy: při fixním kurzu je nabídka peněz **endogenní** (intervence CB), při plovoucím působí **kurzový kanál** přes NX. V základní verzi s dokonalou mobilitou platí i = i*.

*Příklad:* Pro Českou republiku jako malou otevřenou ekonomiku jsou úroková míra eurozóny (i*) i poptávka v Německu dány zvenčí. ČNB od roku 1997 uplatňuje řízený plovoucí kurz, s výjimkou kurzového závazku v letech 2013–2017.

### ? Který předpoklad NEPATŘÍ k základnímu modelu Mundell–Fleming?

- [ ] Malá otevřená ekonomika
- [ ] Daná zahraniční úroková míra i*
- [x] Pružná cenová hladina
- [ ] Statická kurzová očekávání

> Model Mundell–Fleming je krátkodobý a předpokládá fixní cenovou hladinu; produkt je určen poptávkou. Ostatní možnosti jsou jeho základní předpoklady.

## Fixní kurz a dokonalá mobilita kapitálu {#mf-fixni-dokonala .explain}

BP je vodorovná při i = i* a CB musí udržet kurz. **Fiskální expanze** (G↑) posune IS doprava a vyvolá tlak na růst i nad i*. Kapitál přitéká, koruna by posilovala, a CB proto nakupuje devizy a **zvyšuje M** — LM se posune doprava, až se i vrátí na i*. Úroková míra neroste, k vytěsnění nedochází a Y vzroste o **plný multiplikátor**: fiskální politika je **maximálně účinná**. **Monetární expanze** (M↑) sníží i pod i*, kapitál odtéká, koruna by oslabovala; CB prodává devizy, stahuje korunu a M se vrátí na původní úroveň — monetární politika je **neúčinná**, změní se jen složení měnové báze (méně devizových rezerv).

*Příklad:* α = 2,5, G vzroste o 40 → Y vzroste o 100, i = i*, E beze změny; M vzroste právě o tolik, aby byl trh peněz při vyšším Y a i = i* v rovnováze.

### ? Fixní kurz, dokonalá mobilita kapitálu, multiplikátor α = 2. Vláda zvýší G o 50. Co se stane?

- [ ] Y vzroste méně než o 100, i vzroste
- [ ] Y se nezmění, koruna posílí
- [ ] Y vzroste o 100, i se nezmění, M klesne
- [x] Y vzroste o 100, i se nezmění, M vzroste

> Tlak na růst i vyvolá příliv kapitálu; CB brání posílení koruny nákupem deviz, M roste a i zůstává na i*. Bez vytěsnění ΔY = α · ΔG = 2 · 50 = 100.

### ? Fixní kurz, dokonalá mobilita. Centrální banka zvýší nabídku peněz nákupem dluhopisů. Jaký je konečný výsledek?

- [x] Y, i i M se nezmění, ubude rezerv
- [ ] Y vzroste, i klesne, koruna oslabí
- [ ] Y vzroste, i zůstane na úrovni i*
- [ ] Y klesne kvůli odlivu kapitálu

> Pokles i pod i* vyvolá odliv kapitálu; k udržení kurzu CB prodává devizy a stahuje korunu, dokud se M nevrátí na původní úroveň. Změní se jen struktura měnové báze.

## Plovoucí kurz a dokonalá mobilita kapitálu {#mf-plovouci-dokonala .explain}

**Fiskální expanze** posune IS doprava a vyvolá tlak na růst i. Příliv kapitálu způsobí **apreciaci** koruny (E klesá), čistý export klesá a IS se posouvá zpět doleva, dokud se i nevrátí na i*. Protože se LM nezměnila a i = i*, zůstane i Y na původní úrovni: růst G **úplně vytěsní čistý export** (ΔNX = −ΔG) — fiskální politika je **neúčinná**. **Monetární expanze** posune LM doprava, i klesá pod i*, kapitál odtéká a koruna **depreciuje** (E roste). Vyšší NX posune IS doprava, až se i vrátí na i* při vyšším Y — monetární politika je **maximálně účinná** a působí kurzovým kanálem.

*Příklad:* Vláda zvýší G o 30. Koruna posílí natolik, že NX klesne o 30; Y, i i M zůstanou beze změny, změní se jen složení poptávky (více G, méně NX).

### ? Plovoucí kurz, dokonalá mobilita. Vláda zvýší vládní nákupy. Co se stane s Y, i a E?

- [ ] Y vzroste, i se nezmění, E vzroste
- [x] Y a i se nezmění, E klesne (koruna posílí)
- [ ] Y vzroste, i vzroste, E se nezmění
- [ ] Y se nezmění, i vzroste, E vzroste

> Tlak na růst i přiláká kapitál a koruna posílí; nižší NX posune IS zpět. Při nezměněné LM a i = i* musí být Y původní — čistý export je úplně vytěsněn.

### ? Plovoucí kurz, dokonalá mobilita. Centrální banka zvýší nabídku peněz. Přes jaký kanál výsledně zvýší produkt?

- [ ] Trvalý pokles i zvýší investice
- [ ] Apreciace koruny zlevní dovoz
- [x] Depreciace koruny zvýší čistý export
- [ ] Příliv kapitálu zvýší devizové rezervy

> Pokles i pod i* vyvolá odliv kapitálu a oslabení koruny; vyšší NX posune IS doprava. V novém rovnovážném stavu je opět i = i*, takže efekt nejde přes trvale nižší úrokovou míru.

## Nulová mobilita kapitálu {#mf-nulova-mobilita .explain}

Při dokonalé imobilitě kapitálu je BP svislá: platební bilance je jen běžný účet a je vyrovnaná při jediném Y (pro dané E). **Fixní kurz:** fiskální expanze zvýší Y, vzroste dovoz a vznikne deficit; CB prodává devizy, M klesá a LM se posouvá doleva, dokud se Y nevrátí na úroveň BP. Výsledkem je stejné Y a vyšší i — investice jsou **úplně vytěsněny** a fiskální politika je **neúčinná**. Monetární expanze vyvolá deficit a pokles M zpět — je také **neúčinná**. **Plovoucí kurz:** deficit vyvolaný růstem Y (po fiskální i monetární expanzi) způsobí depreciaci, ta zvýší NX a posune IS i BP doprava. Obě politiky jsou **účinné** a kurzový kanál jejich vliv na Y posiluje.

*Příklad:* Při fixním kurzu a nulové mobilitě zvýší vláda G. Krátkodobě Y vzroste, ale deficit běžného účtu postupně odčerpá devizové rezervy a M; konečný produkt je stejný jako na počátku, jen úroková míra je vyšší a investice nižší.

### ? Fixní kurz, nulová mobilita kapitálu. Vláda zvýší G. Jaký je konečný výsledek?

- [ ] Y vzroste o plný multiplikátor, i se nezmění
- [ ] Y vzroste, i vzroste, rezervy vzrostou
- [ ] Y ani i se nezmění, koruna oslabí
- [x] Y se nezmění, i vzroste, rezervy klesnou

> Růst Y vyvolá deficit běžného účtu; CB prodává devizy, M klesá a LM se posouvá doleva, dokud se Y nevrátí na úroveň svislé BP. Vyšší i úplně vytěsní investice.

### ? Plovoucí kurz, nulová mobilita kapitálu. Centrální banka zvýší nabídku peněz. Co se stane?

- [x] Y vzroste a koruna oslabí
- [ ] Y se nezmění, odliv kapitálu oslabí korunu
- [ ] Y vzroste, koruna posílí a vznikne přebytek běžného účtu
- [ ] Y klesne, protože CB ztratí devizové rezervy

> Vyšší M sníží i a zvýší Y, roste dovoz a vzniká deficit. Koruna oslabí, NX vzroste a IS i BP se posunou doprava — produkt je vyšší a běžný účet opět vyrovnaný. Kapitál při nulové mobilitě neodtéká.

## Nedokonalá mobilita kapitálu {#mf-nedokonala .explain}

BP je rostoucí a výsledek **fiskální politiky** závisí na tom, zda je BP plošší, nebo strmější než LM. Fiskální expanze zvýší Y i i: je-li BP **plošší než LM** (vyšší mobilita), převáží příliv kapitálu a vznikne **přebytek**; je-li **strmější** (nízká mobilita), převáží růst dovozu a vznikne **deficit**.

- **Fixní kurz:** přebytek zvýší M (LM doprava) a fiskální politika je účinnější než v uzavřené ekonomice; deficit sníží M a účinnost oslabí, Y však vzroste. Monetární politika je **neúčinná** (deficit → pokles M zpět).
- **Plovoucí kurz:** přebytek vyvolá apreciaci a část efektu se vytěsní přes NX; deficit vyvolá depreciaci, která účinek posílí. Monetární expanze vždy vyvolá deficit (nižší i i vyšší Y) a depreciaci — je **účinná**.

Obecně: čím vyšší mobilita kapitálu, tím je fiskální politika účinnější při fixním a méně účinná při plovoucím kurzu.

*Příklad:* Fixní kurz, BP plošší než LM: po zvýšení G vzroste i, přiteče kapitál, CB nakupuje devizy a M roste — vytěsnění investic je menší než v uzavřené ekonomice.

### ? Fixní kurz, nedokonalá mobilita, BP je plošší než LM. Vláda zvýší G. Co se stane s nabídkou peněz a produktem?

- [ ] M klesne a Y se vrátí na původní úroveň
- [x] M vzroste a Y vzroste více než v uzavřené ekonomice
- [ ] M se nezmění a Y vzroste stejně jako v uzavřené ekonomice
- [ ] M vzroste, ale Y se nezmění kvůli apreciaci

> Při vysoké mobilitě převáží příliv kapitálu a vznikne přebytek; CB brání posílení koruny nákupem deviz, M roste a LM se posouvá doprava, což tlumí vytěsnění.

### ? Plovoucí kurz, nízká mobilita kapitálu (BP strmější než LM). Vláda zvýší G. Co se stane s kurzem a účinkem na Y?

- [ ] Koruna posílí a účinek na Y se oslabí
- [ ] Kurz se nezmění, CB intervencemi sníží M
- [x] Koruna oslabí a účinek na Y se posílí
- [ ] Koruna oslabí, ale Y se vrátí na původní úroveň

> Při nízké mobilitě převáží růst dovozu nad přílivem kapitálu a vznikne deficit. Depreciace zvýší NX a posune IS dál doprava, takže fiskální expanze je účinnější.

## Souhrn: účinnost politik v modelu Mundell–Fleming {#mf-souhrn .compare}

Účinnost expanzivní politiky na produkt Y v malé otevřené ekonomice (krátké období, fixní P):

| Mobilita kapitálu | Fixní kurz — fiskální | Fixní kurz — monetární | Plovoucí kurz — fiskální | Plovoucí kurz — monetární |
|---|---|---|---|---|
| **Dokonalá** (BP vodorovná) | **plně účinná** — intervence zvýší M, bez vytěsnění | **neúčinná** — intervence vrátí M zpět | **neúčinná** — apreciace vytěsní NX | **plně účinná** — depreciace zvýší NX |
| **Nedokonalá** (BP rostoucí) | **účinná**, tím více, čím vyšší mobilita | **neúčinná** (dočasně jen se sterilizací) | **účinná**, tím méně, čím vyšší mobilita | **účinná**, depreciace účinek posiluje |
| **Nulová** (BP svislá) | **neúčinná** — deficit sníží M, vytěsnění přes i | **neúčinná** — deficit sníží M | **účinná**, depreciace účinek posiluje | **účinná**, depreciace účinek posiluje |

Pravidlo: **při fixním kurzu je monetární politika vždy neúčinná** (nabídka peněz je endogenní), při plovoucím kurzu je vždy účinná. Fiskální politika je nejúčinnější při fixním kurzu a dokonalé mobilitě, neúčinná při plovoucím kurzu a dokonalé mobilitě a při fixním kurzu a nulové mobilitě. „Neúčinná" se týká produktu Y, ne nutně úrokové míry nebo struktury poptávky.

### ? Ve které kombinaci je fiskální expanze nejúčinnější?

- [ ] Plovoucí kurz a dokonalá mobilita kapitálu
- [ ] Fixní kurz a nulová mobilita kapitálu
- [ ] Plovoucí kurz a nedokonalá mobilita kapitálu
- [x] Fixní kurz a dokonalá mobilita kapitálu

> Při fixním kurzu a dokonalé mobilitě CB intervencemi zvyšuje M, i zůstává na i* a Y roste o plný multiplikátor. Při plovoucím kurzu a dokonalé mobilitě je fiskální politika naopak neúčinná.

### ? Země chce stabilizovat produkt monetární politikou. Který kurzový režim to umožní?

- [x] Plovoucí kurz při jakékoli mobilitě kapitálu
- [ ] Fixní kurz s dokonalou mobilitou kapitálu
- [ ] Fixní kurz s nulovou mobilitou kapitálu
- [ ] Fixní kurz s nedokonalou mobilitou bez sterilizace

> Při fixním kurzu je nabídka peněz endogenní — intervence na obranu kurzu vrátí M zpět. Jen plovoucí kurz dává centrální bance kontrolu nad M a kurzový kanál navíc účinek posiluje.

### ? Ekonomika s dokonalou mobilitou kapitálu přejde od fixního k plovoucímu kurzu. Jak se změní účinnost politik?

- [ ] Fiskální se stane účinnou, monetární ztratí účinnost
- [x] Monetární se stane účinnou, fiskální ztratí účinnost
- [ ] Obě zůstanou stejně účinné
- [ ] Obě ztratí účinnost

> Při fixním kurzu a dokonalé mobilitě je účinná jen fiskální politika, při plovoucím jen monetární — role obou politik se prohodí.
