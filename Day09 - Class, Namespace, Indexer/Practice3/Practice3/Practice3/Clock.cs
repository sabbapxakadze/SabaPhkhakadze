class Clock
{
    int _Second;
    public int Second 
    { 
        get { return _Second; }
        set 
        { 
            if (value >= 0 && value < 60)
            _Second = value; 
        }
    }
    int _Minute;
    public int Minute
    {
        get { return _Minute; }
        set
        {
            if (value >= 0 && value < 60)
                _Minute = value;
        }
    }
    int _Hour;
    public int Hour
    {
        get { return _Hour; }
        set
        {
            if (value >= 0 && value < 60)
                _Hour = value;
        }
    }

    public void IncSecond() 
    {
        if (Second == 59)
        {
            Second = 0;
            IncMinute();
        }
        else Second = Second + 1;
    }
    public void IncMinute()
    {
        if (Minute == 59)
        {
            Minute = 0;
            IncHour();
        }
        else Minute = Minute + 1;
    }
    public void IncHour()
    {
        if (Hour == 23)
        {
            Hour = 0;
        }
        else Hour = Hour + 1;
    }

    public void DecSecond()
    {
        if (Second == 0)
        {
            Second = 59;
            DecMinute();
        }
        else Second = Second - 1;
    }
    public void DecMinute()
    {
        if (Minute == 0)
        {
            Minute = 59;
            DecHour();
        }
        else Minute = Minute - 1;
    }
    public void DecHour()
    {
        if (Hour == 0)
        {
            Hour = 23;
        }
        else Hour = Hour - 1;
    }
    public void GetCurrentTime()
    {
        string h = $"{Hour}";
        string m = $"{Minute}";
        string s = $"{Second}";
        if (Hour < 10)
            h = 0 + h;
        if (Minute < 10)
            m = 0 + m;
        if (Second < 10)
            s = 0 + s;
        Console.WriteLine($"{h}:{m}:{s}");
    }
}

class Test
{
    static void Main(string[] args)
    {
        Clock clk = new Clock();

        Console.Write("Enter second: ");
        clk.Second = int.Parse(Console.ReadLine());
        Console.Write("Enter minute: ");
        clk.Minute = int.Parse(Console.ReadLine());

        Console.Write("Enter hour: ");
        clk.Hour = int.Parse(Console.ReadLine());

        clk.IncMinute();
        clk.IncMinute();
        clk.IncSecond();
        clk.DecHour();

        clk.GetCurrentTime();
    }
}