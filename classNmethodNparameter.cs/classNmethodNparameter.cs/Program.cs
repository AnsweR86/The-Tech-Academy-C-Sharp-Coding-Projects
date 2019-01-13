using System;

namespace MethodDrill2
{
    class Program
    {
        static void Main(string[] args)
        {   ///Integer
            Calculator calc = new Calculator();
            int result = 0;
            result = calc.Multiplication(12, 10);
            Console.WriteLine(result);
            Console.ReadLine();

            ///Decimal
            Calculator calc2 = new Calculator();
            int result2 = 0;
            result2 = calc2.Subtraction(15, 2.2);
            Console.WriteLine(result2);
            Console.ReadLine();

            /// and STRING
            Calculator calc3 = new Calculator();
            int result3 = 0;
            result3 = calc3.Addition("15", "5");
            Console.WriteLine(result3);
            Console.ReadLine();

        }
    }
}