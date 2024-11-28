public class DebitIBAN : IBAN
{
    public decimal DailyDepositLimit { get; set; }
    public DebitIBAN(decimal limit, string fullName, string ibanNumber, CurrencyCode currency, string bankName)
        : base(fullName, ibanNumber, currency, bankName)
    {
        DailyDepositLimit = limit;
    }
    public override void Deposit(decimal amount)
    {
        if (amount > DailyDepositLimit) throw new DailyDepositExceedException();
        if (amount <= 0) throw new NegativeAmountDepositException();
        Balance += amount;
    }
}