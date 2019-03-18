using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    namespace interfaceDrill
{
    /////interface and implement the Quit() method //
    class Employee : IQuittable
    {
        void IQuittable.Quit()
        {
            Console.WriteLine("you have quit the game");
        
        }

    }
}



    
