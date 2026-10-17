---
kind: topic
subject: togaf-practitioner
slug: rizika-a-pozadavky
name: "Rizika, požadavky a připravenost na změnu ve scénářích"
order: 7
---

Risk Management (iniciální × reziduální riziko), Business Transformation Readiness Assessment, Requirements Management v průběhu ADM.

## Kde v ADM se řeší rizika transformace {#rizika-v-adm .explain}

Risk Management není samostatná fáze, ale technika, která se používá napříč celým cyklem ADM. Už v **Phase A** architekt identifikuje rizika obchodní transformace a navrhuje zmírňující aktivity — patří k podkladům, na jejichž základě sponzor schvaluje Architecture Vision a Statement of Architecture Work. Ve fázích B–D se rizika zpřesňují podle toho, jaké mezery se ukážou. V **Phase E a F** se rizika konsolidují a ovlivňují implementační strategii, seskupení work packages a jejich prioritu. V **Phase G** se rizika monitorují a nová rizika s dopadem na architekturu mohou vést přes Change Request do **Phase H**.

*Příklad:* Riziko „klíčový dodavatel nestihne dodat integrační platformu" se objeví v Phase A, v Phase F ovlivní pořadí work packages a v Phase G se sleduje na pravidelných revizích.

### ? Pojišťovna zahajuje cyklus ADM pro novou platformu likvidace pojistných událostí. Architekt připravuje Architecture Vision a Statement of Architecture Work ke schválení sponzorem. Sponzor se ptá, kdy se budou řešit rizika samotné transformace. Jaká odpověď nejlépe odpovídá TOGAF?

- [ ] Rizika se poprvé posoudí až v Phase F při sestavování Implementation and Migration Plan.
- [x] Rizika transformace se identifikují už nyní v Phase A a v dalších fázích se zpřesňují.
- [ ] Rizika řeší výhradně projektové řízení, ADM se jimi jako architektonickou otázkou nezabývá.
- [ ] Rizika se vyhodnotí až při Compliance Review v Phase G nad rozpracovaným řešením.

> Identifikace rizik transformace a zmírňujících aktivit je součástí Phase A a je podkladem pro schválení. Odkládat ji do Phase F nebo G znamená schvalovat vizi bez znalosti rizik; tvrzení, že ADM rizika neřeší, je v rozporu s technikou Risk Management.

### ? Výrobní firma je ve fázi implementace (Phase G) podle schválené architektury. Dodavatel klíčové integrační platformy oznámí změnu licenčního modelu, která může zdražit provoz a donutit k jinému řešení integrace. Architekt nové riziko zatím nikde neevidoval. Co je nejlepší další krok?

- [ ] Riziko ignorovat, protože rizika byla uzavřena schválením Implementation and Migration Plan.
- [ ] Okamžitě zahájit nový cyklus ADM od Preliminary Phase a přepracovat celý rámec.
- [ ] Vrátit se do Phase A a přepsat Architecture Vision, aniž by se riziko nejdřív posoudilo.
- [x] Zaevidovat a posoudit riziko v Phase G, při dopadu na architekturu podat Change Request.

> Monitorování rizik pokračuje i v Phase G; nové riziko se posoudí a teprve pokud mění architekturu, jde přes Change Request do Phase H. Ignorování je chybou governance, restart od Preliminary nebo přepis vize bez posouzení jsou nepřiměřené a předčasné.

## Iniciální × reziduální riziko (initial × residual risk) v praxi {#inicialni-vs-rezidualni .compare}

Obě úrovně se hodnotí stejnou stupnicí, aby šlo posoudit, kolik zmírňující opatření skutečně přinesla.

| | Iniciální riziko (initial risk) | Reziduální riziko (residual risk) |
|---|---|---|
| Kdy se určuje | před návrhem a provedením zmírňujících opatření | po zohlednění naplánovaných zmírňujících opatření |
| K čemu slouží | určit, kterými riziky se zabývat přednostně | rozhodnout, zda je zbývající riziko přijatelné |
| Typická reakce | navrhnout mitigaci úměrnou riziku | přijmout, dále zmírnit, nebo eskalovat |
| Kdo rozhoduje | architekt s vlastníky rizik navrhuje | o přijetí rozhodují odpovědní stakeholdeři (sponzor, governance) |

### ? Banka plánuje migraci dat do nového core systému. Riziko neúspěšné migrace bylo před jakýmikoli opatřeními ohodnoceno jako vysoké. Po naplánování zkušební migrace a postupu návratu (rollback) tým stejné riziko ohodnotil jako nízké. Která úroveň rizika je rozhodující pro sponzorovo rozhodnutí o přijetí?

- [x] Reziduální riziko (nízké); iniciální úroveň sponzorovi ukazuje přínos opatření.
- [ ] Iniciální riziko (vysoké), protože jen to vyjadřuje skutečnou hrozbu pro projekt.
- [ ] Průměr obou hodnocení, aby sponzor dostal vyvážený a konzervativní obraz rizika.
- [ ] Žádná, protože rizika s naplánovanou mitigací se ze seznamu rizik automaticky vyřazují.

> O přijetí se rozhoduje nad reziduálním rizikem, které zohledňuje plánovaná opatření; sponzor přitom vidí i iniciální úroveň, která slouží k prioritizaci a ukazuje, kolik mitigace přinesla. Samotné iniciální riziko přínos opatření ignoruje, průměrování nemá oporu a riziko s mitigací se dál sleduje, nevyřazuje se.

### ? Logistická firma posuzuje riziko výpadku skladového systému při přechodu na novou platformu. I po naplánovaných opatřeních (posílený tým podpory, rozšířené testování) zůstává reziduální riziko na nejvyšší úrovni stupnice. Termín spuštění se blíží. Co má architekt udělat?

- [ ] Pokračovat podle plánu, protože zmírňující opatření jsou zdokumentována a tím je povinnost splněna.
- [ ] Přehodnotit iniciální riziko na nižší úroveň, aby rozdíl proti reziduálnímu riziku vypadal menší.
- [x] Navrhnout další zmírnění, případně riziko eskalovat sponzorovi a governance k rozhodnutí.
- [ ] Odstranit riziko z přehledu rizik, protože ho tým už nemůže dalšími prostředky ovlivnit.

> Nepřijatelné reziduální riziko se buď dále zmírňuje, nebo eskaluje k těm, kdo smějí rozhodnout (např. o posunu termínu či změně rozsahu). Samotná dokumentace opatření riziko nesnižuje a manipulace s hodnocením či mazání rizika jsou porušením governance.

## Postup Risk Management krok za krokem {#proces-rizik .explain}

Prakticky se postupuje v logické posloupnosti:

1. **Klasifikace rizik** — sjednotit kategorie a stupnice (ideálně převzít podnikové); rizika se typicky posuzují podle dopadu na čas, náklady a rozsah.
2. **Identifikace rizik** — zdroje jsou např. výsledky Business Transformation Readiness Assessment, analýza mezer, závislosti work packages, workshopy se stakeholdery.
3. **Iniciální posouzení** — ohodnotit každé riziko (dopad × četnost) a určit priority.
4. **Zmírnění a posouzení reziduálního rizika** — navrhnout opatření a znovu ohodnotit, co po nich zbude.
5. **Monitorování a governance** — sledovat rizika při implementaci (Phase G) a reagovat na změny.

Výsledky se obvykle vedou v přehledu rizik, kde je u každého rizika iniciální hodnocení, opatření a reziduální hodnocení.

*Příklad:* Z workshopu vzejde 15 rizik; po iniciálním posouzení se ukáže, že jen 4 vyžadují mitigaci, ostatní se přijmou a sledují.

### ? Architekt telekomunikační firmy má po workshopu se stakeholdery seznam dvaceti identifikovaných rizik transformace, zatím bez jakéhokoli hodnocení. Sponzor chce vědět, na která rizika má firma vynaložit prostředky na zmírnění nejdřív. Co je nejlepší další krok?

- [ ] Navrhnout zmírňující opatření pro všech dvacet rizik se stejnou intenzitou a rozpočtem.
- [x] Provést iniciální posouzení rizik (dopad a četnost) a podle něj stanovit priority.
- [ ] Nejprve stanovit reziduální riziko každé položky a teprve potom posoudit riziko iniciální.
- [ ] Odložit hodnocení do Phase G, kdy bude riziko možné sledovat na skutečných projektech.

> Prioritizaci umožní až iniciální posouzení; teprve pak má smysl navrhovat mitigaci úměrnou riziku. Reziduální riziko bez navržených opatření určit nelze a odklad do Phase G by znamenal implementovat bez znalosti priorit.

### ? Ve Phase E architekt maloobchodního řetězce konsoliduje výsledky analýzy mezer z fází B–D. Zjistí, že pět plánovaných work packages závisí na jednom starém systému, jehož vyřazení dodavatel ohlásil za osm měsíců. Toto riziko dosud nikdo neevidoval. Jak má architekt naložit se zjištěním?

- [ ] Ponechat zjištění jen v analýze mezer, protože rizika se identifikují výhradně v Phase A.
- [ ] Přesunout všech pět work packages do posledního přechodu a riziko dál neřešit.
- [ ] Předat zjištění vedoucímu provozu IT jako provozní problém mimo rozsah architektury.
- [x] Zaevidovat ho jako riziko, posoudit ho a zohlednit v pořadí work packages a mitigaci.

> Identifikace rizik pokračuje i ve fázích E a F, kde závislosti work packages často odhalí nová rizika. Riziko je potřeba posoudit a promítnout do plánování; odsunutí bez posouzení ani předání mimo architekturu ho neřeší.

## Hodnocení rizika: dopad × četnost (effect × frequency) {#matice-dopadu .explain}

TOGAF doporučuje hodnotit riziko kombinací **závažnosti dopadu** (effect — od zanedbatelného po katastrofický, např. Negligible, Marginal, Critical, Catastrophic) a **četnosti či pravděpodobnosti výskytu** (frequency — od Unlikely po Frequent). Kombinace dává výslednou míru rizika (od Low po Extremely High). Prakticky platí: hodnotit stejnou stupnicí iniciální i reziduální riziko; neřadit rizika jen podle jednoho rozměru; mitigace obvykle snižuje buď **četnost** (prevence — testy, pilot), nebo **dopad** (připravenost — rollback, záložní řešení).

*Příklad:* Pilotní provoz na jedné pobočce snižuje pravděpodobnost chyby při plošném nasazení; připravený rollback snižuje škodu, pokud chyba přesto nastane.

### ? Banka připravuje přepnutí platebního systému na novou platformu během jednoho víkendu. Tým navrhuje připravit plně vyzkoušený postup návratu na původní systém do jedné hodiny. Kterou složku hodnocení rizika „selhání přepnutí" toto opatření primárně snižuje?

- [x] Dopad (effect), protože omezí škodu, pokud selhání nastane; jeho pravděpodobnost se nemění.
- [ ] Četnost (frequency), protože díky návratovému postupu bude selhání přepnutí méně pravděpodobné.
- [ ] Iniciální riziko, protože návratový postup se započítá do původního hodnocení před opatřeními.
- [ ] Pouze kategorii rizika, která se tím přesune do jiné třídy podnikové klasifikace rizik.

> Rollback nezabrání selhání, ale zkrátí výpadek a sníží škodu — snižuje tedy dopad. Opatření se promítají do reziduálního hodnocení, nikoli do iniciálního, a klasifikaci rizika nemění.

### ? Architekt pojišťovny porovnává dvě rizika. Riziko A: únik citlivých dat klientů — dopad katastrofický, výskyt málo pravděpodobný. Riziko B: drobné zpoždění měsíčních reportů — dopad zanedbatelný, výskyt častý. Tým navrhuje řadit rizika jen podle četnosti. Jak má architekt postupovat?

- [ ] Souhlasit s řazením podle četnosti, protože časté riziko B ovlivní provoz nejvíce.
- [ ] Řadit jen podle dopadu a riziko B jako zanedbatelné z přehledu rizik úplně vyřadit.
- [x] Hodnotit kombinaci dopadu a četnosti; riziko A nelze odbýt jen kvůli nízké četnosti.
- [ ] Neřešit ani jedno, protože každé z rizik má vysokou hodnotu jen v jednom rozměru.

> Míra rizika vzniká kombinací dopadu a četnosti; katastrofický dopad může i při nízké pravděpodobnosti vyžadovat mitigaci. Řazení podle jediného rozměru zkresluje priority a vyřazení či ignorace rizik je chybou.

### ? Energetická společnost hodnotí riziko výpadku zákaznického portálu. Iniciální hodnocení provedl tým bezpečnosti na pětistupňové stupnici, reziduální po opatřeních provedl jiný tým na třístupňové stupnici. Sponzor chce vědět, jak moc opatření pomohla. Co má architekt udělat?

- [ ] Prohlásit opatření za účinná, protože reziduální riziko vyšlo na nižším stupni stupnice.
- [x] Přehodnotit obě úrovně na stejné stupnici, aby šly iniciální a reziduální riziko porovnat.
- [ ] Předložit sponzorovi jen reziduální hodnocení, protože iniciální už nemá pro rozhodnutí význam.
- [ ] Převést výsledky na peníze a stupnice rizik pro sponzora vůbec nepoužívat.

> Přínos mitigace je vidět jen při srovnání obou úrovní na stejné stupnici. Různé stupnice srovnání znemožňují, iniciální úroveň je pro posouzení přínosu nutná a vypuštění stupnice by rozbilo konzistenci s ostatními riziky.

## Zmírnění rizika a přijetí reziduálního rizika {#mitigace-a-prijeti .explain}

U rizik s nepřijatelnou úrovní architekt navrhne zmírňující opatření. Z obecné praxe řízení rizik se používají např. snížení pravděpodobnosti, omezení dopadu, přenesení (např. smluvně na dodavatele) nebo vyhnutí se riziku změnou rozsahu či přístupu. Mitigace stojí čas a peníze, proto má být **úměrná riziku** — drobné riziko se často vědomě přijme. Po zmírnění se ohodnotí reziduální riziko a jeho **přijetí je rozhodnutím odpovědných stakeholderů** (sponzor, vlastník rizika, případně Architecture Board), ne samotného architekta. Opatření, která vyžadují práci, se promítají do work packages a Implementation and Migration Plan.

*Příklad:* Riziko nedostatku specialistů na novou technologii se zmírní školením a externí posilou; obě aktivity se objeví jako položky v plánu přechodu.

### ? Architekt e-shopu identifikoval riziko, že nový reportingový modul bude při spuštění o den později aktualizovat jeden interní přehled. Riziko má nízký dopad i nízkou pravděpodobnost. Navržené zmírnění by vyžadovalo dva měsíce práce dalšího vývojáře. Jaký postup je nejvhodnější?

- [ ] Opatření provést, protože každé identifikované riziko musí být před spuštěním zmírněno.
- [ ] Riziko z přehledu vymazat, protože nízká rizika do přehledu rizik vůbec nepatří.
- [ ] Odložit spuštění, dokud nebude k dispozici vývojář, který opatření provede.
- [x] Riziko zdokumentovat a s jeho vlastníkem dohodnout jeho vědomé přijetí bez mitigace.

> Mitigace má být úměrná riziku; když náklady převyšují možnou škodu, je správné riziko vědomě přijmout a dál sledovat. Povinná mitigace všeho plýtvá zdroji, mazání rizika ruší jeho sledování a odklad spuštění je nepřiměřený.

### ? Architekt nemocnice dokončil návrh zmírnění rizik pro nový informační systém a reziduální rizika vyšla jako střední. Projektový tým chce, aby architekt reziduální rizika sám podepsal jako přijatá, aby se nezdržovalo schválení. Co má architekt udělat?

- [ ] Rizika podepsat, protože architekt je odpovědný za obsah architektury i za její rizika.
- [x] Předložit reziduální rizika sponzorovi a vlastníkům rizik k formálnímu rozhodnutí o přijetí.
- [ ] Rizika nepodepisovat a místo toho je přesunout do Requirements Impact Assessment.
- [ ] Zmírňovat rizika dál, dokud nevyjdou nízká, a teprve potom je předložit k rozhodnutí.

> Přijetí reziduálního rizika je rozhodnutím odpovědných stakeholderů; architekt jim dodá podklad. Requirements Impact Assessment slouží k posouzení dopadu požadavků, ne k přijímání rizik, a další mitigace „za každou cenu" není nutná, když o přijatelnosti středního rizika mohou rozhodnout stakeholdeři.

### ? Pojišťovna přechází na externí SaaS řešení pro správu smluv. Riziko dlouhého výpadku služby tým ohodnotil jako vysoké iniciální riziko. Jako zmírnění vyjednal se dodavatelem závazek dostupnosti se sankcemi a připravil náhradní postup ručního zpracování smluv. Co má architekt podle techniky Risk Management udělat dál?

- [x] Ohodnotit reziduální riziko po opatřeních, předložit ho k přijetí a riziko dál sledovat.
- [ ] Považovat riziko za uzavřené, protože smlouva přenesla odpovědnost za výpadky na dodavatele.
- [ ] Ponechat jen iniciální hodnocení, protože opatření se do hodnocení rizika vůbec nepromítají.
- [ ] Vyřadit riziko z přehledu a jeho sledování nechat výhradně na dodavateli služby SaaS.

> Po zmírnění se riziko znovu ohodnotí jako reziduální, o jeho přijetí rozhodnou odpovědní stakeholdeři a riziko se dál monitoruje, protože výpadek může stále nastat. Smlouva riziko neodstraňuje, účinek opatření se má promítnout právě do reziduálního hodnocení a přenechání sledování dodavateli ruší monitoring na straně firmy.

## Sladění s podnikovým řízením rizik {#soulad-s-podnikovym-rizenim .explain}

Řízení rizik architektury nemá vytvářet paralelní systém. Pokud organizace má podnikový rámec řízení rizik (taxonomii, stupnice, registr, eskalační cesty, vlastníky rizik), architektonická práce ho má **využít a napojit se na něj** — rizika transformace se pak objevují ve stejném reportingu jako ostatní rizika a vedení je umí porovnat. Jak se architektura na podnikové řízení rizik napojí, je vhodné určit při přizpůsobení rámce (tailoring) v **Preliminary Phase**. Pokud podnikový rámec chybí, architekt nastaví jednoduchou, konzistentní stupnici a používá ji ve všech fázích.

*Příklad:* Banka s registrem rizik a stupnicí 5 × 5 mapuje hodnocení dopadu a četnosti z architektury přímo na svou stupnici a rizika transformace eviduje v podnikovém registru.

### ? Banka má vyspělý útvar řízení rizik s centrálním registrem rizik, vlastní stupnicí a pravidly eskalace. Architektonický tým chce pro nový program vést vlastní oddělený přehled rizik s jinou stupnicí, protože „TOGAF má svůj postup". Co je nejlepší doporučení?

- [x] Napojit řízení rizik architektury na podnikový rámec, stupnici a centrální registr.
- [ ] Vést oddělený přehled s jinou stupnicí, protože technika TOGAF má vlastní závazná pravidla.
- [ ] Vést oba přehledy souběžně a rozdíly mezi nimi řešit až při Compliance Review ve Phase G.
- [ ] Rizika architektury vůbec neevidovat a nechat je řešit jen útvar řízení rizik banky.

> TOGAF doporučuje sladit řízení rizik s podnikovým rámcem, aby rizika byla srovnatelná a eskalovala se standardní cestou. Paralelní systém vytváří nekonzistenci a zcela předat rizika mimo architekturu znamená ztratit jejich vazbu na architektonická rozhodnutí.

### ? Pojišťovna teprve zavádí architektonickou praxi podle TOGAF. Útvar řízení rizik požaduje, aby architektura od začátku používala firemní kategorie rizik a hlásila rizika jeho cestou. Kdy je nejvhodnější toto napojení dohodnout a zakotvit?

- [ ] V Phase G, až budou běžet první implementační projekty s reálnými riziky.
- [ ] V Phase H, kdy se posuzují změny architektury a jejich rizika pro podnik.
- [x] Při přizpůsobení rámce v Preliminary Phase, kde se nastavuje způsob práce.
- [ ] V Requirements Management jako jeden z požadavků na cílovou architekturu.

> Preliminary Phase připravuje architektonickou praxi včetně přizpůsobení rámce a napojení na podnikové procesy, jako je řízení rizik. Fáze G a H jsou na zavedení pravidel pozdě a Requirements Management spravuje požadavky na architekturu, ne nastavení způsobu práce.

## Business Transformation Readiness Assessment: kdy a proč {#btra-kdy .explain}

Business Transformation Readiness Assessment (BTRA) zjišťuje, zda je organizace **schopná a ochotná změnu přijmout a provést** — neposuzuje technickou kvalitu architektury. Poprvé se provádí v **Phase A**, protože připravenost ovlivňuje ambice a rozsah vize i rizika transformace. V **Phase E** se připravenost a rizika znovu potvrzují před formulací implementační a migrační strategie a zlepšující akce se promítají do **Phase F** (Implementation and Migration Plan). Slabá místa připravenosti se dále řídí jako rizika technikou Risk Management. Doporučuje se společný workshop se zástupci business i IT, ne jen hodnocení od stolu.

*Příklad:* Firma s technicky skvělou vizí, ale bez vlastníka změny na straně byznysu, zjistí díky BTRA, že nejdřív musí zajistit sponzorství a vedení.

### ? Logistická firma připravuje v Phase A vizi nové plánovací platformy. Návrh je technicky velmi kvalitní, ale personální ředitel upozorňuje, že tři předchozí transformace selhaly kvůli odporu zaměstnanců, a IT oddělení je přetížené. Kterou techniku má architekt použít, než potvrdí rozsah a ambice vize?

- [ ] Gap Analysis mezi Baseline a Target Architecture v doménách business, dat a aplikací.
- [ ] Architecture Compliance Review nad stávajícími projekty, které IT oddělení zatěžují.
- [x] Business Transformation Readiness Assessment se zástupci business i IT stakeholderů.
- [ ] Capability-Based Planning pro rozdělení cílových kapabilit do jednotlivých přírůstků.

> Signály se týkají schopnosti a ochoty organizace změnu provést, což je předmětem BTRA, a to už v Phase A. Gap Analysis porovnává architektury, Compliance Review posuzuje soulad projektů a Capability-Based Planning plánuje dodávky kapabilit — připravenost na změnu žádná z nich neměří.

### ? Ve Phase A provedla firma před osmi měsíci Business Transformation Readiness Assessment s dobrými výsledky. Od té doby proběhla reorganizace a původní sponzor odešel. Architekt je nyní ve Phase E a chystá se formulovat implementační a migrační strategii. Co má udělat?

- [x] Aktualizovat BTRA a znovu potvrdit připravenost a rizika před volbou strategie.
- [ ] Použít původní výsledky beze změny, protože BTRA se podle TOGAF provádí jen ve Phase A.
- [ ] Odložit nové posouzení připravenosti do Phase G, až budou známy první výsledky projektů.
- [ ] Nahradit posouzení připravenosti novou analýzou mezer mezi Baseline a Target Architecture.

> Ve Phase E se připravenost a rizika transformace potvrzují; po reorganizaci a odchodu sponzora jsou staré výsledky nespolehlivé. Odklad do Phase G by strategii postavil na zastaralých předpokladech a Gap Analysis připravenost organizace neposuzuje.

### ? Architekt veřejné instituce chce rychle provést Business Transformation Readiness Assessment. Navrhuje, že faktory připravenosti ohodnotí sám na základě dokumentů, aby nezatěžoval vedoucí útvarů. Jak nejlépe posoudit tento přístup?

- [ ] Je správný, protože BTRA je interní analýza architektonického týmu bez účasti stakeholderů.
- [ ] Je správný, pokud hodnocení po dokončení schválí Architecture Board jako formální výstup.
- [ ] Je nevhodný, protože BTRA má provést externí auditor nezávislý na celé organizaci.
- [x] Je nevhodný; připravenost se posuzuje společně se zástupci business i IT na workshopu.

> Připravenost na změnu vědí nejlépe ti, kdo ji budou provádět a přijímat, proto se BTRA doporučuje dělat společně se stakeholdery. Hodnocení od stolu ani dodatečné schválení boardem tento vhled nenahradí a požadavek externího auditora TOGAF nestanoví.

## Faktory připravenosti (readiness factors) v praxi {#btra-faktory .explain}

BTRA hodnotí organizaci podle sady **faktorů připravenosti**. TOGAF uvádí výchozí seznam (odvozený z praxe kanadské vlády), například Vision, Desire/Willingness/Resolve, Need, Business Case, Funding, Sponsorship and Leadership, Governance, Accountability, Workable Approach and Execution Model, IT Capacity to Execute, Departmental Capacity to Execute a Ability to Implement and Operate. Seznam je **výchozí bod** — organizace ho přizpůsobí svému kontextu (doplní, sloučí nebo vypustí faktory). Při práci je užitečné ke každému zjištění najít faktor, kterého se týká, a podle něj navrhnout nápravu.

*Příklad:* „Nikdo z vedení nepřebírá odpovědnost za změnu" spadá pod Sponsorship and Leadership, „útvary nebudou schopny nový systém samy provozovat" pod Ability to Implement and Operate.

### ? V Phase A architekt pojišťovny zjistí: rozpočet programu je schválený, sponzor změnu nadšeně podporuje a vize je jasná. Všichni klíčoví specialisté interního IT jsou ale do konce roku plně alokováni na regulatorní projekt. Který faktor připravenosti je zde nejslabší?

- [ ] Funding, protože program bude potřebovat dodatečné prostředky na externí kapacity.
- [x] IT Capacity to Execute, protože IT nemá volné lidi na provedení transformace.
- [ ] Sponsorship and Leadership, protože sponzor nezajistil uvolnění specialistů.
- [ ] Vision, protože vize nepočítala s probíhajícím regulatorním projektem.

> Zadání výslovně říká, že rozpočet, sponzorství i vize jsou v pořádku; problémem je kapacita IT transformaci provést. Ostatní možnosti přisuzují problém faktorům, které jsou podle zadání silné.

### ? Farmaceutická firma připravuje BTRA. Kromě výchozích faktorů připravenosti z TOGAF je pro ni zásadní, zda změnu včas schválí státní regulátor, bez jehož souhlasu nelze nový výrobní proces spustit. Jak má architekt s tímto faktorem naložit?

- [ ] Nezahrnout ho, protože BTRA smí používat pouze výchozí seznam faktorů z TOGAF.
- [ ] Nahradit celé BTRA samostatným dotazníkem zaměřeným jen na regulatorní schválení.
- [ ] Zahrnout ho až do Requirements Management jako požadavek na Target Architecture.
- [x] Přizpůsobit seznam faktorů a regulatorní schválení do hodnocení připravenosti doplnit.

> Výchozí seznam faktorů je třeba přizpůsobit kontextu organizace, takže specifický faktor se doplní. Striktní držení výchozího seznamu by ignorovalo klíčovou podmínku a náhrada celého BTRA by ztratila ostatní faktory; nejde přitom o požadavek na architekturu, ale o připravenost organizace.

## Postup BTRA: od faktorů k akcím v plánu {#btra-postup .explain}

Praktický postup BTRA:

1. **Určit faktory připravenosti** relevantní pro danou organizaci.
2. **Popsat faktory pomocí modelů zralosti (maturity models)** — pro každý faktor se popíšou úrovně, aby hodnocení nebylo jen dojmem.
3. **Ohodnotit faktory** — u každého faktoru urgency (naléhavost), readiness status (stav připravenosti) a degree of difficulty to fix (obtížnost nápravy).
4. **Posoudit rizika jednotlivých faktorů a navrhnout zlepšující akce** — slabý faktor je riziko transformace.
5. **Zapracovat akce do plánu** — zlepšující akce se ve Phase E a F promítnou do work packages, Architecture Roadmap a Implementation and Migration Plan.

Výsledkem tedy není jen „známka připravenosti", ale konkrétní kroky, které organizaci na změnu připraví.

*Příklad:* Slabý faktor Accountability vede k akci „jmenovat vlastníky procesů pro každou doménu" naplánované před prvním přechodem.

### ? Po workshopu Business Transformation Readiness Assessment v logistické firmě má architekt ohodnocené faktory připravenosti. Tři faktory vyšly slabě: sponzorství, odpovědnost za procesy a kapacita útvarů. Co je nejlepší další krok?

- [ ] Zastavit program, dokud všechny faktory nedosáhnou nejvyšší úrovně zralosti.
- [ ] Přiložit hodnocení jako přílohu k Architecture Vision bez dalších navazujících kroků.
- [x] Posoudit rizika slabých faktorů a navrhnout zlepšující akce, které se zapracují do plánu.
- [ ] Okamžitě snížit cílovou architekturu na úroveň, kterou dnešní připravenost zvládne.

> Slabé faktory jsou rizika, ke kterým se navrhují zlepšující akce a ty se plánují v rámci přechodu. Zastavení programu je nepřiměřené, příloha bez akcí nic neřeší a okamžité snížení cíle přeskakuje posouzení, zda slabinu nelze odstranit.

### ? Business Transformation Readiness Assessment v nemocnici vedlo ke zlepšujícím akcím: proškolit klíčové uživatele, přijmout dva integrační specialisty a jmenovat vlastníka klinických procesů. Architekt je nyní ve Phase F. Kam tyto akce patří?

- [x] Do Implementation and Migration Plan a Architecture Roadmap jako plánované aktivity.
- [ ] Do Architecture Contract mezi Architecture Boardem a implementačními projekty.
- [ ] Do Requirements Impact Assessment jako posouzení dopadu nových požadavků.
- [ ] Do architektonických principů jako nová pravidla pro rozhodování o architektuře.

> Zlepšující akce z BTRA jsou práce, kterou je třeba naplánovat, financovat a provést — proto patří do plánu přechodu. Architecture Contract upravuje soulad implementace, Requirements Impact Assessment dopady požadavků a principy obecná pravidla rozhodování.

## Hodnocení faktoru: naléhavost, stav, obtížnost nápravy {#btra-hodnoceni .explain}

Každý faktor připravenosti se v BTRA hodnotí z několika úhlů, typicky: **naléhavost** (urgency — jak brzy musí být faktor v pořádku), **stav připravenosti** (readiness status — jak na tom organizace dnes je) a **obtížnost nápravy** (degree of difficulty to fix — kolik úsilí a času náprava vyžaduje). Teprve kombinace ukazuje prioritu: naléhavý a těžko napravitelný faktor je potřeba řešit nejdřív, protože náprava trvá dlouho; nenaléhavý faktor lze naplánovat na pozdější přechod.

*Příklad:* Chybějící datoví správci jsou potřeba až pro třetí přechod — akce se naplánuje později; nefunkční governance programu je naléhavá a těžká — řeší se hned.

### ? Při BTRA vyšly dva slabé faktory. Faktor A je naléhavý (bez něj nelze zahájit první přechod) a jeho náprava je obtížná a dlouhodobá. Faktor B není naléhavý (týká se až posledního přechodu) a jeho náprava je snadná. Jak nejlépe stanovit pořadí zlepšujících akcí?

- [ ] Začít faktorem B, protože rychlé a snadné výsledky mají vždy přednost před obtížnými.
- [ ] Řešit oba faktory souběžně se stejnou prioritou, protože oba vyšly jako slabé.
- [ ] Oba faktory odložit do Phase G, kdy bude jasné, zda se problém skutečně projeví.
- [x] Začít hned faktorem A, který je naléhavý a náprava trvá dlouho; B naplánovat později.

> Naléhavost spolu s obtížností nápravy určuje prioritu: naléhavou a dlouhodobou nápravu je nutné zahájit co nejdřív. Snadný, ale nenaléhavý faktor může počkat; stejná priorita ani odklad do Phase G nezohledňují hodnocení.

### ? V BTRA banky má faktor „schopnost útvarů provozovat nový systém" nízký stav připravenosti. Systém ale bude útvarům předán až v posledním přechodu za dva roky a náprava (školení, úprava procesů) je středně obtížná. Sponzor se ptá, zda kvůli tomu odložit start programu. Co architekt doporučí?

- [ ] Odložit start programu, dokud faktor nedosáhne dobrého stavu připravenosti.
- [x] Nezdržovat start a zlepšující akce naplánovat v roadmapě s předstihem před předáním.
- [ ] Faktor neřešit, protože za dva roky se situace v útvarech pravděpodobně zlepší sama.
- [ ] Vypustit poslední přechod z plánu, aby se problém s provozem vůbec neobjevil.

> Nízká naléhavost umožňuje zahájit program a nápravu naplánovat tak, aby byla hotová před předáním systému. Odklad startu je nepřiměřený, spoléhání na samovolné zlepšení je neřízené riziko a vypuštění přechodu obětuje cíl.

## BTRA × Capability Assessment × Risk Management — co zvolit {#btra-vs-ostatni .compare}

Všechny tři se používají už v Phase A, ale odpovídají na jinou otázku.

| | Business Transformation Readiness Assessment | Capability Assessment | Risk Management |
|---|---|---|---|
| Otázka | Je organizace schopná a ochotná změnu provést? | Jaké schopnosti (business i IT) podnik má a jak jsou vyspělé? | Co může transformaci ohrozit a jak to zmírnit? |
| Typický výsledek | hodnocení faktorů připravenosti a zlepšující akce | přehled dnešních kapabilit a jejich zralosti jako základ vize | iniciální a reziduální hodnocení rizik, opatření |
| Kdy hlavně | Phase A, potvrzení v E, akce do F | Phase A | napříč ADM (A až G) |
| Vazba | slabé faktory vstupují jako rizika | ukazuje, co je třeba vybudovat | přebírá rizika z BTRA i z mezer |

### ? Ředitel obchodu chce v Phase A vědět, jaké obchodní a IT schopnosti firma dnes má a jak vyspělé jsou vůči cílům nové služby pro firemní zákazníky, aby bylo jasné, co je třeba vybudovat. Ochota lidí ke změně ani rizika ho teď nezajímají. Kterou činnost má architekt provést?

- [x] Capability Assessment, tedy posouzení dnešních kapabilit podniku a jejich zralosti.
- [ ] Business Transformation Readiness Assessment, tedy posouzení připravenosti na změnu.
- [ ] Risk Management, tedy identifikaci a iniciální posouzení rizik transformace.
- [ ] Requirements Impact Assessment, tedy posouzení dopadu nových požadavků.

> Otázka „co dnes umíme a jak vyspěle" je předmětem Capability Assessment v Phase A. BTRA měří připravenost a ochotu ke změně, Risk Management hrozby a Requirements Impact Assessment dopady změněných požadavků.

### ? BTRA v distribuční firmě ukázalo nízkou připravenost ve faktoru Governance: neexistuje fórum, které by rozhodovalo spory mezi útvary. Architekt přemýšlí, jak toto zjištění propojit s ostatní prací ve Phase A. Jaký postup je nejvhodnější?

- [ ] Zapsat zjištění jako nový požadavek do Architecture Requirements Specification.
- [ ] Nechat zjištění jen ve zprávě z BTRA, protože s Risk Managementem nesouvisí.
- [x] Převzít slabý faktor jako riziko transformace, posoudit ho a navrhnout zmírnění.
- [ ] Ponechat zjištění na Compliance Review ve Phase G, kde se governance kontroluje.

> Slabé faktory připravenosti jsou rizika transformace a řídí se technikou Risk Management (iniciální posouzení, mitigace, reziduální riziko). Architecture Requirements Specification obsahuje měřitelné požadavky na řešení, ne slabiny organizace, a odklad do Phase G by riziko nechal bez řešení.

## Requirements Management: proces ve středu ADM {#req-mgmt-princip .explain}

Requirements Management není fáze, kterou se jednou projde — běží **nepřetržitě po celý cyklus** a obsluhuje všechny fáze. Jeho úkolem je požadavky zachytit, uložit v **Architecture Requirements Repository**, sledovat jejich změny a posoudit dopad. **Samotné zpracování požadavku** (prioritizace, zapracování do architektury, zamítnutí) se však děje **v příslušné fázi ADM**, ne v procesu Requirements Management. Požadavky jsou proměnlivé: jak architektura vzniká, objevují se nové a stávající se mění. TOGAF nepředepisuje konkrétní nástroj ani metodu sběru požadavků — organizace použije to, co jí vyhovuje.

*Příklad:* Požadavek na archivaci dat 10 let se zaeviduje v repozitáři, ale o tom, jak ho datová architektura splní a s jakou prioritou, se rozhoduje ve Phase C.

### ? Architektonický tým výrobní firmy navrhuje „dokončit fázi Requirements Management" a zmrazit všechny požadavky dřív, než začne Phase B, aby se pak už nic neměnilo. Jak má vedoucí architekt reagovat?

- [ ] Souhlasit, protože Requirements Management je fáze mezi Phase A a Phase B.
- [x] Vysvětlit, že Requirements Management běží po celý cyklus a požadavky se mohou měnit.
- [ ] Souhlasit, ale zmrazit požadavky až po dokončení Phase D, kdy jsou známy všechny domény.
- [ ] Vysvětlit, že požadavky se řeší až v Phase H jako součást řízení změn architektury.

> Requirements Management je průběžný proces ve středu ADM; požadavky jsou proměnlivé a jejich změny je třeba řídit v každé fázi, ne zmrazit. Zmrazení po Phase D je stejná chyba později a omezení na Phase H ignoruje práci s požadavky ve fázích A–G.

### ? Ve Phase C se v pojišťovně objeví nový požadavek na uchovávání dat o škodách po dobu patnácti let. Správce požadavků prohlásí, že o prioritě a způsobu splnění rozhodne sám v rámci procesu Requirements Management. Co je správně?

- [ ] Správce má pravdu, protože Requirements Management o požadavcích autoritativně rozhoduje.
- [ ] O požadavku má rozhodnout Architecture Board ještě před jeho zaevidováním v repozitáři.
- [ ] Požadavek se odloží do Phase H, protože se objevil až během vývoje architektury.
- [x] Proces požadavek eviduje a posoudí dopad, o prioritě a řešení se rozhoduje ve Phase C.

> Requirements Management požadavky spravuje a posuzuje jejich dopad, ale samo je nezpracovává ani neprioritizuje — to se děje v příslušné fázi ADM se stakeholdery. Board neschvaluje požadavek před evidencí a automatický odklad do Phase H není důvodný.

## Nový nebo změněný požadavek uprostřed cyklu {#req-novy-pozadavek .explain}

Když se během cyklu objeví nový nebo změněný požadavek, praktický postup je:

1. **Zaevidovat** ho v Architecture Requirements Repository.
2. **Posoudit dopad** na aktuální i dříve dokončené fáze (Requirements Impact Assessment) a přehodnotit priority.
3. **Rozhodnout** se stakeholdery o naložení: zapracovat v aktuální fázi; vrátit se (iterovat) do dřívější fáze a upravit její výstupy včetně analýzy mezer; nebo, pokud je mimo rozsah či vyžaduje zásadní změnu, odložit do dalšího cyklu (řízení změn v Phase H, nový Request for Architecture Work).
4. **Aktualizovat** repozitář a dotčené výstupy a informovat stakeholdery.

*Příklad:* Drobná úprava formátu reportu se zapracuje lokálně; nová regulace měnící datovou architekturu vyžaduje návrat do Phase C.

### ? Banka je ve Phase D. Vyjde nová regulace, podle níž musí data o klientech zůstat fyzicky v EU — to zasahuje datovou architekturu dokončenou ve Phase C i technologickou architekturu, na které tým právě pracuje. Co je nejlepší další krok?

- [x] Zaevidovat požadavek, posoudit dopad na Phase C i D a podle výsledku se vrátit do C.
- [ ] Vyřešit vše jen ve Phase D volbou cloudu v EU a dokončené výstupy Phase C neotvírat.
- [ ] Požadavek odložit do Phase H, protože regulace přišla až po dokončení Phase C.
- [ ] Zastavit celý cyklus a znovu začít Preliminary Phase s novým rámcem architektury.

> Požadavek mění výstupy dokončené fáze, proto je třeba posoudit dopad na aktuální i předchozí fáze a iterovat zpět do Phase C. Řešit to jen technologií nechá datovou architekturu v rozporu s regulací, odklad je nepřípustný u povinné regulace a restart od Preliminary je nepřiměřený.

### ? Ve Phase B si útvar controllingu vyžádá, aby měsíční přehled nákladů obsahoval navíc sloupec s rozpočtem. Posouzení dopadu ukáže, že změna nemá vliv na žádný architektonický výstup ani na dřívější fáze. Jak s požadavkem naložit?

- [ ] Podat Change Request a nechat změnu posoudit Architecture Boardem ve Phase H.
- [ ] Zahájit nový cyklus ADM, protože každá změna požadavku vyžaduje novou iteraci.
- [x] Zapracovat ho v aktuální fázi a aktualizovat záznam v Architecture Requirements Repository.
- [ ] Vrátit se do Phase A a doplnit požadavek do Architecture Vision a Statement of Architecture Work.

> Když posouzení dopadu neukáže zásah do architektury ani dřívějších fází, požadavek se zpracuje v aktuální fázi a zaeviduje. Change Request, nový cyklus i návrat do Phase A jsou pro takto malou změnu nepřiměřené.

### ? Ve Phase F, těsně před schválením Implementation and Migration Plan, požádá marketing o nový mobilní kanál pro zákazníky. Požadavek je významný, ale leží mimo rozsah schváleného Statement of Architecture Work a sponzor trvá na dodržení termínu. Co má architekt udělat?

- [ ] Rozšířit rozsah tichou úpravou plánu, aby marketing nemusel čekat na další cyklus.
- [x] Zaevidovat požadavek, posoudit dopad a se stakeholdery ho odložit do budoucího cyklu.
- [ ] Požadavek odmítnout a nezaevidovat, protože mimo rozsah práce nepatří do repozitáře.
- [ ] Vrátit celý cyklus do Phase A a přepracovat vizi tak, aby mobilní kanál zahrnovala.

> Požadavek mimo schválený rozsah se zaeviduje a po posouzení dopadu se se stakeholdery rozhodne o jeho odkladu do dalšího cyklu (řízení změn, nový Request for Architecture Work). Tiché rozšíření rozsahu obchází governance, nezaevidování ztrácí požadavek a návrat do Phase A ohrožuje termín, na kterém sponzor trvá.

## Requirements Impact Assessment {#req-impact-assessment .term}

Výstup procesu Requirements Management, který pro nový nebo změněný požadavek popisuje, **které části architektury a které fáze ADM zasahuje** a jak doporučeně postupovat (zapracovat, vrátit se do dřívější fáze, odložit). Průběžně se aktualizuje, jak se požadavek zpracovává, a slouží stakeholderům jako podklad k rozhodnutí.

### ? Ve Phase C výrobní firmy přijde požadavek na sledování výrobních šarží až na úroveň jednotlivých komponent. Sponzor chce před rozhodnutím vidět dokument, který popíše, které již vytvořené architektury a fáze ADM požadavek zasáhne a jak doporučeně postupovat. Který výstup architekt připraví?

- [ ] Architecture Requirements Specification s měřitelnými kritérii pro implementaci.
- [ ] Change Request pro Architecture Board s návrhem nového cyklu architektury.
- [ ] Compliance Assessment, který posoudí soulad projektů s cílovou architekturou.
- [x] Requirements Impact Assessment, který posoudí dopad požadavku a doporučí postup.

> Posouzení dopadu nového požadavku na architekturu a fáze ADM je účelem Requirements Impact Assessment. Architecture Requirements Specification obsahuje měřitelné požadavky na řešení, Change Request se týká změn v Phase H a Compliance Assessment posuzuje projekty v Phase G.

## Specifikace × repozitář × posouzení dopadu požadavků {#req-spec-vs-repo .compare}

Tři pojmy kolem požadavků se snadno pletou; v praxi slouží jiným účelům.

| | Architecture Requirements Specification | Architecture Requirements Repository | Requirements Impact Assessment |
|---|---|---|---|
| Co to je | výstup fází B–D (zpřesňuje se v E a F) | část Architecture Repository | výstup Requirements Management |
| Obsah | měřitelné požadavky na implementaci: kritéria, služby, omezení, předpoklady | všechny požadavky s jejich stavem a historií | dopad konkrétního nového či změněného požadavku a doporučený postup |
| Kdo ho využije | implementační projekty, dodavatelé, Architecture Contract | architekti po celý cyklus i mezi cykly | stakeholdeři při rozhodování o změně |
| Doplňuje | Architecture Definition Document (kvalitativní popis) | — | — |

### ? Implementační partner telekomunikační firmy se ptá, jaká měřitelná kritéria musí jeho řešení splnit — požadovanou dostupnost, dobu odezvy a omezení, která musí respektovat. Architekt je po dokončení Phase D. Který výstup mu má předat?

- [x] Architecture Requirements Specification s měřitelnými požadavky na implementaci.
- [ ] Architecture Definition Document s popisem cílové architektury a jejího zdůvodnění.
- [ ] Requirements Impact Assessment s posouzením dopadu změněných požadavků.
- [ ] Architecture Requirements Repository se všemi záznamy požadavků a jejich historií.

> Kvantitativní, měřitelné požadavky na implementaci obsahuje Architecture Requirements Specification. Architecture Definition Document popisuje architekturu kvalitativně, Requirements Impact Assessment se týká změn a repozitář je úložiště, ne výstup pro dodavatele.

### ? Interní auditor banky chce zjistit, kdy a od koho požadavek na dvoufázové ověření klientů vzešel, jak se v průběhu dvou cyklů ADM měnil a v jakém je dnes stavu. Kde má architekt tyto informace hledat?

- [ ] V Architecture Requirements Specification z aktuálně probíhajícího cyklu ADM.
- [ ] V Requirements Impact Assessment z posledního provedeného posouzení dopadu.
- [x] V Architecture Requirements Repository uvnitř Architecture Repository.
- [ ] V Architecture Definition Document z poslední dokončené Phase D cyklu.

> Historii a stav požadavků napříč cykly uchovává Architecture Requirements Repository. Specifikace a Architecture Definition Document zachycují stav jednoho cyklu a Requirements Impact Assessment se týká jen konkrétní změny.

## Požadavky během implementace a po ní (Phase G a H) {#req-v-implementaci .explain}

I během implementace (Phase G) vznikají nové nebo změněné požadavky — z projektů, od dodavatelů, z provozu. Pokud změna zůstává v rámci schválené architektury, řeší se v implementační governance. Pokud **mění architekturu**, požadavek se zaeviduje, posoudí se jeho dopad a podá se **Change Request**, o kterém se rozhoduje v **Phase H**. Phase H také průběžně sleduje změny podnikového prostředí a technologií; nové požadavky, které z toho plynou, Requirements Management zachytí a mohou se stát vstupem dalšího cyklu ADM (např. přes nový Request for Architecture Work). Projekt by nikdy neměl architekturu měnit potichu sám.

*Příklad:* Dodavatel zjistí, že plánovaná integrace v reálném čase není možná; místo tiché změny na dávkové zpracování se podá Change Request.

### ? Během Phase G implementační projekt pojišťovny zjistí, že cílová architektura počítá s integrací s partnerem v reálném čase, ale partner podporuje jen noční dávkový přenos. Změna by ovlivnila i další plánované projekty. Co je správný postup?

- [ ] Nechat projekt přejít na dávkový přenos sám, protože jde o detail implementace.
- [x] Zaevidovat změnu požadavku, posoudit dopad a podat Change Request k rozhodnutí.
- [ ] Zastavit všechny projekty a vrátit celý program do Phase A k nové vizi architektury.
- [ ] Neřešit to nyní a odchylku zaznamenat až při Compliance Review po spuštění řešení.

> Změna, která mění architekturu a dotýká se dalších projektů, se musí zaevidovat, posoudit a předložit přes Change Request k rozhodnutí v Phase H. Tichá změna projektem obchází governance, zastavení všeho je nepřiměřené a čekání do po spuštění nechá problém neřízený.

### ? Rok po dokončení implementace sleduje architektonický tým ve Phase H změny trhu. Konkurence zavedla okamžité platby a obchod požaduje stejnou službu, která vyžaduje významné změny business i aplikační architektury. Jak má architekt s tímto požadavkem naložit?

- [ ] Předat požadavek přímo vývojovému týmu, protože architektura je již implementována.
- [ ] Přidat službu do stávajícího Architecture Contract hotového implementačního projektu.
- [ ] Požadavek zamítnout, protože po dokončení cyklu ADM se nové požadavky nepřijímají.
- [x] Zachytit ho v Requirements Management a předat jako vstup dalšímu cyklu ADM.

> Phase H sleduje změny prostředí a významné nové požadavky se přes Requirements Management stávají vstupem dalšího cyklu ADM (nový Request for Architecture Work). Předání přímo vývoji obchází architekturu, uzavřený Architecture Contract se na novou práci nehodí a zamítnutí ignoruje, že ADM je opakovaný cyklus.
