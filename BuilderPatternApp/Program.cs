using BuilderPatternApp.Model;

namespace BuilderPatternApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ReportDirector reportDirector = new ReportDirector();
            Report report = reportDirector.MakeReport(new PDFReport());
            report.DisplayReport();
            Console.WriteLine("-------------------");
            
            report = reportDirector.MakeReport(new ExcelReport());
            report.DisplayReport();

        }
    }
}
