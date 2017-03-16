
namespace BankAccounts
{
    using System;
    public class DepositAccount : Account , IDepositable ,IWithdrawable
    {
        public DepositAccount(decimal CustomerBalance, long InterestRate,Customers Customer)
            : base(CustomerBalance, InterestRate, Customer) { }
        
        public void DepositSum(decimal money)
        {
            this.customerBalance += money;
        }
        public void WithdrawSum(decimal money)
        {
            if (this.customerBalance - money < 0)
            {
                Console.WriteLine("You don't have the sum in your account!");
            }
            else
            {
                this.customerBalance -= money;
            }
        }
        public override long interestForPeriod(int months)
        {
            long interest = 0;
            if (this.Balance < 1000)
            {
                interest = 0;
            }
            else
            {
                interest = this.interestRate * months;
            }
            return interest;
        }
    }
}
