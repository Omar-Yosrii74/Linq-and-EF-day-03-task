# EF01 Task — Bookstore System (Entity Framework Core Code First)

## Project Structure
BookstoreSystem/
├── Models/
│   ├── Book.cs
│   └── Author.cs
├── Contexts/
│   ├── BookstoreDbContext.cs
│   └── BookConfiguration.cs
├── Migrations/
│   └── (Auto-generated migration files)
└── Screenshots/
    └── database_tables.png

## What This Project Does
A simple Bookstore System built using Entity Framework Core Code First approach.
Maps C# classes to a SQL Server database using three different mapping strategies.

## Mapping Strategies Used
- Convention — Id becomes Primary Key automatically
- Data Annotations — [Required], [MaxLength], [Table] on Author
- Fluent API — BookConfiguration class for Book entity

## How to Run
1. Open in Visual Studio 2022
2. Install NuGet packages: EF Core SqlServer + Tools (v5.x)
3. Open Package Manager Console and run:
   Add-Migration InitialCreate
   Update-Database
