static int CountWords(string x)
{
    int cnt = 0;

    string[] arr = x.Split(' ');

    for (int i = 0; i < arr.Length; i++)
    {
        if (!String.IsNullOrEmpty(arr[i])) cnt++;
    }
    return cnt;
}

static void PrintCount(string x)
{
    int cnt = CountWords(x);

    Console.WriteLine(cnt);
}

PrintCount(Console.ReadLine());