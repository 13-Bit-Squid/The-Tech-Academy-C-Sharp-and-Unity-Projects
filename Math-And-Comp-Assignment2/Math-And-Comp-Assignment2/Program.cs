using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_And_Comp_Assignment2
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Person 1");
            Console.WriteLine("Hourly Rate:");
            string personOneHourStr = Console.ReadLine();
            int personOneHourInt = Convert.ToInt32(personOneHourStr);

            Console.WriteLine("Hours worked per Week:");
            string personOneWorkStr = Console.ReadLine();
            int personOneWorkInt = Convert.ToInt32(personOneWorkStr);

            Console.WriteLine("Person 2");
            Console.WriteLine("Hourly Rate:");
            string personTwoHourStr = Console.ReadLine();
            int personTwoHourInt = Convert.ToInt32(personTwoHourStr);

            Console.WriteLine("Hours worked per Week:");
            string personTwoWorkStr = Console.ReadLine();
            int personTwoWorkInt = Convert.ToInt32(personTwoWorkStr);

            Console.WriteLine("Annual salary of Person 1:");
            int productOne = personOneHourInt * personOneWorkInt * 52;
            Console.WriteLine(productOne);
            Console.ReadLine();

            Console.WriteLine("Annual salary of Person 2:");
            int productTwo = personTwoHourInt * personTwoWorkInt * 52;
            Console.WriteLine(productTwo);
            Console.ReadLine();

            Console.WriteLine("Does Person 1 make more money than Person 2?");
            bool trueOrFalse =  productOne > productTwo;
            Console.WriteLine(trueOrFalse);
            Console.ReadLine();

        }
    }
}
