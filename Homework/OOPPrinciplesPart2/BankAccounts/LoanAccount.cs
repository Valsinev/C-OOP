
namespace BankAccounts
{
    public class LoanAccount : Account , IDepositable
    {
        public LoanAccount(decimal CustomerBalance, long InterestRate, Customers Customer)
            : base(CustomerBalance, InterestRate, Customer) { }
        public void DepositSum(decimal money)
        {
            this.customerBalance += money;
        }
        public override long interestForPeriod(int months)
        {
            long result = 0;
            if (customer == Customers.Individual && months < 3)
            {
                result = this.interestRate * (months - 3);
            }
            if (customer == Customers.Company && months < 2)
            {
                result = this.interestRate * (months - 2);
            }
            return result;
        }
    }
}
