static int[,] Create2DimArr()
{
    Console.Write("Enter a row size: ");
    int row = int.Parse(Console.ReadLine());
    while (row <= 0) 
    {
        Console.Write("Enter a valid row size: ");
    }

    Console.Write("Enter a column size: ");
    int col = int.Parse(Console.ReadLine());
    while (col <= 0)
    {
        Console.Write("Enter a valid column size: ");
    }
    Console.WriteLine("======================================");



    int[,] arr1 = new int[row, col];

    for (int i = 0; i < arr1.GetLength(0); i++)
    {
        for (int j = 0; j < arr1.GetLength(1); j++)
        {
            Console.Write($"Enter a number for {i},{j} index: ");
            arr1[i, j] = int.Parse(Console.ReadLine());
        }
    }
    Console.WriteLine("======================================");
    return arr1;

}


static int[,] SumOfArrays(int[,] arr1, int[,] arr2)
{
    for (int i = 0;i < arr1.GetLength(0);i++)
    {
        for (int j = 0;j < arr1.GetLength(1);j++)
        {
            arr1[i, j] += arr2[i, j];
        }
    }
    return arr1;
}

static void PrintTheMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j == matrix.GetLength(1) - 1)
                Console.Write(matrix[i,j]);
            else Console.Write($"{matrix[i,j]}, ");
        }
        Console.WriteLine();
    }
}

PrintTheMatrix(SumOfArrays(Create2DimArr(), Create2DimArr()));