using System.Collections.Concurrent;

public class Warehouse
{
    private readonly int _capacity;
    private readonly ConcurrentDictionary<string, int> _currentStock = new ConcurrentDictionary<string, int>();
    private readonly object _lock = new object();

    public Warehouse(int capacity)
    {
        _capacity = capacity;
    }

    public void ReceiveProduct(string factoryName, string productName, int units)
    {
        lock (_lock)
        {
            _currentStock.AddOrUpdate(productName, units, (key, oldValue) => oldValue + units);
            Console.WriteLine($"Получено {units} единиц продукта {productName} от завода {factoryName}. Текущий запас: {_currentStock[productName]}");

            if (CheckCapacity())
            {
                ReleaseProduct();
            }
        }
    }

    private bool CheckCapacity()
    {
        int totalUnits = 0;
        foreach (var stock in _currentStock.Values)
        {
            totalUnits += stock;
        }
        return totalUnits >= _capacity * 0.95;
    }

    private void ReleaseProduct()
    {
        // Логика для выпуска продукции грузовикам
        Console.WriteLine("Склад заполнен более чем на 95%. Выпускаем продукцию.");
    }
}