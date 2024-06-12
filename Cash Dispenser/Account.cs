using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cash_Dispenser
{
    // Factory Method Design Pattern
    public abstract class Account
    {
        public abstract string GetAccountType();
    }

    public class SavingsAccount : Account
    {
        public override string GetAccountType()
        {
            return "Savings Account";
        }
    }

    public class CurrentAccount : Account
    {
        public override string GetAccountType()
        {
            return "Current Account";
        }
    }

    public static class AccountFactory
    {
        public static Account CreateAccount(string accountType)
        {
            switch (accountType.ToLower())
            {
                case "savings":
                    return new SavingsAccount();
                case "current":
                    return new CurrentAccount();
                default:
                    throw new ArgumentException("Unknown account type");
            }
        }
    }
}
