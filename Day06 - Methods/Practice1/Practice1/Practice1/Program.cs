static int Practice1(int[] arr, int i)
{
    if (i < 0 || i >= arr.Length || arr == null)
        Console.WriteLine("bad input");

    Console.WriteLine($"Number at index {i} is {arr[i]}");
    return arr[i];
}