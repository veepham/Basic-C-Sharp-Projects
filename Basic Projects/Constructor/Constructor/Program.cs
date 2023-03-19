using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            const string Company = "The School"; // create const variable
            var newStudent = new Student("Jack"); // Create a variable using the keyword “var.”
            Console.WriteLine("Welcome to {0}! ", Company);
            Console.WriteLine(newStudent.name + " is present.");
            Console.ReadLine();
        }
    }
}
