using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BuilderPatternApp.Model
{
    //1. Product
    /*The Product is the complex object that the Builder pattern
     is responsible for constructing.
    It may consist of multiple components or parts,
    and its structure can vary based on the implementation.
    The Product is typically a class with attributes
    representing the different parts that the Builder constructs.
    */
    public class Report
    {
        public string ReportType { get; set; }
        public string ReportHeader { get; set; }
        public string ReportFooter { get; set; }
        public string ReportContent { get; set; }
        public void DisplayReport()
        {
            Console.WriteLine("Report Type :" + ReportType);
            Console.WriteLine("Header :" + ReportHeader);
            Console.WriteLine("Content :" + ReportContent);
            Console.WriteLine("Footer :" + ReportFooter);
        }
    }
}
