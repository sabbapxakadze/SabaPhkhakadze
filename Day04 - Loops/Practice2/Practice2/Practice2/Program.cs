Console.WriteLine("Enter your number");

int x = int.Parse(Console.ReadLine());
while (x < 0)
{
    Console.WriteLine("Enter nonnegative number:");
    x = int.Parse(Console.ReadLine());
}
int res = 0;
for (int i = 0; i <= x; i++)
    res += i;

Console.WriteLine($"Sum from 0 to {x} is {res}");