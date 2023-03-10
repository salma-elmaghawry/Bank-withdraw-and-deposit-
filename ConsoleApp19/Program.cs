
BankAccount myAccount = new BankAccount();
myAccount.BankName = "Deutsche Bank ";
myAccount.BranchName = "Dresden";
myAccount.BranchAddress = "142 Hantstrasses ";
myAccount.AccountNumber = "DE01546";
myAccount.Accountcurrancy = "USD";
myAccount.Balance = 1500;

Console.WriteLine(myAccount.BankName);
Console.WriteLine(myAccount.Balance);

myAccount.deposit(500);
class BankAccount
{
    public string  BankName  { get; set; }
    public string BranchName { get; set; }
    public string BranchAddress  { get; set; }
    public string AccountNumber  { get; set; }
    public string Accountcurrancy  { get; set; }
    public decimal Balance  { get; set; }

    public void withdraw (decimal amount )
    {
        decimal newBalance = Balance - amount;
        if (newBalance < 0)
        {
            Console.WriteLine("Invalid transaction ");
        }
        else
        {
            Console.WriteLine($"withdraw amount is {amount}");
            Console.WriteLine($"your new balance for {AccountNumber} is {newBalance}");
        }
        Console.WriteLine($"Transaction date {DateTime.Now}");
    }
    public void deposit(decimal amount)
    {
        decimal newBalance = Balance + amount;
        Console.WriteLine($"decimal amount is {amount}");
        Console.WriteLine($"your new balance for {AccountNumber} is {newBalance}");
        Console.WriteLine($"Transaction date {DateTime.Now}");
    }
    





}




