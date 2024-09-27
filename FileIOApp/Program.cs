using System.Xml;

namespace FileIOApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TextFileWriter();
            // TextFileReader();
            XmlFileReader();
        }
        public static void TextFileWriter()
        {
            StreamWriter streamWriter = new StreamWriter("E:\\DotNet\\Monocept_Assignments\\FileIOApp\\TextFile.txt",true);
            //StreamWriter streamWriter = new StreamWriter("E:\\DotNet\\Monocept_Assignments\\FileIOApp\\TextFile1.txt");

            Console.WriteLine("Enter a Text write into file:");

            string str = Console.ReadLine()??string.Empty;

            streamWriter.WriteLine(str);
            streamWriter.Flush();
            streamWriter.Close();
        }

        public static void TextFileReader()
        {
            StreamReader streamReader = new StreamReader("E:\\DotNet\\Monocept_Assignments\\FileIOApp\\TextFile.txt");
            Console.WriteLine("Content of the File:");

            // Seek method is used to specify from where to start reading input stream 
            streamReader.BaseStream.Seek(0, SeekOrigin.Begin);

            // To read line from input stream 
            string str = streamReader.ReadLine();

            // To read the whole file line by line 
            while (str != null)
            {
                Console.WriteLine(str);
                str = streamReader.ReadLine();
            }
            Console.ReadLine();

            // to close the stream 
            streamReader.Close();
        }
        public static void XmlFileReader()
        {
            String URLString = "E:\\DotNet\\Monocept_Assignments\\FileIOApp\\bookstore.xml";
            XmlTextReader reader = new XmlTextReader(URLString);

            while (reader.Read())
            {
                switch (reader.NodeType)
                {
                    case XmlNodeType.Element: // The node is an element.
                        Console.Write("<" + reader.Name);

                        while (reader.MoveToNextAttribute()) // Read the attributes.
                            Console.Write(" " + reader.Name + "='" + reader.Value + "'");
                        Console.Write(">");
                        break;
                    case XmlNodeType.Text: //Display the text in each element.
                        Console.WriteLine(reader.Value);
                        break;
                    case XmlNodeType.EndElement: //Display the end of the element.
                        Console.Write("</" + reader.Name);
                        Console.WriteLine(">");
                        break;
                }
            }
        }
    }
}
