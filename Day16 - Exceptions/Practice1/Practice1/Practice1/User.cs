public class User
{
    public string FullName { get; set; }
    public List<IBAN> accounts { get; set; } = new List<IBAN>();
    public User(string fullName)
    {
        this.FullName = fullName;
    }
    public IBAN AddNewAccount()
    {
        Console.Write($"Creating new IBAN for {FullName}. For credit card type C, for debit card type D: ");
        char res = char.Parse(Console.ReadLine());
        string res1 = res.ToString().ToLower();

        IBAN iban;
        IBAN.CurrencyCode currency = IBAN.CurrencyCode.USD;
        decimal limit;

        Console.Write("Choose desired currency USD,GEL,GBP,EUR: ");
        string curr = Console.ReadLine().ToLower();

        while (curr != "usd" && curr != "gel" && curr != "gbp" && curr != "eur")
        {
            Console.Write("Please give correct input for currency: ");
                curr = Console.ReadLine().ToLower();
        }
        switch (curr)
        {
            case "usd": 
                currency = IBAN.CurrencyCode.USD;
                break;
            case "gel":
                currency= IBAN.CurrencyCode.GEL;
                break;
            case "gbp":
                currency = IBAN.CurrencyCode.GBP;
                break;
            case "eur":
                currency = IBAN.CurrencyCode.EUR;
                break;
        }

        while (res1 != "c" && res1 != "d")
        {
            Console.WriteLine("Type as mentioned, C or D");
            res = char.Parse(Console.ReadLine());
            res1 = res.ToString().ToLower();
        }
        if (res1 == "d")
        {
            Console.Write("Enter your daily limit: ");
            limit = decimal.Parse(Console.ReadLine());

            int hs = FullName.GetHashCode();
            hs = hs < 0 ? -hs : hs;
            string iNumber = hs.ToString();

            iban = new CreditIBAN(limit, FullName, iNumber, currency, "TBC");
            accounts.Add(iban);
        }
        else
        {
            Console.Write("Enter your credit limit: ");
            limit = decimal.Parse(Console.ReadLine());
            int hs = FullName.GetHashCode();
            hs = hs < 0 ? -hs : hs;
            string iNumber = hs.ToString();

            iban = new DebitIBAN(limit, FullName, iNumber, currency, "TBC");
            accounts.Add(iban);
        }
        Console.WriteLine($"Created a new IBAN for {iban.FullName} with Number {iban.IBANNumber} with limit {limit} in the {iban.BankName} Bank with Currency {iban.Currency}");
        Console.WriteLine("---------------------------------------------------------------------------------------");
        return iban;
    }
}