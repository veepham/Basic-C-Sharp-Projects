using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanLogicAssignment
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("What is your age?");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Have you ever had a DUI? Please answer true or false.");
            bool dui = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("How many speeding tickets have you had?");
            int ticket = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Qualified?");
            bool qualify = age > 15 && dui == false && ticket < 3;
            Console.WriteLine(qualify);
            Console.ReadLine();

        }
    }
}
