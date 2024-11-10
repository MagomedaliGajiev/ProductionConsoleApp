class Program
{
    static void Main(string[] args)
    {
        var warehouseCapacity = 1000; // Пример вместимости
        var warehouse = new Warehouse(warehouseCapacity);

        // Создание заводов
        var factoryA = new Factory("A", "a", 50, warehouse);
        var factoryB = new Factory("B", "b", 55, warehouse);
        var factoryC = new Factory("C", "c", 60, warehouse);

        // Запуск потоков производства заводов
        var factoryAThread = new Thread(factoryA.StartProduction);
        var factoryBThread = new Thread(factoryB.StartProduction);
        var factoryCThread = new Thread(factoryC.StartProduction);

        factoryAThread.Start();
        factoryBThread.Start();
        factoryCThread.Start();

        // Создание грузовиков
        var truck1 = new Truck(warehouse, 100);
        var truck2 = new Truck(warehouse, 150);

        // Запуск потоков доставки грузовиков
        var truck1Thread = new Thread(truck1.StartDelivery);
        var truck2Thread = new Thread(truck2.StartDelivery);

        truck1Thread.Start();
        truck2Thread.Start();

        // Сохранение основного потока в активном состоянии
        Console.ReadLine();
    }
}