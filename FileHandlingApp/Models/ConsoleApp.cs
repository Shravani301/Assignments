using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandlingApp.Models
{
    internal class ConsoleApp
    {
        // prompt the user to enter username and
        // writes it into a file without overwriting existing data.
        public void WriteUsernameToFile(string filePath)
        {
            
            Console.Write("Enter your username: ");
            string userName = Console.ReadLine()??string.Empty;

            // Open the file in append mode and add the username
            // (without overwriting the previous data)
            // by passing AppendText or else we can use stream writer class with filepath and
            // passing true in that case it is considers this as append mode
            //StreamWriter sw = new StreamWriter(filePath,true)
            using (StreamWriter sw = File.AppendText(filePath))
            {
                sw.WriteLine(userName);
            }

           Console.WriteLine("Username has been written to file.");
        }

        // reading and display all the usernames stored in the file.
        public void ReadUsernamesFromFile(string filePath)
        {
            // Check if the file exists
            if (File.Exists(filePath))
            {
                
                Console.WriteLine("Previous usernames:");

                string[] usernames = File.ReadAllLines(filePath);

                foreach (var user in usernames)
                {
                    Console.WriteLine(user);
                }
            }
            else
            {
                Console.WriteLine("No file found with usernames.");
            }
        }
    }
}
