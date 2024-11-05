void RecursiveNumberOfLength(int x, int acc = 0)
{
    if (x < 0) RecursiveNumberOfLength(-x, acc);
    
    else if (x>10) RecursiveNumberOfLength(x / 10, acc + 1);

    else Console.WriteLine(acc + 1);
}

RecursiveNumberOfLength(int.Parse(Console.ReadLine()));