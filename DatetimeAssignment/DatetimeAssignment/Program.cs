using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatetimeAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);
            Console.WriteLine("Please input a number.");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(DateTime.Now.AddHours(x));
            Console.ReadLine();
        }
    }
}
