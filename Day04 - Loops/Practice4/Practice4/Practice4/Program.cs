Console.WriteLine("Enter your number");

int x = int.Parse(Console.ReadLine());


int sum = 0;

if (x > 0)
for (int i = 0; i <= x; i++)
{
    if (i % 2 == 1) sum += i;
}

else
for (int i = 0; i >= x; i--)
{
    if (i % 2 == -1) sum += i;
}

Console.WriteLine($"Sum of odd numbers from 0 to {x} is {sum}");