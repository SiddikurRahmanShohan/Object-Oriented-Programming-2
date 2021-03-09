using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking
{
    class Program
    {
        public static bool AccountMenu(Bank bank, Account account) {
            Console.WriteLine("*****************Welcome, {0}*************", account.AccountName);
            Console.WriteLine("\nType 'diposit' to Make A Diposit");
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
                    Console.Write("\nInput Diposit Amount: ");
                    double amount = Convert.ToDouble(Console.ReadLine());
                    bank.Transaction(tType, amount, account);
                    return true;
                case "withdraw":
                    Console.WriteLine("----------Input Withdrawal Details-----------");
                    tType = 2;
                    Console.Write("\nInput Withdraw Amount: ");
                    amount = Convert.ToDouble(Console.ReadLine());
                    bank.Transaction(tType, amount, account);
                    return true;
                case "transfer":
                    Console.WriteLine("----------Input Transfer Details-----------");
                    tType = 3;
                    Console.Write("Enter the Recivers's Account Number: ");
                    int rAccountNumber = Convert.ToInt32(Console.ReadLine());
                    Console.Write("\nInput Transfer Amount: ");
                    amount = Convert.ToDouble(Console.ReadLine());
                    bank.Transaction(tType, amount, account, rAccountNumber);
                    return true;
                case "show":
                    Console.WriteLine("Do You want to show all accounts? y/n");
                    char r = Convert.ToChar(Console.ReadLine());
                    if (r == 'y')
                    {
                        bank.PrintAccountDetails();
                    }
                    else {
                        account.ShowAccountInformation();
                    }
                    return true;
                case "quit":
                    Console.Clear();
                    return false;
                default:
                    return true;
            }
        }

        public static bool OpenMenu(Bank bank) {
            Console.WriteLine("******************Developer's Bank Colsole Application*************");
            Console.WriteLine("\nType 'savings' to Open a Savings Account");
            Console.WriteLine("Type 'checking' to Open a Checking Account");
            Console.WriteLine("Type 'quit' to Exit");
            Console.Write("\r\nSelect an option: ");
            switch (Console.ReadLine())
            {
                case "savings":
                    Console.WriteLine("----------Input Personal Details for Savings Account-----------\n");
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
                    Console.Write("\nPassword: ");
                    string password = (Console.ReadLine());
                    Console.Write("\nInitial Diposit Amount: ");
                    double balance = Convert.ToDouble(Console.ReadLine());
                    Account account = new SavingsAccount(name, dateOfBirth, balance, password,
                        new Address(houseNo, roadNo, city, country));
                    bank.AddAccount(account);
                    Console.WriteLine("\n----------Account Added----------");
                    bank.PrintAccountDetails();
                    return true;
                case "checking":
                    Console.WriteLine("----------Input Personal Details for Checking Account-----------\n");
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
                    Console.Write("\nPassword: ");
                    password = (Console.ReadLine());
                    Console.Write("\nInitial Diposit Amount: ");
                    balance = Convert.ToDouble(Console.ReadLine());
                    account = new CheckingAccount(name, dateOfBirth, balance, password,
                        new Address(houseNo, roadNo, city, country));
                    bank.AddAccount(account);
                    Console.WriteLine("\n----------Account Added----------");
                    account.ShowAccountInformation();
                    return true;
                case "quit":
                    Console.Clear();
                    return false;
                default:
                    return true;
            }
        }
        public static bool HomeMenu(Bank bank) {
            Console.WriteLine("********************Developer's Bank Colsole Application*************");
            Console.WriteLine("\nType 'open' to Open an Account");
            Console.WriteLine("Type 'account' for Transaction");
            Console.WriteLine("Type 'quit' to Exit");
            Console.Write("\r\nSelect an option: ");

            switch (Console.ReadLine())
            {
                case "open":
                    Console.Clear();
                    bool showOpenMenu = true;
                    while (showOpenMenu)
                    {
                        showOpenMenu = OpenMenu(bank);
                    }
                    return true;
                case "account":
                    Console.Clear();
                    Console.WriteLine("********************Login*************");
                    Console.Write("\nAccount No. ");
                    int accountNo = Convert.ToInt32(Console.ReadLine());
                    Console.Write("\nPassword: ");
                    string password = (Console.ReadLine());
                    bool showAccountMenu = true;
                    Account account = bank.GetUser(accountNo, password);
                    if (account != null)
                    {
                        
                        while (showAccountMenu)
                        {
                            showAccountMenu = AccountMenu(bank, account);
                        }
                    }
                    return true;
                case "quit":
                    return false;
                default:
                    return true;
            }
        }
        static void Main(string[] args)
        {
            Bank bank = new Bank("Developers Bank", 5);
            bool showHomeMenu = true;
            while (showHomeMenu)
            {
                showHomeMenu = HomeMenu(bank);
            }
        }
    }
 }