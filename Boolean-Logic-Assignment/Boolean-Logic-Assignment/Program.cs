using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boolean_Logic_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");
            string whatAgeStr = Console.ReadLine();
            int whatAgeInt = Convert.ToInt32(whatAgeStr);

            Console.WriteLine("Have you ever had a DUI? Please type True or False");
            string duiStr = Console.ReadLine();
            bool duiBool = Convert.ToBoolean(duiStr);

            Console.WriteLine("How many speeding tickets do you have?");
            string speTicStr = Console.ReadLine();
            int speTicInt = Convert.ToInt32(speTicStr);

            bool carInsur = whatAgeInt > 15 && duiBool == false && speTicInt < 3;
            Console.WriteLine("Qualified?");
            Console.WriteLine(carInsur);
            Console.ReadLine();
        }
    }
}
