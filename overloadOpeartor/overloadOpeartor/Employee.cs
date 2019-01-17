using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadingOperator_App
{
   public class Employee
    {
        public int id { get; set; }
        public static bool operator ==(Employee e1, Employee e2)
        {
            if (e1.id == e2.id)
            {
                return true;
            }
            else
                return false;
        }
        public static bool operator !=(Employee e1, Employee e2)
        {
            if (e1.id != e2.id)
            {
                return true;
            }
            else return false;

        }
        public override bool Equals(object obj)
        {
            return base.Equals(obj); 

        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

    }
}




