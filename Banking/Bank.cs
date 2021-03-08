using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking
{
    class Bank
    {
        private string bankName;
        private Account[] myBank;
        public Bank(string name, int size)
        {
            this.bankName = name;
            myBank = new Account[size];
        }
        public string Name
        {
            set { this.bankName = value; }
            get { return this.bankName; }
        }
        public Account[] Accounts
        {
            set { this.myBank = value; }
            get { return this.myBank; }
        }
        public void AddAccount(Account account)
        {
            for (int i = 0; i < myBank.Length; i++)
            {
                if(myBank[i]==null)
                {
                    Console.Write("\nAdding..... ");
                    myBank[i] = account;
                    myBank[i].AccountNumber = i + 1;
                    break;
                }
            }
        }
        
       public void DeleteAccount(int accountNo) {
            int flag = 1;
            for (int i = 0; i < myBank.Length; i++)
            {
                if (myBank[i] == null)
                {
                    continue;
                }
                else if (myBank[i].AccountNumber == accountNo)
                {
                    flag = 0;
                    for (int j = i; j < myBank.Length; j++) {
                        if (j < myBank.Length - 1) { myBank[j] = null; myBank[j] = myBank[j + 1]; }
                        else { myBank[j] = null; }
                    }
                    Console.WriteLine("\nAccount Deleted");
                    break;
                }
            }
            if(flag == 1) { Console.WriteLine("Account Not Found"); }
        }

        public Account GetUser(int accountNo, string password) {
            int flag = 0;
            for (int i = 0; i < myBank.Length; i++)
            {
                if (myBank[i] == null)
                {
                    continue;
                }
                else if (myBank[i].AccountNumber == accountNo && myBank[i].Password == password)
                {
                    flag = 0;
                    return myBank[i];
                }
                else
                {
                    flag = 1;

                }
            }
            if (flag == 1)
            {
                Console.WriteLine("incorect Password");
            }
            return null;
        }

        public void Transaction(int transactionType, double amount,Account account, params int[] accountNumber ) {
            if (transactionType == 1) 
                { account.Diposit(amount); }
            else if (transactionType == 2) 
                { account.Withdraw(amount); }
            else if (transactionType == 3)
                { account.Transfer(myBank[(accountNumber[0] - 1)], amount); }
        }

        public void PrintAccountDetails()
        {
            for (int i = 0; i < myBank.Length; i++)
            {
                if (myBank[i] == null)
                {
                    continue;
                }
                else {
                    myBank[i].ShowAccountInformation();
                }
            }
        }
    }
}
