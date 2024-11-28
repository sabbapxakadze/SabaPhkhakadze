public class InsufficientAmountException : Exception 
{ 
    public InsufficientAmountException() : base("Insufficient funds on your account!")
    {
        
    }

    public InsufficientAmountException(string message) : base(message)
    {

    }
}

public class NegativeAmountDepositException : Exception 
{
    public NegativeAmountDepositException() : base("Can not deposit negative number!")
    { 
    
    }
    public NegativeAmountDepositException(string message) : base(message)
    {

    }
}

public class DailyDepositExceedException : Exception
{
    public DailyDepositExceedException() : base("Can not deposit above daily limit!")
    {

    }
    public DailyDepositExceedException(string message) : base(message)
    {

    }
}