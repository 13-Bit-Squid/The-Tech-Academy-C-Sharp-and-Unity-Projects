using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace InputChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input any number of choice!");
            string number = Console.ReadLine();
            File.WriteAllText(@"D:\\Documents\\Logs\\log2.txt", number);
            string read = File.ReadAllText(@"D:\\Documents\\Logs\\log2.txt");
            Console.WriteLine(read);
            Console.ReadLine();
        }
    }
}
