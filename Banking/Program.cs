using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking
{
    class Program
    {
        public static bool OpenMenu() {
            Console.WriteLine("Type 'savings' to Open a Savings Account");
            Console.WriteLine("Type 'checking' to Open a Checking Account");
            Console.WriteLine("Type 'quit' to Exit");
            Console.Write("\r\nSelect an option: ");
            Bank bank = new Bank("Developers Bank", 5);
            switch (Console.ReadLine())
            {
                case "savings":
                    Console.WriteLine("----------Input Personal Details for Savings Account-----------");
                    Console.Write("Name of Account Holder: ");
                    string name = (Console.ReadLine());
                    Console.Write("\nDate of Birth: ");
                    string dateOfBirth = (Console.ReadLine());
                    Console.Write("\nHouse Number: ");
                    string houseNo = (Console.ReadLine());
                    Console.Write("\nRoad Number: ");
                    string roadNo = (Console.ReadLine());
                    Console.Write("\nCity: ");
                    string city = (Console.ReadLine());
                    Console.Write("\nCounty: ");
                    string country = (Console.ReadLine());
                    Console.Write("\nInitial Diposit Amount: ");
                    double balance = Convert.ToDouble(Console.ReadLine());
                    Account account = new Account(name, dateOfBirth, balance,
                        new Address(houseNo, roadNo, city, country));
                    bank.AddAccount(account);
                    Console.WriteLine("\n----------Account Added----------");
                    account.ShowAccountInformation();
                    return true;
                case "checking":
                    return true;
                case "quit":
                    return false;
                default:
                    return true;
            }
        }
        public static bool HomeMenu() {
            //Console.Clear();
            Console.WriteLine("Type 'open' to Open an Account");
            Console.WriteLine("Type 'account' for Transaction");
            Console.WriteLine("Type 'quit' to Exit");
            Console.Write("\r\nSelect an option: ");
            switch (Console.ReadLine()) 
                {
                case "open":
                    bool showOpenMenu = true;
                    while (showOpenMenu) {
                        showOpenMenu = OpenMenu();
                    }
                return true;
                case "account":
                    
                return true;
                case "quit":

                    return false;
                default:
                    return true;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("*************Welcome to Banking Colsole Application*************");
            bool showHomeMenu = true;
            while (showHomeMenu)
            {
                showHomeMenu = HomeMenu();
            }
           /* bank.Transaction(1, 500.0);
            Console.WriteLine("\nAfter Depositing 500 in Account no. 3");
            account3.ShowAccountInformation();
            bank.Transaction(2, 200.0);
            Console.WriteLine("\nAfter Withdrawing 200 from Account no. 2");
            account2.ShowAccountInformation();
            bank.Transaction(3, 1000, account3);
            Console.WriteLine("\nAfter Transfering 1000 from Account no. 5 to Account no. 3");
            account3.ShowAccountInformation();
            account5.ShowAccountInformation();
            bank.DeleteAccount(3);
            Console.WriteLine("\nAfter Deleting Account no. 3");
            bank.PrintAccountDetails();*/
        }
    }
 }