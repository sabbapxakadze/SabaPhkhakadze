static bool BalancedBrackets(string str)
{ 
    Stack<char> stack = new Stack<char>();

    foreach (char c in str)
    {
        if (c.Equals('(') || c.Equals('[') || c.Equals('{'))
            stack.Push(c);
        else if 
            (stack.Count != 0 && (
            ((c.Equals(')') && stack.Peek().Equals('(')))
            ||
            ((c.Equals(']') && stack.Peek().Equals('[')))
            ||
            ((c.Equals('}') && stack.Peek().Equals('{')))
            ))
            stack.Pop();
        
        else
            return false;
    }

    return stack.Count == 0;
}

Console.WriteLine(BalancedBrackets("(){([])}")); // this must be true!
Console.WriteLine(BalancedBrackets("({([])}")); // this must be false!
Console.WriteLine(BalancedBrackets("([)]"));