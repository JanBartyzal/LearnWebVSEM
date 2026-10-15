---
kind: topic
subject: aplikace-podnikove-informatiky
slug: elektronicka-vymena-dat-edi
name: "Elektronická výměna dat (EDI)"
order: 8
---

principy EDI, využití infrastruktury, VAN sítě, inhouse formát, požadavky na EDI komunikaci, standard UN/EDIFACT, EDI konvertory, internetu, ostatní standardy (EDIFACT, ODETTE…), možnosti a standardy ebXML. Architektura ebXML. Standardy AS1, AS2, AS3.

## Elektronická výměna dat (EDI) {#edi .term}

EDI (Electronic Data Interchange, elektronická výměna dat) je **strojová výměna strukturovaných obchodních dokumentů** (objednávek, dodacích listů, faktur…) **mezi informačními systémy obchodních partnerů** v dohodnutém standardním formátu, **bez lidského zásahu**. Doklad vzniklý v systému odesílatele se v systému příjemce zpracuje automaticky, bez přepisování. EDI tedy není e-mail s fakturou v PDF ani vyplňování webového formuláře.

### ? Která z uvedených situací představuje EDI v pravém smyslu?

- [ ] Dodavatel posílá faktury e-mailem jako přílohu ve formátu PDF
- [ ] Odběratel vyplňuje objednávku ve webovém formuláři
- [x] ERP odběratele pošle objednávku přímo do ERP dodavatele
- [ ] Účetní přepisuje přijaté faktury do účetního systému

> EDI je výměna strukturovaných zpráv přímo mezi systémy partnerů bez ručního zásahu. PDF v e-mailu ani webový formulář tuto podmínku nesplňují, protože data musí někdo číst nebo zadávat.

### ? Co je podmínkou, aby systém příjemce mohl přijatou EDI zprávu zpracovat automaticky?

- [x] Zpráva má strukturu podle dohodnutého standardu
- [ ] Zprávu před zpracováním zkontroluje referent
- [ ] Každá položka zprávy je zvlášť elektronicky podepsaná
- [ ] Zpráva je odeslána výhradně jako e-mail

> Automatické zpracování je možné jen tehdy, když obě strany znají strukturu zprávy — proto se používají standardy jako UN/EDIFACT. Ruční kontrola by princip EDI popírala.

## Průběh výměny dokladu přes EDI {#edi-prubeh .explain}

Typická výměna probíhá v těchto krocích:

1. **Aplikace odesílatele** (např. ERP) vytvoří doklad a vyexportuje ho ve svém **inhouse formátu**.
2. **EDI konvertor** ho převede (namapuje) do standardní zprávy (např. UN/EDIFACT ORDERS) a zabalí do obálky s identifikací odesílatele a příjemce.
3. **Komunikační vrstva** zprávu přenese — přes síť VAN, přímé spojení nebo internet (např. AS2).
4. **Konvertor příjemce** zprávu zkontroluje a převede do inhouse formátu jeho systému.
5. **Aplikace příjemce** doklad automaticky zpracuje; příjemce odešle potvrzení.

*Příklad:* Obchodní řetězec odešle ze svého ERP objednávku. Za několik minut ji má dodavatel založenou jako zakázku ve svém ERP, aniž by ji kdokoli přepisoval, a stejnou cestou pak posílá avízo o odeslání a fakturu.

### ? Jaká je správná posloupnost kroků při odeslání objednávky přes EDI?

- [ ] Konverze → export z ERP → přenos → import do ERP
- [ ] Přenos → export z ERP → konverze → import do ERP
- [ ] Export z ERP → import do ERP → konverze → přenos
- [x] Export z ERP → konverze → přenos → konverze → import

> Doklad se nejprve vyexportuje z aplikace odesílatele, konvertor jej převede do standardní zprávy, ta se přenese a u příjemce se převede zpět do jeho formátu a importuje.

### ? Proč odesílatel neposílá partnerovi data přímo ve vnitřním formátu svého ERP?

- [ ] Vnitřní formáty je zakázáno přenášet mimo firmu
- [x] Systém partnera má jinou vnitřní strukturu dat
- [ ] Data z ERP nelze přenášet přes internet
- [ ] ERP neumí data do souboru vůbec exportovat

> Každý systém má vlastní datovou strukturu, a proto se data převádějí do společného standardu, kterému rozumějí obě strany. Bez standardu by bylo nutné přizpůsobovat se každému partnerovi zvlášť.

## Přínosy a bariéry EDI {#edi-prinosy .explain}

**Přínosy:** rychlost (minuty místo dnů), odstranění chyb z ručního přepisu, nižší náklady na zpracování dokladu (papír, poštovné, práce), zkrácení cyklu objednávka–dodávka–platba, přesnější plánování zásob (podpora JIT či VMI) a těsnější vazba na partnery.

**Bariéry:** vstupní náklady (konvertor, mapování, komunikační kanál, případně poplatky VAN), nutnost dohody na standardu a pravidlech s každým partnerem, složitost standardů. EDI se proto vyplácí hlavně při **velkém objemu pravidelných transakcí**. Často ho iniciuje silný partner (obchodní řetězec, automobilka) a vyžaduje jej po svých dodavatelích.

*Příklad:* Automobilka posílá dodavatelům dílů odvolávky přes EDI a bez EDI napojení s dodavatelem vůbec neuzavře smlouvu — dodávky „just in time" by jinak nebylo možné řídit.

### ? Co NENÍ typickým přínosem EDI?

- [x] Nulové vstupní náklady na straně partnera
- [ ] Odstranění chyb z ručního přepisu dokladů
- [ ] Zkrácení cyklu od objednávky po platbu
- [ ] Nižší náklady na zpracování jednoho dokladu

> EDI vyžaduje vstupní investice — konvertor, mapování zpráv a komunikační kanál. Ostatní možnosti jsou typické přínosy automatizované výměny dokladů.

### ? Pro kterou firmu se plná EDI integrace s odběrateli vyplatí nejvíce?

- [ ] Pro řemeslníka s několika fakturami ročně
- [ ] Pro firmu s nepravidelnými jednorázovými zakázkami
- [x] Pro výrobce s denními objednávkami od řetězců
- [ ] Pro začínající e-shop prodávající jen spotřebitelům

> Vstupní náklady EDI se vracejí při velkém objemu pravidelných transakcí s obchodními partnery. Při malém objemu stačí jednodušší řešení, například webový portál.

## Komunikační infrastruktura EDI {#edi-infrastruktura .compare}

EDI zprávy lze přenášet různými cestami; volba ovlivňuje náklady i služby, které firma dostane.

| | Přímé spojení (vlastní linka) | Síť VAN | Internet (AS1/AS2/AS3, OFTP2, SFTP…) |
|---|---|---|---|
| Princip | partneři se propojí napřímo, každý pár zvlášť | zprávy jdou přes síť poskytovatele s poštovními schránkami | přenos veřejnou sítí se šifrováním a podpisy |
| Přidané služby | žádné, vše řeší partneři sami | konverze, archivace, sledování, propojení s jinými VAN | jen to, co si partneři zajistí sami |
| Náklady | rostou s počtem partnerů | průběžné poplatky, obvykle podle objemu dat | nízké provozní, vstupní investice do software a certifikátů |
| Vhodné pro | několik partnerů s velkým objemem | mnoho partnerů, firmy bez vlastních EDI odborníků | partnery s vlastním technickým zázemím |

### ? Firma obchoduje přes EDI se stovkami partnerů, nemá vlastní EDI odborníky a chce, aby jí někdo zajišťoval doručování, archivaci i převod formátů. Jaké řešení zvolí?

- [ ] Samostatné pevné linky ke každému partnerovi
- [ ] Přenos zpráv pomocí AS2 bez dalších služeb
- [ ] Zasílání souborů na přenosném médiu
- [x] Služby poskytovatele sítě VAN

> Síť VAN poskytuje jediné připojení ke všem partnerům a k tomu přidané služby jako konverzi, archivaci a sledování zpráv. Přímé spojení ani samotné AS2 tyto služby nenabízejí.

### ? Jaká je hlavní nevýhoda přímého spojení s každým partnerem zvlášť?

- [ ] Nelze přes ně přenášet standardní zprávy
- [x] Náklady a správa rostou s počtem partnerů
- [ ] Platí se za ně poplatky podle objemu dat
- [ ] Partneři musí sdílet jeden společný konvertor

> Při přímém propojení je nutné zřídit a spravovat spojení s každým partnerem zvlášť, což se při mnoha partnerech prodražuje. Poplatky podle objemu jsou typické pro VAN.

## Síť VAN {#van .term}

VAN (Value Added Network, síť s přidanou hodnotou) je **komunikační síť externího poskytovatele**, která zprostředkuje výměnu EDI zpráv mezi partnery. Pracuje na principu **elektronických poštovních schránek** (store-and-forward): odesílatel zprávu předá síti, ta ji uloží do schránky příjemce a příjemce si ji vyzvedne, kdy je připraven. Přidanou hodnotu tvoří služby jako **konverze formátů a protokolů**, **archivace** zpráv, **sledování a protokolování** doručení, notifikace, zabezpečení a **propojení s jinými sítěmi VAN**. Firma potřebuje jediné připojení místo spojení s každým partnerem, platí však průběžné poplatky.

### ? Co znamená, že síť VAN pracuje na principu poštovních schránek?

- [x] Zpráva čeká v síti, dokud si ji příjemce nevyzvedne
- [ ] Zprávy se posílají jako běžné e-maily s přílohou
- [ ] Příjemce musí být online v okamžiku odeslání
- [ ] Každá zpráva se doručuje i v papírové podobě

> Princip store-and-forward znamená, že síť zprávu uloží do schránky příjemce a ten si ji vyzvedne, až je připraven. Odesílatel ani příjemce tak nemusí být spojeni současně.

### ? Která služba NEPATŘÍ k typickým službám sítě VAN?

- [ ] Archivace přenesených zpráv
- [ ] Konverze formátů zpráv
- [x] Zaúčtování přijatých faktur
- [ ] Propojení s jinými sítěmi VAN

> VAN zajišťuje přenos zpráv a služby kolem něj — schránky, konverzi, archivaci a propojení sítí. Zaúčtování faktury je úloha ERP příjemce.

## Inhouse formát {#inhouse-format .term}

Inhouse formát (vnitřní, interní formát) je **datový formát, v němž informační systém firmy doklady exportuje a importuje** — například textový soubor s pevnou strukturou, CSV, XML nebo formát IDoc v systému SAP. Je specifický pro daný systém a odpovídá jeho datové struktuře. Mezi inhouse formátem a standardní EDI zprávou překládá **EDI konvertor**, díky čemuž aplikace nemusí standardy EDI vůbec znát.

### ? Systém SAP předává objednávku EDI konvertoru ve formátu IDoc. Jak se takový formát z pohledu EDI označuje?

- [ ] Standardní zpráva UN/EDIFACT
- [x] Inhouse (vnitřní) formát
- [ ] Profil spolupráce (CPP)
- [ ] Obálka výměny (interchange)

> Formát, v němž aplikace firmy data exportuje a importuje, je inhouse formát. Do standardní zprávy jej převádí až EDI konvertor.

### ? Jaký je přínos toho, že ERP pracuje jen s inhouse formátem a převod do standardu zajišťuje konvertor?

- [ ] ERP pak nemusí doklady vůbec exportovat
- [ ] Odpadá nutnost dohody s partnery o standardu
- [ ] Partner může data přímo zapisovat do ERP
- [x] ERP nemusí znát jednotlivé standardy EDI

> Oddělení inhouse formátu od standardu znamená, že změny standardů, verzí a požadavků partnerů se řeší v konvertoru a ERP zůstává beze změny.

## EDI konvertor {#edi-konvertor .explain}

EDI konvertor (překladač, translator) je software, který **převádí data mezi inhouse formátem a standardní EDI zprávou** v obou směrech. Jeho jádrem je **mapování** — předpis, které pole inhouse formátu odpovídá kterému segmentu a datovému prvku zprávy, včetně převodu kódů (např. interní číslo zboží → kód GTIN). Konvertor dále **kontroluje syntaxi** přijatých zpráv, vytváří a rozbaluje **obálky** s identifikací partnerů, vede **profily partnerů** (jaký standard a verzi kdo používá) a generuje potvrzení. Mapování se připraví jednou pro typ zprávy a partnera a pak běží automaticky. Konvertor může firma provozovat sama, nebo ho využívá jako službu poskytovatele VAN či EDI cloudu.

*Příklad:* Dodavatel získá nového odběratele, který posílá objednávky v jiné verzi standardu. Upraví jen mapování v konvertoru, ERP zůstane beze změny.

### ? Co se u EDI konvertoru rozumí mapováním?

- [x] Předpis, jak si odpovídají pole inhouse formátu a zprávy
- [ ] Grafické zobrazení sítě všech obchodních partnerů
- [ ] Přidělení adres poštovních schránek v síti VAN
- [ ] Rozvržení odesílaných zpráv do jednotlivých dnů

> Mapování určuje, jak se údaje z vnitřního formátu převádějí do segmentů a datových prvků standardní zprávy a zpět. Je to klíčová část nastavení EDI s každým partnerem.

### ? Dodavatel získá odběratele, který posílá objednávky v jiné verzi standardu než ostatní odběratelé. Co musí dodavatel ve svém EDI řešení upravit?

- [ ] Datovou strukturu svého ERP systému
- [ ] Komunikační kanály všech stávajících partnerů
- [x] Mapování v konvertoru pro tohoto partnera
- [ ] Inhouse formát pro všechny ostatní partnery

> Rozdíly ve standardech a verzích mezi partnery řeší konvertor pomocí mapování. ERP ani nastavení ostatních partnerů se měnit nemusí.

## Požadavky na EDI komunikaci {#pozadavky-edi .explain}

Aby si partneři mohli zprávy vyměňovat automaticky, musí se shodnout na:

- **standardu zpráv** — syntaxe, typy zpráv a jejich verze (např. UN/EDIFACT, EANCOM) a způsob identifikace partnerů a zboží (např. GLN, GTIN);
- **komunikačním kanálu a protokolu** — VAN, AS2, OFTP2, SFTP…;
- **dohodě o výměně dat** (interchange agreement) — smluvní rámec: které zprávy se vyměňují, kdy se zpráva považuje za doručenou, závaznost elektronických dokladů, odpovědnost za chyby, archivace, postup při výpadku;
- **bezpečnosti a potvrzování** — důvěrnost, integrita a autenticita zpráv (šifrování, elektronický podpis) a potvrzení přijetí.

Shoda na stejném informačním systému potřeba není — právě to umožňuje standard.

*Příklad:* Než dodavatel začne posílat řetězci faktury přes EDI, podepíší dohodu o výměně dat, nastaví AS2 spojení, otestují zprávy INVOIC na testovacím prostředí a teprve pak přejdou do ostrého provozu.

### ? Kde partneři smluvně upraví, kdy se EDI zpráva považuje za doručenou a jak se archivuje?

- [ ] V profilu partnera v konvertoru
- [x] V dohodě o výměně dat
- [ ] V adresáři zpráv UN/EDIFACT
- [ ] V obálce každé výměny zpráv

> Dohoda o výměně dat (interchange agreement) je smluvní rámec EDI — určuje vyměňované zprávy, okamžik doručení, závaznost dokladů, odpovědnost i archivaci.

### ? Co NENÍ nutné, aby si dva partneři mohli začít vyměňovat EDI zprávy?

- [ ] Shoda na standardu a verzi zpráv
- [ ] Shoda na komunikačním kanálu
- [ ] Dohoda o potvrzování přijetí zpráv
- [x] Používání stejného systému ERP

> Standard zpráv a konvertory umožňují komunikaci mezi libovolnými systémy, takže partneři nepotřebují stejný ERP. Musí se ale shodnout na standardu, kanálu a pravidlech výměny.

## Potvrzování a bezpečnost EDI zpráv {#potvrzovani .explain}

Potvrzení se v EDI rozlišují podle úrovně:

- **potvrzení přenosu** — např. **MDN** (Message Disposition Notification) u AS1, AS2 a AS3: stvrzenka (na vyžádání odesílatele elektronicky podepsaná), že zpráva dorazila neporušená;
- **syntaktické (funkční) potvrzení** — konvertor příjemce ověří, že zpráva odpovídá standardu: v UN/EDIFACT zpráva **CONTRL**, v ANSI X12 transakce **997**;
- **obchodní odpověď** — reakce na obsah, např. potvrzení objednávky zprávou ORDRSP.

Bezpečnost zajišťuje **šifrování** (důvěrnost) a **elektronický podpis** (autenticita odesílatele a integrita zprávy). Podepsané potvrzení přijetí zajišťuje **nepopiratelnost** — odesílatel může prokázat, že příjemce zprávu dostal.

*Příklad:* Odběratel tvrdí, že fakturu nikdy nedostal. Dodavatel předloží podepsané MDN s datem a časem přijetí a spor je vyřešen.

### ? Dodavatel obdržel k odeslané faktuře INVOIC zprávu CONTRL. Co mu tím odběratel potvrdil?

- [ ] Že fakturu schválil k proplacení
- [ ] Že fakturu už uhradil na účet dodavatele
- [x] Že faktura prošla syntaktickou kontrolou
- [ ] Že fyzicky převzal zboží uvedené na faktuře

> CONTRL je v UN/EDIFACT syntaktické potvrzení — zpráva byla přijata a odpovídá standardu. O schválení či úhradě faktury nic neříká.

### ? Jaký význam má podepsané potvrzení přijetí (MDN) při přenosu přes AS2?

- [x] Prokazuje, že příjemce zprávu skutečně dostal
- [ ] Příjemce tím schvaluje obchodní obsah zprávy
- [ ] Zpráva se tím automaticky převede do UN/EDIFACT
- [ ] Zpráva se tím uloží do archivu sítě VAN

> MDN potvrzuje doručení neporušené zprávy a díky podpisu zajišťuje nepopiratelnost přijetí. Obsah zprávy tím příjemce neschvaluje.

## Standard UN/EDIFACT {#edifact .term}

UN/EDIFACT (United Nations Electronic Data Interchange for Administration, Commerce and Transport) je **mezinárodní standard EDI** spravovaný orgánem OSN **UN/CEFACT**. Tvoří ho **syntaktická pravidla** (norma **ISO 9735**) a **adresáře** standardních zpráv, segmentů, datových prvků a kódů, vydávané v pravidelných verzích (např. D.96A, D.01B). Je **oborově nezávislý** (obchod, doprava, celnictví, veřejná správa) a rozšířený zejména v Evropě; pro jednotlivá odvětví z něj vznikají zúžené podmnožiny (**subsety**), např. EANCOM.

### ? Která organizace spravuje standard UN/EDIFACT?

- [ ] GS1
- [x] UN/CEFACT
- [ ] ASC X12
- [ ] ODETTE

> UN/EDIFACT spravuje UN/CEFACT, orgán OSN pro usnadnění obchodu a elektronické podnikání. GS1 spravuje subset EANCOM, ASC X12 americký standard X12.

### ? Co platí o standardu UN/EDIFACT?

- [ ] Je určen výhradně pro automobilový průmysl
- [ ] Je americkým národním standardem pro EDI
- [ ] Je postaven na jazyce XML a webových službách
- [x] Je mezinárodním, oborově nezávislým standardem

> UN/EDIFACT je mezinárodní standard OSN použitelný v různých odvětvích. Americkým standardem je ANSI X12, automotive používá ODETTE, na XML staví ebXML.

## Struktura zprávy UN/EDIFACT {#edifact-struktura .explain}

Data v UN/EDIFACT mají hierarchickou strukturu:

- **Výměna (interchange)** — obálka **UNB…UNZ** s identifikací odesílatele a příjemce, datem a referenčním číslem; může obsahovat více zpráv (volitelně seskupených do funkčních skupin UNG…UNE).
- **Zpráva (message)** — **UNH…UNT**, jeden obchodní doklad, např. objednávka.
- **Segment** — skupina souvisejících údajů označená třípísmennou značkou, např. BGM (začátek zprávy), DTM (datum), NAD (jméno a adresa), LIN (položka), QTY (množství).
- **Datový prvek** — nejmenší jednotka údaje; jednoduchý, nebo složený z komponent.

Oddělovače: apostrof `'` ukončuje segment, `+` odděluje datové prvky, `:` komponenty složeného prvku, `?` je uvolňovací znak.

*Příklad:* Segment `QTY+21:48'` vyjadřuje množství — kvalifikátor 21 (objednané množství) a hodnotu 48 kusů.

### ? Jaké je správné pořadí úrovní struktury UN/EDIFACT od nejvyšší po nejnižší?

- [x] Výměna → zpráva → segment → datový prvek
- [ ] Zpráva → výměna → datový prvek → segment
- [ ] Segment → zpráva → výměna → datový prvek
- [ ] Výměna → segment → zpráva → datový prvek

> Výměna (UNB…UNZ) obsahuje zprávy (UNH…UNT), zpráva se skládá ze segmentů a segment z datových prvků.

### ? Co v UN/EDIFACT představuje jedna zpráva ohraničená segmenty UNH a UNT?

- [ ] Celou dávku dat zaslanou jednomu partnerovi
- [ ] Jeden údaj, například datum nebo množství
- [x] Jeden obchodní doklad, například objednávku
- [ ] Jednu položku objednávky včetně její ceny

> Zpráva odpovídá jednomu obchodnímu dokladu. Dávku pro partnera tvoří výměna (interchange), jednotlivé údaje jsou datové prvky a položka se zapisuje skupinou segmentů.

### ? Zpráva UN/EDIFACT obsahuje řetězec `NAD+BY+5412345000013::9'`. Kterou úroveň struktury tento řetězec představuje?

- [ ] Výměnu (interchange)
- [x] Segment
- [ ] Zprávu (message)
- [ ] Funkční skupinu

> Řetězec začíná třípísmennou značkou NAD (jméno a adresa) a končí apostrofem, jde tedy o segment. Jeho části oddělené znakem + jsou datové prvky.

## Typy zpráv UN/EDIFACT {#edifact-zpravy .explain}

Každý typ zprávy má šestipísmenný kód. V dodavatelském řetězci se typicky používají:

- **PRICAT** — ceník / katalog zboží,
- **ORDERS** — objednávka,
- **ORDRSP** — odpověď na objednávku (potvrzení, změny),
- **DESADV** — avízo o odeslání (elektronický dodací list),
- **RECADV** — avízo o příjmu zboží,
- **INVOIC** — faktura,
- **REMADV** — avízo o platbě.

*Příklad:* Řetězec pošle ORDERS, dodavatel potvrdí ORDRSP, při expedici pošle DESADV, takže sklad řetězce může příjem zboží připravit předem, a nakonec vystaví INVOIC.

### ? Dodavatel chce odběrateli ještě před příjezdem kamionu elektronicky oznámit, co a v jakém balení odeslal. Kterou zprávu UN/EDIFACT použije?

- [ ] ORDERS
- [ ] INVOIC
- [ ] ORDRSP
- [x] DESADV

> DESADV (despatch advice) je avízo o odeslání, které příjemci umožní připravit příjem zboží. ORDERS je objednávka, ORDRSP odpověď na ni a INVOIC faktura.

### ? Která zpráva UN/EDIFACT slouží jako elektronická faktura?

- [x] INVOIC
- [ ] REMADV
- [ ] PRICAT
- [ ] RECADV

> Faktura se posílá zprávou INVOIC. REMADV je avízo o platbě, PRICAT ceník a RECADV avízo o příjmu zboží.

## Další standardy EDI {#dalsi-standardy .compare}

Vedle obecného UN/EDIFACT existují národní a oborové standardy.

| Standard | Správce / původ | Kde se používá | Poznámka |
|---|---|---|---|
| UN/EDIFACT | OSN (UN/CEFACT) | mezinárodně, různá odvětví | obecný základ, z něhož vycházejí subsety |
| ANSI X12 | ASC X12 (USA) | Severní Amerika | transakce označené čísly, např. 850 objednávka, 810 faktura, 856 avízo dodávky |
| GS1 EANCOM | GS1 | maloobchod a spotřební zboží | subset UN/EDIFACT; identifikace míst a subjektů kódem GLN, zboží kódem GTIN |
| ODETTE | evropská organizace automobilového průmyslu | výrobci automobilů a dodavatelé dílů | oborové zprávy (později založené na UN/EDIFACT) a přenosový protokol OFTP / OFTP2 |

### ? Český dodavatel dílů pro evropskou automobilku má zavést EDI podle oborových zvyklostí. Se kterým standardem se nejspíše setká?

- [ ] ANSI X12
- [ ] GS1 EANCOM
- [x] ODETTE
- [ ] HL7

> ODETTE sdružuje evropský automobilový průmysl a definuje oborové zprávy i přenosový protokol OFTP. EANCOM je určen pro maloobchod, ANSI X12 pro Severní Ameriku a HL7 pro zdravotnictví.

### ? Výrobce potravin dodává do supermarketů a odběratel požaduje identifikaci zboží kódy GTIN a míst kódy GLN. Který standard EDI se v tomto prostředí typicky používá?

- [ ] ODETTE
- [x] GS1 EANCOM
- [ ] ANSI X12
- [ ] OFTP2

> EANCOM je subset UN/EDIFACT spravovaný organizací GS1 pro maloobchod a pracuje s identifikátory GTIN a GLN. OFTP2 není standard zpráv, ale přenosový protokol.

### ? Americký odběratel posílá objednávky jako transakci 850. Ve kterém standardu jsou zapsány?

- [ ] GS1 EANCOM
- [ ] ODETTE
- [ ] UN/EDIFACT
- [x] ANSI X12

> ANSI X12 označuje transakce čísly — 850 je objednávka, 810 faktura. UN/EDIFACT a jeho subset EANCOM používají šestipísmenné kódy zpráv (ORDERS, INVOIC).

## EDI přes internet {#edi-internet .explain}

Klasické EDI přes VAN nebo pevné linky bylo pro menší firmy drahé. Internet nabízí levnou a všudypřítomnou infrastrukturu, protože je ale veřejný, je nutné doplnit **šifrování, elektronické podpisy a potvrzení přijetí**. Používají se:

- standardizované protokoly **AS1, AS2, AS3** (IETF) a navazující AS4 (OASIS),
- **OFTP2** v automobilovém průmyslu,
- zabezpečený přenos souborů (SFTP, FTPS),
- **web EDI** pro malé partnery,
- formáty zpráv založené na **XML** (např. ebXML).

Obsah zpráv přitom může zůstat stejný (UN/EDIFACT, X12) — mění se jen přenosová cesta. Poskytovatelé VAN dnes rovněž nabízejí připojení přes internet.

*Příklad:* Distributor přejde z VAN na AS2 s hlavními odběrateli. Zprávy ORDERS a INVOIC posílá ve stejném formátu jako dřív, odpadnou mu ale poplatky za objem přenesených dat.

### ? Firma přechází při výměně s hlavními partnery ze sítě VAN na přenos přes AS2. Co se tím typicky změní?

- [x] Přenosová cesta; obsah zpráv může zůstat stejný
- [ ] Standard zpráv; je nutné opustit UN/EDIFACT
- [ ] Inhouse formát; je nutné upravit datovou strukturu ERP
- [ ] Nic, protože AS2 je jen jiný název pro síť VAN

> AS2 je přenosový protokol, nikoli formát zpráv, takže zprávy UN/EDIFACT nebo X12 lze posílat beze změny. Mění se způsob, jak se zprávy k partnerovi dostanou.

### ? Proč EDI přes internet vyžaduje šifrování a elektronické podpisy?

- [ ] Bez nich nelze zprávy převést do UN/EDIFACT
- [ ] Vyžaduje je adresář zpráv UN/EDIFACT
- [x] Zprávy putují veřejnou, nezabezpečenou sítí
- [ ] Internet nedokáže přenášet textové soubory

> Internet je veřejná síť, proto je nutné zajistit důvěrnost (šifrování), autenticitu a integritu (podpis) a doložit přijetí zprávy. Formát zprávy s tím nesouvisí.

## Standardy AS1, AS2, AS3 {#as1-as2-as3 .compare}

Standardy AS (Applicability Statement) vznikly v pracovní skupině EDIINT organizace IETF a určují, jak **bezpečně přenášet EDI** (ale i XML či jiná data) **přes internet**. Formát zpráv nedefinují. Všechny používají **S/MIME** (šifrování a elektronický podpis) a potvrzení přijetí **MDN**.

| | AS1 | AS2 | AS3 |
|---|---|---|---|
| Přenosový protokol | e-mail (SMTP) | HTTP / HTTPS | FTP |
| Způsob komunikace | asynchronní přes poštovní servery | přímé spojení partnerů; MDN ve stejném spojení (synchronně) nebo později (asynchronně) | model klient–server, soubory se ukládají na FTP server |
| Požadavek na infrastrukturu | poštovní server | trvale dostupný HTTP(S) server u příjemce | FTP server |
| Rozšíření | historicky první | velmi rozšířený, vyžadují ho mnohé obchodní řetězce | méně častý |

Na AS2 navazuje **AS4** — už ne standard IETF, ale profil organizace OASIS (ebMS 3.0), který přenáší zprávy pomocí webových služeb.

### ? Který protokol používá pro přenos EDI zpráv standard AS2?

- [ ] SMTP
- [x] HTTP/HTTPS
- [ ] FTP
- [ ] OFTP2

> AS2 přenáší zprávy protokolem HTTP nebo HTTPS. AS1 používá e-mail (SMTP), AS3 protokol FTP a OFTP2 je samostatný protokol automobilového průmyslu.

### ? Odběratel požaduje, aby EDI zprávy chodily jako zabezpečené e-maily s podepsaným potvrzením přijetí. Kterému standardu to odpovídá?

- [ ] AS2
- [ ] AS3
- [ ] OFTP2
- [x] AS1

> AS1 přenáší EDI zprávy elektronickou poštou (SMTP) se šifrováním, podpisem a potvrzením MDN. AS2 používá HTTP(S), AS3 FTP.

### ? Co mají standardy AS1, AS2 a AS3 společné?

- [ ] Všechny používají stejný přenosový protokol
- [ ] Všechny vyžadují připojení k síti VAN
- [x] Šifrování, podpis a potvrzení přijetí MDN
- [ ] Všechny definují vlastní formát obchodních zpráv

> Všechny tři standardy zabezpečují přenos pomocí S/MIME a potvrzují přijetí zprávou MDN; liší se přenosovým protokolem (SMTP, HTTP, FTP). Formát obchodních zpráv neurčují.

## Web EDI {#web-edi .explain}

Web EDI umožňuje zapojit do EDI **malé partnery bez vlastního konvertoru a integrace**. Partner se přes webový prohlížeč přihlásí na portál (provozuje ho velký partner nebo poskytovatel EDI služeb), přijaté zprávy vidí jako přehledné formuláře a odpovědi (potvrzení objednávky, dodací list, fakturu) vyplňuje ve formulářích. Portál je převede do standardních zpráv a odešle do systému velkého partnera.

**Výhody:** nízké vstupní náklady, rychlé zapojení všech dodavatelů, velký partner dostává data elektronicky. **Nevýhody:** malý partner data zadává ručně a nemá je propojená se svým systémem — výhody automatizace má hlavně velký partner.

*Příklad:* Malá pekárna dodává do obchodního řetězce. Objednávky vidí na webovém portálu, fakturu tam vyplní a řetězec ji obdrží jako zprávu INVOIC přímo do svého ERP.

### ? Malý dodavatel vyplňuje faktury ve webovém formuláři, odkud je portál posílá jako zprávy INVOIC do ERP obchodního řetězce. Na čí straně probíhá zpracování bez ručního zásahu?

- [x] Jen na straně obchodního řetězce
- [ ] Jen na straně malého dodavatele
- [ ] Na straně obou partnerů stejně
- [ ] Na straně žádného z partnerů

> Řetězec přijímá standardní zprávy přímo do ERP, zatímco dodavatel údaje do formuláře zadává ručně. Web EDI tak automatizuje hlavně stranu velkého partnera.

### ? Co je hlavní výhodou web EDI pro malého dodavatele?

- [ ] Plná integrace s jeho účetním systémem
- [x] Nepotřebuje vlastní konvertor ani integraci
- [ ] Odpadá mu veškeré ruční zadávání dat
- [ ] Může si zvolit vlastní formát dokladů

> K web EDI stačí webový prohlížeč, takže malý dodavatel nemusí investovat do konvertoru a mapování. Data však zadává ručně a nemá je propojená se svým systémem.

## ebXML {#ebxml .term}

ebXML (Electronic Business using eXtensible Markup Language) je soubor **otevřených specifikací pro elektronické podnikání založených na XML**, které společně vytvořily **UN/CEFACT a OASIS**. Cílem je umožnit **globální, bezpečnou a interoperabilní výměnu obchodních informací** mezi libovolnými partnery a zpřístupnit elektronickou výměnu dat i **malým a středním firmám**, pro které bylo klasické EDI příliš drahé a složité. Spojuje zkušenosti EDI s obchodní sémantikou a internetové technologie; část specifikací byla převzata i do norem řady ISO 15000.

### ? Jaký byl hlavní cíl iniciativy ebXML?

- [ ] Nahradit internet uzavřenými sítěmi VAN
- [ ] Vytvořit jednotný ERP systém pro všechny firmy
- [ ] Standardizovat platby kartou v e-shopech
- [x] Otevřená výměna obchodních dat na bázi XML

> ebXML má umožnit otevřenou, bezpečnou a interoperabilní výměnu obchodních dat na bázi XML a internetu, a to i malým a středním firmám.

### ? Které organizace stojí za vznikem ebXML?

- [ ] GS1 a ODETTE
- [ ] IETF a ASC X12
- [x] UN/CEFACT a OASIS
- [ ] W3C a ISO

> ebXML vzniklo jako společná iniciativa UN/CEFACT (správce UN/EDIFACT) a konsorcia OASIS. IETF stojí za standardy AS1–AS3, GS1 za EANCOM.

## Architektura ebXML {#ebxml-architektura .explain}

Architektura ebXML se skládá z několika provázaných částí:

- **Obchodní procesy** (Business Process Specification Schema, BPSS) — strojově čitelný popis spolupráce partnerů: jaké obchodní transakce a v jakém pořadí probíhají.
- **Základní komponenty** (Core Components) — znovupoužitelné, na syntaxi nezávislé stavební bloky obchodních dat (např. adresa, částka, datum).
- **Registr a repozitář** (Registry/Repository) — sdílené úložiště, kde firmy zveřejňují a vyhledávají procesy, schémata zpráv, komponenty a profily partnerů.
- **CPP** (Collaboration Protocol Profile) — profil jedné firmy: které procesy a role podporuje a jaké má technické možnosti (protokoly, zabezpečení).
- **CPA** (Collaboration Protocol Agreement) — dohoda dvou partnerů odvozená z jejich CPP: přesné technické podmínky výměny.
- **Služba zasílání zpráv** (ebXML Messaging Service, ebMS) — spolehlivý a zabezpečený přenos zpráv nezávislý na jejich obsahu, postavený na protokolu SOAP.

*Příklad:* Firma A zveřejní v registru svůj profil CPP. Firma B ji v registru najde, porovná profil se svým CPP, partneři uzavřou CPA a zahájí výměnu zpráv přes ebMS.

### ? Dva partneři porovnají své profily a vytvoří technickou dohodu o tom, jakými protokoly a s jakým zabezpečením si budou vyměňovat zprávy. Jak se tento dokument v ebXML nazývá?

- [ ] CPP
- [x] CPA
- [ ] BPSS
- [ ] ebMS

> CPA (Collaboration Protocol Agreement) je dohoda dvou partnerů vzniklá z jejich profilů CPP. CPP je profil jedné firmy, BPSS popisuje obchodní procesy a ebMS přenáší zprávy.

### ? Která část architektury ebXML slouží firmám k vyhledání potenciálních partnerů a jejich profilů?

- [x] Registr a repozitář
- [ ] Služba zasílání zpráv
- [ ] Základní komponenty
- [ ] Dohoda o spolupráci

> Registr a repozitář je sdílené úložiště, kde firmy zveřejňují své profily CPP, procesy a schémata a kde je ostatní vyhledávají.

### ? Která část architektury ebXML zajišťuje spolehlivý a zabezpečený přenos zpráv mezi partnery?

- [ ] Registr a repozitář
- [ ] Základní komponenty
- [ ] Popis obchodních procesů
- [x] Služba zasílání zpráv (ebMS)

> ebXML Messaging Service přenáší zprávy spolehlivě a zabezpečeně bez ohledu na jejich obsah. Registr slouží k vyhledávání, Core Components a BPSS popisují data a procesy.
