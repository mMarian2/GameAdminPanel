# 🎮 Game Admin Panel

O aplicație web Full-Stack pentru administrarea jucătorilor și eroilor dintr-un joc video. Proiectul demonstrează implementarea completă a operațiunilor CRUD (Create, Read, Update, Delete) folosind tehnologii moderne .NET.

## 🚀 Tehnologii Folosite

* **Backend:** C# .NET 8.0, ASP.NET Core MVC
* **Baza de Date:** SQL Server (LocalDB), Entity Framework Core
* **Frontend:** HTML5, CSS3, Bootstrap (Razor Views)
* **Arhitectură:** Model-View-Controller (MVC)

## ✨ Funcționalități Principale

1.  **Dashboard Eroi:** Vizualizarea tuturor eroilor din baza de date într-un tabel dinamic.
2.  **Adăugare Erou (Create):** Formular validat pentru crearea de noi personaje (Nume, Clasă, Nivel).
3.  **Editare (Update):** Posibilitatea de a modifica atributele eroilor existenți.
4.  **Ștergere (Delete):** Eliminarea eroilor din sistem.
5.  **Bază de Date Automată:** Sistem de Migrations (Code-First) care generează automat structura SQL.

## 🛠️ Cum să rulezi proiectul

1.  Clonează acest repository.
2.  Deschide soluția în **Visual Studio 2022**.
3.  Deschide **Package Manager Console** și rulează comanda pentru a crea baza de date locală:
    ```powershell
    Update-Database
    ```
4.  Apasă butonul de **Run** (Play) sau `F5`.
5.  Navighează la `/Erous` pentru a accesa panoul de administrare.
