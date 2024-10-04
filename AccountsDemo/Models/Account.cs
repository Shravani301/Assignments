using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountsDemo.Models
{
    internal class Account
    {
        public int AccountId { get; set; }
        public string AccountHolderName { get; set; }
        public string BankName { get; set; }
        public double AccountBalance { get; set; }
        public const int MINIMUM_BALANCE = 500;

        public Account() { }
        public Account(int accountId, string accountHolderName, string bankName) 
        {
            AccountId = accountId;
            AccountHolderName = accountHolderName;
            BankName = bankName;
            AccountBalance =MINIMUM_BALANCE;
        }
        public Account(int accountId, string accountHolderName, string bankName, double accountBalance)
            : this(accountId, accountHolderName, bankName)
        {
            AccountBalance = accountBalance > MINIMUM_BALANCE ? accountBalance : MINIMUM_BALANCE;
        }

        public string DepositAmount(double amount)
        {
            AccountBalance += amount;
            return "Deposit Successfull!";
        }
        public string WithdrawAmount(double amount)
        {
            if (AccountBalance - amount < MINIMUM_BALANCE)
                return "Insufficient Funds!";
            AccountBalance -= amount;
            return "Withdrwal Successfull!";
        }
        public override string ToString()
        {
            return $"=================== Account Details are ===================\n" +
                $"Account ID is: {AccountId}\n" +
                $"Account Holder Name is: {AccountHolderName}\n" +
                $"Bank Name is: {BankName}\n" +
                $"Balance is: {AccountBalance}";
        }
    }
}
