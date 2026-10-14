---
kind: topic
subject: aplikace-podnikove-informatiky
slug: aplikace-elektronickeho-podnikani-ebusiness
name: "Aplikace elektronického podnikání (eBusiness)"
order: 7
---

Vymezení možností a rozdílů jednotlivých typů aplikací elektronického podnikání (elektronický obchod, elektronické zásobování, elektronická tržiště) - hlavní principy, dopady aplikací a technologií elektronického podnikání do řízení firmy, efekty, přístupy k implementaci, přehled hlavních produktů na ICT trhu.

## eBusiness × eCommerce {#ebusiness-ecommerce .compare}

Oba pojmy označují využití internetu a ICT v podnikání, liší se šíří záběru. Aplikace eBusinessu proto zahrnují nejen prodej, ale i nákup a spolupráci s partnery.

| | eCommerce (elektronický obchod) | eBusiness (elektronické podnikání) |
|---|---|---|
| Rozsah | nákup a prodej zboží a služeb elektronickou cestou | elektronizace všech podnikových procesů a vztahů |
| Typické aplikace | e-shop, online objednávka, elektronická platba | eCommerce + elektronické zásobování, e-tržiště, spolupráce s dodavateli, CRM, interní procesy |
| Vzájemný vztah | je součástí eBusinessu | širší pojem, který eCommerce zahrnuje |

### ? Firma sdílí s dodavateli plán zásob, elektronicky schvaluje nákupní objednávky a provozuje e-shop. Která z těchto činností je eCommerce v užším smyslu?

- [ ] Sdílení plánu zásob s dodavateli
- [ ] Elektronické schvalování objednávek
- [x] Prodej zboží zákazníkům přes e-shop
- [ ] Sdílení technické dokumentace s partnery

> eCommerce se týká elektronického nákupu a prodeje, zde tedy e-shopu. Spolupráce s dodavateli a interní schvalování patří do širšího eBusinessu.

### ? Které tvrzení o vztahu eBusinessu a eCommerce je správné?

- [x] eCommerce je součástí širšího eBusinessu
- [ ] eBusiness je jen B2B obdobou eCommerce
- [ ] Oba pojmy označují výhradně prodej přes e-shop
- [ ] eCommerce zahrnuje i všechny interní procesy

> eBusiness pokrývá elektronizaci všech podnikových procesů a vztahů; eCommerce (elektronický nákup a prodej) je jeho součástí.

## Modely B2B, B2C, C2C a B2G {#modely-b2b-b2c .compare}

Modely se rozlišují podle toho, kdo s kým obchoduje; liší se i nároky na aplikace.

| Model | Kdo s kým | Typické aplikace | Specifika |
|---|---|---|---|
| B2B | firma s firmou | B2B e-shop/portál, eProcurement, e-tržiště, EDI | velké a opakované objednávky, smluvní ceny, platba na fakturu, integrace s ERP |
| B2C | firma se spotřebitelem | e-shop | mnoho malých objednávek, platba předem či při převzetí, marketing, ochrana spotřebitele |
| C2C | spotřebitel se spotřebitelem přes platformu | inzertní a aukční portály | provozovatel obchod jen zprostředkuje |
| B2G | firma s veřejnou správou | elektronické nástroje pro veřejné zakázky, elektronická podání | formalizované postupy stanovené předpisy |

### ? Dodavatel kancelářského nábytku podává nabídku do veřejné zakázky města přes elektronický nástroj pro zadávání veřejných zakázek. O jaký model jde?

- [ ] B2B
- [ ] C2C
- [ ] B2C
- [x] B2G

> Druhou stranou transakce je veřejná správa (město), jde tedy o model business-to-government.

### ? Čím se B2B elektronický obchod typicky liší od B2C?

- [ ] Menšími objemy jednotlivých objednávek
- [x] Smluvními cenami a platbou na fakturu
- [ ] Platbou vždy předem platební kartou
- [ ] Tím, že nevyžaduje napojení na ERP

> V B2B obchodují firmy na základě smluv — mají individuální ceny, objednávají ve velkých objemech a platí na fakturu se splatností. Integrace s ERP je v B2B naopak velmi důležitá.

## Typy aplikací eBusinessu {#typy-aplikaci-ebusiness .compare}

Tři hlavní typy aplikací se liší tím, kdo je provozuje a kolik stran propojují.

| | Elektronický obchod (e-shop) | Elektronické zásobování (eProcurement) | Elektronické tržiště (eMarketplace) |
|---|---|---|---|
| Strana | prodávající (*sell-side*) | kupující (*buy-side*) | prostředník mezi stranami |
| Vztah | jeden prodávající — mnoho kupujících | jeden kupující — mnoho dodavatelů | mnoho kupujících — mnoho prodávajících |
| Cíl | prodat, získat zákazníky | zlevnit a zrychlit nákup | zprostředkovat obchod, zvýšit konkurenci |
| Příklad | internetový obchod s elektronikou | nákupní systém výrobce aut | oborové B2B tržiště, online tržiště pro spotřebitele |

### ? Velký výrobce provozuje systém, v němž jeho nákupčí poptávají materiál u desítek dodavatelů a schvalují objednávky. O jaký typ aplikace jde?

- [x] Elektronické zásobování (eProcurement)
- [ ] Elektronický obchod (e-shop)
- [ ] Nezávislé elektronické tržiště
- [ ] Elektronický katalog prodávajícího dodavatele

> Systém provozuje kupující a slouží jeho nákupu od mnoha dodavatelů — jde o buy-side řešení, tedy eProcurement.

### ? Která aplikace eBusinessu propojuje MNOHO kupujících s MNOHA prodávajícími?

- [ ] Elektronický obchod (e-shop)
- [ ] Elektronické zásobování
- [ ] Firemní intranet
- [x] Elektronické tržiště

> Elektronické tržiště je místo setkání mnoha kupujících a mnoha prodávajících. E-shop má jednoho prodávajícího, eProcurement jednoho kupujícího.

## Funkce elektronického obchodu {#funkce-eshopu .explain}

Elektronický obchod (e-shop) je aplikace prodávajícího, v níž si zákazník sám vybere, objedná a zaplatí zboží nebo službu. Skládá se ze dvou částí:

- **front office** (část pro zákazníky) — **katalog produktů** (kategorie, vyhledávání, filtry, popisy, ceny, dostupnost), **nákupní košík**, **objednávka** s volbou dopravy a platby, **zákaznický účet** (historie nákupů, sledování objednávky), doporučování a personalizace,
- **back office** (správa) — správa sortimentu a cen, zpracování a expedice objednávek, skladové zásoby, fakturace, správa zákazníků, marketingové nástroje (slevové kódy, newslettery) a reporty.

*Příklad:* Knihkupectví v e-shopu doporučuje tituly podle předchozích nákupů zákazníka. Pracovníci v back office zatím doplňují nové knihy do katalogu a připravují objednávky k odeslání.

### ? Zákazník si v e-shopu postupně vybírá zboží a odkládá si ho, aby vše objednal a zaplatil najednou. Kterou funkci e-shopu využívá?

- [ ] Katalog produktů
- [ ] Zákaznický účet
- [x] Nákupní košík
- [ ] Platební bránu

> Nákupní košík shromažďuje vybrané zboží až do dokončení objednávky. Katalog slouží k výběru, platební brána k zaplacení.

### ? Která funkce patří do back office e-shopu, a NE do části určené zákazníkům?

- [ ] Vyhledávání a filtry v katalogu
- [ ] Nákupní košík a objednávka
- [ ] Sledování stavu objednávky
- [x] Správa sortimentu a cen

> Back office slouží pracovníkům prodávajícího ke správě sortimentu, cen, objednávek a zákazníků. Vyhledávání, košík i sledování objednávky využívá zákazník ve front office.

## Platby a logistika v e-shopu {#platby-logistika .explain}

Úspěch e-shopu nezávisí jen na webu, ale i na **platbách** a **doručení**:

- **platby** — platební karta přes **platební bránu** (zprostředkuje ověření a provedení platby u banky, e-shop sám údaje o kartách nezpracovává), online bankovní převod, platební tlačítka a digitální peněženky, dobírka, v B2B platba na fakturu,
- **logistika** — sklad a vychystání objednávek, napojení na přepravce (přepravní štítky, sledování zásilky), doručení na adresu, výdejní místa a boxy; část firem logistiku svěřuje externímu poskytovateli (*fulfillment*),
- **vratky** — spotřebitel může od smlouvy uzavřené na dálku odstoupit do 14 dnů, e-shop proto musí zvládat i zpětnou logistiku a vracení peněz.

*Příklad:* Malý e-shop s hračkami přijímá karty přes platební bránu, zásilky posílá přes dva přepravce s výdejními místy a vrácené zboží zpracovává podle jednotného postupu.

### ? Jakou úlohu má platební brána v e-shopu?

- [x] Zprostředkuje ověření a provedení platby kartou
- [ ] Vystavuje daňové doklady a vede účetnictví e-shopu
- [ ] Vybírá přepravce a tiskne přepravní štítky
- [ ] Spravuje ceny a slevové akce v katalogu

> Platební brána propojuje e-shop s bankou a zajišťuje bezpečné ověření a provedení platby. E-shop díky ní nemusí sám zpracovávat citlivé údaje o kartách.

### ? Proč musí e-shop prodávající spotřebitelům počítat s procesem vratek (zpětnou logistikou)?

- [ ] E-shop musí přijmout vrácené zboží bez omezení lhůty
- [x] Spotřebitel může od nákupu na dálku odstoupit do 14 dnů
- [ ] Platební brány podmiňují platbu možností vrácení
- [ ] Přepravci nepřevezmou zásilku bez možnosti vratky

> Spotřebitel má u smlouvy uzavřené na dálku právo odstoupit bez udání důvodu ve lhůtě 14 dnů. E-shop proto musí zvládat příjem vráceného zboží i vracení peněz.

## B2C × B2B e-shop {#b2c-vs-b2b-eshop .compare}

Elektronický obchod pro firemní zákazníky (často nazývaný B2B portál) má jiné funkce než e-shop pro spotřebitele.

| | B2C e-shop | B2B e-shop (portál) |
|---|---|---|
| Ceny | jednotný veřejný ceník, akce | individuální ceníky a smluvní slevy po přihlášení |
| Objednávky | jednorázové, menší | opakované, velké, rychlé zadání podle kódů zboží nebo importem |
| Platba | předem, kartou, dobírkou | na fakturu se splatností, kreditní limit |
| Uživatelé | jeden zákazník = jeden účet | více uživatelů jednoho odběratele, schvalování objednávek |
| Integrace | ERP prodávajícího | ERP prodávajícího i systémy kupujícího (punch-out, EDI) |

### ? Velkoobchod chce, aby každý odběratel po přihlášení viděl své smluvní ceny a kreditní limit a mohl rychle objednávat podle kódů zboží. Jaké řešení potřebuje?

- [ ] B2C e-shop s jednotným ceníkem
- [ ] Horizontální elektronické tržiště
- [x] B2B e-shop (zákaznický portál)
- [ ] Elektronickou reverzní aukci

> Individuální ceny, kreditní limity a rychlé opakované objednávky jsou typické funkce B2B e-shopu. B2C e-shop má jednotný ceník pro všechny.

## Elektronické zásobování (eProcurement) {#eprocurement .term}

Aplikace na straně **kupujícího** (*buy-side*), která elektronizuje nákupní proces — od **požadavku** přes výběr dodavatele, **objednávku** a **schválení** až po příjem zboží a **párování faktury** s objednávkou (celý cyklus *procure-to-pay*). Je napojena na ERP kupujícího a využívá elektronické katalogy, poptávky (e-RFx), e-aukce a schvalovací workflow.

### ? Kdo typicky provozuje systém eProcurement a k jakému účelu?

- [ ] Prodávající, aby získal nové zákazníky
- [ ] Nezávislý operátor, aby propojil celé odvětví
- [ ] Banka, aby zprostředkovala platby za zboží
- [x] Kupující, aby zefektivnil vlastní nákup

> eProcurement je buy-side aplikace — provozuje ji kupující firma a slouží k zrychlení, zlevnění a kontrole jejího nákupu.

### ? Která činnost NEPATŘÍ do procesu, který pokrývá eProcurement?

- [x] Prezentace sortimentu koncovým spotřebitelům
- [ ] Schválení požadavku na nákup
- [ ] Výběr dodavatele a odeslání objednávky
- [ ] Párování faktury s objednávkou a příjemkou

> eProcurement pokrývá nákupní proces kupující firmy od požadavku po fakturu. Prezentace sortimentu spotřebitelům je úlohou e-shopu prodávajícího.

## Nástroje elektronického zásobování {#nastroje-eprocurement .explain}

Systémy eProcurement obvykle nabízejí:

- **elektronické katalogy** schválených dodavatelů se smluvními cenami — zaměstnanci si běžné položky objednají sami,
- **e-RFx** — elektronické poptávky (žádosti o informace, návrh řešení, cenovou nabídku),
- **elektronické aukce** — soutěž dodavatelů o cenu v reálném čase,
- **schvalovací workflow** — automatické směrování požadavků ke schválení podle částky, útvaru či kategorie,
- **správu dodavatelů a smluv** a **analýzu výdajů** (kolik, u koho a za co firma utrácí).

Elektronické katalogy omezují **nákupy mimo smlouvy** (*maverick buying*), kdy zaměstnanci nakupují u libovolných obchodníků za horších podmínek. eProcurement se často nejdřív zavádí pro **nepřímý materiál** (kancelářské potřeby, IT vybavení, údržba).

*Příklad:* Nemocnice zavedla katalog smluvních dodavatelů spotřebního materiálu. Oddělení objednávají sama, požadavky nad stanovený limit schvaluje vedoucí a nákup se soustředí na vyjednávání rámcových smluv.

### ? Firma chce, aby každý nákupní požadavek nad 50 000 Kč automaticky putoval ke schválení vedoucímu útvaru a poté finančnímu řediteli. Kterou funkci eProcurement využije?

- [ ] Elektronickou reverzní aukci
- [x] Schvalovací workflow
- [ ] Elektronický katalog dodavatele
- [ ] Analýzu výdajů podle kategorií

> Schvalovací workflow automaticky směruje požadavky ke schválení podle pravidel, například podle částky a útvaru.

### ? Zaměstnanci nakupovali kancelářské potřeby u libovolných obchodů mimo uzavřené rámcové smlouvy. Jak tento problém řeší eProcurement?

- [ ] Úplně zakáže nákup kancelářských potřeb
- [ ] Přesune nákup na spotřebitelská tržiště
- [x] Nabídne katalogy jen smluvních dodavatelů
- [ ] Nahradí rámcové smlouvy jednorázovými aukcemi

> Katalogy schválených dodavatelů se smluvními cenami usměrňují nákup do rámcových smluv a omezují nákupy mimo smlouvy (maverick buying).

## Interní e-katalog × punch-out katalog {#e-katalogy .compare}

Elektronické katalogy dodavatelů lze do nákupního systému kupujícího zapojit dvěma způsoby.

| | Interní (statický) e-katalog | Punch-out katalog |
|---|---|---|
| Kde je obsah | nahraný v systému kupujícího | na webu (v e-shopu) dodavatele |
| Jak se nakupuje | výběr přímo v nákupním systému | přechod na web dodavatele, košík se vrátí do systému kupujícího |
| Aktualizace cen a dostupnosti | dodavatel posílá nové verze katalogu | průběžně spravuje dodavatel |
| Výhoda | kupující má obsah plně pod kontrolou | aktuální data, vhodné pro velký a proměnlivý sortiment |

### ? Nákupčí klikne v nákupním systému své firmy na odkaz dodavatele, naplní košík přímo na jeho webu a obsah košíku se vrátí do firemního systému ke schválení. O jaké řešení jde?

- [ ] Interní elektronický katalog
- [ ] Elektronická reverzní aukce
- [ ] Žádost o informace (RFI)
- [x] Punch-out katalog

> Punch-out katalog přesměruje uživatele do e-shopu dodavatele a vybraný košík vrátí do systému kupujícího, kde pokračuje schválení a objednávka.

### ? Jaká je hlavní výhoda punch-out katalogu oproti internímu e-katalogu kupujícího?

- [x] Ceny a dostupnost spravuje přímo dodavatel
- [ ] Kupující má celý obsah katalogu pod úplnou kontrolou
- [ ] Nákup nevyžaduje připojení k systému dodavatele
- [ ] Objednávky nemusí projít schvalovacím workflow

> U punch-out katalogu zůstává obsah na straně dodavatele, takže ceny a dostupnost jsou vždy aktuální. Úplnou kontrolu nad obsahem dává naopak interní katalog.

## e-RFx: RFI, RFP a RFQ {#e-rfx .compare}

**e-RFx** je souhrnné označení elektronických poptávkových dokumentů, které kupující rozesílá dodavatelům.

| | RFI (Request for Information) | RFP (Request for Proposal) | RFQ (Request for Quotation) |
|---|---|---|---|
| Česky | žádost o informace | žádost o návrh řešení | žádost o cenovou nabídku |
| Účel | zmapovat trh a schopnosti dodavatelů | získat návrhy řešení složitější potřeby | porovnat ceny přesně specifikované položky |
| Kdy | na začátku, potřeba ještě není přesně známa | potřeba je známa, řešení ne | specifikace je jasná, rozhoduje cena a podmínky |

### ? Firma přesně ví, kolik kusů standardních šroubů dané normy potřebuje, a chce od dodavatelů jen ceny a dodací lhůty. Kterou žádost použije?

- [ ] RFI
- [x] RFQ
- [ ] RFP
- [ ] Punch-out

> RFQ (žádost o cenovou nabídku) se používá pro přesně specifikované položky, kde se porovnávají ceny a podmínky dodání.

### ? Firma teprve zjišťuje, kteří dodavatelé vůbec umějí dodat řešení pro automatizaci skladu a jaké mají zkušenosti. Kterou žádost rozešle?

- [ ] RFQ
- [ ] RFP
- [x] RFI
- [ ] Objednávku

> RFI (žádost o informace) slouží k počátečnímu zmapování trhu a schopností dodavatelů. Návrh řešení (RFP) nebo cenu (RFQ) firma žádá až později.

## Elektronická reverzní aukce {#reverzni-aukce .term}

Elektronická (nákupní) aukce, v níž **kupující** vyhlásí poptávku s přesnými parametry a **dodavatelé v reálném čase snižují své nabídkové ceny**; vidí přitom své pořadí nebo nejlepší nabídku. Hodí se pro **standardizované položky** se srovnatelnými parametry a dostatečným počtem dodavatelů (materiál, energie, běžné služby). Riziko představuje tlak na marže a zhoršení vztahů s dodavateli.

### ? Čím se reverzní (nákupní) e-aukce liší od klasické prodejní aukce?

- [ ] Kupující v ní přihazují vyšší ceny za zboží jednoho prodávajícího
- [ ] Cenu v ní předem pevně stanoví prodávající a nelze ji měnit
- [ ] Probíhá vždy jen v jednom kole formou e-mailových nabídek
- [x] Dodavatelé v ní soutěží snižováním ceny pro jednoho kupujícího

> V reverzní aukci jde cena dolů — dodavatelé se předhánějí v nižších nabídkách pro jednoho kupujícího. V klasické aukci naopak kupující přihazují a cena roste.

### ? Pro který nákup je reverzní e-aukce NEJMÉNĚ vhodná?

- [x] Vývoj unikátního zařízení, které umí jen jeden dodavatel
- [ ] Kancelářský papír v přesně dané specifikaci a gramáži
- [ ] Elektrická energie pro všechny provozovny firmy
- [ ] Ocelové plechy podle technické normy

> Aukce potřebuje srovnatelné nabídky a více soutěžících dodavatelů. U unikátního plnění s jediným dodavatelem není kdo by soutěžil.

## Elektronické tržiště (eMarketplace) {#e-trziste .term}

Internetová platforma, na které se setkává **mnoho kupujících s mnoha prodávajícími**. Provozovatel nabízí společné katalogy, poptávky, aukce a srovnání nabídek, případně i platby, logistiku a hodnocení účastníků. Na rozdíl od e-shopu (jeden prodávající) a eProcurement (jeden kupující) je tržiště prostředníkem. Provozovatel vydělává hlavně na **provizích z obchodů, členských poplatcích a reklamě**.

### ? Jak typicky vydělává provozovatel nezávislého elektronického tržiště?

- [ ] Marží z prodeje vlastních zásob zboží
- [x] Provizemi a poplatky od účastníků
- [ ] Úsporami ve vlastním nákupu materiálu
- [ ] Prodejem licencí ERP účastníkům tržiště

> Nezávislé tržiště zprostředkovává obchod mezi jinými stranami a příjmy má z provizí, členských poplatků a reklamy.

### ? Výrobce elektroniky začne kromě vlastního e-shopu nabízet zboží i na online platformě, kde prodávají stovky dalších obchodníků. Co pro něj na tržišti platí?

- [ ] Platí stejná pravidla jako ve vlastním e-shopu
- [ ] Sám určuje pravidla a poplatky celého tržiště
- [x] Je jedním z mnoha prodávajících vedle konkurence
- [ ] Tržiště nahradí jeho skladový a účetní systém

> Na tržišti se firma stává jedním z mnoha prodávajících, soutěží přímo s ostatními a řídí se pravidly provozovatele. Ve vlastním e-shopu určuje pravidla sama.

## Horizontální × vertikální tržiště {#horizontalni-vertikalni .compare}

Tržiště se dělí podle toho, zda slouží jednomu odvětví, nebo nabízí položky potřebné napříč obory.

| | Horizontální tržiště | Vertikální tržiště |
|---|---|---|
| Zaměření | zboží a služby potřebné firmám napříč odvětvími | jedno odvětví s jeho specifickými položkami |
| Typické položky | kancelářské potřeby, IT, energie, přeprava, údržba a provozní materiál (MRO) | suroviny a komponenty oboru (chemie, ocel, automobilový průmysl, zemědělství) |
| Přidaná hodnota | velký počet účastníků, standardizované zboží | oborové katalogy, specifikace a znalost trhu |

### ? Tržiště sdružuje dodavatele a odběratele chemických surovin a nabízí oborové katalogy a technické specifikace. O jaký typ tržiště jde?

- [ ] Horizontální tržiště
- [ ] Spotřebitelské C2C tržiště
- [ ] Interní katalog kupujícího
- [x] Vertikální tržiště

> Tržiště zaměřené na jedno odvětví (zde chemii) s oborovými katalogy je vertikální. Horizontální tržiště nabízí stejnou kategorii zboží firmám z různých oborů.

### ? Které zboží se typicky obchoduje na horizontálním e-tržišti?

- [x] Kancelářské potřeby, IT vybavení a služby údržby
- [ ] Speciální komponenty pro letecký průmysl
- [ ] Léčiva pro nemocniční lékárny
- [ ] Surovinové vstupy pro chemickou výrobu

> Horizontální tržiště nabízí položky, které potřebují firmy napříč odvětvími (provozní materiál, IT, služby). Oborově specifické vstupy patří na vertikální tržiště.

## Nezávislé, konsorciální a soukromé tržiště {#vlastnictvi-trzist .compare}

Tržiště se dělí i podle toho, kdo je provozuje — to ovlivňuje jeho neutralitu.

| | Nezávislé (neutrální) | Konsorciální | Soukromé |
|---|---|---|---|
| Provozovatel | třetí strana mimo obchodující firmy | skupina velkých firem z odvětví | jedna velká firma |
| Účastníci | kdokoli splní podmínky | zakladatelé a jejich dodavatelé či odběratelé | vybraní dodavatelé nebo odběratelé provozovatele |
| Výhoda | neutralita, mnoho účastníků | sdílení nákladů, velký objem obchodů hned od začátku | plná kontrola nad pravidly a procesy |
| Riziko | obtížně získává kritické množství účastníků | dominance silných zakladatelů, soutěžněprávní otázky | pravidla ve prospěch provozovatele, menší otevřenost |

### ? Tři největší výrobci v odvětví společně založí platformu, přes kterou budou nakupovat od svých dodavatelů. O jaký typ tržiště jde?

- [ ] Nezávislé (neutrální) tržiště
- [x] Konsorciální tržiště
- [ ] Soukromé tržiště
- [ ] Horizontální tržiště

> Tržiště založené a provozované skupinou firem z odvětví je konsorciální. Soukromé tržiště provozuje jediná firma, nezávislé třetí strana.

### ? Jakého rizika se obávají dodavatelé u soukromého tržiště, které provozuje jediný velký odběratel?

- [ ] Tržiště nesmí využívat elektronické aukce
- [ ] Provozovatel nemá zájem přes tržiště nakupovat
- [x] Pravidla mohou zvýhodňovat provozovatele
- [ ] Dodavatelé nemohou zveřejňovat své katalogy

> Soukromé tržiště plně kontroluje jeho provozovatel, a pravidla i podmínky proto mohou zvýhodňovat jeho a ne dodavatele.

## Dopady eBusinessu do řízení firmy {#dopady-do-rizeni .explain}

Aplikace a technologie eBusinessu mění řízení firmy v několika oblastech:

- **procesy** — nepřetržitý provoz (24/7), rychlejší vyřízení objednávek, automatizace rutinních kroků nákupu a prodeje,
- **organizace a role** — nové činnosti (správa e-shopu a obsahu, online marketing, analýza dat); nákup se přesouvá od operativního objednávání k vyjednávání smluv a řízení dodavatelů,
- **obchodní kanály** — **disintermediace** (vynechání zprostředkovatelů, např. přímý prodej výrobce zákazníkům) a vznik nových online prostředníků (tržiště, srovnávače); hrozí **konflikt kanálů** se stávajícími distributory,
- **trh a ceny** — vyšší transparentnost cen a snadné srovnání nabídek zvyšují tlak na ceny,
- **rozhodování podle dat** — analýza chování zákazníků a nákupních výdajů,
- **technologie, bezpečnost a právo** — integrace s ERP, kybernetická bezpečnost, ochrana osobních údajů (GDPR) a spotřebitele.

*Příklad:* Výrobce kol spustil přímý prodej přes vlastní e-shop. Získal data o zákaznících a vyšší marži, ale musel nově nastavit podmínky pro své prodejce, kteří se obávali ztráty obchodu.

### ? Výrobce kol začne prodávat přímo koncovým zákazníkům přes vlastní e-shop a obejde tradiční velkoobchod. Jak se tento jev nazývá?

- [ ] Reintermediace
- [ ] Outsourcing prodeje
- [ ] Konsolidace dodavatelů
- [x] Disintermediace

> Disintermediace znamená vynechání zprostředkovatelů v obchodním řetězci díky přímému prodeji přes internet.

### ? Jaké riziko přináší výrobci zahájení přímého prodeje přes vlastní e-shop?

- [ ] Ztrátu přímého kontaktu se zákazníky
- [x] Konflikt s dosavadními prodejci a distributory
- [ ] Nemožnost sbírat data o nákupech zákazníků
- [ ] Nižší dostupnost nabídky mimo pracovní dobu

> Přímý prodej konkuruje dosavadním obchodním partnerům, kteří mohou výrobce omezit nebo přestat prodávat jeho zboží (konflikt kanálů). Kontakt se zákazníky a data naopak výrobce získá.

### ? Firma zavedla eProcurement a běžné objednávky si zaměstnanci zadávají sami z katalogů. Jak se typicky mění role útvaru nákupu?

- [ ] Ručně přepisuje všechny objednávky do ERP
- [ ] Zaniká, protože nákup už nikdo neřídí
- [x] Soustředí se na vyjednávání smluv a dodavatele
- [ ] Schvaluje osobně každou drobnou objednávku

> Operativní objednávání přebírají katalogy a workflow, nákup se proto může věnovat strategickým činnostem — výběru dodavatelů, vyjednávání a řízení smluv.

## Efekty aplikací eBusinessu {#efekty-ebusiness .explain}

**Přínosy pro prodávajícího:** nový prodejní kanál a přístup na vzdálené trhy, prodej 24/7, nižší náklady na zpracování objednávky, data o zákaznících pro marketing a personalizaci.

**Přínosy pro kupujícího:** nižší náklady a kratší doba zpracování nákupu, nižší ceny díky konkurenci a aukcím, dodržování smluv a přehled o výdajích, méně chyb z ručního přepisu.

**Rizika a náklady:** investice do řešení a jeho integrace, kybernetické útoky a únik dat, závislost na provozovateli platformy, odpor zaměstnanců a partnerů ke změně, tlak na ceny a marže, konflikt kanálů. Efekty se projeví jen při změně procesů, ne pouhým nasazením technologie.

*Příklad:* Distributor zdravotnického materiálu po zavedení B2B portálu zrušil ruční přepisování objednávek z e-mailů a faxů. Obchodníci se místo zadávání objednávek věnují péči o klíčové zákazníky.

### ? Který efekt je typickým PŘÍNOSEM elektronického zásobování pro kupující firmu?

- [ ] Vyšší počet ručně zpracovaných dokladů
- [x] Nižší náklady na zpracování objednávky
- [ ] Delší doba od požadavku k objednávce
- [ ] Vyšší podíl nákupů mimo rámcové smlouvy

> eProcurement automatizuje nákupní proces, takže zpracování objednávky je levnější a rychlejší a nákup se drží v rámci smluv.

### ? Co NENÍ typickým rizikem zavedení aplikací eBusinessu?

- [ ] Kybernetické útoky a únik dat
- [ ] Závislost na provozovateli platformy
- [ ] Odpor zaměstnanců a partnerů ke změně
- [x] Možnost obsluhovat zákazníky nepřetržitě

> Nepřetržitá dostupnost (24/7) je přínosem eBusinessu, nikoli rizikem. Ostatní možnosti jsou typická rizika.

## Přístupy k implementaci a produkty {#pristupy-implementace .compare}

Aplikaci eBusinessu lze vyvinout na míru, koupit jako software k vlastnímu provozu, nebo pronajmout jako službu (SaaS). Produkty v tabulce jsou jen obecně známé příklady.

| | Vlastní vývoj | Licencovaná / open source platforma | SaaS platforma |
|---|---|---|---|
| Počáteční náklady | vysoké | střední (licence, implementace, servery) | nízké, platí se předplatné |
| Rychlost spuštění | pomalá | střední | rychlá |
| Přizpůsobení | neomezené | velké (úpravy, rozšíření) | omezené na nastavení a doplňky |
| Provoz a aktualizace | vlastní IT nebo dodavatel | vlastní IT nebo partner | poskytovatel |
| Vhodné pro | jedinečné procesy tvořící konkurenční výhodu | střední a větší firmy s vlastními požadavky | malé a začínající firmy, standardní potřeby |
| Příklady | — | Magento Open Source (Adobe Commerce dnes převážně jako cloud) | Shoptet, Shopify; pro nákup SAP Ariba |

### ? Začínající obchod s kosmetikou chce do měsíce spustit e-shop bez vlastních serverů a programátorů. Který přístup je NEJVHODNĚJŠÍ?

- [x] Pronájem SaaS e-commerce platformy
- [ ] Vlastní vývoj e-shopu na míru
- [ ] Nákup licence a provoz na vlastních serverech
- [ ] Vybudování vlastního elektronického tržiště

> SaaS platforma se spouští rychle, nevyžaduje vlastní servery ani vývoj a provoz zajišťuje poskytovatel. Vývoj na míru je pomalý a drahý.

### ? Kdy je vlastní vývoj aplikace eBusinessu na míru nejvíce opodstatněný?

- [ ] Když firma potřebuje e-shop co nejrychleji a nejlevněji
- [ ] Když firma nemá vlastní IT ani rozpočet na vývoj
- [x] Když jedinečný proces tvoří konkurenční výhodu
- [ ] Když stačí standardní katalog, košík a platby

> Vývoj na míru se vyplatí tam, kde hotová řešení nepokryjí jedinečný proces, na kterém firma staví svou konkurenční výhodu. Pro standardní potřeby je výhodnější hotová platforma.

### ? Který produkt je příkladem cloudového řešení pro elektronické zásobování (eProcurement)?

- [ ] Shoptet
- [x] SAP Ariba
- [ ] Shopify
- [ ] Moodle

> SAP Ariba je cloudové řešení pro nákup a spolupráci s dodavateli. Shoptet a Shopify jsou platformy pro e-shopy, Moodle je systém pro řízení výuky (LMS).

## Integrace eBusinessu s ERP {#integrace-s-erp .explain}

Aplikace eBusinessu nefungují odděleně — data musí sdílet s **ERP**, aby se nic nepřepisovalo ručně:

- **z ERP do e-shopu** — produkty, ceny a zákaznické ceníky, skladová dostupnost, stav objednávky, faktury, saldo odběratele,
- **z e-shopu do ERP** — přijaté objednávky, údaje o zákaznících, přijaté platby,
- **u eProcurement** — objednávky, příjemky a faktury v ERP kupujícího, katalogy a potvrzení od dodavatelů.

Propojení se řeší přes **API**, hotové **konektory** (doplňky) platformy, integrační platformu, případně dávkovými soubory; mezi firmami také přes **EDI**. Čím častější synchronizace (ideálně téměř v reálném čase), tím menší riziko prodeje zboží, které není skladem.

*Příklad:* Velkoobchod propojil B2B portál s ERP přes API. Odběratelé vidí aktuální zásoby a své ceny, objednávky se v ERP objeví hned a fakturu si stáhnou z portálu.

### ? E-shop prodal zboží, které už nebylo skladem, protože se dostupnost z ERP přenášela jen jednou týdně. Co je příčinou?

- [ ] Chybějící platební brána v e-shopu
- [ ] Příliš mnoho kategorií v katalogu
- [ ] Nepoužití reverzní aukce při nákupu
- [x] Příliš řídká synchronizace s ERP

> Skladová dostupnost se musí z ERP do e-shopu přenášet často, ideálně téměř v reálném čase. Týdenní přenos vede k prodeji zboží, které už není k dispozici.

### ? Který datový tok směřuje typicky z e-shopu DO ERP?

- [x] Přijaté objednávky a údaje o zákaznících
- [ ] Ceník a skladová dostupnost zboží
- [ ] Kmenová data produktů a jejich popisy
- [ ] Saldo a kreditní limit odběratele

> Objednávky a zákaznická data vznikají v e-shopu a předávají se do ERP ke zpracování. Ceny, zásoby, kmenová data i saldo vede ERP a e-shop je přebírá.
