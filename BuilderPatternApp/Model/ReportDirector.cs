using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPatternApp.Model
{
    /*
   4. Director
    The Director is responsible for managing the construction
    process of the complex object.

    It collaborates with a Builder, but it doesn’t know the specific
    details about how each part of the object is constructed.
    It provides a high-level interface for constructing the 
    product and managing the steps needed to create the complex object.
     */
    internal class ReportDirector
    {
        public Report MakeReport(ReportBuilder reportBuilder)
        {
            reportBuilder.CreateNewReport();
            reportBuilder.SetReportType();
            reportBuilder.SetReportHeader();
            reportBuilder.SetReportContent();
            reportBuilder.SetReportFooter();
            return reportBuilder.GetReport();
        }
    }
}
