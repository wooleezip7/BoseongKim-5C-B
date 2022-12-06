using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Library_Assignment
{
    public class Person
    {
        public Address _Address { get; set; }

        public string Name { get; set; }
        public string Email { get; set; }
        public string Tel_Num { get; set; }

        public Person(string name, string email, string telnum) 
        {
            Name = name;
            Email = email;
            Tel_Num = telnum;
        }
    }
}
