using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cash_Dispenser
{
    // Strategy Design Pattern
    public interface ITransactionStrategy
    {
        void Execute(ATM atm, int amount = 0);
    }

    public class WithdrawStrategy : ITransactionStrategy
    {
        public void Execute(ATM atm, int amount)
        {
            if (atm.Withdraw(amount))
            {
                Console.WriteLine($"Withdrew {amount}, new balance is {atm.GetBalance()}");
            }
            else
            {
                Console.WriteLine("Insufficient balance");
            }
        }
    }

    public class CheckBalanceStrategy : ITransactionStrategy
    {
        public void Execute(ATM atm, int amount = 0)
        {
            Console.WriteLine($"Current balance is {atm.GetBalance()}");
        }
    }
}
