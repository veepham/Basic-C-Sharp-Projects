using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IterationAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Assignment Part One 
            string[] stringArray = { "Hi my name is ", "You can call me ", "Lets go " };

            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();

            for (int i = 0; i < stringArray.Length; i++)
            {
                stringArray[i] = stringArray[i] + name;             
            }

            for (int i = 0; i < stringArray.Length; i++)
            {
                Console.WriteLine(stringArray[i]);
                Console.ReadLine();
            }
            

            //________________****************_________________________//

            //Assignment Part Two Infinite Loop
            List<int> myNumbers = new List<int>() { 98, 99, 12, 74, 23, 99 };

            //My infinite loop:
            //while(true)
            //{
            //    Console.WriteLine("this is working");
            //}

            foreach (int number in myNumbers) // adding a specific condition to ensure the loop ends
            {
                if (number > 5)
                {
                    Console.WriteLine("this is working");
                }
            }
            Console.ReadLine();

            //________________****************_________________________//
            //Assignment Part 3:
            List<int> testScores = new List<int>() { 98, 99, 12, 74, 23, 59 };
            foreach (int score in testScores) 
            {
                if (score < 60) 
                {
                    Console.WriteLine("Your score was " + score + " so you failed.");
                }
            }
            Console.ReadLine();

            foreach (int score in testScores)
            {
                if (score <= 30)
                {
                    Console.WriteLine("Your score was " + score + " so you REALLY failed.");
                }
            }
            Console.ReadLine();

            //________________****************_________________________//
            //Assignment Part 4:
            List<string> players = new List<string>() { "Dame", "Anfernee", "Shaedon", "Jerami", "Jusuf" };

            Console.WriteLine("Who is the star of the Portland Trailblazers?");
            string star = Console.ReadLine();

            foreach (string player in players) 
            {
                if (player == star)
                {
                    Console.WriteLine("The player you chose is listed in our list at number " + players.IndexOf(star));
                    break;
                }
            }

            if (!players.Contains(star))
            {
                Console.WriteLine("This player is not on the starting 5 list.");
            }
            Console.ReadLine();


            //________________****************_________________________//
            //Assignment Part 5:
            List<string> animals = new List<string>() { "dog", "cat", "bird", "cow", "dog", "cat", "fish", "dog" };

            Console.WriteLine("What animal makes a great pet? \nIf your choice is on the list, we will give you the listed position(s) of that animal on our list.");
            string pet = Console.ReadLine();

            bool matchExists = false;
            for (int x=0; x < animals.Count; x++)
            {
                if (animals[x] == pet)
                {
                    matchExists = true;                 
                    Console.WriteLine(x);
                }
            }

            if (matchExists == false)
            { 
                Console.WriteLine("this is not an animal on the list!");
            }
            
            Console.ReadLine();

            //________________****************_________________________//
            //Assignment Part 6:
            List<string> letters = new List<string>() { "A", "B", "C", "B", "E", "B" };
            List<string> duplicates = new List<string>() { };

            foreach (string letter in letters)
            {                
                if (duplicates.Contains(letter))
                {
                    Console.WriteLine(letter + " - this item is a duplicate.");
                }
                else
                {
                    Console.Write(letter + " - this item is unique.\n");
                    duplicates.Add(letter);
                }
            }
            Console.ReadLine();

        }
    }
}
