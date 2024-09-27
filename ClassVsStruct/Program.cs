using ClassVsStruct.Models;

namespace ClassVsStruct
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Difference 1: Reference vs Value Type

            // Class: Employee is a reference type, allocated on the heap
            Console.WriteLine("Employee is a reference type, allocated on the heap");
            Employee employee = new Employee(1, "Allen", 40000);
            Employee employee1=employee;// Both employee and employee1 point to the same object
            employee1.EmployeeName = "Mark";


            Console.WriteLine("Employee and employee1 both are affected");

            Console.WriteLine("Employee: ");
            employee.Display(); // Changes in employee1 affect employee,
                                // both reference the same object
            Console.WriteLine("Employee 1: ");
            employee1.Display();

            // Struct: Customer is a value type, allocated on the stack
            Console.WriteLine("Customer is a value type, allocated on the stack");
            Console.WriteLine("Changes in customer1 do not affect customer");
            Customer customer = new Customer(101, "Alice");
            Customer customer1 = customer;  // Creates a copy of customer
            customer1.CustomerName = "Bob";   // Changes in customer1 do not affect customer

            Console.WriteLine("\nCustomer: ");
            customer.Display();  // customer remains unchanged
            Console.WriteLine("Customer 1: ");
            customer.Display();

            // Difference 2: Inheritance

            // Class supports inheritance
            Console.WriteLine("Class Supports Inheritance Employee is Parent " +
                "class Developer is derived class");
            Developer developer = new Developer(2, "Mary", 90000, "DotNet-C#");
            developer.Display(); // Displays additional information from Developer

            // Difference 3: Constructors and Destructors

            // Employee class uses parameterless constructor
            Employee employee2 = new Employee();
            employee2.Display();

            // Customer struct must use a parameterized constructor
            Customer customer2 = new Customer(102, "Bob");
            customer2.Display();

            // Difference 4: Virtual Methods

            // Developer class uses virtual and overridden methods
            Employee employee4 = new Employee(103, "Allice",85000);
            employee4.Display(); // Calls the overridden method in SeniorDeveloper

            // EmployeeRecord struct cannot have virtual or abstract methods

            // Destructor in Developer class is automatically called when object goes out of scope

            Console.ReadKey();
        }
    }
}
