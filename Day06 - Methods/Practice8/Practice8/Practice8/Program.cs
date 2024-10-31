static int EnterAPositiveNumber()
{
    Console.Write("Enter a positive number: ");
    int x = int.Parse(Console.ReadLine());
    while (x <= 0)
    {
        Console.Write("Enter a valid positive number: ");
        x = int.Parse(Console.ReadLine());
    }
    return x;
}

static void PrintTheSumOfDegree(int x)
{
    int old = x;
    string res = "";
    int deg = 0;
    
    while (x != 0)
    {
        int rem = x % 10;

        if (x / 10 == 0)
            res = $"{rem} * 10^{deg} " + res;
        else 
            res = $"+ {rem} * 10^{deg} " + res;

        x /= 10;
        deg = deg + 1;
    }
    res = $"{old} = {res}";
    Console.WriteLine(res);
}

PrintTheSumOfDegree(EnterAPositiveNumber());