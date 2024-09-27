using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassVsStruct.Models
{
    // Class for Employee (Reference Type)
    internal class Employee
    {
        public int EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public double EmployeeSalary { get; set; }

        // Classes can contain constructor or destructor
        // classes can contain a parameterized and parameter-less constructors. 
        public Employee()
        {
            Console.WriteLine("Inside the Parameter-less constructor of Employee Class");
        }

        public Employee(int employeeId, string name, double salary)
        {
            EmployeeID = employeeId;
            EmployeeName = name;
            EmployeeSalary = salary;
        }

        //Classes can have a virtual and abstract methods,
        //Struct cannot have virtual or abstract methods
        public virtual void Display()
        {
            Console.WriteLine($"EmployeeID: {EmployeeID}\n" +
                $" Name: {EmployeeName}\n" +
                $"Salary: {EmployeeSalary}\n");
        }
        public virtual void Project() 
        {
            Console.WriteLine("Inside the Project Class");
        }
    }
}
