using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BranchingSubmissionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("Please enter the package weight:");
            int packWeight = Convert.ToInt32(Console.ReadLine());

            if (packWeight <= 50)
            {
                Console.WriteLine("Please enter the package width:");
                int packWidth = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please enter the package height:");
                int packHeight = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please enter the package length:");
                int packLength = Convert.ToInt32(Console.ReadLine());

                if (packHeight + packWidth + packLength <= 50)
                {
                    int quote = packHeight * packWidth * packLength;
                    int quoteTotal = quote * packWeight / 100;
                    Console.WriteLine("Your estimated total for shipping this package is: " + "$" + quoteTotal + ".00" + " Thank you!");
                }
                else
                {
                    Console.WriteLine("Package too big to be shipped via Package Express. Have a good day.");
                }
            }
            else
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            }
            Console.ReadLine();
        }
    }
}
