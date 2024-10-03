using System.Text.Json;
using System.Text.Json.Serialization;

namespace SerializeDemo
{
    internal class Program
    {
        static string filePath = "accountData.json";

            static void Main(string[] args)
            {
                Account account;

                if (File.Exists(filePath))
                {
                    var jsonData = File.ReadAllText(filePath);
                    account = JsonSerializer.Deserialize<Account>(jsonData);
                    Console.WriteLine("Welcome Back!");
                    Console.WriteLine($"Account Balance is: {account.AccountBalance}");
                }
                else
                {
                    account = CreateNewAccount();
                }

                bool exit = false;
                while (!exit)
                {
                    Console.WriteLine("\nWhat do you wish to do? \n" +
                        "1. Deposit \n 2. Withdraw \n 3. Display Balance\n 4. Exit ");
                   Console.Write("Enter your choice: ");
                    int choice = Convert.ToInt32(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                        {
                            Console.Write("Enter amount to deposit: ");
                            double amount = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine(account.Deposit(amount));
                            break;
                        }
                            
                        case 2:
                        {
                            Console.Write("Enter amount to withdraw: ");
                            double amount = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine(account.Withdraw(amount));
                            break;
                        }
                            
                        case 3:
                        Console.WriteLine($"Balance for AccNo {account.AccountId} is:" +
                            $" {account.AccountBalance}");
                        break;
                        case 4:
                            {
                            var jsonAccount = JsonSerializer.Serialize(account);
                            File.WriteAllText(filePath, jsonAccount);
                            Console.WriteLine("Account data saved successfully!");
                            exit = true;
                            break;
                        }
                            
                        default:
                            Console.WriteLine("Invalid choice. Please try again.");
                            break;
                    }
                }
            }

            static Account CreateNewAccount()
            {
                Console.WriteLine("Welcome! Enter Account Details to create a new Account:");
                Console.Write("Account Number: ");
                int accountId = Convert.ToInt32(Console.ReadLine());
                Console.Write("AccName: ");
                string accountHolderName = Console.ReadLine()??string.Empty;
                Console.Write("BankName: ");
                string bankName = Console.ReadLine()??string.Empty;
                Console.Write("Opening Balance: ");
                double openingBalance = Convert.ToDouble(Console.ReadLine());

                Account account = new Account(accountId, accountHolderName, bankName, openingBalance);
                Console.WriteLine("Account created successfully!");

                return account;
            }
        }
    }

