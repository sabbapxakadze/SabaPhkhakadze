using System.Text;

static void AddSpaces(string x)
{
    StringBuilder str = new StringBuilder();

    for (int i = 0; i < x.Length; i++)
    {
        str.Append(x[i]);
        if (i != x.Length-1) str.Append(' ');
    }
    Console.Write(str.ToString());
}

AddSpaces("mevarsaba");