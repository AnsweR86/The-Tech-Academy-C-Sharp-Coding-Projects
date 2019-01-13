using System;


namespace MethodsDrill
{
    public class MethodsDrill
    {
        static void Main()
        {
            Console.WriteLine("Pick a number and it will Add your number to my Equations!");
            int userInput = Convert.ToInt32(Console.ReadLine());
            Math_ing a = new Math_ing();
            int x = a.MutilplytwoValues(5, 10);
            int y = a.AddThreeValues(15, 25, 35);
            int z = a.AddNMultiplyFourValues(10, 20, 30, 40);

            Console.WriteLine(x + userInput);
            Console.ReadLine();
            Console.WriteLine(y + userInput);
            Console.ReadLine();
            Console.WriteLine(z + userInput);
            Console.ReadLine();
        }
    }
}