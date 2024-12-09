public class TemperatureMonitor
{
    public event EventHandler<int> TemperatureChanged;

    public void CheckTemperature(int temperature)
    {
        OnTemperatureChanged(temperature);
    }

    protected virtual void OnTemperatureChanged(int temperature)
    {
        TemperatureChanged?.Invoke(this, temperature);
    }
}