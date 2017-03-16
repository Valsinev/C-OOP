
namespace BankAccounts
{
    using System;
    using System.Collections.Generic;
    public class Bank
    {
        private string name;
        private string owner;
        private List<Account> accounts;

        public Bank(string BankName,string BankOwner)
        {
            this.name = BankName;
            this.owner = BankOwner;
            this.accounts = new List<Account>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }
        }
        public string Owner
        {
            get
            {
                return this.owner;
            }
        }
        public IEnumerable<Account> Accounts
        {
            get
            {
                return this.accounts; 
            }
        }

        public void AddAccount(Account newAccount)
        {
            this.accounts.Add(newAccount);
        }
        public void RemoveAccount(Account accToRemove)
        {
            this.accounts.Remove(accToRemove);
        }
    }
}
