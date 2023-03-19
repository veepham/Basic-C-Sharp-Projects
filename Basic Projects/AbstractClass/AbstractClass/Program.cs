using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee person = new Employee() { firstName = "Sample", lastName = "Student" };
            person.SayName();
            Console.ReadLine();
        }
    }
}
