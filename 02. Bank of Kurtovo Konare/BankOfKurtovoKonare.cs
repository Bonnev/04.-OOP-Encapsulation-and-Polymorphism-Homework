using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Bank_of_Kurtovo_Konare
{
    static class BankOfKurtovoKonare
    {
        static void Main(string[] args)
        {
            IndividualCustomer customer1 = new IndividualCustomer("Ivan");
            DepositAccount account1 = new DepositAccount(4, customer1, 1000);
            account1.Deposit(100);
            account1.Withdraw(400);

            Company customer2 = new Company("NN");
            MortgageAccount account2 = new MortgageAccount(7, customer2, 10000);
            account2.Deposit(1000);

            Account[] accounts = {account1, account2};
            foreach (Account account in accounts)
            {
                Console.WriteLine("{0}: {1} name: {2}, balance: {3}, interest: {4}",
                    account.GetType().Name,
                    account.Customer.GetType().Name,
                    account.Customer.Name,
                    account.Balance,
                    account.GetInterest(24));
            }
        }
    }
}
