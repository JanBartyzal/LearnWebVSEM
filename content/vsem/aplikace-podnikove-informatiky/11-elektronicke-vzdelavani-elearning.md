---
kind: topic
subject: aplikace-podnikove-informatiky
slug: elektronicke-vzdelavani-elearning
name: "Elektronické vzdělávání (eLearning)"
order: 11
---

Historický vývoj a podstata eLearningu, virtuální třída, blended learning a jiné formy výuky, LMS – systém pro řízení výuky, Efekty aplikací eLearningu. mLearning jako navazující forma výuky. Omezení a nevýhody mobilní výuky.

## eLearning (elektronické vzdělávání) {#elearning .term}

eLearning je vzdělávání **podporované informačními a komunikačními technologiemi** — výukový obsah, komunikace s lektorem i ostatními studenty, testování a evidence výsledků probíhají zcela nebo zčásti elektronicky, typicky přes internet či intranet. V podnicích slouží ke školení zaměstnanců (povinná školení BOZP, produktové znalosti, zaškolení nováčků), ve školách jako doplněk nebo náhrada prezenční výuky.

### ? Co je podstatou eLearningu?

- [ ] Výuka výhradně prostřednictvím nahraných videopřednášek
- [x] Vzdělávání podporované ICT včetně obsahu, komunikace a hodnocení
- [ ] Jakékoli vzdělávání, které probíhá mimo budovu školy či firmy
- [ ] Samostudium z tištěných skript doplněné konzultacemi e-mailem

> eLearning využívá ICT pro celý vzdělávací proces — zpřístupnění obsahu, komunikaci, testování i evidenci výsledků. Samotné video nebo výuka mimo budovu ještě eLearning nedefinují.

## Historický vývoj eLearningu {#vyvoj-elearningu .explain}

Vývoj eLearningu lze zjednodušeně popsat několika navazujícími etapami (časové vymezení je orientační):

1. **CBT** (Computer-Based Training) — výukové programy na nosičích (disketa, CD-ROM) spouštěné lokálně na počítači bez sítě; typicky 80. a 90. léta.
2. **WBT** (Web-Based Training) — výuka přes web v prohlížeči; obsah leží na serveru a lze jej centrálně aktualizovat; od druhé poloviny 90. let.
3. **LMS** (Learning Management System) — platformy, které výuku řídí: správa kurzů a uživatelů, testy, sledování výsledků; standardy pro přenositelnost obsahu (SCORM).
4. **MOOC** (Massive Open Online Course) — masové otevřené online kurzy pro tisíce účastníků.

Na tyto etapy navazuje mobilní výuka (mLearning), microlearning a další formy.

*Příklad:* Firma, která kdysi rozesílala pobočkám CD-ROM s kurzem o novém produktu, dnes kurz zveřejní v LMS a ihned vidí, kdo ho dokončil a s jakým výsledkem.

### ? Které pořadí odpovídá historickému vývoji eLearningu?

- [ ] WBT → CBT → MOOC → LMS
- [ ] CBT → MOOC → WBT → LMS
- [ ] LMS → CBT → WBT → MOOC
- [x] CBT → WBT → LMS → MOOC

> Nejdříve vznikly programy na nosičích (CBT), pak výuka přes web (WBT), následně platformy pro řízení výuky (LMS) a později masové otevřené online kurzy (MOOC). Jde o zjednodušení — WBT a první LMS se ve skutečnosti vyvíjely téměř souběžně.

## CBT × WBT {#cbt-vs-wbt .compare}

Obě formy jsou počítačem podporovaná výuka; liší se tím, zda obsah běží lokálně, nebo přes web.

| | CBT (Computer-Based Training) | WBT (Web-Based Training) |
|---|---|---|
| Distribuce | nosič (disketa, CD-ROM), instalace na PC | web — internet nebo intranet, prohlížeč |
| Připojení k síti | není potřeba | nutné |
| Aktualizace obsahu | nová verze nosiče a její rozeslání | centrálně na serveru |
| Evidence výsledků | lokálně, centrálně se sbírá obtížně | centrálně na serveru (LMS) |
| Komunikace | jen interakce s programem | e-mail, diskusní fóra, chat |

### ? Firma rozeslala pobočkám kurz na CD-ROM, který se instaloval a spouštěl na počítači bez připojení k síti. O jakou formu eLearningu šlo?

- [ ] Web-Based Training (WBT)
- [ ] Massive Open Online Course (MOOC)
- [x] Computer-Based Training (CBT)
- [ ] Virtuální třída (virtual classroom)

> Výuka z nosiče spouštěná lokálně bez sítě je typická pro CBT. WBT a MOOC běží přes web, virtuální třída vyžaduje živé online spojení.

### ? Jaká je hlavní výhoda WBT oproti CBT pro firmu, která školí zaměstnance na mnoha pobočkách?

- [x] Obsah se aktualizuje centrálně na jednom serveru
- [ ] Kurz lze spustit i bez jakéhokoli připojení k síti
- [ ] Kurz nevyžaduje počítač, tablet ani jiné zařízení
- [ ] Obsah se pobočkám spolehlivě doručuje na nosičích

> U WBT leží obsah na serveru, takže změna se projeví všem uživatelům okamžitě a bez rozesílání nosičů. Práce bez sítě je naopak vlastnost CBT.

## MOOC {#mooc .term}

MOOC (Massive Open Online Course) je online kurz určený pro **velmi velký počet účastníků** (tisíce i více), **otevřený** — zapsat se může kdokoli bez přijímacího řízení, často zdarma (placený bývá certifikát) — a probíhající **celý online**. Obvykle obsahuje krátká videa, testy s automatickým hodnocením, vzájemné hodnocení studentů (peer review) a diskusní fóra. Příklady platforem: Coursera, edX. Typickou slabinou je **nízký podíl účastníků, kteří kurz dokončí**.

### ? Co vyjadřuje slovo „Open" ve zkratce MOOC?

- [ ] Kurz je postaven výhradně na open source softwaru
- [x] Zapsat se může kdokoli bez přijímacího řízení
- [ ] Studenti mohou libovolně upravovat obsah kurzu
- [ ] Kurz nemá pevně stanovené cíle ani osnovu

> „Open" znamená otevřený přístup — kurz není omezen přijímacím řízením ani předchozím vzděláním a často je zdarma. Neznamená open source software ani volnou úpravu obsahu.

### ? Co je typickou slabinou MOOC?

- [ ] Kapacita omezená na několik desítek studentů
- [ ] Povinná osobní účast na úvodním soustředění
- [ ] Vysoké školné hrazené před zahájením kurzu
- [x] Nízký podíl účastníků, kteří kurz dokončí

> Do MOOC se lze snadno a zdarma zapsat, ale bez osobního závazku a dohledu jej mnoho účastníků nedokončí. Kapacita je naopak prakticky neomezená.

## Virtuální třída {#virtualni-trida .term}

Virtuální třída (virtual classroom) je online prostředí, které **napodobuje prezenční výuku**: lektor a studenti se setkávají **ve stejném čase** přes internet a mohou spolu průběžně komunikovat. Typické nástroje: živé video a zvuk, sdílení obrazovky a prezentace, interaktivní tabule (whiteboard), chat, hlasování, „zvednutí ruky", práce ve skupinách (breakout rooms) a záznam lekce. Příklady nástrojů: Microsoft Teams, Zoom, BigBlueButton.

### ? Firma chce, aby lektor z centrály vedl živé školení pro zaměstnance poboček, kteří mu mohou průběžně klást dotazy a pracovat ve skupinách. Co zvolí?

- [ ] Kurz na CD-ROM (CBT)
- [ ] Samostudijní kurz v LMS
- [x] Virtuální třídu
- [ ] Nahraný videozáznam přednášky

> Virtuální třída umožňuje živou výuku na dálku s okamžitou interakcí a skupinovou prací. Samostudijní kurz, video ani CBT živou komunikaci s lektorem nenabízejí.

## Synchronní × asynchronní výuka {#synchronni-vs-asynchronni .compare}

Online výuka se dělí podle toho, zda účastníci komunikují ve stejném čase.

| | Synchronní výuka | Asynchronní výuka |
|---|---|---|
| Čas | všichni ve stejném čase | každý ve svém čase |
| Komunikace | okamžitá (video, živý chat) | se zpožděním (e-mail, fórum, komentáře) |
| Příklady | virtuální třída, webinář, živý chat | samostudijní kurz v LMS, video, diskusní fórum |
| Výhody | okamžitá zpětná vazba, interakce, sounáležitost | flexibilita, individuální tempo, čas na rozmyšlení |
| Nevýhody | pevný termín, potíže s časovými pásmy | menší interakce, nutná samostatnost a motivace |

### ? Která z uvedených forem komunikace ve výuce je ASYNCHRONNÍ?

- [ ] Webinář s živým dotazováním
- [ ] Videokonference ve virtuální třídě
- [ ] Chat s lektorem během živé lekce
- [x] Diskusní fórum v kurzu LMS

> Do diskusního fóra přispívá každý, kdy mu to vyhovuje, a odpovědi přicházejí se zpožděním. Webinář, videokonference i chat během lekce probíhají v reálném čase, jsou tedy synchronní.

### ? Nadnárodní firma má zaměstnance v Evropě, Asii a Americe a chce, aby si každý prošel školení, kdy mu to vyhovuje. Která forma je vhodnější?

- [x] Asynchronní výuka
- [ ] Synchronní výuka
- [ ] Prezenční výuka v centrále
- [ ] Živý webinář v pevný čas

> Asynchronní výuka nevyžaduje společný čas, takže nevadí časová pásma ani pracovní rozvrhy. Synchronní formy včetně webináře potřebují pevný termín pro všechny.

## Blended learning {#blended-learning .explain}

Blended learning (kombinovaná, smíšená výuka) **kombinuje prezenční výuku** s lektorem **a eLearning** tak, aby se využily výhody obou. Online část se hodí pro teorii, samostudium a testování znalostí, prezenční část pro diskusi, nácvik dovedností, řešení případových studií a budování vztahů. Poměr a pořadí obou složek se volí podle cíle kurzu. Známým modelem je **převrácená třída** (flipped classroom): studenti nastudují teorii online předem a čas ve třídě se věnuje procvičování a diskusi.

*Příklad:* Nový obchodník nejprve projde v LMS kurz o produktech a cenové politice zakončený testem a teprve potom absolvuje dvoudenní prezenční trénink obchodního jednání s hraním rolí.

### ? Banka zaškoluje nové pracovníky poboček: předpisy studují v online kurzu s testy a nácvik jednání s klienty probíhá na prezenčním workshopu. Jak se tato forma výuky nazývá?

- [ ] Microlearning
- [x] Blended learning
- [ ] Virtuální třída
- [ ] Massive Open Online Course

> Kombinace online samostudia a prezenční výuky je blended learning. Virtuální třída je čistě online živá výuka, microlearning výuka v krátkých lekcích.

### ? Co je podstatou převrácené třídy (flipped classroom)?

- [ ] Studenti vyučují spolužáky místo lektora
- [ ] Online materiály zcela nahradí prezenční výuku
- [x] Teorie se studuje online předem, ve třídě se procvičuje
- [ ] Test se píše na začátku kurzu místo na jeho konci

> Převrácená třída přesouvá výklad teorie do online přípravy před výukou, takže společný čas ve třídě zbývá na procvičování, diskusi a řešení problémů.

## Microlearning {#microlearning .term}

Microlearning je forma výuky v **krátkých, samostatných lekcích** (řádově jednotky minut), z nichž každá sleduje **jeden konkrétní cíl** — např. krátké video, kvíz, kartička nebo infografika. Hodí se pro průběžné opakování, osvěžení znalostí a učení „právě včas" (just-in-time) přímo při práci, často na mobilu. Nehodí se pro souvislý výklad složitých témat.

### ? Servisní technik si přímo u zákazníka pustí v mobilu tříminutové video o výměně konkrétního dílu. O jakou formu výuky jde?

- [x] Microlearning
- [ ] Virtuální třída
- [ ] Blended learning
- [ ] Computer-Based Training

> Krátká samostatná lekce s jedním cílem, využitá právě ve chvíli potřeby, je typický microlearning. Nejde o živou výuku (virtuální třída) ani o kombinaci s prezenční výukou (blended learning).

## Gamifikace výuky {#gamifikace .term}

Gamifikace je využití **herních prvků a mechanik** (body, odznaky, úrovně, žebříčky, výzvy, okamžitá zpětná vazba) v neherním kontextu — zde ve výuce — s cílem zvýšit **motivaci a zapojení** studentů. Liší se od výuky pomocí her (serious games), kde výukovým prostředkem je celá hra. Účinek není automatický: špatně nastavené odměny mohou vést k honbě za body místo za znalostmi a žebříčky mohou slabší studenty demotivovat.

### ? Která situace je příkladem gamifikace výuky?

- [ ] Lektor vede živou lekci ve virtuální třídě
- [ ] Studenti si stáhnou skripta ve formátu PDF
- [ ] Kurz kombinuje online teorii a prezenční nácvik
- [x] Za splněné lekce student získává body a odznaky

> Body a odznaky jsou herní prvky použité v neherním kontextu výuky, tedy gamifikace. Ostatní možnosti popisují virtuální třídu, samostudium a blended learning.

### ? Jaké riziko gamifikace ve výuce je třeba hlídat?

- [ ] Nutnost pořídit studentům herní konzole
- [x] Studenti se honí za body místo za znalostmi
- [ ] Nemožnost sledovat výsledky studentů v kurzu
- [ ] Kurz pak nelze provozovat přes internet

> Herní odměny mohou přesunout pozornost od učení k samotnému sbírání bodů a žebříčky mohou slabší studenty demotivovat. Gamifikace proto vyžaduje promyšlené nastavení.

## LMS — systém pro řízení výuky {#lms .explain}

LMS (Learning Management System) je aplikace, která **řídí a administruje vzdělávání** — eviduje, kdo se má co naučit, zpřístupňuje kurzy a sleduje výsledky. Hlavní funkce:

- **správa kurzů** — katalog, zápis, zpřístupnění obsahu, termíny;
- **správa uživatelů a rolí** — studenti, lektoři, správci, skupiny;
- **sledování pokroku** — co student otevřel, dokončil a jak dlouho studoval;
- **testování a hodnocení** — testy, úkoly, známky, certifikáty;
- **komunikace** — fóra, zprávy, oznámení;
- **reporting** — přehledy pro lektory a manažery.

Ve firmě se LMS často napojuje na personální systém, aby kurzy přiděloval podle pracovní pozice. Příkladem open source LMS je **Moodle**.

*Příklad:* Personální oddělení v LMS zjistí, kterým zaměstnancům končí platnost školení BOZP, a systém jim kurz automaticky přidělí i s termínem splnění.

### ? Personální ředitel potřebuje přehled, kteří zaměstnanci dosud nesplnili povinné školení o ochraně osobních údajů. Která funkce LMS mu ho poskytne?

- [ ] Správa a verzování výukových objektů
- [ ] Interaktivní tabule pro živou výuku
- [x] Sledování pokroku a reporting
- [ ] Diskusní fórum v rámci kurzu

> LMS eviduje, kdo kurz dokončil, a z těchto dat vytváří přehledy pro manažery. Verzování obsahu je doménou LCMS, tabule a fórum slouží výuce, ne vyhodnocení.

### ? Co NENÍ typickou funkcí LMS?

- [x] Vedení účetnictví a mzdové agendy
- [ ] Zápis studentů do kurzů a správa rolí
- [ ] Testování a evidence výsledků studentů
- [ ] Sledování pokroku studentů v kurzech

> Účetnictví a mzdy patří do ERP (modul financí a personalistiky). LMS se může na personální systém napojit, ale sám řídí jen vzdělávání.

## LMS × LCMS {#lms-vs-lcms .compare}

LMS řídí **výuku a studenty**, LCMS (Learning Content Management System) **výukový obsah**. V praxi se často kombinují nebo bývají součástí jedné platformy.

| | LMS | LCMS |
|---|---|---|
| Zaměření | řízení a administrace výuky | tvorba a správa výukového obsahu |
| Hlavní uživatelé | studenti, lektoři, správci, personalisté | autoři obsahu, instrukční designéři |
| Typické funkce | zápis, kurzy, testy, sledování, reporting | tvorba, verze, repozitář výukových objektů, opakované použití |
| Odpovídá na otázku | kdo se co naučil a s jakým výsledkem | z čeho a jak je kurz sestaven |

### ? Firma chce, aby autoři vytvářeli výukové objekty, verzovali je a skládali z nich různé kurzy pro různé pozice. Jaký typ systému potřebuje především?

- [ ] LMS — systém pro řízení výuky
- [x] LCMS — systém pro správu výukového obsahu
- [ ] DMS — systém pro správu dokumentů
- [ ] CRM — systém pro řízení vztahů se zákazníky

> Tvorba, verzování a opakované použití výukových objektů je hlavní úlohou LCMS. LMS se zaměřuje na studenty a průběh výuky, DMS spravuje obecné dokumenty bez výukové logiky.

### ? Kdo jsou hlavní uživatelé LCMS?

- [ ] Studenti absolvující zadané kurzy
- [ ] Manažeři sledující výsledky školení
- [x] Autoři a tvůrci výukového obsahu
- [ ] Správci firemní počítačové sítě

> LCMS slouží především těm, kdo výukový obsah vytvářejí a spravují. Studenti a manažeři pracují hlavně s LMS.

## Standardy SCORM a xAPI {#scorm-xapi .explain}

Standardy eLearningu zajišťují **interoperabilitu** — aby výukový obsah od jednoho dodavatele fungoval v různých LMS a dal se znovu použít.

- **SCORM** (Sharable Content Object Reference Model) — soubor specifikací iniciativy ADL (Advanced Distributed Learning). Určuje, jak se obsah **zabalí** do balíčku s manifestem (vychází ze specifikace IMS Content Packaging) a jak obsah za běhu **komunikuje s LMS** — předává např. dokončení lekce a výsledek testu. Rozšířené jsou verze 1.2 a 2004.
- **xAPI** (Experience API, dříve Tin Can API) — zaznamenává učební zkušenosti jako výroky typu **„kdo – co udělal – s čím"** (např. „Jana dokončila simulaci") do úložiště **LRS** (Learning Record Store). Umožňuje sledovat učení i mimo LMS a prohlížeč — v mobilní aplikaci, simulátoru nebo offline.

*Příklad:* Firma koupí od externího dodavatele kurz BOZP jako SCORM balíček a nahraje jej do svého LMS, který pak eviduje, kdo kurz dokončil a s jakým výsledkem.

### ? Firma nakupuje kurzy od více dodavatelů a chce je všechny provozovat ve svém LMS včetně evidence výsledků. Jaký standard by měla od dodavatelů vyžadovat?

- [x] SCORM
- [ ] SCOR
- [ ] UN/EDIFACT
- [ ] BPMN

> SCORM určuje balení výukového obsahu a jeho komunikaci s LMS, takže kurz od kteréhokoli dodavatele lze nahrát a sledovat. SCOR je model dodavatelského řetězce, UN/EDIFACT standard EDI zpráv a BPMN notace procesů.

### ? Čím se standard xAPI odlišuje od SCORM?

- [ ] Popisuje pouze zabalení obsahu do archivu
- [ ] Funguje výhradně uvnitř webového prohlížeče
- [ ] Slouží k výměně obchodních dokladů mezi firmami
- [x] Sleduje učení i mimo LMS, např. v mobilní aplikaci

> xAPI ukládá záznamy o učení do LRS z libovolného prostředí — mobilní aplikace, simulátoru či offline. SCORM je vázán na spuštění obsahu v LMS.

## Efekty eLearningu {#efekty-elearningu .explain}

Hlavní přínosy aplikací eLearningu:

- **dostupnost kdykoli a kdekoli** — bez cestování a vazby na učebnu;
- **škálovatelnost** — jeden kurz pro desítky i tisíce lidí;
- **nižší náklady na jednoho studenta** — vysoké počáteční náklady na tvorbu obsahu se rozloží mezi mnoho účastníků a odpadá cestovné, pronájem učeben i část ušlé pracovní doby;
- **individuální tempo** — student se vrací k obtížným částem a přeskakuje známé;
- **jednotná kvalita a rychlá aktualizace** obsahu;
- **evidence a měřitelnost** — průkazné doložení absolvování povinných školení.

*Příklad:* Obchodní řetězec proškolí tisíce zaměstnanců na stovkách prodejen o novém pokladním systému online během dvou týdnů a náklady na tvorbu kurzu se rozdělí mezi všechny účastníky.

### ? Proč s rostoucím počtem účastníků klesají náklady eLearningu na jednoho studenta?

- [ ] Tvorba online kurzu je levnější než příprava jedné přednášky
- [x] Vysoké počáteční náklady na obsah se rozloží mezi více lidí
- [ ] Online kurz už po spuštění nepotřebuje žádnou aktualizaci
- [ ] Licence všech systémů LMS jsou poskytovány bezplatně

> Náklady na tvorbu kurzu vznikají jednou a s každým dalším účastníkem se rozpouštějí. Kvalitní obsah je naopak drahý a vyžaduje údržbu.

### ? Firma musí při kontrole doložit, že všichni zaměstnanci absolvovali školení BOZP. Který přínos eLearningu je pro ni klíčový?

- [ ] Gamifikace výuky
- [ ] Individuální tempo studia
- [x] Evidence a průkaznost absolvování
- [ ] Možnost studia na mobilu

> Systém eLearningu automaticky zaznamenává, kdo kurz a test dokončil, a firma tak má průkazný doklad. Ostatní přínosy se týkají pohodlí a motivace studentů.

## Omezení eLearningu {#omezeni-elearningu .explain}

eLearning má i nevýhody, se kterými je třeba počítat:

- **vysoké počáteční náklady** na tvorbu kvalitního obsahu a platformu;
- nutnost **sebekázně a motivace** studenta — vyšší míra nedokončení kurzů;
- **omezený osobní kontakt**, pocit izolace, slabší okamžitá zpětná vazba;
- nevhodnost pro **praktické a manuální dovednosti** a pro nácvik jednání s lidmi;
- **technické požadavky** (zařízení, připojení) a nutná digitální gramotnost;
- obtížné ověření, že test skutečně vyplnil daný student.

Proto se eLearning často kombinuje s prezenční výukou (blended learning).

*Příklad:* Výrobní firma zjistí, že obsluhu nového lisu se pracovníci z online kurzu nenaučí. Teorii a bezpečnostní pravidla proto ponechá online, ale obsluhu nacvičuje u stroje s instruktorem.

### ? Pro které školení je čistě online eLearning NEJMÉNĚ vhodný?

- [x] Nácvik manuální obsluhy výrobního stroje
- [ ] Seznámení s novými interními předpisy
- [ ] Opakování znalostí o produktovém portfoliu
- [ ] Ověření znalostí pravidel ochrany dat

> Manuální dovednosti vyžadují praktický nácvik pod dohledem instruktora, což online kurz nenahradí. Předpisy a znalosti lze online předat i ověřit dobře.

### ? Co NEPATŘÍ mezi omezení eLearningu?

- [ ] Vysoké počáteční náklady na tvorbu obsahu
- [ ] Nutnost sebekázně a vlastní motivace studenta
- [ ] Omezený osobní kontakt s lektorem a spolužáky
- [x] Nemožnost studovat vlastním tempem

> Studium vlastním tempem je naopak jedním z hlavních přínosů eLearningu. Ostatní možnosti jsou jeho typická omezení.

## mLearning (mobilní výuka) {#mlearning .term}

mLearning je forma eLearningu využívající **mobilní zařízení** — chytré telefony a tablety. Navazuje na eLearning a rozšiřuje jej o učení **kdykoli a kdekoli**, i v krátkých volných chvílích (cesta, čekání), a o možnosti mobilu: **notifikace** připomínající opakování, obsah stažený pro **offline** použití, fotoaparát či polohu. Typicky se pojí s microlearningem; obsah musí být přizpůsoben malé obrazovce (responzivní web nebo mobilní aplikace).

### ? Čím mLearning nejvíce rozšiřuje klasický eLearning?

- [ ] Vyžaduje stálé připojení ke stolnímu počítači
- [x] Umožňuje učit se v krátkých chvílích kdekoli
- [ ] Odstraňuje potřebu přizpůsobit obsah zařízení
- [ ] Hodí se hlavně pro dlouhé souvislé výklady

> Mobilní zařízení má student stále u sebe, a může se proto učit v krátkých volných chvílích. Obsah je naopak nutné přizpůsobit malé obrazovce a krátkým lekcím.

### ? Která funkce je typická právě pro mLearning?

- [ ] Distribuce kurzu na nosiči CD-ROM
- [ ] Výuka výhradně v počítačové učebně
- [x] Notifikace připomínající opakování
- [ ] Rozesílání tištěných studijních opor

> Notifikace jsou vlastností mobilních zařízení a mLearning je využívá k připomínání lekcí a opakování. CD-ROM odpovídá CBT, učebna a tištěné opory mobilní výuku nevystihují.

## Omezení a nevýhody mobilní výuky {#omezeni-mlearningu .explain}

Mobilní výuka má svá specifická omezení:

- **malý displej** — špatně se zobrazují tabulky, schémata a delší texty;
- **obtížné psaní** — dlouhé odpovědi a výpočty se na dotykové klávesnici zadávají špatně, proto převládají otázky s výběrem odpovědi;
- **rozptylování** — notifikace jiných aplikací, hlučné prostředí;
- **krátká doba soustředění** — vhodné jsou jen krátké lekce;
- **konektivita** — výpadky signálu, omezený datový tarif, výdrž baterie;
- **různorodost zařízení a operačních systémů** — obsah musí fungovat na mnoha typech;
- **bezpečnost** firemních dat na soukromých zařízeních (BYOD).

*Příklad:* Pojišťovna chce zpřístupnit v mobilu dvouhodinový kurz s rozsáhlými tabulkami tarifů. Místo prostého převodu jej rozdělí do pětiminutových lekcí s kvízy, tabulky nechá k prostudování na počítači a lekce zpřístupní i offline.

### ? Proč se v mobilních kurzech častěji používají otázky s výběrem odpovědi než otevřené otázky?

- [ ] Mobilní zařízení nepodporují zadávání textu
- [ ] Standard SCORM otevřené otázky nepřipouští
- [ ] Otevřené odpovědi nelze uložit do LMS
- [x] Psaní delších textů na mobilu je obtížné

> Psaní na dotykové klávesnici malého displeje je pomalé a nepohodlné, proto mobilní kurzy upřednostňují výběr z možností. Technicky zadávat text lze, jen je to pro studenta náročné.

### ? Firma chce převést do mobilní aplikace kurz s rozsáhlými tabulkami a hodinovými výklady. Které omezení mobilní výuky ji nejvíce ohrozí?

- [x] Malý displej a krátká doba soustředění
- [ ] Nemožnost sledovat pokrok studentů
- [ ] Neschopnost mobilu přehrát video
- [ ] Nutnost osobní přítomnosti lektora

> Rozsáhlé tabulky se na malém displeji špatně čtou a dlouhé výklady neodpovídají krátkému soustředění při učení na mobilu. Obsah je proto třeba rozdělit do krátkých lekcí.

### ? Co NEPATŘÍ mezi typická omezení mobilní výuky?

- [ ] Rozptylování notifikacemi jiných aplikací
- [x] Nemožnost učit se mimo kancelář
- [ ] Výpadky připojení a omezený datový tarif
- [ ] Obtížné psaní delších odpovědí

> Učení mimo kancelář je naopak hlavní výhodou mLearningu. Rozptylování, konektivita a obtížné psaní jsou jeho typická omezení.
