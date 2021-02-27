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
                    Console.WriteLine("Account Deleted");
                    break;
                }
            }
            if(flag == 1) { Console.WriteLine("Account Not Found"); }
        }

        public void Transaction(int transactionType, double amount, params Account[] account ) {
            if (transactionType == 1) 
                { myBank[2].Diposit(amount); }
            else if (transactionType == 2) 
                { myBank[1].Withdraw(amount); }
            else if (transactionType == 3)
                { myBank[4].Transfer(account[0], amount); }
        }

        public void PrintAccountDetails()
        {
            for (int i = 0; i < myBank.Length; i++)
            {
                if (myBank[i] == null)
                {
                    continue;
                }
                myBank[i].ShowAccountInformation();
            }
        }
    }
}
