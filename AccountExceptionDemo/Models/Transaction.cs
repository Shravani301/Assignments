using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountExceptionDemo.Models
{
    internal class Transaction
    {
        public static string Id { get; set; }
        public string Type { get; set; }
        public double Amount { get; set; }
        public DateTime DateTime { get; set; }

        public static string GenerateTransactionId(Account account)
        { 
            Id = "TXID" + account.AccountId + DateTime.Now;
            return Id;
        }
        
    }
}
