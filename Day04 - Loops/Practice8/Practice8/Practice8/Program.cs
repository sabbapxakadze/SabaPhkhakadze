Console.Write("Enter a number: ");
int x = int.Parse(Console.ReadLine());

while (x < 0)
{
    Console.Write("Enter a valid number: ");
    x = int.Parse(Console.ReadLine());
}

string r = "";
int old = x;

while (x != 0)
{
    if (x % 2 == 0) r = 0 + r;
    else r = 1 + r;
    x /= 2;
}

Console.WriteLine($"Your number {old} in binary is {r}");