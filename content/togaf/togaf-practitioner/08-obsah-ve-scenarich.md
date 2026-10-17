---
kind: topic
subject: togaf-practitioner
slug: obsah-ve-scenarich
name: "Obsah architektury a repozitář ve scénářích"
order: 8
---

Volba deliverables a artefaktů, využití Enterprise Continuum a Architecture Repository, znovupoužití Building Blocks, Capability-Based Planning.

## Výběr artefaktů podle stakeholderů {#vyber-artefaktu .explain}

Artefakty se nevybírají „všechny ze seznamu", ale podle toho, kdo je bude číst a jaký zájem (concern) mají řešit. Postup: identifikovat stakeholdery a jejich concerns, ke každé skupině zvolit hledisko (viewpoint) a z něj odvodit pohledy (views) a konkrétní katalogy, matice a diagramy. Rozsah a hloubka se řídí rozsahem architektury a přizpůsobeným rámcem — artefakt, který neřeší žádný concern, je zbytečná práce. Stejné informace z repozitáře lze pro různé publikum promítnout do různých pohledů.

*Příklad:* Finanční ředitel chce vědět, které aplikace podporují fakturaci — dostane pohled na vazby aplikací a business funkcí, ne detailní diagram síťové infrastruktury.

### ? Architekt v pojišťovně připravuje Architecture Definition Document pro projekt nové likvidace pojistných událostí. Tým má šablonu se všemi artefakty z TOGAF a navrhuje ji vyplnit celou, „aby nic nechybělo". Termín je krátký a hlavními stakeholdery jsou vedení likvidace a provoz IT. Jaký je nejlepší postup?

- [ ] Vyplnit všechny artefakty ze šablony v plné hloubce, protože úplnost je podmínkou schválení
- [x] Z concerns stakeholderů odvodit viewpointy a vytvořit artefakty, které je řeší
- [ ] Vytvořit jen diagramy, protože katalogy a matice vedení likvidace nezajímají a jen zdržují
- [ ] Odložit výběr artefaktů do Phase G, až bude jasné, co implementační projekty potřebují

> TOGAF vede k volbě artefaktů podle zájmů stakeholderů (přes viewpointy) a podle rozsahu architektury. Plné vyplnění šablony plýtvá kapacitou, paušálně vynechat katalogy a matice je chyba (jsou podkladem repozitáře i diagramů) a Phase G je pro definici architektury pozdě.

### ? Ve výrobní firmě se na revizi architektury opakovaně stává, že výrobní ředitel nerozumí předloženým technickým diagramům aplikačních komponent a schůzky končí bez rozhodnutí. Obsah architektury je přitom věcně správný a ostatní stakeholdeři ho přijali. Co má architekt udělat?

- [ ] Přepracovat celou architekturu, protože ji klíčový stakeholder nepřijal
- [ ] Požádat Architecture Board, aby architekturu schválil i bez výrobního ředitele
- [ ] Doplnit k diagramům ještě podrobnější technickou dokumentaci komponent
- [x] Pro výrobního ředitele zvolit jiný viewpoint a připravit pohled v jeho jazyce

> Problém je v prezentaci, ne v obsahu: stejné informace lze promítnout do pohledu podle hlediska, které odpovídá zájmům daného stakeholdera. Přepracování správného obsahu je zbytečné, obejití stakeholdera porušuje stakeholder management a další technické detaily problém zhorší.

## Katalog, matice, nebo diagram? {#katalog-matice-diagram .compare}

Typ artefaktu se volí podle toho, k čemu má informace sloužit.

| | Katalog (catalog) | Matice (matrix) | Diagram |
|---|---|---|---|
| Co zachycuje | seznam prvků jednoho druhu s atributy | vztahy mezi dvěma druhy prvků | vybrané prvky a vztahy graficky |
| Kdy po něm sáhnout | inventura, evidence, základ repozitáře | analýza dopadů, pokrytí, duplicit a mezer | vysvětlení a komunikace se stakeholdery |
| Typická otázka | „Co všechno máme?" | „Co s čím souvisí?" | „Jak to spolu funguje?" |
| Příklad | Application Portfolio catalog | Application/Function matrix | Application Communication diagram |

### ? Nově jmenovaný chief architect v obchodní firmě zjistí, že nikdo neví, kolik aplikací firma provozuje, kdo je vlastní a na jaké platformě běží. Vedení chce za tři měsíce rozhodnout o konsolidaci aplikačního portfolia. Jakým artefaktem má architektura začít?

- [x] Application Portfolio catalog s vlastníky a platformami
- [ ] Application Communication diagram se všemi rozhraními mezi aplikacemi
- [ ] Solution Concept diagram cílového stavu konsolidovaného portfolia
- [ ] Software Distribution diagram instalací po pobočkách

> Chybí základní inventura — otázku „co všechno máme" řeší katalog, který je zároveň podkladem pro pozdější matice a diagramy. Diagramy komunikace či distribuce nelze bez inventury spolehlivě sestavit a Solution Concept cílového stavu předbíhá znalost výchozího stavu.

### ? Banka má aktuální katalog aplikací i katalog business funkcí. Vedení se ptá, které business funkce podporuje více aplikací současně (kandidáti na odstranění duplicit) a které nepodporuje žádná aplikace. Jaký artefakt na to nejlépe odpoví?

- [ ] Application Portfolio catalog rozšířený o sloupec s poznámkami
- [ ] Functional Decomposition diagram se všemi business funkcemi banky
- [x] Application/Function matrix mapující aplikace na business funkce
- [ ] Application Use-Case diagram pro nejdůležitější aplikace banky

> Otázka se týká vztahu dvou druhů prvků (aplikace × funkce), na což slouží matice: prázdné řádky ukážou funkce bez podpory, vícenásobné vazby duplicity. Katalog nese jen jeden druh prvků, Functional Decomposition ukazuje jen funkce a use-case diagram popisuje interakci uživatelů s aplikací.

## Artefakty pro vizi a business architekturu {#artefakty-vize-business .compare}

Typické situace ve Phase A a B a artefakty, které na ně sedí.

| Situace | Vhodný artefakt |
|---|---|
| zmapovat, kdo má na iniciativu vliv a zájem a jak ho zapojit | Stakeholder Map matrix |
| ukázat vedení na jedné stránce, jak firma vytváří hodnotu a kam iniciativa míří | Value Chain diagram |
| načrtnout na vysoké úrovni podobu řešení pro schválení vize | Solution Concept diagram |
| propojit cíle a organizační jednotky s funkcemi a s technickými komponentami, které je podporují | Business Footprint diagram |
| evidovat, kdo v organizaci co vykonává | Organization/Actor catalog, Role catalog |
| rozložit schopnosti firmy na funkce bez vazby na organizační strukturu | Functional Decomposition diagram |

### ? Architekt v energetické firmě je ve Phase A. Generální ředitel chce před podpisem Statement of Architecture Work na jedné stránce vidět, jak bude nové zákaznické řešení zhruba vypadat a z jakých hlavních částí se bude skládat, bez technických detailů. Který artefakt je nejvhodnější?

- [ ] Application Communication diagram s rozhraními budoucích systémů
- [x] Solution Concept diagram s hrubou podobou cílového řešení
- [ ] Process Flow diagram všech zákaznických procesů firmy
- [ ] Technology Portfolio catalog uvažovaných technologických produktů

> Solution Concept diagram je artefakt Phase A určený k vysokoúrovňovému nastínění řešení v rámci Architecture Vision. Ostatní artefakty jsou příliš podrobné a patří do fází B, C a D, kde by v Phase A předbíhaly analýzu.

### ? Na začátku programu digitalizace v logistické firmě architekt zjistí, že o programu rozhoduje dvanáct osob s velmi rozdílným vlivem a zájmem a část z nich o programu dosud ani neví. Potřebuje rozhodnout, koho aktivně zapojit, koho jen informovat a jaké concerns řešit. Který artefakt má vytvořit?

- [ ] Organization Decomposition diagram celé logistické firmy
- [ ] Role catalog se všemi rolemi, které v logistice existují
- [ ] Value Chain diagram s hlavními činnostmi celé logistické firmy
- [x] Stakeholder Map matrix se zájmy, vlivem a způsobem zapojení

> Stakeholder Map matrix shrnuje stakeholdery, jejich concerns, vliv a doporučený přístup k nim — přesně to, co architekt potřebuje. Organizační diagram ani katalog rolí neříkají nic o zájmu a vlivu a Value Chain diagram popisuje tvorbu hodnoty, ne stakeholdery.

### ? Představenstvo maloobchodního řetězce se ptá, které strategické cíle podporuje plánovaná modernizace pokladních systémů, kterých organizačních jednotek a business funkcí se dotkne a jaké technické komponenty za tím stojí. Chce to vidět v jednom přehledu. Co je nejvhodnější?

- [x] Business Footprint diagram od cílů až po technologii
- [ ] Technology Standards catalog pro pokladní systémy
- [ ] Data Entity/Business Function matrix pro data o prodeji
- [ ] Value Chain diagram řetězce bez vazby na informační systémy

> Business Footprint diagram spojuje business cíle a organizační jednotky s funkcemi a s technickými komponentami, které je realizují. Katalog standardů ani datová matice strategické cíle nepokrývají a Value Chain diagram nevede až k technologii.

## Artefakty pro data, aplikace a technologii {#artefakty-is-tech .compare}

Typické situace ve Phase C a D a artefakty, které na ně sedí.

| Situace | Vhodný artefakt |
|---|---|
| evidovat rozhraní mezi aplikacemi (protokol, formát, vlastník) | Interface catalog |
| ukázat vazby a toky mezi aplikacemi | Application Communication diagram |
| zjistit, které business funkce vytvářejí a používají které datové entity | Data Entity/Business Function matrix |
| naplánovat přenos dat ze starých systémů do nových | Data Migration diagram |
| ukázat, kdo smí přistupovat ke kterým datům | Data Security diagram |
| zjistit, na jaké technologii aplikace běží | Application/Technology matrix |
| evidovat schválené technologické standardy a používané produkty | Technology Standards catalog, Technology Portfolio catalog |

### ? Pojišťovna nahrazuje dvacet let starý systém správy smluv. Architekt potřebuje ukázat, odkud se která data převezmou, jak se během přechodu transformují a do kterých cílových systémů poputují. Který artefakt je nejvhodnější?

- [x] Data Migration diagram toku dat ze starého do nových systémů
- [ ] Logical Data diagram cílového datového modelu pojišťovny
- [ ] Data Lifecycle diagram se stavy jedné pojistné smlouvy v průběhu času
- [ ] Application Portfolio catalog s plánem vyřazení systémů

> Data Migration diagram zachycuje tok dat z výchozích do cílových systémů včetně transformací — přesně účel migrace. Logický model ukazuje jen cílovou strukturu, lifecycle diagram stavy entity v čase a katalog aplikací tok dat neukáže.

### ? Nemocnice se připravuje na audit ochrany osobních údajů. Auditor chce z architektury vidět, které role, organizační útvary a systémy mají přístup ke zdravotním datům pacientů. Který artefakt na to nejlépe odpoví?

- [ ] Conceptual Data diagram se všemi hlavními datovými entitami nemocnice
- [ ] Application Communication diagram mezi klinickými systémy
- [x] Data Security diagram zobrazující, kdo smí ke kterým datům
- [ ] Interface catalog rozhraní mezi laboratoří a odděleními

> Data Security diagram zobrazuje, kteří aktéři (osoby, útvary, systémy) mají přístup ke kterým datům — což je zájem auditora. Konceptuální model přístupová práva neobsahuje a komunikační diagram ani katalog rozhraní oprávnění nepopisují.

### ? Integrační tým v telekomunikační firmě řeší, že při každé změně nikdo neví, jaká rozhraní mezi aplikacemi existují, jakým protokolem a formátem komunikují a kdo je vlastní. Potřebují spolehlivou evidenci, ze které budou vycházet další analýzy i diagramy. Co je nejvhodnější?

- [ ] Application Communication diagram kreslený pro každou změnu zvlášť
- [ ] Application/Organization matrix s vlastníky jednotlivých aplikací
- [ ] Platform Decomposition diagram použité integrační platformy
- [x] Interface catalog s atributy a vlastníkem každého rozhraní

> Evidenci prvků s atributy řeší katalog a komunikační diagramy z něj lze odvodit. Jednorázové diagramy nejsou spolehlivou evidencí, matice vlastníků aplikací rozhraní nepopisuje a dekompozice platformy popisuje technologii, ne rozhraní.

## Který deliverable na co {#volba-deliverable .compare}

Výběr výstupu (deliverable) podle toho, co je potřeba dohodnout nebo zdokumentovat.

| Potřeba | Deliverable |
|---|---|
| dohodnout se sponzorem rozsah, přístup, plán a zdroje architektonické práce | Statement of Architecture Work |
| získat podporu pro vysokoúrovňový cílový stav a hodnotu iniciativy | Architecture Vision |
| zdokumentovat modely architektury, zdůvodnění a analýzu mezer | Architecture Definition Document |
| stanovit měřitelné požadavky, které musí implementace splnit | Architecture Requirements Specification |
| ukázat pořadí work packages a Transition Architectures v čase | Architecture Roadmap |
| zavázat realizační projekt k dodržení architektury | Architecture Contract |
| posoudit dopad nového požadavku na schválenou architekturu | Requirements Impact Assessment |

### ? Architekt dokončuje Phase C pro e-shop. Vývojový dodavatel potřebuje jednoznačně ověřitelné podmínky, které musí nová platforma splnit: maximální dobu odezvy, dostupnost 99,9 % a povinné rozhraní na skladový systém. Do kterého deliverable je má architekt zapsat?

- [ ] Do Architecture Vision, protože jde o klíčové cíle iniciativy
- [x] Do Architecture Requirements Specification jako měřitelné požadavky
- [ ] Do Statement of Architecture Work jako kritéria úspěchu práce
- [ ] Do Architecture Definition Document jako součást architektonických modelů

> Architecture Requirements Specification nese kvantifikovaná, ověřitelná kritéria, která musí implementace splnit (včetně požadavků na rozhraní). ADD obsahuje modely a zdůvodnění, Architecture Vision je vysokoúrovňová a SoAW vymezuje architektonickou práci, ne požadavky na řešení.

### ? Sponzor programu v bance souhlasí s obecným záměrem architektury, ale chce mít písemně potvrzené, co přesně architektonický tým dodá, v jakém rozsahu, v jakém harmonogramu a s jakými zdroji. Teprve pak uvolní rozpočet. Jaký deliverable má architekt připravit k podpisu?

- [ ] Architecture Definition Document s popisem výchozí architektury
- [ ] Architecture Roadmap s termíny jednotlivých work packages
- [ ] Implementation and Migration Plan celého programu banky
- [x] Statement of Architecture Work s rozsahem, plánem a zdroji

> Statement of Architecture Work vymezuje rozsah, přístup, harmonogram a zdroje architektonické práce a sponzor ho schvaluje — je měřítkem úspěchu architektonického projektu. ADD, Roadmap i Implementation and Migration Plan vznikají až v průběhu práce a nepopisují závazek architektonického týmu.

### ? Rok po schválení architektury přichází obchodní ředitel pojišťovny s novým požadavkem na okamžité online sjednání pojištění, který zasahuje do schválené Target Architecture. Architekt potřebuje před rozhodnutím zjistit, kterých částí architektury a probíhajících projektů se požadavek dotkne. Co má vytvořit?

- [x] Requirements Impact Assessment s dopady na architekturu a projekty
- [ ] Nový Statement of Architecture Work pro celou novou iteraci ADM
- [ ] Aktualizovanou Architecture Vision, zatím bez samostatné analýzy dopadu
- [ ] Compliance Assessment všech probíhajících realizačních projektů

> Requirements Impact Assessment posuzuje dopad nového či změněného požadavku na architekturu a je podkladem pro rozhodnutí, jak změnu řešit. Nový SoAW nebo vize předbíhají rozhodnutí o rozsahu změny a Compliance Assessment hodnotí soulad projektů s architekturou, ne dopad požadavku.

## Deliverable × artefakt v praxi {#deliverable-artefakt-praxe .explain}

Deliverable je formálně dohodnutý výstup, který se reviduje, schvaluje a podepisuje; artefakt je jemnější část popisu architektury (katalog, matice, diagram) a „žije" v Architecture Repository. Jeden artefakt se může objevit ve více deliverables — např. katalog aplikací v ADD i v podkladech pro Architecture Board. Artefakty se proto udržují na jednom místě v repozitáři a deliverables na ně odkazují nebo se z nich sestavují, místo aby se kopírovaly do dokumentů. Schválený deliverable se verzuje a slouží jako reference; další změny se řídí, ne přepisují volně.

*Příklad:* Po schválení ADD se jeho popisy uloží do Architecture Landscape; další projekt z nich vyjde jako z Baseline a nemusí inventuru dělat znovu.

### ? V úřadu státní správy má každý projekt vlastní dokument architektury, do kterého si zkopíruje seznam aplikací a ručně ho upraví. Po roce existuje deset vzájemně si odporujících verzí katalogu aplikací. Jaké opatření nejlépe odpovídá TOGAF?

- [ ] Zakázat projektům popisovat aplikace a nechat evidenci jen na provozu IT
- [ ] Sloučit všech deset dokumentů jednorázově do jednoho velkého deliverable
- [x] Udržovat katalog jako jeden artefakt v repozitáři a v dokumentech na něj odkazovat
- [ ] Nechat Architecture Board každý nový dokument ručně porovnat s ostatními

> Artefakty patří do Architecture Repository jako jediný zdroj a deliverables je využívají. Zákaz popisu ztrácí informace, jednorázové sloučení problém do budoucna neřeší a ruční porovnávání Boardem je drahé a nepředchází vzniku dalších verzí.

### ? Architekt v obchodní firmě dokončil Architecture Definition Document a ten byl na revizi se stakeholdery formálně schválen. Kolega navrhuje dokument dál volně upravovat podle nových nápadů, „protože architektura je živá". Jaký je správný přístup?

- [ ] Dokument dál průběžně upravovat, protože schválení bylo jen formalita
- [x] Schválenou verzi zafixovat jako referenci a změny dál řešit řízeně
- [ ] Dokument po schválení archivovat, protože už nebude potřeba
- [ ] Schválený obsah přesunout do Governance Log a dál ho nevyužívat

> Deliverable po formálním review a schválení slouží jako dohodnutá reference pro další práci; změny se řídí přes řízení požadavků a změn architektury. Volné úpravy podkopávají dohodu se stakeholdery a archivace ani přesun do logu rozhodnutí by nezachovaly jeho referenční roli.

## Enterprise Continuum jako mapa pro znovupoužití {#continuum-hledani .explain}

Enterprise Continuum třídí architektonická aktiva od obecných po specifická pro organizaci, a tím zároveň ukazuje, kde hledat, co znovupoužít. Před tvorbou nového popisu architekt prochází repozitář: má organizace podobnou architekturu (Organization-Specific)? Existuje odvětvový referenční model (Industry)? Obecný vzor pro daný druh systémů (Common Systems)? Čím obecnější aktivum, tím víc ho je třeba přizpůsobit, ale tím šířeji je použitelné. Architecture Continuum přitom vede výběr a tvorbu řešení v Solutions Continuum.

*Příklad:* Pojišťovna navrhující klientský portál zjistí, že sesterská společnost má v repozitáři skupiny architekturu podobného portálu, a vyjde z ní místo prázdného papíru.

### ? Telekomunikační operátor zahajuje architekturu nového systému pro správu zákaznických objednávek. Tým navrhuje začít „na zelené louce" vlastním modelem procesů a dat. Pro telekomunikace přitom existují zavedené odvětvové referenční modely. Co je nejlepší první krok?

- [ ] Navrhnout vlastní model, protože referenční model omezí kreativitu týmu
- [ ] Převzít odvětvový model beze změn rovnou jako Target Architecture
- [ ] Začít výběrem dodavatele, jehož produkt odvětvový model obsahuje
- [x] Vyjít z odvětvového modelu (Industry Architecture) a přizpůsobit ho firmě

> Enterprise Continuum vede ke znovupoužití existujících aktiv: odvětvový referenční model se zařadí jako Industry Architecture a specializuje na potřeby firmy. Zelená louka plýtvá prací, převzetí beze změn ignoruje specifika a výběr dodavatele předbíhá definici architektury (SBB se hledají až k definovaným ABB).

### ? Architekt v holdingu zjistí, že dceřiná společnost před dvěma lety úspěšně zavedla architekturu centrální správy identit a teď totéž potřebuje mateřská firma. Architektura dcery je uložena v repozitáři skupiny. Jak má architekt postupovat?

- [x] Posoudit architekturu dcery ke znovupoužití a přizpůsobit ji
- [ ] Vytvořit novou architekturu, protože cizí nelze znovupoužít
- [ ] Převzít celé řešení dcery i se smlouvami s dodavateli bez posouzení
- [ ] Počkat, až vznikne obecný referenční model správy identit pro holdingy

> Repozitář a Enterprise Continuum slouží právě k tomu, aby se existující architektury znovupoužily; specifická architektura sesterské organizace se posoudí a přizpůsobí. Odmítnout ji je plýtvání, převzetí bez posouzení ignoruje odlišné požadavky a čekání na obecný model nemá oporu.

## Specializace × zobecnění v Enterprise Continuum {#continuum-smer .compare}

Pohyb po kontinuu má dva směry a oba mají praktický smysl. Architecture Continuum (logické architektury) přitom na každém stupni vede odpovídající stupeň Solutions Continuum (konkrétní řešení).

| | Specializace (od obecného ke specifickému) | Zobecnění (od specifického k obecnému) |
|---|---|---|
| Co se děje | obecný model se doplňuje o odvětvová a firemní specifika | z úspěšné konkrétní architektury se vytáhne znovupoužitelné jádro |
| Kdy | při tvorbě nové architektury nebo řešení | po dokončení projektu, při budování knihovny vzorů |
| Výsledek | architektura či řešení pro konkrétní organizaci | obecnější aktivum, např. vzor nebo referenční architektura |
| Směr | Foundation → Common Systems → Industry → Organization-Specific | opačný |

### ? Po úspěšném nasazení integrační platformy v jedné divizi strojírenského koncernu chce chief architect, aby z výsledku měly užitek i další divize s podobnými potřebami. Architektura je ale plná specifik první divize. Co má udělat?

- [ ] Zkopírovat architekturu divize beze změn do všech ostatních divizí
- [x] Zobecnit ji na znovupoužitelný vzor a uložit ho do Reference Library
- [ ] Uložit ji jen do Governance Log jako záznam o přijatém rozhodnutí
- [ ] Nechat každou divizi navrhnout vlastní integraci samostatně od úplného začátku

> Zobecnění (pohyb k obecnějším stupňům Enterprise Continuum) odstraní specifika a vytvoří znovupoužitelné aktivum, typicky vzor či referenční architekturu v Reference Library. Kopie beze změn přenáší cizí specifika, Governance Log slouží k záznamu rozhodnutí a návrh od začátku plýtvá prací.

### ? Architekt v bance má schválenou logickou architekturu platebního systému bez vazby na produkty a nyní hledá konkrétní komponenty k realizaci. Kolegové se přou, zda hledat v Architecture Continuum, nebo v Solutions Continuum. Co je správně?

- [ ] V Architecture Continuum, protože obsahuje i konkrétní produkty dodavatelů
- [ ] Mimo repozitář, protože obě kontinua slouží jen ke klasifikaci
- [x] V Solutions Continuum, které nese řešení k logickým architekturám
- [ ] V žádném z nich, konkrétní produkty se volí až ve Phase G

> Architecture Continuum obsahuje logické architektury a vede výběr v Solutions Continuum, kde jsou konkrétní řešení. Produkty do Architecture Continuum nepatří, kontinua slouží i k vyhledávání aktiv a konkrétní řešení se hledají už ve Phase E, nikoli až ve Phase G.

## Odvětvové referenční modely: přizpůsobit, ne převzít {#referencni-modely .explain}

Odvětvové referenční modely (např. pro bankovnictví, telekomunikace nebo maloobchod) urychlují tvorbu architektury a dávají společný slovník s partnery a dodavateli; v Enterprise Continuum patří mezi Industry Architectures. Architekt je nepřebírá mechanicky: vybere části relevantní pro rozsah, sladí je s architektonickými principy a business cíli a odchylky vědomě zdokumentuje. Volba referenčních modelů, viewpointů a nástrojů je prvním krokem fází B, C i D. Je potřeba hlídat i licenční podmínky modelu.

*Příklad:* Banka použije odvětvový model služeb jako kostru katalogu business služeb, ale doplní vlastní služby správy aktiv, které model nepokrývá.

### ? Retailová firma koupila licenci odvětvového referenčního modelu. Konzultant navrhuje prohlásit celý model za Target Business Architecture, protože „je to best practice". Firma ale prodává z velké části přes franšízy, což referenční model nepokrývá. Jak má architekt postupovat?

- [ ] Přijmout celý model jako Target Architecture a franšízy řešit až v provozu
- [ ] Model odmítnout úplně, protože nepokrývá podstatná specifika firmy
- [ ] Upravit franšízový prodej firmy tak, aby odpovídal referenčnímu modelu
- [x] Použít relevantní části modelu, doplnit franšízy a odchylky zdokumentovat

> Referenční model je Industry Architecture, kterou je třeba specializovat na organizaci. Mechanické převzetí ignoruje business specifika, úplné odmítnutí zahazuje přínos modelu a přizpůsobovat obchodní model referenčnímu modelu obrací logiku — architektura slouží business cílům.

### ? Ve Phase B architekt pojišťovny volí, z jakých podkladů bude modelovat business architekturu. K dispozici má obecný odvětvový model pojišťovnictví a interní procesní mapu z roku 2015, která už neodpovídá realitě. Jaký postup je nejlepší?

- [x] Odvětvový model jako reference, Baseline z aktualizované mapy
- [ ] Použít jen mapu z roku 2015, protože je specifická pro tuto firmu
- [ ] Vynechat Baseline a modelovat rovnou cílový stav podle modelu
- [ ] Odložit Phase B, dokud jiný tým nevytvoří novou úplnou procesní mapu

> Prvním krokem Phase B je výběr referenčních modelů, viewpointů a nástrojů; odvětvový model dá strukturu a aktualizovaná interní mapa poslouží pro Baseline. Spoléhat jen na zastaralou mapu ztrácí přínos reference, bez Baseline nejde udělat Gap Analysis a odklad zdržuje bez důvodu.

## Kam v Architecture Repository co uložit {#repozitar-kam .compare}

Části Architecture Repository a obsah, který do nich patří.

| Obsah | Část repozitáře |
|---|---|
| popisy architektury organizace (Baseline, Target, Transition) na úrovni strategické, segmentové i kapabilitní | Architecture Landscape |
| referenční architektury, vzory, šablony, návody | Reference Library |
| schválené standardy, kterým musí řešení vyhovět | Standards Library |
| rozhodnutí (včetně výjimek), výsledky compliance a capability assessments | Governance Log |
| požadavky odsouhlasené pro architekturu | Architecture Requirements Repository |
| plánovaná a nasazená řešení (SBB) | Solutions Landscape |
| přizpůsobený rámec — metoda (tailored ADM) a metamodel obsahu | Architecture Metamodel |
| parametry, struktury a procesy architektonické funkce | Architecture Capability |

### ? Architekt hledá, která konkrétní řešení (produkty a služby) jsou v podniku nasazená nebo plánovaná, aby je posoudil jako kandidátní SBB. Kde v Architecture Repository je najde?

- [ ] V Reference Library s referenčními architekturami a vzory
- [ ] V Architecture Requirements Repository s požadavky
- [x] V Solutions Landscape s plánovanými a nasazenými SBB
- [ ] V Standards Library se schválenými standardy

> Solutions Landscape popisuje plánovaná a nasazená řešení podniku, tedy SBB, které lze posoudit jako kandidáty k realizaci. Reference Library obsahuje obecné referenční architektury a vzory, Architecture Requirements Repository požadavky a Standards Library standardy, jimž mají řešení vyhovět — konkrétní řešení podniku neeviduje žádná z nich.

### ? Bezpečnostní tým banky vytvořil a Architecture Board schválil povinný standard pro šifrování uložených dat. Architekt chce zajistit, aby ho všechny budoucí projekty našly a aby se jejich řešení vůči němu posuzovala. Kam ho má uložit?

- [x] Do Standards Library jako závazný standard pro řešení
- [ ] Do Governance Log jako jednorázové rozhodnutí Architecture Boardu
- [ ] Do Solutions Landscape jako jedno z nasazených řešení banky
- [ ] Do Architecture Requirements Repository jako požadavek projektu

> Schválené standardy, vůči nimž se řešení posuzují, patří do části repozitáře pro standardy (Standards Library). Governance Log zaznamená rozhodnutí o schválení, ale není přehledem platných standardů; Solutions Landscape popisuje řešení a Requirements Repository požadavky konkrétních architektur.

### ? Po dokončení architektury CRM v pojišťovně vznikly schválené popisy Baseline a Target Architecture a dvou Transition Architectures. Další projekty z nich mají vycházet jako z oficiálního popisu současného a plánovaného stavu. Kam v Architecture Repository patří?

- [ ] Do Reference Library jako obecné vzory pro jiné organizace v odvětví
- [x] Do Architecture Landscape jako popis architektury organizace
- [ ] Do Architecture Metamodel jako nová pravidla pro obsah
- [ ] Do Governance Log jako záznam o ukončení projektu CRM

> Architecture Landscape obsahuje architektonické popisy organizace (Baseline, Target, Transition) na různých úrovních. Reference Library je pro obecné vzory, metamodel určuje strukturu obsahu a Governance Log zachycuje rozhodnutí, nikoli popisy architektury.

## ABB, nebo SBB? Kdy a proč {#abb-sbb-praxe .explain}

Ve fázích B, C a D se definují hlavně Architecture Building Blocks — popisují požadovanou funkcionalitu, rozhraní a vlastnosti nezávisle na produktech. Solution Building Blocks, tedy konkrétní produkty, komponenty nebo služby, se hledají především ve Phase E, kde se rozhoduje, čím ABB realizovat (koupit, vyvinout, znovupoužít). Předčasné uvažování v produktech vede k uzamčení u dodavatele a k architektuře, která kopíruje možnosti jednoho produktu místo potřeb byznysu. ABB pak slouží jako kritérium pro hodnocení kandidátních SBB.

*Příklad:* ABB „správa identit s jednotným přihlášením a federací" se ve Phase E porovná se třemi komerčními produkty a s existující interní službou.

### ? Ve Phase C architekt e-shopu modeluje aplikační architekturu. Obchodní ředitel trvá na tom, aby se do modelu rovnou zapsal konkrétní produkt e-commerce platformy, který viděl na veletrhu, „ať se neztrácí čas". Jak má architekt reagovat?

- [ ] Produkt do modelu zapsat, protože konkrétní SBB urychlí Phase E
- [x] Potřebu popsat jako ABB a produkt posoudit jako kandidátní SBB ve Phase E
- [ ] Produkt odmítnout, protože TOGAF komerční produkty v architektuře nepřipouští
- [ ] Ukončit Phase C a přejít rovnou do Phase G k výběru dodavatele

> Ve fázích B–D se definují ABB nezávislé na produktu; konkrétní řešení (SBB) se hodnotí ve Phase E proti požadavkům ABB. Zapsání produktu předem riskuje uzamčení u dodavatele, TOGAF produkty nezakazuje a Phase G je implementační governance, ne výběr řešení.

### ? Ve Phase E architekt v logistické firmě hledá řešení pro ABB „sledování zásilek v reálném čase". Na výběr má komerční SaaS službu, vlastní vývoj a modul, který firma už provozuje pro jinou divizi. Jaký je nejlepší postup?

- [ ] Zvolit vlastní vývoj, protože jen tak lze ABB splnit přesně
- [ ] Zvolit SaaS službu, protože komerční řešení jsou vždy levnější
- [ ] Vrátit se do Phase B a ABB přepsat podle nejlevnější varianty
- [x] Posoudit všechny tři varianty jako kandidátní SBB proti požadavkům ABB

> Ve Phase E se kandidátní SBB (koupě, vývoj, znovupoužití) hodnotí proti funkcím a rozhraním definovaným v ABB, přičemž znovupoužití existujícího řešení bývá silný kandidát. Předem zvolená varianta ani přepisování ABB podle ceny neodpovídají logice ADM.

## Rozhodnutí o znovupoužití stavebního bloku {#znovupouziti-bb .explain}

Než architekt definuje nový stavební blok, prohledá Architecture Repository (zejména Architecture Landscape, Solutions Landscape a Reference Library). Kandidát se posoudí podle shody s požadavky, rozhraní, souladu se standardy a fáze životního cyklu. Výsledkem je rozhodnutí: znovupoužít beze změny, přizpůsobit, nebo vytvořit nový — a nový či upravený blok se po schválení zapíše zpět do repozitáře, aby ho našli další. Znovupoužití se ale nevynucuje za každou cenu: blok určený k vyřazení nebo s nevyhovujícím rozhraním může být dražší cestou.

*Příklad:* Platební modul jedné divize by se hodil pro e-shop, ale běží na platformě určené k vyřazení — architekt raději použije novější platební službu ze Solutions Landscape.

### ? Architekt v bance potřebuje ve Phase C stavební blok pro ověřování identity klientů. V repozitáři najde existující blok, který splňuje 90 % požadavků, jen mu chybí podpora nového typu elektronického podpisu. Blok je aktivně podporovaný a v souladu se standardy. Co je nejlepší?

- [x] Blok znovupoužít, doplnit o nový typ podpisu a aktualizovat v repozitáři
- [ ] Vytvořit nový blok, protože existující nesplňuje všechny požadavky bez výjimky
- [ ] Použít existující blok beze změny a chybějící požadavek z rozsahu vypustit
- [ ] Nechat rozhodnutí na dodavateli, který bude blok v projektu implementovat

> Kandidát s vysokou shodou a souladem se standardy je vhodný k přizpůsobení a rozšíření se promítne do repozitáře pro další uživatele. Nový blok duplikuje práci, vypuštění požadavku ignoruje potřebu byznysu a delegace na dodavatele obchází architektonické rozhodnutí.

### ? Při revizi architektury nového zákaznického portálu pojišťovny Architecture Board zjistí, že tým navrhl vlastní notifikační službu, přestože v Solutions Landscape existuje firemní notifikační služba se shodnými funkcemi. Tým repozitář před návrhem neprohledal. Jaké je nejlepší doporučení?

- [ ] Návrh schválit, protože tým má právo zvolit si vlastní řešení
- [ ] Celý projekt portálu zastavit pro porušení architektonické governance
- [x] Vrátit návrh k posouzení existující služby a znovupoužít ji, pokud vyhovuje
- [ ] Firemní službu zrušit a nahradit ji novou notifikační službou navrženou pro portál

> Repozitář se má prohledat před návrhem nového bloku; Board proto vrátí návrh k posouzení existujícího řešení. Schválení vytváří zbytečnou duplicitu, zastavení celého projektu je nepřiměřené a nahrazení fungující firemní služby nemá žádné zdůvodnění.

## Vlastnosti dobře navrženého stavebního bloku {#kvalitni-bb .explain}

Znovupoužitelný stavební blok má jasně vymezenou hranici, funkce a rozhraní, skrývá vnitřní realizaci a je volně svázaný s okolím, takže ho lze nahradit jinou realizací. Respektuje platné standardy a jeho specifikace počítá s dostupnými produkty a řešeními, aby byl realizovatelný. Důležitá je přiměřená granularita: příliš velký blok se jinde nepoužije, příliš drobný přináší režii s množstvím vazeb. Popsané vztahy k ostatním blokům umožní ostatním týmům blok v repozitáři najít a posoudit.

*Příklad:* Blok „výpočet pojistného" s popsaným rozhraním poslouží portálu i aplikaci pro makléře; portál, který výpočet obsahuje natvrdo, takto znovupoužít nejde.

### ? Architekt v energetické firmě navrhuje stavební blok pro odečty elektroměrů. Jeden návrh slučuje odečty, fakturaci a zákaznickou podporu do jediného bloku, druhý odděluje odečty za definované rozhraní. Firma plánuje do pěti let vyměnit fakturační systém. Který návrh je vhodnější a proč?

- [ ] Sloučený, protože méně bloků znamená jednodušší správu repozitáře
- [x] Oddělený s rozhraním, protože ho lze nezávisle nahradit a znovupoužít
- [ ] Sloučený, protože odečty a fakturace spolu v energetice vždy souvisejí
- [ ] Oba jsou rovnocenné, granularita bloků nemá vliv na budoucí změny

> Volné vazby a definované rozhraní umožní vyměnit fakturační systém, aniž by se musely měnit odečty, a blok odečtů lze použít i jinde. Sloučený blok tuto výměnu prodraží; jednodušší správa repozitáře ani obsahová souvislost to nevyváží a granularita budoucí změny přímo ovlivňuje.

### ? Tým v dopravní firmě zapsal do repozitáře stavební blok „služba jízdních řádů", ale uvedl jen název a krátký popis, bez rozhraní a vazeb na další bloky. Ostatní projekty ho proto nedokážou posoudit a vytvářejí si vlastní varianty. Co nejlépe pomůže?

- [ ] Blok přejmenovat výstižněji, aby ho projekty v repozitáři snáz našly
- [ ] Nařídit všem projektům blok použít bez ohledu na jejich požadavky
- [x] Doplnit specifikaci funkcí, rozhraní a vazeb, aby šel blok posoudit
- [ ] Blok z repozitáře odstranit, protože je nedostatečně popsaný

> Bez specifikace funkcí a rozhraní nelze posoudit vhodnost bloku a znovupoužití selhává. Přejmenování nepřidá potřebné informace, plošné nařízení ignoruje požadavky projektů a odstranění bloku zahodí existující práci.

## Kdy sáhnout po Capability-Based Planning {#cbp-kdy .explain}

Capability-Based Planning se hodí, když strategický cíl vyžaduje novou nebo posílenou schopnost (capability), kterou nevytvoří jeden projekt, ale koordinovaná změna napříč útvary, procesy, lidmi, informacemi a technologiemi. Plánuje se podle schopností, které má podnik získat, a projekty jsou jen prostředkem k jejich dodání. Přínosy se sledují na úrovni schopnosti, ne jednotlivých projektů, a plánování vede byznys. V architektuře se s tím pracuje tak, že Architecture Roadmap a Transition Architectures se slaďují s dodávkami schopností.

*Příklad:* Cíl „vyřídit pojistnou událost do 24 hodin" je schopnost; vyžaduje nový proces, školení likvidátorů, mobilní aplikaci a propojení dat — čtyři projekty, jedna schopnost a jedno měření přínosu.

### ? Pojišťovna spustila pět samostatných IT projektů na „zrychlení likvidace". Všechny byly dodány včas a v rozpočtu, ale doba vyřízení pojistné události se nezkrátila, protože nikdo nekoordinoval změny procesů, školení a dat mezi projekty. Jaký přístup měl architekt doporučit?

- [ ] Přísnější projektové řízení každého z pěti projektů zvlášť
- [ ] Rozšířit rozsah jednoho projektu tak, aby pokryl všechny ostatní
- [x] Capability-Based Planning se schopností jako jednotkou plánování
- [ ] Přidat šestý IT projekt zaměřený na měření doby vyřízení

> Capability-Based Planning koordinuje projekty napříč doménami tak, aby společně dodaly schopnost, a úspěch měří přínosem schopnosti. Lepší řízení jednotlivých projektů problém koordinace neřeší, jeden obří projekt zvyšuje riziko a další IT projekt nepřidá chybějící změnu procesů a lidí.

### ? Vedení banky schválilo strategický cíl „poskytnout firemním klientům úvěr online do jednoho dne". Potřebné jsou změny v řízení rizik, nové scoringové modely, úprava procesů poboček a nové aplikace. Jak má architekt v duchu Capability-Based Planning nastavit plánování?

- [ ] Nechat plánování na vedoucím IT, protože většinu změn tvoří aplikace
- [x] Plánovat schopnost jako celek pod vedením byznysu a měřit její přínos
- [ ] Rozdělit cíl mezi projektové manažery bez společného plánu a měření
- [ ] Svěřit plánování Architecture Boardu, protože schvaluje celou architekturu

> Capability-Based Planning je řízené byznysem a schopnost se plánuje a měří jako celek napříč projekty a doménami. Svěření IT ignoruje business změny, rozdělení bez společného plánu vede k dílčí optimalizaci a Architecture Board je orgán governance, ne vlastník business schopnosti.

## Přírůstky schopností a Transition Architectures {#cbp-prirustky .explain}

Schopnost se obvykle nedodává naráz, ale po přírůstcích (capability increments), z nichž každý přinese měřitelnou část hodnoty. Přírůstek vyžaduje souběžnou změnu více dimenzí schopnosti (např. lidé, procesy, informace a technologie); dodat jen technologii nestačí. V architektuře se přírůstky slaďují s Transition Architectures: přechodová architektura má odpovídat stavu, kdy je dodán ucelený přírůstek, a Architecture Roadmap ukazuje jejich pořadí. Work packages z různých projektů se tak skládají podle toho, ke kterému přírůstku přispívají.

*Příklad:* Přírůstek 1 „online sjednání cestovního pojištění" (proces, web, školení call centra) odpovídá Transition Architecture 1; přírůstek 2 přidá životní pojištění.

### ? Architekt v logistické firmě plánuje Transition Architectures pro schopnost „sledování zásilek pro zákazníky". Projektový tým navrhuje přechodové stavy podle technických vrstev: nejdřív celá databáze, pak všechna rozhraní, nakonec uživatelská aplikace. Co architekt doporučí?

- [x] Vymezit přechodové stavy podle přírůstků schopnosti s měřitelnou hodnotou
- [ ] Ponechat dělení podle technických vrstev, protože je realizačně nejlevnější
- [ ] Vynechat Transition Architectures a dodat schopnost najednou na konci
- [ ] Rozdělit přechodové stavy podle organizačních útvarů logistické firmy

> Transition Architectures se mají slaďovat s přírůstky schopnosti, aby každý přechodový stav přinesl byznysu použitelnou hodnotu. Dělení podle technických vrstev přinese hodnotu až na konci, dodávka naráz zvyšuje riziko a dělení podle útvarů nesleduje schopnost.

### ? Univerzita zavádí schopnost „online přijímací řízení". Dodavatel dodal funkční aplikaci, ale studijní oddělení dál pracuje s papírovými přihláškami, protože se nezměnily vnitřní předpisy ani procesy a zaměstnanci nebyli proškoleni. Co tato situace ukazuje z pohledu Capability-Based Planning?

- [ ] Že aplikaci měl dodat jiný dodavatel s lepší uživatelskou podporou
- [ ] Že schopnost byla dodána a zavedení do praxe je už věcí provozu
- [ ] Že projekt měl být od začátku řízen jako změna ve Phase H
- [x] Že dodat jen technologii nestačí, přírůstek musí změnit i procesy a lidi

> Schopnost vzniká teprve souběžnou změnou více dimenzí — vedle technologie zde chyběla změna předpisů, procesů a proškolení lidí; samotná aplikace schopnost nedodá. Výměna dodavatele by nepomohla, přesunutí odpovědnosti na provoz ignoruje chybějící změny a Phase H řeší změny již zavedené architektury.

## Plánování podle projektů × podle schopností {#cbp-vs-projekty .compare}

Srovnání tradičního plánování po projektech s Capability-Based Planning.

| | Plánování podle projektů | Capability-Based Planning |
|---|---|---|
| Jednotka plánování | projekt s vlastním rozsahem | business schopnost a její přírůstky |
| Měřítko úspěchu | termín, rozpočet a rozsah projektu | dosažená schopnost a přínos pro byznys |
| Koordinace | uvnitř projektu | napříč projekty, útvary a doménami |
| Typické riziko | projekty jsou hotové, ale hodnota nevznikla | náročnější řízení portfolia |
| Vazba na architekturu | architektura řešená zvlášť pro projekt | Roadmap a Transition Architectures sladěné s přírůstky |

### ? Ředitel portfolia ve výrobní firmě hodnotí úspěch IT programu podle počtu projektů dokončených v termínu. Strategie firmy přitom požaduje „schopnost přizpůsobit výrobu individuální zakázce do 48 hodin". Které měřítko úspěchu odpovídá Capability-Based Planning?

- [ ] Podíl projektů programu dokončených v termínu a rozpočtu
- [ ] Počet nových aplikací nasazených v rámci programu
- [x] Skutečná doba přizpůsobení výroby zakázce ve srovnání s cílem
- [ ] Počet podepsaných Architecture Contracts se všemi projekty programu

> Capability-Based Planning měří úspěch dosaženou schopností a jejím přínosem, tedy zde dobou přizpůsobení výroby. Termíny projektů, počet aplikací ani počet smluv neříkají, zda schopnost skutečně vznikla.

### ? Architekt v telekomunikační firmě sestavuje Architecture Roadmap. Má seznam třiceti work packages z různých projektů a strategii postavenou na třech klíčových business schopnostech. Jak má work packages v Roadmap uspořádat v souladu s Capability-Based Planning?

- [ ] Podle velikosti rozpočtu, od nejdražšího work package po nejlevnější
- [ ] Podle projektů, k nimž jednotlivé work packages organizačně patří
- [x] Seskupit je do přírůstků schopností a seřadit podle dodávané hodnoty
- [ ] Podle toho, kdy dodavatelé nabídnou volnou kapacitu pro jejich realizaci

> V Capability-Based Planning se work packages seskupují podle přírůstků schopností, které společně dokončí, a jejich pořadí se odvíjí od hodnoty pro byznys. Řazení podle rozpočtu, projektů nebo kapacity dodavatelů nesleduje, kdy a jaká schopnost vznikne.
