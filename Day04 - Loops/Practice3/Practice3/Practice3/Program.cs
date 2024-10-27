Console.WriteLine("Enter your number");

int x = int.Parse(Console.ReadLine());
while (x < 0)
{
    Console.WriteLine("Enter nonnegative number:");
    x = int.Parse(Console.ReadLine());
}

for (int i = 0; i <= x; i++)
{
    Console.WriteLine($"{i} cubed is {i*i*i}");
}