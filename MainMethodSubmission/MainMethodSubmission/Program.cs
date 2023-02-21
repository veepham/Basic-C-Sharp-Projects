using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter any whole number.");
            int x = Convert.ToInt32(Console.ReadLine());

            mainClass math = new mainClass(); //instantiate the class
            Console.WriteLine(math.Addition(x)); // calling method and passing in the integer
            Console.ReadLine();


            Console.WriteLine("Please enter a decimal value.");
            decimal y = Convert.ToDecimal(Console.ReadLine());

            mainClass decimalMath = new mainClass(); //instantiate the class
            Console.WriteLine(math.Addition(y)); // calling method and passing in the integer
            Console.ReadLine();

            Console.WriteLine("Please enter a whole number.");
            string z = Console.ReadLine();

            mainClass stringMath = new mainClass();
            Console.WriteLine(stringMath.Addition(z));
            Console.ReadLine();
        }
    }
}
