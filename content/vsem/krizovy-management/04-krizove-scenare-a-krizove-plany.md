---
kind: topic
subject: krizovy-management
slug: krizove-scenare-a-krizove-plany
name: "Krizové scénáře a krizové plány"
order: 4
---

Vymezení pojmů. Cíl, struktura a požadavky na zpracování scénářů a plánů. Využití a postup implementace. Trénink na krizové situace. Dokumentace. Legislativa. Business Continuity Management.

## Krizový scénář {#krizovy-scenar .term}

Krizový scénář je **modelový popis možného vývoje krizové situace** — co ji spustí (iniciační událost), jak se může vyvíjet v čase, jaké bude mít dopady a jaká opatření a zdroje bude její zvládnutí vyžadovat. Scénář neslouží k přesné předpovědi budoucnosti, ale jako **podklad pro krizové plánování a cvičení**: podle něj se navrhují postupy plánu a ověřuje připravenost organizace.

### ? Jaký je hlavní účel krizového scénáře?

- [ ] Přesně předpovědět, kdy krize nastane
- [x] Sloužit jako podklad pro plánování a cvičení
- [ ] Nahradit krizový plán a jeho pravidelné cvičení
- [ ] Předem určit viníka budoucí krize

> Scénář popisuje možný vývoj krize a její dopady, aby se na něj dalo připravit plán a podle něj cvičit. Budoucnost přesně nepředpovídá a plán nenahrazuje.

### ? Výrobní firma popsala, že požár skladu by zastavil expedici, po dvou dnech by začali odcházet odběratelé a bylo by nutné najít náhradní sklad. Jaký dokument firma zpracovala?

- [ ] Krizový plán
- [ ] Bezpečnostní zprávu
- [ ] Plán obnovy IT (DRP)
- [x] Krizový scénář

> Popis spouštěcí události, vývoje v čase a dopadů je krizový scénář. Krizový plán by navíc určoval, kdo co udělá, s jakými zdroji a v jakém pořadí.

## Krizový plán {#krizovy-plan .term}

Krizový plán je dokument, který předem stanoví, **kdo, co, kdy a s jakými zdroji dělá** při vzniku krizové situace — kritéria aktivace, krizový tým a jeho pravomoci, postupy reakce, komunikaci, kontakty a zdroje. Zatímco scénář popisuje, **co se může stát**, plán určuje, **jak na to organizace odpoví**. Cílem je zkrátit dobu reakce, omezit improvizaci a škody a zajistit koordinaci.

### ? Jaký je základní rozdíl mezi krizovým scénářem a krizovým plánem?

- [x] Scénář popisuje vývoj, plán reakci na něj
- [ ] Scénář určuje role, plán popisuje dopady krize
- [ ] Scénář je závazný, plán je jen doporučením
- [ ] Scénář tvoří stát, plán výhradně podnik

> Scénář odpovídá na otázku „co se může stát", plán na otázku „jak zareagujeme" — určuje role, postupy, komunikaci a zdroje.

### ? Proč má mít organizace krizový plán připravený předem?

- [ ] Aby v krizi nebylo nutné nic rozhodovat
- [ ] Protože nahrazuje pojištění majetku
- [x] Aby zkrátil reakci a omezil improvizaci
- [ ] Aby krize vůbec nemohla nastat

> Připravený plán šetří čas a snižuje počet chyb v situaci časového tlaku. Rozhodování v krizi neodstraní a vzniku krize sám nezabrání.

## Krizový plán × havarijní plán × plán kontinuity {#typy-planu .compare}

Pojmy se v praxi překrývají; liší se hlavně zaměřením a podkladem, ze kterého vycházejí.

| | Krizový plán | Havarijní plán | Plán kontinuity (BCP) |
|---|---|---|---|
| Zaměření | řízení organizace v krizové situaci jako celku | zásah při havárii (únik nebezpečné látky, požár, výbuch) | udržení a obnova kritických činností |
| Hlavní otázka | kdo rozhoduje a jak koordinovat reakci | jak chránit životy, zdraví, majetek a životní prostředí | jak pokračovat v klíčových činnostech a do kdy je obnovit |
| Typický podklad | krizové scénáře, analýza rizik | analýza rizik havárie | analýza dopadů (BIA) |
| Časový rámec | od aktivace do odvolání krizového režimu | akutní zásah — hodiny až dny | od narušení do obnovy běžného provozu |

Krizová komunikace se promítá do všech tří; plán obnovy IT po havárii (DRP) je technickou součástí plánu kontinuity.

### ? Chemička řeší, jak při úniku amoniaku varovat zaměstnance, zastavit únik a spolupracovat s hasiči. Který plán to primárně upravuje?

- [ ] Plán kontinuity činností
- [x] Havarijní plán
- [ ] Plán obnovy IT (DRP)
- [ ] Komunikační plán

> Zásah při havárii s cílem chránit životy, zdraví a prostředí je obsahem havarijního plánu. Plán kontinuity by řešil, jak pak obnovit výrobu a dodávky.

### ? Pojišťovna řeší, jak při nedostupnosti hlavní budovy do 24 hodin obnovit vyřizování pojistných událostí z jiného místa. Který plán to upravuje?

- [x] Plán kontinuity činností
- [ ] Havarijní plán
- [ ] Plán krizové komunikace
- [ ] Vnější havarijní plán

> Obnova kritické činnosti v cílové době a z náhradního pracoviště je typickým obsahem plánu kontinuity. Havarijní plány řeší zásah při havárii.

## Cíl a požadavky na zpracování krizových plánů {#pozadavky-na-plany .explain}

Cílem krizového plánu je, aby organizace v krizi reagovala **rychle, koordinovaně a s co nejmenšími škodami**. Dobře zpracovaný plán splňuje tyto požadavky:

- **jednoduchost a srozumitelnost** — pod stresem nikdo nečte desítky stran; stručné postupy a kontrolní seznamy (checklisty),
- **realizovatelnost** — postupy počítají s lidmi a zdroji, které jsou skutečně k dispozici,
- **jednoznačné odpovědnosti** — u každého úkolu je jasné, kdo ho plní a kdo ho zastupuje,
- **pružnost** — plán nemůže popsat každou situaci, proto obsahuje i obecné postupy a nechává prostor pro rozhodnutí,
- **aktuálnost** — lidé, kontakty a systémy se mění,
- **dostupnost** — plán je k dispozici i při výpadku IT nebo nepřístupnosti budovy,
- **provázanost** s dalšími plány organizace i s plány obce, kraje a složek IZS.

*Příklad:* Firma nahradí 120stránkový krizový manuál desetistránkovým plánem s kontrolními seznamy pro jednotlivé role; podrobné podklady přesune do příloh.

### ? Krizový plán firmy má 150 stran souvislého textu a je uložen jen na interním serveru. Které požadavky porušuje?

- [ ] Pružnost a provázanost s IZS
- [x] Srozumitelnost a dostupnost při výpadku
- [ ] Aktuálnost a jednoznačnost rolí
- [ ] Realizovatelnost a pravidelnost cvičení týmu

> Dlouhý souvislý text se v krizi pod tlakem nedá rychle použít a plán uložený jen na serveru nebude dostupný při výpadku IT. Ostatní požadavky ze zadání posoudit nelze.

### ? Proč by krizový plán neměl do detailu popisovat reakci na každou myslitelnou situaci?

- [ ] Zákon podrobné postupy v plánu zakazuje
- [x] Žádný plán nepokryje vše, musí být pružný
- [ ] Podrobné postupy jsou úkolem jen složek IZS
- [ ] Plán smí obsahovat jen seznam kontaktů

> Skutečná krize se vždy v něčem liší od předpokladů. Plán proto kombinuje konkrétní postupy pro hlavní scénáře s obecnými pravidly a prostorem pro rozhodnutí krizového týmu.

## Struktura krizového plánu {#struktura-planu .explain}

Podnikový krizový plán obvykle obsahuje:

1. **účel, rozsah a vazby** — na co se plán vztahuje, odkazy na další plány,
2. **aktivaci a eskalaci** — spouštěcí kritéria, úrovně závažnosti, kdo plán aktivuje a odvolává,
3. **krizový tým, role a odpovědnosti** včetně zástupců a pravomocí,
4. **postupy reakce** — kontrolní seznamy prvních kroků a opatření pro hlavní typy krizí,
5. **komunikaci** — vnitřní i vnější, mluvčí, předpřipravená prohlášení,
6. **zdroje** — krizové pracoviště, technika, finance, smluvní dodavatelé,
7. **kontakty** — krizový tým, zaměstnanci, IZS, úřady, klíčoví zákazníci a dodavatelé,
8. **přílohy** — formuláře, mapy, deník událostí, pravidla aktualizace.

*Příklad:* Při výpadku elektřiny v centrále vedoucí směny otevře plán v části „Aktivace", podle kritérií zjistí, že jde o vyšší úroveň závažnosti, a podle kontaktní části svolá krizový tým.

### ? Co obvykle NEPATŘÍ do podnikového krizového plánu?

- [ ] Kritéria aktivace a eskalace
- [ ] Role krizového týmu a jejich zástupci
- [ ] Kontakty na složky IZS a úřady
- [x] Roční plán prodeje a marketingu

> Krizový plán obsahuje to, co je potřeba k reakci na krizi: aktivaci, role, postupy, komunikaci, zdroje a kontakty. Obchodní plánování do něj nepatří.

### ? Proč krizový plán u každé klíčové role uvádí i zástupce?

- [x] Určená osoba nemusí být v krizi dostupná
- [ ] Zástupce vždy rozhoduje místo vedoucího
- [ ] Každé opatření musí podepsat dvě osoby
- [ ] Zástupce sepisuje plán místo vedení

> Při krizi může být klíčová osoba na dovolené, nemocná, nedosažitelná nebo sama zasažená. Zástupce zajistí, že role zůstane obsazená.

## Aktivace a eskalace {#aktivace-eskalace .explain}

Plán musí jednoznačně stanovit, **kdy a kdo jej aktivuje**. **Spouštěcí kritéria** (triggery) se definují prahovými hodnotami a příklady událostí — např. výpadek kritického systému delší než stanovená doba, zranění osob, únik osobních údajů, zájem médií. Události se třídí do **úrovní závažnosti** (např. incident řešený linií → vážný incident → krize) a podle úrovně se určuje, kdo je informován a kdo řídí. **Eskalace** je předání řešení na vyšší úroveň řízení, když událost přesáhne pravomoci či kapacity nižší úrovně nebo hrozí její rozšíření. Plán stanoví i **deeskalaci a odvolání** krizového režimu, tj. návrat k běžnému řízení.

*Příklad:* Kybernetický incident řeší nejprve IT oddělení. Když se ukáže, že útočníci zašifrovali data zákazníků, vedoucí IT jej podle eskalačních pravidel předá generálnímu řediteli, který aktivuje krizový plán.

### ? V e-shopu vypadl platební systém. IT se jej snaží obnovit, po třech hodinách ale stále nefunguje a začínají se ozývat novináři. Co by měl plán v této situaci předepisovat?

- [ ] Vyčkat, dokud IT problém samo nevyřeší
- [ ] Ihned odvolat všechna krizová opatření
- [x] Eskalovat událost na vyšší úroveň řízení
- [ ] Předat řešení dodavateli bez vědomí vedení

> Událost přerůstá kapacity a pravomoci IT a začíná ohrožovat pověst firmy, proto ji je třeba eskalovat — vedení posoudí aktivaci krizového plánu.

### ? Co je spouštěcí kritérium (trigger) krizového plánu?

- [x] Podmínka, při které se plán aktivuje
- [ ] Seznam osob, které plán schvalují
- [ ] Postup návratu k běžnému provozu
- [ ] Rozpočet vyčleněný na krizová opatření

> Spouštěcí kritérium je předem stanovená podmínka (prahová hodnota, typ události), při jejímž splnění se plán aktivuje. Díky němu se o aktivaci nerozhoduje pocitově.

## Zdroje a kontakty v krizovém plánu {#zdroje-kontakty .explain}

Plán předem zajišťuje **zdroje** pro reakci: krizové pracoviště (i záložní mimo hlavní budovu), komunikační prostředky včetně náhradních, **finance s rychlým přístupem** (pravomoc čerpat bez běžného schvalovacího procesu), techniku a materiál a **smlouvy s dodavateli uzavřené předem** (sanace, náhradní doprava, IT služby). **Kontaktní seznamy** obsahují více spojení na každou osobu, zástupce i externí subjekty (IZS, úřady, pojišťovna, banka, klíčoví zákazníci) a musí se pravidelně ověřovat. Pro rychlé vyrozumění se používá **svolávací schéma** (call tree), v němž každý informuje určené další osoby.

*Příklad:* Firma má s dodavatelem rámcovou smlouvu na vysoušení prostor po zatopení. Když praskne hlavní vodovodní potrubí, technika dorazí ještě týž den bez výběrového řízení a vyjednávání o ceně.

### ? Proč je vhodné uzavřít smlouvu s firmou na sanaci po požáru ještě dříve, než k požáru dojde?

- [ ] Smlouva uzavřená po škodě je neplatná
- [x] V krizi chybí čas na výběr a vyjednávání
- [ ] Pojišťovna by jinak škodu nikdy neuhradila
- [ ] Sanace patří výhradně do kompetence IZS

> V krizi rozhodují hodiny a dodavatelé mohou být přetížení. Předem sjednaná smlouva zaručí rychlou dostupnost služby a známé podmínky.

### ? K čemu slouží svolávací schéma (call tree)?

- [ ] K rozdělení rozpočtu mezi jednotlivá krizová opatření
- [ ] K vyhodnocení příčin krize po jejím konci
- [x] K rychlému vyrozumění členů krizového týmu
- [ ] K určení pořadí obnovy kritických činností

> Svolávací schéma určuje, kdo koho informuje, takže se zpráva rychle rozšíří k potřebným lidem bez spoléhání na jednoho člověka.

## Metody tvorby krizových scénářů {#tvorba-scenaru .explain}

Tvorba scénářů obvykle probíhá v krocích:

1. **identifikace hrozeb** — z analýzy rizik, historie vlastních i cizích incidentů, oborových zkušeností,
2. **výběr scénářů** — rizika s vysokým dopadem a reálnou pravděpodobností; scénáře se často seskupují podle **dopadu** (nedostupnost budovy, výpadek IT, ztráta lidí, výpadek dodavatele), ne podle příčiny,
3. **popis vývoje** — iniciační událost, průběh v čase, možné řetězení a souběh událostí,
4. **analýza dopadů** — na lidi, majetek, provoz, finance, zákazníky, pověst a životní prostředí,
5. **určení potřebných opatření a zdrojů**, které se přenesou do plánu.

Využívají se expertní metody (brainstorming, workshopy, metoda Delphi), **analýza „co když"** (what-if) a strom událostí.

*Příklad:* Banka místo samostatných scénářů pro požár, povodeň, výpadek proudu či blokádu budovy pracuje se scénářem „nedostupnost centrály" — reakce je ve všech případech stejná: přesun na záložní pracoviště.

### ? Proč se krizové scénáře často seskupují podle dopadu (např. „nedostupnost budovy") místo podle příčiny?

- [x] Různé příčiny vyžadují stejnou reakci
- [ ] Příčiny krizí nelze nikdy zjistit
- [ ] Dopady stanovuje krizový zákon
- [ ] Dopadové scénáře nepotřebují analýzu rizik

> Požár, povodeň i výpadek proudu mohou vést ke stejnému dopadu, na který se reaguje stejně. Seskupení podle dopadu zjednoduší plán a omezí počet scénářů.

### ? Krizový tým si klade otázky typu „Co se stane, když současně s výpadkem proudu selže i záložní zdroj?" Jakou metodu používá?

- [ ] Metodu Delphi
- [ ] Benchmarking
- [x] Analýzu „co když"
- [ ] Analýzu BCG matice

> Analýza „co když" (what-if) systematicky klade otázky po možných odchylkách a jejich důsledcích. Metoda Delphi je anonymní opakované dotazování expertů.

## Nejlepší, nejpravděpodobnější a nejhorší scénář {#varianty-scenaru .compare}

Pro jednu hrozbu se obvykle zpracovává několik variant vývoje:

| | Nejlepší (optimistický) | Nejpravděpodobnější (realistický) | Nejhorší (pesimistický) |
|---|---|---|---|
| Předpoklad | příznivý vývoj, rychlé zvládnutí | nejčastěji očekávaný průběh | souběh nepříznivých okolností |
| Využití | dolní mez potřebných zdrojů | základ běžného plánování | dimenzování rezerv a odolnosti |
| Riziko, když se spoléháme jen na něj | podcenění přípravy | nepřipravenost na vážnější vývoj | nepřiměřeně drahá příprava |

V praxi se plán dimenzuje podle **nejhoršího věrohodného scénáře** (reasonable worst case) — nejhoršího, ale ještě reálně představitelného vývoje, ne libovolné extrémní katastrofy.

### ? Firma plánuje kapacitu záložního pracoviště. Podle jakého scénáře by ji měla dimenzovat, aby obstála i při vážné krizi?

- [ ] Podle nejlepšího scénáře
- [x] Podle nejhoršího věrohodného scénáře
- [ ] Podle nejpravděpodobnějšího scénáře vývoje
- [ ] Podle průměru minulých let

> Nejhorší věrohodný scénář pokryje i vážný, ale reálný vývoj. Nejpravděpodobnější scénář by firmu nechal nepřipravenou na horší průběh.

### ? Proč se plán obvykle nedimenzuje podle absolutně nejhoršího myslitelného scénáře?

- [x] Příprava na něj by byla nepřiměřeně drahá
- [ ] Popisuje jen vývoj mimo organizaci
- [ ] Nezahrnuje dopady na pověst a hospodaření firmy
- [ ] Nedává žádnou informaci o rezervách

> Extrémní scénář s mizivou pravděpodobností by vyžadoval neúměrné náklady. Proto se volí nejhorší věrohodný scénář jako rozumný kompromis.

## Postup implementace krizových plánů {#implementace .explain}

Sepsaný plán ještě nezajišťuje připravenost. Implementace obvykle zahrnuje:

1. **schválení a podporu vrcholového vedení** — odpovědnost za plán, autorita, zdroje,
2. **zajištění zdrojů** — pracoviště, technika, smlouvy, rozpočet,
3. **seznámení a školení** — členové krizového týmu podrobně, ostatní zaměstnanci v rozsahu svých úkolů (evakuace, hlášení událostí),
4. **začlenění do běžných procesů** — hlášení incidentů, řízení změn, nástup a odchod zaměstnanců,
5. **cvičení a testování**,
6. **pravidelné vyhodnocení a aktualizaci**.

*Příklad:* Plán je schválený, ale pracovníci recepce nevědí, komu hlásit telefonickou výhrůžku bombou. Firma doplní krátké školení a na každou recepci kartu s postupem.

### ? Firma má schválený krizový plán, ale zaměstnanci o něm nevědí a nikdy se necvičil. Který krok implementace byl zanedbán?

- [ ] Schválení plánu vedením
- [ ] Analýza dopadů na činnosti
- [x] Seznámení, školení a cvičení
- [ ] Výběr krizových scénářů

> Plán, který lidé neznají a nikdy si ho nevyzkoušeli, v krizi nefunguje. Seznámení, školení a cvičení jsou nezbytnou součástí implementace.

### ? Proč je podpora vrcholového vedení podmínkou úspěšné implementace krizového plánu?

- [ ] Vedení musí plán osobně celý sepsat
- [x] Vedení zajišťuje zdroje a autoritu plánu
- [ ] Bez vedení nelze plán uložit na server
- [ ] Vedení nahrazuje krizový tým v akutní fázi

> Bez vedení nejsou peníze na zdroje ani autorita, aby se plán bral vážně a dodržoval. Sepisování plánu se deleguje.

## Trénink: formy cvičení {#cviceni .compare}

Cvičení ověřuje, zda plán funguje, a učí lidi jednat pod tlakem. Formy podle rostoucí náročnosti:

| Forma | Jak probíhá | Nasazení zdrojů | Co ověří |
|---|---|---|---|
| Procházení plánu (walkthrough) | účastníci krok za krokem projdou plán | minimální | srozumitelnost, aktuálnost kontaktů |
| Table-top (cvičení u stolu) | krizový tým diskutuje nad zadaným scénářem | nízké | rozhodování, role, komunikaci |
| Simulace (funkční cvičení) | tým řeší scénář v reálném čase s průběžnými vstupy (injekty), bez skutečného nasazení techniky | střední | koordinaci, tok informací, časování |
| Plné cvičení (full-scale) | reálné nasazení lidí a techniky — evakuace, přepnutí na zálohu, často se složkami IZS | vysoké | skutečnou funkčnost postupů a zdrojů |

Náročnost se zvyšuje postupně; část cvičení může být neohlášená, aby ověřila skutečnou připravenost.

### ? Krizový tým se sejde v zasedací místnosti, moderátor popíše scénář kybernetického útoku a členové diskutují, jak by postupovali. O jakou formu cvičení jde?

- [ ] Plné cvičení
- [ ] Funkční simulace
- [ ] Procházení kontaktů
- [x] Table-top cvičení

> Table-top je diskusní cvičení u stolu nad zadaným scénářem bez nasazení techniky. Simulace by probíhala v reálném čase s průběžnými vstupy, plné cvičení se skutečným nasazením sil.

### ? Nemocnice při cvičení skutečně evakuuje jedno oddělení a zapojí hasiče i záchrannou službu. O jakou formu cvičení jde?

- [x] Plné (full-scale) cvičení
- [ ] Table-top cvičení
- [ ] Procházení plánu
- [ ] Simulace bez skutečného nasazení sil

> Skutečné nasazení lidí a techniky včetně složek IZS je znakem plného cvičení. Ověří reálnou funkčnost postupů, je ale nejnáročnější.

### ? Jaká je hlavní výhoda table-top cvičení oproti plnému cvičení?

- [ ] Ověří skutečnou funkčnost záložní techniky
- [ ] Prověří reálnou spolupráci s IZS
- [x] Je levné a nenarušuje běžný provoz
- [ ] Změří skutečnou dobu evakuace

> Table-top vyžaduje jen čas účastníků, proto se dá opakovat často. Funkčnost techniky ani reálné časy však neověří — k tomu slouží plné cvičení.

## Vyhodnocení cvičení a aktualizace plánů {#aktualizace-planu .explain}

Každé cvičení i skutečná událost končí **vyhodnocením** (debriefing): co fungovalo, co ne, proč a co změnit. Zjištění se převedou na **nápravná opatření** s odpovědnou osobou a termínem a promítnou se do plánu. Cílem cvičení není „projít bez chyby", ale **najít slabiny dřív**, než nastane skutečná krize. Plán se aktualizuje **pravidelně** (např. jednou ročně, kontakty častěji) a **mimořádně** — po cvičení či incidentu a při změně organizace, procesů, lidí, IT, dodavatelů nebo legislativy.

*Příklad:* Při simulaci se zjistí, že ze záložního pracoviště nejde přihlásit do účetního systému. Vedoucí IT dostane úkol zajistit přístup do měsíce a po splnění se test zopakuje.

### ? Při cvičení se ukázalo, že polovina telefonních čísel v krizovém plánu je neplatná. Jak tento výsledek chápat?

- [x] Splnilo účel, chybu je třeba opravit
- [ ] Cvičení selhalo a příště se nemá konat
- [ ] Plán je bezcenný a musí se celý zahodit
- [ ] Výsledek je vhodné před vedením utajit

> Cvičení má odhalit slabiny dřív než skutečná krize. Neplatné kontakty se opraví a zavede se jejich pravidelné ověřování.

### ? Která situace NENÍ obvyklým důvodem k mimořádné aktualizaci krizového plánu?

- [ ] Reorganizace a změna vedoucích pracovníků
- [x] Běžné měsíční zpracování mezd
- [ ] Přechod na nový informační systém
- [ ] Zkušenost ze skutečného incidentu

> Plán se mimořádně aktualizuje, když se změní lidé, organizace, systémy či dodavatelé nebo po incidentu a cvičení. Rutinní měsíční agenda plán nemění.

## Dokumentace krizového řízení {#dokumentace .explain}

Dokumentace zahrnuje **plány a jejich přílohy** (kontakty, mapy, kontrolní seznamy, formuláře), **záznamy o školeních a cvičeních** a jejich vyhodnocení a **záznamy z průběhu skutečné krize** — deník událostí: kdo, kdy, co rozhodl a na základě jakých informací. Požadavky: **řízení verzí** (platná verze, datum, schvalovatel, seznam příjemců), **dostupnost** i při výpadku IT či nepřístupnosti budovy (tištěné kopie, offline kopie v mobilu, uložení mimo hlavní lokalitu) a **ochrana důvěrných údajů** (osobní kontakty, popis bezpečnostních slabin). Záznamy z krize slouží k vyhodnocení i k doložení postupu vůči úřadům, pojišťovně nebo soudu.

*Příklad:* Po povodni pojišťovna i inspekce žádají doložit, kdy firma zastavila provoz a odvezla chemikálie. Díky deníku krizového štábu s časy rozhodnutí to firma snadno doloží.

### ? Proč se mají kopie krizového plánu uchovávat i v tištěné nebo offline podobě mimo hlavní budovu?

- [ ] Elektronická verze plánu nemá právní platnost
- [ ] Tištěná verze se nemusí aktualizovat
- [x] Krize může vyřadit IT i přístup do budovy
- [ ] Norma zakazuje ukládat plány na servery

> Plán musí být použitelný právě ve chvíli, kdy nefungují servery nebo se nedá vstoupit do budovy. Kopie se však musí aktualizovat spolu s hlavní verzí.

### ? K čemu slouží průběžný deník událostí a rozhodnutí vedený během krize?

- [x] Umožní zpětně doložit a vyhodnotit postup
- [ ] Nahrazuje komunikaci s médii
- [ ] Slouží jako náhrada krizového plánu
- [ ] Určuje pořadí obnovy kritických činností a systémů

> Záznam s časy, informacemi a rozhodnutími je podkladem pro vyhodnocení krize i pro doložení postupu úřadům, pojišťovně či soudu.

## Krizové plánování podle krizového zákona {#krizovy-zakon .explain}

Krizový zákon (240/2000 Sb.) ukládá zpracovat **krizové plány** orgánům krizového řízení — zejména ministerstvům a jiným ústředním správním úřadům, **krajům** (krizový plán kraje) a **obcím s rozšířenou působností** (krizový plán ORP). Plány vycházejí z analýzy ohrožení a obsahují opatření pro zvládání krizových situací. **Právnické a podnikající fyzické osoby**, které orgán krizového řízení zahrne do krizového plánu (např. kvůli dodávkám nebo službám potřebným v krizi), zpracovávají **plán krizové připravenosti** — jak splní úkoly, které jim z krizového plánu vyplývají. Zvláštní povinnosti mají subjekty kritické infrastruktury a podniky s nebezpečnými látkami (havarijní plánování podle zákona o prevenci závažných havárií). Ostatní firmy zákonnou povinnost krizového plánu nemají, plány si však tvoří dobrovolně jako součást řízení rizik.

*Příklad:* Pekárnu zahrnula obec s rozšířenou působností do krizového plánu kvůli nouzovému zásobování obyvatel. Pekárna proto zpracuje plán krizové připravenosti: jak zajistí výrobu při výpadku elektřiny, kdo je kontaktní osoba a jaké suroviny drží v zásobě.

### ? Kdo podle krizového zákona zpracovává krizový plán?

- [ ] Každá obchodní společnost nad 50 zaměstnanců
- [x] Kraj a obec s rozšířenou působností
- [ ] Každá podnikající fyzická osoba
- [ ] Pouze Ministerstvo vnitra za celou ČR

> Krizové plány zpracovávají orgány krizového řízení — ústřední správní úřady, kraje a obce s rozšířenou působností. Podniky mají povinnosti jen ve vymezených případech.

### ? Mlékárnu zahrnula obec s rozšířenou působností do svého krizového plánu kvůli nouzovému zásobování. Jaký dokument mlékárna zpracovává?

- [ ] Krizový plán kraje
- [ ] Bezpečnostní zprávu
- [ ] Vnější havarijní plán
- [x] Plán krizové připravenosti

> Právnická nebo podnikající fyzická osoba zahrnutá do krizového plánu zpracovává plán krizové připravenosti. Bezpečnostní zpráva a havarijní plány se týkají objektů s nebezpečnými látkami.

## BCM — Business Continuity Management {#bcm .explain}

BCM (management kontinuity podnikání, resp. činností organizace) je řídicí proces, který připravuje organizaci na to, aby při **narušení** (požár, výpadek IT, kybernetický útok, epidemie, výpadek dodavatele, ztráta klíčových lidí) dokázala **pokračovat v kritických činnostech** na přijatelné úrovni a obnovit je. Požadavky na systém managementu kontinuity (BCMS) stanoví norma **ISO 22301**, založená na cyklu **PDCA**. Hlavní prvky: kontext a rozsah, vedení a politika, **analýza dopadů (BIA)** a posouzení rizik, **strategie kontinuity**, **plány kontinuity**, **cvičení a testování**, hodnocení a zlepšování. Oproti krizovému řízení, které řídí krizi jako celek včetně rozhodování na úrovni vedení a ochrany pověsti, se BCM soustředí na **udržení a obnovu provozu**; obě disciplíny se doplňují.

*Příklad:* Výrobce komponent dodává automobilkám bez skladových zásob a odběratelé po něm chtějí doložit připravenost na výpadek. Firma provede BIA, zajistí možnost přesunout výrobu do druhého závodu a jednou ročně přesun cvičí.

### ? Firma se chce nechat certifikovat v oblasti řízení kontinuity podnikání. Podle které normy?

- [ ] ISO 31000
- [ ] ISO 9001
- [ ] ISO 27001
- [x] ISO 22301

> Požadavky na systém managementu kontinuity podnikání (BCMS) stanoví ISO 22301. ISO 31000 obsahuje směrnice pro management rizik a není určena k certifikaci, ISO 9001 se týká kvality a ISO 27001 bezpečnosti informací.

### ? Jaký je hlavní rozdíl mezi BCM a krizovým řízením?

- [ ] BCM řeší jen IT systémy, krizové řízení jen finance
- [x] BCM chrání provoz, krizové řízení celou krizi
- [ ] BCM se uplatňuje jen ve veřejné správě
- [ ] Krizové řízení začíná až po skončení BCM

> BCM se soustředí na udržení a obnovu kritických činností, krizové řízení na zvládnutí krize jako celku včetně strategických rozhodnutí a pověsti. V praxi se doplňují.

## Analýza dopadů na činnosti (BIA) {#bia .explain}

BIA (Business Impact Analysis) zjišťuje, **které činnosti jsou kritické** a jak rostou **dopady jejich přerušení v čase** (finanční, právní, reputační, na zákazníky). Na jejím základě se stanoví:

- **MTPD** (maximální přijatelná doba narušení) — po jejím uplynutí by dopady byly pro organizaci nepřijatelné,
- **RTO** (Recovery Time Objective) — cílová doba obnovy činnosti; **nesmí překročit MTPD** (RTO ≤ MTPD),
- **RPO** (Recovery Point Objective) — maximální přijatelná ztráta dat, tj. k jakému okamžiku musí být data obnovitelná,
- **potřebné zdroje** pro obnovu — lidé, IT, prostory, dodavatelé.

BIA předchází volbě strategie kontinuity a sepsání plánu. Posouzení rizik (jaké hrozby a s jakou pravděpodobností) je samostatný krok.

*Příklad:* Call centrum zjistí, že výpadek do 4 hodin zákazníci tolerují, ale po 12 hodinách hrozí smluvní pokuty a odchod klíčových klientů. Stanoví MTPD 12 hodin a RTO 6 hodin.

### ? BIA ukázala, že výpadek objednávkového systému je pro firmu nepřijatelný po 8 hodinách. Firma přesto stanovila RTO 12 hodin. Co je na tom špatně?

- [ ] RTO se musí rovnat RPO
- [ ] RTO se stanoví až po skončení krize
- [x] RTO nesmí překročit MTPD (RTO ≤ MTPD)
- [ ] MTPD musí být kratší než RTO

> Cílová doba obnovy nesmí překročit maximální přijatelnou dobu narušení (zde 8 hodin). RTO 12 hodin by znamenalo, že dopady překročí únosnou mez.

### ? Co je hlavním rozdílem mezi BIA a posouzením rizik?

- [ ] BIA vyčísluje pravděpodobnost jednotlivých hrozeb
- [ ] Posouzení rizik určuje RTO a RPO
- [ ] BIA se provádí až po napsání plánu
- [x] BIA zkoumá dopady, ne pravděpodobnost hrozeb

> BIA se ptá, co se stane, když činnost vypadne, a jak rychle ji obnovit. Posouzení rizik zkoumá, které hrozby mohou výpadek způsobit a s jakou pravděpodobností.

## MTPD × RTO × RPO {#rto-rpo-mtpd .compare}

Tři časové ukazatele z BIA, které určují požadavky na strategii kontinuity:

| | MTPD | RTO | RPO |
|---|---|---|---|
| Anglicky | Maximum Tolerable Period of Disruption | Recovery Time Objective | Recovery Point Objective |
| Česky | maximální přijatelná doba narušení | cílová doba obnovy | cílový bod obnovy (max. přijatelná ztráta dat) |
| Otázka | Jak dlouho výpadek vydržíme, než budou dopady nepřijatelné? | Do kdy musíme činnost obnovit? | O data za jak dlouhé období smíme přijít? |
| Měří se | od okamžiku narušení dopředu | od okamžiku narušení dopředu | od okamžiku narušení zpět k poslední použitelné kopii dat |
| Vztah | horní mez | nesmí překročit MTPD (RTO ≤ MTPD) | určuje četnost zálohování či replikace |

### ? Banka zálohuje data transakčního systému každé 4 hodiny. Kolik dat může v nejhorším případě ztratit a který ukazatel to vyjadřuje?

- [ ] Data až za 4 hodiny, ukazatel RTO
- [x] Data až za 4 hodiny, ukazatel RPO
- [ ] Data až za 2 hodiny, ukazatel RPO
- [ ] Data až za 4 hodiny, ukazatel MTPD

> Pokud k výpadku dojde těsně před další zálohou, ztratí se data až za 4 hodiny. Přijatelnou ztrátu dat vyjadřuje RPO; RTO se týká doby obnovy.

### ? Firma chce u svého systému dosáhnout RPO blízké nule. Jaké řešení to vyžaduje?

- [ ] Rychle dostupné plně vybavené náhradní pracoviště
- [ ] Delší interval mezi zálohami dat
- [ ] Větší počet členů krizového týmu
- [x] Průběžnou (synchronní) replikaci dat

> RPO blízké nule znamená prakticky žádnou ztrátu dat, což zajistí jen průběžné zrcadlení dat na jiné místo. Náhradní pracoviště ovlivňuje spíše RTO.

### ? Výpadek systému začal v 10:00. RTO je 4 hodiny a RPO 1 hodina. Co z toho plyne?

- [ ] Obnovit do 11:00, ztratit nejvýš data od 6:00
- [ ] Obnovit do 14:00, ztratit nejvýš data od 6:00
- [x] Obnovit do 14:00, ztratit nejvýš data od 9:00
- [ ] Obnovit do 11:00, ztratit nejvýš data od 9:00

> RTO se počítá od výpadku dopředu: 10:00 + 4 h = 14:00. RPO se počítá zpět: data musí být obnovitelná nejméně ke stavu z 9:00, takže se ztratí nejvýš hodina dat.

## Strategie kontinuity {#strategie-kontinuity .explain}

Podle výsledků BIA organizace volí, **jak** kritické činnosti udrží nebo obnoví v požadovaném RTO. Strategie se volí pro každý druh zdroje:

- **lidé** — zastupitelnost, křížové zaškolení, práce na dálku, rozdělení týmu na více míst,
- **prostory** — náhradní pracoviště: **horké** (plně vybavené, provoz během hodin), **teplé** (částečně vybavené, provoz během dnů), **studené** (jen prostory a základní infrastruktura, týdny); vzájemná výpomoc poboček,
- **IT a data** — zálohování, replikace, záložní datové centrum, cloud,
- **dodavatelé** — více dodavatelů místo jediného zdroje, pojistné zásoby, smluvní závazky dodavatele ke kontinuitě,
- **náhradní (manuální) postupy** — např. papírové objednávky při výpadku systému.

Volba je kompromisem mezi **náklady a rychlostí obnovy**: čím kratší RTO, tím dražší řešení.

*Příklad:* Malá účetní kancelář volí levné řešení — data v cloudu a práci z domova. Burzovní obchodník s RTO v řádu minut potřebuje zrcadlené záložní datové centrum.

### ? Pojišťovna musí obnovit call centrum do 4 hodin od zničení budovy. Jaké náhradní pracoviště zvolí?

- [x] Horké pracoviště
- [ ] Teplé pracoviště
- [ ] Studené pracoviště
- [ ] Žádné, stačí pojištění budovy

> Obnovu během hodin umožní jen plně vybavené horké pracoviště. Teplé se zprovozňuje dny, studené týdny; pojištění kryje škodu, ale provoz neobnoví.

### ? Výrobce nakupuje klíčový čip od jediného dodavatele v Asii. Která strategie kontinuity sníží tuto závislost?

- [ ] Prodloužit splatnost faktur dodavateli
- [ ] Prodloužit RTO výrobní linky
- [ ] Vynechat čip z analýzy dopadů
- [x] Zajistit alternativního dodavatele

> Jediný dodavatel je jediný bod selhání. Alternativní dodavatel (případně pojistná zásoba) umožní pokračovat ve výrobě i při jeho výpadku.

## Plán kontinuity (BCP) × plán obnovy po havárii (DRP) {#bcp-drp .compare}

Oba plány realizují zvolenou strategii kontinuity, liší se rozsahem:

| | Plán kontinuity (BCP) | Plán obnovy po havárii (DRP) |
|---|---|---|
| Zaměření | kritické činnosti celé organizace — lidé, prostory, dodavatelé, IT, komunikace | obnova IT systémů, dat a infrastruktury |
| Odpovídají | vlastníci procesů, koordinátor BCM | IT oddělení |
| Obsah | aktivace, role, náhradní postupy a zdroje, komunikace, priority z BIA | postupy obnovy systémů a dat v pořadí priorit, zálohy, záložní datové centrum |
| Vztah | nadřazený celek | technická součást BCP |

### ? Dokument popisuje, v jakém pořadí obnovit servery a databáze ze záloh v záložním datovém centru. O jaký dokument jde?

- [ ] Plán kontinuity celé organizace
- [ ] Krizový komunikační plán
- [x] Plán obnovy po havárii (DRP)
- [ ] Analýza dopadů na činnosti

> Technické postupy obnovy IT systémů a dat obsahuje plán obnovy po havárii (DRP). Plán kontinuity je širší a řeší i lidi, prostory, dodavatele a komunikaci.

### ? Proč samotný plán obnovy IT (DRP) nestačí k zajištění kontinuity podnikání?

- [ ] Plán obnovy IT se nesmí testovat
- [ ] Řeší pouze komunikaci s médii, úřady a zákazníky
- [ ] Zpracovává se až po skončení krize
- [x] Neřeší lidi, prostory, dodavatele a postupy

> Fungující IT je jen jedna podmínka. Kritické činnosti potřebují i lidi, pracoviště, dodavatele a náhradní postupy, které řeší plán kontinuity.
