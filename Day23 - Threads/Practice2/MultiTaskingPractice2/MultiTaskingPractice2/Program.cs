using System.Diagnostics;

public class Program
{
    static int _seconds;
    static bool _isRunning = true;
    static object _lock = new object();

    static void Main(string[] args)
    {
        Thread timeThread = new Thread(UpdateTimer);
        timeThread.Start();

        Thread inputThread = new Thread(HandleUserInput);
        inputThread.Start();

        timeThread.Join();
        inputThread.Join();
    }

    static void UpdateTimer()
    {
        while (_isRunning)
        {
            lock (_lock)
            {
                Console.SetCursorPosition(0, 0);
                Console.Write($"Elapsed time: {_seconds} seconds");
            }
            Thread.Sleep(1000);

            lock (_lock)
            {
                _seconds++;
            }
        }
    }

    static void HandleUserInput()
    {
        while (_isRunning)
        {
            char input = Console.ReadKey(true).KeyChar;

            Console.SetCursorPosition(0, 2);
            Console.Write(new string(' ', Console.WindowWidth));

            if (input == 'R' || input == 'r')
            {
                lock (_lock)
                {
                    _seconds = 0;
                }
                Console.SetCursorPosition(0, 2); // Move to a new line
                Console.WriteLine("Timer reset.");
            }
            else if (input == 'Q' || input == 'q')
            {
                _isRunning = false;
                Console.SetCursorPosition(0, 2); // Move to a new line
                Console.WriteLine("Program ending");
                Console.WriteLine();
            }
            else
            {
                Console.SetCursorPosition(0, 2); // Move to a new line
                Console.WriteLine("You should reset timer with 'R'");
                Console.WriteLine("End program with 'Q'");
            }
        }

        
    }
}