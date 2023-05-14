using System;


namespace PizzeriaLibrary.Pizzeria;

public class Pizza : IPizza
{
    private readonly Basis _basis = null!;
    private readonly Dough _dough = null!;

    public Basis Basis { get => _basis; }
    public Dough Dough { get => _dough; }


    public Pizza(Basis basis, Dough dought)
    {
        _basis = basis;
        _dough = dought;
    }


    public string GetDescription() => $"{_basis.Name};{_dough.Name};";

    public bool isFree() => false;

    public decimal GetPrice() => !isFree() ? _basis.Price + _dough.Price : 0.00M;
}