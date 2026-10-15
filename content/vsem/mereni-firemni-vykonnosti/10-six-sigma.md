---
kind: topic
subject: mereni-firemni-vykonnosti
slug: six-sigma
name: "Six Sigma"
order: 10
---

Metodologie konstrukce modelu, jeho podstata, cíl a možnosti při aplikaci v řízení firmy, sekvence jednotlivých kroků Definice-Měření-Analýza-Zlepšování-Řízení, strategie zvyšování výkonnosti jednotlivých procesů s cílem permanentního zvyšování výkonnosti, maximalizace hodnoty a zabezpečení permanentní konkurenční výhody na trhu.

## Podstata a cíl Six Sigma {#podstata .explain}

**Six Sigma** je disciplinovaná, daty řízená metodologie zlepšování procesů, jejímž cílem je **snížit variabilitu procesu** a tím počet vad, které zákazník vnímá jako nekvalitu. Vznikla v 80. letech ve firmě **Motorola** (Bill Smith, 1986), proslavila ji **General Electric** pod vedením Jacka Welche (od roku 1995). Název vychází ze směrodatné odchylky σ: proces „na úrovni šesti sigma" produkuje nejvýše **3,4 vady na milion příležitostí** (DPMO). Klíčové rysy: orientace na požadavky zákazníka (CTQ), rozhodování na základě dat a statistiky, realizace formou projektů s vyčísleným finančním přínosem, vyškolené role (Belts) a podpora vrcholového vedení.

*Příklad:* Banka zjistí, že doba schválení úvěru kolísá od 2 do 15 dnů. Six Sigma projekt neřeší jen průměrnou dobu, ale hlavně rozptyl — zákazník vnímá jako vadu každé schválení delší než slíbených 5 dní.

### ? Ve které firmě metodologie Six Sigma vznikla?

- [ ] Toyota Motor Corporation v rámci výrobního systému TPS
- [x] Motorola v 80. letech 20. století
- [ ] General Electric v polovině 90. let 20. století
- [ ] Ford Motor Company při zavádění pásové výroby

> Six Sigma vznikla ve společnosti Motorola (Bill Smith, 1986). General Electric ji od roku 1995 masově rozšířila, Toyota je spojena s Lean (TPS).

### ? Co je hlavním předmětem zlepšování v metodologii Six Sigma?

- [ ] Zvýšení objemu výroby bez ohledu na kvalitu výstupu
- [ ] Rozšíření tolerancí, aby méně výrobků bylo vadných
- [ ] Nahrazení statistických metod zkušeností manažerů
- [x] Snížení variability procesu a tím i počtu vad

> Six Sigma usiluje o snížení rozptylu (variability) procesu tak, aby se výstupy co nejméně odchylovaly od požadavku zákazníka. Tolerance stanovuje zákazník, metodologie je naopak silně statistická.

## Variabilita procesu a sigma úroveň {#sigma-uroven .explain}

Každý proces kolísá; míra kolísání se měří **směrodatnou odchylkou σ**. Zákazník definuje přijatelný rozsah výstupu **specifikačními mezemi** — dolní (LSL, lower specification limit) a horní (USL, upper specification limit). **Sigma úroveň** (Z) říká, kolik směrodatných odchylek se vejde mezi střed procesu µ a nejbližší specifikační mez: `Z = min((USL − µ)/σ; (µ − LSL)/σ)`. Čím vyšší Z, tím menší pravděpodobnost, že výstup překročí mez, tj. tím méně vad. Sigma úroveň lze zvýšit **snížením σ** nebo **vycentrováním procesu** (posunem µ do středu tolerance).

*Příklad:* Horní mez doby vyřízení reklamace je 30 minut, průměr 18 minut a σ = 3 minuty → Z = (30 − 18)/3 = 4, proces je na úrovni 4σ (měřeno k horní mezi).

### ? Proces má průměr µ = 50, směrodatnou odchylku σ = 2, dolní specifikační mez LSL = 44 a horní USL = 60. Jaká je jeho sigma úroveň Z (vzdálenost k nejbližší mezi v násobcích σ)?

- [x] 3
- [ ] 5
- [ ] 4
- [ ] 8

> K dolní mezi: (50 − 44)/2 = 3; k horní: (60 − 50)/2 = 5. Rozhoduje nejbližší mez, tedy Z = 3. Hodnota 8 = (60 − 44)/2 je šířka celé tolerance v σ, 4 je chybný průměr obou vzdáleností.

### ? Kterým opatřením lze zvýšit sigma úroveň procesu, aniž by se měnily požadavky zákazníka?

- [ ] Rozšířením specifikačních mezí podle skutečných výsledků procesu
- [ ] Zvýšením počtu kontrolorů na konci výrobní linky
- [x] Snížením směrodatné odchylky nebo vycentrováním procesu
- [ ] Posunutím průměru procesu těsně k horní specifikační mezi

> Z roste, když se zmenší σ nebo když se průměr posune do středu tolerance. Specifikační meze určuje zákazník, výstupní kontrola vady jen odhalí, neodstraní jejich vznik.

## Vada, příležitost k vadě a DPMO {#dpmo .explain}

**Jednotka** je výstup procesu (výrobek, faktura, objednávka), **vada** (defect) každé nesplnění požadavku zákazníka a **příležitost k vadě** (opportunity) každé místo, kde může vada vzniknout (např. pole faktury). Základní ukazatele:
- `DPU = vady / jednotky` (vady na jednotku),
- `DPO = vady / (jednotky · příležitosti)` (vady na příležitost),
- `DPMO = vady / (jednotky · příležitosti) · 10⁶` (vady na milion příležitostí).

Přepočet na příležitosti umožňuje **srovnávat procesy různé složitosti** (jednoduchý formulář × složitá smlouva) a převést výsledek na sigma úroveň.

*Příklad:* Účtárna zkontrolovala 500 faktur, každá má 8 kontrolovaných polí, nalezla 20 vad. DPU = 20/500 = 0,04; DPO = 20/(500 · 8) = 0,005; DPMO = 0,005 · 10⁶ = 5 000, což odpovídá zhruba 4,1σ.

### ? Firma zpracovala 1 200 objednávek, u každé sleduje 4 příležitosti k vadě a celkem našla 36 vad. Jaké je DPMO?

- [ ] 30 000
- [x] 7 500
- [ ] 750
- [ ] 1 875

> DPMO = 36/(1 200 · 4) · 10⁶ = 36/4 800 · 10⁶ = 7 500. Hodnota 30 000 vznikne při opomenutí příležitostí (36/1 200 · 10⁶), 1 875 při dvojím dělení počtem příležitostí.

### ? Pojišťovna zkontrolovala 250 smluv, u každé 10 polí (příležitostí k vadě), a našla 20 vad. Jaké jsou DPO a DPMO?

- [ ] DPO = 0,08; DPMO = 80 000
- [ ] DPO = 0,008; DPMO = 800
- [ ] DPO = 0,0008; DPMO = 800
- [x] DPO = 0,008; DPMO = 8 000

> DPO = 20/(250 · 10) = 20/2 500 = 0,008; DPMO = 0,008 · 10⁶ = 8 000. Hodnota 0,08 je DPU (20/250) — vady na jednotku, nikoli na příležitost.

### ? Proč Six Sigma vyjadřuje chybovost na milion příležitostí (DPMO), a ne jen podílem vadných jednotek?

- [x] Aby šlo srovnávat procesy různé složitosti a převést je na sigma úroveň
- [ ] Protože počet vadných jednotek nelze v běžném procesu nikdy spolehlivě zjistit ani odhadnout
- [ ] Protože DPMO vždy vychází nižší, a proces proto působí kvalitněji
- [ ] Aby se do výpočtu nemusely zahrnovat vady zjištěné až zákazníkem

> Složitější výstup má více míst, kde může vzniknout vada; přepočet na příležitosti chybovost normalizuje a umožní srovnání i přepočet na sigma úroveň. Vady zjištěné zákazníkem se samozřejmě započítávají.

## Výtěžnost procesu (FTY a RTY) {#vyteznost .explain}

**Výtěžnost** (yield) vyjadřuje podíl výstupů bez vady. **Výtěžnost prvního průchodu** (FTY, first time yield) jednoho kroku = jednotky bez vady napoprvé / vstupní jednotky — přepracované kusy se nepočítají jako dobré. **Průběžná (kumulovaná) výtěžnost** (RTY, rolled throughput yield) celého procesu je **součin FTY jednotlivých kroků** a udává pravděpodobnost, že jednotka projde všemi kroky bez vady. Klasická výtěžnost, která počítá i opravené kusy, skrývá tzv. **skrytou továrnu** (hidden factory) — kapacitu a náklady spotřebované na opravy. Na úrovni příležitostí platí výtěžnost = 1 − DPO.

*Příklad:* Proces má tři kroky s FTY 95 %, 90 % a 98 %. RTY = 0,95 · 0,90 · 0,98 = 0,8379, tj. jen asi 83,8 % jednotek projde celým procesem napoprvé bez vady.

### ? Proces má čtyři navazující kroky, každý s výtěžností prvního průchodu 97 %. Jaká je průběžná výtěžnost (RTY) celého procesu?

- [ ] 97,0 %
- [ ] 88,0 %
- [x] 88,5 %
- [ ] 91,3 %

> RTY = 0,97⁴ = 0,9409 · 0,9409 ≈ 0,885, tj. 88,5 %. Hodnota 88,0 % vznikne prostým odečtením 4 · 3 %, 91,3 % je součin jen tří kroků, 97 % je průměr kroků.

### ? Do kroku vstoupilo 400 jednotek; 368 prošlo napoprvé bez vady, 20 bylo vadných a po opravě použito, 12 skončilo jako zmetek. Jaká je výtěžnost prvního průchodu (FTY)?

- [ ] 97 %
- [x] 92 %
- [ ] 95 %
- [ ] 3 %

> FTY = 368/400 = 0,92 = 92 %. Hodnota 97 % = (368 + 20)/400 počítá i opravené kusy, a tím skrývá „skrytou továrnu"; 3 % je podíl zmetků.

## Sigma úroveň, DPMO a výtěžnost {#tabulka-sigma .compare}

Převod sigma úrovně na DPMO a výtěžnost (s konvenčním posunem průměru o 1,5σ, jednostranně):

| Sigma úroveň | DPMO | Výtěžnost |
|---|---|---|
| 1σ | 691 462 | 30,9 % |
| 2σ | 308 538 | 69,1 % |
| 3σ | 66 807 | 93,3 % |
| 4σ | 6 210 | 99,38 % |
| 5σ | 233 | 99,977 % |
| 6σ | 3,4 | 99,99966 % |

Vztah je silně nelineární: každý další stupeň sigma snižuje počet vad o řád i více.

### ? Proces vykazuje 233 vad na milion příležitostí. Jaké sigma úrovni (s konvenčním posunem o 1,5σ) to odpovídá?

- [ ] 3σ
- [ ] 4σ
- [ ] 6σ
- [x] 5σ

> Podle převodní tabulky odpovídá 233 DPMO úrovni 5σ. Úroveň 3σ znamená 66 807 DPMO, 4σ 6 210 DPMO a 6σ jen 3,4 DPMO.

### ? Kolikrát přibližně klesne počet vad, zlepší-li se proces z úrovně 3σ (66 807 DPMO) na úroveň 4σ (6 210 DPMO)?

- [x] Zhruba 11krát
- [ ] Zhruba o třetinu
- [ ] Zhruba 2krát
- [ ] Zhruba 1 000krát

> 66 807 / 6 210 ≈ 10,8, tedy asi 11krát. Vztah sigma úrovně a vad je nelineární — zlepšení o jeden stupeň neznamená pokles „o třetinu".

### ? Manažer se chlubí, že 99 % výstupů jeho procesu je bez vady (jedna příležitost k vadě na výstup). Jak tento výsledek hodnotí Six Sigma (s posunem o 1,5σ)?

- [ ] Odpovídá úrovni 6σ, proces je prakticky bezvadný
- [x] Jde o 10 000 DPMO, tedy úroveň mezi 3σ a 4σ
- [ ] Jde o 1 000 DPMO, tedy úroveň mezi 4σ a 5σ
- [ ] Jde o 100 000 DPMO, tedy úroveň pod 3σ

> 1 % vad = 0,01 · 10⁶ = 10 000 DPMO, což leží mezi 3σ (66 807) a 4σ (6 210), přibližně 3,8σ. Výtěžnost 99 % zní dobře, ale k 6σ (99,99966 %) má daleko.

## Posun o 1,5 sigma {#posun-15-sigma .explain}

Motorola empiricky pozorovala, že střed procesu se **v dlouhodobém horizontu posouvá** (opotřebení, změny materiálu, obsluhy) zhruba o **1,5σ**. Sigma úroveň se proto uvádí jako **krátkodobá** a pro výpočet dlouhodobé chybovosti se od ní odečítá 1,5: `Z dlouhodobá = Z krátkodobá − 1,5`. Proces na úrovni 6σ je tedy dlouhodobě vzdálen od nejbližší meze jen 4,5σ, čemuž odpovídá jednostranná pravděpodobnost vady asi **3,4 · 10⁻⁶ = 3,4 DPMO**. Bez posunu by 6σ znamenalo jen asi 0,002 DPMO (oboustranně, tj. za obě meze dohromady). Posun o 1,5σ je **konvence**, nikoli přírodní zákon, a bývá kritizován.

*Příklad:* Proces s naměřenou dlouhodobou vzdáleností k mezi Z = 3,0 se podle konvence označí jako proces na úrovni 3,0 + 1,5 = 4,5σ.

### ? Proč proces na úrovni 6σ odpovídá 3,4 DPMO, a ne zhruba 0,002 DPMO, jak by plynulo z normálního rozdělení?

- [x] Počítá s dlouhodobým posunem průměru o 1,5σ, k mezi tak zbývá jen 4,5σ
- [ ] Hodnota 3,4 DPMO zahrnuje i chyby měřicího systému, které se k vadám přičítají
- [ ] Hodnota 3,4 DPMO vychází z rozdělení vad podle Paretova pravidla 80/20
- [ ] Šest sigma se počítá jako šířka celé tolerance, tedy ±3σ kolem průměru

> Konvence posunu o 1,5σ zohledňuje dlouhodobé kolísání středu procesu; jednostranná pravděpodobnost za 4,5σ je asi 3,4 na milion. Bez posunu (±6σ) by vad bylo jen asi 0,002 na milion.

### ? Dlouhodobá data procesu ukazují vzdálenost průměru k nejbližší specifikační mezi Z = 2,5. Jakou sigma úroveň proces podle konvence Six Sigma vykazuje?

- [ ] 1,0σ
- [ ] 2,5σ
- [ ] 3,75σ
- [x] 4,0σ

> Uváděná (krátkodobá) sigma úroveň = dlouhodobá + 1,5 = 2,5 + 1,5 = 4,0σ. Hodnota 1,0σ vznikne odečtením posunu místo přičtení.

## Způsobilost procesu Cp a Cpk {#cp-cpk .explain}

**Index způsobilosti** porovnává šířku tolerance s přirozeným rozptylem procesu (6σ):
- `Cp = (USL − LSL) / (6σ)` — potenciální způsobilost, nezohledňuje polohu průměru,
- `Cpk = min((USL − µ)/(3σ); (µ − LSL)/(3σ))` — skutečná způsobilost se zohledněním vycentrování.

Proces se obvykle považuje za způsobilý při Cp i Cpk ≥ 1,33. Proces na úrovni 6σ má Cp = 2 (mezi meze se vejde ±6σ) a po posunu průměru o 1,5σ Cpk = (6 − 1,5)/3 = 1,5. Je-li Cpk výrazně nižší než Cp, proces není vycentrovaný.

*Příklad:* LSL = 9,4 mm, USL = 10,6 mm, σ = 0,1 mm, µ = 10,15 mm. Cp = 1,2/0,6 = 2,0; Cpk = min(0,45/0,3; 0,75/0,3) = min(1,5; 2,5) = 1,5.

### ? Proces má LSL = 40, USL = 52, průměr µ = 47 a směrodatnou odchylku σ = 1. Jaký je index Cpk?

- [ ] 2,00
- [x] 1,67
- [ ] 2,33
- [ ] 0,83

> Cpk = min((52 − 47)/3; (47 − 40)/3) = min(1,67; 2,33) = 1,67. Hodnota 2,00 je Cp = 12/6, 2,33 je chybně zvolené maximum a 0,83 vznikne dělením 6σ místo 3σ.

### ? Proces má Cp = 1,8, ale Cpk = 0,9. Jak výsledek interpretovat?

- [ ] Proces má příliš velký rozptyl a je nutné snížit σ
- [ ] Proces je plně způsobilý, protože rozhoduje vyšší z indexů
- [x] Rozptyl procesu je malý, ale průměr leží mimo střed tolerance
- [ ] Specifikační meze jsou příliš úzké a musí se rozšířit

> Vysoké Cp ukazuje, že se rozptyl do tolerance vejde, nízké Cpk znamená, že průměr je posunut k jedné mezi. Prvním krokem je vycentrovat proces, ne snižovat σ.

## Metodologie DMAIC {#dmaic .explain}

**DMAIC** je základní pětifázový cyklus zlepšování **existujícího procesu**:
1. **Define (Definovat)** — vymezit problém, cíl, rozsah a zákazníka projektu.
2. **Measure (Měřit)** — změřit současnou výkonnost a ověřit spolehlivost dat.
3. **Analyze (Analyzovat)** — najít a daty potvrdit kořenové příčiny problému.
4. **Improve (Zlepšit)** — navrhnout, ověřit a zavést řešení odstraňující příčiny.
5. **Control (Řídit)** — udržet dosažené zlepšení a předat proces vlastníkovi.

Postup odpovídá logice cyklu PDCA, ale klade důraz na statistické ověření každého kroku. Fáze končí revizí (tollgate), kde sponzor schválí přechod dál.

*Příklad:* E-shop řeší vysoký podíl chybně vychystaných zásilek: v D stanoví cíl snížit chybovost na polovinu, v M změří výchozí DPMO, v A zjistí, že chyby vznikají u podobných kódů zboží, v I zavede skenování čárových kódů a v C sleduje chybovost regulačním diagramem.

### ? Které pořadí fází metodologie DMAIC je správné?

- [x] Definovat → Měřit → Analyzovat → Zlepšit → Řídit
- [ ] Měřit → Definovat → Analyzovat → Řídit → Zlepšit
- [ ] Definovat → Analyzovat → Měřit → Zlepšit → Řídit
- [ ] Analyzovat → Definovat → Měřit → Zlepšit → Řídit

> DMAIC = Define, Measure, Analyze, Improve, Control. Analýza příčin předpokládá data z fáze Měření, řízení (udržení) přichází až po zavedení zlepšení.

### ? Ve které fázi DMAIC se hledají a daty potvrzují kořenové příčiny problému?

- [ ] Define
- [ ] Measure
- [ ] Improve
- [x] Analyze

> Kořenové příčiny se identifikují a statisticky ověřují ve fázi Analyze. Measure stanoví výchozí výkonnost, Improve navrhuje a zavádí řešení.

## Fáze Define: projektová charta, CTQ a SIPOC {#define .explain}

Ve fázi **Define** tým vymezí projekt v **projektové chartě** (popis problému, měřitelný cíl, rozsah, tým, harmonogram, očekávaný finanční přínos). Z **hlasu zákazníka** (VOC, voice of customer) odvodí **CTQ** (critical to quality) — měřitelné charakteristiky kritické pro kvalitu, včetně cílové hodnoty a specifikačních mezí; často pomocí stromu CTQ. Proces zachytí v hrubé mapě **SIPOC** (Suppliers – Inputs – Process – Outputs – Customers), která vymezí hranice procesu a jeho účastníky.

*Příklad:* Zákazník říká „chci rychlé doručení" (VOC). CTQ: doba od objednávky do doručení nejvýše 48 hodin. SIPOC: dodavatelé zboží → skladové zásoby a objednávky → vychystání a expedice → doručená zásilka → zákazník e-shopu.

### ? Co vyjadřuje zkratka SIPOC používaná ve fázi Define?

- [ ] Strategie, investice, procesy, organizace, kontrola
- [x] Dodavatelé, vstupy, proces, výstupy, zákazníci
- [ ] Specifikace, inspekce, produkce, výstup, náklady
- [ ] Standardy, ukazatele, plánování, cíle, kapacita

> SIPOC = Suppliers, Inputs, Process, Outputs, Customers. Jde o hrubou mapu procesu, která vymezuje jeho hranice a účastníky ještě před detailním měřením.

### ? Co v Six Sigma označuje pojem CTQ (critical to quality)?

- [ ] Kontrolní bod, ve kterém se vadné výrobky vyřazují
- [ ] Celkové náklady vynaložené podnikem na zajištění a kontrolu jakosti výrobků
- [x] Měřitelnou charakteristiku, kterou zákazník považuje za klíčovou
- [ ] Kvalifikační stupeň pracovníka vedoucího projekt

> CTQ převádí obecný hlas zákazníka (VOC) na měřitelný požadavek s cílovou hodnotou a mezemi. Na CTQ se pak vztahuje měření vad i sigma úrovně.

### ? Který prvek NEPATŘÍ do projektové charty ve fázi Define?

- [ ] Popis problému a měřitelný cíl projektu
- [ ] Vymezení rozsahu a složení týmu
- [ ] Odhad očekávaného finančního přínosu
- [x] Ověřené výsledky plánovaného experimentu

> Projektová charta vzniká na začátku projektu a obsahuje problém, cíl, rozsah, tým, harmonogram a očekávaný přínos. Plánované experimenty (DOE) se provádějí až ve fázích Analyze a Improve.

## Fáze Measure {#measure .explain}

Fáze **Measure** stanoví, jak dobře proces funguje dnes. Tým sestaví **plán sběru dat** s operačními definicemi (co přesně je vada), podrobněji zmapuje proces a nejprve ověří **měřicí systém** — **analýza systému měření** (MSA, measurement system analysis), např. studie **Gage R&R** (opakovatelnost a reprodukovatelnost), ukáže, zda variabilitu nezpůsobuje samotné měření. Výstupem je **výchozí výkonnost** (baseline): DPMO, sigma úroveň, výtěžnost, případně Cp/Cpk, se kterou se později porovná efekt zlepšení.

*Příklad:* Dva kontroloři měří tutéž součást a dostávají rozdílné hodnoty. Gage R&R ukáže, že 40 % pozorované variability tvoří měření — nejprve je nutné sjednotit postup měření, jinak by analýza příčin pracovala se zkreslenými daty.

### ? Jaký je účel analýzy systému měření (MSA, např. Gage R&R) ve fázi Measure?

- [x] Ověřit, že pozorovaná variabilita nevzniká chybami samotného měření
- [ ] Spočítat finanční přínos projektu pro schválení sponzorem
- [ ] Určit, který pracovník je za vady v procesu odpovědný
- [ ] Nahradit sběr dat odhadem zkušených pracovníků procesu

> MSA posuzuje opakovatelnost a reprodukovatelnost měření. Je-li měřicí systém nespolehlivý, data i navazující analýza příčin by byly zkreslené.

### ? Co je hlavním výstupem fáze Measure?

- [ ] Seznam ověřených kořenových příčin problému
- [ ] Zavedená řešení a aktualizované pracovní postupy
- [x] Výchozí výkonnost procesu podložená spolehlivými daty
- [ ] Kontrolní plán pro dlouhodobé udržení výsledku

> Measure stanoví výchozí stav (baseline — DPMO, sigma úroveň, výtěžnost), se kterým se porovná výsledek projektu. Kořenové příčiny patří do Analyze, kontrolní plán do Control.

## Fáze Analyze: Paretův a Ishikawův diagram {#analyze .explain}

Fáze **Analyze** hledá **kořenové příčiny** problému a ověřuje je daty. Typické nástroje:
- **Paretův diagram** — sloupce kategorií vad seřazené sestupně s kumulativní čarou; podle pravidla 80/20 ukáže „životně důležitou menšinu" příčin.
- **Diagram příčin a následků** (Ishikawa, rybí kost) — strukturuje možné příčiny do skupin, např. 6M: člověk, stroj, metoda, materiál, měření, prostředí.
- **5× proč** — opakovaným ptaním se dojde od symptomu ke kořenové příčině.
- **Bodový diagram, regrese, testy hypotéz** — statisticky ověří, zda domnělá příčina skutečně ovlivňuje výsledek.

*Příklad:* Z 250 reklamací připadá 120 na poškozený obal, 80 na záměnu zboží a 50 na ostatní příčiny (v Paretově diagramu se „ostatní" dává na konec). Dvě nejčastější kategorie tvoří 200/250 = 80 % reklamací — zde má zlepšování největší efekt.

### ? Reklamace se dělí do kategorií: A 120, B 60, C 40, D 20 a E 10 případů. Jaký kumulativní podíl všech reklamací tvoří dvě nejčastější kategorie v Paretově diagramu?

- [ ] 48 %
- [x] 72 %
- [ ] 88 %
- [ ] 80 %

> Celkem 120 + 60 + 40 + 20 + 10 = 250; A + B = 180; 180/250 = 72 %. 48 % je jen kategorie A, 88 % jsou tři nejčastější kategorie (220/250).

### ? K čemu slouží Ishikawův diagram (diagram rybí kosti) ve fázi Analyze?

- [ ] K seřazení kategorií vad podle četnosti a kumulativního podílu
- [ ] K odlišení náhodné a zvláštní variability v čase
- [ ] K výpočtu sigma úrovně z naměřených dat procesu
- [x] K uspořádání možných příčin problému do logických skupin

> Ishikawův diagram strukturuje možné příčiny (např. podle 6M) jednoho následku. Řazení podle četnosti je Paretův diagram, sledování variability v čase regulační diagram.

## Fáze Improve: řešení, FMEA a poka-yoke {#improve .explain}

Ve fázi **Improve** tým navrhne řešení, která odstraňují potvrzené kořenové příčiny (brainstorming, benchmarking), vybere nejlepší a ověří je — často **plánovaným experimentem** (DOE, design of experiments) a **pilotním provozem**. Rizika nového řešení posuzuje **FMEA** (analýza možných vad a jejich důsledků): každý způsob selhání se hodnotí významem S, výskytem O a odhalitelností D na škále 1–10 a **rizikové číslo** `RPN = S · O · D` určí prioritu opatření (vysoké D = obtížně odhalitelná vada). **Poka-yoke** jsou konstrukční opatření, která chybě zabrání nebo ji okamžitě odhalí. Fáze končí zavedením řešení a ověřením zlepšení oproti výchozímu stavu.

*Příklad:* Konektor lze zapojit jen jedním způsobem díky asymetrickému tvaru (poka-yoke) — chyba „otočený konektor" tím fyzicky zmizí a RPN tohoto způsobu selhání klesne na minimum.

### ? FMEA hodnotí dva způsoby selhání: X má význam S = 9, výskyt O = 2, odhalitelnost D = 3; Y má S = 5, O = 6, D = 4. Kterému dá metoda podle rizikového čísla RPN přednost?

- [ ] X, protože rozhoduje nejvyšší význam S = 9
- [ ] X, protože nízká odhalitelnost D = 3 znamená vyšší riziko
- [x] Y, protože RPN = 120 je vyšší než 54 u X
- [ ] Y, protože součet S + O + D je 15 oproti 14

> RPN = S · O · D: X = 9 · 2 · 3 = 54, Y = 5 · 6 · 4 = 120, prioritu má Y. Nízké D znamená dobře odhalitelnou vadu, tedy nižší riziko; v praxi se ale vady s velmi vysokým S sledují i samostatně.

### ? Co označuje pojem poka-yoke?

- [x] Opatření, které chybě zabrání nebo ji ihned odhalí
- [ ] Statistický test porovnání průměrů procesu před zlepšením a po něm
- [ ] Postup pro výpočet rizikového čísla ve FMEA
- [ ] Kontrolní plán předávaný vlastníkovi procesu

> Poka-yoke (ochrana proti chybám) je jednoduché, často konstrukční opatření, které chybu fyzicky znemožní nebo ji okamžitě signalizuje, místo aby se spoléhalo na pozornost člověka.

## Fáze Control: udržení zlepšení a regulační diagramy {#control .explain}

Fáze **Control** zajišťuje, aby se proces nevrátil do původního stavu. Nástroje: **standardizace** (aktualizované pracovní postupy), **kontrolní plán** (co, jak často, kdo měří a jak reagovat), **statistická regulace procesu** (SPC) a předání procesu jeho **vlastníkovi**; projekt se uzavírá vyčíslením dosaženého přínosu. **Regulační diagram** sleduje hodnoty v čase kolem centrální linie; **regulační meze** se počítají z dat procesu, typicky jako `střední hodnota ± 3σ`. Body uvnitř mezí bez neobvyklých vzorců odpovídají **náhodné (obecné) variabilitě**, bod mimo meze signalizuje **zvláštní (vymezitelnou) příčinu**, kterou je nutné hledat. Regulační meze („hlas procesu") nejsou totéž co specifikační meze („hlas zákazníka").

*Příklad:* Průměrná doba vyřízení požadavku je 20 minut, σ = 2 minuty → regulační meze 14 a 26 minut. Hodnota 29 minut signalizuje zvláštní příčinu, např. výpadek systému.

### ? Jaký je rozdíl mezi regulačními a specifikačními mezemi?

- [ ] Jde o synonyma, obě meze stanovuje zákazník ve smlouvě
- [x] Regulační meze vycházejí z dat procesu, specifikační z požadavků zákazníka
- [ ] Regulační meze stanovuje zákazník, specifikační se počítají z dat
- [ ] Specifikační meze se používají jen ve fázi Control, regulační naopak jen ve fázi Define

> Regulační meze (obvykle ± 3σ kolem střední hodnoty) popisují přirozené chování procesu, specifikační meze vyjadřují, co zákazník akceptuje. Proces může být statisticky stabilní, a přesto nezpůsobilý.

### ? Plnicí linka má střední hmotnost balení 500 g a směrodatnou odchylku 4 g. Jaké budou horní a dolní regulační mez při obvyklém nastavení ± 3σ?

- [ ] 504 g a 496 g
- [ ] 508 g a 492 g
- [ ] 524 g a 476 g
- [x] 512 g a 488 g

> UCL = 500 + 3 · 4 = 512 g, LCL = 500 − 3 · 4 = 488 g. Ostatní možnosti odpovídají ± 1σ, ± 2σ a ± 6σ.

### ? Na regulačním diagramu se objeví bod nad horní regulační mezí. Jak má tým reagovat?

- [x] Hledat zvláštní (vymezitelnou) příčinu, která výkyv způsobila
- [ ] Ignorovat ho, protože jde o běžnou náhodnou variabilitu
- [ ] Ihned rozšířit regulační meze, aby bod ležel uvnitř
- [ ] Zrušit kontrolní plán a vrátit projekt do fáze Define

> Bod mimo regulační meze je signálem zvláštní příčiny variability, kterou je třeba identifikovat a odstranit. Posouvání mezí by signál jen skrylo.

## Role v Six Sigma {#role .compare}

Six Sigma pracuje s hierarchií vyškolených rolí (označení podle pásků v bojových uměních):

| Role | Postavení | Hlavní úkoly |
|---|---|---|
| **Champion** (sponzor) | vrcholový nebo střední manažer | vybírá a schvaluje projekty, zajišťuje zdroje, odstraňuje organizační bariéry |
| **Master Black Belt** | expert na metodiku, obvykle plný úvazek | školí a koučuje Black Belty, řídí portfolio projektů, garantuje metodiku |
| **Black Belt** | specialista na plný úvazek | vede náročnější projekty, ovládá statistické nástroje, vede tým |
| **Green Belt** | pracovník na část úvazku | vede menší projekty ve svém útvaru nebo pracuje v týmu Black Beltu |
| **Yellow Belt** | řadový pracovník se základním školením | člen týmu, sběr dat, zavádění zlepšení |

### ? Která role v Six Sigma typicky vede náročnější zlepšovací projekty na plný úvazek?

- [ ] Champion (sponzor projektu)
- [ ] Green Belt
- [x] Black Belt
- [ ] Yellow Belt

> Black Belt je specialista uvolněný na plný úvazek pro vedení projektů. Green Belt pracuje na projektech jen část úvazku, Champion je sponzor z řad managementu.

### ? Jaká je hlavní úloha Championa v programu Six Sigma?

- [ ] Provádí statistické analýzy a vede tým v jednotlivých fázích
- [x] Sponzoruje projekty, zajišťuje zdroje a odstraňuje bariéry
- [ ] Sbírá data přímo v procesu a zavádí dílčí zlepšení
- [ ] Školí Black Belty a garantuje správnost metodiky

> Champion je manažer-sponzor, který projekty vybírá, schvaluje a podporuje. Statistickou práci vykonávají Black/Green Belty, školení a metodiku zajišťuje Master Black Belt.

### ? Která role je nejvyšší odbornou autoritou na metodiku, školí a koučuje Black Belty?

- [ ] Green Belt
- [ ] Champion (sponzor projektu)
- [ ] Yellow Belt
- [x] Master Black Belt

> Master Black Belt je zkušený expert, který školí a koučuje Black Belty a řídí portfolio projektů. Champion je sice výše v řídicí hierarchii, ale jako sponzor, nikoli metodik.

## DMAIC × DMADV {#dmadv .compare}

Vedle DMAIC existuje přístup **DMADV** (Define, Measure, Analyze, Design, Verify), jádro tzv. **Design for Six Sigma** (DFSS):

| Hledisko | DMAIC | DMADV |
|---|---|---|
| Účel | zlepšení existujícího procesu | návrh nového procesu, produktu nebo služby |
| Kdy použít | proces existuje, ale nesplňuje CTQ | proces neexistuje, nebo ho nelze dostatečně zlepšit |
| Poslední dvě fáze | Improve (zlepšit), Control (řídit) | Design (navrhnout), Verify (ověřit) |
| Výsledek | snížení vad a variability | proces navržený pro úroveň Six Sigma od počátku |

### ? Kdy je vhodné použít přístup DMADV místo DMAIC?

- [x] Při návrhu nového procesu nebo produktu, případně když stávající nelze dostatečně zlepšit
- [ ] Vždy, když je proces již stabilní a má sigma úroveň vyšší než 4σ
- [ ] Při krátkodobém řešení jednorázové reklamace konkrétního zákazníka
- [ ] Pouze u výrobních procesů, protože DMAIC je určen jen pro služby

> DMADV (Design for Six Sigma) slouží k návrhu nového procesu či produktu „na úrovni Six Sigma" od počátku. DMAIC zlepšuje existující proces a lze jej použít ve výrobě i službách.

### ? Co znamenají poslední dvě fáze přístupu DMADV?

- [ ] Develop a Validate — vývoj prototypu a jeho schválení
- [ ] Deploy a Verify — nasazení řešení a jeho kontrola
- [x] Design a Verify — navrhnout a ověřit
- [ ] Define a Value — vymezení hodnoty pro zákazníka

> DMADV = Define, Measure, Analyze, Design, Verify. Místo zlepšení a řízení existujícího procesu se nový proces navrhne a ověří, zda splňuje CTQ.

## Lean Six Sigma {#lean-six-sigma .explain}

**Lean Six Sigma** spojuje dva přístupy. **Lean** (vychází z výrobního systému Toyota) se zaměřuje na **odstraňování plýtvání** (muda — např. nadvýroba, čekání, zbytečná doprava, nadbytečné zpracování, zásoby, zbytečné pohyby, vady) a na **rychlost a plynulost toku** hodnoty; nástroje: mapování toku hodnot (VSM), 5S, kaizen, tahový systém. **Six Sigma** se zaměřuje na **variabilitu a vady** a pracuje statisticky v cyklu DMAIC. Spojení umožňuje zároveň zrychlit proces a zvýšit jeho kvalitu; Lean nástroje se běžně zařazují do fází DMAIC.

*Příklad:* Vyřízení pojistné události trvá 20 dní, z toho jen 2 dny skutečné práce. Lean odstraní čekání mezi odděleními, Six Sigma sníží chybovost posudků, která vyvolávala vracení spisů.

### ? Co do spojení Lean Six Sigma přináší především Lean?

- [ ] Statistické řízení variability pomocí regulačních diagramů
- [x] Odstraňování plýtvání a zrychlení toku hodnoty procesem
- [ ] Výpočet sigma úrovně a převod vad na DPMO
- [ ] Hierarchii rolí Champion, Black Belt a Green Belt

> Lean se soustředí na plýtvání (muda) a plynulost toku, Six Sigma na variabilitu a vady. Výpočet DPMO, statistické nástroje i systém Belts pocházejí ze Six Sigma.

### ? Který z uvedených pojmů NEPATŘÍ mezi druhy plýtvání (muda) podle Lean?

- [ ] Nadvýroba
- [ ] Zbytečné zásoby
- [ ] Čekání
- [x] Standardizovaná práce

> Mezi klasické druhy plýtvání patří nadvýroba, čekání, zbytečná doprava, nadbytečné zpracování, zásoby, zbytečné pohyby a vady. Standardizovaná práce je naopak nástroj Lean pro stabilní proces.

## Přínos Six Sigma pro výkonnost a konkurenční výhodu {#prinosy .explain}

Six Sigma propojuje zlepšování procesů s **finanční výkonností**: každý projekt má vyčíslený přínos, typicky ze snížení **nákladů nekvality** (COPQ, cost of poor quality — přepracování, zmetky, reklamace, ztráta zákazníků). Méně vad a nižší variabilita znamenají nižší náklady, menší zásoby a kratší dobu průběhu, a tedy vyšší zisk i lepší využití kapitálu (vyšší EVA). Zároveň roste spokojenost a loajalita zákazníků. V logice BSC zlepšuje perspektivu **interních procesů**, která se promítá do zákaznické a finanční perspektivy. Konkurenční výhodu přináší systematičnost — trvalé zlepšování založené na datech, které konkurence obtížně napodobí.

*Příklad:* Proces má 1 000 000 příležitostí ročně; zlepšení ze 4σ (6 210 DPMO) na 5σ (233 DPMO) odstraní 5 977 vad. Při nákladech 500 Kč na vadu jde o roční úsporu 5 977 · 500 = 2 988 500 Kč.

### ? Proces má 400 000 příležitostí k vadě ročně. Projekt snížil DPMO z 5 000 na 500; jedna vada stojí 300 Kč. Jaká je roční úspora nákladů nekvality?

- [ ] 1 350 000 Kč
- [ ] 600 000 Kč
- [x] 540 000 Kč
- [ ] 54 000 Kč

> Vady před = 5 000 · 0,4 = 2 000, po = 500 · 0,4 = 200; úspora = 1 800 · 300 = 540 000 Kč. Hodnota 1 350 000 Kč vznikne bez přepočtu na 400 000 příležitostí (4 500 · 300), 600 000 Kč ocení všechny původní vady.

### ? Jak se Six Sigma promítá do výkonnosti v logice Balanced Scorecard?

- [x] Zlepšuje interní procesy, což se přenáší do zákaznické a finanční perspektivy
- [ ] Nahrazuje finanční perspektivu, protože měří výkonnost jen v DPMO
- [ ] Týká se výhradně perspektivy učení se a růstu, tedy školení Belts
- [ ] Nemá k BSC vazbu, protože sleduje pouze technické parametry výroby

> Six Sigma primárně zlepšuje interní procesy; méně vad zvyšuje spokojenost zákazníků a snižuje náklady, čímž roste finanční výkonnost. Školení rolí podporuje i perspektivu učení se a růstu, ale není jediným dopadem.

### ? Co v Six Sigma označují náklady nekvality (COPQ)?

- [ ] Náklady na školení Black Beltů a Green Beltů
- [ ] Investice do nového výrobního zařízení
- [x] Náklady na vady — přepracování, zmetky, reklamace
- [ ] Náklady na vedení a archivaci projektové dokumentace Six Sigma

> COPQ (cost of poor quality) zahrnuje náklady vzniklé kvůli vadám — interní (přepracování, zmetky) i externí (reklamace, ztráta zákazníků). Jejich snížení je hlavním zdrojem finančního přínosu projektů.
