namespace PizzeriaLibrary.Pizzeria;

public interface IPizza
{
    public string GetDescription();
    public bool isFree();
    public decimal GetPrice();
}

