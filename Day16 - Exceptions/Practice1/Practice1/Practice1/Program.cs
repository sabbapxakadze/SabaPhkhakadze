Console.Write("Enter the full name for the first person: ");
User user1 = new User(Console.ReadLine());
Console.Write("Enter the full name for the second person: ");
User user2 = new User(Console.ReadLine());

IBAN iban1 = user1.AddNewAccount();
IBAN iban2 = user2.AddNewAccount();


Console.Write("Enter how much to deposit in the first account: ");
iban1.Deposit(decimal.Parse(Console.ReadLine()));
Console.Write("Enter how much to deposit in the second account: ");
iban2.Deposit(decimal.Parse(Console.ReadLine()));


Console.Write("Enter how much to withdraw in the first account: ");
iban1.Withdraw(decimal.Parse(Console.ReadLine()));
Console.Write("Enter how much to withdraw in the second account: ");
iban2.Withdraw(decimal.Parse(Console.ReadLine()));