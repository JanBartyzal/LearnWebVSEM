---
kind: topic
subject: mereni-firemni-vykonnosti
slug: alternativni-modely
name: "Alternativní modely"
order: 5
---

Využití elementárních nástrojů finanční analýzy v alternativních modelech v paralelní soustavě ukazatelů, Quick testu, v Beaverově jednorozměrné diskriminační analýze, v predikčních modelech, konstrukce a vypovídací schopnost Altmanová bankrotního modelu, Tamariho rizikového indexu, Beermanově diskriminační funkci a v bonitních modelech.

## Paralelní soustava ukazatelů {#paralelni-soustava .explain}

**Paralelní soustava** je skupina **rovnocenných ukazatelů** postavených vedle sebe, z nichž každý vypovídá o jiné stránce finančního zdraví (stabilita, likvidita, rentabilita, aktivita). Na rozdíl od pyramidové soustavy mezi nimi **nejsou matematické vazby** — nelze z nich rozkladem odvodit vrcholový ukazatel ani kvantifikovat vliv faktorů. Ukazatele jsou **účelově vybrané**: buď expertně (Quick test), nebo statisticky z dat zdravých a zkrachovalých podniků (bankrotní modely). Výsledky se často agregují do **jednoho čísla** (bodový součet, vážený součet), které umožní rychlé zařazení podniku do třídy.

*Příklad:* Kralickův Quick test posuzuje vedle sebe kvótu vlastního kapitálu, dobu splácení dluhu, cash flow v % tržeb a ROA. Žádný z nich nevzniká součinem či součtem ostatních.

### ? Čím se paralelní soustava ukazatelů liší od pyramidové soustavy?

- [ ] Paralelní soustava rozkládá vrcholový ukazatel na součin dílčích ukazatelů
- [x] Její ukazatele jsou rovnocenné a nejsou propojeny matematickými vazbami
- [ ] Obsahuje pouze nefinanční ukazatele z oblasti zákazníků a procesů
- [ ] Umožňuje přesně kvantifikovat vliv jednotlivých faktorů na zisk

> Paralelní soustava staví vedle sebe rovnocenné, účelově vybrané ukazatele bez matematických vazeb. Rozklad vrcholového ukazatele a kvantifikace vlivu faktorů jsou vlastnosti pyramidové soustavy.

### ? Proč NELZE na paralelní soustavu ukazatelů použít analýzu odchylek metodou postupných změn?

- [ ] Paralelní soustava obsahuje vždy jen jeden ukazatel
- [ ] Ukazatele paralelní soustavy se počítají jen z peněžních toků
- [ ] Metoda postupných změn se používá jen u nefinančních ukazatelů
- [x] Mezi ukazateli neexistuje funkční vazba na vrcholový ukazatel

> Analýza odchylek vyžaduje přesnou (aditivní nebo multiplikativní) vazbu dílčích ukazatelů na vrcholový ukazatel. Paralelní soustava takovou vazbu nemá, ukazatele stojí vedle sebe.

## Predikční modely {#predikcni-modely .term}

**Predikční modely** (modely včasného varování, early warning) jsou účelově sestavené soustavy ukazatelů, které podle hodnot z účetních výkazů **předpovídají budoucí finanční situaci podniku** — zda mu hrozí finanční tíseň a bankrot, nebo jak je bonitní. Vznikly převážně **statistickým zpracováním** dat skupin zdravých a zkrachovalých podniků (diskriminační analýza) a výsledek shrnují do jednoho čísla s pásmy pro interpretaci.

### ? Co je hlavním účelem predikčních modelů finanční analýzy?

- [ ] Rozložit rentabilitu vlastního kapitálu na dílčí faktory
- [ ] Sestavit finanční plán podniku na příští účetní období
- [x] Včas signalizovat hrozbu bankrotu nebo posoudit bonitu
- [ ] Stanovit tržní hodnotu akcie na základě diskontovaných dividend

> Predikční modely jsou modely včasného varování: z účetních dat odhadují, zda podniku hrozí bankrot, případně jak je finančně zdravý. Rozklad ROE je úloha pyramidové soustavy.

## Bankrotní × bonitní modely {#bankrotni-vs-bonitni .compare}

Predikční modely se dělí podle otázky, na kterou odpovídají:

| | Bankrotní modely | Bonitní modely |
|---|---|---|
| Otázka | Hrozí podniku v blízké budoucnosti bankrot? | Jak kvalitní (bonitní) je podnik ve srovnání s jinými? |
| Typický uživatel | věřitel (banka, dodavatel) | vlastník, investor, management |
| Konstrukce | vážený součet ukazatelů z diskriminační analýzy dat zdravých a zkrachovalých firem | expertní bodové hodnocení ukazatelů a zařazení do třídy bonity (Quick test, Tamari); IN99 je naopak vážený součet ukazatelů odvozený statisticky |
| Výstup | skóre a pásmo (zdravý / šedá zóna / ohrožený) | body, známka, pořadí podniku |
| Příklady | Altmanovo Z-skóre, Tafflerův model, Beermanova funkce, IN95 | Kralickův Quick test, Tamariho model, IN99 |

Index **IN05** (stejně jako IN01) oba pohledy kombinuje.

### ? Banka zvažuje poskytnutí úvěru a chce rychle zjistit, zda dlužníkovi hrozí v nejbližších letech bankrot. Který typ modelu odpovídá této otázce nejpříměji?

- [x] Bankrotní model, například Altmanovo Z-skóre
- [ ] Bonitní model, například vlastnický index IN99
- [ ] Pyramidový rozklad ROE podle Du Ponta
- [ ] Model ekonomické přidané hodnoty EVA

> Bankrotní modely jsou konstruovány z pohledu věřitele a odpovídají na otázku hrozícího bankrotu. IN99 je vlastnický (bonitní) index, Du Pont a EVA predikci bankrotu neslouží.

### ? Který model se řadí k bonitním modelům?

- [ ] Altmanovo Z-skóre
- [ ] Tafflerův model
- [x] Tamariho model
- [ ] Beermanova diskriminační funkce

> Tamariho model bodově hodnotí kvalitu podniku, a patří proto k bonitním modelům. Altmanův, Tafflerův i Beermanův model jsou bankrotní diskriminační funkce.

## Jednorozměrná × vícerozměrná diskriminační analýza {#jednorozmerna-vicerozmerna .compare}

Diskriminační analýza hledá ukazatele, které nejlépe **oddělí (diskriminují)** zdravé a zkrachovalé podniky.

| | Jednorozměrná (univariate) | Vícerozměrná (multivariate) |
|---|---|---|
| Princip | každý ukazatel se hodnotí **samostatně** a pro každý se hledá dělicí hodnota | ukazatele se kombinují do **jedné diskriminační funkce** (vážený součet) |
| Představitel | W. H. Beaver (1966) | E. I. Altman (1968), Taffler, Beermann, IN indexy |
| Výhoda | jednoduchost, snadná interpretace jednotlivých ukazatelů | jedno souhrnné skóre, zohlední vzájemné působení ukazatelů |
| Slabina | ukazatele mohou dávat **protichůdné signály**, chybí celkový verdikt | váhy platí pro vzorek, ze kterého vznikly; horší přenositelnost |

### ? Jaký je hlavní nedostatek jednorozměrné diskriminační analýzy, který vedl k vývoji vícerozměrných modelů?

- [ ] Nepracuje s účetními daty, ale jen s tržními cenami akcií podniku
- [x] Ukazatele mohou dávat protichůdné signály bez celkového verdiktu
- [ ] Vyžaduje znalost vah všech ukazatelů stanovených expertem
- [ ] Lze ji použít jen u podniků obchodovaných na burze

> Jednorozměrná analýza hodnotí každý ukazatel zvlášť, takže jeden může signalizovat zdraví a jiný tíseň. Vícerozměrná analýza (Altman) proto ukazatele spojuje do jedné vážené funkce.

## Beaverova jednorozměrná diskriminační analýza {#beaver .explain}

**W. H. Beaver** (1966) porovnal **79 zkrachovalých podniků** s 79 párovými zdravými podniky (stejné odvětví a podobná velikost) a sledoval přibližně **30 poměrových ukazatelů** až pět let před bankrotem. Každý ukazatel testoval **samostatně**: hledal dělicí hodnotu (cut-off), při které ukazatel nejméně chybně zařazuje podniky do skupiny zdravých a zkrachovalých, a porovnával průměrné profily obou skupin. **Nejlepším prediktorem** byl poměr **cash flow / celkové dluhy** (cizí zdroje); dobře vycházely i čistý zisk / aktiva a cizí zdroje / aktiva. U zkrachovalých firem se ukazatele zhoršovaly už několik let před bankrotem.

*Příklad:* podnik s cash flow 6 mil. Kč a cizími zdroji 120 mil. Kč má CF / celkové dluhy = 0,05 — z cash flow by dluhy splácel zhruba 20 let. Čím nižší poměr (a zejména záporné cash flow), tím slabší schopnost splácet; u zkrachovalých podniků Beaver zjistil, že tento poměr v letech před bankrotem klesal hluboko pod úroveň zdravých firem.

### ? Který ukazatel se v Beaverově analýze ukázal jako nejlepší prediktor bankrotu?

- [ ] Běžná likvidita (oběžná aktiva / krátkodobé závazky)
- [ ] Obrat celkových aktiv (tržby / aktiva)
- [ ] Rentabilita tržeb (čistý zisk / tržby)
- [x] Cash flow / celkové dluhy

> Beaver zjistil, že nejlépe odděluje zkrachovalé a zdravé podniky poměr cash flow k celkovým dluhům. Likvidita a obrat aktiv měly nižší vypovídací schopnost.

### ? Proč se Beaverova analýza označuje jako jednorozměrná?

- [x] Každý ukazatel posuzuje samostatně, bez spojení do jedné funkce
- [ ] Pracuje vždy jen s daty jednoho roku před bankrotem
- [ ] Hodnotí pouze jednu skupinu podniků bez kontrolního vzorku
- [ ] Používá jediný ukazatel, který vybral expert bez statistického ověření

> Jednorozměrnost znamená, že se predikční schopnost testuje u každého ukazatele zvlášť. Beaver přitom sledoval desítky ukazatelů, několik let před bankrotem a s párovým vzorkem zdravých firem.

### ? Podnik vytvořil cash flow 9 mil. Kč, jeho cizí zdroje činí 180 mil. Kč a aktiva 300 mil. Kč. Jaká je hodnota Beaverova nejlepšího prediktoru cash flow / celkové dluhy?

- [ ] 0,03
- [x] 0,05
- [ ] 0,60
- [ ] 20,00

> CF / celkové dluhy = 9 / 180 = 0,05. Hodnota 0,03 vznikne dělením aktivy (9 / 300), 20 je převrácený poměr (180 / 9) a 0,60 je podíl cizích zdrojů na aktivech.

## Kralickův Quick test — ukazatele {#quick-test-ukazatele .explain}

**Quick test** (P. Kralicek) je bonitní model, který rychle hodnotí podnik pomocí **čtyř ukazatelů** ze dvou oblastí:

- **finanční stabilita:** (1) **kvóta vlastního kapitálu** = VK / A (kapitálová síla, nezávislost na věřitelích); (2) **doba splácení dluhu z cash flow** = (cizí zdroje − peněžní prostředky) / provozní CF (za kolik let by podnik z cash flow splatil dluhy);
- **výnosová situace:** (3) **cash flow v % tržeb** = provozní CF / tržby (finanční výkonnost); (4) **ROA** = EBIT / A (rentabilita aktiv).

Každý ukazatel se oboduje podle stupnice, oblasti se zprůměrují a z nich vznikne celkové hodnocení. Model je oblíbený, protože kombinuje rozvahová data, zisk i **cash flow**.

*Příklad:* VK 60 mil. Kč, aktiva 200 mil. Kč, cizí zdroje 140 mil. Kč, peníze 20 mil. Kč, provozní CF 15 mil. Kč → kvóta VK = 30 %, doba splácení dluhu = (140 − 20) / 15 = 8 let.

### ? Podnik má cizí zdroje 150 mil. Kč, peněžní prostředky 30 mil. Kč a provozní cash flow 20 mil. Kč. Jaká je doba splácení dluhu z cash flow podle Kralickova Quick testu?

- [ ] 7,5 roku
- [ ] 9,0 roku
- [x] 6,0 roku
- [ ] 0,17 roku

> (150 − 30) / 20 = 6 let. Bez odečtení peněžních prostředků vyjde 7,5 roku, (150 + 30) / 20 = 9 let a 0,17 je převrácený poměr (20 / 120).

### ? Který ukazatel NENÍ součástí Kralickova Quick testu?

- [ ] Kvóta vlastního kapitálu
- [x] Běžná likvidita
- [ ] Cash flow v procentech tržeb
- [ ] Rentabilita aktiv (ROA)

> Quick test tvoří kvóta vlastního kapitálu, doba splácení dluhu z cash flow, cash flow v % tržeb a ROA. Běžná likvidita mezi jeho čtyři ukazatele nepatří.

### ? Které dva ukazatele Quick testu hodnotí výnosovou situaci podniku?

- [ ] Kvóta vlastního kapitálu a doba splácení dluhu z cash flow
- [ ] Kvóta vlastního kapitálu a rentabilita aktiv
- [ ] Doba splácení dluhu z cash flow a cash flow v % tržeb
- [x] Cash flow v % tržeb a rentabilita aktiv

> Výnosovou situaci popisuje cash flow v % tržeb a ROA. Kvóta vlastního kapitálu a doba splácení dluhu hodnotí finanční stabilitu.

## Kralickův Quick test — hodnocení {#quick-test-hodnoceni .explain}

Hodnoty ukazatelů se zařadí do pěti tříd:

| Ukazatel | výborný | velmi dobrý | dobrý | špatný | ohrožení insolvencí |
|---|---|---|---|---|---|
| Kvóta VK | > 30 % | > 20 % | > 10 % | > 0 % | záporná |
| Doba splácení dluhu | < 3 roky | < 5 let | < 12 let | > 12 let | > 30 let |
| CF v % tržeb | > 10 % | > 8 % | > 5 % | > 0 % | záporné |
| ROA | > 15 % | > 12 % | > 8 % | > 0 % | záporná |

Třídám se přiřadí body (stupnice se v literatuře liší, např. 0–4 nebo 1–5), spočte se průměr za **finanční stabilitu** (ukazatele 1 a 2), průměr za **výnosovou situaci** (3 a 4) a jejich průměr dá **celkové hodnocení**. Tím model vyvažuje kapitálovou sílu s výkonností.

*Příklad:* kvóta VK 25 % (velmi dobrý), doba splácení 6 let (dobrý), CF v % tržeb 6 % (dobrý), ROA 13 % (velmi dobrý) — stabilita i výnosová situace jsou mezi „velmi dobrou" a „dobrou" úrovní.

### ? Podnik má vlastní kapitál 50 mil. Kč a aktiva 200 mil. Kč. Do které třídy Quick testu patří jeho kvóta vlastního kapitálu?

- [ ] Výborný (nad 30 %)
- [x] Velmi dobrý (nad 20 %)
- [ ] Dobrý (nad 10 %)
- [ ] Špatný (nad 0 %)

> Kvóta VK = 50 / 200 = 25 %, což je nad hranicí 20 %, ale pod 30 % — třída velmi dobrý.

### ? Podnik dosáhl EBIT 26 mil. Kč při aktivech 200 mil. Kč. Jak Quick test hodnotí jeho rentabilitu aktiv?

- [x] Velmi dobrý (ROA 13 %, nad hranicí 12 %)
- [ ] Výborný (ROA 13 %, nad hranicí 10 %)
- [ ] Dobrý (ROA 13 %, nad hranicí 8 %)
- [ ] Špatný (ROA 7,7 %, pod hranicí 8 % pro dobrý)

> ROA = 26 / 200 = 13 %. Pro „výborný" je třeba více než 15 %, hranice 12 % dává třídu velmi dobrý. Hodnota 7,7 % vznikne převrácením výpočtu (200 / 26 = 7,7).

### ? Podnik má dobu splácení dluhu z cash flow 35 let. Jak tento výsledek Quick test hodnotí?

- [ ] Dobrý, protože dluh je dlouhodobý
- [ ] Špatný, ale bez rizika insolvence
- [ ] Výborný, protože podnik využívá levný cizí kapitál
- [x] Ohrožení insolvencí

> Doba splácení dluhu nad 30 let spadá do nejhorší třídy — ohrožení insolvencí. Podnik by z cash flow splácel dluhy nepřiměřeně dlouho.

## Altmanovo Z-skóre — konstrukce {#altman-konstrukce .explain}

**E. I. Altman** (1968) použil **vícerozměrnou diskriminační analýzu** na vzorek **66 průmyslových podniků** (33 zkrachovalých a 33 zdravých) a z 22 testovaných ukazatelů vybral pět, které spojil do jedné funkce:

`Z = 1,2·X₁ + 1,4·X₂ + 3,3·X₃ + 0,6·X₄ + 1,0·X₅`

- **X₁ = ČPK / A** — likvidita (podíl čistého pracovního kapitálu na aktivech),
- **X₂ = nerozdělený zisk / A** — kumulovaná ziskovost a „stáří" podniku, samofinancování,
- **X₃ = EBIT / A** — produkční síla aktiv (nejvyšší váha),
- **X₄ = tržní hodnota VK / cizí zdroje** — o kolik může klesnout hodnota firmy, než dluhy převýší majetek,
- **X₅ = T / A** — obrat aktiv, schopnost aktiv vytvářet tržby.

Model je určen pro **akciové společnosti obchodované na burze** (X₄ vyžaduje tržní hodnotu akcií).

*Příklad:* EBIT / A = 0,10 přispívá do Z-skóre 3,3 · 0,10 = 0,33.

### ? Který ukazatel má v původním Altmanově Z-skóre nejvyšší váhu (koeficient)?

- [ ] Nerozdělený zisk / aktiva
- [ ] Tržby / aktiva
- [ ] Čistý pracovní kapitál / aktiva
- [x] EBIT / aktiva

> EBIT / A má koeficient 3,3, nerozdělený zisk / A 1,4, ČPK / A 1,2, tržní hodnota VK / cizí zdroje 0,6 a tržby / A 1,0. Model tak nejvíce zdůrazňuje produkční sílu aktiv.

### ? Proč je původní Altmanovo Z-skóre určeno pro akciové společnosti obchodované na burze?

- [x] Ukazatel X₄ pracuje s tržní hodnotou vlastního kapitálu
- [ ] Ukazatel X₁ vyžaduje údaje o dividendách na akcii
- [ ] Neobchodované firmy nesestavují rozvahu ani výsledovku
- [ ] Ukazatel X₅ se počítá z burzovního obratu akcií

> X₄ = tržní hodnota VK / cizí zdroje, a tržní hodnotu akcií lze spolehlivě zjistit jen u obchodovaných společností. Pro ostatní firmy vznikla upravená varianta Z′ s účetní hodnotou VK.

### ? Ukazatel X₂ v Altmanově modelu (nerozdělený zisk / aktiva) zachycuje především:

- [ ] okamžitou likviditu podniku
- [ ] rychlost obratu pohledávek
- [x] kumulovanou ziskovost a míru samofinancování podniku
- [ ] podíl tržní hodnoty akcií na celkových dluzích podniku

> Nerozdělený zisk je zisk zadržený v podniku za dobu jeho existence; vyjadřuje kumulovanou ziskovost a samofinancování. Mladé podniky mají tento ukazatel zpravidla nízký.

## Altmanovo Z-skóre — výpočet a interpretace {#altman-vypocet .explain}

Výsledné Z se porovná se dvěma hranicemi:

- **Z > 2,99** — finančně zdravý podnik, bankrot nehrozí,
- **1,81 ≤ Z ≤ 2,99** — **šedá zóna**, výsledek nelze jednoznačně hodnotit,
- **Z < 1,81** — vážné finanční problémy, vysoké riziko bankrotu.

Ukazatele X₁ až X₅ se dosazují jako **desetinná čísla** (ne v procentech). Při interpretaci je vhodné sledovat i **příspěvky** jednotlivých složek a vývoj Z v čase.

*Příklad:* A = 100, ČPK = 20, nerozdělený zisk = 15, EBIT = 10, tržní hodnota VK = 60, cizí zdroje = 50, T = 120 (mil. Kč). X₁ = 0,2; X₂ = 0,15; X₃ = 0,1; X₄ = 1,2; X₅ = 1,2. Z = 0,24 + 0,21 + 0,33 + 0,72 + 1,20 = **2,70** → šedá zóna.

### ? Podnik obchodovaný na burze má aktiva 200, čistý pracovní kapitál 30, nerozdělený zisk 40, EBIT 30, tržní hodnotu vlastního kapitálu 150, cizí zdroje 100 a tržby 300 (mil. Kč). Jaké je jeho Altmanovo Z-skóre a jak jej interpretujete?

- [ ] 2,46 — šedá zóna
- [ ] 1,86 — šedá zóna, blízko pásma ohrožení
- [ ] 2,96 — šedá zóna
- [x] 3,36 — finančně zdravý podnik

> X₁ = 0,15 → 0,18; X₂ = 0,2 → 0,28; X₃ = 0,15 → 0,495; X₄ = 1,5 → 0,9; X₅ = 1,5 → 1,5. Z = 0,18 + 0,28 + 0,495 + 0,9 + 1,5 ≈ 3,36 > 2,99. Hodnota 2,46 vznikne vynecháním X₄, 1,86 vynecháním X₅.

### ? Altmanovo Z-skóre podniku vyšlo 2,4. Co tento výsledek znamená?

- [x] Podnik je v šedé zóně a jeho situaci nelze jednoznačně určit
- [ ] Podnik je finančně zdravý a bankrot mu nehrozí
- [ ] Podnik má vážné finanční problémy a hrozí mu v krátké době bankrot
- [ ] Podnik tvoří hodnotu pro vlastníky nad náklady kapitálu

> Hodnota 2,4 leží mezi hranicemi 1,81 a 2,99, tedy v šedé zóně. Tvorbu hodnoty pro vlastníky Altmanův model neměří — to je otázka vlastnických indexů (IN99) nebo EVA.

### ? Podnik má EBIT 8 mil. Kč a aktiva 100 mil. Kč. Kolik přispívá ukazatel X₃ do jeho Altmanova Z-skóre?

- [ ] 0,08
- [ ] 0,112
- [x] 0,264
- [ ] 26,4

> X₃ = 8 / 100 = 0,08; příspěvek = 3,3 · 0,08 = 0,264. Hodnota 0,112 vznikne záměnou koeficientu za 1,4, hodnota 26,4 dosazením ukazatele v procentech (3,3 · 8).

## Varianty Z-skóre pro neobchodované a nevýrobní podniky {#altman-varianty .explain}

Protože původní model vyžaduje tržní hodnotu akcií, Altman později model **přepočítal**:

- **Z′ (1983) pro podniky neobchodované na burze:** `Z′ = 0,717·X₁ + 0,847·X₂ + 3,107·X₃ + 0,420·X₄ + 0,998·X₅`, kde X₄ = **účetní hodnota VK / cizí zdroje**; hranice **1,23** a **2,90** (Z′ < 1,23 ohrožený, 1,23–2,90 šedá zóna, > 2,90 zdravý).
- **Z″ pro nevýrobní podniky** (a rozvíjející se trhy) vynechává obrat aktiv X₅, protože ten se mezi odvětvími výrazně liší: `Z″ = 6,56·X₁ + 3,26·X₂ + 6,72·X₃ + 1,05·X₄`; hranice 1,1 a 2,6 (platí pro verzi bez konstanty; varianta pro rozvíjející se trhy přičítá konstantu 3,25 a má jiná pásma).

Nové koeficienty nejsou jen „přeznačením" — vznikly novým odhadem diskriminační funkce, proto se **hranice jednotlivých variant nesmí zaměňovat**.

*Příklad:* česká s. r. o. bez akcií na burze se hodnotí variantou Z′ s účetním vlastním kapitálem; Z′ = 2,5 je šedá zóna (mezi 1,23 a 2,90).

### ? Jak se v Altmanově variantě Z′ pro podniky neobchodované na burze změnil ukazatel X₄?

- [ ] Byl zcela vypuštěn a nahrazen ukazatelem tržby / aktiva
- [ ] Tržní hodnota VK je nahrazena nominální hodnotou akcií
- [ ] Místo cizích zdrojů se ve jmenovateli použijí celková aktiva
- [x] Tržní hodnota VK je nahrazena účetní hodnotou VK

> V Z′ je X₄ = účetní hodnota VK / cizí zdroje, protože tržní hodnota u neobchodovaných firem neexistuje. Zároveň se změnily koeficienty i hranice pásem (1,23 a 2,90).

### ? Proč varianta Z″ pro nevýrobní podniky vynechává ukazatel tržby / aktiva?

- [x] Obrat aktiv se mezi odvětvími výrazně liší a zkresloval by výsledek
- [ ] Nevýrobní podniky obvykle nevykazují tržby za vlastní výrobky a služby
- [ ] Ukazatel tržby / aktiva vyžaduje tržní hodnotu aktiv
- [ ] Obrat aktiv je již obsažen v ukazateli EBIT / aktiva

> Obchodní a servisní firmy mají obrat aktiv zcela jiný než průmyslové podniky, takže by tento ukazatel skóre systematicky zkresloval. Z″ proto pracuje jen se čtyřmi ukazateli.

## Vypovídací schopnost Altmanova modelu {#altman-vypovidaci .explain}

Na původním vzorku Altmanův model správně zařadil zhruba **95 % podniků jeden rok před bankrotem**, se vzdáleností od bankrotu ale přesnost **výrazně klesá** (dva roky předem přibližně 72 %). Model je silný v tom, že spojuje likviditu, ziskovost, zadluženost a aktivitu do jednoho čísla, je jednoduchý a široce ověřený. Omezení: vznikl na **amerických průmyslových podnicích** 50. a 60. let, koeficienty proto nemusí sedět na jiné země, odvětví a dobu; je citlivý na kvalitu účetních dat a kreativní účetnictví; **šedá zóna** neposkytuje jasný verdikt a model neříká, **proč** je podnik ohrožen.

*Příklad:* česká obchodní firma s vysokým obratem aktiv může mít Z > 2,99 díky složce X₅, přestože je ztrátová — vysoké skóre proto nenahradí rozbor jednotlivých složek.

### ? Které tvrzení o vypovídací schopnosti Altmanova Z-skóre je správné?

- [ ] Přesnost predikce s rostoucím časovým odstupem od bankrotu naopak roste
- [x] Přesnost je nejvyšší krátce před bankrotem a s delším horizontem klesá
- [ ] Model je stejně přesný pro všechna odvětví a země
- [ ] Model přesně určuje datum, kdy podnik zbankrotuje

> Altmanův model nejlépe klasifikoval podniky rok před bankrotem (přibližně 95 % na původním vzorku), dva a více let předem byla přesnost výrazně nižší. Přenositelnost na jiná odvětví a země je omezená.

### ? Obchodní podnik se ztrátou dosáhl Altmanova Z-skóre 3,2, přičemž složka 1,0·X₅ (tržby / aktiva) činí 2,8. Jaký závěr je nejrozumnější?

- [ ] Podnik je finančně zdravý, protože Z převyšuje 2,99
- [ ] Výsledek je chybný, protože Z-skóre nemůže přesáhnout 3
- [x] Vysoké skóre je tažené obratem aktiv; je třeba posoudit jednotlivé složky
- [ ] Podnik je v šedé zóně, protože je ztrátový

> Skóre je téměř celé tvořeno obratem aktiv, který je u obchodních firem přirozeně vysoký; ostatní složky (včetně ziskovosti) jsou slabé. Proto je vhodné rozebrat složky, případně použít variantu Z″ bez X₅.

## Tamariho rizikový index {#tamari .explain}

**Tamariho model** (rizikový index, M. Tamari) je **bodový** model: podnik se hodnotí podle **šesti ukazatelů** z oblastí **finanční nezávislosti** (v literatuře uváděná jako vlastní kapitál / aktiva, v některých pramenech jako vlastní kapitál / cizí zdroje), **rentability** (zisk / aktiva), **likvidity** (běžná likvidita) a **aktivity** (obrat zásob, obrat pohledávek, obrat pracovního kapitálu). Za každý ukazatel podnik získá body podle toho, **jak si stojí v rozdělení hodnot ostatních podniků odvětví** (např. podle kvartilů), takže hodnocení je relativní vůči odvětví. Body se sečtou do indexu s maximem **100 bodů**; **čím více bodů, tím nižší riziko** a vyšší bonita. Model se proto řadí k bonitním modelům, přestože jeho výsledek se interpretuje jako míra rizika.

*Příklad:* podnik, jehož finanční nezávislost i rentabilita patří do horního kvartilu odvětví, získá za tyto ukazatele vysoký počet bodů, i když jeho absolutní hodnoty nejsou výjimečné.

### ? Jak Tamariho model přiděluje body za jednotlivé ukazatele?

- [ ] Podle toho, zda ukazatel překročí pevnou hranici platnou pro všechna odvětví
- [x] Podle postavení hodnoty ukazatele v rozdělení hodnot podniků odvětví
- [ ] Násobením ukazatele koeficientem z diskriminační funkce
- [ ] Podle odborného odhadu analytika bez vazby na data

> Tamariho model hodnotí ukazatele relativně — podle toho, do kterého pásma (např. kvartilu) odvětvových hodnot podnik spadá. Násobení koeficienty je princip diskriminačních funkcí (Altman).

### ? Podnik získal v Tamariho modelu vysoký počet bodů blízko maxima 100. Jak výsledek interpretujete?

- [x] Podnik má nízké riziko a vysokou bonitu ve srovnání s odvětvím
- [ ] Podnik má vysoké riziko finanční tísně
- [ ] Podnik je v šedé zóně a výsledek nelze interpretovat
- [ ] Podnik tvoří ekonomický zisk ve výši počtu bodů

> V Tamariho modelu platí, že čím více bodů, tím nižší riziko a lepší postavení podniku vůči odvětví. Ekonomický zisk model nevyjadřuje.

## Beermanova diskriminační funkce {#beerman .term}

**Beermanova diskriminační funkce** je německý **bankrotní model** postavený stejně jako Altmanův na **vícerozměrné diskriminační analýze**: z účetních dat zdravých a zkrachovalých podniků odvozuje **vážený součet několika poměrových ukazatelů** a výsledné skóre porovnává s kritickou hodnotou, která odděluje podniky ohrožené a zdravé. Protože vznikla na datech německých podniků, je její přenositelnost na jiné prostředí omezená stejně jako u ostatních diskriminačních funkcí.

### ? Na jakém metodickém principu je založena Beermanova diskriminační funkce?

- [ ] Na bodovém hodnocení ukazatelů podle kvartilů odvětví
- [ ] Na samostatném testování každého ukazatele zvlášť
- [x] Na vícerozměrné diskriminační analýze, tj. váženém součtu ukazatelů
- [ ] Na pyramidovém rozkladu rentability vlastního kapitálu

> Beermanova funkce je stejně jako Altmanovo Z-skóre výsledkem vícerozměrné diskriminační analýzy: vážený součet ukazatelů se porovná s kritickou hodnotou. Bodování podle kvartilů je princip Tamariho modelu, samostatné testování ukazatelů Beaverova.

## Indexy IN manželů Neumaierových {#in-indexy .explain}

Inka a Ivan **Neumaierovi** vytvořili predikční modely pro **české podniky**, protože zahraniční modely na české prostředí dobře nesedí:

- **IN95** — **věřitelský** (bankrotní) index: hrozí podniku bankrot? (vzniklo i odvětvové nastavení vah),
- **IN99** — **vlastnický** (bonitní) index: tvoří podnik hodnotu pro vlastníky? (odvozen ve vazbě na ekonomický zisk / EVA),
- **IN01** — **kombinovaný** index spojující oba pohledy,
- **IN05** — aktualizace IN01 na novějších datech; hranice **0,9** a **1,6**.

Všechny indexy jsou vážené součty poměrových ukazatelů (struktura podobná Altmanovi) a pracují jen s **účetními daty**, takže je lze použít i u podniků neobchodovaných na burze.

*Příklad:* banka posuzující úvěr sleduje hlavně věřitelský pohled (IN95), majitel firmy zvažující další investici spíš vlastnický pohled (IN99); IN05 dává obojí jedním číslem.

### ? Který z indexů manželů Neumaierových je čistě vlastnický, tj. hodnotí, zda podnik tvoří hodnotu pro vlastníky?

- [ ] IN95
- [x] IN99
- [ ] IN01
- [ ] IN05 (aktualizace z roku 2005)

> IN99 je vlastnický (bonitní) index odvozený ve vazbě na ekonomický zisk. IN95 je věřitelský, IN01 a IN05 kombinují pohled věřitele i vlastníka.

### ? Proč jsou indexy IN vhodnější pro české podniky než původní Altmanovo Z-skóre?

- [x] Byly odvozeny z dat českých podniků a nevyžadují tržní hodnotu akcií
- [ ] Neobsahují žádné ukazatele rentability ani zadluženosti
- [ ] Vycházejí výhradně z peněžních toků, a nejsou proto ovlivněny účetnictvím
- [ ] Jsou to pyramidové soustavy s přesnými matematickými vazbami

> Neumaierovi kalibrovali indexy na českých datech a používají jen účetní údaje. Původní Z-skóre vzniklo na amerických burzovně obchodovaných firmách a X₄ vyžaduje tržní hodnotu VK.

## Index IN05 — výpočet {#in05-vypocet .explain}

`IN05 = 0,13·A/CZ + 0,04·EBIT/U + 3,97·EBIT/A + 0,21·V/A + 0,09·OA/(KZ + KBÚ)`

kde A = aktiva, CZ = cizí zdroje, U = nákladové úroky, V = výnosy, OA = oběžná aktiva, KZ = krátkodobé závazky, KBÚ = krátkodobé bankovní úvěry. Ukazatele vyjadřují postupně **finanční páku**, **úrokové krytí**, **rentabilitu aktiv**, **obrat aktiv (z výnosů)** a **likviditu**; největší váhu má rentabilita aktiv. Při velmi nízkých nebo nulových úrocích by úrokové krytí výsledek přehnaně zvýšilo, proto se v literatuře doporučuje jeho hodnotu omezit (obvykle na 9). Interpretace: **IN05 > 1,6** podnik tvoří hodnotu; **0,9–1,6** šedá zóna; **IN05 < 0,9** podnik je ohrožen bankrotem.

*Příklad:* A = 100, CZ = 50, EBIT = 12, U = 3, V = 150, OA = 40, KZ + KBÚ = 25 (mil. Kč). IN05 = 0,13·2 + 0,04·4 + 3,97·0,12 + 0,21·1,5 + 0,09·1,6 = 0,26 + 0,16 + 0,476 + 0,315 + 0,144 ≈ **1,36** → šedá zóna.

### ? Podnik má aktiva 100, cizí zdroje 50, EBIT 12, nákladové úroky 3, výnosy 150, oběžná aktiva 40 a krátkodobé závazky včetně krátkodobých bankovních úvěrů 25 (mil. Kč). Jaký je index IN05 a jak jej interpretujete?

- [ ] 0,88 — podnik je ohrožen bankrotem
- [x] 1,36 — šedá zóna
- [ ] 1,67 — podnik tvoří hodnotu
- [ ] 1,04 — šedá zóna

> 0,13·(100/50) + 0,04·(12/3) + 3,97·(12/100) + 0,21·(150/100) + 0,09·(40/25) = 0,26 + 0,16 + 0,476 + 0,315 + 0,144 ≈ 1,36, tedy mezi 0,9 a 1,6. Vynecháním výnosové složky vyjde 1,04, vynecháním rentability aktiv 0,88.

### ? Který ukazatel má v indexu IN05 nejvyšší váhu (koeficient)?

- [ ] Aktiva / cizí zdroje
- [ ] EBIT / nákladové úroky
- [ ] Výnosy / aktiva
- [x] EBIT / aktiva

> Rentabilita aktiv EBIT / A má koeficient 3,97; ostatní koeficienty jsou 0,13, 0,04, 0,21 a 0,09. Index tak stejně jako Altmanův model nejvíce zdůrazňuje výdělečnou schopnost aktiv.

## Výhody a omezení predikčních modelů {#omezeni-modelu .explain}

**Výhody:** jednoduchost a rychlost, souhrnný verdikt jedním číslem, použitelnost pro externího analytika jen z účetních výkazů, statistické podložení (diskriminační modely), možnost sledovat vývoj v čase.

**Omezení:** modely platí pro **vzorek, zemi, odvětví a období**, ze kterého vznikly; jsou citlivé na **kvalitu a manipulaci účetních dat**; **šedá zóna** nedává jasný výsledek; jsou **statické** a neříkají, **proč** je podnik ohrožen; různé modely mohou dát pro stejný podnik **rozdílný závěr**. Při klasifikaci vznikají dvě chyby: **chyba I. druhu** — zkrachovalý (ohrožený) podnik je zařazen mezi zdravé (pro věřitele nejdražší), a **chyba II. druhu** — zdravý podnik je označen za ohrožený (ztráta obchodní příležitosti). Predikční modely proto slouží jako **rychlý filtr**, ne náhrada podrobné finanční analýzy.

*Příklad:* Altmanův model vyjde 3,1 (zdravý), IN05 0,8 (ohrožen) — analytik musí rozebrat složky a příčiny rozporu, např. vysoký obrat aktiv při nízké ziskovosti.

### ? Banka použila bankrotní model a podnik, který o rok později zbankrotoval, model označil za zdravý. O jakou chybu jde?

- [ ] Chybu II. druhu — zdravý podnik označen za ohrožený
- [ ] Chybu měření — špatně spočtená rentabilita aktiv
- [ ] Chybu agregace — chybějící pyramidová vazba ukazatelů
- [x] Chybu I. druhu — ohrožený podnik zařazen mezi zdravé

> Zařazení podniku, který zkrachuje, mezi zdravé je chyba I. druhu a pro věřitele je nejnákladnější. Chyba II. druhu je opačná — zdravý podnik je chybně označen za ohrožený.

### ? Které tvrzení o predikčních modelech je NESPRÁVNÉ?

- [ ] Koeficienty platí především pro zemi, odvětví a období, ze kterých model vznikl
- [x] Model přesně vysvětluje příčiny finančních potíží podniku
- [ ] Výsledky jsou ovlivněny kvalitou a případnou manipulací účetních dat
- [ ] Různé modely mohou pro stejný podnik dát odlišný závěr

> Predikční modely dávají souhrnné skóre, ale neříkají, proč je podnik ohrožen — příčiny musí odhalit podrobná finanční analýza. Ostatní tvrzení popisují skutečná omezení modelů.
