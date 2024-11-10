class Factory
{
    public string Name { get; }
    public string ProductName { get; }
    public double ProductionRate { get; }
    private Warehouse _warehouse;

    public Factory(string name, string productName, double productionRate, Warehouse warehouse)
    {
        Name = name;
        ProductName = productName;
        ProductionRate = productionRate;
        _warehouse = warehouse;
    }

    public void StartProduction()
    {
        while (true)
        {
            int units = (int)ProductionRate;
            _warehouse.ReceiveProduct(Name, ProductName, units);
            Thread.Sleep(1000); // Симуляция времени производства
        }
    }
}