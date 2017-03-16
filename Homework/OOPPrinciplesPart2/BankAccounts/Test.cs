
namespace BankAccounts
{
    using System;
    using System.Collections.Generic;
    class Test
    {
        static void Main(string[] args)
        {
            var deacc = new DepositAccount(234234.122m, 21313, Customers.Company);
            var loan = new LoanAccount(234234.122m, 21313, Customers.Individual);
            var loan2 = new LoanAccount(234234.122m, 21313, Customers.Individual);
            var loan3 = new LoanAccount(234234.122m, 21313, Customers.Individual);
            deacc.WithdrawSum(234233.122m);
            Console.WriteLine(deacc.Balance);
            var bank = new Bank("Izgrev", "Pesho");
            bank.AddAccount(deacc);
            bank.AddAccount(loan);
            bank.AddAccount(loan2);
            bank.AddAccount(loan3);
            bank.RemoveAccount(loan);
            foreach (var item in bank.Accounts)
            {
                Console.WriteLine(item);
            }


        }
    }
}
