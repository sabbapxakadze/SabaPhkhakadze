public static class MATH
{
    public enum STATUS
    {
        PowMustBeaPositiveOrZero,
        Success,
        ElementsAreEqual
    }
    public static int POW(int num, int power, out STATUS result)
    {
        if (power < 0)
        {
            result = STATUS.PowMustBeaPositiveOrZero;
            return 0;
        }
        else if (power == 0)
        {
            result = STATUS.Success;
            return 1;
        }
        else 
        {
            result = STATUS.Success;
            return num * POW(num, power-1, out result);
        }
    }
    public static int Min(int n1, int n2, out STATUS result)
    {
        if (n1 == n2)
        {
            result = STATUS.ElementsAreEqual;
            return 0;
        }
        else
        {
            result = STATUS.Success;
            return n1 < n2 ? n1 : n2;
        }
    }
    public static int Max(int n1, int n2, out STATUS result)
    {
        if (n1 == n2)
        {
            result = STATUS.ElementsAreEqual;
            return 0;
        }
        else
        {
            result = STATUS.Success;
            return n1 < n2 ? n2 : n1;
        }
    }
}