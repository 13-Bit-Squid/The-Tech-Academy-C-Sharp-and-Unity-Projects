using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalStatementChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            //string name = "Ty";

            //if (name == "Makayla")
            //{
            //    Console.WriteLine("Hi Makayla! :D");
            //}

            //else if (name == "Ty")
            //{
            //    Console.WriteLine("Howdy, howdy Ty!");
            //}

            //else 
            //{
            //    Console.WriteLine("WHO ARE YOU??");
            //}

            //if (8 != 9)
            //{
            //    Console.WriteLine("Business as usual.");
            //}

            //else
            //{
            //    Console.WriteLine("Something is clearly, very, very wrong...");
            //}
            //Console.ReadLine();

            if (8 > 5)
            {
                Console.WriteLine("8 is greater than 5.");
            }

            else
            {
                Console.WriteLine("Somehow, 8 is less than 5...");
            }
            Console.ReadLine();

            if (8 < 5)
            {
                Console.WriteLine("Somehow, 8 is less than 5...");
            }

            else
            {
                Console.WriteLine("8 is greater than 5.");
            }
            Console.ReadLine();
        }
    }
}
