using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsAssignment
{
    class Employee
    {
        public int ID { get; set; }

        public static bool operator ==(Employee employee, Employee employee1)
        {
            if(employee.ID == employee1.ID)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator !=(Employee employee, Employee employee1)
        {
            return employee.ID != employee1.ID;
        }

    }
}
