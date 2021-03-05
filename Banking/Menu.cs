using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking
{
    class Menu
    {
        Bank bank = new Bank("Developers Bank", 5);
        public Menu() {
            bool showHomeMenu = true;
            while (showHomeMenu)
            {
                showHomeMenu = HomeMenu();
            }
        }

        public bool HomeMenu()
        {
            Console.WriteLine("*************Welcome to Banking Colsole Application*************");
            Console.WriteLine("Type 'open' to Open an Account");
            Console.WriteLine("Type 'account' for Transaction");
            Console.WriteLine("Type 'quit' to Exit");
            Console.Write("\r\nSelect an option: ");

            switch (Console.ReadLine())
            {
                case "open":
                    Console.WriteLine("Type 'savings' to Open a Savings Account");
                    Console.WriteLine("Type 'checking' to Open a Checking Account");
                    Console.WriteLine("Type 'quit' to Exit");
                    Console.Write("\r\nSelect an option: ");
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
                            Account account = new SavingsAccount(name, dateOfBirth, balance,
                                new Address(houseNo, roadNo, city, country));
                            bank.AddAccount(account);
                            Console.WriteLine("\n----------Account Added----------");
                            bank.PrintAccountDetails();
                            return true;
                        case "checking":
                            Console.WriteLine("----------Input Personal Details for Checking Account-----------");
                            Console.Write("Name of Account Holder: ");
                            name = (Console.ReadLine());
                            Console.Write("\nDate of Birth: ");
                            dateOfBirth = (Console.ReadLine());
                            Console.Write("\nHouse Number: ");
                            houseNo = (Console.ReadLine());
                            Console.Write("\nRoad Number: ");
                            roadNo = (Console.ReadLine());
                            Console.Write("\nCity: ");
                            city = (Console.ReadLine());
                            Console.Write("\nCounty: ");
                            country = (Console.ReadLine());
                            Console.Write("\nInitial Diposit Amount: ");
                            balance = Convert.ToDouble(Console.ReadLine());
                            account = new CheckingAccount(name, dateOfBirth, balance,
                                new Address(houseNo, roadNo, city, country));
                            bank.AddAccount(account);
                            Console.WriteLine("\n----------Account Added----------");
                            account.ShowAccountInformation();
                            return true;
                        case "quit":
                            Console.Clear();
                            return true;
                    }
                    return true;
                case "account":
                    Console.WriteLine("Type 'diposit' to Make A Diposit");
                    Console.WriteLine("Type 'withdraw' to Make A Withdrawal");
                    Console.WriteLine("Type 'transfer' to Transfer Amount");
                    Console.WriteLine("Type 'show' to View Transaction And Balance");
                    Console.WriteLine("Type 'quit' to exit");
                    Console.Write("\r\nSelect an option: ");
                    switch (Console.ReadLine())
                    {
                        case "diposit":
                            Console.WriteLine("----------Input Diposit Details-----------");
                            int tType = 1;
                            Console.Write("Enter the Account Number: ");
                            int accountNumber = Convert.ToInt32(Console.ReadLine());
                            Console.Write("\nInput Diposit Amount: ");
                            double amount = Convert.ToDouble(Console.ReadLine());
                            bank.Transaction(tType, amount, accountNumber);
                            return true;
                        case "withdraw":
                            Console.WriteLine("----------Input Withdrawal Details-----------");
                            tType = 2;
                            Console.Write("Enter the Account Number: ");
                            accountNumber = Convert.ToInt32(Console.ReadLine());
                            Console.Write("\nInput Diposit Amount: ");
                            amount = Convert.ToDouble(Console.ReadLine());
                            bank.Transaction(tType, amount, accountNumber);
                            return true;
                        case "transfer":
                            Console.WriteLine("----------Input Transfer Details-----------");
                            tType = 3;
                            Console.Write("Enter the Sender's Account Number: ");
                            int sAccountNumber = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Enter the Recivers's Account Number: ");
                            int rAccountNumber = Convert.ToInt32(Console.ReadLine());
                            Console.Write("\nInput Transfer Amount: ");
                            amount = Convert.ToDouble(Console.ReadLine());
                            bank.Transaction(tType, amount, sAccountNumber, rAccountNumber);
                            return true;
                        case "show":
                            Console.Write("Enter the Account Number to Show Details: ");
                            accountNumber = Convert.ToInt32(Console.ReadLine());
                            bank.PrintAccountDetails();
                            return true;
                        case "quit":
                            Console.Clear();
                            return true;
                    }
                    return true;
                case "quit":
                    return false;
                default:
                    return true;
            }
        }
    }
}
