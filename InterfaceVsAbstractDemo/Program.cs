using InterfaceVsAbstractDemo.Models;

namespace InterfaceVsAbstractDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            CreditCard creditCard = new CreditCard();
            Paypal paypal = new Paypal();
            BankTransfer bankTransfer = new BankTransfer();

            
            Console.WriteLine("Welcome to the Payment Processing System!");
            Console.WriteLine("Please choose a payment method:\n 1. Credit Card\n 2. PayPal\n 3. Bank Transfer\n Enter your choice (1/2/3):");
            int choice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the base amount to pay:");
            double amount = Convert.ToDouble(Console.ReadLine());

            
            IPaymentProcessor paymentProcessor;
            switch (choice)
            {
                case 1:
                    paymentProcessor = creditCard;
                    break;
                case 2:
                    paymentProcessor = paypal;
                    break;
                case 3:
                    paymentProcessor = bankTransfer;
                    break;
                default:
                    Console.WriteLine("Invalid Input. Please enter a choice between 1 and 3.");
                    return; 
            }

            ProcessPaymentPrint(paymentProcessor, amount);
        }

        
        static void ProcessPaymentPrint(IPaymentProcessor processor, double amount)
        {
            Console.WriteLine($"Base Amount: ${amount}");
            Console.WriteLine($"Tax (10%): ${processor.TAX * amount}");
            Console.WriteLine($"Processing Fee: ${processor.CalculateProcessingFee(amount)}");
            Console.WriteLine($"Total Amount: ${processor.ProcessPayment(amount)}");
        }
    }
}
