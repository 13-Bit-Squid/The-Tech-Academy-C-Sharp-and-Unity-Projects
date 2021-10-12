namespace parsingEnums
{
    internal class ProgramBase
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Please enter the current day of the week.");
                var x = Console.ReadLine();

                DaysOfTheWeek day = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), x);
                Console.WriteLine("Today is " + x);
                Console.ReadLine();
            }
    }
}