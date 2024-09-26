using PrimeNumberApp.Models;

namespace PrimeNumberApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrimeNumber primeNumber = new PrimeNumber();

            Console.WriteLine("Enter a number to check whether it is prime or not:");

            int myNumber = Convert.ToInt32(Console.ReadLine());

            if (primeNumber.IsPrimeOrNot(myNumber))
                Console.WriteLine("Given Number is Prime:" + myNumber);
            else
                Console.WriteLine("Given Number is not an Prime:" + myNumber);
        }
    }
}
