---
kind: topic
subject: archimate-foundation
slug: vztahy
name: "Vztahy a jejich odvozování"
order: 3
---

Strukturální (Composition, Aggregation, Assignment, Realization), závislostní (Serving, Access, Influence, Association), dynamické (Triggering, Flow) a ostatní (Specialization, Junction); pravidla odvozování (derivation).

## Kategorie vztahů (Relationship categories) {#kategorie-vztahu .compare}

ArchiMate 3.2 dělí vztahy do čtyř skupin. Každý vztah je orientovaný od **zdroje** k **cíli** (výjimkou je neorientovaná Association).

| Kategorie | Vztahy | Co vyjadřují |
|---|---|---|
| Strukturální (structural) | Composition, Aggregation, Assignment, Realization | statickou stavbu: z čeho se prvek skládá, kdo co vykonává, co co uskutečňuje |
| Závislostní (dependency) | Serving, Access, Influence, Association | jak prvky na sobě závisí a využívají se |
| Dynamické (dynamic) | Triggering, Flow | časovou či příčinnou návaznost a přenos mezi prvky chování |
| Ostatní (other) | Specialization | že prvek je zvláštním případem jiného prvku |

**Junction** není vztah, ale spojovník (relationship connector), kterým se spojuje více vztahů téhož typu.

### ? Do které kategorie vztahů patří v ArchiMate 3.2 vztah Assignment?

- [x] Strukturální vztahy (structural)
- [ ] Závislostní vztahy (dependency)
- [ ] Dynamické vztahy (dynamic)
- [ ] Ostatní vztahy (other)

> Assignment patří spolu s Composition, Aggregation a Realization mezi strukturální vztahy. Závislostní jsou Serving, Access, Influence a Association, dynamické Triggering a Flow, do ostatních patří Specialization.

### ? Který vztah NEPATŘÍ mezi závislostní (dependency) vztahy?

- [ ] Serving
- [ ] Influence
- [ ] Association
- [x] Triggering

> Triggering je spolu s Flow dynamický vztah. Serving, Influence, Association a Access tvoří skupinu závislostních vztahů.

## Kompozice (Composition) {#composition .term}

**Composition** vyjadřuje, že prvek (celek) **se skládá** z jiných prvků (částí), které k němu pevně patří — mimo celek nemají samostatný smysl a sdílejí jeho životní cyklus. Je to **nejsilnější** strukturální vztah. **Notace:** plná čára s **vyplněným kosočtvercem u celku**; směr vede od celku k části. Typicky spojuje prvky stejného druhu (proces a jeho podprocesy, komponenta a její moduly), ale např. i Application Component —composition→ Application Interface (rozhraní je součástí komponenty).

### ? Jak se v ArchiMate graficky značí vztah Composition?

- [ ] Plná čára s prázdným kosočtvercem u celku
- [ ] Čárkovaná čára s prázdným trojúhelníkem u cíle
- [ ] Plná čára s tečkou u zdroje a šipkou u cíle
- [x] Plná čára s vyplněným kosočtvercem u celku

> Composition má plnou čáru a vyplněný kosočtverec u celku. Prázdný kosočtverec značí Aggregation, čárkovaná čára s prázdným trojúhelníkem Realization a tečka se šipkou Assignment.

### ? Modul Fakturace nemá smysl mimo ERP systém a s jeho vyřazením zaniká. Který zápis vazbu vystihuje nejlépe?

- [ ] ERP (Application Component) —aggregation→ Fakturace (Application Component)
- [x] ERP (Application Component) —composition→ Fakturace (Application Component)
- [ ] Fakturace (Application Component) —composition→ ERP (Application Component)
- [ ] ERP (Application Component) —specialization→ Fakturace (Application Component)

> Část, která bez celku nemá smysl a zaniká s ním, se modeluje vztahem Composition od celku k části. Aggregation by připouštěla samostatnou existenci modulu, obrácený směr by z ERP dělal část Fakturace a Specialization vyjadřuje podtyp, ne skladbu.

## Agregace (Aggregation) {#aggregation .term}

**Aggregation** vyjadřuje, že prvek **seskupuje** jiné prvky, které však mohou **existovat samostatně** a mohou být současně součástí více agregací. **Notace:** plná čára s **prázdným kosočtvercem u celku**; směr vede od celku k části. Typické použití: Grouping nebo Product seskupující prvky, Business Collaboration sdružující role, portfolio aplikací. V síle pro odvozování je hned za Composition.

### ? Který vztah je vhodný, když tentýž prvek má být součástí několika celků a může existovat i bez nich?

- [ ] Composition
- [ ] Assignment
- [x] Aggregation
- [ ] Specialization

> Aggregation seskupuje prvky, které existují nezávisle na celku a mohou patřit do více agregací. Composition naopak vyjadřuje pevnou příslušnost části k celku, Assignment přidělení chování a Specialization podtyp.

### ? Schvalovací komise vzniká spoluprací rolí Ředitel, Právník a Finanční manažer; tyto role existují i mimo komisi. Který zápis je správný?

- [ ] Právník (Business Role) —aggregation→ Schvalovací komise (Business Collaboration)
- [ ] Schvalovací komise (Business Collaboration) —realization→ Právník (Business Role)
- [x] Schvalovací komise (Business Collaboration) —aggregation→ Právník (Business Role)
- [ ] Právník (Business Role) —specialization→ Schvalovací komise (Business Collaboration)

> Business Collaboration sdružuje role, které existují i samostatně, proto vede Aggregation od kolaborace (celku) k roli (části). Obrácený směr by z role dělal celek, Realization ani Specialization skladbu z účastníků nevyjadřují.

## Composition × Aggregation {#composition-vs-aggregation .compare}

Oba vztahy vyjadřují vztah celek–část a kreslí se od celku k části; liší se pevností vazby.

| Hledisko | Composition | Aggregation |
|---|---|---|
| Vazba části na celek | pevná, část k celku patří | volná, část může být ve více celcích |
| Existence části | závisí na celku, zaniká s ním | nezávislá na celku |
| Notace | plná čára, vyplněný kosočtverec u celku | plná čára, prázdný kosočtverec u celku |
| Síla při odvozování | nejsilnější strukturální vztah | druhý nejsilnější |
| Příklad | Objednávka (Business Process) —composition→ Kontrola skladu (Business Process) | Klíčové systémy (Grouping) —aggregation→ CRM (Application Component) |

### ? Čím se Aggregation liší od Composition?

- [ ] Aggregation smí spojovat jen prvky z různých vrstev
- [ ] Aggregation se kreslí čárkovanou čarou bez kosočtverce
- [x] Části agregace mohou existovat i nezávisle na celku
- [ ] Aggregation patří mezi závislostní vztahy, ne strukturální

> U Aggregation část na celku nezávisí a může patřit do více celků, u Composition s celkem zaniká. Oba vztahy jsou strukturální, kreslí se plnou čarou s kosočtvercem a nejsou omezeny na prvky z různých vrstev.

### ? Firma vytváří skupinu „Klíčové systémy" (Grouping), do níž zařazuje CRM a ERP; obě aplikace patří zároveň i do jiných skupin. Který vztah od Grouping k aplikacím použije?

- [ ] Composition, protože Grouping je vždy celkem
- [ ] Assignment, protože skupina aplikace spravuje
- [ ] Realization, protože skupinu aplikace uskutečňují
- [x] Aggregation, protože aplikace jsou ve více skupinách

> Aplikace existují samostatně a patří do více skupin, proto se použije Aggregation. Composition by znamenala pevnou příslušnost k jediné skupině, Assignment a Realization vyjadřují vykonávání chování a uskutečnění abstrakce.

## Přiřazení (Assignment) {#assignment .term}

**Assignment** vyjadřuje **přidělení odpovědnosti, vykonávání chování nebo nasazení**: kdo nebo co dané chování vykonává (aktivní struktura → chování), kdo zastává jakou roli (Business Actor → Business Role) nebo na čem je něco nasazeno (Node či System Software → Artifact). **Notace:** plná čára s **tečkou u zdroje a šipkou u cíle**; směr vede od vykonavatele k vykonávanému.

### ? Který zápis správně vyjadřuje, že role Referent vykonává proces Kontrola žádosti?

- [ ] Kontrola žádosti (Business Process) —assignment→ Referent (Business Role)
- [ ] Referent (Business Role) —serving→ Kontrola žádosti (Business Process)
- [ ] Referent (Business Role) —realization→ Kontrola žádosti (Business Process)
- [x] Referent (Business Role) —assignment→ Kontrola žádosti (Business Process)

> Kdo chování vykonává, se vyjadřuje vztahem Assignment od aktivní struktury (role) k chování (procesu). Obrácený směr je chybný, Serving by znamenal, že role procesu poskytuje funkcionalitu, a Realization se používá pro uskutečnění abstraktnějšího prvku.

### ? Jak se v ArchiMate 3.2 značí vztah Assignment?

- [ ] Plná čára s plnou šipkou u cíle, bez dalších značek
- [x] Plná čára s tečkou u zdroje a šipkou u cíle
- [ ] Čárkovaná čára s tečkou u zdroje a bez šipky
- [ ] Tečkovaná čára se šipkou ve směru toku dat

> Assignment má plnou čáru, tečku u zdroje (vykonavatele) a šipku u cíle. Plná čára s plnou šipkou je Triggering a tečkovaná čára se šipkou ve směru toku dat je Access.

### ? Zaměstnankyně Jana Nováková (Business Actor) zastává ve firmě roli Účetní. Který zápis je správný?

- [x] Jana Nováková (Business Actor) —assignment→ Účetní (Business Role)
- [ ] Jana Nováková (Business Actor) —specialization→ Účetní (Business Role)
- [ ] Účetní (Business Role) —composition→ Jana Nováková (Business Actor)
- [ ] Jana Nováková (Business Actor) —realization→ Účetní (Business Role)

> Že aktér zastává roli, se modeluje vztahem Assignment od Business Actor k Business Role. Specialization smí spojovat jen prvky stejného typu, role se ze svého nositele neskládá a Realization zde nevyjadřuje uskutečnění abstrakce.

## Realizace (Realization) {#realization .term}

**Realization** vyjadřuje, že **konkrétnější prvek uskutečňuje, implementuje nebo naplňuje prvek abstraktnější**: chování realizuje službu, Data Object realizuje Business Object, Artifact realizuje Application Component, prvek architektury realizuje Requirement. **Notace:** **čárkovaná čára s prázdným trojúhelníkem** u realizovaného (abstraktnějšího) prvku; směr vede od konkrétního k abstraktnímu. Je to **nejslabší** strukturální vztah.

### ? Který zápis správně vyjadřuje, že proces Vyřízení reklamace zajišťuje službu Reklamace zboží?

- [ ] Reklamace zboží (Business Service) —realization→ Vyřízení reklamace (Business Process)
- [x] Vyřízení reklamace (Business Process) —realization→ Reklamace zboží (Business Service)
- [ ] Vyřízení reklamace (Business Process) —assignment→ Reklamace zboží (Business Service)
- [ ] Vyřízení reklamace (Business Process) —composition→ Reklamace zboží (Business Service)

> Chování (proces) uskutečňuje službu, proto vede Realization od procesu ke službě. Opačný směr je chybný, Assignment vede od aktivní struktury k chování a Composition by ze služby dělala část procesu.

### ? Jak se v ArchiMate značí vztah Realization?

- [ ] Plná čára s prázdným trojúhelníkem u obecnějšího prvku
- [ ] Čárkovaná čára s plnou šipkou u cílového prvku
- [x] Čárkovaná čára s prázdným trojúhelníkem u cíle
- [ ] Tečkovaná čára s otevřenou šipkou u cílového prvku

> Realization se kreslí čárkovanou čarou s prázdným trojúhelníkem u realizovaného prvku. Plná čára s prázdným trojúhelníkem je Specialization a čárkovaná čára s plnou šipkou je Flow.

## Assignment × Realization {#assignment-vs-realization .compare}

Oba vztahy jsou strukturální; rozhoduje, zda jde o **vykonavatele** nebo o **uskutečnění abstrakce**.

| Hledisko | Assignment | Realization |
|---|---|---|
| Otázka, na kterou odpovídá | Kdo nebo co to vykonává či hostí? | Čím je to uskutečněno či naplněno? |
| Typické dvojice | aktivní struktura → chování; Business Actor → Business Role; Node → Artifact | chování → služba; Data Object → Business Object; Artifact → Application Component |
| Notace | plná čára, tečka u zdroje, šipka u cíle | čárkovaná čára, prázdný trojúhelník u cíle |
| Síla při odvozování | třetí v pořadí | nejslabší |

*Příklad:* Platební brána (Application Component) —assignment→ Autorizace platby (Application Function) —realization→ Ověření karty (Application Service).

### ? Aplikační komponenta Platební brána vykonává aplikační funkci Autorizace platby a tato funkce zajišťuje aplikační službu Ověření karty. Která dvojice vztahů je správná?

- [ ] komponenta —realization→ funkce; funkce —assignment→ služba
- [ ] komponenta —assignment→ funkce; funkce —assignment→ služba
- [x] komponenta —assignment→ funkce; funkce —realization→ služba
- [ ] komponenta —composition→ funkce; funkce —serving→ služba

> Komponenta funkci vykonává (Assignment) a funkce jako chování službu uskutečňuje (Realization). Prohozené vztahy, Assignment od funkce ke službě ani Composition s následným Serving tento standardní vzor nevystihují.

### ? Ve kterém případě se použije Realization, a NE Assignment?

- [ ] Business Actor zastává v organizaci Business Role
- [ ] Node slouží jako hostitel nasazeného Artifactu
- [x] Artifact je fyzickým souborem Application Component
- [ ] Business Role vykonává jednotlivé kroky Business Process

> Artifact je fyzickou podobou komponenty, tedy ji realizuje. Zastávání role, nasazení artefaktu na Node i vykonávání procesu rolí se modelují vztahem Assignment.

## Obsluhování (Serving) {#serving .term}

**Serving** vyjadřuje, že prvek **poskytuje svou funkcionalitu** jinému prvku, který ji využívá. Typicky služba → chování nebo aktivní struktura, která ji používá; rozhraní → role; komponenta → komponenta. **Notace:** **plná čára s otevřenou šipkou** u obsluhovaného (využívajícího) prvku; směr vede od poskytovatele k uživateli. Ve verzi ArchiMate 2 se tento vztah jmenoval „used by".

### ? Kterým směrem vede vztah Serving?

- [ ] Od prvku, který funkcionalitu využívá, k jejímu poskytovateli
- [x] Od poskytovatele funkcionality k prvku, který ji využívá
- [ ] Od abstraktnějšího prvku ke konkrétnějšímu, který jej realizuje
- [ ] Oběma směry, protože poskytovatel a uživatel jsou rovnocenní

> Serving vede od poskytovatele (např. služby) k uživateli, u něhož je šipka. Opačný směr je častá chyba; vztah konkrétního a abstraktního prvku vyjadřuje Realization.

### ? Business služba Ověření bonity je využívána procesem Schválení úvěru. Který zápis je správný?

- [ ] Schválení úvěru (Business Process) —serving→ Ověření bonity (Business Service)
- [ ] Ověření bonity (Business Service) —realization→ Schválení úvěru (Business Process)
- [ ] Ověření bonity (Business Service) —assignment→ Schválení úvěru (Business Process)
- [x] Ověření bonity (Business Service) —serving→ Schválení úvěru (Business Process)

> Služba poskytuje funkcionalitu procesu, proto vede Serving od služby k procesu. Opačný směr je chybný, Realization by znamenala, že služba proces uskutečňuje, a Assignment vede od aktivní struktury, ne od služby.

### ? Jak se nazýval vztah Serving ve verzi ArchiMate 2?

- [ ] Uses
- [x] Used by
- [ ] Supports
- [ ] Depends on

> ArchiMate 3 přejmenoval vztah „used by" na Serving; význam (poskytování funkcionality uživateli) zůstal stejný. Ostatní názvy v jazyce jako vztahy neexistují.

## Přístup (Access) {#access .term}

**Access** vyjadřuje, že chování nebo aktivní struktura **pracuje s pasivním prvkem** (Business Object, Data Object, Artifact) — čte jej, zapisuje nebo mění. V modelu vede vždy **od chování (aktivní struktury) k pasivnímu prvku**, protože pasivní prvek sám nic nevykonává. **Notace:** **tečkovaná čára**; nepovinná šipka ukazuje **směr toku dat**:

- **write** — šipka u pasivního prvku (data tečou do objektu),
- **read** — šipka u chování (data tečou z objektu),
- **readwrite** — šipky na obou koncích,
- **access** bez určení — bez šipky.

### ? Proces Vystavení faktury zapisuje do objektu Faktura. Jak vypadá vztah Access v diagramu?

- [x] Tečkovaná čára se šipkou u objektu Faktura
- [ ] Tečkovaná čára se šipkou u procesu Vystavení faktury
- [ ] Tečkovaná čára se šipkami na obou koncích
- [ ] Plná čára s otevřenou šipkou u objektu Faktura

> Při zápisu tečou data do objektu, proto je šipka u objektu. Šipka u procesu znamená čtení, šipky na obou koncích readwrite a plná čára s otevřenou šipkou je Serving.

### ? Proces Kontrola smlouvy objekt Smlouva pouze čte. Kde je u vztahu Access šipka?

- [ ] U objektu Smlouva, protože vztah vede od procesu
- [ ] Na obou koncích, protože proces s objektem pracuje
- [x] U procesu, protože data tečou z objektu do procesu
- [ ] Nikde, protože čtení se v ArchiMate neznázorňuje

> Šipka u Access ukazuje směr toku dat; při čtení tečou data z objektu do procesu, takže je šipka u procesu. Šipky na obou koncích znamenají readwrite a vztah bez šipky blíže neurčený přístup.

### ? Který zápis je v ArchiMate CHYBNÝ?

- [ ] Vystavení faktury (Business Process) —access (write)→ Faktura (Business Object)
- [ ] Kontrola faktury (Business Process) —access (read)→ Faktura (Business Object)
- [ ] Účtování (Business Process) —access (readwrite)→ Faktura (Business Object)
- [x] Faktura (Business Object) —access (write)→ Vystavení faktury (Business Process)

> Access se modeluje vždy od chování nebo aktivní struktury k pasivnímu prvku; Business Object nemůže být zdrojem. Režim čtení či zápisu vyjadřuje šipka, ne obrácení vztahu.

## Serving × Access {#serving-vs-access .compare}

Oba vztahy jsou závislostní, ale liší se tím, **na čem** prvek závisí.

| Hledisko | Serving | Access |
|---|---|---|
| Co vyjadřuje | využívání funkcionality (služby, rozhraní, komponenty) | práci s informacemi či daty |
| Cíl vztahu | chování nebo aktivní struktura, která funkcionalitu využívá | pasivní prvek (Business Object, Data Object, Artifact) |
| Notace | plná čára, otevřená šipka u uživatele | tečkovaná čára, šipka podle toku dat |
| Typická chyba | kreslit Serving od objektu k procesu | kreslit Access mezi dvěma prvky chování |

### ? Proces Schválení úvěru (Business Process) čte údaje z objektu Úvěrová žádost (Business Object) a zároveň využívá službu Ověření bonity (Business Service). Které dva vztahy situaci vystihují?

- [ ] objekt —serving→ proces; služba —serving→ proces
- [ ] proces —access (read)→ objekt; proces —access→ služba
- [ ] objekt —serving→ proces; proces —access (read)→ služba
- [x] proces —access (read)→ objekt; služba —serving→ proces

> S pasivním objektem proces pracuje přes Access, funkcionalitu služby využívá přes Serving od služby k procesu. Objekt nic neposkytuje, takže Serving od objektu je chybný, a Access ke službě nedává smysl, protože služba není pasivní prvek.

### ? Proč NELZE vztahem Serving propojit Business Object jako zdroj s Business Process?

- [x] Pasivní prvek nic neposkytuje; s objektem se pracuje přes Access
- [ ] Serving smí vést jen mezi prvky dvou různých vrstev architektury
- [ ] Serving je dynamický vztah a pasivní prvky nemají časové vazby
- [ ] Business Object smí být jen cílem vztahů Composition a Aggregation

> Pasivní struktura nevykonává chování ani neposkytuje funkcionalitu, proto se s ní propojuje vztahem Access od chování. Serving je závislostní vztah a běžně se používá i uvnitř jedné vrstvy.

## Vliv (Influence) {#influence .term}

**Influence** vyjadřuje, že prvek **ovlivňuje** dosažení či naplnění jiného prvku, aniž by jej plně realizoval — přispívá k němu, nebo mu naopak brání. Používá se hlavně mezi prvky Motivation (Goal, Requirement, Principle, Assessment…). Lze uvést znaménko a sílu vlivu (+, ++, −, −−) nebo vlastní popisek. **Notace:** **čárkovaná čára s otevřenou šipkou** u ovlivňovaného prvku. Proti Realization: realizace prvek naplňuje, influence jen přispívá. Podrobnosti o prvcích Motivation patří do tématu Strategy a Motivation.

*Příklad:* Zavést samoobslužný portál (Requirement) —influence (+)→ Snížit náklady na podporu (Goal).

### ? Požadavek „Zavést samoobslužný portál" přispívá ke snížení nákladů na podporu, ale cíl sám o sobě nezajistí. Který vztah zvolíte?

- [ ] Realization od požadavku k cíli
- [x] Influence (+) od požadavku k cíli
- [ ] Association bez směru mezi nimi
- [ ] Triggering od požadavku k cíli

> Influence vyjadřuje částečný příspěvek bez plného naplnění; znaménko + říká, že vliv je kladný. Realization by tvrdila, že požadavek cíl plně naplní, Association nenese žádný význam a Triggering se používá mezi prvky chování.

### ? Jak se v ArchiMate značí vztah Influence?

- [ ] Plná čára s otevřenou šipkou, volitelně s popiskem
- [ ] Tečkovaná čára se šipkou ve směru toku informací
- [x] Čárkovaná čára s otevřenou šipkou, volitelně se znaménkem
- [ ] Čárkovaná čára s prázdným trojúhelníkem u ovlivněného prvku

> Influence se kreslí čárkovanou čarou s otevřenou šipkou a může nést znaménko (+, −). Plná čára s otevřenou šipkou je Serving, tečkovaná čára Access a čárkovaná čára s prázdným trojúhelníkem Realization.

## Asociace (Association) {#association .term}

**Association** je **obecný, blíže neurčený vztah** mezi prvky; použije se, když vazbu nevystihuje žádný konkrétnější vztah. Je **povolena vždy**, mezi libovolnými dvěma prvky, a může spojit i prvek se vztahem (např. Business Object se vztahem Flow, aby bylo vidět, co teče). Výchozí je **neorientovaná**, lze ji však kreslit i jako orientovanou (určuje směr čtení). **Notace:** plná čára bez koncových značek, orientovaná varianta má malou poloviční šipku. Typicky ji používají i jiná témata, např. Gap asociovaný se dvěma Plateau.

### ? Kdy je vhodné použít vztah Association?

- [ ] Když jeden prvek časově předchází druhému a spouští jej
- [ ] Když prvek seskupuje jiné, které existují i samostatně
- [ ] Když jeden prvek poskytuje druhému svou funkcionalitu
- [x] Když vazbu nevystihuje žádný konkrétnější typ vztahu

> Association je obecný vztah pro vazby, které nelze vyjádřit konkrétnějším typem. Časovou návaznost vyjadřuje Triggering, seskupení samostatných prvků Aggregation a poskytování funkcionality Serving.

### ? Které tvrzení o vztahu Association v ArchiMate 3.2 platí?

- [x] Je povolena mezi libovolnými dvěma prvky a může být orientovaná
- [ ] Je povolena jen mezi prvky téže vrstvy a je vždy neorientovaná
- [ ] Patří mezi strukturální vztahy a je nejslabší z nich v odvozování
- [ ] Smí spojovat jen prvky Motivation a vždy nese znaménko + nebo −

> Association lze použít mezi jakýmikoli dvěma prvky a volitelně ji orientovat. Je to závislostní vztah, ne strukturální, a znaménko nese Influence, ne Association.

## Spouštění (Triggering) {#triggering .term}

**Triggering** vyjadřuje **časovou nebo příčinnou návaznost** mezi prvky chování a událostmi: po dokončení jednoho začne druhý, nebo událost spustí proces. **Notace:** **plná čára s plnou (vyplněnou) šipkou** u následujícího prvku. Typicky Business Event —triggering→ Business Process, Business Process —triggering→ Business Process nebo proces —triggering→ událost, kterou končí. Při větvení se kombinuje s Junction.

### ? Událost Přijetí objednávky zahajuje proces Zpracování objednávky. Který zápis je správný?

- [ ] Zpracování objednávky (Business Process) —triggering→ Přijetí objednávky (Business Event)
- [ ] Přijetí objednávky (Business Event) —serving→ Zpracování objednávky (Business Process)
- [x] Přijetí objednávky (Business Event) —triggering→ Zpracování objednávky (Business Process)
- [ ] Přijetí objednávky (Business Event) —assignment→ Zpracování objednávky (Business Process)

> Událost spouští proces, proto vede Triggering od události k procesu. Opačný směr by znamenal, že proces událostí končí, Serving vyjadřuje poskytování funkcionality a Assignment vede od aktivní struktury.

### ? Jak se v ArchiMate značí vztah Triggering?

- [x] Plná čára s plnou šipkou u následujícího prvku
- [ ] Čárkovaná čára s plnou šipkou u přijímajícího prvku
- [ ] Plná čára s otevřenou šipkou u využívajícího prvku
- [ ] Tečkovaná čára se šipkou u prvku, kam tečou data

> Triggering má plnou čáru a plnou šipku. Čárkovaná čára s plnou šipkou je Flow, plná čára s otevřenou šipkou Serving a tečkovaná čára Access.

## Tok (Flow) {#flow .term}

**Flow** vyjadřuje **přenos** něčeho (informace, zboží, peněz, materiálu) od jednoho prvku chování k jinému. Neříká, že příjemce začne až po zdroji — jen že mezi nimi něco putuje. **Notace:** **čárkovaná čára s plnou šipkou** u příjemce; co teče, lze uvést popiskem nebo asociací vztahu s pasivním prvkem. Typicky mezi procesy a funkcemi, v aplikační vrstvě pro výměnu dat mezi aplikačními funkcemi a komponentami.

### ? Funkce Sklad průběžně předává údaje o zásobách funkci Nákup, aniž by tím Nákup spouštěla. Který zápis situaci vystihuje?

- [ ] Sklad (Business Function) —triggering→ Nákup (Business Function)
- [x] Sklad (Business Function) —flow→ Nákup (Business Function)
- [ ] Sklad (Business Function) —serving→ Nákup (Business Function)
- [ ] Nákup (Business Function) —flow→ Sklad (Business Function)

> Předávání údajů bez příčinné návaznosti je Flow od zdroje k příjemci. Triggering by tvrdil, že Sklad Nákup spouští, Serving vyjadřuje poskytování funkcionality a obrácený Flow má chybný směr.

### ? Jak se v ArchiMate značí vztah Flow?

- [ ] Plná čára s plnou šipkou u příjemce
- [ ] Tečkovaná čára s otevřenou šipkou u příjemce
- [ ] Čárkovaná čára s otevřenou šipkou u příjemce
- [x] Čárkovaná čára s plnou šipkou u příjemce

> Flow má čárkovanou čáru a plnou šipku. Plná čára s plnou šipkou je Triggering, čárkovaná čára s otevřenou šipkou Influence.

## Triggering × Flow {#triggering-vs-flow .compare}

Oba vztahy jsou dynamické a vedou mezi prvky chování (případně událostmi), vyjadřují však jinou věc.

| Hledisko | Triggering | Flow |
|---|---|---|
| Význam | příčinná či časová návaznost — B začne po A | přenos obsahu — A předává B informaci, věc, peníze |
| Otázka | Co následuje? | Co se předává? |
| Notace | plná čára, plná šipka | čárkovaná čára, plná šipka |
| Příklad | Přijetí objednávky (Business Event) —triggering→ Kontrola objednávky (Business Process) | Fakturace (Business Function) —flow→ Účetnictví (Business Function), popisek „faktury" |

### ? Které tvrzení správně odlišuje Triggering od Flow?

- [ ] Triggering přenáší data, Flow určuje pořadí kroků procesu
- [ ] Triggering je strukturální vztah, Flow je vztah dynamický
- [ ] Triggering spojuje jen aplikace, Flow jen business procesy
- [x] Triggering vyjadřuje příčinnou návaznost, Flow přenos obsahu

> Triggering říká, co po čem následuje, Flow co se mezi prvky předává. Oba jsou dynamické a lze je použít v kterékoli vrstvě.

### ? Proces Vystavení faktury předává faktury procesu Zaúčtování, který však běží jednou denně nezávisle na vystavení. Který vztah mezi procesy zvolíte?

- [x] Flow, protože jde o předání obsahu bez spouštění
- [ ] Triggering, protože zaúčtování logicky následuje
- [ ] Serving, protože vystavení poskytuje data zaúčtování
- [ ] Access, protože zaúčtování čte vystavené faktury

> Zaúčtování není spouštěno vystavením, jen dostává faktury, proto je správně Flow. Triggering by vyjadřoval příčinnou návaznost, Serving poskytování funkcionality a Access vede k pasivnímu prvku, ne mezi dvěma procesy.

## Specializace (Specialization) {#specialization .term}

**Specialization** vyjadřuje, že prvek je **zvláštním případem (podtypem)** jiného prvku — přebírá jeho vlastnosti a upřesňuje je. Smí spojovat jen prvky **stejného typu** (Business Process s Business Process, Business Object s Business Object). **Notace:** **plná čára s prázdným trojúhelníkem** u obecnějšího prvku; směr vede od speciálního k obecnému. Pozor na záměnu s Realization, která má stejný trojúhelník, ale čárkovanou čáru. Specializace typů prvků při přizpůsobení jazyka patří do tématu Viewpointy.

*Příklad:* Zálohová faktura (Business Object) —specialization→ Faktura (Business Object).

### ? Která dvojice prvků může být spojena vztahem Specialization?

- [ ] Faktura (Business Object) a Faktura PDF (Artifact)
- [x] Faktura (Business Object) a Zálohová faktura (Business Object)
- [ ] Fakturace (Business Process) a Fakturace (Application Process)
- [ ] Účetní (Business Role) a Jana Nováková (Business Actor)

> Specialization smí spojovat jen prvky stejného typu, zde dva Business Object. Ostatní dvojice tvoří prvky různých typů; vztahy mezi nimi jsou jiné (např. Realization nebo Assignment).

### ? Plná čára s prázdným trojúhelníkem u cílového prvku znamená v ArchiMate vztah…

- [ ] Realization
- [ ] Aggregation
- [x] Specialization
- [ ] Composition

> Plná čára s prázdným trojúhelníkem je Specialization. Realization má stejný trojúhelník, ale čárkovanou čáru; Aggregation a Composition mají kosočtverec u celku.

## Spojovník (Junction) {#junction .term}

**Junction** je **spojovník vztahů** (relationship connector), ne samostatný vztah ani prvek. Spojuje několik vztahů **téhož typu** a umožňuje vyjádřit větvení a slučování. **And Junction** (plný kroužek) — platí všechny větve současně. **Or Junction** (prázdný kroužek) — platí jen některá z větví, jde o alternativu či rozhodnutí. Nejčastěji se používá u Triggering a Flow.

*Příklad:* Kontrola objednávky (Business Process) —triggering→ Or Junction —triggering→ Expedice (Business Process) a zároveň Or Junction —triggering→ Zamítnutí objednávky (Business Process).

### ? Co je v ArchiMate Junction?

- [ ] Zvláštní dynamický vztah pro modelování paralelních činností
- [x] Spojovník, který propojuje více vztahů stejného typu
- [ ] Kompozitní prvek kategorie Other, který seskupuje koncepty
- [ ] Odvozený vztah, který vznikne zkrácením řetězce vztahů

> Junction je relationship connector — není to vztah ani prvek, jen spojuje vztahy téhož typu. Seskupování konceptů zajišťuje Grouping a zkrácený řetězec vztahů je odvozený vztah.

### ? Po schválení žádosti mají začít současně dva procesy: Odeslání smlouvy a Založení účtu. Čím rozvětvíte vztah Triggering?

- [x] And Junction
- [ ] Or Junction
- [ ] Business Event
- [ ] Grouping

> Obě větve platí současně, proto se použije And Junction. Or Junction vyjadřuje alternativu, Business Event je prvek chování a Grouping jen seskupuje prvky.

### ? Jak se v ArchiMate rozliší And Junction a Or Junction?

- [x] And Junction je plný kroužek, Or Junction prázdný kroužek
- [ ] And Junction je prázdný kroužek, Or Junction plný kroužek
- [ ] And Junction je kosočtverec, Or Junction je kroužek
- [ ] Oba vypadají stejně, liší se jen textovým popiskem

> And Junction se kreslí jako plný (vyplněný) kroužek, Or Junction jako prázdný kroužek. Kosočtverec je značka Composition a Aggregation.

## Vnoření (Nesting) {#vnoreni .explain}

Místo čáry lze vztah v pohledu vyjádřit **vnořením** — prvek je nakreslen uvnitř jiného prvku. Používá se hlavně pro strukturální vztahy, nejčastěji pro Composition a Aggregation. Výhodou je přehlednost, nevýhodou, že z obrázku **není vidět, který vztah** vnoření znamená — v modelu proto musí být uložen konkrétní vztah. Vnoření nemění význam modelu, je to jen grafická zkratka.

*Příklad:* Uvnitř obdélníku ERP (Application Component) jsou nakresleny moduly Fakturace a Sklad; v modelu tomu odpovídá ERP (Application Component) —composition→ Fakturace (Application Component) a ERP —composition→ Sklad (Application Component).

### ? Co je hlavní nevýhodou znázornění vztahu vnořením?

- [ ] Vnořené prvky nelze použít v žádném jiném pohledu modelu
- [x] Z obrázku není zřejmé, jaký typ vztahu vnoření znamená
- [ ] Vnoření automaticky mění každý vztah na Composition
- [ ] Vnořit lze jen prvky ze dvou různých vrstev architektury

> Vnoření je grafická zkratka, která sama neříká, zda jde o Composition, Aggregation či jiný vztah; ten musí být v modelu. Vnořený prvek lze použít i v jiných pohledech a vnoření není omezeno na různé vrstvy.

## Odvozování vztahů (Derivation) {#odvozovani .explain}

**Odvozování** umožňuje z **řetězce vztahů** A → B → C získat přímý vztah A → C bez kreslení mezilehlých prvků. Využívá se v přehledových pohledech (např. „aplikace slouží procesu") a při kontrole konzistence modelu. Platně odvozený vztah je jen důsledkem existujících vztahů a nepřináší novou informaci. Specifikace rozlišuje **platné (valid)** odvození, které platí vždy, a **potenciální (potential)**, které platit může, ale modelář je musí ověřit.

*Příklad:* CRM (Application Component) —assignment→ Správa kontaktů (Application Function) —realization→ Evidence klientů (Application Service) —serving→ Prodej (Business Process) ⇒ CRM (Application Component) —serving→ Prodej (Business Process).

### ? K čemu slouží odvozování vztahů (derivation) v ArchiMate?

- [x] K získání přímého vztahu z řetězce vztahů přes mezilehlé prvky
- [ ] K automatickému doplnění nových prvků, které v modelu chybějí
- [ ] K převodu modelu ArchiMate do notace BPMN nebo do notace UML
- [ ] K určení viewpointu, který je pro daného stakeholdera vhodný

> Odvozování zkracuje řetězce vztahů na přímý vztah, což zjednodušuje pohledy a pomáhá kontrolovat model. Nové prvky nevytváří, s převodem do jiných notací ani s výběrem viewpointu nesouvisí.

### ? V modelu platí: CRM (Application Component) —assignment→ Správa kontaktů (Application Function) —realization→ Evidence klientů (Application Service) —serving→ Prodej (Business Process). Jaký přímý vztah lze z CRM k procesu Prodej odvodit?

- [ ] Realization
- [ ] Assignment
- [x] Serving
- [ ] Triggering

> Assignment a Realization jsou strukturální vztahy a závěrečný Serving se po nich „posune" až ke komponentě, takže CRM slouží procesu Prodej. Strukturální vztah se zde neodvodí, protože řetěz končí závislostním vztahem, a Triggering v řetězci vůbec není.

## Odvozování strukturálních vztahů {#odvozeni-strukturalni .explain}

Navazující řetěz **strukturálních** vztahů (cíl jednoho je zdrojem dalšího) lze nahradit jedním strukturálním vztahem, a to tím **nejslabším** v řetězci. Pořadí síly: **Composition > Aggregation > Assignment > Realization**.

- A —composition→ B —assignment→ C ⇒ A —assignment→ C
- A —aggregation→ B —composition→ C ⇒ A —aggregation→ C
- A —assignment→ B —realization→ C ⇒ A —realization→ C

*Příklad:* ERP (Application Component) —composition→ Fakturace (Application Component) —assignment→ Vystavování faktur (Application Function) ⇒ ERP (Application Component) —assignment→ Vystavování faktur (Application Function).

### ? Jaké je pořadí strukturálních vztahů od nejsilnějšího k nejslabšímu?

- [x] Composition, Aggregation, Assignment, Realization
- [ ] Aggregation, Composition, Realization, Assignment
- [ ] Composition, Assignment, Aggregation, Realization
- [ ] Realization, Assignment, Aggregation, Composition

> Nejsilnější je Composition, následuje Aggregation, pak Assignment a nejslabší je Realization. Toto pořadí určuje výsledek odvození z řetězce strukturálních vztahů.

### ? V modelu platí Portál (Application Component) —composition→ Přihlašování (Application Component) a Přihlašování —assignment→ Ověření identity (Application Function). Jaký vztah lze odvodit z Portálu k Ověření identity?

- [ ] Composition
- [x] Assignment
- [ ] Aggregation
- [ ] Serving

> Z řetězce strukturálních vztahů se odvodí ten nejslabší; Assignment je slabší než Composition, takže Portál —assignment→ Ověření identity. Aggregation v řetězci není a Serving není strukturální vztah.

### ? Komponenta Účetnictví (Application Component) vykonává funkci Zaúčtování (Application Function) a ta realizuje službu Zaúčtování dokladu (Application Service). Jaký přímý vztah lze odvodit mezi komponentou a službou?

- [ ] Assignment
- [ ] Serving
- [ ] Composition
- [x] Realization

> Řetěz Assignment → Realization dává nejslabší z obou, tedy Realization: komponenta službu realizuje. Assignment je silnější než Realization, Serving ani Composition v řetězci nejsou.

## Odvozování se závislostními vztahy {#odvozeni-zavislosti .explain}

Závislostní vztah na konci řetězce (typicky **Serving**) lze „posunout" po předchozích **strukturálních** vztazích: když A je s B spojen strukturálně (A vykonává, realizuje nebo obsahuje B) a B slouží C, platí i **A —serving→ C**. Výsledný vztah má typ závislostního vztahu, ne strukturálního. Dynamický vztah (Triggering, Flow) mezi dvěma prvky chování lze zobrazit i mezi aktivní strukturou, která je k nim přiřazena (assignment) — např. Flow mezi funkcemi dvou komponent jako Flow mezi komponentami. U složitějších kombinací (změna směru, části celku) jde často jen o **potenciální** odvození.

*Příklad:* Platební brána (Application Component) —realization→ Platba kartou (Application Service) —serving→ Objednávka (Business Process) ⇒ Platební brána (Application Component) —serving→ Objednávka (Business Process). U dynamických vztahů: Fakturace (Application Component) —assignment→ Vystavení faktury (Application Function) —flow→ Zaúčtování (Application Function) a Účetnictví (Application Component) —assignment→ Zaúčtování ⇒ Fakturace (Application Component) —flow→ Účetnictví (Application Component).

### ? V modelu platí Platební brána (Application Component) —realization→ Platba kartou (Application Service) a Platba kartou —serving→ Objednávka (Business Process). Jaký vztah lze platně odvodit?

- [ ] Objednávka (Business Process) —serving→ Platební brána (Application Component)
- [ ] Platební brána (Application Component) —realization→ Objednávka (Business Process)
- [ ] Platební brána (Application Component) —assignment→ Objednávka (Business Process)
- [x] Platební brána (Application Component) —serving→ Objednávka (Business Process)

> Serving se po strukturálním vztahu Realization přenese ke komponentě: brána slouží procesu Objednávka. Odvozený vztah zachovává směr řetězce a typ závislostního vztahu, proto nevznikne obrácený Serving, Realization ani Assignment.

### ? Řetězec vztahů obsahuje nejprve několik strukturálních vztahů a na konci vztah Serving. Jakého typu je platně odvozený přímý vztah?

- [x] Serving
- [ ] Nejslabší strukturální vztah řetězce
- [ ] Composition
- [ ] Association

> Když řetěz strukturálních vztahů končí vztahem Serving, odvodí se Serving. Pravidlo nejslabšího článku platí jen pro řetězce složené výhradně ze strukturálních vztahů.

## Platné × potenciální odvození (valid × potential derivation) {#valid-vs-potential .compare}

| Hledisko | Platné (valid) | Potenciální (potential) |
|---|---|---|
| Platnost | vždy, plyne z pravidel jazyka | jen možná, záleží na konkrétní situaci |
| Kdo rozhoduje | pravidla odvozování | modelář musí vztah ověřit |
| Typické případy | řetěz strukturálních vztahů (nejslabší článek); strukturální vztahy zakončené vztahem Serving | kombinace, u nichž z modelu nevyplývá, zda vazba platí pro všechny části či situace |
| Použití v nástroji | nástroje mohou platné vztahy nabízet automaticky (závisí na nástroji) | modelář musí vztah před použitím posoudit |

### ? Čím se potenciální (potential) odvození liší od platného (valid)?

- [ ] Potenciální odvození platí vždy, platné jen v některých pohledech
- [x] Potenciální vztah platit může, ale modelář jej musí ověřit
- [ ] Potenciální odvození se týká jen vztahů mezi různými vrstvami
- [ ] Potenciální vztah vzniká výhradně z řetězce vztahů Composition

> Platné odvození platí vždy, potenciální jen může platit a je nutné je posoudit v kontextu modelu. Rozlišení nesouvisí s vrstvami ani s jedním typem vztahu.

### ? Nástroj nabídl analytikovi vztah, který je podle pravidel jazyka jen potenciálním odvozením. Jak má analytik postupovat?

- [ ] Použít jej bez ověření, protože jej vytvořila pravidla jazyka
- [ ] Vždy jej smazat, protože potenciální vztahy jsou v modelu zakázané
- [x] Ověřit, zda vazba ve skutečnosti platí, a teprve pak ji použít
- [ ] Převést jej na Association, která potenciální vztahy nahrazuje

> Potenciální odvození je jen kandidát — modelář musí posoudit, zda v dané situaci platí. Nejsou zakázané ani automaticky platné a převod na Association by význam vztahu ztratil.
