using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            int army = 4;
            switch (army)
            {
                case 1:
                    Console.WriteLine("Blood Angels");
                    break;
                case 2:
                    Console.WriteLine("Imperial Fists");
                    break;
                case 3:
                    Console.WriteLine("Dark Angels");
                    break;
                case 4:
                    Console.WriteLine("Ultra Marines");
                    break;
                case 5:
                    Console.WriteLine("White Scars");
                    break;
                case 6:
                    Console.WriteLine("Iron Hands");
                    break;
                case 7:
                    Console.WriteLine("Space Wolves");
                    break;
                case 8:
                    Console.WriteLine("Raven Guard");
                    break;
                case 9:
                    Console.WriteLine("Salamanders");
                    break;
            }
            Console.ReadLine();
        }
    }
}
