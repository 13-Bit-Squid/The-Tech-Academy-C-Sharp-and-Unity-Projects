using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TernaryOperatorChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 42;
            int num2 = 56;

            string result = num1 < num2 ? "num1 is less than num2." : "num1 is greater than num2.";
            Console.WriteLine(result);
            Console.ReadLine();

        }
    }
}
