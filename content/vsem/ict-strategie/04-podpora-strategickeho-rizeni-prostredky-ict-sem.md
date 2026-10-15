---
kind: topic
subject: ict-strategie
slug: podpora-strategickeho-rizeni-prostredky-ict-sem
name: "Podpora strategického řízení prostředky ICT (SEM)"
order: 4
---

Podpora strategického řízení prostředky ICT. Návrh a specifikace aplikací typu SEM (Strategic Enterprise Management), definování jejich požadované funkcionality a podpory procesů strategického řízení informačními technologiemi. V rámci projektů strategického řízení se definují i úlohy multidimenzionálně orientovaných podnikových analýz a plánovacích činností jako součásti manažerských aplikací.

## Strategic Enterprise Management (SEM) {#sem .term}

**Strategic Enterprise Management (SEM)** je třída manažerských aplikací, které podporují **celý cyklus strategického řízení** podniku: od formulace strategie a stanovení cílů přes plánování a simulace až po sledování plnění cílů a vyhodnocení výkonnosti. Nepracují s jednotlivými transakcemi, ale s daty z transakčních systémů (ERP) shromážděnými v **datovém skladu**, která doplňují o externí informace. Pojem se spojuje zejména s produktem SAP SEM.

### ? Co je hlavním účelem aplikací typu SEM?

- [ ] Zaznamenávat jednotlivé obchodní transakce v okamžiku jejich vzniku
- [ ] Řídit výrobní linky a sbírat provozní data přímo ze strojů
- [x] Podporovat strategické plánování a sledování výkonnosti
- [ ] Zajišťovat oběh dokumentů a schvalování přijatých faktur

> SEM slouží vrcholovému vedení a controllingu k podpoře cyklu strategického řízení — plánování, simulacím a sledování plnění cílů. Záznam transakcí je úlohou ERP, řízení strojů výrobních systémů.

### ? Pro kterou z uvedených úloh je vhodná aplikace typu SEM?

- [ ] Zaúčtování přijaté faktury od dodavatele
- [x] Čtvrtletní vyhodnocení plnění strategických cílů divizí
- [ ] Vystavení objednávky na materiál
- [ ] Evidence docházky zaměstnanců ve směnném provozu

> Vyhodnocení plnění strategických cílů je typická manažerská úloha SEM. Ostatní možnosti jsou operativní transakce, které patří do transakčních systémů.

## Corporate / Enterprise Performance Management (CPM, EPM) {#cpm-epm .term}

**Corporate Performance Management (CPM)**, též **Enterprise Performance Management (EPM)** nebo Business Performance Management, je souhrnné označení pro **metodiky, ukazatele, procesy a informační systémy**, jimiž firma plánuje, sleduje a řídí svou výkonnost. Zahrnuje zejména plánování a rozpočtování, prognózy, konsolidaci, scorecardy a reporting výkonnosti. Koncept SEM se s CPM/EPM do značné míry překrývá; CPM/EPM je dnes na trhu běžnější označení této oblasti.

### ? Firma hledá software pro plánování, rozpočtování, konsolidaci a scorecardy. Pod jakým označením tuto kategorii aplikací na trhu nejspíše najde?

- [ ] CRM (Customer Relationship Management)
- [ ] MES (Manufacturing Execution System)
- [ ] ECM (Enterprise Content Management) systém
- [x] EPM (Enterprise Performance Management)

> Plánování, rozpočtování, konsolidace a scorecardy jsou jádrem aplikací CPM/EPM. CRM řídí vztahy se zákazníky, MES výrobu a ECM podnikový obsah a dokumenty.

### ? Která oblast NEPATŘÍ do řešení typu CPM/EPM?

- [ ] Konsolidace výsledků skupiny
- [x] Zpracování mezd a výplatních pásek
- [ ] Plánování, rozpočtování a průběžné prognózy
- [ ] Scorecardy s ukazateli výkonnosti

> Zpracování mezd je operativní personální agenda, kterou zajišťuje transakční (mzdový) systém. CPM/EPM se zabývá řízením výkonnosti — plány, konsolidací a ukazateli.

## Cyklus strategického řízení jako uzavřená smyčka {#uzavrena-smycka .explain}

Strategické řízení probíhá v opakujícím se cyklu: **formulace strategie a cílů → plánování a alokace zdrojů → realizace → měření a monitorování → analýza odchylek → korekce** strategie či plánů. Aplikace SEM má tento cyklus podporovat jako **uzavřenou smyčku** (closed loop): strategické cíle, plány, skutečnost i výsledky analýz leží v jedné konzistentní datové základně, takže zjištění z monitorování se přímo promítají do další iterace plánu. Bez takové podpory bývá strategie oddělena od rozpočtu a vyhodnocení probíhá v nesourodých tabulkách, které si každý útvar vede po svém.

*Příklad:* Vedení při čtvrtletním vyhodnocení zjistí, že nový segment zaostává za plánem, v téže aplikaci přesune část marketingového rozpočtu a upraví cíle na další čtvrtletí.

### ? Vedení zjistí, že tržby nového segmentu zaostávají o 20 % za plánem, a ve stejné aplikaci, kde sleduje skutečnost, rovnou upraví plán na další čtvrtletí. Jaký princip podpory strategického řízení se tím uplatňuje?

- [ ] Transakční zpracování (OLTP)
- [ ] Konsolidace účetních závěrek
- [x] Uzavřená smyčka řízení (closed loop)
- [ ] Bottom-up sběr rozpočtů

> Uzavřená smyčka znamená, že výsledky měření a analýzy odchylek se přímo vracejí do plánování v jedné konzistentní datové základně. Ostatní pojmy popisují jiné úlohy.

## Požadovaná funkcionalita aplikací SEM {#funkcionalita-sem .explain}

Od aplikace SEM se typicky požaduje:

- **strategické plánování, rozpočtování a prognózy** navázané na strategické cíle,
- **simulace a modelování** (analýzy „co když", scénáře),
- **konsolidace** výsledků skupiny (finanční i manažerská),
- **scorecardy** a strategické mapy (Balanced Scorecard), sledování klíčových ukazatelů (KPI),
- **řízení vztahů se stakeholdery** (zjišťování jejich očekávání, komunikace výsledků),
- **sběr a analýza informací** — interních i externích, strukturovaných i nestrukturovaných,
- **reporting a multidimenzionální analýzy** pro manažery.

*Příklad:* Holding požaduje jeden nástroj, v němž dceřiné firmy zadají plán, centrála jej zkonsoliduje, nasimuluje dopad změny kurzu a výsledky sleduje ve scorecardu.

### ? Která z uvedených funkcí NEPATŘÍ mezi typickou funkcionalitu aplikací SEM?

- [x] Evidence skladových pohybů materiálu
- [ ] Konsolidace výsledků dceřiných společností
- [ ] Simulace scénářů vývoje tržeb
- [ ] Scorecard s klíčovými ukazateli výkonnosti

> Evidence skladových pohybů je transakční úloha ERP. Konsolidace, simulace a scorecardy patří ke standardní funkcionalitě SEM.

### ? Controlling chce zjistit, co se stane se ziskem, když firma zdraží o 5 % a prodej přitom klesne o 3 %. Kterou funkci SEM využije?

- [ ] Konsolidaci
- [ ] Sběr externích informací
- [ ] Řízení vztahů se stakeholdery
- [x] Simulaci a modelování

> Otázka „co když" (what-if) je typickou úlohou simulace a modelování: změní se vstupní předpoklady a model dopočítá dopad na zisk.

## Komponenty SAP SEM jako příklad {#sap-sem .compare}

Typickým příkladem aplikace SEM byl produkt **SAP SEM** (Strategic Enterprise Management), postavený nad datovým skladem SAP BW. Jeho komponenty odpovídají požadované funkcionalitě SEM; dnes SAP tuto oblast pokrývá novějšími produkty.

| Komponenta | Účel |
|---|---|
| **BPS** — Business Planning and Simulation | plánování, rozpočtování, simulace |
| **BCS** — Business Consolidation | konsolidace skupiny |
| **CPM** — Corporate Performance Monitor (pozor: jiný význam než obecný pojem CPM = Corporate Performance Management) | scorecardy (BSC), strategické mapy, sledování KPI |
| **SRM** — Stakeholder Relationship Management | komunikace a vztahy se stakeholdery |
| **BIC** — Business Information Collection | sběr interních i externích informací |

### ? Která komponenta SAP SEM sloužila primárně plánování a simulacím?

- [x] BPS (Business Planning and Simulation)
- [ ] BCS (Business Consolidation)
- [ ] SRM (Stakeholder Relationship Management)
- [ ] BIC (Business Information Collection)

> Plánování a simulace pokrývala komponenta BPS. BCS sloužila konsolidaci, SRM vztahům se stakeholdery a BIC sběru informací.

## Integrované strategické plánování a rozpočtování {#integrovane-planovani .explain}

Strategický plán (obvykle na několik let) stanoví cíle a směr; z něj se odvozují **roční operativní plány a rozpočty** útvarů a průběžné **prognózy** (forecast). Aplikace SEM má tyto úrovně **propojit**, aby alokace zdrojů v rozpočtu odpovídala strategickým cílům a aby šlo sledovat, jak plnění rozpočtu přispívá ke strategii. Podporuje přitom **verze plánu** (návrh, schválený plán, prognóza), **schvalovací proces** (workflow) a často **klouzavý výhled** (rolling forecast), který se pravidelně posouvá o další období dopředu.

*Příklad:* Strategický cíl „zvýšit podíl online prodeje" se v ročním rozpočtu projeví navýšením nákladů na e-shop a ve čtvrtletní prognóze tržeb online kanálu.

### ? Firma místo jednoho pevného ročního rozpočtu každé čtvrtletí aktualizuje výhled vždy na následujících 12 měsíců. Jak se tento přístup nazývá?

- [x] Klouzavý výhled (rolling forecast)
- [ ] Konsolidace plánu
- [ ] Bottom-up rozpočtování útvarů a divizí
- [ ] Rozpočtování od nulového základu (zero-based budgeting)

> Klouzavý výhled se pravidelně posouvá o další období, takže firma má stále před sebou plán na stejně dlouhý horizont. Rozpočtování od nulového základu naopak znamená sestavovat rozpočet bez ohledu na minulost.

### ? Proč je důležité propojit strategický plán s ročním rozpočtem v jedné aplikaci?

- [ ] Aby rozpočet nebylo nutné schvalovat
- [ ] Aby odpadla potřeba sledovat skutečnost
- [ ] Aby strategii mohli měnit pouze controlleři
- [x] Aby alokace zdrojů odpovídala strategickým cílům

> Propojení zajišťuje, že peníze a kapacity v rozpočtu míří tam, kam ukazuje strategie, a že lze sledovat přínos plnění rozpočtu ke strategickým cílům.

## Top-down × bottom-up plánování {#top-down-bottom-up .compare}

Plánovací aplikace podporují oba směry sestavení plánu; v praxi se obvykle kombinují v několika iteracích (vedení zadá cílové hodnoty, útvary je zpřesní a vrátí ke schválení).

| | Top-down (shora dolů) | Bottom-up (zdola nahoru) |
|---|---|---|
| Postup | vedení stanoví cílové hodnoty, ty se rozpadají na nižší úrovně | útvary sestaví vlastní plány, ty se sčítají na vyšší úrovně |
| Výhoda | soulad se strategií, rychlost | realističnost, znalost útvarů, motivace |
| Nevýhoda | riziko nerealistických cílů, slabá identifikace útvarů | riziko nesouladu se strategií a nadsazených rezerv |
| Podpora v aplikaci | rozpad (distribuce) podle klíčů, např. loňských podílů | sběr dat a agregace podle hierarchie |

### ? Vedení stanoví plán tržeb skupiny 50 mil. Kč a rozpadne ho na tři regiony podle jejich podílu na loňských tržbách: A 40 %, B 35 %, C 25 %. Jaký plán tržeb dostane region B?

- [ ] 15,0 mil. Kč
- [ ] 12,5 mil. Kč
- [x] 17,5 mil. Kč
- [ ] 20,0 mil. Kč

> Rozpad shora dolů podle klíče: `50 × 0,35 = 17,5 mil. Kč`. Region A dostane 20 mil. Kč a region C 12,5 mil. Kč.

### ? Útvary samy sestaví své rozpočty a aplikace je sečte podle organizační hierarchie až na úroveň celé firmy. O jaký přístup jde?

- [ ] Top-down plánování
- [x] Bottom-up plánování
- [ ] Klouzavý výhled
- [ ] Konsolidace účetních výkazů skupiny

> Plány vznikají na nejnižší úrovni a agregují se nahoru, jde tedy o bottom-up. Konsolidace se týká slučování výsledků samostatných společností skupiny.

## Simulace a modelování {#simulace-modelovani .explain}

Simulace v SEM pracuje s **modelem podniku**, v němž jsou výsledné ukazatele (tržby, zisk, cash flow) vyjádřeny pomocí **hnacích faktorů** (value drivers) — objemu prodeje, ceny, kurzu, mzdových sazeb apod. Uživatel mění předpoklady a model dopočítá dopady (**analýza „co když"**, what-if), případně porovná několik **scénářů** (optimistický, realistický, pesimistický) nebo zjistí citlivost výsledku na jednotlivé faktory. Výsledky simulací se ukládají do **samostatných verzí**, aby nepřepsaly schválený plán a daly se navzájem porovnat.

*Příklad:* Výrobce modeluje, jak by zisk ovlivnilo posílení koruny o 1 Kč/EUR při stejném objemu exportu.

### ? Firma prodává 10 000 ks výrobku za 200 Kč. Simulace předpokládá zvýšení ceny o 5 % a pokles prodaného objemu o 10 %. Jaké budou tržby podle simulace?

- [x] 1 890 000 Kč
- [ ] 1 900 000 Kč
- [ ] 1 800 000 Kč
- [ ] 2 100 000 Kč

> Nová cena `200 × 1,05 = 210 Kč`, nový objem `10 000 × 0,9 = 9 000 ks`, tržby `9 000 × 210 = 1 890 000 Kč`. Pouhé odečtení procent (−5 %) dává chybně 1 900 000 Kč.

### ? Proč se výsledky simulačních scénářů v aplikaci SEM ukládají do samostatných verzí plánu?

- [ ] Aby je nebylo možné porovnat se skutečností
- [ ] Protože simulace nepracuje s dimenzemi
- [x] Aby nepřepsaly schválený plán
- [ ] Protože scénáře smí vidět pouze auditor

> Verze oddělují schválený plán od pracovních scénářů; díky tomu lze scénáře porovnávat mezi sebou i se skutečností, aniž by se poškodil platný plán.

## Konsolidace {#konsolidace .term}

**Konsolidace** je sloučení finančních (případně manažerských) výkazů jednotek **skupiny podniků** do jednoho celku, jako by šlo o jediný podnik. Kromě sečtení je nutné **eliminovat vnitroskupinové vztahy** — vzájemné pohledávky a závazky, výnosy a náklady z obchodů mezi členy skupiny a vzájemné kapitálové účasti; často je potřeba i **přepočet měn**. Aplikace SEM/CPM podporují **zákonnou (statutární)** konsolidaci i **manažerskou** konsolidaci podle vlastní řídicí struktury (divize, segmenty).

### ? Mateřská firma má tržby 100 mil. Kč, dceřiná firma 40 mil. Kč; z tržeb dceřiné firmy tvoří 10 mil. Kč prodeje mateřské firmě. Jaké jsou konsolidované tržby skupiny (jiné vnitroskupinové obchody nejsou)?

- [ ] 140 mil. Kč
- [ ] 120 mil. Kč
- [ ] 110 mil. Kč
- [x] 130 mil. Kč

> Sečtou se tržby obou firem a eliminuje se vnitroskupinový prodej: `100 + 40 − 10 = 130 mil. Kč`. Prodej mateřské firmě není z pohledu skupiny prodejem navenek.

### ? Proč při konsolidaci nestačí výsledky společností skupiny jen sečíst?

- [x] Vnitroskupinové obchody by výsledky skupiny nadhodnotily
- [ ] Dceřiné společnosti nevedou vlastní účetnictví
- [ ] Konsolidace pracuje jen s nefinančními ukazateli
- [ ] Sčítání tržeb vykázaných v různých měnách není technicky možné

> Obchody mezi členy skupiny by se při prostém součtu promítly do tržeb, nákladů i pohledávek, přestože skupina jako celek nic navenek neprodala. Proto se eliminují.

## Scorecardy a strategické mapy v aplikaci {#scorecard-aplikace .explain}

Metoda **Balanced Scorecard** (Kaplan a Norton; výklad metody viz téma 3) se v SEM/CPM implementuje jako aplikace. **Strategická mapa** zobrazuje strategické cíle ve čtyřech perspektivách (finanční, zákaznická, interních procesů, učení a růstu) a **příčinně-následné vazby** mezi nimi. Ke každému cíli patří **KPI** s cílovou hodnotou, skutečností, prahovými hodnotami a **vlastníkem**, případně navázané **strategické iniciativy** (projekty). Stav se zobrazuje symbolem a barvou a hodnoty se plní **automaticky z datového skladu**, takže vedení vidí aktuální stav bez ručního sběru.

*Příklad:* Ukazatel „podíl reklamací" je pod prahem (symbol ✗ a červená); manažer z něj přejde k detailu po produktových řadách a vidí, které iniciativě zlepšení kvality je přiřazen.

### ? Co v aplikaci typu scorecard znázorňuje strategická mapa?

- [ ] Geografické rozmístění poboček firmy
- [ ] Rozpad rozpočtu na nákladová střediska
- [ ] Organizační schéma vrcholového vedení
- [x] Příčinně-následné vazby mezi strategickými cíli

> Strategická mapa ukazuje, jak cíle v perspektivě učení a růstu a interních procesů podporují cíle zákaznické a ty finanční.

### ? Firma chce, aby se hodnoty KPI ve scorecardu neplnily ručním přepisováním tabulek. Jaké řešení je pro aplikace SEM typické?

- [ ] Měsíční zasílání tabulek controllerovi e-mailem
- [x] Automatické plnění KPI z datového skladu
- [ ] Ruční zadávání hodnot vedoucími útvarů
- [ ] Výpočet KPI při každé transakci přímo v ERP

> Aplikace SEM čerpají ukazatele z datového skladu, kam se data pravidelně a řízeně načítají z transakčních systémů. Ruční sběr je pomalý a chybový, výpočty v ERP zatěžují provoz.

## Řízení vztahů se stakeholdery {#stakeholderi .explain}

Strategie musí brát v úvahu očekávání **zainteresovaných stran** (stakeholderů) — akcionářů a investorů, bank, zaměstnanců, zákazníků, dodavatelů, regulátorů i veřejnosti. Funkce řízení vztahů se stakeholdery v SEM pomáhá jejich očekávání **systematicky zjišťovat a evidovat** a promítat je do strategických cílů, a naopak jim **cíleně komunikovat** informace o strategii a plnění cílů (např. vztahy s investory, výroční zprávy, nefinanční reporting). Zpětná vazba od stakeholderů se pak stává dalším vstupem do cyklu strategického řízení.

*Příklad:* Banka financující investici vyžaduje čtvrtletní přehled vybraných finančních ukazatelů; firma jej generuje ze stejných dat, z nichž vychází interní scorecard.

### ? Firma chce systematicky evidovat očekávání akcionářů a bank a pravidelně jim předávat informace o plnění strategických cílů. Kterou funkci SEM využije?

- [ ] Konsolidaci výsledků
- [ ] Simulaci a modelování
- [x] Řízení vztahů se stakeholdery
- [ ] Bottom-up rozpočtování útvarů a divizí

> Zjišťování očekávání zainteresovaných stran a komunikace výsledků směrem k nim je náplní řízení vztahů se stakeholdery.

## Sběr a analýza informací {#sber-informaci .term}

Funkce SEM, která kromě interních dat z transakčních systémů shromažďuje i **externí** a často **nestrukturované** informace — o trhu, konkurenci, zákaznících, ekonomickém a legislativním vývoji (zprávy, studie, internetové zdroje). Informace se třídí, opatřují popisnými údaji (metadaty) a přiřazují ke strategickým cílům či ukazatelům, aby byly vedení k dispozici v kontextu rozhodování.

### ? Které informace pro strategické řízení obvykle NELZE získat z podnikového ERP, a proto je SEM shromažďuje samostatně?

- [ ] Náklady jednotlivých nákladových středisek
- [x] Údaje o konkurenci a vývoji trhu
- [ ] Stav zásob na skladech
- [ ] Hodnotu vystavených faktur

> ERP eviduje vnitřní transakce firmy. Informace o konkurenci a trhu jsou externí, často nestrukturované a je třeba je sbírat z jiných zdrojů.

## Transakční (OLTP) × analytické aplikace {#oltp-vs-analyticke .compare}

Aplikace SEM patří mezi analytické (manažerské) aplikace; od transakčních se liší účelem i charakterem práce s daty.

| | Transakční (OLTP) | Analytické (BI, OLAP, SEM) |
|---|---|---|
| Účel | zpracování každodenních operací | podpora rozhodování, analýzy, plánování |
| Uživatelé | operativní pracovníci, mnoho souběžných | manažeři, analytici, controlling |
| Operace | časté krátké zápisy a změny záznamů | čtení a agregace velkých objemů dat; zápis jen u plánů |
| Data | aktuální, detailní, z jednoho systému | historická, detailní i agregovaná, integrovaná z více zdrojů |
| Datový model | normalizovaný relační | dimenzionální (kostka, hvězda) |
| Příklad | ERP — objednávky, fakturace | datový sklad, plánovací a reportingové aplikace |

### ? Která úloha patří typicky do transakčních (OLTP) aplikací?

- [ ] Porovnání tržeb za pět let podle regionů
- [ ] Simulace dopadu změny cen na zisk
- [ ] Sledování KPI ve strategické mapě
- [x] Zápis nové objednávky zákazníka

> Zápis objednávky je krátká operace se záznamem jedné transakce — typická úloha OLTP. Ostatní úlohy pracují s historickými a agregovanými daty a patří do analytických aplikací.

### ? Proč se náročné manažerské analýzy obvykle nespouštějí přímo nad provozní databází ERP?

- [x] Zatěžovaly by provoz a chybí integrovaná historie z více zdrojů
- [ ] Databáze ERP ukládá data jen v agregované podobě
- [ ] Analytické dotazy vyžadují normalizovaný datový model
- [ ] Provozní databáze neumožňuje čtení více uživatelům

> Rozsáhlé agregační dotazy by zpomalovaly zpracování transakcí a provozní databáze navíc neobsahuje integrovaná historická data z dalších zdrojů. Proto se analýzy provádějí nad datovým skladem.

## Multidimenzionální analýza {#multidimenzionalni-analyza .explain}

Manažerské aplikace zobrazují data jako **multidimenzionální kostku**: **ukazatele** (měřítka — tržby, náklady, marže) se analyzují podle **dimenzí** (čas, produkt, region, zákazník, organizační jednotka). Dimenze mají **hierarchie** (den → měsíc → čtvrtletí → rok; produkt → skupina → kategorie), po nichž se manažer může pohybovat od souhrnu k detailu a zpět. Tento princip se označuje jako OLAP (podrobně téma 10). V SEM je důležitá dimenze **verze** (plán, skutečnost, prognóza, scénáře), díky níž lze v jedné kostce porovnávat plán se skutečností.

*Příklad:* Obchodní ředitel vidí odchylku tržeb za čtvrtletí, rozloží ji podle regionů a zjistí, že ji způsobil jediný region a jedna produktová skupina.

### ? Analytik sleduje tržby podle produktu, regionu a měsíce. Čím jsou v multidimenzionálním pohledu „tržby"?

- [ ] Dimenzí
- [x] Ukazatelem (měřítkem)
- [ ] Hierarchií v dimenzi čas
- [ ] Verzí plánu

> Tržby jsou číselný ukazatel, který se analyzuje; produkt, region a měsíc jsou dimenze, podle nichž se ukazatel člení.

### ? Která dimenze umožní v aplikaci SEM porovnat plán a skutečnost v rámci jedné kostky?

- [ ] Čas
- [ ] Organizační jednotka
- [x] Verze (scénář)
- [ ] Produkt

> Dimenze verze rozlišuje plán, skutečnost, prognózu či scénáře nad stejnými ukazateli a ostatními dimenzemi, takže je lze přímo porovnat.

## Multidimenzionální plánování {#multidimenzionalni-planovani .explain}

Plánovací úlohy v SEM pracují **ve stejných dimenzích a hierarchiích jako skutečnost**, takže plán a skutečnost lze přímo porovnávat. Uživatelé zadávají hodnoty na zvolené **granularitě** (např. měsíc × produktová skupina × region) a aplikace je ukládá zpět do multidimenzionální databáze (**zpětný zápis**, write-back). Plánovací funkce zahrnují **rozpad** hodnot shora dolů podle klíčů, **agregaci** zdola nahoru, kopírování a přecenění verzí, plánovací vzorce založené na hnacích faktorech a **stav a schvalování** jednotlivých částí plánu.

*Příklad:* Regionální manažeři zadají plán prodeje v kusech, aplikace jej ocení plánovanými cenami a výsledek se automaticky promítne do plánu tržeb firmy.

### ? Proč je výhodné plánovat ve stejných dimenzích a hierarchiích, v jakých se sleduje skutečnost?

- [ ] Plán pak není nutné schvalovat
- [ ] Plán lze zadávat jen na nejvyšší úrovni
- [ ] Odpadá potřeba datového skladu
- [x] Plán a skutečnost lze přímo porovnat

> Shodná struktura plánu a skutečnosti umožňuje bez převodů počítat odchylky na kterékoli úrovni hierarchie a uzavřít tak smyčku řízení.

### ? Jak se nazývá schopnost plánovací aplikace ukládat hodnoty zadané uživatelem zpět do multidimenzionální databáze?

- [x] Zpětný zápis (write-back)
- [ ] Drill-down (přechod k detailu)
- [ ] ETL
- [ ] Konsolidace

> Zpětný zápis umožňuje do kostky nejen číst, ale i zapisovat plánované hodnoty. Drill-down je přechod k detailu, ETL plní datový sklad ze zdrojových systémů.

## Návrh a specifikace aplikace SEM {#specifikace-sem .explain}

SEM (Strategic Enterprise Management) je třída aplikací pro podporu strategického řízení; jejím etalonem je **SAP SEM** s komponentami BPS, BIC, BCS, CPM a SRM. Obsahově dnes SEM splývá s aplikacemi **CPM/EPM**, takže specifikace se v praxi týká i řešení s tímto označením.

Specifikace aplikace SEM vychází z **potřeb řízení**, nikoli z dat, která jsou zrovna k dispozici. Typicky zahrnuje:

1. analýzu **procesů strategického řízení** a rozhodovacích rolí (kdo rozhoduje, o čem a jak často),
2. **strategické cíle a ukazatele** (např. z Balanced Scorecard) včetně cílových hodnot a vlastníků,
3. **dimenze, hierarchie a granularitu** analýz a plánů,
4. **zdroje dat** (interní i externí), jejich kvalitu a frekvenci aktualizace,
5. **plánovací procesy** — verze, plánovací kalendář, schvalování,
6. **uživatele, přístupová práva a výstupy** (reporty, scorecardy),
7. **volbu řešení** (standardní produkt × vlastní vývoj) a integraci s ERP a datovým skladem.

*Příklad:* Před výběrem produktu vedení definuje deset strategických KPI, jejich zdroje a měsíční periodicitu; teprve podle toho se posuzuje, který nástroj požadavky splní.

### ? Firma zahajuje projekt aplikace SEM. Čím by měla specifikace začít?

- [ ] Výběrem databázového serveru
- [x] Analýzou informačních potřeb řízení
- [ ] Převzetím všech tabulek z ERP
- [ ] Návrhem grafiky dashboardů

> Aplikace má sloužit rozhodování vedení, proto specifikace začíná analýzou procesů strategického řízení a z nich plynoucích informačních potřeb. Technologie a vzhled výstupů se volí až podle nich.

### ? Při specifikaci plánovací aplikace se stanoví, že plán tržeb se bude zadávat po měsících a produktových skupinách, nikoli po jednotlivých výrobcích a dnech. Co se tím definuje?

- [ ] Přístupová práva uživatelů
- [ ] Zdroj externích dat
- [x] Granularita plánu
- [ ] Schvalovací workflow

> Granularita určuje nejnižší úroveň detailu, na které se data plánují nebo ukládají — zde měsíc × produktová skupina.
