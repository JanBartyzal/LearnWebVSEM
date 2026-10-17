---
kind: topic
subject: togaf-practitioner
slug: kapabilita-v-praxi
name: "Zřízení architektonické kapability v praxi"
order: 2
---

Preliminary Phase ve scénářích: principy, governance, Architecture Repository, role a odpovědnosti, zralost organizace.

## Kdy a proč nasadit Preliminary Phase {#prelim-kdy .explain}

Preliminary Phase připravuje organizaci na architektonickou práci. Neřeší konkrétní architekturu, ale otázky **kdo** (které organizační jednotky, týmy a role), **jak** (metoda, principy, governance, nástroje) a **s jakou ambicí** (cílová zralost architektonické kapability). Konkrétní architektura začíná až ve Phase A na základě Request for Architecture Work. Typické spouštěče jsou zakládání nové EA praxe, fúze či reorganizace, nedůvěra businessu k architektům nebo nejednotné postupy různých týmů. Hlavními výsledky jsou Organizational Model for Enterprise Architecture, Tailored Architecture Framework, Architecture Principles, rámec architektonické governance a počáteční (initial) Architecture Repository.

*Příklad:* Pokud firma už má funkční EA praxi se schválenými principy a governance, nový projekt začíná rovnou ve Phase A — Preliminary se neopakuje při každém zadání.

### ? Pojišťovna jmenovala svého prvního hlavního architekta. Ředitel IT po něm chce do dvou týdnů cílovou aplikační architekturu. Ve firmě zatím neexistují architektonické principy, governance ani dohodnutý způsob architektonické práce a nikdo z vedení nevymezil, co má podniková architektura řešit. Co je nejlepší první krok?

- [ ] Rovnou zahájit Phase C a popsat Baseline aplikací, protože požadavek ředitele je naléhavý
- [x] Provést Preliminary Phase: vymezit rozsah, sponzora, principy, governance a způsob práce
- [ ] Pořídit EA nástroj a naplnit Architecture Repository úplným inventářem aplikací
- [ ] Sepsat Statement of Architecture Work na aplikační architekturu a nechat ho podepsat

> Bez mandátu, principů a governance nemá architektonická práce oporu, a proto je na řadě Preliminary Phase. Skok do Phase C přeskakuje přípravu i vizi, nákup nástroje předbíhá rozhodnutí o tom, co má repozitář obsahovat, a Statement of Architecture Work patří do Phase A, až bude jasné, jak a pro koho se architektura dělá.

### ? Banka má několik let funkční EA praxi: schválené architektonické principy, fungující Architecture Board a zavedený repozitář. Ředitel retailu právě předal Request for Architecture Work na novou platformu pro hypotéky. Nikdo nenavrhuje měnit způsob, jakým architekti v bance pracují. Jak má hlavní architekt postupovat?

- [ ] Nejprve zopakovat celou Preliminary Phase, aby principy odpovídaly novému projektu
- [ ] Svolat Architecture Board a nechat ho znovu schválit Organizational Model for EA
- [ ] Přeskočit vizi a začít rovnou Phase B, protože principy a governance už existují
- [x] Zahájit Phase A a využít v ní existující principy, governance a rámec

> Preliminary Phase se opakuje jen tehdy, když se mění samotná architektonická kapabilita; jinak nový požadavek začíná ve Phase A, která na připravený rámec navazuje. Opakování Preliminary nebo znovuschvalování modelu by bylo zbytečné a přeskočení Phase A by vynechalo vizi, stakeholdery a Statement of Architecture Work.

## Vymezení dotčených částí podniku (core, soft, extended enterprise) {#rozsah-podniku .compare}

Prvním krokem Preliminary Phase je určit, kterých částí podniku a okolí se architektonická práce týká. Na zařazení závisí, koho zapojit, jak hluboko a s jakou formou komunikace.

| Skupina | Koho zahrnuje | Jak s ní v praxi pracovat |
|---|---|---|
| Core enterprise | jednotky, které změna zasáhne nejvíc a nejvíc z ní získají | plné zapojení do tvorby a schvalování architektury |
| Soft enterprise | jednotky, jejichž kapabilita se změní, ale nejsou přímým cílem | konzultovat dopady, sladit rozhraní a termíny |
| Extended enterprise | jednotky mimo vymezený podnik (partneři, dodavatelé), které budou muset upravit vlastní architekturu | dohodnout rozhraní a smluvní či technické podmínky |
| Dotčené komunity (communities) | skupiny stakeholderů zasažené změnou jako celek | oslovovat přes jejich zástupce |
| Dotčená governance | řídicí struktury, právní rámce a geografie, které změnu ovlivňují | zapracovat do principů, omezení a governance |

### ? Výrobce spotřební elektroniky zavádí podnikovou architekturu pro svou prodejní divizi, jejíž procesy a systémy se zásadně změní. Účetní oddělení bude z nového systému jen přebírat data. Nezávislí distributoři, kteří nejsou součástí firmy, budou kvůli změně muset upravit vlastní objednávkové systémy a napojení. Jak mají architekti v Preliminary Phase zařadit distributory?

- [x] Jako extended enterprise, protože jsou mimo podnik a změna je zasáhne
- [ ] Jako core enterprise, protože bez nich změna nemůže fungovat
- [ ] Jako soft enterprise, protože jejich kapabilita se změní jen nepřímo
- [ ] Mimo rozsah, protože nejsou organizační součástí výrobce

> Partneři mimo vymezený podnik, kteří kvůli změně upravují svou architekturu, tvoří extended enterprise. Core enterprise je prodejní divize, soft enterprise jsou interní jednotky dotčené nepřímo a vynechat distributory z rozsahu by znamenalo přehlédnout kritická rozhraní.

### ? Nemocnice připravuje architekturu nového systému pro příjem pacientů. Ambulance a příjmová kancelář budou pracovat úplně jinak a nový systém jim přinese největší užitek. Oddělení ekonomiky bude dál pracovat svými postupy, jen začne dostávat data o výkonech v jiné podobě a musí na ně přizpůsobit vykazování. Kam ekonomické oddělení patří?

- [x] Do soft enterprise — změní se mu práce, ale není cílem změny
- [ ] Do core enterprise — každé dotčené interní oddělení patří do jádra změny
- [ ] Do extended enterprise — přebírá data z jiného systému, než sám používá
- [ ] Do dotčené governance — vykazování výkonů je regulovaná oblast

> Ekonomické oddělení je interní jednotka, které se změní způsob práce s daty, ale změna se dělá kvůli příjmu pacientů — to odpovídá soft enterprise. Core enterprise jsou ambulance a příjem, extended enterprise jsou subjekty mimo podnik a regulace vykazování by se zapracovala jako dotčená governance, ne jako zařazení oddělení.

## Sponzor a mandát architektonické práce {#sponzor-mandat .explain}

Architektonická kapabilita bez sponzora z vedení obvykle končí jako izolovaná aktivita IT, kterou projekty obcházejí. V Preliminary Phase proto architekt nejprve hledá **sponzora s rozhodovací pravomocí** a s ním dohodne mandát: jaký rozsah podniku architektura pokrývá, kdo rozhoduje ve sporech, jaký je rozpočet a jak se architektura promítne do řízení podniku. Tyto dohody se zapisují do Organizational Model for Enterprise Architecture (rozpočtové požadavky, governance and support strategy). Principy a governance navržené bez sponzora mají jen poradní váhu.

*Příklad:* Místo toho, aby architekt sám sepsal principy a „prodával" je projektům, nejdřív získá finančního ředitele jako sponzora, který principy předloží vedení ke schválení.

### ? Architekt v logistické firmě má neformální podporu několika vedoucích v IT. Obchodní vedení o záměru zavést podnikovou architekturu neví, rozpočet na ni nikdo nevyčlenil a projekty dnes o technologiích rozhodují samy. Architekt chce, aby jeho práce měla skutečný vliv. Co má udělat nejdřív?

- [x] Získat sponzora z vedení a dohodnout s ním mandát, rozpočet a strategii governance
- [ ] Sepsat sám architektonické principy a postupně je nabízet jednotlivým projektům
- [ ] Vybudovat Architecture Repository, aby kvalitní obsah přesvědčil obchodní vedení
- [ ] Zahájit Phase A pro nejviditelnější projekt a sponzora hledat až podle jeho výsledků

> Bez sponzora a mandátu nemají principy ani governance váhu, proto je prvním krokem dohoda s vedením zapsaná v Organizational Model for EA. Principy psané o samotě, repozitář „do zásoby" i projekt bez sponzora vynakládají úsilí, které projekty mohou dál ignorovat.

## Organizational Model for Enterprise Architecture v praxi {#org-model-ea .explain}

Organizational Model for Enterprise Architecture je výstup Preliminary Phase, který popisuje, **jak bude architektonická funkce zorganizována a řízena**. Obsahuje rozsah dotčených organizací, posouzení zralosti, zjištěné mezery a způsob jejich řešení, role a odpovědnosti architektonických týmů, omezení architektonické práce, rozpočtové požadavky a strategii governance a podpory. Používá se jako „smlouva" mezi architekty a vedením: když vznikne spor o pravomoci, rozpočet či rozsah, hledá se odpověď právě zde. Nepopisuje žádnou konkrétní architekturu — to dělají výstupy Phase A až D.

*Příklad:* Spor o to, zda architekt smí zastavit výběr dodavatele, se řeší podle rozhodovacích práv zapsaných v Organizational Model for EA, ne podle toho, kdo je zrovna hlasitější.

### ? Nový generální ředitel strojírenské firmy chce v jednom dokumentu vidět, kdo v oblasti podnikové architektury za co odpovídá, kolik architektonická funkce stojí, jaká omezení pro její práci platí a jak zralá je dnes. O žádnou konkrétní cílovou architekturu se zatím nezajímá. Který výstup ADM mu architekt předloží?

- [ ] Architecture Vision
- [ ] Statement of Architecture Work
- [x] Organizational Model for EA
- [ ] Architecture Definition Document

> Role, rozpočet, omezení architektonické práce a posouzení zralosti jsou obsahem Organizational Model for EA z Preliminary Phase. Architecture Vision a Statement of Architecture Work se týkají konkrétního architektonického zadání ve Phase A a Architecture Definition Document popisuje samotné architektury z fází B–D.

### ? Telekomunikační operátor dokončuje Preliminary Phase. Architekt připravuje Organizational Model for Enterprise Architecture a váhá, co do něj zařadit. Která z následujících položek do tohoto výstupu patří?

- [ ] Seznam work packages a přechodových architektur na první dva roky realizace
- [ ] Cílová aplikační architektura s mapou rozhraní mezi systémy
- [ ] Architecture Contract s dodavatelem nového billingového systému
- [x] Role a odpovědnosti architektonických týmů a rozpočtové požadavky

> Organizational Model for EA popisuje organizaci a řízení architektonické funkce — role, rozpočet, omezení, zralost a strategii governance. Work packages vznikají ve Phase E, cílová aplikační architektura ve Phase C a Architecture Contract slouží implementační governance ve Phase G.

## Role, odpovědnosti a rozhodovací práva {#role-odpovednosti .explain}

Častým zdrojem konfliktů je nejasná hranice mezi architekty, projektovými manažery, vlastníky produktů a provozem. V Preliminary Phase se proto pro architektonickou práci určují **role a rozhodovací práva** — typicky sponzor, Architecture Board, hlavní architekt, doménoví architekti a jejich vazba na projektové a provozní role. Pomáhá jednoduchá matice odpovědností (např. RACI): kdo rozhoduje, kdo schvaluje, koho je nutné konzultovat a koho jen informovat. Do stejného modelu patří i chybějící dovednosti a plán, jak je doplnit (nábor, školení, externí partner).

*Příklad:* Projekt rozhoduje o knihovnách a frameworcích sám; o výběru nové databázové platformy rozhoduje architektura, protože jde o standard pro celý podnik.

### ? V e-shopu se architekti a projektoví manažeři opakovaně přou, kdo rozhoduje o výběru technologií. Některé projekty si vybírají platformy samy, jiné čekají měsíce na vyjádření architektů. Vedení chce spory ukončit, ale nechce zbytečně zpomalit dodávky. Co je nejvhodnější řešení?

- [ ] Přenést všechna technologická rozhodnutí na Architecture Board, aby byla jednotná
- [x] Vyjasnit rozhodovací práva (např. maticí RACI) v Organizational Model for EA
- [ ] Nechat rozhodování výhradně na projektech a architekty využívat jen jako poradce
- [ ] Řešit každý spor jednotlivě eskalací na ředitele IT podle aktuální situace

> Spory o pravomoci řeší jasné rozdělení rozhodovacích práv zakotvené v modelu architektonické funkce — co rozhoduje projekt a co architektura. Centralizace všech rozhodnutí by dodávky zahltila, úplné přenechání projektům rozbije konzistenci a ad hoc eskalace spory jen odkládá.

### ? Banka při zřizování architektonické funkce zjistila, že všichni její architekti mají technické zaměření a nikdo z nich nemá zkušenost s business architekturou. Vedení přitom očekává, že architektura pomůže s přestavbou obchodních procesů. Jak s tímto zjištěním v Preliminary Phase naložit?

- [ ] Vynechat Phase B a soustředit architektonickou práci jen na Phases C a D
- [ ] Svěřit business architekturu projektovým manažerům jednotlivých iniciativ
- [x] Zapsat chybějící dovednosti jako mezeru a naplánovat její řešení (nábor, školení)
- [ ] Odložit veškerou architektonickou práci, dokud se nepodaří najmout business architekty

> Mezery v dovednostech a způsob jejich řešení patří k výsledkům Preliminary Phase a plánují se jako součást budování kapability. Vynechat Phase B by popřelo očekávání vedení, přesunout ji na projektové manažery znamená ztratit podnikový pohled a čekat se vším je zbytečně drahé.

## Centrální × federovaná architektonická funkce {#centralni-federovany .compare}

Jak architektonickou funkci uspořádat, závisí na struktuře podniku; TOGAF dovoluje oba přístupy, pokud jsou řízené společnými pravidly.

| Hledisko | Centrální tým | Federované týmy pod společnou governance |
|---|---|---|
| Kdy se hodí | menší či jednotně řízený podnik, jedna strategie | koncern, autonomní divize nebo segmenty s vlastním IT |
| Co je společné | vše — jeden tým, jeden repozitář, jedny principy | podnikové principy, governance, metamodel a pravidla repozitáře |
| Co je lokální | nic podstatného | segmentové a kapabilitní architektury, lokální standardy v mezích podnikových |
| Hlavní riziko | úzké hrdlo a odtržení od divizí | rozdrobení, pokud chybí společná governance a koordinace |

### ? Skupina vlastní pět dceřiných společností v různých zemích. Každá má vlastní IT a vlastní projekty, ale vedení skupiny chce sdílet několik platforem a mít společné principy pro data a bezpečnost. Dceřiné firmy odmítají, aby o jejich lokálních systémech rozhodoval jeden tým z centrály. Jaké uspořádání architektonické funkce je nejvhodnější?

- [ ] Jeden centrální tým skupiny, který vytváří a schvaluje všechny architektury
- [ ] Samostatné architektonické funkce v každé firmě, každá s vlastním rámcem
- [x] Federované týmy v dceřiných firmách pod společnými principy a governance
- [ ] Architektura jen v největší dceřiné firmě, jejíž řešení ostatní později převezmou

> Kombinace lokální autonomie a společných pravidel odpovídá federovanému uspořádání se společnými principy, governance a pravidly repozitáře na úrovni skupiny. Centrální tým by narazil na odpor a stal by se úzkým hrdlem, zcela samostatné funkce nedokážou sdílet platformy a principy a přístup „jedna firma za všechny" ignoruje odlišnosti ostatních.

## Napojení na existující řídicí rámce {#napojeni-ramce .explain}

Architektonická funkce nevzniká ve vzduchoprázdnu: podnik už má strategické plánování, portfolio a projektové řízení, IT governance, řízení provozu a změn, často i regulatorní požadavky. V Preliminary Phase se tyto rámce **identifikují a stanoví se rozhraní**, tedy kde a kdy do nich architektura vstupuje a co jim předává. Architektura má existující procesy doplnit, ne vytvořit paralelní schvalovací cestu. Dotčené právní a regulatorní rámce se zároveň promítnou do principů, omezení a governance.

*Příklad:* Místo vlastního „architektonického schvalování" se do existujícího stage-gate procesu projektů vloží architektonická kontrola na dvou branách — při schválení záměru a před spuštěním do provozu.

### ? Pojišťovna má zavedené portfolio management, projektový proces s branami (stage-gate) a řízení změn v provozu. Nově vzniklý architektonický tým navrhuje vlastní samostatný schvalovací proces, kterým by každý projekt musel projít navíc. Projektoví manažeři se obávají dalšího zdržení. Co je nejlepší postup?

- [ ] Zavést samostatný architektonický proces, protože jen ten zajistí nezávislost architektury
- [ ] Nahradit dosavadní projektový proces jednotným procesem řízeným architekty
- [ ] Nechat architektonickou kontrolu dobrovolnou, aby projekty nezdržovala
- [x] Napojit architekturu na existující brány projektového procesu a definovat rozhraní

> Preliminary Phase má potvrdit existující řídicí rámce a určit, kde do nich architektura vstupuje, místo budování paralelního schvalování. Samostatný proces dodávky zbytečně zdržuje, nahrazovat fungující projektový proces je mimo mandát architektů a dobrovolná kontrola nemá žádnou vymahatelnost.

### ? Banka zakládá architektonickou funkci. Podléhá dohledu centrální banky, který klade přísné požadavky na outsourcing a na umístění dat klientů. Architekti řeší, kdy a jak tyto požadavky zohlednit. Co je nejvhodnější?

- [x] Zahrnout je hned v Preliminary Phase do governance, principů a omezení
- [ ] Zohlednit je až ve Phase G, kdy se řeší soulad implementace s pravidly
- [ ] Nechat jejich posouzení na právním oddělení, mimo architektonický rámec
- [ ] Řešit je jen u projektů, které výslovně počítají s outsourcingem služeb

> Právní a regulatorní rámce patří k dotčené governance, kterou Preliminary Phase identifikuje, a mají se projevit v principech a omezeních pro veškerou architektonickou práci. Odklad do Phase G by vedl k drahým přepracováním, oddělení od architektonického rámce k nekonzistenci a řešení jen u některých projektů přehlíží dopady na data klientů jinde.

## Rámec architektonické governance {#governance-ramec .explain}

Rámec architektonické governance se navrhuje v Preliminary Phase, ne až při první implementaci. Popisuje **procesy** (Policy Management and Take-On, Compliance, Dispensation, Monitoring and Reporting, Business Control, Environment Management), **obsah**, s nímž pracují (např. hodnocení souladu, rozhodnutí, výjimky), a **organizační kontext** (kdo rozhoduje a komu se zodpovídá). Dobrá governance má mít vlastnosti jako disciplína, transparentnost, nezávislost, odpovědnost (accountability i responsibility) a férovost. Rozhodnutí se zaznamenávají do Governance Log v Architecture Repository, aby byla dohledatelná.

*Příklad:* Když projekt nemůže z vážného důvodu splnit standard, nežádá o „tichou toleranci", ale formálně o výjimku (dispensation) s časovým omezením a podmínkami.

### ? Firma zřídila Architecture Board a vydala technologické standardy. Brzy se ukázalo, že projekt s mimořádnými požadavky na výkon nemůže jeden ze standardů splnit, a neexistuje žádný postup, jak takovou situaci řešit — projekt buď standard tiše porušuje, nebo stojí. Který proces architektonické governance firmě chybí?

- [ ] Policy Management and Take-On
- [x] Dispensation
- [ ] Monitoring and Reporting
- [ ] Environment Management

> Řízené udělení výjimky z požadavků architektury s podmínkami a časovým omezením je úkolem procesu Dispensation. Policy Management and Take-On spravuje zavádění a údržbu pravidel, Monitoring and Reporting sleduje a vykazuje výkonnost governance a Environment Management zajišťuje prostředí, v němž governance funguje.

### ? Architecture Board výrobní firmy rozhoduje o výjimkách ze standardů na neveřejných jednáních. Zdůvodnění rozhodnutí se nikde nezapisuje a projekty ani vedení si nemohou ověřit, proč jeden projekt výjimku dostal a jiný ne. Kterou vlastnost dobré architektonické governance firma porušuje nejvíce?

- [x] Transparentnost
- [ ] Nezávislost
- [ ] Disciplínu
- [ ] Odpovědnost (responsibility)

> Transparentnost znamená, že rozhodnutí a jejich podklady jsou dostupné k nahlédnutí oprávněným stranám; to tu zcela chybí. Nezávislost se týká střetu zájmů, disciplína dodržování dohodnutých pravidel a responsibility odpovědného jednání každé zapojené strany — přímo porušená je zde dohledatelnost rozhodnutí.

### ? Ve stavební firmě předsedá Architecture Board ředitel divize, který je zároveň sponzorem největšího probíhajícího projektu. Board má právě rozhodnout, zda tento projekt smí nasadit nestandardní platformu, a předseda o tom hlasuje jako ostatní členové. Kterou vlastnost dobré governance tato situace ohrožuje?

- [ ] Transparentnost
- [ ] Disciplínu
- [x] Nezávislost
- [ ] Odpovědnost (accountability)

> Nezávislost vyžaduje, aby rozhodovací mechanismy minimalizovaly střet zájmů — sponzor projektu by o výjimce pro vlastní projekt neměl rozhodovat. Transparentnost se týká dohledatelnosti rozhodnutí, disciplína dodržování pravidel a accountability toho, kdo se za rozhodnutí zodpovídá; žádná z nich zde není hlavním problémem.

## Zřízení Architecture Board {#zrizeni-board .explain}

Architecture Board se ustavuje v rámci Preliminary Phase jako součást governance. V praxi je důležité: **jasný mandát** (o čem rozhoduje, kam eskaluje, jak se vztahuje k IT governance a portfoliu), **malé jádro stálých členů** — standard doporučuje zhruba čtyři až pět a rozhodně ne víc než deset — a **zastoupení businessu i IT** na úrovni, která má skutečnou rozhodovací pravomoc. Další odborníci se přizývají podle projednávaného tématu. Board odpovídá za konzistenci architektur, vymáhání souladu, rozhodování o výjimkách a řešení sporů.

*Příklad:* Místo dvacetičlenné komise, která se nikdy neusnese, má Board pět stálých členů (dva z businessu, tři z IT a architektury) a k bezpečnostním tématům přizve CISO.

### ? Při zřizování Architecture Board navrhl ředitel IT, aby v něm byl zástupce každého ze 16 oddělení firmy, „aby se nikdo necítil opomenut". Architekt se obává, že takový orgán nebude schopen rychle rozhodovat. Jaké doporučení je nejlepší?

- [ ] Přijmout návrh, protože široké zastoupení zaručuje přijetí všech rozhodnutí
- [ ] Nezřizovat Board a nechat rozhodování výhradně na hlavním architektovi
- [ ] Zřídit Board jen z architektů, kteří rozhodnutím odborně rozumějí nejlépe
- [x] Malé jádro stálých členů s mandátem, odborníky přizývat podle tématu

> Standard doporučuje malý Board se zhruba čtyřmi až pěti stálými členy (nejvýš deseti), doplňovaný odborníky podle potřeby. Šestnáctičlenný orgán by rozhodoval pomalu, jediný rozhodující architekt postrádá kolektivní governance a Board jen z architektů nemá podporu businessu.

### ? Architecture Board pojišťovny tvoří pouze vedoucí oddělení IT. Obchodní ředitelé jeho rozhodnutí o prioritách a standardech opakovaně zpochybňují a projekty, které sponzorují, si prosazují výjimky přes generálního ředitele. Co je nejlepší náprava?

- [x] Doplnit Board o zástupce businessu s pravomocí a potvrdit mandát u sponzora
- [ ] Zpřísnit sankce za nedodržení rozhodnutí Boardu u projektů businessu
- [ ] Přesunout rozhodnutí Boardu do projektových řídicích výborů jednotlivých projektů
- [ ] Omezit působnost Boardu jen na technologické standardy, kde mu business nevstupuje

> Rozhodnutí Boardu mají váhu jen tehdy, když v něm sedí business i IT na úrovni s rozhodovací pravomocí a jeho mandát potvrdí vedení. Sankce bez legitimity odpor zvýší, přesun do projektových výborů rozbije podnikový pohled a omezení na technologie vzdá řízení architektury jako celku.

## Jak vytvořit architektonické principy {#principy-tvorba .explain}

Architektonické principy se v Preliminary Phase **odvozují z business principů, cílů a strategie** podniku a mají je podporovat; nevznikají jako osobní preference architektů. Každý princip má části Name, Statement, Rationale a Implications — nejčastěji se podceňují Implications, tedy co princip znamená pro business i IT (náklady, nové úkoly, změny chování). Dobrá sada je **malá**, obvykle v řádu jednotek až nižších desítek principů, aby si je lidé pamatovali a mohli je použít. Principy se projednávají se stakeholdery a schvalují (obvykle Architecture Board a sponzor), jinak nebudou vymahatelné.

*Příklad:* Business princip „Jednotný pohled na zákazníka" vede k architektonickému principu „Data o zákaznících mají jednoho vlastníka a jeden zdroj pravdy" s implikací, že projekty nesmějí zakládat vlastní kopie zákaznických dat.

### ? Nově jmenovaný architekt maloobchodního řetězce sepsal o víkendu 45 architektonických principů podle svých zkušeností z předchozího zaměstnání a rozeslal je projektům jako závazné. Projekty je nečtou a vedení o nich neví. Co je nejlepší další krok?

- [ ] Doplnit ke každému principu sankci, aby projekty začaly principy dodržovat
- [ ] Ponechat všech 45 principů a vysvětlit je projektům na sérii školení
- [x] Zredukovat je na menší sadu odvozenou ze strategie, projednat a schválit
- [ ] Nahradit je ukázkovou sadou principů ze standardu bez dalších úprav

> Principy mají být nečetné, odvozené z business principů a strategie, projednané se stakeholdery a formálně schválené. Sankce ani školení nevyřeší, že principy nemají legitimitu ani vazbu na podnik, a převzetí ukázkové sady bez úprav ignoruje konkrétní situaci firmy.

### ? Vedení letecké společnosti vyhlásilo business principy, mezi nimi „Bezpečnost provozu má přednost před náklady" a „Zákazník dostává jednotné informace ve všech kanálech". Architekti teď v Preliminary Phase připravují architektonické principy. Jak mají postupovat?

- [ ] Vytvořit architektonické principy nezávisle, protože business principy se týkají jen vedení
- [x] Odvodit je tak, aby business principy podporovaly, a odkázat na ně v Rationale
- [ ] Převzít business principy beze změny a označit je za architektonické principy
- [ ] Počkat s principy do Phase B, kdy bude známa business architektura

> Architektonické principy mají z business principů vycházet a v Rationale zdůvodnit, jak je podporují. Nezávislá sada riskuje rozpor se strategií, prosté převzetí nedá architektům konkrétní vodítko pro rozhodování a principy jsou výsledkem Preliminary Phase, ne až Phase B.

### ? Distribuční firma má schválený princip „Data jsou sdíleným podnikovým aktivem" s vyplněnými částmi Name, Statement a Rationale. Projekty s ním formálně souhlasí, ale dál si budují vlastní izolované databáze, protože nikdo neřekl, co konkrétně mají dělat jinak. Jak princip nejlépe zlepšit?

- [ ] Přeformulovat Statement, aby byl princip delší a podrobnější
- [ ] Doplnit Rationale o další argumenty, proč jsou sdílená data výhodná
- [ ] Přejmenovat princip, aby jeho Name lépe vystihovalo důležitost dat
- [x] Doplnit Implications, tedy dopady principu na business, projekty a IT

> Implications popisují, co princip prakticky znamená — jaké úkoly, náklady a změny chování z něj plynou; bez nich princip nevede k jinému jednání. Delší Statement, další argumenty v Rationale ani nový název nezodpoví otázku „co mám dělat jinak".

## Kvalitativní kritéria sady principů {#principy-kriteria .compare}

Pět kritérií dobré sady principů pomáhá rozpoznat, co je se sadou v nepořádku a jak to opravit.

| Kritérium | Co vyžaduje | Typický příznak porušení | Náprava |
|---|---|---|---|
| Understandable | smysl principu rychle pochopí každý v organizaci | lidé si princip vykládají každý jinak, protože mu nerozumějí | přeformulovat srozumitelně, bez žargonu |
| Robust | princip je dost přesný pro konzistentní rozhodování i ve sporných případech | v konkrétním sporu z něj nelze nic vyvodit | zpřesnit Statement a Implications |
| Complete | sada pokrývá všechny podstatné oblasti řízení informací a technologií | pro důležitou oblast (např. data) chybí jakékoli vodítko | doplnit chybějící principy |
| Consistent | principy lze vyvažovat, aniž by dodržení jednoho popřelo smysl jiného | dva principy se vzájemně zcela vylučují | přeformulovat, aby šlo hledat rovnováhu |
| Stable | principy jsou trvalé, mění se jen řízeným procesem | sada se mění s každým novým manažerem | zavést schvalovací proces změn principů |

### ? Za tři roky se v pojišťovně vystřídali tři ředitelé IT a každý po nástupu vyhlásil vlastní, výrazně odlišnou sadu architektonických principů. Projekty si stěžují, že nevědí, podle čeho dlouhodobě plánovat. Které kritérium kvality principů je porušeno nejvíc?

- [ ] Complete
- [ ] Understandable
- [ ] Robust
- [x] Stable

> Kritérium Stable požaduje, aby principy byly trvalé a měnily se jen řízeným procesem změn, ne s každým novým manažerem. Ostatní kritéria se týkají pokrytí oblastí, srozumitelnosti a přesnosti pro rozhodování, na které stížnost projektů nemíří.

### ? Logistická firma má schválené dva principy: „Všechny aplikace provozujeme výhradně ve veřejném cloudu" a „Žádná data neopouštějí vlastní datové centrum firmy". Formulace nepřipouštějí žádnou výjimku ani vyvažování. Architekti nemohou navrhnout žádné řešení, které by splnilo oba. Které kritérium kvality sady principů je porušeno?

- [x] Consistent
- [ ] Stable
- [ ] Complete
- [ ] Understandable

> Consistent vyžaduje, aby se principy daly vyvažovat a dodržení jednoho nepopíralo smysl jiného — zde se oba striktně vylučují. Sada se nemění (Stable), oba principy jsou srozumitelné (Understandable) a nejde o chybějící oblast (Complete).

### ? Výrobní firma má sedm schválených architektonických principů a všechny se týkají infrastruktury a provozu serverů. Když projekt potřeboval rozhodnout, kdo vlastní data o zákaznících a kdo k nim smí přistupovat, žádný princip mu nedal vodítko. Které kritérium kvality sady principů je porušeno?

- [ ] Robust
- [x] Complete
- [ ] Consistent
- [ ] Stable

> Complete znamená, že sada pokrývá všechny podstatné oblasti řízení informací a technologií; zde zcela chybí data. Robust by bylo porušeno, kdyby princip pro data existoval, ale byl příliš vágní, a o rozpor (Consistent) ani nestálost (Stable) nejde.

## Použití principů při rozhodování a výjimky {#principy-pouziti .explain}

Principy nejsou dekorace: slouží jako **kritéria pro hodnocení alternativ**, jako základ hodnocení souladu projektů a jako argument při řešení sporů. Rozhodnutí se má výslovně odvolat na principy, které podpořilo nebo upozadilo. Když jsou dva principy v napětí, hledá se rovnováha pro konkrétní situaci a důvod se zdokumentuje. Jednorázová oprávněná odchylka se řeší **výjimkou (dispensation)** přes governance; jestliže se ale od principu odchylují opakovaně mnohé projekty, je to signál k **řízené revizi principu**.

*Příklad:* Princip „Nákup má přednost před vývojem" vede při výběru CRM k upřednostnění SaaS řešení; vlastní vývoj vyžaduje doložit, proč trh potřebu nepokrývá.

### ? Mediální firma vybírá redakční systém. Na stole jsou dvě technicky srovnatelné varianty: vlastní vývoj na míru a hotový SaaS produkt. Firma má schválené principy „Nákup má přednost před vývojem" a „Podporujeme sdílené platformy". Vedení chce rozhodnutí, které bude možné později obhájit. Jak má architekt principy využít?

- [x] Použít principy jako kritéria hodnocení variant a odvolat se na ně v doporučení
- [ ] Rozhodnout podle ceny a principy uvést jen v příloze jako doplňující informaci
- [ ] Nechat volbu na dodavatelích a principy použít až při kontrole souladu ve Phase G
- [ ] Vytvořit pro tento výběr nový princip, který jednu z variant jednoznačně určí

> Principy slouží právě k hodnocení alternativ a dohledatelnému zdůvodnění rozhodnutí. Odsunout je do přílohy nebo až do Phase G popírá jejich roli při návrhu a tvořit účelový princip pro jedno rozhodnutí podkopává stabilitu celé sady.

### ? Nemocnice má princip „Používáme jen standardizované podnikové databázové platformy". Jedno pracoviště potřebuje pro přístroj certifikovaný výrobcem specializovanou databázi, kterou žádná standardní platforma nenahradí; jde o jediný takový případ v nemocnici. Jak má architektura postupovat?

- [ ] Zrušit princip, protože se ukázal jako neudržitelný
- [ ] Odmítnout přístroj, protože porušuje schválený princip
- [x] Projednat výjimku (dispensation) přes governance s podmínkami a evidencí
- [ ] Nechat pracoviště nasadit databázi tiše, bez formálního rozhodnutí a evidence

> Jednorázová oprávněná odchylka se řeší řízenou výjimkou, která je zdůvodněná, podmíněná a zaznamenaná. Rušit princip kvůli jedinému případu je přehnané, odmítnout certifikovaný přístroj ignoruje potřebu pracoviště a tichá tolerance podkopává governance.

### ? Banka má princip „Všechny aplikace běží v našem datovém centru". Během posledního roku požádalo o výjimku jedenáct projektů, protože jimi požadované služby nabízejí dodavatelé už jen jako cloudové. Architecture Board všechny výjimky schválil. Co by měl hlavní architekt navrhnout?

- [ ] Přestat výjimky schvalovat, aby se princip v bance začal znovu dodržovat
- [x] Zahájit řízenou revizi principu, protože výjimky ukazují na jeho zastarání
- [ ] Pokračovat ve schvalování výjimek, protože governance funguje správně
- [ ] Nechat projekty, aby si princip vykládaly podle vlastní situace

> Opakované a oprávněné výjimky signalizují, že princip neodpovídá realitě, a má se řízeně revidovat. Plošné odmítání by blokovalo potřebné služby, nekonečné výjimky princip vyprazdňují a volný výklad projekty ruší jeho smysl.

## Počáteční Architecture Repository a volba nástrojů {#repozitar-start .explain}

V Preliminary Phase vzniká **počáteční (initial) Architecture Repository** a strategie nástrojů a technik. Dobrá praxe postupuje v pořadí: nejdřív rozhodnout, **co má repozitář obsahovat a komu slouží** (metamodel, druhy obsahu, uživatelé), pak zvolit nástroj, který to podporuje. Na začátek stačí jádro, které bude hned potřeba: principy, standardy, šablony, záznamy governance a dosavadní architektonické podklady. Podrobný obsah se doplňuje postupně podle skutečných zadání, ne „do zásoby".

*Příklad:* Firma nezačíná nákupem drahého modelovacího nástroje; nejdřív sjednotí metamodel a šablony, zaeviduje existující standardy a dokumenty a nástroj vybírá podle těchto potřeb.

### ? Hlavní architekt chemického podniku chce hned po svém nástupu koupit robustní EA modelovací nástroj, protože ho znal z minulé firmy. Zatím není rozhodnuto, jaký obsah bude repozitář uchovávat, kdo ho bude používat ani jak bude vypadat metamodel. Jaké doporučení je nejlepší?

- [ ] Nástroj koupit hned, protože bez něj nelze Preliminary Phase dokončit
- [ ] Vybrat nástroj podle toho, který mají ostatní firmy v oboru nejčastěji
- [ ] Odložit repozitář i nástroje až do Phase A prvního architektonického projektu
- [x] Nejdřív určit obsah, metamodel a uživatele repozitáře, pak zvolit nástroj

> Strategie nástrojů vychází z toho, co má repozitář obsahovat a komu sloužit; nástroj se volí až podle těchto potřeb. Nákup naslepo ani výběr podle oboru nezaručí soulad s potřebami firmy a odklad do Phase A by první projekt nechal bez připraveného repozitáře.

### ? Telekomunikační operátor v Preliminary Phase zakládá počáteční Architecture Repository. Má rozpracované architektonické dokumenty z minulých projektů, schválené technologické standardy a nově schválené principy. Tým má jen dva architekty a první architektonický projekt začne za měsíc. Co má do repozitáře uložit přednostně?

- [ ] Úplný podrobný model všech 400 aplikací včetně rozhraní, než začne první projekt
- [x] Principy, standardy, šablony a existující architektonické podklady; detail postupně
- [ ] Pouze cílové architektury, protože výchozí stav se bude stejně měnit
- [ ] Nic, dokud Architecture Board neschválí kompletní metamodel na několik let dopředu

> Počáteční repozitář má obsahovat jádro, které je okamžitě potřeba — principy, standardy, šablony a to, co už existuje; podrobný obsah přibývá s konkrétními zadáními. Úplné modelování předem je při dvou architektech nereálné, ukládat jen cílové architektury ztrácí výchozí stav a čekat na dokonalý metamodel zbytečně brzdí.

## Zralost architektonické kapability {#zralost .explain}

Součástí Preliminary Phase je **posouzení současné zralosti** architektonické kapability (procesy, lidé, nástroje, governance, využívání výstupů) a **stanovení cílové zralosti**, kterou podnik skutečně potřebuje. Rozdíl mezi nimi se zapíše jako mezery spolu se způsobem jejich řešení. Cílová úroveň se volí podle potřeb businessu, ne podle toho, co je teoreticky nejvyšší, a dosahuje se po přírůstcích. Posouzení zralosti zároveň slouží jako výchozí bod, vůči kterému lze později doložit zlepšení.

*Příklad:* Firma s neformální EA praxí si stanoví, že do roka bude mít schválené principy, fungující Board a jednotné šablony; měřitelné řízení výkonnosti architektury odloží na další etapu.

### ? Posouzení ukázalo, že architektonická praxe distribuční firmy je nízce zralá: postupy se liší tým od týmu, governance je neformální a výstupy se málo používají. Generální ředitel požaduje dosáhnout nejvyšší úrovně zralosti do šesti měsíců. Co má architekt doporučit?

- [ ] Přijmout cíl a zavést všechny procesy na nejvyšší úroveň zároveň
- [x] Stanovit cílovou zralost podle potřeb businessu a dosahovat ji po přírůstcích
- [ ] Vzdát se cílů zralosti a soustředit se jen na dodávky projektů
- [ ] Najmout externí poradce, kteří nejvyšší úroveň zavedou místo vlastních architektů

> Cílová zralost má odpovídat potřebám podniku a budovat se postupně, protože skok přes několik úrovní najednou organizace nevstřebá. Plošné zavedení všeho najednou i najmutí externího týmu přehlížejí změnu v lidech a procesech a rezignace na cíle ponechává praxi nízce zralou.

### ? Architekt nastoupil do pojišťovny, kde už několik let funguje skupina architektů se svými zvyklostmi. Chce okamžitě navrhnout nové governance procesy a šablony, aniž by zjišťoval, co z dosavadní praxe funguje a co ne. Kolegové upozorňují, že část současných postupů je osvědčená. Co by měl udělat nejdřív?

- [ ] Zavést nové procesy hned a nechat osvědčené postupy časem vytlačit
- [ ] Převzít současné postupy beze změny, aby nevznikl odpor architektů
- [x] Posoudit současnou zralost kapability a použít ji jako výchozí stav pro návrh
- [ ] Požádat Architecture Board o schválení šablon převzatých ze standardu bez úprav

> Posouzení současné zralosti ukáže, co funguje a kde jsou skutečné mezery, a je výchozím stavem pro návrh cílové kapability. Zavádět vše nové zahazuje osvědčené postupy, převzít vše beze změny ignoruje mezery a šablony bez úprav nereflektují situaci pojišťovny.

## Budování kapability jako vlastní architektonický úkol {#kapabilita-adm .explain}

Zřízení nebo zásadní rozvoj architektonické kapability je samo o sobě změnou podniku, a standard proto doporučuje řídit ho stejně jako jiné architektonické úsilí — **s pomocí kroků ADM**. Nejdřív vize a mandát kapability, pak popis výchozího a cílového stavu (organizace, procesy, role, nástroje, governance), analýza mezer a plán postupného zavedení v přírůstcích. Zavedení se sleduje a vyhodnocuje a podle zkušeností upravuje. Kapabilita se tak buduje plánovitě, ne nahodilým zaváděním jednotlivých nástrojů a procesů.

*Příklad:* Plán zřízení EA praxe má tři etapy: v první principy, Board a šablony; ve druhé repozitář a napojení na portfolio; ve třetí měření přínosů architektury.

### ? Vedení energetické společnosti schválilo zřízení architektonické funkce a chce od hlavního architekta dvouletý plán jejího vybudování. Architekt zvažuje, jak plán sestavit, aby byl obhajitelný a dal se průběžně kontrolovat. Jaký přístup je nejvhodnější?

- [ ] Zavádět jednotlivé nástroje a procesy podle toho, jak o ně budou projekty žádat
- [ ] Převzít plán zavedení od dodavatele EA nástroje, který firma plánuje koupit
- [ ] Nejprve dva roky popisovat všechny architektury a kapabilitu zavést potom
- [x] Řídit zřízení kapability kroky ADM: vize, výchozí a cílový stav, mezery a etapy

> Standard doporučuje budovat architektonickou kapabilitu jako vlastní architektonické úsilí s využitím kroků ADM, což dává obhajitelný a kontrolovatelný plán. Zavádění na vyžádání je nahodilé, plán od dodavatele nástroje se soustředí na nástroj místo na organizaci a odklad kapability za tvorbu architektur obrací logické pořadí.

## Kdy se k Preliminary Phase vrátit {#navrat-prelim .explain}

Preliminary Phase není jednorázová, ale ani se neopakuje s každým projektem. Návrat k ní má smysl, když se **mění samotná architektonická kapabilita nebo její kontext**: fúze či akvizice, zásadní reorganizace, nová strategie řízení podniku, opakované selhávání governance nebo zjištění, že principy a rámec už neodpovídají potřebám. Podnět často přichází z Phase H, když změna přesahuje běžné řízení architektury. Drobné úpravy standardů či šablon se řeší běžnými procesy governance, ne novým Preliminary.

*Příklad:* Po akvizici konkurenta se slučují dva architektonické týmy s odlišnými principy a repozitáři — nejdřív se sjednotí rozsah, principy, governance a organizace, teprve pak se spouštějí nové architektonické projekty.

### ? Dvě regionální banky se sloučily. Každá měla vlastní architektonický tým, odlišné architektonické principy, jiný Architecture Board a jiný repozitář. Nové vedení už požaduje první společné architektonické projekty. Co je nejlepší další krok hlavního architekta?

- [ ] Zahájit první společný projekt ve Phase A a principy obou bank používat podle potřeby
- [ ] Ponechat oba týmy a rámce beze změny a sjednotit je až po dokončení projektů
- [x] Vrátit se k Preliminary Phase a sjednotit principy, governance, repozitář a tým
- [ ] Převzít bez posouzení rámec větší banky a menší banku do něj začlenit

> Fúze mění samotnou architektonickou kapabilitu a její kontext, a proto je třeba nejdřív v Preliminary Phase sjednotit principy, governance, tým a repozitář. Projekty nad dvěma odlišnými rámci by vedly k rozporným rozhodnutím a převzetí rámce větší banky bez posouzení přehlíží, co mohla menší banka dělat lépe.

### ? Výrobní firma má zavedenou EA praxi se schválenými principy, Architecture Board i repozitářem. Které z následujících situací je nejlépe řešit návratem k Preliminary Phase?

- [ ] Do knihovny standardů je třeba doplnit novou verzi podporovaného serverového operačního systému
- [ ] Projekt potřebuje výjimku z jednoho technologického standardu kvůli dodavateli
- [ ] Architekti chtějí upravit šablonu Architecture Definition Document o jednu sekci
- [x] Firma přechází z centrálního řízení na samostatné divize s vlastním IT a rozpočtem

> Přechod na divizní model mění organizaci, rozsah i governance architektury, a proto vyžaduje přepracovat výsledky Preliminary Phase. Aktualizace standardu, výjimka i úprava šablony jsou běžné záležitosti governance a správy repozitáře, které novou Preliminary Phase nepotřebují.
