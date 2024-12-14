using System.Diagnostics;

public class Program
{
    public static List<int> primeNums = new List<int>();
    static object locker = new object();

    static void Main(string[] args)
    {
        Console.Write("Enter the start of the range: ");
        int start = int.Parse(Console.ReadLine());
        while (start <= 0)
        {
            Console.Write("The number must be a natural: ");
            start = int.Parse(Console.ReadLine());
        }

        Console.Write("Enter the end of the range: ");
        int end = int.Parse(Console.ReadLine());
        
        while(start > end)
        {
            Console.Write("The end must be higher than a start: ");
            end = int.Parse(Console.ReadLine());
        }

        Console.Write("Enter a threads to use: ");
        int threads = int.Parse(Console.ReadLine());
        while (threads <= 0)
        {
            Console.Write("Enter a natural number: ");
            threads = int.Parse(Console.ReadLine());
        }

        // we have threadNumber, start and end
        // now each threadnumber will work this way:
        // we will get the range number (end-start+1)
        // after doing this we will divide this number(lets call this "interval")
        // by all threadNumber
        // and then each thread will find primes
        // in the given start+(interval * threadnumber)
        // theadnumbers are from 0 to user input on threadNumber-1 !

        int range = end - start + 1;

        int interval = range / threads;
        int remainder = range % threads;

        List<Thread> threadList = new List<Thread>();

        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start(); 

        for (int i = 0; i < threads; i++)
        {
            int threadStart = start + i * range;
            int threadEnd = (i == threads - 1) ? end : threadStart + range - 1;
            Thread t = new Thread(() => PrimesInRange(threadStart, threadEnd));
            threadList.Add(t);
        }

        foreach (Thread t in threadList)
        {
            t.Start();
        }
        foreach (Thread t in threadList)
        {
            t.Join();
        }

        stopwatch.Stop(); 


        primeNums.Sort();
        Console.WriteLine("Primes in the range are: ");
        foreach(int i in primeNums)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();
        Console.WriteLine($"This process took {stopwatch.ElapsedMilliseconds}ms");
    }

    public static void PrimesInRange(int start, int end)
    {
        List<int> primes = new List<int>();
        for (int i = start; i <= end; i++)
        {
            if (IsPrime(i))
                primes.Add(i);
        }
        lock (locker)
        {
            primeNums.AddRange(primes);
        }
        
    }


    public static bool IsPrime(int n)
    {
        if (n <= 0) return false;
        else if (n == 1) return false;
        else if (n == 2) return true;

        int cnt = 1;

        for (int i = 2; i <= n; i++)
        {
            if (cnt > 2) return false;
            if (n % i == 0) cnt++;
        }
        return cnt == 2;
    }
}