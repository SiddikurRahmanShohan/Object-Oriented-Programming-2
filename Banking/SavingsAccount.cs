using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking
{
    class SavingsAccount: Account
    {
        public SavingsAccount(string accountName, string dateOfBirth, double balance, Address address):
            base(accountName, dateOfBirth, balance, address)
        {
        }
       override public int AccountNumber
        {
            get { return this.accountNumber; }
            set { this.accountNumber = value; }
        }
        override public string AccountName
        {
            get { return this.accountName; }
            set { this.accountName = value; }
        }

        override public string DateOfBirth
        {
            get { return this.dateOfBirth; }
            set { this.dateOfBirth = value; }
        }
        override public double Balance
        {
            get { return this.balance; }
            set { this.balance = value; }
        }

        override public Address Address
        {
            get { return this.address; }
            set { this.address = value; }
        }

        override public void Diposit(double amount)
        {
            double newBalance = this.balance + amount;
            this.balance = newBalance;
            Console.WriteLine("\n-----------Diposit Successful-----------");
            Console.WriteLine("\nNew Balance: " + this.balance);
        }

        override public void Withdraw(double amount)
        {
            if (amount < this.balance)
            {
                double newBalance = this.balance - amount;
                this.balance = newBalance;
                Console.WriteLine("\n-----------Withdrawal Successful-----------");
                Console.WriteLine("\nNew Balance: " + this.balance);
            }
            else {
                Console.WriteLine("\nYou Can not Withdraw an Amount of " + amount);
                Console.WriteLine("\nBalance: " + this.balance);
            }
        }

        override public void Transfer(Account reciver, double amount)
        {
            if (this.balance > amount)
            {
                reciver.Diposit(amount);
                this.Withdraw(amount);
                Console.WriteLine("\n-----------Transfer Successful-----------");
                Console.WriteLine("\nNew Balance: " + this.balance);
            }
            else
            {
                Console.WriteLine("\nYou Can not Transfer an Amount of " + amount);
                Console.WriteLine("\nBalance: " + this.balance);
            }
        }
        override public void ShowAccountInformation()
        {
            Console.WriteLine("\nAccount No:{0}\nAccount Name:{1}\nDate Of Birth:{2}\nBalance:{3}\nAddress:{4}",
                this.accountNumber, this.accountName, this.dateOfBirth, this.balance, this.address.GetAddress());
        }
    }
}
