Dungeons and Dragons Manager pro Postavy a kostky
  Aplikace udělaná ve windows Forms která ukládá informace do databáze

Aplikace obsahuje:
  Učty s encrypcí hesel
  Možnost přidávat, upravovat a odstraňovat postavy
  Možnost prohlížet si postavy ostatních
  Možnost přidávat kostky a házek kostkama 

Jak to stáhnout?
  Potřebujete:
  .NET 8.0 SDK
  SQL databázi pro ukládání dat
  NuGet package:
  System.Data.SqlClient

Stahování
  Otevřete visual studio
  Klikněte na clone repository
  Zadejte https://github.com/Dvormen/DnDProjekt.git jako lokaci repozitáře
  V Solution Exploreru najděte App.config a otevřete ho
Tam najdete
  DataSource - Vložte jméno vašeho serveru
  Database - Vložte jméno vaší databáze
  Name - Vložte váš login
  Password - Vložte vaše heslo
  Open query.sql
Spusťte soubor Sqlko.sql a SQLdata.sql ve vaší databázi

Nainstalujte NUGET package jestli je nemáte
spusťte aplikaci
Po spuštění se objeví login a odtamtud se může uživatel přihlásit do databáze

Dělání postav
  Uživatel může v aplikaci vytvářep dnd postavy se staty a příběhem
  Ostatní uživatelé si mohou postavy prohlédnout

Dělání kostek
  Uživatel si může udělat své vlastní kostky a může k nim "připnout" stat postavy, kterou udělal a házet tak "za stat"

Problémy?
Pokud nepoužijete MSSQL server tak vám možná aplikace nepoběží

Pokud máte nějaké stížnosti, bugy a nebo návrky jaké rasy a classy přidat, dejte mi vědět na emailu s předmětem DnDStížnost

luky.dvorak07@gmail.com
