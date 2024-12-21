Console.Write("Enter array row size: ");
int x = int.Parse(Console.ReadLine());

while (x <= 0)
{
    Console.Write("Enter a valid row size number: ");
    x = int.Parse(Console.ReadLine());
}

Console.Write("Enter array column size: ");
int y = int.Parse(Console.ReadLine());

while (y <= 0)
{
    Console.Write("Enter a valid column size number: ");
    y = int.Parse(Console.ReadLine());
}

int[,] arr = new int[x, y];

for (int i = 0; i < x; i++)
{
    for (int j = 0; j < y; j++)
    {
        Console.Write($"Enter number for {i},{j}: ");
        arr[i,j] = int.Parse(Console.ReadLine());
    }
}


Console.WriteLine("Here is matrix of your multidimensional array");
for(int i = 0; i < x; i++)
{
    Console.Write("| ");
    for (int j = 0; j < y; j++)
    {
        if (j == y - 1)
            Console.Write($"{arr[i, j]} ");
        else
            Console.Write($"{arr[i, j]}, ");
    }
    Console.Write("|");
    Console.WriteLine();
}