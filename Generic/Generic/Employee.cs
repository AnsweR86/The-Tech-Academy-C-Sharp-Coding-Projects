using System;
using System.Collections.Generic;
//MAKE THE EMPLOYEE CLASS TAKE  A GENERIC TYPE PARAMETER
namespace Generic
{
    
    public class Employee<THING>
    {

        public List<THING> Things { get; set; }

        public string item { get; set; }

        public int Numbers { get; set; }

    }




}