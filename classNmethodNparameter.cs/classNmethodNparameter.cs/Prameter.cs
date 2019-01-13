

    using System;
    
        namespace MethodDrill2
    
    {
        public class Calculator
        {
            public Calculator()
            {
                // public Multiplication (int num1, int num2)
                //(num1 * num2);
            }
            //  
            // public int Subtraction(double num1, double num2)
            //{
            //return Convert.ToInt32(num1 - num2);
            //}
            //
            public void AddNumbers(int a, [Optional] int[] b)
            {
                int total = a + 10;
    
                if (b != null)
                {
                    foreach (int i in b)
                    {
    
                        total += 1;
                    }
                }//GIVING THE METHOD A WAY TO PRINTTO SCREEN
                    Console.WriteLine("10+interger One +intergen two");
                Console.WriteLine(total);
            }
    
        }
    
    }
        
            

    