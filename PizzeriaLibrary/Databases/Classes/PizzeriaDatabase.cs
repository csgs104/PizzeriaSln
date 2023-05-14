using System;

using Microsoft.Data.SqlClient;

using PizzeriaLibrary.Databases.Abstract;


namespace PizzeriaLibrary.Databases.Classes;

public class PizzeriaDatabase : Database
{
    public PizzeriaDatabase(string connection)
	: base(connection)
    { }

    private static string database = "Pizzeria";
    private static string[] tables = new string[] {"Order", "Receipt"};

    public override string CreateDataBase() =>  $@"
    IF NOT EXISTS (SELECT * FROM [sys].[databases] WHERE [name]='{database}') 
    BEGIN CREATE DATABASE [{database}] END";

    public override string CreateTables() => $@"
    IF NOT EXISTS (SELECT * FROM [{database}].[sys].[sysobjects] WHERE [name]='{tables[0]}' AND [xtype]='U')
    BEGIN 
    CREATE TABLE [{database}].[dbo].[{tables[0]}] (
    [Id] INT NOT NULL UNIQUE IDENTITY(1,1), 
    [Pizzas] NVARCHAR(2000000000) NOT NULL,
    [Date] DATETIME NOT NULL,
    CONSTRAINT PK_Order PRIMARY KEY (Id)
    ) END
    
    IF NOT EXISTS (SELECT * FROM [{database}].[sys].[sysobjects] WHERE [name]='{tables[1]}' AND [xtype]='U')
    BEGIN 
    CREATE TABLE [{database}].[dbo].[{tables[1]}] (
    [Id] INT NOT NULL UNIQUE IDENTITY(1,1), 
    [OrderId] INT NOT NULL,
    [Price] DECIMAL(20,2) NOT NULL, 
    CONSTRAINT PK_Receipt PRIMARY KEY (Id)
    CONSTRAINT FK_OrderReceipt FOREIGN KEY (OrderId) REFERENCES Order(Id)
    ) END";

    public override string InsertTables() => @"";
}