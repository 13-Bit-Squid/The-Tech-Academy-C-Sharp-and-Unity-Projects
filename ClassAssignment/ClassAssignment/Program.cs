using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            VoidAgain voidAgain = new VoidAgain();
            Console.WriteLine("Please input a number to be divided by 2.");
            int a = Convert.ToInt32(Console.ReadLine());
            voidAgain.DivTwo(a);
            Console.ReadLine();
        }
    }
}
