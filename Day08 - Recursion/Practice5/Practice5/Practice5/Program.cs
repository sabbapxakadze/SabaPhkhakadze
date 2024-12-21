void IsPalindrome(string str)
{
    if (str.Length <= 1) Console.WriteLine("Is Palindrome? True");
    
    else if (str[0].Equals(str[str.Length - 1])) IsPalindrome(str.Substring(1, str.Length - 2));
    
    else Console.WriteLine("Is Palindrome? False");
}

IsPalindrome(Console.ReadLine());