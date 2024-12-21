using System.Text;


static bool IsVowelFunc(char a)
{
    switch (char.ToLower(a))
    {
        case 'a': return true;
        case 'e': return true;
        case 'i': return true;
        case 'o': return true;
        case 'u': return true;
        default: return false;
    }
}

static void VowelOrConsonantCounter(bool isVowel = true)
{
    string or = isVowel ? "Vowel" : "Consonant";
    Console.Write($"Enter a string to count {or}s: ");
    //default would be true
    string x = Console.ReadLine();
    
    int cnt = 0;

    if (isVowel)
    for (int i = 0; i < x.Length; i++)
    {
        if (IsVowelFunc(x[i]))
        {
            cnt++;
        }  
    }

    else
    for (int i = 0; i < x.Length; i++)
    {
        if (!IsVowelFunc(x[i]))
        {
            cnt++;
        }
    }    

    Console.WriteLine($"{or} count is {cnt}");
}


static void VowelOrConsonantString(bool isVowel = true)
{

    string or = isVowel ? "Vowel" : "Consonant";
    Console.Write($"Enter a string to count {or}s: ");
    //default would be true
    string x = Console.ReadLine();

    StringBuilder str = new StringBuilder();
    if (isVowel)
        for (int i = 0; i < x.Length; i++)
        {
            if (IsVowelFunc(x[i]))
            {
                str.Append(x[i] + " ");             
            }
        }

    else
        for (int i = 0; i < x.Length; i++)
        {
            if (!IsVowelFunc(x[i]))
            {
                str.Append(x[i] + " ");              
            }
        }
    string result = str.ToString();

    Console.WriteLine($"{or}: {result}");
}

VowelOrConsonantCounter();

VowelOrConsonantString();