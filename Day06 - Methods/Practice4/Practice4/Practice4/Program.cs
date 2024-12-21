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

static double AverageOfArray(int[] arr)
{
    if (arr == null || arr.Length == 0)
    {
        Console.WriteLine("bad input!");
        return 0.0;
    }

    double sum = 0.0;
    foreach (int i in arr) 
    {
        sum += arr[i];
    }
    double avg = sum / arr.Length;
    Console.WriteLine($"Arithmetic average of your array is {avg}");
    return avg;
}