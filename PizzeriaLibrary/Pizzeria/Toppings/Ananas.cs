namespace PizzeriaLibrary.Pizzeria.Toppings;

public class Ananas : PizzaTopping
{
    public Ananas(IPizza pizza) 
	: base(pizza, "Ananas", 0.00M)
    { }

    public override bool isFree() => true;
}