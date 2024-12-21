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

Console.Write("Product of array elements is ");
int prod = 1;

for (int i = 0; i < arr.Length; i++)
    prod *= arr[i];

Console.Write(prod);