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
            Console.WriteLine("please write any number, to be converted into an integer, then multiplied by 2.");
            int userint = Convert.ToInt32(Console.ReadLine());
            int answer1 = operations1.MainOperator(userint);
            Console.WriteLine("your number as an integer is: {0}, multiplied by 2 is: {1}", userint, answer1);

            Operations operations2 = new Operations();
            Console.WriteLine("Please write any decimal, to be converted into an integer, then multiplied by 5.");
            decimal userDec = Convert.ToDecimal(Console.ReadLine());
            int answer2 = operations2.MainOperator(userDec);
            Console.WriteLine("Your number as an integer is: {0}, multiplied by 5 is: {1}", userDec, answer2);

            Operations operations3 = new Operations();
            Console.WriteLine("Please input any number as a string, to be converted into an integer, then multiplied by 3.");
            string number = Console.ReadLine();
            int answer3 = operations3.WordNumberToInt(number);
            Console.WriteLine("Your number as an integer is: {0}, multiplied by 3 is: {1}", number, answer3);

            Console.ReadLine();
        }
    }
}
