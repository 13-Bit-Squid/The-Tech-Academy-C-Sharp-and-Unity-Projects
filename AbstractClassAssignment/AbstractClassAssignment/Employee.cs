using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssignment
{
    class Employee : Person, IQuittable //step 2
    {
        public override void SayName()
        {
            Console.WriteLine("Name: [{0} {1}]", firstName, lastName);
            return;
        }

        public void Quit() 
        {
            Console.WriteLine("I quit!");
        }
    }
}
