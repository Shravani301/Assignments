using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializeDemo
{
    [Serializable]
    internal class Account
    {
        public int AccountId {  get; set; }
        public string AccountHolderName { get; set; }
        public string BankName { get; set; }
        public double AccountBalance {  get; set; }
        const int MINIMUM_BALANCE = 1000;

        public Account() { }
        public Account(int accId, string accName, string bankName)
        {
            AccountId = accId;
            AccountHolderName = accName;
            BankName = bankName;
            AccountBalance = MINIMUM_BALANCE;
        }
        public Account(int accId, string accName, string bankName, double balance)
            :this(accId, accName, bankName)
        {
            AccountBalance = balance > MINIMUM_BALANCE ? balance : MINIMUM_BALANCE;

        }
        public string Deposit(double amount)
        {
            AccountBalance += amount;
            return $"Amount Deposited Successfully:{amount}";
        }
        public string Withdraw(double amount)
        {

            if (AccountBalance - amount >=MINIMUM_BALANCE)
            {
                AccountBalance -= amount;
                return $"Amount Withdrawn Successfully:{amount}";
            }
            return "Insufficient Balance";
        }
    }
}
