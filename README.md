# Dungeons and Dragons Manager pro Postavy a Kostky

Aplikace vytvořená ve Windows Forms, která ukládá informace do SQL databáze.

---

## Funkce aplikace

- Účty s encrypcí hesel  
- Možnost přidávat, upravovat a odstraňovat postavy  
- Možnost prohlížet si postavy ostatních uživatelů  
- Možnost přidávat vlastní kostky a házet s nimi (včetně vazby na staty postav)

---

## Požadavky

- [.NET 8.0 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)
- SQL databáze (doporučeno MSSQL Server)
- NuGet balíček:  
  - `System.Data.SqlClient`

---

## Instalace

1. Otevřete **Visual Studio**
2. Klikněte na **Clone repository**
3. Zadejte jako lokaci repozitáře:  
   `https://github.com/Dvormen/DnDProjekt.git`
4. V **Solution Exploreru** najděte a otevřete `App.config`
5. Upravte následující hodnoty podle vaší databáze:
   - `DataSource` – jméno vašeho SQL serveru  
   - `Database` – název databáze  
   - `Name` – vaše přihlašovací jméno  
   - `Password` – vaše heslo  
6. Otevřete a spusťte soubory `Sqlko.sql` a `SQLdata.sql` ve vaší databázi
7. Nainstalujte potřebný NuGet balíček (`System.Data.SqlClient`)
8. Spusťte aplikaci

Po spuštění se zobrazí login obrazovka, kde se můžete přihlásit do databáze.

---

## Vytváření postav

Uživatel může vytvářet DnD postavy, zadávat jejich statistiky a přidávat k nim příběh.  
Tyto postavy si pak mohou prohlížet ostatní uživatelé.

---

## Práce s kostkami

Uživatel si může vytvořit vlastní kostky a připnout je ke konkrétním statům postavy – při hodu se použije příslušná hodnota.

---

## Testování

Projekt byl otestován mojí sestrou, spolužákem a mým bývalým spolužákem, ještě jim takto chci poděkovat

---

## Známé problémy

- Pokud nepoužijete MSSQL server, aplikace nemusí fungovat správně.

---

## Kontakt

Pokud máte jakékoli stížnosti, bugy nebo návrhy (např. na nové rasy nebo classy), napište mi na:

**luky.dvorak07@gmail.com**  
(předmět e-mailu: `DnDStížnost`)
