using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethodsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input a number to be added, subtracted, and multiplied by 8.");
            int userNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The sum of 8 plus " + userNum + " is: " + MathOperators.AddItem(userNum));
            Console.WriteLine("The difference of 8 minus " + userNum + " is: " + MathOperators.SubItem(userNum));
            Console.WriteLine("The product of 8 times " + userNum + " is: " + MathOperators.MultItem(userNum));

            Console.ReadLine();
        }
    }
}
