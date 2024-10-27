Console.Write("Enter a positive number: ");
int x = int.Parse(Console.ReadLine());

while (x <= 0)
{
    Console.Write("Enter a valid number: ");
    x = int.Parse(Console.ReadLine());
}

Console.Write($"The divisors of {x} are: ");

for (int i = 1; i <= x; i++)
{
    if (x % i == 0)
        if (x == i) Console.Write(i);
        else Console.Write(i + ", ");
}