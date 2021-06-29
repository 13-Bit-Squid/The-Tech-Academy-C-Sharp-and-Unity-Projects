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
            return;
        }
        public void DivTwo(out int b)
        {
            b = 13;
            b *= b;
        }
    }
}
