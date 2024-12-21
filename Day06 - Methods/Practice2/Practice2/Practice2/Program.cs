static int Practice2(int[] arr, int i)
{
    if (arr == null || i < 0 || i >= arr.Length)
    {
        Console.WriteLine("bad input!");
        return 0;
    }
    int x = arr[i];
    int res = 0;

    while (x != 0)
    {
        res += x % 10;
        x /= 10;
    }
    Console.WriteLine($"The sum of digits on the index {i} in this array is {res}");
    return res;
}
