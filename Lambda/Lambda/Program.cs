using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee em1 = new Employee()
            {
                Id = 1,
                firstName= "John",
                lastName= "Doe"
            };

            Employee em2 = new Employee()
            {
                Id = 2,
                firstName = "Joe",
                lastName = "Smith"
            };
            Employee em3 = new Employee()
            {
                Id = 3,
                firstName = "Lisa",
                lastName = "Johnson"                
            };
            Employee em4 = new Employee()
            {
                Id = 4,
                firstName = "Joe",
                lastName = "Johnson"
            };
            Employee em5 = new Employee()
            {
                Id = 5,
                firstName = "Lisa",
                lastName = "Smith"
            };
            Employee em6 = new Employee()
            {
                Id = 6,
                firstName = "Lauren",
                lastName = "Jackson"
            };
            Employee em7 = new Employee()
            {
                Id = 7,
                firstName = "Joe",
                lastName = "James"
            };
            Employee em8 = new Employee()
            {
                Id = 8,
                firstName = "Mary",
                lastName = "Smith"
            };
            Employee em9 = new Employee()
            {
                Id = 9,
                firstName = "Jack",
                lastName = "Brown"
            };
            Employee em10 = new Employee()
            {
                Id = 10,
                firstName = "Joe",
                lastName = "Brown"
            };

            List<Employee> Employees = new List<Employee>() { em1, em2, em3, em4, em5, em6, em7, em8, em9, em10 };
            //List<Employee> Joes = new List<Employee>();

            //foreach (Employee x in Employees)
            //{
            //    if (x.firstName != "Joe")
            //    {
            //        Console.WriteLine(x.Id + " is not named Joe.");
            //    }
            //    else
            //    {
            //        Console.WriteLine(x.Id + " is named Joe and will be added to the list.");
            //        Joes.Add(x);
            //    }
            //}
            //Console.WriteLine(Joes.Count + " total Joes in this workplace.");
            //Console.ReadLine();

            // creating a list of Joes using lambda expression
            List<Employee> Joes = Employees.Where(x => x.firstName == "Joe").ToList();
            Console.WriteLine(Joes.Count + " employees whose names start with Joe.");
            Console.ReadLine();

            List<Employee> newList = Employees.Where( x => x.Id > 5).ToList();
            Console.WriteLine(newList.Count + " employees whose ID number is greate than 5.");
            Console.ReadLine();

        }
    }
}
