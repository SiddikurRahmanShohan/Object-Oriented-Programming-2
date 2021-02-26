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

        public void PrintAccountDetails()
        {
            for(int i=0;i< myBank.Length;i++)
            {
                if (myBank[i] == null)
                {
                    continue;
                }
                myBank[i].ShowAccountInformation();
            }
        }
        public void AddAccount(Account account)
        {
            for (int i = 0; i < myBank.Length; i++)
            {
                if(myBank[i]==null)
                {
                    myBank[i] = account;
                    break;
                }
            }
        }
        
       public void DeleteAccount(int accountNo) { 
            for (int i = 0; i < myBank.Length; i++)
            {
                if (myBank[i] == null)
                {
                    continue;
                }
                else if (myBank[i].AccountNumber == accountNo)
                {
                    myBank[i] = null;
                    for (int j = i; j < (myBank.Length - 1); j++) {
                        myBank[j] = myBank[j + 1];
                    }
                    Console.WriteLine("Account Deleted");
                    break;
                }
                else
                {
                    Console.WriteLine("Account Deleted");

                }
            }
        }
        
    }
}
