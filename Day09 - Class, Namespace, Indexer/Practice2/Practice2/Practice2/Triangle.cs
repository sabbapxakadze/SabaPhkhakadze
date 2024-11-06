class Triangle
{
    public int Side1 { get; set; }
    public int Side2 { get; set; }
    int _Side3;
    public int Side3
    {
        get { return _Side3; }
        set
        {
            if (Side1 + Side2 > value && Side1 + value > Side2 && Side2 + value > Side1)
                _Side3 = value;
        }
    }

    public int Perimeter()
    {
        if (Side3 != 0)
            return Side1 + Side2 + Side3;
        else return -1;
    }
    public double Area()
    {
        {
            double p = this.Perimeter() / 2;
            return Math.Sqrt(p * (p - Side1) * (p - Side2) * (p - Side3));
        }
    }
}

    class Test
    {
        static void Main(string[] args)
        {
            Triangle triangle = new Triangle();

            Console.Write("Enter Side 1: ");
            triangle.Side1 = int.Parse(Console.ReadLine());

            Console.Write("Enter Side 2: ");
            triangle.Side2 = int.Parse(Console.ReadLine());


            Console.Write("Enter Side 3: ");
            triangle.Side3 = int.Parse(Console.ReadLine());

            if (triangle.Perimeter() == -1)
            {
                Console.WriteLine("It is not valid triangle!");
            }
            else
            {
                Console.WriteLine($"Perimeter of the triangle is {triangle.Perimeter()}");
                Console.WriteLine($"Area of the triangle is {Math.Round(triangle.Area(), 2)}");
            }
        }
    }