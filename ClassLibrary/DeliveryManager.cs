class DeliveryManager
{
    private readonly Warehouse _warehouse;

    public DeliveryManager(Warehouse warehouse)
    {
        _warehouse = warehouse;
    }

    public void GenerateStatistics()
    {
        // Логика для расчета средних значений и итогов по доставкам грузовиков
        Console.WriteLine("Генерация статистики...");
    }
}