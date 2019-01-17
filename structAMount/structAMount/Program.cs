using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace structAMount
{
    public struct Number
    {
        public decimal Amount { get; set; }



        class Program
        {
            static void Main(string[] args)
            {
                Number value = new Number();
                Console.WriteLine("Please enter a number value:");
                value.Amount = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine(value.Amount);
                Console.ReadLine();

            }
        }
    }
}
