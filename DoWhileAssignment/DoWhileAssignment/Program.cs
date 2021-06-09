using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoWhileAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess my favorite number!");
            int guessNum = Convert.ToInt32(Console.ReadLine());
            bool favNum = guessNum == 13;

            //while (!favNum)
            //{
            //    switch (guessNum)
            //    {
            //        case 12:
            //            Console.WriteLine("Sorry, that's not the right number... You're so close! Try again!");
            //            Console.WriteLine("Guess my favorite number!");
            //            guessNum = Convert.ToInt32(Console.ReadLine());
            //            break;

            //        case 13:
            //            Console.WriteLine("Congratulations!! You've guessed my favorite number! Pat yourself on the back, well done!");
            //            favNum = true;
            //            break;

            //        case 14:
            //            Console.WriteLine("Sorry, that's not the right number... You're so close! Try again!");
            //            Console.WriteLine("Guess my favorite number!");
            //            guessNum = Convert.ToInt32(Console.ReadLine());
            //            break;

            //        default:
            //            Console.WriteLine("Sorry, that's not the right number... Try again!");
            //            Console.WriteLine("Guess my favorite number!");
            //            guessNum = Convert.ToInt32(Console.ReadLine());
            //            break;
            //    }
            //}
            //Console.ReadLine();

            do
            {
                switch (guessNum)
                {
                    case 12:
                        Console.WriteLine("Sorry, that's not the right number... You're so close! Try again!");
                        Console.WriteLine("Guess my favorite number!");
                        guessNum = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 13:
                        Console.WriteLine("Congratulations!! You've guessed my favorite number! Pat yourself on the back, well done!");
                        favNum = true;
                        break;

                    case 14:
                        Console.WriteLine("Sorry, that's not the right number... You're so close! Try again!");
                        Console.WriteLine("Guess my favorite number!");
                        guessNum = Convert.ToInt32(Console.ReadLine());
                        break;

                    default:
                        Console.WriteLine("Sorry, that's not the right number... Try again!");
                        Console.WriteLine("Guess my favorite number!");
                        guessNum = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }
            while (!favNum);
            Console.ReadLine();
        }
    }
}
