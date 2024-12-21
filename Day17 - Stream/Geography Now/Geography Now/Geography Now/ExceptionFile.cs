using System.IO;

public class CountryMustHaveSingleCapital : Exception
{
    public CountryMustHaveSingleCapital()
        : base()
    {
        LogError("A country must have exactly one capital city.");
    }

    private void LogError(string message)
    {
        File.AppendAllText("log.txt", $"{DateTime.Now}: {message}{Environment.NewLine}");
    }
}

public class CountryMustHaveAtLeastOneCity : Exception
{
    public CountryMustHaveAtLeastOneCity()
        : base()
    {
        LogError("A country must have at least one city.");
    }

    private void LogError(string message)
    {
        File.AppendAllText("log.txt", $"{DateTime.Now}: {message}{Environment.NewLine}");
    }
}

public class NegativePopulation : Exception
{
    public NegativePopulation()
        : base()
    {
        LogError("Can't have negative population");
    }

    private void LogError(string message)
    {
        File.AppendAllText("log.txt", $"{DateTime.Now}: {message}{Environment.NewLine}");
    }
}

public class NegativeArea : Exception
{
    public NegativeArea()
        : base()
    {
        LogError("Can't have negative area");
    }

    private void LogError(string message)
    {
        File.AppendAllText("log.txt", $"{DateTime.Now}: {message}{Environment.NewLine}");
    }
}
