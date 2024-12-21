void RecursivePrint(int x)
{
    if (x <= 1) Console.Write(x + " ");
    else 
    {
        RecursivePrint(x - 1);
        Console.Write(x + " ");
    }
}

RecursivePrint(int.Parse(Console.ReadLine()));