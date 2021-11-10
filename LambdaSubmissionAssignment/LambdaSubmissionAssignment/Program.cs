using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaSubmissionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            var employees = new List<Employee>()
            {
                new Employee(){ Id = 1, FirstName = "Joe", LastName = "Mah-Mah"},
                new Employee(){ Id = 2, FirstName = "Joe", LastName = "Chang"},
                new Employee(){ Id = 3, FirstName = "Matt", LastName = "Tan"},
                new Employee(){ Id = 4, FirstName = "Makayla", LastName = "Goslant"},
                new Employee(){ Id = 5, FirstName = "Ben", LastName = "Chew"},
                new Employee(){ Id = 6, FirstName = "Nick", LastName = "Bellendir"},
                new Employee(){ Id = 7, FirstName = "Clyde", LastName = "Whitaker"},
                new Employee(){ Id = 8, FirstName = "Zaxton", LastName = "Koplin"},
                new Employee(){ Id = 9, FirstName = "Gavin", LastName = "Sun"},
                new Employee(){ Id = 10, FirstName = "Xavier", LastName = "Gennet"}
            };
            foreach (Employee joe in employees)
            {
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
