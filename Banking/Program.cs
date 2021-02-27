using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*************Welcome to Banking Colsole Application*************");
            Bank bank = new Bank("New Bank", 5);
            Account account1 = new Account("Any1", 5000, new Address("24", "31", "Vegas", "USA"));
            Account account2 = new Account("Any2", 3000, new Address("214", "21", "LA", "USA"));
            Account account3 = new Account("Any3", 2000, new Address("4", "2", "Dhaka", "Bangladesh"));
            Account account4 = new Account("Any4", 2500, new Address("12", "66", "Chittagong", "Bangladesh"));
            Account account5 = new Account("Any5", 8000, new Address("2", "85", "Waterloo", "Canada"));
            bank.AddAccount(account1);
            bank.AddAccount(account2);
            bank.AddAccount(account3);
            bank.AddAccount(account4);
            bank.AddAccount(account5);
            bank.PrintAccountDetails();
            bank.Transaction(1, 500.0);
            Console.WriteLine("\nAfter Depositing 500 in Account no. 3");
            account3.ShowAccountInformation();
            bank.Transaction(2, 200.0);
            Console.WriteLine("\nAfter Withdrawing 200 from Account no. 2");
            account2.ShowAccountInformation();
            bank.Transaction(3, 1000, account3);
            Console.WriteLine("\nAfter Transfering 1000 from Account no. 5 to Account no. 3");
            bank.PrintAccountDetails();
        }
    }
 }