using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassVsStruct.Models
{
    //Developer class inherits from Employee(inheritance, not possible in struct)
    internal class Developer:Employee
    {
        // Protected member, not allowed in struct
        protected string DeveloperProject { get; set; }
        public Developer(int employeeId, string name, double salary,string project)
            :base(employeeId,name,salary) 
        {
            DeveloperProject = project;            
        }


        // Overriding the virtual method

        public override void Display()
        {
            Console.WriteLine($"{base.Display}\n" +
                $"Developer working under the project is:{DeveloperProject}");
        }
        public override void Project()
        {
            Console.WriteLine("Inside the abstract project method of Developer class");
        }

    }
}

