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

Console.Write("Here is the sum of your array: ");
int sum = 0;
for (int i = 0; i < arr.Length; i++)
    sum += arr[i];

Console.Write(sum);