Console.Write("Ented a positive number: ");

int x = int.Parse(Console.ReadLine());

while (x < 0)
{
    Console.Write("Enter a valid number:");
    x = int.Parse(Console.ReadLine());
}

int f1 = 0;
int f2 = 1;
int f3 = 1;


if (x == 0) Console.WriteLine(f1);
else if (x == 1) Console.WriteLine(f1 + ", " + f2);
else
{ 
    Console.Write($"{f1}, {f2}, {f3}");
    for (int i = 3; i <= x; i++)
    {
        f1 = f2;
        f2 = f3;
        f3 = f1 + f3;
        Console.Write($", {f3}");

    }
}