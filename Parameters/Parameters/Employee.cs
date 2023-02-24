using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parameters
{
    public class Employee<T>
    {
        public List<T> Things { get; set; }
    }
}
