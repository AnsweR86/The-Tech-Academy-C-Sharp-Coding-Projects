using System;

namespace Method_Optional_App
{
    class Magic
    {
       
        
        public static int Calc(int firstInput, int secondInput = 0)
        {
            int calcAnswer = 20 + firstInput + secondInput;
            return calcAnswer;
        }
    }
}