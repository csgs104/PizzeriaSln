using System;

using PizzeriaLibrary.Pizzeria;


namespace PizzeriaLibrary.Pizzeria.Toppings;

public class BackedHam : PizzaTopping
{
    public BackedHam(IPizza pizza) 
	: base(pizza, "BackedHam", 1.00M)
    { }

    public override bool isFree() => Pizza.isFree();
}