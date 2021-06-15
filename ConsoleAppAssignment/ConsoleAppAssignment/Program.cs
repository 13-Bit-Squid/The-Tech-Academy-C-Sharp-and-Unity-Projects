using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Assignments 1-3 (Sorry I combined them)
            //string[] favCrittters = { "Rabbit", "Bear", "Tortoise", "Horse", "Dog", "Cat" };
            //Console.WriteLine("Please add your favorite animal.");
            //string critter = Console.ReadLine();
            //for (int i = 0; i < favCrittters.Length; i++) //Decrementing "i--" would result in an infinite loop, and so to solve this I incremented it. 
            ////for (int i = 0; i <= favCrittters.Length; i++) This results in an error.
            //{
            //    Console.WriteLine("\n" + favCrittters[i] + " " + critter);
            //}
            ////Assignment 4
            //List<string> members = new List<string>() { "Brian", "Joji", "Keith", "Niki", "Chungha", "Seori" };
            //Console.WriteLine("Type in a name to see if it's in the registry.");
            //string search = Console.ReadLine();
            //bool guess = false;
            //do
            //{
            //    if (members.Contains(search))
            //    {
            //        Console.WriteLine("The index of that member is: " + members.IndexOf(search));
            //        guess = true;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Sorry, there isn't anyone by that name in the registry, have a good day.");
            //        break;
            //    }
            //}
            //while (!guess);
            ////Assignment 5
            //List<string> members1 = new List<string>() { "Brian", "Joji", "Keith", "Brian", "Niki", "Chungha", "Seori" }; 
            //Console.WriteLine("Type in a name to see if it's in the registry.");
            //string search1 = Console.ReadLine();
            //bool guess1 = false;
            //do
            //{
            //    if (members1.Contains(search1))
            //    {
            //        Console.WriteLine("The index of that member is: " + members1.IndexOf(search1));
            //        guess1 = true;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Sorry, there isn't anyone by that name in the registry, have a good day.");
            //        break;
            //    }
            //}
            //while (!guess1);
            //Assignment 6
            List<string> members2 = new List<string>() { "Brian", "Joji", "Keith", "Brian", "Niki", "Chungha", "Seori" };
            List<string> newList = new List<string>();
            bool ischeck = newList.Contains(Convert.ToString(members2));

            foreach (var i in members2 )
            {
                if (newList.Contains(i))
                {
                    Console.WriteLine(i + " has already appeared in the list.");
                }
                else
                {
                    newList.Add(i);
                    Console.WriteLine("Is not already in the list.");
                }
            }

            Console.ReadLine();
        }
    }
}
