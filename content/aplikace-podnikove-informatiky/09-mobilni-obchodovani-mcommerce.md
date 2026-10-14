---
kind: topic
subject: aplikace-podnikove-informatiky
slug: mobilni-obchodovani-mcommerce
name: "Mobilní obchodování (mCommerce)"
order: 9
---

mobilní podnikání a mobilní obchodování. Principy řešení mCommerce. Možnosti a funkce mCommerce. Efekty mCommerce.

## Mobilní podnikání × mobilní obchodování {#mbusiness-vs-mcommerce .compare}

**Mobilní obchodování (mCommerce, mobile commerce)** je nákup a prodej zboží a služeb prostřednictvím mobilních zařízení (chytrý telefon, tablet) připojených k bezdrátové síti. Je podmnožinou elektronického obchodu (eCommerce). **Mobilní podnikání (mBusiness)** je širší pojem.

| | Mobilní podnikání (mBusiness) | Mobilní obchodování (mCommerce) |
|---|---|---|
| Rozsah | veškeré podnikové činnosti podporované mobilními technologiemi | jen obchodní transakce (nákup, prodej, platba) |
| Zaměření | interní procesy, spolupráce s partnery i zákazníky | vztah prodávající – kupující |
| Uživatelé | zaměstnanci, partneři, zákazníci | především zákazníci |
| Příklady | schvalování v ERP z mobilu, terénní servis, mobilní CRM | nákup v e-shopu z mobilu, mobilní platba, m-ticketing |

### ? Obchodní zástupce v terénu schvaluje na tabletu objednávku v ERP a zapisuje návštěvu u zákazníka do CRM. Jak tuto činnost nejlépe zařadit?

- [ ] Mobilní obchodování (mCommerce) se spotřebitelem
- [x] Mobilní podnikání (mBusiness) mimo samotný nákup
- [ ] Elektronická výměna dat (EDI) mezi aplikacemi
- [ ] Mobilní marketing zaměřený na koncové zákazníky

> Jde o podporu interních procesů firmy mobilními technologiemi, tedy o mobilní podnikání (mBusiness). Pojem mCommerce se omezuje na nákup a prodej zboží a služeb přes mobilní zařízení.

### ? Jaký je vztah mobilního obchodování (mCommerce) k elektronickému obchodu (eCommerce)?

- [ ] mCommerce je nadřazený pojem zahrnující eCommerce
- [ ] Jde o dva nezávislé pojmy bez společného základu
- [ ] mCommerce zahrnuje jen platby, ne nákup zboží
- [x] mCommerce je podmnožinou elektronického obchodu

> mCommerce je elektronický obchod realizovaný přes mobilní zařízení, a je tedy jeho podmnožinou. Kromě plateb zahrnuje i nákup zboží a služeb.

## Mobilní aplikace uvnitř podniku {#mobilni-podnikove-aplikace .explain}

Mobilní podnikání zahrnuje i aplikace pro **zaměstnance**: mobilní přístup k ERP a CRM (schvalování, přehledy, reporty), aplikace pro **terénní servis** (zakázky, fotodokumentace, podpis zákazníka na displeji), mobilní podporu prodeje a skladové terminály se čtečkou čárových kódů. Hlavním přínosem je, že data vznikají **přímo v místě události** a odpadá přepisování papírových záznamů. Firemní zařízení se spravují centrálně pomocí **MDM** (Mobile Device Management) — vynucení zabezpečení (zámek, šifrování), distribuce aplikací a vzdálené vymazání dat při ztrátě. Při **BYOD** (Bring Your Own Device) používá zaměstnanec vlastní telefon a firma musí oddělit firemní data od soukromých.

*Příklad:* Servisní technik výtahů dostane zakázku do aplikace v telefonu, na místě vyfotí závadu, zapíše použité díly a zákazník potvrdí opravu podpisem na displeji. Data se okamžitě promítnou do ERP a fakturace.

### ? Firma chce při ztrátě služebního telefonu na dálku smazat firemní data a centrálně vynucovat zámek obrazovky. Jaký nástroj nasadí?

- [x] Správu mobilních zařízení (MDM)
- [ ] Lokalizační službu (LBS)
- [ ] Progresivní webovou aplikaci (PWA)
- [ ] Mobilní peněženku s tokenizací

> MDM (Mobile Device Management) slouží k centrální správě mobilních zařízení: vynucuje bezpečnostní politiky, distribuuje aplikace a umožňuje vzdálené vymazání dat. Ostatní možnosti správu zařízení neřeší.

### ? Co je hlavním přínosem mobilní aplikace pro servisní techniky v terénu?

- [ ] Firma už nepotřebuje centrální ERP systém
- [ ] Zakázky se přestanou evidovat v systému
- [x] Údaje se zapisují přímo v místě zásahu
- [ ] Technik přestane potřebovat jakékoli školení

> Mobilní aplikace umožňuje zachytit data tam, kde vznikají, takže odpadá přepisování papírových výkazů a s ním chyby i zpoždění. Na podnikové systémy (ERP) aplikace navazuje, nenahrazuje je.

## Mobilní web × nativní aplikace × PWA {#web-nativni-pwa .compare}

Firma může mobilní obchod zpřístupnit třemi základními způsoby, které se liší náklady, možnostmi i způsobem distribuce.

| | Mobilní (responzivní) web | Nativní aplikace | Progresivní webová aplikace (PWA) |
|---|---|---|---|
| Instalace | žádná, otevře se v prohlížeči | z obchodu s aplikacemi (App Store, Google Play) | z prohlížeče na plochu, obchod není nutný |
| Vývoj | jeden kód pro všechna zařízení | zvlášť pro každou platformu (iOS, Android) | jeden webový kód |
| Přístup k hardwaru | omezený | plný (fotoaparát, NFC, senzory, biometrie) | širší než web, užší než nativní |
| Práce offline | zpravidla ne | ano | ano (service worker) |
| Push notifikace | omezeně (podle prohlížeče a platformy) | ano | ano, s omezeními podle platformy |
| Náklady | nejnižší | nejvyšší | střední |

Kompromisem jsou i **multiplatformní** nástroje (např. React Native, Flutter), kde se z jednoho kódu sestaví aplikace pro více platforem.

### ? Banka potřebuje plný přístup k biometrii a NFC čipu telefonu a nejvyšší výkon; vyšší náklady na vývoj pro iOS i Android jí nevadí. Jaké řešení zvolí?

- [ ] Responzivní mobilní web
- [x] Nativní mobilní aplikace
- [ ] Progresivní webovou aplikaci
- [ ] Zjednodušenou mobilní verzi webu

> Nativní aplikace má plný přístup k hardwaru zařízení a nejlepší výkon, za cenu vývoje zvlášť pro každou platformu. Webová řešení včetně PWA mají k hardwaru přístup omezenější.

### ? Malý e-shop chce, aby si zákazník mohl web přidat na plochu telefonu a prohlížet katalog i offline, ale bez vývoje pro každou platformu a bez obchodu s aplikacemi. Co zvolí?

- [ ] Nativní aplikaci pro iOS a Android
- [ ] Kampaň SMS s odkazem na e-shop
- [ ] Klasický web bez úprav pro mobil
- [x] Progresivní webovou aplikaci (PWA)

> PWA je webová aplikace s jedním kódem, kterou lze přidat na plochu a která díky service workeru funguje i offline. Nevyžaduje distribuci přes obchod s aplikacemi.

### ? Co je typickou nevýhodou nativní mobilní aplikace oproti mobilnímu webu?

- [x] Vývoj a údržba zvlášť pro každou platformu
- [ ] Nemožnost pracovat bez připojení k síti
- [ ] Žádný přístup k fotoaparátu a senzorům
- [ ] Nemožnost posílat uživateli notifikace

> Nativní aplikace se vyvíjí pro konkrétní platformu (iOS, Android), takže vývoj i údržba se násobí. Práce offline, přístup k hardwaru i notifikace jsou naopak její silné stránky.

## Responzivní design {#responzivni-design .term}

Přístup k tvorbě webu, kdy se **jedna verze** stránek automaticky přizpůsobuje velikosti a orientaci obrazovky (rozvržení, velikost písma a obrázků, navigace), typicky pomocí kaskádových stylů (CSS media queries). Často se kombinuje s přístupem **mobile first** — návrh nejprve pro malý displej, poté rozšíření pro větší. Odpadá správa samostatné mobilní verze webu.

### ? Firma má jeden web, jehož rozvržení se samo přizpůsobí šířce displeje telefonu, tabletu i monitoru. Jak se tento přístup nazývá?

- [ ] Nativní vývoj pro každou platformu
- [ ] Samostatná mobilní verze webu
- [x] Responzivní design webu
- [ ] Jazyková lokalizace webu

> Responzivní design znamená jeden web, který se přizpůsobuje velikosti obrazovky. Samostatná mobilní verze je naopak oddělený web, který je nutné spravovat zvlášť.

## Progresivní webová aplikace (PWA) {#pwa .term}

Webová aplikace (**Progressive Web App**), která běží v prohlížeči, ale chová se podobně jako nativní aplikace: lze ji **přidat na plochu**, funguje **offline** díky **service workeru** (skript ukládající obsah do mezipaměti) a umí posílat notifikace. Název, ikonu a vzhled po instalaci popisuje **manifest webové aplikace**; provoz vyžaduje zabezpečené spojení HTTPS. Distribuce přes obchod s aplikacemi není nutná.

### ? Která součást umožňuje progresivní webové aplikaci (PWA) fungovat i bez připojení k internetu?

- [ ] Manifest webové aplikace
- [x] Service worker s mezipamětí
- [ ] Responzivní kaskádové styly
- [ ] Obchod s aplikacemi Google Play

> Service worker je skript, který ukládá obsah do mezipaměti a obsluhuje požadavky i bez připojení. Manifest popisuje název a ikonu aplikace, offline režim nezajišťuje.

## Push notifikace {#push-notifikace .term}

Krátké zprávy, které server aplikace posílá na zařízení uživatele a které se zobrazí, i když aplikace **není právě otevřená** (např. na zamčené obrazovce). Doručují je služby provozovatelů platforem (Apple, Google), nikoli mobilní operátor jako u SMS. Uživatel k nim musí dát **souhlas** a může je kdykoli vypnout; příliš časté notifikace vedou k jejich vypnutí nebo odinstalaci aplikace.

### ? Čím se push notifikace liší od SMS zprávy?

- [x] Doručí ji aplikace přes službu platformy, ne operátor
- [ ] Lze ji poslat i na tlačítkový telefon bez aplikací a internetu
- [ ] Nevyžaduje od uživatele žádný předchozí souhlas
- [ ] Zobrazí se jen tehdy, když je aplikace otevřená

> Push notifikace doručuje služba provozovatele platformy do aplikace a vyžaduje připojení i souhlas uživatele. SMS jde přes mobilního operátora a dorazí i na telefon bez aplikací a internetu.

### ? Aplikace obchodního řetězce posílá zákazníkům denně několik push notifikací s akcemi. Jaké riziko tím hrozí?

- [ ] Zákazníkům přestanou fungovat platby kartou
- [ ] Notifikace se začnou účtovat jako placené SMS
- [x] Uživatelé notifikace vypnou či aplikaci smažou
- [ ] Aplikace přestane fungovat bez připojení

> Nadměrné množství notifikací uživatele obtěžuje, takže je vypne nebo aplikaci odinstaluje, a firma tím ztratí komunikační kanál.

## Lokalizační služby (LBS) {#lbs .explain}

**Lokalizační služby** (LBS, Location-Based Services) poskytují službu podle aktuální **polohy zařízení**. Poloha se určuje pomocí satelitní navigace (GPS a další systémy GNSS), sítí Wi-Fi, buněk mobilní sítě a uvnitř budov např. pomocí **Bluetooth majáčků** (beacons), kde je satelitní signál slabý. Využití: navigace, vyhledání nejbližší pobočky, sledování kurýra, nabídky v okolí. **Geofencing** vymezuje virtuální hranici kolem místa a při jejím překročení aplikace spustí akci (např. notifikaci). Poloha je osobní údaj, proto vyžaduje souhlas uživatele a ochranu podle GDPR.

*Příklad:* Kavárenský řetězec nastaví kolem každé pobočky virtuální hranici. Když do ní vstoupí zákazník s aplikací a povoleným sdílením polohy, dostane nabídku kávy se slevou.

### ? Aplikace obchodního řetězce pošle zákazníkovi nabídku, jakmile se přiblíží na 300 metrů k prodejně. Jak se tento princip nazývá?

- [ ] Responzivní design
- [ ] Tokenizace
- [ ] Mobilní bankovnictví
- [x] Geofencing

> Geofencing vymezuje virtuální hranici kolem místa a při jejím překročení spustí akci, např. notifikaci s nabídkou. Je to typické využití lokalizačních služeb v mobilním marketingu.

### ? Kterou technologii lokalizační služby typicky využívají k určení polohy uvnitř budovy, např. v obchodním centru?

- [ ] Satelitní navigaci GPS
- [x] Bluetooth majáčky (beacons)
- [ ] Čipy NFC v pokladních terminálech
- [ ] Push notifikace platformy

> Uvnitř budov je satelitní signál slabý, proto se používají Bluetooth majáčky rozmístěné v prostoru. NFC funguje jen na vzdálenost několika centimetrů a k lokalizaci se nepoužívá.

## Mobilní platby {#mobilni-platby .explain}

**Mobilní platba** je platba, při které se k zadání nebo potvrzení použije mobilní zařízení. Hlavní formy:
- **bezkontaktní platba NFC** na terminálu v obchodě — telefon nebo hodinky nahrazují kartu,
- **platba QR kódem** — např. QR kód s platebními údaji na faktuře naskenovaný v bankovní aplikaci,
- **platba v aplikaci nebo na mobilním webu** — uložená karta nebo mobilní peněženka,
- **platba přes mobilního operátora** — částka se připíše k vyúčtování tarifu (např. premium SMS),
- **platby mezi lidmi (P2P)** — např. podle telefonního čísla.

Bezpečnost zajišťuje tokenizace, biometrické ověření a silné ověření klienta.

*Příklad:* Zákazník zaplatí v obchodě přiložením telefonu k terminálu a večer pošle kamarádovi podíl na útratě převodem na telefonní číslo.

### ? Zákazník si koupí hru do telefonu a částka se mu připíše k měsíčnímu vyúčtování mobilního tarifu. O jakou formu mobilní platby jde?

- [ ] Bezkontaktní platbu NFC
- [ ] Platbu převodem přes QR kód z banky
- [x] Platbu přes mobilního operátora
- [ ] Platbu mobilní peněženkou

> Při platbě přes operátora se částka připíše k vyúčtování mobilních služeb a operátor ji předá obchodníkovi. Ostatní formy čerpají peníze z platební karty nebo bankovního účtu.

### ? Firma chce, aby zákazníci mohli zaplatit fakturu převodem bez ručního opisování čísla účtu a částky. Co na fakturu přidá?

- [x] QR kód s platebními údaji
- [ ] NFC štítek s číslem karty
- [ ] Odkaz na mobilní peněženku
- [ ] Kód pro platbu přes operátora

> QR kód s platebními údaji zákazník naskenuje v bankovní aplikaci a údaje pro převod se vyplní automaticky. Platba přes operátora ani mobilní peněženka převod faktury z účtu neřeší.

## NFC × QR kód {#nfc-vs-qr .compare}

Obě technologie propojují mobil s fyzickým světem (platby, jízdenky, vstupenky), liší se principem a náklady.

| | NFC (Near Field Communication) | QR kód |
|---|---|---|
| Princip | rádiová komunikace na velmi krátkou vzdálenost (několik centimetrů) | dvourozměrný (2D) kód snímaný fotoaparátem |
| Vybavení | telefon s čipem NFC a čtečka / terminál | jen fotoaparát; kód lze vytisknout nebo zobrazit na displeji |
| Náklady obchodníka | bezkontaktní terminál | velmi nízké (vytištěný kód) |
| Typické použití | bezkontaktní platby, jízdenky, přístupové systémy | platby převodem, odkazy na web, jízdenky, vstupenky |
| Bezpečnostní riziko | malé díky krátkému dosahu a tokenizaci | podvržení — falešný kód přelepený přes pravý |

### ? Malý stánkař nemá platební terminál a chce přijímat platby z mobilu co nejlevněji. Které řešení je pro něj vhodnější?

- [ ] NFC s bezkontaktním terminálem
- [ ] Čtečka magnetického proužku
- [ ] Bluetooth majáček u stánku
- [x] Vytištěný QR kód pro platbu

> QR kód stačí vytisknout a zákazník jej naskenuje fotoaparátem v bankovní aplikaci, takže obchodník nepotřebuje žádné zařízení. NFC vyžaduje bezkontaktní terminál.

### ? Jaké bezpečnostní riziko je typické spíše pro QR kódy než pro NFC?

- [ ] Odposlech rádiového signálu na dálku
- [x] Přelepení pravého kódu podvrženým
- [ ] Vysoké pořizovací náklady čtečky
- [ ] Vybití baterie během komunikace

> QR kód je jen obrázek, takže jej útočník může snadno přelepit vlastním kódem vedoucím na podvodný web nebo účet. NFC komunikuje na vzdálenost centimetrů, odposlech na dálku proto není typickým rizikem.

## Mobilní peněženka {#mobilni-penezenka .term}

Aplikace v telefonu nebo hodinkách (např. Apple Pay, Google Pay / Google Wallet), která uchovává **platební karty** a další položky — věrnostní karty, jízdenky, vstupenky, palubní vstupenky. Při placení se místo skutečného čísla karty používá **token** (zástupné číslo; **tokenizace**) a platbu uživatel potvrzuje biometrií nebo kódem zařízení. V obchodech se platí nejčastěji bezkontaktně přes NFC.

### ? Co znamená tokenizace u mobilní peněženky?

- [x] Skutečné číslo karty nahradí zástupné číslo
- [ ] Platba se rozdělí na několik menších částí
- [ ] Karta se uloží v čitelné podobě v telefonu
- [ ] Za každou platbu zákazník získá věrnostní body

> Při tokenizaci se v zařízení a při platbě používá zástupné číslo (token) místo skutečného čísla karty. Při úniku tokenu tak útočník nezíská údaje o kartě samotné.

## Mobilní bankovnictví {#mobilni-bankovnictvi .term}

Přístup ke službám banky přes **mobilní aplikaci** (případně mobilní web): přehled účtů, platby, správa karet (blokace, limity), investice, komunikace s bankou. Aplikace slouží i k **ověřování** přihlášení a plateb. Platí požadavek **silného ověření klienta** (SCA, Strong Customer Authentication) podle evropské směrnice PSD2 — kombinace alespoň dvou ze tří kategorií faktorů: **znalost** (PIN, heslo), **vlastnictví** (registrovaný telefon), **inherence** (biometrie — otisk prstu, obličej).

### ? Klient potvrzuje platbu otiskem prstu v mobilní aplikaci banky, která je registrovaná jen v jeho telefonu. Které dva faktory silného ověření tím kombinuje?

- [ ] Znalost a vlastnictví
- [ ] Znalost a inherenci
- [ ] Jen jeden faktor – vlastnictví
- [x] Vlastnictví a inherenci

> Registrovaný telefon je faktor vlastnictví, otisk prstu je faktor inherence (biometrie). Faktor znalosti by představoval PIN nebo heslo.

### ? Klient si v aplikaci banky v telefonu dočasně zablokuje ztracenou platební kartu a změní její limit. O jakou službu jde?

- [ ] Mobilní peněženku
- [x] Mobilní bankovnictví
- [ ] Mobilní marketing
- [ ] Lokalizační službu

> Správa účtu a karet (blokace, limity) v aplikaci banky je služba mobilního bankovnictví. Mobilní peněženka slouží k placení uloženými kartami, ne ke správě účtu.

## Mobilní jízdenky a vstupenky (m-ticketing) {#m-ticketing .term}

Nákup, uchování a kontrola **jízdenek a vstupenek v mobilu** (veřejná doprava, kultura, sport, parkování). Doklad má obvykle podobu QR nebo čárového kódu v aplikaci či mobilní peněžence a kontroluje se naskenováním z displeje. Zákazník nemusí stát frontu a může koupit na poslední chvíli; provozovatel šetří náklady na tisk a prodej a získává data o poptávce.

### ? Dopravce chce zrušit papírové jízdenky; cestující si koupí jízdenku v aplikaci a průvodčí ji ověří naskenováním kódu z displeje. Jak se tato služba nazývá?

- [ ] Mobilní bankovnictví
- [ ] Lokalizační služba (LBS)
- [x] Mobilní jízdenky (m-ticketing)
- [ ] Mobilní marketing

> M-ticketing je nákup a kontrola jízdenek a vstupenek v mobilu, typicky pomocí kódu zobrazeného na displeji.

### ? Co je přínosem m-ticketingu pro provozovatele dopravy?

- [x] Nižší náklady na tisk a prodej jízdenek
- [ ] Odpadá nutnost jízdenky kontrolovat
- [ ] Cestující nepotřebují žádný mobilní telefon
- [ ] Zaniká potřeba jakéhokoli informačního systému

> Elektronické jízdenky snižují náklady na tisk, prodejní místa a obsluhu a přinášejí data o cestujících. Kontrola jízdenek však zůstává, jen probíhá skenováním displeje.

## Mobilní marketing {#mobilni-marketing .explain}

**Mobilní marketing** je marketingová komunikace prostřednictvím mobilních zařízení. Nástroje: SMS a MMS kampaně, push notifikace a zprávy v aplikaci, reklama v mobilních aplikacích a ve vyhledávání, **proximity marketing** (nabídky v blízkosti prodejny pomocí majáčků nebo geofencingu), **QR kódy** na plakátech a obalech propojující fyzický svět s webem a věrnostní programy v aplikaci. Výhodou je cílení podle polohy, času a chování a okamžitá měřitelnost odezvy. Obchodní sdělení elektronickou cestou obvykle vyžadují **předchozí souhlas** příjemce (opt-in) a možnost odhlášení; zpracování polohy podléhá GDPR.

*Příklad:* Kino vylepí plakát s QR kódem. Po naskenování si zákazník rovnou koupí vstupenku a kino vidí, kolik prodejů plakát přinesl.

### ? Výrobce nápojů umístí na etiketu kód, po jehož naskenování se zákazník dostane do soutěže na mobilním webu. Jaký nástroj mobilního marketingu využil?

- [ ] Geofencing kolem prodejny
- [ ] Premium SMS přes operátora
- [ ] Push notifikaci z aplikace
- [x] QR kód propojující obal s webem

> QR kód na obalu propojuje fyzický produkt s mobilním webem a firma přitom může měřit, kolik lidí jej naskenovalo.

### ? Co firma obvykle potřebuje, než začne zákazníkům posílat obchodní SMS nebo e-mailové nabídky?

- [ ] Nativní aplikaci zákazníka v telefonu
- [x] Předchozí souhlas příjemce (opt-in)
- [ ] Platební kartu zákazníka v peněžence
- [ ] Polohu zákazníka z lokalizační služby

> Obchodní sdělení šířená elektronickou cestou zpravidla vyžadují předchozí souhlas příjemce a možnost odhlášení. Aplikace, karta ani poloha k jejich zasílání nutné nejsou.

## Efekty mCommerce {#efekty-mcommerce .explain}

Přínosy mobilního obchodování pro zákazníka i firmu:
- **všudypřítomnost** (ubiquity) — nákup kdykoli a kdekoli, i během čekání nebo cesty,
- **dosažitelnost** — zákazník je zastižitelný téměř stále (notifikace),
- **personalizace** — telefon je osobní zařízení jednoho uživatele, nabídky lze cílit na míru,
- **lokalizace** — služby a nabídky podle aktuální polohy,
- **rychlost a pohodlí** — okamžitý nákup, uložené platební údaje, ověření biometrií,
- pro firmu: **nový prodejní kanál**, samoobsluha snižující náklady, data o chování zákazníků a propojení kamenné prodejny s online kanály.

*Příklad:* Drogerie zavede aplikaci s digitální věrnostní kartou. Zákazníci dostávají kupóny podle svých nákupů a firma získá přehled o tom, co kdo kupuje.

### ? Proč je mobilní telefon vhodnější pro personalizované nabídky než sdílený domácí počítač?

- [x] Telefon obvykle používá jen jeden člověk
- [ ] Telefon má větší displej než počítač
- [ ] Telefon nevyžaduje souhlas se zpracováním dat
- [ ] Telefon nelze ztratit ani nechat odcizit

> Mobil je osobní zařízení, které obvykle používá jediný člověk, takže data o chování lze přiřadit konkrétnímu zákazníkovi. Souhlas se zpracováním osobních údajů je potřeba i u mobilu.

### ? Zákazník si v tramvaji cestou z práce objedná nákup potravin, který mu večer dovezou. Který efekt mCommerce se tu projevuje především?

- [ ] Lokalizace nabídky podle polohy
- [ ] Fragmentace mobilních platforem
- [x] Dostupnost kdykoli a kdekoli
- [ ] Nižší náklady na vývoj aplikace

> Nákup během cesty ilustruje všudypřítomnost mCommerce — zákazník nakupuje kdykoli a kdekoli. Nabídka zde nezávisí na poloze a fragmentace platforem je bariéra, ne efekt.

## Bariéry mCommerce {#bariery-mcommerce .explain}

Mobilní obchodování omezují:
- **bezpečnost** — ztráta nebo krádež zařízení, malware, podvodné SMS (smishing), falešné aplikace a QR kódy,
- **malý displej a omezené zadávání** — složité formuláře a srovnávání produktů jsou nepohodlné; řeší se zjednodušením nákupu,
- **fragmentace platforem** — iOS × Android, různé verze systému a velikosti displejů zvyšují náklady na vývoj a testování,
- **konektivita a baterie** — výpadky signálu, omezená výdrž,
- **obavy o soukromí** — sledování polohy a chování,
- **závislost na obchodech s aplikacemi** — schvalovací pravidla a poplatky provozovatelů platforem.

*Příklad:* E-shop zjistí, že zákazníci na mobilu opouštějí košík u dlouhého formuláře. Zkrátí jej, přidá platbu mobilní peněženkou a počet dokončených objednávek vzroste.

### ? Vývojový tým musí aplikaci testovat na desítkách modelů telefonů s různými verzemi systému a velikostmi displeje. Jakou bariéru mCommerce to ilustruje?

- [ ] Omezenou výdrž baterie
- [ ] Obavy o soukromí
- [ ] Nedostatečné pokrytí sítí
- [x] Fragmentaci platforem

> Fragmentace znamená velké množství platforem, verzí operačních systémů a typů zařízení, na kterých musí aplikace fungovat, což zvyšuje náklady na vývoj a testování.

### ? Které opatření pomůže zmírnit bariéru malého displeje při nákupu na mobilu?

- [ ] Přidat do košíku podrobnou srovnávací tabulku
- [x] Zkrátit formuláře a umožnit platbu jedním krokem
- [ ] Vyžádat si od zákazníka přístup k jeho poloze
- [ ] Posílat zákazníkovi několik push notifikací každý den

> Na malém displeji se špatně vyplňují dlouhé formuláře, proto se nákup zjednodušuje — méně polí, uložené údaje, platba jedním krokem. Rozsáhlé tabulky problém naopak zhoršují.

### ? Co z uvedeného NENÍ bariérou mCommerce?

- [ ] Riziko ztráty nebo krádeže zařízení
- [ ] Omezená výdrž baterie telefonu
- [x] Personalizace nabídky podle uživatele
- [ ] Různé verze operačních systémů

> Personalizace je přínosem (efektem) mCommerce, protože mobil je osobní zařízení. Ztráta zařízení, baterie i fragmentace operačních systémů patří k bariérám.
