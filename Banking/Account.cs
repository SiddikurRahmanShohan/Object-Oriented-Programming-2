using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking
{
    abstract class Account
    {
        protected int accountNumber = 0;
        protected string accountName;
        protected string dateOfBirth;
        protected double balance;
        protected Address address;
        //private static int count = 1000;

        public Account()
        {
        }
        public Account(string accountName, string dateOfBirth, double balance, Address address)
        {
            this.accountName = accountName;
            this.dateOfBirth = dateOfBirth;
            this.balance = balance;
            this.address = address;
        }

        public int AccountNumber
        {
            get { return this.accountNumber; }
            set { this.accountNumber = value; }
        }
        public string AccountName
        {
            get { return this.accountName; }
            set { this.accountName = value; }
        }

        public string DateOfBirth
        {
            get { return this.dateOfBirth; }
            set { this.dateOfBirth = value; }
        }
        public double Balance
        {
            get { return this.balance; }
            set { this.balance = value; }
        }
        public Address Address
        {
            get { return this.address; }
            set { this.address = value; }
        }

        abstract public void Diposit(double amount);

        abstract public void Withdraw(double amount);

        abstract public void Transfer(Account reciver, double amount);
        abstract public void ShowAccountInformation();
    }
}
