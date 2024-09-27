using FileHandlingApp.Models;

namespace FileHandlingApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Creating instances of the FileReader, FileWriter, and ConsoleApp classes
            FileReader fileReader = new FileReader();
            FileWriter fileWriter = new FileWriter();
            ConsoleApp consoleApp = new ConsoleApp();

            // file paths for the different file types
            string xmlFilePath = "samplexml.xml";     
            string htmlFilePath = "sampleHtml.html";   
            string textFilePath = "sampleText.txt";   
            string userFilePath = "usernames.txt";

            
            // Reading from the XML file and displaying its contents
            Console.WriteLine("Reading XML file:");
            fileReader.ReadXmlFile(xmlFilePath);

            // Reading from the HTML file and displaying its contents
            Console.WriteLine("\nReading HTML file:");
            fileReader.ReadFromHtml(htmlFilePath);

            // Reading from the Text file and displaying its contents
            Console.WriteLine("\nReading Text file:");
            fileReader.ReadFromText(textFilePath);

            // Writing into files

            // Writing into the XML file
            Console.WriteLine("\nWriting to XML file:");
            fileWriter.WriteToXml(xmlFilePath);

            // Writing into the HTML file
            Console.WriteLine("\nWriting to HTML file:");
            fileWriter.WriteToHtml(htmlFilePath);

            // Writing into the Text file
            Console.WriteLine("\nWriting to Text file:");
            fileWriter.WriteToText(textFilePath);

            // Console App: Writing and Reading usernames from file

            // Writing a new username to the file (does not overwrite existing usernames)
            consoleApp.WriteUsernameToFile(userFilePath);

            // Reading and displaying the previously stored usernames
            consoleApp.ReadUsernamesFromFile(userFilePath);
        }
    }
}
