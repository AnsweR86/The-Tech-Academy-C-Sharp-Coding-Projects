using System;

namespace constVariable
{
     class Student
    { //1.CREATING A CONST VARIABLE
        public Student(string name) : this("name", "city") { }

        public Student(string name,string city)
        {
            name = name;
            city = city;
        }
        public string name { get; set; }
        public string city { get; set; }

        
       
      
    }
}