using System.Diagnostics;

public class Program
{
    static async Task Main(string[] args)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;

        Console.WriteLine("Let's charge the cars!");
        
        ElectricCar car1 = new ElectricCar("BMW I8", 2023);
        ElectricCar car2 = new ElectricCar("Mercedes Maybach Electric", 2022);
        ElectricCar car3 = new ElectricCar("Porsche New", 2024);
        ElectricCar car4 = new ElectricCar("Ferrari Electric", 2021);

        var items = new List<ElectricCar> { car1, car2, car3, car4 };
        await ElectricCar.ChargeAllCars(items);
        Console.WriteLine("Done!");
    }
    
}