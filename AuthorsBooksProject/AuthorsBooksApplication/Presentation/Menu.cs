using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthorsBooksApplication.Presentation
{
    public class Menu
    {
        public static void MainMenu()
        {
            while (true)
            {
                Console.WriteLine("Select what do you wish to do?\n" +
                    "1. Authors Management\n" +
                    "2. Books Management\n" +
                    "3. Exit\n" +
                    "Enter your choice:");
                int choice=Convert.ToInt32(Console.ReadLine());
                DoTasksMainMenu(choice);
            }
        }
        public static void DoTasksMainMenu(int choice)
        {
            switch (choice)
            {
                case 1:
                    AuthorMenu.DisplayAuthorMenu();
                    break;
                case 2:
                    BookMenu.DisplayBookMenu();
                    break;
                case 3:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Enter correct choice");
                    break;
            }
        }
    }
}
