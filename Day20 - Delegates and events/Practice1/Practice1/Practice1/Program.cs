

TemperatureMonitor monitor = new TemperatureMonitor();

TemperatureAlert alert = new TemperatureAlert();

monitor.TemperatureChanged += alert.OnProcessCompletedHandler;

Console.WriteLine("Please enter values of temperature. Program will end if you type \"exit\".");
string userInput;

do
{
    userInput = Console.ReadLine().ToLower();

    if (userInput.Equals("exit"))
    {
        break;
    }

    if (int.TryParse(userInput, out int temperature))
    {
        monitor.CheckTemperature(temperature); // here, im triggering the event!
    }
    else
    {
        Console.WriteLine("Invalid input. Please enter a valid integer.");
    }
}
while (true);

Console.WriteLine("Program ended.");
