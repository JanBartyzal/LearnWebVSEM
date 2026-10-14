---
kind: topic
subject: ict-strategie
slug: ekonomicke-a-organizacni-analyzy-informatiky-sla
name: "Ekonomické a organizační analýzy informatiky (SLA)"
order: 9
---

Ekonomické a organizační analýzy informatiky, jako např. nákladové analýzy, ukazatelé efektů z informatiky a možnosti jejich exaktního měření a hodnocení, problémy alokace nákladů na informatiku na jednotlivé útvary apod. Analýzy efektů informatiky podle základních zdrojů, v tomto případě aplikací, které je přinášejí, resp. jsou s jejich implementací spojeny. Analýza ukazatele cena / výkon podle jednotlivých provozovaných úloh nebo poskytovaných služeb. Dopady sledovaných nákladů do dokumentů SLA (Service Level Agreement).

## Členění nákladů na informatiku {#cleneni-nakladu-it .compare}

Nákladová analýza informatiky třídí náklady z několika hledisek; nejčastěji podle charakteru výdaje a podle toho, zda je lze přímo přiřadit k IT.

| Hledisko | Kategorie | Příklady |
|---|---|---|
| Charakter výdaje | **investiční** (CAPEX) — jednorázové pořízení dlouhodobého majetku | nákup serverů, licence na dobu neurčitou, implementace nového ERP |
| | **provozní** (OPEX) — opakované náklady běžného chodu | maintenance licencí, cloudové předplatné, energie, mzdy provozu |
| Přiřaditelnost k IT | **přímé** — evidované v rozpočtu IT | hardware, software, služby dodavatelů, mzdy IT útvaru |
| | **nepřímé (skryté)** — vznikají mimo IT, často se nesledují | čas uživatelů při výpadcích, vzájemná výpomoc kolegů, „stínové IT" v útvarech |

### ? Firma přechází z vlastních serverů na pronájem cloudové infrastruktury placené měsíčně. Jak se tím typicky změní struktura nákladů na IT?

- [x] Část investičních nákladů se přesune do provozních
- [ ] Část provozních nákladů se přesune do investičních
- [ ] Zmizí všechny nepřímé náklady uživatelů
- [ ] Náklady přestanou být přiřaditelné k IT

> Cloud se platí průběžně jako služba (OPEX), místo aby firma jednorázově investovala do vlastního hardwaru (CAPEX). Nepřímé náklady, např. ztracený čas uživatelů, tím nezanikají.

### ? Které z uvedených nákladů jsou nepřímým (skrytým) nákladem na informatiku?

- [ ] Roční poplatek dodavateli za podporu a údržbu ERP
- [ ] Mzdy správců sítě v IT útvaru
- [x] Čas obchodníků ztracený při výpadku CRM
- [ ] Nákup nových notebooků pro účtárnu

> Nepřímé náklady vznikají mimo rozpočet IT, typicky jako ztráta produktivity uživatelů. Ostatní položky jsou přímé náklady evidované v rozpočtu IT.

## Celkové náklady vlastnictví (TCO) {#tco .explain}

**TCO (Total Cost of Ownership)** jsou celkové náklady spojené s pořízením, provozem, údržbou a vyřazením IT prostředku (aplikace, zařízení, služby) **za celou dobu jeho životnosti**, nikoli jen pořizovací cena. Zahrnuje jednorázové náklady (hardware, licence, implementace, migrace dat, školení) i opakované náklady (podpora a maintenance, provoz, energie, personál, upgrady), a pokud je to možné, i nepřímé náklady uživatelů. Výpočet: `TCO = jednorázové náklady + Σ roční provozní náklady za sledované období`. TCO slouží hlavně ke **srovnání variant** (vlastní provoz × cloud, dva dodavatelé) na stejném časovém horizontu.

*Příklad:* Levnější licence může mít vyšší TCO, pokud vyžaduje dražší provoz a více specialistů na správu.

### ? Firma pořizuje nový systém: hardware 400 000 Kč, licence 600 000 Kč, implementace 300 000 Kč. Roční náklady na podporu jsou 120 000 Kč a na provoz a personál 180 000 Kč. Jaké je TCO za 5 let?

- [ ] 1 300 000 Kč
- [ ] 1 600 000 Kč
- [ ] 2 500 000 Kč
- [x] 2 800 000 Kč

> Jednorázové náklady: 400 000 + 600 000 + 300 000 = 1 300 000 Kč. Roční náklady: 120 000 + 180 000 = 300 000 Kč, za 5 let 1 500 000 Kč. TCO = 1 300 000 + 1 500 000 = 2 800 000 Kč.

### ? Varianta A (vlastní provoz) stojí na začátku 900 000 Kč a ročně 150 000 Kč. Varianta B (SaaS) stojí na začátku 100 000 Kč za implementaci a ročně 400 000 Kč. Která varianta má nižší TCO za 3 roky a o kolik?

- [ ] Varianta A, o 50 000 Kč
- [x] Varianta B, o 50 000 Kč
- [ ] Varianta B, o 500 000 Kč
- [ ] Obě varianty mají stejné TCO

> TCO A = 900 000 + 3 × 150 000 = 1 350 000 Kč. TCO B = 100 000 + 3 × 400 000 = 1 300 000 Kč. Varianta B je levnější o 50 000 Kč.

### ? Proč se při výběru IT řešení nemá rozhodovat jen podle pořizovací ceny?

- [ ] Pořizovací cena se do účetnictví vůbec nepromítá
- [ ] Provozní náklady IT jsou vždy zanedbatelné
- [ ] Pořizovací cena už zahrnuje náklady na celou dobu životnosti
- [x] Provoz a údržba mohou pořizovací cenu výrazně převýšit

> Podstatou TCO je, že náklady na podporu, provoz, personál a upgrady se sčítají po celou dobu životnosti a často tvoří větší část celkových nákladů než samotné pořízení.

## Alokace nákladů na informatiku {#alokace-nakladu .explain}

**Alokace nákladů** je rozpočítání nákladů na informatiku na útvary (nákladová střediska), které IT služby využívají. Přímo přiřaditelné náklady (např. licence aplikace, kterou používá jen jeden útvar) se přiřadí přímo, **společné náklady** (síť, datové centrum, service desk) se rozpočítávají pomocí **alokačních klíčů** — např. počet uživatelů nebo pracovních stanic, počet transakcí, objem dat, počet požadavků na service desk, spotřebovaný strojový čas. Problémem je, že žádný klíč neodráží spotřebu přesně, příliš podrobné měření je nákladné a nespravedlivý klíč vyvolává spory s útvary. Dobrý klíč má být **srozumitelný, měřitelný a co nejvíce odpovídat skutečnému čerpání** služby.

*Příklad:* Náklady na provoz e-mailu se rozpočítají podle počtu poštovních schránek, náklady na tiskové služby podle počtu vytištěných stran.

### ? Společné roční náklady na IT infrastrukturu jsou 2 000 000 Kč a rozpočítávají se podle počtu uživatelů. Obchod má 50 uživatelů, výroba 30 a účetnictví 20. Kolik připadne na výrobu?

- [x] 600 000 Kč
- [ ] 300 000 Kč
- [ ] 666 667 Kč
- [ ] 1 000 000 Kč

> Celkem je 50 + 30 + 20 = 100 uživatelů, na jednoho připadá 2 000 000 / 100 = 20 000 Kč. Výroba: 30 × 20 000 = 600 000 Kč.

### ? Náklady na service desk se dosud rozpočítávaly podle počtu zaměstnanců útvarů. Útvar s mnoha zaměstnanci, kteří IT téměř nevyužívají, protestuje. Jaký alokační klíč by lépe odpovídal skutečné spotřebě?

- [ ] Podíl útvaru na tržbách firmy
- [ ] Rovným dílem mezi všechny útvary bez ohledu na velikost
- [x] Počet požadavků útvaru na service desk
- [ ] Rozloha kanceláří útvaru

> Alokační klíč má co nejvíce odpovídat skutečnému čerpání služby. U service desku to je počet (případně pracnost) požadavků, ne velikost útvaru, tržby nebo plocha.

## Chargeback × showback {#chargeback-showback .compare}

Oba přístupy vycházejí z alokace nákladů na IT služby; liší se tím, zda útvary náklady skutečně platí.

| | Showback | Chargeback |
|---|---|---|
| Princip | útvarům se náklady jen **ukazují** (reportují) | náklady se útvarům **skutečně účtují** (vnitropodnikové přeúčtování) |
| Dopad na rozpočet útvaru | žádný, náklady zůstávají v rozpočtu IT | snižuje rozpočet/hospodářský výsledek útvaru |
| Účel | zvýšit povědomí o nákladech, transparentnost | motivovat útvary k hospodárnému využívání IT |
| Riziko | slabší motivace šetřit | spory o ceny a klíče, administrativní náročnost |

Showback se často používá jako první krok před zavedením chargebacku.

### ? IT útvar každý měsíc posílá vedoucím útvarů přehled, kolik stály jimi využívané IT služby, ale do jejich rozpočtů nic nepřeúčtovává. Jaký přístup používá?

- [ ] Chargeback
- [x] Showback
- [ ] Profit centrum
- [ ] Outsourcing

> Při showbacku se náklady útvarům pouze zobrazují pro informaci. Kdyby se jim skutečně přeúčtovávaly, šlo by o chargeback.

### ? Jaký je hlavní důvod, proč vedení zavádí chargeback IT služeb?

- [ ] Odstranit potřebu sledovat náklady na IT
- [ ] Přesunout veškerý provoz IT k externímu dodavateli služeb
- [ ] Zjednodušit administrativu útvaru IT
- [x] Motivovat útvary k hospodárnému čerpání IT služeb

> Když útvar za službu skutečně platí ze svého rozpočtu, má důvod zvažovat, kolik služeb a v jaké úrovni opravdu potřebuje. Administrativu naopak chargeback zvyšuje.

## Přínosy (efekty) informatiky {#prinosy-it .compare}

Efekty z informatiky se dělí podle toho, zda je lze vyjádřit v penězích.

| | Hmotné (kvantifikovatelné) přínosy | Nehmotné (obtížně kvantifikovatelné) přínosy |
|---|---|---|
| Podstata | lze je změřit a převést na peníze | lze je popsat, ale těžko vyčíslit |
| Příklady | úspora pracovních hodin, snížení zásob, nižší náklady na tisk, rychlejší inkaso pohledávek | lepší informovanost managementu, spokojenost zákazníků, image firmy, lepší rozhodování |
| Použití v hodnocení | přímo vstupují do ROI a NPV | hodnotí se bodově, expertně nebo nepřímo přes ukazatele (KPI) |

Přínosy se dále dělí na **přímé** (plynou přímo z nasazení IT, např. méně ruční práce) a **nepřímé** (projeví se zprostředkovaně, např. vyšší tržby díky lepšímu servisu zákazníkům).

### ? Které z uvedených je nehmotným přínosem nového CRM systému?

- [ ] Snížení nákladů na poštovné o 80 000 Kč ročně
- [ ] Úspora 2 000 hodin ruční práce ročně
- [ ] Zkrácení doby inkasa pohledávek o 5 dní
- [x] Lepší přehled obchodníků o vztahu se zákazníkem

> Lepší informovanost a přehled se těžko převádějí na peníze, jde tedy o nehmotný přínos. Ostatní možnosti jsou měřitelné a dají se vyčíslit.

### ? Jak se v hodnocení IT projektu obvykle pracuje s nehmotnými přínosy?

- [x] Hodnotí se bodově či expertně nebo přes vhodné ukazatele
- [ ] Nezohledňují se vůbec, protože je nelze spolehlivě změřit
- [ ] Započítávají se do ROI ve výši pořizovací ceny
- [ ] Nahrazují se celkovými náklady TCO

> Nehmotné přínosy nejdou spolehlivě vyjádřit v penězích, a proto se nedávají přímo do ROI. Projekt se jimi ale nevynechává — hodnotí se bodově, expertním odhadem nebo nepřímo přes KPI.

## Měření efektů informatiky {#mereni-efektu .explain}

Exaktní měření přínosů IT je obtížné, protože efekty obvykle **nevznikají samotnou technologií**, ale až spolu se změnou procesů, organizace a chování lidí, projevují se se **zpožděním** a těžko se oddělují od jiných vlivů (trh, sezónnost). Aby šlo přínosy měřit, je třeba **předem** stanovit měřitelné cíle a ukazatele (KPI), zjistit jejich **výchozí hodnotu** (baseline) před nasazením a po nasazení měřit stejné ukazatele stejným způsobem. Přínosy se přiřazují konkrétním procesům a aplikacím a měří se v čase (např. po půl roce a po roce). Nesoulad mezi velkými investicemi do IT a obtížně prokazatelným růstem produktivity se označuje jako **produktivitní paradox IT**.

*Příklad:* Před zavedením skenování dokladů firma změří, že zpracování jedné faktury trvá 12 minut; po roce provozu měří stejný ukazatel znovu a rozdíl převede na úsporu hodin.

### ? Firma chce po zavedení nového skladového systému prokázat zkrácení doby vyskladnění objednávky. Co musela udělat PŘED nasazením systému?

- [ ] Spočítat celkové náklady vlastnictví (TCO) systému za pět let
- [x] Změřit výchozí dobu vyskladnění
- [ ] Zavést chargeback skladových služeb
- [ ] Uzavřít se skladem dohodu OLA

> Bez výchozí hodnoty (baseline) změřené před nasazením nelze zlepšení prokázat. Po nasazení se stejný ukazatel měří znovu a porovná.

### ? Proč je obtížné přesně připsat přínos konkrétní IT investici?

- [ ] Přínosy IT se vždy projeví okamžitě po spuštění
- [ ] Účetnictví neumí evidovat náklady na IT odděleně od ostatních nákladů
- [x] Efekt vzniká spolu se změnami procesů a ovlivňují ho i jiné faktory
- [ ] Přínosy IT jsou vždy výhradně nehmotné

> Výsledek je kombinací technologie, změny procesů a vnějších vlivů a projevuje se se zpožděním, proto je atribuce přínosů obtížná. IT přitom přináší i hmotné, měřitelné efekty.

## ROI IT projektu {#roi-it .explain}

**ROI (Return on Investment, návratnost investice)** vyjadřuje, kolik čistého přínosu přinesla investice v poměru k jejím nákladům: `ROI = (přínosy − náklady) / náklady × 100 %`. Přínosy i náklady se berou za stejné období (např. 3 roky). Kladné ROI znamená, že přínosy převýšily náklady. Příbuzným ukazatelem je **doba návratnosti** (payback period): `doba návratnosti = investice / roční čistý přínos` (při stejných ročních přínosech). Oba ukazatele jsou jednoduché, ale nezohledňují **časovou hodnotu peněz** — tu řeší NPV. (Pozor: ROI v throughput accounting metody TOC se počítá jinak — (T − OE) / I.)

*Příklad:* Automatizace fakturace za 1 mil. Kč, která ročně ušetří 400 000 Kč, se vrátí za 2,5 roku.

### ? IT projekt stál 2 000 000 Kč a během tří let přinesl úspory 800 000 Kč ročně. Jaké je ROI za tyto tři roky?

- [ ] 40 %
- [ ] 83 %
- [x] 20 %
- [ ] 120 %

> Přínosy: 3 × 800 000 = 2 400 000 Kč. ROI = (2 400 000 − 2 000 000) / 2 000 000 = 0,2, tedy 20 %.

### ? Investice do nového e-shopu je 1 500 000 Kč a roční čistý přínos se odhaduje na 500 000 Kč. Jaká je prostá doba návratnosti?

- [ ] 2 roky
- [x] 3 roky
- [ ] 5 let
- [ ] 0,33 roku

> Doba návratnosti = investice / roční čistý přínos = 1 500 000 / 500 000 = 3 roky.

## NPV pro IT investice {#npv-it .explain}

**NPV (Net Present Value, čistá současná hodnota)** převádí budoucí peněžní přínosy na dnešní hodnotu pomocí **diskontní sazby** a odečte od nich investici: `NPV = Σ CFₜ / (1 + r)ᵗ − investice`, kde CFₜ je čistý peněžní tok v roce t a r diskontní sazba (požadovaná výnosnost, cena kapitálu). Na rozdíl od ROI zohledňuje, že koruna získaná za tři roky má menší hodnotu než koruna dnes. **NPV > 0** znamená, že projekt vytváří hodnotu nad požadovanou výnosnost a je přijatelný; při výběru mezi variantami je výhodnější ta s vyšším NPV.

*Příklad:* Dva projekty s celkovými přínosy 1 mil. Kč — ten, který přínosy generuje dříve, má vyšší NPV.

### ? IT projekt vyžaduje investici 1 000 000 Kč a přinese čistý peněžní tok 600 000 Kč na konci 1. roku a 600 000 Kč na konci 2. roku. Diskontní sazba je 10 %. Jaká je přibližně NPV?

- [ ] +200 000 Kč
- [ ] +90 909 Kč
- [ ] −41 322 Kč
- [x] +41 322 Kč

> Současná hodnota: 600 000 / 1,1 = 545 455 Kč a 600 000 / 1,1² = 600 000 / 1,21 = 495 868 Kč, součet 1 041 322 Kč. NPV = 1 041 322 − 1 000 000 ≈ +41 322 Kč.

### ? Co znamená, že IT projekt má NPV kladnou?

- [x] Diskontované přínosy převyšují investici, projekt vytváří hodnotu
- [ ] Projekt se vrátí do jednoho roku a poté už jen vydělává
- [ ] Projekt nemá žádné provozní náklady
- [ ] Nehmotné přínosy převyšují hmotné

> Kladná NPV říká, že současná hodnota budoucích přínosů při zvolené diskontní sazbě je vyšší než investice. O délce návratnosti ani o nehmotných přínosech nic přímo neříká.

### ? Proč je NPV pro hodnocení dlouhodobé IT investice vhodnější než prosté ROI?

- [ ] Nevyžaduje odhad budoucích přínosů
- [ ] Zahrnuje automaticky i nehmotné přínosy
- [x] Zohledňuje časovou hodnotu peněz
- [ ] Nepotřebuje znát výši investice

> NPV diskontuje budoucí peněžní toky, takže pozdější přínosy mají menší váhu. Prosté ROI sčítá přínosy bez ohledu na to, kdy vzniknou.

## Analýza efektů podle aplikací {#efekty-podle-aplikaci .explain}

Analýza efektů podle aplikací přiřazuje náklady i přínosy informatiky **konkrétním aplikacím**, protože právě aplikace jsou zdrojem efektů pro byznys. Pro každou aplikaci se sleduje zejména: podporované procesy a útvary, náklady (TCO aplikace, podíl na infrastruktuře), využití (počet uživatelů, transakcí), dosahované přínosy, kritičnost pro byznys a technický stav. Výsledkem je přehled, které aplikace přinášejí hodnotu úměrnou nákladům, a podklad pro rozhodnutí o portfoliu aplikací: **dále rozvíjet, ponechat, nahradit, nebo vyřadit**. Analýza zároveň odhalí duplicitní aplikace se stejnou funkcí.

*Příklad:* Analýza ukáže, že dva útvary platí za dvě různé aplikace na správu smluv; firma jednu vyřadí a uživatele převede na druhou.

### ? Analýza ukázala, že stará aplikace na evidenci reklamací má vysoké náklady na údržbu, používají ji jen tři lidé a její funkci pokrývá i nové CRM. Jaké rozhodnutí analýza efektů podle aplikací nejspíš doporučí?

- [ ] Aplikaci dále rozvíjet a rozšířit uživatele
- [x] Aplikaci vyřadit a uživatele převést do CRM
- [ ] Zachovat obě aplikace a zvýšit jim rozpočet
- [ ] Převést náklady aplikace do showbacku

> Vysoké náklady, nízké využití a duplicita funkcí s jinou aplikací jsou typickým důvodem k vyřazení aplikace z portfolia.

### ? Proč se efekty informatiky analyzují právě po jednotlivých aplikacích?

- [ ] Aplikace jsou jedinou nákladovou položkou IT a ostatní náklady jsou zanedbatelné
- [ ] Přínosy hardwaru nelze nikdy změřit
- [ ] Účetní předpisy to vyžadují
- [x] Aplikace přímo podporují procesy, a jsou tak zdrojem přínosů pro byznys

> Byznys pociťuje efekty IT prostřednictvím aplikací podporujících jeho procesy. Přiřazení nákladů a přínosů aplikacím proto umožňuje posoudit hodnotu každé z nich.

## Ukazatel cena / výkon {#cena-vykon .explain}

Ukazatel **cena / výkon** porovnává náklady na úlohu nebo IT službu s jejím výkonem, tedy s objemem poskytnutých jednotek. Typicky se vyjadřuje jako **jednotkové náklady**: náklady na uživatele měsíčně, na transakci, na zpracovaný doklad, na vyřešený požadavek, na GB uložených dat. Umožňuje sledovat vývoj efektivity v čase, porovnávat služby mezi sebou nebo s externí nabídkou (benchmarking, rozhodování o outsourcingu) a je základem pro **ocenění služeb** v katalogu a v SLA. Výkon se musí měřit ve srovnatelných jednotkách a při stejné úrovni kvality služby.

*Příklad:* Interní provoz e-mailu stojí 300 Kč na schránku měsíčně, cloudová nabídka se srovnatelnými parametry 150 Kč — podklad pro úvahu o změně sourcingu.

### ? Služba e-mailu stojí firmu ročně 1 200 000 Kč a využívá ji 400 uživatelů. Jaké jsou náklady na jednoho uživatele měsíčně?

- [x] 250 Kč
- [ ] 300 Kč
- [ ] 400 Kč
- [ ] 3 000 Kč

> Na uživatele ročně: 1 200 000 / 400 = 3 000 Kč, měsíčně 3 000 / 12 = 250 Kč.

### ? Systém A zpracuje ročně 2 mil. transakcí s náklady 600 000 Kč, systém B 5 mil. transakcí s náklady 1 000 000 Kč (při stejné kvalitě). Který má lepší poměr cena / výkon?

- [ ] A, protože má nižší celkové náklady
- [ ] Oba mají stejný poměr
- [x] B, protože stojí 0,20 Kč na transakci proti 0,30 Kč
- [ ] A, protože stojí 0,20 Kč na transakci proti 0,30 Kč

> A: 600 000 / 2 000 000 = 0,30 Kč na transakci. B: 1 000 000 / 5 000 000 = 0,20 Kč. Lepší poměr cena / výkon má B, i když jeho celkové náklady jsou vyšší.

## SLA (Service Level Agreement) {#sla .term}

**SLA (Service Level Agreement, dohoda o úrovni služeb)** je dohoda mezi **poskytovatelem IT služby a zákazníkem**, která popisuje službu a **měřitelně stanovuje požadovanou úroveň** jejího poskytování (např. dostupnost, doby reakce a vyřešení), způsob měření a vykazování a důsledky nedodržení. Uzavírá se s externím dodavatelem jako součást smlouvy i uvnitř firmy mezi útvarem IT a byznysovými útvary.

### ? Co je hlavním účelem SLA?

- [ ] Popsat interní organizační strukturu a role uvnitř útvaru IT poskytovatele
- [x] Měřitelně sjednat úroveň poskytování služby mezi poskytovatelem a zákazníkem
- [ ] Stanovit alokační klíče pro rozpočítání nákladů IT
- [ ] Vyhodnotit návratnost investice do IT služby

> SLA definuje, jakou kvalitu služby má poskytovatel zajistit a jak se to bude měřit. Alokace nákladů ani ROI nejsou jejím předmětem.

## Obsah dohody SLA {#obsah-sla .explain}

Typická SLA obsahuje: **popis služby** a její rozsah, **dobu poskytování** (servisní okno, např. 24×7 nebo 8×5) a plánované odstávky, **parametry kvality** s cílovými hodnotami (dostupnost, doba odezvy systému, doba reakce a vyřešení incidentu podle priority, kapacita), **způsob měření a reportingu**, povinnosti zákazníka, kontakty a **eskalační postup**, **cenu** služby, **sankce** (případně bonusy) za nedodržení a dobu platnosti s pravidly pro revizi. Parametry musí být **měřitelné** a odpovídat potřebám byznysu — příliš vysoká úroveň zbytečně zvyšuje náklady.

*Příklad:* SLA pro mzdový systém stanoví provoz 7–18 h v pracovní dny, dostupnost 99 % měsíčně, vyřešení kritického incidentu do 4 hodin a měsíční report dostupnosti.

### ? Která položka do dohody SLA obvykle NEPATŘÍ?

- [ ] Způsob měření a pravidelného vykazování dosažené dostupnosti
- [ ] Sankce za nedodržení sjednaných parametrů
- [ ] Servisní okno, v němž se služba poskytuje
- [x] Mzdy jednotlivých administrátorů poskytovatele

> SLA popisuje službu, její parametry, měření, cenu a důsledky nedodržení. Interní mzdy pracovníků poskytovatele nejsou předmětem dohody se zákazníkem.

### ? Vedoucí útvaru chce do SLA napsat „systém musí fungovat rychle a spolehlivě". Co je na tom špatně?

- [x] Parametry SLA musí být měřitelné, např. dostupnost v procentech a doby v hodinách
- [ ] SLA nesmí obsahovat žádné požadavky na kvalitu
- [ ] Požadavky na rychlost patří jen do dohody OLA
- [ ] Spolehlivost se v SLA nikdy nesleduje

> Obecné formulace nelze vyhodnotit ani vymáhat. SLA proto stanoví konkrétní cílové hodnoty a způsob, jak se budou měřit.

## Dostupnost služby a její výpočet {#dostupnost .explain}

**Dostupnost** je podíl sjednané doby provozu, po kterou byla služba skutečně k dispozici: `dostupnost = (sjednaná doba provozu − doba výpadků) / sjednaná doba provozu × 100 %`. Počítá se jen v rámci **servisního okna** (sjednané doby provozu); výpadky mimo něj a obvykle ani plánované odstávky ohlášené podle smlouvy se nezapočítávají — rozhoduje znění SLA. Každá „devítka" navíc znamená výrazně kratší povolený výpadek: při 24×7 je za rok (8 760 h) při 99 % povoleno 87,6 h výpadku, při 99,9 % jen 8,76 h. Dostupnost lze vyjádřit i pomocí spolehlivosti: `dostupnost = MTBF / (MTBF + MTTR)`, kde MTBF je střední doba mezi poruchami a MTTR střední doba obnovy.

*Příklad:* Při režimu 24×7 a 30denním měsíci (720 h) znamená dostupnost 99,5 % nejvýše 3,6 h výpadku za měsíc.

### ? SLA požaduje dostupnost 99,5 % v režimu 24×7 a měří se za 30denní měsíc. Jaký je nejvyšší povolený souhrnný výpadek za měsíc?

- [ ] 0,36 hodiny
- [x] 3,6 hodiny
- [ ] 7,2 hodiny
- [ ] 36 hodin

> Měsíc má 30 × 24 = 720 h. Povolený výpadek = 720 × (1 − 0,995) = 720 × 0,005 = 3,6 h.

### ? Služba se poskytuje v režimu 24×7. Za týden (168 h) byla celkem 1,68 h nedostupná. Jaká byla dostupnost?

- [ ] 98,32 %
- [ ] 99,5 %
- [x] 99 %
- [ ] 99,9 %

> Dostupnost = (168 − 1,68) / 168 = 166,32 / 168 = 0,99, tedy 99 %. Hodnota 98,32 % vznikne chybným odečtením hodin od 100 %.

### ? Servisní okno SLA je pondělí–pátek 8–16 h (40 h týdně). Během týdne nastal výpadek 2 h v pracovní době a další 3 h v noci. Jaká je dostupnost podle SLA?

- [x] 95 %
- [ ] 87,5 %
- [ ] 97,0 %
- [ ] 98,8 %

> Započítává se jen výpadek v servisním okně, tedy 2 h. Dostupnost = (40 − 2) / 40 = 0,95, tedy 95 %. Noční výpadek mimo sjednanou dobu provozu se nezapočítává.

## Doba reakce × doba vyřešení × doba odezvy {#doby-v-sla .compare}

SLA obvykle sjednává několik časových parametrů, které je třeba nezaměňovat.

| Parametr | Co měří | Příklad cílové hodnoty |
|---|---|---|
| **Doba reakce** | od nahlášení incidentu do potvrzení a zahájení práce na něm | kritický incident: reakce do 30 min |
| **Doba vyřešení** | od nahlášení incidentu do obnovení služby (vyřešení či náhradního řešení) | kritický incident: vyřešení do 4 h |
| **Doba odezvy systému** | výkonnost — za jak dlouho aplikace odpoví na požadavek uživatele | 95 % transakcí do 2 s |

Cílové doby reakce a vyřešení se obvykle **odstupňují podle priority** incidentu (dopad × naléhavost).

### ? Podle SLA má dodavatel u kritického incidentu „reagovat do 30 minut". Incident byl nahlášen v 9:00, technik začal pracovat v 9:20 a služba byla obnovena v 14:00. Co platí?

- [ ] Doba reakce byla porušena, protože služba nebyla obnovena do 30 minut
- [ ] Doba reakce byla 5 hodin
- [ ] Byla porušena doba odezvy systému
- [x] Doba reakce (20 min) byla dodržena; vyřešení posuzuje jiný parametr

> Doba reakce měří čas do zahájení práce, tj. 20 minut, a byla tedy splněna. Zda byla dodržena doba vyřešení (5 h), závisí na jejím samostatně sjednaném limitu.

### ? Uživatelé si stěžují, že vyhledání zákazníka v aplikaci trvá 15 sekund, přestože aplikace nemá výpadek. Který parametr SLA se tím sleduje?

- [ ] Dostupnost služby
- [x] Doba odezvy systému
- [ ] Doba vyřešení incidentu
- [ ] Doba reakce service desku

> Rychlost, s jakou systém odpovídá na požadavek uživatele, je výkonový parametr doba odezvy. Dostupnost by byla dotčena jen při úplné nedostupnosti služby.

## Sankce a servisní kredity v SLA {#sankce-sla .term}

**Sankce** jsou smluvené důsledky nedodržení parametrů SLA. U externích dodavatelů mají nejčastěji podobu **servisních kreditů** — slevy z ceny služby odstupňované podle míry porušení (např. dostupnost pod 99,5 % = sleva 10 %), případně smluvní pokuty a při opakovaném porušení právo smlouvu vypovědět. Někdy se sjednávají i **bonusy** za překročení cílů (bonus–malus). U interních SLA se místo finančních sankcí používá spíše eskalace a revize služby.

### ? Měsíční cena služby je 200 000 Kč. SLA stanoví slevu 10 % při dostupnosti pod 99,5 % a 25 % při dostupnosti pod 99,0 %. Skutečná dostupnost byla 99,2 %. Jaký servisní kredit dodavatel poskytne?

- [ ] 0 Kč
- [ ] 50 000 Kč
- [x] 20 000 Kč
- [ ] 70 000 Kč

> 99,2 % je pod hranicí 99,5 %, ale nad 99,0 %, platí tedy sleva 10 %: 200 000 × 0,10 = 20 000 Kč.

### ? Jakou podobu mají sankce v SLA s externím dodavatelem IT služeb nejčastěji?

- [x] Servisní kredity, tj. odstupňované slevy z ceny služby
- [ ] Automatické převedení služby zpět do vlastního provozu firmy
- [ ] Snížení rozpočtu útvaru, který službu využívá
- [ ] Prodloužení doby platnosti smlouvy

> Typickou sankcí jsou servisní kredity — sleva z ceny služby odpovídající míře nedodržení parametrů. Krajním důsledkem opakovaného porušení může být výpověď smlouvy.

## SLA × OLA × UC {#sla-ola-uc .compare}

Podle ITIL tvoří tyto dohody řetězec: aby IT mohlo splnit SLA vůči zákazníkovi, musí mít podložené závazky od interních týmů (OLA) i externích dodavatelů (UC).

| | SLA | OLA | UC |
|---|---|---|---|
| Název | Service Level Agreement | Operational Level Agreement | Underpinning Contract (podpůrná smlouva) |
| Strany | poskytovatel IT služby × **zákazník** (byznys) | poskytovatel služby × **jiná interní složka** téže organizace | poskytovatel služby × **externí dodavatel** |
| Charakter | dohoda o úrovni služby pro zákazníka | interní provozní dohoda | právně závazná obchodní smlouva |
| Příklad | IT × obchod: CRM dostupné na 99,5 % | service desk × síťový tým: zásah do 1 h | IT × operátor: konektivita na 99,9 % |

Parametry OLA a UC musí být nastaveny tak, aby **podporovaly splnění SLA** (např. kratší doby než v SLA).

### ? Interní tým správy databází se zavázal týmu provozu aplikací obnovit databázi do 2 hodin od požadavku. O jaký typ dohody jde?

- [ ] SLA
- [ ] UC
- [x] OLA
- [ ] Rámcová kupní smlouva

> Jde o dohodu mezi dvěma interními složkami téže IT organizace, tedy o OLA. SLA by se uzavírala se zákazníkem, UC s externím dodavatelem.

### ? IT útvar garantuje obchodu dostupnost e-shopu a se svým hostingovým providerem má smlouvu o dostupnosti serverů. Jak se nazývá smlouva s providerem?

- [ ] OLA
- [x] UC
- [ ] SLA se zákazníkem
- [ ] Showback

> Smlouva s externím dodavatelem, která podkládá plnění SLA vůči zákazníkovi, je podpůrná smlouva (Underpinning Contract, UC).

### ? Proč mají být doby vyřešení v OLA a UC obvykle kratší nebo stejné jako v navazující SLA?

- [ ] Protože OLA a UC jsou právně nevymahatelné
- [ ] Protože SLA se týká jen investičních nákladů
- [ ] Protože zákazník platí přímo interním týmům
- [x] Aby poskytovatel mohl závazek vůči zákazníkovi skutečně splnit

> Podpůrné dohody musí poskytovateli dát dostatečnou časovou rezervu. Pokud by dodavatel měl na opravu víc času, než IT slíbilo zákazníkovi, SLA by nebylo možné dodržet.

## Náklady a úroveň služby v SLA {#naklady-a-sla .explain}

Sledované náklady se do SLA promítají přes **cenu služby**: z nákladové analýzy a alokace vzniká kalkulace ceny jednotky služby (např. na uživatele či transakci), která se uvádí v katalogu služeb a v SLA. Úroveň služby a náklady spolu úzce souvisejí — vyšší dostupnost nebo delší servisní okno (24×7 místo 8×5) vyžaduje redundantní infrastrukturu, pohotovostní služby a dražší podporu dodavatelů, takže náklady rostou **výrazně rychleji** než sjednaná úroveň. Proto se často nabízí několik **úrovní služby** (např. zlatá, stříbrná, bronzová) s různou cenou a byznys volí úroveň podle toho, jakou škodu mu výpadek způsobí. Smyslem je sjednat úroveň, jejíž náklady odpovídají přínosu, a ne maximální možnou.

*Příklad:* Interní intranet stačí v úrovni 8×5 s dostupností 98 %, zatímco e-shop s nepřetržitými tržbami si platí 24×7 s dostupností 99,9 %.

### ? Obchodní ředitel požaduje pro interní reporting dostupnost 99,99 % v režimu 24×7, ačkoli se reporty používají jen v pracovní době. Jak má útvar IT postupovat?

- [ ] Vyhovět bez diskuse, vyšší úroveň je vždy lepší
- [ ] Požadavek odmítnout, protože SLA se uzavírá jen s dodavateli
- [x] Ukázat náklady různých úrovní a doporučit úroveň podle potřeby
- [ ] Nabídnout úroveň 99,99 % zdarma a náklady rozpustit v celkovém rozpočtu IT

> Vyšší úroveň služby znamená výrazně vyšší náklady. Byznys má volit úroveň podle přínosu a škody z výpadku — pro reporting používaný v pracovní době stačí nižší úroveň.

### ? Jak se sledované náklady na informatiku typicky promítají do SLA?

- [ ] Do SLA se uvádí celkový rozpočet IT útvaru
- [x] Z nákladů se kalkuluje cena služby, která je součástí SLA
- [ ] Náklady se do SLA nepromítají, ta obsahuje jen technické parametry
- [ ] SLA obsahuje přehled mezd pracovníků IT

> Nákladová analýza a alokace umožní spočítat cenu jednotky služby. Ta se uvádí v katalogu služeb a v SLA a spolu s úrovní služby určuje, kolik zákazník zaplatí.

## Organizace informatiky ve firmě {#organizace-it .explain}

**Útvar IT** se obvykle člení na části pro vývoj a správu aplikací, provoz infrastruktury, uživatelskou podporu (service desk), případně architekturu a bezpečnost. Jeho vedoucím je **CIO** (Chief Information Officer), který odpovídá za soulad IT se strategií firmy, IT strategii, rozpočet, portfolio projektů a řízení dodavatelů; čím výše je CIO postaven (např. přímo pod generálním ředitelem místo pod finančním ředitelem), tím strategičtější roli IT obvykle hraje. Útvar IT může být řízen jako **nákladové středisko** (sleduje se jen dodržení rozpočtu), **servisní středisko** (služby účtuje útvarům v interních cenách) nebo **ziskové středisko** (nabízí služby i navenek). Součástí struktur **IT governance** je **řídicí výbor IT** (IT steering committee) se zástupci vrcholového vedení, byznysových útvarů a CIO, který stanovuje priority, schvaluje IT projekty a rozpočet a sleduje jejich realizaci.

*Příklad:* Řídicí výbor IT čtvrtletně rozhoduje, které ze žádostí útvarů o nové aplikace se zařadí do portfolia projektů na příští rok.

### ? Kdo ve firmě typicky rozhoduje o prioritách IT projektů a schvaluje IT rozpočet za účasti zástupců byznysu?

- [ ] Service desk
- [ ] Externí dodavatel na základě UC
- [ ] Správce sítě
- [x] Řídicí výbor IT

> Řídicí výbor IT je orgán IT governance, v němž vedení a byznysové útvary spolu s CIO rozhodují o prioritách, projektech a rozpočtu informatiky.

### ? Útvar IT účtuje ostatním útvarům své služby v interních cenách, ale navenek služby neprodává. Jako jaké středisko je řízen?

- [ ] Nákladové středisko
- [x] Servisní středisko
- [ ] Ziskové středisko
- [ ] Investiční středisko

> Servisní středisko poskytuje služby uvnitř firmy a účtuje je v interních cenách. Nákladové středisko služby neúčtuje, ziskové je nabízí i externím zákazníkům.
