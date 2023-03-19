using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodSubmission
{
    public class mainClass
    {
        public int Addition (int x) 
        {
            return x + 100; 
        }

        public int Addition (decimal x)
        {
            int y = Convert.ToInt32(x);
            return y + 500;
        }

        public int Addition (string x)
        {
            int z = Convert.ToInt32(x);
            return z + 200;
        }
    }
}
