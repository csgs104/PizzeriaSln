using System;


namespace PizzeriaLibrary.Pizzeria;

public class PizzaTopping : IPizza
{
    private readonly IPizza _pizza;

    private readonly string _topping;
    private readonly decimal _price;

    public IPizza Pizza { get => _pizza; }

    public string Topping { get => _topping; }
    public decimal Price { get => _price; }


    public PizzaTopping(IPizza pizza, string topping, decimal price)
    {
        _pizza = pizza;
        _topping = topping;
        _price = price;
    }


    public string GetDescription() => $"{Pizza.GetDescription()}{Topping},";

    public virtual bool isFree() => false;

    public decimal GetPrice() => !isFree() ? Pizza.GetPrice() + Price : 0.00M;
}

