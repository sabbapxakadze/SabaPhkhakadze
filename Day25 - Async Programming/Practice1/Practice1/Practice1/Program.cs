using System.Threading.Tasks;
public class Program
{
    static async Task Main(string[] args)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        
        CancellationTokenSource cts = new CancellationTokenSource();
        CancellationToken cToken = cts.Token;


        Task[] tasks = new Task[11];


        for (int i = 0; i < 10; i++)
        {
            int taskNum = i;
            tasks[taskNum] = Task.Run(() => WriteToFile(taskNum, cToken));
        }

        tasks[10] = Task.Run(() =>
        {
            Console.WriteLine("Type x to cancel all tasks! \n");

            while (true)
            {
                var key = Console.ReadKey();
                char input = key.KeyChar;
                Console.WriteLine("\n\n");
                if (input == 'X' || input == 'x')
                {
                    cts.Cancel();
                    break;
                }
            }
        });

        try
        {
            await Task.WhenAll(tasks);
        }
        catch (OperationCanceledException)
        {
            Console.WriteLine("Tasks were canceled.");
        }
        finally
        {
            cts.Dispose();
        }

        Console.WriteLine("Application has exited.");
    }


    static async Task WriteToFile(int num, CancellationToken ct)
    {
        string fileName = $"{num}.txt";

        try
        {
            while (!ct.IsCancellationRequested)
            {
                Console.WriteLine($"writing in {fileName} Task{num}");
                   await File.AppendAllTextAsync(fileName, $"Task{num} ");
                

                await Task.Delay(500*(num+1));
            }
        }
        catch (OperationCanceledException)
        {
            Console.WriteLine($"The Task{num} was cancelled");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Exception occured!");
        }
        finally
        {
            Console.WriteLine($"Task {num} stopped writing to {fileName}");
        }
    }
}