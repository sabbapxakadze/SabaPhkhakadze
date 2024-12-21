static int[] CreateAndInitiateArray()
{
    Console.Write("Enter size for array: ");
    int size = int.Parse(Console.ReadLine());
    while(size <= 0)
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

static void PrintMinAndMax(int[] arr)
{
    if (arr == null)
    {
        Console.WriteLine("array has no element");
        return;
    }
    int max = int.MinValue;
    int min = int.MaxValue;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max) max = arr[i];
        if (arr[i] < min) min = arr[i];
    }
    Console.WriteLine($"The minimum in your array is {min}");
    Console.WriteLine($"The maximum in your array is {max}");
}

PrintMinAndMax(CreateAndInitiateArray());