using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPatternApp.Model
{
    /* 3. ConcreteBuilder
      ConcreteBuilder classes implement the Builder interface,
      providing specific implementations for building each part of the product.
      Each ConcreteBuilder is tailored to create a specific variation of the product.
      It keeps track of the product being constructed and provides methods
       for setting or constructing each part.
   */
    public class ExcelReport : ReportBuilder
    {
        public override void SetReportContent()
        {
            reportObject.ReportContent = "Excel Content Section";
        }
        public override void SetReportFooter()
        {
            reportObject.ReportFooter = "Excel Footer";
        }
        public override void SetReportHeader()
        {
            reportObject.ReportHeader = "Excel Header";
        }
        public override void SetReportType()
        {
            reportObject.ReportType = "Excel";
        }
    }
}
