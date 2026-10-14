---
kind: topic
subject: manazerska-ekonomie
slug: model-dynamicke-agregatni-poptavky-a-dynamicke
name: "Model dynamické agregátní poptávky a dynamické agregátní nabídky"
order: 9
---

Reakční funkce centrální banky. Model IS-MR a odvození dynamické agregátní poptávky. Dynamická agregátní nabídka ve velmi krátkém, krátkém a dlouhém období. Ekonomické šoky a přizpůsobovací mechanismy v modelu DAD-DAS.

## Model DAD-DAS a použité pojetí {#dad-das-pojeti .explain}

Model DAD-DAS (dynamická agregátní poptávka a dynamická agregátní nabídka) popisuje krátkodobé kolísání produktu a inflace v ekonomice, kde centrální banka (CB) cíluje inflaci a řídí úrokovou sazbu. Na rozdíl od statického modelu AD-AS je na svislé ose **míra inflace π** (ne cenová hladina P) a na vodorovné **produkt Y**. Tyto karty drží pojetí podle Mankiwa (*Macroeconomics*, dynamický model AD-AS): **DAD** vzniká spojením IS křivky (výdaje závisí na reálné úrokové míře r) s **reakční funkcí CB** (Taylorovo pravidlo), **DAS** je Phillipsova křivka s adaptivními očekáváními. Model IS-MR (Carlin & Soskice) slouží k odvození, jak reakci volí optimalizující CB — jeho klesající MR křivka v prostoru (Y, π) hraje obdobnou roli jako DAD. Mezera výstupu (Y − Y*)/Y* se ve všech vzorcích dosazuje v procentech, model se řeší po obdobích (t = 0, 1, 2…).

*Příklad:* Po zdražení ropy se DAS posune nahoru: inflace vzroste, produkt klesne pod Y* a CB se pohybuje po DAD — na vyšší inflaci reaguje vyšší reálnou sazbou.

### ? Co je v grafu modelu DAD-DAS na svislé ose?

- [ ] Cenová hladina P
- [ ] Nominální úroková míra i
- [x] Míra inflace π
- [ ] Reálná úroková míra r

> Dynamický model pracuje s inflací π a produktem Y. Cenová hladina P je na svislé ose statického modelu AD-AS, úrokové míry na svislé ose IS křivky.

### ? Čím je v modelu DAD-DAS nahrazen trh peněz (LM křivka) ze statického modelu?

- [x] Reakční funkcí CB pro úrokovou sazbu
- [ ] Kvantitativní rovnicí MV = PY s pevným M
- [ ] Phillipsovou křivkou s adaptivními očekáváními
- [ ] Podmínkou nekryté úrokové parity

> CB nestanovuje množství peněz, ale úrokovou sazbu podle pravidla (Taylorovo pravidlo, MR křivka). Phillipsova křivka v modelu tvoří DAS, ne poptávkovou stranu.

## Cílování inflace {#cilovani-inflace .term}

Cílování inflace (inflation targeting) je režim měnové politiky, v němž centrální banka veřejně vyhlásí **číselný inflační cíl π*** a úrokové sazby nastavuje podle **prognózy** inflace tak, aby se inflace vrátila k cíli v horizontu, kdy měnová politika nejvíce působí. ČNB cíluje inflaci od roku 1998, od roku 2010 je cílem **2 % s tolerančním pásmem ±1 p. b.** (horizont měnové politiky zhruba 12–18 měsíců, hlavním nástrojem je 2T repo sazba); ECB má od roku 2021 symetrický cíl 2 % ve střednědobém horizontu.

### ? Jaký inflační cíl má ČNB od roku 2010?

- [ ] 3 % s tolerančním pásmem ±1 p. b.
- [ ] Inflace pod 2 %, ale blízko 2 %
- [ ] 1 % bez tolerančního pásma
- [x] 2 % s tolerančním pásmem ±1 p. b.

> Od ledna 2010 cíluje ČNB 2 % ±1 p. b. (v letech 2006–2009 to byla 3 % ±1 p. b.). Formulace „pod, ale blízko 2 %" byla cílem ECB do roku 2021.

### ? Proč centrální banka při cílování inflace reaguje na prognózu inflace, a ne jen na její aktuální hodnotu?

- [ ] Aktuální inflaci statistické úřady nezveřejňují
- [x] Změna sazeb působí na inflaci se zpožděním
- [ ] Prognóza bývá vždy nižší než aktuální inflace
- [ ] Inflační cíl platí jen pro jádrovou inflaci

> Transmisní mechanismus měnové politiky trvá několik čtvrtletí (u ČNB zhruba 12–18 měsíců), proto musí CB reagovat na to, jaká inflace se očekává v tomto horizontu.

## Reakční funkce centrální banky {#reakcni-funkce .term}

Reakční funkce centrální banky (monetary policy rule) je pravidlo, podle kterého CB nastavuje svůj nástroj — **krátkodobou úrokovou sazbu** — v závislosti na stavu ekonomiky, typicky na **odchylce inflace od cíle (π − π*)** a **mezeře výstupu (Y − Y*)/Y***. Může být zadaná empiricky (Taylorovo pravidlo), nebo odvozená z minimalizace ztrátové funkce CB (MR křivka v modelu IS-MR); nabídka peněz je přitom endogenní — CB dodá tolik peněz, kolik odpovídá zvolené sazbě.

### ? Na které veličiny standardní reakční funkce CB Taylorova typu reaguje?

- [ ] Na růst peněžní zásoby a měnový kurz
- [ ] Na saldo státního rozpočtu a nezaměstnanost
- [x] Na odchylku inflace od cíle a mezeru výstupu
- [ ] Na ceny akcií a dlouhodobé úrokové sazby

> Taylorovo pravidlo i MR křivka vážou sazbu na odchylku inflace od cíle a na odchylku produktu od potenciálu.

### ? Jakou roli má nabídka peněz v modelu, kde CB řídí ekonomiku reakční funkcí pro úrokovou sazbu?

- [x] Je endogenní, CB ji přizpůsobí zvolené sazbě
- [ ] Je pevně daná a sama určuje úrokovou míru
- [ ] Roste konstantním tempem podle Friedmanova pravidla
- [ ] Určují ji výhradně komerční banky bez vlivu CB

> Když CB cílí úrokovou sazbu, musí na mezibankovním trhu dodat (nebo stáhnout) takové množství likvidity, aby se sazba udržela na zvolené úrovni — peníze se stávají endogenní veličinou.

## Taylorovo pravidlo {#taylorovo-pravidlo .explain}

Taylorovo pravidlo (J. B. Taylor, 1993) je jednoduchá reakční funkce, která dobře popisovala chování amerického Fedu:

`i = r* + π + 0,5 · (π − π*) + 0,5 · (Y − Y*)/Y*`

kde r* je **přirozená (neutrální) reálná úroková míra**, při níž je produkt na potenciálu, π* inflační cíl a mezera výstupu se dosazuje v procentech. Taylor původně použil r* = 2 % a π* = 2 %. Je-li inflace na cíli a produkt na potenciálu, je sazba neutrální: i = r* + π*. Odečtením inflace dostaneme **reálnou sazbu** r = i − π = r* + 0,5 · (π − π*) + 0,5 · (Y − Y*)/Y* (při adaptivních očekáváních se očekávaná inflace rovná současné).

*Příklad:* r* = 2 %, π* = 2 %, π = 4 %, produkt 1 % nad potenciálem → i = 2 + 4 + 0,5 · 2 + 0,5 · 1 = 7,5 %; reálná sazba r = 7,5 − 4 = 3,5 %.

### ? r* = 2 %, π* = 2 %, inflace je 3 % a produkt je 2 % pod potenciálem. Jakou nominální sazbu doporučuje Taylorovo pravidlo?

- [ ] 6,5 %
- [ ] 5,5 %
- [ ] 1,5 %
- [x] 4,5 %

> i = 2 + 3 + 0,5 · (3 − 2) + 0,5 · (−2) = 2 + 3 + 0,5 − 1 = 4,5 %. Hodnota 6,5 % vznikne přičtením záporné mezery s kladným znaménkem, 5,5 % vynecháním mezery výstupu.

### ? Inflace vzroste o 2 p. b., mezera výstupu se nezmění. O kolik se podle Taylorova pravidla změní nominální a reálná sazba?

- [ ] Nominální vzroste o 1 p. b., reálná klesne o 1 p. b.
- [x] Nominální vzroste o 3 p. b., reálná o 1 p. b.
- [ ] Nominální vzroste o 2 p. b., reálná se nezmění
- [ ] Nominální vzroste o 4 p. b., reálná o 2 p. b.

> Inflace je v pravidle dvakrát: celkový koeficient je 1 + 0,5 = 1,5, takže Δi = 1,5 · 2 = 3 p. b. a Δr = Δi − Δπ = 3 − 2 = 1 p. b.

### ? r* = 2 %, π* = 2 %, inflace je 5 % a produkt je 1 % nad potenciálem. Jakou reálnou úrokovou míru implikuje Taylorovo pravidlo?

- [ ] 9 %
- [ ] 3,5 %
- [x] 4 %
- [ ] 2 %

> r = r* + 0,5 · (π − π*) + 0,5 · mezera = 2 + 0,5 · 3 + 0,5 · 1 = 4 %. Nominální sazba je i = r + π = 9 %; 3,5 % vznikne vynecháním mezery výstupu.

## Taylorův princip {#tayloruv-princip .explain}

Taylorův princip říká, že CB musí na růst inflace reagovat **zvýšením nominální sazby o více než jeden procentní bod** na každý bod růstu inflace (v Taylorově pravidle o 1 + 0,5 = 1,5 p. b.). Jen tak **reálná** sazba r = i − π vzroste, utlumí poptávku a vrátí inflaci k cíli. Kdyby nominální sazba rostla méně než inflace, reálná sazba by klesla, poptávka by vzrostla a inflace by dále zrychlovala — politika by byla destabilizující. V modelu DAD-DAS je splnění principu podmínkou, aby DAD byla klesající a ekonomika se po šoku vracela k rovnováze.

*Příklad:* Inflace vzroste ze 2 na 3 %. Podle Taylorova pravidla vzroste i o 1,5 p. b. a r o 0,5 p. b. Kdyby CB zvýšila i jen o 0,5 p. b., r by klesla o 0,5 p. b. a měnová politika by se paradoxně uvolnila.

### ? CB zvyšuje nominální sazbu o 0,8 p. b. na každý 1 p. b. růstu inflace. Co se stane s reálnou úrokovou mírou, když inflace vzroste o 1 p. b.?

- [x] Klesne o 0,2 p. b. a poptávka se posílí
- [ ] Vzroste o 0,8 p. b. a poptávka se utlumí
- [ ] Vzroste o 0,2 p. b. a poptávka se utlumí
- [ ] Nezmění se, změnila se jen nominální sazba

> Δr = Δi − Δπ = 0,8 − 1 = −0,2 p. b. Reálná sazba klesá, politika se uvolňuje a inflace dále roste — Taylorův princip je porušen.

### ? Která reakce CB na růst inflace o 1 p. b. splňuje Taylorův princip?

- [ ] Zvýšení nominální sazby o 0,5 p. b.
- [ ] Zvýšení nominální sazby o 1 p. b.
- [ ] Ponechání nominální sazby beze změny
- [x] Zvýšení nominální sazby o 1,5 p. b.

> Princip vyžaduje Δi > Δπ. Při zvýšení o 1 p. b. by reálná sazba zůstala beze změny a poptávku by netlumila; teprve 1,5 p. b. zvýší reálnou sazbu o 0,5 p. b.

## IS křivka s reálnou úrokovou mírou {#is-krivka .explain}

IS křivka v modelu IS-MR (i DAD-DAS) vyjadřuje rovnováhu na trhu zboží. Plánované výdaje, hlavně investice a nákupy zboží dlouhodobé spotřeby, závisí na **reálné** úrokové míře r, protože firmy a domácnosti se rozhodují podle reálných nákladů úvěru. Zapisuje se jako odchylka od potenciálu:

`(Y − Y*)/Y* = −a · (r − r*) + ε`

kde a > 0 je citlivost výdajů na sazbu, r* přirozená reálná úroková míra (u Carlin & Soskice „stabilizující" sazba), při níž je produkt na potenciálu, a ε **poptávkový šok**. V prostoru (Y, r) je IS klesající; posouvají ji změny G a T, důvěra spotřebitelů a firem, zahraniční poptávka. Na rozdíl od IS-LM se nepředpokládá pevná nabídka peněz — místo LM vstupuje do modelu reakční funkce CB, která na IS volí bod.

*Příklad:* Při a = 0,5 a ε = 0 sníží zvýšení reálné sazby o 2 p. b. nad r* produkt o 1 % pod potenciál.

### ? Co posune IS křivku doprava?

- [ ] Zvýšení reálné úrokové míry centrální bankou
- [ ] Zdražení ropy na světových trzích
- [x] Růst důvěry spotřebitelů a firem
- [ ] Snížení inflačního cíle centrální banky

> Vyšší důvěra zvýší výdaje při každé sazbě (ε > 0). Změna r je pohyb po IS, ropa je nabídkový šok (posouvá DAS) a inflační cíl působí přes reakční funkci CB, ne přes IS.

### ? Proč IS křivka v modelu IS-MR závisí na reálné, a ne na nominální úrokové míře?

- [ ] Protože nominální sazbu CB neovlivňuje
- [x] Protože výdaje závisí na reálných nákladech úvěru
- [ ] Protože inflace je v modelu vždy nulová
- [ ] Protože reálná sazba je rovna zahraniční sazbě

> Pro investora či dlužníka je podstatné, kolik ho úvěr stojí po odečtení inflace. CB nominální sazbu řídí a inflace v modelu nulová není.

### ? Citlivost výdajů na sazbu je a = 0,8 a nepůsobí žádný poptávkový šok. CB zvýší reálnou sazbu o 1,5 p. b. nad r*. Jaká bude mezera výstupu?

- [x] −1,2 %
- [ ] +1,2 %
- [ ] −1,875 %
- [ ] −0,8 %

> (Y − Y*)/Y* = −a · (r − r*) = −0,8 · 1,5 = −1,2 %. Hodnota −1,875 % vznikne dělením 1,5 / 0,8 místo násobení, kladné znaménko je opačný směr účinku.

## Ztrátová funkce centrální banky {#ztratova-funkce .explain}

V modelu IS-MR (Carlin & Soskice) centrální banka minimalizuje **ztrátovou funkci**, která trestá odchylky produktu od potenciálu i inflace od cíle:

`L = ((Y − Y*)/Y*)² + β · (π − π*)²`

Kvadratický tvar znamená, že kladné i záporné odchylky jsou stejně nežádoucí a velké odchylky jsou trestány více než úměrně. Parametr **β** vyjadřuje relativní váhu inflace: β = 1 znamená stejnou váhu obou cílů, **β > 1 inflačně averzní („konzervativní") CB**, β < 1 CB, která více dbá na produkt a zaměstnanost. CB čelí **tradeoffu**: inflaci nad cílem může snížit jen tak, že dočasně stlačí produkt pod potenciál (podle Phillipsovy křivky).

*Příklad:* Mezera výstupu −1 %, inflace 1 p. b. nad cílem, β = 1 → L = (−1)² + 1 · 1² = 2.

### ? Mezera výstupu je −1 %, inflace je 2 p. b. nad cílem a β = 2. Jaká je hodnota ztrátové funkce L?

- [ ] 6
- [ ] 5
- [ ] 17
- [x] 9

> L = (−1)² + 2 · 2² = 1 + 8 = 9. Hodnota 6 vznikne, když se váha β přiřadí mezeře výstupu (2 · 1 + 4), hodnota 5 při vynechání druhých mocnin (1 + 2 · 2).

### ? Co vyjadřuje parametr β > 1 ve ztrátové funkci centrální banky?

- [ ] CB přikládá větší váhu stabilizaci produktu
- [x] CB přikládá větší váhu odchylkám inflace
- [ ] CB vůbec nereaguje na mezeru výstupu
- [ ] CB má inflační cíl vyšší než 1 %

> β násobí kvadrát odchylky inflace; β > 1 tedy znamená inflačně averzní CB, která je ochotna obětovat více produktu za rychlejší návrat inflace k cíli.

## MR křivka (monetární pravidlo) {#mr-krivka .explain}

**MR křivka** (monetary rule) je reakční funkce optimalizující CB v modelu IS-MR. CB minimalizuje ztrátu L s omezením Phillipsovy křivky π = π₋₁ + φ · (Y − Y*)/Y*, kde φ je její sklon. Z podmínky prvního řádu vyjde:

`(Y − Y*)/Y* = −φ · β · (π − π*)`

MR je v prostoru (Y, π) **klesající přímka procházející bodem (Y*, π*)**: je-li inflace nad cílem, CB zvolí produkt pod potenciálem, a to tím více, čím vyšší je β (averze k inflaci) a φ (o kolik pokles produktu sníží inflaci). Vyšší β nebo φ dělá MR **plošší** — CB obětuje víc produktu za rychlejší dezinflaci.

*Příklad:* φ = 1, β = 1 a inflace je 1 p. b. nad cílem → CB usiluje o produkt 1 % pod potenciálem; při β = 2 by to byla 2 %.

### ? φ = 1, β = 2 a inflace leží na MR 1,5 p. b. nad cílem. Jakou mezeru výstupu CB zvolí?

- [ ] −1,5 %
- [ ] −0,75 %
- [x] −3 %
- [ ] +3 %

> (Y − Y*)/Y* = −φ · β · (π − π*) = −1 · 2 · 1,5 = −3 %. Hodnota −0,75 % vznikne dělením β místo násobení, kladné znaménko by znamenalo expanzi při vysoké inflaci.

### ? CB se stane inflačně averznější (β vzroste). Jak se změní MR a reakce CB na inflační šok?

- [x] Plošší MR, větší pokles produktu, rychlejší dezinflace
- [ ] Strmější MR, menší pokles produktu, pomalejší dezinflace
- [ ] Plošší MR, menší pokles produktu, pomalejší dezinflace
- [ ] MR se posune doprava, produkt vzroste nad potenciál

> Sklon MR v prostoru (Y, π) je −1/(φβ); vyšší β ho zplošťuje. Pro snížení inflace o daný bod CB připustí hlubší pokles produktu, inflace se proto k cíli vrací rychleji.

## Reakce CB na šok v modelu IS-MR {#is-mr-reakce .explain}

Reakce CB na šok v modelu IS-PC-MR (Carlin & Soskice) probíhá ve třech krocích, protože úroková sazba působí na produkt se zpožděním jednoho období:

1. CB pozoruje inflaci π₀ (např. po šoku) a ví, že v příštím období bude ekonomika na Phillipsově křivce π₁ = π₀ + φ · (Y₁ − Y*)/Y*.
2. Na této Phillipsově křivce zvolí bod, který leží na MR, tj. minimalizuje svou ztrátu.
3. Z IS křivky odvodí reálnou sazbu r, při níž produkt dosáhne zvolené úrovně Y₁.

V dalších obdobích se postup opakuje: inflace klesá po MR k π*, produkt se vrací k Y* a sazba k r*.

*Příklad:* π₀ = 4 %, π* = 2 %, φ = 1, β = 1, a = 1. Phillipsova křivka: π₁ = 4 + mezera; MR: mezera = −(π₁ − 2). Dosazením π₁ = 4 − π₁ + 2, tedy π₁ = 3 % a mezera −1 %. Z IS (a = 1) plyne, že CB zvýší r o 1 p. b. nad r*.

### ? π₀ = 6 %, π* = 2 %, φ = 1 a β = 1. Jakou inflaci a mezeru výstupu CB v příštím období zvolí?

- [ ] π₁ = 2 %, mezera −4 %
- [x] π₁ = 4 %, mezera −2 %
- [ ] π₁ = 5 %, mezera −1 %
- [ ] π₁ = 6 %, mezera 0 %

> Phillipsova křivka π₁ = 6 + mezera, MR mezera = −(π₁ − 2). Tedy π₁ = 6 − π₁ + 2 → π₁ = 4 %, mezera = −2 %. Ostatní body leží na Phillipsově křivce, ale ne na MR.

### ? CB chce dosáhnout mezery výstupu −2 % a citlivost výdajů na sazbu je a = 0,5. O kolik musí nastavit reálnou sazbu nad r*?

- [ ] O 1 p. b.
- [ ] O 2 p. b.
- [ ] O 2,5 p. b.
- [x] O 4 p. b.

> Z IS: −2 = −0,5 · (r − r*), tedy r − r* = 2 / 0,5 = 4 p. b. Hodnota 1 p. b. vznikne násobením 2 · 0,5 místo dělení.

## Odvození křivky DAD {#odvozeni-dad .explain}

Křivka DAD ukazuje kombinace inflace π a produktu Y, při nichž je trh zboží v rovnováze **a** sazba odpovídá reakční funkci CB. Odvození: reálnou sazbu z Taylorova pravidla r = r* + 0,5 · (π − π*) + 0,5 · (Y − Y*)/Y* dosadíme do IS křivky (Y − Y*)/Y* = −a · (r − r*) + ε. Po úpravě:

`(Y − Y*)/Y* = −[0,5a / (1 + 0,5a)] · (π − π*) + ε / (1 + 0,5a)`

DAD je **klesající**: vyšší inflace → CB podle Taylorova principu zvýší reálnou sazbu → klesnou investice a spotřeba → nižší produkt. Nejde tedy o efekt reálných peněžních zůstatků jako u statické AD, ale o reakci měnové politiky. Je-li inflace na cíli a ε = 0, je produkt na potenciálu.

*Příklad:* Při a = 1 je DAD: (Y − Y*)/Y* = −(1/3) · (π − π*) + (2/3) · ε. Při inflaci 5 % a cíli 2 % (bez šoku) je produkt 1 % pod potenciálem.

### ? IS křivka je (Y − Y*)/Y* = −1 · (r − r*) + ε a CB nastavuje sazbu podle Taylorova pravidla r = r* + 0,5 · (π − π*) + 0,5 · (Y − Y*)/Y*.
Bez poptávkového šoku (ε = 0) vzroste inflace na 8 % při cíli 2 %. Jaká bude mezera výstupu podle křivky DAD?

- [ ] −3 %
- [x] −2 %
- [ ] −6 %
- [ ] +2 %

> (Y − Y*)/Y* = −(1/3) · (8 − 2) = −2 %. Hodnota −3 % vznikne, když se zapomene, že CB reaguje i na mezeru výstupu (jmenovatel 1 + 0,5a), tedy −0,5 · 6.

### ? Proč je křivka DAD klesající?

- [ ] Vyšší inflace snižuje reálné peněžní zůstatky při pevném M
- [ ] Vyšší inflace zvyšuje náklady firem, které omezí výrobu
- [ ] Vyšší inflace zdražuje vývoz a snižuje čistý export
- [x] CB na vyšší inflaci reaguje zvýšením reálné sazby

> Klesající sklon DAD vychází z reakční funkce: podle Taylorova principu roste při vyšší inflaci reálná sazba a ta tlumí výdaje. Efekt reálných zůstatků patří statické AD, náklady firem nabídkové straně.

### ? IS křivka je (Y − Y*)/Y* = −1 · (r − r*) + ε a CB nastavuje sazbu podle Taylorova pravidla r = r* + 0,5 · (π − π*) + 0,5 · (Y − Y*)/Y*.
Inflace je na cíli a nastane poptávkový šok ε = 1,5 %. Jaká bude mezera výstupu podle křivky DAD?

- [x] +1 %
- [ ] +1,5 %
- [ ] +0,5 %
- [ ] −1 %

> (Y − Y*)/Y* = (2/3) · 1,5 = +1 %. Šok se do produktu nepromítne celý (+1,5 %), protože CB na rostoucí produkt reaguje zvýšením sazby.

## Pohyb po DAD a posun DAD {#posuny-dad .compare}

| Událost | Účinek v modelu DAD-DAS |
|---|---|
| změna inflace (např. po nabídkovém šoku) | **pohyb po DAD** — CB mění sazbu podle pravidla |
| kladný poptávkový šok (růst G, pokles T, růst důvěry, zahraniční poptávky) | **posun DAD doprava (nahoru)** |
| záporný poptávkový šok (pokles důvěry, fiskální konsolidace) | posun DAD doleva (dolů) |
| snížení inflačního cíle π* | **posun DAD dolů** — při dané inflaci drží CB vyšší sazbu |
| silnější reakce sazby na inflaci (vyšší koeficient u π − π*) | DAD je **plošší** |
| silnější reakce sazby na mezeru výstupu | DAD je strmější |
| nabídkový šok (ropa, energie) | DAD se neposouvá, posouvá se DAS |

### ? Jak se v grafu DAD-DAS projeví snížení inflačního cíle CB?

- [ ] DAS se posune nahoru
- [ ] DAD se posune doprava
- [x] DAD se posune dolů
- [ ] Ekonomika se pohybuje po nezměněné DAD

> Při nižším cíli je stejná inflace větší odchylkou od π*, CB proto drží vyšší reálnou sazbu a pro každou inflaci je produkt nižší — DAD se posune dolů (doleva).

### ? CB začne na odchylku inflace od cíle reagovat razantněji. Jak se změní dopad nepříznivého nabídkového šoku?

- [ ] Inflace vzroste více, produkt klesne méně
- [x] Inflace vzroste méně, produkt klesne více
- [ ] Inflace i produkt se změní stejně jako dříve
- [ ] Inflace vzroste méně a produkt se nezmění

> Razantnější reakce na inflaci dělá DAD plošší. Posun DAS nahoru se pak promítne spíše do poklesu produktu a méně do růstu inflace.

### ? Která událost znamená pohyb po DAD, a NE její posun?

- [ ] Růst vládních nákupů G
- [ ] Pokles důvěry firem
- [ ] Snížení inflačního cíle
- [x] Reakce CB na vyšší inflaci po zdražení ropy

> Zdražení ropy posune DAS; CB na vyšší inflaci odpoví podle stávajícího pravidla, takže se ekonomika pohybuje po nezměněné DAD. Ostatní možnosti DAD posouvají.

## DAS ve velmi krátkém období {#das-velmi-kratke .term}

Ve **velmi krátkém období** jsou ceny, resp. tempo jejich růstu, předem dané (firmy upravují ceny a mzdy jen v pravidelných intervalech), takže inflace v daném období na poptávku nereaguje. DAS je **horizontální** na úrovni dané (očekávané) inflace a změny poptávky se plně promítnou do produktu, nikoli do inflace.

### ? Firmy mají ceny na celé období pevně stanovené. Jak se ve velmi krátkém období projeví kladný poptávkový šok?

- [x] Produkt vzroste, inflace se nezmění
- [ ] Inflace vzroste, produkt se nezmění
- [ ] Vzroste produkt i inflace
- [ ] Nezmění se produkt ani inflace

> Při horizontální DAS je inflace pro dané období fixní, takže posun DAD doprava zvýší jen produkt. Pouze inflace by se měnila při vertikální DAS (dlouhé období).

## DAS v krátkém období {#das-kratke .explain}

V **krátkém období** je DAS **rostoucí**: vychází z Phillipsovy křivky rozšířené o očekávání (viz téma Phillipsova křivka):

`π = πᵉ + φ · (Y − Y*)/Y* + ν`

kde φ > 0 vyjadřuje citlivost inflace na mezeru výstupu a ν **nabídkový šok** (cena ropy, energií, potravin). Při **adaptivních očekáváních** platí πᵉ = π₋₁ — lidé čekají, že inflace bude stejná jako v minulém období. Produkt nad potenciálem (napjatý trh práce, vysoké využití kapacit) inflaci zrychluje, produkt pod potenciálem ji zpomaluje. DAS se **posouvá** se změnou očekávané inflace (každé období s inflací minulého období) a při nabídkových šocích.

*Příklad:* π₋₁ = 3 %, φ = 0,5, produkt 2 % nad potenciálem, ν = 0 → π = 3 + 0,5 · 2 = 4 %. V dalším období se DAS posune nahoru, protože πᵉ = 4 %.

### ? π₋₁ = 2 %, φ = 0,5, produkt je 2 % pod potenciálem a ceny energií přidají ν = 1 p. b. Jaká bude inflace podle krátkodobé DAS?

- [ ] 4 %
- [ ] 1 %
- [ ] 3 %
- [x] 2 %

> π = 2 + 0,5 · (−2) + 1 = 2 − 1 + 1 = 2 %. Hodnota 4 % vznikne opačným znaménkem mezery, 1 % vynecháním šoku a 3 % vynecháním mezery výstupu.

### ? Co při adaptivních očekáváních posune krátkodobou DAS v příštím období nahoru?

- [ ] Snížení inflačního cíle CB
- [ ] Zvýšení vládních nákupů G
- [x] Vyšší inflace v tomto období
- [ ] Růst potenciálního produktu

> Při πᵉ = π₋₁ se letošní vyšší inflace stane příští rok očekávanou inflací a DAS se posune nahoru. Cíl CB a G posouvají DAD, růst Y* posune DAS doprava.

## DAS ve velmi krátkém, krátkém a dlouhém období {#das-srovnani .compare}

| Období | Tvar DAS | Předpoklad | Dopad trvalého posunu DAD |
|---|---|---|---|
| velmi krátké | horizontální | ceny, resp. tempo jejich růstu, jsou předem dané | mění se jen Y |
| krátké | rostoucí | π = πᵉ + φ · (Y − Y*)/Y* + ν; očekávání se nestihnou přizpůsobit | mění se Y i π |
| dlouhé | vertikální v Y* | očekávání se plně přizpůsobí (π = πᵉ), mzdy a ceny jsou pružné | mění se jen π |

V dlouhém období je produkt určen **potenciálem Y*** (práce, kapitál, technologie), nikoli poptávkou; měnová politika (inflační cíl) určuje jen dlouhodobou inflaci.

### ? Proč je dlouhodobá DAS vertikální v úrovni Y*?

- [ ] Protože CB v dlouhém období přestane reagovat na inflaci
- [x] Protože při π = πᵉ musí být mezera výstupu nulová
- [ ] Protože ceny jsou v dlouhém období fixní
- [ ] Protože potenciální produkt roste s inflací

> Dosadíme-li π = πᵉ (a ν = 0) do π = πᵉ + φ · (Y − Y*)/Y*, vyjde Y = Y* pro jakoukoli inflaci. Fixní ceny naopak odpovídají horizontální DAS velmi krátkého období.

### ? CB trvale zvýší inflační cíl ze 2 na 3 %. Jaký je dlouhodobý výsledek v modelu DAD-DAS?

- [x] Inflace 3 %, produkt na úrovni Y*
- [ ] Inflace 3 %, produkt trvale nad Y*
- [ ] Inflace 2 %, produkt trvale nad Y*
- [ ] Inflace 2,5 %, produkt na úrovni Y*

> Vertikální dlouhodobá DAS znamená, že změna cíle ovlivní v dlouhém období jen inflaci: ta se ustálí na novém cíli 3 % a produkt se vrátí na potenciál.

## Rovnováha v modelu DAD-DAS {#rovnovaha .explain}

**Krátkodobá rovnováha** je v průsečíku DAD a krátkodobé DAS daného období. **Dlouhodobá rovnováha** nastává, když nepůsobí šoky (ε = 0, ν = 0) a inflace je stabilní, π = π₋₁ = πᵉ: z DAS pak plyne Y = Y*, z DAD π = π*, z reakční funkce r = r* a i = r* + π*. Model je dynamický — inflace jednoho období vstupuje do očekávání dalšího období a posouvá DAS, proto se řeší postupně po obdobích. Pro výpočty v dalších kartách použijeme ilustrační parametry:

- DAD: (Y − Y*)/Y* = −2 · (π − π*) + ε (ε = poptávkový šok v % produktu). Tato zjednodušená DAD odpovídá pravidlu, kdy CB reaguje **jen na inflaci**, r = r* + 0,5 · (π − π*), a citlivosti IS a = 4: mezera = −4 · 0,5 · (π − π*) + ε. Šok proto vstupuje do DAD celý; při plném Taylorově pravidle z karty o odvození DAD by ho tlumila i reakce CB na mezeru výstupu,
- DAS: π = π₋₁ + 0,5 · (Y − Y*)/Y* + ν,
- výchozí stav: π* = π₋₁ = 2 %, Y = Y*.

*Příklad:* Při r* = 2 % a π* = 2 % je v dlouhodobé rovnováze nominální sazba i = 2 + 2 = 4 % a reálná r = 2 %.

### ? Co platí v dlouhodobé rovnováze modelu DAD-DAS?

- [ ] Y > Y*, π = π*, r = r*
- [ ] Y = Y*, π = 0, r = 0
- [x] Y = Y*, π = π*, r = r*
- [ ] Y = Y*, π = πᵉ, ale r > r*

> Bez šoků a se stabilní inflací je produkt na potenciálu, inflace na cíli a očekávání se s ní shodují; sazba je neutrální (r = r*).

### ? Přirozená reálná úroková míra je r* = 2 % a inflační cíl π* = 2 %. Jaká je nominální sazba v dlouhodobé rovnováze?

- [ ] 2 %
- [ ] 6 %
- [ ] 0 %
- [x] 4 %

> V dlouhodobé rovnováze je π = π* a mezera nulová, takže podle Taylorova pravidla i = r* + π* = 2 + 2 = 4 %. Hodnota 2 % je reálná, nikoli nominální sazba.

## Poptávkový šok a přizpůsobení {#sok-poptavky .explain}

Kladný poptávkový šok (růst G, vlna optimismu spotřebitelů a firem) posune DAD doprava. V 1. období produkt vzroste nad Y* a po rostoucí DAS roste i inflace; CB podle pravidla zvýší sazbu, takže produkt roste méně než o velikost šoku. Když jednorázový šok odezní, DAD se vrátí do výchozí polohy, ale DAS zůstává výše, protože očekávaná inflace je rovna zvýšené inflaci minulého období. CB proto drží reálnou sazbu nad r* a produkt v dalších obdobích klesne **pod** potenciál; inflace postupně klesá a ekonomika se vrací do dlouhodobé rovnováhy (Y*, π*).

*Příklad:* Parametry z karty o rovnováze, jednorázový šok ε = +2 % v 1. období:

| Období | ε (%) | π (%) | mezera výstupu (%) |
|---|---|---|---|
| 0 | 0 | 2 | 0 |
| 1 | +2 | 2,5 | +1 |
| 2 | 0 | 2,25 | −0,5 |
| 3 | 0 | 2,125 | −0,25 |

### ? DAD: mezera = −2 · (π − π*) + ε, DAS: π = π₋₁ + 0,5 · mezera + ν, kde mezera = (Y − Y*)/Y* v %.
Výchozí stav: π* = π₋₁ = 2 %, Y = Y*. V 1. období nastane jednorázový poptávkový šok ε = +4 % (ν = 0). Jaká bude v 1. období inflace a mezera výstupu?

- [x] π = 3 %, mezera +2 %
- [ ] π = 2 %, mezera +4 %
- [ ] π = 4 %, mezera +4 %
- [ ] π = 3 %, mezera +4 %

> DAS: π = 2 + 0,5 · mezera, DAD: mezera = −2 · (π − 2) + 4. Dosazením π − 2 = 0,5 · (−2 · (π − 2) + 4) → 2 · (π − 2) = 2 → π = 3 %, mezera = −2 + 4 = +2 %. Mezera +4 % by platila jen při fixní inflaci (horizontální DAS).

### ? Proč je po odeznění jednorázového kladného poptávkového šoku produkt dočasně POD potenciálem?

- [ ] Protože CB po šoku trvale snížila inflační cíl
- [x] Protože zvýšená očekávaná inflace drží DAS výše
- [ ] Protože DAD se po šoku posune doprava ještě více
- [ ] Protože potenciální produkt se po šoku snížil

> Při adaptivních očekáváních je πᵉ v 2. období rovna zvýšené inflaci z 1. období, DAS je tedy výše. Inflace je nad cílem, CB drží reálnou sazbu nad r* a produkt klesne pod Y*, dokud inflace neklesne k cíli.

## Nabídkový šok a přizpůsobení {#sok-nabidky .explain}

Nepříznivý nabídkový šok (zdražení ropy, energií, neúroda) posune DAS nahoru (ν > 0). V 1. období inflace vzroste a produkt klesne pod potenciál — **stagflace**. DAD se neposouvá: CB se pohybuje po DAD, na vyšší inflaci odpovídá vyšší reálnou sazbou, a tím inflaci tlumí za cenu hlubšího poklesu produktu. Po odeznění šoku zůstává DAS zvýšená kvůli adaptivním očekáváním a klesá jen postupně, jak inflace slábne; inflace i produkt se vracejí k (Y*, π*). CB tak řeší dilema mezi rychlejším návratem inflace k cíli a menším poklesem produktu.

*Příklad:* Parametry z karty o rovnováze, jednorázový šok ν = +2 p. b. v 1. období:

| Období | ν (p. b.) | π (%) | mezera výstupu (%) |
|---|---|---|---|
| 0 | 0 | 2 | 0 |
| 1 | +2 | 3 | −2 |
| 2 | 0 | 2,5 | −1 |
| 3 | 0 | 2,25 | −0,5 |

### ? DAD: mezera = −2 · (π − π*) + ε, DAS: π = π₋₁ + 0,5 · mezera + ν, kde mezera = (Y − Y*)/Y* v %.
Výchozí stav: π* = π₋₁ = 2 %, Y = Y*. Zdraží ropa a v 1. období působí nabídkový šok ν = +4 p. b. (ε = 0). Jaká bude v 1. období inflace a mezera výstupu?

- [ ] π = 6 %, mezera 0 %
- [ ] π = 4 %, mezera −2 %
- [ ] π = 3 %, mezera −2 %
- [x] π = 4 %, mezera −4 %

> DAS: π = 2 + 0,5 · mezera + 4, DAD: mezera = −2 · (π − 2). Dosazením π − 2 = −(π − 2) + 4 → π − 2 = 2 → π = 4 %, mezera = −2 · 2 = −4 %. Kontrola v DAS: 2 + 0,5 · (−4) + 4 = 4 %.

### ? Proč se po jednorázovém nabídkovém šoku inflace nevrátí na cíl hned v dalším období?

- [ ] Protože nabídkový šok trvale posunul DAD nahoru
- [ ] Protože CB po šoku zvýšila inflační cíl
- [x] Protože očekávaná inflace vychází ze zvýšené minulé inflace
- [ ] Protože potenciální produkt trvale klesl

> Při adaptivních očekáváních je πᵉ = π₋₁, takže DAS v 2. období zůstává výše a inflace klesá postupně (3 → 2,5 → 2,25 % v příkladu). DAD ani cíl se nemění.

## Šok inflačního cíle (dezinflace) {#sok-cile .explain}

Snížení inflačního cíle posune DAD dolů: při dosavadní inflaci je nyní inflace nad novým cílem a CB zvýší reálnou sazbu. Produkt klesne pod potenciál, a protože očekávaná inflace je dána minulou inflací, inflace klesá jen postupně. Každé období se DAS posune dolů, recese slábne a v dlouhém období je π rovna novému cíli a Y = Y* — dlouhodobá DAS je vertikální, takže změna cíle trvale ovlivní jen inflaci. Kumulativní ztráta produktu během přechodu je **cenou dezinflace**; vydělená poklesem inflace dává **poměr obětí** (sacrifice ratio) — v příkladu 4 % / 2 p. b. = 2 % produktu na 1 p. b. inflace.

*Příklad:* Parametry z karty o rovnováze, ale výchozí inflace i cíl jsou 4 %; v 1. období CB sníží cíl na 2 %:

| Období | π* (%) | π (%) | mezera výstupu (%) |
|---|---|---|---|
| 0 | 4 | 4 | 0 |
| 1 | 2 | 3 | −2 |
| 2 | 2 | 2,5 | −1 |
| 3 | 2 | 2,25 | −0,5 |

### ? DAD: mezera = −2 · (π − π*), DAS: π = π₋₁ + 0,5 · mezera (adaptivní očekávání, bez šoků), kde mezera = (Y − Y*)/Y* v %.
Výchozí inflace i cíl jsou 4 %, Y = Y*. V 1. období CB sníží cíl na 2 % a inflace pak klesá 3 → 2,5 → 2,25 %. Jaká je kumulativní ztráta produktu (součet záporných mezer) za první tři období po snížení cíle?

- [ ] 2 %
- [x] 3,5 %
- [ ] 4 %
- [ ] 1,5 %

> 2 + 1 + 0,5 = 3,5 % potenciálního produktu. Hodnota 4 % je celková ztráta za všechna období (mezera se každé období půlí: 2 + 1 + 0,5 + 0,25 + … = 4).

### ? Jaký je dlouhodobý výsledek snížení inflačního cíle ze 4 na 2 % v modelu DAD-DAS s adaptivními očekáváními?

- [x] Inflace 2 %, produkt na úrovni Y*
- [ ] Inflace 2 %, produkt trvale pod Y*
- [ ] Inflace 4 %, produkt na úrovni Y*
- [ ] Inflace 3 %, produkt trvale pod Y*

> Recese je jen přechodná. Jakmile se očekávání přizpůsobí nové inflaci, ekonomika se ustálí na vertikální dlouhodobé DAS: π = 2 % a Y = Y*.

## Role očekávání při přizpůsobení {#role-ocekavani .explain}

Rychlost přizpůsobení v modelu DAD-DAS určuje to, jak se tvoří **očekávaná inflace πᵉ**, která udává polohu krátkodobé DAS. Při **adaptivních očekáváních** (πᵉ = π₋₁) se DAS posouvá postupně, inflace má setrvačnost, návrat k rovnováze trvá několik období a dezinflace stojí ztrátu produktu. Je-li CB **důvěryhodná** a očekávání jsou **ukotvena na inflačním cíli** (blíže racionálním očekáváním), DAS se posune rovnou na úroveň nového cíle a dezinflace může proběhnout s malou nebo žádnou ztrátou produktu. Proto CB cílující inflaci zdůrazňují transparentnost, komunikaci a důvěryhodnost. U nabídkových šoků ukotvená očekávání brání tomu, aby se jednorázový růst cen přelil do mezd a trvale vyšší inflace (tzv. efekty druhého kola).

*Příklad:* Při snížení cíle ze 4 na 2 % s adaptivními očekáváními klesá inflace 3 → 2,5 → 2,25 % a produkt je 2, 1 a 0,5 % pod potenciálem. Kdyby lidé novému cíli hned uvěřili (πᵉ = 2 %), byla by již v 1. období π = 2 % a Y = Y*.

### ? DAD: mezera = −2 · (π − π*), DAS: π = πᵉ + 0,5 · mezera (bez šoků), kde mezera = (Y − Y*)/Y* v %.
Výchozí inflace i cíl jsou 4 %, Y = Y*. CB sníží cíl na 2 % a veřejnost tomu okamžitě plně uvěří (πᵉ = 2 % už v 1. období). Jaký bude výsledek v 1. období?

- [ ] π = 3 %, mezera −2 %
- [ ] π = 4 %, mezera −4 %
- [x] π = 2 %, mezera 0 %
- [ ] π = 2 %, mezera −2 %

> DAS: π = 2 + 0,5 · mezera, DAD: mezera = −2 · (π − 2). Jediné řešení je π = 2 % a mezera 0 — dezinflace proběhne bez ztráty produktu. Výsledek π = 3 %, mezera −2 % platí při adaptivních očekáváních.

### ? Co v modelu DAD-DAS způsobuje setrvačnost inflace a postupné přizpůsobení po šocích?

- [ ] Vertikální dlouhodobá DAS
- [ ] Klesající sklon křivky DAD
- [ ] Taylorův princip v reakční funkci CB
- [x] Adaptivní tvorba inflačních očekávání

> Při πᵉ = π₋₁ se každá minulá odchylka inflace přenáší do polohy DAS v dalším období. Vertikální dlouhodobá DAS a klesající DAD určují, kam se ekonomika vrací, ne rychlost přizpůsobení.
