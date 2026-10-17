---
kind: topic
subject: archimate-practitioner
slug: spravnost-a-odvozovani
name: "Správnost modelu a odvozené vztahy"
order: 7
---

Kontrola platnosti vztahů, odvozování v praxi, typické chyby v modelech.

## Postup kontroly vztahu {#postup-kontroly .explain}

U každého podezřelého vztahu si polož tři otázky. (1) Do kterého aspektu a vrstvy patří oba prvky — je to aktivní struktura, chování, nebo pasivní struktura? (2) Co má vztah vyjádřit — celek a část, kdo co vykonává, co co uskutečňuje, kdo komu poskytuje službu, kdo pracuje s daty, nebo co po čem následuje? (3) Odpovídá směr tomuto významu? Většina chyb v modelech nevzniká neznalostí tabulky povolených vztahů, ale záměnou významu: serving místo realization, assignment mezi dvěma chováními nebo obrácený směr. Barva ani rozmístění prvků v diagramu o správnosti nerozhodují — barvy nejsou normativní.

*Příklad:* `Fakturace (Application Function) —serving→ Fakturační služba (Application Service)` neprojde druhou otázkou: funkce službu uskutečňuje, správně je `—realization→`.

### ? Při revizi modelu nemocnice narazíš na vztah mezi prvky `Lékař (Business Role)` a `Příjem pacienta (Business Process)`. Než posoudíš, zda autor zvolil správný typ vztahu, co je nejužitečnější si ujasnit jako první?

- [ ] Jakou barvou a jakým tvarem jsou oba prvky v nástroji zakresleny
- [x] Do kterého aspektu patří oba prvky a co má vztah mezi nimi vyjadřovat
- [ ] Zda je vztah zakreslen ve všech pohledech, kde se oba prvky vyskytují
- [ ] Kolik dalších vztahů má každý z obou prvků v modelu zachyceno

> Role je aktivní struktura, proces je chování a vztah má říct, kdo proces vykonává — z toho plyne assignment od role k procesu. Barvy nejsou v ArchiMate normativní a výskyt v pohledech ani počet dalších vztahů o správném typu vztahu nic neříká.

### ? Logistická firma má v modelu `Sledování zásilek (Application Function) —serving→ Sledování zásilek online (Application Service)`. Funkce je vnitřní chování aplikace a služba je navenek nabízená podoba právě této funkce, kterou využívá dispečink. Co je na fragmentu chybně?

- [ ] Směr: serving má vést od služby Sledování zásilek online k funkci
- [ ] Typ prvku: službu je nutné modelovat jako Application Interface
- [ ] Nic, serving je mezi interní funkcí a službou správná volba
- [x] Typ vztahu: funkce službu uskutečňuje, patří sem realization

> Interní chování uskutečňuje externí chování, tedy službu — správně je realization od funkce ke službě. Otočený serving by tvrdil, že služba obsluhuje vlastní funkci, a interface je přístupový bod ke službě, ne služba sama.

## Serving × Realization {#serving-vs-realization .compare}

Nejčastější záměna v modelech. Rozhoduje, zda jeden prvek druhý *používá*, nebo ho *uskutečňuje*.

| | Serving | Realization |
|---|---|---|
| Na co odpovídá | Kdo komu poskytuje svou funkčnost? | Co tuto (abstraktnější) věc skutečně uskutečňuje? |
| Směr | od poskytovatele ke spotřebiteli | od konkrétnějšího k abstraktnějšímu |
| Typické dvojice | Application Service → Business Process; Technology Service → Application Component; Application Interface → Business Role | Business Process → Business Service; Application Function → Application Service; Application Process → Business Process; Data Object → Business Object |
| Kategorie | závislostní (dependency) | strukturální |
| Notace | plná čára s otevřenou šipkou | čárkovaná čára s prázdným trojúhelníkem |
| Typická chyba | serving od chování ke službě, kterou samo poskytuje | realization tam, kde jedna vrstva druhou jen používá |

### ? Stavební spořitelna má proces „Vyřízení žádosti o úvěr" (Business Process), který zajišťuje službu „Poskytnutí úvěru" (Business Service) nabízenou klientům. Který fragment vztah procesu a služby zachycuje správně?

- [ ] `Vyřízení žádosti o úvěr (Business Process) —serving→ Poskytnutí úvěru (Business Service)`
- [ ] `Poskytnutí úvěru (Business Service) —realization→ Vyřízení žádosti o úvěr (Business Process)`
- [x] `Vyřízení žádosti o úvěr (Business Process) —realization→ Poskytnutí úvěru (Business Service)`
- [ ] `Poskytnutí úvěru (Business Service) —assignment→ Vyřízení žádosti o úvěr (Business Process)`

> Proces (interní chování) uskutečňuje službu (externí chování), proto realization od procesu ke službě. Serving by tvrdil, že proces službu používá, opačný realization obrací význam a assignment vede od aktivní struktury k chování, ne od služby k procesu.

### ? Dispečeři taxislužby při přidělování jízd využívají aplikační službu „Návrh nejbližšího vozu" (Application Service) dispečerského systému. Proces „Přidělení jízdy" (Business Process) zůstává ruční — dispečer jen využije výsledek služby a rozhodne sám. Který fragment je správný?

- [x] `Návrh nejbližšího vozu (Application Service) —serving→ Přidělení jízdy (Business Process)`
- [ ] `Návrh nejbližšího vozu (Application Service) —realization→ Přidělení jízdy (Business Process)`
- [ ] `Přidělení jízdy (Business Process) —realization→ Návrh nejbližšího vozu (Application Service)`
- [ ] `Přidělení jízdy (Business Process) —serving→ Návrh nejbližšího vozu (Application Service)`

> Aplikace proces podporuje, ale neprovádí ho — klasická mezivrstvová vazba serving od aplikační služby k business procesu. Realization by znamenal, že služba proces uskutečňuje (automatizace), a obrácené směry tvrdí, že proces slouží aplikaci nebo ji realizuje.

### ? Pojišťovna plně automatizovala výpočet pojistného: aplikační proces „Automatický výpočet pojistného" (Application Process) bez lidského zásahu provádí to, co dříve dělal business proces „Výpočet pojistného" (Business Process). Architekt chce zachytit, že aplikační proces business proces uskutečňuje. Který fragment je nejvhodnější?

- [ ] `Automatický výpočet pojistného (Application Process) —serving→ Výpočet pojistného (Business Process)`
- [ ] `Výpočet pojistného (Business Process) —realization→ Automatický výpočet pojistného (Application Process)`
- [ ] `Automatický výpočet pojistného (Application Process) —assignment→ Výpočet pojistného (Business Process)`
- [x] `Automatický výpočet pojistného (Application Process) —realization→ Výpočet pojistného (Business Process)`

> Automatizaci, kdy aplikační chování provádí business chování, vyjadřuje realization od Application Process k Business Process. Serving by říkal jen „podporuje", obrácený realization má opačný význam a assignment vede od aktivní struktury k chování, ne mezi dvěma procesy.

## Směr vztahů: co je zdroj a co cíl {#smer-vztahu .compare}

Obrácený směr je druhá nejčastější chyba. Platný typ vztahu s opačným směrem často znamená něco úplně jiného, nebo není povolen vůbec.

| Vztah | Zdroj | Cíl |
|---|---|---|
| Composition, Aggregation | celek | část |
| Assignment | vykonavatel (aktér, role, komponenta, node); aktér u přiřazení role; system software či node u nasazení | chování, role, artifact |
| Realization | konkrétnější prvek | abstraktnější prvek (služba, business object, požadavek) |
| Serving | poskytovatel | spotřebitel |
| Access | chování (nebo aktivní struktura), které s daty pracuje | pasivní objekt; šipka read/write ukazuje tok dat |
| Influence | ovlivňující prvek | ovlivňovaný prvek |
| Triggering, Flow | předcházející / odesílající chování | následující / přijímající chování |
| Specialization | specifický prvek | obecný prvek |

### ? V modelu e-shopu je `Data objednávky (Data Object) —realization→ orders.db (Artifact)`. Soubor orders.db je databázový soubor, ve kterém jsou data objednávek fyzicky uložena. Co je na fragmentu chybně?

- [ ] Typ vztahu: mezi Data Object a Artifact patří assignment
- [x] Směr: konkrétnější artifact realizuje data object, ne naopak
- [ ] Typ vztahu: databázový soubor k datům přistupuje přes access
- [ ] Typ prvku: databázový soubor je nutné modelovat jako Node

> Realization vede od konkrétnějšího k abstraktnějšímu — fyzický soubor (Artifact) realizuje logický Data Object. Assignment do artifactu patří u nasazení na system software či node, access používá chování k práci s daty a Node je výpočetní prostředek, ne soubor.

### ? Firma rozlišuje typy smluv: obecnou `Smlouva (Contract)` a konkrétnější `Rámcová smlouva (Contract)`. Architekt potřebuje vyjádřit, že rámcová smlouva je druhem smlouvy, nikoli její částí. Který fragment je správný?

- [ ] `Smlouva (Contract) —specialization→ Rámcová smlouva (Contract)`
- [ ] `Smlouva (Contract) —composition→ Rámcová smlouva (Contract)`
- [ ] `Smlouva (Contract) —aggregation→ Rámcová smlouva (Contract)`
- [x] `Rámcová smlouva (Contract) —specialization→ Smlouva (Contract)`

> Vztah „je druhem" je specialization a vede od specifického prvku k obecnému. Obrácený směr by tvrdil, že obecná smlouva je druhem rámcové, a composition s aggregation vyjadřují vztah celku a části.

## Assignment: kdo co vykonává {#assignment-chyby .explain}

Assignment přiřazuje vykonavatele: vede od aktivní struktury k chování, které vykonává (role → proces, komponenta → funkce, node → technology function), od aktéra k roli, kterou zastává, a v technologii od system software nebo node k nasazenému artifactu. Typické chyby: **assignment mezi dvěma chováními** (podproces patří do procesu přes composition, následný proces přes triggering), **obrácený směr** (od procesu k roli) a assignment tam, kde jde o skladbu organizace (oddělení a jeho týmy jsou celek a části). Kdo je vykonavatel, je vždy zdroj.

*Příklad:* `Účetní (Business Role) —assignment→ Párování plateb (Business Process)`, nikoli `Párování plateb —assignment→ Účetní`.

### ? V e-shopu po procesu „Přijetí reklamace" (Business Process) vždy následuje proces „Posouzení reklamace" (Business Process). V modelu je `Přijetí reklamace (Business Process) —assignment→ Posouzení reklamace (Business Process)`. Jak fragment opravit?

- [ ] Ponechat assignment a jen otočit jeho směr k procesu Přijetí reklamace
- [ ] Nahradit assignment vztahem composition od Přijetí k Posouzení reklamace
- [x] Nahradit assignment vztahem triggering od Přijetí k Posouzení reklamace
- [ ] Nahradit assignment vztahem realization od Přijetí k Posouzení reklamace

> Časovou návaznost dvou procesů vyjadřuje triggering od předchozího k následujícímu. Assignment mezi dvěma chováními nedává smysl v žádném směru, composition by z posouzení dělala součást přijetí a realization by tvrdil, že jeden proces uskutečňuje druhý.

### ? V modelu účtárny je `Schválení faktury (Business Process) —assignment→ Vedoucí oddělení (Business Role)`. Autor chtěl vyjádřit, že faktury schvaluje vedoucí oddělení. Co je třeba opravit?

- [x] Otočit směr: assignment vede od role Vedoucí oddělení k procesu
- [ ] Změnit typ vztahu na serving od procesu k roli Vedoucí oddělení
- [ ] Změnit typ vztahu na realization od role Vedoucí oddělení k procesu
- [ ] Nic, směr assignment mezi rolí a procesem není podstatný

> Vykonavatel (role) je zdrojem assignment, chování je cílem. Serving od procesu k roli by říkal, že proces roli obsluhuje, realization od role k procesu neodpovídá významu „vykonává" a směr vztahu podstatný vždy je.

### ? Paní Nováková (Business Actor) ve firmě zastává roli „Garant produktu" (Business Role). Který fragment tuto skutečnost zachycuje správně?

- [ ] `Garant produktu (Business Role) —assignment→ Nováková (Business Actor)`
- [ ] `Nováková (Business Actor) —specialization→ Garant produktu (Business Role)`
- [ ] `Garant produktu (Business Role) —composition→ Nováková (Business Actor)`
- [x] `Nováková (Business Actor) —assignment→ Garant produktu (Business Role)`

> Aktér je přiřazen k roli, kterou zastává — assignment od aktéra k roli. Opačný směr je chybný, specialization smí spojovat jen prvky stejného typu a composition by z aktéra dělala součást role.

## Access: práce s daty, ne s lidmi {#access-chyby .explain}

Access spojuje chování (případně aktivní strukturu) s pasivním objektem, který čte nebo zapisuje. Modeluje se vždy od toho, kdo s daty pracuje, k objektu; volitelná šipka ukazuje tok dat — při čtení míří k chování, při zápisu k objektu (v textovém zápisu uvádíme režim v závorce). Typické chyby: **access od služby k aktérovi** (aktér není pasivní objekt — „služba je pro zákazníka" je serving), access mezi dvěma chováními (předání dat mezi nimi je flow) a pasivní objekt jako zdroj triggering, flow nebo serving — pasivní objekt sám nic nedělá.

*Příklad:* `Fakturace (Business Process) —access (write)→ Faktura (Business Object)`.

### ? V modelu cestovní kanceláře je `Rezervace zájezdu (Business Service) —access→ Zákazník (Business Actor)`. Autor chtěl vyjádřit, že zákazník službu rezervace využívá. Který fragment je správný?

- [ ] `Zákazník (Business Actor) —access→ Rezervace zájezdu (Business Service)`
- [x] `Rezervace zájezdu (Business Service) —serving→ Zákazník (Business Actor)`
- [ ] `Rezervace zájezdu (Business Service) —assignment→ Zákazník (Business Actor)`
- [ ] `Rezervace zájezdu (Business Service) —realization→ Zákazník (Business Actor)`

> Využívání služby vyjadřuje serving od služby ke spotřebiteli. Access patří jen k pasivním objektům (aktér ani služba jimi nejsou), assignment vede od vykonavatele k chování a realization by tvrdil, že služba uskutečňuje aktéra.

### ? Mzdová účetní provádí proces „Výpočet mezd" (Business Process): čte evidenci „Docházka" (Business Object) a vytváří „Výplatní páska" (Business Object). Který fragment je správný?

- [ ] `Docházka —flow→ Výpočet mezd`; `Výpočet mezd —flow→ Výplatní páska`
- [ ] `Docházka —serving→ Výpočet mezd`; `Výpočet mezd —access (write)→ Výplatní páska`
- [ ] `Výpočet mezd —access (write)→ Docházka`; `Výpočet mezd —access (read)→ Výplatní páska`
- [x] `Výpočet mezd —access (read)→ Docházka`; `Výpočet mezd —access (write)→ Výplatní páska`

> Access vede od chování k objektu a režim říká, zda proces data čte, nebo zapisuje: docházku čte, pásku vytváří. Flow ani serving nemohou vycházet z pasivního objektu a třetí možnost má prohozené režimy.

## Composition × Aggregation: jeden celek, nebo sdílení? {#composition-vs-aggregation .explain}

Composition říká, že část existenčně patří k celku a bez něj nemá smysl; součást ve composition proto patří **jen k jednomu** celku. Aggregation seskupuje části, které existují samostatně a mohou patřit do více celků. Kontrola: pokud stejný prvek vystupuje jako část ve dvou composition s různými celky, je model chybný — sdílenou část připoj aggregation. Grouping a Location typicky seskupují prvky přes aggregation.

*Příklad:* Sdílený modul ověření identity: `Internetové bankovnictví (Application Component) —aggregation→ Ověření identity (Application Component)` a zároveň `Mobilní bankovnictví (Application Component) —aggregation→ Ověření identity (Application Component)`.

### ? Banka modeluje dvě aplikace, které obě používají tentýž modul „Ověření identity" (Application Component). Model obsahuje `Internetové bankovnictví —composition→ Ověření identity` a `Mobilní bankovnictví —composition→ Ověření identity` (všechny prvky jsou Application Component). Co je třeba opravit?

- [ ] Nic, composition smí mít stejnou část u libovolného počtu celků
- [ ] Nahradit oba vztahy assignment od aplikací k modulu Ověření identity
- [ ] Nahradit oba vztahy specialization od modulu Ověření identity k aplikacím
- [x] Nahradit oba vztahy aggregation, protože modul je sdílený oběma celky

> Část ve composition patří jen jednomu celku; sdílený modul je typický případ aggregation. Assignment mezi dvěma komponentami nevyjadřuje skladbu a specialization by tvrdila, že modul je druhem obou aplikací.

### ? Formulář „Žádost o dotaci" (Business Object) se skládá z oddílů „Údaje žadatele" a „Rozpočet projektu" (Business Object). Oddíly samostatně nikde nepoužíváte a se zrušením formuláře zanikají. Který vztah od formuláře k oddílům situaci vystihuje nejpřesněji?

- [x] composition, protože oddíly bez formuláře neexistují
- [ ] aggregation, protože oddíly lze sdílet mezi formuláři
- [ ] specialization, protože oddíl je zvláštním druhem formuláře
- [ ] association, protože mezi objekty nelze použít jiný vztah

> Části, které existenčně závisí na jednom celku, vyjadřuje composition. Aggregation by naznačovala samostatnou existenci a sdílení, specialization je vztah „je druhem" a mezi business objekty jsou composition i aggregation běžně povoleny.

## Specialization × Composition × Aggregation {#specialization-chyby .compare}

Specialization je vztah *druhu* („je to typ …"), composition a aggregation jsou vztahy *skladby* („je to část …").

| | Specialization | Composition | Aggregation |
|---|---|---|---|
| Kontrolní otázka | Je A druhem B? | Je A nedílnou částí B? | Je A samostatnou částí skupiny B? |
| Typy prvků | **jen stejného typu** | celek a část | celek a část |
| Směr | od specifického k obecnému | od celku k části | od celku k části |
| Příklad | Hypotéka (Product) → Úvěr (Product) | Objednávka → Položka objednávky | Portfolio aplikací (Grouping) → CRM |
| Notace | plná čára s prázdným trojúhelníkem | plný kosočtverec u celku | prázdný kosočtverec u celku |

### ? Banka nabízí produkty „Hypotéka" a „Spotřebitelský úvěr" (Product), oba jsou druhem obecného produktu „Úvěr" (Product). Architekt chce zachytit vztah druhu, ne skladby. Který fragment je správný?

- [ ] `Úvěr (Product) —composition→ Hypotéka (Product)`; `Úvěr —composition→ Spotřebitelský úvěr`
- [x] `Hypotéka (Product) —specialization→ Úvěr (Product)`; `Spotřebitelský úvěr —specialization→ Úvěr`
- [ ] `Úvěr (Product) —aggregation→ Hypotéka (Product)`; `Úvěr —aggregation→ Spotřebitelský úvěr`
- [ ] `Hypotéka (Product) —realization→ Úvěr (Product)`; `Spotřebitelský úvěr —realization→ Úvěr`

> Vztah „je druhem" je specialization od specifického prvku k obecnému. Composition a aggregation by tvrdily, že hypotéka je součástí obecného úvěru, a realization znamená uskutečnění abstraktnějšího prvku konkrétnějším.

### ? V modelu dopravní firmy je `Řidič (Business Role) —specialization→ Zaměstnanec (Business Actor)`. Autor chtěl říct, že řidič je zvláštní druh zaměstnance. Co je na fragmentu chybně?

- [ ] Specialization musí vést od obecného prvku ke specifickému
- [ ] Specialization se v Business Layer smí kreslit jen přes Junction
- [x] Specialization smí spojovat jen dva prvky, které jsou stejného typu
- [ ] Specialization je povolena jen mezi prvky pasivní struktury

> Specialization je povolena jen mezi prvky téhož typu — role a aktér jsou různé typy, takže je nutné obojí modelovat buď jako role, nebo jako aktéry. Směr od specifického k obecnému je správný, Junction se specialization nesouvisí a specialization je povolena u všech typů prvků.

## Triggering × Flow {#triggering-vs-flow .compare}

Oba vztahy jsou dynamické, ale říkají něco jiného.

| | Triggering | Flow |
|---|---|---|
| Vyjadřuje | časovou nebo příčinnou návaznost: dokončení A spouští B | přenos něčeho (informace, zboží, peněz) z A do B |
| Pořadí | ano, B začíná po A | ne nutně, chování mohou běžet souběžně |
| Typické prvky | procesy, funkce, události (událost spouští proces) | chování; běžně i mezi Application Component |
| Notace | plná čára s plnou šipkou | čárkovaná čára s plnou šipkou |
| Typická chyba | triggering pro předání dat bez návaznosti | flow pro „potom následuje" |

Co se přenáší, lze doplnit asociací předávaného objektu k vztahu flow; samotný pasivní objekt ale zdrojem ani cílem flow či triggering není.

### ? Ve skladovém systému aplikační funkce „Příjem objednávky" průběžně předává data o nových objednávkách funkci „Plánování expedice" (obě Application Function). Obě funkce běží souběžně a nejde o pořadí kroků, jen o předávání dat. Který fragment je nejvhodnější?

- [ ] `Příjem objednávky (Application Function) —triggering→ Plánování expedice (Application Function)`
- [ ] `Příjem objednávky (Application Function) —access (write)→ Plánování expedice (Application Function)`
- [x] `Příjem objednávky (Application Function) —flow→ Plánování expedice (Application Function)`
- [ ] `Příjem objednávky (Application Function) —serving→ Plánování expedice (Application Function)`

> Přenos dat mezi souběžně běžícími chováními je flow. Triggering by vyjadřoval časovou návaznost, access vede jen k pasivnímu objektu a serving by tvrdil, že jedna funkce poskytuje druhé svou funkčnost.

### ? V e-shopu se po přijetí platby (Business Event „Platba přijata") spouští proces „Expedice objednávky" (Business Process). Data o objednávce jsou v objektu „Objednávka" (Business Object). Který fragment spuštění správně zachycuje?

- [ ] `Objednávka (Business Object) —triggering→ Expedice objednávky (Business Process)`
- [ ] `Expedice objednávky (Business Process) —triggering→ Platba přijata (Business Event)`
- [ ] `Platba přijata (Business Event) —serving→ Expedice objednávky (Business Process)`
- [x] `Platba přijata (Business Event) —triggering→ Expedice objednávky (Business Process)`

> Událost spouští proces — triggering od události k procesu. Pasivní objekt nic nespouští, obrácený směr by říkal, že expedice vyvolá platbu, a serving není vztah spouštění.

## Association jako poslední možnost {#association-posledni .explain}

Association je obecný, nejméně výmluvný vztah a je povolen mezi libovolnými prvky. Proto ho model „vždy snese" — a právě to je past: pokud existuje vztah, který význam vyjádří přesněji (assignment, serving, access, realization…), má přednost. Model plný asociací nic neříká o tom, kdo co vykonává nebo co na čem závisí, a analýza dopadů je nepřesná. Association je namístě tam, kde jiný vztah neodpovídá nebo ho jazyk pro danou dvojici nepředepisuje — například Gap se asociuje s dvěma Plateaus.

*Příklad:* místo `Účetní (Business Role) —association→ Uzávěrka (Business Process)` patří `—assignment→`.

### ? Architekt e-shopu kontroluje model, v němž je `Platby (Application Component) —association→ Platební služba (Application Service)`. Komponenta Platby tuto službu svým chováním skutečně zajišťuje. Jaké je nejlepší hodnocení?

- [ ] Vztah je chybný, association mezi aplikačními prvky není povolena
- [ ] Vztah je vhodný, association je doporučený výchozí vztah pro vazby
- [ ] Vztah je chybný, správně je serving od služby ke komponentě Platby
- [x] Vztah je platný, ale lepší je konkrétnější realization ke službě

> Association je povolena mezi libovolnými prvky, ale nese nejméně významu; když komponenta službu svým chováním zajišťuje, vystihuje to realization od komponenty ke službě. Serving od služby ke komponentě by z komponenty dělal spotřebitele služby.

### ? Které použití association je v modelu zcela namístě, protože konkrétnější vztah pro danou vazbu nepřichází v úvahu?

- [x] Gap „Chybí online podpis" asociovaný se dvěma Plateaus, které porovnává
- [ ] Role „Účetní" asociovaná s procesem „Uzávěrka", který vykonává
- [ ] Služba „Výpis z účtu" asociovaná s procesem „Kontrola plateb", jemuž slouží
- [ ] Proces „Fakturace" asociovaný s objektem „Faktura", který vytváří

> Gap se s porovnávanými Plateaus spojuje právě association. U ostatních existuje přesnější vztah: role vykonává proces (assignment), služba slouží procesu (serving) a proces zapisuje objekt (access).

## Junction: jen vztahy stejného typu {#junction-pravidla .term}

Junction je spojovník vztahů (relationship connector), ne prvek: spojí několik vztahů do jednoho bodu, aby šlo vyjádřit větvení nebo slučování. **And** Junction znamená „všechny větve", **Or** Junction „jedna nebo některé z větví". Všechny vztahy napojené na jeden Junction musí být **stejného typu** — například samé triggering. Junction sám nic nevykonává ani neuchovává.

### ? Model procesu pojistné události obsahuje Junction, do kterého vstupuje triggering z procesu „Přijetí hlášení" a vystupuje z něj flow do procesu „Likvidace" a triggering do procesu „Prohlídka vozu". Co je na tomto fragmentu chybně?

- [ ] Junction smí mít jen jeden vstupní a jeden výstupní vztah
- [x] Na jednom Junction nesmí být zároveň kombinovány vztahy různých typů
- [ ] Junction lze v ArchiMate používat jen se vztahem association
- [ ] Junction musí být modelován jako Business Event mezi procesy

> Všechny vztahy napojené na jeden Junction musí být stejného typu; zde se mísí triggering a flow. Junction smí mít více vstupů i výstupů (proto existuje), používá se zejména s dynamickými vztahy a událostí není — je to spojovník.

### ? Úvěrová firma po procesu „Posouzení žádosti" pokračuje buď procesem „Schválení", nebo procesem „Zamítnutí" — nikdy oběma. Který fragment větvení zachycuje nejlépe?

- [ ] `Posouzení žádosti —triggering→ And Junction`; z Junction triggering do Schválení i do Zamítnutí
- [ ] `Posouzení žádosti —flow→ Or Junction`; z Junction triggering do Schválení i do Zamítnutí
- [x] `Posouzení žádosti —triggering→ Or Junction`; z Junction triggering do Schválení i do Zamítnutí
- [ ] `Posouzení žádosti —composition→ Or Junction`; z Junction composition do Schválení i do Zamítnutí

> Výlučné pokračování jednou z větví vyjadřuje Or Junction a návaznost procesů triggering. And Junction by znamenal, že běží obě větve, druhá možnost mísí flow a triggering na jednom Junction a composition je vztah celku a části, ne návaznosti.

## Realization mezi vrstvami: od konkrétního k abstraktnímu {#realizace-mezi-vrstvami .explain}

Při kontrole mezivrstvových vazeb si pamatuj, že realization míří vždy **nahoru k abstraktnějšímu**: Data Object realizuje Business Object, Artifact realizuje Data Object i Application Component, Application Process realizuje Business Process (automatizace). Typické chyby jsou obrácený směr (business object „realizuje" data) a použití serving nebo access tam, kde jde o technickou podobu téhož (soubor *je* podobou komponenty, nikoli její službou). Pokud nižší vrstva vyšší jen podporuje, nejde o realization, ale o serving.

*Příklad:* `crm-server.jar (Artifact) —realization→ CRM (Application Component)`.

### ? V modelu pojišťovny je `Smlouva (Business Object) —realization→ Záznam smlouvy (Data Object)`. Záznam smlouvy je datová podoba smlouvy v aplikaci správy smluv. Co je třeba opravit?

- [ ] Změnit typ vztahu na access od Smlouvy k Záznamu smlouvy
- [ ] Změnit typ vztahu na serving od Smlouvy k Záznamu smlouvy
- [ ] Změnit Záznam smlouvy na Artifact a vztah ponechat beze změny
- [x] Otočit směr: Záznam smlouvy realizuje business object Smlouva

> Datová reprezentace (Data Object) realizuje abstraktnější Business Object, tedy realization od Záznamu smlouvy ke Smlouvě. Access patří od chování k objektu, serving mezi objekty nedává smysl a záměna za Artifact by směr chyby neopravila.

### ? Soubor `crm-server.jar` je spustitelná podoba aplikace „CRM" (Application Component) a je nasazen na aplikační server. Který fragment vztah souboru a komponenty vystihuje správně?

- [x] `crm-server.jar (Artifact) —realization→ CRM (Application Component)`
- [ ] `crm-server.jar (Artifact) —assignment→ CRM (Application Component)`
- [ ] `CRM (Application Component) —realization→ crm-server.jar (Artifact)`
- [ ] `crm-server.jar (Artifact) —serving→ CRM (Application Component)`

> Artifact je fyzickou podobou komponenty, a proto ji realizuje. Assignment u artifactu vede od system software nebo node (nasazení), obrácený realization má opačný význam a soubor komponentě neposkytuje službu.

## Odvozené vztahy v praxi {#odvozovani-ucel .explain}

Odvozený vztah (derived relationship) shrnuje řetězec vztahů do jednoho přímého. V praxi slouží hlavně k **přehledovým pohledům** (vedení nemusí vidět funkci a službu mezi komponentou a procesem) a k **analýze dopadů** (co všechno závisí na serveru). Specifikace rozlišuje odvození **valid** (platí vždy, když platí řetězec) a **potential** (může platit, je třeba ověřit). Zásady: odvozený vztah kresli jen tam, kde v modelu existuje řetězec, který ho podkládá; detailní řetězec v modelu nemaž; potenciální odvození před použitím ověř.

*Příklad:* model obsahuje `Billing (Application Component) —assignment→ Fakturace (Application Function) —realization→ Vystavení faktury (Application Service) —serving→ Prodej (Business Process)`; přehled pro vedení ukáže jen `Billing —serving→ Prodej`.

### ? Model telekomunikační firmy obsahuje `Billing (Application Component) —assignment→ Fakturace (Application Function) —realization→ Vystavení faktury (Application Service) —serving→ Prodej (Business Process)`. Pro obchodního ředitele chce architekt jednodušší obrázek. Jak má postupovat?

- [ ] V modelu nahradit celý řetězec přímým vztahem a mezilehlé prvky smazat
- [x] V pohledu ukázat odvozený vztah Billing —serving→ Prodej, model ponechat
- [ ] V pohledu spojit Billing s procesem Prodej vztahem association
- [ ] V pohledu ukázat odvozený vztah Billing —realization→ Prodej, model ponechat

> Odvozený vztah zjednoduší pohled, aniž by se model ochudil o detail. Mazání mezilehlých prvků ničí informaci pro jiné pohledy, association zbytečně ztrácí význam a výsledkem řetězce končícího serving je serving, ne realization.

### ? Modelovací nástroj ti v bance nabídne odvozený vztah, který označí jako potenciální (potential) — ze dvou na sebe navazujících vztahů nelze jistě určit, zda platí. Jak s ním nejlépe naložit?

- [ ] Přijmout ho bez dalšího, protože ho vypočítal nástroj podle pravidel jazyka
- [ ] Odmítnout ho, protože potenciální odvození vždy značí chybu v modelu
- [x] Ověřit u vlastníka nebo v realitě, zda platí, a teprve pak ho použít
- [ ] Nahradit ho vztahem association, aby byl model formálně správný

> Potenciální odvození může, ale nemusí platit — je to podnět k ověření, ne fakt ani chyba. Přijmout ho bez ověření může zanést nepravdu, plošné odmítnutí zahodí užitečnou informaci a association problém jen zamaskuje.

## Řetězec strukturálních vztahů: nejslabší článek {#nejslabsi-clanek .explain}

Řetězec samých strukturálních vztahů lze shrnout do jednoho vztahu, jehož typ je **nejslabší** v řetězci. Síla od nejsilnějšího: **Composition > Aggregation > Assignment > Realization**. Platí to jen pro řetězce, kde vztahy na sebe navazují stejným směrem (cíl jednoho je zdrojem dalšího). Výsledek nikdy není silnější než nejslabší článek — z composition a realization nikdy nevznikne composition.

*Příklad:* `Portál (Application Component) —composition→ Modul plateb (Application Component) —assignment→ Zpracování platby (Application Function)` ⇒ `Portál —assignment→ Zpracování platby`.

### ? Model e-shopu obsahuje `Portál (Application Component) —composition→ Modul plateb (Application Component) —assignment→ Zpracování platby (Application Function)`. Který vztah mezi Portálem a funkcí Zpracování platby lze z řetězce odvodit?

- [x] `Portál (Application Component) —assignment→ Zpracování platby (Application Function)`
- [ ] `Portál (Application Component) —composition→ Zpracování platby (Application Function)`
- [ ] `Portál (Application Component) —serving→ Zpracování platby (Application Function)`
- [ ] `Zpracování platby (Application Function) —assignment→ Portál (Application Component)`

> Řetězec strukturálních vztahů dává nejslabší z nich — assignment je slabší než composition. Composition by byla silnější než nejslabší článek, serving je závislostní vztah, který v řetězci není, a obrácený směr neodpovídá řetězci.

### ? ERP firmy obsahuje `ERP (Application Component) —aggregation→ Sklad (Application Component) —composition→ Inventura (Application Component)`. Který odvozený vztah mezi ERP a Inventurou je správný?

- [ ] `ERP (Application Component) —composition→ Inventura (Application Component)`
- [ ] `Inventura (Application Component) —aggregation→ ERP (Application Component)`
- [x] `ERP (Application Component) —aggregation→ Inventura (Application Component)`
- [ ] `ERP (Application Component) —assignment→ Inventura (Application Component)`

> Nejslabší z dvojice aggregation a composition je aggregation, a ta se tedy odvodí ve směru řetězce od ERP k Inventuře. Composition je silnější než nejslabší článek, obrácený směr neodpovídá řetězci a assignment se v řetězci vůbec nevyskytuje.

### ? Platební brána je modelována jako `Platební brána (Application Component) —assignment→ Autorizace karty (Application Function) —realization→ Ověření platby (Application Service)`. Který odvozený vztah mezi komponentou a službou je správný?

- [ ] `Platební brána (Application Component) —assignment→ Ověření platby (Application Service)`
- [ ] `Ověření platby (Application Service) —serving→ Platební brána (Application Component)`
- [ ] `Platební brána (Application Component) —composition→ Ověření platby (Application Service)`
- [x] `Platební brána (Application Component) —realization→ Ověření platby (Application Service)`

> Z assignment a realization je nejslabší realization, takže komponenta službu (odvozeně) realizuje. Assignment je silnější než nejslabší článek, composition tím spíš a serving od služby ke komponentě v řetězci nemá oporu.

## Posun serving a access po strukturálních vztazích {#posun-serving .explain}

Když prvek A je strukturálně spojen s B (je jeho celkem, vykonavatelem nebo ho realizuje) a B slouží C, lze odvodit, že **A slouží C** — závislostní vztah se „posune" k poskytovateli na začátku řetězce a jeho typ zůstává (serving zůstane serving). Stejně se posouvá access: komponenta, jejíž funkce zapisuje data, s daty pracuje. Typické použití: od komponenty přes funkci a službu k procesu, od node přes technology function a technology service ke komponentě. Posun spoléhej jen na straně poskytovatele; posun na straně spotřebitele (z části na celek) neber bez ověření jako jistý.

*Příklad:* `DB cluster (Node) —assignment→ Provoz databáze (Technology Function) —realization→ Databázová služba (Technology Service) —serving→ Účetnictví (Application Component)` ⇒ `DB cluster —serving→ Účetnictví`.

### ? Model obsahuje `CRM (Application Component) —assignment→ Správa kontaktů (Application Function) —realization→ Vyhledání zákazníka (Application Service) —serving→ Obsluha klienta (Business Process)`. Který vztah mezi CRM a procesem lze odvodit?

- [ ] `CRM (Application Component) —realization→ Obsluha klienta (Business Process)`
- [x] `CRM (Application Component) —serving→ Obsluha klienta (Business Process)`
- [ ] `CRM (Application Component) —assignment→ Obsluha klienta (Business Process)`
- [ ] `Obsluha klienta (Business Process) —serving→ CRM (Application Component)`

> Strukturální začátek řetězce (assignment, realization) a serving na konci dávají serving od komponenty k procesu. Realization ani assignment nevystihují, že aplikace proces jen podporuje, a obrácený serving neodpovídá směru řetězce.

### ? Provoz IT modeluje `DB cluster (Node) —assignment→ Provoz databáze (Technology Function) —realization→ Databázová služba (Technology Service) —serving→ Účetnictví (Application Component)`. Při plánované odstávce clusteru chce zjistit, které aplikace jsou dotčené. Který odvozený vztah to podloží?

- [ ] `DB cluster (Node) —realization→ Účetnictví (Application Component)`
- [ ] `Účetnictví (Application Component) —serving→ DB cluster (Node)`
- [x] `DB cluster (Node) —serving→ Účetnictví (Application Component)`
- [ ] `DB cluster (Node) —assignment→ Účetnictví (Application Component)`

> Serving se posune po strukturálních vztazích k poskytovateli na začátku řetězce: node slouží aplikaci, a proto ji odstávka zasáhne. Realization a assignment by tvrdily, že node aplikaci uskutečňuje nebo vykonává, a obrácený serving neodpovídá řetězci.

### ? Mzdová aplikace je modelována jako `Mzdy (Application Component) —assignment→ Výpočet mezd (Application Function) —access→ Výplatní data (Data Object)`. Auditor se ptá, které aplikace s výplatními daty pracují. Který odvozený vztah na to odpovídá?

- [x] `Mzdy (Application Component) —access→ Výplatní data (Data Object)`
- [ ] `Mzdy (Application Component) —assignment→ Výplatní data (Data Object)`
- [ ] `Mzdy (Application Component) —composition→ Výplatní data (Data Object)`
- [ ] `Výplatní data (Data Object) —serving→ Mzdy (Application Component)`

> Strukturální vztah (assignment) následovaný access dává access od komponenty k datům — komponenta s daty pracuje prostřednictvím své funkce. Assignment ani composition nevyjadřují práci s daty a pasivní objekt nemůže sloužit aplikaci.

## Co z modelu lze a nelze vyvodit {#co-nelze-vyvodit .explain}

Model i pohled jsou vždy výřez reality. **Chybějící vztah v pohledu neznamená, že závislost neexistuje** — pohled ukazuje jen to, co viewpoint vybral; jistotu dává až dotaz do celého modelu. Odvozený vztah je **informačně chudší** než řetězec: neřekne, přes kterou službu nebo rozhraní závislost vede. Dva vztahy, které míří do stejného cíle (A slouží C, B slouží C), neříkají nic o vztahu A a B. Z modelu bez atributů nelze vyčíst kapacitu, četnost ani výkon. Odvozuj jen z řetězců navazujících stejným směrem.

*Příklad:* `CRM —serving→ Obsluha klienta` a `ERP —serving→ Obsluha klienta` neříkají, zda CRM a ERP spolu komunikují.

### ? V modelu pojišťovny platí `CRM (Application Component) —serving→ Obsluha klienta (Business Process)` a `ERP (Application Component) —serving→ Obsluha klienta (Business Process)`. Jiné vztahy mezi CRM a ERP v modelu nejsou. Co lze z modelu jednoznačně vyvodit?

- [x] Obě aplikace podporují proces Obsluha klienta, o jejich vzájemném vztahu nic
- [ ] CRM a ERP si nutně předávají data, takže mezi nimi platí flow
- [ ] Jedna z aplikací musí sloužit druhé, protože podporují tentýž proces
- [ ] CRM a ERP tvoří složenou aplikaci a platí mezi nimi aggregation

> Vztahy mířící do společného cíle nevytvářejí řetězec, z něhož by se dal odvodit vztah mezi CRM a ERP. Flow, serving ani aggregation mezi nimi z modelu neplynou — bylo by nutné je doložit.

### ? Architekt e-shopu ukazuje vedení pohled podle Application Cooperation viewpointu, v němž mezi aplikacemi „Sklad" a „Účetnictví" není žádný vztah. Finanční ředitel z toho vyvozuje, že výměnu účetního systému sklad nijak neovlivní. Jak má architekt reagovat?

- [ ] Potvrdit závěr, protože pohled zachycuje všechny vazby mezi aplikacemi
- [x] Upozornit, že pohled je výřez, a ověřit závislosti dotazem do celého modelu
- [ ] Potvrdit závěr, pokud je pohled kreslen podle příkladového viewpointu
- [ ] Doplnit do pohledu association mezi oběma aplikacemi pro jistotu

> Pohled ukazuje jen vybranou část modelu; chybějící vztah v něm nedokazuje nezávislost. Spolehlivou odpověď dá až analýza dopadů nad celým modelem; association „pro jistotu" by naopak tvrdila vazbu, o které nic nevíme.

### ? Přehledový pohled banky ukazuje odvozený vztah `Core banking (Application Component) —serving→ Vedení účtu (Business Process)`. Kterou informaci z tohoto jediného vztahu NELZE zjistit?

- [ ] Zda aplikace Core banking proces Vedení účtu podporuje
- [ ] Kterým směrem mezi aplikací a procesem vede závislost
- [x] Přes kterou aplikační službu je proces aplikací obsluhován
- [ ] Že jde o závislostní, a ne o strukturální vztah obou prvků

> Odvozený vztah zachová typ a směr závislosti, ale zahodí mezilehlé prvky — kterou službu nebo rozhraní řetězec používá, zjistíš jen z modelu. Podporu, směr i kategorii vztahu (serving je závislostní) z odvozeného vztahu vyčteš.

## Konzistence modelu napříč pohledy {#konzistence-modelu .explain}

Pohledy jsou jen různé výřezy jednoho modelu, proto každý prvek existuje v modelu **jednou** a v pohledech se znovu používá. Duplicitní prvky stejného jména rozbijí analýzu dopadů — změna jednoho se neprojeví u druhého. Přímý vztah v přehledovém pohledu musí mít oporu v řetězci v detailním modelu, jinak si pohledy odporují. Při revizi proto kontroluj: duplicity prvků, „visící" přímé vztahy bez řetězce a vztahy, které ukazují v různých pohledech opačný směr.

*Příklad:* `CRM (Application Component)` vytvořený zvlášť v pohledu pro obchod a zvlášť v pohledu pro provoz jsou pro nástroj dvě různé aplikace — správně jde o jeden prvek použitý v obou pohledech.

### ? V modelu obchodní firmy existují dva prvky „CRM" (Application Component): jeden vznikl v pohledu pro obchodní oddělení, druhý v pohledu pro provoz IT. Analýza dopadů výpadku serveru proto nezobrazuje obchodní procesy, které CRM podporuje. Co je nejlepší řešení?

- [ ] Propojit oba prvky CRM vztahem association, aby analýza prošla
- [ ] Propojit oba prvky CRM vztahem specialization od jednoho k druhému
- [x] Sloučit je do jednoho prvku CRM a ten použít v obou pohledech
- [ ] Ponechat oba prvky, pohledy pro různé stakeholdery mají být oddělené

> Pohledy mají sdílet tytéž prvky modelu — jeden prvek CRM propojí obchodní i provozní vztahy a analýza dopadů začne fungovat. Association ani specialization mezi duplicitami problém neřeší, jen ho zakonzervují, a oddělené pohledy neznamenají oddělené prvky.

### ? Přehledový pohled pro vedení logistické firmy ukazuje `Sledování (Application Component) —serving→ Doručení zásilky (Business Process)`. V detailním modelu ale neexistuje žádný řetězec mezi aplikací Sledování a tímto procesem, ani přímý vztah. Co má architekt udělat?

- [x] Ověřit skutečnou vazbu a doplnit do modelu řetězec, nebo vztah z pohledu odstranit
- [ ] Ponechat vztah, protože přehledové pohledy nemusejí s modelem souhlasit
- [ ] Nahradit vztah v přehledovém pohledu vztahem association a dál neřešit
- [ ] Zkopírovat vztah do detailních pohledů, aby byly všechny pohledy stejné

> Vztah v pohledu musí odpovídat modelu; přímý nebo odvozený vztah bez opory v řetězci je nekonzistence, kterou je třeba ověřit a opravit. Ponechání, záměna za association či kopírování nepodloženého vztahu chybu jen šíří.
