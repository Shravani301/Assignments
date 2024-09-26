using ArmstrongApp.Models;

namespace ArmstrongApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Armstrong armstrong = new Armstrong();
            Console.WriteLine("Enter a number to check whether it is armstrong or not:");
            int input=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            if (armstrong.CheckArmstrong(input))
                Console.WriteLine($"{input} is an armstrong number");
            else
                Console.WriteLine($"{input} is not a armstrong number");
            
        }
    }
}
