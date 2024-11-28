public abstract class IBAN
{
    public enum CurrencyCode
    {
        EUR,
        USD,
        GEL,
        BTC,
        JPY,
        GBP
    }
    public string FullName { get; set; }
    public string IBANNumber { get; set; }
    public decimal Balance { get; set; } = 0;
    public CurrencyCode Currency { get; set; }
    public string BankName { get; set; }
    public IBAN(string fullName, string ibanNumber, CurrencyCode currency, string bankName)
    {
        FullName = fullName;
        IBANNumber = ibanNumber;
        Currency = currency;
        BankName = bankName;
    }

    public virtual void Deposit(decimal amount)
    {
        if (amount <= 0) throw new NegativeAmountDepositException();
        Balance += amount;
    }
    public virtual void Withdraw(decimal amount)
    {
        if (Balance < amount) throw new InsufficientAmountException();
        Balance -= amount;
    }
}