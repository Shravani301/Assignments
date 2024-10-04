using AccountsDemo.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountsDemo.Presentation
{
    internal class AccountStore
    {
        static AccountManager manager=new AccountManager();
        public static void DisplayMenu()
        {
            while (true)
            {
                Console.WriteLine("Enter your Choice");
                Console.WriteLine("1. Create account\n" +
                    "2. Deposit\n" +
                    "3. Withdraw\n" +
                    "4. Display Account Details\n" +
                    "5. Exit");
                int choice = Convert.ToInt32(Console.ReadLine());
                DoTask(choice);
            }
        }
        public static void DoTask(int choice)
        {
            switch (choice)
            {
                case 1:
                    CreateAccount();
                    break;
                case 2:
                    DepositMoney();
                    break;
                case 3:
                    WithdrawMoney();
                    break;
                case 4:
                    ShowDetails();
                    break;
                case 5:
                    manager.SerializeAccount();
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Enter correct choice");
                    break;
            }
        }
        public static void CreateAccount()
        {
            Console.WriteLine("Enter your Account Number");
            int accId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Account Holder Name");
            string name= Console.ReadLine();
            Console.WriteLine("Enter Bank Name");
            string bankName= Console.ReadLine();
            Console.WriteLine("Enter Openeing Balance");
            double amount= Convert.ToDouble(Console.ReadLine());
            manager.Create(accId, name, bankName, amount);
        }

        public static void DepositMoney()
        {
            Console.WriteLine("Enter account number");
            int id= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter amount");
            double amount=Convert.ToDouble(Console.ReadLine());
            manager.Deposit(id,amount); 

        }
        public static void WithdrawMoney()
        {
            Console.WriteLine("Enter account number");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter amount");
            double amount = Convert.ToDouble(Console.ReadLine());
            manager.Withdraw(id,amount);
        }
        public static void ShowDetails()
        {
            Console.WriteLine("Enter Account Number");
            int id=Convert.ToInt32(Console.ReadLine());
            manager.Print(id);
        }
        
       


    }
}
