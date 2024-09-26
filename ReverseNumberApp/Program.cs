using ReverseNumberApp.Models;

namespace ReverseNumberApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ReverseNumber reverseNumber = new ReverseNumber();
            Console.WriteLine("Enter a Number for Reverse:");
            int myNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Reverse of a {myNumber}  number is: "+reverseNumber.ReverseGivenNumber(myNumber));
        }
    }
}
