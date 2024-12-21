static int[] CreateAndInitiateArray()
{
    Console.Write("Enter size for array: ");
    int size = int.Parse(Console.ReadLine());
    while (size <= 0)
    {
        Console.Write("Enter a valid size number: ");
        size = int.Parse(Console.ReadLine());
    }
    int[] arr = new int[size];

    for (int i = 0; i < size; i++)
    {
        Console.Write($"Enter an integer for index {i}: ");
        arr[i] = int.Parse(Console.ReadLine());
    }
    return arr;
}

static int Factorial(int x)
{
    if (x < 0)
    {
        Console.WriteLine("Factorial of negative numbers are undefined!");
    }
    if (x == 0)
        return 1;

    return x * Factorial(x - 1);
}

static void FindAndPrintFactorial(int[] arr, int n)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == n)
        {
            int res = Factorial(arr[i]);
            Console.WriteLine($"Given number {n} was in the array and factorial of it is {res}");
            return;
        }
    }
    Console.WriteLine($"Given number {n} was not found in the array!");
}