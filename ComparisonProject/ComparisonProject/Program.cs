using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparisonProject
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.ReadLine();
            Console.WriteLine("Person 1");
            Console.ReadLine();
            Console.WriteLine("What is your hourly rate?");
            int hourRate = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many hours did you work this week?");
            int hoursWorked = Convert.ToInt32(Console.ReadLine());
            int annualSalary1 = hourRate * hoursWorked * 52;
            Console.WriteLine("Person 1's annual salary: " + annualSalary1);
            Console.ReadLine();
            Console.WriteLine("Person 2");
            Console.ReadLine();
            Console.WriteLine("What is your hourly rate?");
            int hourRate2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many hours did you work this week?");
            int hoursWorked2 = Convert.ToInt32(Console.ReadLine());
            int annualSalary2 = hourRate2 * hoursWorked2 * 52;
            Console.WriteLine("Person 2's annual salary: " + annualSalary2);
            Console.ReadLine();
            Console.WriteLine("Does Person 1 make more money than Person 2?");
            Console.ReadLine();
            bool compare = annualSalary1 > annualSalary2;
            Console.WriteLine(compare);
            Console.ReadLine();


        }
    }
}
