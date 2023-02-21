using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number:");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter another number:");
            int y = Convert.ToInt32(Console.ReadLine());

            myClass mathMethod = new myClass(); //instantiate
            int result; // defining variable used in "out"
            mathMethod.Math(x, y, out result); // calling method and specifying the parameters
            
            Console.ReadLine();
        }
    }
}
