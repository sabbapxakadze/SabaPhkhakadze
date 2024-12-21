int[,] arr = new int[8, 8];


//fill the matrix based on the first picture
for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = i+1; j < arr.GetLength(1); j++)
    {
        arr[i, j] = 1;
    }
}

//print the matrix
for (int i = 0; i < arr.GetLength(0); i++)
{
    Console.Write("| ");
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        Console.Write(arr[i, j] + " ");

    }
    Console.Write("|");
    Console.WriteLine();
}

// now change the elements based on the second picture

for (int i = 0; i < arr.GetLength(0)/2; i++)
{
    for(int j = 0; j < arr.GetLength(1); j++)
    {
        int x = arr.GetLength(0) - 1 - i;
        int v = arr[x, j];
        arr[x, j] = arr[i, j];
        arr[i, j] = v;
    }     
}

// now print changed array
Console.WriteLine("--------------------");
for (int i = 0; i < arr.GetLength(0); i++)
{
    Console.Write("| ");
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        Console.Write(arr[i, j] + " ");

    }
    Console.Write("|");

    Console.WriteLine();
}