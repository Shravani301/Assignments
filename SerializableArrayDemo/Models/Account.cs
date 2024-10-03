using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializableArrayDemo.Models
{
    [Serializable]
    public class Account
        {
        public int AccountId { get; set; }
        public string AccountHolderName { get; set; } = string.Empty; 
        public string BankName { get; set; } = string.Empty;
        public double AccountBalance { get; set; }

        private const int MINIMUM_BALANCE = 1000;

        public Account() { }

        public Account(int accountId, string accountHolderName, string bankName)
        {
            AccountId = accountId;
            AccountHolderName = accountHolderName;
            BankName = bankName;
            AccountBalance = MINIMUM_BALANCE;
        }

        public Account(int accountId, string accountHolderName, string bankName, double accountBalance)
            : this(accountId, accountHolderName, bankName)
        {
            AccountBalance = accountBalance > MINIMUM_BALANCE ? accountBalance : MINIMUM_BALANCE;
        }

        public string Deposit(double amount)
        {
            AccountBalance += amount;
            return $"Amount Deposited Successfully: {amount}";
        }

        public string Withdraw(double amount)
        {
            if (AccountBalance - amount >= MINIMUM_BALANCE)
            {
                AccountBalance -= amount;
                return $"Amount Withdrawn Successfully: {amount}";
            }
            return "Insufficient Balance";
        }

        public override string ToString()
        {
            return $"Account Id: {AccountId}\nAccount Name: {AccountHolderName}\nBank Name: {BankName}\nAvailable Balance: {AccountBalance}\n";
        }
    }
}
