using System;


namespace PizzeriaLibrary.Databases.Abstract;

public interface IDatabase
{
    public string CreateDataBase();
    
    public string CreateTables();
    
    public string InsertTables();

    public bool Initialize();
}
