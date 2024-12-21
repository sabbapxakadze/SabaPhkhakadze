static double PointCalculation((double,double) a, (double,double) b)
{
    // formula is: sqrt( (x2-x1)^2 + (y2-y1)^2) )
    double x = b.Item1 - a.Item1;
    x *= x;

    double y = b.Item2 - a.Item2;
    y *= y;
    return Math.Sqrt(x + y);
}

Console.Write("Enter x for a: ");
double x1 = double.Parse(Console.ReadLine());
Console.Write("Enter y for a: ");
double y1 = double.Parse(Console.ReadLine());

Console.Write("Enter x for b: ");
double x2 = double.Parse(Console.ReadLine());
Console.Write("Enter y for b: ");
double y2 = double.Parse(Console.ReadLine());

Console.WriteLine($"Length between a{(x1,y1)} and b{(x2,y2)} is {Math.Round(PointCalculation((x1,y1),(x2,y2)))}");