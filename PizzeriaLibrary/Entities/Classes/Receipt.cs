using System;

using PizzeriaLibrary.Entities.Abstract;


namespace PizzeriaLibrary.Entities.Classes;

public class Receipt : Entity
{
    private readonly int _orderId;
    private readonly decimal _price;

    public int OrderId { get => _orderId; }
    public decimal Price { get => _price; }

    // relationships
    public virtual Order Order { get; set; } = null!;


    public Receipt(int id, int orderId, decimal price) 
	: base(id)
    {
        _orderId = orderId;
        _price = price;
    }

    public Receipt(int orderId, decimal price) 
	: base()
    {
        _orderId = orderId;
        _price = price;
    }


    public override string ToString()
    { 
        return $"{nameof(Receipt)}{base.ToString()}{Environment.NewLine}Order{Order.ToString()}{Environment.NewLine}Price:{Price.ToString()}$";
    }

    public override Dictionary<string, object> ToDictionary()
    {
        var dic = base.ToDictionary();
        dic.Add(nameof(OrderId), OrderId);
        dic.Add(nameof(Price), Price);
        return dic;
    }
}