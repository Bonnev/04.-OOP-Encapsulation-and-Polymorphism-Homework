using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Bank_of_Kurtovo_Konare
{
    class DepositAccount : Account, IDepositable, IWithdrawable
    {
        public DepositAccount(decimal interestRate, Customer customer, decimal balance) : base(interestRate, customer, balance)
        {
        }

        public void Deposit(decimal amount)
        {
            Balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            Balance -= amount;
        }

        public override decimal GetInterest(int months)
        {
            if (Balance > 0 && Balance < 1000) return 0;
            return base.GetInterest(months);
        }
    }
}
