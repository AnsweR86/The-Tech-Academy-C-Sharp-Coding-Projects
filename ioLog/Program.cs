using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ioLOG
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask a user for a number.
            Console.WriteLine("Hi there. Please give me a number from 1 to 10.");
            string userInput = Console.ReadLine();
            //LOG THAT NUMBER TO A TEXT FILE.
            File.WriteAllText(@"C:\Users\Jinho\Desktop\The-Tech-Academy-C-Sharp-Coding-Projects\log.txt",userInput);

            // Print the text file back to the user. 
            string readNumber = File.ReadAllText(@"C:\Users\Jinho\Desktop\The-Tech-Academy-C-Sharp-Coding-Projects\log.txt");
            Console.ReadLine();

            Console.WriteLine(File.ReadAllText(@"C:\Users\Jinho\Desktop\The-Tech-Academy-C-Sharp-Coding-Projects\log.txt"));
            Console.ReadLine();
        }
    }
}