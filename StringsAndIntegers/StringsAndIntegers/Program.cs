using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsAndIntegers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<int> myNumbers = new List<int>() { 98, 99, 12, 74, 23, 59 };

                Console.WriteLine("Choose a number to divide each number in our list by.");
                int yourNumber = Convert.ToInt32(Console.ReadLine());

                foreach (int number in myNumbers)
                {
                    int result = number / yourNumber;
                    Console.WriteLine(number + " divide by " + yourNumber + " equals to " + result);
                }
            }

            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message + "\nPlease type a whole number.");
                return;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Please don't divide by zero.");
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Thanks for playing the game!");
                Console.ReadLine();
            }

        }
    }
}
