using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParamatersAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> employee1 = new Employee<string>
            {
                Things = new List<string>()
            };
            employee1.Things.Add("Nick");
            employee1.Things.Add("Matt");
            employee1.Things.Add("Zaxton");
            employee1.Things.Add("Makayla");

            Employee<int> employee2 = new Employee<int>
            {
                Things = new List<int>()
            };
            employee2.Things.Add(4);
            employee2.Things.Add(6);
            employee2.Things.Add(8);
            employee2.Things.Add(13);

            foreach(string thing in employee1.Things)
            {
                Console.WriteLine(thing);
            }

            foreach (int thing in employee2.Things)
            {
                Console.WriteLine(thing);
            }
            Console.ReadLine();
        }
    }
}
