using AccountsDemo.Models;
using AccountsDemo.Presentation;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace AccountsDemo.Controller
{

    internal class AccountManager
    {
        static List<Account> accounts = new List<Account>();
        static string FilePath = ConfigurationManager.AppSettings["myFile"];
        public AccountManager() 
        {
            if (File.Exists(FilePath))
            {
                var jsonData = File.ReadAllText(FilePath);
                accounts = JsonSerializer.Deserialize<List<Account>>(jsonData);
            }
            
        }
        public string Deposit(int accId, double amount)
        { 
            Account account=GetAccount(accId);
            if (account != null)
                return account.DepositAmount(amount);
            return "No Such Account exist";
            
        }
        public static Account GetAccount(int accId)
        {
            return accounts.Where(accounts => accounts.AccountId == accId).FirstOrDefault();
        }
        public string Withdraw(int accId, double amount)
        {
            Account account = GetAccount(accId);
            if (account != null)
                return account.WithdrawAmount(amount);
            return "No Such Account exist";
        }

        public void Create(int accId, string name, string bankName, double openingBalance)
        {
            accounts.Add(new Account(accId, name, bankName, openingBalance));
        }

        public void Print(int accId)
        {
            Account account = GetAccount(accId);
            if (account != null)
            {
                Console.WriteLine(account);            
            }
            
        }
        public string SerializeAccount()
        {
            using (StreamWriter sw = new StreamWriter(FilePath))
            {
                sw.WriteLine(JsonSerializer.Serialize(accounts));
                return "Accounts saved Successfully!";
            }

        }

    }
}
