void PowerOfNum(int num, int deg, int acc = 1)
{
    if (deg == 0) Console.WriteLine(1);
    else if (deg < 0) PowerOfNum(1 / num, -deg);
    else if (deg == 1) Console.WriteLine(acc*num);
    else PowerOfNum(num, deg - 1, acc*num);
}

PowerOfNum(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));