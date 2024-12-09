public class TemperatureAlert
{
    public void OnProcessCompletedHandler(object sender, int temp)
    {
        if (temp > 40 || temp < 0)
        {
            Console.WriteLine("Alert! Critical temperature detected: " + temp);
        }
        else
        {
            Console.WriteLine("Temperature is okay: " + temp);
        }
    }
}