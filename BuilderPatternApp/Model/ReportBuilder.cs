using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPatternApp.Model
{
    //2. Builder
    /*
    The Builder is an interface or an abstract class that declares
    the construction steps for building a complex object.
    It typically includes methods for constructing individual parts of the product.
    By defining an interface, the Builder allows for the creation of 
    different concrete builders that can produce variations of the product.

    (for examples:1. stone and wooden houses
                  2. car->sports car, suv car.
                  3. report->pdf, excel fomrat
                  4. Beverage-> Tea, Coffee.
    */
    public abstract class ReportBuilder
    {
        protected Report reportObject;
        public abstract void SetReportType();
        public abstract void SetReportHeader();
        public abstract void SetReportContent();
        public abstract void SetReportFooter();
        public void CreateNewReport()
        {
            reportObject = new Report();
        }
        public Report GetReport()
        {
            return reportObject;
        }
    }
}
