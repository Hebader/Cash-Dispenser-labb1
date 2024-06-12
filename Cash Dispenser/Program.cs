using Cash_Dispenser;
using System.Security.Principal;

class Program
{
    static void Main()
    {
        ATM atm = ATM.Instance;

        // Factory Method, (skapar ett konto av typen savings)
        Account account = AccountFactory.CreateAccount("savings");
        Console.WriteLine($"Created account of type: {account.GetAccountType()}");

        // Strategy Method, (drar 100 från sadlot)
        ITransactionStrategy strategy = new WithdrawStrategy();
        strategy.Execute(atm, 100);
        

        //Hämtar nuvarande saldot
        strategy = new CheckBalanceStrategy();
        strategy.Execute(atm);
    }
}