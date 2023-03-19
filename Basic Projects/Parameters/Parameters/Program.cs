using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parameters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee<string> myList = new Employee<string>();
            myList.Things = new List<string>() { "hey", "how are you", "whats new" };

            Employee<int> Id = new Employee<int>();
            Id.Things = new List<int>() { 1, 2, 3, 4 };

            foreach (var thing in myList.Things)
            {
                Console.WriteLine(thing);
                Console.ReadLine();
            }
            foreach (var thing in Id.Things)
            {
                Console.WriteLine(thing);
                Console.ReadLine();
            }
        }
    }
}
