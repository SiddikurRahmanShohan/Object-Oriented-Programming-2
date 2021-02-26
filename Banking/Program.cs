using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking
{
    class Program
    {
        private static string bank, holder, houseNo, roadNo, city, country;
        private static double amount;
        private static int aSize;
        static void Main(string[] args)
        {
            Console.WriteLine("*************Welcome to Banking Colsole Application*************\n");
            Bank bank = new Bank("New Bank", 5);
            Account account1 = new Account("Any1", 5000, new Address("24", "31", "Vagas", "USA"));
            Account account2 = new Account("Any1", 5000, new Address("24", "31", "Vagas", "USA"));
            Account account3 = new Account("Any1", 5000, new Address("24", "31", "Vagas", "USA"));
            Account account4 = new Account("Any1", 5000, new Address("24", "31", "Vagas", "USA"));
            Account account5 = new Account("Any1", 5000, new Address("24", "31", "Vagas", "USA"));
            bank.AddAccount(account1);
            bank.AddAccount(account2);
            bank.AddAccount(account3);
            bank.AddAccount(account4);
            bank.AddAccount(account5);

        }
    }
 }