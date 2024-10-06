using AccountExceptionDemo.Exceptions;
using AccountExceptionDemo.Models;
using AccountExceptionDemo.Services;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace AccountExceptionDemo.Controller
{
    internal class AccountManager
    {
        static List<Account> accounts = new List<Account>();
        public AccountManager()
        {
            accounts = Serialization.Deserialze();

        }
        public string Deposit(int accId, double amount)
        {
            Account account = GetAccount(accId);
            try
            {
                if (account == null)
                {
                    throw new AccountNotFoundException("No such Account Exist");
                }
                return account.DepositAmount(amount);
            }
            catch (AccountNotFoundException e)
            {
                Console.WriteLine(e.Message);
                return "Deposit failed due to account not found.";
            }

        }
        public static Account GetAccount(int accId)
        {
            return accounts.Where(accounts => accounts.AccountId == accId).FirstOrDefault();
        }
        public void Withdraw(int accId, double amount)
        {
            Account account = GetAccount(accId);
            try
            {
                if (account == null)
                    throw new AccountNotFoundException("No such Account Exist");
                account.WithdrawAmount(amount);
            }
            catch (AccountNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (MinimumBalanceException e)
            {
                Console.WriteLine(e.Message);
            }
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
        public void DisplayAccounts()
        {
            try
            {
                if (accounts.Count == 0)
                {
                    throw new ZeroAccountsException("Zero Accounts exist");
                }
                foreach (Account account in accounts)
                {
                    Console.WriteLine(account);
                }
            }
            catch (ZeroAccountsException e)
            {
                Console.WriteLine(e.Message);
            }

        }
        public string SerializeAccount()
        {
            return Serialization.Serialize(accounts);
        }

    }
}
