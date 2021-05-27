using System;

namespace DailyReportAssignment
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("The Tech Academy.");
            Console.WriteLine("Student Daily Report.");
            Console.ReadLine();

            Console.WriteLine("What is your name?");
            string yourName = Console.ReadLine();
            Console.WriteLine("Your name is: " + yourName + ".");
            Console.ReadLine();

            Console.WriteLine("What course are you on?");
            string yourCourse = Console.ReadLine();
            Console.WriteLine("You're currently taking the " + yourCourse + " course.");
            Console.ReadLine();

            Console.WriteLine("What page number are you on? (Please only answer in a numerical value.)");
            string pageNumber = Console.ReadLine();
            int pagNum = Convert.ToInt32(pageNumber);
            Console.WriteLine("You're currently on page " + pagNum + ".");
            Console.ReadLine();

            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false.\"");
            string studyHelp = Console.ReadLine();
            bool assisting = Convert.ToBoolean(studyHelp);

            Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics.");
            string yourExp = Console.ReadLine();
            Console.ReadLine();

            Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
            string yourFeBack = Console.ReadLine();
            Console.ReadLine();

            Console.WriteLine("How many hours did you study today?");
            string hours = Console.ReadLine();
            int hourstotal = Convert.ToInt32(hours);
            Console.WriteLine("Great job getting " + hourstotal + " hours in!");
            Console.ReadLine();

            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
            Console.ReadLine();
        }
    }
}
