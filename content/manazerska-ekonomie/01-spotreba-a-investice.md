---
kind: topic
subject: manazerska-ekonomie
slug: spotreba-a-investice
name: "Spotřeba a investice"
order: 1
---

Keynesova krátkodobá spotřební funkce. Model mezičasové volby. Teorie životního cyklu a teorie permanentního důchodu. Optimální zásoba kapitálu. Neoklasická teorie poptávky po investicích. Tobinovo q. Změna stavu zásob.

## Keynesova krátkodobá spotřební funkce {#keynes-spotrebni-funkce .explain}

J. M. Keynes v *Obecné teorii zaměstnanosti, úroku a peněz* (1936) formuloval „základní psychologický zákon": s růstem důchodu lidé zvyšují spotřebu, ale o méně, než o kolik vzrostl důchod. Krátkodobá spotřební funkce má tvar `C = Ca + c·YD`, kde **Ca** je autonomní spotřeba (nezávislá na důchodu), **c** mezní sklon ke spotřebě (0 < c < 1) a **YD = Y − T + TR** disponibilní důchod. Spotřeba tedy závisí hlavně na **běžném** disponibilním důchodu; úrokové míře Keynes rozhodující vliv na spotřebu nepřisuzoval. Doplňkem je úsporová funkce `S = YD − C = −Ca + (1 − c)·YD`. Přístup se označuje jako hypotéza absolutního důchodu.

*Příklad:* Ca = 200, c = 0,8. Při YD = 1 000 je C = 200 + 800 = 1 000 a S = 0; při YD = 1 500 je C = 200 + 1 200 = 1 400 a S = 100.

### ? Spotřební funkce je C = 200 + 0,75·YD, důchod Y = 2 000, daně T = 400 a transfery jsou nulové. Jaká je spotřeba?

- [ ] 1 700
- [ ] 1 200
- [x] 1 400
- [ ] 600

> YD = Y − T = 2 000 − 400 = 1 600; C = 200 + 0,75 · 1 600 = 200 + 1 200 = 1 400. Hodnota 1 700 vznikne dosazením Y místo YD, hodnota 600 záměnou c za s (200 + 0,25 · 1 600).

### ? Které tvrzení NEPATŘÍ mezi Keynesovy předpoklady o spotřebě?

- [ ] Mezní sklon ke spotřebě leží mezi 0 a 1
- [ ] Průměrný sklon ke spotřebě s růstem důchodu klesá
- [ ] Hlavním determinantem spotřeby je běžný důchod
- [x] Úroková míra má na spotřebu rozhodující vliv

> Keynes považoval vliv úrokové míry na spotřebu za druhořadý. Úrokovou míru jako determinant spotřeby zdůrazňuje až Fisherův model mezičasové volby.

## Průměrný a mezní sklon ke spotřebě {#apc-mpc .compare}

Oba sklony se počítají z disponibilního důchodu, ale měří něco jiného:

| | Průměrný sklon ke spotřebě (APC) | Mezní sklon ke spotřebě (MPC, c) |
|---|---|---|
| Význam | podíl spotřeby na důchodu | o kolik vzroste spotřeba při růstu důchodu o jednotku |
| Vzorec | `APC = C / YD` | `MPC = ΔC / ΔYD` |
| U funkce C = Ca + c·YD | `APC = Ca/YD + c` | `MPC = c` (konstantní) |
| S růstem YD | klesá a blíží se c | nemění se |
| Vzájemný vztah | APC > MPC (při Ca > 0) | MPC < APC |
| V grafu | sklon spojnice bodu funkce s počátkem | sklon spotřební funkce |
| Doplněk k úsporám | APS = S/YD = 1 − APC | s = 1 − c |

### ? Spotřební funkce je C = 100 + 0,8·YD. Jaký je průměrný sklon ke spotřebě při YD = 1 000?

- [ ] 0,8
- [x] 0,9
- [ ] 1,0
- [ ] 0,2

> C = 100 + 0,8 · 1 000 = 900, APC = 900 / 1 000 = 0,9. Hodnota 0,8 je mezní sklon c, hodnota 0,2 mezní sklon k úsporám.

### ? Co se děje se sklony ke spotřebě v Keynesově funkci C = Ca + c·YD (Ca > 0) při růstu disponibilního důchodu?

- [x] APC klesá a blíží se MPC, MPC se nemění
- [ ] APC roste a blíží se 1, MPC se nemění
- [ ] APC je stálý a rovná se MPC
- [ ] MPC klesá, APC zůstává stálý

> APC = Ca/YD + c: první člen s růstem YD klesá k nule, takže APC klesá směrem k c. MPC je u lineární funkce konstantní. APC = MPC platí jen pro funkci procházející počátkem (Ca = 0).

## Kuznetsova hádanka {#kuznetsova-hadanka .explain}

Z Keynesovy funkce plyne, že s růstem důchodu má APC klesat. Odpovídala tomu průřezová data domácností (bohatší domácnosti spoří větší podíl důchodu) i krátké časové řady. Někteří ekonomové proto za 2. světové války předpovídali, že s růstem důchodů bude podíl spotřeby klesat, poptávka nebude stačit a hrozí **sekulární stagnace** — po válce se to nenaplnilo. **Simon Kuznets** zpracoval dlouhé časové řady USA od roku 1869 a zjistil, že poměr spotřeby k důchodu byl z dekády na dekádu **pozoruhodně stabilní**, přestože důchody silně rostly. Rozpor mezi krátkodobou funkcí (Ca > 0, APC klesá) a dlouhodobou funkcí (přímka z počátku, APC stálý a rovný MPC) se nazývá **Kuznetsova (spotřební) hádanka**. Vysvětlily ji teorie životního cyklu a permanentního důchodu.

*Příklad:* Krátkodobě C = 200 + 0,6·YD: při YD = 1 000 je APC = 800 / 1 000 = 0,8, při YD = 2 000 jen 1 400 / 2 000 = 0,7. Dlouhodobá data odpovídají spíše funkci C ≈ 0,8·YD se stále stejným APC.

### ? Co zjistil Simon Kuznets z dlouhých časových řad spotřeby a důchodu v USA?

- [ ] Průměrný sklon ke spotřebě v dlouhém období výrazně klesal
- [ ] Mezní sklon ke spotřebě byl dlouhodobě větší než 1
- [ ] Spotřeba v dlouhém období silně závisela na úrokové míře
- [x] Poměr spotřeby k důchodu byl dlouhodobě přibližně stálý

> Kuznets ukázal, že i přes velký růst důchodů zůstával APC z dekády na dekádu stabilní — v rozporu s Keynesovou předpovědí klesajícího APC.

### ? Jaký tvar má dlouhodobá spotřební funkce, která odpovídá Kuznetsovým zjištěním?

- [ ] Přímka s kladnou autonomní spotřebou a APC > MPC
- [x] Přímka procházející počátkem, u níž APC = MPC
- [ ] Vodorovná přímka, spotřeba nezávisí na důchodu
- [ ] Křivka, u níž APC s důchodem roste

> Stálý APC znamená, že C = k·Y bez autonomní složky; přímka pak prochází počátkem a průměrný i mezní sklon se rovnají k. Kladná autonomní spotřeba popisuje krátkodobou funkci.

## Mezičasové rozpočtové omezení (Fisher) {#mezicasove-omezeni .explain}

Irving Fisher (*The Theory of Interest*, 1930) zkoumá, jak racionální spotřebitel rozděluje spotřebu mezi současnost a budoucnost. V modelu dvou období má spotřebitel důchody Y₁ a Y₂ a může za reálnou úrokovou míru r spořit i si půjčovat. Platí `C₂ = Y₂ + (1 + r)·(Y₁ − C₁)`, po úpravě **mezičasové rozpočtové omezení**:

`C₁ + C₂/(1 + r) = Y₁ + Y₂/(1 + r)`

Současná hodnota spotřeby se rovná současné hodnotě důchodů. V grafu (C₁ na vodorovné ose, C₂ na svislé) je to přímka se sklonem **−(1 + r)**, která vždy prochází bodem (Y₁, Y₂) — v něm spotřebitel ani nespoří, ani si nepůjčuje. Body vlevo nahoře od něj znamenají spoření, vpravo dole půjčování. Růst r omezení **otočí kolem bodu (Y₁, Y₂)** a zestrmí ho.

*Příklad:* Y₁ = 100, Y₂ = 110, r = 10 %. Současná hodnota důchodů je 100 + 110 / 1,1 = 200. Kdo v 1. období uspoří 20 (C₁ = 80), bude mít C₂ = 110 + 1,1 · 20 = 132.

### ? Spotřebitel má Y₁ = 200, Y₂ = 100, reálná úroková míra je 5 % a v 1. období spotřebuje C₁ = 160. Kolik může spotřebovat ve 2. období?

- [x] 142
- [ ] 140
- [ ] 102
- [ ] 138,1

> Úspora v 1. období je 200 − 160 = 40, s úrokem 40 · 1,05 = 42; C₂ = 100 + 42 = 142. Hodnota 140 opomíjí úrok, 138,1 vznikne chybným diskontováním úspory (40 / 1,05) místo jejího zúročení.

### ? Spotřebitel má Y₁ = 150, Y₂ = 210 a r = 5 %. Kolik nejvýše může spotřebovat v 1. období, pokud si půjčí proti celému budoucímu důchodu?

- [ ] 360
- [x] 350
- [ ] 370,5
- [ ] 150

> Maximum C₁ je současná hodnota důchodů: 150 + 210 / 1,05 = 150 + 200 = 350. Hodnota 360 ignoruje diskontování, 370,5 budoucí důchod chybně zúročí (210 · 1,05).

### ? Jak se změní mezičasové rozpočtové omezení, když vzroste reálná úroková míra?

- [ ] Posune se rovnoběžně doprava
- [ ] Otočí se kolem průsečíku s vodorovnou osou
- [ ] Nezmění se, protože důchody Y₁ a Y₂ jsou stejné
- [x] Otočí se kolem bodu (Y₁, Y₂) a bude strmější

> Sklon omezení je −(1 + r), takže s růstem r je strmější. Bod (Y₁, Y₂) je dosažitelný vždy (bez spoření i půjček), proto se přímka otáčí právě kolem něj.

## Optimum spotřebitele ve Fisherově modelu {#fisher-optimum .explain}

Preference spotřebitele popisují **indiferenční křivky** mezi C₁ a C₂; jejich sklon udává **mezní míru substituce** MRS — kolik jednotek C₂ je spotřebitel ochoten obětovat za jednotku C₁ navíc. Optimum leží v bodě, kde se nejvyšší dosažitelná indiferenční křivka dotýká rozpočtového omezení: `MRS = 1 + r`. Z modelu plyne, že spotřeba v obou obdobích závisí na **současné hodnotě celoživotních důchodů**, nikoli jen na běžném důchodu; časové rozložení důchodů je (bez likviditních omezení) nepodstatné. Jsou-li C₁ i C₂ normální statky, zvýšení Y₁ nebo Y₂ zvýší spotřebu v obou obdobích — spotřebitel **vyhlazuje spotřebu** (consumption smoothing).

*Příklad:* Y₁ = 100, Y₂ = 110, r = 10 % a spotřebitel, jehož optimum je C₁ = C₂. Z C₁ + C₁/1,1 = 200 vychází C₁ = C₂ ≈ 104,8: v 1. období si půjčí asi 4,8 a ve 2. splatí 4,8 · 1,1 ≈ 5,2.

### ? Jaká podmínka platí v optimu spotřebitele ve Fisherově modelu?

- [ ] MRS = r
- [ ] MRS = 1
- [x] MRS = 1 + r
- [ ] MRS = 1/(1 + r)

> V optimu se indiferenční křivka dotýká rozpočtového omezení, jehož sklon je −(1 + r). Mezní míra substituce C₁ za C₂ se tedy rovná 1 + r — ceně dnešní spotřeby vyjádřené v budoucí spotřebě.

### ? Spotřebitel se dozví, že jeho důchod ve 2. období bude vyšší, než čekal. Y₁ ani r se nemění, likviditní omezení nejsou a spotřeba je normální statek. Co udělá?

- [x] Zvýší spotřebu v 1. i ve 2. období
- [ ] Zvýší jen spotřebu ve 2. období, C₁ se nezmění
- [ ] Sníží C₁ a o to více zvýší C₂
- [ ] Nezmění nic, protože běžný důchod je stejný

> Vyšší Y₂ zvýší současnou hodnotu celoživotních důchodů a posune rozpočtové omezení doprava. Spotřebitel vyhlazuje spotřebu, takže si část budoucího přírůstku „přenese" do současnosti půjčkou nebo nižším spořením.

## Vliv úrokové míry: substituční a důchodový efekt {#fisher-urokova-mira .compare}

Růst reálné úrokové míry r působí na spotřebu dvěma efekty (C₁ i C₂ jsou normální statky):

| | Substituční efekt | Důchodový efekt | Celkový dopad |
|---|---|---|---|
| **Střadatel** (C₁ < Y₁) | C₁ ↓, C₂ ↑ — dnešní spotřeba zdražila vůči budoucí | C₁ ↑, C₂ ↑ — úroky z úspor ho obohacují | C₂ jistě ↑, C₁ nejednoznačně |
| **Dlužník** (C₁ > Y₁) | C₁ ↓, C₂ ↑ | C₁ ↓, C₂ ↓ — vyšší úroky z dluhu ho ochuzují | C₁ jistě ↓, C₂ nejednoznačně |

Proto teorie ani empirie nedávají jednoznačnou odpověď, zda vyšší úroková míra zvyšuje úspory domácností.

### ? Střadateli vzroste reálná úroková míra. Co lze o jeho spotřebě říci jednoznačně?

- [ ] Spotřeba v 1. období klesne
- [x] Spotřeba ve 2. období vzroste
- [ ] Spotřeba v obou obdobích klesne
- [ ] C₁ vzroste a C₂ klesne

> U střadatele oba efekty zvyšují C₂ (substituční i důchodový). Na C₁ působí substituční efekt dolů a důchodový nahoru, takže výsledek je nejednoznačný.

### ? Dlužníkovi vzroste reálná úroková míra. Co lze o jeho spotřebě říci jednoznačně?

- [ ] Spotřeba v 1. období vzroste
- [ ] Spotřeba v 1. období se nezmění
- [ ] Spotřeba ve 2. období vzroste
- [x] Spotřeba v 1. období klesne

> U dlužníka substituční efekt snižuje C₁ a důchodový efekt (vyšší úroky ho ochuzují) také. Na C₂ působí efekty proti sobě, takže dopad na C₂ je nejednoznačný.

### ? Jak působí samotný substituční efekt růstu reálné úrokové míry?

- [ ] C₁ i C₂ vzrostou
- [ ] C₁ vzroste, C₂ klesne
- [x] C₁ klesne, C₂ vzroste
- [ ] C₁ i C₂ klesnou

> Vyšší r znamená, že za jednotku dnešní spotřeby se obětuje víc budoucí spotřeby (1 + r). Dnešní spotřeba relativně zdraží, a proto ji spotřebitel nahrazuje budoucí.

## Likviditní omezení {#likviditni-omezeni .explain}

Fisherův model předpokládá, že si lze volně půjčit proti budoucímu důchodu. Mnoho domácností (studenti, mladé rodiny, lidé bez zajištění) však úvěr nedostane nebo jen za vysoký úrok. **Likviditní omezení** (omezení půjček, borrowing constraint) přidává podmínku `C₁ ≤ Y₁`: rozpočtová množina je vpravo od bodu (Y₁, Y₂) uříznuta svislou čarou. Chtěl-li by spotřebitel bez omezení utrácet víc, než činí běžný důchod, je omezení **závazné** a platí `C₁ = Y₁` — spotřeba pak závisí na **běžném** důchodu, nikoli na celoživotních zdrojích. Pro takové domácnosti je Keynesova spotřební funkce dobrým popisem a jejich sklon ke spotřebě z běžného důchodu je vysoký. Spotřebitele, který chce spořit, omezení neovlivní.

*Příklad:* Student má Y₁ = 120 tis. Kč, po škole očekává Y₂ = 600 tis. Kč a rád by dnes utratil 250 tis. Kč, ale banka mu bez zajištění nepůjčí. Utratí tedy 120 tis. Kč; přivydělá-li si brigádou 30 tis. Kč, utratí je celé (mezní sklon ke spotřebě je při závazném omezení 1).

### ? Spotřebitel by si rád půjčil, ale nemůže (likviditní omezení je závazné). Čemu se rovná jeho spotřeba v 1. období?

- [x] C₁ = Y₁
- [ ] C₁ = Y₁ + Y₂/(1 + r)
- [ ] C₁ = Y₂
- [ ] C₁ = (1 + r)·Y₁

> Při závazném omezení spotřebitel utratí celý běžný důchod, ale nic víc: C₁ = Y₁. Výraz Y₁ + Y₂/(1 + r) je spotřeba, kterou by si mohl dovolit bez omezení.

### ? Student se závazným likviditním omezením dostane nabídku dobře placené práce po ukončení studia. Jak se změní jeho spotřeba v 1. období?

- [ ] Vzroste o současnou hodnotu očekávaného přírůstku důchodu
- [ ] Klesne, protože začne spořit na budoucnost
- [x] Nezmění se, zůstane rovna běžnému důchodu
- [ ] Vzroste o mezní sklon ke spotřebě násobený přírůstkem Y₂

> Vyšší Y₂ zvyšuje spotřebu, kterou by si student přál dnes, ale bez možnosti půjčky zůstává C₁ = Y₁. Spotřebu omezeného spotřebitele ovlivní jen změna běžného důchodu.

## Teorie životního cyklu (Modigliani) {#zivotni-cyklus .explain}

Franco Modigliani (s R. Brumbergem a A. Andem v 50. letech; Nobelova cena 1985) vychází z toho, že důchod během života kolísá — v mládí je nízký, v produktivním věku vysoký, v penzi klesá — a lidé se úsporami a půjčkami snaží udržet **stabilní spotřebu po celý život**. Spotřebitel očekává, že bude žít ještě **T** let, má bohatství **W** a bude pobírat důchod **Y** ještě **R** let do odchodu do penze. Celoživotní zdroje W + R·Y rozloží rovnoměrně do zbývajících let (základní verze předpokládá nulovou úrokovou míru):

`C = (W + R·Y) / T = α·W + β·Y`, kde α = 1/T a β = R/T.

Spotřeba tedy závisí na **bohatství i důchodu**; α je mezní sklon ke spotřebě z bohatství, β z důchodu. Agregovaná spotřební funkce má stejný tvar.

*Příklad:* T = 40 let, R = 30 let, W = 800 tis. Kč, Y = 400 tis. Kč ročně → C = (800 + 30 · 400) / 40 = 12 800 / 40 = 320 tis. Kč ročně; α = 0,025, β = 0,75.

### ? Spotřebitel bude žít ještě 50 let, z toho 30 let bude pracovat s ročním důchodem 300 tis. Kč, a má bohatství 600 tis. Kč. Jaká je jeho roční spotřeba podle teorie životního cyklu?

- [ ] 180 tis. Kč
- [ ] 320 tis. Kč
- [ ] 300 tis. Kč
- [x] 192 tis. Kč

> C = (W + R·Y) / T = (600 + 30 · 300) / 50 = 9 600 / 50 = 192 tis. Kč. Hodnota 180 opomíjí bohatství, hodnota 320 dělí chybně délkou pracovního života R místo T.

### ? Spotřebitel bude žít ještě T = 50 let a pracovat R = 30 let. Zdědí 100 tis. Kč. O kolik vzroste jeho roční spotřeba?

- [ ] O 100 tis. Kč
- [x] O 2 tis. Kč
- [ ] O 60 tis. Kč
- [ ] O 3,3 tis. Kč

> Mezní sklon ke spotřebě z bohatství je α = 1/T = 1/50, takže ΔC = 100 / 50 = 2 tis. Kč ročně. Hodnota 60 použije chybně β = R/T, hodnota 3,3 dělí délkou pracovního života.

## Životní cyklus, sklon ke spotřebě a úspory {#zivotni-cyklus-apc .explain}

Z funkce `C = α·W + β·Y` plyne průměrný sklon `APC = C/Y = α·(W/Y) + β`. **Krátkodobě** a v průřezu domácností se bohatství nemění úměrně s důchodem: domácnost s vyšším důchodem má nižší W/Y, a tedy nižší APC — krátkodobá funkce vypadá keynesiánsky (autonomní spotřebě odpovídá α·W). **Dlouhodobě** roste bohatství spolu s důchodem, poměr W/Y je přibližně stálý, a proto je stálý i APC — tím teorie vysvětluje Kuznetsova zjištění. Lidé podle teorie spoří v produktivním věku a v penzi úspory čerpají, takže bohatství vrcholí při odchodu do penze (profil ve tvaru hrbu). Empiricky však starší lidé čerpají úspory pomaleji, než model předpovídá — kvůli nejisté délce života a výdajům na zdraví (preventivní úspory) a kvůli snaze zanechat dědictví.

*Příklad:* α = 0,025, β = 0,75. Při W/Y = 2 je APC = 0,05 + 0,75 = 0,8; vzroste-li krátkodobě Y tak, že W/Y klesne na 1, klesne APC na 0,775.

### ? Proč podle teorie životního cyklu krátkodobě APC s růstem důchodu klesá?

- [x] Bohatství neroste úměrně s důchodem, takže W/Y klesá
- [ ] Mezní sklon ke spotřebě z důchodu β s důchodem klesá
- [ ] Lidé s vyšším důchodem očekávají kratší život
- [ ] S důchodem roste úroková míra a substituční efekt

> APC = α·(W/Y) + β. Krátkodobě je bohatství téměř dané, takže růst Y snižuje W/Y a tím APC. Dlouhodobě roste W s Y a APC zůstává stálý.

### ? Jak podle teorie životního cyklu vypadá průběh úspor během života?

- [ ] Lidé spoří celý život stejný podíl důchodu
- [ ] Nejvíce spoří v penzi z důchodových dávek
- [x] V produktivním věku spoří, v penzi úspory čerpají
- [ ] V produktivním věku si půjčují a v penzi splácejí

> Pracovní důchod je soustředěn do produktivního věku, spotřeba je rozložena rovnoměrně — proto se v produktivním věku spoří a v penzi úspory spotřebovávají.

### ? Proč starší lidé čerpají úspory pomaleji, než předpovídá základní model životního cyklu?

- [ ] V penzi jejich důchod obvykle roste
- [x] Kvůli nejisté délce života a snaze zanechat dědictví
- [ ] Model předpokládá, že v penzi spoří stejně jako dříve
- [ ] Jejich průměrný sklon ke spotřebě je vyšší než 1

> Neznámá délka života a riziko vysokých výdajů na zdraví vedou k preventivním úsporám; část lidí chce také zanechat dědictví. Obojí zpomaluje čerpání bohatství v penzi.

## Teorie permanentního důchodu (Friedman) {#permanentni-duchod .explain}

Milton Friedman (*A Theory of the Consumption Function*, 1957; Nobelova cena 1976) dělí běžný důchod na **permanentní** Yᴾ (trvalý, očekávaný průměrný důchod — odpovídá vzdělání, schopnostem, majetku) a **přechodný** Yᵀ (dočasná, nečekaná odchylka, v průměru nulová): `Y = Yᴾ + Yᵀ`. Spotřeba závisí na permanentním důchodu: `C = α·Yᴾ`. Přechodný důchod domácnosti z velké části uspoří (pokles naopak pokryjí z úspor), protože jeho spotřebu rozloží do mnoha let. Průměrný sklon je `APC = C/Y = α·Yᴾ/Y`: v průřezu mají domácnosti s vysokým běžným důchodem v průměru kladný přechodný důchod, a proto nižší APC; dlouhodobě je kolísání důchodu převážně permanentní, takže APC je stálý. Permanentní důchod Friedman odhadoval jako vážený průměr minulých důchodů (adaptivní očekávání).

*Příklad:* Yᴾ = 500 tis. Kč, α = 0,9 → C = 450 tis. Kč. Při jednorázové prémii 100 tis. Kč je Y = 600 tis. Kč, ale C zůstane přibližně 450 tis. Kč a APC klesne z 0,9 na 0,75.

### ? Domácnost má permanentní důchod 400 tis. Kč a α = 0,9. Letos dostane jednorázovou prémii 50 tis. Kč. Jaký je její APC z běžného důchodu podle základní verze teorie?

- [ ] 0,9
- [ ] 0,72
- [x] 0,8
- [ ] 0,85

> C = 0,9 · 400 = 360 tis. Kč (přechodná prémie spotřebu neovlivní), běžný důchod Y = 450 tis. Kč, APC = 360 / 450 = 0,8. Hodnota 0,9 je α, tedy APC z permanentního důchodu.

### ? Proč mají v průřezových datech domácnosti s vysokým běžným důchodem nižší APC?

- [ ] Mají vyšší koeficient α než ostatní domácnosti
- [ ] Jejich permanentní důchod je nižší než nula
- [ ] Spotřebovávají celý svůj přechodný důchod
- [x] Mají v průměru kladný přechodný důchod

> Mezi domácnostmi s vysokým běžným důchodem je víc těch, které mají právě kladný přechodný důchod. Ten se převážně uspoří, takže C/Y je u nich nižší.

## Permanentní vs. přechodná změna důchodu {#permanentni-vs-prechodny .compare}

Reakce spotřeby na změnu důchodu závisí na tom, zda je změna trvalá, nebo dočasná:

| Změna důchodu | Druh | Keynes (C = Ca + c·YD) | Friedman (C = α·Yᴾ) |
|---|---|---|---|
| Trvalé zvýšení platu po povýšení | permanentní | C vzroste o c·ΔYD | C vzroste o α·ΔYᴾ — výrazně |
| Jednorázová prémie, výhra v loterii | přechodný | C vzroste o c·ΔYD | C vzroste jen málo, většina se uspoří |
| Dočasné snížení daní na jeden rok | přechodný | silný dopad na C | slabý dopad na C |
| Trvalé snížení daní | permanentní | silný dopad na C | silný dopad na C |
| Dočasný výpadek příjmu v recesi | převážně přechodný | C klesne o c·ΔYD | C klesne málo, domácnost čerpá úspory |

### ? Vláda na jeden rok sníží daně a předem oznámí, že pak se vrátí na původní úroveň. Co podle teorie permanentního důchodu nastane?

- [ ] Spotřeba vzroste o c·ΔYD jako v Keynesově modelu
- [x] Spotřeba vzroste jen málo, většina se uspoří
- [ ] Spotřeba vzroste o celou částku ušetřenou na daních
- [ ] Spotřeba trvale vzroste o α násobek snížení daní

> Dočasné snížení daní je přechodný důchod, který permanentní důchod zvýší jen nepatrně. Domácnosti ho převážně uspoří, takže dopad na spotřebu je slabý.

### ? Která změna představuje především změnu permanentního důchodu?

- [ ] Výhra 200 tis. Kč v loterii
- [ ] Mimořádně dobrá úroda farmáře v jednom roce
- [x] Dokončení VŠ studia a trvale lépe placená práce
- [ ] Jednorázová vánoční prémie

> Vzdělání a nová trvale lépe placená práce zvyšují očekávaný průměrný důchod na mnoho let dopředu. Výhra, jednorázová prémie i výjimečná úroda jsou přechodný důchod.

## Srovnání teorií spotřeby {#srovnani-teorii-spotreby .compare}

| | Keynes | Fisher | Modigliani (životní cyklus) | Friedman (permanentní důchod) |
|---|---|---|---|---|
| Hlavní determinant C | běžný disponibilní důchod | současná hodnota důchodů všech období | bohatství a celoživotní pracovní důchod | permanentní důchod |
| Časový horizont | jedno období | více období (model dvou období) | zbývající délka života | dlouhodobý (trvalý) důchod |
| Vyhlazování spotřeby | ne | ano | ano | ano |
| APC s růstem důchodu | klesá | model přímo nezkoumá | krátkodobě klesá, dlouhodobě stálý | krátkodobě klesá, dlouhodobě stálý |
| Reakce C na přechodný nárůst důchodu | silná (o c·ΔYD) | slabá, rozloží se do obou období | slabá, rozloží se do zbytku života | velmi slabá, většina se uspoří |
| Klíčový koncept | mezní sklon ke spotřebě | mezičasové omezení, úroková míra | bohatství, fáze života | permanentní a přechodný důchod |

Keynesovo chování dobře popisuje domácnosti s likviditním omezením.

### ? Podle které teorie se přechodné zvýšení důchodu nejsilněji projeví v běžné spotřebě?

- [x] Keynesovy hypotézy absolutního důchodu
- [ ] Friedmanovy teorie permanentního důchodu
- [ ] Modiglianiho teorie životního cyklu
- [ ] Fisherova modelu bez likviditních omezení

> V Keynesově funkci zvýší každá koruna běžného disponibilního důchodu spotřebu o c bez ohledu na trvalost změny. Ostatní teorie předpokládají vyhlazování spotřeby, takže přechodný důchod se rozloží do delšího období.

### ? Co mají společného teorie životního cyklu a teorie permanentního důchodu?

- [ ] Spotřeba závisí výhradně na běžném důchodu
- [ ] APC s růstem důchodu v dlouhém období klesá
- [x] Spotřeba závisí na dlouhodobých zdrojích a domácnosti ji vyhlazují
- [ ] Úspory domácností jsou v každém období nulové

> Obě teorie navazují na Fisherův model: spotřeba se odvíjí od celoživotních či trvalých zdrojů a je v čase vyhlazena. Obě také vysvětlují dlouhodobě stálý APC.

## Investice a jejich druhy {#druhy-investic .term}

Investice (I) jsou v makroekonomii výdaje na **nový kapitál**: **fixní investice firem** (stroje, budovy, software), **investice do bydlení** (nové byty a domy) a **změna stavu zásob**; nákup akcií či již existujících aktiv je jen finanční investice (převod vlastnictví), nikoli výdaj I. **Hrubé investice** zahrnují i náhradu opotřebeného kapitálu, **čisté investice** = hrubé investice − opotřebení (δ·K) a rovnají se přírůstku zásoby kapitálu ΔK.

### ? Co NENÍ investicí ve smyslu výdajové složky HDP?

- [ ] Nákup nového výrobního stroje firmou
- [x] Nákup akcií existující firmy domácností
- [ ] Výstavba nového rodinného domu
- [ ] Přírůstek zásob hotových výrobků

> Nákup akcií jen převádí vlastnictví existujícího kapitálu, nový kapitál nevzniká. Stroje, nové domy i přírůstek zásob jsou investice v makroekonomickém smyslu.

### ? Hrubé investice v ekonomice činí 500 mld. Kč a opotřebení kapitálu 420 mld. Kč. Jak se změní zásoba kapitálu?

- [x] Vzroste o 80 mld. Kč
- [ ] Vzroste o 500 mld. Kč
- [ ] Vzroste o 920 mld. Kč
- [ ] Klesne o 80 mld. Kč

> ΔK = čisté investice = hrubé investice − opotřebení = 500 − 420 = 80 mld. Kč. Hrubé investice nejsou celé přírůstkem kapitálu, protože 420 mld. Kč jen nahrazuje opotřebený kapitál.

## Uživatelské náklady kapitálu {#uzivatelske-naklady .explain}

Uživatelské náklady kapitálu (user cost of capital, D. Jorgenson) jsou roční náklady na držení jednotky kapitálu — stejné, ať ho firma vlastní, nebo si ho pronajímá. Tvoří je **ušlý úrok** i·P_K (peníze vázané ve stroji by jinak nesly úrok) a **opotřebení** δ·P_K, odečítá se **kapitálový zisk** z růstu ceny kapitálu ΔP_K (P_K je cena jednotky kapitálu):

`uživatelské náklady = P_K · (i − ΔP_K/P_K + δ)`

Rostou-li ceny kapitálu stejně jako ostatní ceny, je i − ΔP_K/P_K ≈ r a náklady jsou `P_K · (r + δ)`; reálně (v jednotkách produkce) `(P_K/P) · (r + δ)`. Uživatelské náklady zvyšuje vyšší reálná úroková míra, vyšší relativní cena kapitálu a rychlejší opotřebení; snižují je daňové úlevy na investice (investiční pobídky, zrychlené odpisy).

*Příklad:* Stroj za P_K = 2 mil. Kč, r = 4 %, δ = 6 % → uživatelské náklady 2 000 · 0,10 = 200 tis. Kč ročně.

### ? Stroj stojí 1 mil. Kč, nominální úroková míra je 6 %, cena strojů roste o 2 % ročně a míra opotřebení je 10 %. Jaké jsou roční uživatelské náklady kapitálu?

- [ ] 180 tis. Kč
- [ ] 160 tis. Kč
- [x] 140 tis. Kč
- [ ] 60 tis. Kč

> 1 000 · (0,06 − 0,02 + 0,10) = 1 000 · 0,14 = 140 tis. Kč. Hodnota 180 růst ceny chybně přičítá, 160 ho ignoruje a 60 zahrnuje jen ušlý úrok.

### ? Která změna uživatelské náklady kapitálu ZVÝŠÍ?

- [ ] Zavedení investiční daňové úlevy
- [ ] Očekávaný rychlejší růst ceny kapitálu
- [ ] Delší životnost strojů, tj. nižší δ
- [x] Růst reálné úrokové míry

> Vyšší r zvyšuje ušlý úrok z kapitálu. Daňová úleva, kapitálový zisk z růstu ceny kapitálu i nižší opotřebení uživatelské náklady naopak snižují.

## Optimální zásoba kapitálu {#optimalni-zasoba-kapitalu .explain}

Firma rozšiřuje zásobu kapitálu, dokud se přínos dodatečné jednotky kapitálu nevyrovná nákladům na ni. Přínosem je **mezní produkt kapitálu** MPK, který kvůli klesajícím výnosům s růstem zásoby kapitálu klesá. Optimální zásoba kapitálu K* proto splňuje podmínku

`MPK = (P_K/P) · (r + δ)` — mezní produkt kapitálu = reálné uživatelské náklady kapitálu.

Je-li MPK vyšší než náklady, vyplatí se kapitál přidávat; je-li nižší, firma ho nechá opotřebovat. K* roste s technologickým pokrokem (vyšší MPK) a s vyšší očekávanou produkcí, klesá s růstem r, δ a relativní ceny kapitálu. Pro Cobb–Douglasovu produkční funkci je MPK = α·Y/K, takže při dané produkci Y a P_K/P = 1 vychází `K* = α·Y / (r + δ)`.

*Příklad:* α = 0,3, Y = 1 200, r + δ = 0,12 → K* = 0,3 · 1 200 / 0,12 = 360 / 0,12 = 3 000.

### ? Pro Cobb–Douglasovu funkci platí α = 0,3, Y = 1 000, r = 5 %, δ = 10 % a P_K/P = 1. Jaká je optimální zásoba kapitálu?

- [ ] 6 000
- [x] 2 000
- [ ] 3 000
- [ ] 1 500

> K* = α·Y / (r + δ) = 0,3 · 1 000 / 0,15 = 300 / 0,15 = 2 000. Hodnota 6 000 opomíjí opotřebení (300 / 0,05), hodnota 1 500 odpovídá r = 10 % (300 / 0,2).

### ? Mezní produkt kapitálu firmy je 0,18 a reálné uživatelské náklady kapitálu 0,15. Co je pro firmu optimální?

- [ ] Snížit zásobu kapitálu, aby MPK vzrostl
- [ ] Ponechat zásobu kapitálu, firma je v optimu
- [ ] Investovat jen do náhrady opotřebeného kapitálu
- [x] Zvyšovat zásobu kapitálu, dokud MPK neklesne na 0,15

> Dodatečná jednotka kapitálu přináší víc (0,18), než stojí (0,15), takže se vyplatí investovat. S růstem K mezní produkt klesá, dokud se nevyrovná uživatelským nákladům.

## Neoklasická teorie poptávky po investicích {#neoklasicka-investicni-funkce .explain}

Neoklasická teorie investic (D. Jorgenson, 60. léta) odvozuje investice z rozdílu mezi optimální a skutečnou zásobou kapitálu. Firmy zvyšují kapitál, pokud MPK převyšuje reálné uživatelské náklady:

`I = Iₙ(MPK − (P_K/P) · (r + δ)) + δ·K`

První člen jsou **čisté investice** (rostoucí funkce rozdílu mezi MPK a náklady kapitálu), druhý **náhradové investice** δ·K. Přizpůsobení kapitálu je nákladné a trvá (výstavba, instalace), proto firmy mezeru uzavírají postupně, např. `čisté investice = λ · (K* − K)`, 0 < λ < 1 (model flexibilního akcelerátoru). Investiční funkce proto **klesá s reálnou úrokovou mírou**; doprava se posouvá při technologickém pokroku, očekávaném růstu poptávky či daňových pobídkách.

*Příklad:* K* = 3 000, K = 2 600, λ = 0,25, δ = 0,1 → čisté investice 0,25 · 400 = 100, náhradové 0,1 · 2 600 = 260, hrubé investice 360.

### ? Optimální zásoba kapitálu je 2 000, skutečná 1 800, firma uzavírá ročně 25 % mezery a míra opotřebení je 10 %. Jaké jsou hrubé investice?

- [ ] 200
- [ ] 50
- [ ] 250
- [x] 230

> Čisté investice = 0,25 · (2 000 − 1 800) = 50, náhradové = 0,1 · 1 800 = 180, hrubé = 50 + 180 = 230. Hodnota 50 jsou jen čisté investice, 200 celá mezera a 250 počítá opotřebení chybně z K*.

### ? Proč neoklasická investiční funkce klesá s reálnou úrokovou mírou?

- [x] Vyšší r zvyšuje uživatelské náklady kapitálu a snižuje K*
- [ ] Vyšší r zvyšuje mezní produkt kapitálu
- [ ] Vyšší r zrychluje opotřebení kapitálu
- [ ] Vyšší r zvyšuje Tobinovo q

> Reálná úroková míra je součástí uživatelských nákladů (P_K/P)·(r + δ). Při jejich růstu se rovnost s MPK dosáhne při menší zásobě kapitálu, takže firmy investují méně.

## Tobinovo q {#tobinovo-q .explain}

James Tobin (1969; Nobelova cena 1981) navrhl měřit motivaci k investicím poměrem

`q = tržní hodnota instalovaného kapitálu / reprodukční (náhradová) cena kapitálu`

Čitatel vychází z ocenění firmy na akciovém trhu, jmenovatel udává, kolik by stálo pořídit tentýž kapitál nově. Je-li **q > 1**, trh oceňuje kapitál výše, než stojí jeho pořízení — vyplatí se investovat. Je-li **q < 1**, firmy nenahrazují ani opotřebený kapitál. Tržní hodnota odráží očekávané budoucí zisky z kapitálu, takže q > 1 odpovídá situaci MPK > uživatelské náklady v neoklasickém modelu. Pro rozhodování je teoreticky podstatné **mezní** q (pro nové jednotky kapitálu), v datech se však měří **průměrné** q; shodují se jen za zvláštních předpokladů (F. Hayashi, 1982). Teorie vysvětluje, proč investice reagují na vývoj akciového trhu.

*Příklad:* Akciový trh oceňuje kapitál firmy na 900 mil. Kč, jeho nové pořízení by stálo 1 200 mil. Kč → q = 0,75 < 1, firma nové investice odloží.

### ? Akciový trh oceňuje kapitál firmy na 1,5 mld. Kč, nové pořízení stejného kapitálu by stálo 1,2 mld. Kč. Jaké je Tobinovo q a co z něj plyne?

- [ ] q = 0,8; investovat se nevyplatí
- [ ] q = 1,25; investovat se nevyplatí
- [x] q = 1,25; investice se vyplatí
- [ ] q = 0,8; investice se vyplatí

> q = 1,5 / 1,2 = 1,25 > 1: trh oceňuje instalovaný kapitál výše, než stojí jeho pořízení, takže nové investice zvyšují hodnotu firmy. Hodnota 0,8 vznikne převrácením zlomku.

### ? Ceny akcií prudce klesnou, ceny nových strojů se nezmění. Co předpovídá teorie Tobinova q?

- [x] q klesne a investice se sníží
- [ ] q vzroste a investice se zvýší
- [ ] q se nezmění, rozhodují jen úrokové sazby
- [ ] q klesne, ale investice vzrostou, protože firmy zlevnily

> Pokles cen akcií snižuje tržní hodnotu instalovaného kapitálu, a tedy čitatel q. Při nezměněné reprodukční ceně kapitálu q klesá a motivace investovat slábne.

## Motivy držby zásob {#motivy-drzby-zasob .compare}

Změna stavu zásob je malou, ale velmi kolísavou složkou investic; firmy drží zásoby z několika motivů:

| Motiv | Podstata | Příklad |
|---|---|---|
| **Vyhlazování výroby** (production smoothing) | výroba se udržuje rovnoměrná, zásoby rostou při nízkých a klesají při vysokých prodejích; je to levnější než měnit tempo výroby | výrobce hraček vyrábí celý rok a zásoby prodá v předvánoční sezóně |
| **Zásoby jako výrobní faktor** | zásoba vstupů umožňuje vyrábět a prodávat efektivněji, bez prostojů | továrna drží suroviny a díly, aby nemusela čekat na každou dodávku |
| **Předcházení vyprodání** (stock-out avoidance) | rezerva pro nečekaně vysoké prodeje, protože o výrobě se rozhoduje dřív, než jsou prodeje známy | prodejce aut má vozy na skladě, aby zákazník neodešel ke konkurenci |
| **Rozpracovaná výroba** (work in process) | výroba trvá určitou dobu, nedokončené výrobky jsou také zásobou | rozestavěná auta na montážní lince |

### ? Prodejce elektroniky drží před Vánoci větší sklad, protože poptávku nelze přesně odhadnout a nechce přijít o zákazníky. O který motiv držby zásob jde?

- [x] Předcházení vyprodání
- [ ] Rozpracovaná výroba
- [ ] Vyhlazování výroby
- [ ] Zásoby jako výrobní faktor

> Zásoba slouží jako rezerva pro nečekaně vysokou poptávku — jde o předcházení vyprodání (stock-out avoidance). Vyhlazování výroby by znamenalo rovnoměrnou výrobu během roku.

### ? Do které kategorie zásob patří trupy letadel rozestavěné v montážní hale?

- [ ] Zásoby hotových výrobků
- [x] Rozpracovaná výroba
- [ ] Zásoby pro předcházení vyprodání
- [ ] Zásoby pro vyhlazování výroby

> Nedokončené výrobky, které jsou teprve ve výrobním procesu, tvoří rozpracovanou výrobu (work in process).

## Akcelerátorový model zásob {#akcelerator-zasob .explain}

Akcelerátorový model předpokládá, že firmy chtějí držet zásoby úměrné produkci (prodejům): `N = β·Y`, kde N je zásoba a β žádoucí poměr zásob k produkci. Investice do zásob jsou změnou zásoby: `ΔN = β·ΔY`. Nezávisí tedy na **úrovni** produkce, ale na její **změně** — zpomalí-li růst produkce, investice do zásob klesnou, i když produkce stále roste; při poklesu produkce jsou záporné. Změna stavu zásob proto zesiluje hospodářský cyklus a v recesích výrazně přispívá k poklesu výdajů. Vliv má i úroková míra: držba zásob váže kapitál, takže vyšší reálná úroková míra zvyšuje náklady příležitosti a snižuje žádoucí zásoby.

*Příklad:* β = 0,2. Produkce vzroste z 1 000 na 1 100 → ΔN = 0,2 · 100 = 20; další rok vzroste jen na 1 150 → ΔN = 10. Investice do zásob se sníží na polovinu, přestože produkce dál roste.

### ? Žádoucí poměr zásob k produkci je β = 0,25 a produkce klesne z 2 080 na 2 000. Jaké jsou investice do zásob podle akcelerátorového modelu?

- [ ] +20
- [ ] 500
- [ ] −80
- [x] −20

> ΔN = β·ΔY = 0,25 · (2 000 − 2 080) = 0,25 · (−80) = −20. Hodnota 500 je úroveň zásoby β·Y, hodnota −80 změna produkce bez násobení β.

### ? Co podle akcelerátorového modelu nastane s investicemi do zásob, pokud produkce zůstane dva roky na stejné vysoké úrovni?

- [ ] Budou vysoké, protože produkce je vysoká
- [ ] Budou záporné, protože růst se zastavil
- [x] Budou nulové
- [ ] Budou rovny β·Y

> Investice do zásob závisí na změně produkce: při ΔY = 0 je ΔN = β · 0 = 0. Firmy jen udržují zásobu β·Y na stejné úrovni.
