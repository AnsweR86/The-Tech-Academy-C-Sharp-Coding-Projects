using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methodoverload
{
    public class OverloadMod
    {
        public int myMethod(int num)
        {
            return num * 2;
        }


        /*will take in a decimal, do a different math operation to it and then return the answer as an integer.*/
        public int myMethod(decimal d)
        {
            return Convert.ToInt32(d % 5);
        }

        /*call the third method, passing in a string that equates to an integer.*/
        public int myMethod(string s)
        {
            int final = Convert.ToInt32(s) + 1000;
            return final;
        }




    }
}
