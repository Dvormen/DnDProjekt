# Dungeons and Dragons Manager pro Postavy a Kostky

Aplikace udělaná ve Windows Forms, která ukládá informace do databáze.

---

## Aplikace obsahuje:

- Účty s encrypcí hesel  
- Možnost přidávat, upravovat a odstraňovat postavy  
- Možnost prohlížet si postavy ostatních  
- Možnost přidávat kostky a házet kostkami  

---

## Jak to stáhnout?

**Potřebujete:**

- .NET 8.0 SDK  
- SQL databázi pro ukládání dat  
- NuGet balíček:  
  - `System.Data.SqlClient`  

---

## Stahování

1. Otevřete **Visual Studio**
2. Klikněte na **Clone repository**
3. Zadejte jako lokaci repozitáře:
   https://github.com/Dvormen/DnDProjekt.git
4. V **Solution Exploreru** najděte `App.config` a otevřete ho

V souboru `App.config` najdete následující řádky:

- `DataSource` – Vložte jméno vašeho serveru  
- `Database` – Vložte jméno vaší databáze  
- `Name` – Vložte váš login  
- `Password` – Vložte vaše heslo  

5. Otevřete `query.sql`
6. Spusťte soubory `Sqlko.sql` a `SQLdata.sql` ve vaší databázi

7. Nainstalujte NuGet balíček, pokud ho ještě nemáte

8. Spusťte aplikaci

Po spuštění se objeví login, ze kterého se uživatel může přihlásit do databáze.

---

## Dělání postav

Uživatel může v aplikaci vytvářet DnD postavy se staty a příběhem.  
Ostatní uživatelé si tyto postavy mohou prohlédnout.

---

## Dělání kostek

Uživatel si může vytvořit vlastní kostky a může k nim "připnout" stat postavy, kterou udělal – hází tak "za stat".

---

## Problémy?

Pokud nepoužijete MSSQL server, aplikace vám možná nepoběží.

---

## Kontakt

Pokud máte nějaké stížnosti, bugy nebo návrhy jaké rasy a classy přidat, dejte mi vědět na e-mail:

**luky.dvorak07@gmail.com**  
(předmět e-mailu: `DnDStížnost`)
