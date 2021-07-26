using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.ID = 1;
            Employee employee1 = new Employee();
            employee1.ID = 2;

            Console.WriteLine(employee == employee1);
            Console.ReadLine();

        }
    }
}
