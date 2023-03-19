using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadOperators
{
    public class Program
    {
        static void Main(string[] args)
        {
            Employee em1 = new Employee() { FirstName = "Bob", LastName = "Smith", Id = 1 };
            Employee em2 = new Employee() { FirstName = "Bob", LastName = "Jones", Id = 2 };
            Console.WriteLine(em1 == em2);
            Console.ReadLine();
            
        }
    }
}
