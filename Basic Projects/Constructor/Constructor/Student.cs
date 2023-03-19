using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    public class Student
    {
        public string name;
        public string location;

        public Student(string name) : this(name, "Online") { } //Chain two constructors together.
        public Student(string name, string location) 
        {
            this.name = name;
            this.location = location;
        }
    }
}
