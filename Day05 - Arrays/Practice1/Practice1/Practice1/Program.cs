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
    Console.Write($"Enter number for inder {i}: ");
    arr[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine("Here is your array:");
for (int i = 0;i < arr.Length;i++)
    Console.WriteLine(arr[i]);