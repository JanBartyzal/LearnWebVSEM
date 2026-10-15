---
kind: topic
subject: aplikace-podnikove-informatiky
slug: aplikace-ve-verejne-sprave
name: "Aplikace ve veřejné správě"
order: 12
---

eGovernment, informatizace veřejné správy. Kategorizace aplikací ve veřejné správě. Základní registry, CzechPOINT, datové schránky. Efekty aplikací veřejné správy.

## eGovernment {#egovernment .term}

**Elektronická veřejná správa (eGovernment)** je využití informačních a komunikačních technologií, zejména internetu, k výkonu veřejné správy a k poskytování jejích služeb občanům a firmám i ke komunikaci mezi úřady navzájem. Nejde jen o přenesení formulářů na web, ale o **změnu procesů** veřejné správy tak, aby se agendy vyřizovaly elektronicky a se sdílením dat mezi úřady.

### ? Co nejlépe vystihuje pojem eGovernment?

- [ ] Prodej státního majetku přes e-shopy soukromých firem
- [ ] Zavedení podnikového ERP systému na jednom ministerstvu
- [x] Využití ICT k výkonu a službám veřejné správy
- [ ] Zveřejňování tiskových zpráv úřadů na sociálních sítích

> eGovernment znamená elektronizaci výkonu veřejné správy a jejích služeb pro občany, firmy i jiné úřady. Samotný IS jednoho úřadu nebo komunikace na sítích jsou jen dílčí prvky.

## Vztahy G2C, G2B a G2G {#g2c-g2b-g2g .compare}

Aplikace eGovernmentu se člení podle toho, s kým veřejná správa elektronicky komunikuje. Vztah G2B je z pohledu firmy totéž, co model **B2G** (business-to-government) v elektronickém obchodě.

| Vztah | Kdo s kým | Příklad |
|---|---|---|
| **G2C** (government-to-citizen) | úřad s občanem | žádost podaná přes Portál občana, výpis z rejstříku trestů on-line |
| **G2B** (government-to-business) | úřad s firmou | elektronické podání daňových tvrzení, elektronické veřejné zakázky |
| **G2G** (government-to-government) | úřad s jiným úřadem | sdílení údajů ze základních registrů mezi úřady |

Někdy se doplňuje i **G2E** (government-to-employee) — vztah státu k vlastním zaměstnancům.

### ? Finanční úřad si aktuální údaje o podnikateli automaticky načte z registru vedeného jiným úřadem, aniž by se podnikatele ptal. Který vztah eGovernmentu to je?

- [x] G2G
- [ ] G2B
- [ ] G2C
- [ ] B2B

> Údaje si předávají dva orgány veřejné správy navzájem, jde tedy o vztah government-to-government. Podnikatel do výměny vůbec nevstupuje.

### ? Stavební firma podává elektronickou nabídku do veřejné zakázky ministerstva. Jak se tento vztah označuje z pohledu veřejné správy?

- [ ] G2C
- [ ] G2G
- [x] G2B
- [ ] C2C

> Úřad zde komunikuje s firmou, z pohledu státu jde o G2B. Z pohledu firmy se tentýž vztah označuje B2G.

## Informatizace veřejné správy {#informatizace-vs .explain}

**Informatizace veřejné správy** je soustavné zavádění ICT do činnosti úřadů spojené se změnou jejich procesů a legislativy. Hlavní cíle jsou:

- zpřístupnit služby **elektronicky, kdykoli a odkudkoli**,
- **snížit administrativní zátěž** občanů a firem (méně cest na úřad a méně dokládání),
- **zefektivnit práci úřadů** — sdílet data místo opakovaného sběru, omezit papír,
- zvýšit **kvalitu dat a transparentnost** veřejné správy.

Předpokladem je legislativa uznávající elektronické úkony, **sdílená infrastruktura** (základní registry, datové schránky, elektronická identifikace) a **interoperabilita** systémů různých úřadů. Rámec určují vládní strategie a koncepce digitalizace.

*Příklad:* Místo aby žadatel nosil na úřad výpis z obchodního rejstříku, úředník si údaje o firmě přečte sám ze sdíleného registru.

### ? Co NENÍ cílem informatizace veřejné správy?

- [ ] Snížení administrativní zátěže občanů a firem
- [ ] Sdílení dat mezi úřady místo opakovaného sběru
- [ ] Dostupnost služeb i mimo úřední hodiny
- [x] Převod formulářů do PDF beze změny procesů

> Informatizace má měnit procesy úřadů a umožnit sdílení dat. Pouhé převedení formulářů do elektronické podoby při zachování starého postupu přináší jen malý užitek.

## Digital by default a only once {#digital-by-default-only-once .compare}

Dva principy, na kterých stojí moderní eGovernment (prosazuje je mj. Evropská unie).

| | Digital by default (digitálně jako výchozí) | Only once (pouze jednou) |
|---|---|---|
| Podstata | služby se navrhují **primárně jako elektronické** | občan ani firma **nedokládají údaje, které už veřejná správa má** |
| Co to znamená pro občana | může vše vyřídit on-line, listinná cesta zůstává jako alternativa | údaj sdělí státu jen jednou, úřady si ho dál předávají samy |
| Předpoklad | elektronická identifikace, elektronické podání a doručování | sdílený datový fond (základní registry), propojení systémů úřadů |

V ČR se právo na digitální služby promítlo do zákona o právu na digitální služby (č. 12/2020 Sb.).

### ? Při žádosti o dávku úřad nechce od žadatele potvrzení o trvalém pobytu, protože si údaj zjistí z registru sám. Který princip uplatňuje?

- [ ] Digital by default
- [x] Only once
- [ ] Fikce doručení
- [ ] Autorizovaná konverze

> Princip only once znamená, že úřad nežádá údaje, které už veřejná správa má, a získá je sdílením dat. Digital by default se týká elektronické podoby služby, ne sdílení údajů.

### ? Ministerstvo navrhuje novou službu tak, že ji lze celou vyřídit on-line a listinné podání zůstane jen jako alternativa. Který princip uplatňuje?

- [ ] Only once
- [ ] Referenční údaj
- [ ] Jednotné kontaktní místo
- [x] Digital by default

> Digital by default znamená, že služba je primárně navržena jako elektronická. Listinná cesta se zachovává pro ty, kdo elektronicky komunikovat nemohou.

## Kategorizace aplikací ve veřejné správě {#kategorie-aplikaci-vs .compare}

Členění se v literatuře liší; běžně se rozlišují tyto skupiny aplikací.

| Kategorie | Účel | Příklady |
|---|---|---|
| **Agendové IS** | výkon konkrétní agendy svěřené úřadu zákonem | evidence obyvatel, registr vozidel, živnostenský rejstřík, daňové systémy |
| **Ekonomické IS** | rozpočet, účetnictví, majetek, mzdy úřadu | rozpočtový a účetní systém obce napojený na státní výkaznictví |
| **Spisová služba** (eSSL) | evidence, oběh, vyřízení a uložení dokumentů | elektronický podací deník, skartace dokumentů |
| **Portály** | jednotný přístup k informacím a službám | Portál veřejné správy, Portál občana, web obce |
| **Sdílené služby** | infrastruktura společná všem úřadům | základní registry, datové schránky, CzechPOINT, elektronická identifikace |

### ? Obecní úřad potřebuje evidovat došlou poštu, přidělovat ji referentům a vyřízené dokumenty uložit a později skartovat. Který typ aplikace k tomu slouží?

- [ ] Agendový informační systém
- [x] Elektronický systém spisové služby
- [ ] Ekonomický informační systém
- [ ] Portál veřejné správy

> Evidence, oběh, vyřízení, uložení a skartace dokumentů jsou úlohy spisové služby. Agendový IS slouží k výkonu konkrétní agendy, ekonomický IS k rozpočtu a účetnictví.

### ? Krajský úřad sestavuje rozpočet, vede účetnictví a eviduje svůj majetek. Do které kategorie aplikací patří systém, který k tomu používá?

- [ ] Agendové informační systémy
- [ ] Spisová služba
- [x] Ekonomické informační systémy
- [ ] Portály veřejné správy

> Rozpočet, účetnictví, majetek a mzdy úřadu pokrývají ekonomické IS. Agendové IS slouží k výkonu veřejné správy vůči občanům a firmám.

## Agendový informační systém {#agendovy-is .term}

Informační systém veřejné správy, který slouží k výkonu konkrétní **agendy** — ucelené oblasti působnosti, kterou zákon svěřuje orgánu veřejné moci (např. evidence obyvatel, evidence řidičů, živnostenské podnikání). Agendové systémy jsou vůči základním registrům v dvojí roli: jako **editoři** do nich zapisují změny referenčních údajů a zároveň z nich údaje **čtou**.

### ? Který systém je typickým příkladem agendového informačního systému?

- [x] Registr silničních vozidel
- [ ] Rozpočtový a účetní systém úřadu
- [ ] Elektronický podací deník úřadu
- [ ] Webový informační portál obce

> Registr vozidel slouží k výkonu konkrétní agendy svěřené zákonem. Účetní systém je ekonomický IS, podací deník patří ke spisové službě a web obce je portál.

## Spisová služba {#spisova-sluzba .explain}

**Spisová služba** zajišťuje řádnou správu dokumentů, které úřad (původce) přijme nebo vytvoří: **příjem a evidenci** (podací deník, číslo jednací), **rozdělování a oběh**, **vyřizování**, podepisování a odesílání, **ukládání** a nakonec **vyřazování ve skartačním řízení**, kde se oddělí archiválie k trvalému uložení od dokumentů ke zničení. Pravidla stanoví zákon o archivnictví a spisové službě (č. 499/2004 Sb.). **Elektronický systém spisové služby (eSSL)** tyto činnosti vykonává elektronicky a je napojen na datovou schránku úřadu, agendové systémy a archiv. Z pohledu ECM jde o specializovaný systém pro správu dokumentů s workflow, jehož pravidla určuje zákon.

*Příklad:* Žádost doručená do datové schránky obce se v eSSL automaticky zaeviduje, dostane číslo jednací a přijde referentovi. Po vyřízení se uloží a po uplynutí skartační lhůty projde skartačním řízením.

### ? Kterou činností končí ve spisové službě životní cyklus dokumentu?

- [ ] Autorizovanou konverzí dokumentu
- [ ] Fikcí doručení dokumentu
- [x] Vyřazením ve skartačním řízení
- [ ] Zápisem referenčního údaje

> Po uplynutí skartační lhůty se dokumenty vyřazují ve skartačním řízení — archiválie se předají archivu, ostatní se zničí.

## Základní registry {#zakladni-registry .explain}

**Systém základních registrů** (zákon o základních registrech, č. 111/2009 Sb., v provozu od roku 2012) je sdílený datový fond veřejné správy. Nejdůležitější údaje o osobách, adresách a úřadech se v něm vedou **jednou, centrálně a jako referenční**. Tvoří ho čtyři registry: **ROB** (obyvatel), **ROS** (osob), **RÚIAN** (územní identifikace, adres a nemovitostí) a **RPP** (práv a povinností). Registry propojuje **ISZR** a o ochranu osobních údajů se stará převodník identifikátorů **ORG**. Úřady údaje z registrů čtou a mění je jen oprávnění editoři, takže občan nemusí stejné údaje dokládat na každém úřadě.

*Příklad:* Když se člověk přestěhuje, změnu adresy zapíše ohlašovna do evidence obyvatel a nová adresa se promítne do ROB. Ostatní úřady pak pracují s novou adresou bez dalšího hlášení.

### ? Který registr NEPATŘÍ mezi čtyři základní registry?

- [ ] Registr obyvatel (ROB)
- [ ] Registr osob (ROS)
- [ ] Registr práv a povinností (RPP)
- [x] Obchodní rejstřík

> Základní registry jsou ROB, ROS, RÚIAN a RPP. Obchodní rejstřík je veřejný rejstřík vedený soudy; je zdrojem změn údajů v ROS, ale sám mezi základní registry nepatří.

## ROB, ROS, RÚIAN a RPP {#rob-ros-ruian-rpp .compare}

| Registr | Co obsahuje | Správce |
|---|---|---|
| **ROB** — registr obyvatel | údaje o **fyzických osobách** — občanech ČR a cizincích s povoleným pobytem (jméno, příjmení, datum narození, adresa místa pobytu, státní občanství…) | Ministerstvo vnitra |
| **ROS** — registr osob | údaje o **právnických osobách, podnikajících fyzických osobách** a orgánech veřejné moci (název, identifikační číslo osoby — IČO, sídlo, statutární orgán…) | Český statistický úřad |
| **RÚIAN** — registr územní identifikace, adres a nemovitostí | **územní prvky a adresy** — kraje, obce, katastrální území, ulice, parcely, stavební objekty, adresní místa | Český úřad zeměměřický a katastrální |
| **RPP** — registr práv a povinností | **agendy a orgány veřejné moci**, jejich působnost a **oprávnění k přístupu k údajům** v registrech | Ministerstvo vnitra |

### ? Akciová společnost přesune sídlo a změní složení představenstva. Ve kterém základním registru se změní referenční údaje o této firmě?

- [ ] ROB
- [x] ROS
- [ ] RÚIAN
- [ ] RPP

> Údaje o právnických osobách a podnikajících fyzických osobách vede registr osob (ROS). Samotné adresní místo sídla je vedeno v RÚIAN, ROS na něj jen odkazuje.

### ? Úřad potřebuje ověřit, že adresa uvedená v žádosti skutečně existuje, a zjistit, ke které stavbě a parcele patří. Který základní registr použije?

- [ ] ROB
- [ ] ROS
- [ ] RPP
- [x] RÚIAN

> Adresní místa, stavby a parcely vede registr územní identifikace, adres a nemovitostí (RÚIAN). ROB a ROS obsahují údaje o osobách.

### ? Systém základních registrů kontroluje, zda daný úřad smí při výkonu své agendy číst určité údaje o obyvatelích. Odkud tuto informaci bere?

- [x] Z registru práv a povinností (RPP)
- [ ] Z registru obyvatel (ROB)
- [ ] Z registru osob (ROS)
- [ ] Z registru územní identifikace (RÚIAN)

> RPP eviduje agendy, orgány veřejné moci a jejich oprávnění k údajům v registrech. Podle něj se řídí, kdo smí jaké údaje číst nebo měnit.

## Referenční údaj {#referencni-udaj .term}

Údaj vedený v základním registru a označený jako **referenční**. Považuje se za **správný, dokud se neprokáže opak**, a orgány veřejné moci jej mají využívat přímo z registru (ne jej znovu zjišťovat od občana). Měnit jej smí jen **editor** — úřad, který vede příslušnou agendu (např. ohlašovna v evidenci obyvatel, rejstříkový soud u obchodního rejstříku). Má-li jiný úřad pochybnost o správnosti údaje, oznámí ji editorovi.

### ? Co platí pro referenční údaj vedený v základním registru?

- [ ] Smí jej opravit každý úřad, který jej používá
- [x] Považuje se za správný, dokud se neprokáže opak
- [ ] Úřad jej musí ověřit čestným prohlášením občana
- [ ] Má jen informativní povahu a nelze o něj opřít rozhodnutí

> Referenční údaj je považován za správný, dokud se neprokáže opak, a úřady jej mají využívat. Měnit jej smí jen editor příslušné agendy.

### ? Kdo smí změnit referenční údaj v základním registru?

- [ ] Kterýkoli úřad, který údaj ve své agendě používá
- [ ] Sám občan přímým zápisem přes Portál občana
- [ ] Správce systému na základě žádosti kteréhokoli úřadu
- [x] Editor, tedy úřad vedoucí příslušnou agendu

> Referenční údaje zapisuje a mění jen editor — orgán, který vede agendu, z níž údaj pochází. Ostatní úřady mohou pouze upozornit na pochybnost o jeho správnosti.

## ISZR a převodník ORG {#iszr-org .explain}

**Informační systém základních registrů (ISZR)** propojuje registry navzájem i s agendovými systémy úřadů. Agendový systém se tedy nepřipojuje ke každému registru zvlášť, ale komunikuje přes ISZR, které **ověří oprávnění podle RPP** a přístupy zaznamenává. **Převodník identifikátorů fyzických osob (ORG)** chrání soukromí: fyzická osoba nemá ve všech agendách jeden společný identifikátor (jako rodné číslo), ale v každé agendě jiný **agendový identifikátor (AIFO)**. Propojit údaje o člověku mezi agendami lze jen přes ORG, který identifikátory převádí; úřady tak nemohou svévolně slučovat údaje z různých agend.

*Příklad:* Úřad práce a finanční úřad vedou tutéž osobu pod různými AIFO. Když si potřebují předat údaje, jde dotaz přes ISZR a ORG převede identifikátor jedné agendy na identifikátor druhé.

### ? Agendový systém úřadu potřebuje číst údaje z registru obyvatel i z registru osob. Jak se k nim připojí?

- [ ] Ke každému registru zvlášť přes jeho vlastní rozhraní
- [x] Přes ISZR, které ověří jeho oprávnění podle RPP
- [ ] Přes datovou schránku úřadu, kam mu registry posílají výpisy
- [ ] Přes kontaktní místo CzechPOINT na svém úřadě

> Přístup agendových systémů k registrům zprostředkuje ISZR. Kontroluje oprávnění evidovaná v RPP a přístupy zaznamenává.

### ? Proč mají fyzické osoby v každé agendě jiný agendový identifikátor (AIFO) a převod mezi nimi zajišťuje ORG?

- [x] Aby úřady nemohly volně propojovat údaje z agend
- [ ] Aby každý úřad mohl osobám přidělovat vlastní rodná čísla
- [ ] Aby se údaje o osobě nemusely vést v registru obyvatel
- [ ] Aby občan mohl mít v každé agendě jinou adresu pobytu

> Oddělené agendové identifikátory chrání soukromí — údaje z různých agend lze propojit jen řízeně přes převodník ORG, nikoli přes jeden univerzální identifikátor.

## CzechPOINT {#czechpoint .explain}

**CzechPOINT** (Český podací ověřovací informační národní terminál) je síť **kontaktních míst veřejné správy**, kde úředník asistovaně vyřídí pro občana nebo firmu úkony vůči státu bez ohledu na to, který úřad je věcně příslušný — princip „úřad na jednom místě". Kontaktní místa jsou zejména na obecních a krajských úřadech a na pobočkách České pošty, dále např. u notářů a Hospodářské komory. Typické služby jsou **ověřené výpisy z veřejných rejstříků a evidencí** (např. z rejstříku trestů, katastru nemovitostí, obchodního a živnostenského rejstříku, bodového hodnocení řidiče, ze základních registrů), **autorizovaná konverze dokumentů** a úkony související s **datovými schránkami** (např. žádost o zřízení). Přesný katalog služeb se postupně rozšiřuje.

*Příklad:* Podnikatel potřebuje do výběrového řízení výpis z rejstříku trestů a z obchodního rejstříku. Místo dvou cest na různé instituce zajde na poštu s CzechPOINT a odnese si oba výpisy.

### ? Jaký je hlavní princip kontaktních míst CzechPOINT?

- [ ] Občan na nich ověřuje svou elektronickou identitu
- [ ] Úřady přes ně spravují referenční údaje
- [x] Úkony vůči různým úřadům na jednom místě
- [ ] Doručují se přes ně datové zprávy firmám

> CzechPOINT je asistované kontaktní místo, kde lze vyřídit výpisy a další úkony bez ohledu na věcně příslušný úřad. Doručování zajišťují datové schránky, identifikaci NIA.

### ? Majitel nemovitosti nemá elektronickou identitu a potřebuje ověřený výpis z katastru nemovitostí. Kde jej nejsnáze získá?

- [ ] Ve spisové službě obecního úřadu
- [x] Na kontaktním místě CzechPOINT
- [ ] V registru práv a povinností
- [ ] V převodníku identifikátorů ORG

> Ověřené výpisy z katastru nemovitostí patří k typickým službám CzechPOINT. Ostatní možnosti jsou interní systémy úřadů, ne místa pro veřejnost.

## Autorizovaná konverze dokumentů {#autorizovana-konverze .term}

Převedení dokumentu z **listinné podoby do elektronické nebo naopak** tak, aby výsledný dokument měl **stejné právní účinky** jako původní. Provádí ji např. kontaktní místo veřejné správy (CzechPOINT), úřad, notář či advokát a výstup opatří **ověřovací doložkou**. Upravuje ji zákon o elektronických úkonech a autorizované konverzi dokumentů (č. 300/2008 Sb.).

### ? Firma má listinnou plnou moc s ověřeným podpisem a potřebuje ji odeslat datovou schránkou se stejnou právní silou. Co využije?

- [ ] Naskenování a zaslání dokumentu jako PDF e-mailem
- [ ] Zápis plné moci do registru práv a povinností
- [x] Autorizovanou konverzi do elektronické podoby
- [ ] Výpis ze základních registrů na kontaktním místě

> Autorizovaná konverze převede listinu do elektronické podoby s ověřovací doložkou, takže výstup má stejné právní účinky. Prostý sken takové účinky nemá.

## Datové schránky {#datove-schranky .explain}

**Datová schránka** je elektronické úložiště určené k **doručování dokumentů orgány veřejné moci** a k provádění úkonů vůči nim. Provozuje se v **informačním systému datových schránek (ISDS)**. Dokument dodaný úřadem do schránky má účinky **doručení do vlastních rukou**; úkon, který oprávněná osoba učiní ze své schránky vůči úřadu, má zpravidla stejné účinky jako písemný podepsaný úkon. Ze zákona (bez žádosti) se zřizuje **orgánům veřejné moci**, **všem právnickým osobám** a od 1. 1. 2023 i **podnikajícím fyzickým osobám** (novela zákona č. 300/2008 Sb. provedená zákonem č. 261/2021 Sb.). **Nepodnikající fyzické osoby** ji mají jen **dobrovolně**, na vlastní žádost. Mezi soukromými subjekty lze posílat i **poštovní datové zprávy**.

*Příklad:* Finanční úřad pošle firmě výzvu do datové schránky. Účetní se přihlásí, výzvu otevře a odpověď odešle zpět stejnou cestou — bez pošty a bez ověřeného podpisu.

### ? K čemu primárně slouží datová schránka?

- [x] K prokazatelnému doručování dokumentů od úřadů i úřadům
- [ ] K archivaci účetních záznamů firmy po dobu skartační lhůty
- [ ] K přihlašování občanů k on-line službám státu a bank
- [ ] K vedení referenčních údajů o právnických osobách

> Datová schránka je kanál pro elektronické doručování, především mezi orgány veřejné moci a ostatními osobami. Přihlašování zajišťuje elektronická identifikace, referenční údaje základní registry.

### ? Čím se doručení rozhodnutí úřadu do datové schránky liší od zaslání běžným e-mailem?

- [ ] Datová zpráva se doručí rychleji než e-mail
- [x] Doručení má právní účinky a je prokazatelné
- [ ] Datovou zprávu lze přečíst bez přihlášení
- [ ] Datová schránka nemá omezenou velikost zprávy

> Datová schránka zajišťuje prokazatelné doručení s účinky doručení do vlastních rukou. Běžný e-mail takové právní účinky nemá.

### ? Kdo z uvedených NEMÁ datovou schránku zřízenou povinně ze zákona, ale jen na vlastní žádost?

- [ ] Živnostník podnikající na základě živnostenského oprávnění
- [ ] Společnost s ručením omezeným
- [ ] Spolek zapsaný ve spolkovém rejstříku
- [x] Zaměstnanec, který nepodniká

> Povinně se datová schránka zřizuje orgánům veřejné moci, všem právnickým osobám (včetně spolků) a od 1. 1. 2023 i podnikajícím fyzickým osobám. Nepodnikající fyzická osoba ji má jen dobrovolně na žádost.

## Fikce doručení {#fikce-doruceni .term}

Dokument dodaný do datové schránky je **doručen okamžikem, kdy se do schránky přihlásí** osoba oprávněná k němu přistupovat. Pokud se nikdo nepřihlásí do **10 dnů** od dodání, považuje se dokument za **doručený posledním dnem této lhůty** (fikce doručení), pokud zvláštní zákon nestanoví jinak. Adresát se tak doručení nevyhne tím, že schránku neotevírá.

### ? Úřad dodal firmě rozhodnutí do datové schránky, ale nikdo z firmy se 10 dní nepřihlásil. Co platí?

- [ ] Doručení se neuskutečnilo a úřad musí rozhodnutí poslat poštou
- [ ] Rozhodnutí je doručeno až při prvním přihlášení, kdykoli později
- [ ] Rozhodnutí bylo doručeno už okamžikem dodání do schránky
- [x] Rozhodnutí se považuje za doručené posledním dnem lhůty

> Jde o fikci doručení: když se oprávněná osoba nepřihlásí do 10 dnů od dodání, platí dokument za doručený posledním dnem této lhůty.

### ? Úřad dodal dokument do datové schránky a oprávněná osoba se přihlásila třetí den po dodání. Kdy byl dokument doručen?

- [x] Okamžikem přihlášení oprávněné osoby
- [ ] Okamžikem dodání zprávy do datové schránky
- [ ] Posledním dnem desetidenní lhůty
- [ ] Okamžikem otevření konkrétní zprávy

> Dokument je doručen přihlášením oprávněné osoby do schránky, i kdyby zprávu samotnou neotevřela. Fikce doručení nastupuje, jen pokud se nikdo nepřihlásí do 10 dnů.

## Elektronická identifikace a Portál občana {#nia-portal-obcana .explain}

On-line služby státu musí spolehlivě ověřit, kdo je kdo. **Národní identitní autorita (NIA)** je centrální bod, přes který se uživatel prokáže zvoleným **prostředkem elektronické identifikace** a služba veřejné správy od něj dostane **ověřenou identitu** navázanou na údaje ze základních registrů. Úřad tedy nemusí spravovat vlastní hesla — jde o federovanou identitu s jedním přihlášením pro více služeb. Prostředky jsou např. **občanský průkaz s čipem (eObčanka)**, **bankovní identita** (přihlášení přes internetové bankovnictví) nebo **mobilní klíč eGovernmentu**; jejich nabídka se vyvíjí. **Portál občana** je osobní část Portálu veřejné správy: po přihlášení přes NIA zobrazí údaje vedené o občanovi, umožní podání a přístup k dalším službám, např. k datové schránce. Vzájemné uznávání identit mezi státy EU upravuje nařízení **eIDAS**.

*Příklad:* Studentka se do Portálu občana přihlásí bankovní identitou, zkontroluje své údaje v registrech a podá žádost — bez cesty na úřad a bez zvláštního hesla.

### ? Co je bankovní identita v kontextu eGovernmentu?

- [ ] Platební nástroj pro úhradu správních poplatků on-line
- [ ] Státem vedený registr bankovních účtů občanů a firem
- [x] Přihlášení ke službám státu přes přístup do svého bankovnictví
- [ ] Datová schránka, kterou občanovi zřizuje jeho banka

> Bankovní identita je prostředek elektronické identifikace: banka, která klienta už ověřila, potvrdí jeho identitu pro službu veřejné správy přes NIA.

### ? Jakou roli plní Národní identitní autorita (NIA)?

- [ ] Doručuje úřední dokumenty do schránek občanů
- [ ] Převádí identifikátory osob mezi agendami úřadů
- [ ] Vede referenční údaje o obyvatelích České republiky
- [x] Ověřuje identitu uživatelů pro on-line služby státu

> NIA zprostředkuje elektronickou identifikaci — ověří uživatele zvoleným prostředkem a předá službě jeho identitu. Převod identifikátorů dělá ORG, údaje o obyvatelích vede ROB.

## Efekty a bariéry aplikací veřejné správy {#efekty-vs .compare}

| Oblast | Přínosy | Bariéry a rizika |
|---|---|---|
| Občané a firmy | úspora času a cest, služby 24/7, méně dokládání údajů | digitální propast — část lidí služby neumí nebo nemůže používat; nízká důvěra |
| Úřady | nižší náklady na zpracování, rychlejší řízení, méně chyb díky referenčním údajům | zastaralé a roztříštěné systémy, nízká interoperabilita, nedostatek IT odborníků |
| Stát jako celek | transparentnost, lepší podklady pro rozhodování, otevřená data | bezpečnost a ochrana osobních údajů, závislost na dodavateli (vendor lock-in), nutnost měnit legislativu a procesy |

### ? Co je typickou bariérou rozvoje aplikací ve veřejné správě?

- [ ] Dostupnost služeb i mimo úřední hodiny
- [x] Část obyvatel neumí nebo nemůže služby používat
- [ ] Sdílení údajů mezi úřady přes základní registry
- [ ] Menší počet cest občanů a firem na úřad

> Digitální propast omezuje dosah elektronických služeb, proto stát zachovává i listinné a asistované kanály (např. CzechPOINT). Ostatní možnosti jsou přínosy eGovernmentu.

### ? Proč zavedení základních registrů snižuje chybovost údajů ve veřejné správě?

- [x] Údaj se vede jednou a ostatní úřady ho přebírají
- [ ] Každý úřad si vede vlastní ověřenou kopii údajů
- [ ] Občan potvrzuje své údaje při každé návštěvě úřadu
- [ ] Údaje se do registrů opisují z listinných dokladů

> Když se údaj vede jen jednou jako referenční a úřady ho přebírají, nevznikají rozdílné verze téhož údaje v různých systémech.
