namespace PizzeriaLibrary.Pizzeria;

public abstract class Basis : Ingredient
{
    public Basis(string name, decimal price)
    : base(name, price)
    { }
}