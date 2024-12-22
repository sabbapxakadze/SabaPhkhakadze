using System.Threading.Tasks;
//დავწეროთ კონსილის აპლიკაცია სადაც შევქმნით 10 ცალ ტასკს და გავუშვებთ პარალელურად. 
//თითოეული მათგანი შექმნის თავისივე ნუმერაციის txt ფაილს (მაგ: 1.txt,2.txt) სადაც
//პერმანენტულად დაიწყებს რაიმე ტექსტის ჩაწერას მაგალითად: Task1, Task2 და ა.შ.
//ტასკი უნდა წერდეს ფაილში უსასრულოდ სანამ სხვა ტასკი არ დააქენსელებს (შესაბამისად
//უნდა არსებობდეს დამატებით 1 ტასკი რომელიც ელოდება კონსოლიდან input ს და როდესაც
//input იქნება x ტოკენს დააქენსელებს). 
//თითოეული ტასკი ფაილში უნდა წერდეს while ის საშუალებით, რომელიც დამოკიდებულია
//token ის აქტიურ სტატუსზე. როდესაც მოხდება token ის დაქენსელება while პროცესი შეწყდეს
//და exception არ ამოვარდეს. 
//ფაილში ჩაწერისას გავუკეთოთ Delay ტასკის ნუმერაცია * 100 ზე
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