using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stakking
{
    class Person
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string SocialSecurityNumber { get; set; }

        public int CompareTo(object obj)
        {
            Person CompareTo = (Person)obj;
            int lastnames = Lastname.CompareTo(CompareTo.Lastname);
            if (lastnames == 0) return Firstname.CompareTo(CompareTo.Firstname);
            return lastnames;
        }

        public override string ToString()
        {
            return Firstname + " " + Lastname + " " + SocialSecurityNumber;
        }
    }
}
