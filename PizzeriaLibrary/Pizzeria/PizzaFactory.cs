namespace PizzeriaLibrary.Pizzeria;

using Basises;
using Doughs;
using Toppings;

public static class PizzaFactory
{
    public static IPizza Build(string str)
    {
        var order = BuildOrder(str);
        if (order is null || order.Length < 2) { throw new Exception("Not an Order!"); }
        else if (order.Length == 2) { return BuildNoToppings(order); }
        else if (order.Length > 2) { return BuildWithToppings(order); }
        else { throw new Exception("Not an Order!"); }   
    }

    private static string[] BuildOrder(string str)
    {
        if (str is null || !str.Contains(';'))
        {
            throw new Exception($"BuildOrder Not Working: {str}.");
        }
        else
        {
            string[] pizza = str.Split(';');
            string[] toppings = pizza[2] != string.Empty ? pizza[2].Split(',') : new string[0];
            // Console.WriteLine(toppings.Aggregate("", (s,acc) => acc + " " + s));

            string[] order = new string[toppings.Length + 2];
            order[0] = pizza[0];
            order[1] = pizza[1];

            for (var t = 0; t < toppings.Length; t++) { order[t + 2] = toppings[t]; }

            return order;
        }
    }

    private static IPizza BuildNoToppings(string[] order)
    {
        return new Pizza(AddBaisis(order[0]), AddDough(order[1]));
    }

    private static IPizza BuildWithToppings(string[] order)
    {
        IPizza pizza = BuildNoToppings(order);
        for (int t = 2; t < order.Length; t++) { pizza = AddToppings(pizza, order[t]); }
        return pizza;
    }

    private static Basis AddBaisis(string str) 
    {
        Basis basis;
        if (str == "Margherita") { basis = new Margherita(); }
        else if (str == "Neapolitan") { basis = new Neapolitan(); }
        else if (str == "White") { basis = new White(); }
        else { throw new Exception($"AddBaisis Not Working: {str}."); }
	    return basis;
    }

    private static Dough AddDough(string str)
    {
        Dough dough;
        if (str == "Normal") { dough = new Normal(); }
        else if (str == "Wholemeal") { dough = new Wholemeal(); }
        else { throw new Exception($"AddDough Not Working: {str}."); }
        return dough;
    }

    private static IPizza AddToppings(IPizza pizza, string topping)
    {
        if (topping == "Ananas") { return new Ananas(pizza); }
        else if (topping == "Mushrooms") { return new Mushrooms(pizza); }
        else if (topping == "BackedHam") { return new BackedHam(pizza); }
        else if (topping == "RawHam") { return new RawHam(pizza); }
        else { throw new Exception($"AddToppings Not Working: {topping}."); }
    }
}