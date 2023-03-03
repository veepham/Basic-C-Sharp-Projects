using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dtSubmission
{
    class Program
    {
        static void Main(string[] args)
        {            
            Console.WriteLine("It is currently " + DateTime.Now);
            Console.ReadLine();

            Console.WriteLine("Please enter a number from 1-12.");
            int x = Convert.ToInt32(Console.ReadLine());
            DateTime later = DateTime.Now.AddHours(x);

            Console.WriteLine("In " + x + " hour(s), it will be " + later);
            Console.ReadLine();

        }
    }
}
