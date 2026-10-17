---
kind: topic
subject: togaf-practitioner
slug: governance-v-praxi
name: "Implementační governance a změny (G–H) ve scénářích"
order: 6
---

Architecture Contracts, Compliance Review, Architecture Board, řízení změn a rozhodnutí o nové iteraci ADM.

## Role architekta ve Phase G (Implementation Governance) {#role-v-g .explain}

Ve Phase G už cílová architektura i plán přechodu existují a řešení realizují projekty — vlastní vývojové týmy nebo dodavatelé. Architekt v této fázi architekturu znovu nenavrhuje ani neřídí projekt; jeho úkolem je **dohled**: zajistit, aby nasazovaná řešení odpovídala cílové architektuře, a aby každá odchylka prošla governance. Nástroji jsou Architecture Contract, Compliance Reviews, rozhodnutí Architecture Board a Change Requests. Architektonický tým zároveň projektům vysvětluje architekturu a připravuje pro ně projektově zaměřené pohledy.

*Příklad:* Dodavatel navrhne vlastní způsob ověřování uživatelů. Architekt návrh nepřepisuje, ale posoudí ho proti architektuře a odchylku předá k rozhodnutí.

### ? Banka dokončila Phase F a schválila Implementation and Migration Plan. Tři implementační projekty začínají s externím dodavatelem, který je hned na začátku ve skluzu. Projektový manažer žádá hlavního architekta, aby za dodavatele převzal detailní návrh rozhraní, „protože architekturu zná nejlépe". Co je pro architekta nejvhodnější postup?

- [ ] Převzít detailní návrh rozhraní, aby projekt dohnal skluz a návrh byl hned v souladu
- [x] Zůstat v roli dohledu, požadavky ukotvit v Architecture Contract a hlídat soulad
- [ ] Vrátit práci do Phase C a přepracovat Application Architecture podle možností dodavatele
- [ ] Předat celou odpovědnost projektovému manažerovi a do implementace už dále nezasahovat

> Ve Phase G architekt implementaci řídí governancí (kontrakt, compliance reviews), ne tím, že sám dělá detailní návrh za dodavatele. Návrat do Phase C kvůli skluzu dodavatele nemá opodstatnění a úplné stažení z implementace by znamenalo ztrátu kontroly nad souladem.

### ? Výrobní podnik je uprostřed Phase G. Ředitel IT se ptá, co má architektonický tým na konci této fáze prokazatelně předložit, aby bylo vidět, že implementaci skutečně řídil. Která odpověď nejlépe odpovídá účelu Phase G?

- [ ] Finální verzi Architecture Roadmap s pořadím work packages a odhadem jejich přínosu
- [ ] Aktualizovaný Statement of Architecture Work s novým rozsahem a harmonogramem prací
- [ ] Novou Architecture Vision, která zohlední zkušenosti z probíhajících projektů
- [x] Podepsané Architecture Contracts, compliance hodnocení a řešení nasazená v souladu

> Typickými výsledky Phase G jsou podepsané Architecture Contracts, Compliance Assessments, Change Requests a nasazená řešení v souladu s architekturou. Roadmapa patří do Phases E–F, Statement of Architecture Work do Phase A a nová vize by vznikla až v nové iteraci ADM.

## Postup práce ve Phase G {#postup-g .explain}

Práci ve Phase G lze číst jako sled kroků: nejprve s vedením vývoje (development management) **potvrdit rozsah a priority nasazení**, pak **identifikovat zdroje a dovednosti** pro nasazení, **vést vývoj řešení** (formalizovat požadavky do Architecture Contract), **provádět Compliance Reviews**, zajistit **zavedení do business a IT provozu** a nakonec udělat **post-implementation review** a implementaci formálně uzavřít. Poznatky z vyhodnocení se předávají do Phase H a do dalších iterací.

*Příklad:* Po spuštění nového e-shopu tým vyhodnotí, které architektonické požadavky se osvědčily a které vedly k potížím, a zaznamená doporučení pro budoucí projekty.

### ? Pojišťovna zahajuje Phase G pro program modernizace škodních systémů. Architekt chce okamžitě spustit compliance reviews všech projektů. S vedením vývoje však zatím nikdo nevyjasnil, které projekty se nasazují přednostně a v jakém rozsahu, protože portfolio se po Phase F ještě upravovalo. Co by měl architekt udělat jako první?

- [x] Potvrdit s vedením vývoje rozsah a priority nasazení jednotlivých projektů
- [ ] Spustit compliance reviews u všech projektů současně, aby se nic nezmeškalo
- [ ] Vrátit se do Phase E a znovu sestavit work packages podle nového portfolia
- [ ] Požádat Architecture Board o dispensation pro projekty bez stanovené priority

> Prvním krokem Phase G je potvrdit s vedením vývoje rozsah a priority nasazení. Bez toho nelze rozumně plánovat zdroje ani reviews. Úprava portfolia sama o sobě nevyžaduje návrat do Phase E a dispensation slouží k povolení odchylky od architektury, ne k řešení chybějících priorit.

### ? Logistická firma právě uvedla do provozu nový systém řízení skladů. Projekt splnil termín a uživatelé systém používají. Projektový manažer navrhuje rozpustit tým a dokumentaci archivovat bez dalšího hodnocení. Co by měl architekt doporučit před uzavřením implementace?

- [ ] Hned zahájit novou iteraci ADM od Phase A, protože implementace je dokončena
- [ ] Archivovat dokumentaci a dál se k implementaci vracet jen při stížnostech uživatelů
- [x] Provést post-implementation review a poznatky předat do Phase H a dalších projektů
- [ ] Zopakovat úplnou Gap Analysis mezi Baseline a Target Architecture celého podniku

> Phase G končí vyhodnocením po implementaci a formálním uzavřením; poznatky slouží řízení změn ve Phase H i dalším projektům. Nová iterace ADM není automatickým důsledkem dokončení projektu a nová úplná Gap Analysis patří do vývoje architektury, ne do uzavření implementace.

## Architecture Contract — kdy a s kým {#kontrakt-kdy .explain}

Architecture Contract je společná dohoda o tom, co se dodá, v jaké kvalitě a jak bude soulad s architekturou ověřován. TOGAF rozlišuje několik situací: **Statement of Architecture Work** z Phase A funguje jako kontrakt mezi architektonickou funkcí a sponzorem; během implementace se uzavírá kontrakt mezi architektonickou funkcí a **partnery pro návrh a vývoj** (vlastní tým i dodavatel) a kontrakt s **business uživateli**, kteří architekturu přebírají a provozují. Kontrakt se uzavírá **před zahájením** realizace a jeho dodržování dohlíží Architecture Board.

*Příklad:* Před výběrem dodavatele integrační platformy připojí architekt k výběrovému řízení návrh kontraktu se standardy, které musí řešení splnit.

### ? Maloobchodní řetězec svěří vývoj nové mobilní aplikace externímu studiu. Cílová architektura předepisuje použití firemní API platformy a jednotné správy identit. Smlouva se studiem obsahuje jen cenu, termíny a funkční zadání. Co by měl architekt zajistit před zahájením vývoje?

- [ ] Doplnit do Statement of Architecture Work kapitolu o mobilní aplikaci a studiu
- [ ] Nechat studio vyvíjet a soulad s architekturou zkontrolovat až při akceptaci
- [x] Uzavřít se studiem Architecture Contract s požadavky a způsobem ověřování
- [ ] Vystavit pro studio nový Request for Architecture Work se zadáním mobilní aplikace

> Pro partnera, který řešení navrhuje a vyvíjí, je určen Architecture Contract uzavřený před začátkem vývoje. Statement of Architecture Work je dohoda se sponzorem architektonické práce, Request for Architecture Work iniciuje architektonickou práci, ne vývoj, a kontrola až při akceptaci by odchylky odhalila příliš pozdě.

### ? Sponzor programu podnikové architektury v energetické společnosti tvrdí, že s architektonickým týmem nemá „žádnou závaznou dohodu" o tom, co tým v této iteraci dodá. Tým přitom ve Phase A připravil a se sponzorem schválil dokument s rozsahem, harmonogramem a kritérii úspěchu. Jak to má architekt sponzorovi vysvětlit?

- [x] Schválený Statement of Architecture Work je fakticky kontraktem mezi týmem a sponzorem
- [ ] Dohoda vznikne až ve Phase G podpisem Architecture Contract s vývojovými partnery
- [ ] Závazná dohoda se sponzorem v TOGAF neexistuje, sponzor jen schvaluje Architecture Vision
- [ ] Roli dohody plní Architecture Requirements Specification schválená ve Phase B

> Statement of Architecture Work z Phase A je v TOGAF chápán jako kontrakt mezi architektonickou funkcí a sponzorem. Kontrakty z Phase G se týkají partnerů pro vývoj a business uživatelů, ne sponzora, a Architecture Requirements Specification je specifikace požadavků, ne dohoda o práci.

## Co musí Architecture Contract obsahovat {#obsah-kontraktu .explain}

Aby kontrakt šel později použít při Compliance Review, nestačí v něm termíny a cena. Obvykle obsahuje **rozsah** a povahu dohody, závazné **architektonické principy a požadavky**, **požadavky na soulad** (conformance requirements), **měřítka cílové architektury**, definované fáze a výstupy, společný prioritizovaný plán, **časové okno** a **metriky** dodávky a přínosu. U kontraktu s business uživateli jsou navíc důležité provozní a servisní závazky. Kontrakt podepisují obě strany a jeho stav se sleduje v rámci architektonické governance.

*Příklad:* Kontrakt s dodavatelem CRM stanoví, že veškerá integrace půjde přes firemní API platformu a že dodavatel doloží soulad na kontrolním seznamu před každým vydáním.

### ? Dodavatel nového účetního systému navrhuje Architecture Contract co nejstručnější: termíny, rozpočet a seznam funkcí. Architekt ví, že za tři měsíce proběhne první Compliance Review a Architecture Board bude chtít vědět, podle čeho se soulad posuzuje. Co je pro tento účel nejdůležitější do kontraktu doplnit?

- [ ] Podrobný harmonogram schůzek projektového týmu s rozpisem odpovědných osob
- [ ] Úplný popis Baseline Architecture účetních systémů před zahájením projektu
- [ ] Seznam všech stakeholderů podniku s jejich zájmy a postojem k projektu
- [x] Požadavky na soulad, závazné principy a měřítka, podle kterých se řešení ověří

> Compliance Review posuzuje řešení proti dohodnutým požadavkům na soulad, principům a měřítkům cílové architektury — bez nich není podle čeho soulad hodnotit. Harmonogram schůzek, Baseline Architecture ani seznam stakeholderů tuto funkci kontraktu neplní.

### ? Obchodní divize přebírá sdílenou platformu pro správu zákazníků, kterou bude dlouhodobě sama používat a spravovat. Projektový tým platformu nasadil a končí. Divize chce vědět, k čemu se jako uživatel architektury zavazuje a co může od platformy očekávat. Jaké řešení je nejvhodnější?

- [ ] Ponechat divizi pouze provozní příručku od dodavatele bez dalších závazků
- [x] Uzavřít s divizí kontrakt pro business uživatele včetně servisních závazků
- [ ] Zahrnout divizi do kontraktu s vývojovým dodavatelem jako jeho další stranu
- [ ] Vystavit divizi dispensation, aby mohla platformu upravovat podle svých potřeb

> Pro business uživatele, kteří architekturu přebírají a provozují, počítá TOGAF se samostatným kontraktem, který řeší jejich závazky i očekávanou úroveň služeb. Kontrakt s vývojovým dodavatelem končí s vývojem, příručka nezavazuje k souladu a dispensation je výjimka z architektury, ne dohoda o jejím používání.

## Kdy provádět Architecture Compliance Review {#review-kdy .explain}

Compliance Review má smysl provádět **v průběhu** projektu, ne až na jeho konci — čím později se odchylka najde, tím dražší je náprava. Typické body jsou zahájení projektu, první (high-level) návrh řešení, každá **zásadní změna návrhu** a případně kontrola ad hoc, když vznikne pochybnost. Rozsah a hloubku review je dobré přizpůsobit velikosti a riziku projektu. Plán reviews patří do implementační governance a do Architecture Contract.

*Příklad:* Projekt nového portálu má review po schválení high-level návrhu a znovu, když tým navrhne přechod z firemní databáze na cloudovou službu.

### ? Telekomunikační operátor spouští devítiměsíční projekt nového billingového systému. Projektový plán počítá s jedinou kontrolou souladu s architekturou týden před spuštěním do provozu, aby „architekti nebrzdili vývoj". Systém se napojuje na pět klíčových podnikových aplikací. Co by měl architekt doporučit?

- [ ] Ponechat jedinou kontrolu před spuštěním, ale rozšířit ji na všechna rozhraní
- [x] Naplánovat reviews už u zahájení a prvního návrhu a dále při zásadních změnách
- [ ] Nahradit reviews průběžným reportingem projektového manažera Architecture Board
- [ ] Přesunout kontrolu souladu až do Phase H po prvních měsících ostrého provozu

> Reviews v raných fázích projektu odhalí odchylky, dokud je jejich náprava levná; kontrola týden před spuštěním přichází pozdě. Reporting projektového manažera nenahrazuje nezávislé posouzení souladu a Phase H slouží řízení změn architektury, ne dodatečné kontrole projektu.

### ? Projekt nového HR systému prošel úspěšně review high-level návrhu. Po čtyřech měsících se tým rozhodne nahradit firemní databázovou platformu cloudovou službou, se kterou cílová architektura nepočítá. Do dalšího plánovaného review zbývá ještě pět měsíců. Co je nejvhodnější?

- [ ] Počkat na plánované review, protože změna techniky je věcí projektového týmu
- [ ] Rovnou změnit cílovou architekturu tak, aby cloudovou službu povolovala
- [ ] Zastavit projekt, dokud Architecture Board nevypíše nové výběrové řízení
- [x] Vyvolat mimořádné review, protože jde o zásadní změnu návrhu řešení

> Zásadní změna návrhu je typickým spouštěčem mimořádného review. Čekat pět měsíců znamená riskovat drahou nápravu, jednostranná změna architektury obchází governance a zastavení projektu bez posouzení je nepřiměřené.

## Jak Compliance Review proběhne {#review-postup .explain}

Review začíná vymezením **rozsahu** (které části řešení a které domény), určením odpovědného architekta a **přizpůsobením kontrolních seznamů** (checklists) danému projektu — obecný seznam pro celý podnik bývá zbytečně široký. Následují rozhovory s klíčovými lidmi projektu a analýza vyplněných seznamů. Výsledkem je **zpráva** se zjištěními a doporučeními, kterou architekt projedná s projektem a předloží k přijetí; podstatná rozhodnutí přísluší Architecture Board a zaznamenávají se do Governance Log.

*Příklad:* U projektu, který mění jen aplikační vrstvu, architekt vynechá části seznamu o síťové infrastruktuře a datových centrech.

### ? Architektonický tým státního úřadu má obecný kontrolní seznam s dvěma sty položkami pro všechny domény. Teď má posoudit malý projekt, který mění pouze jednu webovou aplikaci a její napojení na stávající registr. Projektový tým si stěžuje, že vyplňování seznamu zabere týdny. Jak má architekt postupovat?

- [x] Vymezit rozsah review a přizpůsobit kontrolní seznamy tomu, co projekt mění
- [ ] Trvat na celém seznamu, protože jen úplné vyplnění zaručí srovnatelnost projektů
- [ ] Review u malého projektu úplně vynechat a spolehnout se na zkušenost dodavatele
- [ ] Nechat projektový tým, aby si položky seznamu vybral sám podle svého uvážení

> TOGAF počítá s přizpůsobením kontrolních seznamů rozsahu konkrétního review. Celý seznam je pro malý projekt neúměrný, vynechání review ruší governance a výběr položek samotným projektem by narušil nezávislost posouzení.

### ? Compliance Review projektu nového skladového systému odhalilo, že dvě rozhraní nepoužívají firemní integrační platformu a jedno ukládá osobní údaje mimo schválené úložiště. Architekt dokončil zprávu se zjištěními a doporučeními. Co je nejvhodnějším dalším krokem?

- [ ] Projekt okamžitě zastavit vlastním rozhodnutím architekta až do odstranění všech zjištění
- [ ] Zprávu poslat jen dodavateli, aby zjištění opravil bez zapojení dalších stran
- [x] Projednat zprávu s projektem a předložit ji k rozhodnutí Architecture Board s evidencí
- [ ] Zprávu archivovat a zjištění zohlednit až v příští iteraci podnikové architektury

> Zpráva z review se projedná s projektem a předkládá se k přijetí; o nápravě, výjimkách či eskalaci rozhoduje Architecture Board a rozhodnutí se evidují. Architekt sám projekt nezastavuje, jednostranné předání dodavateli obchází governance a odklad do další iterace ponechá rizika bez řešení.

## Úrovně souladu (Architecture Compliance) {#urovne-souladu .compare}

TOGAF popisuje vztah implementace ke specifikaci architektury několika úrovněmi souladu:

| Úroveň | Co platí pro implementaci |
|---|---|
| Irrelevant | nemá se specifikací nic společného |
| Consistent | má se specifikací část společnou a ta odpovídá; část specifikace chybí a část implementace jde mimo ni |
| Compliant | ne vše ze specifikace je implementováno, ale vše implementované je specifikací pokryto a odpovídá jí |
| Conformant | vše ze specifikace je implementováno podle ní, navíc jsou implementovány další věci, které jí neodpovídají |
| Fully Conformant | plná shoda — vše ze specifikace a nic navíc |
| Non-conformant | některá věc ze specifikace je implementována v rozporu se specifikací |

### ? Platforma pro správu dokumentů implementuje všechny funkce, které specifikace architektury předepisuje, a to přesně podle ní. Dodavatel k ní ale přidal vlastní modul pro sdílení souborů, se kterým specifikace nepočítá a který jejím pravidlům neodpovídá. Jakou úroveň souladu má architekt v hodnocení uvést?

- [ ] Compliant
- [ ] Fully Conformant
- [ ] Consistent
- [x] Conformant

> Conformant znamená, že vše ze specifikace je implementováno podle ní, ale navíc existují věci mimo ni. Fully Conformant by vyžadoval, aby nic navíc nebylo, Compliant popisuje situaci, kdy část specifikace chybí, a Consistent připouští chybějící i nadbytečné části současně.

### ? Projekt zákaznického portálu je v polovině. Zatím implementoval jen čtyři z osmi služeb, které specifikace architektury předepisuje, ale všechno, co implementoval, specifikaci přesně odpovídá a nic navíc nepřidal. Jakou úroveň souladu má architekt v průběžném hodnocení uvést?

- [ ] Conformant
- [x] Compliant
- [ ] Non-conformant
- [ ] Irrelevant

> Compliant znamená, že část specifikace zatím chybí, ale vše implementované je jí pokryto a odpovídá jí. Conformant by vyžadoval úplnou implementaci specifikace, Non-conformant rozpor se specifikací a Irrelevant úplnou absenci společných prvků.

## Jak reagovat na nesoulad {#reakce-na-nesoulad .compare}

Zjištěný nesoulad neznamená automaticky zastavení projektu. Volba reakce závisí na příčině:

| Situace | Vhodná reakce |
|---|---|
| Odchylka z opomenutí, náprava je proveditelná | náprava v projektu, ověření při dalším review |
| Projekt dočasně nemůže vyhovět (termín, chybějící schopnost standardu) | žádost o **dispensation** u Architecture Board — časově omezená, s podmínkami |
| Architektura nebo standard se ukazuje jako nevhodný pro více projektů | **Change Request** na architekturu, posouzení ve Phase H |
| Projekt odmítá vyhovět a odchylka ohrožuje podnik | eskalace přes Architecture Board k vedení |

### ? Projekt plateb pro regulatorní hlášení musí být hotový za dva měsíce. Schválená integrační platforma zatím neumí potřebný protokol, který umí jiný produkt, jež už firma vlastní. Dodavatel platformy slibuje podporu protokolu do roka a projekt je ochoten pak na ni přejít. Co má architekt doporučit?

- [ ] Odložit projekt, dokud schválená platforma potřebný protokol nepodporuje
- [ ] Povolit druhý produkt rozhodnutím architekta a zapsat ho mezi standardy
- [x] Požádat Architecture Board o časově omezenou dispensation s plánem přechodu
- [ ] Spustit novou iteraci ADM a přepracovat Technology Architecture celé firmy

> Dočasná nemožnost vyhovět s jasným plánem návratu ke standardu je typickým případem pro dispensation udělenou Architecture Board. Odklad by ohrozil regulatorní termín, jednostranné rozhodnutí architekta obchází governance a nová iterace ADM je na jeden projekt nepřiměřená.

### ? V posledním roce požádalo pět projektů o dispensation ze stejného důvodu: schválená databázová platforma nezvládá zpracování časových řad, které nové aplikace potřebují. Architecture Board všechny výjimky udělil. Jaký je nejvhodnější další krok architekta?

- [x] Podat Change Request na technologický standard a nechat ho posoudit ve Phase H
- [ ] Udělovat další dispensations, protože u předchozích projektů se postup osvědčil
- [ ] Nařídit projektům, aby zpracování časových řad přepsaly na schválenou platformu
- [ ] Zrušit platnost standardu a nechat volbu databáze na jednotlivých projektech

> Opakované výjimky ze stejného důvodu ukazují, že problém je v architektuře, ne v projektech — správnou cestou je Change Request posouzený v rámci Architecture Change Management. Další výjimky problém jen odkládají, nucený přepis ignoruje skutečnou potřebu a zrušení standardu bez posouzení rozbíjí governance.

### ? Při review projektu interního portálu architekt zjistí, že vývojáři z nepozornosti napojili jednu službu přímo na databázi jiné aplikace místo přes existující API, které vše potřebné nabízí. Úprava zabere zhruba dva dny. Jak má architekt naložit s tímto zjištěním?

- [ ] Doporučit Architecture Board udělit dispensation, protože jde o malou odchylku
- [ ] Podat Change Request, aby architektura přímé napojení na databáze povolila
- [ ] Eskalovat nesoulad k vedení podniku jako závažné porušení architektury
- [x] Požadovat nápravu v projektu a ověřit ji při dalším review nebo kontrole

> Odchylka z opomenutí, kterou lze levně opravit, se řeší nápravou v projektu. Dispensation je pro situace, kdy projekt vyhovět nemůže, Change Request pro nevhodnou architekturu a eskalace pro závažné a odmítané odchylky.

## Dispensation v praxi {#dispensation .explain}

Dispensation je formální **povolení odchylky** od architektury, které uděluje Architecture Board, když projekt z vážných důvodů nemůže vyhovět. Měla by být **časově omezená**, mít jasné podmínky (co se smí, po jakou dobu, co se bude sledovat) a ideálně plán návratu k souladu. Udělené výjimky se **evidují** v Governance Log a po uplynutí lhůty se znovu posuzují — řešení buď přejde do souladu, výjimka se s odůvodněním prodlouží, nebo se ukáže potřeba změnit architekturu.

*Příklad:* Board povolí na 12 měsíců provoz starého reportingového nástroje s podmínkou, že nebude rozšiřován o nové funkce.

### ? Architecture Board udělil před dvanácti měsíci dispensation, která projektu povolila dočasně používat starší autentizační server. Lhůta právě vypršela a projekt mezitím na schválenou službu nepřešel, protože se změnily priority. Co je nejvhodnější?

- [ ] Považovat výjimku za trvalou, protože ji Board jednou schválil a provoz funguje
- [x] Znovu ji posoudit — přechod vynutit, odůvodněně prodloužit, nebo změnit architekturu
- [ ] Okamžitě odpojit starší server bez ohledu na dopad na uživatele a provoz
- [ ] Nechat rozhodnutí na projektovém manažerovi, protože jde o jeho prioritu

> Dispensation je časově omezená a po vypršení se musí znovu posoudit; výsledkem je návrat k souladu, odůvodněné prodloužení nebo podnět ke změně architektury. Tichá trvalá výjimka i rozhodnutí projektového manažera obcházejí governance a okamžité odpojení ignoruje dopady.

### ? Projekt nového datového skladu potřebuje dočasně použít nástroj, který není ve Standards Library. Projektový manažer navrhuje, že výjimku „podepíše" sám, protože má rozpočtovou odpovědnost, případně ji schválí hlavní architekt projektu. Kdo by měl o výjimce rozhodnout?

- [ ] Projektový manažer, protože odpovídá za rozpočet i termín projektu
- [ ] Hlavní architekt projektu, protože nejlépe rozumí technickým důsledkům
- [x] Architecture Board, který dispensations uděluje a eviduje jejich podmínky
- [ ] Dodavatel nástroje, protože zaručí jeho kompatibilitu se stávajícím prostředím

> Udělování dispensations je odpovědností Architecture Board, aby výjimky byly posuzovány jednotně a evidovány. Projektový manažer i projektový architekt jsou stranou žádosti a dodavatel nemá v architektonické governance rozhodovací roli.

## Architecture Board ve scénářích {#board-v-praxi .explain}

Architecture Board je orgán, který dává architektonické governance **autoritu**: dohlíží na soulad, schvaluje nebo zamítá dispensations, rozhoduje spory mezi projekty a o změnách architektury, hlídá konzistenci dílčích architektur a podporuje znovupoužití. Měl by být **malý**, s trvalými členy, kteří mají pravomoc a reprezentují business i IT, a měl by se zabývat **architektonicky významnými** rozhodnutími — ne každým detailem návrhu. Běžnou práci deleguje na architekty a review.

*Příklad:* Dva projekty chtějí každý jinou integrační platformu; Board rozhodne podle principů a cílové architektury a rozhodnutí zapíše.

### ? Dva projekty v pojišťovně se nemohou shodnout, zda pro výměnu dat použít firemní event platformu, nebo přímá API volání. Oba tvrdí, že jejich varianta je v souladu s architekturou, a spor už zdržuje oba harmonogramy. Hlavní architekti obou projektů se nedohodli. Kdo by měl spor rozhodnout?

- [x] Architecture Board na základě principů a cílové architektury
- [ ] Projekt, který má vyšší rozpočet a větší dopad na zákazníky
- [ ] Dodavatel event platformy, protože zná její možnosti nejlépe
- [ ] Ředitel IT neformálně, bez zápisu, aby se spor rychle uzavřel

> Rozhodování sporů o výklad architektury mezi projekty je úlohou Architecture Board a rozhodnutí se evidují. Velikost rozpočtu není kritériem souladu, dodavatel není nezávislý a neformální rozhodnutí bez záznamu podkopává governance.

### ? Nový ředitel IT chce posílit governance a navrhuje Architecture Board s pětadvaceti členy včetně všech projektových manažerů, který bude každý týden schvalovat každý detail návrhu všech projektů. Architekt má k návrhu dát doporučení. Jaké doporučení nejlépe odpovídá TOGAF?

- [ ] Návrh přijmout, protože více členů a častější schvalování znamená silnější governance
- [ ] Board zrušit a schvalování nechat na Compliance Reviews jednotlivých architektů
- [ ] Do Boardu přizvat i dodavatele, aby se jejich návrhy schvalovaly hned při jednání
- [x] Board držet malý, s pravomocí, a zaměřit ho na architektonicky významná rozhodnutí

> TOGAF doporučuje malý Board s trvalými členy, kteří mají autoritu, zaměřený na významná rozhodnutí; detailní práce se deleguje. Velký Board schvalující detaily se stane úzkým hrdlem, zrušení Boardu odstraní autoritu governance a přizvání dodavatelů ohrožuje nezávislost.

## Governance Log a evidence rozhodnutí {#governance-log .explain}

Aby governance byla průhledná a dohledatelná, zaznamenávají se architektonicky významná rozhodnutí, výsledky compliance hodnocení, udělené dispensations a další governance činnosti do **Governance Log** v Architecture Repository. Záznam umožňuje později doložit, proč bylo něco povoleno, sledovat lhůty výjimek a vyhodnocovat opakující se problémy. Neevidované rozhodnutí se v praxi chová, jako by neexistovalo.

*Příklad:* Při auditu firma doloží, že odchylka projektu byla schválena Boardem na 6 měsíců a že lhůta byla dodržena.

### ? Interní audit se ptá, proč projekt nového CRM před dvěma lety směl použít databázi mimo podnikové standardy a zda šlo o schválenou výjimku. Projektový tým už neexistuje a autoři návrhu z firmy odešli. Kde by měl architekt hledat doklad o rozhodnutí?

- [ ] V Standards Library, kde jsou uvedeny schválené technologie a produkty
- [ ] V Reference Library, která obsahuje referenční modely a vzory řešení
- [x] V Governance Log, který zaznamenává rozhodnutí, hodnocení a výjimky
- [ ] V Architecture Requirements Repository se seznamem požadavků projektu

> Governance Log slouží jako záznam governance činností, včetně rozhodnutí Boardu, compliance hodnocení a dispensations. Standards Library obsahuje standardy, ne výjimky z nich, Reference Library referenční materiály a repozitář požadavků požadavky, ne rozhodnutí o odchylkách.

### ? Architektonický tým zjišťuje, že lhůty udělených dispensations nikdo nesleduje a některé výjimky platí roky. Výjimky se schvalovaly e-mailem a záznamy jsou rozptýlené po schránkách. Co je nejvhodnějším opatřením?

- [ ] Přestat výjimky udělovat a všechny projekty okamžitě převést do souladu
- [x] Evidovat výjimky s lhůtami v Governance Log a pravidelně je revidovat
- [ ] Předat sledování výjimek projektovým manažerům, kteří o ně žádali
- [ ] Doplnit výjimky do Standards Library jako trvale povolené technologie

> Systematická evidence v Governance Log s lhůtami umožňuje výjimky sledovat a po vypršení znovu posoudit. Úplný zákaz výjimek je nerealistický, sledování žadateli postrádá nezávislost a zápis výjimek mezi standardy je mění na trvalé bez posouzení.

## Účel Phase H v praxi {#ucel-h .explain}

Phase H (Architecture Change Management) začíná tam, kde implementace končí, a trvá průběžně. Architekt v ní **sleduje změny** v businessu a technologiích, **vyhodnocuje přínosy** realizované architektury (value realization) a rizika, řídí governance proces a rozhoduje, jak s každou změnou naložit. Kroky zahrnují zavedení procesu realizace hodnoty, nasazení monitorovacích nástrojů, řízení rizik, analýzu pro řízení změn, odvození požadavků na změnu z výkonnostních cílů, řízení governance a aktivaci procesu realizace změny. Cílem je, aby architektura i architektonická kapabilita zůstaly aktuální.

*Příklad:* Rok po zavedení nové platformy tým porovná dosažené KPI s cíli z Architecture Vision a podle výsledku navrhne úpravy.

### ? Po nasazení všech projektů programu chce vedení architektonický tým rozpustit, protože „architektura je hotová". Firma přitom působí na rychle se měnícím trhu a dodavatelé klíčových technologií ohlásili zásadní změny. Jak má architekt vedení vysvětlit další potřebu architektonické práce?

- [ ] Architektura se po implementaci pouze archivuje a znovu otevře až při další strategii
- [x] Architektura se dál spravuje ve Phase H: sledují se změny, přínosy a rizika
- [ ] Tým je nutný, protože Phase G pokračuje až do vypršení všech Architecture Contracts
- [ ] Tým musí ihned zahájit novou iteraci ADM, protože každá iterace na předchozí navazuje

> Phase H zajišťuje průběžnou správu architektury: monitoring změn v businessu a technologiích, vyhodnocování přínosů a rizik a rozhodování o změnách. Archivace by ignorovala oznámené změny, Phase G se týká implementace a nová iterace se spouští až na základě posouzení změny, ne automaticky.

### ? Rok po spuštění nové omnikanálové platformy se představenstvo ptá, zda přinesla zvýšení konverze a snížení nákladů slíbené v Architecture Vision. Žádná měření zatím nikdo nezavedl. Co by měl architekt v rámci Phase H prosadit?

- [ ] Nový Compliance Review platformy se zaměřením na dodržení technických standardů
- [ ] Opakovanou Gap Analysis mezi Baseline a Target Architecture prodejních kanálů
- [ ] Nový Business Scenario, který popíše, jak má omnikanálový prodej vypadat
- [x] Proces realizace hodnoty s měřítky odvozenými z cílů ve vizi a jejich sledováním

> Ověření přínosů je úkolem procesu realizace hodnoty (value realization) s monitoringem ve Phase H. Compliance Review hodnotí soulad s architekturou, ne obchodní přínos, a Gap Analysis ani Business Scenario na otázku dosažených výsledků neodpovídají.

## Odkud přicházejí podněty ke změně {#zdroje-zmen .explain}

Podněty ke změně architektury mají různý původ: **strategické změny shora** (nová strategie, akvizice, regulace), **změny zdola** napravující nebo vylepšující stávající schopnosti a **zkušenosti z dříve dodaných projektů** včetně Change Requests z Phase G. Z technologické strany jde o nové technologie, možnosti úspor, ukončení podpory produktů či nové standardy. Každý podnět se **zaregistruje** jako Change Request, posoudí se jeho dopad a teprve pak se rozhodne o způsobu řešení. Požadavky se zároveň předávají do Requirements Management.

*Příklad:* Dodavatel ohlásí konec podpory middleware za 18 měsíců; tým změnu zaeviduje, zjistí, kterých aplikací se týká, a připraví návrh řešení.

### ? Dodavatel databázové platformy, na které běží většina podnikových aplikací, oznámil ukončení podpory za osmnáct měsíců. Několik projektových týmů už začalo samostatně zkoumat různé náhradní produkty. Co je nejvhodnějším postupem architekta?

- [x] Zaregistrovat změnu jako Change Request a posoudit dopad na celou architekturu
- [ ] Nechat každý tým zvolit náhradu sám, protože zná potřeby své aplikace nejlépe
- [ ] Ihned objednat nejrozšířenější náhradní produkt, aby se nepromeškala lhůta
- [ ] Počkat, až podpora skutečně skončí, a řešit jen aplikace, které přestanou fungovat

> Technologická změna s dopadem napříč podnikem se ve Phase H registruje jako Change Request a posoudí se její dopad, aby se rozhodlo o jednotném řešení. Samostatné volby týmů vedou k roztříštění, okamžitý nákup přeskakuje analýzu a čekání do konce podpory vytváří zbytečné riziko.

### ? Během implementace nového skladového systému dodavatel zjistí, že cílová architektura předpokládá synchronní volání služby, která v praxi nezvládne potřebnou zátěž. Navrhuje asynchronní frontu, což je v rozporu s jedním z návrhových pravidel architektury. Jak má s tímto podnětem architekt naložit?

- [ ] Nechat dodavatele frontu tiše použít, protože jde o technický detail implementace
- [ ] Trvat na synchronním volání, protože architektura je pro projekt závazná beze změn
- [x] Vystavit Change Request vzniklý z implementace a nechat ho posoudit v řízení změn
- [ ] Vrátit celý program do Phase A a znovu připravit Architecture Vision

> Zkušenost z implementace, která zpochybňuje část architektury, se zachytí jako Change Request a posoudí v Architecture Change Management. Tichá odchylka obchází governance, slepé trvání na nefunkčním řešení ignoruje skutečný problém a návrat do Phase A je pro dílčí technický podnět nepřiměřený.

## Tři druhy změn v Phase H {#klasifikace-zmen .compare}

TOGAF rozlišuje změny podle toho, jak hluboký zásah do architektury vyžadují:

| Druh změny | Typický motiv | Obvyklé řešení |
|---|---|---|
| Simplification change (zjednodušující) | snížit investice, konsolidovat, zjednodušit | běžné řízení změn (change management) |
| Incremental change (inkrementální) | získat více hodnoty ze stávající investice | change management, nebo částečné přepracování architektury — podle povahy |
| Re-architecting change (re-architekturní) | vyšší investice kvůli nové hodnotě | nový průchod cyklem ADM |

### ? Firma po předchozích akvizicích provozuje dva funkčně téměř shodné nástroje pro interní reporting. Vedení chce snížit licenční náklady a jeden nástroj zrušit; uživatelé nepřijdou o žádnou schopnost a nevzniká žádná nová schopnost ani nová investice. Jak má architekt změnu klasifikovat a řešit?

- [ ] Re-architecting change, kterou je nutné řešit novým cyklem ADM
- [ ] Incremental change, která vyžaduje částečné přepracování architektury
- [x] Simplification change, kterou lze řešit běžným řízením změn
- [ ] Žádnou změnu architektury, kterou stačí oznámit uživatelům

> Konsolidace se snížením nákladů bez ztráty schopností je zjednodušující změna, obvykle zvládnutelná běžným řízením změn. Inkrementální změna přináší novou hodnotu ze stávající investice, re-architekturní vyžaduje nový cyklus a i zjednodušení se má zaznamenat v architektuře, ne jen oznámit.

### ? Banka chce na stávající platformě internetového bankovnictví zpřístupnit klientům novou samoobslužnou funkci změny limitů karet. Platforma i integrační vrstva zůstávají, přibude jedna služba a úprava jednoho procesu. Cílem je vytěžit více hodnoty z investice, která už byla udělána. O jaký druh změny jde?

- [ ] Simplification change, protože se využívá stávající platforma
- [x] Incremental change, řešená change managementem nebo dílčí úpravou
- [ ] Re-architecting change, protože přibývá nová služba pro klienty
- [ ] Dispensation, protože jde o odchylku od schválené architektury

> Získání další hodnoty ze stávající investice odpovídá inkrementální změně, kterou lze podle povahy řešit change managementem nebo částečným přepracováním. Nejde o zjednodušení ani o zásadní novou investici a dispensation není druh změny, ale výjimka ze souladu.

### ? Výrobce průmyslových čerpadel se sloučí s konkurentem a nová společnost chce vstoupit na trh služeb založených na vzdáleném monitoringu zařízení. Změní se obchodní model, procesy, datové toky i technologická platforma ve většině divizí. Jak má architekt s touto změnou naložit?

- [ ] Řešit ji jako incremental change postupnými úpravami stávající architektury
- [ ] Udělit divizím dispensations, dokud se nová organizace nestabilizuje
- [ ] Zpracovat ji jako simplification change, protože sloučení odstraní duplicity
- [x] Klasifikovat ji jako re-architecting change a spustit nový cyklus ADM

> Zásadní změna strategie a obchodního modelu s dopadem na všechny domény je re-architekturní změna, která vyžaduje nový průchod ADM. Postupné úpravy by nezajistily konzistentní novou architekturu, dispensations problém jen odkládají a odstranění duplicit není hlavní podstatou změny.

## Rozhodnutí: change management, nebo nová iterace ADM {#pravidla-rozhodnuti .explain}

Při posuzování Change Request pomáhají jednoduchá vodítka: změna, která se dotýká **jen jednoho stakeholdera**, je spíše kandidátem pro běžné řízení změn; změna s dopadem na **dva a více stakeholderů** pravděpodobně vyžaduje přepracování architektury a návrat do ADM; změna, kterou lze pokrýt **dispensation**, spadá spíše do řízení změn. Vždy se nejprve posoudí dopad a změna se zaregistruje, rozhodnutí přísluší governance (Architecture Board nebo jím pověřené roli). Vodítka nejsou mechanická pravidla — rozhoduje i rozsah dopadu na principy a cílovou architekturu.

*Příklad:* Úprava schvalovacího workflow v jednom oddělení jde do change managementu; nový požadavek regulátora na data napříč divizemi spustí architektonickou práci.

### ? Personální oddělení chce do stávajícího HR systému přidat nové pole pro evidenci jazykových certifikátů. Změna se netýká jiných útvarů ani rozhraní a je v souladu se stávajícími standardy. Jak má být změna podle vodítek TOGAF řešena?

- [x] Běžným řízením změn, protože se dotýká jediného stakeholdera
- [ ] Novou iterací ADM, protože jde o změnu podnikové aplikace
- [ ] Žádostí o dispensation, protože mění schválené řešení
- [ ] Novým Architecture Contract s dodavatelem HR systému

> Změna s dopadem na jediného stakeholdera a v souladu se standardy je typickým kandidátem pro běžné řízení změn. Nová iterace ADM je nepřiměřená, dispensation se uděluje pro odchylku od architektury a nový kontrakt drobnou změnu neřeší.

### ? Regulátor zavádí nové pravidlo pro uchovávání transakčních dat. Dotkne se finančního oddělení, logistiky, zákaznického servisu i externích partnerů, kteří data dodávají, a změní požadavky na datovou architekturu. Jaký postup je podle vodítek Phase H nejvhodnější?

- [ ] Řešit změnu v rámci change managementu každého útvaru zvlášť
- [ ] Udělit útvarům dispensation, dokud regulátor nevydá výklad
- [x] Počítat s přepracováním architektury a návratem do cyklu ADM
- [ ] Předat změnu přímo projektům bez posouzení architektonického dopadu

> Změna s dopadem na více stakeholderů a na datovou architekturu pravděpodobně vyžaduje přepracování architektury a nový vstup do ADM. Řešení po útvarech by vedlo k nekonzistenci, dispensation zákonnou povinnost neřeší a obejití posouzení dopadu odporuje řízení změn.

### ? Pobočka obchodní firmy potřebuje na půl roku provozovat starší pokladní software, protože nové pokladny dorazí se zpožděním. Cílová architektura se nemění a po dodání se pobočka na standard převede. Jak je vhodné tuto situaci řešit?

- [ ] Spustit novou iteraci ADM a do cílové architektury doplnit starší software
- [x] Řešit ji řízením změn, protože ji lze pokrýt časově omezenou dispensation
- [ ] Podat Change Request na zrušení standardu pokladních systémů v celé firmě
- [ ] Nechat pobočku provozovat software bez rozhodnutí, protože jde o přechodný stav

> Změna, kterou lze pokrýt dispensation, je podle vodítek kandidátem pro řízení změn, ne pro nový cyklus ADM. Rušit standard kvůli dočasnému zpoždění nedává smysl a provoz bez rozhodnutí obchází governance.

## Spuštění nové iterace ADM z Phase H {#nova-iterace .explain}

Když posouzení ukáže, že změna vyžaduje přepracování architektury, výstupem Phase H je **nový Request for Architecture Work**, který zahájí další cyklus ADM — obvykle od Phase A s novým rozsahem a vizí. Pokud se změna týká samotného architektonického rámce, principů nebo governance, výstupem jsou i **změny architektonického rámce a principů**, které se promítnou do Preliminary Phase. Dalšími výstupy Phase H bývají aktualizace architektury, Statement of Architecture Work, Architecture Contracts a Compliance Assessments. Nová iterace nezačíná skokem přímo do technologické domény.

*Příklad:* Po rozhodnutí o vstupu na nový trh vznikne nový Request for Architecture Work a tým připraví novou Architecture Vision se stakeholdery.

### ? Architecture Board na základě posouzení dopadu rozhodl, že nová strategie expanze do zahraničí vyžaduje přepracování architektury v několika doménách. Architekt má formálně zahájit další architektonickou práci. Který výstup Phase H ji iniciuje?

- [ ] Aktualizovaný Architecture Contract s implementačními partnery
- [ ] Nový Compliance Assessment stávajících řešení v zahraničí
- [ ] Aktualizovaná Architecture Roadmap s novými work packages
- [x] Nový Request for Architecture Work pro další cyklus ADM

> Rozhodnutí o přepracování architektury se z Phase H promítne do nového Request for Architecture Work, který zahájí další cyklus ADM. Kontrakt, compliance hodnocení ani roadmapa novou architektonickou práci neiniciují; roadmapa navíc vzniká až ve Phases E–F nového cyklu.

### ? Vyhodnocení ve Phase H ukázalo, že problémy posledních let nevznikají v konkrétních architekturách, ale v samotném fungování architektonické práce: principy jsou nejasné a schvalovací proces Architecture Board je pomalý a nikdo ho nedodržuje. Kam se má tento výsledek promítnout?

- [x] Do změn architektonického rámce a principů, řešených v Preliminary Phase
- [ ] Do nové Architecture Vision, kterou připraví Phase A dalšího cyklu ADM
- [ ] Do aktualizace Technology Architecture a Standards Library ve Phase D
- [ ] Do nových Architecture Contracts s projekty, které budou teprve zahájeny

> Problémy s principy a governance se týkají architektonického rámce a kapability, tedy oblasti Preliminary Phase; Phase H má mezi výstupy změny rámce a principů. Nová vize, technologická architektura ani kontrakty fungování samotné architektonické práce nenapraví.

### ? Nová regulace mění způsob, jakým pojišťovna vyřizuje pojistné události — dotkne se procesů, dat i aplikací. Board rozhodl o re-architekturní změně. Tým navrhuje rovnou otevřít Phase D a vyměnit technologickou platformu, protože technologie je „nejviditelnější" částí změny. Co má architekt doporučit?

- [ ] Souhlasit a otevřít Phase D, protože technologická platforma je pro regulaci klíčová
- [ ] Začít rovnou Phase E a sestavit work packages, aby se změna stihla zavést včas
- [x] Vystavit nový Request for Architecture Work a začít Phase A vymezením rozsahu a vize
- [ ] Řešit změnu dočasnými dispensations, dokud regulace nevstoupí v plnou účinnost

> Re-architekturní změna znamená nový průchod ADM: Phase H vystaví nový Request for Architecture Work a cyklus začíná vymezením rozsahu a vize ve Phase A. Skok do Phase D nebo E přeskakuje business a datové dopady regulace a dispensations zákonnou povinnost neřeší.
