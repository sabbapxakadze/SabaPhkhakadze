static bool BalancedBrackets(string str)
{
    Stack<char> round = new Stack<char>();
    Stack<char> curly = new Stack<char>();
    Stack<char> square = new Stack<char>();


    for (int i = 0; i < str.Length; i++)
    {
        if (str[i].Equals('('))
            round.Push(str[i]);

        else if (str[i].Equals('{'))
            curly.Push(str[i]);

        else if (str[i].Equals('['))
            square.Push(str[i]);


        else if (str[i].Equals(')'))
        {
            if (round.Count != 0 && round.Peek().Equals('('))
            round.Pop();
            else round.Push(str[i]);
        }
        else if (str[i].Equals('}'))
        {
            if (curly.Count != 0  && curly.Peek().Equals('{'))
                curly.Pop();
            else curly.Push(str[i]);
        }
        else if (square.Count != 0 && str[i].Equals(']'))
        {
            if (square.Peek().Equals('['))
                square.Pop();
            else square.Push(str[i]);
        }
    }

    return round.Count + curly.Count + square.Count == 0;
}

Console.WriteLine(BalancedBrackets("(){([])}")); // this must be true!
Console.WriteLine(BalancedBrackets("({([])}")); // this must be false!