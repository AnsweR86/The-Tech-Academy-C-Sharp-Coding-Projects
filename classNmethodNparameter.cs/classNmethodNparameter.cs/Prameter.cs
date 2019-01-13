using System;


namespace MethodDrill2

{
    public class Calculator
    {
        public Calculator()
        {

        }

        public int Multiplication (int num1, int num2)
        {
            return num1 * num2;
        }

        public int Subtraction(double num1, double num2)
        {
            return Convert.ToInt32(num1 - num2);
        }

        public int Addition(string one, string two)
        {
            int ex = 0;
            int why = 0;
            if (!Int32.TryParse(one, out ex))
            {
                ex= -1;
            }
            if (!Int32.TryParse(two, out why))
            {
                why= -1;
            }
            return ex + why;
        }
    }
}