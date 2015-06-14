using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Bank_of_Kurtovo_Konare
{
    class MortgageAccount : Account, IDepositable
    {
        public MortgageAccount(decimal interestRate, Customer customer, decimal balance) : base(interestRate, customer, balance)
        {
        }

        public void Deposit(decimal amount)
        {
            Balance += amount;
        }

        public override decimal GetInterest(int months)
        {
            if (Customer is IndividualCustomer) return base.GetInterest(months-6);
            decimal interest = 0.5m*base.GetInterest(12);
            if (months > 12) interest += base.GetInterest(months - 12);
            return interest;
        }
    }
}
