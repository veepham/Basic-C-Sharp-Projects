using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ParsingEnums
{
    class Program
    {

        public enum DaysOfWeek
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
        static void Main(string[] args)
        {
            try 
            {
                Console.WriteLine("Please enter a day of the week:");
                string day = Console.ReadLine();
                DaysOfWeek yourDay = (DaysOfWeek) Enum.Parse(typeof(DaysOfWeek), day, true); //ignores case and saves input as variable of enum data type 

                Console.WriteLine(yourDay);     

            }

            catch (Exception ex)
            {
                Console.WriteLine("Please enter an actual day of the week.");
            }

            
        }

       
    }
}
