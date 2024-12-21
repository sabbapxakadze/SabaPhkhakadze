Console.Write("Enter a number for a floyds triangle: ");

int x = int.Parse(Console.ReadLine());

while (x <= 0)
{
    Console.WriteLine("Ented a valid number for the triangle");
    x = int.Parse(Console.ReadLine());
}

string r = "";


for (int i = 0; i < x; i++)
{
    if (i % 2 == 0) r = 1 + " " + r;
    else r = 0 + " " + r;
    Console.WriteLine(r);
}