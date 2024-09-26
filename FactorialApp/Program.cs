using FactorialApp.Models;

namespace FactorialApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Factorial factorial = new Factorial();
            Console.WriteLine("Enter a Number to find out factorial:");
            int input=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Factorial of {input} is:{factorial.FindFactorial(input)}");

        }
    }
}
