using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methodoverload
{
    class Program
    {
        
         static void Main(string[] args)
        {
            OverloadMod Class = new OverloadMod();

            /*call the first method, passing in an integer, such as 12. Then display the result to the screen.*/
            Console.WriteLine(Class.myMethod(12));

            /*call the second method, passing in a decimal. Display the result to the screen.*/
            Console.WriteLine(Class.myMethod(1.5m));

            /*call the third method, passing in a string that equates to an integer. 
             * Display the result to the screen.*/
            Console.WriteLine(Class.myMethod("24"));

            Console.ReadLine();
        }
    }
}
