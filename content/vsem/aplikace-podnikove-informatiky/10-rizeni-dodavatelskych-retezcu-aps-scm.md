---
kind: topic
subject: aplikace-podnikove-informatiky
slug: rizeni-dodavatelskych-retezcu-aps-scm
name: "Řízení dodavatelských řetězců (APS/SCM)"
order: 10
---

principy a funkcionalita aplikací APS/SCM, efekty aplikací APS/SCM.

## Dodavatelský řetězec a SCM {#scm .term}

**Dodavatelský řetězec** (supply chain) je síť organizací a činností od získání surovin přes výrobce, distributory a obchodníky až ke konečnému zákazníkovi; procházejí jím **toky materiálu, informací a peněz**. **Řízení dodavatelského řetězce** (Supply Chain Management, SCM) tyto toky koordinuje a integruje napříč firmami tak, aby **řetězec jako celek** dosáhl požadované úrovně obsluhy konečného zákazníka při nejnižších celkových nákladech a zásobách. Aplikace SCM tuto koordinaci podporují sdílením informací a společným plánováním.

### ? Které toky procházejí dodavatelským řetězcem?

- [x] Toky materiálu, informací a peněz
- [ ] Jen toky materiálu a hotových výrobků
- [ ] Jen toky informací mezi obchodníky
- [ ] Toky materiálu a pracovníků mezi závody

> Dodavatelským řetězcem proudí materiál (po proudu k zákazníkovi), informace (oběma směry) a peníze (od zákazníka k dodavatelům). SCM koordinuje všechny tři toky.

### ? Tři navazující firmy v řetězci každá samostatně minimalizují své zásoby, přesto konečný zákazník čeká na zboží a celkové náklady rostou. Co je v rozporu s principem SCM?

- [ ] Sdílení prognóz mezi články řetězce
- [ ] Dlouhodobé partnerství s dodavateli
- [x] Optimalizace každého článku zvlášť
- [ ] Společné plánování doplňování zásob

> SCM optimalizuje řetězec jako celek; součet lokálních optim jednotlivých firem zpravidla nedává optimum celého řetězce. Ostatní možnosti jsou naopak typické nástroje SCM.

## Plánovací a realizační aplikace SCM {#scp-vs-sce .compare}

Aplikace pro řízení dodavatelského řetězce se obvykle dělí na dvě skupiny; obě čerpají kmenová a transakční data z ERP a vracejí do něj výsledky.

| | Plánování (Supply Chain Planning, SCP) | Realizace (Supply Chain Execution, SCE) |
|---|---|---|
| Řeší | co, kolik, kdy a kde vyrobit, nakoupit a dodat | jak plán fyzicky provést a sledovat |
| Horizont | hodiny až roky | minuty až dny |
| Typické aplikace | APS — plánování poptávky, sítě, výroby, distribuce a dopravy | WMS (řízení skladu), TMS (řízení dopravy), sledování zásilek |
| Výstup | plány, rozvrhy, přislíbené termíny | provedené operace, aktuální stav toků |

### ? Firma potřebuje aplikaci, která řídí naskladnění, umístění zboží v regálech a vychystávání objednávek. O jaký typ SCM aplikace jde?

- [ ] Plánovací aplikace pro prognózu poptávky
- [x] Realizační aplikace — řízení skladu (WMS)
- [ ] Plánovací aplikace pro návrh distribuční sítě
- [ ] Plánovací aplikace pro rozvrhování výroby

> Naskladnění a vychystávání jsou fyzické operace, které řídí realizační (SCE) aplikace typu WMS. Plánovací aplikace (APS) určují, co a kdy se má udělat, samy ale operace neprovádějí.

### ? Který úkol je typický pro plánovací (SCP) aplikaci?

- [ ] Potvrdit příjem palet na rampě skladu
- [ ] Zaznamenat vychystání konkrétní objednávky
- [ ] Sledovat polohu kamionu během cesty
- [x] Určit, kolik a kde vyrábět příští čtvrtletí

> Plánovací aplikace rozhodují o objemech, místech a termínech do budoucna. Příjem, vychystání a sledování zásilek jsou úlohy realizačních (SCE) aplikací.

## APS (Advanced Planning and Scheduling) {#aps .term}

APS (Advanced Planning and Scheduling, pokročilé plánování a rozvrhování) jsou aplikace, které plánují výrobu a dodávky **s respektováním omezených kapacit** a dalších omezení (materiál, pracovníci, nástroje, doprava) a hledají **optimální, nebo alespoň proveditelný plán** pomocí optimalizačních algoritmů a heuristik. Materiál a kapacity plánují **současně**, umožňují **simulaci** variant („co když") a rychlé přeplánování. Obvykle doplňují ERP, z něhož čerpají data.

### ? Co nejlépe vystihuje aplikace APS?

- [ ] Evidují doklady o nákupu a prodeji zboží
- [ ] Plánují materiál bez ohledu na kapacity
- [x] Plánují s ohledem na omezené kapacity
- [ ] Řídí fyzické vychystávání zboží ve skladu

> APS hledají proveditelný a co nejlepší plán, který respektuje omezené kapacity a další omezení. Plánování materiálu bez ohledu na kapacity je typické pro MRP, evidence dokladů pro ERP a vychystávání pro WMS.

### ? Plánovač chce před přijetím velké zakázky zjistit, jak by její zařazení posunulo termíny ostatních zakázek. Kterou schopnost APS využije?

- [ ] Elektronickou výměnu dat (EDI)
- [ ] Výpočet čisté potřeby podle kusovníku
- [ ] Zásoby řízené dodavatelem (VMI)
- [x] Simulaci variant „co když"

> APS umožňují nasimulovat variantu plánu bez jejího uložení a porovnat dopady na termíny a kapacity. Výpočet čisté potřeby kapacitní dopady neukáže.

## APS × MRP / MRP II {#aps-vs-mrp .compare}

Tradiční plánování MRP/MRP II v ERP a plánování v APS se liší hlavně přístupem ke kapacitám.

| | MRP / MRP II | APS |
|---|---|---|
| Kapacity | **neomezená kapacita** — přetížení se zjistí až dodatečně a řeší ručně | **omezená (konečná) kapacita** respektovaná přímo v plánu |
| Postup | **postupný**: hlavní plán → potřeba materiálu → kontrola kapacit | **současné** plánování materiálu a kapacit |
| Průběžné doby | pevné, předem zadané | vyplývají z plánu (zatížení, fronty) |
| Metoda | deterministický výpočet | optimalizace, heuristiky, simulace |
| Rozsah | zpravidla jeden podnik či závod | i více závodů a celý řetězec |

### ? Výpočet MRP naplánoval lince na příští týden 600 hodin práce, ačkoli má kapacitu jen 400 hodin. Co je příčinou?

- [ ] Kusovník výrobku obsahuje chybné množství
- [x] MRP plánuje s neomezenou kapacitou
- [ ] Hlavní plán výroby nebyl vůbec zadán
- [ ] Linka nemá zadanou průběžnou dobu

> MRP počítá potřebu materiálu a termíny bez ohledu na dostupnou kapacitu; přetížení odhalí až následná kontrola kapacit a plánovač je řeší ručně. APS by plán rovnou přizpůsobil kapacitě linky.

### ? Čím se APS ZÁSADNĚ liší od MRP II?

- [ ] Odvozuje potřebu součástí z kusovníku
- [ ] Vychází z hlavního plánu výroby
- [ ] Pracuje s kmenovými daty z ERP
- [x] Plánuje materiál a kapacity současně

> Kusovník, hlavní plán výroby i kmenová data z ERP používají oba přístupy. Rozdíl je v tom, že APS plánuje materiál a kapacity současně, kdežto MRP II postupně s dodatečnou kontrolou kapacit.

## Principy řešení APS {#principy-aps .explain}

APS staví na několika principech:

- **Model omezení** — podnik a řetězec se popíší jako síť zdrojů s kapacitami, časy přestavby, kalendáři a vazbami mezi operacemi.
- **Optimalizace** — systém hledá plán, který nejlépe splní **cílovou funkci** (např. minimální náklady, dodržení termínů, využití úzkého místa); používá matematické programování a heuristiky.
- **Simulace** — porovnání variant „co když" bez zásahu do platného plánu.
- **Výpočet v operační paměti** — rychlé přeplánování při změně objednávky či výpadku stroje.
- **Řízení výjimkami** — systém upozorní plánovače na problémy (zpoždění, nedostatek), místo aby musel kontrolovat celý plán.

*Příklad:* Po poruše lisu APS během několika minut přepočítá rozvrh, přesune zakázky na náhradní stroj a upozorní plánovače jen na dvě zakázky, které nestihnou termín.

### ? Plánovací systém má zvolit plán s minimálními náklady, který přitom dodrží termíny i kapacity. Jaký princip APS to popisuje?

- [ ] Výpočet čisté potřeby podle kusovníku
- [ ] Ruční vyrovnání kapacit plánovačem
- [x] Optimalizaci cílové funkce s omezeními
- [ ] Plánování s pevnými průběžnými dobami

> Optimalizace hledá mezi proveditelnými plány ten, který nejlépe plní cílovou funkci (zde náklady) při respektování omezení (termíny, kapacity).

### ? Co znamená řízení výjimkami v aplikaci APS?

- [x] Plánovač dostane upozornění jen na problémy
- [ ] Plán se přepočítává jen jednou za měsíc
- [ ] Výjimečné zakázky se plánují mimo systém
- [ ] Systém ignoruje zakázky s nízkou prioritou

> Při řízení výjimkami systém sám kontroluje plán a upozorní plánovače na zpoždění či nedostatky, takže se nemusí probírat celým plánem.

## Vrstvy plánování v dodavatelském řetězci {#vrstvy-planovani .compare}

Plánovací úlohy se podle horizontu a míry detailu dělí do tří vrstev; vyšší vrstva vymezuje rámec pro nižší.

| | Strategické | Taktické | Operativní |
|---|---|---|---|
| Horizont | roky | měsíce až rok | dny až týdny (u rozvrhování hodiny) |
| Typické úlohy | návrh sítě — počet a umístění závodů a skladů, kapacity, výběr dodavatelů | plánování poptávky, hlavní (agregované) plánování sítě, rozdělení výroby mezi závody | rozvrhování výroby, plánování nákupu, distribuce a dopravy, ATP/CTP |
| Detail | agregovaný (skupiny výrobků, regiony) | střední | detailní (položky, stroje, vozidla) |

### ? Firma rozhoduje, zda postavit nové distribuční centrum v Polsku. Do které vrstvy plánování úloha patří?

- [ ] Operativní
- [ ] Taktické
- [x] Strategické
- [ ] Realizační (SCE)

> Rozhodnutí o počtu a umístění skladů a závodů je dlouhodobé a mění strukturu sítě — patří do strategického plánování.

### ? Plánovač určuje pořadí zakázek na lisu pro zítřejší směnu. Do které vrstvy plánování úloha patří?

- [ ] Strategické
- [x] Operativní
- [ ] Taktické
- [ ] Návrhu sítě

> Pořadí zakázek na konkrétním stroji v horizontu hodin je detailní rozvrhování — operativní plánování.

## Plánování poptávky (forecasting) {#planovani-poptavky .explain}

Plánování poptávky (demand planning) sestavuje **prognózu budoucího prodeje**, z níž vycházejí plány výroby, nákupu i distribuce. Aplikace počítá **statistickou prognózu** z historie prodejů (trend, sezónnost) a plánovači ji upravují o známé události — akce, uvedení nových výrobků, ztrátu zákazníka. Obchod, marketing a výroba se pak shodnou na jedné **konsenzuální prognóze**. Aplikace průběžně měří **přesnost prognózy** a umožňuje ji sdílet s partnery v řetězci.

*Příklad:* Výrobce zmrzlin vychází ze sezónní křivky minulých let, přidá plánovanou letní reklamní kampaň a prognózu v týdenním členění předá plánování výroby.

### ? Firma chce prognózu prodeje, která zohlední sezónnost z minulých let i plánovanou letní akci. Kterou funkci APS/SCM použije?

- [x] Plánování poptávky
- [ ] Detailní rozvrhování výroby
- [ ] Plánování dopravy a tras
- [ ] Kontrolu dostupnosti ATP

> Plánování poptávky kombinuje statistickou prognózu z historie (sezónnost, trend) s úpravami o známé budoucí události, jako jsou akce.

### ? Proč je přesnost prognózy poptávky pro plánování v APS klíčová?

- [x] Vycházejí z ní plány výroby, nákupu i distribuce
- [ ] Přímo nahrazuje přijaté objednávky zákazníků
- [ ] Bez ní nelze v ERP vystavit fakturu
- [ ] Určuje maximální kapacitu výrobních strojů

> Prognóza je vstupem pro navazující plány; chybná prognóza se promítne do nadbytečných zásob nebo nedostatku v celém řetězci.

## Plánování dodávek a sítě {#planovani-site .explain}

Plánování dodávek a sítě (supply network planning, též hlavní plánování — master planning) v **taktickém horizontu** vyrovnává prognózovanou poptávku s možnostmi celé sítě. Model obsahuje závody, sklady, dodavatele a přepravní trasy s jejich kapacitami a náklady. Výsledkem je rozhodnutí, **který závod vyrobí co a kolik**, jaké množství se přesune mezi lokalitami a co se nakoupí — v agregovaných jednotkách (týdny, skupiny výrobků). Odlišuje se od strategického **návrhu sítě**, který mění samotnou strukturu sítě (nové závody a sklady).

*Příklad:* Výrobce oken se závody v Česku a na Slovensku rozdělí plán na 3. čtvrtletí tak, aby nepřetížil český závod a zároveň minimalizoval náklady na dopravu do regionálních skladů.

### ? Výrobce se dvěma závody chce rozdělit objem výroby na příští čtvrtletí tak, aby respektoval kapacity závodů a minimalizoval náklady dopravy ke skladům. Kterou funkci použije?

- [ ] Detailní rozvrhování operací na strojích
- [x] Plánování dodávek a sítě
- [ ] Kontrolu dostupnosti ke slíbení (ATP)
- [ ] Prognózování poptávky z historie

> Rozdělení objemů mezi lokality s ohledem na kapacity a náklady dopravy v horizontu měsíců je úloha plánování dodávek a sítě (master planning).

## Výrobní plánování a rozvrhování {#rozvrhovani .explain}

**Výrobní plánování** určuje pro jednotlivé závody, které výrobky, v jakých dávkách a na kterých linkách se budou vyrábět v nejbližších týdnech. **Detailní rozvrhování** (scheduling) pak stanoví **pořadí a přesné časy operací** na konkrétních strojích a pracovištích v horizontu hodin až dnů. Respektuje kapacity, směny, dostupnost materiálu i nástrojů, **časy přestavby** (seřízení) a soustředí se na **úzké místo**. Výsledek se zobrazuje typicky v Ganttově diagramu, kde jej plánovač může ručně upravit.

*Příklad:* Lakovna seřadí zakázky od světlých barev k tmavým, aby zkrátila čištění linky mezi zakázkami a zvýšila její využití.

### ? Lakovna chce seřadit zakázky od světlých barev k tmavým, aby zkrátila čištění linky mezi nimi. Kterou funkci APS použije?

- [x] Detailní rozvrhování výroby
- [ ] Plánování poptávky zákazníků
- [ ] Distribuční plánování zásob
- [ ] Strategický návrh sítě

> Pořadí zakázek na lince s ohledem na časy přestavby určuje detailní rozvrhování (scheduling).

### ? Co je hlavním výstupem detailního rozvrhování výroby?

- [x] Pořadí a časy operací na jednotlivých strojích
- [ ] Prognóza prodeje výrobků na příští rok
- [ ] Rozhodnutí o umístění nového závodu
- [ ] Rozdělení zásob mezi regionální sklady

> Rozvrhování stanoví, kdy a v jakém pořadí proběhnou operace na konkrétních pracovištích. Prognóza, návrh sítě a rozdělení zásob jsou jiné plánovací úlohy.

## Distribuční plánování a plánování dopravy {#distribuce-doprava .explain}

**Distribuční plánování** určuje, kdy a kolik zboží doplnit do jednotlivých skladů a distribučních center, aby pokryly poptávku svých regionů. Při nedostatku rozhoduje, **jak rozdělit dostupnou zásobu** mezi sklady či zákazníky (deployment). **Plánování dopravy** pak sestavuje z jednotlivých zásilek **náklady vozidel**, volí **trasy**, dopravce a termíny tak, aby vozidla byla dobře vytížena a doprava co nejlevnější. Naplánované přepravy pak provádí a sleduje realizační systém řízení dopravy (TMS).

*Příklad:* Velkoobchod s nápoji spojí zásilky pro pět sousedních prodejen do jednoho kamionu a naplánuje trasu tak, aby nejvzdálenější prodejna dostala zboží jako první.

### ? Distributor chce spojit menší zásilky pro sousední prodejny do jednoho kamionu a naplánovat jeho trasu. Kterou funkci použije?

- [ ] Plánování poptávky
- [ ] Rozvrhování výroby
- [ ] Distribuční plánování zásob
- [x] Plánování dopravy

> Sestavení nákladů vozidel a volba tras je úloha plánování dopravy. Distribuční plánování určuje, kolik zboží má do kterého skladu dorazit, ne jak ho naložit a odvézt.

### ? Při nedostatku zboží je třeba rozhodnout, kolik z dostupné zásoby dostane které regionální skladiště. Kterou funkci firma použije?

- [ ] Plánování dopravy
- [x] Distribuční plánování
- [ ] Detailní rozvrhování
- [ ] Návrh distribuční sítě

> Rozdělení dostupné zásoby mezi sklady (deployment) je součástí distribučního plánování. Návrh sítě by měnil počet a umístění skladů.

## ATP × CTP — slibování termínů {#atp-ctp .compare}

Funkce slibování termínů (order promising) odpovídají už při přijetí objednávky, **kdy a kolik lze zákazníkovi dodat**.

| | ATP (Available to Promise) | CTP (Capable to Promise) |
|---|---|---|
| Česky | dostupné ke slíbení | schopné ke slíbení (s výrobou) |
| Co ověřuje | volnou zásobu a plánované příjmy, které dosud nejsou přislíbeny jiným objednávkám | navíc, zda lze chybějící množství vyrobit či obstarat s ohledem na kapacity a materiál |
| Výsledek | termín z existující či plánované zásoby | termín včetně nové výroby, kterou případně rovnou zaplánuje |
| Typické užití | výroba na sklad | výroba na zakázku, kapacitně omezená výroba |

### ? Obchodník zjišťuje, zda lze 500 ks dodat do pátku. Volných je 200 ks a zbytek by se musel vyrobit na vytížené lince. Která kontrola zohlední i kapacitu linky?

- [ ] ATP — dostupné ke slíbení
- [ ] MRP — výpočet čisté potřeby
- [x] CTP — schopné ke slíbení
- [ ] VMI — zásoby řízené dodavatelem

> CTP ověřuje kromě zásob i to, zda lze chybějící množství vyrobit s ohledem na kapacity a materiál. ATP pracuje jen s existující a již plánovanou zásobou.

### ? Co ověřuje kontrola ATP (Available to Promise)?

- [ ] Volnou kapacitu strojů pro novou výrobu
- [ ] Platební schopnost zákazníka
- [ ] Dostupnost dopravce v den dodání
- [x] Zásobu a příjmy dosud nepřislíbené jiným

> ATP porovnává volnou zásobu a plánované příjmy s již přislíbenými objednávkami a zjistí, co lze ještě slíbit. Kapacitu pro novou výrobu zohledňuje až CTP.

## Spolupráce v řetězci: VMI a CPFR {#vmi-cpfr .explain}

Aplikace SCM umožňují partnerům **sdílet data** — prodeje konečným zákazníkům (údaje z pokladen, POS), stavy zásob, prognózy a plány — přes portály nebo EDI. Na sdílení stojí dvě formy spolupráce: při **VMI** (Vendor Managed Inventory, zásoby řízené dodavatelem) dodavatel sleduje zásoby a prodeje u odběratele a **sám rozhoduje o termínu a velikosti doplnění** v dohodnutých mezích (minimum–maximum). Při **CPFR** (Collaborative Planning, Forecasting and Replenishment) partneři **společně** plánují, sestavují prognózu a doplňování a řeší rozdíly mezi svými čísly.

*Příklad:* Výrobce drogerie denně dostává z obchodního řetězce stavy zásob v jeho distribučních centrech a sám plánuje jejich závozy; řetězec už objednávky nevystavuje.

### ? Dodavatel denně dostává údaje o zásobách a prodejích ze skladů odběratele a sám rozhoduje, kdy a kolik doplní v dohodnutých mezích. O jaký princip jde?

- [x] VMI — zásoby řízené dodavatelem
- [ ] CPFR — společné plánování a prognózy
- [ ] CTP — schopné ke slíbení
- [ ] MRP II — plánování výrobních zdrojů

> Při VMI přebírá rozhodnutí o doplnění dodavatel na základě sdílených údajů o zásobách a prodejích odběratele. Při CPFR by plány a prognózy vznikaly společně.

### ? Čím se CPFR liší od VMI?

- [ ] O doplnění rozhoduje sám dodavatel
- [ ] Odběratel nesdílí s dodavatelem žádná data
- [x] Partneři tvoří prognózy a plány společně
- [ ] Jde jen o technický formát zprávy EDI

> CPFR je společné plánování, prognózování a doplňování obou partnerů. Samostatné rozhodování dodavatele o doplnění je naopak podstatou VMI.

## Efekt biče a role aplikací SCM {#bullwhip .explain}

**Efekt biče** (bullwhip effect, též Forresterův efekt) je zesilování výkyvů objednávek **proti proudu řetězce** — od maloobchodu přes velkoobchod k výrobci a jeho dodavatelům. Vzniká mimo jiné tím, že každý článek prognózuje podle objednávek svého odběratele místo konečné poptávky, objednává ve velkých dávkách, reaguje na cenové akce a při nedostatku nadsazuje objednávky. Aplikace SCM jej tlumí: **sdílejí údaje o konečné poptávce** (POS) s celým řetězcem, umožňují jednu společnou prognózu, zkracují informační zpoždění (EDI, portály) a podporují VMI a CPFR.

*Příklad:* Výrobce dětských plen zjistil, že spotřeba je velmi stabilní, ale objednávky distributorů silně kolísaly. Po zavedení sdílení prodejních dat z obchodů začal plánovat podle skutečné spotřeby.

### ? Malé výkyvy prodeje v obchodech vedou k velkým výkyvům objednávek u dodavatele surovin. Jak tento jev aplikace SCM nejlépe omezí?

- [ ] Objednáváním ve větších dávkách
- [x] Sdílením údajů o konečné poptávce
- [ ] Samostatnou prognózou v každém článku
- [ ] Prodloužením dodacích lhůt

> Když všechny články vidí skutečnou poptávku konečných zákazníků, neplánují podle zkreslených objednávek. Větší dávky, oddělené prognózy a delší lhůty efekt biče naopak zesilují.

### ? Kterým směrem se při efektu biče výkyvy objednávek zesilují?

- [ ] Od dodavatelů surovin k zákazníkovi
- [ ] Jen mezi dvěma sousedními články
- [ ] Rovnoměrně ve všech článcích řetězce
- [x] Od zákazníka k dodavatelům surovin

> Výkyvy rostou proti proudu řetězce, takže jsou největší u článků nejvzdálenějších od konečného zákazníka.

## Model SCOR {#scor .explain}

**SCOR** (Supply Chain Operations Reference model) je **referenční procesní model** dodavatelského řetězce, který vytvořila v 90. letech Supply-Chain Council (dnes jej spravuje asociace ASCM). Poskytuje jednotný jazyk pro popis procesů, standardní **metriky** výkonnosti (např. spolehlivost dodávek, rychlost reakce, náklady, využití aktiv) a osvědčené postupy; procesy člení hierarchicky do úrovní od obecných typů po jednotlivé kroky. V klasické podobě má na nejvyšší úrovni šest procesů:

- **Plan** — plánování (vyrovnání poptávky a zdrojů),
- **Source** — obstarání (nákup materiálu a služeb),
- **Make** — výroba,
- **Deliver** — dodání (vyřízení objednávek, sklad, doprava),
- **Return** — zpětné toky (vratky, reklamace),
- **Enable** — podpůrné řízení (pravidla, data, výkonnost, rizika).

Novější verze (SCOR Digital Standard) používá upravené členění procesů. Model slouží k benchmarkingu, návrhu procesů i k vymezení požadavků na aplikace SCM.

*Příklad:* Výrobce elektroniky popíše své procesy podle SCOR, porovná metriku včasnosti dodávek s konkurencí a zjistí, že slabinou je proces Deliver.

### ? Do kterého procesu modelu SCOR patří vyřízení reklamace a zpětný odběr vadného zboží od zákazníka?

- [ ] Deliver
- [ ] Source
- [x] Return
- [ ] Enable

> Return pokrývá zpětné toky — vratky a reklamace od zákazníků i vracení zboží dodavatelům. Deliver řeší dodání zákazníkovi.

### ? Který proces NEPATŘÍ mezi šest procesů nejvyšší úrovně klasického modelu SCOR?

- [ ] Plan
- [x] Sell
- [ ] Make
- [ ] Enable

> Klasický SCOR tvoří procesy Plan, Source, Make, Deliver, Return a Enable. Prodej a marketing jako samostatný proces „Sell" v něm nejsou.

### ? K čemu firma typicky využije model SCOR?

- [ ] K výpočtu čisté potřeby materiálu
- [ ] K elektronické výměně objednávek
- [ ] K detailnímu rozvrhování strojů
- [x] K popisu procesů a srovnání metrik

> SCOR je referenční model se standardními procesy a metrikami, takže slouží k popisu, srovnání (benchmarkingu) a zlepšování řetězce. Výpočty a výměnu dat zajišťují aplikace.

## APS a ERP: spolupráce a zavedení {#aps-erp .explain}

APS **nenahrazuje ERP**, ale doplňuje jej. ERP zůstává **transakčním systémem** a zdrojem kmenových dat (kusovníky, postupy, kapacity pracovišť), objednávek a stavů zásob. APS si tato data načte, vypočte plán a výsledky — plánované výrobní zakázky, návrhy nákupních objednávek, rozvrh — **vrátí do ERP** k realizaci. Kvalita plánu proto závisí na **kvalitě kmenových dat** (kapacity, časy přestavby, průběžné doby). APS se zavádí obvykle postupně, od úlohy s největším přínosem (např. úzkého místa výroby nebo plánování poptávky). Příklady produktů: SAP APO a jeho nástupci (SAP IBP, plánování v S/4HANA), Blue Yonder (dříve JDA), Kinaxis; jednodušší rozvrhování nabízejí i moduly ERP.

*Příklad:* Strojírna zavede APS nejprve jen pro rozvrhování obráběcího centra, které je úzkým místem; zakázky a sklad dál vede v ERP, do kterého se rozvrh každou hodinu vrací.

### ? Firma zavádí APS a řeší, kde budou dál evidovány skutečné zakázky a stavy zásob. Jaké je obvyklé rozdělení?

- [ ] APS nahradí ERP včetně účetnictví
- [ ] ERP počítá plány, APS eviduje zásoby
- [x] ERP eviduje transakce, APS počítá plány
- [ ] Oba systémy mají oddělená nezávislá data

> ERP zůstává transakčním systémem a zdrojem dat; APS z nich počítá plány a výsledky vrací do ERP k realizaci.

### ? Proč projekty APS často narážejí na kvalitu kmenových dat?

- [x] Plán je jen tak dobrý jako zadané kapacity a časy
- [ ] APS kmenová data při plánování vůbec nepoužívá
- [ ] Kmenová data se v APS zadávají jen jednou za rok
- [ ] ERP neumí kmenová data do APS žádným způsobem předat

> Optimalizace pracuje s modelem kapacit, časů přestavby a průběžných dob; jsou-li tyto údaje nepřesné, je nepřesný i výsledný plán.

## Efekty aplikací APS/SCM {#efekty .explain}

**Přínosy:** nižší zásoby v celém řetězci, vyšší úroveň obsluhy a **spolehlivější termíny** dodání (realistické sliby přes ATP/CTP), kratší průběžné doby, lepší využití kapacit a úzkých míst, nižší náklady na dopravu, rychlejší reakce na změny poptávky či výpadky a omezení efektu biče. **Rizika a bariéry:** vysoké náklady a složitost zavedení, závislost na **kvalitě dat** a přesnosti prognóz, **nedůvěra plánovačů** k výsledkům algoritmů („černá skříňka") a potřeba **důvěry a sdílení dat** mezi partnery. Aplikace nejistotu poptávky neodstraní, jen pomáhají na ni lépe reagovat.

*Příklad:* Po zavedení APS dodávala firma včas častěji a snížila zásoby hotových výrobků, protože přestala vyrábět „pro jistotu" na sklad.

### ? Který z uvedených efektů NENÍ reálným přínosem aplikací APS/SCM?

- [ ] Nižší zásoby v celém řetězci
- [ ] Spolehlivější termíny dodání
- [ ] Lepší využití úzkých míst výroby
- [x] Úplné odstranění nejistoty poptávky

> APS/SCM snižují zásoby, zpřesňují termíny a lépe využívají kapacity, nejistotu poptávky však odstranit nemohou — jen na ni pomáhají rychleji a lépe reagovat.

### ? Plánovači po zavedení APS výsledkům nevěří a plány ručně přepisují. Na jaké riziko to ukazuje?

- [ ] Příliš nízkou cenu licencí aplikace
- [x] Nízké přijetí systému uživateli
- [ ] Nadměrné sdílení dat s partnery
- [ ] Chybějící vazbu na model SCOR

> Nedůvěra k výsledkům algoritmů vede k obcházení systému a přínosy se nedostaví. Pomáhá srozumitelnost plánů, zapojení plánovačů a kvalitní data.
