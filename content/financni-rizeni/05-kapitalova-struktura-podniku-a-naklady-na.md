---
kind: topic
subject: financni-rizeni
slug: kapitalova-struktura-podniku-a-naklady-na
name: "Kapitálová struktura podniku a náklady na firemní kapitál"
order: 5
---

Kapitálová struktura a její vliv na rentabilitu podnikání. Přístupy k optimalizaci kapitálové struktury. Vliv zadlužení firmy na rentabilitu vlastního kapitálu. Ziskový účinek finanční páky. Limitní zadlužení podniku a jeho výpočet. Pravidlo pro výběr cizího kapitálu. Náklady na firemní kapitál, přístupy k jeho zjišťování.

## Kapitálová struktura a hodnota podniku {#kapitalova-struktura .explain}

Navazuje na Strategii podniku (struktura kapitálu): **finanční struktura** je složení všech pasiv, **kapitálová struktura** v užším smyslu složení dlouhodobého kapitálu (VK + dlouhodobé cizí zdroje). Pro rozhodování o optimální struktuře se pracuje s **úročeným** cizím kapitálem a pokud možno s **tržními** hodnotami. Hodnota podniku pro všechny investory je `V = VK + CK` a rovná se současné hodnotě volných peněžních toků do firmy (FCFF) diskontovaných WACC; pro věčný konstantní tok `V = FCFF / WACC`. Pokud volba financování nemění provozní peněžní toky, znamená **minimalizace WACC maximalizaci hodnoty podniku** — to je jádro otázky optimální kapitálové struktury. Struktura přitom ovlivňuje i rentabilitu vlastního kapitálu (finanční páka), finanční riziko a kontrolu nad podnikem.

*Příklad:* FCFF 24 mil. Kč ročně věčně; při WACC 10 % je V = 240 mil. Kč, při WACC 9,6 % je V = 250 mil. Kč.

### ? Podnik očekává věčný volný peněžní tok do firmy (FCFF) 30 mil. Kč ročně. Změnou kapitálové struktury klesne WACC z 10 % na 8 %, provozní peněžní toky se nezmění. O kolik vzroste hodnota podniku?

- [ ] O 60 mil. Kč
- [x] O 75 mil. Kč
- [ ] O 0,6 mil. Kč
- [ ] O 375 mil. Kč

> V = FCFF / WACC: 30 / 0,10 = 300 mil. Kč, 30 / 0,08 = 375 mil. Kč, přírůstek 75 mil. Kč. 60 mil. Kč vznikne, když se hodnota zvýší jen o 20 % (relativní pokles WACC) místo o 25 %; 0,6 mil. Kč je roční úspora 30 · 0,02 a 375 mil. Kč je nová hodnota, ne přírůstek.

### ? Jak se liší finanční struktura od kapitálové struktury v užším smyslu?

- [ ] Finanční zahrnuje jen úročené zdroje, kapitálová všechny zdroje
- [ ] Finanční popisuje složení aktiv, kapitálová složení pasiv
- [ ] Kapitálová se měří tržně, finanční výhradně účetně
- [x] Finanční zahrnuje všechna pasiva, kapitálová jen dlouhodobá

> Finanční struktura je složení všech zdrojů financování včetně krátkodobých, kapitálová struktura v užším smyslu jen dlouhodobý kapitál (vlastní kapitál a dlouhodobé cizí zdroje). Obě popisují pasiva; složení aktiv je majetková struktura.

## Vliv zadlužení na rentabilitu vlastního kapitálu {#vliv-zadluzeni-roe .explain}

Vztah ROE a zadlužení (shodně s Manažerskou ekonomikou a MFV) se odvodí z výkazu zisku a ztráty. Při ROA = EBIT / A, A = VK + CK a průměrné úrokové sazbě i = nákladové úroky / úročený CK platí `EBIT = ROA · (VK + CK)` a `EAT = (EBIT − i · CK) · (1 − t)`. Po vydělení vlastním kapitálem:

`ROE = [ROA + (ROA − i) · CK/VK] · (1 − t)`

- ROA · (1 − t) je ROE nezadluženého podniku, člen **(ROA − i) · CK/VK** je **příspěvek finanční páky**,
- rozdíl ROA − i určuje **směr** působení páky, poměr CK/VK jeho **sílu**,
- ze vzorce lze dopočítat zadlužení potřebné pro cílovou ROE: `CK/VK = [ROE/(1 − t) − ROA] / (ROA − i)`.

Vzorec předpokládá, že všechen CK je úročený (neúročené závazky by snižovaly průměrnou sazbu i) a že EBT je kladný.

*Příklad:* ROA 11 %, i = 5 %, CK/VK = 1,5, t = 21 % → ROE = [11 % + 6 % · 1,5] · 0,79 = 20 % · 0,79 = 15,8 %.

### ? Podnik má aktiva 120 mil. Kč (VK 40, úročený CK 80 mil. Kč), EBIT 15,6 mil. Kč, úrokovou sazbu 7 % a sazbu daně t = 21 %. Jaké je ROE?

- [ ] 25,00 %
- [ ] 10,27 %
- [x] 19,75 %
- [ ] 15,01 %

> ROA = 15,6 / 120 = 13 %, CK/VK = 2 → ROE = [13 % + 6 % · 2] · 0,79 = 19,75 %. Kontrola: úroky 5,6; EBT 10,0; EAT 7,9; 7,9 / 40 = 19,75 %. 25 % je ROE před zdaněním, 10,27 % ROE bez dluhu a 15,01 % vznikne opomenutím poměru CK/VK.

### ? Podnik má ROA (EBIT / A) 12 %, úrokovou sazbu cizího kapitálu 6 % a sazbu daně t = 21 %. Jaký poměr CK/VK potřebuje, aby ROE dosáhla 18,96 %?

- [x] 2,00
- [ ] 1,16
- [ ] 1,58
- [ ] 3,16

> ROE před zdaněním = 18,96 / 0,79 = 24 %; 24 % = 12 % + 6 % · CK/VK → CK/VK = 2. Hodnota 1,16 vznikne zapomenutím daně, 1,58 zdaněním jen členu ROA a 3,16 prostým podílem 18,96 / 6.

## Pozitivní a negativní působení finanční páky {#pusobeni-paky .compare}

Směr působení páky určuje vztah rentability aktiv (EBIT / A) a úrokové sazby; páka funguje oběma směry — tentýž dluh, který v dobrém roce ROE zvyšuje, ji ve špatném roce snižuje.

| Situace | Příspěvek páky (ROA − i) · CK/VK | Vliv dalšího dluhu na ROE | Důsledek |
|---|---|---|---|
| ROA > i | kladný | ROE roste | pozitivní páka — dluh zvyšuje výnos vlastníků i jejich riziko |
| ROA = i | nulový | ROE = ROA · (1 − t) bez ohledu na dluh | neutrální — dluh přidává jen riziko |
| ROA < i | záporný | ROE klesá | negativní páka — vhodné zadlužení snižovat |

### ? Podniky A a B mají aktiva 60 mil. Kč. A je financován jen vlastním kapitálem, B má VK 20 a úvěr 40 mil. Kč s úrokem 8 %. Sazba daně t = 21 %. V dobrém roce je EBIT obou 9 mil. Kč, ve špatném 4,2 mil. Kč. Jaké ROE dosáhne podnik B?

- [ ] 22,9 % v dobrém a 5,53 % ve špatném roce
- [x] 22,9 % v dobrém a 3,95 % ve špatném roce
- [ ] 11,85 % v dobrém a 5,53 % ve špatném roce
- [ ] 29,0 % v dobrém a 5,0 % ve špatném roce

> Úroky B = 3,2 mil. Kč. Dobrý rok: ROA 15 % > 8 % → ROE = [15 % + 7 % · 2] · 0,79 = 22,9 % (A má 11,85 %). Špatný rok: ROA 7 % < 8 % → EBT = 1,0; EAT = 0,79; ROE = 3,95 %, tedy méně než 5,53 % u A — páka působí negativně. 29 % a 5 % jsou hodnoty před zdaněním.

### ? Podnik s poměrem CK/VK = 3 refinancuje úvěry a jeho úroková sazba vzroste z 5 % na 10 %. ROA (EBIT / A) je stabilně 8 %. Jak se změní působení finanční páky?

- [ ] Páka zůstane pozitivní, protože ROA je stále kladná
- [ ] Páka přestane působit a ROE se bude rovnat ROA · (1 − t)
- [x] Páka se stane negativní a každý další dluh ROE sníží
- [ ] Páka zesílí, protože vyšší úroky zvyšují daňový štít

> Před refinancováním ROA − i = +3 p. b. (pozitivní páka), po něm 8 − 10 = −2 p. b.; při CK/VK = 3 klesne ROE před zdaněním na 8 % − 2 % · 3 = 2 %. Daňový štít výsledek jen proporcionálně krátí přes (1 − t), směr páky nezmění.

## Ziskový účinek finanční páky {#ziskovy-ucinek-paky .explain}

Rozšířený rozklad ROE (navazuje na Du Pontovu rovnici z MFV) odděluje vliv daní, úroků, provozní výkonnosti a zadlužení:

`ROE = (EAT/EBT) · (EBT/EBIT) · (EBIT/A) · (A/VK)`

- EAT/EBT — **daňová redukce** zisku, rovná (1 − t),
- EBT/EBIT — **úroková redukce** zisku (úrokové zatížení), jaká část EBIT zbude po úrocích; ≤ 1,
- EBIT/A — rentabilita aktiv (ROA),
- A/VK — **finanční páka** (multiplikátor vlastního kapitálu).

**Ziskový účinek finanční páky** = `(EBT/EBIT) · (A/VK)`. Je-li **> 1**, zadlužení ROE zvyšuje (ROE před zdaněním > ROA); = 1 je neutrální, **< 1** zadlužení ROE snižuje. Podmínka > 1 je ekvivalentní podmínce ROA > i. Vyšší páka A/VK tedy zvyšuje ROE jen tehdy, když její přínos neodčerpá úrokové zatížení.

*Příklad:* A 90, VK 30, EBIT 12, úroky 3 mil. Kč → EBT/EBIT = 9/12 = 0,75; A/VK = 3; ziskový účinek 2,25 > 1 (ROE před zdaněním 30 % = 2,25 · ROA 13,3 %).

### ? Podnik má aktiva 50 mil. Kč, vlastní kapitál 20 mil. Kč, EBIT 6 mil. Kč a nákladové úroky 2,4 mil. Kč. Jaký je ziskový účinek finanční páky a co znamená?

- [ ] 0,6 — zadlužení ROE snižuje
- [ ] 2,5 — zadlužení ROE zvyšuje
- [ ] 0,4 — zadlužení ROE snižuje
- [x] 1,5 — zadlužení ROE zvyšuje

> EBT = 6 − 2,4 = 3,6; úrokové zatížení 3,6 / 6 = 0,6; páka A/VK = 50 / 20 = 2,5; součin 1,5 > 1. Kontrola: ROE před zdaněním 3,6 / 20 = 18 % = 1,5 · ROA 12 %. Hodnota 0,6 je jen úrokové zatížení, 2,5 jen páka a 0,4 podíl úroků na EBIT.

### ? Kdy je ziskový účinek finanční páky (EBT/EBIT · A/VK) větší než 1?

- [x] Když EBIT / A převyšuje úrokovou sazbu dluhu
- [ ] Když je finanční páka A / VK vyšší než hodnota 2
- [ ] Když úroky tvoří méně než polovinu EBIT
- [ ] Když je sazba daně nižší než úroková sazba

> Ziskový účinek > 1 znamená, že ROE před zdaněním převyšuje ROA, a to nastává právě tehdy, když majetek vydělává víc, než stojí cizí kapitál (ROA > i). Samotná výše páky ani podíl úroků na EBIT to nezaručí; daň v tomto součinu nevystupuje.

### ? Podnik zvýšil finanční páku A/VK z 2 na 3, úrokové zatížení EBT/EBIT ale kleslo z 0,8 na 0,5. Rentabilita aktiv EBIT / A zůstala 10 %. Co se stalo s ROE před zdaněním?

- [ ] Vzrostla z 16 % na 30 %, protože páka vzrostla o polovinu
- [ ] Nezměnila se, vliv páky a úroků se přesně vyrovnal
- [x] Klesla z 16 % na 15 %, úroky odčerpaly přínos páky
- [ ] Klesla z 20 % na 15 %, protože se snížila páka

> ROE před zdaněním = ROA · ziskový účinek: dříve 10 % · 0,8 · 2 = 16 %, nyní 10 % · 0,5 · 3 = 15 %. Ziskový účinek 1,5 je stále > 1, ale nižší než 1,6 — dluh se zdražil natolik, že vyšší páka ROE nezvýšila. 30 % vznikne opomenutím úrokového zatížení.

## Stupeň finanční páky (DFL) {#stupen-financni-paky .explain}

**Stupeň finanční páky** (degree of financial leverage, DFL) měří citlivost čistého zisku na změnu EBIT:

`DFL = %ΔEAT / %ΔEBIT = EBIT / (EBIT − nákladové úroky) = EBIT / EBT`

Je převrácenou hodnotou úrokového zatížení EBT/EBIT. Bez dluhu je DFL = 1; čím vyšší jsou fixní úroky vzhledem k EBIT, tím víc čistý zisk (a ROE, resp. EPS) kolísá — DFL je tak měřítkem **finančního rizika**. Konstantní sazba daně poměr nemění, protože zdaní EBT proporcionálně. DFL platí pro výchozí úroveň EBIT; spolu s provozní pákou (fixní provozní náklady) určuje celkové riziko výsledku vlastníků.

*Příklad:* EBIT 10 mil. Kč, úroky 4 mil. Kč → DFL = 10 / 6 ≈ 1,67; pokles EBIT o 15 % (na 8,5) sníží EBT i EAT o 25 % (EBT z 6 na 4,5).

### ? Podnik má EBIT 8 mil. Kč a nákladové úroky 3 mil. Kč, sazba daně t = 21 %. EBIT klesne o 20 %. O kolik procent klesne čistý zisk EAT?

- [x] O 32 %
- [ ] O 20 %
- [ ] O 25,3 %
- [ ] O 12,5 %

> DFL = 8 / (8 − 3) = 1,6 → EAT klesne o 1,6 · 20 % = 32 %. Kontrola: EBT z 5 na 6,4 − 3 = 3,4 mil. Kč, tj. −32 %; daň 21 % poměr nezmění. 20 % platí jen bez dluhu, 25,3 % vznikne zbytečným násobením (1 − t) a 12,5 % dělením místo násobení DFL.

### ? Co vyjadřuje stupeň finanční páky DFL = 2,5?

- [ ] Aktiva podniku jsou 2,5krát vyšší než vlastní kapitál
- [ ] EBIT podniku pokryje nákladové úroky 2,5krát
- [x] Změna EBIT o 1 % změní čistý zisk o 2,5 %
- [ ] Cizí kapitál je 2,5krát vyšší než vlastní kapitál

> DFL je elasticita čistého zisku vůči EBIT. Poměr A/VK je finanční páka v Du Pontově rozkladu, EBIT / úroky je úrokové krytí (krytí 2,5 by odpovídalo DFL = 2,5 / 1,5 ≈ 1,67) a CK/VK míra zadluženosti vlastního kapitálu.

## Pravidlo pro výběr cizího kapitálu {#pravidlo-vyberu-ck .explain}

Základní pravidlo: použít cizí kapitál se z hlediska rentability vyplatí, je-li **rentabilita celkového kapitálu EBIT / A vyšší než úroková sazba** cizího kapitálu (ekvivalentně ziskový účinek finanční páky > 1). Daň směr rozhodnutí nemění, protože zjednodušeně zdaňuje výnos majetku i úsporu z úroků stejnou sazbou. Porovnává se **očekávaná** rentabilita financovaného majetku, ne minulá, a pravidlo je třeba doplnit hlediskem **rizika** (stabilita EBIT, úrokové krytí, kovenanty) a **likvidity** (splátky jistiny z peněžních toků, sladění splatnosti s životností majetku). Při **výběru mezi nabídkami** úvěrů rozhoduje **efektivní náklad**, nikoli nominální sazba: zahrnují se poplatky (za poskytnutí, vedení, nevyčerpanou částku), četnost připisování úroků, kompenzační zůstatky a náklady zajištění.

*Příklad:* Jednoletý úvěr 5 mil. Kč s úrokem 6 % splatným na konci a poplatkem 50 000 Kč sraženým při čerpání → efektivní sazba (300 000 + 50 000) / (5 000 000 − 50 000) ≈ 7,07 %.

### ? Podnik s aktivy 200 mil. Kč očekává EBIT 14 mil. Kč a zvažuje financovat rozšíření úvěrem s úrokem 8 %. Rozšíření nezmění rentabilitu aktiv. Je úvěr z hlediska ROE výhodný?

- [x] Není, rentabilita aktiv 7 % je nižší než úrok 8 %
- [ ] Je, protože cizí kapitál je vždy levnější než vlastní
- [ ] Je, protože úroky snižují základ daně z příjmů
- [ ] Je, každá kladná rentabilita aktiv zvýší s dluhem ROE

> EBIT / A = 14 / 200 = 7 % < 8 % — každá koruna úvěru vydělá méně, než stojí, a ROE by klesla (negativní páka). Daňová uznatelnost úroků snižuje náklad dluhu i výnos z majetku stejným poměrem, směr působení nezmění.

### ? Podnik vybírá mezi dvěma jednoletými úvěry na 10 mil. Kč s úrokem splatným na konci roku. Banka X: úrok 6,5 %, bez poplatků. Banka Y: úrok 6 % a poplatek 80 000 Kč sražený při čerpání. Který úvěr je levnější?

- [ ] Y, protože má nižší nominální úrokovou sazbu
- [x] X, protože efektivní sazba Y je přibližně 6,85 %
- [ ] X, protože poplatky z úvěru nejsou daňově uznatelné
- [ ] Oba jsou stejně drahé, poplatek vyrovná rozdíl sazeb

> Y: podnik získá 9,92 mil. Kč a zaplatí úrok 600 000 Kč, náklad je 680 000 / 9 920 000 ≈ 6,85 % > 6,5 % u X. Rozhoduje efektivní, ne nominální sazba; poplatky za úvěr jsou zpravidla daňově uznatelné, takže to důvodem není.

## Limitní zadlužení podniku {#limitni-zadluzeni .explain}

Pojem **limitní zadlužení** se v literatuře nevykládá jednotně; obvykle se rozlišují dvě hranice:

- **rentabilitní hranice** — financuje-li dluh rozšíření majetku se stejnou rentabilitou (VK se nemění), zvyšuje další dluh ROE, dokud je **mezní úroková sazba** (sazba z další koruny dluhu) nižší než EBIT / A. Protože věřitelé s rostoucím zadlužením požadují vyšší úrok, existuje míra zadlužení, za níž další dluh ROE snižuje;
- **hranice únosnosti (dluhové kapacity)** — úroky musí být hrazeny z provozního zisku. Při úrokovém krytí EBIT / úroky = 1 spotřebují úroky celý EBIT (EBT = 0), absolutní strop je tedy `CK_max = EBIT / i`. Věřitelé ale vyžadují rezervu — minimální úrokové krytí k, takže `CK_lim = EBIT / (k · i)`.

V praxi banky hranici určují i dalšími ukazateli (např. čistý dluh / EBITDA, schopnost splácet jistinu z peněžních toků). Limitní zadlužení je strop, ne doporučená výše dluhu.

*Příklad:* EBIT 12 mil. Kč, úrok 6 %, požadované krytí 4 → úroky nejvýše 3 mil. Kč → CK nejvýše 50 mil. Kč; absolutní strop při krytí 1 je 200 mil. Kč.

### ? Podnik dosahuje stabilního EBIT 18 mil. Kč. Banka požaduje úrokové krytí (EBIT / nákladové úroky) alespoň 3 a úvěry poskytuje za 7,5 %. Jaký nejvyšší úročený dluh může podnik mít?

- [ ] 240 mil. Kč
- [ ] 6 mil. Kč
- [ ] 26,7 mil. Kč
- [x] 80 mil. Kč

> Úroky smějí činit nejvýše 18 / 3 = 6 mil. Kč, což při 7,5 % odpovídá dluhu 6 / 0,075 = 80 mil. Kč. 240 mil. Kč je absolutní strop při krytí 1 (EBIT / i), 6 mil. Kč je maximální roční úrok a 26,7 mil. Kč vznikne, když se krytím vydělí dvakrát.

### ? Podnik financuje rozšíření majetku se stejnou rentabilitou aktiv EBIT / A = 10 %, vlastní kapitál se nemění. Banka účtuje na část dluhu do CK/A = 40 % úrok 6 %, na část mezi 40 a 60 % úrok 9 % a nad 60 % úrok 12 %. Do jaké míry zadlužení CK/A se z hlediska ROE vyplatí dluh zvyšovat?

- [ ] Do 40 %, za touto hranicí sazba roste
- [ ] Neomezeně, dokud je průměrná sazba pod ROA
- [x] Do 60 %, do té je mezní sazba nižší než ROA
- [ ] Vůbec, sazba se se zadlužením zvyšuje

> Další koruna dluhu zvýší ROE, jen když vydělá víc (10 %), než stojí její vlastní úrok. Mezní sazby 6 % a 9 % jsou pod 10 %, sazba 12 % nad 60 % už ne. Průměrná sazba je zavádějící — zůstává pod ROA i tehdy, když nejdražší část dluhu ROE už snižuje.

## Náklady kapitálu a přístupy k jejich zjišťování {#pristupy-naklady-kapitalu .compare}

Náklady kapitálu jsou výnosnost požadovaná jeho poskytovateli — oportunitní náklad (navazuje na Manažerskou ekonomiku). Přehled přístupů:

| Složka | Přístup | Vzorec / princip | Poznámka |
|---|---|---|---|
| Cizí kapitál — úvěr | efektivní úroková sazba po zdanění | `r_CK · (1 − t)` | včetně poplatků; aktuální, ne historická sazba |
| Cizí kapitál — dluhopisy | výnos do splatnosti po zdanění | `YTM · (1 − t)` | YTM z aktuální tržní ceny (téma 4) |
| Prioritní akcie | dividendový výnos | `r_P = D_P / P_0` | dividenda není daňově uznatelná |
| Vlastní kapitál | CAPM | `r_f + β · (r_m − r_f)` | pro obchodované akcie nebo s betou srovnatelných firem |
| Vlastní kapitál | dividendový (Gordonův) model | `D_1 / P_0 + g` | stabilně rostoucí dividenda |
| Vlastní kapitál | přirážka k výnosu dluhopisů | YTM vlastních dluhopisů + riziková přirážka | hrubý kontrolní odhad |
| Vlastní kapitál | stavebnicový model (INFA) | r_f + součet rizikových přirážek | z účetních dat, i pro neobchodované podniky |
| Celkový kapitál | WACC | vážený průměr nákladů složek | tržní, účetní nebo cílové váhy |

### ? Kterým přístupem lze nejlépe odhadnout náklady vlastního kapitálu s.r.o., jejíž podíly nejsou obchodovány a která nevyplácí stabilní podíl na zisku?

- [ ] Gordonovým dividendovým modelem
- [ ] Modelem CAPM s betou z kurzů vlastních akcií
- [x] Stavebnicovým modelem z účetních dat
- [ ] Výnosem do splatnosti vlastních dluhopisů

> Stavebnicový model (např. INFA) skládá r_VK z bezrizikové sazby a přirážek odvozených z účetních výkazů, proto nepotřebuje kurzy ani dividendy. Gordonův model vyžaduje stabilní dividendu, CAPM s vlastní betou kurzy a YTM dluhopisů měří náklady cizího, ne vlastního kapitálu.

### ? Proč jsou náklady vlastního kapitálu skutečným nákladem, i když je podnik nikomu smluvně neplatí?

- [x] Vlastníci by mohli při stejném riziku investovat jinde
- [ ] Vlastní kapitál se ze zákona úročí sazbou centrální banky
- [ ] Podnik musí každý rok vyplatit vlastníkům podíl na zisku
- [ ] Účetně se zachycují jako finanční náklad ve výsledovce

> Náklad vlastního kapitálu je oportunitní: vlastníci se vzdávají výnosu z alternativní investice se srovnatelným rizikem. Pokud jim podnik tento výnos nevydělá, ničí jejich bohatství, i když účetně vykazuje zisk.

## Náklady cizího kapitálu {#naklady-ck .explain}

Náklady cizího kapitálu r_CK jsou výnosnost, kterou věřitelé požadují **nyní**: u nového úvěru efektivní sazba včetně poplatků, u dluhopisů **výnos do splatnosti (YTM)** při aktuální tržní ceně (u nové emise z čistého výnosu po emisních nákladech) — nikoli historický kupón. Po zdanění je náklad `r_CK · (1 − t)`, ale jen pokud podnik daňový štít skutečně využije: ztrátový podnik ho uplatní nejvýše později (odpočtem daňové ztráty) a omezení daňové uznatelnosti úroků (např. nízká kapitalizace) štít snižují. Při více úvěrech se r_CK počítá jako **vážený průměr** podle objemů. Neúročené závazky (dodavatelé, mzdy) se do r_CK ani WACC nezahrnují.

*Příklad:* Podnik vydal před lety dluhopisy s kupónem 2,5 %, dnes se obchodují s YTM 6 % → pro WACC se použije 6 % · (1 − t), ne 2,5 %.

### ? Podnik vydal před pěti lety dluhopisy s kupónovou sazbou 3 %. Dnes se obchodují pod jmenovitou hodnotou s výnosem do splatnosti 5,5 %. Při sazbě DPPO 21 % jaký náklad cizího kapitálu po zdanění použije pro WACC?

- [ ] 2,37 %
- [x] 4,35 %
- [ ] 5,50 %
- [ ] 3,00 %

> Rozhoduje současný požadovaný výnos věřitelů, tedy YTM: 5,5 % · 0,79 ≈ 4,35 %. Hodnota 2,37 % je historický kupón po zdanění, 5,50 % YTM bez daňového štítu a 3,00 % samotný kupón.

### ? Podnik má dva úvěry: 30 mil. Kč s úrokem 4 % a 10 mil. Kč s úrokem 8 %. Při sazbě daně t = 21 % jaký je průměrný náklad cizího kapitálu po zdanění?

- [ ] 4,74 %
- [ ] 5,00 %
- [ ] 1,05 %
- [x] 3,95 %

> Vážený průměr sazeb = (30 · 4 % + 10 · 8 %) / 40 = 5 %; po zdanění 5 % · 0,79 = 3,95 %. Prostý průměr sazeb (6 %) dá po zdanění 4,74 %, 5,00 % je náklad před zdaněním a 1,05 % jen daňová úspora.

### ? Proč podnik, který je dlouhodobě v daňové ztrátě, NEMŮŽE počítat náklad cizího kapitálu jako r_CK · (1 − t)?

- [ ] Ztrátovému podniku banky ze zákona nesmějí půjčovat
- [x] Neplatí daň, takže mu úroky daň aktuálně nesnižují
- [ ] Úroky se u něj účtují přímo proti vlastnímu kapitálu
- [ ] Jeho náklad cizího kapitálu se rovná nákladu VK

> Daňový štít vzniká jen tehdy, když úroky skutečně snižují placenou daň. Ve ztrátě je efektivní náklad dluhu blízký r_CK; štít lze nanejvýš uplatnit později odpočtem daňové ztráty, což má kvůli času nižší hodnotu.

## CAPM a vliv zadlužení na betu {#capm-beta .explain}

Model CAPM (Manažerská ekonomika) odhaduje `r_VK = r_f + β · (r_m − r_f)`. Beta akcie zadluženého podniku obsahuje vedle **provozního** i **finanční riziko**, a proto se zadlužením roste. Vztah zadlužené a nezadlužené bety popisuje Hamadova rovnice:

`β_L = β_U · [1 + (1 − t) · CK/VK]`

kde β_U je beta nezadlužená (jen provozní riziko odvětví) a β_L beta zadlužená. Postup „odpáknutí a zapáknutí" se používá, když podnik není obchodován (vezme se β_U srovnatelných firem) nebo když se odhaduje r_VK pro jinou kapitálovou strukturu. Rovnice je obdobou tvrzení MM II s daněmi.

*Příklad:* β_U = 0,8, CK/VK = 1, t = 21 % → β_L = 0,8 · (1 + 0,79) = 1,432.

### ? Nezadlužená beta odvětví je 0,9. Podnik plánuje strukturu CK/VK = 0,5, sazba daně je 21 %, bezriziková sazba 3 % a tržní riziková prémie (r_m − r_f) 6 %. Jaké budou jeho náklady vlastního kapitálu podle CAPM?

- [ ] 8,40 %
- [ ] 11,10 %
- [ ] 7,53 %
- [x] 10,53 %

> β_L = 0,9 · (1 + 0,79 · 0,5) = 1,2555; r_VK = 3 % + 1,2555 · 6 % ≈ 10,53 %. S nezadluženou betou vyjde 8,40 %, bez (1 − t) v Hamadově rovnici 11,10 % a 7,53 % je jen riziková prémie bez r_f.

### ? Proč beta akcie s rostoucím zadlužením podniku roste?

- [ ] Zadlužení zvyšuje provozní riziko výroby podniku
- [x] Vlastníci nesou navíc finanční riziko z fixních úroků
- [ ] Úroky z dluhu snižují bezrizikovou sazbu na trhu
- [ ] Zadlužený podnik má vždy kolísavější tržby než nezadlužený

> Provozní riziko (kolísání EBIT) se dluhem nemění, ale fixní úroky toto kolísání přenesou na menší vlastní kapitál v zesílené podobě (finanční páka). Vlastníci proto nesou vyšší systematické riziko a požadují vyšší výnos.

## Dividendový (Gordonův) model nákladů vlastního kapitálu {#gordonuv-model .explain}

Z Gordonova modelu ceny akcie `P_0 = D_1 / (r_VK − g)` (téma 4) se vyjádří náklad vlastního kapitálu:

`r_VK = D_1 / P_0 + g`, kde `D_1 = D_0 · (1 + g)`

Náklad VK je tedy součtem očekávaného **dividendového výnosu** a **tempa růstu** dividend. Předpokládá konstantní g < r_VK a stabilní dividendovou politiku; g se odhaduje např. jako b · ROE (téma 8) nebo z prognóz analytiků a model je na jeho odhad velmi citlivý. U podniků bez dividend je nepoužitelný. **Nový** vlastní kapitál z emise je dražší než zadržený zisk o emisní náklady f: `r_e = D_1 / [P_0 · (1 − f)] + g`. Pro **prioritní akcie** s pevnou dividendou platí `r_P = D_P / P_0`.

*Příklad:* D_0 = 12 Kč, g = 5 %, P_0 = 300 Kč → D_1 = 12,60 Kč; r_VK = 4,2 % + 5 % = 9,2 %.

### ? Akcie se obchoduje za 500 Kč. Právě vyplacená dividenda činila 25 Kč a očekává se její trvalý růst o 3 % ročně. Jaké jsou náklady vlastního kapitálu podle Gordonova modelu?

- [ ] 8,00 %
- [x] 8,15 %
- [ ] 5,15 %
- [ ] 8,24 %

> D_1 = 25 · 1,03 = 25,75 Kč; r_VK = 25,75 / 500 + 3 % = 5,15 % + 3 % = 8,15 %. 8,00 % vznikne dosazením právě vyplacené dividendy D_0, 5,15 % je jen dividendový výnos bez růstu a 8,24 % vznikne vynásobením chybného výsledku s D_0 (8 %) faktorem 1,03.

### ? Firma chce vydat nové akcie. Tržní cena je 200 Kč, emisní náklady 6 % z ceny, očekávaná dividenda za příští rok D_1 = 9,40 Kč a trvalé tempo růstu 4 %. Jaké jsou náklady nového vlastního kapitálu?

- [ ] 9,20 %
- [ ] 8,70 %
- [ ] 5,00 %
- [x] 9,00 %

> Čistý výnos emise na akcii = 200 · 0,94 = 188 Kč; r_e = 9,40 / 188 + 4 % = 5 % + 4 % = 9 %. Bez emisních nákladů by vyšlo 8,70 % (náklad zadrženého zisku), 9,20 % vznikne dalším navýšením D_1 o růst a 5,00 % je jen dividendový výnos.

### ? Prioritní akcie s pevnou dividendou 18 Kč se obchoduje za 240 Kč. Jaké jsou náklady prioritního kapitálu?

- [x] 7,50 %
- [ ] 5,93 %
- [ ] 9,49 %
- [ ] 13,33 %

> r_P = D_P / P_0 = 18 / 240 = 7,5 %. Dividendy se vyplácejí ze zisku po zdanění, proto se na rozdíl od úroků nenásobí (1 − t) — 5,93 % je tato chyba; 9,49 % vznikne dělením (1 − t) a 13,33 % převráceným poměrem.

## Přirážka k výnosu dluhopisů {#prirazka-k-dluhopisum .term}

Jednoduchý odhad nákladů vlastního kapitálu: **výnos do splatnosti vlastních dluhopisů podniku (před zdaněním) + riziková přirážka** za vyšší riziko vlastníků oproti věřitelům, v literatuře orientačně kolem 3–5 procentních bodů. Vychází z logiky, že podnik s rizikovějším dluhem má i rizikovější akcie; jde o hrubý odhad, který slouží hlavně ke kontrole výsledků CAPM a Gordonova modelu.

### ? Dluhopisy podniku mají výnos do splatnosti 6 %, sazba daně je 21 % a analytik používá rizikovou přirážku 4 procentní body. Jaký je odhad nákladů vlastního kapitálu metodou přirážky k výnosu dluhopisů?

- [ ] 8,74 %
- [ ] 7,90 %
- [x] 10,00 %
- [ ] 4,00 %

> r_VK = YTM + přirážka = 6 % + 4 % = 10 %. Výnos dluhopisů se zde bere před zdaněním — vlastníci požadují výnos nad úroveň výnosu věřitelů, daňový štít podniku s tím nesouvisí. 8,74 % vznikne zdaněním YTM, 7,90 % zdaněním celého výsledku a 4,00 % je jen přirážka.

## Stavebnicový model nákladů vlastního kapitálu (INFA) {#stavebnicovy-model .explain}

Stavebnicový (build-up) model skládá náklady vlastního kapitálu z bezrizikové sazby a **přirážek za jednotlivá rizika**. V české praxi je známá varianta manželů **Neumaierových (INFA)**, z níž vycházejí analýzy podnikové sféry Ministerstva průmyslu a obchodu (navazuje na EVA z pohledu vlastníků v MFV):

`r_VK = r_f + přirážka za podnikatelské riziko + přirážka za finanční stabilitu + přirážka za velikost podniku + přirážka za kapitálovou strukturu`

- **r_f** — bezriziková sazba (výnos dlouhodobých státních dluhopisů),
- **podnikatelské riziko** — odvozuje se z výnosnosti aktiv; čím vyšší provozní rentabilita, tím nižší přirážka,
- **finanční stabilita** — odvozuje se z likvidity; horší likvidita znamená vyšší přirážku,
- **velikost podniku** — menší podnik (méně likvidní a obchodovatelné podíly) má vyšší přirážku,
- **kapitálová struktura** — vyšší zadlužení znamená vyšší přirážku (finanční riziko vlastníků).

Přirážky se určují z **účetních výkazů**, proto lze model použít i pro neobchodované podniky. Konkrétní funkce a hraniční hodnoty přirážek stanoví metodika a v čase se upravují — zde jen princip.

*Příklad:* r_f 4 % + podnikatelské riziko 3 % + finanční stabilita 1,5 % + velikost 2 % + kapitálová struktura 2,5 % → r_VK = 13 % (ilustrativní čísla).

### ? Bezriziková sazba je 4,2 %, přirážka za podnikatelské riziko 2,8 %, za finanční stabilitu 1,0 %, za velikost podniku 3,0 % a za kapitálovou strukturu 1,5 %. Jaké jsou náklady vlastního kapitálu podle stavebnicového modelu?

- [ ] 8,3 %
- [ ] 11,0 %
- [ ] 9,5 %
- [x] 12,5 %

> r_VK = 4,2 + 2,8 + 1,0 + 3,0 + 1,5 = 12,5 %. 8,3 % je jen součet přirážek bez bezrizikové sazby, 11,0 % vznikne vynecháním přirážky za kapitálovou strukturu a 9,5 % vynecháním přirážky za velikost.

### ? Jak se ve stavebnicovém modelu INFA projeví, když se podniku výrazně zhorší likvidita?

- [ ] Sníží se bezriziková sazba r_f
- [ ] Sníží se přirážka za velikost podniku
- [x] Vzroste přirážka za finanční stabilitu
- [ ] Vzroste přirážka za podnikatelské riziko

> Přirážka za finanční stabilitu se odvozuje z likvidity — horší likvidita znamená vyšší riziko pro vlastníky, a tedy vyšší r_VK. Bezriziková sazba je dána trhem, přirážka za podnikatelské riziko vychází z provozní rentability a přirážka za velikost z objemu kapitálu.

### ? Proč lze stavebnicový model použít i pro podniky, jejichž akcie nejsou obchodovány?

- [x] Přirážky se odvozují z účetních výkazů, ne z kurzů
- [ ] Model nevyžaduje znalost bezrizikové sazby
- [ ] Vychází z bety vypočtené z vlastních kurzů akcií
- [ ] Používá jen dividendy vyplacené za poslední rok

> Přirážky za podnikatelské riziko, finanční stabilitu, velikost a strukturu se počítají z rozvahy a výsledovky, k nimž se přičte tržní bezriziková sazba. CAPM s vlastní betou i dividendový model potřebují tržní data o akciích.

## WACC — tržní, účetní a cílové váhy {#wacc-vahy .compare}

Vzorec WACC (Manažerská ekonomika, Strategie podniku) je citlivý na volbu vah jednotlivých zdrojů:

| | Účetní váhy | Tržní váhy | Cílové váhy |
|---|---|---|---|
| Zdroj údajů | rozvaha (historické hodnoty) | tržní kapitalizace VK, tržní hodnota dluhu | plánovaná dlouhodobá struktura |
| Výhody | dostupné, stabilní, i pro neobchodované podniky | odpovídají současným nárokům investorů, teoreticky správné | konzistentní s budoucím financováním projektů |
| Nevýhody | VK bývá při P/BV > 1 podhodnocen → WACC vychází nízký | kolísají s kurzem, u neobchodovaných nedostupné | závisí na odhadu managementu |

Tržní hodnota dluhu se často aproximuje účetní hodnotou, pokud se úrokové sazby od jeho přijetí výrazně nezměnily.

### ? Účetní hodnota VK je 40 mil. Kč, tržní kapitalizace akcií 100 mil. Kč, úročený dluh 60 mil. Kč (tržní ≈ účetní). r_VK = 12 %, r_CK = 5 %, sazba daně t = 21 %. Jaký je WACC s tržními a s účetními vahami?

- [ ] Tržní 7,17 %, účetní 8,98 %
- [x] Tržní 8,98 %, účetní 7,17 %
- [ ] Tržní 9,38 %, účetní 7,80 %
- [ ] V obou případech 8,50 %

> Tržní váhy 100/160 a 60/160: 12 % · 0,625 + 5 % · 0,79 · 0,375 = 7,5 + 1,48 ≈ 8,98 %. Účetní váhy 40/100 a 60/100: 12 % · 0,4 + 3,95 % · 0,6 = 4,8 + 2,37 = 7,17 %. Bez daňového štítu vyjde 9,38 % a 7,80 %, 8,50 % je prostý průměr sazeb.

### ? Proč se při výpočtu WACC dává přednost tržním vahám před účetními?

- [ ] Tržní hodnoty jsou vždy ověřeny auditorem
- [ ] Účetní hodnoty zahrnují i neúročené závazky
- [x] Odrážejí dnešní hodnotu nároků investorů
- [ ] Tržní váhy vedou vždy k nižšímu WACC

> Investoři požadují výnos z aktuální tržní hodnoty svých nároků, ne z historické účetní hodnoty. Tržní váhy WACC obvykle zvyšují, protože tržní hodnota VK bývá nad účetní; účetní VK je tak v průměru podhodnocen.

## WACC při více zdrojích financování {#wacc-vice-zdroju .explain}

Obecně je WACC vážený průměr nákladů všech dlouhodobých úročených zdrojů, přičemž (1 − t) se uplatní jen u daňově uznatelných nákladů (úroků). Při financování kmenovými akciemi, prioritními akciemi a dluhem:

`WACC = r_VK · VK/C + r_P · P/C + r_CK · (1 − t) · CK/C`, kde `C = VK + P + CK`

WACC je správnou diskontní sazbou jen pro projekty s **rizikem odpovídajícím průměru podniku**. Projekt v rizikovějším oboru vyžaduje vyšší sazbu (např. divizní WACC nebo r_VK odvozené z bety srovnatelných firem); použití jednotného WACC vede k přijímání příliš rizikových a odmítání bezpečných projektů.

*Příklad:* VK 60 (r_VK = 12 %), prioritní akcie 10 (r_P = 8 %), CK 30 mil. Kč (r_CK = 6 %), t = 21 % → WACC = 7,2 + 0,8 + 6 · 0,79 · 0,3 = 9,42 %.

### ? Tržní hodnoty: kmenový vlastní kapitál 50 mil. Kč (r_VK = 13 %), prioritní akcie 10 mil. Kč (r_P = 8 %), úročený dluh 40 mil. Kč (r_CK = 7 %), sazba daně t = 21 %. Jaký je WACC?

- [x] 9,51 %
- [ ] 10,10 %
- [ ] 9,34 %
- [ ] 9,68 %

> WACC = 13 % · 0,5 + 8 % · 0,1 + 7 % · 0,79 · 0,4 = 6,5 + 0,8 + 2,21 ≈ 9,51 %. Bez daňového štítu vyjde 10,10 %, zdanění i prioritní dividendy dá 9,34 % a vynechání prioritních akcií z vah 9,68 %.

### ? Podnik s WACC 9 % zvažuje projekt v odvětví s výrazně vyšším rizikem, než má jeho stávající činnost. Projekt má IRR 10 %. Jak by měl postupovat?

- [ ] Přijmout, protože IRR převyšuje WACC podniku
- [ ] Zamítnout, protože riziko vždy zvyšuje náklady dluhu
- [x] Posoudit ho sazbou odpovídající riziku projektu
- [ ] Přijmout, pokud ho podnik financuje úvěrem

> WACC podniku odráží riziko jeho současné činnosti. Pro rizikovější projekt je třeba vyšší požadovaná výnosnost (např. z bety firem v daném odvětví); teprve s ní lze rozhodnout, zda IRR 10 % stačí. Způsob financování konkrétního projektu na tom nic nemění.

## Mezní náklady kapitálu (MCC) {#mezni-naklady-kapitalu .explain}

**Mezní náklady kapitálu** (marginal cost of capital, MCC) jsou WACC další, nově získané koruny kapitálu. Při financování v cílové struktuře jsou zpočátku konstantní, ale **skokově rostou**, jakmile se vyčerpá levnější zdroj — typicky zadržený zisk (dál je nutná emise akcií s emisními náklady) nebo levnější tranše úvěru. Místo skoku je **bod zlomu**:

`bod zlomu = objem levnějšího zdroje / jeho váha v cílové struktuře`

Křivka MCC se porovnává s křivkou investičních příležitostí (projekty seřazené podle IRR): přijímají se projekty, dokud IRR dalšího projektu převyšuje MCC — tím je určen optimální kapitálový rozpočet.

*Příklad:* Zadržený zisk 9 mil. Kč, cílový podíl VK 60 % → bod zlomu 9 / 0,6 = 15 mil. Kč; do 15 mil. Kč nového kapitálu je WACC např. 9 %, nad ním 9,6 %.

### ? Podnik financuje investice v cílové struktuře 60 % vlastní a 40 % cizí kapitál. Má k dispozici zadržený zisk 18 mil. Kč, nad tuto částku musí vydat dražší nové akcie. Do jakého celkového objemu nového kapitálu zůstanou mezní náklady kapitálu na nejnižší úrovni?

- [ ] 18 mil. Kč
- [x] 30 mil. Kč
- [ ] 45 mil. Kč
- [ ] 10,8 mil. Kč

> Bod zlomu = 18 / 0,6 = 30 mil. Kč: při 30 mil. Kč nového kapitálu připadne na VK právě 18 mil. Kč zadrženého zisku a 12 mil. Kč na dluh. 18 mil. Kč přehlíží souběžné čerpání dluhu, 45 mil. Kč vznikne dělením váhou dluhu a 10,8 mil. Kč násobením místo dělení.

### ? Proč mezní náklady kapitálu s rostoucím objemem investic od určité výše skokově rostou?

- [x] Levnější zdroje se vyčerpají a další jsou dražší
- [ ] Úroky z nových úvěrů nejsou daňově uznatelné
- [ ] Bezriziková sazba roste s objemem investic podniku
- [ ] Vlastní kapitál se po emisi mění na cizí kapitál

> Nejdřív se čerpá nejlevnější kapitál (zadržený zisk, levnější tranše úvěru). Po jeho vyčerpání je třeba emitovat akcie s emisními náklady nebo přijmout dražší dluh, takže WACC každé další koruny vzroste.

## Přístupy k optimalizaci kapitálové struktury {#pristupy-optimalizace .compare}

| Přístup | Závěr o optimu | Hlavní argument |
|---|---|---|
| Tradiční | optimum existuje při mírném zadlužení | r_VK zpočátku roste pomalu, WACC klesá; pak r_VK i r_CK prudce rostou |
| Modigliani & Miller bez daní (1958) | struktura je pro hodnotu irelevantní | arbitráž; r_VK roste přesně tak, že WACC je konstantní |
| Modigliani & Miller s daněmi (1963) | čím více dluhu, tím lépe (teoreticky téměř 100 %) | daňový štít zvyšuje hodnotu o t · CK |
| Kompromisní (trade-off) | optimum, kde mezní přínos štítu = mezním nákladům tísně | daňový štít × náklady finanční tísně a agentní náklady |
| Hierarchie zdrojů (pecking order) | cílová struktura neexistuje | informační asymetrie, preference interních zdrojů |

### ? Která teorie tvrdí, že na dokonalém kapitálovém trhu bez daní hodnota podniku NEZÁVISÍ na kapitálové struktuře?

- [ ] Tradiční přístup
- [ ] Kompromisní teorie (trade-off)
- [ ] Hierarchie zdrojů (Myers a Majluf)
- [x] Modigliani a Miller (1958)

> MM (1958) ukázali, že bez daní, transakčních nákladů a nákladů tísně je hodnota podniku dána jen provozními peněžními toky a jejich rizikem. Tradiční přístup a kompromisní teorie optimum připouštějí, hierarchie zdrojů vysvětluje pořadí financování.

### ? Který přístup vede při důsledném použití k závěru, že optimální je financování téměř výhradně cizím kapitálem?

- [x] Modigliani a Miller s daněmi (1963)
- [ ] Modigliani a Miller bez daní (1958)
- [ ] Kompromisní teorie
- [ ] Tradiční přístup

> Podle MM s daněmi zvyšuje každá koruna dluhu hodnotu o současnou hodnotu daňového štítu t · CK, takže hodnota roste s dluhem bez omezení. Tento nerealistický závěr koriguje kompromisní teorie náklady finanční tísně.

## Tradiční přístup {#tradicni-pristup .explain}

**Tradiční přístup** je starší, převážně empirický pohled z doby před MM. Při nízkém až mírném zadlužení požadují věřitelé stále zhruba stejný úrok a vlastníci zvyšují požadovaný výnos r_VK jen málo — přidáváním levnějšího dluhu proto **WACC klesá** a hodnota podniku roste. Za určitou mírou zadlužení začnou r_VK i r_CK **prudce růst** (rostoucí riziko úpadku) a WACC stoupá. Závislost WACC na zadlužení má tvar U-křivky s minimem — **optimální kapitálovou strukturou**. Přístup nevychází z rigorózního modelu chování investorů; MM ho kritizovali, protože na dokonalém trhu by rozdíl v hodnotě odstranila arbitráž. Dnešní kompromisní teorie dochází k podobnému tvaru, ale vysvětluje ho daněmi a náklady finanční tísně.

*Příklad:* WACC 11 % bez dluhu, 9,5 % při 30 % dluhu, 12 % při 70 % dluhu — optimum je v pásmu mírného zadlužení.

### ? Čím se podle tradičního přístupu vysvětluje, že WACC při mírném zadlužení klesá?

- [ ] Náklady vlastního kapitálu se zadlužením klesají
- [x] Levnější dluh převáží jen mírný růst r_VK
- [ ] Daňový štít roste rychleji než hodnota dluhu
- [ ] Arbitráž investorů udržuje WACC konstantní

> Při mírném dluhu vlastníci zvyšují požadovaný výnos jen málo, takže přidání levnějšího dluhu průměr snižuje. Konstantní WACC díky arbitráži tvrdí MM bez daní, daňový štít je argument MM s daněmi a kompromisní teorie.

### ? Čím se liší tradiční přístup od kompromisní teorie, když obě dospívají k U-křivce WACC?

- [ ] Tradiční přístup optimum popírá, kompromisní ho připouští
- [ ] Tradiční přístup stojí na arbitráži, kompromisní na daních
- [ ] Kompromisní teorie nepočítá s náklady finanční tísně
- [x] Tradiční je empirický, kompromisní stojí na štítu a tísni

> Tradiční přístup tvar U-křivky jen empiricky popisuje chováním investorů, kompromisní teorie ho odvozuje z vyvažování daňového štítu a nákladů finanční tísně (a agentních nákladů). Arbitráž je argument Modiglianiho a Millera.

## Předpoklady Modiglianiho a Millera {#mm-predpoklady .explain}

Modigliani a Miller (1958) vycházejí z **dokonalého kapitálového trhu**: žádné daně, žádné transakční a emisní náklady, žádné náklady finanční tísně a bankrotu, investoři si půjčují za stejnou sazbu jako podniky, všichni mají stejné informace, provozní zisk (EBIT) nezávisí na financování a srovnávané podniky patří do stejné třídy rizika. Tvrzení dokazují **arbitráží**: kdyby byl zadlužený podnik dražší než jinak shodný nezadlužený, investor by prodal jeho akcie, sám si půjčil (**domácí páka**, homemade leverage) a koupil akcie nezadluženého podniku — získal by stejný výnos levněji. Smysl modelu není realistický popis, ale určení, **kde** hledat vliv struktury na hodnotu — v porušení předpokladů (daně, náklady tísně, informační asymetrie, agentní náklady).

*Příklad:* Akcionář chce páku jako u podniku s CK/VK = 1, ale akcie toho podniku jsou drahé. Koupí akcie stejného nezadluženého podniku za 100 000 Kč, z toho 50 000 Kč na úvěr — výsledné riziko i výnos odpovídají zadluženému podniku.

### ? Který předpoklad NEPATŘÍ mezi předpoklady původního tvrzení Modiglianiho a Millera (1958)?

- [ ] Neexistují daně ani transakční náklady
- [ ] Investoři si půjčují za stejnou sazbu jako podniky
- [x] Úroky z dluhu snižují daň z příjmů podniku
- [ ] Všichni účastníci trhu mají stejné informace

> Původní model z roku 1958 pracuje se světem bez daní, takže daňový štít v něm neexistuje. Daň z příjmů korporací doplnili MM až v roce 1963, a tím změnili závěr ve prospěch dluhu.

### ? Co je „domácí páka" (homemade leverage) v argumentaci Modiglianiho a Millera?

- [ ] Zadlužení podniku u jeho vlastních akcionářů
- [x] Investor si půjčí sám a napodobí zadlužení podniku
- [ ] Financování podniku výhradně ze zadrženého zisku
- [ ] Úvěr poskytnutý mateřskou společností dceřiné

> Pokud si investor může půjčit za stejnou sazbu jako podnik, dokáže si libovolnou páku vytvořit sám. Za zadlužení podniku proto nebude platit prémii a hodnota podniku na struktuře nezávisí.

## Tvrzení MM I bez daní {#mm-1 .explain}

**Tvrzení I** (1958): hodnota podniku nezávisí na kapitálové struktuře:

`V_L = V_U = EBIT / r_U` (pro věčný konstantní EBIT, bez daní)

kde V_L je hodnota zadluženého a V_U nezadluženého podniku a **r_U** náklady kapitálu nezadluženého podniku (odráží jen provozní riziko). Hodnota je dána velikostí a rizikem provozních peněžních toků, ne tím, jak se rozdělí mezi vlastníky a věřitele („velikost koláče nezávisí na tom, jak se krájí"). Důsledkem je, že **WACC je konstantní** a rovná se r_U při jakémkoli zadlužení; dluh jen přesouvá riziko mezi skupinami investorů. Tržní hodnota VK = V − CK.

*Příklad:* Věčný EBIT 15 mil. Kč, r_U = 12 % → V = 125 mil. Kč; s dluhem 50 mil. Kč je hodnota podniku stále 125 mil. Kč a vlastního kapitálu 75 mil. Kč.

### ? Podnik bez dluhu má věčný EBIT 9 mil. Kč a náklady kapitálu r_U = 12 %, daně neexistují. Podnik vydá dluhopisy za 30 mil. Kč a výtěžkem odkoupí vlastní akcie. Jaká je podle MM I tržní hodnota jeho vlastního kapitálu po změně?

- [ ] 75 mil. Kč
- [ ] 105 mil. Kč
- [ ] 30 mil. Kč
- [x] 45 mil. Kč

> V = 9 / 0,12 = 75 mil. Kč a podle MM I se dluhem nezmění; VK = 75 − 30 = 45 mil. Kč. 75 mil. Kč je hodnota celého podniku, 105 mil. Kč vznikne chybným přičtením dluhu k hodnotě a 30 mil. Kč je hodnota dluhu.

### ? Co podle tvrzení MM I bez daní platí pro WACC při zvyšování zadlužení?

- [x] Zůstává stejný a rovná se r_U nezadluženého podniku
- [ ] Klesá, protože se do průměru přidává levnější dluh
- [ ] Roste, protože roste finanční riziko vlastníků
- [ ] Nejprve klesá, pak roste — má tvar U-křivky

> Bez daní je hodnota podniku i WACC na struktuře nezávislé: přínos levnějšího dluhu přesně vyruší růst nákladů vlastního kapitálu (tvrzení II). U-křivku předpokládá tradiční přístup a kompromisní teorie.

## Tvrzení MM II bez daní {#mm-2 .explain}

**Tvrzení II** (1958): náklady vlastního kapitálu rostou lineárně se zadlužením (v tržních hodnotách):

`r_VK = r_U + (r_U − r_CK) · CK/VK`

Člen (r_U − r_CK) · CK/VK je prémie za **finanční riziko**, které vlastníci nesou navíc k provoznímu riziku. Úspora z levnějšího dluhu je přesně vyrušena růstem r_VK, takže `WACC = r_VK · VK/V + r_CK · CK/V = r_U` zůstává konstantní. Argument „dluh je levnější, proto zlevňuje financování" je tedy bez daní klam — dluh zdražuje vlastní kapitál.

*Příklad:* r_U = 10 %, r_CK = 6 %, CK/VK = 1 → r_VK = 10 % + 4 % · 1 = 14 %; WACC = 0,5 · 14 % + 0,5 · 6 % = 10 % = r_U.

### ? Podle MM bez daní má nezadlužený podnik náklady kapitálu r_U = 11 %. Podnik přejde na strukturu CK/VK = 0,6 při nákladech dluhu r_CK = 6 %. Jaké budou náklady vlastního kapitálu?

- [ ] 13,37 %
- [x] 14,00 %
- [ ] 11,00 %
- [ ] 14,60 %

> r_VK = 11 % + (11 % − 6 %) · 0,6 = 14 %. Kontrola: WACC = 14 % · 0,625 + 6 % · 0,375 = 11 % = r_U. 13,37 % vznikne použitím vzorce s daněmi, 11,00 % opomenutím finančního rizika a 14,60 % dosazením r_CK místo rozdílu r_U − r_CK.

### ? Podnik ve světě bez daní má r_VK = 15 %, r_CK = 5 % a podíl dluhu na hodnotě podniku CK/V = 40 %. Jaké budou podle MM náklady vlastního kapitálu, když sníží podíl dluhu na 20 %?

- [ ] 15,0 %
- [ ] 11,0 %
- [ ] 13,0 %
- [x] 12,5 %

> Nejdřív r_U = WACC = 15 % · 0,6 + 5 % · 0,4 = 11 %. Při CK/V = 20 % je CK/VK = 0,25 → r_VK = 11 % + 6 % · 0,25 = 12,5 %. 11 % je r_U, 13 % vznikne, když se prémie 4 p. b. sníží úměrně podílu CK/V místo poměru CK/VK.

### ? Proč podle MM II bez daní NEPLATÍ, že podnik zlevní financování, když nahradí vlastní kapitál levnějším dluhem?

- [x] Růst r_VK přesně vyrovná přínos levnějšího dluhu
- [ ] Na dokonalém trhu se z dluhu neplatí žádné úroky
- [ ] Věřitelé požadují stejný výnos jako vlastníci
- [ ] Na dokonalém trhu si podnik nemůže vůbec půjčit

> S rostoucím dluhem nesou vlastníci vyšší finanční riziko a jejich požadovaný výnos roste lineárně tak, že vážený průměr zůstane r_U. Úroky se platí a dluh je levnější než VK — jen ho kompenzuje zdražení vlastního kapitálu.

## MM s daněmi — hodnota zadluženého podniku {#mm-dane .explain}

V roce 1963 doplnili Modigliani a Miller daň z příjmů korporací. Úroky snižují základ daně, takže zadlužený podnik odvede státu méně a investorům (vlastníkům + věřitelům) zůstane víc:

`V_L = V_U + t · CK`, kde `V_U = EBIT · (1 − t) / r_U`

Člen **t · CK** je současná hodnota daňového štítu z trvalého dluhu: roční štít t · r_CK · CK diskontovaný sazbou r_CK. Hodnota podniku roste s dluhem lineárně, takže teoreticky je optimální téměř 100% dluh. Ve skutečnosti je výhoda menší — podnik musí mít dost zdanitelného zisku, uznatelnost úroků je omezena a podle Millera (1977) část výhody ruší osobní daně investorů; nadto rostou náklady finanční tísně.

*Příklad:* EBIT 10 mil. Kč, t = 21 %, r_U = 10 % → V_U = 7,9 / 0,1 = 79 mil. Kč; trvalý dluh 40 mil. Kč → V_L = 79 + 0,21 · 40 = 87,4 mil. Kč.

### ? Nezadlužený podnik má věčný EBIT 20 mil. Kč, r_U = 10 % a sazbu daně t = 21 %. Pokud si trvale vypůjčí 50 mil. Kč a výtěžkem odkoupí akcie, jaká bude podle MM s daněmi hodnota podniku?

- [ ] 158,0 mil. Kč
- [ ] 200,0 mil. Kč
- [ ] 208,0 mil. Kč
- [x] 168,5 mil. Kč

> V_U = 20 · 0,79 / 0,10 = 158 mil. Kč; V_L = 158 + 0,21 · 50 = 168,5 mil. Kč. 158 mil. Kč je hodnota bez daňového štítu, 200 mil. Kč hodnota bez daní a 208 mil. Kč vznikne přičtením celého dluhu místo štítu.

### ? Podnik má trvalý úvěr 60 mil. Kč s úrokem 5 % a sazbu daně t = 21 %. Jaká je podle MM současná hodnota daňového štítu, diskontuje-li se sazbou r_CK?

- [ ] 0,63 mil. Kč
- [ ] 3,00 mil. Kč
- [ ] 47,40 mil. Kč
- [x] 12,60 mil. Kč

> Roční štít = 60 · 0,05 · 0,21 = 0,63 mil. Kč; jako věčná renta 0,63 / 0,05 = 12,6 mil. Kč = t · CK. 0,63 mil. Kč je jen roční štít, 3 mil. Kč roční úrok a 47,4 mil. Kč dluh po zdanění 60 · 0,79.

## Tvrzení MM II s daněmi a WACC {#mm-dane-wacc .explain}

S daněmi náklady vlastního kapitálu rostou se zadlužením **pomaleji** než bez daní:

`r_VK = r_U + (r_U − r_CK) · (1 − t) · CK/VK`

Protože část rizika „nese" stát přes daňový štít, WACC (s daňově upraveným nákladem dluhu) se zadlužením **klesá**; pro trvalý dluh platí `WACC = r_U · (1 − t · CK/V)`. Minimum WACC a maximum hodnoty by nastalo při téměř 100% dluhu, což odporuje praxi — proto kompromisní teorie přidává náklady finanční tísně.

*Příklad:* r_U = 12 %, r_CK = 6 %, t = 21 %, CK/VK = 1 → r_VK = 12 % + 6 % · 0,79 = 16,74 %; WACC = 0,5 · 16,74 % + 0,5 · 4,74 % = 10,74 % = 12 % · (1 − 0,21 · 0,5).

### ? Podle MM s daněmi: r_U = 11 %, r_CK = 6 %, sazba daně t = 21 %, CK/VK = 0,4. Jaké jsou náklady vlastního kapitálu?

- [ ] 13,00 %
- [ ] 13,50 %
- [x] 12,58 %
- [ ] 11,00 %

> r_VK = 11 % + (11 % − 6 %) · 0,79 · 0,4 = 11 % + 1,58 % = 12,58 %. 13,00 % je výsledek bez daní (MM 1958), 13,50 % vznikne odečtením zdaněného r_CK od r_U místo zdanění celého rozdílu a 11,00 % opomenutím zadlužení.

### ? Podle MM s daněmi má nezadlužený podnik r_U = 10 % a sazbu daně t = 21 %. Jaký bude WACC, když podíl trvalého dluhu na hodnotě podniku CK/V dosáhne 40 %?

- [x] 9,16 %
- [ ] 10,00 %
- [ ] 8,60 %
- [ ] 7,90 %

> WACC = r_U · (1 − t · CK/V) = 10 % · (1 − 0,21 · 0,4) = 9,16 %. 10 % by platilo bez daní, 8,60 % vznikne dosazením poměru CK/VK (0,67) místo CK/V a 7,90 % zdaněním celého r_U.

## Kompromisní teorie (trade-off) {#kompromisni-teorie .explain}

Navazuje na optimální kapitálovou strukturu v Manažerské ekonomice. Hodnota zadluženého podniku:

`V_L = V_U + SH daňového štítu − SH očekávaných nákladů finanční tísně − agentní náklady`

**Náklady finanční tísně** jsou **přímé** (soudní a insolvenční řízení, odměny správce a poradců) a **nepřímé** (odchod zákazníků a dodavatelů, přísnější platební podmínky, odchod klíčových lidí, odklad investic, výprodej majetku pod cenou) — nepřímé bývají vyšší. Očekávané náklady = pravděpodobnost tísně × jejich výše; rostou se zadlužením a jsou vyšší u podniků s nehmotným majetkem a kolísavými peněžními toky. **Optimum** je tam, kde mezní přínos daňového štítu vyrovná mezní očekávané náklady tísně. Teorie předpovídá **cílovou strukturu**: vyšší dluh u ziskových podniků se stabilními toky a hmotným majetkem. Slabinou je, že nejziskovější firmy bývají empiricky málo zadlužené.

*Příklad:* Provozovatel logistických areálů se stálým nájemným unese vysoký dluh; biotechnologický startup s hodnotou v patentech a nejistými tržbami se financuje hlavně vlastním kapitálem.

### ? Nezadlužený podnik má hodnotu 300 mil. Kč, sazba daně t = 21 %. Zvažuje trvalý dluh 100 mil. Kč, při kterém současná hodnota očekávaných nákladů finanční tísně činí 9 mil. Kč; agentní náklady jsou zanedbatelné. Jaká bude hodnota podniku podle kompromisní teorie?

- [ ] 321 mil. Kč
- [ ] 291 mil. Kč
- [ ] 412 mil. Kč
- [x] 312 mil. Kč

> V_L = 300 + 0,21 · 100 − 9 = 312 mil. Kč. 321 mil. Kč je výsledek MM s daněmi bez nákladů tísně, 291 mil. Kč vznikne vynecháním daňového štítu a 412 mil. Kč chybným přičtením celého dluhu.

### ? Který podnik by měl mít podle kompromisní teorie NEJNIŽŠÍ cílový podíl dluhu?

- [ ] Provozovatel nákupních center se stálým nájemným od nájemců
- [x] Softwarová firma s nehmotnými aktivy a kolísavými tržbami
- [ ] Distributor energie s regulovanými cenami a tržbami
- [ ] Ziskový výrobce s vysokou daňovou povinností

> Nehmotný majetek ztrácí v tísni hodnotu a kolísavé tržby zvyšují pravděpodobnost tísně, takže očekávané náklady tísně jsou vysoké. Stabilní toky, hmotný majetek a vysoký zdanitelný zisk naopak vyšší dluh ospravedlňují.

### ? Která položka NENÍ nepřímým nákladem finanční tísně?

- [ ] Odchod zákazníků, kteří se bojí o záruční servis
- [ ] Přísnější platební podmínky od dodavatelů
- [x] Odměna insolvenčního správce a soudní poplatky
- [ ] Odchod klíčových zaměstnanců ke konkurenci

> Odměna správce a soudní poplatky jsou přímé náklady řízení. Ztráta zákazníků, horší podmínky od dodavatelů a odchod lidí jsou nepřímé náklady — nevznikají jako platba, ale jako ušlý zisk a vyšší provozní náklady.

## Agentní náklady a kapitálová struktura {#agentni-naklady .explain}

Agentní teorie (Jensen a Meckling, 1976) vysvětluje vliv struktury konflikty zájmů a z nich plynoucími **agentními náklady** (náklady zastoupení, viz téma 1):

- **Agentní náklady dluhu** (vlastníci × věřitelé) — při hrozbě úpadku mají vlastníci motiv k **přesunu rizika** (asset substitution: riskantní projekty, jejichž zisk připadne jim, ale ztrátu ponesou věřitelé), k **podinvestování** (underinvestment, Myers 1977: odmítnutí projektu s kladnou NPV, protože jeho přínos by připadl hlavně věřitelům) nebo k odčerpání majetku výplatami před úpadkem. Věřitelé se brání **kovenanty**, zajištěním a vyšším úrokem, takže náklad nakonec nesou vlastníci.
- **Agentní náklady vlastního kapitálu** (vlastníci × manažeři) — manažeři mohou plýtvat **volnými peněžními toky** na neefektivní investice a výdaje (Jensen, 1986); dluh je **disciplinuje**, protože povinné úroky a splátky volnou hotovost odčerpají.

Dluh tedy jedny agentní náklady vytváří a jiné snižuje; obojí vstupuje do kompromisní teorie.

*Příklad:* Firma těsně před úpadkem vsadí poslední hotovost na velmi riskantní zakázku — při úspěchu se vlastníci zachrání, při neúspěchu přijdou o peníze hlavně věřitelé.

### ? Firma blízko úpadku odmítne projekt s kladnou NPV, protože jeho výnos by šel hlavně na splacení věřitelů. Jak se tento jev nazývá?

- [ ] Přesun rizika (asset substitution)
- [x] Problém podinvestování (underinvestment)
- [ ] Domácí páka (homemade leverage)
- [ ] Hierarchie zdrojů (pecking order)

> Podinvestování nastává, když vlastníci zadluženého podniku nevloží peníze do výhodného projektu, protože jeho přínos by zvýšil hlavně hodnotu dluhu. Přesun rizika je opačný jev — volba příliš riskantních projektů.

### ? Jak podle Jensenovy teorie volných peněžních toků působí dluh na chování manažerů?

- [x] Splátky odčerpají volnou hotovost a omezí plýtvání
- [ ] Manažeři získají víc prostředků na akvizice
- [ ] Dluh zvyšuje informační asymetrii vůči vlastníkům
- [ ] Úroky převedou kontrolu nad podnikem na manažery

> Pevné úroky a splátky nutí manažery vyplácet hotovost věřitelům místo investic do projektů se zápornou NPV nebo do „impérií". Dluh tak snižuje agentní náklady vlastního kapitálu.

## Teorie hierarchie zdrojů (pecking order) {#pecking-order .explain}

Teorie hierarchie zdrojů (Myers a Majluf, 1984) vychází z **informační asymetrie**: manažeři znají hodnotu a vyhlídky podniku lépe než investoři. Akcie vydávají spíše tehdy, když je považují za **nadhodnocené**; investoři to vědí, a proto oznámení emise chápou jako **negativní signál** a cena akcií klesá. Podnik proto financuje investice v pořadí:

1. **interní zdroje** (zadržený zisk, odpisy),
2. **dluh** — nejprve bezpečný, pak rizikovější, případně hybridní nástroje (konvertibilní dluhopisy),
3. **emise akcií** jako poslední možnost.

Důsledky: **cílová struktura neexistuje** — zadlužení je výsledkem nahromaděné potřeby externího financování; ziskové podniky mají málo dluhu; podniky drží **finanční rezervu** (financial slack — hotovost a nevyčerpanou dluhovou kapacitu), aby nemusely emitovat akcie v nevhodnou chvíli.

*Příklad:* Ziskový technologický podnik financuje vývoj ze zisku a dluh nemá; při velké akvizici si nejprve vezme úvěr a akcie vydá, až když dluhová kapacita nestačí.

### ? V jakém pořadí podle teorie hierarchie zdrojů podnik preferuje zdroje financování?

- [ ] Emise akcií → dluh → zadržený zisk
- [ ] Dluh → zadržený zisk → emise akcií
- [ ] Zadržený zisk → emise akcií → dluh
- [x] Zadržený zisk → dluh → emise akcií

> Interní zdroje nevyžadují zveřejnění informací ani emisní náklady, dluh je méně citlivý na informační asymetrii a emise akcií vysílá negativní signál o nadhodnocení — proto je až poslední.

### ? Proč cena akcií podle Myerse a Majlufa často klesne po oznámení nové emise akcií?

- [ ] Emise vždy snižuje EPS stávajících akcionářů
- [x] Investoři tuší, že manažeři emitují při nadhodnocení
- [ ] Nové akcie mají přednost při výplatě dividend
- [ ] Emisní náklady se odečtou z ceny všech akcií

> Manažeři mají lepší informace a vydávají akcie hlavně tehdy, když je trh přeceňuje. Investoři emisi proto čtou jako signál nadhodnocení a cenu sníží. Kmenové akcie z nové emise žádnou přednost nemají.

## Kompromisní teorie vs. hierarchie zdrojů {#tradeoff-vs-pecking .compare}

| | Kompromisní teorie | Hierarchie zdrojů |
|---|---|---|
| Klíčový faktor | daňový štít × náklady finanční tísně | informační asymetrie mezi manažery a investory |
| Cílová struktura | ano, podnik se k ní vrací | ne, struktura je výsledkem historie financování |
| Ziskový podnik | má mít více dluhu (využije štít) | má méně dluhu (financuje se ze zisku) |
| Emise akcií | běžný nástroj úpravy struktury | poslední možnost, negativní signál |
| Co vysvětluje dobře | rozdíly mezi odvětvími (hmotný majetek, stabilita toků) | nízký dluh ziskových firem, pokles kurzu po oznámení emise |

### ? Empiricky se ukazuje, že nejziskovější podniky v odvětví bývají nejméně zadlužené. Která teorie to vysvětluje lépe?

- [x] Hierarchie zdrojů — ziskové firmy vystačí s interními zdroji
- [ ] Kompromisní teorie — ziskové firmy daňový štít nepotřebují
- [ ] MM s daněmi — vysoký zisk snižuje současnou hodnotu daňového štítu
- [ ] Tradiční přístup — ziskové firmy mají vyšší náklady VK

> Podle hierarchie zdrojů financují ziskové firmy investice ze zadrženého zisku, takže dluh nepotřebují. Kompromisní teorie naopak předpovídá, že ziskové firmy s vysokou daní využijí štít a budou zadluženější; podle MM s daněmi vyšší zdanitelný zisk hodnotu štítu nesnižuje, ale činí ho plně využitelným, a model vede k co nejvyššímu dluhu.

### ? Podnik s rozsáhlým hmotným majetkem a stabilními tržbami pravidelně upravuje financování tak, aby udržel poměr CK/VK kolem 1. Které teorii toto chování odpovídá?

- [ ] Teorii hierarchie zdrojů
- [ ] Modiglianimu a Millerovi bez daní
- [x] Kompromisní teorii
- [ ] Signalizační teorii

> Návrat k cílovému poměru dluhu je typický pro kompromisní teorii — podnik drží strukturu, kde se přínos štítu vyrovnává s náklady tísně. Hierarchie zdrojů cílovou strukturu nepředpokládá a podle MM bez daní na struktuře nezáleží.
