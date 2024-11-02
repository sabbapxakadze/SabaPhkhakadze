static int CountLetters(string s)
{
    int cnt = 0;
    foreach (char c in s)
    {
        if (char.IsLetter(c)) cnt++;
    }
    return cnt;
}
static int CountDigits(string s)
{
    int cnt = 0;
    foreach (char c in s)
    {
        if (char.IsDigit(c)) cnt++;
    }
    return cnt;
}       

static void PrintTheResults(string s)
{
    int letters = CountLetters(s);
    int digits = CountDigits(s);

    Console.WriteLine($"\"{s}\": -> Letters: {letters}, Numbers: {digits}, Others: {s.Length - letters - digits}");
}

PrintTheResults(Console.ReadLine());