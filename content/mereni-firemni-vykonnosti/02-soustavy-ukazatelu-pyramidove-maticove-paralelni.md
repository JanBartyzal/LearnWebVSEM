---
kind: topic
subject: mereni-firemni-vykonnosti
slug: soustavy-ukazatelu-pyramidove-maticove-paralelni
name: "Soustavy ukazatelů (pyramidové, maticové, paralelní)"
order: 2
---

Typy vazeb mezi jednotlivými ukazateli v rámci soustavy (aditivní, multiplikativní, kombinované) a matematicko-statistický aparát sloužící k jejich vyjádření (metoda řetězového dosazování, logaritmická metoda, funkcionální metoda), typy vazeb nefinančních ukazatelů (logická vazba).

## Soustava ukazatelů {#soustava-ukazatelu .term}

**Soustava ukazatelů** je uspořádaný soubor ukazatelů, mezi nimiž existují definované vazby (matematické, statistické nebo logické), a který popisuje výkonnost či finanční situaci podniku komplexněji než jednotlivé izolované ukazatele. Jediný ukazatel zachytí jen jeden aspekt a může být zavádějící (např. vysoká likvidita na úkor rentability); soustava umožňuje hodnotit ukazatele v souvislostech a dohledávat příčiny změn. Více ukazatelů zpřesňuje obraz, ale snižuje přehlednost — dobrá soustava hledá rozumný kompromis.

### ? Proč se výkonnost podniku hodnotí soustavou ukazatelů, a ne jediným ukazatelem?

- [ ] Jednotlivé ukazatele nelze z účetních výkazů spočítat
- [ ] Soustava ukazatelů nepotřebuje srovnávací základnu
- [x] Jediný ukazatel zachytí jen jeden aspekt a může klamat
- [ ] Soustava obsahuje výhradně nefinanční ukazatele

> Izolovaný ukazatel popisuje jen jednu stránku hospodaření — např. vysoká likvidita může skrývat nízkou rentabilitu. Soustava ukazuje ukazatele ve vzájemných souvislostech; srovnávací základnu potřebuje stejně jako jednotlivý ukazatel.

### ? Co obecně platí o počtu ukazatelů v soustavě?

- [x] Více ukazatelů zpřesní obraz, ale sníží přehlednost
- [ ] Čím více ukazatelů, tím je soustava vždy lepší
- [ ] Soustava musí obsahovat přesně čtyři ukazatele
- [ ] Počet ukazatelů nemá na použitelnost soustavy vliv

> Rostoucí počet ukazatelů přináší podrobnější informace, ale soustava se stává nepřehlednou a ukazatele se mohou překrývat či si odporovat. Hledá se kompromis mezi úplností a přehledností.

## Členění soustav ukazatelů {#cleneni-soustav .compare}

Soustavy se člení podle uspořádání ukazatelů a podle typu vazby mezi nimi:

| Hledisko | Druh | Charakteristika |
|---|---|---|
| Uspořádání | **pyramidová** (hierarchická) | vrcholový ukazatel se postupně rozkládá na dílčí ukazatele nižších úrovní |
| Uspořádání | **paralelní** | skupiny rovnocenných ukazatelů stojí vedle sebe, každá popisuje jinou oblast |
| Uspořádání | **maticová** | ukazatele se třídí podle dvou hledisek do řádků a sloupců matice |
| Vazba | **matematická** (deterministická) | přesná rovnice — aditivní, multiplikativní nebo kombinovaná vazba |
| Vazba | **statistická** (empirická) | výběr ukazatelů (u vícerozměrných modelů i jejich váhy) plyne ze statistického zpracování dat — diskriminační analýza u bankrotních modelů (Altman, IN95, jednorozměrně Beaver) a u bonitního indexu IN99; expertní bodové modely (Kralickův Quick test, Tamariho model) sem nepatří (viz téma Alternativní modely) |
| Vazba | **logická** (příčinná) | věcná souvislost příčina → důsledek bez rovnice, typicky u nefinančních ukazatelů |

Pyramidové soustavy stojí na matematických vazbách, paralelní soustavy sdružují ukazatele bez vzájemné matematické vazby.

### ? Bankrotní model sčítá vážené poměrové ukazatele, jejichž výběr a váhy byly odvozeny diskriminační analýzou dat zdravých a zbankrotovaných podniků. Jaký typ vazby v něm převažuje?

- [ ] Matematická — ukazatele jsou rozkladem jednoho vrcholového ukazatele
- [x] Statistická — výběr ukazatelů i jejich váhy plynou z dat
- [ ] Logická — ukazatele tvoří řetězec příčin a důsledků
- [ ] Aditivní — ukazatele se sčítají bez jakýchkoli vah

> Bankrotní modely (a bonitní index IN99) jsou účelově sestavené soustavy: ukazatele a jejich váhy určila statistická (diskriminační) analýza, nikoli matematický rozklad. Součet vážených ukazatelů je jen způsob, jak je spojit do jednoho skóre. Expertní bodové modely (Quick test, Tamari) naopak stojí na odborně zvolených ukazatelích a stupnicích.

### ? Ve které soustavě lze odchylku vrcholového ukazatele přesně rozložit na vlivy dílčích ukazatelů?

- [ ] V paralelní soustavě rovnocenných skupin ukazatelů
- [ ] V soustavě s logickými vazbami nefinančních ukazatelů
- [ ] V bankrotním modelu sestaveném diskriminační analýzou
- [x] V pyramidové soustavě s matematickými vazbami

> Kvantifikovat vlivy dílčích ukazatelů lze jen tam, kde je vrcholový ukazatel přesnou funkcí dílčích (aditivní či multiplikativní vazba) — to splňuje pyramidová soustava.

## Pyramidová soustava ukazatelů {#pyramidova-soustava .explain}

**Pyramidová (hierarchická) soustava** má na vrcholu jeden souhrnný ukazatel — typicky rentabilitu (ROE, ROA, ROI) nebo EVA — který se postupně rozkládá na ukazatele nižších úrovní. Každý ukazatel vyšší úrovně je **přesnou matematickou funkcí** ukazatelů nižší úrovně:

- **multiplikativní rozklad** (součin, podíl) — např. ROA = EBIT / A = (EBIT / T) · (T / A), tj. provozní zisková marže · obrat aktiv,
- **aditivní rozklad** (součet, rozdíl) — např. aktiva = dlouhodobý majetek + oběžná aktiva + ostatní aktiva, EBIT = tržby − náklady.

Pyramida ukazuje, **které dílčí faktory** změnu vrcholového ukazatele způsobily, a umožňuje je vyčíslit metodami analýzy odchylek. Ukazatele nižších úrovní lze přidělit útvarům, které je ovlivňují (řízení podle odpovědnosti), a pyramidu použít i k plánování („co se stane, když…"). Omezením je, že zachycuje jen kvantifikovatelné, převážně finanční a minulé veličiny.

*Příklad:* EBIT 3 000, tržby 40 000, aktiva 25 000 tis. Kč → provozní zisková marže 3 000 / 40 000 = 7,5 %, obrat aktiv 40 000 / 25 000 = 1,6 → ROA = 7,5 % · 1,6 = 12 % (kontrola: 3 000 / 25 000 = 12 %).

### ? Platí ROA = (EBIT / T) · (T / A). ROA podniku je 12 % a obrat aktiv 1,5. Jaká je provozní zisková marže EBIT / T?

- [ ] 18 %
- [ ] 10,5 %
- [x] 8 %
- [ ] 12,5 %

> EBIT / T = ROA / obrat aktiv = 12 % / 1,5 = 8 %. Hodnota 18 % vznikne násobením, 10,5 % odečtením a 12,5 % převrácením poměru (1,5 / 12).

### ? Proč se pyramidová soustava hodí k řízení podle odpovědnosti?

- [ ] Vrcholový ukazatel lze vypočítat bez účetních dat
- [x] Dílčí ukazatele lze přidělit útvarům, které je ovlivňují
- [ ] Pyramida obsahuje jen nefinanční ukazatele útvarů
- [ ] Pyramida odstraňuje závislost výsledku na cenách

> Rozklad vrcholového ukazatele vede k dílčím ukazatelům (nákladovost, obrat zásob, doba inkasa…), za které odpovídají konkrétní útvary. Zlepšení na nižší úrovni se přes matematické vazby promítne do vrcholového ukazatele.

## Du Pontova pyramida a další pyramidové soustavy {#du-pont-pyramida .explain}

Nejznámější pyramidová soustava vznikla počátkem 20. století v chemickém koncernu **Du Pont**. Vrcholovým ukazatelem je **rentabilita investovaného kapitálu (ROI)**, rozložená na dvě větve:

- **ziskovost tržeb** (zisk / tržby) — dále na tržby a náklady (a jejich druhy),
- **obrat aktiv** (tržby / aktiva) — dále na tržby a aktiva, aktiva na dlouhodobý majetek a oběžná aktiva (zásoby, pohledávky, peněžní prostředky).

ROI = ziskovost tržeb · obrat aktiv. Rozšířením o finanční páku (aktiva / VK) vzniká Du Pontova rovnice pro ROE (podrobně téma Klasické modely). Z pyramidy je vidět, že stejné rentability lze dosáhnout vysokou marží při pomalém obratu (např. strojírenství), nebo nízkou marží při rychlém obratu (obchod). Na Du Pontův rozklad navázaly další pyramidové soustavy, např. německá soustava **ZVEI** s vrcholovým ukazatelem rentability vlastního kapitálu.

*Příklad:* Tržby 50 000, náklady 46 000 → zisk 4 000; dlouhodobý majetek 18 000 + oběžná aktiva 14 000 = aktiva 32 000 tis. Kč. Ziskovost tržeb 8 %, obrat aktiv 50 000 / 32 000 = 1,5625 → ROI = 0,08 · 1,5625 = 12,5 % (kontrola: 4 000 / 32 000 = 12,5 %).

### ? Ziskovost tržeb podniku je 8 % a obrat aktiv 1,5. Podnik zrychlí obrat aktiv na 1,8 při nezměněné ziskovosti tržeb. Jak se změní ROI podle Du Pontova rozkladu?

- [ ] +0,3 p. b. (z 12 % na 12,3 %)
- [ ] +3,6 p. b. (z 12 % na 15,6 %)
- [ ] +1,2 p. b. (z 12 % na 13,2 %)
- [x] +2,4 p. b. (z 12 % na 14,4 %)

> ROI = ziskovost tržeb · obrat aktiv: 8 % · 1,5 = 12 %, 8 % · 1,8 = 14,4 %, změna +2,4 p. b. (= 8 % · 0,3). Hodnota +0,3 je jen změna obratu, +3,6 vznikne vynásobením 12 · 0,3.

### ? Ve které větvi Du Pontovy pyramidy se projeví nárůst zásob při nezměněných tržbách a zisku a jak ovlivní ROI?

- [x] Ve větvi obratu aktiv — obrat klesne, ROI se sníží
- [ ] Ve větvi ziskovosti tržeb — marže klesne, ROI se sníží
- [ ] Ve větvi obratu aktiv — obrat vzroste, ROI se zvýší
- [ ] V žádné — zásoby nejsou součástí rozkladu ROI

> Zásoby jsou součástí oběžných aktiv, a tedy jmenovatele obratu aktiv (tržby / aktiva). Vyšší aktiva při stejných tržbách obrat zpomalí a při stejné ziskovosti tržeb sníží ROI.

## Paralelní soustava ukazatelů {#paralelni-soustava .explain}

**Paralelní soustava** sdružuje **rovnocenné skupiny ukazatelů**, které stojí vedle sebe a každá charakterizuje jinou oblast hospodaření — typicky rentabilitu, aktivitu, likviditu, zadluženost a ukazatele kapitálového trhu. Mezi skupinami **není matematická vazba**, vrcholový ukazatel neexistuje. Zvláštním případem jsou **účelově vybrané soustavy** — bankrotní a bonitní modely (viz téma Alternativní modely). Bankrotní modely (Altman, IN95) a bonitní index IN99 spojují statisticky vybrané ukazatele vahami do jednoho skóre; expertní bodové bonitní modely (Kralickův Quick test, Tamariho model) sčítají body přidělené ukazatelům podle stupnic.

- **Výhody:** komplexní pohled na různé stránky podniku, jednoduchost, snadné srovnání s oborem.
- **Nevýhody:** nevysvětlí příčinné vztahy mezi oblastmi a neumožní vyčíslit vliv jednoho ukazatele na jiný; ukazatele si mohou odporovat, takže je nutné souhrnné hodnocení (bodování, vážení, pořadí).

*Příklad:* Podnik má rentabilitu nad oborovým průměrem, likviditu pod ním a vysokou zadluženost. Paralelní soustava ukáže tento profil, ale nevyčíslí, nakolik k vyšší rentabilitě přispělo zadlužení.

### ? Které tvrzení o paralelní soustavě ukazatelů platí?

- [ ] Všechny ukazatele jsou rozkladem jednoho vrcholového ukazatele
- [ ] Skupiny ukazatelů jsou seřazeny podle důležitosti do hierarchie
- [x] Skupiny ukazatelů jsou rovnocenné a matematicky nesouvisejí
- [ ] Ukazatele jsou spojeny výhradně logickými vazbami

> Paralelní soustava staví vedle sebe rovnocenné skupiny ukazatelů (rentabilita, likvidita, zadluženost…), mezi nimiž není matematický vztah. Hierarchický rozklad je znakem pyramidové soustavy.

### ? Analytik hodnotí podnik pěti skupinami poměrových ukazatelů: rentabilita je výborná, likvidita slabá. Co mu tato paralelní soustava NEUMOŽNÍ?

- [ ] Srovnat jednotlivé ukazatele s oborovým průměrem
- [ ] Zjistit, které oblasti hospodaření jsou slabé
- [ ] Sestavit souhrnné bodové hodnocení podniku
- [x] Vyčíslit, jak likvidita ovlivnila rentabilitu

> Mezi skupinami paralelní soustavy chybí matematická vazba, takže vliv jedné oblasti na druhou nelze kvantifikovat. Srovnání s oborem, identifikace slabin i bodové hodnocení jsou naopak běžné.

## Maticová soustava ukazatelů {#maticova-soustava .explain}

V **maticové soustavě** se ukazatele třídí podle **dvou hledisek** současně — řádky a sloupce matice představují např. oblasti výkonnosti a typ ukazatele, případně organizační útvary. Každé pole matice obsahuje ukazatele dané kombinace. Přínosem je **kontrola vyváženosti a úplnosti**: prázdné pole ukazuje oblast, kterou podnik neměří. Vzájemné vazby mezi ukazateli matice sama nevyjadřuje.

Známým příkladem je **Performance Measurement Matrix** (Keegan, Eiler a Jones, 1989) — matice 2 × 2, která kombinuje hlediska **nákladové × nenákladové** (finanční × nefinanční) a **interní × externí** ukazatele:

| | Nákladové | Nenákladové |
|---|---|---|
| **Interní** | náklady na jednotku výkonu | doba průběhu zakázky, počet nových výrobků |
| **Externí** | náklady ve srovnání s konkurencí | spokojenost zákazníků, podíl na trhu |

*Příklad:* Podnik sleduje jen náklady a zisk (nákladová pole). Matice odhalí, že chybí nenákladové externí ukazatele, např. spokojenost zákazníků — tedy předstihová informace o budoucích tržbách.

### ? Do kterého pole matice ukazatelů členěné na nákladové × nenákladové a interní × externí patří spokojenost zákazníků?

- [ ] Interní nákladové
- [x] Externí nenákladové
- [ ] Interní nenákladové
- [ ] Externí nákladové

> Spokojenost zákazníků není peněžní (nákladový) ukazatel a měří vnímání podniku zvenčí — patří do pole externích nenákladových ukazatelů.

### ? Jaký je hlavní přínos maticového uspořádání ukazatelů?

- [ ] Umožňuje přesně vyčíslit vliv faktorů na vrcholový ukazatel
- [ ] Nahrazuje statistický výběr ukazatelů v bankrotních modelech
- [ ] Odstraňuje potřebu srovnávat ukazatele s oborovým průměrem
- [x] Ukazuje, zda soustava pokrývá všechny kombinace hledisek

> Matice třídí ukazatele podle dvou hledisek; prázdné pole odhalí neměřenou oblast, a matice tak podporuje vyváženost soustavy. Vazby mezi ukazateli ani vlivy faktorů nevyjadřuje.

## Typy vazeb mezi ukazateli {#typy-vazeb .compare}

Matematické vazby v soustavě ukazatelů jsou tří typů:

| Vazba | Obecný tvar | Příklad | Rozklad odchylky |
|---|---|---|---|
| **Aditivní** | y = a + b − c (součet, rozdíl) | EBIT = tržby − náklady; aktiva = DM + OA + ostatní aktiva | vliv složky = její změna (odčítaná složka s opačným znaménkem); bez zbytku, nezávisle na pořadí |
| **Multiplikativní — součin** | y = a · b · c | tržby = Q · p; ROA = (EBIT / T) · (T / A) | speciální metody (postupné změny, rozklad se zbytkem, logaritmická, funkcionální) — vzniká společný vliv faktorů |
| **Multiplikativní — podíl** | y = a / b | ROA = EBIT / A; produktivita = výkony / počet pracovníků | jako součin y = a · (1 / b) |
| **Kombinovaná** | y = a / (b + c), y = (a − b) · c | ROA = EBIT / (DM + OA) | multiplikativní metoda pro součtovou složku jako celek, pak její vliv rozdělit mezi sčítance |

DM = dlouhodobý majetek, OA = oběžná aktiva.

### ? Ukazatel je definován jako ROA = EBIT / (dlouhodobý majetek + oběžná aktiva). Jaký typ vazby představuje?

- [ ] Čistě aditivní vazbu
- [ ] Čistě multiplikativní vazbu
- [ ] Logickou vazbu
- [x] Kombinovanou vazbu

> Jmenovatel je součtem (aditivní vazba) a celý ukazatel podílem (multiplikativní vazba) — spojení obou je kombinovaná vazba.

### ? Proč u aditivní vazby nevzniká problém nerozloženého zbytku?

- [ ] Protože aditivní vazba obsahuje vždy jen dva faktory
- [x] Změna součtu je přesně rovna součtu změn složek
- [ ] Protože složky součtu se nikdy nemění současně
- [ ] Protože se u ní používá logaritmická metoda

> U y = a + b platí Δy = Δa + Δb — složky se nenásobí, takže nevzniká žádný společný vliv. U součinu y = a · b naopak přibývá člen Δa · Δb.

## Analýza odchylek a vlivu faktorů {#analyza-vlivu-faktoru .explain}

**Analýza odchylek (vlivu faktorů)** rozkládá změnu ukazatele y mezi základním (index 0 — plán, minulé období) a sledovaným obdobím (index 1) na příspěvky jednotlivých faktorů.

- absolutní odchylka Δy = y₁ − y₀, index I_y = y₁ / y₀, relativní změna R_y = I_y − 1 = Δy / y₀,
- požadavek úplnosti: **součet vlivů všech faktorů = Δy**,
- **aditivní vazba**: vliv složky = její absolutní změna; u odčítané složky (náklady) s opačným znaménkem,
- vlivy lze vyjádřit absolutně nebo jako podíl na celkové odchylce (v %).

*Příklad:* EBIT = T − VN − FN (VN variabilní, FN fixní náklady). Tržby 10 000 → 11 000, VN 6 000 → 6 800, FN 2 500 → 2 400 tis. Kč; EBIT 1 500 → 1 800, Δ = +300. Vliv tržeb +1 000, vliv VN −800, vliv FN +100; součet +300.

### ? EBIT = tržby − variabilní náklady − fixní náklady. Tržby vzrostly z 10 000 na 11 000, variabilní náklady z 6 000 na 6 800 a fixní náklady klesly z 2 500 na 2 400 tis. Kč. Jaké jsou vlivy jednotlivých složek na změnu EBIT?

- [ ] Tržby +1 000, variabilní náklady +800, fixní náklady −100
- [ ] Tržby +1 000, variabilní náklady −800, fixní náklady −100
- [x] Tržby +1 000, variabilní náklady −800, fixní náklady +100
- [ ] Tržby +300, variabilní náklady −800, fixní náklady +100

> Aditivní vazba: vliv tržeb = +1 000; růst nákladů zisk snižuje, vliv VN = −800; pokles FN zisk zvyšuje, vliv FN = +100. Součet +300 = 1 800 − 1 500 tis. Kč.

### ? Jakou podmínku musí splňovat výsledek rozkladu odchylky ukazatele na vlivy faktorů?

- [x] Součet vlivů všech faktorů se rovná celkové odchylce
- [ ] Vliv každého faktoru musí být kladný
- [ ] Vlivy všech faktorů musí být stejně velké
- [ ] Součet vlivů se rovná hodnotě ukazatele v základu

> Rozklad musí být úplný: Σ vlivů = Δy = y₁ − y₀. Vlivy mohou mít různá znaménka i velikosti — jeden faktor může odchylku zvyšovat a jiný snižovat.

## Společný vliv (zbytek) u multiplikativní vazby {#spolecny-vliv .explain}

U součinu y = a · b nelze celou odchylku jednoznačně přiřadit jednotlivým faktorům. Platí:

`Δy = a₁ · b₁ − a₀ · b₀ = Δa · b₀ + a₀ · Δb + Δa · Δb`

První dva členy jsou „čisté" vlivy faktorů (změna jednoho při základní hodnotě druhého), třetí člen **Δa · Δb** je **společný (kombinovaný) vliv** obou faktorů — tzv. **zbytek**. Metody analýzy odchylek se liší právě tím, jak se zbytkem naloží: metoda postupných změn ho přiřadí později dosazenému faktoru, rozklad se zbytkem ho vykáže samostatně, funkcionální metoda ho rozdělí rovným dílem, logaritmická v poměru logaritmů indexů. Zbytek je malý, když se faktory mění málo; při velkých změnách obou faktorů roste.

*Příklad:* Tržby: 1 000 ks · 200 Kč = 200 000 Kč → 1 250 ks · 240 Kč = 300 000 Kč, Δ = +100 000 Kč. Δa · b₀ = 250 · 200 = 50 000; a₀ · Δb = 1 000 · 40 = 40 000; společný vliv Δa · Δb = 250 · 40 = 10 000 Kč.

### ? Výkony = počet pracovníků · produktivita práce. Počet pracovníků klesl z 50 na 45, produktivita vzrostla z 600 na 700 tis. Kč na pracovníka. Jaký je společný vliv obou faktorů (Δa · Δb)?

- [ ] +500 tis. Kč
- [x] −500 tis. Kč
- [ ] −250 tis. Kč
- [ ] +1 500 tis. Kč

> Δa · Δb = (45 − 50) · (700 − 600) = −5 · 100 = −500 tis. Kč. Kontrola: Δy = 31 500 − 30 000 = 1 500 = −3 000 (Δa · b₀) + 5 000 (a₀ · Δb) − 500. Hodnota −250 je polovina zbytku, +1 500 celková odchylka.

### ? Kdy je společný vliv (zbytek) u multiplikativní vazby dvou faktorů zanedbatelný?

- [ ] Když se oba faktory mění o velká procenta
- [ ] Když jeden faktor roste a druhý klesá
- [ ] Když je ukazatel vyjádřen v peněžních jednotkách
- [x] Když jsou relativní změny faktorů malé

> Zbytek Δa · Δb je součinem dvou změn; při malých relativních změnách je řádově menší než čisté vlivy. Při velkých změnách obou faktorů roste a volba metody výsledek výrazně ovlivní.

## Metoda postupných změn (řetězového dosazování) {#postupne-zmeny .explain}

**Metoda postupných změn** (řetězového dosazování, řetězové substituce) nahrazuje ve výchozím vztahu **postupně, jeden po druhém**, základní hodnoty faktorů skutečnými. Vliv faktoru = výsledek po jeho dosazení − výsledek před ním; již dosazené faktory zůstávají ve skutečné výši, dosud nedosazené v základní. Součet vlivů se rovná celkové odchylce.

Pro dva faktory y = a · b (pořadí a, b): `vliv a = Δa · b₀`, `vliv b = a₁ · Δb`.
Pro tři faktory y = a · b · c: `vliv a = Δa · b₀ · c₀`, `vliv b = a₁ · Δb · c₀`, `vliv c = a₁ · b₁ · Δc`.

Metoda je jednoduchá a názorná, ale **nerozkládá společný vliv** — ten skrytě připadne faktorům dosazeným později, a výsledek proto **závisí na pořadí** dosazování.

*Příklad:* Plán 800 ks · 1 500 Kč = 1 200 000 Kč, skutečnost 900 ks · 1 450 Kč = 1 305 000 Kč, Δ = +105 000 Kč. Vliv objemu = 100 · 1 500 = +150 000 Kč, vliv ceny = 900 · (−50) = −45 000 Kč; součet +105 000 Kč.

### ? Tržby = Q · p. Plán: 4 000 ks po 250 Kč, skutečnost: 4 400 ks po 240 Kč. Jaké jsou vlivy faktorů metodou postupných změn (nejprve objem, pak cena)?

- [ ] Objem +96 000 Kč, cena −40 000 Kč
- [ ] Objem +100 000 Kč, cena −40 000 Kč
- [ ] Objem +98 000 Kč, cena −42 000 Kč
- [x] Objem +100 000 Kč, cena −44 000 Kč

> Tržby 1 000 000 → 1 056 000 Kč, Δ = +56 000. Vliv objemu = (4 400 − 4 000) · 250 = +100 000; vliv ceny = 4 400 · (240 − 250) = −44 000; součet +56 000. Dvojice +96 000 / −40 000 odpovídá opačnému pořadí, +98 000 / −42 000 funkcionální metodě; +100 000 / −40 000 nedává v součtu celkovou odchylku.

### ? Výkony = počet strojů · hodiny provozu na stroj · hodinový výkon. Základ: 10 strojů · 4 000 h · 2,0 tis. Kč/h; skutečnost: 12 strojů · 3 800 h · 2,1 tis. Kč/h. Jaký je vliv změny hodin provozu metodou postupných změn (pořadí: stroje, hodiny, výkon)?

- [x] −4 800 tis. Kč
- [ ] −4 000 tis. Kč
- [ ] −5 040 tis. Kč
- [ ] +4 560 tis. Kč

> Vliv hodin = 12 · (3 800 − 4 000) · 2,0 = −4 800 tis. Kč (stroje už skutečné, výkon ještě základní). Kontrola: stroje 2 · 4 000 · 2,0 = +16 000, výkon 12 · 3 800 · 0,1 = +4 560; součet +15 760 = 95 760 − 80 000. Hodnota −4 000 použije základní počet strojů, −5 040 skutečný hodinový výkon.

## Závislost na pořadí dosazování {#poradi-faktoru .explain}

Při jiném pořadí dosazování vycházejí v metodě postupných změn **jiné velikosti dílčích vlivů** (jejich součet je stále stejný). U dvou faktorů se faktor dosazený jako **první** oceňuje základní hodnotou druhého (Δa · b₀), faktor dosazený jako **druhý** skutečnou hodnotou prvního — a dostane tak i **celý společný vliv** Δa · Δb.

Pořadí se proto stanoví předem a dodržuje se: obvykle od **extenzivních (objemových, kvantitativních)** faktorů k **intenzivním (kvalitativním, cenovým)** — nejprve objem či počet, pak cena či výkonnost. Nejednoznačnost je hlavní slabinou metody; odstraňují ji logaritmická a funkcionální metoda.

*Příklad:* Plán 800 ks · 1 500 Kč, skutečnost 900 ks · 1 450 Kč. Pořadí objem → cena: +150 000 a −45 000 Kč. Pořadí cena → objem: vliv ceny = 800 · (−50) = −40 000 Kč, vliv objemu = 100 · 1 450 = +145 000 Kč. Součet je v obou případech +105 000 Kč.

### ? Tržby = Q · p. Plán: 4 000 ks po 250 Kč, skutečnost: 4 400 ks po 240 Kč. Jaký je vliv ceny metodou postupných změn, dosadí-li se nejprve cena a teprve pak objem?

- [ ] −44 000 Kč
- [ ] −42 000 Kč
- [x] −40 000 Kč
- [ ] +56 000 Kč

> Cena se dosazuje první, oceňuje se tedy plánovaným objemem: 4 000 · (240 − 250) = −40 000 Kč. Vliv objemu je pak 400 · 240 = +96 000 Kč, součet +56 000. Hodnota −44 000 platí pro pořadí objem → cena.

### ? Kterému faktoru přiřadí metoda postupných změn u dvou faktorů společný vliv Δa · Δb?

- [ ] Faktoru, který se dosazuje jako první
- [x] Faktoru, který se dosazuje jako druhý
- [ ] Oběma faktorům rovným dílem
- [ ] Žádnému, vykáže ho jako samostatný zbytek

> Druhý faktor se oceňuje skutečnou hodnotou prvního: a₁ · Δb = a₀ · Δb + Δa · Δb, takže obsahuje i celý společný vliv. Rovné dělení odpovídá funkcionální metodě, samostatný zbytek metodě rozkladu se zbytkem.

## Metoda rozkladu se zbytkem {#rozklad-se-zbytkem .explain}

**Metoda rozkladu se zbytkem** mění vždy **jen jeden faktor**, ostatní ponechává v základní výši:

`vliv aᵢ = Δaᵢ · (ostatní faktory v základní výši) = y₀ · Rᵢ`, kde Rᵢ = Δaᵢ / aᵢ₀ je relativní změna faktoru.

Rozdíl mezi celkovou odchylkou a součtem vlivů se vykáže **samostatně jako nerozložený zbytek** (společný vliv faktorů). Metoda **nezávisí na pořadí** a je průhledná, ale část odchylky zůstává nevysvětlená — při velkých změnách faktorů může být zbytek značný.

*Příklad:* Tržby 1 000 ks · 200 Kč → 1 250 ks · 240 Kč, Δ = +100 000 Kč. Vliv objemu = 250 · 200 = 50 000 Kč (= 200 000 · 0,25), vliv ceny = 1 000 · 40 = 40 000 Kč (= 200 000 · 0,20), zbytek = 100 000 − 50 000 − 40 000 = 10 000 Kč.

### ? Tržby = Q · p. Základ: 2 000 ks po 500 Kč, skutečnost: 2 400 ks po 450 Kč. Jaký je výsledek metody rozkladu se zbytkem?

- [ ] Objem +200 000, cena −120 000, zbytek 0 Kč
- [ ] Objem +190 000, cena −110 000, zbytek 0 Kč
- [ ] Objem +180 000, cena −100 000, zbytek 0 Kč
- [x] Objem +200 000, cena −100 000, zbytek −20 000 Kč

> Tržby 1 000 000 → 1 080 000 Kč, Δ = +80 000. Vliv objemu = 400 · 500 = +200 000, vliv ceny = 2 000 · (−50) = −100 000, zbytek = 400 · (−50) = −20 000; součet +80 000. Ostatní dvojice jsou výsledky postupných změn (oběma pořadími) a funkcionální metody.

### ? Tržby v základním období činily 500 000 Kč, prodané množství vzrostlo o 8 % a cena o 5 %. Jaký je vliv množství metodou rozkladu se zbytkem?

- [x] +40 000 Kč
- [ ] +42 000 Kč
- [ ] +65 000 Kč
- [ ] +25 000 Kč

> Vliv množství = y₀ · R_Q = 500 000 · 0,08 = +40 000 Kč (cena ponechána v základní výši). Hodnota 42 000 = 500 000 · 0,08 · 1,05 by ocenila změnu skutečnou cenou (postupné změny s cenou dosazenou dříve), 25 000 je vliv ceny.

## Logaritmická metoda {#logaritmicka-metoda .explain}

**Logaritmická metoda** vychází z toho, že index součinu je součinem indexů: I_y = I_a · I_b, a po zlogaritmování ln I_y = ln I_a + ln I_b. Odchylka se rozdělí v poměru logaritmů indexů:

`vliv aᵢ = (ln I_aᵢ / ln I_y) · Δy`

Na základu logaritmu nezáleží (podíl logaritmů je stejný pro ln i log). Metoda je **bez zbytku** a **nezávislá na pořadí** — společný vliv rozdělí v poměru logaritmů indexů. Omezení: všechny hodnoty musí být **kladné** (index záporného či nulového ukazatele nelze logaritmovat) a **index ukazatele nesmí být 1** (ln 1 = 0 → dělení nulou). Výsledky se zaokrouhlují; po zaokrouhlení se kontroluje, že součet vlivů dává Δy.

*Příklad:* Tržby 1 000 ks · 200 Kč → 1 250 ks · 240 Kč, Δ = +100 000 Kč; I_Q = 1,25, I_p = 1,2, I_T = 1,5. ln 1,25 ≈ 0,2231, ln 1,2 ≈ 0,1823, ln 1,5 ≈ 0,4055. Vliv objemu ≈ 0,5503 · 100 000 ≈ +55 034 Kč, vliv ceny ≈ 0,4497 · 100 000 ≈ +44 966 Kč (podíly z nezaokrouhlených logaritmů, výsledky zaokrouhleny na Kč).

### ? Tržby = Q · p. Plán: 4 000 ks po 250 Kč, skutečnost: 4 400 ks po 240 Kč. Jaké jsou vlivy faktorů logaritmickou metodou (zaokrouhleno na Kč)?

- [ ] Objem +100 000 Kč, cena −44 000 Kč
- [x] Objem +97 955 Kč, cena −41 955 Kč
- [ ] Objem +98 000 Kč, cena −42 000 Kč
- [ ] Objem +96 000 Kč, cena −40 000 Kč

> I_Q = 1,1, I_p = 0,96, I_T = 1,056, Δ = +56 000 Kč. Vliv objemu = ln 1,1 / ln 1,056 · 56 000 ≈ 0,09531 / 0,05449 · 56 000 ≈ 1,7492 · 56 000 ≈ +97 955 Kč; vliv ceny = ln 0,96 / ln 1,056 · 56 000 ≈ −0,7492 · 56 000 ≈ −41 955 Kč. Ostatní dvojice dávají postupné změny (obě pořadí) a funkcionální metoda.

### ? ROA = ROS · obrat aktiv. ROS vzrostla z 5 % na 6 %, obrat aktiv klesl z 2,0 na 1,8, ROA tak vzrostla z 10 % na 10,8 %. Jaké jsou vlivy faktorů logaritmickou metodou (zaokrouhleno na tisíciny p. b.)?

- [ ] ROS +2,000 p. b., obrat aktiv −1,200 p. b.
- [ ] ROS +1,800 p. b., obrat aktiv −1,000 p. b.
- [ ] ROS +1,900 p. b., obrat aktiv −1,100 p. b.
- [x] ROS +1,895 p. b., obrat aktiv −1,095 p. b.

> I_ROS = 1,2, I_obrat = 0,9, I_ROA = 1,08. Vliv ROS = ln 1,2 / ln 1,08 · 0,8 ≈ 0,18232 / 0,07696 · 0,8 ≈ +1,895 p. b.; vliv obratu = ln 0,9 / ln 1,08 · 0,8 ≈ −0,10536 / 0,07696 · 0,8 ≈ −1,095 p. b.; součet +0,8. Hodnoty +2,0 / −1,2 a +1,8 / −1,0 dávají postupné změny, +1,9 / −1,1 funkcionální metoda.

### ? EBIT vzrostl z 1 200 na 1 500 tis. Kč, aktiva z 10 000 na 12 500 tis. Kč. Proč nelze změnu ROA = EBIT / A rozložit logaritmickou metodou?

- [ ] Logaritmická metoda se nedá použít pro podílovou vazbu
- [ ] Indexy EBIT i aktiv jsou větší než 1
- [x] ROA se nezměnila, index je 1 a jeho logaritmus nula
- [ ] EBIT a aktiva mají odlišné měrné jednotky

> ROA = 12 % v obou obdobích (1 200 / 10 000 = 1 500 / 12 500), I_ROA = 1 a ln 1 = 0 — ve vzorci by se dělilo nulou. Podílovou vazbu logaritmická metoda zvládá (ln I_y = ln I_a − ln I_b).

## Funkcionální metoda {#funkcionalni-metoda .explain}

**Funkcionální metoda** rozkládá odchylku **beze zbytku** a **nezávisle na pořadí** tak, že společný vliv faktorů dělí mezi zúčastněné faktory **rovným dílem** (její výsledky odpovídají tzv. integrální metodě). Pro dva faktory y = a · b:

`vliv a = Δa · b₀ + ½ · Δa · Δb = Δa · (b₀ + b₁) / 2`
`vliv b = a₀ · Δb + ½ · Δa · Δb = Δb · (a₀ + a₁) / 2`

Ekvivalentně přes relativní změny: vliv a = y₀ · (R_a + ½ · R_a · R_b) = (Δy / R_y) · (R_a + ½ · R_a · R_b). U tří faktorů se společné vlivy dvojic dělí na poloviny a společný vliv všech tří na třetiny. Metodu lze na rozdíl od logaritmické použít i při záporných hodnotách nebo nulové změně ukazatele.

*Příklad:* Tržby 1 000 ks · 200 Kč → 1 250 ks · 240 Kč, Δ = +100 000 Kč. Vliv objemu = 250 · (200 + 240) / 2 = +55 000 Kč, vliv ceny = 40 · (1 000 + 1 250) / 2 = +45 000 Kč; součet +100 000 Kč (logaritmická metoda dává podobně ≈ 55 034 a 44 966 Kč).

### ? Tržby = Q · p. Základ: 2 000 ks po 500 Kč, skutečnost: 2 400 ks po 450 Kč. Jaké jsou vlivy faktorů funkcionální metodou?

- [ ] Objem +200 000 Kč, cena −120 000 Kč
- [x] Objem +190 000 Kč, cena −110 000 Kč
- [ ] Objem +180 000 Kč, cena −100 000 Kč
- [ ] Objem +200 000 Kč, cena −100 000 Kč

> Δ = 1 080 000 − 1 000 000 = +80 000 Kč. Vliv objemu = 400 · (500 + 450) / 2 = +190 000; vliv ceny = −50 · (2 000 + 2 400) / 2 = −110 000; součet +80 000. Společný vliv −20 000 se rozdělil na poloviny.

### ? Podnik měl v základním období ztrátu a ve sledovaném období zisk. Kterou metodu zvolí analytik, potřebuje-li rozklad bez zbytku a nezávislý na pořadí faktorů?

- [x] Funkcionální metodu
- [ ] Metodu postupných změn
- [ ] Logaritmickou metodu
- [ ] Metodu rozkladu se zbytkem

> Záporný ukazatel v základu znemožní logaritmickou metodu (index by byl záporný). Postupné změny závisejí na pořadí a rozklad se zbytkem ponechá nerozložený zbytek; podmínky splní jen funkcionální metoda.

## Rozklad podílové vazby {#podilova-vazba .explain}

Podíl y = a / b se rozkládá jako součin y = a · (1 / b). Při **postupných změnách** (nejprve čitatel, pak jmenovatel):

`vliv a = a₁ / b₀ − a₀ / b₀`, `vliv b = a₁ / b₁ − a₁ / b₀`

Při **logaritmické metodě** platí ln I_y = ln I_a − ln I_b, takže vliv a = (ln I_a / ln I_y) · Δy a vliv b = (−ln I_b / ln I_y) · Δy. Růst jmenovatele (např. aktiv) má na ukazatel záporný vliv.

*Příklad:* ROA = EBIT / A; EBIT 1 200 → 1 560, aktiva 10 000 → 12 000 tis. Kč; ROA 12 % → 13 %, Δ = +1 p. b. Postupné změny: vliv EBIT = 1 560 / 10 000 − 12 % = 15,6 % − 12 % = +3,6 p. b.; vliv aktiv = 13 % − 15,6 % = −2,6 p. b.

### ? ROA = EBIT / A. EBIT vzrostl z 1 200 na 1 560 tis. Kč, aktiva z 10 000 na 12 000 tis. Kč, ROA z 12 % na 13 %. Jaké jsou vlivy logaritmickou metodou (zaokrouhleno na setiny p. b.)?

- [x] EBIT +3,28 p. b., aktiva −2,28 p. b.
- [ ] EBIT +3,60 p. b., aktiva −2,60 p. b.
- [ ] EBIT +3,00 p. b., aktiva −2,00 p. b.
- [ ] EBIT +2,28 p. b., aktiva −1,28 p. b.

> I_EBIT = 1,3, I_A = 1,2, I_ROA = 13 / 12 ≈ 1,0833. Vliv EBIT = ln 1,3 / ln 1,0833 · 1 ≈ 0,26236 / 0,08004 ≈ +3,28 p. b.; vliv aktiv = −ln 1,2 / ln 1,0833 ≈ −0,18232 / 0,08004 ≈ −2,28 p. b.; součet +1,00. Dvojice +3,6 / −2,6 a +3,0 / −2,0 dávají postupné změny.

### ? Produktivita = výkony / počet pracovníků. Výkony vzrostly z 36 000 na 40 800 tis. Kč, počet pracovníků z 60 na 64. Jaký je vliv počtu pracovníků metodou postupných změn (nejprve výkony, pak počet pracovníků)?

- [ ] −37,5 tis. Kč na pracovníka
- [x] −42,5 tis. Kč na pracovníka
- [ ] +37,5 tis. Kč na pracovníka
- [ ] −80,0 tis. Kč na pracovníka

> Produktivita 600 → 637,5 tis. Kč, Δ = +37,5. Vliv výkonů = 40 800 / 60 − 600 = 680 − 600 = +80; vliv pracovníků = 637,5 − 680 = −42,5; součet +37,5. Hodnota −37,5 platí pro opačné pořadí (36 000 / 64 − 600).

## Rozklad kombinované vazby {#kombinovana-vazba .explain}

U **kombinované vazby**, např. y = a / (b + c), se postupuje ve dvou krocích:

1. Součtová složka (b + c) se bere jako **jeden faktor** a odchylka y se rozloží zvolenou multiplikativní metodou na vliv a a vliv (b + c).
2. Vliv (b + c) se rozdělí mezi sčítance **v poměru jejich změn**: `vliv b = Δb / (Δb + Δc) · vliv (b + c)`, obdobně pro c.

Analogicky se rozkládají i jiné kombinace, např. y = (a − b) · c.

*Příklad:* ROA = EBIT / (DM + OA). EBIT 1 200 → 1 560, DM 6 000 → 6 500, OA 4 000 → 5 500 tis. Kč (aktiva 10 000 → 12 000). Postupnými změnami: vliv EBIT +3,6 p. b., vliv aktiv −2,6 p. b. Ten se rozdělí v poměru 500 : 1 500 → vliv DM = 0,25 · (−2,6) = −0,65 p. b., vliv OA = 0,75 · (−2,6) = −1,95 p. b.

### ? ROA = EBIT / (DM + OA). EBIT vzrostl z 2 000 na 2 200 tis. Kč, dlouhodobý majetek z 12 000 na 12 500 a oběžná aktiva z 8 000 na 9 500 tis. Kč. Vliv aktiv na ROA vyšel metodou postupných změn −1 p. b. Jaký je vliv oběžných aktiv?

- [ ] −0,25 p. b.
- [ ] −1,00 p. b.
- [x] −0,75 p. b.
- [ ] −0,50 p. b.

> ΔDM = 500, ΔOA = 1 500, ΔA = 2 000. Vliv OA = 1 500 / 2 000 · (−1) = −0,75 p. b., vliv DM = −0,25 p. b. (ROA 10 % → 10 %: vliv EBIT 2 200 / 20 000 − 10 % = +1 p. b., vliv aktiv −1 p. b.). Hodnota −0,50 odpovídá chybnému dělení rovným dílem.

### ? Jak se v kombinované vazbě y = a / (b + c) rozdělí vliv součtové složky (b + c) na její sčítance?

- [x] V poměru změn sčítanců Δb : Δc
- [ ] Rovným dílem mezi b a c
- [ ] V poměru základních hodnot b₀ : c₀
- [ ] Celý vliv připadne většímu sčítanci

> Vliv součtu se rozdělí podle toho, jak se který sčítanec na změně součtu podílel: vliv b = Δb / (Δb + Δc) · vliv (b + c).

## Srovnání metod analýzy odchylek {#srovnani-metod .compare}

U aditivní vazby je rozklad jednoznačný (vliv = změna složky). U multiplikativní vazby se metody liší naložením se společným vlivem:

| Metoda | Společný vliv (zbytek) | Závislost na pořadí | Poznámka / omezení |
|---|---|---|---|
| **Postupných změn** (řetězového dosazování) | skrytě připadne později dosazeným faktorům | **ano** | jednoduchá; pořadí nutno stanovit předem (extenzivní → intenzivní) |
| **Rozkladu se zbytkem** | vykázán samostatně, nerozložen | ne | při velkých změnách velký nevysvětlený zbytek |
| **Logaritmická** | rozdělen v poměru logaritmů indexů | ne | jen kladné hodnoty, index ukazatele ≠ 1; výsledky se zaokrouhlují |
| **Funkcionální** (integrální) | rozdělen rovným dílem | ne | použitelná i pro záporné hodnoty; u více faktorů pracnější |

Při malých změnách faktorů dávají všechny metody podobné výsledky; rozdíly se projeví při velkých změnách.

### ? Která metoda NEZÁVISÍ na pořadí faktorů, ale část odchylky ponechá nevysvětlenou?

- [x] Metoda rozkladu se zbytkem
- [ ] Metoda postupných změn
- [ ] Logaritmická metoda
- [ ] Funkcionální metoda

> Rozklad se zbytkem mění vždy jen jeden faktor (proto nezávisí na pořadí) a společný vliv vykáže jako nerozložený zbytek. Logaritmická i funkcionální metoda zbytek rozdělí, postupné změny závisejí na pořadí.

### ? Kdy se výsledky metody postupných změn, logaritmické a funkcionální metody od sebe liší nejvíce?

- [ ] Když se mění jen jeden z faktorů
- [x] Když se oba faktory výrazně změní
- [ ] Když jde o aditivní vazbu ukazatelů
- [ ] Když jsou všechny hodnoty kladné

> Rozdíly vznikají jen v rozdělení společného vlivu Δa · Δb, který je velký při výrazných změnách obou faktorů. Mění-li se jen jeden faktor, je společný vliv nulový a metody se shodují; u aditivní vazby problém nevzniká.

## Logická vazba nefinančních ukazatelů {#logicka-vazba .explain}

Nefinanční ukazatele (spokojenost zákazníků, kvalita, doba dodání, fluktuace, počet zlepšovacích návrhů) obvykle **nelze spojit rovnicí** s finančními ukazateli. Mezi nimi je **logická (příčinná, kauzální) vazba**: předpoklad, že zlepšení příčiny vede — často se **zpožděním** — ke zlepšení důsledku. Taková vazba se zachycuje jako **řetězec příčin a důsledků**, strom nebo strategická mapa (viz téma Balanced Scorecard) a její síla se může **ověřovat statisticky** (korelace, regrese na časových řadách) — odhaduje se, nepočítá přesně. Rizikem je domnělá kauzalita, nejisté zpoždění a souběh více příčin. Odchylku proto nelze rozložit metodami analýzy odchylek.

*Příklad:* Školení obsluhy → méně vad a reklamací → vyšší spokojenost zákazníků → více opakovaných nákupů → růst tržeb. Účinek na tržby se projeví až po několika měsících a nelze ho přesně vyčíslit rovnicí.

### ? Jaká vazba je typicky mezi mírou fluktuace zaměstnanců a spokojeností zákazníků?

- [ ] Aditivní
- [ ] Multiplikativní
- [x] Logická (příčinná)
- [ ] Kombinovaná

> Mezi fluktuací a spokojeností zákazníků neexistuje rovnice; předpokládá se příčinná souvislost (zkušení stálí pracovníci obsluhují lépe). Jde o logickou vazbu, kterou lze nanejvýš statisticky ověřit.

### ? Proč nelze změnu tržeb rozložit metodou postupných změn na vliv spokojenosti zákazníků a vliv kvality výrobků?

- [ ] Metoda postupných změn se používá jen pro nefinanční ukazatele
- [ ] Spokojenost i kvalita se mění vždy ve stejném směru
- [x] Mezi těmito ukazateli a tržbami není matematická rovnice
- [ ] Tržby nejsou absolutním ukazatelem

> Metody analýzy odchylek vyžadují přesnou matematickou vazbu (součet, součin, podíl). Spokojenost a kvalita působí na tržby jen logicky (příčinně) a se zpožděním, jejich vliv lze nanejvýš odhadnout statisticky.
