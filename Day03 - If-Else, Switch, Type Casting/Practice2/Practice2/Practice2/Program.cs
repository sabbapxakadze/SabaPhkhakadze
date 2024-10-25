


Console.WriteLine("Enter your first number!");
int a = int.Parse(Console.ReadLine());


Console.WriteLine("Enter your second number!");
int b = int.Parse(Console.ReadLine());


Console.WriteLine("Enter your third number!");
int c = int.Parse(Console.ReadLine());


if (a + b > c && a + c > b && b + c > a)
    Console.WriteLine("This should be a triangle!");
else Console.WriteLine("This can not be a triangle");