using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace FileHandlingApp.Models
{
    internal class FileReader
    {
        // Reading a XML file
        // This method reads the entire content of an XML file
        // and displays it in the console.
        public void ReadXmlFile(string xmlFilePath)
        {
            // Checking if the file exists
            if (File.Exists(xmlFilePath))
            {
                // Load the XML file into an XmlDocument object
                XmlDocument xmlRead = new XmlDocument();
                xmlRead.Load(xmlFilePath);

                // Display the inner XML content (the entire XML structure)
                Console.WriteLine("Contents of XML file:");
                Console.WriteLine(xmlRead.InnerXml);
            }
            else
            {
                Console.WriteLine("XML file not found.");
            }
        }

        // Reading a HTML file
        // This method reads the contents of an HTML file and displays it in the console.
        public void ReadFromHtml(string htmlFilePath)
        {
            
            if (File.Exists(htmlFilePath))
            {
                // Read the entire HTML file content as a string
                string htmlContent = File.ReadAllText(htmlFilePath);

                Console.WriteLine("Contents of HTML file:");
                Console.WriteLine(htmlContent);
            }
            else
            {
                Console.WriteLine("HTML file not found.");
            }
        }

        // Reading a Text file
        // This method reads the contents of a text file and displays it in the console.
        public void ReadFromText(string textFilePath)
        {
            // Check if the file exists
            if (File.Exists(textFilePath))
            {
                string textContent = File.ReadAllText(textFilePath);

                Console.WriteLine("Contents of Text file:");
                Console.WriteLine(textContent);
            }
            else
            {
                Console.WriteLine("Text file not found.");
            }
        }
    }
}
