static void Multiplies(params int[] p)
{

    int res = 1;

    foreach (int i in p)
    {
        res = res * i;
    }

    Console.WriteLine($"The product of array elements are: {res}");
}

Multiplies(1,3,4,15,13,23,98);