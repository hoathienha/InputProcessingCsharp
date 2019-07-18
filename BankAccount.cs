using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_8
{
    class BankAccount
    {
        private decimal _balance;

        public BankAccount()
        {
            _balance = 0m;
        }

        public BankAccount(decimal val)
        {
            _balance = val;
        }

        public decimal Balance
        {
            get { return _balance; }
        }

        public void Deposit(decimal depo)
        {
            _balance += depo;
        }

        public void Withdraw(decimal wit)
        {
            _balance -= wit;
        }
    }
}
