
namespace BankAccounts
{
    public abstract class Account
    {
        protected Customers customer;
        protected decimal customerBalance;
        public Account(decimal CustomerBalance, long InterestRate,Customers Customer)
        {
            this.customerBalance = CustomerBalance;
            this.interestRate = InterestRate;
            this.customer = Customer;
        }
        public decimal Balance
        {
            get
            {
                return this.customerBalance;
            }
        }
        public long interestRate { get;protected set; }
        public abstract long interestForPeriod(int months);
        

    }
}
