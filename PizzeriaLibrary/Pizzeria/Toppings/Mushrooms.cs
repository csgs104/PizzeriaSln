namespace PizzeriaLibrary.Pizzeria.Toppings;

public class Mushrooms : PizzaTopping
{
    public Mushrooms(IPizza pizza) 
	: base(pizza, "Mushrooms", 2.00M)
    { }

    public override bool isFree() => Pizza.isFree();
}