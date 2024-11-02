using System.Text;


static bool IsVowel(char a)
{
    switch (a)
    {
        case 'a': return true;
        case 'A': return true;
        case 'e': return true;
        case 'E': return true;
        case 'i': return true;
        case 'I': return true;
        case 'o': return true;
        case 'O': return true;
        case 'u': return true;
        case 'U': return true;
        default: return false;
    }
}

static void VowelFunction()
{
    string x = Console.ReadLine();
    
    int cnt = 0;

    StringBuilder str = new StringBuilder();
    for (int i = 0; i < x.Length; i++)
    {
        if (IsVowel(x[i]))
        {
            str.Append(x[i] + " ");
            cnt++;
        }  
    }
    string result = str.ToString(); 
    Console.WriteLine($"Vowel count is {cnt}");
    Console.WriteLine($"Vowel: {result}");
}



static void ConsonantFunction()
{
    string x = Console.ReadLine();

    int cnt = 0;

    StringBuilder str = new StringBuilder();
    for (int i = 0; i < x.Length; i++)
    {
        if (!IsVowel(x[i]))
        {
            str.Append(x[i] + " ");
            cnt++;
        }
    }
    string result = str.ToString();
    Console.WriteLine($"Consonant count is {cnt}");
    Console.WriteLine($"Consonant: {result}");
}

VowelFunction();

ConsonantFunction();