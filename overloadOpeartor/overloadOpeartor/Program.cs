using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace OverloadingOperator_App
{
    public class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee { id = 123 };
            Employee emp2 = new Employee { id = 123 };

            bool compare = emp1 != emp2;
            Console.WriteLine("Are the two ids equal?" + compare);
            Console.ReadLine();
        }
    }

    
    
    
}

