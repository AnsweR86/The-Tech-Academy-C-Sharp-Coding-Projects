using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Class_App
{
    class Divider
    {
        //Created "Divider" class. Created void "Half" method.
        
        public static void Half(out int dividedNum, int userInt)
        {
            dividedNum = userInt / 2;
        }

        //Made second method to overload "Half" method.
        public static void Half(int userInt)
        {
            int dividedNum = userInt / 2;
        }
    }
}