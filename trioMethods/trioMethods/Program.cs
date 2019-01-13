using System;

namespace Method_Optional_App
{
    class Program
    {
        static void Main(string[] args)
        {
            //STEP 2.) Instantiated "Engorgio"(Harry Potter spell to Enlarge) object.
            Magic Engorgio = new Magic();

            //STEP 3.) Asked for user input of one integer with the option for a second integer.
            Console.WriteLine("Please type an integer you would like 'Engorgio' performed on, then press \"Enter.'\'(^.^)V");
            int firstInput = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("If you would like a second integer to be a part of the 'Engorgio' , type it here and press \"Enter.\" " +
                "\n If you are fine with just one integer and have no other integer, simply Shout'Wingardium Leviosa!!'or\n just press \"Enter\" without input.");


            
            bool ifInteger = Int32.TryParse(Console.ReadLine(), out int secondInput);

            //STEP 4.) Called the "Calc" method, allowing for one or two separate integers.
            if (ifInteger == true)
            {
                Console.WriteLine("ENGORGIO~!!\n I did magic things and now your integers have become: " + Magic.Calc(firstInput, secondInput) + "!");
            }
            else
            {
                Console.WriteLine("ENGORGIO~!!\n I did magic things and now your integer has become: " + Magic.Calc(firstInput, secondInput) + "!");
            }

            Console.ReadLine();

            //STEP 5.) Tried several integer combinations, as well as only inputting one integer, 
        }
    }
}