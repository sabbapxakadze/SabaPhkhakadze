public class CreditIBAN : IBAN
{
    public decimal CreditLimit { get; set; }

    public CreditIBAN(decimal limit, string fullName, string ibanNumber, CurrencyCode currency, string bankName)
        : base(fullName, ibanNumber, currency, bankName)
    {
        CreditLimit = limit;
    }
    public override void Withdraw(decimal amount)
    {
        if (Balance + CreditLimit < amount)
            throw new InsufficientAmountException();
        Balance -= amount;
    }
}