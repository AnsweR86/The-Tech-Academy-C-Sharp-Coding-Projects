using System;


namespace classNmethodNparameter
{
    class Program
    {
        static void Main(string[] args)
        {
            //ARGUMENTS THATS GOING TO PASSED FROM MAIN TO PrameterCLASS
            Console.WriteLine("Please enter an integer value:");
            int one = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter a second integer value:");
            int two = Convert.ToInt32(Console.ReadLine());


            Prameter result = new Prameter();
            result.Prametermodifier(one, two);
            result.Prametermodifier(5, 2);


        

        }
    }
}
