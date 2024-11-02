using System.Text;

static void ReverseString()
{
    string x = Console.ReadLine();

    StringBuilder stringBuilder = new StringBuilder();

    for (int i = x.Length - 1; i >= 0; i--)
    { 
        stringBuilder.Append(x[i]);
    }

    string result = stringBuilder.ToString();
    Console.WriteLine(result);
}

ReverseString();