Console.Write("Enter a number: ");

int num = int.Parse(Console.ReadLine());

Console.Write("Enter a power: ");
int power = int.Parse(Console.ReadLine());

MATH.STATUS res;
Console.WriteLine($"Output is {MATH.POW(num, power, out res)}");
Console.WriteLine();