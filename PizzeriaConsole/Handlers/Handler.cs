namespace PizzeriaConsole.Handlers;

using FileReaderLibrary;
using FileReaderLibrary.FileReaders;
using FileWriterLibrary;
using FileWriterLibrary.FileWriters;
using PizzeriaLibrary.Pizzeria;

public class Handler : IHandler
{
    private readonly string _ordersDirectory;
    private readonly string _receiptsDirectory;

    public string OrdersDirectory { get => _ordersDirectory; }
    public string ReceiptsDirectory { get => _receiptsDirectory; }

    public Handler(string ordersDirectory, string receiptsDirectory)
    {
        _ordersDirectory = ordersDirectory;
        _receiptsDirectory = receiptsDirectory;
    }

    public Handler()
    {
        _ordersDirectory = DestinationPath("TheOrders");
        _receiptsDirectory = DestinationPath("TheReceipts");
    }

    public void Handle()
    {
        var orders = GetFiles(OrdersDirectory);
        FileReader reader;
        FileWriter writer;

        foreach (var order in orders) 
	    {
            reader = new FileReaderText(Path.GetFileName(order), OrdersDirectory);
            reader.FileRead();

            writer = new FileWriterText(reader.Name.Replace("Order", "Receipt"), ReceiptsDirectory, BuildContent(reader.Content));
            writer.FileWrite();
        }
    }

    private static string DestinationPath(string directory)
    {
        var name = "PizzeriaConsole";
        var path = Directory.GetCurrentDirectory();
        // ...
        var root = Path.GetPathRoot(path) ?? "No PathRoot";
        var bs = Path.Combine(path.Split(Path.DirectorySeparatorChar).TakeWhile(s => !s.Equals(name)).ToArray());
        // ...
        return Path.Combine(root, bs, name, directory);
    }

    private static List<string> GetFiles(string path)
    {
        // Console.WriteLine(Path.Combine(basepath, directory));
        // Console.WriteLine(Directory.Exists(Path.Combine(basepath, directory)));
        // foreach (var file in Directory.GetFiles(Path.Combine(basepath, directory), "*.csv")) Console.WriteLine(file);
        // return Directory.GetFiles(Path.Combine(basepath, directory), "*.csv");
        var orders = Directory.GetFiles(path, "*.*", SearchOption.AllDirectories).Where(s => s.EndsWith(".csv"));
        return orders.ToList();
    }

    private static string BuildContent(string content) 
    {
        try
        {
            var pizzas = ReadPizzas(content);
            string description = $"Orders:{Environment.NewLine}";
            decimal price = 0.00M;
            foreach (var pizza in pizzas)
            {
                description += $"{pizza.GetDescription().TrimEnd(',')}{Environment.NewLine}";
                price += pizza.GetPrice();
            }
            description += $"Price: {price}$";
            return description;
        }
        catch (Exception /*ex*/)
        {
            // Console.WriteLine(ex.Message);
            return string.Empty;
        }
    }

    private static List<IPizza> ReadPizzas(string content)
    {
        List<IPizza> pizzas = new List<IPizza>();
        foreach (var line in content.Split(Environment.NewLine).Skip(1))
        {
            // Console.WriteLine(line);
            pizzas.Add(PizzaFactory.Build(line));
        }
        return pizzas;
    }
}
