using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Bank_of_Kurtovo_Konare
{
    internal abstract class Account
    {
        public readonly decimal InterestRate;
        public readonly Customer Customer;

        public decimal Balance { get; set; }

        protected Account(decimal interestRate, Customer customer, decimal balance)
        {
            InterestRate = interestRate;
            Customer = customer;
            Balance = balance;
        }

        public virtual decimal GetInterest(int months)
        {
            if (months <= 0) return 0;
            return Balance*(1 + InterestRate/100*months);
        }
    }
}
