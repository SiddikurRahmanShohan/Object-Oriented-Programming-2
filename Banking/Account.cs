using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking
{
    class Account
    {
        private int accountNumber = 0;
        private string accountName;
        private double balance;
        private Address address;

        public Account(string accountName, double balance, Address address)
        {
            this.accountName = accountName;
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

        public void Diposit(double amount) {
            double newBalance = this.balance + amount;
            this.balance = newBalance;
        }

        public void Withdraw(double amount)
        {
            if(amount > 0.0)
            {
                double newBalance = this.balance - amount;
                this.balance = newBalance;
            }
        }

        public void Transfer(Account reciver, double amount)
        {
            if (this.balance > amount)
            {
                reciver.Diposit(amount);
                this.Withdraw(amount);
            }
        }
        public void ShowAccountInformation()
        {
            Console.WriteLine("\nAccount No:{0}\nAccount Name:{1}\nBalance:{2}\nAddress:{3}",
                this.accountNumber, this.accountName, this.balance, this.address.GetAddress());
        }
    }
}
