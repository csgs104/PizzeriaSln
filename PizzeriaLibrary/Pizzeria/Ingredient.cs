using System;


namespace PizzeriaLibrary.Pizzeria;

public abstract class Ingredient
{
    private string _name = null!;
    private decimal _price;

    public string Name { get => _name; }
    public decimal Price { get => _price; }


    public Ingredient(string name, decimal price)
    {
        _name = name;
        _price = price;
    }
}