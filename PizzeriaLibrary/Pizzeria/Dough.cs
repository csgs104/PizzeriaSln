namespace PizzeriaLibrary.Pizzeria;

public abstract class Dough : Ingredient
{
    public Dough(string name, decimal price) 
	: base(name, price)
    { }
}