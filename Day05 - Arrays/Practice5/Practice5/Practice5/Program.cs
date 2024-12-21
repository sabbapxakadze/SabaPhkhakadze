Console.Write("Enter your array size: ");

int x = int.Parse(Console.ReadLine());
while (x <= 0)
{
    Console.WriteLine("Enter a valid number");
    x = int.Parse(Console.ReadLine());
}

int[] arr = new int[x];

for (int i = 0; i < x; i++)
{
    Console.Write($"Enter number for index {i}: ");
    arr[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine("Unique elements of your array are: ");

for (int i = 0; i < arr.Length; i++)
{
    bool cond = true;

        for (int j = 0; j < arr.Length; j++)
        {
            if (i == j) 
                continue;
            if (arr[i] == arr[j])
            {
                cond = false;
                break;
            }
        }
    if (cond) Console.WriteLine(arr[i]);
}