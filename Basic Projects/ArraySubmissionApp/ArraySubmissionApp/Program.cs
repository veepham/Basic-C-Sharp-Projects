using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySubmissionApp
{
    internal class Program
    {
        static void Main()
        {
            string[] stringArray = { "cat", "dog", "cow", "chicken", "fox" };

            Console.WriteLine("Pick a number 0-4 to display a word.");
            int chosenNum = Convert.ToInt32(Console.ReadLine());

            if (chosenNum < 0 || chosenNum > stringArray.Length - 1)
            {
                Console.WriteLine("This position does not exist in the array. Better luck next time.");
                Console.ReadLine();

            }
            else
            {
                Console.WriteLine("The position you selected contains the animal: " + stringArray[chosenNum]);
                Console.ReadLine();
            }
            

            int[] numArray = { 1, 2, 3, 4, 5, 6 };
            Console.WriteLine("Pick a number to display a number from the array.");
            int arrayNum = Convert.ToInt32(Console.ReadLine());
            if (arrayNum < 0 || arrayNum > numArray.Length - 1) 
            {
                Console.WriteLine("This position does not exist in the array. Better luck next time.");
                Console.ReadLine();
                
            }
            else
            {
                Console.WriteLine("The position you selected contains the number: " + numArray[arrayNum]);
                Console.ReadLine();
            }
            
            List<string> list = new List<string>();
            list.Add("This is a sentence.");
            list.Add("How are you today?");
            list.Add("The sky is blue.");

            Console.WriteLine("Pick a number from 0-2 for a random sentence.");
            int indexNum = Convert.ToInt32(Console.ReadLine());
            if (indexNum < 0 || indexNum > list.Count - 1)
            {
                Console.WriteLine("This position does not exist in the list. Better luck next time.");
                Console.ReadLine();

            }
            else
            {
                Console.WriteLine(list[indexNum]);
                Console.ReadLine();
            }

            
        }
    }
}
