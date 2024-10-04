using AccountsDemo.Controller;
using AccountsDemo.Models;
using AccountsDemo.Presentation;

namespace AccountsDemo
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            
            AccountManager manager = new AccountManager();
            AccountStore.DisplayMenu();
        }
    }
}
