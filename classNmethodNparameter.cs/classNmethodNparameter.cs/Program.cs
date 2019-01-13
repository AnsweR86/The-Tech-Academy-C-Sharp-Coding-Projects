using System;


namespace MethodDrill2
        {
            class Program
            {
                public static void Main(string[] args)
                {
                    //ARGUMENTS THATS GOING TO PASSED FROM MAIN TO CLASS
                    Console.WriteLine("Please enter an integer.");
                        int x = Convert.ToInt32(Console.ReadLine());
        
                    Console.WriteLine("Please enter a second integer (it is not necessary).");
                        int y = 0;
                     try
                        {
                            y = Convert.ToInt32(Console.ReadLine());
                        }
                    catch
                        {
                        Console.WriteLine("Nothing was entered for second integer");
                     }
        
        
                           Example add = new Example();
                           add.AddNumbers(x, new int[] { y });
        
                           Console.ReadLine();
                          
        
                    }
                }
            } 
};