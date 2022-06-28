# WFSQL
[![CodeFactor](https://www.codefactor.io/repository/github/kolyafedorenko/wfsql/badge)](https://www.codefactor.io/repository/github/kolyafedorenko/wfsql)
![Nuget](https://img.shields.io/nuget/v/wfsql)
![GitHub release (latest by date)](https://img.shields.io/github/v/release/KolyaFedorenko/WFSQL)
![GitHub Release Date](https://img.shields.io/github/release-date/KolyaFedorenko/WFSQL)

WFSQL is a simple library to simplify working with a SQL Server database in a C# Windows Forms application

### About this library
The library includes classes with methods that can be used for:
- Filling the DataGridView with data obtained from the database using SELECT queries
- Filling the ComboBox with data obtained from the database using SELECT queries
- Performing INSERT, DELETE and UPDATE queries to the database

The library includes interface with method that can be used to:
- Notify the parent form of an event in the child form

### How to use this library:
To get started, install this library using PackageManager:
```powershell
Install-Package wfsql -Version 1.2.0
```
Or using .NET CLI:
```
dotnet add package wfsql --version 1.2.0
```

After installing the NuGet package, you can use the `Database` class to work with the database.

First, create an instance of the `Database` class by passing the database connection string as a parameter to its constructor:
```cs
private Database database = new Database(@"Data Source=SOME\SQLDATASOURCE;Initial Catalog=SomeDatabase;User ID=SomeUser;Password=SomePassword");
```

To fill the DataGridView with values from the database, you can use the `FillDataGridView` method:
```cs
database.FillDataGridView("SELECT * FROM SomeTable", someDataGridView);
```

To fill the ComboBox with values from the database, you can use the `FillComboBox` method:
```cs
database.FillComboBox("SELECT SomeId, SomeName FROM SomeTable", someComboBox, "SomeId", "SomeName");
```

To perform an INSERT, DELETE or UPDATE query to the database, you can use the `ExecuteSqlQuery` method:
```cs
database.ExecuteSqlQuery("INSERT INTO SomeTable(SomeId, SomeName) VALUES (1, 'NameOfUserWithId1')");
database.ExecuteSqlQuery("UPDATE SomeTable SET SomeName = 'UpdatedName' WHERE SomeId = 1");
database.ExecuteSqlQuery("DELETE FROM SomeTable WHERE SomeId = 1");
```

An example of a Windows Forms application using the classes of this library is presented in the [Sample folder](https://github.com/KolyaFedorenko/WFSQL/tree/main/Sample)
