using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambaExpression
{
    class Program
    {
        static void Main(string[] args)
        {
            //STEP 1.) Created list "employees" with ten items, two of which are named "Joe."
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee() { EmpId = 1, FirstName = "Mike", LastName = "Jetson" });
            employees.Add(new Employee() { EmpId = 2, FirstName = "Joe", LastName = "Fredericks" });
            employees.Add(new Employee() { EmpId = 3, FirstName = "Suzie", LastName = "Terry" });
            employees.Add(new Employee() { EmpId = 4, FirstName = "Ellie", LastName = "Bartlet" });
            employees.Add(new Employee() { EmpId = 5, FirstName = "Joe", LastName = "Sawbones" });
            employees.Add(new Employee() { EmpId = 6, FirstName = "Samantha", LastName = "Wills" });
            employees.Add(new Employee() { EmpId = 7, FirstName = "Alex", LastName = "Ericson" });
            employees.Add(new Employee() { EmpId = 8, FirstName = "Jackson", LastName = "Flaxon" });
            employees.Add(new Employee() { EmpId = 9, FirstName = "Michael", LastName = "Michaels" });
            employees.Add(new Employee() { EmpId = 10, FirstName = "Sarah", LastName = "Smith" });

            // STEP 2.) Created foreach loop to add employees named "Joe" to a new list.
            //NOTE: Comment out when using the lambda expression below.

            //List<Employee> theJoes = new List<Employee>();
            //foreach (Employee employee in employees)
            //{
            //    if (employee.FirstName == "Joe")
            //    {
            //        theJoes.Add(employee);
            //    }
            //}

            //STEP 3.) Created lambda expression to add employees named "Joe" to a new list.
            //NOTE: Comment out when using the foreach loop above.


            List<Employee> joeLambda = employees.Where(x => x.FirstName == "Joe").ToList();

            //STEP4.) Created lambda expression to add employees with an Id greater than 5 to a new list.

            List<Employee> bigId = employees.Where(x => x.EmpId > 5).ToList();

            //NOTE: included optional foreach loop to check that correct employees have been added to new list.
            // Each list has a different name, and must be changed in this loop depending on which one of the
            // above lambdas /loops are used.
            foreach (Employee employee in bigId)
            {
                Console.WriteLine(employee.FirstName + " " + employee.LastName + ", ID: " + employee.EmpId);
            }

            Console.ReadLine();
        }
    }
}
        