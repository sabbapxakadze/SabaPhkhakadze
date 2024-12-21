static char[] CreateAndInitiateArray()
{
    Console.Write("Enter size for array: ");
    int size = int.Parse(Console.ReadLine());
    while (size <= 0)
    {
        Console.Write("Enter a valid size number: ");
        size = int.Parse(Console.ReadLine()); 
    }
    char[] arr = new char[size];

    for (int i = 0; i < size; i++)
    {
        Console.Write($"Enter a char for index {i}: ");
        arr[i] = Console.ReadKey().KeyChar;
        Console.WriteLine();
    }
    return arr;
}

static int FindNum(char[] arr, char a)
{
    int repetition = 0;
    foreach (char c in arr)
    {
        if (c == a) repetition++;
    }
    return repetition;
}

static void PrintTheResults(char a, int repetition)
{
    Console.WriteLine($"'{a}' shegvxvda {repetition}-jer");
}

PrintTheResults('L', FindNum(CreateAndInitiateArray(), 'L'));