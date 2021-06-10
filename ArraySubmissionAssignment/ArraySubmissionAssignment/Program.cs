using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySubmissionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {

            //string[] stringArray = { "red", "orange", "yellow", "green", "blue", "indigo", "violet" };
            //Console.WriteLine("Pick and submit a number between 0 and 6 to select a color in the array.");
            //int colorArray = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Your color is: " + stringArray[colorArray]);

            //int[] intArray = { 4, 6, 8, 13, 42, 56, 64 };
            //Console.WriteLine("Pick and submit a number between 0 and 6 to select a number in the array.");
            //int numArray = Convert.ToInt32(Console.ReadLine());
            //if (numArray < 7)
            //{
            //    Console.WriteLine("Your number is: " + intArray[numArray]);
            //} 
            //else
            //{
            //    Console.WriteLine("Sorry, the number at that position isn't in the array.");
            //}

            List<string> stringList = new List<string>();
            stringList.Add("Jellyfish");
            stringList.Add("Sea Cucumber");
            stringList.Add("Squid");
            stringList.Add("Clam");
            Console.WriteLine("Pick and submit a number between 0 and 3 to select an ocean creature in the array.");
            int numList = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your ocean creature is: " + stringList[numList]);

            Console.ReadLine();

        }
    }
}
