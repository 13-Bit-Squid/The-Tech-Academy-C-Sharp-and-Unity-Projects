using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAssignment
{
    class VoidAgain
    {
        public void DivTwo(int a)
        {
            int Quotient = a / 2;
            Console.WriteLine("Your number {0}, divided by 2 is: {1}", a, Quotient);
        }
        static string DivTwo(string b)
        {
            Console.WriteLine("You really just put words in a math request??");
            return b;
        }
    }
}
