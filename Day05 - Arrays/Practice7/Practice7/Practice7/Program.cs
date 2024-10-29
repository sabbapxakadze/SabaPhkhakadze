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

int[,] arr1 = new int[x, y];
int[,] arr2 = new int[x, y];
//filling in the arr1
Console.WriteLine("Fill in the first matrix: ");
for (int i = 0; i < x; i++)
{
    for (int j = 0; j < y; j++)
    {
        Console.Write($"Enter number for {i},{j}: ");
        arr1[i, j] = int.Parse(Console.ReadLine());
    }
}

//filling in the arr2
Console.WriteLine("Fill in the second matrix: ");
for (int i = 0; i < x; i++)
{
    for (int j = 0; j < y; j++)
    {
        Console.Write($"Enter number for {i},{j}: ");
        arr2[i, j] = int.Parse(Console.ReadLine());
    }
}

int[,] res = new int[x, y]; 
//adding and filling the result matrix
for (int i = 0; i < x; i++)
{
    for (int j = 0; j < y; j++)
    {
        res[i,j] = arr1[i,j] + arr2[i,j];
    }
}


Console.WriteLine("Here is the sum of your matrices: ");
for (int i = 0; i < x; i++)
{
    Console.Write("| ");
    for (int j = 0; j < y; j++)
    {
        if (j == y - 1)
            Console.Write($"{res[i, j]} ");
        else
            Console.Write($"{res[i, j]}, ");
    }
    Console.Write("|");
    Console.WriteLine();
}