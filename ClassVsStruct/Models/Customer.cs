using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassVsStruct.Models
{
    internal struct Customer
    {
        public int CustomerID { get; set; }
        public string CustomerName { get; set; }

        // Struct can have a parameterized constructor,
        // struct does not contain a parameter less constructor ,
        // structures can de declared using struct keyword
        public Customer(int cId, string cName)
        {
            CustomerID = cId;
            CustomerName = cName;
        }

        // Struct cannot have virtual or abstract methods
        public void Display()
        {
            Console.WriteLine($"EmployeeID: {CustomerID}\n" +
                $" Name: {CustomerName}\n");

        }
    }
}
