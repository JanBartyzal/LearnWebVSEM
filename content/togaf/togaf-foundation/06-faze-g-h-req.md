---
kind: topic
subject: togaf-foundation
slug: faze-g-h-req
name: "ADM — Phases G, H a Requirements Management"
order: 6
---

Implementation Governance (Architecture Contract, Compliance Review), Architecture Change Management (změny zjednodušující, inkrementální, re-architekturní) a Requirements Management jako centrální proces ADM.

## Phase G — Implementation Governance {#faze-g .term}

Fáze ADM, ve které architektonický tým dohlíží na to, aby implementační projekty dodaly řešení v souladu s cílovou (Target) architekturou. Samotný vývoj a nasazení neprovádějí architekti — probíhá souběžně ve vývojovém a projektovém procesu organizace; Phase G k němu připojuje architektonický dohled (governance).

### ? Co je hlavním smyslem Phase G (Implementation Governance)?

- [ ] Navrhnout podrobnou cílovou technologickou architekturu pro implementační projekty
- [x] Dohlížet, aby projekty dodaly řešení v souladu s cílovou architekturou
- [ ] Seřadit pracovní balíky podle hodnoty a rizika do Implementation and Migration Plan
- [ ] Sledovat změny prostředí po nasazení a rozhodovat o zahájení nové iterace ADM

> Phase G je o dohledu nad realizací: architektura už je navržená (B–D) a naplánovaná (E–F). Prioritizace balíků patří do Phase F, sledování změn po nasazení a rozhodování o novém cyklu do Phase H.

### ? Kdo v Phase G typicky vyvíjí a nasazuje samotné řešení?

- [x] Implementační projekty v rámci vývojového procesu organizace
- [ ] Architektonický tým, který řešení předtím navrhl ve fázích B až D
- [ ] Architecture Board, který schvaluje a provádí jednotlivé dodávky
- [ ] Sponzor architektury uvedený ve Statement of Architecture Work

> Vývoj probíhá souběžně s Phase G ve vlastním vývojovém procesu organizace. Architekti a Architecture Board vykonávají governance, nestaví řešení; sponzor práci zadává a financuje.

## Cíle Phase G {#g-cile .explain}

Phase G má dva hlavní cíle: **zajistit soulad** implementačních projektů s cílovou architekturou a **vykonávat architektonickou governance** nad dodávaným řešením i nad změnami architektury, které vyvolá sama implementace. Prakticky to znamená převést architekturu do závazných doporučení a omezení pro projekty, průběžně kontrolovat, zda je dodržují, a řízeně řešit odchylky. Phase G tak propojuje svět architektury se světem realizace.

*Příklad:* Cílová architektura počítá s jednotnou platformou pro správu identit. V Phase G architekti předají projektům závazná pravidla, kontrolují jejich dodržení a odchylky řeší přes výjimku nebo požadavek na změnu.

### ? Který z následujících cílů NEPATŘÍ do Phase G?

- [ ] Zajistit, aby implementační projekty dodržovaly cílovou architekturu
- [ ] Vykonávat governance nad změnami architektury vyvolanými implementací
- [x] Vytvořit Architecture Vision a získat pro ni schválení od sponzora
- [ ] Převést architekturu do závazných doporučení a omezení pro projekty

> Architecture Vision vzniká a schvaluje se v Phase A. Phase G architekturu nevytváří, ale dohlíží na její dodržení při realizaci a řeší změny, které z realizace vyplynou.

### ? Implementační projekt během realizace zjistí, že část architektury v praxi nefunguje a musí se změnit. Co z toho platí pro Phase G?

- [ ] Phase G takovou změnu neřeší, projekt má postupovat podle původního plánu
- [ ] Projekt si architekturu upraví sám a změnu jen oznámí po dokončení dodávky
- [ ] Změna se musí vždy vyřešit okamžitým zahájením zcela nového cyklu ADM
- [x] Patří k jejím cílům řídit i změny architektury, které vyvolá implementace

> Jedním z cílů Phase G je vykonávat governance i nad změnami vyvolanými implementací — typicky formou Change Request. Zda změna vyžaduje nový cyklus, posuzuje až Phase H; svévolná úprava projektem by obešla governance.

## Kroky Phase G {#g-kroky .explain}

Phase G postupuje zhruba v těchto krocích: **Confirm scope and priorities for deployment with development management** (sladit rozsah a priority nasazení s vedením vývoje), **Identify deployment resources and skills**, **Guide development of solutions deployment** (doporučení projektům, Architecture Contract, aktualizace repozitáře), **Perform Enterprise Architecture Compliance Reviews**, **Implement business and IT operations** (převést řešení do provozu) a **Perform post-implementation review and close the implementation**. Závěrečná revize po implementaci shrne poznatky (lessons learned), které se mohou promítnout do dalších změn v Phase H.

*Příklad:* Po spuštění nového CRM architekti s projektovým týmem vyhodnotí, co se povedlo a co ne, a zjištění předají jako podněty pro další vývoj architektury.

### ? Který krok patří do Phase G?

- [ ] Establish value realization process
- [ ] Develop Baseline Architecture Description
- [ ] Assign a business value to each work package
- [x] Perform Enterprise Architecture Compliance Reviews

> Compliance Reviews jsou typickým krokem Phase G. Value realization patří do Phase H, popis výchozí architektury do fází B–D a přiřazení obchodní hodnoty balíkům do plánování migrace (Phase F).

### ? Kterým krokem Phase G končí?

- [x] Revizí po implementaci (post-implementation review) a uzavřením implementace
- [ ] Vydáním nové Request for Architecture Work pro další cyklus vývoje architektury
- [ ] Schválením Implementation and Migration Plan řídicím výborem a sponzorem programu
- [ ] Sestavením katalogu požadavků pro Architecture Requirements Specification

> Phase G se uzavírá revizí po implementaci a uzavřením implementace. Nová Request for Architecture Work je výstupem Phase H, schválení Implementation and Migration Plan patří do Phase F.

### ? Proč Phase G obsahuje krok „Confirm scope and priorities for deployment with development management"?

- [ ] Aby architekti mohli sami přidělovat vývojářům jednotlivé úkoly
- [ ] Aby se znovu otevřela analýza mezer mezi Baseline a Target architekturou
- [x] Aby se architektonický plán sladil s tím, jak vývoj skutečně nasazení řídí
- [ ] Aby se rozhodlo, zda celou architekturu předat do nového cyklu ADM

> Krok propojuje architekturu s vedením vývoje: potvrdí, co a v jakém pořadí se bude nasazovat. Architekti vývoj neřídí operativně, analýza mezer patří do B–D a rozhodnutí o novém cyklu do Phase H.

## Implementation Governance Model {#implementation-governance-model .term}

Model, který určuje, jak bude řízena realizace architektury — kdo rozhoduje, jaké jsou kontrolní body, role a procesy dohledu. Finalizuje se na konci **Phase F** a Phase G ho uplatňuje v praxi.

### ? Ve které fázi ADM se finalizuje Implementation Governance Model, který Phase G uplatňuje?

- [ ] Phase E
- [x] Phase F
- [ ] Phase G
- [ ] Phase H

> Implementation Governance Model je výstupem plánování migrace v Phase F. Phase G ho přebírá jako vstup a podle něj řídí dohled nad implementací.

### ? Co popisuje Implementation Governance Model?

- [ ] Pořadí přechodových architektur a jejich termíny
- [ ] Rozdíly mezi výchozí a cílovou architekturou
- [ ] Seznam stavebních bloků vhodných k opakovanému užití
- [x] Způsob řízení a dohledu nad realizací architektury

> Model říká, jak bude implementace řízena (role, procesy, kontrolní body). Pořadí přechodů je v Architecture Roadmap, mezery v analýze mezer a znovupoužitelné bloky v repozitáři.

## Architecture Contract ve Phase G {#architecture-contract .term}

Architecture Contract je společná dohoda partnerů na vývoji (development partners) a sponzorů o tom, co se dodá, v jaké kvalitě a v souladu s jakými architektonickými požadavky. V Phase G se finalizuje a podepisuje a stává se měřítkem, podle kterého se pak posuzuje soulad.

### ? Co představuje Architecture Contract v Phase G?

- [ ] Smlouvu s externím dodavatelem o ceně a termínu dodávky licencí
- [x] Dohodu partnerů na vývoji a sponzorů o tom, co a jak se dodá
- [ ] Interní zápis Architecture Board o schválení architektonických principů
- [ ] Žádost sponzora o zahájení nového cyklu architektury

> Architecture Contract zavazuje partnery na vývoji a sponzory k dodávce v souladu s architekturou a slouží jako základ pro Compliance Reviews. Nejde o obchodní smlouvu o ceně ani o principy; žádost o zahájení práce je Request for Architecture Work.

### ? Implementační projekt začíná s realizací nové platformy. Čím se v Phase G formálně zakotví, jaké architektonické požadavky musí projekt dodržet?

- [ ] Aktualizovanou Architecture Vision
- [ ] Novou Request for Architecture Work
- [ ] Rozhodnutím o udělení dispensation
- [x] Podepsaným Architecture Contract

> Podepsaný Architecture Contract je hlavním výstupem Phase G, který partnery na vývoji zavazuje. Vision vzniká v Phase A, Request for Architecture Work zahajuje práci a dispensation je výjimka z požadavků, ne jejich zakotvení.

## Compliance Review ve Phase G {#compliance-review .term}

Prověrka souladu (Compliance Review) posuzuje konkrétní projekt nebo řešení vůči architektuře — zda splňuje dohodnuté architektonické požadavky, standardy a principy. V Phase G se provádí průběžně v klíčových bodech realizace, ne až po dokončení; výsledky se zaznamenávají do **Compliance Assessments**.

### ? Jakým výstupem Phase G se zaznamenávají výsledky prověrek souladu projektů s architekturou?

- [x] Compliance Assessments
- [ ] Requirements Impact Assessment
- [ ] Capability Assessment
- [ ] Transition Architecture

> Výsledky Compliance Reviews se zapisují do Compliance Assessments. Requirements Impact Assessment je výstupem Requirements Management, Capability Assessment vzniká v Phase A.

### ? Kdy se v Phase G provádějí Compliance Reviews?

- [ ] Jen jednou, až po úplném dokončení řešení a jeho předání do provozu
- [ ] Jen tehdy, když si projekt sám vyžádá posouzení od architektů
- [x] Průběžně v klíčových bodech realizace, ať se odchylky zachytí včas
- [ ] Před zahájením Phase A, aby se ověřila připravenost organizace

> Smyslem prověrek je zachytit odchylky dřív, než se je napravovat prodraží, proto se konají průběžně. Kontrola jen na konci nebo jen na žádost by governance oslabila.

## Výjimka (Dispensation) {#dispensation .term}

Když řešení nemůže některý architektonický požadavek splnit, lze mu řízeně udělit výjimku (dispensation) — vždy **časově omezenou** a obvykle s podmínkami. O výjimce rozhoduje Architecture Board (nebo jiný governance orgán); výjimky a doporučení patří mezi výstupy Phase G.

### ? Projekt kvůli omezení dodavatele dočasně nedokáže splnit jeden architektonický standard, jinak je v souladu. Jaký mechanismus mu umožní pokračovat řízeně?

- [ ] Projekt standard potichu vynechá a uvede to v závěrečné zprávě
- [x] Architecture Board udělí časově omezenou výjimku (dispensation)
- [ ] Standard se trvale zruší pro všechny projekty v organizaci
- [ ] Projekt se zastaví a celá architektura se vrátí do Phase B

> Dispensation je řízená, časově omezená výjimka udělená governance orgánem. Tiché obejití standardu porušuje governance, plošné zrušení i návrat do Phase B jsou na jednu odchylku nepřiměřené.

### ? Co platí o výjimce (dispensation) z architektonických požadavků?

- [ ] Platí trvale a projekt už se k danému požadavku nemusí vracet
- [ ] Uděluje si ji sám vedoucí projektu, Architecture Board ji jen eviduje
- [ ] Je možná jen u technologických standardů, ne u business požadavků
- [x] Je časově omezená a uděluje ji Architecture Board či jiný orgán

> Výjimka je vždy dočasná a rozhoduje o ní governance orgán, typicky Architecture Board. Projekt si ji sám udělit nemůže.

## Výstupy Phase G {#g-vystupy .explain}

Typickými výstupy Phase G jsou **podepsaný Architecture Contract**, **Compliance Assessments**, **Change Requests** (požadavky na změnu architektury zjištěné při realizaci) a samotná **řešení nasazená v souladu s architekturou** (Architecture-compliant solutions deployed). K nasazeným řešením patří i doplněný Architecture Repository, doporučení a výjimky (dispensations), požadavky na úroveň služeb a metriky výkonu a aktualizace Architecture Vision a Architecture Definition Document podle skutečně implementovaného stavu.

*Příklad:* Projekt zjistí, že zvolená integrační platforma nezvládne požadovaný výkon. Architekti nezačnou architekturu přepisovat sami, ale vystaví Change Request, který se posoudí v Phase H.

### ? Který z následujících výstupů NENÍ typickým výstupem Phase G?

- [ ] Podepsaný Architecture Contract
- [x] Implementation and Migration Plan
- [ ] Compliance Assessments z prověrek souladu
- [ ] Change Requests z realizace

> Implementation and Migration Plan se finalizuje v Phase F a do Phase G vstupuje. Podepsaný kontrakt, prověrky souladu a požadavky na změnu jsou typické výstupy Phase G.

### ? Při realizaci se ukáže, že zvolená integrační platforma nezvládne požadovaný výkon a architektura se musí upravit. Jakým výstupem Phase G se tato potřeba formálně předá dál?

- [ ] Novou verzí Statement of Architecture Work
- [ ] Udělením trvalé výjimky (dispensation)
- [x] Požadavkem na změnu (Change Request)
- [ ] Aktualizovanou Architecture Roadmap

> Potřeba změnit architekturu se z Phase G předává jako Change Request, který se dál posuzuje v Phase H. Výjimka nikdy není trvalá a Roadmap ani Statement of Architecture Work se nemění bez posouzení změny.

## Phase H — Architecture Change Management {#faze-h .term}

Fáze ADM, která po nasazení průběžně řídí změny architektury: sleduje vývoj byznysu i technologií, posuzuje požadavky na změnu a rozhoduje, zda změnu zapracovat jako údržbu stávající architektury, nebo zahájit nový cyklus ADM. Zajišťuje, aby architektura zůstala aktuální a dál přinášela hodnotu.

### ? Ve které fázi ADM se rozhoduje, zda požadavek na změnu vyřešit úpravou stávající architektury, nebo zahájením nového cyklu ADM?

- [ ] Phase F
- [ ] Phase G
- [ ] Requirements Management
- [x] Phase H

> Rozhodování o tom, jak naložit se změnou, je jádrem Phase H (Architecture Change Management). Phase G změny z implementace jen zachytí a předá, Requirements Management spravuje požadavky, ale o nich nerozhoduje.

### ? Co je hlavní náplní Phase H?

- [x] Průběžně řídit změny architektury po nasazení a udržovat ji aktuální
- [ ] Dohlížet na soulad právě běžících implementačních projektů s architekturou
- [ ] Definovat rozsah, stakeholdery a vizi nové iterace architektonické práce
- [ ] Seskupit mezery do pracovních balíků a navrhnout přechodové architektury

> Phase H spravuje životní cyklus architektury po nasazení. Dohled nad běžícími projekty je Phase G, vize a rozsah Phase A, pracovní balíky a přechodové architektury Phase E.

## Cíle Phase H {#h-cile .explain}

Phase H usiluje o to, aby **životní cyklus architektury** zůstal udržovaný, aby se **Architecture Governance Framework** skutečně uplatňoval a aby **Architecture Capability** organizace (lidé, procesy, nástroje architektonické funkce) odpovídala aktuálním potřebám. Součástí je i ověřování, že architektura přináší očekávanou hodnotu (value realization). Phase H tedy nehlídá jen samotné modely, ale i fungování architektonické práce jako celku.

*Příklad:* Organizace zjistí, že její architektonický tým nestíhá posuzovat rostoucí počet změn. V Phase H to lze zachytit jako potřebu upravit architektonickou kapabilitu, nejen samotnou architekturu.

### ? Který z následujících cílů patří do Phase H?

- [ ] Zajistit, aby implementační projekty podepsaly Architecture Contract
- [ ] Získat od sponzora schválení Statement of Architecture Work
- [x] Zajistit, aby architektonická kapabilita odpovídala aktuálním potřebám
- [ ] Seřadit projekty migrace podle obchodní hodnoty a míry rizika

> Udržení vhodné Architecture Capability je jedním z cílů Phase H. Podpis kontraktu patří do Phase G, schválení Statement of Architecture Work do Phase A a prioritizace projektů do Phase F.

### ? Proč Phase H sleduje i to, zda architektura přináší očekávanou hodnotu (value realization)?

- [x] Aby se změny opíraly o skutečné přínosy, ne jen o technické podněty
- [ ] Aby se vyhodnotila výkonnost jednotlivých vývojářů v implementačních projektech
- [ ] Aby se před zahájením Phase A ověřila finanční situace celé organizace
- [ ] Aby se nahradily Compliance Reviews, které v Phase H už nejsou potřeba

> Sledování realizace hodnoty dává změnovému řízení obchodní měřítko. Nejde o hodnocení jednotlivců ani o náhradu prověrek souladu, které patří do Phase G.

## Podněty ke změně architektury {#h-podnety .explain}

Změny architektury typicky přicházejí ze tří zdrojů: **strategické změny shora** (vedení chce novou nebo rozšířenou kapabilitu), **změny zdola** (oprava či vylepšení stávající provozní kapability, např. infrastruktury) a **zkušenosti z dříve dodaných projektových inkrementů**. Konkrétní požadavky na změnu pak vyvolávají jak **technologické změny** (nové technologie, zastarávání, úspory nákladů, nové standardy), tak **obchodní změny** (nová strategie, inovace, výjimky z běžného provozu). Phase H tyto podněty sbírá a posuzuje jednotně.

*Příklad:* Výrobce ukončí podporu databázové platformy (technologický podnět zdola) a zároveň vedení rozhodne o vstupu na nový trh (strategický podnět shora) — oba požadavky se posoudí v Phase H.

### ? Vedení banky rozhodne o spuštění zcela nové produktové řady. Jaký druh podnětu ke změně architektury to je?

- [ ] Změna zdola zaměřená na opravu provozní infrastruktury
- [x] Strategická změna shora směřující k nové kapabilitě
- [ ] Zkušenost z dříve dodaného projektového inkrementu
- [ ] Výjimka udělená projektu v rámci Phase G

> Rozhodnutí vedení o nové kapabilitě je strategický podnět shora. Změny zdola opravují stávající provoz, zkušenosti z inkrementů plynou z dodaných projektů.

### ? Který z následujících podnětů je typickou TECHNOLOGICKOU příčinou požadavku na změnu architektury?

- [ ] Rozhodnutí vedení vstoupit na nový zahraniční trh
- [ ] Změna obchodní strategie po akvizici konkurenta
- [ ] Nový produkt navržený obchodním oddělením
- [x] Ukončení podpory používané platformy výrobcem

> Zastarání a ukončení podpory technologie je typický technologický podnět. Ostatní možnosti jsou obchodní změny.

## Druhy změn v Phase H {#h-druhy-zmen .compare}

TOGAF třídí změny architektury do tří kategorií podle toho, jak hluboký zásah vyžadují.

| Druh změny | Typický příklad | Obvyklé zpracování |
|---|---|---|
| **Simplification change** (zjednodušující) | odstranění duplicitních aplikací se stejnou funkcí | běžnými technikami změnového řízení, bez nového cyklu ADM |
| **Incremental change** (inkrementální) | rozšíření stávající kapability o další funkci | podle povahy změnovým řízením, nebo částečnou re-architekturou |
| **Re-architecting change** (re-architekturní) | zásadní změna strategie, fúze dvou firem | znovu celý cyklus ADM (nová Request for Architecture Work) |

### ? Firma chce sloučit tři aplikace pro evidenci smluv, které dělají totéž, do jedné. Jak TOGAF takovou změnu typicky klasifikuje?

- [ ] Re-architecting change
- [ ] Incremental change
- [x] Simplification change
- [ ] Transition change

> Odstranění duplicit a snížení složitosti je zjednodušující změna, kterou lze obvykle zvládnout změnovým řízením. Pojem „Transition change" mezi kategoriemi TOGAF není.

### ? Jak se obvykle zpracuje Re-architecting change?

- [x] Znovu se projde cyklus ADM na základě nové Request for Architecture Work
- [ ] Udělí se dispensation a změna se zapracuje až při příští Compliance Review
- [ ] Projekt ji provede sám a aktualizuje Architecture Repository po dokončení
- [ ] Zapíše se do Architecture Roadmap jako další přechodová architektura

> Re-architekturní změna je tak hluboká, že vyžaduje nový průchod ADM. Výjimka, svévolná úprava projektem nebo jen zápis do Roadmap by takový zásah neošetřily.

### ? Která změna může být podle TOGAF zpracována buď změnovým řízením, nebo částečnou re-architekturou, podle své povahy?

- [ ] Simplification change
- [x] Incremental change
- [ ] Re-architecting change
- [ ] Maintenance change

> Inkrementální změna je hraniční — podle rozsahu ji lze zvládnout změnovým řízením, nebo vyžaduje částečné přepracování architektury. Zjednodušující jde obvykle změnovým řízením, re-architekturní novým cyklem.

## Jak rozhodnout o zpracování změny {#h-pravidla .explain}

TOGAF nabízí orientační pravidla (rules of thumb), jak poznat, zda změnu zvládne změnové řízení, nebo je nutné vrátit se do ADM. Pokud změna **ovlivní dva a více stakeholderů**, pravděpodobně vyžaduje přepracování architektury a nový vstup do ADM. Pokud se týká **jen jednoho stakeholdera**, je spíše kandidátem na běžné změnové řízení. Pokud lze změnu **povolit formou výjimky (dispensation)**, je také spíše kandidátem na změnové řízení.

*Příklad:* Úprava reportu pro jedno oddělení je změnovým řízením; změna procesu fakturace, která zasáhne obchod, finance i zákazníky, spíše vede k novému cyklu ADM.

### ? Požadovaná změna zasáhne obchodní oddělení, finance i zákaznický servis. Co podle orientačních pravidel TOGAF nejspíš platí?

- [ ] Stačí běžné změnové řízení, protože jde o jedinou změnu
- [ ] Stačí udělit výjimku, protože změna je jen dočasná
- [ ] Změnu má provést nejbližší implementační projekt sám
- [x] Pravděpodobně vyžaduje přepracování architektury a ADM

> Změna dopadající na dva a více stakeholderů je podle pravidel TOGAF spíše kandidátem na re-architekturu a nový vstup do ADM. Samostatný zásah projektu by obešel governance.

### ? Která situace je podle orientačních pravidel TOGAF spíše kandidátem na běžné změnové řízení než na nový cyklus ADM?

- [x] Změna se týká jen jednoho stakeholdera
- [ ] Změna zasahuje několik obchodních útvarů
- [ ] Změna vyplývá z fúze se zahraniční firmou
- [ ] Změna mění hlavní strategický cíl podniku

> Dopad na jediného stakeholdera ukazuje na změnové řízení. Zásah do více útvarů, fúze nebo změna strategie směřují spíše k re-architektuře.

### ? Co podle orientačních pravidel TOGAF naznačuje, že změnu lze zpracovat změnovým řízením?

- [ ] Změna vyžaduje novou Architecture Vision
- [ ] Změna mění několik architektonických domén
- [x] Změnu lze povolit formou výjimky (dispensation)
- [ ] Změna vyžaduje nový Statement of Architecture Work

> Je-li změna přípustná jako výjimka, jde spíše o změnové řízení. Nová Vision, Statement of Architecture Work nebo zásah do více domén ukazují na nový cyklus ADM.

## Kroky Phase H {#h-kroky .explain}

Phase H zahrnuje kroky: **Establish value realization process**, **Deploy monitoring tools** (sledování technologických a obchodních změn, výkonu, kapacity a dalších ukazatelů), **Manage risks**, **Provide analysis for architecture change management**, **Develop change requirements to meet performance targets**, **Manage governance process** (svolat Architecture Board nebo jiný orgán k rozhodnutí o změnách) a **Activate the process to implement change** (např. vystavit novou Request for Architecture Work). Jde o nepřetržitou činnost, ne o jednorázový projekt.

*Příklad:* Monitorování ukáže, že kapacita platformy se blíží limitu. Analýza navrhne změnové požadavky, governance orgán rozhodne a v případě velké změny se spustí nový cyklus ADM.

### ? Který krok patří do Phase H?

- [ ] Guide development of solutions deployment
- [x] Deploy monitoring tools
- [ ] Identify deployment resources and skills
- [ ] Perform post-implementation review

> Nasazení monitorovacích nástrojů je krok Phase H. Ostatní tři kroky patří do Phase G.

### ? Kterým krokem Phase H se spustí realizace schválené změny?

- [ ] Establish value realization process
- [ ] Provide analysis for architecture change management
- [ ] Manage risks
- [x] Activate the process to implement change

> Krok „Activate the process to implement change" změnu uvádí do pohybu, např. novou Request for Architecture Work. Ostatní kroky změnu připravují, analyzují nebo hodnotí.

## Výstupy Phase H {#h-vystupy .explain}

Výstupy Phase H se liší podle velikosti změny. U **údržbových změn** jde o aktualizace architektury a případně změny architektonického rámce a principů. U **zásadních změn** je výstupem **nová Request for Architecture Work**, která spouští další cyklus ADM. Podle potřeby se aktualizují i Statement of Architecture Work, Architecture Contract a Compliance Assessments.

*Příklad:* Doplnění nového rozhraní do existující aplikace skončí aktualizací architektury; rozhodnutí o fúzi skončí novou Request for Architecture Work.

### ? Jakým výstupem Phase H se zahajuje nový cyklus ADM při zásadní změně?

- [x] Novou Request for Architecture Work
- [ ] Podepsaným Architecture Contract
- [ ] Finalizovanou Architecture Roadmap
- [ ] Aktualizovaným Compliance Assessment

> Nová Request for Architecture Work je vstupem do další iterace ADM. Architecture Contract se podepisuje v Phase G, Roadmap se finalizuje v Phase F.

### ? Co je typickým výstupem Phase H u drobné údržbové změny?

- [ ] Nová Architecture Vision schválená sponzorem
- [ ] Nový Implementation and Migration Plan
- [x] Aktualizace stávající architektury
- [ ] Nový cyklus Preliminary Phase

> Drobná změna se promítne jako aktualizace architektury (případně rámce a principů) bez nového cyklu. Nová Vision, plán migrace či Preliminary Phase odpovídají až nové iteraci.

## Architecture Board v Phase G a H {#board-v-fazich .explain}

Architecture Board (nebo jiný governance orgán) je ve fázích G a H místem, kde se rozhoduje o odchylkách a změnách. V **Phase G** posuzuje výsledky prověrek souladu, řeší eskalace nesouladu a uděluje výjimky (dispensations). V **Phase H** se schází v rámci kroku řízení governance a rozhoduje o požadavcích na změnu — zda je zpracovat údržbou, povolit výjimkou, nebo spustit nový cyklus ADM. Obecné postavení a složení Architecture Board je samostatným tématem governance.

*Příklad:* Projekt žádá o odchylku od standardu šifrování. Architecture Board ji posoudí a udělí šestiměsíční výjimku s podmínkou nápravy v příští verzi.

### ? Jakou roli má Architecture Board v Phase H?

- [ ] Sám implementuje schválené změny do provozních systémů organizace
- [x] Rozhoduje o požadavcích na změnu i o případném novém cyklu ADM
- [ ] Sestavuje katalog stakeholderů pro novou Architecture Vision v Phase A
- [ ] Provádí analýzu mezer mezi výchozí a cílovou datovou architekturou

> V Phase H governance orgán rozhoduje o tom, jak naložit s požadavky na změnu. Implementaci provádějí projekty, stakeholdery a analýzu mezer řeší jiné fáze.

### ? Který z úkonů typicky provádí Architecture Board v Phase G?

- [x] Uděluje časově omezené výjimky projektům, které nesplní standard
- [ ] Píše zdrojový kód kritických komponent implementovaného řešení
- [ ] Vystavuje první Request for Architecture Work pro celou organizaci
- [ ] Definuje business goals a drivers pro novou Architecture Vision

> V Phase G Architecture Board řeší nesoulad a uděluje výjimky. Vývoj provádějí projekty, Request for Architecture Work a business cíle patří k zahájení architektonické práce.

## Requirements Management {#requirements-management .term}

Proces ADM, který spravuje architektonické požadavky po celou dobu vývoje architektury — zachycuje je, eviduje jejich změny a zajišťuje, aby každá fáze měla k dispozici aktuální a relevantní požadavky. Na diagramu ADM je ve **středu cyklu**, protože je propojen se všemi fázemi.

### ? Proč je Requirements Management na diagramu ADM zobrazen ve středu cyklu?

- [ ] Protože je to první fáze, která se provádí ještě před Preliminary Phase
- [ ] Protože se provádí jen jednou, po dokončení všech ostatních fází ADM
- [x] Protože je to průběžný proces propojený se všemi fázemi ADM
- [ ] Protože v něm Architecture Board schvaluje výstupy každé fáze ADM

> Requirements Management není samostatný krok v pořadí, ale proces, který běží souběžně se všemi fázemi a zásobuje je požadavky. Schvalování výstupů není jeho úlohou.

### ? Co je hlavním účelem Requirements Management v ADM?

- [ ] Odhadovat náklady implementačních projektů
- [x] Spravovat požadavky ve všech fázích ADM
- [ ] Řídit smlouvy s dodavateli technologií
- [ ] Posuzovat soulad projektů s architekturou

> Requirements Management zajišťuje, že požadavky jsou zachyceny, spravovány a dostupné pro všechny fáze. Posuzování souladu je náplní Compliance Reviews v Phase G.

## Requirements Management jako dynamický proces {#req-centralni .explain}

Požadavky se v průběhu ADM neustále mění — upřesňují se, přibývají a některé zanikají, a změna v jedné fázi může zasáhnout fáze předchozí i následující. Requirements Management tyto změny zachycuje a zprostředkuje, ale **sám požadavky neprioritizuje, neřeší ani o nich nerozhoduje** — to se děje v příslušných fázích ADM. TOGAF přitom nepředepisuje konkrétní metodu ani nástroj pro správu požadavků; organizace může použít vlastní.

*Příklad:* Během Phase C vznikne nový požadavek na archivaci dat. Requirements Management ho zaeviduje a posoudí dopady, ale jeho prioritu a řešení určí architekti v Phase C, případně dalších dotčených fázích.

### ? Kde se podle TOGAF architektonické požadavky prioritizují a řeší?

- [ ] Přímo v Requirements Management, který o nich rozhoduje centrálně
- [ ] Výhradně v Phase A, kde se požadavky schvalují jednou provždy
- [ ] V Phase H, která jediná smí měnit stávající požadavky
- [x] V příslušných fázích ADM, Requirements Management je spravuje

> Requirements Management požadavky spravuje a zprostředkuje, ale jejich prioritizace a řešení probíhají ve fázích, kterých se týkají. Phase A ani Phase H nemají na požadavky monopol.

### ? Co platí o metodě a nástroji pro správu požadavků v TOGAF?

- [ ] TOGAF předepisuje jediný povinný nástroj pro evidenci požadavků
- [x] TOGAF konkrétní metodu ani nástroj nepředepisuje, volí je organizace
- [ ] TOGAF povoluje evidovat požadavky jen v Architecture Definition Document
- [ ] TOGAF vyžaduje, aby požadavky spravoval výhradně Architecture Board

> TOGAF popisuje proces, ale konkrétní metodu ani nástroj neurčuje. Požadavky se evidují v repozitáři a specifikacích, ne jen v jednom dokumentu, a nespravuje je Architecture Board.

### ? Během Phase D se objeví nový požadavek, který zpětně ovlivní dříve dokončenou aplikační architekturu. Co platí?

- [ ] Požadavek se odloží až do příští iterace ADM, protože Phase C je uzavřená
- [ ] Požadavek se zapracuje jen do Phase D, předchozí fáze zůstanou beze změny
- [x] Requirements Management posoudí dopad i na Phase C a změnu pak zprostředkuje
- [ ] Požadavek musí nejprve schválit sponzor novým Statement of Architecture Work

> Requirements Management sleduje dopady změněných požadavků na aktuální i předchozí fáze, případně i na jejich analýzu mezer. Ignorovat dopad na Phase C by vedlo k nekonzistentní architektuře.

## Postup řízení požadavků {#req-postup .explain}

Řízení požadavků se prolíná s fázemi ADM. Fáze požadavky **identifikují a dokumentují**; Requirements Management z nich vytvoří **výchozí sadu (baseline)**, sleduje ji a **zaznamenává změny včetně priorit**. U změněných požadavků **posoudí dopad** na aktuální i předchozí fáze, převezme také požadavky vzniklé v Phase H, **aktualizuje repozitář požadavků**, změnu zapracuje v aktuální fázi a případně přehodnotí analýzu mezer dřívějších fází. Výsledky se promítají zejména do Architecture Requirements Specification.

*Příklad:* Nová regulace změní požadavek na uchování dat. Změna se zaeviduje, posoudí se dopad na datovou i technologickou architekturu, aktualizuje se repozitář a upraví analýza mezer.

### ? Co musí Requirements Management udělat se změněným požadavkem dřív, než se změna zapracuje v aktuální fázi?

- [ ] Požadavek se rovnou zapracuje do provozních systémů organizace
- [x] Posoudí se jeho dopad na aktuální i dříve provedené fáze ADM
- [ ] Požadavek se trvale vyřadí, dokud neskončí běžící cyklus ADM
- [ ] Vystaví se k němu nový Architecture Contract s dodavatelem

> Než se změna zapracuje, musí se posoudit její dopad na aktuální i dřívější fáze ADM. Přímé nasazení do provozu ani odkládání do konce cyklu nejsou součástí procesu a Architecture Contract se uzavírá v Phase G.

### ? Do kterého dokumentu se architektonické požadavky z fází B–D a jejich změny promítají především?

- [ ] Statement of Architecture Work
- [ ] Implementation Governance Model
- [x] Architecture Requirements Specification
- [ ] Request for Architecture Work

> Kvantifikované architektonické požadavky shrnuje Architecture Requirements Specification, kterou Requirements Management udržuje aktuální. Ostatní dokumenty zadávají práci nebo řídí implementaci.

## Requirements Impact Assessment {#requirements-impact-assessment .term}

Výstup Requirements Management, který ukáže, co změna požadavků ovlivní ve stávajících specifikacích a co se kvůli ní musí přepracovat. Architekti z něj v dotčených fázích vycházejí, když o změně rozhodují.

### ? Který výstup Requirements Management popisuje důsledky změny požadavků pro stávající specifikace?

- [ ] Compliance Assessment
- [ ] Business Transformation Readiness Assessment
- [ ] Gap Analysis Matrix
- [x] Requirements Impact Assessment

> Requirements Impact Assessment je typickým výstupem Requirements Management. Compliance Assessment vzniká v Phase G, Business Transformation Readiness Assessment hodnotí připravenost organizace na změnu a Gap Analysis Matrix porovnává Baseline s Target.

### ? K čemu slouží Requirements Impact Assessment?

- [x] Ukazuje, co je kvůli změně požadavků nutné upravit a s jakými důsledky
- [ ] Hodnotí, zda dokončený projekt dodržel podmínky Architecture Contract
- [ ] Měří zralost architektonické kapability organizace na stupnici úrovní
- [ ] Určuje, kteří stakeholdeři mají nejvyšší vliv a zájem na architektuře

> Posouzení dopadu požadavků slouží jako podklad pro rozhodnutí o změnách. Soulad s kontraktem hodnotí Compliance Review, zralost kapability a mapa stakeholderů jsou jiné techniky.

## Architecture Requirements Repository {#requirements-repository .term}

Část Architecture Repository, ve které se ukládají a udržují architektonické požadavky ze všech fází ADM. Requirements Management ho průběžně aktualizuje, takže každá fáze čerpá z jednoho aktuálního zdroje požadavků.

### ? Kam Requirements Management ukládá a udržuje architektonické požadavky?

- [ ] Do Governance Log
- [ ] Do Reference Library
- [x] Do Architecture Requirements Repository
- [ ] Do Solutions Landscape

> Požadavky se udržují v Architecture Requirements Repository, aby k nim měly přístup všechny fáze. Ostatní části repozitáře slouží jiným účelům.

### ? Jaký je hlavní přínos jednotného repozitáře architektonických požadavků?

- [ ] Nahrazuje Architecture Contract a prověrky souladu v Phase G
- [x] Všechny fáze ADM čerpají z jednoho aktuálního zdroje požadavků
- [ ] Umožňuje přeskočit Phase H při každé změně požadavků
- [ ] Zajišťuje, že se požadavky po schválení už nikdy nemění

> Jednotný repozitář zajišťuje, že fáze pracují s týmiž aktuálními požadavky. Požadavky se naopak mění dál a governance ani Phase H nenahrazuje.

## Phase G × Phase H × Requirements Management {#g-h-req-srovnani .compare}

Tři části ADM, které se týkají realizace a změn, mají odlišný účel.

| | Phase G | Phase H | Requirements Management |
|---|---|---|---|
| Hlavní otázka | Dodávají projekty v souladu s architekturou? | Jak naložit se změnou po nasazení? | Jsou požadavky aktuální a dostupné všem fázím? |
| Typické výstupy | podepsaný Architecture Contract, Compliance Assessments, Change Requests | aktualizace architektury, nová Request for Architecture Work | Requirements Impact Assessment, změněné požadavky |
| Kdy probíhá | během realizace projektů | průběžně po nasazení | souběžně se všemi fázemi |

### ? Organizace potřebuje ověřit, že právě běžící projekt nového e-shopu dodržuje dohodnuté standardy. Ve které části ADM se to řeší?

- [x] Phase G
- [ ] Phase H
- [ ] Phase F
- [ ] Requirements Management

> Kontrola souladu běžících projektů je náplní Phase G (Compliance Reviews). Phase H řeší změny po nasazení a Requirements Management spravuje požadavky.

### ? Rok po nasazení se změní legislativa a dotkne se několika systémů. Která část ADM rozhodne, zda stačí údržba, nebo je nutný nový cyklus?

- [ ] Phase G
- [ ] Requirements Management
- [x] Phase H
- [ ] Preliminary Phase

> Rozhodnutí o zpracování změny po nasazení patří do Phase H. Requirements Management změněné požadavky zaeviduje a posoudí jejich dopad, ale o novém cyklu nerozhoduje.
