using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cash_Dispenser
{
    // Singleton Design Pattern
    public class ATM
    {
        private static ATM _instance;
        private int _balance;

        private ATM()
        {
            _balance = 1000; // Startbalans
        }

        public static ATM Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ATM();
                }
                return _instance;
            }
        }

        public int GetBalance()
        {
            return _balance;
        }

        public bool Withdraw(int amount)
        {
            if (amount <= _balance)
            {
                _balance -= amount;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
