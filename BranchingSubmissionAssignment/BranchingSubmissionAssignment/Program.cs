using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BranchingSubmissionAssignment
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.ReadLine();
            Console.WriteLine("What is the weight (lbs) of your package? Please round up to the whole number.");
            double weight = Convert.ToDouble(Console.ReadLine());

            if (weight > 50.00) 
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
            }

            else
            {
                Console.WriteLine("Please enter package width: ");
                double width = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Please enter package height: ");
                double height = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Please enter package length: ");
                double length = Convert.ToDouble(Console.ReadLine());
                double totalDimensions = width + height + length;
                double cost = totalDimensions * weight / 100.00;

                if (totalDimensions > 50.00)
                {
                    Console.WriteLine("Package too big to be shipped via Package Express.");
                }
                else
                {
                    Console.WriteLine("Your estimated total for shipping this package is: $" + cost);
                    Console.ReadLine();
                }

            }
            
        }
    }
}
