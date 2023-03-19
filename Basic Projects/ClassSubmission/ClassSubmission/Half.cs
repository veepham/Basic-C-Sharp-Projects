using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSubmission
{
    public class Half
    {

        public void halfMath(int input, out int output)
        {
            output = input / 2;
            Console.WriteLine(input + " divided by 2 equals " + output);
        }

        public void halfMath(decimal input, out decimal output)
        {
            output = input / 2;
            Console.WriteLine(input + " divided by 2 equals " + output);
        }

    }
}
