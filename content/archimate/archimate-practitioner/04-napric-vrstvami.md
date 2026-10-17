---
kind: topic
subject: archimate-practitioner
slug: napric-vrstvami
name: "Modely napříč vrstvami ve scénářích"
order: 4
---

Layered view, propojení business–aplikace–technologie, správné použití serving × realization × access.

## Layered view {#layered-view .explain}

Layered viewpoint je příkladový viewpoint, který v jednom pohledu ukazuje více vrstev (nebo všechny) a vazby mezi nimi. Pohled se obvykle kreslí ve vodorovných pásech shora dolů: zákazníci a role → business služby → business procesy → aplikační služby → aplikační komponenty → technologické služby → nody. Hodí se pro přehled, jak je podnikání podporováno IT, a pro analýzu dopadu změny nebo výpadku. Aby zůstal čitelný, zužuje se na jeden rozsah (proces, produkt, útvar) a podrobnosti se nechávají jiným pohledům.

*Příklad:* `Aplikační cluster (Node) —realization→ Hostování aplikací (Technology Service) —serving→ Kalkulačka (Application Component) —realization→ Výpočet pojistného (Application Service) —serving→ Sjednání pojištění (Business Process)`; `Poradce (Business Role) —assignment→ Sjednání pojištění (Business Process)`.

### ? CIO pojišťovny chce na jednom obrázku vidět, jak je proces likvidace pojistných událostí podporován aplikacemi a jaké technologické služby a servery tyto aplikace potřebují. Který viewpoint je nejvhodnější?

- [ ] Application Cooperation viewpoint
- [ ] Organization viewpoint
- [x] Layered viewpoint
- [ ] Technology viewpoint

> Layered viewpoint spojuje business, aplikační i technologickou vrstvu v jednom pohledu, což CIO požaduje. Application Cooperation ukazuje vazby mezi aplikacemi, Organization strukturu organizace a Technology viewpoint jen technologickou infrastrukturu bez vazby na proces.

### ? Architekt nakreslil Layered view celé banky se 400 prvky; představenstvo se v něm nevyzná. Co je nejlepší úprava?

- [ ] Odstranit z pohledu celou technologickou vrstvu a ponechat jen business a aplikace
- [x] Zúžit pohled na jeden rozsah, např. jeden proces, a detail nechat jiným pohledům
- [ ] Nahradit všechny vztahy vztahem association, aby byl obrázek jednodušší
- [ ] Rozdělit prvky do samostatných modelů podle vrstev bez vzájemných vazeb

> Layered view zůstává čitelný, když se omezí na jeden rozsah a podrobnosti přenechá jiným pohledům téhož modelu. Odstranění vrstvy popírá smysl vrstveného pohledu, association vazby zbaví významu a oddělené modely ztratí právě mezivrstvové vazby.

### ? Architekt chce v Layered view propojit vrstvy tak, aby každá vrstva ukazovala vyšší vrstvě jen to, co jí nabízí, a ne své vnitřní uspořádání. Které prvky mají tvořit spoj mezi vrstvami?

- [ ] Grouping každé vrstvy propojený vztahem association s vrstvou nad ní
- [ ] Aktivní struktura nižší vrstvy přiřazená (assignment) k prvkům vyšší vrstvy
- [ ] Pasivní prvky, které si vrstvy předávají vztahem flow
- [x] Služby (business, application, technology service) se vztahem serving

> Služby jsou externí chování, které vrstva nabízí, a serving je napojí na uživatele ve vyšší vrstvě — vnitřní funkce a struktura zůstanou skryté. Grouping s association nic nevyjadřuje, assignment mezi vrstvami neukazuje poskytování a pasivní prvky se mezi vrstvami propojují realizací, ne předáváním.

## Služby jako rozhraní mezi vrstvami {#sluzby-mezi-vrstvami .explain}

Každá vrstva slouží vyšší vrstvě prostřednictvím služeb: technologické služby slouží aplikacím, aplikační služby business procesům a business služby zákazníkům. Uvnitř vrstvy platí stejný vzor — aktivní struktura je přiřazena k internímu chování a to realizuje službu; zkráceně lze psát i `Application Component —realization→ Application Service`. Výhoda: když se vymění aplikace nebo infrastruktura, vyšší vrstva se nemění, změní se jen to, co službu realizuje.

*Příklad:* `Tisk (Technology Service) —serving→ Fakturace (Application Component) —realization→ Vystavení faktury (Application Service) —serving→ Fakturace zákazníkům (Business Process)`.

### ? Firma tiskne faktury přes centrální tiskovou službu. Fakturační aplikace nabízí účetním službu Vystavení faktury, kterou využívají v procesu Fakturace zákazníkům. Který řetězec je správný?

- [x] `Tisk (Technology Service) —serving→ Fakturace (Application Component) —realization→ Vystavení faktury (Application Service) —serving→ Fakturace zákazníkům (Business Process)`
- [ ] `Tisk (Technology Service) —realization→ Fakturace (Application Component) —serving→ Vystavení faktury (Application Service) —realization→ Fakturace zákazníkům (Business Process)`
- [ ] `Fakturace (Application Component) —serving→ Tisk (Technology Service)`; `Fakturace zákazníkům (Business Process) —serving→ Vystavení faktury (Application Service)`
- [ ] `Tisk (Technology Service) —serving→ Vystavení faktury (Application Service) —realization→ Fakturace (Application Component) —serving→ Fakturace zákazníkům (Business Process)`

> Technologická služba slouží komponentě, komponenta realizuje svou aplikační službu a ta slouží business procesu. Druhá možnost prohazuje serving a realization, třetí obrací směr obou serving a čtvrtá staví službu do role toho, kdo realizuje komponentu.

### ? Firma nahrazuje starý CRM novým systémem; obchodníci budou nadále používat stejnou funkcionalitu Správa kontaktů. Architekt chce, aby se business část modelu změnou nedotkla. Jak má být model postaven?

- [ ] Business proces napojit vztahem serving přímo na nody, na kterých starý i nový CRM běží
- [ ] Business proces napojit vztahem association na starý i nový CRM současně
- [x] Proces obsluhuje Application Service Správa kontaktů; mění se jen její realizace
- [ ] Nový CRM namodelovat jako Business Actor, aby byl v modelu co nejblíž obchodníkům

> Aplikační služba odstiňuje business vrstvu od konkrétní aplikace: při náhradě se změní jen realizace služby, vztah serving k procesu zůstane. Vazba na nody tuto vazbu obchází, association nemá jasný význam a aplikace není business aktér.

## Serving × Realization × Access mezi vrstvami {#serving-realization-access .compare}

Tři nejčastější vztahy napříč vrstvami vyjadřují tři různé věci; záměna mezi nimi je nejčastější chyba v modelech.

| Vztah | Co vyjadřuje | Typické použití napříč vrstvami | Typická chyba |
|---|---|---|---|
| serving | nižší vrstva poskytuje funkcionalitu uživateli ve vyšší vrstvě (od poskytovatele k uživateli) | Application Service → Business Process; Technology Service → Application Component; Application Interface → Business Role | obrácený směr; serving tam, kde aplikace proces plně uskutečňuje |
| realization | konkrétnější prvek uskutečňuje abstraktnější (od fyzického / automatizovaného k logickému) | Application Process → Business Process (automatizace); Data Object → Business Object; Artifact → Data Object, Application Component | realization tam, kde aplikace člověku jen pomáhá |
| access | chování čte nebo zapisuje pasivní prvek (vztah vede od chování k objektu) | Business Process → Business Object; Application Function → Data Object; Technology Process → Artifact | access mezi dvěma pasivními prvky nebo od objektu k chování |

### ? Business analytici mají v modelu Business Object Faktura. V ERP existuje Data Object Faktura, který tuto obchodní informaci uchovává v elektronické podobě. Jaký vztah má vést od Data Object k Business Object?

- [ ] Access, protože ERP s fakturou pracuje
- [ ] Serving, protože data slouží obchodu
- [ ] Aggregation, protože data jsou součástí informace
- [x] Realization, protože data informaci uskutečňují

> Data Object je elektronická podoba obchodní informace, proto Business Object realizuje. Access vede od chování k pasivnímu prvku, ne mezi dvěma pasivními prvky, serving je pro poskytování funkcionality a aggregation celek–část v různých vrstvách tento vztah nevystihuje.

### ? Úvěrový referent v bance provádí proces Schválení úvěru. Během něj ručně spouští aplikační službu Výpočet skóre a podle výsledku rozhoduje. Jaký vztah má vést od Výpočtu skóre k procesu?

- [x] Serving, protože služba referentovi v procesu pomáhá
- [ ] Realization, protože služba proces uskutečňuje
- [ ] Access, protože proces používá výsledek výpočtu
- [ ] Triggering, protože výpočet spouští rozhodnutí

> Proces vykonává člověk a aplikační služba mu jen pomáhá — to je serving. Realization by znamenala, že aplikace proces plně uskutečňuje, access vede k pasivním prvkům a triggering vyjadřuje časovou návaznost, ne podporu.

### ? Aplikační funkce Výpočet pojistného při každém výpočtu načítá Data Object Tarif, který sama nemění. Který fragment je správný?

- [ ] `Výpočet pojistného (Application Function) —realization→ Tarif (Data Object)`
- [ ] `Výpočet pojistného (Application Function) —access (write)→ Tarif (Data Object)`
- [x] `Výpočet pojistného (Application Function) —access (read)→ Tarif (Data Object)`
- [ ] `Tarif (Data Object) —serving→ Výpočet pojistného (Application Function)`

> Čtení se modeluje jako access od funkce k datovému objektu s režimem read (v diagramu šipka míří k funkci, protože data tečou k ní). Realization by tvrdila, že funkce tarif uskutečňuje, write by znamenal změnu tarifu a pasivní prvek funkci neposkytuje funkcionalitu.

## Aplikace podporuje proces (serving) {#podpora-procesu .explain}

Když proces vykonávají lidé a aplikace jim jen pomáhá, platí vzor: `Business Role —assignment→ Business Process` a `Application Service —serving→ Business Process`. Business vrstva tak ukazuje, *kdo* proces dělá, aplikační vrstva, *čím* mu pomáhá. Pokud záleží i na tom, přes jaké uživatelské rozhraní role s aplikací pracuje, přidá se `Application Interface —serving→ Business Role`. Směr serving vždy vede od aplikace (poskytovatele) k procesu (uživateli).

*Příklad:* `Operátor (Business Role) —assignment→ Vyřízení reklamace (Business Process)`; `Evidence reklamací (Application Service) —serving→ Vyřízení reklamace (Business Process)`.

### ? V call centru e-shopu vyřizují operátoři reklamace. Při tom používají aplikaci, která jim nabízí službu Evidence reklamací. Architekt chce ukázat, kdo proces vykonává a čím je podporován. Který fragment je správný?

- [ ] `Operátor (Business Role) —serving→ Vyřízení reklamace (Business Process)`; `Evidence reklamací (Application Service) —assignment→ Vyřízení reklamace (Business Process)`
- [x] `Operátor (Business Role) —assignment→ Vyřízení reklamace (Business Process)`; `Evidence reklamací (Application Service) —serving→ Vyřízení reklamace (Business Process)`
- [ ] `Operátor (Business Role) —assignment→ Vyřízení reklamace (Business Process)`; `Evidence reklamací (Application Service) —realization→ Vyřízení reklamace (Business Process)`
- [ ] `Vyřízení reklamace (Business Process) —assignment→ Operátor (Business Role)`; `Vyřízení reklamace (Business Process) —serving→ Evidence reklamací (Application Service)`

> Role vykonává proces (assignment od role k procesu) a aplikační služba mu slouží (serving). První možnost prohazuje oba vztahy, třetí tvrdí, že aplikace proces plně automatizuje, a čtvrtá obrací směr obou vztahů.

### ? Ve stavební spořitelně procházejí poradci proces Sjednání smlouvy. Aplikace jim nabízí službu Výpočet úspory, kterou během schůzky s klientem spouštějí. Který vztah mezi službou a procesem je správný?

- [ ] `Sjednání smlouvy (Business Process) —serving→ Výpočet úspory (Application Service)`
- [ ] `Výpočet úspory (Application Service) —realization→ Sjednání smlouvy (Business Process)`
- [ ] `Výpočet úspory (Application Service) —access→ Sjednání smlouvy (Business Process)`
- [x] `Výpočet úspory (Application Service) —serving→ Sjednání smlouvy (Business Process)`

> Aplikační služba pomáhá poradcům v procesu, tedy mu slouží; směr vede od poskytovatele k uživateli. Obrácený serving tvrdí, že proces slouží aplikaci, realization by znamenala plnou automatizaci a access vede k pasivním prvkům, ne k procesu.

### ? Tým logistické firmy namodeloval: `Plánování rozvozu (Business Process) —serving→ Optimalizace tras (Application Service)`. Dispečeři přitom při plánování používají optimalizaci tras jako pomůcku. Co je nejlepší oprava?

- [x] Otočit směr serving: od Optimalizace tras k Plánování rozvozu
- [ ] Nahradit serving vztahem realization od Plánování rozvozu k Optimalizaci tras
- [ ] Změnit Optimalizaci tras na Business Service, aby byla ve stejné vrstvě jako proces
- [ ] Nahradit serving vztahem flow od Plánování rozvozu k Optimalizaci tras

> Poskytovatelem je aplikační služba a uživatelem proces dispečerů, takže serving má vést od služby k procesu. Realization od procesu ke službě nedává smysl, optimalizaci tras zajišťuje aplikace (není to business služba) a flow vyjadřuje předání informace, ne podporu.

## Automatizace procesu (realization) {#automatizace-procesu .explain}

Když proces probíhá **plně automaticky** bez lidského zásahu, platí vzor `Application Process —realization→ Business Process` (u funkcí obdobně `Application Function —realization→ Business Function`). Business proces z modelu nemizí — popisuje, *co* podnik dělá, a aplikační proces, *jak* se to děje automaticky; aplikační komponenta je přiřazena k aplikačnímu procesu. Žádná business role se k automatizovanému procesu nepřiřazuje jako vykonavatel. Obdobně `Data Object —realization→ Business Object` vyjadřuje, že obchodní informace existuje v elektronické podobě.

*Příklad:* `E-shop (Application Component) —assignment→ Automatické potvrzení (Application Process) —realization→ Potvrzení objednávky (Business Process)`.

### ? V e-shopu se objednávka po zaplacení potvrzuje zcela automaticky — systém ověří platbu, rezervuje zboží a pošle e-mail, nikdo z lidí nezasahuje. Business analytik chce zachovat business proces Potvrzení objednávky. Který fragment je správný?

- [ ] `Automatické potvrzení (Application Process) —serving→ Potvrzení objednávky (Business Process)`
- [ ] `Potvrzení objednávky (Business Process) —realization→ Automatické potvrzení (Application Process)`
- [x] `Automatické potvrzení (Application Process) —realization→ Potvrzení objednávky (Business Process)`
- [ ] `Automatické potvrzení (Application Process) —triggering→ Potvrzení objednávky (Business Process)`

> Plná automatizace se vyjadřuje realizací business procesu aplikačním procesem. Serving by znamenal, že aplikace jen pomáhá lidem, obrácená realization převrací význam a triggering vyjadřuje, že jeden proces následuje po druhém, ne že ho uskutečňuje.

### ? Energetická firma vystavuje měsíční vyúčtování dávkově a plně automaticky, nikdo z lidí do procesu nezasahuje. Junior architekt chce k business procesu Vyúčtování přiřadit business roli Fakturant. Co je nejlepší doporučení?

- [ ] Přiřadit roli Fakturant, protože každý business proces musí mít vykonavatele
- [x] Roli nepřiřazovat; aplikační proces realizuje business proces
- [ ] Business proces smazat a ponechat jen aplikační proces fakturace
- [ ] Přiřadit roli Fakturant a doplnit serving od aplikační služby k procesu

> U plně automatizovaného procesu je vykonavatelem aplikace: aplikační proces realizuje business proces a komponenta je přiřazena k aplikačnímu procesu. Fiktivní role by zkreslila skutečnost, smazáním business procesu by zmizelo, co podnik dělá, a serving se hodí pro podporu lidí, ne pro automat.

### ? Pojišťovna plně automatizovala proces Přijetí žádosti o pojištění. Člen týmu navrhuje business proces z modelu odstranit, protože ho teď „dělá aplikace". Jak má architekt reagovat?

- [ ] Souhlasit a business proces nahradit aplikačním procesem ve stejném místě modelu
- [ ] Souhlasit a business proces změnit na typ Application Process
- [ ] Business proces nahradit business službou, kterou aplikace realizuje
- [x] Business proces ponechat a doplnit aplikační proces, který ho realizuje

> Business proces popisuje, co podnik dělá, a to se automatizací nemění; automatizace se vyjádří realizací business procesu aplikačním procesem. Odstranění nebo změna typu by smazaly business pohled a business služba je externí nabídka, ne náhrada procesu.

## Podpora × plná × částečná automatizace {#podpora-vs-automatizace .compare}

Volba vztahu mezi aplikací a business procesem odpovídá na otázku, kdo proces vykonává.

| | Podpora | Plná automatizace | Částečná automatizace |
|---|---|---|---|
| Kdo vykonává | člověk (business role) | aplikace | část kroků člověk, část aplikace |
| Vzor | `Application Service —serving→ Business Process` | `Application Process —realization→ Business Process` | proces rozdělit na podprocesy (composition); automatické realizuje aplikační proces, ručním slouží aplikační služby |
| Role k procesu | ano (assignment) | ne | jen k ručním podprocesům |
| Chyba | realization u procesu, který dělají lidé | serving u procesu bez lidí | jediný vztah pro celý smíšený proces |

### ? Proces Poskytnutí úvěru má tři kroky: referent zadá žádost do aplikace, systém bez zásahu člověka vypočte skóre a manažer úvěr schválí. Který způsob modelování je nejlepší?

- [ ] Celý proces realizuje aplikační proces, protože klíčový krok skóre počítá systém
- [ ] Celému procesu slouží aplikační služba a skóre se samostatně nemodeluje
- [x] Rozdělit na podprocesy: skóre realizuje aplikační proces, zbytku slouží služby
- [ ] Referenta i manažera přiřadit k aplikačnímu procesu výpočtu skóre

> Smíšený proces se rozdělí na podprocesy, aby automatický krok mohl být realizován aplikací a ruční kroky podporovány službami. Realizace celého procesu by popřela práci lidí, samotný serving by skryl automatizaci a business role se k aplikačnímu procesu nepřiřazují.

### ? Účtárna dnes přepisuje přijaté faktury ručně s pomocí aplikace. Projekt zavede OCR, které faktury zpracuje zcela samo. Jak se má v cílovém modelu změnit vazba mezi aplikací a business procesem Přijetí faktury?

- [x] Ze serving aplikační služby k procesu na realization procesu aplikačním procesem
- [ ] Z realization procesu aplikačním procesem na serving aplikační služby k procesu
- [ ] Ze serving aplikační služby k procesu na access z aplikační služby k business procesu
- [ ] Vazba zůstane stejná, změní se jen název aplikační služby

> Dnešní stav (člověk s pomocí aplikace) je podpora vyjádřená serving; cílový stav bez lidí je plná automatizace vyjádřená realization. Opačná změna popisuje přechod obráceným směrem, access vede k pasivním prvkům a ponechání vazby by změnu nezachytilo.

## Informace napříč vrstvami {#informace-napric-vrstvami .explain}

Tatáž informace se ve vrstvách objevuje v různé podobě a vrstvy spojuje **realization**: `Artifact —realization→ Data Object —realization→ Business Object`. Business Object je obchodní pojem (Smlouva), Data Object jeho elektronická podoba zpracovatelná aplikací, Artifact fyzické uložení (databáze, soubor). Typické chyby: dva stejně pojmenované objekty v různých vrstvách bez vazby, access mezi nimi (access nespojuje dva pasivní prvky) nebo obrácený směr realizace.

*Příklad:* `SMLOUVY_DB (Artifact) —realization→ Smlouva (Data Object) —realization→ Smlouva (Business Object)`.

### ? Banka chce u obchodního pojmu Úvěrová smlouva ukázat, ve kterém datovém objektu úvěrového systému je evidován a ve které databázi je fyzicky uložen. Který řetězec je správný?

- [ ] `Úvěrová smlouva (Business Object) —realization→ Smlouva (Data Object) —realization→ UVERY_DB (Artifact)`
- [ ] `UVERY_DB (Artifact) —access→ Smlouva (Data Object) —access→ Úvěrová smlouva (Business Object)`
- [x] `UVERY_DB (Artifact) —realization→ Smlouva (Data Object) —realization→ Úvěrová smlouva (Business Object)`
- [ ] `UVERY_DB (Artifact) —serving→ Smlouva (Data Object) —serving→ Úvěrová smlouva (Business Object)`

> Konkrétnější podoba realizuje abstraktnější: databáze realizuje datový objekt a ten obchodní pojem. Obrácený řetězec převrací směr, access vede od chování k pasivnímu prvku, ne mezi pasivními prvky, a pasivní prvky si navzájem neslouží.

### ? V modelu telco operátora existuje Business Object Zákazník a v CRM Data Object Zákazník; tým je propojil vztahem `Zákazník (Data Object) —access→ Zákazník (Business Object)`. Co je nejlepší oprava?

- [ ] Ponechat access a doplnit režim read
- [x] Nahradit access vztahem realization od Data Object k Business Object
- [ ] Oba objekty sloučit do jednoho Business Object a Data Object z CRM odstranit
- [ ] Nahradit access vztahem association bez směru

> Data Object je elektronická podoba obchodní informace, proto Business Object realizuje; access nespojuje dva pasivní prvky. Sloučení by ztratilo rozlišení business a aplikační vrstvy a association by vazbu zbavila významu.

## Access na správné vrstvě {#access-vrstva .explain}

Access vede **od chování k pasivnímu prvku**; režim (read, write, readwrite) určuje směr toku dat, který se v diagramu ukazuje šipkou (u read míří k chování, u write k objektu). V modelu napříč vrstvami je přehledné, když každé chování pracuje s objektem své vrstvy — business proces s Business Object, aplikační funkce s Data Object, technologický proces s Artifact — a vrstvy se propojí realizací objektů. Strukturní prvek (komponenta, role) smí mít access jen jako odvozenou zkratku; v podrobném modelu kresli access od jeho chování.

*Příklad:* `Vyřízení žádosti (Business Process) —access (read)→ Žádost (Business Object)`; `Kontrola žádosti (Application Function) —access (read)→ Žádost (Data Object)`; `Žádost (Data Object) —realization→ Žádost (Business Object)`.

### ? Na úřadě úředník v procesu Vyřízení žádosti pracuje s obchodním pojmem Žádost a aplikační funkce Kontrola žádosti čte její elektronickou podobu. Který fragment je správný?

- [ ] `Žádost (Business Object) —access→ Vyřízení žádosti (Business Process)`; `Žádost (Data Object) —access→ Kontrola žádosti (Application Function)`
- [ ] `Vyřízení žádosti (Business Process) —realization→ Žádost (Business Object)`; `Kontrola žádosti (Application Function) —realization→ Žádost (Data Object)`
- [ ] `Vyřízení žádosti (Business Process) —access→ Žádost (Business Object)`; `Kontrola žádosti (Application Function) —serving→ Žádost (Data Object)`
- [x] `Vyřízení žádosti (Business Process) —access→ Žádost (Business Object)`; `Kontrola žádosti (Application Function) —access (read)→ Žádost (Data Object)`

> Každé chování přistupuje k objektu své vrstvy a access vede od chování k objektu. První možnost má opačný směr, realization by tvrdila, že procesy objekty uskutečňují, a funkce datovému objektu neslouží — pracuje s ním.

### ? Aplikační funkce Založení objednávky při každém volání vytvoří nový záznam Data Object Objednávka. Který vztah je správný?

- [x] `Založení objednávky (Application Function) —access (write)→ Objednávka (Data Object)`
- [ ] `Založení objednávky (Application Function) —realization→ Objednávka (Data Object)`
- [ ] `Založení objednávky (Application Function) —access (read)→ Objednávka (Data Object)`
- [ ] `Založení objednávky (Application Function) —assignment→ Objednávka (Data Object)`

> Vytvoření záznamu je zápis, tedy access (write) od funkce k datovému objektu. Read by znamenal jen čtení, funkce datový objekt nerealizuje (to dělá artefakt) a assignment vychází z aktivní struktury k chování.

## Uživatelské rozhraní pro roli {#rozhrani-pro-roli .explain}

Application Service odpovídá na otázku *co* aplikace business vrstvě nabízí, Application Interface na otázku *kudy* se k tomu uživatel dostane (webový portál, mobilní aplikace, obrazovka terminálu). Pro kanál k uživateli platí `Application Interface —serving→ Business Role` (případně Business Actor); rozhraní je přiřazeno ke službě, kterou zpřístupňuje: `Application Interface —assignment→ Application Service`. Rozhraní se modeluje, když záleží na kanálu (více kanálů ke stejné službě, bezpečnost, uživatelská zkušenost).

*Příklad:* `Mobilní bankovnictví (Application Interface) —serving→ Klient (Business Role)`; `Mobilní bankovnictví (Application Interface) —assignment→ Platební příkaz (Application Service)`.

### ? Banka nabízí klientům zadávání plateb přes mobilní aplikaci. Architekt chce ukázat, jakým kanálem se k funkcionalitě dostane role Klient. Který fragment je správný?

- [x] `Mobilní bankovnictví (Application Interface) —serving→ Klient (Business Role)`
- [ ] `Klient (Business Role) —serving→ Mobilní bankovnictví (Application Interface)`
- [ ] `Mobilní bankovnictví (Application Component) —assignment→ Klient (Business Role)`
- [ ] `Mobilní bankovnictví (Application Interface) —realization→ Klient (Business Role)`

> Uživatelské rozhraní aplikace slouží roli, která ho používá; směr vede od rozhraní k roli. Obrácený serving tvrdí, že klient slouží aplikaci, aplikace není přiřazena k business roli a rozhraní roli nerealizuje.

### ? Pojišťovna nabízí službu Hlášení škody přes webový portál i přes mobilní aplikaci a chce v modelu odlišit funkcionalitu od kanálů. Který fragment to nejlépe vystihuje?

- [ ] Dvě Application Service „Hlášení škody – web" a „Hlášení škody – mobil", každá serving k roli Klient
- [x] Jedna Application Service Hlášení škody a dvě Application Interface přiřazená k této službě
- [ ] Jedna Application Interface Hlášení škody a dvě Application Service jako její kanály
- [ ] Jedna Application Service Hlášení škody a dvě Business Role „Klient web" a „Klient mobil"

> Funkcionalita je jedna služba a kanály jsou rozhraní, která ji zpřístupňují (assignment od rozhraní ke službě). Zdvojení služby podle kanálu směšuje co a kudy, třetí možnost role služby a rozhraní prohazuje a rozdělování rolí podle kanálu nic neříká o aplikaci.

## Technologie přímo pro business {#technologie-pro-business .explain}

Technologická služba může sloužit business vrstvě i přímo — `Technology Service —serving→ Business Process` — když lidé používají infrastrukturu bez obchodně specifické aplikace mezi nimi: telefonie, e-mail, tisk, Wi-Fi, sdílené úložiště. Pokud ale lidé pracují přes aplikaci, má model vést přes aplikační vrstvu (technologie → aplikace → business); přímá vazba by aplikaci skryla a zkreslila analýzu dopadu.

*Příklad:* `Telefonie (Technology Service) —serving→ Obsluha hovorů (Business Process)`.

### ? Operátoři linky podpory přijímají hovory přímo přes podnikovou telefonní ústřednu; žádnou aplikaci k tomu nepoužívají. Architekt chce ukázat, co proces Obsluha hovorů z IT potřebuje. Který fragment je nejvhodnější?

- [ ] `Obsluha hovorů (Business Process) —serving→ Telefonie (Technology Service)`
- [ ] `Telefonie (Technology Service) —realization→ Obsluha hovorů (Business Process)`
- [ ] `Telefonní ústředna (Application Component) —serving→ Obsluha hovorů (Business Process)`
- [x] `Telefonie (Technology Service) —serving→ Obsluha hovorů (Business Process)`

> Technologická služba smí sloužit business procesu přímo, když mezi nimi není obchodní aplikace. Obrácený serving převrací směr závislosti, realization by tvrdila, že telefonie proces uskutečňuje, a ústředna je technologie, ne aplikační komponenta.

### ? V modelu je `Databázová služba (Technology Service) —serving→ Účtování (Business Process)`. Účetní však s daty pracují výhradně přes ERP, které databázovou službu využívá. Architekt potřebuje model pro analýzu dopadu výpadku. Co je nejlepší úprava?

- [ ] Ponechat přímou vazbu, protože technologie smí business vrstvě sloužit i přímo
- [x] Vést vazbu přes ERP: DB služba slouží ERP, služba ERP slouží procesu
- [ ] Nahradit serving vztahem realization od databázové služby k procesu
- [ ] Doplnit přímou vazbu i od nodu databáze k procesu Účtování

> Účetní pracují přes ERP, takže věrný řetězec vede technologie → aplikace → business; jen tak analýza dopadu ukáže i ERP. Přímá vazba je přípustná jen bez aplikace mezi, realization nevyjadřuje podporu a další přímá vazba by aplikaci skryla ještě víc.

## Řetězec přes tři vrstvy {#retezec-tri-vrstev .explain}

Úplný model napříč vrstvami spojuje: `Business Role —assignment→ Business Process` ← serving ← `Application Service` ← realization ← `Application Component` ← serving ← `Technology Service` ← realization ← `Node`, a navíc `Node —assignment→ Artifact —realization→ Application Component`. Modeluje se buď shora (co proces potřebuje), nebo zdola (co závisí na infrastruktuře). V každém kroku je třeba hlídat směr: serving od poskytovatele k uživateli, realization od konkrétnějšího k abstraktnějšímu, assignment od vykonavatele.

*Příklad:* `Aplikační server (Node) —assignment→ erp.war (Artifact) —realization→ ERP (Application Component)`; `Hostování aplikací (Technology Service) —serving→ ERP (Application Component)`.

### ? Architekt modeluje proces Vychystání objednávky ve skladu od business vrstvy po technologii. Ve kterém fragmentu jsou všechny vztahy správně?

- [ ] `Rezervace zásob (Application Service) —serving→ Vychystání objednávky (Business Process)`; `Rezervace zásob (Application Service) —realization→ WMS (Application Component)`; `Hostování (Technology Service) —serving→ WMS (Application Component)`
- [ ] `Rezervace zásob (Application Service) —serving→ Vychystání objednávky (Business Process)`; `WMS (Application Component) —realization→ Rezervace zásob (Application Service)`; `WMS (Application Component) —serving→ Hostování (Technology Service)`
- [x] `Rezervace zásob (Application Service) —serving→ Vychystání objednávky (Business Process)`; `WMS (Application Component) —realization→ Rezervace zásob (Application Service)`; `Hostování (Technology Service) —serving→ WMS (Application Component)`
- [ ] `Vychystání objednávky (Business Process) —serving→ Rezervace zásob (Application Service)`; `WMS (Application Component) —realization→ Rezervace zásob (Application Service)`; `Hostování (Technology Service) —serving→ WMS (Application Component)`

> Aplikační služba slouží procesu, komponenta službu realizuje a technologická služba slouží komponentě. Ostatní možnosti mají vždy jeden vztah obráceně: službu realizující komponentu, komponentu sloužící technologii, nebo proces sloužící aplikační službě.

### ? Model obsahuje: `Vystavení faktury (Application Service) —serving→ Fakturace (Business Process)`; `ERP (Application Component) —realization→ Vystavení faktury (Application Service)`; prvek `SRV-APP01 (Node)` bez vztahů. Provoz se ptá, na kterém serveru ERP běží. Co v modelu chybí?

- [ ] `SRV-APP01 (Node) —serving→ Fakturace (Business Process)`
- [ ] `ERP (Application Component) —assignment→ erp.war (Artifact) —assignment→ SRV-APP01 (Node)`
- [ ] `SRV-APP01 (Node) —realization→ Vystavení faktury (Application Service)`
- [x] `SRV-APP01 (Node) —assignment→ erp.war (Artifact) —realization→ ERP (Application Component)`

> Na kterém serveru aplikace běží, ukazuje nasazení artefaktu na node a realizace komponenty tímto artefaktem. Přímá vazba nodu na proces přeskakuje aplikaci, řetězec od komponenty k nodu má opačný směr (nasazení vede od nodu k artefaktu) a realization od nodu ke službě neukazuje, na čem ERP běží.

## Analýza dopadu přes vrstvy {#analyza-dopadu .explain}

Konzistentní mezivrstvové vztahy umožňují analýzu dopadu: od vypadlého nodu se postupuje vzhůru po vztazích (node → artefakty → komponenty → aplikační služby → business procesy → role a zákazníci), od procesu dolů zjistíme, co potřebuje. Funguje to jen tehdy, když vrstvy spojují vztahy s jasným významem a směrem (assignment, realization, serving). Vztah association bez směru takovou analýzu neumožní, protože neříká, kdo na kom závisí.

*Příklad:* Výpadek `SRV-DB02 (Node)` → `sklad.jar (Artifact)` → `Sklad (Application Component)` → `Rezervace zásob (Application Service)` → `Vychystání objednávky (Business Process)`.

### ? Model distributora obsahuje: `SRV-DB02 (Node) —assignment→ sklad.jar (Artifact) —realization→ Sklad (Application Component) —realization→ Rezervace zásob (Application Service) —serving→ Vychystání objednávky (Business Process)` a dále `SRV-APP01 (Node) —assignment→ erp.war (Artifact) —realization→ ERP (Application Component) —realization→ Vystavení faktury (Application Service) —serving→ Fakturace (Business Process)`. Server SRV-DB02 vypadl. Který business proces je podle modelu zasažen?

- [x] Jen Vychystání objednávky
- [ ] Jen Fakturace
- [ ] Vychystání objednávky i Fakturace
- [ ] Žádný, protože nody slouží jen aplikacím

> Od SRV-DB02 vede řetězec přes sklad.jar, komponentu Sklad a službu Rezervace zásob k procesu Vychystání objednávky. Fakturace závisí na SRV-APP01, který nevypadl, a výpadek technologie se po vztazích šíří až do business vrstvy.

### ? Tým propojil všechny prvky napříč vrstvami jen vztahem association, protože „je to jednodušší". Vedení chce z modelu zjistit, které procesy ohrozí výpadek konkrétního serveru. Jaký je hlavní problém?

- [ ] Association vůbec nelze použít mezi prvky různých vrstev, jen uvnitř vrstvy
- [x] Association neříká, kdo na kom závisí, takže dopad nelze sledovat
- [ ] Association je dynamický vztah, a proto ukazuje jen pořadí kroků v procesu
- [ ] Association lze podle pravidel jazyka použít jen mezi pasivními prvky

> Association vyjadřuje jen obecnou souvislost bez významu závislosti, takže z ní nelze odvodit směr šíření výpadku. Mezi vrstvami ji použít lze, není dynamická (dynamické jsou triggering a flow) a není omezena na pasivní prvky.

## Typické chyby v mezivrstvových modelech {#chyby-mezi-vrstvami .explain}

Nejčastější chyby: **obrácený serving** (proces „slouží" aplikaci), **realization ze služby na komponentu** (správně komponenta realizuje službu), **access mezi dvěma pasivními prvky**, **realization tam, kde aplikace jen pomáhá** (má být serving), **dva stejnojmenné objekty v různých vrstvách bez vazby** (chybí realization) a **přeskočení vrstvy**, které skryje aplikaci mezi technologií a business. Kontrolní otázka u každého vztahu: kdo poskytuje, kdo užívá, co je konkrétnější?

*Příklad:* chybně `Ověření identity (Application Service) —realization→ Portál (Application Component)`, správně `Portál (Application Component) —realization→ Ověření identity (Application Service)`.

### ? Model banky obsahuje: `Klient (Business Role) —assignment→ Otevření účtu (Business Process)`; `Ověření identity (Application Service) —serving→ Otevření účtu (Business Process)`; `Ověření identity (Application Service) —realization→ Portál (Application Component)`. Co je chybně?

- [ ] Klient má být Business Actor, protože role nemůže proces vykonávat
- [ ] Mezi službou a procesem má být realization, protože služba proces uskutečňuje
- [x] Realization má opačný směr — komponenta Portál realizuje službu
- [ ] Ověření identity má být Technology Service, protože jde o bezpečnost

> Komponenta je konkrétnější a službu realizuje, ne naopak. Business Role proces vykonávat smí, serving je správný vztah pro podporu procesu, který vykonává klient, a ověření identity je aplikační funkcionalita, ne obecná infrastruktura.

### ? Ve kterém fragmentu jsou oba vztahy správně?

- [ ] `Smlouva (Data Object) —access→ Smlouva (Business Object)`; `Evidence smluv (Application Service) —serving→ Uzavření smlouvy (Business Process)`
- [ ] `Uzavření smlouvy (Business Process) —serving→ Evidence smluv (Application Service)`; `Smlouva (Data Object) —realization→ Smlouva (Business Object)`
- [ ] `Evidence smluv (Application Service) —serving→ Uzavření smlouvy (Business Process)`; `Smlouva (Business Object) —realization→ Smlouva (Data Object)`
- [x] `Evidence smluv (Application Service) —serving→ Uzavření smlouvy (Business Process)`; `Smlouva (Data Object) —realization→ Smlouva (Business Object)`

> Aplikační služba slouží procesu a datový objekt realizuje obchodní objekt. Ostatní možnosti obsahují vždy jednu chybu: access mezi dvěma pasivními prvky, obrácený serving nebo obrácenou realizaci.

### ? V modelu pojišťovny existuje Business Object Pojistná událost a v systému likvidace Data Object Pojistná událost; mezi nimi není žádný vztah. Co je nejlepší úprava?

- [ ] Smazat Business Object, protože informace už je v systému
- [ ] Propojit je vztahem association, aby bylo vidět, že spolu souvisejí
- [ ] Propojit je vztahem access od Business Object k Data Object
- [x] Doplnit realization od Data Object k Business Object

> Datový objekt je elektronická podoba obchodní informace, a proto Business Object realizuje. Smazání by ztratilo business pohled, association nemá jasný význam a access vede od chování, ne mezi pasivními prvky.

## Komponenta nebo služba jako poskytovatel {#komponenta-nebo-sluzba .compare}

K business procesu lze aplikaci napojit podrobně přes službu, nebo zkratkou přímo z komponenty (`Application Component —serving→ Business Process` — odvozený vztah, protože komponenta realizuje službu, která procesu slouží).

| | Přes Application Service | Zkratka z Application Component |
|---|---|---|
| Fragment | `Komponenta —realization→ Application Service —serving→ Business Process` | `Komponenta —serving→ Business Process` |
| Co ukazuje | *jakou* funkcionalitu proces využívá | jen *která* aplikace proces podporuje |
| Kdy použít | návrh, náhrada aplikace, více aplikací pro tutéž službu | přehledy pro vedení, mapa podpory procesů aplikacemi |
| Riziko | více prvků a vztahů | při výměně aplikace je třeba přepojit vazby k procesům |

### ? Představenstvo chce přehled, které z 20 aplikací podporují kterou z 30 hlavních činností; podrobnosti o službách ho nezajímají. Který způsob modelování je nejvhodnější?

- [x] Zkratka serving z Application Component k Business Process pro každou dvojici
- [ ] Úplný řetězec od nodů přes artefakty a komponenty až po aplikační služby a procesy
- [ ] Jen Application Service se vztahem serving k procesům, bez aplikačních komponent
- [ ] Vztah association mezi každou aplikací a činností, kterou podporuje

> Pro přehled stačí odvozený vztah serving z komponenty k procesu — přímo ukazuje, která aplikace kterou činnost podporuje. Úplný řetězec je příliš podrobný, samotné služby neřeknou, o které aplikace jde, a association neříká, kdo komu slouží.

### ? Pojišťovna plánuje, že během dvou let nahradí aplikaci pro správu smluv a některé její funkce převezme jiný systém. Architekt připravuje model jako podklad pro plánování této náhrady. Jak má aplikace napojit na business procesy?

- [ ] Zkratkou serving z komponenty k procesům, aby byl model co nejmenší
- [ ] Vztahem association od komponenty k procesům, aby šla vazba snadno měnit
- [ ] Přímo z nodů, na kterých aplikace běží, vztahem serving k procesům
- [x] Přes Application Service, které komponenty realizují a slouží procesům

> Při náhradě aplikace jsou klíčové služby: ukazují, jakou funkcionalitu procesy potřebují, a při výměně se mění jen jejich realizace. Zkratka z komponenty tuto informaci neobsahuje, association nemá význam a vazba z nodů přeskakuje aplikační vrstvu.

## Úroveň detailu v mezivrstvovém pohledu {#uroven-detailu .explain}

Pohled napříč vrstvami má držet **jednotnou úroveň detailu** odpovídající zájmu stakeholdera. Pro vedení stačí v každé vrstvě abstraktnější prvky — business procesy, aplikační komponenty nebo služby, technologické služby a Node jako celek; artefakty, verze operačních systémů a jednotlivá zařízení patří do detailních pohledů pro provoz. Míchání úrovní (hlavní proces vedle konkrétního konfiguračního souboru) pohled znepřehlední a svádí k chybným závěrům. Detaily se z modelu nemažou — jen se v přehledovém pohledu nezobrazí.

*Příklad:* Přehled pro ředitele: `Hostování aplikací (Technology Service) —serving→ ERP (Application Component)`; detail pro provoz: `SRV-APP01 (Node) —composition→ HW-APP01 (Device)`; `SRV-APP01 (Node) —composition→ RHEL 9 (System Software) —assignment→ erp.war (Artifact)`.

### ? Ředitel obchodu dostal Layered view pro proces Prodej. V technologické části je 15 artefaktů, verze operačních systémů a sériová čísla serverů. Ředitele zajímá jen to, na čem prodej z IT závisí. Co je nejlepší úprava pohledu?

- [x] Technologii ukázat jen jako technologické služby a nody jako celky
- [ ] Technologickou část z modelu smazat, protože ředitele nezajímá
- [ ] Artefakty ponechat a odstranit z pohledu raději aplikační komponenty
- [ ] Nahradit technologické prvky jedním prvkem Grouping „IT" bez vztahů

> Přehledový pohled má mít jednotně abstraktní úroveň, takže technologii stačí ukázat jako služby a nody; detaily zůstanou v modelu pro provoz. Smazání z modelu by o informaci připravilo jiné stakeholdery, odstranění aplikací by přerušilo řetězec a Grouping bez vztahů nic neříká o závislosti.

### ? Architekt připravuje pro provozní tým pohled, ze kterého se mají plánovat odstávky serverů kvůli záplatování. Které prvky do pohledu napříč vrstvami nejvíc patří?

- [ ] Jen business procesy a aplikační komponenty, bez technologické vrstvy
- [x] Device, System Software s verzemi a artefakty napojené na komponenty
- [ ] Jen technologické služby a Node jako celky bez vnitřní skladby
- [ ] Capability a Value Stream, ke kterým se servery vztahují

> Provoz potřebuje detail: konkrétní zařízení, verze softwaru k záplatování a artefakty, které přes komponenty ukážou dopad odstávky. Bez technologie nelze odstávky plánovat, abstraktní nody skryjí, co se záplatuje, a strategické prvky jsou pro tento účel příliš vzdálené.

## Grouping napříč vrstvami {#grouping-napric-vrstvami .explain}

Grouping seskupuje prvky libovolných vrstev a typů podle hlediska, které model jinak nevyjadřuje — např. „Řešení digitální onboarding" s procesy, aplikacemi i nody, které k řešení patří. Grouping se k prvkům váže aggregation (prvek může patřit do více seskupení) nebo composition (prvek existuje jen v rámci seskupení). Location je pro geografické umístění, Product pro nabídku zákazníkovi a Application Collaboration pro aplikace vykonávající společné chování — ani jedno nenahrazuje volné seskupení napříč vrstvami.

*Příklad:* `Digitální onboarding (Grouping) —aggregation→ Založení klienta (Business Process)`; `Digitální onboarding (Grouping) —aggregation→ Onboarding portál (Application Component)`; `Digitální onboarding (Grouping) —aggregation→ Kontejnerová platforma (Node)`.

### ? Banka chce v modelu označit všechny prvky, které patří k řešení Digitální onboarding — procesy, aplikace, technologické služby i servery. Který prvek pro toto seskupení napříč vrstvami použít?

- [ ] Application Collaboration
- [ ] Product
- [x] Grouping
- [ ] Location

> Grouping seskupuje prvky libovolných vrstev podle zvoleného hlediska. Application Collaboration seskupuje jen aplikační komponenty pro společné chování, Product je nabídka zákazníkovi ze služeb a smluv a Location vyjadřuje geografické umístění.

### ? Aplikace Registr klientů patří k řešení Digitální onboarding i k řešení Správa úvěrů. Architekt má obě řešení modelovaná jako Grouping. Jakým vztahem má obě seskupení s aplikací spojit?

- [ ] Composition z obou Grouping, protože aplikace je částí řešení
- [x] Aggregation z obou Grouping, aplikace smí patřit do více celků
- [ ] Assignment z obou Grouping, protože řešení aplikaci využívají
- [ ] Composition z jednoho Grouping a association z druhého

> Aggregation dovoluje, aby prvek patřil do více celků, což je tento případ. Composition znamená, že část existuje jen v rámci jednoho celku, assignment vyjadřuje přiřazení vykonavatele a nesouměrné vztahy by naznačily rozdílný vztah k oběma řešením, který neexistuje.
