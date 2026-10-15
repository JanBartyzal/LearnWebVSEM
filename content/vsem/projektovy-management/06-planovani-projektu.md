---
kind: topic
subject: projektovy-management
slug: planovani-projektu
name: "Plánování projektu"
order: 6
---

Časové a kapacitní plánování projektu. Členění projektů do fází. Definování činností. Strukturovaná dekompozice činností. Rozpad (dekompozice) projektu – W/OBS (Work/ Object Breakdown Structure). Definování logických vazeb. Rozvrhování činností v čase. Plánování nákladů. Plánování zdrojů. Rozpočet projektu - finanční a ekonomické aspekty řízení projektů.

## Časové a kapacitní plánování {#casove-kapacitni-planovani .explain}

**Časové plánování** určuje, *co* se bude dělat, *v jakém pořadí* a *kdy*. **Kapacitní plánování** k činnostem přiřazuje zdroje (lidi, stroje, materiál) a ověřuje, zda jsou v daném čase skutečně k dispozici. Typický postup časového plánování (PMBOK Guide):

1. definování činností,
2. stanovení logických vazeb mezi činnostmi,
3. odhad doby trvání činností,
4. sestavení harmonogramu.

Oba plány jsou provázané — termín je reálný jen tehdy, jsou-li v daném období k dispozici potřebné zdroje; při jejich nedostatku se harmonogram upravuje.

*Příklad:* Harmonogram počítá s dokončením analýzy za dva týdny, kapacitní plán však ukáže, že jediný analytik je v té době z poloviny vytížen jiným projektem — termín je nutné posunout nebo zajistit dalšího analytika.

### ? Jaké je správné pořadí kroků časového plánování?

- [ ] Odhad doby trvání → definování činností → vazby → harmonogram
- [x] Definování činností → vazby → odhad doby trvání → harmonogram
- [ ] Harmonogram → definování činností → odhad doby trvání → vazby
- [ ] Vazby → definování činností → harmonogram → odhad doby trvání

> Nejprve je nutné vědět, jaké činnosti projekt obsahuje, pak se určí jejich pořadí a doba trvání; harmonogram je až výsledkem těchto kroků.

### ? Co je hlavním úkolem kapacitního plánování?

- [ ] Stanovit logické pořadí činností projektu
- [ ] Rozdělit celý rozsah projektu do pracovních balíků
- [ ] Určit kritickou cestu projektu
- [x] Porovnat potřebu zdrojů s jejich dostupností

> Kapacitní plánování zjišťuje, kolik zdrojů činnosti v jednotlivých obdobích potřebují, a porovnává to s disponibilní kapacitou. Pořadí činností, WBS i kritická cesta jsou předmětem jiných kroků plánování.

## Členění projektu do fází {#faze-projektu .explain}

**Projektová fáze** je soubor logicky souvisejících činností, který končí dokončením jednoho nebo více výstupů (deliverables). Členění do fází zlepšuje řiditelnost: velký projekt se rozdělí na menší celky, které lze podrobněji naplánovat a kontrolovat. Na konci fáze se na **fázové bráně** (phase gate, stage gate) posoudí výsledky a rozhodne, zda projekt pokračuje, mění se, nebo končí. V PRINCE2 odpovídají tomuto členění **manažerské etapy** (management stages). S fázemi souvisí **klouzavé plánování** (rolling wave planning): blízká fáze se plánuje podrobně, vzdálenější jen hrubě a plán se postupně zpřesňuje.

*Příklad:* Stavba rodinného domu: projektová příprava → hrubá stavba → dokončovací práce → kolaudace. Podrobný harmonogram dokončovacích prací se zpracuje až v průběhu hrubé stavby.

### ? Co se typicky děje na fázové bráně?

- [x] Posoudí se výstupy fáze a rozhodne o pokračování projektu
- [ ] Projekt se formálně uzavře a výstupy se předají do provozu
- [ ] Jednorázově se přidělí zdroje všem činnostem do konce projektu
- [ ] Poprvé se sestaví WBS celého projektu

> Fázová brána je rozhodovací bod na konci fáze — hodnotí se dosažené výstupy a rozhoduje o pokračování. Formální uzavření a předání do provozu patří na konec celého projektu.

### ? Co vyjadřuje klouzavé plánování (rolling wave planning)?

- [ ] Celý projekt se hned na začátku podrobně naplánuje a plán se už nemění
- [ ] Harmonogram se pravidelně posouvá o stejný interval podle skutečného postupu
- [x] Blízké období se plánuje podrobně, vzdálené jen hrubě
- [ ] Plánuje se výhradně na fázových branách, mezi nimi se plán neupravuje

> Klouzavé plánování je forma postupného zpřesňování: práce v blízké budoucnosti se rozpracuje do detailu, vzdálenější práce zůstává na vyšší úrovni a zpřesní se, až bude více informací.

## Struktura rozpadu prací (WBS) {#wbs .term}

Struktura rozpadu prací (Work Breakdown Structure, **WBS**) je **hierarchický rozklad celkového rozsahu práce** projektu na menší, lépe řiditelné části, orientovaný na **výstupy** (deliverables). Nejnižší úroveň tvoří pracovní balíky. Spolu s popisem rozsahu a slovníkem WBS tvoří **výchozí plán rozsahu** (scope baseline).

### ? Na co je WBS primárně orientována?

- [ ] Na organizační útvary podílející se na projektu
- [ ] Na časovou posloupnost činností
- [x] Na výstupy (deliverables) projektu
- [ ] Na nákladová střediska organizace

> WBS rozkládá rozsah projektu podle výstupů, které je třeba vytvořit. Časovou posloupnost řeší harmonogram, organizační útvary organizační struktura projektu.

### ? Které dokumenty tvoří výchozí plán rozsahu (scope baseline)?

- [x] Popis rozsahu, WBS a slovník WBS
- [ ] Harmonogram, rozpočet a registr rizik
- [ ] WBS, matice odpovědnosti a seznam milníků
- [ ] Projektová charta, WBS a kapacitní plán

> Podle PMBOK Guide tvoří výchozí plán rozsahu schválený popis rozsahu projektu (scope statement), WBS a slovník WBS.

## Strukturovaná dekompozice {#dekompozice .explain}

Dekompozice postupuje **shora dolů** (top-down): celkový výstup projektu na nejvyšší úrovni se rozkládá na dílčí výstupy a ty dále, dokud nevzniknou části, které lze spolehlivě odhadnout, přidělit odpovědné osobě a kontrolovat. Členit lze podle produktů (komponent), podle fází životního cyklu nebo kombinovaně; v rámci jedné úrovně se doporučuje držet jednotný princip členění. Prvky se označují hierarchickým kódem (1, 1.1, 1.1.1 …). Míra podrobnosti je kompromis: příliš hrubý rozpad ztěžuje řízení, příliš jemný zbytečně zvyšuje administrativu.

*Příklad:* WBS e-shopu: 1 Řízení projektu · 2 Analýza · 3 Front-end (3.1 Katalog, 3.2 Košík, 3.3 Objednávka) · 4 Back-end · 5 Nasazení a školení.

### ? Kdy je vhodné dekompozici ukončit?

- [ ] Když WBS dosáhne předepsaných tří úrovní hierarchie
- [ ] Když každý prvek trvá nejvýše jeden pracovní den
- [ ] Když počet prvků odpovídá počtu členů týmu
- [x] Když části lze spolehlivě odhadnout a řídit

> Dekompozice končí na úrovni, kde lze pro části spolehlivě odhadnout náklady a dobu trvání, přidělit je a kontrolovat. Pevný počet úrovní ani délka prvku se obecně nepředepisují.

## Pravidlo 100 % {#pravidlo-100 .explain}

Pravidlo 100 % říká, že WBS zahrnuje **veškerou práci** definovanou rozsahem projektu — včetně práce na řízení projektu — a **nic navíc**. Na každé úrovni platí, že součet podřízených prvků představuje 100 % práce prvku nadřazeného. Práce, která ve WBS není, není součástí projektu. Pravidlo pomáhá předcházet opomenutí práce i nekontrolovanému rozšiřování rozsahu (scope creep).

*Příklad:* Prvek „Školení uživatelů" má podřízené prvky „Příprava materiálů" a „Realizace kurzů". Pokud rozsah zahrnuje i „Vyhodnocení kurzů" a ve WBS chybí, je pravidlo 100 % porušeno.

### ? Prvek WBS „Implementace" má tři podřízené prvky. Co musí podle pravidla 100 % platit?

- [ ] Každý podřízený prvek představuje třetinu práce
- [x] Společně pokrývají přesně celou jeho práci
- [ ] Mohou obsahovat i práci mimo rozsah projektu
- [ ] Alespoň jeden z nich musí být milník

> Součet podřízených prvků musí odpovídat 100 % práce nadřazeného prvku — nic nesmí chybět a nic nesmí přebývat. Rovnoměrné rozdělení práce pravidlo nepožaduje.

### ? Které tvrzení NEODPOVÍDÁ pravidlu 100 %?

- [ ] WBS obsahuje i práci na řízení projektu
- [ ] Práce, která není ve WBS, není součástí projektu
- [ ] Součet podřízených prvků odpovídá nadřazenému prvku
- [x] Do WBS se navíc zahrne práce mimo schválený rozsah

> Pravidlo 100 % vyžaduje veškerou práci v rozsahu a nic navíc. Zahrnutí práce mimo schválený rozsah by vedlo k rozšiřování rozsahu (scope creep).

## Pracovní balík (work package) {#pracovni-balik .term}

Pracovní balík (work package) je **nejnižší úroveň WBS**, pro kterou lze odhadnout a řídit náklady a dobu trvání. Má jednoznačně určeného odpovědného vlastníka a při plánování harmonogramu se dále rozkládá na činnosti. Pracovní balíky se pro sledování nákladů seskupují do kontrolních účtů (control accounts).

### ? Co je pracovní balík?

- [ ] Nejvyšší úroveň WBS reprezentující celý projekt
- [x] Nejnižší úroveň WBS, kterou lze odhadnout a řídit
- [ ] Soubor dokumentů předávaných zákazníkovi
- [ ] Skupina pracovníků přidělená na jednu fázi

> Pracovní balík leží na nejnižší úrovni WBS a lze pro něj odhadnout a řídit náklady i dobu trvání.

### ? Proč má mít každý pracovní balík jednoho odpovědného vlastníka?

- [ ] Aby se snížil počet činností v harmonogramu
- [ ] Protože to přímo vyžaduje pravidlo 100 %
- [x] Aby byla jasná odpovědnost za jeho dodání
- [ ] Aby nebylo nutné sestavovat slovník WBS

> Jednoznačný vlastník zajišťuje, že za dodání balíku někdo konkrétní odpovídá. Pravidlo 100 % se týká úplnosti rozsahu, nikoli odpovědnosti.

## Slovník WBS {#slovnik-wbs .term}

Slovník WBS (WBS dictionary) je dokument, který ke každému prvku WBS uvádí **podrobný popis**: identifikátor (kód), popis práce, odpovědnou osobu či útvar, milníky, odhad nákladů a potřebných zdrojů, požadavky na kvalitu a akceptační kritéria. Doplňuje grafickou WBS tak, aby obsah jednotlivých prvků nebyl vykládán nejednoznačně.

### ? Kterou informaci slovník WBS typicky NEOBSAHUJE?

- [x] Výkazy skutečně odpracovaných hodin
- [ ] Kód prvku a podrobný popis jeho práce
- [ ] Odpovědnou osobu nebo útvar
- [ ] Akceptační kritéria výstupu

> Slovník WBS je plánovací dokument popisující obsah prvků WBS. Skutečně odpracované hodiny vznikají až při realizaci a evidují se ve výkazech práce.

## W/OBS — WBS, OBS a matice odpovědnosti {#wbs-pbs-obs .compare}

Osnova uvádí rozpad projektu zkratkou **W/OBS**. Studijní texty VŠEM chápou **OBS** jako **Organisational Breakdown Structure** — organizační strukturu projektu (rozepsání „Object" v osnově je nepřesné). Rozpad projektu má tedy dvě osy: **co** se má udělat (WBS) a **kdo** to udělá (OBS). Jejich propojením vzniká **matice odpovědnosti** (Responsibility Assignment Matrix, RAM).

| Struktura | Co zachycuje | Použití |
|---|---|---|
| **WBS** (Work Breakdown Structure) | veškerou práci projektu rozloženou na dílčí výstupy a pracovní balíky | základ plánování rozsahu, času a nákladů |
| **OBS** (Organisational Breakdown Structure) | organizaci projektu rozloženou na útvary, týmy a role | určení nositelů práce a odpovědnosti |
| **WBS × OBS → RAM** | průsečíky pracovních balíků (řádky) a organizačních jednotek či rolí (sloupce) | přiřazení odpovědnosti za každý pracovní balík, např. ve formě RACI |

*Příklad:* Pracovní balík „Migrace dat" z WBS se v matici odpovědnosti přiřadí oddělení IT z OBS jako odpovědnému útvaru a účetnímu oddělení jako konzultovanému.

### ? Co vznikne propojením struktury členění prací (WBS) s organizační strukturou projektu (OBS)?

- [x] Matice odpovědnosti (RAM) k pracovním balíkům
- [ ] Síťový graf s logickými vazbami mezi činnostmi
- [ ] Výchozí plán nákladů rozložený do časových období
- [ ] Registr rizik s vlastníky jednotlivých rizik

> Křížením WBS (co se dělá) a OBS (kdo to dělá) vzniká matice odpovědnosti (RAM), která ke každému pracovnímu balíku určuje odpovědný útvar či roli.

### ? Co zobrazuje OBS (Organisational Breakdown Structure) projektu?

- [ ] Rozklad práce na pracovní balíky
- [ ] Posloupnost činností a jejich vazby
- [x] Organizační útvary a role odpovědné za práci
- [ ] Rozpad nákladů do časových období

> Organisational Breakdown Structure zachycuje organizaci projektu (útvary, týmy, role); propojením s WBS se v matici odpovědnosti určuje, kdo odpovídá za který pracovní balík.

## Činnost a milník {#cinnost-milnik .compare}

Při **definování činností** se pracovní balíky WBS dále rozkládají na činnosti; výstupem je seznam činností (activity list) s jejich atributy a seznam milníků.

| | Činnost (activity) | Milník (milestone) |
|---|---|---|
| Doba trvání | nenulová | **nulová** |
| Zdroje | spotřebovává (práce, materiál) | nespotřebovává |
| Význam | konkrétní práce vedoucí k vytvoření výstupu | významný okamžik — dokončení výstupu či fáze, rozhodnutí |
| Typická formulace | děj: „Naprogramovat modul fakturace" | dosažený stav: „Systém akceptován zákazníkem" |

### ? Jak vznikají činnosti při definování činností?

- [ ] Sloučením milníků do větších celků
- [x] Dekompozicí pracovních balíků WBS
- [ ] Odvozením z rozpočtu projektu
- [ ] Převzetím z organizační struktury firmy

> Činnosti vznikají dalším rozkladem pracovních balíků na konkrétní úkony, které je třeba provést k vytvoření výstupu balíku.

### ? Čím se milník liší od běžné činnosti?

- [ ] Spotřebovává nejvíce zdrojů v projektu
- [ ] Musí vždy ležet na kritické cestě
- [ ] Je vždy umístěn na konci projektu
- [x] Má nulovou dobu trvání

> Milník je významný okamžik v projektu, nikoli práce — proto má nulovou dobu trvání a nespotřebovává zdroje. Může ležet kdekoli v harmonogramu.

### ? Která položka je vhodnou formulací milníku?

- [ ] Programování modulu fakturace
- [x] Akceptace systému zákazníkem
- [ ] Testování uživatelského rozhraní
- [ ] Školení koncových uživatelů

> Akceptace systému je okamžik (dosažený stav) s nulovou dobou trvání. Ostatní položky popisují práci s nenulovou dobou trvání, tedy činnosti.

## Typy logických vazeb {#typy-vazeb .compare}

Logické vazby mezi předchůdcem a následníkem se v síťovém diagramu typu „činnost v uzlu" (metoda předcházejících vztahů, PDM) vyjadřují čtyřmi typy:

| Vazba | Význam | Příklad |
|---|---|---|
| **FS** — konec–začátek (Finish-to-Start) | následník může začít až po dokončení předchůdce; **nejčastější** typ | omítání stěny lze zahájit až po dokončení zdění |
| **SS** — začátek–začátek (Start-to-Start) | následník může začít až po zahájení předchůdce | pokládka kabelů může začít, až začne hloubení výkopu |
| **FF** — konec–konec (Finish-to-Finish) | následník může skončit až po dokončení předchůdce | uživatelskou dokumentaci lze dokončit až po dokončení vývoje |
| **SF** — začátek–konec (Start-to-Finish) | následník může skončit až po zahájení předchůdce; **nejvzácnější** typ | provoz starého systému může skončit až po spuštění nového |

### ? Testování nemůže skončit dříve, než skončí vývoj, ale obě činnosti mohou běžet souběžně. O jaký typ vazby jde?

- [x] FF (konec–konec)
- [ ] FS (konec–začátek)
- [ ] SS (začátek–začátek)
- [ ] SF (začátek–konec)

> Omezení se týká konců obou činností: následník (testování) smí skončit až po skončení předchůdce (vývoje). To je vazba konec–konec.

### ? Který typ vazby se v harmonogramech používá nejčastěji?

- [ ] SS (začátek–začátek)
- [ ] SF (začátek–konec)
- [ ] FF (konec–konec)
- [x] FS (konec–začátek)

> Nejběžnější je vazba konec–začátek, kdy následník začíná po dokončení předchůdce. Vazba SF je naopak nejvzácnější.

### ? Starý informační systém smí být odstaven až poté, co se spustí nový. Jaký typ vazby to je (následníkem je provoz starého systému)?

- [ ] FS (konec–začátek)
- [ ] FF (konec–konec)
- [x] SF (začátek–konec)
- [ ] SS (začátek–začátek)

> Konec následníka (provoz starého systému) závisí na zahájení předchůdce (spuštění nového systému) — jde o vazbu začátek–konec.

## Předstih a zpoždění (lead a lag) {#lead-lag .explain}

Předstih a zpoždění upřesňují logickou vazbu. **Zpoždění** (lag) je povinná čekací doba mezi předchůdcem a následníkem, zapisuje se např. jako FS + 3 dny. **Předstih** (lead) naopak umožňuje následníkovi začít dříve, než by vazba jinak dovolila; zapisuje se jako záporné zpoždění, např. FS − 2 dny. Zpoždění není činnost a nespotřebovává zdroje. Vazby mohou být **povinné** (vyplývají z povahy práce), **volitelné** (dané osvědčenou praxí nebo preferencí týmu) nebo **externí** (závislost na okolí projektu).

*Příklad:* Po betonáži základové desky musí beton zrát 7 dní → FS + 7 dní. Malíři mohou začít v hotových místnostech 2 dny před dokončením omítek v celém patře → FS − 2 dny.

### ? Po nátěru musí barva 2 dny schnout, než lze pokládat podlahu. Jak to v harmonogramu vyjádříte?

- [ ] Předstihem FS − 2 dny
- [ ] Samostatným milníkem s dobou trvání 2 dny
- [x] Zpožděním FS + 2 dny
- [ ] Vazbou SF bez zpoždění

> Povinná čekací doba mezi koncem předchůdce a začátkem následníka je zpoždění (lag). Milník má nulovou dobu trvání, předstih by práci naopak překryl.

### ? Který výrok o předstihu (lead) je správný?

- [ ] Prodlužuje dobu trvání předchůdce
- [ ] Je to samostatná činnost, která spotřebovává zdroje
- [ ] Lze jej použít výhradně u vazby SF
- [x] Umožňuje dřívější zahájení následníka

> Předstih zkracuje odstup mezi činnostmi — následník může začít, ještě než předchůdce skončí (zápis jako záporné zpoždění). Nejde o činnost a nemění dobu trvání předchůdce.

## Odhad doby trvání činností {#odhad-doby-trvani .explain}

Odhad doby trvání (duration) určuje počet pracovních období potřebných k dokončení činnosti. Je třeba odlišit **pracnost** (effort, např. 20 člověkodnů) od **doby trvání** (např. 10 dní při dvou pracovnících). Vztah není vždy lineární — přidání lidí nemusí dobu úměrně zkrátit kvůli koordinaci a zaučení. Používá se expertní odhad, odhad analogií, parametrický odhad nebo tříbodový odhad (optimistický, nejpravděpodobnější a pesimistický; výpočet viz PERT v tématu Metody). Odhad by měl dávat ten, kdo práci provede nebo ji dobře zná.

*Příklad:* Instalace 40 pracovních stanic po 2 hodinách = 80 hodin pracnosti; dva technici po 8 hodinách denně ji zvládnou za 5 pracovních dní.

### ? Činnost má pracnost 30 člověkodnů a pracují na ní 3 lidé na plný úvazek. Jaká je přibližná doba trvání?

- [x] 10 pracovních dní
- [ ] 30 pracovních dní
- [ ] 90 pracovních dní
- [ ] 3 pracovní dny

> Doba trvání ≈ pracnost / počet pracovníků = 30 / 3 = 10 pracovních dní (za předpokladu, že práci lze rovnoměrně rozdělit).

### ? Proč nelze dobu trvání vždy zkrátit na polovinu zdvojnásobením počtu lidí?

- [ ] Pracnost činnosti se přidáním lidí automaticky snižuje
- [x] Roste potřeba koordinace a zaučení nových lidí
- [ ] Doba trvání na počtu pracovníků vůbec nezávisí
- [ ] Odhad doby trvání se po schválení nesmí měnit

> Více lidí znamená více komunikace, zaučování a práce, kterou nelze dělit. Pracnost tím spíše roste, a doba trvání se proto nezkrátí úměrně.

## Harmonogram a kalendáře {#harmonogram-kalendare .explain}

**Harmonogram** (project schedule) stanoví u každé činnosti plánovaný začátek a konec. Vychází ze seznamu činností, logických vazeb, odhadů doby trvání, kalendářů a dostupnosti zdrojů (výpočet metodou kritické cesty a zobrazení Ganttovým diagramem viz téma Metody). **Kalendář projektu** určuje pracovní dny a směny (víkendy, svátky); **kalendář zdrojů** určuje dostupnost konkrétních lidí a strojů (dovolené, částečné úvazky). Schválený harmonogram se stává **výchozím plánem harmonogramu** (schedule baseline), se kterým se porovnává skutečný postup.

*Příklad:* Činnost s dobou trvání 5 pracovních dní zahájená ve čtvrtek skončí při pracovním týdnu Po–Pá až ve středu následujícího týdne.

### ? Činnost s dobou trvání 5 pracovních dní začne ve čtvrtek ráno, kalendář je Po–Pá bez svátků. Kdy skončí?

- [ ] V pondělí následujícího týdne
- [ ] V úterý následujícího týdne
- [ ] Ve čtvrtek následujícího týdne
- [x] Ve středu následujícího týdne

> Pracovní dny jsou čtvrtek, pátek, pondělí, úterý a středa — víkend se nepočítá, činnost tedy skončí ve středu.

### ? Co zachycuje kalendář zdrojů?

- [ ] Termíny milníků dohodnuté se zákazníkem
- [ ] Pořadí činností podle logických vazeb
- [x] Kdy jsou konkrétní lidé a stroje k dispozici
- [ ] Plán čerpání rozpočtu po měsících

> Kalendář zdrojů eviduje dostupnost jednotlivých zdrojů (dovolené, úvazky, servisní odstávky strojů) a harmonogram jej musí respektovat.

## Druhy nákladů projektu {#druhy-nakladu .compare}

| Hledisko | Druh | Popis | Příklad |
|---|---|---|---|
| přiřaditelnost | **přímé** | lze je přímo přiřadit projektu či činnosti | mzdy členů týmu, materiál, subdodávky |
| přiřaditelnost | **nepřímé** (režijní) | sdílené více projekty, do projektu se rozpouštějí přirážkou nebo klíčem | nájem kanceláří, administrativa, IT podpora |
| závislost na objemu | **fixní** | nemění se s objemem vykonané práce | paušální pronájem zařízení, licence |
| závislost na objemu | **variabilní** | rostou s objemem práce či výstupů | spotřebovaný materiál, práce placená po hodinách |

### ? Do které kategorie patří nájem kanceláří, které sdílí několik projektů firmy?

- [ ] Přímé náklady
- [x] Nepřímé (režijní) náklady
- [ ] Variabilní náklady
- [ ] Mimořádné náklady

> Nájem sdílených kanceláří nelze přímo přiřadit jednomu projektu, rozpouští se do projektů jako režie — jde o nepřímé náklady.

### ? Náklady na materiál při pokládce dlažby rostou s počtem m². O jaké náklady jde?

- [x] Variabilní
- [ ] Fixní
- [ ] Nepřímé
- [ ] Utopené

> Náklady, které rostou s objemem práce či výstupů, jsou variabilní. Fixní náklady se s objemem nemění.

## Metody odhadu nákladů {#odhady-nakladu .compare}

| Metoda | Princip | Přesnost a pracnost | Typické použití |
|---|---|---|---|
| **Analogický odhad** (top-down) | vychází ze skutečných nákladů podobného dřívějšího projektu | nižší přesnost, rychlý a levný | rané fáze, málo podrobných informací |
| **Parametrický odhad** | statistický vztah mezi parametrem a náklady (např. Kč/m², Kč/funkční bod) | přesnost závisí na kvalitě dat a modelu | opakovatelné, dobře měřitelné práce |
| **Odhad zdola nahoru** (bottom-up) | odhadnou se pracovní balíky či činnosti a sečtou do vyšších úrovní WBS | nejvyšší přesnost, časově náročný | podrobně rozpracovaná WBS |

### ? Rozpočtář vynásobí plánovanou plochu budovy 2 000 m² průměrnou cenou 35 000 Kč/m². Jaký typ odhadu použil?

- [x] Parametrický odhad
- [ ] Odhad zdola nahoru
- [ ] Analogický odhad
- [ ] Tříbodový odhad

> Náklady se odvozují ze statistického vztahu mezi parametrem (plochou) a jednotkovou cenou — to je parametrický odhad.

### ? Která metoda odhadu nákladů je zpravidla nejpřesnější, ale zároveň nejpracnější?

- [ ] Analogický odhad
- [x] Odhad zdola nahoru
- [ ] Parametrický odhad
- [ ] Odhad shora dolů

> Odhad zdola nahoru vychází z podrobného ocenění pracovních balíků či činností, proto je nejpřesnější, ale vyžaduje rozpracovanou WBS a hodně času.

### ? Kdy je analogický odhad nákladů nejvhodnější?

- [ ] Když je WBS rozpracována až na úroveň činností
- [ ] Když jsou známy přesné jednotkové ceny všech prací
- [x] Na začátku projektu, kdy chybí podrobné informace
- [ ] Při sestavování výchozího plánu nákladů před realizací

> Analogický odhad je rychlý a nevyžaduje detail, proto se hodí v raných fázích. Při rozpracované WBS je vhodnější přesnější odhad zdola nahoru.

## Kapacitní plán a histogram zdrojů {#kapacitni-plan .explain}

**Kapacitní plán** (plán zdrojů) určuje, jaké zdroje a v jakém množství budou v jednotlivých obdobích potřeba, a porovnává je s dostupnou kapacitou. Potřeba se zjistí přiřazením zdrojů činnostem harmonogramu a sečtením po obdobích. Výsledek se zobrazuje **histogramem zdrojů** (resource histogram) — sloupcovým grafem potřeby zdroje v čase, často s čarou dostupné kapacity. Sloupce nad touto čarou ukazují **přetížení** (overallocation), které je nutné vyřešit.

*Příklad:* Tým má 3 testery, ale harmonogram v 6. týdnu vyžaduje 5 testerů — histogram ukáže přetížení o 2 osoby.

### ? Co zobrazuje histogram zdrojů?

- [ ] Logické vazby mezi činnostmi
- [ ] Kumulované náklady projektu v čase
- [ ] Hierarchii pracovních balíků
- [x] Potřebu zdroje v jednotlivých obdobích

> Histogram zdrojů je sloupcový graf potřeby (vytížení) zdroje v čase; kumulované náklady zobrazuje S-křivka, hierarchii balíků WBS.

### ? Sloupec histogramu zdroje v 8. týdnu přesahuje čáru dostupné kapacity. Co to znamená?

- [ ] Zdroj je v tomto týdnu nevyužit
- [x] Zdroj je v tomto týdnu přetížen
- [ ] Činnosti v 8. týdnu leží mimo kritickou cestu
- [ ] Projekt v tomto týdnu překročil rozpočet

> Potřeba zdroje převyšuje jeho dostupnou kapacitu, jde tedy o přetížení, které se řeší např. vyrovnáním zdrojů.

## Vyrovnání a vyhlazení zdrojů {#vyrovnani-vyhlazeni .compare}

Obě techniky optimalizace zdrojů řeší nerovnoměrné nebo nadměrné vytížení zdrojů, liší se dopadem na termíny.

| | Vyrovnání zdrojů (resource leveling) | Vyhlazení zdrojů (resource smoothing) |
|---|---|---|
| Cíl | odstranit přetížení, respektovat omezenou kapacitu | rovnoměrnější čerpání zdrojů při zachování termínů |
| Posun činností | i nad rámec časových rezerv | jen v rámci volné a celkové rezervy |
| Dopad na konec projektu | konec se může posunout, může se změnit kritická cesta | termín konce ani kritická cesta se nemění |
| Kdy se použije | zdroj je omezený a nelze jej navýšit | termín je pevný, cílem je plynulejší vytížení |

### ? Projekt má pevný termín a manažer chce jen rovnoměrněji vytížit programátory bez posunu konce projektu. Kterou techniku zvolí?

- [ ] Vyrovnání zdrojů
- [ ] Odhad zdola nahoru
- [ ] Klouzavé plánování
- [x] Vyhlazení zdrojů

> Vyhlazení zdrojů posouvá činnosti jen v rámci jejich časových rezerv, takže termín konce zůstává. Vyrovnání by mohlo projekt prodloužit.

### ? Jaký důsledek může mít vyrovnání zdrojů?

- [ ] Snížení pracnosti činností na kritické cestě
- [ ] Zvýšení dostupné kapacity zdrojů
- [x] Prodloužení projektu a změnu kritické cesty
- [ ] Zrušení logických vazeb mezi činnostmi

> Vyrovnání zdrojů posouvá činnosti podle dostupnosti zdrojů i mimo rezervy, takže se konec projektu může posunout a kritická cesta změnit.

## Rozpočet a výchozí plán nákladů {#rozpocet .explain}

Rozpočet projektu vzniká agregací odhadů nákladů zdola nahoru (činnosti → pracovní balíky → kontrolní účty → projekt) a jejich rozložením v čase. Schválený časově rozložený rozpočet **bez manažerské rezervy** je **výchozí plán nákladů** (cost baseline); zahrnuje kontingenční rezervy (rezervy na nepředvídané události). V kumulované podobě má zpravidla tvar **S-křivky**. Celkový rozpočet projektu = výchozí plán nákladů + manažerská rezerva. Výchozí plán nákladů je základem pro sledování nákladů (metoda vydělané hodnoty viz téma Metody).

*Příklad:* Odhady pracovních balíků 8 mil. Kč + kontingenční rezervy 0,8 mil. Kč = výchozí plán nákladů 8,8 mil. Kč; po přičtení manažerské rezervy 0,5 mil. Kč činí rozpočet projektu 9,3 mil. Kč.

### ? Co zahrnuje výchozí plán nákladů (cost baseline)?

- [x] Odhady nákladů a kontingenční rezervy, bez manažerské rezervy
- [ ] Odhady nákladů a manažerskou rezervu, bez kontingenčních rezerv
- [ ] Jen odhady nákladů pracovních balíků bez jakýchkoli rezerv
- [ ] Odhady nákladů, obě rezervy a zisk dodavatele

> Podle PMBOK Guide obsahuje výchozí plán nákladů odhady nákladů včetně kontingenčních rezerv; manažerská rezerva je až součástí celkového rozpočtu.

### ? Proč má kumulovaný výchozí plán nákladů typicky tvar S-křivky?

- [ ] Náklady jsou rozloženy rovnoměrně po celou dobu projektu
- [ ] Manažerská rezerva se čerpá až na konci projektu
- [x] Čerpání zrychluje uprostřed projektu a ke konci slábne
- [ ] Nepřímé náklady převažují nad přímými

> Na začátku a na konci projektu probíhá méně prací než v jeho středu, proto kumulované náklady rostou nejprve pomalu, pak rychle a nakonec opět pomalu.

### ? Odhady nákladů činí 10 mil. Kč, kontingenční rezervy 1 mil. Kč a manažerská rezerva 0,5 mil. Kč. Jaký je výchozí plán nákladů?

- [ ] 10 mil. Kč
- [ ] 10,5 mil. Kč
- [ ] 11,5 mil. Kč
- [x] 11 mil. Kč

> Výchozí plán nákladů = odhady + kontingenční rezervy = 11 mil. Kč. Po přičtení manažerské rezervy vychází celkový rozpočet 11,5 mil. Kč.

## Kontingenční a manažerská rezerva {#rezervy .compare}

| | Kontingenční rezerva (contingency reserve) | Manažerská rezerva (management reserve) |
|---|---|---|
| Kryje | identifikovaná rizika — „známé neznámé" (known unknowns) | neidentifikovaná rizika a nepředvídanou práci v rozsahu — „neznámé neznámé" (unknown unknowns) |
| Součást výchozího plánu nákladů | ano | ne, je jen v celkovém rozpočtu |
| Kdo o čerpání rozhoduje | projektový manažer v rámci schválených pravidel | vedení organizace / sponzor; čerpání mění výchozí plán |
| Stanovení | z analýzy rizik (např. procentem z odhadu, očekávanou hodnotou) | zpravidla procentem z rozpočtu podle politiky organizace |

### ? Během realizace nastane riziko, které bylo zapsáno v registru rizik. Z které rezervy se mají dopady krýt?

- [ ] Z manažerské rezervy
- [x] Z kontingenční rezervy
- [ ] Z rezervy na kritické cestě
- [ ] Ze zisku dodavatele

> Identifikovaná rizika („známé neznámé") kryje kontingenční rezerva, která je součástí výchozího plánu nákladů.

### ? Která rezerva NENÍ součástí výchozího plánu nákladů?

- [x] Manažerská rezerva
- [ ] Kontingenční rezerva
- [ ] Rezerva na identifikovaná rizika
- [ ] Rezerva odvozená z analýzy rizik

> Manažerská rezerva je mimo výchozí plán nákladů, je jen součástí celkového rozpočtu. Ostatní možnosti popisují kontingenční rezervu.

### ? Kdo obvykle schvaluje čerpání manažerské rezervy?

- [ ] Kterýkoli člen projektového týmu
- [ ] Vlastník pracovního balíku
- [ ] Projektový manažer samostatně
- [x] Vedení organizace nebo sponzor

> Manažerská rezerva je pod kontrolou vedení či sponzora; její čerpání znamená změnu výchozího plánu nákladů a prochází řízením změn.

## Cash-flow a financování projektu {#cash-flow .explain}

Finanční řízení projektu sleduje nejen výši nákladů, ale i jejich **časování**. **Cash-flow** (peněžní tok) projektu je přehled příjmů a výdajů v čase; z kumulovaného cash-flow se určí **potřeba financování** a období, kdy je nutné zajistit peníze (vlastní zdroje, úvěr, dotace, zálohy od zákazníka). Náklady a výdaje se časově nemusí shodovat — např. materiál se zaplatí dříve, než se spotřebuje. Je-li financování omezené, může být nutné upravit harmonogram. Ekonomické hodnocení posuzuje, zda se projekt vyplatí, např. dobou návratnosti nebo čistou současnou hodnotou (NPV), která zohledňuje časovou hodnotu peněz.

*Příklad:* Stavební dodavatel platí subdodavatele měsíčně, ale zákazník platí až po dokončení etap — záporné kumulované cash-flow v mezidobí musí dodavatel krýt např. kontokorentním úvěrem.

### ? Proč nestačí znát jen celkový rozpočet a je třeba plánovat i cash-flow?

- [ ] Cash-flow nahrazuje výchozí plán nákladů
- [ ] Cash-flow určuje logické vazby mezi činnostmi
- [x] Je nutné zajistit peníze ve chvíli, kdy jsou potřeba
- [ ] Bez cash-flow nelze sestavit WBS projektu

> Cash-flow ukazuje, kdy vznikají příjmy a výdaje, a tedy kdy a kolik peněz musí být k dispozici. Rozpočet sám o sobě časování plateb neřeší.

### ? Který ukazatel ekonomického hodnocení projektu zohledňuje časovou hodnotu peněz?

- [ ] Prostá doba návratnosti
- [x] Čistá současná hodnota (NPV)
- [ ] Celkový rozpočet projektu
- [ ] Prostý součet ročních přínosů

> Čistá současná hodnota diskontuje budoucí peněžní toky na současnou hodnotu. Prostá doba návratnosti ani prostý součet přínosů diskontování nepoužívají.
