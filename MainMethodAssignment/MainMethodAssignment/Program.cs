using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodAssignment
{
    class Program
    {
        static void Main()
        {

            Operations operations1 = new Operations();
            Console.WriteLine("please write any integer, to be converted into an integer.");
            int userint = Convert.ToInt32(Console.ReadLine());
            int answer1 = operations1.MainOperator(userint);
            Console.WriteLine("your number as an integer is {0}", answer1);

            Operations operations2 = new Operations();
            Console.WriteLine("Please write any decimal, to be converted into an integer.");
            decimal userDec = Convert.ToDecimal(Console.ReadLine());
            int answer2 = operations2.MainOperator(userDec);
            Console.WriteLine("Your number as an integer is {0}", answer2);

            Operations operations3 = new Operations();
            Console.WriteLine("Please write input any number, to be converted into an integer.");
            string userStr = Console.ReadLine();
            int answer3 = operations3.MainOperator(userStr);
            Console.WriteLine("Your number as an integer is {0}", answer3);

            Console.ReadLine();
        }
    }
}
