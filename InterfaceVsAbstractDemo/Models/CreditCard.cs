using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceVsAbstractDemo.Models
{
    internal class CreditCard : IPaymentProcessor
    {
        public double TAX { get; } = 0.10;
        public double ProcessingFee { get; } = 0.02;
        
        public double CalculateProcessingFee(double amount)
        {
            return ProcessingFee * amount;
        }

        public double ProcessPayment(double amount)
        {
            return amount * TAX + CalculateProcessingFee(amount)+amount;
        }
    }
}
