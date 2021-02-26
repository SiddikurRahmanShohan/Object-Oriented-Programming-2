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
        private static bool Menu()
        {
            Console.Clear();
            Console.WriteLine("1) Add new Bank");
            Console.WriteLine("2) Add new Account");
            Console.WriteLine("3) Delete an Account");
            Console.WriteLine("4) Deposit Money");
            Console.WriteLine("5) Withdraw Money");
            Console.WriteLine("6) Transfer Money");
            Console.WriteLine("6) Transfer Money");
            Console.Write("\r\nSelect an option: ");

            switch (Console.ReadLine())
            {
                case "1":
                    Console.Write("Enter Bank Name: ");
                    bank = Console.ReadLine();
                    Console.Write("Enter Account Size: ");
                    aSize = Convert.ToInt32(Console.ReadLine());
                    //Bank ourBank = new Bank(bank, aSize);
                    return true;
                case "2":
                    //ourBank.PrintAccountDetails();
                    return true;
                case "3":
                    return true;
                case "4":
                    return true;
                case "5":
                    return true;
                case "6":
                    return true;
                case "7":
                    return false;
                default:
                    return true;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("*************Welcome to Banking Colsole Application*************\n");
            bool showMenu = true;
            while (showMenu)
            {
                showMenu = Menu();
            }
        }
    }
}
