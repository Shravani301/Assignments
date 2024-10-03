using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceVsAbstractDemo.Models
{
    internal interface IPaymentProcessor
    {
        public double ProcessingFee { get;}
        double TAX { get; }
        double CalculateProcessingFee(double amount);
        double ProcessPayment(double amount);
    }
}
