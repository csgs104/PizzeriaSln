namespace PizzeriaLibrary.Pizzeria.Toppings;

public class RawHam : PizzaTopping
{
    public RawHam(IPizza pizza) 
	: base(pizza, "RawHam", 2.00M)
    { }

    public override bool isFree() => Pizza.isFree();
}