public static class Calculator
{
    public static double Add(double a, double b)
    {
        return a + b;
    }
    public static double Subtract(double a, double b)
    {
        return a - b;
    }
    public static double Multiply(double a, double b)
    {
        return a * b;
    }
    public static double Divide(double a, double b)
    {
        if (a == 0) throw new DivideByZeroException();
        return a / b;
    }
    public static double Square(double a)
    {
        return a * a;
    }
    public static double Multiply5x(double a, double b, double c, double d, double e)
    {
        return a * b * c * d * e;
    }
}