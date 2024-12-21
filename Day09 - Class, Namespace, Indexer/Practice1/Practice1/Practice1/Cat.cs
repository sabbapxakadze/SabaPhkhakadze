class Cat
{
    string _Name;
    public string Name
    {
        get
        {
            return _Name;
        }
        set
        {
            _Name = value;
        }
    }
    string _Breed;

    public string Breed
    {
        get
        {
            return _Breed;
        }
        set
        {
            _Breed = value;
        }
    }

    public int _Age { get; set; }
    public string _Gender { get; set; }
    int canEatGram = 10;

    public void Meow()
    {
        Console.WriteLine("meowing..");
    }

    public void Eat(int grams)
    {
        Console.WriteLine($"{this.Name} starts eating...");
        while (grams > 0)
        {
            Console.WriteLine("Eating ...");
            grams -= canEatGram;
        }
    }
}

class test
{
    static void Main(string[] args)
    {
        Console.WriteLine("Creating Cat Object...");
        Cat cat = new Cat();
        Console.Write("Enter name: ");
        cat.Name = Console.ReadLine();

        Console.Write("Enter breed: ");
        cat.Breed = Console.ReadLine();

        Console.Write("Enter age: ");
        cat._Age = int.Parse(Console.ReadLine());

        Console.Write("Enter sex: ");
        cat._Gender = Console.ReadLine();

        Console.Write("Enter a food weight in grams: ");
        cat.Eat(int.Parse(Console.ReadLine()));

        Console.Write("Enter a meow count: ");

        for (int i = int.Parse(Console.ReadLine())-1; i >= 0; i--)
            cat.Meow();       
    }
}