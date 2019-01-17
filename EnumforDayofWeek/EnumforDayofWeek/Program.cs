using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//  CREATE AN ENMU FOR THE DAYS OF THE WEEK
namespace EnumforDayofWeek
{
    class Program
    {
        static void Main(string[] args)
        {//PROMPT THE USER TO ENTER THE CURRENT DAY OF THE WEEK.

            Console.WriteLine("Please enter the current day of the week:");
            var entry = Console.ReadLine();

        Start:
            //WRAP STATEMENT IN A TRY/CATCH BLOCK AND PRINT ERROR MESSAGE.
            try
            {
                DaysOfTheWeek day = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), entry);

            }
            catch (System.ArgumentException)
            {
                Console.WriteLine("Please enter an actual day of the week.");
                entry = Console.ReadLine();
                goto Start;
            }

            DaysOfTheWeek value = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), entry);

            Console.WriteLine(value);
            Console.ReadLine();

        }//assign the VALUE TO A VARIABLE
             public enum DaysOfTheWeek
            {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday,
        }

    }


}
