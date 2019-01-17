using System;

namespace constVariable
{
    public class Student
    {
        public Student() : this("", "")
        {
        }

        public Student(string name, string city)
        {//1.CREATING A CONST VARIABLE
            const string studentName = "jino Chang";
            //2.CREATING A VARIAIBLE USING "VAR"
            var City = "Seattle";
            Console.WriteLine("Student name = {0}, City = {1}", studentName, City);
        }
    }
}