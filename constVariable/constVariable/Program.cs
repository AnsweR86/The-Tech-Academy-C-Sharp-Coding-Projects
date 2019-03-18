using System;

//3.CHAIN 2 CONSTRUCTORS TOGETHER
namespace constVariable
{
    public class Program
    {
        static void Main()
        {//2. CREATING VARIABLE USING VAR//
            const string schoolName = "Umbrella Academy";
            Student student = new Student("Students Name","");
            Student city = new Student("Students Home");
            var students = new System.Collections.Generic.List<Student>() { student, city };

            Console.WriteLine("Come and Sign up at {0}",schoolName);
            Console.WriteLine("Students:");
            foreach (Student Student in students)
            {
                Console.WriteLine("Name: {0}, City: {1}", student.name, student.city);
            }

            Console.WriteLine("We Value Our students info");
            Console.ReadLine();

        }
    }
}