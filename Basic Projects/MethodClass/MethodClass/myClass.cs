using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClass
{
    public class myClass
    {
        public void Math(int x, int y, out int result)
        {
            result = x * 100;
            Console.WriteLine(x + " times 100 is equal to " + result);
            Console.WriteLine("The second number you entered is: " + y);
            
        }
    }
}
