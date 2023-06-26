namespace PizzeriaLibrary.Entities.Classes;

using Abstract;

public class Order : Entity
{
    private readonly string _pizzas = null!;
    private readonly DateTime _date;

    public string Pizzas { get => _pizzas; }
    public DateTime Date { get => _date; }

    public Order(int id, string pizzas, DateTime date) 
	: base(id)
    {
        _pizzas = pizzas;
        _date = date;
    }

    public Order(string pizzas, DateTime date) 
	: base()
    {
        _pizzas = pizzas;
        _date = date;
    }

    public Order(int id, string pizzas) 
	: this(id, pizzas, DateTime.Now)
    { }

    public Order(string pizzas)
    : this(pizzas, DateTime.Now)
    { }

    public override string ToString()
    { 
        return $"{nameof(Order)}{base.ToString()}{Environment.NewLine}Password:{Pizzas}{Environment.NewLine}Date:{Date.ToString()}";
    }

    public override Dictionary<string, object> ToDictionary()
    {
        var dic = base.ToDictionary();
        dic.Add(nameof(Pizzas), Pizzas);
        dic.Add(nameof(Date), Date);
        return dic;
    }
}