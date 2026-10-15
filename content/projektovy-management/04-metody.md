---
kind: topic
subject: projektovy-management
slug: metody
name: "Metody"
order: 4
---

Metoda logického rámce, technika SMART/i/, analýza SW/OT v projektech, technika Ganttových diagramů, metody síťové analýzy (CPM, PERT), metoda kritického řetězce, metody pro vyhodnocení stavu projektu (procentuální, SSD, metoda dosažené hodnoty EVM, metody MTA aj.), Parettova analýza v projektu. Procurement a metody hodnocení dodavatelů, metody analýzy zainteresovaných stran v projektu.

## Metoda logického rámce {#logicky-ramec .explain}

Metoda logického rámce (Logical Framework Approach, LFA) je nástroj pro přípravu, plánování a hodnocení projektu. Vznikla koncem 60. let pro americkou agenturu USAID a dnes ji často vyžadují poskytovatelé dotací, např. Evropská komise u programů vnější pomoci. Výsledkem je **matice logického rámce** (logframe) o rozměru 4 × 4, která na jedné stránce shrnuje, *proč* se projekt dělá, *čeho* má dosáhnout, *co* dodá a *jak*, a zároveň jak se úspěch změří a za jakých předpokladů. Nutí autory projektu ujasnit si příčinné vazby mezi činnostmi a cíli.

*Příklad:* Žádost obce o dotaci na rekonstrukci školy obsahuje logický rámec, ze kterého hodnotitel hned vidí cíl, výstupy, měřitelné ukazatele i rizika projektu.

### ? K čemu primárně slouží metoda logického rámce?

- [ ] K výpočtu kritické cesty a časových rezerv činností
- [x] Ke strukturování projektu od záměru po činnosti v jedné matici
- [ ] K průběžnému měření nákladové výkonnosti projektu
- [ ] K výběru dodavatele podle vážených kritérií

> Logický rámec v matici 4 × 4 propojuje záměr, cíl, výstupy a činnosti s ukazateli, zdroji ověření a předpoklady. Kritickou cestu počítá CPM, nákladovou výkonnost EVM.

## Struktura matice logického rámce {#matice-logframe .compare}

Matice má 4 řádky (úrovně cílů, shora dolů) a 4 sloupce:

| Úroveň | Popis (intervenční logika) | Objektivně ověřitelné ukazatele | Zdroje ověření | Předpoklady |
|---|---|---|---|---|
| **Záměr** (Goal) | širší cíl, ke kterému projekt přispívá | ukazatele dopadu | statistiky, studie | — |
| **Cíl projektu** (Purpose) | přímý přínos pro cílovou skupinu | ukazatele výsledku | průzkumy, evidence | předpoklady pro přispění k záměru |
| **Výstupy** (Outputs) | produkty a služby, které projekt dodá | ukazatele výstupů | předávací protokoly | předpoklady pro dosažení cíle |
| **Činnosti** (Activities) | co se musí vykonat | potřebné zdroje (vstupy) | rozpočet, náklady | předpoklady pro vznik výstupů |

Pod maticí se uvádějí **předběžné podmínky** — co musí platit, aby bylo možné projekt vůbec zahájit.

### ? Který sloupec matice logického rámce obsahuje vnější podmínky, které projekt nemůže ovlivnit, ale musí platit?

- [ ] Objektivně ověřitelné ukazatele
- [ ] Zdroje ověření
- [ ] Popis (intervenční logika)
- [x] Předpoklady

> Předpoklady (assumptions) jsou vnější faktory mimo kontrolu projektového týmu, na kterých závisí přechod na vyšší úroveň matice.

### ? Co v matici logického rámce obvykle obsahuje řádek Činnosti ve sloupcích ukazatelů a zdrojů ověření?

- [x] Potřebné zdroje (vstupy) a rozpočet nákladů
- [ ] Ukazatele dopadu na celé odvětví
- [ ] Rizika ohrožující dlouhodobý záměr
- [ ] Seznam zainteresovaných stran a jejich vliv

> U činností se místo ukazatelů uvádějí potřebné vstupy (lidé, materiál, vybavení) a místo zdrojů ověření jejich náklady, resp. rozpočet.

## Vertikální logika logického rámce {#vertikalni-logika .explain}

Vertikální logika popisuje **příčinné vazby mezi řádky** matice ve tvaru „pokud–pak": pokud jsou splněny předběžné podmínky, lze zahájit činnosti; pokud se provedou činnosti a platí předpoklady, vzniknou výstupy; pokud vzniknou výstupy a platí předpoklady, dosáhne se cíle projektu; cíl spolu s předpoklady přispěje k záměru. Matice se **navrhuje shora dolů** (od záměru k činnostem), ale **realizuje a ověřuje zdola nahoru**. Pokud vazba mezi dvěma úrovněmi nedává smysl, je projekt špatně navržen.

*Příklad:* Záměr: snížit nezaměstnanost absolventů v regionu. Cíl: absolventi rekvalifikačního kurzu získají práci v IT. Výstup: 100 proškolených absolventů. Činnosti: příprava kurzu, nábor, výuka. Předpoklad u výstupů: poptávka firem po IT pracovnících trvá.

### ? Jak se čte vertikální logika logického rámce při ověřování návrhu?

- [ ] Zleva doprava: popis → ukazatele → zdroje ověření
- [ ] Shora dolů bez ohledu na předpoklady
- [x] Zdola nahoru ve vazbách „pokud–pak" přes předpoklady
- [ ] Libovolně, protože úrovně na sobě nezávisí

> Vertikální logika se ověřuje zdola nahoru: činnosti + předpoklady → výstupy, výstupy + předpoklady → cíl, cíl + předpoklady → záměr. Čtení zleva doprava je horizontální logika.

### ? Logický rámec rekvalifikačního projektu: záměr — snížit nezaměstnanost absolventů v regionu; cíl projektu — absolventi kurzu získají práci v IT; výstup — 100 proškolených absolventů; činnosti — příprava kurzu, nábor, výuka. Ke které vazbě patří předpoklad „poptávka firem po IT pracovnících trvá"?

- [ ] Mezi činnostmi a výstupy
- [x] Mezi výstupy a cílem projektu
- [ ] Mezi cílem projektu a záměrem
- [ ] Mezi předběžnými podmínkami a činnostmi

> Proškolení absolventi (výstup) najdou práci (cíl) jen tehdy, pokud firmy stále hledají IT pracovníky — jde tedy o předpoklad přechodu od výstupů k cíli.

## Horizontální logika logického rámce {#horizontalni-logika .explain}

Horizontální logika se čte **v každém řádku zleva doprava**: ke každé položce popisu musí existovat **objektivně ověřitelný ukazatel**, k ukazateli **zdroj ověření** (kde a jak se hodnota zjistí) a k úrovni **předpoklady**. Ukazatele mají splňovat kritéria SMART — musí mít konkrétní cílovou hodnotu, kvalitu, cílovou skupinu a termín. Ukazatel, ke kterému neexistuje dostupný a důvěryhodný zdroj ověření, je k ničemu a je třeba ho přeformulovat.

*Příklad:* Výstup „proškolení absolventi" — ukazatel: 100 absolventů s certifikátem do 30. 6. 2027; zdroj ověření: prezenční listiny a evidence vydaných certifikátů.

### ? Co je známkou porušené horizontální logiky logického rámce?

- [ ] Ukazatel má stanovenou cílovou hodnotu a termín
- [ ] Předpoklady leží mimo kontrolu projektového týmu
- [ ] Výstupy jsou formulovány jako hotové produkty
- [x] K ukazateli neexistuje zdroj, ze kterého by šel ověřit

> Horizontální logika vyžaduje, aby každý ukazatel bylo možné ověřit z konkrétního zdroje. Ostatní možnosti popisují správně sestavený rámec.

## Analýza SWOT v projektu {#swot .explain}

Analýza SWOT hodnotí **silné stránky** (Strengths), **slabé stránky** (Weaknesses), **příležitosti** (Opportunities) a **hrozby** (Threats). Silné a slabé stránky jsou **vnitřní** faktory (projekt, tým, organizace je může ovlivnit), příležitosti a hrozby jsou **vnější** faktory okolí (trh, legislativa, konkurence). V projektovém řízení se používá hlavně v předprojektové fázi při posuzování záměru a volbě strategie projektu, ale také jako podklad pro identifikaci rizik.

*Příklad:* Projekt e-shopu: S — zkušený vývojový tým; W — malý marketingový rozpočet; O — růst online nákupů v segmentu; T — vstup silného konkurenta na trh.

### ? Do kterého kvadrantu SWOT patří chystaná legislativní změna, která zvýší požadavky na vyvíjený produkt?

- [ ] Slabé stránky (W)
- [ ] Silné stránky (S)
- [x] Hrozby (T)
- [ ] Příležitosti (O)

> Legislativa je vnější faktor, který projekt neovlivní, a zvýšení požadavků působí nepříznivě — jde tedy o hrozbu.

### ? Které dva kvadranty SWOT popisují vnitřní prostředí projektu či organizace?

- [x] Silné a slabé stránky (S, W)
- [ ] Příležitosti a hrozby (O, T)
- [ ] Silné stránky a příležitosti (S, O)
- [ ] Slabé stránky a hrozby (W, T)

> S a W jsou vnitřní charakteristiky, které lze ovlivnit; O a T vycházejí z vnějšího okolí.

## Strategie SWOT (SO, ST, WO, WT) {#swot-strategie .compare}

Kombinací vnitřních a vnějších faktorů vznikají čtyři typy strategií:

| | Příležitosti (O) | Hrozby (T) |
|---|---|---|
| **Silné stránky (S)** | **SO (maxi-maxi)** — využít silné stránky k využití příležitostí | **ST (maxi-mini)** — využít silné stránky k odvrácení hrozeb |
| **Slabé stránky (W)** | **WO (mini-maxi)** — překonat slabiny využitím příležitostí | **WT (mini-mini)** — omezit slabiny a vyhnout se hrozbám (obranná strategie) |

### ? Firma má slabý vlastní vývoj (W), ale vyhlášený dotační program podporuje spolupráci s univerzitami (O). Kterou strategii zvolí, když dotaci využije k posílení vývoje?

- [ ] SO
- [x] WO
- [ ] ST
- [ ] WT

> Strategie WO (mini-maxi) překonává slabou stránku pomocí vnější příležitosti.

### ? Která strategie SWOT je označována jako obranná (mini-mini)?

- [ ] SO
- [ ] ST
- [ ] WO
- [x] WT

> Strategie WT se snaží minimalizovat slabé stránky a zároveň se vyhnout hrozbám — jde o obrannou, přežívací strategii.

## Ganttův diagram {#gantt .explain}

Ganttův diagram (podle Henryho L. Gantta, 10. léta 20. století) je **pruhový diagram harmonogramu**: činnosti jsou v řádcích, vodorovně je časová osa a délka pruhu odpovídá době trvání činnosti. Často zobrazuje i **milníky** (symbol s nulovou délkou, obvykle kosočtverec), **vazby** mezi činnostmi (šipky), **stav plnění** (vybarvená část pruhu) a srovnání se **základním plánem** (baseline). Je názorný a srozumitelný i pro laiky, proto se hodí pro komunikaci se zainteresovanými stranami. U velkých projektů je však nepřehledný a bez vazeb sám neukazuje kritickou cestu ani rezervy — proto se kombinuje se síťovou analýzou.

*Příklad:* Nástroje jako MS Project spočítají harmonogram síťovou analýzou a výsledek zobrazí jako Ganttův diagram s vyznačenou kritickou cestou.

### ? Co klasický Ganttův diagram bez vyznačených vazeb NEUMOŽŇUJE spolehlivě určit?

- [x] Kritickou cestu a rezervy činností
- [ ] Plánovaný začátek a konec činností
- [ ] Dobu trvání jednotlivých činností
- [ ] Překrývání činností v čase

> Bez logických vazeb nelze zjistit, které činnosti se navzájem podmiňují, a tedy ani kritickou cestu a rezervy. Termíny, doby trvání a překryvy jsou z pruhů vidět přímo.

### ? Jak se v Ganttově diagramu obvykle zobrazuje milník?

- [ ] Nejdelším pruhem v diagramu
- [ ] Šipkou mezi dvěma činnostmi
- [x] Kosočtvercem s nulovou délkou
- [ ] Pruhem vybarveným podle stavu plnění

> Milník je významný okamžik bez doby trvání, proto se kreslí symbolem (obvykle kosočtvercem), ne pruhem.

## Metoda kritické cesty (CPM) {#cpm .explain}

Metoda kritické cesty (Critical Path Method, CPM) vznikla v roce 1957 ve firmách DuPont a Remington Rand. Projekt se zobrazí jako **síťový graf** — nejčastěji uzlově definovaný (činnosti v uzlech, AON), případně hranově definovaný (činnosti na hranách, AOA). Doby trvání činností jsou **deterministické** (jeden odhad). **Kritická cesta** je nejdelší cesta od začátku do konce projektu; určuje nejkratší možnou dobu trvání projektu a její činnosti mají nulovou celkovou rezervu, takže zpoždění kterékoli z nich posune konec projektu. Kritických cest může být i více.

*Příklad:* U stavby domu leží základy → hrubá stavba → střecha na kritické cestě, zatímco výběr kuchyňské linky má rezervu několik týdnů.

### ? Co platí o kritické cestě v síťovém grafu?

- [ ] Je to nejkratší cesta od začátku do konce projektu
- [ ] Obsahuje činnosti s nejvyššími náklady
- [ ] V každém projektu existuje právě jedna
- [x] Je nejdelší a určuje minimální dobu trvání projektu

> Kritická cesta je nejdelší cesta sítí; kratší dobu projektu dosáhnout nelze. Kritických cest může být více a s náklady činností nesouvisí.

### ? Činnost na kritické cestě se zpozdí o 2 dny a nepřijmou se žádná opatření. Co se stane?

- [ ] Nic, zpoždění pokryje rezerva činnosti
- [x] Konec projektu se posune o 2 dny
- [ ] Konec projektu se posune o 1 den
- [ ] Kritická cesta se zkrátí o 2 dny

> Kritické činnosti mají nulovou celkovou rezervu, takže každé jejich zpoždění se přímo přenese do termínu dokončení projektu.

## Dopředný a zpětný průchod {#pruchody .explain}

**Dopředný průchod** (forward pass) postupuje od začátku sítě a počítá nejdříve možný začátek (ES) a konec (EF): EF = ES + doba trvání; ES následníka = **maximum** EF všech předchůdců. **Zpětný průchod** (backward pass) postupuje od konce a počítá nejpozději přípustný konec (LF) a začátek (LS): LS = LF − doba trvání; LF předchůdce = **minimum** LS všech následníků. Rozdíly mezi pozdními a ranými termíny dávají rezervy.

*Příklad:*

| Činnost | Doba (dny) | Předchůdci | ES–EF | LS–LF |
|---|---|---|---|---|
| A | 3 | — | 0–3 | 0–3 |
| B | 5 | A | 3–8 | 3–8 |
| C | 2 | A | 3–5 | 5–7 |
| D | 1 | C | 5–6 | 7–8 |
| E | 4 | B, D | 8–12 | 8–12 |

Projekt trvá 12 dní, kritická cesta je A–B–E.

### ? Síťový graf: A (3 dny, bez předchůdců), B (5 dní, po A), C (2 dny, po A), D (1 den, po C), E (4 dny, po B a D).
Dopředným průchodem vyjde EF_B = 8 a EF_D = 6. Proč je nejdříve možný začátek (ES) činnosti E právě 8?

- [ ] Je to součet dob trvání činností A a C a D
- [ ] Je to minimum z EF předchůdců B (8) a D (6)
- [x] Je to maximum z EF předchůdců B (8) a D (6)
- [ ] Je to LS činnosti E zmenšené o její dobu trvání

> E může začít až po dokončení všech předchůdců, proto ES = max(EF_B, EF_D) = max(8, 6) = 8. Při chybném použití minima by vyšlo 6.

### ? Jak se při zpětném průchodu určí nejpozději přípustný konec (LF) činnosti, která má více následníků?

- [x] Jako minimum LS všech následníků
- [ ] Jako maximum LS všech následníků
- [ ] Jako maximum EF všech předchůdců
- [ ] Jako součet dob trvání následníků

> Činnost musí skončit včas pro toho následníka, který musí začít nejdříve, proto LF = min(LS následníků). Maximum EF předchůdců se používá při dopředném průchodu pro ES.

## Celková a volná rezerva {#rezervy .compare}

Rezervy (float, slack) říkají, o kolik lze činnost posunout bez negativního dopadu:

| | Celková rezerva (Total Float, TF) | Volná rezerva (Free Float, FF) |
|---|---|---|
| Význam | posun, který neposune **konec projektu** | posun, který neposune **ES žádného následníka** |
| Výpočet | TF = LS − ES = LF − EF | FF = min(ES následníků) − EF |
| Dopad čerpání | může ubrat rezervu následníkům na stejné cestě | neovlivní žádnou jinou činnost |
| Vztah | TF ≥ FF | FF ≤ TF |
| Kritická činnost | TF = 0 | FF = 0 |

### ? Činnost C má ES = 3, EF = 5, LS = 5, LF = 7 a jediného následníka D s ES = 5. Jaká je celková (TF) a volná (FF) rezerva činnosti C?

- [ ] TF = 0, FF = 2
- [x] TF = 2, FF = 0
- [ ] TF = 2, FF = 2
- [ ] TF = 4, FF = 0

> TF = LS − ES = 5 − 3 = 2; FF = ES_D − EF_C = 5 − 5 = 0. Posunem C se tedy posune i D, ale konec projektu ještě ne.

### ? Které tvrzení o rezervách v síťovém grafu je správné?

- [ ] Celková rezerva je vždy menší než volná
- [ ] Kritické činnosti mají kladnou volnou rezervu
- [x] Volná rezerva nemůže být větší než celková
- [ ] Čerpání celkové rezervy nikdy neovlivní jiné činnosti

> Platí FF ≤ TF. Čerpání celkové rezervy může ubrat rezervu následníkům na téže cestě, čerpání volné rezervy nikoli.

## PERT a tříbodový odhad {#pert .explain}

Metoda PERT (Program Evaluation and Review Technique) vznikla v roce 1958 pro raketový program Polaris amerického námořnictva. Pracuje s **nejistotou** doby trvání: pro každou činnost se stanoví tři odhady — **optimistický a**, **nejpravděpodobnější m** a **pesimistický b** — a předpokládá se beta rozdělení. Platí:

- očekávaná doba **tₑ = (a + 4m + b) / 6**
- směrodatná odchylka **σ = (b − a) / 6**, rozptyl σ²

Pro cestu se sčítají očekávané doby i **rozptyly** (při nezávislosti činností), σ cesty je odmocnina součtu rozptylů. Délka projektu se pak aproximuje normálním rozdělením, což umožňuje odhadnout pravděpodobnost dodržení termínu.

*Příklad:* a = 4, m = 7, b = 16 dní → tₑ = (4 + 28 + 16) / 6 = 8 dní, σ = (16 − 4) / 6 = 2 dny.

### ? Odhady činnosti jsou a = 2, m = 5, b = 14 dní. Jaká je očekávaná doba trvání podle PERT?

- [x] 6 dní
- [ ] 7 dní
- [ ] 5 dní
- [ ] 8 dní

> tₑ = (2 + 4 · 5 + 14) / 6 = 36 / 6 = 6 dní. Hodnota 7 by vyšla prostým průměrem (2 + 5 + 14) / 3, hodnota 5 je jen nejpravděpodobnější odhad.

### ? Cesta obsahuje dvě nezávislé činnosti se směrodatnými odchylkami 3 a 4 dny. Jaká je směrodatná odchylka délky cesty?

- [ ] 7 dní
- [ ] 3,5 dne
- [x] 5 dní
- [ ] 12 dní

> Sčítají se rozptyly, ne směrodatné odchylky: 3² + 4² = 9 + 16 = 25, σ = √25 = 5 dní.

### ? Činnost má odhady a = 5, m = 10, b = 23 dní. Jaká je její směrodatná odchylka podle PERT?

- [ ] 18 dní
- [x] 3 dny
- [ ] 6 dní
- [ ] 9 dní

> σ = (b − a) / 6 = (23 − 5) / 6 = 3 dny. Hodnota 18 je rozpětí b − a, hodnota 9 je rozptyl σ².

## CPM vs. PERT {#cpm-vs-pert .compare}

| | CPM | PERT |
|---|---|---|
| Vznik | 1957, DuPont a Remington Rand | 1958, US Navy (program Polaris) |
| Odhad doby činnosti | jeden, deterministický | tři (a, m, b), pravděpodobnostní |
| Hlavní výstup | kritická cesta, rezervy | očekávaná doba projektu, její rozptyl a pravděpodobnost dodržení termínu |
| Vhodné pro | projekty se známými dobami činností (např. stavebnictví) | nové projekty s vysokou nejistotou (výzkum a vývoj) |
| Náklady | původně i analýza zkracování za cenu vyšších nákladů (crashing) | zaměřen především na čas |

### ? Vyvíjíte zcela nový typ dronu a doby činností lze odhadnout jen velmi nejistě. Která metoda síťové analýzy je vhodnější?

- [ ] CPM s jedním odhadem doby činnosti
- [ ] Ganttův diagram bez vazeb
- [ ] Paretova analýza činností
- [x] PERT se třemi odhady doby činnosti

> PERT pracuje s optimistickým, nejpravděpodobnějším a pesimistickým odhadem, a proto lépe zachytí nejistotu typickou pro výzkum a vývoj.

## Metoda kritického řetězce (CCPM) {#ccpm .explain}

Metodu kritického řetězce (Critical Chain Project Management, CCPM) představil E. M. Goldratt v knize *Critical Chain* (1997); vychází z jeho teorie omezení (TOC). **Kritický řetězec** je nejdelší řetězec činností s ohledem na logické vazby **i na dostupnost zdrojů** (tentýž zdroj nemůže dělat dvě činnosti současně). Odhady jednotlivých činností se zbaví skrytých bezpečnostních rezerv (zkrátí se na „agresivní", ale dosažitelné hodnoty) a ušetřený čas se soustředí do **nárazníků** (buffers). Důvodem je, že rezervy v jednotlivých činnostech se obvykle promrhají: práce se rozroste na celý dostupný čas (Parkinsonův zákon), začíná se na poslední chvíli (studentský syndrom), zpoždění se přenášejí, ale úspory času ne. Metoda také omezuje multitasking.

*Příklad:* Místo 10 dní „s rezervou" plánuje každý vývojář 6 dní; část ušetřeného času se přesune do společného projektového nárazníku na konci řetězce.

### ? Čím se kritický řetězec liší od kritické cesty?

- [x] Zohledňuje kromě logických vazeb i omezení zdrojů
- [ ] Pracuje se třemi odhady doby každé činnosti
- [ ] Ignoruje logické vazby mezi činnostmi
- [ ] Je vždy kratší, protože neobsahuje žádné rezervy

> Kritický řetězec respektuje i zdrojové závislosti. Tři odhady jsou znakem PERT; rezervy CCPM neruší, ale soustřeďuje je do nárazníků.

### ? Člen týmu má na úkol vyhrazeno 10 dní, ale začne na něm pracovat až 3 dny před termínem, takže rezerva se promrhá. Jak se tento jev v CCPM nazývá?

- [ ] Parkinsonův zákon
- [x] Studentský syndrom
- [ ] Paretovo pravidlo
- [ ] Efekt multitaskingu

> Studentský syndrom je odkládání práce na poslední chvíli. Parkinsonův zákon naopak popisuje, že se práce rozroste na celý dostupný čas.

## Nárazníky v metodě kritického řetězce {#ccpm-naraznik .compare}

CCPM používá tři druhy nárazníků (buffers):

| Nárazník | Umístění | Účel |
|---|---|---|
| **Projektový** (project buffer) | na konci kritického řetězce, před termínem dokončení | chrání termín celého projektu |
| **Napájecí** (feeding buffer) | v místě, kde se nekritický řetězec napojuje na kritický | chrání kritický řetězec před zpožděním nekritických činností |
| **Zdrojový** (resource buffer) | před činností kritického řetězce, která potřebuje nový zdroj | upozornění, aby byl zdroj připraven včas; nepřidává čas |

Stav projektu se řídí poměrem **čerpání nárazníku** k postupu na kritickém řetězci (zelená / žlutá / červená zóna, tzv. fever chart).

### ? Kam se v CCPM umisťuje napájecí nárazník?

- [ ] Na konec kritického řetězce před termín projektu
- [ ] Na začátek projektu před první činnost
- [x] Do místa napojení nekritického řetězce na kritický
- [ ] Ke každé činnosti zvlášť jako její vlastní rezerva

> Napájecí nárazník chrání kritický řetězec před zpožděním přitékajícím z nekritických větví. Na konci řetězce je projektový nárazník.

### ? Kritický řetězec je hotov z 30 %, ale projektový nárazník je již vyčerpán ze 70 %. Co to signalizuje?

- [ ] Projekt je v předstihu proti plánu
- [ ] Nárazník je předimenzovaný a lze ho zrušit
- [ ] Normální stav, nárazník se čerpá rovnoměrně
- [x] Termín je ohrožen a je nutné přijmout opatření

> Nárazník se spotřebovává mnohem rychleji, než postupuje práce — projekt je v červené zóně a hrozí nedodržení termínu.

## Procentuální metoda vyhodnocení stavu {#procentualni-metoda .explain}

Procentuální metoda hodnotí postup projektu podle **procenta dokončení** (% complete) činností nebo pracovních balíků a porovnává ho s plánovaným procentem k datu kontroly. Procento se určuje odhadem odpovědné osoby, poměrem hotových měrných jednotek (metry, stránky, testy) nebo pevnými pravidly, např. **0/100** (hodnota se započte až po dokončení) či **50/50** (polovina při zahájení, polovina při dokončení). Výhodou je jednoduchost; nevýhodou subjektivita odhadů (tzv. syndrom 90 % — činnost je dlouho „skoro hotová") a to, že metoda sama nezohledňuje skutečné náklady.

*Příklad:* K 30. 4. mělo být položeno 60 % kabeláže, skutečně je položeno 450 z 1 000 m, tj. 45 % — skluz 15 procentních bodů.

### ? Proč se u procentuální metody používají pravidla jako 0/100 nebo 50/50?

- [ ] Aby se do hodnocení promítly skutečné náklady
- [x] Aby se omezilo subjektivní nadhodnocování dokončení
- [ ] Aby bylo možné určit kritickou cestu projektu
- [ ] Aby šlo vypočítat pesimistický odhad doby

> Pevná pravidla nahrazují subjektivní odhady procenta dokončení, které bývají přehnaně optimistické (syndrom 90 %).

### ? Plán testování obsahuje 1 200 testovacích případů a k datu kontroly mělo být hotovo 50 %. Provedeno je 480 případů. Jaký je stav?

- [x] Skutečnost 40 %, skluz 10 procentních bodů
- [ ] Skutečnost 48 %, skluz 2 procentní body
- [ ] Skutečnost 40 %, předstih 10 procentních bodů
- [ ] Skutečnost 60 %, předstih 10 procentních bodů

> 480 / 1 200 = 0,4 = 40 %; plán byl 50 %, projekt je tedy o 10 procentních bodů pozadu.

## Metoda SSD (Structure–Status–Deviation) {#ssd .explain}

Metoda **SSD** (Structure – Status – Deviation, tj. struktura – stav – odchylka) vyhodnocuje stav projektu podle **stavu jednotlivých činností ke dni kontroly**. Je vhodná pro **středně rozsáhlé projekty**. Postup:

1. **Struktura** — vyjde se ze seznamu činností projektu (z WBS a harmonogramu).
2. **Stav** — u každé činnosti se ke dni kontroly určí plánovaný a skutečný stav: **nezačala / probíhá / ukončena** (bodově 0 / 1 / 2).
3. **Odchylka** — porovnáním skutečného stavu s plánovaným vznikne odchylka v rozmezí **−2 až +2** (záporná = skluz, 0 = podle plánu, kladná = předstih). U nákladů se odchylka hodnotí jen třístupňově (−1 / 0 / +1).
4. **Vyhodnocení** — součtem se vyjádří **procentní stav projektu**: součet bodů skutečných stavů / (2 × počet činností) × 100 %; stejně spočtený plánovaný stav ukáže, o kolik je projekt pozadu či napřed.

*Příklad:* Projekt má 5 činností. Podle plánu mají být ke dni kontroly A a B ukončeny, C a D probíhat a E nezačatá: 2 + 2 + 1 + 1 + 0 = 6 bodů z 10 = 60 %. Skutečně je A ukončena, B a C probíhají, D a E nezačaly: 2 + 1 + 1 + 0 + 0 = 4 body = 40 %. Odchylky činností jsou 0, −1, 0, −1, 0 (součet −2) — projekt má skluz 20 procentních bodů.

### ? Při vyhodnocení stavu projektu metodou SSD měla být činnost ke dni kontroly podle plánu ukončena, ale dosud nezačala. Jakou má odchylku?

- [ ] −1
- [ ] +2
- [x] −2
- [ ] 0

> Odchylka v SSD se pohybuje od −2 do +2. Činnost, která měla být ukončena (nejvyšší stav), a přitom nezačala (nejnižší stav), má maximální skluz −2.

### ? Metoda SSD, stavy činností: nezačala = 0, probíhá = 1, ukončena = 2 body. Podle plánu mají být ke dni kontroly A a B ukončeny, C a D probíhat a E nezačatá. Skutečně je A ukončena, B probíhá, C ukončena, D a E nezačaly. Jaký je skutečný procentní stav projektu a součet odchylek?

- [ ] 60 %, součet odchylek 0
- [x] 50 %, součet odchylek −1
- [ ] 50 %, součet odchylek +1
- [ ] 40 %, součet odchylek −2

> Skutečnost: 2 + 1 + 2 + 0 + 0 = 5 bodů z 10 = 50 % (plán 6 bodů = 60 %). Odchylky: A 0, B −1, C +1, D −1, E 0, součet −1 — projekt je mírně pozadu.

## Metoda dosažené hodnoty (EVM) — základní veličiny {#evm-veliciny .explain}

Metoda dosažené hodnoty (Earned Value Management, EVM) propojuje rozsah, čas a náklady. K datu kontroly porovnává tři veličiny vyjádřené v penězích:

- **PV** (Planned Value, dříve BCWS) — plánovaná hodnota: rozpočtové náklady práce, která **měla být** podle plánu hotová.
- **EV** (Earned Value, dříve BCWP) — dosažená hodnota: rozpočtové náklady práce **skutečně hotové** (% dokončení × BAC).
- **AC** (Actual Cost, dříve ACWP) — skutečné náklady vynaložené na hotovou práci.
- **BAC** (Budget at Completion) — celkový rozpočet projektu.

*Příklad:* BAC = 1 000 tis. Kč na 10 stejných etap. K datu kontroly měly být hotové 4 etapy (PV = 400 tis. Kč), hotové jsou 3 (EV = 300 tis. Kč) a utratilo se 360 tis. Kč (AC).

### ? Která veličina EVM vyjadřuje rozpočtovou hodnotu práce, která byla skutečně dokončena?

- [ ] AC (Actual Cost)
- [x] EV (Earned Value)
- [ ] PV (Planned Value)
- [ ] BAC (Budget at Completion)

> EV je rozpočtová hodnota skutečně hotové práce. PV je hodnota práce plánované k datu kontroly, AC skutečně vynaložené náklady.

### ? Projekt s rozpočtem BAC = 2 000 tis. Kč je k datu kontroly hotový z 25 %. Jaká je dosažená hodnota EV?

- [ ] 2 000 tis. Kč
- [ ] 250 tis. Kč
- [x] 500 tis. Kč
- [ ] 1 500 tis. Kč

> EV = % dokončení × BAC = 0,25 × 2 000 = 500 tis. Kč. Hodnota 1 500 tis. Kč je rozpočet zbývající práce.

## Odchylky a indexy výkonnosti EVM {#evm-indexy .explain}

Z veličin PV, EV a AC se počítají:

- **odchylka harmonogramu SV = EV − PV** a **index výkonnosti harmonogramu SPI = EV / PV**,
- **nákladová odchylka CV = EV − AC** a **index nákladové výkonnosti CPI = EV / AC**.

Záporná odchylka, resp. index menší než 1 znamená nepříznivý stav (skluz, překročení nákladů); kladná odchylka, resp. index větší než 1 příznivý stav. Ve vzorcích odchylek a indexů (SV, CV, SPI, CPI) je vždy na prvním místě EV.

*Příklad:* PV = 400, EV = 300, AC = 360 tis. Kč → SV = −100 tis. Kč, SPI = 0,75 (skluz); CV = −60 tis. Kč, CPI = 300 / 360 ≈ 0,83 — za každou utracenou korunu vzniká práce v rozpočtové hodnotě asi 83 haléřů.

### ? PV = 500, EV = 400 a AC = 320 tis. Kč. Jaké jsou indexy SPI a CPI?

- [ ] SPI = 1,25; CPI = 0,8
- [ ] SPI = 0,64; CPI = 0,8
- [ ] SPI = 1,25; CPI = 1,56
- [x] SPI = 0,8; CPI = 1,25

> SPI = EV / PV = 400 / 500 = 0,8; CPI = EV / AC = 400 / 320 = 1,25. Projekt je ve skluzu, ale levnější, než plánoval rozpočet. První možnost vznikne převrácením zlomků.

### ? Projekt má SPI = 1,1 a CPI = 0,9. Jak jeho stav interpretujete?

- [ ] Skluz v harmonogramu i překročení nákladů
- [ ] Předstih v harmonogramu a úspora nákladů
- [x] Předstih v harmonogramu, ale překročení nákladů
- [ ] Skluz v harmonogramu, ale úspora nákladů

> SPI > 1 znamená, že je hotovo více práce, než bylo plánováno (předstih); CPI < 1 znamená, že hotová práce stála více, než měla.

### ? Který z následujících vzorců EVM NENÍ správný?

- [x] CV = AC − EV
- [ ] SV = EV − PV
- [ ] CPI = EV / AC
- [ ] SPI = EV / PV

> Nákladová odchylka se počítá CV = EV − AC, aby záporná hodnota znamenala překročení nákladů. Ve vzorcích odchylek a indexů (SV, CV, SPI, CPI) je EV vždy na prvním místě.

## Prognóza nákladů při dokončení (EAC) {#evm-prognoza .explain}

EVM umožňuje odhadnout, kolik bude projekt nakonec stát:

- **EAC = BAC / CPI** — dosavadní nákladová výkonnost bude pokračovat (typická, trvalá odchylka),
- **EAC = AC + (BAC − EV)** — zbývající práce proběhne podle původního rozpočtu (netypická, jednorázová odchylka),
- **ETC = EAC − AC** — odhad nákladů na dokončení zbývající práce,
- **VAC = BAC − EAC** — odchylka rozpočtu při dokončení (záporná = překročení).

*Příklad:* BAC = 1 000, EV = 300, AC = 360 tis. Kč, CPI = 300 / 360 → EAC = 1 000 · 360 / 300 = 1 200 tis. Kč, ETC = 840 tis. Kč, VAC = −200 tis. Kč.

### ? Rozpočet projektu je BAC = 800 tis. Kč a CPI = 0,8. Jaký je odhad nákladů při dokončení (EAC), pokud dosavadní nákladová výkonnost bude pokračovat?

- [ ] 640 tis. Kč
- [x] 1 000 tis. Kč
- [ ] 800 tis. Kč
- [ ] 960 tis. Kč

> EAC = BAC / CPI = 800 / 0,8 = 1 000 tis. Kč. Hodnota 640 vznikne chybným násobením BAC × CPI.

### ? BAC = 1 000, EV = 400 a AC = 500 tis. Kč. Překročení nákladů bylo jednorázové a zbytek práce proběhne podle rozpočtu. Jaký je EAC?

- [ ] 1 250 tis. Kč
- [ ] 1 500 tis. Kč
- [ ] 900 tis. Kč
- [x] 1 100 tis. Kč

> Při netypické odchylce EAC = AC + (BAC − EV) = 500 + 600 = 1 100 tis. Kč. Hodnota 1 250 (= BAC / CPI) platí, jen pokud by nákladová výkonnost zůstala trvale na CPI = 0,8.

## Trendová analýza milníků (MTA) {#mta .explain}

Trendová analýza milníků (Milestone Trend Analysis, MTA) sleduje, jak se v čase vyvíjí **prognóza termínů milníků**. Na vodorovné ose grafu jsou data kontrol (reportů), na svislé ose prognózované termíny milníků; obě osy mají stejné měřítko a diagonála uzavírá graf do trojúhelníku. Při každé kontrole se pro každý milník zakreslí aktuální odhad jeho termínu. **Vodorovná** linie znamená stabilní termín, **stoupající** linie zpožďování, **klesající** linie předstih (nebo příliš opatrný plán). Linie končí na diagonále, když je milník dosažen. Metoda je jednoduchá, názorná pro vedení a včas odhalí nepříznivé trendy.

*Příklad:* Milník „spuštění pilotního provozu" měl plán 1. 6.; při kontrolách v březnu, dubnu a květnu se prognóza posouvala na 8. 6., 15. 6. a 29. 6. — stoupající trend je signálem k zásahu.

### ? V grafu MTA linie milníku při posledních třech kontrolách stále stoupá. Co to znamená?

- [ ] Milník byl již dosažen
- [ ] Termín milníku je stabilní
- [ ] Milník bude dosažen dříve, než se plánovalo
- [x] Prognóza termínu se opakovaně posouvá

> Stoupající linie znamená, že se při každé kontrole prognóza termínu milníku posunula na pozdější datum — milník se zpožďuje.

### ? Co zobrazují osy grafu trendové analýzy milníků?

- [x] Data kontrol a prognózované termíny milníků
- [ ] Plánované a skutečné náklady projektu
- [ ] Činnosti projektu a jejich doby trvání
- [ ] Příčiny problémů a jejich kumulativní četnost

> Vodorovná osa nese data kontrol (reportů), svislá osa prognózované termíny milníků. Náklady sleduje EVM, četnosti příčin Paretův diagram.

## Paretova analýza v projektu {#pareto .explain}

Paretova analýza vychází z **pravidla 80/20** (podle ekonoma V. Pareta; do řízení kvality ho přenesl J. M. Juran): zhruba 80 % následků způsobuje přibližně 20 % příčin. Postup: shromáždit četnosti (nebo dopady) příčin → seřadit je sestupně → spočítat kumulativní procenta → vykreslit **Paretův diagram** (sloupce seřazené sestupně + kumulativní čára) → zaměřit se na „životně důležitou menšinu" příčin. V projektech se používá k analýze příčin vad, zpoždění nebo změnových požadavků a ke stanovení priorit. Poměr 80/20 je orientační, ne přesný zákon.

*Příklad:* Rozbor reklamací ukáže, že většina chyb pochází ze 2 z 10 modulů informačního systému — testování a refaktoring se soustředí na ně.

### ? Vady podle příčin: chybná specifikace 45, chyby v kódu 30, chybná konfigurace 12, dokumentace 8, ostatní 5 (celkem 100). Kolik nejčastějších příčin je třeba řešit, aby se pokrylo alespoň 75 % vad?

- [ ] Jednu
- [ ] Tři
- [x] Dvě
- [ ] Čtyři

> Kumulativně: 45 % → 45 + 30 = 75 %. Dvě nejčastější příčiny pokrývají 75 % vad, třetí by kumulaci zvýšila na 87 %.

### ? Co NENÍ součástí Paretova diagramu?

- [ ] Sloupce četností seřazené sestupně
- [ ] Kumulativní procentní čára
- [ ] Kategorie příčin na vodorovné ose
- [x] Časová osa s milníky projektu

> Paretův diagram tvoří sestupně seřazené sloupce kategorií a kumulativní čára. Časová osa s milníky patří Ganttovu diagramu.

## Řízení obstarávání (procurement) {#procurement .explain}

Řízení obstarávání (procurement management) zahrnuje procesy nákupu produktů, služeb a výsledků od externích dodavatelů. Podle PMBOK je tvoří **plánování obstarávání** (analýza „vyrobit, nebo koupit" — make-or-buy, volba typu smlouvy, zadávací dokumentace a hodnoticí kritéria), **provádění obstarávání** (poptávka, výběr dodavatele, uzavření smlouvy) a **kontrola obstarávání** (řízení smluvního vztahu, změny, akceptace, ukončení smlouvy). Typ smlouvy určuje rozložení rizika: u smlouvy **s pevnou cenou** nese riziko překročení nákladů hlavně dodavatel, u smlouvy **s úhradou nákladů** hlavně odběratel, smlouva **na čas a materiál** (T&M) leží mezi nimi. Veřejní zadavatelé v ČR postupují podle zákona č. 134/2016 Sb., o zadávání veřejných zakázek.

*Příklad:* Firma rozhoduje, zda e-shop vyvine vlastním týmem, nebo ho zadá agentuře; analýza make-or-buy porovná náklady, kapacity, know-how a rizika obou variant.

### ? Kdo nese hlavní riziko překročení nákladů u smlouvy s pevnou cenou?

- [x] Dodavatel
- [ ] Odběratel (zákazník)
- [ ] Ze zákona obě strany rovným dílem
- [ ] Sponzor projektu na straně dodavatele

> Při pevné ceně dodavatel dodá sjednaný rozsah za dohodnutou částku, takže vícenáklady jdou na jeho vrub.

### ? Která činnost patří do plánování obstarávání?

- [ ] Akceptace dodávky a ukončení smlouvy
- [ ] Řízení změn již uzavřené smlouvy
- [x] Analýza „vyrobit, nebo koupit"
- [ ] Proplácení faktur dodavateli

> Rozhodnutí make-or-buy předchází samotnému nákupu, proto je součástí plánování. Ostatní činnosti patří do kontroly obstarávání.

## Vícekriteriální hodnocení dodavatelů {#hodnoceni-dodavatelu .explain}

Nabídky dodavatelů se obvykle hodnotí **vícekriteriálně**:

1. stanovit kritéria (cena, kvalita, reference, termín dodání, záruky…),
2. určit **váhy** kritérií se součtem 1 (100 %), např. **Fullerovou metodou** párového srovnání nebo Saatyho metodou (AHP),
3. ohodnotit každého dodavatele v každém kritériu na stejné bodové škále,
4. spočítat **vážené skóre** = Σ (váha × hodnocení),
5. vybrat dodavatele s nejvyšším skóre.

Kritéria a váhy se stanovují **předem**, aby byl výběr transparentní a obhajitelný.

*Příklad:* Váhy: cena 0,5, kvalita 0,3, termín 0,2. Dodavatel s hodnocením 8, 6, 7 získá 0,5 · 8 + 0,3 · 6 + 0,2 · 7 = 4 + 1,8 + 1,4 = 7,2 bodu.

### ? Váhy: cena 0,5, kvalita 0,3, termín 0,2. Dodavatel X má hodnocení 6, 9, 8, dodavatel Y 10, 5, 6 (body 1–10). Kdo zvítězí podle váženého skóre?

- [x] Dodavatel Y se skóre 7,7
- [ ] Dodavatel X se skóre 7,3
- [ ] Dodavatel X, protože má vyšší součet bodů (23)
- [ ] Oba dodavatelé mají stejné skóre

> X: 0,5 · 6 + 0,3 · 9 + 0,2 · 8 = 3 + 2,7 + 1,6 = 7,3; Y: 0,5 · 10 + 0,3 · 5 + 0,2 · 6 = 5 + 1,5 + 1,2 = 7,7. Prostý součet bodů ignoruje váhy kritérií.

### ? Na čem je založena Fullerova metoda stanovení vah kritérií?

- [ ] Na tříbodovém odhadu každého kritéria
- [x] Na párovém srovnání kritérií mezi sebou
- [ ] Na průměru hodnocení všech dodavatelů
- [ ] Na seřazení kritérií podle výše ceny

> Ve Fullerově metodě se každá dvojice kritérií porovná a určí se důležitější; váha kritéria je podíl počtu jeho preferencí na celkovém počtu srovnání.

## Analýza zainteresovaných stran {#analyza-stakeholderu .explain}

Analýza zainteresovaných stran (stakeholder analysis) probíhá v krocích: 1) **identifikace** (brainstorming, kontrolní seznamy, dokumenty), 2) **analýza** zájmů, očekávání, vlivu a postoje k projektu, 3) **prioritizace** pomocí mřížek (moc–zájem, vliv–dopad) nebo **modelu významnosti** (salience model — moc, legitimita, naléhavost), 4) volba **strategie zapojení** a komunikace. Výsledky se zapisují do **registru zainteresovaných stran**. PMBOK dále používá **matici hodnocení zapojení**, která porovnává současnou (C) a požadovanou (D) úroveň zapojení: nevědomý, odporující, neutrální, podporující, vedoucí. Analýza se během projektu opakuje, protože zájmy i vliv se mění.

*Příklad:* U stavby obchvatu se identifikují obyvatelé, obec, kraj, ekologické spolky a dopravci; spolky mají vysoký zájem a mohou projekt zdržet námitkami, proto potřebují aktivní komunikaci.

### ? Které tři atributy používá model významnosti (salience model) k posouzení zainteresovaných stran?

- [ ] Čas, náklady a rozsah
- [ ] Vliv, zájem a rozpočet
- [ ] Silné stránky, slabé stránky a příležitosti
- [x] Moc, legitimita a naléhavost

> Model významnosti (Mitchell, Agle a Wood) třídí zainteresované strany podle moci, legitimity a naléhavosti jejich nároků.

### ? V matici hodnocení zapojení má ředitel IT současný stav „odporující" a požadovaný „podporující". Co z toho plyne?

- [ ] Ředitel IT nemá na projekt vliv a lze jej pominout
- [ ] Ředitele IT je nutné vyřadit z registru stran
- [x] Je třeba naplánovat kroky ke změně jeho postoje
- [ ] Žádná akce není potřeba, stav je vyhovující

> Rozdíl mezi současnou a požadovanou úrovní zapojení ukazuje, kde je nutné cíleně komunikovat a zapojovat, aby se odpor změnil v podporu.

## Matice moc–zájem {#matice-moc-zajem .compare}

Matice moc–zájem (power/interest grid, podle A. Mendelowa) řadí zainteresované strany podle jejich moci (vlivu) na projekt a zájmu o něj:

| | Nízký zájem | Vysoký zájem |
|---|---|---|
| **Vysoká moc** | **udržovat spokojené** (keep satisfied) | **úzce řídit, klíčoví hráči** (manage closely) |
| **Nízká moc** | **monitorovat** s minimálním úsilím (monitor) | **průběžně informovat** (keep informed) |

### ? Generální ředitel má na projekt velkou moc, ale o projekt se příliš nezajímá. Jakou strategii zvolíte?

- [ ] Úzce řídit jako klíčového hráče
- [ ] Průběžně informovat o všech detailech
- [ ] Jen monitorovat s minimálním úsilím
- [x] Udržovat spokojeného

> Vysoká moc + nízký zájem = udržovat spokojené: neobtěžovat detaily, ale zajistit, aby neměl důvod projekt blokovat.

### ? Místní občanské sdružení má o projekt vysoký zájem, ale malou moc. Jakou strategii zvolíte?

- [x] Průběžně informovat
- [ ] Udržovat spokojené
- [ ] Jen monitorovat s minimálním úsilím
- [ ] Zapojit do řídicího výboru projektu

> Nízká moc + vysoký zájem = průběžně informovat; dobrá informovanost předchází zbytečným konfliktům a sdružení může přinést užitečné podněty.
