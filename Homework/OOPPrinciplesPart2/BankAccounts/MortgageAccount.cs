
namespace BankAccounts
{
    public class MortgageAccount : Account , IDepositable
    {
        public MortgageAccount(decimal CustomerBalance, long InterestRate,Customers Customer)
            : base(CustomerBalance, InterestRate, Customer) { }
        public void DepositSum(decimal money)
        {
            this.customerBalance += money;
        }

        public override long interestForPeriod(int months)
        {
            long result = 0;
            if (customer == Customers.Individual && months < 6)
            {
                result = (this.interestRate * months) / 2;
            }
            else if (customer == Customers.Company && months < 12)
            {
                result = (this.interestRate * months) / 2;
            }
            else
            {
                result = this.interestRate * months;
            }
            return result;
        }
    }
}
