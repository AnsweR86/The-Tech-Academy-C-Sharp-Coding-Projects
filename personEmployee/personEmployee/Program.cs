using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person_Employee_App
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiated "employee" object in "Employee" class with FirstName and LastName parameters.
            Employee employee = new Employee { FirstName = "Sample", LastName = "Student" };

            //Called the superclass ("Person") method SayName() on the "employee" object.
            employee.SayName();
            Console.ReadLine();
        }
    }
}