using PolindromeApp.Models;

namespace PolindromeApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Polindrome polindrome = new Polindrome();
            Console.WriteLine("Enter a Number to check whether it is polindrome or not:");
            int inputNumber=Convert.ToInt32(Console.ReadLine());
            if (polindrome.CheckPolindrome(inputNumber))
                Console.WriteLine($"Given Number is Polindrome: {inputNumber}");
            else
                Console.WriteLine($"Given Number is Not a Polindrome: {inputNumber}");

        }
    }
}
