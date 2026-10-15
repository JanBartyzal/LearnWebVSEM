---
kind: topic
subject: systemy-rizeni
slug: rizeni-rizik
name: "Řízení rizik"
order: 5
---

základní pojmy řízení rizik v aplikaci na kvalitu, environment a bezpečnosti práce. Životní cyklus řízení rizik v organizaci. Nástroje pro identifikaci, hodnocení a snižování možných rizik s dopadem na organizaci.

## Riziko podle ISO 31000 {#riziko .term}

Norma **ISO 31000** (Management rizik — Směrnice) definuje riziko jako **účinek nejistoty na cíle**. Účinek je **odchylka od očekávaného** — může být negativní, pozitivní nebo obojí. Riziko se obvykle popisuje **zdrojem rizika, možnou událostí, jejími následky a pravděpodobností**; v praxi se jeho velikost často vyjadřuje jako **kombinace (součin) pravděpodobnosti a následku**. V BOZP se riziko vztahuje k pravděpodobnosti nebezpečné události či expozice a k závažnosti úrazu nebo poškození zdraví.

### ? Jak definuje riziko norma ISO 31000?

- [ ] Jako zdroj, který může způsobit škodu
- [x] Jako účinek nejistoty na cíle organizace
- [ ] Jako škodu, která už v organizaci nastala
- [ ] Jako nesplnění požadavku zákazníka

> ISO 31000 chápe riziko jako účinek nejistoty na cíle, tedy možnou odchylku od očekávání. Zdroj možné škody je nebezpečí, nesplnění požadavku je neshoda.

### ? Pravděpodobnost, že během roku dojde k úniku oleje z nádrže, je odhadnuta na 0,05 a náklady na sanaci půdy by činily 4 mil. Kč. Jaká je hodnota rizika vyjádřená jako očekávaná roční ztráta?

- [ ] 0,05 mil. Kč
- [ ] 0,8 mil. Kč
- [ ] 4 mil. Kč
- [x] 0,2 mil. Kč

> Riziko = pravděpodobnost × následek = 0,05 × 4 mil. Kč = 0,2 mil. Kč ročně. Tuto hodnotu lze porovnat s náklady na opatření, např. záchytnou vanu.

## Nebezpečí a riziko v kvalitě, environmentu a BOZP {#nebezpeci-vs-riziko .compare}

Nebezpečí je **zdroj s potenciálem způsobit škodu**, riziko je **možnost, že se tento potenciál projeví**, vyjádřená pravděpodobností a následkem. Stejné rozlišení platí ve všech třech systémech řízení.

| | Nebezpečí (zdroj) | Riziko (možnost a velikost škody) |
|---|---|---|
| Kvalita | nestabilní svařovací proces | pravděpodobnost dodání neshodných svarů zákazníkovi a následky reklamací |
| Environment | podzemní nádrž s naftou | pravděpodobnost úniku do půdy a rozsah kontaminace |
| BOZP | práce ve výšce na lešení | pravděpodobnost pádu pracovníka a závažnost úrazu |
| Jak se zjišťuje | identifikací (popis zdroje) | analýzou a hodnocením (pravděpodobnost × následek) |
| Co s ním | odstranit nebo nahradit, pokud to jde | snížit na přijatelnou úroveň a sledovat |

### ? Ve výrobní hale je v provozu lis s nechráněným pohyblivým nástrojem. Co z hlediska BOZP představuje samotný pohyblivý nástroj lisu?

- [ ] Riziko
- [ ] Pracovní úraz
- [x] Nebezpečí
- [ ] Zbytkové riziko

> Pohyblivý nástroj je zdrojem možného poškození zdraví, tedy nebezpečím. Rizikem je možnost, že dojde k sevření ruky obsluhy, vyjádřená pravděpodobností a závažností úrazu.

### ? Které tvrzení o vztahu nebezpečí a rizika platí?

- [x] Riziko vyjadřuje možnost, že se nebezpečí projeví
- [ ] Nebezpečí je vypočtená míra očekávané ztráty
- [ ] Nebezpečí vzniká teprve vyčíslením rizika
- [ ] Nebezpečí a riziko jsou v normách synonyma

> Nebezpečí je zdroj potenciální škody, riziko je možnost, že se tento potenciál uplatní, spolu s velikostí následků. Nebezpečí existuje bez ohledu na to, zda a jak bylo riziko vyčísleno — vyčíslení jen určuje velikost rizika.

## Příležitost {#prilezitost .term}

Příležitost je situace nebo okolnost, která může mít **pozitivní účinek na cíle** organizace — v pojetí ISO 31000 je to „kladná strana" nejistoty. Normy **ISO 9001, ISO 14001 a ISO 45001** proto požadují určit nejen **rizika, ale i příležitosti** a plánovat opatření k oběma. Příležitostí může být např. nová technologie, nový trh, nový zákazník nebo možnost zlepšit pracovní podmínky; i vyhledání příležitosti však může přinést nová rizika.

### ? Firma při plánování systému managementu kvality zjistí, že přechod na nový typ obalu by snížil počet poškozených zásilek a otevřel nový segment zákazníků. Jak tuto skutečnost v systému řízení označit?

- [ ] Jako neshodu
- [ ] Jako nebezpečí
- [ ] Jako zbytkové riziko
- [x] Jako příležitost

> Okolnost s možným pozitivním účinkem na cíle je příležitost. Normy ISO pro systémy řízení vyžadují určit rizika i příležitosti a naplánovat opatření k nim.

### ? Které tvrzení o rizicích a příležitostech v normách ISO pro systémy řízení platí?

- [ ] Normy se zabývají jen negativními riziky
- [x] Organizace určuje rizika i příležitosti
- [ ] Příležitosti řeší jen norma ISO 14001
- [ ] Příležitosti nahrazují zlepšování systému

> ISO 9001, ISO 14001 i ISO 45001 požadují určit rizika i příležitosti, které je třeba řešit, aby systém dosáhl zamýšlených výsledků. Odráží to pojetí rizika jako odchylky oběma směry.

## Myšlení založené na rizicích {#mysleni-na-rizicich .explain}

Myšlení založené na rizicích (risk-based thinking) je princip normy **ISO 9001:2015**, který prostupuje celou normu: organizace má při plánování a řízení procesů **předem zvažovat, co se může pokazit i co lze získat**, a přizpůsobit tomu rozsah řízení. Nahrazuje dřívější samostatný požadavek na **preventivní opatření** — prevence se stala součástí běžného plánování. Norma přitom **nevyžaduje formální metodu managementu rizik** ani dokumentovaný proces podle ISO 31000; rozsah a hloubka práce s riziky jsou na organizaci. Stejný přístup přebírají ISO 14001 a ISO 45001.

*Příklad:* Malá tiskárna nepotřebuje rozsáhlý registr rizik — stačí, když před zakázkou pro nového klienta zváží riziko chybných podkladů a zavede schválení náhledu zákazníkem.

### ? Co nahradilo v ISO 9001:2015 dřívější samostatný požadavek na preventivní opatření?

- [ ] Povinné certifikované řízení rizik podle normy ISO 31000
- [ ] Rozšíření nápravných opatření o každou neshodu
- [x] Myšlení založené na rizicích při plánování procesů
- [ ] Povinná metoda FMEA pro všechny procesy

> Preventivní charakter systému zajišťuje myšlení založené na rizicích, které je součástí plánování. Norma žádnou konkrétní metodu, např. FMEA, ani formální proces podle ISO 31000 nepředepisuje.

### ? Malá firma chce splnit ISO 9001:2015 a ptá se, zda musí zavést formální řízení rizik podle ISO 31000. Co je správná odpověď?

- [x] Nemusí, hloubku práce s riziky volí sama
- [ ] Musí, bez ISO 31000 nezíská certifikát
- [ ] Musí, ale jen pro výrobní procesy
- [ ] Nemusí, rizika ISO 9001 vůbec neřeší

> ISO 9001:2015 vyžaduje určit rizika a příležitosti a reagovat na ně, ale formální metodu ani dokumentovaný proces řízení rizik nepožaduje. ISO 31000 je doporučující směrnice, ne certifikační norma.

## ISO 31000: zásady, rámec a proces {#iso-31000 .explain}

Norma **ISO 31000:2018** je **směrnice** (doporučení), podle které se **necertifikuje**; je použitelná pro jakoukoli organizaci a jakýkoli druh rizika. Stojí na třech propojených částech:

- **Zásady** — jejich účelem je **vytváření a ochrana hodnoty**; management rizik má být mj. integrovaný, strukturovaný a komplexní, přizpůsobený, inkluzivní, dynamický, opřený o nejlepší dostupné informace, má brát v úvahu lidské a kulturní faktory a neustále se zlepšovat.
- **Rámec** — zakotvení managementu rizik v organizaci: ve středu **vedení a závazek** vrcholového vedení, kolem něj integrace, návrh, implementace, hodnocení a zlepšování rámce.
- **Proces** — praktický postup práce s riziky (kontext → posuzování → ošetření, průběžně komunikace a monitorování).

*Příklad:* Firma má propracovaný postup posuzování rizik, ale vedení se o výsledky nezajímá a rizika se neprojednávají při rozhodování o investicích — selhává rámec (vedení a závazek, integrace), ne samotný proces.

### ? Co platí o normě ISO 31000?

- [ ] Je certifikační norma pro řízení finančních rizik
- [ ] Nahrazuje požadavky ISO 9001 na rizika
- [ ] Platí jen pro bezpečnost a ochranu zdraví
- [x] Je směrnice použitelná pro jakákoli rizika

> ISO 31000 poskytuje doporučení pro management rizik v jakékoli organizaci a pro jakýkoli druh rizika. Certifikovat podle ní nelze a požadavky norem pro systémy řízení nenahrazuje.

### ? Co tvoří podle ISO 31000:2018 jádro rámce managementu rizik?

- [x] Vedení a závazek vrcholového vedení
- [ ] Registr rizik vedený manažerem kvality
- [ ] Pojištění všech významných rizik
- [ ] Každoroční certifikační audit rizik

> Rámec má zajistit, aby byl management rizik zakotven v řízení a rozhodování organizace; jeho středem je vedení a závazek. Bez nich zůstává práce s riziky formální.

## Proces managementu rizik {#proces-rizeni-rizik .explain}

Proces podle **ISO 31000:2018** má tři hlavní postupné kroky:

1. **Stanovení rozsahu, kontextu a kritérií** — co se posuzuje, vnější a vnitřní prostředí, kritéria rizika (kdy je riziko přijatelné).
2. **Posuzování rizik** (risk assessment): **identifikace** → **analýza** → **hodnocení** rizik.
3. **Ošetření rizik** — výběr a zavedení opatření, posouzení zbytkového rizika.

Tyto kroky **průběžně provázejí** tři činnosti, které nejsou samostatným krokem v pořadí, ale probíhají ve všech fázích:

- **komunikace a konzultace** se zainteresovanými stranami,
- **monitorování a přezkoumání** — sledování efektivnosti opatření, změn rizik i kvality samotného procesu,
- **zaznamenávání a podávání zpráv** — dokumentace výsledků a informování vedení a zainteresovaných stran.

Proces je **cyklický** — rizika se v čase mění, a proto se posouzení opakuje.

*Příklad:* Firma zavádí novou lakovací linku: stanoví kritéria přijatelnosti, s pracovníky identifikuje nebezpečí (výpary, požár, únik barev), analyzuje a hodnotí rizika, zavede odsávání a školení a po půl roce posouzení přezkoumá podle skutečných provozních zkušeností.

### ? Jaké je správné pořadí kroků posuzování rizik podle ISO 31000?

- [ ] Analýza → identifikace → hodnocení
- [ ] Hodnocení → analýza → identifikace
- [x] Identifikace → analýza → hodnocení
- [ ] Identifikace → hodnocení → analýza

> Nejprve je třeba rizika najít a popsat (identifikace), pak určit jejich velikost (analýza) a nakonec je porovnat s kritérii a rozhodnout o prioritách (hodnocení).

### ? Která činnost podle ISO 31000 NENÍ samostatným krokem, ale průběžně provází celý proces managementu rizik?

- [ ] Analýza rizik
- [x] Komunikace a konzultace
- [ ] Ošetření zjištěných rizik
- [ ] Identifikace rizik

> Komunikace a konzultace se zainteresovanými stranami (stejně jako monitorování a přezkoumání a zaznamenávání a podávání zpráv) provází všechny fáze procesu. Identifikace a analýza (součásti posuzování rizik) a ošetření rizik jsou jeho postupné kroky.

### ? Firma posoudila rizika nového skladu před dvěma lety a od té doby se k nim nevrátila, přestože zdvojnásobila objem a začala skladovat hořlaviny. Kterou průběžnou činnost procesu managementu rizik podle ISO 31000 zanedbala?

- [ ] Stanovení kritérií rizika
- [ ] Prvotní identifikaci rizik
- [ ] Komunikaci s dodavateli
- [x] Monitorování a přezkoumání

> Monitorování a přezkoumání provází celý proces: rizika se mění se změnou podmínek, proto je třeba posouzení průběžně sledovat a přezkoumávat. Nové hořlaviny a vyšší objem měly vyvolat opakované posouzení. Kritéria i prvotní identifikace rizik firma při původním posouzení provedla.

## Identifikace, analýza a hodnocení rizik {#posuzovani-rizik .compare}

Posuzování rizik (risk assessment) se podle ISO 31000 skládá ze tří kroků, které se často zaměňují.

| | Identifikace rizik | Analýza rizik | Hodnocení rizik |
|---|---|---|---|
| Otázka | Co se může stát a proč? | Jak pravděpodobné to je a jaké to bude mít následky? | Je riziko přijatelné, co řešit přednostně? |
| Výstup | seznam (registr) rizik, zdroje, příčiny | úroveň rizika (kvalitativní, semikvantitativní, kvantitativní) | pořadí rizik, rozhodnutí o ošetření |
| Typické nástroje | brainstorming, kontrolní seznamy, What-if, HAZOP | FMEA, FTA, ETA, bodové metody | matice rizik, porovnání s kritérii |

Hranice nejsou ostré — např. FMEA rizika zároveň identifikuje i analyzuje a matice rizik slouží k analýze i hodnocení.

### ? Tým porovná vypočtené úrovně rizik se stanovenými kritérii přijatelnosti a rozhodne, která rizika se budou řešit přednostně. Který krok posuzování rizik provádí?

- [x] Hodnocení rizik
- [ ] Identifikaci rizik
- [ ] Analýzu rizik
- [ ] Ošetření rizik

> Hodnocení rizik porovnává výsledky analýzy s kritérii rizika a stanoví priority. Samotné zavádění opatření je až ošetření rizik.

### ? Co je hlavním výstupem identifikace rizik?

- [ ] Vypočtená úroveň každého rizika
- [ ] Rozhodnutí o přijatelnosti rizik
- [x] Seznam rizik s jejich zdroji a příčinami
- [ ] Plán opatření se zbytkovým rizikem

> Identifikace rizik hledá a popisuje, co se může stát, proč a kde. Úroveň rizika určuje analýza, přijatelnost hodnocení a opatření ošetření.

## Ošetření rizik {#osetreni-rizik .explain}

Ošetření rizik (risk treatment) je výběr a zavedení opatření ke změně rizika. ISO 31000 uvádí možnosti, které lze kombinovat:

- **vyhnout se riziku** — činnost nezahájit nebo nepokračovat v ní,
- **odstranit zdroj rizika**,
- **změnit pravděpodobnost** (prevence) nebo **změnit následky** (zmírnění),
- **sdílet riziko** — smlouvou, pojištěním (v klasickém členění „přenesení"),
- **ponechat (akceptovat) riziko** na základě informovaného rozhodnutí,
- u příležitostí i **podstoupit či zvýšit riziko** kvůli možnému přínosu.

Po zavedení opatření zůstává **zbytkové (reziduální) riziko**, které se znovu posoudí, zda je přijatelné. Opatření se volí podle poměru nákladů a přínosů, ale také podle požadavků legislativy a očekávání zainteresovaných stran.

*Příklad:* Firma kvůli riziku znečištění vod vyvolanému poruchou čistírny instaluje záložní čerpadlo (změna pravděpodobnosti), havarijní jímku (změna následků) a uzavře pojištění odpovědnosti za ekologickou újmu (sdílení).

### ? Výrobce uzavře pojištění odpovědnosti za škodu způsobenou vadným výrobkem. Kterou možnost ošetření rizika zvolil?

- [ ] Odstranění zdroje tohoto rizika
- [ ] Změnu pravděpodobnosti
- [ ] Ponechání rizika
- [x] Sdílení (přenesení) rizika

> Pojištěním výrobce přenáší (sdílí) finanční následky rizika s pojistitelem. Pravděpodobnost vzniku vady se tím nemění.

### ? Firma instaluje kolem nádrží s chemikáliemi záchytné vany, které při případném úniku zachytí kapalinu. Na co opatření působí?

- [x] Snižuje následky úniku
- [ ] Snižuje pravděpodobnost úniku
- [ ] Odstraňuje zdroj rizika
- [ ] Přenáší riziko na jiný subjekt

> Záchytná vana nezabrání tomu, aby nádrž začala unikat, ale omezí rozsah kontaminace — mění tedy následky. Pravidelná kontrola těsnosti by naopak snižovala pravděpodobnost.

### ? Co platí o zbytkovém riziku?

- [ ] Vzniká jen při akceptaci rizika
- [ ] Správně zvolené opatření je vždy odstraní
- [x] Zůstává i po zavedení opatření
- [ ] Netřeba je znovu posuzovat

> Opatření riziko zpravidla jen sníží, a proto zůstává zbytkové riziko. To je třeba znovu posoudit a rozhodnout, zda je přijatelné, nebo vyžaduje další ošetření.

## Nástroje identifikace: brainstorming, kontrolní seznamy, What-if {#nastroje-identifikace .explain}

K identifikaci rizik slouží zejména:

- **Brainstorming** — skupinové generování možných rizik bez okamžité kritiky; využívá znalosti a zkušenosti týmu, je rychlý, ale závisí na složení skupiny a není systematický.
- **Kontrolní seznamy (checklists)** — předem připravené seznamy nebezpečí či otázek vycházející z předpisů, norem a dřívějších zkušeností; jsou systematické a snadno použitelné, ale zachytí **jen to, co v seznamu je** — nová rizika mohou uniknout.
- **What-if analýza** („Co když…?") — tým klade strukturované otázky typu „Co když selže chlazení?", „Co když obsluha zamění surovinu?" a k nim hledá následky a existující ochrany. Je pružnější než kontrolní seznam, ale méně systematická než HAZOP; často se oba nástroje kombinují (What-if/Checklist).

*Příklad:* Při přípravě nového skladu technik projde kontrolní seznam požární bezpečnosti a tým pak v What-if analýze řeší otázky „Co když vypadne elektřina?" a „Co když vozík narazí do regálu?".

### ? Jaká je hlavní slabina kontrolních seznamů při identifikaci rizik?

- [ ] Vyžadují složitý matematický výpočet
- [x] Mohou přehlédnout rizika, která v nich nejsou
- [ ] Lze je použít jen v chemickém průmyslu
- [ ] Neumožňují využít dřívější zkušenosti

> Kontrolní seznam je systematický a jednoduchý, ale pokrývá jen předem známá nebezpečí. Nová či neobvyklá rizika se jím odhalit nemusí, proto se doplňuje dalšími metodami.

### ? Tým bezpečnosti si klade otázky „Co když selže chladicí okruh?" a „Co když obsluha nadávkuje dvojnásobek katalyzátoru?" a ke každé hledá následky a stávající ochrany. Jakou metodu používá?

- [ ] FTA
- [ ] Matici rizik
- [x] What-if analýzu
- [ ] Paretovu analýzu

> Strukturované otázky „Co když…?" s rozborem následků a ochran jsou podstatou What-if analýzy. FTA postupuje od vrcholové události k příčinám, matice rizik slouží k analýze a hodnocení.

## HAZOP {#hazop .explain}

**HAZOP** (Hazard and Operability Study — studie nebezpečí a provozuschopnosti) je **systematická týmová metoda identifikace** nebezpečí a provozních problémů, používaná hlavně v **chemickém a procesním průmyslu**. Zařízení se rozdělí na úseky (uzly) a pro každý **procesní parametr** (průtok, tlak, teplota, hladina…) tým aplikuje **klíčová (vodicí) slova** — např. *žádný (NO)*, *více (MORE)*, *méně (LESS)*, *obráceně (REVERSE)*, *jiný než (OTHER THAN)* — a hledá **odchylky od projektového záměru**, jejich příčiny, následky a potřebná opatření. Je důkladný, ale časově náročný a vyžaduje zkušený mezioborový tým s moderátorem.

*Příklad:* Pro potrubí k reaktoru tým zkoumá odchylku „více + průtok": příčinou může být porucha regulačního ventilu, následkem přeplnění reaktoru; opatřením je čidlo hladiny s automatickým uzavřením přívodu.

### ? Čím je charakteristická metoda HAZOP?

- [x] Klíčová slova aplikovaná na procesní parametry
- [ ] Strom poruch od vrcholové události k příčinám
- [ ] Součin významu, výskytu a odhalitelnosti
- [ ] Zařazení rizik do barevné matice 5 × 5

> HAZOP systematicky kombinuje klíčová slova (žádný, více, méně…) s procesními parametry a hledá odchylky od projektového záměru. Strom poruch je FTA, součin S × O × D je RPN ve FMEA.

### ? Kde se metoda HAZOP typicky používá?

- [ ] Při hodnocení spokojenosti zákazníků
- [ ] Při výběru dodavatele kancelářských potřeb
- [x] Při projektování chemického provozu
- [ ] Při plánování kapacit call centra

> HAZOP vznikl a nejvíc se používá v chemickém a procesním průmyslu, kde se hodnotí odchylky parametrů jako tlak, teplota a průtok od projektového záměru.

## FMEA {#fmea .explain}

**FMEA** (Failure Mode and Effects Analysis — analýza možných způsobů a důsledků poruch/vad) je **induktivní metoda „zdola nahoru"**: pro každý prvek výrobku nebo krok procesu tým hledá **možné způsoby selhání**, jejich **důsledky** a **příčiny** a hodnotí je na škále 1–10:

- **S — význam (severity)**: závažnost důsledku (10 = nejzávažnější, např. ohrožení bezpečnosti),
- **O — výskyt (occurrence)**: pravděpodobnost výskytu příčiny,
- **D — odhalitelnost (detection)**: jak obtížně se vada odhalí dřív, než se dostane k zákazníkovi (10 = téměř neodhalitelná).

Prioritu určí **rizikové číslo RPN = S × O × D** (1–1000). Rozlišuje se **konstrukční FMEA** (návrh výrobku) a **procesní FMEA** (výrobní proces). Používá se v kvalitě (zejména automotive), ale i v BOZP a environmentu; novější metodika AIAG-VDA (2019) místo RPN doporučuje tabulku priority opatření (AP).

*Příklad:* U kroku „utažení šroubu kola" je způsobem selhání nedotažený šroub, důsledkem uvolnění kola (S = 10), příčinou špatně nastavený utahovák (O = 3) a vizuální kontrola vadu odhalí jen obtížně (D = 7): RPN = 210.

### ? Co vyjadřuje vysoká hodnota odhalitelnosti D = 9 ve FMEA?

- [ ] Vadu lze snadno a spolehlivě odhalit
- [ ] Vada se vyskytuje velmi často
- [x] Vadu je velmi obtížné odhalit
- [ ] Vada má velmi závažné důsledky

> Na škále odhalitelnosti znamená vysoké číslo, že vada pravděpodobně projde kontrolou až k zákazníkovi — riziko je tedy vyšší. Četnost vyjadřuje O, závažnost S.

### ? Výrobce chce před zahájením výroby nového dílu systematicky projít jednotlivé kroky výrobního procesu, u každého určit možné vady, jejich důsledky a příčiny a stanovit priority opatření. Jakou metodu zvolí?

- [ ] Strom událostí (ETA)
- [x] Procesní FMEA
- [ ] Strom poruch (FTA)
- [ ] Kontrolní seznam

> Procesní FMEA postupuje krok po kroku procesem „zdola nahoru" a ke každému způsobu selhání hledá důsledky, příčiny a prioritu podle RPN. FTA vychází z jedné vrcholové události, ETA z iniciační události.

## Výpočet a interpretace RPN {#rpn .explain}

Rizikové číslo **RPN = S × O × D** slouží k **seřazení způsobů selhání** podle priority: opatření se zaměří nejprve na nejvyšší RPN. Po zavedení opatření se S, O a D ohodnotí znovu a nové RPN ukáže účinek. **Výskyt O** snižuje prevence příčin (poka-yoke, údržba), **odhalitelnost D** lepší kontrola, **význam S** se obvykle změní jen změnou konstrukce. RPN je ale jen **pořadové číslo** — stejné RPN může skrývat velmi rozdílná rizika, a proto se způsoby selhání s **velmi vysokým S** (např. 9–10, ohrožení bezpečnosti) řeší přednostně bez ohledu na RPN.

*Příklad:* Způsob selhání s S = 6, O = 5, D = 6 má RPN = 180. Po zavedení automatické optické kontroly klesne D na 2 a RPN na 6 · 5 · 2 = 60.

### ? Způsob selhání má ve FMEA hodnoty význam S = 7, výskyt O = 4 a odhalitelnost D = 5. Jaké je jeho rizikové číslo RPN?

- [ ] 16
- [x] 140
- [ ] 28
- [ ] 175

> RPN = S × O × D = 7 × 4 × 5 = 140. Součet S + O + D (16) ani součin jen dvou parametrů (28) RPN nejsou.

### ? Způsob selhání má S = 8, O = 5, D = 6. Firma zavede automatickou kontrolu, po které klesne odhalitelnost na D = 2; S a O se nezmění. O kolik se sníží RPN?

- [ ] O 4
- [ ] O 80
- [ ] O 240
- [x] O 160

> Původní RPN = 8 × 5 × 6 = 240, nové RPN = 8 × 5 × 2 = 80. Snížení činí 240 − 80 = 160.

### ? Způsob selhání A má S = 10, O = 2, D = 4 (RPN = 80), způsob B má S = 4, O = 5, D = 5 (RPN = 100). Jak by měl tým postupovat?

- [ ] Řešit jen B, protože má vyšší RPN
- [x] Řešit i A kvůli nejvyššímu významu S = 10
- [ ] Neřešit nic, obě RPN jsou pod hodnotou 125
- [ ] Řešit jen A, protože RPN se nepočítá u S = 10

> RPN je jen pomocné pořadové číslo. Způsob selhání s nejvyšším významem (S = 10, ohrožení bezpečnosti) se řeší přednostně i při nižším RPN; obecně platná hranice RPN, pod níž se nic neřeší, neexistuje.

## Strom poruch (FTA) {#fta .explain}

**FTA** (Fault Tree Analysis — analýza stromu poruch) je **deduktivní metoda „shora dolů"**: vychází z jedné nežádoucí **vrcholové události** (např. „požár skladu", „dodání neshodné šarže") a graficky ji rozkládá na příčiny až po **základní události** (selhání součástí, chyby lidí). Příčiny se spojují logickými **hradly**:

- **hradlo OR (NEBO)** — vrcholová událost nastane, pokud nastane **kterákoli** z příčin,
- **hradlo AND (A)** — událost nastane, jen když nastanou **všechny** příčiny současně.

Strom lze vyhodnotit kvalitativně (které kombinace příčin vedou k události — **minimální kritické řezy**) i kvantitativně: u **nezávislých** událostí se pravděpodobnosti pod hradlem AND **násobí**, pod hradlem OR se pro malé pravděpodobnosti přibližně **sčítají**.

*Příklad:* Únik čpavku (vrcholová událost) nastane, selže-li těsnění **a zároveň** nezafunguje detektor s uzavíracím ventilem (AND) — proto zálohovaná ochrana výrazně snižuje pravděpodobnost úniku.

### ? K přehřátí reaktoru dojde jen tehdy, když současně selže chlazení (pravděpodobnost 0,1) a nezafunguje havarijní odstavení (pravděpodobnost 0,02). Události jsou nezávislé. Jaká je pravděpodobnost přehřátí?

- [x] 0,002
- [ ] 0,12
- [ ] 0,05
- [ ] 0,2

> Obě příčiny musí nastat současně (hradlo AND), proto se pravděpodobnosti nezávislých událostí násobí: 0,1 × 0,02 = 0,002. Sčítání by odpovídalo hradlu OR.

### ? Jakým směrem postupuje analýza stromu poruch (FTA)?

- [ ] Od iniciační události k jejím možným následkům
- [ ] Od každé součásti k důsledkům jejího selhání
- [x] Od vrcholové události k jejím příčinám
- [ ] Od klíčových slov k odchylkám parametrů

> FTA je deduktivní metoda — začíná nežádoucí vrcholovou událostí a hledá kombinace příčin, které k ní vedou. Od iniciační události k následkům postupuje ETA, od součástí k důsledkům FMEA.

## Strom událostí (ETA) {#eta .explain}

**ETA** (Event Tree Analysis — analýza stromu událostí) je **induktivní metoda**: vychází z **iniciační události** (např. únik hořlavé látky) a sleduje, jak se situace vyvine podle toho, zda jednotlivé **ochranné bariéry** (detekce, sprinklery, evakuace) **zafungují, nebo selžou**. Každá bariéra strom větví na úspěch/selhání a konce větví představují možné **scénáře následků**. Pravděpodobnost scénáře je **součin pravděpodobností** podél větve. ETA tak ukazuje, které bariéry nejvíc ovlivňují vážné následky.

*Příklad:* Iniciační událost „požár v serverovně" (0,01 ročně) se rozvětví podle toho, zda zafunguje hasicí systém (spolehlivost 0,95); scénář „požár a hasicí systém selže" má pravděpodobnost 0,01 × 0,05 = 0,0005 ročně.

### ? K úniku hořlavého plynu dojde s pravděpodobností 0,1 ročně. Plynový detektor selže s pravděpodobností 0,2. Jaká je pravděpodobnost scénáře „únik plynu, který detektor nezachytí"?

- [ ] 0,3
- [ ] 0,08
- [ ] 0,2
- [x] 0,02

> Ve stromu událostí se pravděpodobnosti podél větve násobí: 0,1 × 0,2 = 0,02 ročně. Scénář „únik zachycen" má 0,1 × 0,8 = 0,08.

### ? Co je výchozím bodem analýzy stromu událostí (ETA)?

- [x] Iniciační událost
- [ ] Nežádoucí vrcholová událost
- [ ] Seznam klíčových slov
- [ ] Kontrolní seznam nebezpečí

> ETA začíná iniciační událostí a sleduje její možný vývoj přes úspěch či selhání ochranných bariér. Vrcholová událost je výchozím bodem FTA.

## FMEA, FTA, ETA a HAZOP — srovnání {#srovnani-metod .compare}

Metody se liší směrem úvahy a tím, z čeho vycházejí; v praxi se doplňují.

| | FMEA | FTA (strom poruch) | ETA (strom událostí) | HAZOP |
|---|---|---|---|---|
| Logika | induktivní, zdola nahoru | deduktivní, shora dolů | induktivní, od události k následkům | induktivní, odchylky od záměru |
| Výchozí bod | prvky výrobku / kroky procesu | jedna vrcholová událost | iniciační událost | procesní parametry a klíčová slova |
| Hledá | způsoby selhání, důsledky, příčiny | kombinace příčin vedoucích k události | scénáře podle selhání bariér | odchylky, příčiny, následky |
| Výstup | RPN a priority opatření | logický strom, kritické řezy, pravděpodobnost | pravděpodobnosti scénářů | seznam odchylek a doporučení |
| Typické užití | konstrukce, výroba (automotive) | bezpečnost složitých systémů | havarijní scénáře, ochranné bariéry | chemický a procesní průmysl |

### ? Firma vyšetřuje, jaké kombinace selhání mohou vést k jediné nežádoucí události „výpadek dodávky elektřiny do operačního sálu". Která metoda je pro to nejvhodnější?

- [ ] FMEA
- [ ] ETA
- [ ] HAZOP
- [x] FTA

> Rozklad jedné nežádoucí vrcholové události na kombinace příčin je podstatou stromu poruch (FTA). FMEA vychází z jednotlivých prvků, ETA z iniciační události a jejích následků.

### ? Čím se liší FMEA od FTA?

- [ ] FMEA je deduktivní, FTA induktivní
- [x] FMEA: od prvků k důsledkům, FTA: od události k příčinám
- [ ] FMEA používá logická hradla, FTA rizikové číslo
- [ ] FMEA je čistě kvantitativní, FTA jen slovní popis příčin

> FMEA postupuje zdola nahoru — od způsobů selhání prvků k jejich důsledkům, FTA shora dolů — od vrcholové události k příčinám. Logická hradla patří k FTA a rizikové číslo RPN k FMEA.

## Matice rizik {#matice-rizik .explain}

Matice rizik je **semikvantitativní nástroj analýzy a hodnocení**: na jedné ose je **pravděpodobnost** (např. 1–5), na druhé **následek** (1–5). Úroveň rizika se určí jako **součin P × N** (nebo podle polohy v matici) a pole matice se rozdělí do **pásem** podle kritérií přijatelnosti — typicky zelené (přijatelné), žluté (opatření zvážit, snížit „tak nízko, jak je rozumně proveditelné" — ALARP) a červené (nepřijatelné, nutná opatření). Barva se doplňuje číslem či popisem. Výhodou je názornost a jednoduchost, nevýhodou **subjektivita bodování** a to, že **stejné skóre může mít různý charakter** (P5 × N1 i P1 × N5 dávají 5, ale druhé riziko je potenciálně katastrofické).

*Příklad:* Riziko pořezání při balení (P = 4, N = 2) má skóre 8 — žluté pásmo; riziko výbuchu kotle (P = 1, N = 5) skóre 5, ale firma má pravidlo, že následek 5 se řeší vždy.

### ? Firma používá matici rizik 5 × 5, úroveň rizika počítá jako P × N a pásma stanovila takto: 1–4 přijatelné, 5–12 opatření zvážit, 15–25 nepřijatelné. Riziko úniku emulze do kanalizace má pravděpodobnost 3 a následek 5. Do kterého pásma patří?

- [ ] Přijatelné, skóre 8
- [ ] Opatření zvážit, skóre 8
- [x] Nepřijatelné, skóre 15
- [ ] Opatření zvážit, skóre 12

> Úroveň rizika = P × N = 3 × 5 = 15, což spadá do pásma 15–25 — riziko je nepřijatelné a vyžaduje opatření. Skóre 8 by vzniklo chybným sečtením obou hodnot.

### ? Dvě rizika mají v matici P × N stejné skóre 5: riziko A má P = 5 a N = 1, riziko B má P = 1 a N = 5. Co z toho plyne?

- [x] Stejné skóre může skrývat odlišná rizika
- [ ] Obě rizika vyžadují zcela stejná opatření
- [ ] Riziko A je vždy závažnější než riziko B
- [ ] Matici nelze pro tato rizika použít vůbec

> Riziko A je častá drobnost, riziko B vzácná, ale potenciálně katastrofická událost. Proto se kromě skóre sleduje i samotný následek a pro vysoké následky se stanovují zvláštní pravidla.

## Bodové metody hodnocení rizik BOZP {#bodove-metody .explain}

Bodové (semikvantitativní) metody se v BOZP používají k **vyhodnocení rizik na pracovištích**, které je povinností zaměstnavatele. Každý parametr rizika se ohodnotí **body podle předem daných tabulek** a výsledné číslo (obvykle součin) zařadí riziko do **kategorie přijatelnosti**, z níž plyne naléhavost opatření. Kromě pravděpodobnosti a následku se často hodnotí i **expozice** (jak často a jak dlouho jsou lidé nebezpečí vystaveni). Známým příkladem je **metoda Fine–Kinney**: R = pravděpodobnost × expozice × následek. V české praxi se používá také např. **metoda PNH** se třemi bodově hodnocenými parametry. Výhodou je srovnatelnost a jednoduchost, nevýhodou subjektivita bodování.

*Příklad:* U ručního broušení odlitků tým ohodnotí pravděpodobnost úrazu očí, každodenní expozici brusičů a závažnost poranění; vysoké skóre vede k zavedení odsávání s krytem a povinných ochranných brýlí.

### ? Bezpečnostní technik hodnotí riziko metodou R = pravděpodobnost × expozice × následek. Pravděpodobnost ohodnotí 3 body, expozici 6 body a následek 7 body. Jaká je hodnota rizika?

- [ ] 16
- [ ] 42
- [ ] 252
- [x] 126

> R = 3 × 6 × 7 = 126. Výsledek se zařadí do kategorie přijatelnosti podle tabulky použité metody a určí naléhavost opatření.

### ? Co bodové metody hodnocení rizik BOZP oproti prostému součinu pravděpodobnosti a následku často zohledňují navíc?

- [ ] Náklady na pojištění zaměstnanců
- [x] Expozici pracovníků nebezpečí
- [ ] Spokojenost zákazníků s výrobkem
- [ ] Odhalitelnost vady před expedicí

> Řada bodových metod BOZP (např. Fine–Kinney) hodnotí i expozici — jak často a jak dlouho jsou lidé nebezpečí vystaveni. Odhalitelnost vady je parametr FMEA.

## Hierarchie opatření ke snižování rizik {#hierarchie-opatreni .explain}

Hierarchie opatření je vodítkem pro **ošetření rizik** — tedy pro krok, kdy se po hodnocení rizika vybírají konkrétní opatření. Říká, v jakém pořadí možnosti zvažovat: přednost mají opatření, která **působí na zdroj** a **nezávisí na chování lidí**, před opatřeními, která jen chrání vystaveného člověka:

1. **Eliminace** — odstranění nebezpečí; odpovídá možnosti ošetření „odstranit zdroj rizika" či „vyhnout se riziku".
2. **Záměna (substituce)** — nahrazení méně nebezpečným materiálem, procesem či zařízením.
3. **Technická opatření** — kryty, zábrany, odsávání, blokování, oddělení člověka od nebezpečí.
4. **Organizační (administrativní) opatření** — postupy, školení, značení, omezení doby expozice, povolení k práci.
5. **Osobní ochranné pracovní prostředky (OOPP)** — chrání jen jednotlivce a jen tehdy, když je správně používá.

Stupně 2–5 riziko neodstraňují, ale **mění jeho pravděpodobnost nebo následky**. Po zavedení opatření se znovu posoudí **zbytkové riziko**; není-li přijatelné, doplní se další opatření — nižší stupeň vyšší **doplňuje, nenahrazuje**. Hierarchie je výslovně zakotvena v **ISO 45001**, stejný princip se ale uplatňuje i v environmentu (předcházení znečištění u zdroje před koncovými opatřeními) a v kvalitě (zabránit vzniku vady před její kontrolou).

*Příklad:* Hodnocení rizik ve svařovně ukáže, že riziko vdechování svářečských dýmů je nepřijatelné. Při ošetření tým nejprve zjistí, zda lze část svarů nahradit šroubovými spoji (eliminace), u ostatních přejde na metodu svařování s menším vývinem dýmů (záměna), instaluje lokální odsávání (technické opatření), omezí dobu svařování na směnu (organizační) a na zbytkové riziko vydá respirátory (OOPP). Nakonec posoudí, zda je zbytkové riziko přijatelné.

### ? Kovovýroba nahradí řezání plechů plazmou, při kterém vznikají zdraví škodlivé zplodiny, řezáním vodním paprskem, při kterém zplodiny nevznikají. Který stupeň hierarchie opatření uplatnila?

- [ ] Eliminaci
- [x] Záměnu (substituci)
- [ ] Technické opatření
- [ ] Organizační opatření

> Činnost řezání zůstává, jen se provádí méně nebezpečným procesem — jde o záměnu. Nový proces má vlastní, méně závažná nebezpečí (vysokotlaký paprsek, hluk). Eliminací by bylo řezání ve firmě vůbec nepotřebovat, např. nakupovat díly již nařezané.

### ? V lisovně přesahuje hluk hygienický limit. Firma zvažuje buď zakrytovat a odhlučnit lisy, nebo vydat všem pracovníkům chrániče sluchu. Které řešení má podle hierarchie opatření přednost a proč?

- [ ] Chrániče sluchu, protože jsou levnější a dostupné hned
- [x] Odhlučnění lisů, protože snižuje hluk u zdroje pro všechny
- [ ] Obě řešení rovnocenně, rozhodují jen náklady
- [ ] Chrániče sluchu, protože chrání každého pracovníka zvlášť

> Zakrytování a odhlučnění je technické opatření: snižuje hluk přímo u zdroje, chrání každého v hale a nezávisí na tom, zda si pracovník chrániče nasadí. Chrániče sluchu jsou OOPP, tedy poslední stupeň — slouží jako doplněk na zbytkové riziko, ne jako náhrada opatření u zdroje.

### ? Ke kterému stupni hierarchie opatření patří ochranný kryt s blokováním, který zastaví stroj při otevření?

- [ ] Eliminace
- [ ] Organizační opatření
- [x] Technické opatření
- [ ] Osobní ochranné prostředky

> Kryt s blokováním fyzicky odděluje člověka od nebezpečí a funguje nezávisle na jeho pozornosti — jde o technické opatření. Nebezpečí samotné (pohyblivé části) ale zůstává, proto nejde o eliminaci.
