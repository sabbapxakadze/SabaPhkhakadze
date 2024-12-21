public static class MATH
{
    public enum STATUS
    {
        PowMustBeaPositiveOrZero,
        Success,
        ElementsAreEqual
    }
    public static (int x, STATUS result) POW(int num, int power)
    {
        if (power < 0)
        {
            return (0, STATUS.PowMustBeaPositiveOrZero);
        }
        else if (power == 0)
        {
           
            return (1,STATUS.Success);
        }
        else
        {
            return ( num * POW(num, power - 1).x, STATUS.Success);
        }
    }

    public static (int, STATUS) Min(int n1, int n2)
    {
        if (n1 == n2)
        {
            return (0, STATUS.ElementsAreEqual);
        }
        else
        {
            return (n1 < n2 ? n1 : n2, STATUS.Success);
        }
    }
    public static (int, STATUS) Max(int n1, int n2)
    {
        if (n1 == n2)
        {
            return (0, STATUS.ElementsAreEqual);
        }
        else
        {
            return (n1 < n2 ? n2 : n1, STATUS.Success);
        }
    }
}