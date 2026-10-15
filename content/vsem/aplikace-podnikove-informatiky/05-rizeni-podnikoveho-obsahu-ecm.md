---
kind: topic
subject: aplikace-podnikove-informatiky
slug: rizeni-podnikoveho-obsahu-ecm
name: "Řízení podnikového obsahu (ECM)"
order: 5
---

principy řešení ECM, úlohy ECM – správa dokumentů (DMS), řízení a podpora spolupráce (groupware), řízení pracovních postupů a procesů (workflow), správa obsahu, analytické nástroje v ECM, správa neměnných dat, správa multimediálních dat, správa dokumentace výrobků (PLM).

## Řízení podnikového obsahu (ECM) {#ecm .term}

**Enterprise Content Management (ECM)** je soubor strategií, metod a aplikací pro **zachycení, správu, ukládání, uchování a doručení** podnikového obsahu — dokumentů, e-mailů, obrázků, záznamů a dalších převážně **nestrukturovaných dat** — během celého jejich životního cyklu. ECM nejde o jednu aplikaci, ale o zastřešení více úloh: správy dokumentů (DMS), spolupráce, workflow, správy webového obsahu, archivace a správy multimédií.

### ? Která oblast podnikových dat je hlavním předmětem aplikací ECM?

- [ ] Strukturované transakce v tabulkách jádra ERP
- [x] Nestrukturovaný obsah, např. dokumenty a e-maily
- [ ] Agregovaná data v hvězdicovém schématu datového skladu
- [ ] Senzorová data ze strojů ve výrobní lince

> ECM se zaměřuje na obsah, který nemá pevnou strukturu databázové tabulky — smlouvy, dopisy, e-maily, výkresy či obrázky. Transakce řeší ERP, agregovaná data datový sklad a BI.

### ? Proč se ECM označuje spíše jako koncept nebo rodina aplikací než jako jeden program?

- [ ] Protože jej lze provozovat jen jako cloudovou službu
- [ ] Protože nahrazuje celé ERP včetně účetnictví a skladu
- [ ] Protože pracuje výhradně s papírovými dokumenty
- [x] Protože zastřešuje více úloh, např. DMS a workflow

> ECM zahrnuje řadu dílčích úloh — správu dokumentů, spolupráci, workflow, správu webového obsahu, archivaci i správu multimédií. Konkrétní řešení je proto obvykle složeno z více modulů nebo produktů.

## Strukturovaná × nestrukturovaná data {#strukturovana-nestrukturovana .compare}

Podnikové aplikace pracují se dvěma odlišnými druhy dat; ECM se soustředí na ta nestrukturovaná, která tvoří velkou část firemních informací.

| | Strukturovaná data | Nestrukturovaná data |
|---|---|---|
| Podoba | záznamy s pevnými poli (řádky a sloupce) | volný text, obraz, zvuk, video |
| Příklady | objednávka v ERP, kmenová data zákazníka | smlouva v PDF, e-mail, výkres, fotografie |
| Uložení | relační databáze | souborová úložiště, repozitáře ECM |
| Vyhledávání | dotazy nad poli (např. SQL) | fulltext a vyhledávání podle metadat |
| Typické aplikace | ERP, CRM, datový sklad | ECM, DMS, DAM |

### ? Které z uvedených dat jsou typickým příkladem nestrukturovaných dat?

- [ ] Řádek faktury s kódem zboží, množstvím a cenou
- [ ] Kmenový záznam dodavatele s IČO a adresou
- [ ] Pohyb na skladové kartě s datem a množstvím
- [x] Naskenovaný dopis od zákazníka s reklamací

> Naskenovaný dopis je obraz nebo volný text bez pevných polí, proto patří mezi nestrukturovaná data. Ostatní možnosti jsou záznamy s pevnou strukturou typické pro ERP.

### ? Jak se v ECM obvykle umožňuje hledat v nestrukturovaných dokumentech?

- [x] Fulltextem a podle metadat dokumentů
- [ ] Výhradně dotazem SQL nad sloupci relační tabulky
- [ ] Jen ručním procházením složek podle data vzniku
- [ ] Pouze přes multidimenzionální kostky OLAP

> Nestrukturovaný obsah nemá pevná pole, proto se k vyhledávání používá fulltextový index jeho obsahu a metadata (autor, typ, datum, klient). SQL dotazy nad sloupci odpovídají strukturovaným datům.

## Životní cyklus obsahu v ECM {#zivotni-cyklus-obsahu .explain}

Principy řešení ECM se obvykle popisují pěti fázemi, kterými obsah prochází:

1. **Zachycení (capture)** — vznik nebo převzetí obsahu: skenování, rozpoznání textu (OCR) a **vytěžování** údajů (číslo faktury, dodavatel, částka), klasifikace dokumentu, import e-mailů a elektronických dokumentů, přiřazení metadat. Odpadá ruční přepisování a jeho chyby.
2. **Správa (manage)** — práce s obsahem: verze, přístupová práva, workflow, spolupráce.
3. **Ukládání (store)** — dočasné uložení v repozitářích a úložištích během aktivního používání.
4. **Uchování (preserve)** — dlouhodobá a neměnná archivace obsahu, který je třeba uchovat.
5. **Doručení (deliver)** — zpřístupnění obsahu uživatelům a aplikacím (portál, web, e-mail, tisk) ve vhodném formátu.

*Příklad:* Přijatá faktura se naskenuje a vytěží (zachycení), projde schválením (správa), je dostupná účetním v repozitáři (ukládání), po zaúčtování se archivuje na zákonnou dobu (uchování) a auditor ji dostane přes portál (doručení).

### ? Firma skenuje papírové dodací listy a nástroj OCR z nich rozpozná číslo objednávky. Do které fáze životního cyklu obsahu v ECM tato činnost patří?

- [ ] Uchování (preserve)
- [ ] Doručení (deliver)
- [x] Zachycení (capture)
- [ ] Správa (manage)

> Skenování, rozpoznání textu a přiřazení metadat jsou typické činnosti fáze zachycení, kdy obsah vstupuje do systému ECM.

### ? Která fáze životního cyklu obsahu v ECM odpovídá dlouhodobé a neměnné archivaci dokumentů?

- [ ] Ukládání (store)
- [x] Uchování (preserve)
- [ ] Zachycení (capture)
- [ ] Doručení (deliver)

> Uchování zajišťuje dlouhodobé, neměnné a čitelné uložení obsahu. Ukládání (store) se týká dočasného uložení během aktivní práce s obsahem.

### ? Účtárna chce, aby se z naskenovaných faktur automaticky přenášelo číslo faktury, dodavatel a částka bez ručního přepisování. Jakou funkci ECM k tomu využije?

- [x] Vytěžování údajů pomocí OCR
- [ ] Správu verzí s funkcí check-in a check-out
- [ ] Ukládání na médium typu WORM pro archivaci
- [ ] Sdílený týmový kalendář v groupwaru

> Vytěžování dat z naskenovaného obrazu (OCR, rozpoznání polí, klasifikace) patří do fáze zachycení obsahu. Verze, WORM ani kalendáře údaje z dokumentu nezískávají.

## Správa dokumentů (DMS) {#dms .term}

**Document Management System (DMS)** je aplikace pro evidenci, ukládání a správu elektronických dokumentů v centrálním **repozitáři**. Typické funkce jsou **správa verzí**, **check-in/check-out**, popis dokumentů **metadaty**, řízení **přístupových práv**, **vyhledávání** (fulltext i podle metadat) a záznam historie změn (audit trail). DMS nahrazuje nepřehledné sdílené disky a zasílání dokumentů e-mailem.

### ? Firma má smlouvy rozházené po sdílených discích a v e-mailech, nikdo neví, která verze je platná, a nelze dohledat, kdo co změnil. Kterou aplikaci ECM nasadí především?

- [ ] Správu digitálních aktiv (DAM)
- [ ] Správu webového obsahu (WCM)
- [ ] Správu životního cyklu výrobku (PLM)
- [x] Systém správy dokumentů (DMS)

> DMS poskytuje centrální repozitář, správu verzí, přístupová práva a historii změn. DAM je zaměřen na multimédia, WCM na obsah webu a PLM na dokumentaci výrobku.

### ? Která funkce NENÍ typickou funkcí systému správy dokumentů (DMS)?

- [ ] Správa verzí dokumentů
- [ ] Vyhledávání podle metadat
- [x] Výpočet mezd zaměstnanců
- [ ] Řízení přístupových práv

> Výpočet mezd je funkcí personálního a mzdového modulu ERP. Verze, metadata a přístupová práva patří k jádru DMS.

## Správa verzí a check-in / check-out {#verze-check-in-out .explain}

**Správa verzí** uchovává všechny předchozí podoby dokumentu, takže lze zjistit, kdo a kdy co změnil, a případně se vrátit ke starší verzi. Rozlišují se často **hlavní verze** (schválené, např. 1.0, 2.0) a **vedlejší verze** (pracovní, např. 1.1, 1.2). Mechanismus **check-out** dokument při otevření k úpravám **zamkne** pro ostatní, kteří jej mohou jen číst; **check-in** vrátí upravený dokument do repozitáře jako novou verzi a zámek uvolní. Tím se zabrání tomu, aby si dva lidé navzájem přepsali změny.

*Příklad:* Právník si vezme rámcovou smlouvu k úpravě (check-out), kolegyně ji mezitím může jen číst; po uložení (check-in) vznikne verze 1.3 a dokument je opět volný.

### ? Dva obchodníci současně upravovali tutéž nabídku a jeden druhému přepsal změny. Který mechanismus DMS tomu zabrání?

- [ ] Fulltextové indexování obsahu dokumentu
- [x] Mechanismus check-out a check-in
- [ ] Automatická klasifikace dokumentu podle typu
- [ ] Uložení dokumentu na médium typu WORM

> Check-out dokument zamkne pro úpravy jednomu uživateli, ostatní jej mohou jen číst. Check-in uloží novou verzi a zámek uvolní, takže změny se nepřepisují.

### ? Co se stane při operaci check-in v systému správy dokumentů?

- [ ] Dokument se zamkne a nikdo jiný jej nesmí ani číst
- [ ] Dokument se trvale archivuje a nelze jej dál měnit
- [ ] Dokument se automaticky smaže ze všech složek
- [x] Uloží se jako nová verze a zámek se uvolní

> Check-in vrací upravený dokument do repozitáře jako novou verzi a uvolňuje zámek z check-outu. Neměnnou archivaci zajišťuje správa záznamů a archiv, nikoli check-in.

## Metadata a klasifikace dokumentů {#metadata .term}

**Metadata** jsou „data o datech" — popisné údaje o dokumentu, jako je typ dokumentu, autor, datum, klient, číslo smlouvy, stav nebo doba uchování. Umožňují dokumenty **třídit, vyhledávat, řídit k nim přístup a spouštět nad nimi workflow** bez ohledu na to, ve které složce leží. Jednotné třídění zajišťuje **taxonomie** (klasifikační schéma) — dohodnutá struktura kategorií a povinných atributů.

### ? Banka chce dohledat všechny smlouvy konkrétního klienta podepsané v loňském roce, přestože leží v různých složkách. Co jí to v ECM umožní?

- [ ] Uložení smluv na médium typu WORM
- [ ] Sdílený týmový prostor v groupwaru
- [x] Metadata dokumentů (klient, typ, datum)
- [ ] Nativní mobilní aplikace pro všechny obchodníky

> Metadata popisují dokument údaji jako klient, typ a datum podpisu, takže lze vyhledávat napříč úložištěm bez ohledu na umístění souboru.

## Groupware — podpora spolupráce {#groupware .explain}

**Groupware** jsou aplikace pro **podporu týmové spolupráce a komunikace**. Patří sem e-mail, **sdílené kalendáře** a plánování schůzek, sdílené kontakty a úkoly, **týmové prostory** se sdílenými dokumenty, diskusní fóra, chat a videokonference. Podporuje spolupráci **synchronní** (účastníci současně — chat, videokonference) i **asynchronní** (v různém čase — e-mail, diskuse, sdílené dokumenty). Na rozdíl od workflow groupware **neurčuje pevný postup** práce — dává týmu prostor a nástroje, ale pořadí kroků nechává na lidech.

*Příklad:* Projektový tým má společný prostor se sdílenými dokumenty, kalendářem porad a diskusí; termín schůzky naplánuje vedoucí podle volných termínů ve sdíleném kalendáři.

### ? Vedoucí týmu potřebuje najít termín porady, kdy mají všichni členové volno, a založit pro tým společný prostor s dokumenty a diskusí. Kterou úlohu ECM využije?

- [x] Groupware pro podporu spolupráce
- [ ] Workflow pro řízení pracovních postupů
- [ ] Records management pro správu záznamů
- [ ] Správu digitálních aktiv (DAM)

> Sdílené kalendáře, týmové prostory a diskuse jsou typické funkce groupwaru. Workflow řídí předem definovaný postup, records management uchování záznamů a DAM multimédia.

### ? Které z uvedených nástrojů groupwaru podporují synchronní spolupráci?

- [ ] E-mail a diskusní fórum
- [ ] Sdílené dokumenty a seznam úkolů
- [x] Videokonference a chat
- [ ] Sdílený kalendář a kontakty

> Synchronní spolupráce probíhá současně, v reálném čase — typicky videokonference nebo chat. E-mail, fórum či sdílené dokumenty umožňují spolupráci asynchronní, každý v jiném čase.

## Workflow — řízení pracovních postupů {#workflow .explain}

**Workflow** je automatizace pracovního postupu, při které se dokumenty, informace nebo úkoly předávají mezi účastníky podle **předem definovaných pravidel**: kdo, v jakém pořadí, v jakém termínu a za jakých podmínek má krok provést. Systém workflow (workflow management system) úkol **přidělí, hlídá termíny, eskaluje** zpoždění a zaznamenává, kdo co schválil. Postupy mohou být **sekvenční** (krok za krokem), **paralelní** i **podmíněné** (např. podle výše částky).

*Příklad:* Přijatá faktura do 50 000 Kč jde ke schválení vedoucímu nákladového střediska, vyšší částka navíc finančnímu řediteli; nevyřízený úkol systém po třech dnech připomene a eskaluje.

### ? Firma chce, aby objednávky nad určitou částku automaticky putovaly ke schválení řediteli, systém hlídal termíny a zaznamenal, kdo co schválil. Kterou úlohu ECM nasadí?

- [ ] Groupware se sdíleným kalendářem
- [ ] Správu webového obsahu (WCM)
- [ ] Fulltextové vyhledávání nad archivem
- [x] Workflow se schvalovacím postupem

> Workflow automaticky směruje úkoly podle pravidel (např. výše částky), hlídá termíny a zaznamenává schválení. Groupware pevný postup neurčuje.

### ? Co odlišuje workflow od groupwaru?

- [ ] Workflow slouží jen ke sdílení kalendářů a kontaktů
- [x] Workflow řídí práci podle předem daných kroků
- [ ] Workflow nepracuje s dokumenty, jen s e-maily
- [ ] Workflow podporuje výhradně synchronní komunikaci

> Workflow předepisuje postup — kdo, kdy a v jakém pořadí krok provede. Groupware poskytuje prostor a nástroje ke spolupráci, ale pořadí kroků neřídí.

## Workflow a řízení podnikových procesů (BPM) {#workflow-bpm .explain}

Workflow v ECM se obvykle týká **dokumentově orientovaných postupů** — oběhu a schvalování dokumentů (faktur, smluv, žádostí). **BPM** (Business Process Management) je širší přístup k **modelování, automatizaci, sledování a zlepšování podnikových procesů** napříč aplikacemi; procesy se často modelují v notaci **BPMN** a vykonávají v procesním enginu, který může volat i jiné systémy (např. ERP nebo CRM). Workflow lze chápat jako technický prostředek automatizace, BPM jako manažerský i technologický rámec řízení procesů jako celku.

*Příklad:* Schvalování dovolenek je jednoduché workflow; řízení celého procesu od přijetí objednávky po fakturaci napříč CRM, ERP a skladem s měřením průběžné doby je úloha BPM.

### ? Čím se BPM (Business Process Management) liší od jednoduchého dokumentového workflow?

- [ ] BPM se týká pouze oběhu papírových dokumentů
- [ ] BPM nahrazuje DMS i archivaci dokumentů
- [ ] BPM nepoužívá žádné modely ani notace procesů
- [x] BPM modeluje, řídí a zlepšuje procesy napříč aplikacemi

> BPM je širší přístup k řízení procesů — zahrnuje modelování (např. BPMN), automatizaci, měření a zlepšování napříč systémy. Dokumentové workflow řeší hlavně oběh a schvalování dokumentů.

## DMS × groupware × workflow {#dms-groupware-workflow .compare}

Tři základní úlohy ECM se často kombinují, ale každá řeší jiný problém.

| | DMS | Groupware | Workflow |
|---|---|---|---|
| Řeší | evidenci a správu dokumentů | týmovou spolupráci a komunikaci | řízení postupu práce |
| Klíčové funkce | repozitář, verze, check-in/out, metadata | e-mail, kalendáře, týmové prostory, chat | směrování úkolů, pravidla, termíny, eskalace |
| Struktura práce | — | volná, určuje ji tým | předem definovaná |
| Typická otázka | „Kde je platná verze smlouvy?" | „Kdy se sejdeme a kde sdílíme podklady?" | „Kdo má teď fakturu schválit?" |

### ? Firma řeší problém: „Nevíme, kdo má teď fakturu schválit a proč se schvalování zdrželo." Která úloha ECM tento problém řeší?

- [ ] DMS
- [x] Workflow
- [ ] Groupware
- [ ] DAM

> Workflow určuje, kdo má v daném kroku úkol provést, hlídá termíny a eviduje průběh schvalování. DMS řeší evidenci a verze dokumentů, groupware volnou spolupráci.

### ? Firma řeší problém: „Nevíme, která verze ceníku je platná a kdo ji naposledy změnil." Která úloha ECM tento problém řeší?

- [x] DMS
- [ ] Groupware
- [ ] Workflow
- [ ] WCM

> Správa verzí a historie změn je jádrem DMS. Groupware podporuje komunikaci a workflow řídí postup práce, verze dokumentů ale neeviduje.

## Správa webového obsahu (WCM) {#wcm .explain}

**Web Content Management (WCM)** je úloha ECM pro tvorbu, správu a publikování obsahu webových stránek, portálů a intranetu. Základním principem je **oddělení obsahu od prezentace (vzhledu)**: redaktoři vkládají text a obrázky do formulářů a šablony zajistí jednotný vzhled, takže web mohou spravovat i lidé bez znalosti HTML. Typické funkce jsou **šablony**, **schvalovací workflow před publikací**, **plánované zveřejnění a stažení** obsahu, správa verzí stránek, jazykové mutace a řízení práv redaktorů.

*Příklad:* Marketing připraví tiskovou zprávu v redakčním systému, vedoucí ji schválí a systém ji zveřejní na webu i v intranetu v nastaveném čase ve firemním vzhledu.

### ? Marketingové oddělení chce samo, bez programátorů, vkládat a schvalovat články na firemní web, které se zobrazí v jednotném vzhledu. Kterou úlohu ECM využije?

- [ ] Správu dokumentace výrobku (PLM)
- [ ] Records management
- [x] Správu webového obsahu (WCM)
- [ ] Vytěžování dokumentů pomocí OCR

> WCM odděluje obsah od vzhledu: redaktoři vkládají obsah a šablony zajistí jednotný vzhled. Součástí bývá i schválení před publikací.

### ? Co je základním principem systémů pro správu webového obsahu (WCM)?

- [x] Oddělení obsahu stránek od jejich prezentace (vzhledu)
- [ ] Neměnné uložení obsahu na média typu WORM
- [ ] Zamčení stránky pro všechny uživatele po zveřejnění
- [ ] Ukládání obsahu výhradně v podobě obrázků

> Díky oddělení obsahu od prezentace redaktoři spravují texty a obrázky, zatímco vzhled určují šablony. Ostatní možnosti s principem WCM nesouvisejí.

## Analytické nástroje v ECM {#analyticke-nastroje .explain}

Aby byl nestrukturovaný obsah využitelný, nabízí ECM analytické nástroje:

- **Fulltextové a podnikové vyhledávání** (enterprise search) — prohledává obsah dokumentů v různých úložištích najednou a respektuje přístupová práva.
- **Automatická klasifikace** — zařazení dokumentu do kategorie a doplnění metadat podle jeho obsahu.
- **Text mining (dolování z textu)** — hledání vzorců, témat, pojmů a souvislostí ve velkém množství textů, např. četnost témat stížností nebo rozpoznání nálady (sentimentu).
- **Reporty o obsahu a jeho využití** — kolik dokumentů vzniká, jak dlouho trvá schvalování, kdo co čte.

*Příklad:* Pojišťovna analyzuje text tisíců reklamací a zjistí, že nejčastěji opakovaným tématem je zpožděná výplata plnění u jednoho typu pojistky.

### ? Firma chce z tisíců volně psaných zákaznických stížností automaticky zjistit nejčastější témata a jejich vývoj v čase. Který analytický nástroj ECM použije?

- [ ] Správu verzí dokumentů
- [x] Text mining (dolování z textu)
- [ ] Mechanismus check-in a check-out
- [ ] Neměnné úložiště typu WORM

> Text mining hledá vzorce, témata a souvislosti v nestrukturovaném textu. Správa verzí, check-in/out ani WORM obsah textů neanalyzují.

### ? Zaměstnanci potřebují jedním dotazem prohledat dokumenty v DMS, intranetu i e-mailových archivech, přičemž vidí jen to, k čemu mají oprávnění. Co firma nasadí?

- [ ] Sdílený kalendář v groupwaru
- [ ] Schvalovací workflow
- [ ] Správu digitálních aktiv (DAM)
- [x] Podnikové vyhledávání (enterprise search)

> Podnikové vyhledávání indexuje obsah z více úložišť a výsledky filtruje podle přístupových práv uživatele. Ostatní nástroje vyhledávání napříč úložišti neřeší.

## Správa neměnných dat a records management {#records-management .explain}

Část obsahu musí být po dokončení uchována **beze změny** — kvůli zákonu, auditu nebo důkazní hodnotě (účetní doklady, smlouvy, personální spisy). Tuto úlohu řeší **správa záznamů** (records management). Dokument, který je prohlášen za **záznam** (record), už nelze měnit ani libovolně smazat. Pro každý typ záznamu se stanoví **doba uchování** (skartační lhůta) a po jejím uplynutí se záznam řízeně **vyřadí** (skartuje) nebo předá do archivu; vše se zaznamenává v auditní stopě. Pracovní dokument v DMS se tedy mění a verzuje, záznam je naopak zafixovaný.

*Příklad:* Podepsaná pracovní smlouva se prohlásí za záznam s dobou uchování podle předpisů; po jejím uplynutí systém navrhne vyřazení a o skartaci vznikne protokol.

### ? Čím se záznam (record) v records managementu liší od běžného pracovního dokumentu v DMS?

- [ ] Záznam lze libovolně upravovat a vytvářet jeho nové verze
- [x] Záznam je zafixován beze změn a má stanovenou dobu uchování
- [ ] Záznam se ukládá jen v papírové podobě mimo systém
- [ ] Záznam je vždy veřejně dostupný na webu firmy

> Prohlášením za záznam se dokument zafixuje — nelze jej měnit ani libovolně smazat a řídí se dobou uchování. Pracovní dokument se naopak upravuje a verzuje.

### ? Co se v records managementu děje se záznamem po uplynutí jeho doby uchování?

- [ ] Automaticky se převede zpět na upravitelný dokument
- [ ] Zůstane navždy v systému bez dalšího posouzení
- [x] Řízeně se vyřadí (skartuje) nebo předá do archivu
- [ ] Odešle se e-mailem všem zaměstnancům k připomínkám

> Po uplynutí doby uchování proběhne řízené vyřazení — záznam se skartuje, nebo se předá k trvalé archivaci; o vyřazení zůstává auditní stopa.

## Archivace, WORM a dlouhodobé uchování {#archivace-worm .explain}

Archivace v ECM zajišťuje, aby obsah zůstal po dlouhou dobu **neporušený, čitelný a dohledatelný**. K neměnnosti slouží úložiště typu **WORM** (Write Once, Read Many) — data lze zapsat jednou a pak už jen číst, nikoli přepsat či smazat (dříve optické disky, dnes i diskové a cloudové úložiště s uzamčením po stanovenou dobu). U **dlouhodobého uchování** hrozí, že starý formát nepůjde otevřít, proto se používají archivní formáty (např. **PDF/A**), metadata a plánovaná **migrace** obsahu na nová média a formáty.

*Příklad:* Firma ukládá zaúčtované doklady do archivu se zámkem WORM na dobu požadovanou předpisy a smlouvy převádí do PDF/A, aby byly čitelné i za mnoho let.

### ? Firma potřebuje úložiště, na kterém nikdo — ani administrátor — nemůže archivované doklady přepsat nebo smazat. Jaký typ úložiště zvolí?

- [x] Úložiště typu WORM (Write Once, Read Many)
- [ ] Sdílený síťový disk s pravidelnou zálohou
- [ ] Týmový prostor v groupwaru s právy na zápis
- [ ] Redakční systém pro správu webového obsahu

> WORM umožňuje data zapsat jen jednou a dále je pouze číst, takže je nelze přepsat ani smazat. Běžný disk či týmový prostor změny dovolují.

### ? Proč se při dlouhodobé archivaci elektronických dokumentů používají formáty jako PDF/A a plánuje se migrace obsahu?

- [ ] Aby dokumenty zabraly co nejméně místa na disku
- [ ] Aby je mohli redaktoři snadno upravovat na webu
- [x] Aby dokumenty zůstaly čitelné i po zastarání technologií
- [ ] Aby se dokumenty automaticky smazaly po pěti letech

> Hlavním rizikem dlouhodobého uchování je zastarání formátů a médií. Archivní formáty jako PDF/A a migrace na nové technologie zajišťují, že obsah půjde přečíst i za mnoho let.

## Elektronický podpis, pečeť a časové razítko {#podpis-pecet .compare}

V ECM a archivaci zajišťují **pravost (autenticitu) a neporušenost (integritu)** elektronických dokumentů. V EU je upravuje nařízení **eIDAS**.

| | Elektronický podpis | Elektronická pečeť | Časové razítko |
|---|---|---|---|
| Kdo jej vytváří | fyzická osoba (člověk) | právnická osoba (firma, úřad) | poskytovatel služby vytvářející důvěru |
| Co prokazuje | u zaručeného a kvalifikovaného podpisu: kdo dokument podepsal a že se od podpisu nezměnil | že dokument pochází od organizace a nezměnil se | že dokument existoval v daném okamžiku (kvalifikované razítko i to, že se od té doby nezměnil) |
| Typické užití | smlouva podepsaná ředitelem | automaticky opečetěné faktury či výpisy | prokázání času, dlouhodobé uchování |

### ? Firma chce, aby každá automaticky generovaná elektronická faktura nesla záruku původu od firmy jako organizace, bez podpisu konkrétního člověka. Co použije?

- [ ] Elektronický podpis jednatele
- [ ] Úložiště typu WORM
- [ ] Naskenovaný vlastnoruční podpis
- [x] Elektronickou pečeť firmy

> Elektronická pečeť patří právnické osobě a prokazuje původ a neporušenost dokumentu bez vazby na konkrétního člověka. Elektronický podpis vytváří fyzická osoba.

### ? Co prokazuje kvalifikované časové razítko připojené k elektronickému dokumentu?

- [ ] Kdo konkrétně dokument vytvořil a schválil
- [ ] Že dokument nelze nikdy smazat z úložiště
- [x] Že dokument existoval v daném okamžiku a od té doby se nezměnil
- [ ] Že dokument prošel všemi kroky schvalovacího workflow

> Časové razítko spojuje dokument s přesným časovým okamžikem a umožňuje ověřit, že se od té doby nezměnil. Totožnost autora prokazuje podpis, neměnnost uložení WORM.

## Správa multimediálních dat (DAM) {#dam .term}

**Digital Asset Management (DAM)** je úloha ECM pro správu **multimediálního obsahu** — fotografií, grafiky, loga, videa, zvuku a prezentací. Kromě ukládání a metadat (autor, klíčová slova, rozlišení) řeší specifika multimédií: **náhledy**, převod do různých **formátů a rozlišení**, správu **licencí a užívacích práv** a distribuci do kanálů (web, e-shop, tisk, sociální sítě).

### ? Marketing potřebuje centrálně spravovat tisíce produktových fotografií a videí, hlídat licence fotografů a automaticky generovat verze v různém rozlišení pro web a tisk. Kterou úlohu ECM využije?

- [ ] Records management
- [x] Správu digitálních aktiv (DAM)
- [ ] Workflow pro schvalování faktur
- [ ] Správu dokumentace výrobku (PLM)

> DAM je určen pro multimediální obsah — včetně náhledů, převodů formátů a rozlišení a správy licencí. Records management řeší uchování záznamů, PLM technickou dokumentaci výrobku.

## Správa dokumentace výrobků (PLM) {#plm .explain}

**PLM** (Product Lifecycle Management) řídí informace o výrobku během celého jeho **životního cyklu** — od návrhu a vývoje přes výrobu a servis až po stažení z trhu. V rámci ECM jde zejména o **správu technické dokumentace výrobku**: výkresy a modely z **CAD**, **kusovníky** (BOM — Bill of Materials), specifikace, technologické postupy, návody a certifikáty. Klíčové je **řízení technických změn** (engineering change management) — každá změna konstrukce se schvaluje, verzuje a promítne do navazujících dokumentů i do výroby. Jádrem PLM bývá správa produktových dat (**PDM** — Product Data Management); PLM se propojuje s ERP, které z kusovníku plánuje výrobu a nákup.

*Příklad:* Konstruktér změní rozměr dílu v CAD modelu; změna projde schválením, vznikne nová revize výkresu a upravený kusovník se předá do ERP pro výrobu.

### ? Strojírenská firma potřebuje spravovat výkresy z CAD, kusovníky a schvalovat technické změny konstrukce v průběhu celého života výrobku. Jakou aplikaci nasadí?

- [ ] Správu webového obsahu (WCM)
- [ ] Groupware se sdíleným kalendářem
- [ ] Správu digitálních aktiv (DAM)
- [x] PLM (Product Lifecycle Management)

> PLM spravuje technickou dokumentaci výrobku — CAD výkresy, kusovníky, specifikace — a řídí technické změny v celém životním cyklu výrobku.

### ? Jak spolu typicky souvisí PLM a ERP?

- [x] Kusovník a technické údaje z PLM slouží ERP k plánování výroby a nákupu
- [ ] ERP vytváří výkresy, které PLM následně účtuje do hlavní knihy
- [ ] PLM nahrazuje ERP, takže firma už ERP nepotřebuje
- [ ] PLM a ERP spolu nesouvisejí, každý řeší jinou firmu

> PLM je zdrojem technických dat o výrobku, zejména kusovníku; ERP je využívá k plánování výroby, nákupu materiálu a kalkulacím.

## Přínosy a rizika zavedení ECM {#prinosy-ecm .explain}

**Přínosy:** rychlejší dohledání informací, jedna platná verze dokumentu, kratší doba oběhu a schválení dokumentů díky workflow, méně papíru a ručního přepisování, lepší kontrola přístupu a bezpečnost, plnění zákonných povinností uchování a auditovatelnost, lepší týmová spolupráce. **Rizika a předpoklady úspěchu:** nedostatečně promyšlená struktura metadat a taxonomie, odpor uživatelů k nové práci s dokumenty, převod dosavadních dokumentů, integrace s ERP a e-mailem a nutnost nejdřív vyjasnit samotné procesy — automatizace chaotického postupu jej jen zrychlí, nezlepší.

*Příklad:* Po zavedení DMS a schvalovacího workflow se v distribuční firmě zkrátilo schvalování faktur a odpadlo hledání papírových originálů, ale až poté, co se sjednotila pravidla, kdo co schvaluje.

### ? Který z uvedených bodů NEPATŘÍ mezi typické přínosy zavedení ECM?

- [ ] Rychlejší dohledání dokumentů a jedna platná verze
- [ ] Kratší oběh a schvalování dokumentů díky workflow
- [ ] Snazší plnění povinností uchování a auditovatelnost
- [x] Automatické zlepšení špatně navržených procesů

> ECM postup práce zautomatizuje, ale chybně navržený proces samo nezlepší — procesy je třeba vyjasnit před automatizací. Ostatní body jsou typickými přínosy ECM.
