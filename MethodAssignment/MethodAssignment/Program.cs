using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAssignment
{
    class Program
    {
        static void Main()
        {
            MathOperation mathOperation = new MathOperation();
            Console.WriteLine("Please input an integer to multiply by 5.");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = 0;
            Console.WriteLine("If you wish to add an additional number to " + a + ", please input it in the following line.");
            string c = Console.ReadLine();
            if (string.IsNullOrEmpty(c))
            {
                b = 0;
            }
            else
            {
               b = int.Parse(c);
            }
            int answer = mathOperation.MultiStepMath(a, b);
            Console.WriteLine("Your answer is: {0}", answer);
            Console.ReadLine();
        }
    }
}
