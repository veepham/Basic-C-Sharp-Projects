using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSubmission
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            Half math = new Half();
            
            Console.WriteLine("Enter a number to divide by 2:");
            int x = Convert.ToInt32(Console.ReadLine());
            int output;
            math.halfMath(x, out output);

            Console.ReadLine();

            Half math2 = new Half();

            Console.WriteLine("Enter a decimal number to divide by 2:");
            decimal y = Convert.ToDecimal(Console.ReadLine());
            decimal output2;
            math2.halfMath(y, out output2);

            Console.ReadLine();
        }
    }
}
