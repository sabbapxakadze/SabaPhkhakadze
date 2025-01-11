using System.Diagnostics;

public class ElectricCar
{
    public int BatteryLevel { get; private set; }
    public string Model { get; set; }
    public int Year { get; set; }
    public ElectricCar(string model, int year)
    {
        BatteryLevel = 0;
        Model = model;
        Year = year;
    }
    public async Task Charge(CancellationToken token)
    {
        while (BatteryLevel < 100 && !token.IsCancellationRequested)
        {
            BatteryLevel = Math.Min(BatteryLevel + 5, 100);
            Console.WriteLine($"Model: {Model}, Year: {Year}, BatteryLevel: {BatteryLevel}%");
            await Task.Delay(10000, token);
        }
    }
    public static async Task ChargeAllCars(IEnumerable<ElectricCar> cars, int maxSeconds = 200)
    {
        Console.WriteLine("Starting to charge all cars...");

        Stopwatch stopwatch = Stopwatch.StartNew();

        CancellationTokenSource cts = new CancellationTokenSource(TimeSpan.FromSeconds(maxSeconds));
        try
        {
            var chargeTasks = cars.Select(car => car.Charge(cts.Token)).ToList();

            await Task.WhenAll(chargeTasks);
        }
        catch (OperationCanceledException)
        {
            Console.WriteLine("Charging stopped for not completing in the given time!");
        }
        finally
        {
            stopwatch.Stop();
            Console.WriteLine("Charging completed.");
            Console.WriteLine($"Total time elapsed: {stopwatch.Elapsed.TotalSeconds:F2} seconds.");
            cts.Dispose();
        }
    }
}