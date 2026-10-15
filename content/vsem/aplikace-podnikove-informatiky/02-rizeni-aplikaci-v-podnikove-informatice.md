---
kind: topic
subject: aplikace-podnikove-informatiky
slug: rizeni-aplikaci-v-podnikove-informatice
name: "Řízení aplikací v podnikové informatice"
order: 2
---

Řešení podnikové architektury, metodiky a metody řízení aplikací. Životní cyklus aplikace. Strategické aplikace.

## Řízení aplikací {#rizeni-aplikaci .term}

Řízení aplikací (application management) je soubor činností, kterými firma **plánuje, pořizuje, provozuje, rozvíjí a vyřazuje své aplikace** tak, aby po celý jejich životní cyklus podporovaly cíle firmy za přiměřené náklady a rizika. Probíhá na úrovni **strategické** (portfolio a architektura aplikací), **řídicí** (plánování, rozpočet, dodavatelé, úroveň služeb) a **operativní** (provoz, podpora, údržba). Každá aplikace má mít **vlastníka (věcného garanta) z byznysu**, který rozhoduje o požadavcích a prioritách, a **správce (technického garanta) z IT**, který zajišťuje její technický chod.

### ? Kdo by měl typicky rozhodovat o tom, jaké funkce má podniková aplikace mít a které požadavky na její změny mají přednost?

- [x] Vlastník aplikace z byznysu (věcný garant)
- [ ] Správce aplikace z útvaru IT (technický garant)
- [ ] Dodavatel, který aplikaci původně vyvinul
- [ ] Pracovník service desku, který přijímá hlášení

> O funkcích a prioritách rozhoduje vlastník z byznysu, protože aplikace má podporovat jeho procesy. Správce z IT zajišťuje technický chod a dodavatel nebo service desk rozhodnutí jen realizují či podporují.

### ? Co je hlavním cílem řízení aplikací ve firmě?

- [ ] Mít co nejvíce aplikací s nejnovějšími technologiemi
- [ ] Dát každému oddělení vlastní samostatnou aplikaci
- [x] Aby aplikace po celý životní cyklus podporovaly cíle firmy
- [ ] Aby se jednou nasazené aplikace co nejméně měnily

> Řízení aplikací sleduje přínos aplikací pro firmu od záměru až po vyřazení, a to s ohledem na náklady a rizika. Počet aplikací ani jejich technologická novost nejsou cílem samy o sobě.

## Podniková architektura jako rámec řízení aplikací {#podnikova-architektura .explain}

**Podniková architektura** (Enterprise Architecture) je celkový popis firmy jako systému — jejích **procesů, informací, aplikací a technologií a vazeb mezi nimi** — v současném i cílovém stavu, včetně principů, které řídí jejich návrh a rozvoj. Člení se do vrstev **byznys → datová → aplikační → technologická**. Pro řízení aplikací je rámcem: **aplikační architektura** ukazuje, jaké aplikace firma má a mít má, jaké procesy pokrývají a jak jsou propojeny; **architektonické principy** (např. „jeden zdrojový systém pro každá kmenová data") a jejich dohled (architektonická rada) zajišťují, že nové aplikace a změny zapadají do cílového stavu. K tvorbě architektury slouží rámce jako **TOGAF** s metodou ADM.

*Příklad:* Než firma schválí nákup nového nástroje pro marketing, architekt ověří, zda nebude duplikovat funkce CRM a zda zvládne napojení na existující zákaznická data.

### ? Firma má architektonický princip „pro každou oblast kmenových dat existuje jediný zdrojový systém". Marketing chce koupit aplikaci s vlastní, na CRM nezávislou evidencí zákazníků. Jak má řízení aplikací postupovat?

- [ ] Nákup schválit, protože jde z rozpočtu marketingu
- [x] Návrh posoudit podle cílové architektury a jejích principů
- [ ] Nákup odmítnout, protože nové aplikace jsou nežádoucí
- [ ] Rozhodnutí ponechat výhradně na dodavateli aplikace

> Architektonické principy slouží právě k posouzení, zda nová aplikace zapadá do cílové architektury. Výsledkem může být napojení na CRM, úprava návrhu nebo zamítnutí — rozhoduje soulad s principy, ne zdroj financování.

### ? Která vrstva podnikové architektury popisuje, jaké aplikace firma používá, jaké funkce pokrývají a jak jsou mezi sebou propojeny?

- [ ] Byznys architektura
- [ ] Datová architektura
- [ ] Technologická architektura
- [x] Aplikační architektura

> Aplikační architektura je mapou aplikací, jejich funkcí, rozhraní a vazeb. Byznys architektura popisuje procesy a organizaci, datová architektura datové entity a jejich toky, technologická infrastrukturu.

## Metodiky a rámce pro řízení aplikací {#metodiky-rizeni-aplikaci .compare}

Řízení aplikací se opírá o veřejně dostupné rámce osvědčených postupů; každý pokrývá jinou část problematiky a v praxi se kombinují.

| Rámec | Zaměření | Původ / správce | Využití pro aplikace |
|---|---|---|---|
| **ITIL** | řízení IT služeb (IT Service Management) | Velká Británie, vládní agentura CCTA (80. léta) | provoz a podpora aplikací jako součásti služeb: incidenty, problémy, změny, nasazení, úroveň služeb |
| **ASL** (Application Services Library) | správa aplikací (application management) | Nizozemsko | údržba, podpora a obnova aplikací; procesy na operativní, řídicí a strategické úrovni |
| **COBIT** | správa a řízení podnikové IT (governance), cíle a kontroly | ISACA | soulad IT s cíli firmy, řízení rizik, podklad pro audit |
| **TOGAF** | podniková architektura, metoda ADM | The Open Group | návrh cílové aplikační architektury a plánu přechodu |

### ? Firma chce u svých aplikací zavést osvědčené postupy pro řízení incidentů, změn a dohodnuté úrovně služeb. Který rámec je k tomu primárně určen?

- [ ] TOGAF
- [ ] Zachmanův rámec
- [x] ITIL
- [ ] PRINCE2

> ITIL je rámec osvědčených postupů pro řízení IT služeb, kam patří řízení incidentů, změn i úrovně služeb. TOGAF a Zachmanův rámec slouží podnikové architektuře, PRINCE2 řízení projektů.

### ? Interní audit chce ověřit, zda je řízení IT ve firmě v souladu s jejími cíli a zda jsou zavedeny potřebné kontrolní mechanismy. Který rámec se k tomu typicky používá?

- [x] COBIT
- [ ] ITIL
- [ ] TOGAF
- [ ] Scrum

> COBIT (od ISACA) je rámec pro správu a řízení podnikové IT a je oblíbeným podkladem pro audit IT. ITIL se soustředí na poskytování služeb, TOGAF na architekturu a Scrum na agilní vývoj.

### ? Který z uvedených rámců je zaměřen specificky na správu aplikací, tedy na jejich údržbu, podporu a obnovu?

- [ ] TOGAF
- [x] ASL (Application Services Library)
- [ ] COBIT
- [ ] PRINCE2

> ASL vznikl v Nizozemsku jako rámec právě pro správu aplikací. TOGAF řeší podnikovou architekturu, COBIT správu a řízení IT jako celku a PRINCE2 řízení projektů.

## ITIL a správa aplikací {#itil .explain}

**ITIL** je rámec osvědčených postupů (best practice) pro **řízení IT služeb** (ITSM). Aplikace v něm nejsou cílem samy o sobě, ale **součástí IT služby**, kterou útvar IT nebo dodavatel poskytuje uživatelům — uživatele zajímá, zda služba funguje, nikoli jednotlivá komponenta. Starší verze ITIL v3 popisovala životní cyklus služby (strategie, návrh, přechod, provoz, neustálé zlepšování) a správu aplikací (Application Management) jako jednu z funkcí provozu; ITIL 4 (2019) pracuje se systémem hodnoty služeb a s tzv. praktikami. Pro aplikace jsou klíčové zejména **řízení incidentů, problémů a změn**, **uvolňování a nasazení** nových verzí, **řízení úrovně služeb** (SLA) a **evidence konfigurace** (co z čeho se služba skládá).

*Příklad:* Služba „příjem objednávek" se skládá z e-shopu, ERP, platební brány a sítě. ITIL vede k tomu, aby se dostupnost a podpora sledovaly pro službu jako celek, ne zvlášť pro každou aplikaci.

### ? Co je ITIL?

- [ ] Metoda tvorby podnikové architektury s fázemi A až H
- [ ] Agilní rámec pro iterativní vývoj softwaru v týmech
- [ ] Mezinárodní norma pro posuzování kvality softwaru
- [x] Rámec osvědčených postupů pro řízení IT služeb

> ITIL shrnuje osvědčené postupy pro řízení IT služeb (ITSM). Fáze A až H patří metodě ADM v TOGAF, iterativní vývoj v týmech popisuje například Scrum.

### ? Jak se ITIL dívá na podnikové aplikace?

- [x] Jako na součást IT služeb poskytovaných uživatelům
- [ ] Jako na samostatné produkty bez vazby na služby
- [ ] Jako na výhradní odpovědnost dodavatele softwaru
- [ ] Jako na projekty, které končí nasazením do provozu

> V ITIL je aplikace jednou z komponent služby, spolu s infrastrukturou, daty a podporou. Řízení proto sleduje, zda služba funguje pro uživatele, a pokračuje i po nasazení do provozu.

## Incident × problém × změna {#incident-problem-zmena .compare}

Tři nejčastější procesy (praktiky) ITIL při provozu aplikací se liší cílem:

| | Řízení incidentů | Řízení problémů | Řízení změn (v ITIL 4 change enablement) |
|---|---|---|---|
| Řeší | neplánované přerušení nebo zhoršení služby | příčinu jednoho nebo více incidentů | přidání, úpravu či odstranění čehokoli, co ovlivňuje službu |
| Cíl | co nejrychleji obnovit službu (i dočasným obejitím — workaround) | najít a trvale odstranit příčinu, předcházet opakování | provést změnu s co nejmenším rizikem pro provoz |
| Typický výstup | obnovený provoz, záznam incidentu | analýza příčin, známá chyba, návrh trvalé opravy | posouzená a schválená změna, plán nasazení |

### ? Uživatelům přestal ERP tisknout faktury. Service desk do 30 minut zprovoznil tisk dočasným přesměrováním na jinou tiskárnu, příčinu zatím nezná. Který proces ITIL tím postupoval?

- [ ] Řízení problémů
- [x] Řízení incidentů
- [ ] Řízení změn
- [ ] Řízení úrovně služeb

> Řízení incidentů má co nejrychleji obnovit službu, klidně dočasným obejitím (workaround). Hledání skutečné příčiny je úkolem řízení problémů.

### ? Aplikace pro uzávěrku každý měsíc spadne při zpracování velkých dávek. Tým nyní analyzuje, co tuto opakovanou chybu skutečně způsobuje. Který proces ITIL to je?

- [ ] Řízení incidentů
- [ ] Řízení změn
- [ ] Řízení uvolňování verzí
- [x] Řízení problémů

> Řízení problémů hledá a odstraňuje příčinu opakujících se incidentů. Jednotlivé výpadky obnovuje řízení incidentů, samotnou opravu pak do provozu dostane řízení změn.

### ? Vývojáři připravili úpravu výpočtu cen v e-shopu. Před nasazením do provozu se posuzuje její riziko, dopady na ostatní aplikace a termín nasazení. Který proces ITIL to zajišťuje?

- [x] Řízení změn
- [ ] Řízení incidentů
- [ ] Řízení problémů
- [ ] Řízení úrovně služeb

> Řízení změn posuzuje a schvaluje změny, aby jejich nasazení neohrozilo provoz. Incidenty a problémy se týkají poruch a jejich příčin.

## Životní cyklus aplikace {#zivotni-cyklus-aplikace .explain}

Aplikace prochází od vzniku potřeby po ukončení provozu typickými fázemi:

1. **Záměr** — identifikace potřeby, požadavky, business case (přínosy, náklady, rizika), soulad s architekturou.
2. **Výběr nebo vývoj** — výběr hotového řešení a dodavatele, nebo návrh a vývoj vlastní aplikace.
3. **Implementace** — nastavení, migrace dat, integrace, testování, školení uživatelů a nasazení do provozu.
4. **Provoz a údržba** — podpora uživatelů, řešení incidentů, opravy a přizpůsobení prostředí.
5. **Rozvoj** — nové funkce a verze podle měnících se potřeb byznysu.
6. **Vyřazení** — náhrada nebo ukončení provozu, převod či archivace dat.

Fáze provozu, údržby a rozvoje bývá nejdelší a obvykle tvoří **největší část celkových nákladů** (TCO), proto se náklady posuzují za celý životní cyklus, nejen za pořízení.

*Příklad:* Firma zavede docházkový systém (záměr, výběr, implementace), deset let jej provozuje a rozšiřuje o mobilní aplikaci (provoz, rozvoj) a nakonec jej nahradí modulem nového ERP (vyřazení).

### ? Firma zjistila, že ruční evidence reklamací v tabulkách přestala stačit. Zpracovává popis potřeby a odhad přínosů a nákladů nové aplikace. Ve které fázi životního cyklu aplikace se nachází?

- [ ] Implementace
- [ ] Provoz a údržba
- [x] Záměr
- [ ] Rozvoj

> Identifikace potřeby a zpracování business case patří do fáze záměru, ještě před výběrem či vývojem řešení. Implementace, provoz i rozvoj následují až po pořízení aplikace.

### ? Ve které fázi životního cyklu aplikace obvykle vzniká NEJVĚTŠÍ část jejích celkových nákladů?

- [ ] Záměr a zpracování business case
- [x] Provoz, údržba a rozvoj
- [ ] Implementace a nasazení
- [ ] Výběr nebo vývoj řešení

> Provoz, údržba a rozvoj trvají obvykle mnoho let a jejich náklady (podpora, licence, úpravy, infrastruktura) zpravidla převýší náklady na pořízení. Proto se aplikace hodnotí podle nákladů za celý životní cyklus.

## Typy údržby aplikace {#typy-udrzby .compare}

Údržba aplikace v provozu se podle cíle (např. podle normy ISO/IEC 14764) dělí na čtyři typy:

| Typ údržby | Co řeší | Příklad |
|---|---|---|
| **Opravná** (corrective) | odstranění zjištěných chyb | výpočet DPH na faktuře vychází špatně |
| **Adaptivní** (adaptive) | přizpůsobení změněnému prostředí | přechod na novou verzi databáze nebo operačního systému |
| **Zdokonalovací / perfektivní** (perfective) | zlepšení výkonu, použitelnosti, nové funkce na přání uživatelů | rychlejší vyhledávání, nový přehled zakázek |
| **Preventivní** (preventive) | odhalení a odstranění skrytých vad dřív, než se projeví | úprava kódu, který by při růstu dat přestal stačit |

### ? Výrobce databáze ukončuje podporu verze, na které běží skladová aplikace. Aplikaci je proto nutné upravit, aby fungovala na nové verzi databáze. O jaký typ údržby jde?

- [x] Adaptivní
- [ ] Opravnou
- [ ] Perfektivní
- [ ] Preventivní

> Adaptivní údržba přizpůsobuje aplikaci změněnému prostředí, např. nové verzi databáze či operačního systému. Opravná údržba odstraňuje zjištěné chyby, perfektivní zlepšuje funkce.

### ? Uživatelé CRM požadují nový přehled otevřených obchodních příležitostí a rychlejší vyhledávání zákazníků. Aplikace přitom funguje bez chyb. O jaký typ údržby jde?

- [ ] Opravnou
- [ ] Adaptivní
- [x] Perfektivní (zdokonalovací)
- [ ] Preventivní

> Perfektivní údržba zlepšuje výkon a použitelnost aplikace nebo přidává funkce na přání uživatelů. Nejde o opravu chyby ani o reakci na změnu prostředí.

## Vyřazení aplikace {#vyrazeni-aplikace .explain}

Vyřazení (decommissioning) je **řízené ukončení provozu** aplikace, která už nepřináší dostatečnou hodnotu, je technicky zastaralá nebo ji nahrazuje jiné řešení. Zahrnuje zejména: **převod potřebných dat** do nástupnické aplikace, **archivaci dat**, která je nutné uchovat (např. po dobu zákonných lhůt pro účetní či personální záznamy), **odpojení rozhraní** na ostatní systémy, převedení uživatelů, **ukončení licencí, smluv o podpoře a infrastruktury**. Neřízeně „ponechané" staré aplikace dál stojí peníze a představují bezpečnostní riziko, protože často přestávají dostávat bezpečnostní aktualizace.

*Příklad:* Po přechodu na nové ERP firma převede otevřené zakázky do nového systému, účetní data starších let uloží do archivu s možností nahlížení a starý systém vypne včetně jeho serverů a smluv o podpoře.

### ? Co je při vyřazení staré účetní aplikace nutné vyřešit s jejími daty?

- [ ] Všechna data okamžitě smazat kvůli ochraně údajů
- [ ] Data ponechat jen ve staré aplikaci, která dál běží
- [ ] Data předat dodavateli, který je uchová podle uvážení
- [x] Potřebná data převést nebo archivovat po dobu lhůt

> Data potřebná pro další provoz se převádějí do nástupnické aplikace a data, která je nutné uchovat, se archivují po dobu stanovených lhůt. Okamžité smazání by porušilo povinnost uchovávat záznamy.

### ? Který krok NEPATŘÍ k řízenému vyřazení aplikace?

- [ ] Ukončení licencí a smluv o podpoře
- [x] Prodloužení podpory staré verze o dalších pět let
- [ ] Odpojení rozhraní na ostatní systémy
- [ ] Převedení uživatelů na nástupnickou aplikaci

> Řízené vyřazení provoz aplikace ukončuje, takže se smlouvy rušejí, rozhraní odpojují a uživatelé převádějí. Dlouhodobé prodloužení podpory je naopak rozhodnutí aplikaci ponechat.

## Správa portfolia aplikací {#portfolio-aplikaci .term}

Správa portfolia aplikací (Application Portfolio Management, **APM**) je soustavné vedení **přehledu (inventury) všech aplikací** firmy a jejich **hodnocení z hlediska byznysové hodnoty, technického stavu, nákladů a rizik**. Výsledky slouží k rozhodování, do kterých aplikací investovat, které ponechat, nahradit nebo vyřadit, a k **racionalizaci portfolia** — odstranění duplicit a snížení počtu, nákladů a složitosti aplikací.

### ? Firma po několika akvizicích zjistila, že ani neví, kolik aplikací vlastně používá a kolik ji stojí. Co je prvním krokem správy portfolia aplikací?

- [ ] Nahradit všechny aplikace jedním systémem ERP
- [ ] Vyřadit všechny aplikace starší deseti let
- [x] Vytvořit inventuru aplikací s vlastníky a náklady
- [ ] Převést všechny aplikace do cloudu jako SaaS

> Bez úplného přehledu aplikací, jejich vlastníků, nákladů a stavu nelze portfolio hodnotit ani racionalizovat. Plošná rozhodnutí bez inventury a hodnocení by byla nepodložená.

## Racionalizace portfolia — model TIME {#model-time .compare}

Při racionalizaci se aplikace často hodnotí ve dvou dimenzích — **byznysová hodnota** a **technická kvalita** (udržovatelnost, soulad s architekturou, náklady provozu). Tzv. **model TIME** (připisovaný společnosti Gartner) z nich odvozuje čtyři doporučení:

| | Nízká technická kvalita | Vysoká technická kvalita |
|---|---|---|
| **Vysoká byznysová hodnota** | **Migrate** — převést na novou platformu / nahradit | **Invest** — dál investovat a rozvíjet |
| **Nízká byznysová hodnota** | **Eliminate** — vyřadit, funkce převést jinam | **Tolerate** — ponechat s minimálními náklady |

### ? Aplikace pro výpočet pojistného je pro pojišťovnu velmi důležitá, ale běží na zastaralé technologii, kterou už téměř nikdo neumí udržovat. Které doporučení modelu TIME odpovídá?

- [ ] Tolerate
- [ ] Invest
- [ ] Eliminate
- [x] Migrate

> Vysoká byznysová hodnota s nízkou technickou kvalitou vede k doporučení Migrate — funkce zachovat, ale převést na novou platformu. Eliminate se týká aplikací s nízkou hodnotou i kvalitou.

### ? Malá aplikace pro evidenci služebních vozů má nízkou byznysovou hodnotu, je zastaralá a její funkce už pokrývá nový modul ERP. Které doporučení modelu TIME odpovídá?

- [x] Eliminate
- [ ] Tolerate
- [ ] Migrate
- [ ] Invest

> Nízká byznysová hodnota a nízká technická kvalita spolu s duplicitou funkcí vedou k vyřazení (Eliminate). Tolerate by připadalo v úvahu, kdyby aplikace byla technicky v pořádku.

## Vývoj vs. nákup aplikace {#vyvoj-vs-nakup .compare}

Rozhodnutí „vyvinout, nebo koupit" (make or buy) závisí hlavně na tom, zda oblast tvoří **konkurenční výhodu** firmy, jak **specifické** jsou její procesy, jak **rychle** je řešení potřeba a jaké má firma **vlastní kapacity**.

| | Vlastní (zakázkový) vývoj | Hotový (standardní) software | Pronájem jako služba (SaaS) |
|---|---|---|---|
| Vhodné, když | proces je unikátní a je zdrojem konkurenční výhody | procesy jsou standardní, trh nabízí ověřená řešení | standardní procesy, potřeba rychlého startu bez vlastní infrastruktury |
| Přizpůsobení | plné, přesně podle potřeb | parametrizace, případně úpravy | omezené na nastavení, které služba nabízí |
| Rychlost nasazení | nejpomalejší | střední | nejrychlejší |
| Náklady | vysoké na vývoj i údržbu | licence, implementace, podpora | průběžné předplatné |
| Hlavní rizika | překročení času a rozpočtu, závislost na znalostech vývojářů | kompromis ve funkcích, drahé úpravy | závislost na poskytovateli, data mimo firmu |

### ? Firma vyvinula jedinečný způsob tvorby cen, který jí dává náskok před konkurencí, a žádný hotový produkt jej nepokrývá. Jaký způsob pořízení aplikace je nejvhodnější?

- [ ] Pronájem standardní aplikace jako SaaS
- [x] Vlastní (zakázkový) vývoj aplikace
- [ ] Nákup hotového softwaru bez úprav
- [ ] Ponechání výpočtu v tabulkovém procesoru

> Pokud je proces unikátní a je zdrojem konkurenční výhody, vyplatí se vlastní vývoj, který jej přesně podpoří. Standardní software by výhodu buď nepokryl, nebo by ji zpřístupnil i konkurentům.

### ? Malá firma bez vlastního IT oddělení potřebuje do měsíce zavést zpracování mezd podle standardních pravidel. Jaký způsob pořízení je nejvhodnější?

- [ ] Vlastní vývoj na míru
- [ ] Nákup zdrojových kódů a jejich úprava
- [ ] Vývoj vlastní aplikace pomocí brigádníků
- [x] Pronájem standardní aplikace jako SaaS

> Mzdy jsou standardní proces bez konkurenční výhody, firma nemá IT kapacity a potřebuje rychlý start, což nejlépe splňuje SaaS. Vlastní vývoj by byl pomalý, drahý a rizikový.

## Vodopádový model vývoje {#vodopadovy-model .term}

Vodopádový (waterfall) model je **sekvenční** přístup k vývoji aplikací, v němž fáze — **požadavky, analýza, návrh, implementace (programování), testování, nasazení a údržba** — probíhají **postupně za sebou** a každá začíná až po dokončení a schválení předchozí. Opírá se o podrobnou dokumentaci a předem zafixované požadavky; uživatel vidí funkční aplikaci až na konci a pozdní změny požadavků jsou drahé.

### ? Co je charakteristické pro vodopádový model vývoje aplikací?

- [x] Fáze jdou za sebou, každá po dokončení předchozí
- [ ] Aplikace se dodává v krátkých iteracích po částech
- [ ] Požadavky se průběžně mění podle zpětné vazby zákazníka
- [ ] Tým se denně schází na krátkém synchronizačním setkání

> Vodopád je sekvenční: požadavky, návrh, programování a testování následují za sebou. Krátké iterace, průběžná změna požadavků a denní setkání jsou rysy agilních přístupů.

## Agilní vývoj {#agilni-vyvoj .explain}

Agilní přístupy vycházejí z **Manifestu agilního vývoje softwaru** (2001), který formuluje čtyři hodnoty: **jednotlivci a interakce** před procesy a nástroji, **fungující software** před vyčerpávající dokumentací, **spolupráce se zákazníkem** před vyjednáváním o smlouvě a **reakce na změnu** před dodržováním plánu (hodnoty vpravo mají také význam, ale ty vlevo jsou ceněny více). Aplikace se vyvíjí **iterativně a inkrementálně** — v krátkých cyklech vzniká použitelná část, zákazník ji vidí a dává zpětnou vazbu a priority se mohou průběžně měnit. Hodí se zejména tam, kde požadavky nejsou na začátku zřejmé nebo se rychle mění.

*Příklad:* Banka vyvíjí novou mobilní aplikaci. Každé dva týdny ukáže vybraným klientům novou funkci a podle jejich reakcí upraví pořadí dalších prací.

### ? Která z uvedených dvojic odpovídá hodnotě z Manifestu agilního vývoje softwaru?

- [ ] Vyčerpávající dokumentace před fungujícím softwarem
- [ ] Procesy a nástroje před jednotlivci a interakcemi
- [x] Reakce na změnu před dodržováním plánu
- [ ] Vyjednávání o smlouvě před spoluprací se zákazníkem

> Manifest upřednostňuje reakci na změnu před dodržováním plánu. Ostatní možnosti mají pořadí obrácené — manifest dává přednost lidem, fungujícímu softwaru a spolupráci se zákazníkem.

### ? Startup vyvíjí aplikaci pro zcela nový typ služby. Zákazníci zatím nedokážou přesně říct, co budou potřebovat, a požadavky se budou měnit. Jaký přístup k vývoji je vhodnější?

- [ ] Vodopádový, protože fixuje požadavky na začátku
- [x] Agilní, protože pracuje s průběžnou zpětnou vazbou
- [ ] Vodopádový, protože zákazník vidí výsledek průběžně
- [ ] Agilní, protože nevyžaduje žádné zapojení zákazníka

> Při nejasných a měnících se požadavcích je výhodou agilní přístup s krátkými iteracemi a pravidelnou zpětnou vazbou. Agilní vývoj naopak zapojení zákazníka vyžaduje, a ve vodopádu vidí zákazník výsledek až na konci.

## Scrum {#scrum .explain}

Scrum je nejrozšířenější agilní rámec. Práce probíhá ve **sprintech** — iteracích pevné délky **nejvýše jeden měsíc** (často 2 týdny), na jejichž konci vzniká použitelný **přírůstek (inkrement)**.

- **Role:** **Product Owner** (vlastník produktu — spravuje a prioritizuje Product Backlog, zastupuje zájmy zákazníka), **Scrum Master** (pomáhá týmu správně používat Scrum a odstraňuje překážky), **vývojáři** (Developers — samoorganizovaně vytvářejí přírůstek).
- **Artefakty:** **Product Backlog** (seřazený seznam všeho, co má produkt obsahovat), **Sprint Backlog** (vybrané položky a plán na sprint), **přírůstek**.
- **Události:** plánování sprintu, **Daily Scrum** (krátké denní setkání, nejvýše 15 minut), revize sprintu (předvedení výsledku) a retrospektiva (zlepšení způsobu práce).

*Příklad:* Při vývoji zákaznického portálu určuje Product Owner z obchodního oddělení pořadí funkcí v backlogu; tým každé dva týdny předvede na revizi sprintu hotovou část portálu.

### ? Kdo ve Scrumu odpovídá za správu a prioritizaci Product Backlogu?

- [ ] Scrum Master
- [ ] Vývojáři
- [ ] Projektový manažer dodavatele
- [x] Product Owner

> Product Owner spravuje a řadí Product Backlog podle hodnoty pro zákazníka. Scrum Master pomáhá týmu s fungováním Scrumu, vývojáři vytvářejí přírůstek; role projektového manažera ve Scrumu není.

### ? Co platí pro sprint ve Scrumu?

- [ ] Trvá tak dlouho, dokud nejsou hotové všechny položky backlogu
- [ ] Délka se mění podle objemu práce v každé iteraci
- [x] Má pevnou délku nejvýše jeden měsíc a končí přírůstkem
- [ ] Končí jen tehdy, když zákazník schválí celou aplikaci

> Sprint je časově ohraničená iterace pevné délky nejvýše jeden měsíc, jejímž výsledkem je použitelný přírůstek. Celý produkt vzniká postupně v mnoha sprintech.

## Vodopád × agilní přístup {#vodopad-vs-agilni .compare}

Volba přístupu k vývoji nebo implementaci aplikace závisí na stabilitě požadavků, možnosti zapojení zákazníka a povaze projektu; v praxi se používají i kombinace (hybridní přístupy).

| | Vodopádový přístup | Agilní přístup |
|---|---|---|
| Průběh | sekvenční fáze za sebou | krátké opakované iterace |
| Požadavky | stanovené a zafixované na začátku | upřesňují se průběžně, změny se vítají |
| Dodání | celá aplikace na konci projektu | použitelné přírůstky po každé iteraci |
| Zapojení zákazníka | hlavně na začátku (požadavky) a na konci (převzetí) | průběžné, po každé iteraci |
| Dokumentace | podrobná, je klíčovým výstupem fází | jen nezbytná, přednost má fungující software |
| Vhodné, když | požadavky jsou jasné a stabilní, pevný rozsah (např. regulatorní povinnost) | požadavky jsou nejasné či se mění, je třeba rychle ověřovat |

### ? Firma musí upravit výkaznictví podle nového předpisu. Požadavky jsou přesně dané předpisem, nebudou se měnit a zákazník chce pevný rozsah. Který přístup je typicky vhodnější?

- [x] Vodopádový, protože požadavky jsou jasné a stabilní
- [ ] Agilní, protože požadavky jsou jasné a stabilní
- [ ] Vodopádový, protože zákazník chce průběžnou zpětnou vazbu
- [ ] Agilní, protože vyžaduje nejpodrobnější dokumentaci

> Při jasných, stabilních požadavcích a pevném rozsahu se dobře uplatní sekvenční vodopádový přístup. Agilní přístup vyniká hlavně tam, kde se požadavky mění, a podrobnou dokumentaci naopak upozaďuje.

### ? Kdy se uživatel při agilním vývoji poprvé setká s fungující částí aplikace?

- [ ] Až po dokončení všech fází projektu
- [ ] Až po schválení kompletní dokumentace
- [ ] Až při akceptačním testu celé aplikace
- [x] Už po první iteraci, např. po prvním sprintu

> Agilní vývoj dodává použitelné přírůstky po každé iteraci, takže uživatel vidí fungující část brzy a může dávat zpětnou vazbu. Ve vodopádu se fungující aplikace ukáže až na konci.

## Strategické aplikace {#strategicke-aplikace .term}

Strategické aplikace jsou aplikace, které **přímo podporují naplnění budoucí strategie firmy** a jsou zdrojem její **konkurenční výhody** — umožňují nový produkt, službu, obchodní model nebo výrazně lepší vztah se zákazníkem. Nejde o to, zda je aplikace velká nebo drahá, ale o její **přínos pro konkurenční postavení**. Strategický význam není trvalý: jakmile podobné řešení zavedou i konkurenti, aplikace se stává běžnou provozní nutností.

### ? Co odlišuje strategickou aplikaci od ostatních aplikací firmy?

- [ ] Je to vždy nejdražší aplikace v portfoliu
- [x] Podporuje strategii a konkurenční výhodu firmy
- [ ] Používá ji největší počet zaměstnanců firmy
- [ ] Je dodávána největším světovým výrobcem softwaru

> Strategická aplikace se pozná podle přínosu ke konkurenčnímu postavení firmy a k její budoucí strategii. Cena, počet uživatelů ani dodavatel o strategickém významu nerozhodují.

## Matice strategického významu aplikací (McFarlan) {#mcfarlanova-matice .compare}

Matice, v české literatuře označovaná jako **McFarlanova** (vychází z McFarlanovy strategické mřížky; pro portfolio aplikací ji rozpracovali J. Ward a J. Peppard), třídí aplikace podle významu pro **současný provoz** a pro **budoucí úspěch** firmy. Každý kvadrant vyžaduje jiný přístup k řízení a pořízení. Aplikace se v čase přesouvají — z kvadrantu s vysokým potenciálem se může stát strategická, ta se postupně mění v klíčovou provozní a nakonec až v podpůrnou.

| Kvadrant | Charakteristika | Příklad | Přístup k řízení |
|---|---|---|---|
| **Strategické** | kritické pro budoucí strategii, zdroj konkurenční výhody | systém personalizovaných nabídek pro zákazníky | řízení vedením a byznysem, investice podle přínosu, často vývoj na míru |
| **Klíčové provozní** | na nich závisí současný chod firmy, výpadek ji ochromí, výhodu však nepřinášejí | ERP s objednávkami, skladem a fakturací | spolehlivost, kvalita dat, osvědčená standardní řešení |
| **Podpůrné** | užitečné, zvyšují efektivitu, ale nejsou kritické | mzdy, docházka, cestovní náhrady | minimální náklady, standardní software, SaaS či outsourcing |
| **S vysokým potenciálem** | nové nápady s nejistým přínosem, mohou se stát strategickými | pilotní ověřování nové technologie | experiment, omezený rozpočet, rychlé vyhodnocení a rozhodnutí |

### ? Distribuční firma používá ERP pro objednávky, sklad a fakturaci. Bez něj by se provoz zastavil, ale stejné řešení mají i všichni konkurenti. Do kterého kvadrantu McFarlanovy matice ERP patří?

- [ ] Strategické aplikace
- [ ] Podpůrné aplikace
- [x] Klíčové provozní aplikace
- [ ] Aplikace s vysokým potenciálem

> Na klíčových provozních aplikacích závisí současný chod firmy, konkurenční výhodu ale nepřinášejí. Strategická by byla jen tehdy, kdyby firmě dávala náskok před konkurencí.

### ? Jaký přístup k řízení je typicky vhodný pro podpůrné aplikace, jako je evidence cestovních náhrad?

- [x] Co nejnižší náklady, standardní software nebo SaaS
- [ ] Rozsáhlé investice a vývoj aplikace přesně na míru
- [ ] Řízení přímo vrcholovým vedením jako strategický projekt
- [ ] Opakované experimentování s novými technologiemi

> Podpůrné aplikace nejsou kritické ani strategické, proto se řídí s důrazem na efektivitu a nízké náklady. Investice a řízení vedením patří strategickým aplikacím, experimenty aplikacím s vysokým potenciálem.

### ? Pojišťovna v malém pilotu zkouší aplikaci, která z fotografií odhaduje škodu na voze. Přínos je zatím nejistý, ale v budoucnu by mohl být velký. Do kterého kvadrantu McFarlanovy matice aplikace patří?

- [ ] Strategické aplikace
- [ ] Klíčové provozní aplikace
- [ ] Podpůrné aplikace
- [x] Aplikace s vysokým potenciálem

> Nové aplikace s nejistým, ale potenciálně velkým přínosem patří do kvadrantu s vysokým potenciálem. Řídí se jako experiment s omezeným rozpočtem; pokud se osvědčí, mohou se stát strategickými.
