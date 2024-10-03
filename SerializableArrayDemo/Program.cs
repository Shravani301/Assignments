namespace SerializableArrayDemo
{
    using SerializableArrayDemo.Models;
    using SerializableArrayDemo.Services;
    using System.Security.Principal;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    internal class Program
    {
        static void Main(string[] args)
        {
            FileService fileService = new FileService();

            List<Account> accounts = fileService.DeserializeAccounts();

            Account account;

            if (accounts.Count > 0)
            {
                account = accounts.First();
            }
            else
            {
                Console.WriteLine("Welcome! Enter details to create a new bank account.");
                account = CreateNewAccount();
                accounts.Add(account);
            }


            bool exit = false;
            while (!exit)
            {
                account = SelectAccount(accounts, account);

                DisplayMenu();
                int choice = Convert.ToInt32(Console.ReadLine());

                exit = ExecuteChoice(choice,accounts, fileService, account);
            }
        }

        private static Account SelectAccount(List<Account> accounts, Account account)
        {
            
            if (accounts.Count > 1)
            {
                DisplayAccounts(accounts);
                Console.WriteLine($"Current account is:{account.AccountId}\nDo you want to switch accounts? (y/n): ");
                char accountChoice = Convert.ToChar(Console.ReadLine());

                if (accountChoice == 'y')
                {
                    Console.WriteLine($"Select Account (1-{accounts.Count}):");
                    int selectedAccount = Convert.ToInt32(Console.ReadLine());
                    return accounts[selectedAccount - 1];
                }
            }
            return account;
        }

        private static void DisplayAccounts(List<Account> accounts)
        {
            for (int i = 0; i < accounts.Count; i++)
            {
                Console.WriteLine($"{i + 1}: {accounts[i]}");
            }
        }

        private static void DisplayMenu()
        {
            Console.WriteLine("\nWhat do you wish to do?");
            Console.WriteLine("1. Create Account\n2. Deposit\n3. Withdraw\n4. Display Balance\n5. Exit");
            Console.Write("Enter your choice: ");
        }

        private static bool ExecuteChoice(int choice, List<Account> accounts, FileService fileService, Account account)
        {
            switch (choice)
            {
                case 1:
                    account = CreateNewAccount();
                    accounts.Add(account);
                    break;
                case 2:
                    Console.Write("Enter amount to deposit: ");
                    double depositAmount = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine(account.Deposit(depositAmount));
                    break;
                case 3:
                    Console.Write("Enter amount to withdraw: ");
                    double withdrawAmount = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine(account.Withdraw(withdrawAmount));
                    break;
                case 4:
                    DisplayBalance(account);
                    break;
                case 5:
                    fileService.SerializeAccounts(accounts);
                    return true;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }

            return false;
        }

        public static Account CreateNewAccount()
        {
            Console.Write("Account Number: ");
            int accountId = Convert.ToInt32(Console.ReadLine());

            Console.Write("Account Holder Name: ");
            string accountHolderName = Console.ReadLine() ?? string.Empty;

            Console.Write("Bank Name: ");
            string bankName = Console.ReadLine() ?? string.Empty;

            Console.Write("Opening Balance: ");
            double openingBalance = Convert.ToDouble(Console.ReadLine());

            Account account = new Account(accountId, accountHolderName, bankName, openingBalance);
            Console.WriteLine("Account created successfully!");
            return account;
        }
        public static void DisplayBalance(Account account)
        {
            Console.WriteLine($"Balance for Account No {account.AccountId}: {account.AccountBalance}");
        }
    }
}
