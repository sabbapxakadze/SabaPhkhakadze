Console.Write("Enter a number: ");
int num = int.Parse(Console.ReadLine());

Console.Write("Enter a power: ");
int power = int.Parse(Console.ReadLine());

var result = MATH.POW(num, power);

Console.WriteLine($"Output is {result.x}, Status: {result.result}");
Console.WriteLine();



Console.Write("Enter the first number: ");
int num1 = int.Parse(Console.ReadLine());

Console.Write("Enter the second number: ");
int num2 = int.Parse(Console.ReadLine());


var minResult = MATH.Min(num1, num2);
Console.WriteLine($"Min: {minResult.Item1}, Status: {minResult.Item2}");


var maxResult = MATH.Max(num1, num2);
Console.WriteLine($"Max: {maxResult.Item1}, Status: {maxResult.Item2}");
Console.WriteLine();