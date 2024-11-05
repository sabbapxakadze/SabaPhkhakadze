void RecursiveSum(int x, int acc = 0) // this is tail-recursive way and by default acc = 0
{
    if (x == 1) Console.WriteLine(1 + acc);

    else RecursiveSum(x - 1, acc + x);
}

RecursiveSum(int.Parse(Console.ReadLine()));