using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace interfaceDrill
{
   class Program : Employee
    {
        static void Main(string[] args)
        {//////INTERFACE IQuittable//
            IQuittable quitExecute = new Employee();
            quitExecute.Quit();
            Console.ReadLine();

        }
    }

    
    
    
}

