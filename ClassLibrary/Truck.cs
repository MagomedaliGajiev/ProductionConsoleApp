public class Truck
{
    private readonly Warehouse _warehouse;
    public int Capacity { get; }

    public Truck(Warehouse warehouse, int capacity)
    {
        _warehouse = warehouse;
        Capacity = capacity;
    }

    public void StartDelivery()
    {
        while (true)
        {
            // Логика загрузки продукции со склада
            Thread.Sleep(new Random().Next(1000, 3000)); // Симуляция времени загрузки
            Console.WriteLine($"Грузовик с вместимостью {Capacity} загружает продукцию.");
        }
    }
}