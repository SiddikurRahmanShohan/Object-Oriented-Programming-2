using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking
{
    class CheckingAccount: Account
    {
        private int transaction = 0;
        public CheckingAccount(string accountName, string dateOfBirth, double balance, Address address):
            base(accountName, dateOfBirth, balance, address)
        {     
        }
        public int Transaction
        {
            get { return this.transaction; }
            set { this.transaction = value; }
        }
        /*override public int AccountNumber
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
        }*/

        override public void Diposit(double amount)
        {
            double newBalance = this.balance + amount;
            this.balance = newBalance;
            int newTransaction = this.transaction + 1;
            this.transaction = newTransaction;
            Console.WriteLine("\n-----------Diposit Successful-----------");
            Console.WriteLine("\nTransaction no.: " + this.transaction);
            Console.WriteLine("\nNew Balance: " + this.balance);
        }

        override public void Withdraw(double amount)
        {
            if (amount <= this.balance && this.balance > 0.0)
            {
                double newBalance = this.balance - amount;
                this.balance = newBalance;
                int newTransaction = this.transaction + 1;
                this.transaction = newTransaction;
                Console.WriteLine("\n-----------Withdrawal Successful-----------");
                Console.WriteLine("\nTransaction no.: " + this.transaction);
                Console.WriteLine("\nNew Balance: " + this.balance);
            }
            else if (this.balance == 0.0) {
                Console.WriteLine("\nYour Balance is " + this.balance);
            }
            else
            {
                Console.WriteLine("\nYou Can not Withdraw an Amount of " + amount);
                Console.WriteLine("\nBalance: " + this.balance);
            }
        }

        override public void Transfer(Account reciver, double amount)
        {
            if (this.balance >= amount && this.balance > 0.0)
            {
                reciver.Diposit(amount);
                this.Withdraw(amount);
                Console.WriteLine("\n-----------Transfer Successful-----------");
                Console.WriteLine("\nTransaction no.: " + this.transaction);
                Console.WriteLine("\nNew Balance: " + this.balance);
            }
            else if (this.balance == 0.0)
            {
                Console.WriteLine("\nYour Balance is " + this.balance);
            }
            else
            {
                Console.WriteLine("\nYou Can not Transfer an Amount of " + amount);
                Console.WriteLine("\nBalance: " + this.balance);
            }
        }
        override public void ShowAccountInformation()
        {
            Console.WriteLine("\nAccount No:{0}\nAccount Name:{1}\nDate Of Birth:{2}\nBalance:{3}\nNo of Transaction:{4}\nAddress:{5}",
                this.accountNumber, this.accountName, this.dateOfBirth, this.balance, this.transaction, this.address.GetAddress());
        }
    }
}
