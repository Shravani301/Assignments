using System;
using System.IO;
using System.Xml;

namespace FileHandlingApp.Models
{
    internal class FileWriter
    {
        // Writing text into an XML file based on user input
        public void WriteToXml(string xmlFilePath)
        {
            Console.Write("Enter the element name (e.g., DotNet): ");
            string elementName = Console.ReadLine();

            // Prompt the user to input the attribute name
            Console.Write("Enter the attribute name (e.g., Name): ");
            string attributeName = Console.ReadLine();

            // Prompt the user to input the attribute value
            Console.Write("Enter the attribute value (e.g., Alice): ");
            string attributeValue = Console.ReadLine();

            // Create a new XmlDocument
            XmlDocument xmlDoc = new XmlDocument();

            // Creating the root element <Tutorials>
            XmlElement root = xmlDoc.CreateElement("Tutorials");

            // Creating a new element using user input and setting its attribute
            XmlElement userElement = xmlDoc.CreateElement(elementName);
            userElement.SetAttribute(attributeName, attributeValue);

            // Appending the user-defined element to the root element
            root.AppendChild(userElement);

            // Appending the root to the XmlDocument
            xmlDoc.AppendChild(root);

            xmlDoc.Save(xmlFilePath);

            Console.WriteLine("Written to XML file - success.");
        }

        // Writing content to an HTML file based on user input
        public void WriteToHtml(string htmlFilePath)
        {
            Console.Write("Enter the content for the HTML page (e.g., Welcome to my site!): ");
            string userHtmlContent = Console.ReadLine();

            string htmlContent = $"<html><body><h1>{userHtmlContent}</h1></body></html>";

            File.WriteAllText(htmlFilePath, htmlContent);

            Console.WriteLine("Written to HTML file - success.");
        }

        // Writing to a Text file based on user input
        public void WriteToText(string textFilePath)
        {
            // Prompt the user for text content
            Console.Write("Enter the content for the text file: ");
            string userTextContent = Console.ReadLine();
            
            File.WriteAllText(textFilePath, userTextContent);

            Console.WriteLine("Written to Text file - success.");
        }
    }
}
