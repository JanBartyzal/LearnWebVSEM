---
kind: topic
subject: aplikace-podnikove-informatiky
slug: vymezeni-aplikaci-v-podnikove-informatice
name: "Vymezení aplikací v podnikové informatice"
order: 1
---

podstata aplikací, kategorizace aplikačního software. Přehled hlavních typů aplikací, podnikové portály, intranety a extrakty. Poptávka a nabídka aplikací na ICT trhu.

## Aplikační software (aplikace) {#aplikacni-software .term}

Aplikační software je program nebo soubor programů, který **přímo podporuje činnosti uživatelů a procesy firmy** — např. účtování, prodej, skladování, plánování nebo analýzy. Na rozdíl od **systémového software** (operační systémy, ovladače, virtualizace, databázové systémy, middleware) neřídí chod počítače ani běh jiných programů, ale řeší **věcné úlohy podniku**. Aplikace běží nad systémovým software a ICT infrastrukturou.

### ? Který z uvedených programů je aplikačním software?

- [ ] Operační systém aplikačního serveru
- [x] Systém pro evidenci a fakturaci zakázek
- [ ] Ovladač síťové karty v serveru
- [ ] Virtualizační platforma datového centra

> Evidence a fakturace zakázek přímo podporuje podnikový proces, jde tedy o aplikační software. Operační systém, ovladač i virtualizace jsou systémový software, který zajišťuje běh aplikací.

## Aplikační software × systémový software × ICT infrastruktura {#vrstvy-ict .compare}

Podniková informatika se skládá z vrstev, které na sobě stavějí: aplikace potřebují systémový software a ten zase infrastrukturu.

| | Aplikační software | Systémový software | ICT infrastruktura |
|---|---|---|---|
| Účel | podpora podnikových procesů a uživatelů | chod hardwaru a běh aplikací | fyzický a síťový základ |
| Příklady | ERP, CRM, e-shop, mzdy, BI | operační systém, virtualizace, databázový systém, middleware | servery, úložiště, sítě, koncová zařízení, datové centrum |
| Hlavní uživatelé | koncoví uživatelé z byznysu | správci IT a vývojáři | IT provoz |
| Vazba na byznys | přímá — řeší věcné úlohy | zprostředkovaná | zprostředkovaná |

### ? Firma kupuje nové servery, diskové pole a síťové přepínače do svého datového centra. Do které vrstvy podnikové informatiky tato investice patří?

- [ ] Aplikační software
- [ ] Systémový software
- [ ] Uživatelské rozhraní aplikací
- [x] ICT infrastruktura

> Servery, úložiště a síťové prvky tvoří fyzický základ, na kterém běží systémový i aplikační software. Jde proto o investici do ICT infrastruktury.

### ? Do které vrstvy podnikové informatiky se řadí operační systém a virtualizační platforma?

- [x] Systémový software
- [ ] Aplikační software
- [ ] Kancelářské aplikace
- [ ] Podnikové portály

> Operační systém a virtualizace zajišťují chod hardwaru a běh aplikací, nepodporují přímo podnikové procesy. Proto patří do systémového software.

## Podstata a stavba podnikové aplikace {#stavba-aplikace .explain}

Podniková aplikace se obvykle skládá ze tří částí: **datové vrstvy** (databáze se sdílenými podnikovými daty), **aplikační logiky** (business pravidla, výpočty, kontroly a návaznost kroků procesu) a **uživatelského rozhraní** (formuláře, přehledy, mobilní nebo webový přístup). Na rozdíl od osobních programů je **víceuživatelská** — mnoho uživatelů současně pracuje se stejnými daty podle svých **přístupových práv** — a bývá **integrována** s dalšími aplikacemi firmy. Hodnotu přináší tím, jak dobře podporuje procesy, nikoli samotnou technologií.

*Příklad:* Obchodník zadá objednávku do formuláře (uživatelské rozhraní), aplikace ověří úvěrový limit zákazníka a dostupnost zboží (aplikační logika) a objednávku uloží, takže ji hned vidí sklad i fakturace (data).

### ? Aplikace při zadání objednávky ověří, zda zákazník nepřekročil úvěrový limit. Do které části aplikace tato kontrola patří?

- [ ] Do uživatelského rozhraní
- [ ] Do systémového software
- [x] Do aplikační (business) logiky
- [ ] Do datové vrstvy (databáze)

> Business pravidla, výpočty a kontroly tvoří aplikační logiku. Uživatelské rozhraní data jen zobrazuje a přijímá, databáze je ukládá.

### ? Čím se podniková aplikace typicky liší od jednoduchého osobního programu?

- [ ] Nepotřebuje ke svému chodu žádnou databázi
- [ ] Je vždy vyvinuta na zakázku pro jednu firmu
- [ ] Neobsahuje žádné uživatelské rozhraní
- [x] Více uživatelů sdílí data podle svých práv

> Podniková aplikace slouží mnoha uživatelům současně nad sdílenými daty a řídí, kdo smí co vidět a měnit. Může být krabicová i zakázková a uživatelské rozhraní má vždy.

## Kategorizace aplikačního software {#kategorizace .explain}

Aplikace lze třídit podle několika na sobě nezávislých kritérií:

- **podle rozsahu** — celopodnikové × oborové (branžové) × specializované;
- **podle úrovně řízení** — transakční (TPS) × manažerské informační (MIS) × pro podporu rozhodování (DSS, EIS);
- **podle způsobu pořízení a dodávky** — krabicové (standardní) × zakázkové × SaaS (software jako služba);
- **podle licence a přístupu ke zdrojovému kódu** — open source × proprietární;
- **podle věcné oblasti** — ERP, CRM, SCM, ECM, BI, eBusiness a další.

Jedna aplikace se tak dá zařadit do více kategorií současně.

*Příklad:* Docházkový systém pronajímaný v cloudu je specializovaná aplikace, pracuje na transakční úrovni, je dodáván jako SaaS a je proprietární.

### ? Firma třídí své aplikace na krabicové, zakázkové a SaaS. Podle kterého kritéria je kategorizuje?

- [x] Podle způsobu pořízení a dodávky
- [ ] Podle rozsahu pokrytí podniku
- [ ] Podle úrovně řízení, kterou podporují
- [ ] Podle přístupu ke zdrojovému kódu

> Krabicové, zakázkové a SaaS řešení se liší tím, jak firma aplikaci získá a kdo ji provozuje. Rozsah dělí aplikace na celopodnikové, oborové a specializované, úroveň řízení na TPS, MIS a DSS/EIS.

## Celopodnikové × oborové × specializované aplikace {#podle-rozsahu .compare}

Podle rozsahu se aplikace liší tím, jakou část podniku a jaké procesy pokrývají.

| | Celopodnikové | Oborové (branžové) | Specializované |
|---|---|---|---|
| Pokrytí | většina procesů napříč útvary | specifické procesy jednoho odvětví | jedna úzká funkce nebo činnost |
| Uživatelé | celá firma | firmy daného oboru | konkrétní útvar nebo profese |
| Příklady | ERP | nemocniční IS, bankovní systém, IS pro stavebnictví | CAD, mzdový program, evidence docházky |

Hranice nejsou ostré — např. branžová řešení ERP spojují celopodnikový rozsah s oborovými funkcemi.

### ? Projekční kancelář pořizuje program pro tvorbu konstrukčních výkresů, který budou používat jen konstruktéři. Do které kategorie podle rozsahu patří?

- [ ] Celopodniková aplikace
- [ ] Oborová (branžová) aplikace
- [ ] Transakční systém (TPS)
- [x] Specializovaná aplikace

> Program pro konstrukční výkresy (CAD) pokrývá jednu úzkou činnost jedné profese, jde proto o specializovanou aplikaci. Celopodniková aplikace by pokrývala procesy napříč útvary.

### ? Nemocnice zavádí systém pro evidenci pacientů, zdravotní dokumentaci a vykazování péče pojišťovnám. Do které kategorie podle rozsahu patří?

- [ ] Celopodniková aplikace typu ERP
- [x] Oborová (branžová) aplikace
- [ ] Specializovaná kancelářská aplikace
- [ ] Systémový software nemocnice

> Systém řeší procesy specifické pro zdravotnictví, které jiná odvětví nemají, jde tedy o oborovou aplikaci. ERP pokrývá obecné procesy (finance, nákup, sklad) společné většině firem.

## TPS × MIS × DSS × EIS {#podle-urovne-rizeni .compare}

Podle úrovně řízení se aplikace liší tím, komu slouží a jak pracují s daty.

| | TPS (Transaction Processing System) | MIS (Management Information System) | DSS (Decision Support System) | EIS (Executive Information System) |
|---|---|---|---|---|
| Úroveň řízení | operativní | taktická (střední management) | taktická i strategická (manažeři, analytici) | strategická (vrcholové vedení) |
| Úloha | zaznamenává a zpracovává jednotlivé transakce | pravidelné souhrnné přehledy z dat TPS | podpora málo strukturovaných rozhodnutí, modely, analýzy „co když" | souhrnné ukazatele a trendy, interní i externí data, rozpad do detailu (drill-down) |
| Příklad | pokladna, příjem objednávek, fakturace | měsíční přehled tržeb podle poboček | model dopadu změny cen na zisk | přehled klíčových ukazatelů pro představenstvo |

Funkce MIS, DSS a EIS dnes z velké části pokrývají nástroje **Business Intelligence (BI)**.

### ? Vedoucí pobočkové sítě dostává každý měsíc standardní přehled tržeb a nákladů podle jednotlivých poboček. Který typ systému mu jej poskytuje?

- [ ] TPS
- [ ] DSS
- [x] MIS
- [ ] EIS

> Pravidelné standardní souhrnné přehledy pro střední management jsou typickým výstupem MIS. TPS zaznamenává jednotlivé transakce, DSS podporuje neobvyklá rozhodnutí modely a EIS slouží vrcholovému vedení.

### ? Analytik modeluje, jak by se změnil zisk při různém zvýšení cen a odhadovaném poklesu poptávky. Který typ systému k tomu použije?

- [x] DSS
- [ ] MIS
- [ ] TPS
- [ ] EIS

> Analýzy „co když" nad modely jsou typickou úlohou systému pro podporu rozhodování (DSS). MIS poskytuje standardní přehledy, TPS zpracovává transakce.

### ? Který typ systému pracuje na operativní úrovni a zaznamenává jednotlivé obchodní případy, např. prodeje na pokladně?

- [ ] EIS
- [ ] MIS
- [ ] DSS
- [x] TPS

> Transakční systém (TPS) zaznamenává a zpracovává jednotlivé transakce a je zdrojem dat pro MIS, DSS i EIS.

## Krabicové × zakázkové × SaaS řešení {#podle-dodavky .compare}

Firma může aplikaci koupit jako hotový produkt, nechat si ji vyvinout, nebo ji odebírat jako službu.

| | Krabicové (standardní) | Zakázkové (na míru) | SaaS (software jako služba) |
|---|---|---|---|
| Podstata | hotový produkt pro mnoho zákazníků, přizpůsobení nastavením | vyvinuto pro potřeby konkrétní firmy | hotová aplikace provozovaná poskytovatelem, přístup přes internet |
| Pořizovací náklady | střední | vysoké | nízké vstupní, průběžné předplatné |
| Rychlost nasazení | střední | pomalá | nejrychlejší |
| Shoda s procesy firmy | firma se často přizpůsobuje produktu | plná | omezená možnostmi konfigurace |
| Provoz a aktualizace | firma nebo její partner | firma nebo vývojář podle smlouvy | poskytovatel |
| Hlavní riziko | závislost na výrobci a jeho rozvoji | délka vývoje, náklady na údržbu | závislost na poskytovateli, data mimo firmu |

### ? Firma má jedinečný výrobní postup, který je jejím zdrojem konkurenční výhody, a žádný standardní produkt ho nepokrývá. Jaký způsob pořízení aplikace je nejvhodnější?

- [ ] Krabicové řešení s parametrizací
- [x] Zakázková aplikace vyvinutá na míru
- [ ] SaaS služba s měsíčním předplatným
- [ ] Open source kancelářský balík

> Zakázkový vývoj umožní plně podpořit jedinečný proces, který standardní produkty nepokrývají. Je dražší a pomalejší, ale u zdroje konkurenční výhody se to vyplatí.

### ? Malá firma chce rychle začít používat CRM, nechce provozovat vlastní servery a preferuje pravidelné měsíční platby. Které řešení zvolí?

- [ ] Zakázkovou aplikaci na vlastních serverech
- [ ] Krabicový produkt instalovaný ve firmě
- [x] CRM jako službu (SaaS)
- [ ] Vlastní vývoj na open source platformě

> SaaS se nasazuje nejrychleji, provoz a aktualizace zajišťuje poskytovatel a platí se předplatným. Ostatní varianty vyžadují vlastní provoz nebo delší vývoj.

### ? Co je typickou nevýhodou krabicového (standardního) software?

- [ ] Vždy má vyšší pořizovací náklady než vývoj
- [ ] Nedá se nijak nastavit ani parametrizovat
- [ ] Jeho vývoj pro firmu trvá několik let
- [x] Firma musí část procesů přizpůsobit produktu

> Krabicový software je navržen pro mnoho zákazníků, takže jeho logika nemusí přesně odpovídat procesům firmy. Lze jej parametrizovat a obvykle je levnější a rychlejší než vývoj na míru.

## Open source × proprietární software {#open-source-vs-proprietarni .compare}

Rozdíl spočívá v licenci a v přístupu ke zdrojovému kódu, nikoli v tom, zda je software „zdarma".

| | Open source | Proprietární |
|---|---|---|
| Zdrojový kód | zveřejněný, lze jej studovat, upravovat a šířit podle licence | uzavřený, vlastní jej výrobce |
| Licence | open source licence (např. GPL, MIT, Apache) bez poplatku za užití | licenční poplatky, podmínky určuje výrobce |
| Podpora | komunita nebo placená podpora specializovaných firem | výrobce a jeho partneři |
| Náklady | licence zdarma, ale implementace, podpora a správa stojí peníze | licence + implementace + údržba |
| Příklady | Linux, PostgreSQL, LibreOffice | SAP S/4HANA, Microsoft Dynamics 365 |

### ? Které tvrzení o nasazení open source podnikové aplikace je pravdivé?

- [x] Licence je zdarma, nasazení a podpora stojí peníze
- [ ] Celkové náklady na její provoz jsou vždy nulové
- [ ] Podporu k ní může poskytovat výhradně komunita
- [ ] Firma nesmí zdrojový kód aplikace upravovat

> Open source licence nevyžaduje poplatek za užití, ale nasazení, úpravy, správa i podpora náklady vytvářejí. Podporu poskytují i komerční firmy a kód lze podle licence upravovat.

### ? Firma chce mít možnost sama upravovat zdrojový kód aplikace a nebýt přitom závislá na souhlasu výrobce. Jaký typ software tomu odpovídá?

- [ ] Proprietární krabicový software
- [ ] Proprietární SaaS aplikace
- [x] Open source software
- [ ] Software s trvalou licencí

> Open source licence zpřístupňuje zdrojový kód a dovoluje jej upravovat. U proprietárního software je kód uzavřený bez ohledu na to, zda jde o krabici, SaaS či trvalou licenci.

## Přehled hlavních typů podnikových aplikací {#mapa-typu-aplikaci .compare}

Podle věcné oblasti tvoří aplikační portfolio firmy tyto hlavní typy (podrobně v dalších tématech):

| Typ | Zaměření | Typické úlohy |
|---|---|---|
| **ERP** (Enterprise Resource Planning) | integrované jádro, interní zdroje a transakce | finance, nákup, sklad, prodej, výroba, personalistika |
| **CRM** (Customer Relationship Management) | vztahy se zákazníky | kontakty, obchodní příležitosti, kampaně, servis |
| **SCM** (Supply Chain Management) | dodavatelský řetězec | plánování poptávky, zásob, výroby a distribuce s partnery |
| **ECM** (Enterprise Content Management) | nestrukturovaný obsah | dokumenty, workflow, archivace, spolupráce |
| **BI** (Business Intelligence) | analýzy a podpora rozhodování | reporting, dashboardy, datový sklad |
| **eBusiness** | elektronické obchodní vztahy | e-shop, elektronické zásobování, e-tržiště, EDI |

### ? Firma chce centrálně ukládat smlouvy a další dokumenty s historií verzí, metadaty a schvalovacím postupem. Který typ aplikace hledá?

- [ ] CRM
- [ ] BI
- [ ] SCM
- [x] ECM

> Správa dokumentů, jejich verzí a schvalovacích postupů je úlohou ECM (Enterprise Content Management). CRM řídí vztahy se zákazníky, BI analýzy a SCM dodavatelský řetězec.

### ? Která aplikace tvoří integrované transakční jádro, které propojuje finance, nákup, sklad, prodej i výrobu nad společnými daty?

- [ ] CRM
- [x] ERP
- [ ] BI
- [ ] ECM

> ERP pokrývá hlavní interní podnikové transakce nad sdílenou databází a ostatní aplikace se na něj zpravidla napojují.

## Podnikový portál {#podnikovy-portal .term}

Podnikový portál (enterprise portal) je webová aplikace, která uživatelům poskytuje **jednotný přístupový bod** k informacím, aplikacím a službám firmy. Obsah a funkce jsou **personalizované podle role** uživatele a přístup bývá řešen **jednotným přihlášením** (Single Sign-On, SSO). Portál data většinou sám nevytváří, ale **integruje je z různých systémů** (ERP, CRM, správa dokumentů…) do jednoho uživatelského rozhraní.

### ? Zaměstnanci se přihlašují do pěti různých systémů zvlášť a potřebné informace hledají na mnoha místech. Jaké řešení jim poskytne jednotné místo přístupu?

- [x] Podnikový portál s jednotným přihlášením
- [ ] Nový transakční systém pro každý útvar
- [ ] Samostatný systém pro podporu rozhodování
- [ ] Výměna dat se zákazníky pomocí EDI

> Podnikový portál zpřístupňuje informace a aplikace z jednoho místa a díky jednotnému přihlášení (SSO) se uživatel nemusí přihlašovat do každého systému zvlášť.

### ? Co je typickou vlastností podnikového portálu?

- [ ] Nahrazuje ERP i jeho databázi
- [ ] Je přístupný jen z jednoho počítače
- [x] Obsah se přizpůsobuje roli uživatele
- [ ] Slouží výhradně k výměně EDI zpráv

> Portál zobrazuje každému uživateli informace a funkce odpovídající jeho roli (personalizace). Data přitom čerpá z ostatních systémů, nenahrazuje je.

## Intranet {#intranet .term}

Intranet je **vnitřní síť a webové prostředí firmy** postavené na **internetových technologiích** (protokoly TCP/IP, web), přístupné **pouze zaměstnancům** (zvenku obvykle přes VPN nebo zabezpečené přihlášení). Slouží k interní komunikaci a sdílení — novinky, směrnice, telefonní seznam, formuláře, znalostní báze — a často i jako vstup k interním aplikacím (zaměstnanecký portál).

### ? Firma chce zaměstnancům zpřístupnit interní směrnice, novinky a telefonní seznam tak, aby je neviděl nikdo mimo firmu. Které řešení odpovídá?

- [ ] Extranet pro obchodní partnery
- [x] Intranet přístupný zaměstnancům
- [ ] Veřejné firemní webové stránky
- [ ] Elektronické tržiště (e-marketplace)

> Intranet využívá webové technologie, ale je přístupný jen zaměstnancům firmy. Extranet by obsah zpřístupnil i externím partnerům, veřejný web komukoli.

## Extranet {#extranet .term}

Extranet je část podnikové sítě či aplikací založená na **internetových technologiích**, kterou firma **řízeně zpřístupní vybraným externím partnerům** — dodavatelům, odběratelům, dealerům — přes zabezpečený přístup. Partneři v něm např. sledují stav objednávek, zásoby nebo faktury a sdílejí dokumenty. Bývá chápán jako **rozšíření intranetu za hranice firmy**.

### ? Výrobce chce, aby jeho dealeři mohli online sledovat stav svých objednávek a dostupnost náhradních dílů, ale veřejnost k těmto údajům přístup mít nesmí. Jaké řešení použije?

- [ ] Intranet pro vlastní zaměstnance
- [ ] Veřejné firemní webové stránky
- [ ] Interní systém pro podporu rozhodování
- [x] Extranet pro obchodní partnery

> Extranet zpřístupňuje vybrané údaje firmy ověřeným externím partnerům, přičemž veřejnost k nim přístup nemá.

## Intranet × extranet × veřejný web {#intranet-extranet-web .compare}

Všechna tři prostředí využívají stejné internetové technologie, liší se tím, **kdo k nim má přístup**.

| | Intranet | Extranet | Veřejný web (internet) |
|---|---|---|---|
| Kdo má přístup | jen zaměstnanci firmy | vybraní externí partneři (a zaměstnanci) | kdokoli |
| Přihlášení | povinné, interní účty | povinné, účty partnerů | obvykle není nutné |
| Typický obsah | směrnice, novinky, formuláře, interní aplikace | objednávky, zásoby, faktury, sdílené dokumenty | prezentace firmy, katalog, kontakty |
| Typický portál | zaměstnanecký | partnerský (dodavatelský, dealerský) | zákaznický, informační |

### ? Čím se extranet liší od intranetu?

- [ ] Nevyužívá internetové technologie
- [x] Přístup mají i vybraní externí partneři
- [ ] Je volně přístupný široké veřejnosti
- [ ] Neumožňuje sdílení žádných dokumentů

> Intranet i extranet stojí na internetových technologiích a vyžadují přihlášení. Extranet je ale otevřen i vybraným partnerům mimo firmu, nikoli veřejnosti.

### ? Co mají intranet, extranet i veřejný web společné?

- [ ] Stejný okruh uživatelů s přístupem
- [ ] Povinné přihlášení každého návštěvníka
- [ ] Obsah určený jen zaměstnancům firmy
- [x] Využívají stejné internetové technologie

> Všechna tři prostředí jsou postavena na internetových technologiích (TCP/IP, web). Liší se tím, kdo k nim má přístup a zda je nutné přihlášení.

## Typy podnikových portálů {#typy-portalu .explain}

Podle toho, komu portál slouží, se rozlišují zejména:

- **zaměstnanecký portál** (B2E, business-to-employee) — samoobsluha zaměstnanců: žádosti o dovolenou, výplatní pásky, směrnice, interní aplikace; obvykle součást intranetu;
- **partnerský (dodavatelský, dealerský) portál** (B2B) — spolupráce s obchodními partnery: objednávky, potvrzení dodávek, faktury, sdílené plány; obvykle v rámci extranetu;
- **zákaznický portál** (B2C) — samoobsluha zákazníků: přehled smluv a faktur, servisní požadavky, nákupy.

Samoobsluha přes portál snižuje administrativu a zrychluje komunikaci, protože uživatel si údaje zjistí nebo zadá sám.

*Příklad:* Energetická společnost provozuje zákaznický portál, kde si odběratelé stahují faktury a zadávají stav měřidla, a zároveň dodavatelský portál pro výběrová řízení a potvrzování objednávek.

### ? Zaměstnanec si přes portál podá žádost o dovolenou a stáhne si výplatní pásku. O jaký typ portálu jde?

- [x] Zaměstnanecký portál (B2E)
- [ ] Zákaznický portál (B2C)
- [ ] Dodavatelský portál (B2B)
- [ ] Veřejný informační portál

> Samoobsluha zaměstnanců (dovolená, mzdy, směrnice) je náplní zaměstnaneckého portálu, který bývá součástí intranetu.

### ? Dodavatelé přes portál odběratele potvrzují přijaté objednávky a nahrávají své faktury. O jaký typ portálu jde?

- [ ] Zaměstnanecký portál (B2E)
- [ ] Zákaznický portál (B2C)
- [x] Partnerský portál (B2B)
- [ ] Interní znalostní portál

> Spolupráce s obchodními partnery — objednávky, potvrzení, faktury — probíhá přes partnerský (B2B) portál, obvykle v rámci extranetu.

## Poptávka po aplikacích na ICT trhu {#poptavka-aplikaci .explain}

Poptávku po podnikových aplikacích tvoří **velké podniky, malé a střední podniky i veřejná správa**. Typickými podněty jsou **růst a změna podnikání**, **nová legislativa**, **náhrada zastaralého systému** (končící podpora, neudržitelné úpravy), **digitalizace procesů** a tlak konkurence. O pořízení by neměl rozhodovat jen útvar IT: požadavky na funkce formuluje **byznys — vlastníci procesů a uživatelé**, IT posuzuje architekturu, integraci a provoz. Menší firmy obvykle sahají po standardních a SaaS řešeních, velké firmy častěji kombinují standardní produkty s úpravami a integrací.

*Příklad:* Distribuční firma s rychle rostoucím e-shopem zjistí, že účetní program nezvládá objem objednávek ani napojení na sklad. Obchodní a finanční ředitel sepíší požadavky, IT doplní požadavky na integraci a firma vypíše výběrové řízení na ERP.

### ? Kdo by měl při výběru nové podnikové aplikace hlavně formulovat požadavky na její funkcionalitu?

- [ ] Výhradně útvar IT
- [ ] Výhradně dodavatel aplikace
- [ ] Výhradně vrcholové vedení firmy
- [x] Vlastníci procesů a uživatelé

> Funkční požadavky vycházejí z potřeb procesů, které nejlépe znají jejich vlastníci a uživatelé. IT doplňuje požadavky na architekturu, integraci a provoz.

### ? Výrobce aplikace oznámil, že ukončuje podporu verze, kterou firma používá, a další úpravy už nebudou možné. Jaký podnět poptávky po nové aplikaci tím u firmy vzniká?

- [x] Nutnost nahradit zastaralý systém
- [ ] Změna legislativy v oboru
- [ ] Vstup firmy na nový trh
- [ ] Potřeba nového prodejního kanálu

> Konec podpory a neudržitelnost úprav jsou typickým důvodem náhrady zastaralého systému. Ostatní možnosti jsou také podněty poptávky, ale v popsané situaci nenastaly.

## Dodavatelé aplikací na ICT trhu {#dodavatele-aplikaci .compare}

Na straně nabídky působí několik typů dodavatelů, kteří se často kombinují.

| Dodavatel | Role | Příklad činnosti |
|---|---|---|
| **Výrobce (vendor)** | vyvíjí a vlastní softwarový produkt, určuje jeho rozvoj a licence | vydává nové verze ERP |
| **Implementační partner (prodejce, reseller)** | prodává, implementuje a podporuje produkt výrobce, často s vlastními rozšířeními | nastaví ERP pro konkrétního zákazníka |
| **Systémový integrátor** | dodává řešení na klíč z produktů více výrobců a propojuje je | propojí ERP, CRM a e-shop |
| **Poskytovatel SaaS a cloudových služeb** | provozuje aplikaci a poskytuje ji jako službu | pronajímá CRM v cloudu |
| **Poradce (konzultant)** | nezávisle pomáhá s analýzou potřeb a výběrem | připraví výběrové řízení |

### ? Firma potřebuje propojit ERP, CRM a e-shop od různých výrobců a chce celé řešení dodat na klíč od jedné firmy. Kterého typu dodavatele osloví?

- [ ] Výrobce jednoho z produktů
- [ ] Poskytovatele cloudové infrastruktury
- [x] Systémového integrátora
- [ ] Nezávislého poradce pro výběr

> Systémový integrátor dodává řešení složené z produktů více výrobců a zajišťuje jejich propojení. Poradce pomáhá s výběrem, ale řešení nedodává.

### ? Globální výrobce ERP v Česku neimplementuje svůj produkt sám, ale prostřednictvím certifikovaných místních firem. Jak se tyto firmy nazývají?

- [x] Implementační partneři
- [ ] Systémoví výrobci
- [ ] Poskytovatelé infrastruktury
- [ ] Nezávislí konzultanti

> Implementační partneři prodávají, nastavují a podporují produkt výrobce u zákazníků, často s vlastními rozšířeními. Výrobce produkt vyvíjí a určuje jeho rozvoj.

## Licenční modely aplikací {#licencni-modely .compare}

Licenční model určuje, za co a jak dlouho firma platí právo aplikaci užívat.

| | Trvalá licence (perpetual) | Předplatné (subscription) |
|---|---|---|
| Platba | jednorázová za licenci + obvykle roční poplatek za údržbu a podporu | pravidelná (měsíčně, ročně) |
| Právo užívání | trvalé, i bez placení údržby (ale bez aktualizací a podpory) | jen po dobu placení předplatného |
| Aktualizace a podpora | v rámci placené údržby | zahrnuty v předplatném |
| Typický výskyt | instalace ve firmě (on-premise) | SaaS, ale i software instalovaný ve firmě |

Cena se v obou modelech často odvozuje od počtu uživatelů (**per user**): **jmenovitý uživatel** (named user) — licence patří konkrétní osobě; **souběžný uživatel** (concurrent user) — omezen je počet lidí pracujících současně. Dalšími měřítky bývají např. počet serverů či procesorových jader nebo objem transakcí.

### ? Firma zaplatí jednorázově za licenci ERP a pak každý rok platí poplatek za aktualizace a podporu. Jaký licenční model využívá?

- [ ] Předplatné (subscription)
- [x] Trvalou licenci (perpetual)
- [ ] Open source licenci
- [ ] Licenci souběžného uživatele

> Trvalá licence se platí jednorázově a dává trvalé právo užívání; aktualizace a podporu firma získává placením roční údržby.

### ? Aplikaci potřebuje 100 zaměstnanců na směny, ale současně v ní nikdy nepracuje víc než 20 z nich. Který způsob licencování je pro firmu nejvýhodnější?

- [ ] Licence pro jmenovité uživatele
- [ ] Licence podle počtu serverů
- [ ] Licence podle počtu transakcí
- [x] Licence pro souběžné uživatele

> Licence pro souběžné uživatele omezuje jen počet lidí pracujících současně, firma tedy zaplatí 20 licencí místo 100 jmenovitých.

### ? Co se obvykle stane, když firma přestane platit předplatné SaaS aplikace?

- [x] Ztratí právo aplikaci dál používat
- [ ] Získá trvalou licenci bez podpory
- [ ] Aplikace přejde do jejího vlastnictví
- [ ] Ztratí jen nárok na nové verze

> U předplatného trvá právo užívání jen po dobu placení. Trvalé právo užívání bez podpory je vlastností trvalé (perpetual) licence.
