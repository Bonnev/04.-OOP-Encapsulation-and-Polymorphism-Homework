using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Bank_of_Kurtovo_Konare
{
    class LoanAccount : Account, IDepositable
    {
        public LoanAccount(decimal interestRate, Customer customer, decimal balance) : base(interestRate, customer, balance)
        {
        }

        public void Deposit(decimal amount)
        {
            Balance += amount;
        }

        public override decimal GetInterest(int months)
        {
            if (Customer is IndividualCustomer) return base.GetInterest(months - 3);
            return base.GetInterest(months - 3);
        }   
    }
}
