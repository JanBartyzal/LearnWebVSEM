---
kind: topic
subject: ict-strategie
slug: metoda-toc-v-rizeni-firmy-a
name: "Metoda TOC v řízení firmy a v IS/ICT"
order: 5
---

Využití metody TOC v řízení firmy a její implementace v IS/ICT. Zhodnocení možností a nároků na uplatnění metody, formulace požadavků na její implementaci ve specifických projektech, např. pro úlohy řízení výroby. Použití metody TOC (Theory of Constraints) na problémy specifikace funkcionality analytických aplikací ICT i na otázky řízení projektů tak, jak to odpovídá současné praxi.

## Teorie omezení (TOC) {#teorie-omezeni .term}

**Teorie omezení** (Theory of Constraints, TOC) je manažerský přístup, který formuloval **Eliyahu M. Goldratt**, nejznáměji v podnikovém románu **Cíl** (The Goal, 1984). Vychází z toho, že výkonnost každého systému (firmy) je v daném okamžiku limitována **několika málo omezeními** — podobně jako pevnost řetězu určuje jeho nejslabší článek. Cílem ziskové firmy je podle Goldratta **vydělávat peníze nyní i v budoucnu**, a řízení se proto soustředí na omezení, ne na rovnoměrné zlepšování všeho.

### ? Vedení výrobní firmy navrhuje zvýšit efektivitu všech 12 pracovišť o 5 %. Jak by návrh hodnotila teorie omezení?

- [ ] Jako správný, lokální zlepšení se sečtou ve zlepšení celku
- [x] Jako málo účinný, výkon celku určuje omezení, ne průměr pracovišť
- [ ] Jako správný, pokud se zlepšení dosáhne bez investic
- [ ] Jako zbytečný, protože výkonnost firmy určuje jen poptávka

> Podle TOC je výkon systému dán jeho omezením (nejslabším článkem). Zlepšení pracovišť, která omezením nejsou, výstup celé firmy nezvýší.

### ? Co je podle Goldratta cílem ziskové firmy?

- [ ] Minimalizovat náklady na jednotku výrobku
- [ ] Dosáhnout maximálního vytížení všech zdrojů
- [ ] Maximalizovat tržní podíl bez ohledu na zisk
- [x] Vydělávat peníze nyní i v budoucnu

> Goldratt v knize Cíl definuje cíl ziskové firmy jako vydělávání peněz nyní i v budoucnu. Nízké náklady na kus nebo vysoké vytížení jsou jen dílčí měřítka, která mohou být s cílem v rozporu.

## Typy omezení {#typy-omezeni .compare}

Omezení je cokoli, co brání systému dosáhnout vyššího výkonu vzhledem k jeho cíli. Obvykle se rozlišují tři skupiny:

| Typ | Podstata | Příklad |
|---|---|---|
| **Fyzické** (zdrojové) | nedostatečná kapacita zdroje nebo nedostatek materiálu | lakovací linka, jediný specialista, nedostupná komponenta |
| **Tržní** | trh odebere méně, než firma dokáže vyrobit a dodat | poptávka trvale nižší než kapacita |
| **Politické** (manažerské) | pravidla, postupy, měřítka výkonnosti, zažité způsoby myšlení | odměňování podle vytížení strojů, výroba ve zbytečně velkých dávkách |

Politická omezení se odhalují nejhůře, protože nejsou „vidět" — a fyzická omezení bývají často jejich důsledkem.

### ? Výrobní firma má volnou kapacitu na všech linkách, sklad hotových výrobků je plný a obchodníci nesehnali další zakázky. Jaký typ omezení firma má?

- [ ] Fyzické omezení výrobní kapacity
- [ ] Politické omezení v systému odměňování výroby
- [x] Tržní omezení
- [ ] Materiálové omezení u dodavatele

> Firma by dokázala vyrobit více, ale trh více neodebere — omezení je tedy na trhu. Výrobní kapacita ani materiál výstup nebrzdí.

### ? Interní směrnice dovoluje útvaru IT nasazovat změny do produkce jen jednou za čtvrtletí, takže hotové úpravy čekají měsíce a byznys je nemůže využít. O jaký typ omezení jde?

- [x] Politické (manažerské) omezení
- [ ] Tržní omezení
- [ ] Fyzické omezení kapacity vývojářů
- [ ] Fyzické omezení výpočetní kapacity serverů

> Úpravy jsou hotové, ale brzdí je pravidlo (směrnice), ne kapacita lidí či techniky ani trh. Pravidla, postupy a měřítka jsou typickým politickým omezením.

## Lokální × globální optimum {#lokalni-vs-globalni-optimum .explain}

TOC zdůrazňuje, že **součet lokálních optim není globální optimum**. Hodina ztracená na omezení (úzkém místě) je hodina ztracená pro celý systém; hodina ušetřená na pracovišti, které omezením není, výstup nezvýší — jen vzniknou další zásoby rozpracované výroby. Proto se nemá vyrovnávat kapacita všech pracovišť, ale **tok** práce systémem. Měřítka lokální efektivity (vytížení každého stroje či pracovníka) mohou být škodlivá a volná kapacita na ostatních pracovištích je žádoucí, protože chrání tok před výkyvy.

*Příklad:* Pila vyrobí 100 dílů za hodinu, navazující svářečka jen 60. Když pila kvůli vysokému vytížení jede naplno, hromadí se před svářečkou rozpracovaná výroba, ale firma neprodá ani o kus víc.

### ? Výrobní linka má tři pracoviště zapojená za sebou: A zvládne 100 ks/h, B 60 ks/h a C 80 ks/h. Jaký je maximální výstup linky za hodinu?

- [ ] 100 ks
- [ ] 80 ks
- [ ] 70 ks
- [x] 60 ks

> Výstup linky určuje nejpomalejší pracoviště, tedy B s kapacitou 60 ks/h. Rychlejší pracoviště A a C mohou vyrábět víc, ale linkou projde nejvýše 60 ks/h.

### ? Co se podle TOC stane, když firma zvýší výkon pracoviště, které NENÍ omezením, a vše ostatní zůstane beze změny?

- [ ] Výstup celého systému úměrně vzroste
- [x] Výstup se nezmění, mohou jen narůst rozpracované zásoby
- [ ] Omezení se automaticky přesune na toto pracoviště
- [ ] Sníží se provozní náklady celého systému

> Výkon systému určuje omezení, takže zrychlení jiného pracoviště výstup nezvýší. Pokud pracoviště vyrábí víc, než omezení zpracuje, hromadí se jen rozpracovaná výroba.

## Pět kroků zaměření {#pet-kroku .explain}

Proces trvalého zlepšování (POOGI — Process of Ongoing Improvement) se v TOC řídí **pěti kroky zaměření** (five focusing steps):

1. **Identifikuj** omezení systému.
2. **Rozhodni, jak omezení maximálně vytěžit** (exploit) — bez velkých investic.
3. **Podřiď vše ostatní** tomuto rozhodnutí (subordinate).
4. **Pozvedni omezení** (elevate) — zvyš jeho kapacitu, např. investicí.
5. Pokud bylo omezení prolomeno, **vrať se ke kroku 1** a **nedopusť, aby se omezením stala setrvačnost** (inertia).

Kroky 2 a 3 předcházejí investici — často levně odhalí velké rezervy. Setrvačností se myslí pravidla zavedená kvůli starému omezení, která po jeho prolomení zůstanou a stanou se novým (politickým) omezením.

*Příklad:* Úzkým místem je lakovna. Firma nejdřív zajistí, aby lakovna nestála o přestávkách (vytěžení), pak přizpůsobí tempo ostatních dílen (podřízení) a teprve když to nestačí, koupí druhou lakovací linku (pozvednutí).

### ? Které pořadí pěti kroků zaměření TOC je správné?

- [ ] Identifikuj → pozvedni → vytěž → podřiď → opakuj
- [ ] Vytěž → identifikuj → podřiď → pozvedni → opakuj
- [x] Identifikuj → vytěž → podřiď → pozvedni → opakuj
- [ ] Identifikuj → podřiď → pozvedni → vytěž → opakuj

> Správné pořadí je identifikovat omezení, vytěžit ho, podřídit mu vše ostatní, pozvednout ho a pak se vrátit na začátek. Investice do pozvednutí přichází až po levnějších krocích vytěžení a podřízení.

### ? Firma rozšířila kapacitu montáže a omezením je teď prodej. Výrobu však dál plánuje podle pravidel nastavených pro starou úzkou montáž. Před čím varuje pátý krok TOC?

- [x] Před setrvačností, kdy se stará pravidla stanou novým omezením
- [ ] Před přílišným vytěžením nového omezení
- [ ] Před investicí do pozvednutí nového omezení bez jeho vytěžení
- [ ] Před podřízením prodeje výrobě

> Pátý krok říká: po prolomení omezení se vrať k identifikaci a nedopusť, aby se omezením stala setrvačnost. Pravidla vytvořená pro staré omezení se jinak mohou stát novým, politickým omezením.

## Vytěžit × podřídit × pozvednout {#vytezit-podridit-pozvednout .compare}

Kroky 2–4 se v praxi snadno zaměňují. Rozlišuje je to, **co se mění** a **kolik to stojí**:

| Krok | Podstata | Příklad |
|---|---|---|
| **Vytěžit** (exploit) | nic na omezení neplýtvat — využít každou minutu jeho kapacity bez investic | omezení nestojí o přestávkách, nezpracovává vadné díly, pracuje jen na tom, co se prodá |
| **Podřídit** (subordinate) | ostatní zdroje se řídí tempem omezení, i za cenu vlastní nevytíženosti | materiál se uvolňuje jen v tempu omezení, ostatní pracoviště dají přednost práci pro omezení |
| **Pozvednout** (elevate) | zvýšit kapacitu omezení dalšími zdroji | druhý stroj, přesčasy, outsourcing, nábor dalšího specialisty |

### ? Úzkým místem firmy je lis. Firma zavede střídání pracovníků o přestávkách, aby lis nestál, a zařadí kontrolu kvality před lis, aby nelisoval vadné polotovary. Který krok TOC tím provádí?

- [ ] Identifikaci omezení
- [x] Vytěžení omezení
- [ ] Podřízení ostatních zdrojů
- [ ] Pozvednutí omezení

> Firma bez investic zajišťuje, aby lis neztrácel čas prostoji ani zpracováním vadných dílů — to je vytěžení omezení. Kapacitu lisu jako takovou nezvyšuje.

### ? Úzkým místem IT oddělení je jediný databázový specialista. Ani po odebrání vedlejší agendy a úpravě priorit ostatních týmů jeho kapacita nestačí, a firma proto najme druhého specialistu. Který krok TOC provádí?

- [ ] Identifikaci omezení
- [ ] Vytěžení omezení
- [ ] Podřízení ostatních zdrojů
- [x] Pozvednutí omezení

> Přijetím dalšího specialisty firma zvyšuje kapacitu omezení dalšími zdroji, tedy omezení pozvedá. Předchozí kroky (vytěžení a podřízení) už vyčerpala.

### ? Pracoviště před úzkým místem by mohlo vyrábět víc, ale firma záměrně uvolňuje materiál jen v tempu, které úzké místo zpracuje, i když pracoviště pak část směny nemá práci. Který krok TOC provádí?

- [x] Podřízení ostatních zdrojů
- [ ] Vytěžení omezení
- [ ] Pozvednutí omezení
- [ ] Identifikaci nového omezení

> Ostatní zdroje se řídí tempem omezení, i když tím klesne jejich vytížení — to je podřízení. Výroba navíc by jen zvýšila rozpracované zásoby.

## Drum–Buffer–Rope (DBR) {#dbr .explain}

**Drum–Buffer–Rope** (buben–zásobník–lano) je metoda plánování a řízení výroby podle TOC:

- **Buben** (drum) — harmonogram omezení (úzkého místa) udává tempo celého systému.
- **Zásobník** (buffer) — **časová** rezerva před omezením (případně i před expedicí), která chrání omezení před výpadky předchozích pracovišť.
- **Lano** (rope) — mechanismus uvolňování materiálu do výroby v tempu bubnu: materiál se uvolní o délku zásobníku dříve, než ho omezení podle plánu potřebuje.

Ostatní pracoviště se detailně neplánují — zpracují práci, jakmile ji dostanou. Výsledkem je nižší rozpracovanost a spolehlivější dodací termíny.

*Příklad:* Omezením je tepelná úprava. Zakázka na ní má plánovaný start ve čtvrtek ráno a zásobník trvá 2 pracovní dny, proto se materiál uvolní do výroby v úterý ráno.

### ? Co v metodě Drum–Buffer–Rope představuje „lano" (rope)?

- [ ] Harmonogram úzkého místa, který udává tempo výroby
- [ ] Časovou rezervu chránící úzké místo před výpadky
- [x] Uvolňování materiálu do výroby v tempu úzkého místa
- [ ] Napojení plánu výroby na plán prodeje a nákupu v ERP systému

> Lano váže uvolňování materiálu na harmonogram omezení, aby do výroby nevstupovalo víc práce, než omezení zpracuje. Harmonogram omezení je buben a časová rezerva je zásobník.

### ? Zakázka má na úzkém místě naplánovaný začátek ve středu ráno. Délka zásobníku jsou 3 pracovní dny a pracuje se od pondělí do pátku. Kdy se podle DBR uvolní materiál do výroby?

- [x] V pátek ráno předchozího týdne
- [ ] V pondělí ráno téhož týdne
- [ ] V úterý ráno téhož týdne
- [ ] Ve středu ráno, současně se startem na úzkém místě

> Materiál se uvolní o délku zásobníku před plánovaným startem na omezení. Tři pracovní dny před středou ráno: úterý, pondělí, pátek — tedy pátek ráno předchozího týdne.

## Řízení zásobníků {#rizeni-zasobniku .term}

**Řízení zásobníků** (buffer management) je kontrolní mechanismus DBR i kritického řetězce. Zásobník se dělí na **tři zóny — zelenou, žlutou a červenou** — a sleduje se, jak hluboko je spotřebován: zelená znamená bez zásahu, žlutá připravit zásah, červená okamžitě urychlit. Evidence příčin průniků do červené zóny ukazuje, **kde se má zaměřit zlepšování**.

### ? Zakázka, kterou má zpracovat úzké místo, ještě nedorazila a její zásobník je již spotřebován do červené zóny. Jaká je správná reakce podle řízení zásobníků?

- [ ] Zakázku přeplánovat na pozdější termín
- [ ] Zvětšit délku zásobníku pro budoucí zakázky
- [ ] Nechat úzké místo čekat, dokud zakázka nedorazí
- [x] Zakázku okamžitě urychlit, aby úzké místo neztratilo čas

> Průnik do červené zóny je signál k okamžitému zásahu — zakázku je třeba urychlit, aby omezení nestálo. Ztracený čas omezení znamená ztrátu pro celý systém.

### ? K čemu slouží v řízení zásobníků dlouhodobá evidence příčin průniků do červené zóny?

- [ ] K výpočtu odměn mistrů podle vytížení pracovišť
- [x] K určení, kde se má zaměřit trvalé zlepšování
- [ ] K automatickému zvětšování zásob materiálu
- [ ] K rozpočtení režie na jednotlivé výrobky

> Opakující se příčiny průniků (např. konkrétní pracoviště nebo dodavatel) ukazují, které problémy nejvíc ohrožují omezení. Na ně se pak soustředí zlepšování.

## Throughput accounting: T, I, OE {#throughput-accounting .term}

**Throughput accounting** (účetnictví průtoku) je manažerské hodnocení podle TOC založené na třech veličinách:

- **Průtok** (Throughput, **T**) — tempo, jakým systém generuje peníze **prodejem**: tržby minus skutečně variabilní náklady (typicky materiál, provize, přepravné). Výroba na sklad průtok netvoří.
- **Investice / zásoby** (Investment / Inventory, **I**) — peníze vázané v systému ve věcech, které firma hodlá prodat (zásoby, ale i stroje a budovy).
- **Provozní náklady** (Operating Expense, **OE**) — peníze vydané na přeměnu I na T (mzdy včetně přímých, energie, nájmy, IT).

### ? Firma prodala za měsíc 1 000 ks výrobku za 500 Kč/ks. Materiál stojí 200 Kč/ks a přímé mzdy připadající na kus jsou 80 Kč. Jaký je měsíční průtok T?

- [ ] 500 000 Kč
- [ ] 220 000 Kč
- [x] 300 000 Kč
- [ ] 420 000 Kč

> T = (cena − skutečně variabilní náklady) × prodané kusy = (500 − 200) × 1 000 = 300 000 Kč. Přímé mzdy patří v throughput accounting do provozních nákladů OE, ne do výpočtu T.

### ? Firma vyrobila tento měsíc navíc 500 ks, které leží na skladě a zatím se neprodaly. Jak to podle throughput accounting ovlivní průtok T?

- [x] T se nezvýší, vzrostou jen zásoby I
- [ ] T vzroste o hodnotu vyrobených kusů
- [ ] T vzroste o hodnotu kusů v prodejních cenách
- [ ] T klesne o náklady na materiál

> Průtok vzniká až prodejem. Neprodané výrobky pouze zvyšují peníze vázané v zásobách (I).

### ? Do které veličiny throughput accounting patří mzdy programátorů interního útvaru IT?

- [ ] Do průtoku T
- [ ] Do investic / zásob I
- [ ] Do skutečně variabilních nákladů
- [x] Do provozních nákladů OE

> Mzdy (včetně přímých) jsou peníze vydané na přeměnu I na T, tedy provozní náklady OE. Skutečně variabilní náklady jsou jen ty, které rostou s každým prodaným kusem, typicky materiál.

## Ukazatele throughput accounting {#ta-ukazatele .explain}

Z veličin T, I a OE se odvozují ukazatele výkonnosti firmy:

- **Čistý zisk:** `NP = T − OE`
- **Rentabilita investic:** `ROI = (T − OE) / I`
- **Produktivita:** `T / OE`
- **Obrátka investic:** `T / I`

Podle TOC má prioritu **zvyšování T** (není shora omezeno), pak snižování I a teprve potom snižování OE, které nelze snižovat donekonečna bez dopadu na průtok. Každé rozhodnutí — včetně investice do IS/ICT — se posuzuje podle toho, jak změní T, I a OE.

*Příklad:* Firma má T = 6 mil. Kč, OE = 4,5 mil. Kč a I = 7,5 mil. Kč. Čistý zisk je 6 − 4,5 = 1,5 mil. Kč a ROI = 1,5 / 7,5 = 20 %.

### ? Firma má roční průtok T = 9 mil. Kč, provozní náklady OE = 7 mil. Kč a investice I = 16 mil. Kč. Jaká je ROI podle throughput accounting?

- [ ] 56,25 %
- [x] 12,5 %
- [ ] 22,2 %
- [ ] 43,75 %

> ROI = (T − OE) / I = (9 − 7) / 16 = 2 / 16 = 12,5 %. Hodnota 56,25 % by byla T / I, 22,2 % podíl zisku na průtoku.

### ? Nový plánovací systém zvýší podle odhadu roční průtok T o 1,2 mil. Kč a roční provozní náklady OE (licence, podpora, správa) o 0,4 mil. Kč. O kolik se změní roční čistý zisk?

- [ ] Vzroste o 1,2 mil. Kč
- [ ] Vzroste o 1,6 mil. Kč
- [x] Vzroste o 0,8 mil. Kč
- [ ] Klesne o 0,4 mil. Kč

> Čistý zisk NP = T − OE, takže jeho změna je ΔT − ΔOE = 1,2 − 0,4 = +0,8 mil. Kč ročně.

### ? Kterou z veličin throughput accounting doporučuje TOC zlepšovat přednostně?

- [x] Zvyšovat průtok T, protože není shora omezen
- [ ] Snižovat provozní náklady OE
- [ ] Snižovat investice I až na nulu
- [ ] Zvyšovat vytížení všech zdrojů

> TOC dává přednost růstu průtoku, který nemá horní mez, zatímco OE ani I nelze snižovat donekonečna bez poškození schopnosti vydělávat. Vytížení zdrojů není veličinou throughput accounting.

## Svět nákladů × svět průtoku {#svet-nakladu-vs-pruchodu .compare}

Goldratt staví proti sobě tradiční nákladové myšlení a myšlení podle průtoku:

| | Svět nákladů (tradiční nákladové účetnictví) | Svět průtoku (TOC) |
|---|---|---|
| Hlavní priorita | snižování nákladů | zvyšování průtoku T |
| Výběr sortimentu | marže na kus po rozpočtení režie | průtok na jednotku času omezení |
| Měřítko výkonu zdrojů | vytížení a efektivita každého zdroje | výkon celku; na efektivitě záleží hlavně u omezení |
| Zásoby | aktivum; výroba na sklad může zlepšit vykázaný výsledek | váží peníze a prodlužují průběžnou dobu |
| Přímé mzdy | variabilní náklad výrobku | součást OE (krátkodobě fixní) |

### ? Ředitel výroby je odměňován podle průměrného vytížení všech strojů. Proč to TOC považuje za problém?

- [ ] Protože vytížení strojů nelze v informačním systému spolehlivě měřit a porovnávat
- [ ] Protože vede k nedostatečnému využití úzkého místa
- [ ] Protože zvyšuje průtok na úkor zisku
- [x] Protože vede k výrobě na sklad a růstu zásob bez růstu T

> Snaha vytížit i stroje, které nejsou omezením, vede k výrobě, kterou omezení ani trh nevstřebá. Rostou zásoby a provozní náklady, ale průtok se nezvýší.

### ? Jak se na zásoby (rozpracovanou výrobu a hotové výrobky) dívá TOC na rozdíl od tradičního nákladového pohledu?

- [ ] Jako na aktivum, jehož růst vždy zlepšuje hospodářský výsledek firmy
- [x] Jako na vázané peníze, které prodlužují průběžnou dobu
- [ ] Jako na součást průtoku T
- [ ] Jako na provozní náklad OE

> Zásoby jsou v TOC součástí I — vážou peníze, prodlužují průběžnou dobu a zakrývají problémy. Tradiční ocenění zásob včetně fixních nákladů naopak může výrobu na sklad zvýhodňovat.

## Průtok na jednotku omezení {#t-na-jednotku-omezeni .explain}

Při rozhodování o **sortimentu** (product mix) TOC nehodnotí výrobky podle zisku na kus, ale podle **průtoku na jednotku času omezení** — protože kapacita omezení je to, co firma „prodává":

`T na minutu omezení = (cena − skutečně variabilní náklady) / minuty na omezení`

Přednost mají výrobky s nejvyšším T na minutu omezení, dokud to dovolí poptávka; zbytek kapacity omezení dostanou další výrobky v pořadí.

*Příklad:* Výrobek A: T = 600 Kč/ks, na omezení 20 min → 30 Kč/min. Výrobek B: T = 500 Kč/ks, na omezení 10 min → 50 Kč/min. Ačkoli A má vyšší průtok na kus, přednost dostane B.

### ? Výrobek X: cena 1 200 Kč, materiál 450 Kč, na úzkém místě 15 min. Výrobek Y: cena 900 Kč, materiál 300 Kč, na úzkém místě 8 min. Poptávka po obou převyšuje kapacitu. Který výrobek má podle TOC přednost?

- [x] Y, protože má 75 Kč průtoku na minutu omezení oproti 50 Kč u X
- [ ] X, protože má vyšší průtok na kus (750 Kč oproti 600 Kč u výrobku Y)
- [ ] X, protože má vyšší prodejní cenu
- [ ] Y, protože má nižší náklady na materiál

> X: T = 1 200 − 450 = 750 Kč, 750 / 15 = 50 Kč/min. Y: T = 900 − 300 = 600 Kč, 600 / 8 = 75 Kč/min. Rozhoduje průtok na minutu omezení, proto má přednost Y.

### ? Úzké místo má kapacitu 3 000 minut týdně. Výrobek s průtokem 400 Kč/ks potřebuje na úzkém místě 12 minut na kus a poptávka je neomezená. Jaký nejvyšší týdenní průtok T z tohoto výrobku firma dosáhne?

- [ ] 120 000 Kč
- [ ] 33 333 Kč
- [x] 100 000 Kč
- [ ] 1 200 000 Kč

> Úzké místo zvládne 3 000 / 12 = 250 ks týdně. Průtok T = 250 × 400 = 100 000 Kč.

## Myšlenkové procesy TOC {#myslenkove-procesy .compare}

**Myšlenkové procesy** (Thinking Processes) jsou logické nástroje TOC pro řešení problémů, které nemají fyzickou podstatu — zejména politických omezení. Odpovídají na tři otázky: **Co změnit? Na co změnit? Jak změnu vyvolat?**

| Otázka | Nástroj | Co zachycuje |
|---|---|---|
| Co změnit? | **Strom současné reality** (Current Reality Tree, CRT) | příčinné vazby od nežádoucích efektů ke kořenovému problému |
| Na co změnit? | **Mrak** (Evaporating Cloud) | konflikt bránící řešení a nápad (injekci), který ho rozpustí |
| Na co změnit? | **Strom budoucí reality** (Future Reality Tree, FRT) | ověření, že injekce povede k žádoucím efektům a nevyvolá nové problémy (negativní větve) |
| Jak změnu vyvolat? | **Strom předpokladů** (Prerequisite Tree, PRT) | překážky realizace a mezicíle k jejich překonání |
| Jak změnu vyvolat? | **Strom přechodu** (Transition Tree, TT) | konkrétní posloupnost kroků zavedení změny |

### ? Tým navrhl řešení dlouhodobého problému a chce ověřit, že opravdu povede k žádoucím efektům a nevyvolá nové problémy. Který nástroj myšlenkových procesů TOC použije?

- [ ] Strom současné reality
- [ ] Strom předpokladů
- [ ] Mrak (evaporating cloud)
- [x] Strom budoucí reality

> Strom budoucí reality vychází z navržené injekce a logicky ověřuje, že povede k žádoucím efektům; zároveň odhaluje negativní větve, tedy nové problémy. Strom současné reality slouží k hledání příčin, ne k ověření řešení.

### ? Na kterou ze tří otázek myšlenkových procesů TOC odpovídá strom předpokladů (prerequisite tree)?

- [ ] Co změnit?
- [x] Jak změnu vyvolat?
- [ ] Na co změnit?
- [ ] Kdo za změnu odpovídá?

> Strom předpokladů mapuje překážky realizace a mezicíle k jejich překonání, patří tedy k otázce „Jak změnu vyvolat?". Spolu se stromem přechodu tvoří plán zavedení změny.

## Strom současné reality {#strom-soucasne-reality .term}

**Strom současné reality** (Current Reality Tree, CRT) je diagram příčin a následků postavený na logice **„jestliže … pak …"** (postačující příčina). Vychází z pozorovaných **nežádoucích efektů** (undesirable effects, UDE) a hledá mezi nimi příčinné vazby až k jednomu či několika **kořenovým problémům** (core problem), jejichž odstranění odstraní většinu nežádoucích efektů.

### ? IT oddělení zaznamenalo: projekty se zpožďují, uživatelé si stěžují na chyby a specialisté trvale pracují přesčas. Tým chce najít společnou příčinu těchto jevů. Který nástroj TOC použije?

- [x] Strom současné reality
- [ ] Strom budoucí reality
- [ ] Mrak (evaporating cloud)
- [ ] Drum–Buffer–Rope

> Strom současné reality začíná u pozorovaných nežádoucích efektů a logikou příčin a následků vede ke kořenovému problému. Odpovídá na otázku „Co změnit?".

### ? Co jsou ve stromu současné reality nežádoucí efekty (UDE)?

- [ ] Opatření, která mají problém odstranit
- [ ] Překážky, které brání zavedení řešení
- [x] Pozorované negativní jevy, ze kterých analýza vychází
- [ ] Nové problémy, které by mohlo v budoucnu vyvolat navržené řešení

> Nežádoucí efekty jsou viditelné symptomy (např. zpoždění, stížnosti), od kterých se hledají příčiny. Opatření jsou injekce, překážky patří do stromu předpokladů a nové problémy řešení jsou negativní větve stromu budoucí reality.

## Mrak (evaporating cloud) {#mrak .explain}

**Mrak** (Evaporating Cloud, diagram řešení konfliktu) zachycuje konflikt, který brání odstranění problému. Má pět prvků: **společný cíl (A)**, dva **požadavky** nutné k jeho dosažení **(B, C)** a dva **předpoklady** (prerequisites) **(D, D′)**, které jsou ve vzájemném rozporu. Místo kompromisu se zkoumají **skryté předpoklady** za vazbami mezi prvky a hledá se **injekce** — opatření, které některý předpoklad zneplatní, takže lze splnit oba požadavky.

*Příklad:* Cíl: IS spolehlivě podporuje byznys. Požadavek B: rychle dodávat změny → předpoklad D: nasazovat často. Požadavek C: stabilní provoz → předpoklad D′: nasazovat zřídka. Skrytý předpoklad „každé nasazení výrazně zvyšuje riziko výpadku" zneplatní injekce automatizovaného testování a nasazování.

### ? Co je v mraku (evaporating cloud) „injekce"?

- [ ] Kompromis, který z každého z obou požadavků splní alespoň polovinu
- [x] Opatření, které zneplatní skrytý předpoklad konfliktu
- [ ] Nežádoucí efekt, ze kterého analýza konfliktu vychází
- [ ] Společný cíl, ke kterému oba požadavky směřují

> Injekce je nápad, který zneplatní některý skrytý předpoklad, takže konflikt „se vypaří" a oba požadavky lze splnit. Mrak se kompromisu záměrně vyhýbá.

### ? Jaký je hlavní princip řešení konfliktu pomocí mraku v TOC?

- [ ] Rozhodnout hlasováním, který požadavek má přednost
- [ ] Najít kompromis mezi oběma předpoklady
- [ ] Přenést rozhodnutí na vyšší úroveň řízení
- [x] Zpochybnit skryté předpoklady, na nichž konflikt stojí

> Mrak hledá předpoklady, které stojí za vazbami mezi cílem, požadavky a předpoklady. Když se ukáže, že některý neplatí, konflikt zmizí bez kompromisu.

## Kritický řetězec a řízení IT projektů {#kriticky-retezec .explain}

**Kritický řetězec** (Critical Chain Project Management, CCPM; Goldratt, *Critical Chain*, 1997) je uplatnění TOC v řízení projektů. Kritický řetězec je nejdelší posloupnost závislých úkolů s ohledem na **závislosti úkolů i zdrojů** (na rozdíl od kritické cesty, která zdroje nezohledňuje). Bezpečnostní rezervy se odeberou z odhadů jednotlivých úkolů a sdruží do **projektového zásobníku** na konci projektu a **napájecích zásobníků** v místech, kde se do řetězce napojují jiné větve. Metoda čelí odkládání práce na poslední chvíli a škodlivému **multitaskingu**; postup se sleduje podle čerpání zásobníků.

V multiprojektovém prostředí (typicky útvar IT s několika klíčovými specialisty) TOC doporučuje **omezit počet souběžně rozpracovaných projektů** a jejich zahájení rozfázovat podle kapacity nejvytíženějšího zdroje.

*Příklad:* Útvar IT místo souběžného rozjetí 10 projektů spustí 4, které architekti zvládnou, další zahajuje až po uvolnění kapacity — projekty se dokončují dřív a průtok hotových projektů roste.

### ? Jak metoda kritického řetězce pracuje s bezpečnostními rezervami v odhadech úkolů?

- [x] Odebere je z jednotlivých úkolů a sdruží do zásobníků
- [ ] Ponechá je u každého úkolu a ještě je navýší
- [ ] Zcela je zruší a počítá jen s optimistickými odhady trvání úkolů
- [ ] Přidělí je jen úkolům mimo kritický řetězec

> Rezervy u jednotlivých úkolů se v praxi propadají (práce se protáhne na celý odhad). Kritický řetězec je proto sdružuje do projektového a napájecích zásobníků, které chrání celý projekt.

### ? Čím se kritický řetězec liší od kritické cesty?

- [ ] Nezohledňuje závislosti mezi úkoly
- [ ] Je vždy kratší než kritická cesta
- [x] Zohledňuje kromě závislostí úkolů i závislosti na zdrojích
- [ ] Používá se jen pro výrobní projekty, nikoli pro projekty vývoje IS

> Kritická cesta vychází jen z logických návazností úkolů. Kritický řetězec navíc respektuje, že tentýž zdroj (např. jeden specialista) nemůže dělat dva úkoly současně.

### ? Útvar IT má rozpracováno 10 projektů současně a několik klíčových architektů přepíná mezi všemi z nich; všechny projekty se zpožďují. Co doporučuje TOC?

- [ ] Přidělit každému architektovi všech 10 projektů rovnoměrně
- [ ] Zkrátit odhady úkolů a zvýšit tlak na termíny
- [ ] Přidat do každého projektu bezpečnostní rezervu u každého úkolu
- [x] Omezit souběžné projekty a zahajovat je podle kapacity architektů

> Škodlivý multitasking prodlužuje všechny projekty. TOC doporučuje omezit rozpracovanost a rozfázovat zahájení projektů podle kapacity nejvytíženějšího zdroje.

## Technologie je nutná, ale ne postačující {#technologie-nutna-nepostacujici .explain}

Goldratt v knize **Necessary but Not Sufficient** (2000, se spoluautory) ukazuje, že technologie (např. ERP) je **nutnou, ale ne postačující** podmínkou přínosu. Přínos vznikne jen tehdy, když technologie **zmírní nějaké omezení** a firma zároveň **změní pravidla**, která dříve zavedla, aby s tímto omezením dokázala žít. Pomocné otázky:

1. Jaká je hlavní síla technologie?
2. Jaké omezení zmírňuje?
3. Jaká pravidla nám pomáhala s tímto omezením žít?
4. Jaká nová pravidla máme používat nyní?

Přínos investice do IS/ICT se pak posuzuje podle jejího dopadu na T, I a OE.

*Příklad:* Nový systém poskytuje denní přehled o zásobách, ale nákup dál objednává jednou měsíčně ve velkých dávkách — podle pravidla z doby, kdy data byla jen měsíční. Zásoby proto neklesnou.

### ? Firma zavedla ERP s denními daty o zásobách, ale nákup dál objednává jednou měsíčně podle starého postupu a zásoby neklesly. Co podle Goldratta chybí?

- [ ] Rozsáhlejší funkcionalita ERP
- [x] Změna pravidel, která se přizpůsobovala starému omezení
- [ ] Častější a podrobnější aktualizace dat o zásobách ve skladech
- [ ] Vyšší rozpočet na provoz ERP

> Technologie odstranila omezení (data jen jednou měsíčně), ale firma dál používá pravidlo, které vzniklo kvůli němu. Bez změny pravidel technologie přínos nepřinese.

### ? Kdy podle TOC přináší investice do IS/ICT skutečný přínos?

- [x] Když zmírní omezení a firma změní pravidla s ním spojená
- [ ] Když pokryje co nejvíce podnikových procesů
- [ ] Když zvýší vytížení uživatelů i serverů
- [ ] Když je zavedena v termínu, rozsahu a rozpočtu

> Podle TOC je technologie nutná, ale ne postačující: přínos (vyšší T, nižší I nebo OE) vznikne jen ze zmírnění omezení spojeného se změnou pravidel. Rozsah ani dodržení rozpočtu projektu přínos samy nezaručí.

## TOC a funkcionalita analytických aplikací {#toc-analyticke-aplikace .explain}

TOC lze použít při **specifikaci funkcionality analytických aplikací** (BI, manažerský reporting). Goldratt (*The Haystack Syndrome*, 1990) rozlišuje **data** a **informaci** — informace je odpověď na položenou otázku; aplikace tedy nemá vršit data, ale odpovídat na otázky řízení podle omezení. Typické požadavky:

- identifikace omezení — zatížení zdrojů proti kapacitě, fronty, stav zásobníků;
- ukazatele T, I, OE a odvozené ukazatele místo plných nákladů na kus;
- průtok na jednotku omezení podle výrobků, zákazníků a zakázek;
- simulace „co když" — změna sortimentu, pozvednutí omezení, přijetí zakázky;
- přehled stavu zásobníků a evidence příčin průniků.

*Příklad:* Obchodník posuzuje zakázku se slevou; aplikace ukáže, o kolik zakázka změní T a OE a kolik minut omezení spotřebuje.

### ? Firma navrhuje manažerský reporting podle TOC. Který požadavek NEODPOVÍDÁ principům TOC?

- [ ] Přehled zatížení zdrojů proti jejich kapacitě
- [ ] Průtok na minutu omezení podle výrobků
- [x] Plné náklady na kus s rozpočtenou režií jako podklad pro sortiment
- [ ] Simulace dopadu přijetí nové zakázky na průtok T a provozní náklady OE

> Rozhodování o sortimentu podle plných nákladů s rozpočtenou režií patří ke „světu nákladů". TOC rozhoduje podle průtoku na jednotku omezení a dopadů na T, I a OE.

### ? Zákazník nabízí jednorázovou zakázku 200 ks za 700 Kč/ks. Materiál stojí 450 Kč/ks, úzké místo má dostatek volné kapacity, OE se nezmění a ceny ostatním zákazníkům zakázka neovlivní. Kalkulace plných nákladů uvádí 800 Kč/ks. Co ukáže analýza podle TOC?

- [ ] Zakázku odmítnout, zisk by klesl o 20 000 Kč
- [ ] Zakázku přijmout, zisk vzroste o 140 000 Kč
- [ ] Zakázku odmítnout, zisk by klesl o 50 000 Kč
- [x] Zakázku přijmout, zisk vzroste o 50 000 Kč

> Změna T = 200 × (700 − 450) = 50 000 Kč, OE se nemění, takže čistý zisk vzroste o 50 000 Kč. Plné náklady obsahují rozpočtené OE, které se přijetím zakázky nezmění, a proto vedou k chybnému odmítnutí.

## Požadavky na IS pro řízení výroby podle TOC {#toc-is-rizeni-vyroby .explain}

Při implementaci TOC v projektu IS pro **řízení výroby** je třeba formulovat požadavky na data, funkce i organizaci:

- **přesná kmenová data** (technologické postupy, kapacity, časy) — bez nich nelze omezení spolehlivě identifikovat;
- **plán bubnu s konečnou kapacitou** jen na omezení; ostatní pracoviště se detailně neplánují, ale podřizují;
- **uvolňování materiálu podle lana** (plán bubnu minus délka zásobníku);
- **řízení zásobníků** (barevné zóny) jako hlavní dispečerský nástroj;
- vazba na **ERP**: klasické MRP plánuje s neomezenou kapacitou, proto se DBR řeší funkcí ERP nebo specializovaným plánovacím systémem (APS);
- **změna měřítek výkonnosti** a školení — bez změny pravidel software sám nestačí.

*Příklad:* Strojírenská firma při zavádění plánovacího modulu nejdřív vyčistí technologické postupy, určí úzké místo (obráběcí centrum) a zruší prémie mistrů za vytížení ostatních strojů.

### ? Proč samotné klasické MRP v ERP pro řízení výroby podle DBR nestačí?

- [ ] Protože nepracuje s kusovníky
- [x] Protože plánuje s neomezenou kapacitou pracovišť
- [ ] Protože neumí evidovat skladové zásoby
- [ ] Protože neumožňuje plánovat nákup materiálu od dodavatelů

> Klasické MRP počítá potřeby materiálu a termíny bez ohledu na kapacitu pracovišť. DBR vyžaduje plán omezení s konečnou kapacitou a uvolňování materiálu podle něj.

### ? Firma připravuje zadání IS pro řízení výroby podle DBR. Který požadavek s DBR NENÍ v souladu?

- [ ] Plán s konečnou kapacitou pro úzké místo
- [ ] Uvolňování materiálu podle plánu úzkého místa a délky zásobníku
- [x] Detailní plán všech pracovišť s cílem maximálně je vytížit
- [ ] Přehled stavu zásobníků v barevných zónách

> DBR plánuje detailně jen omezení a ostatní pracoviště mu podřizuje; snaha o maximální vytížení všech pracovišť vede k růstu rozpracované výroby. Ostatní požadavky jsou typické prvky DBR.
