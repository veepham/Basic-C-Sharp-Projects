using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please give me a number.");
            int yourNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Calulating your results...");
            Console.ReadLine();

            //calling each method and passing in user input
            newClass math = new newClass();
            int result1 = math.Addition(yourNumber);
            int result2 = math.Subtraction(yourNumber);
            int result3 = math.Multiplication(yourNumber);

            Console.WriteLine("100 plus your chosen number is equal to " + result1);
            Console.ReadLine();

            Console.WriteLine("100 minus your chosen number is equal to " + result2);
            Console.ReadLine();

            Console.WriteLine("100 times your chosen number is equal to " + result3);
            Console.ReadLine();


        }
    }
}
