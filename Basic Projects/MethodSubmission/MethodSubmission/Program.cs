using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            MathClass math = new MathClass();
            

            Console.WriteLine("Please enter your first number.");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter your second number (optional - click enter to surpass)");
            string y = Console.ReadLine();
            Console.WriteLine("Calculating...");

            if (y.Equals(string.Empty))
            {
                Console.WriteLine("Result: " + math.Multiply(x));
            }
            else
            {
                int z = Convert.ToInt32(y);
                Console.WriteLine(math.Multiply(x, z));
            }            
            Console.ReadLine();
        }
    }
}
