using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodAssignment
{
    class Operations
    {
        public int MainOperator(int userInt)
        {
            int prod;
            int numA = userInt;
            prod = numA * 2;
            return prod;
        }

        public int MainOperator(decimal userDec)
        {
            int wholeNum;
            int prod2;
            decimal numB = userDec;
            prod2 = Convert.ToInt32(numB);
            wholeNum = prod2 * 5
            return wholeNum;
        }

        public int MainOperator(string userStr)
        {
            int stringNum;
            int prod3;
            string numC = userStr;
            prod3 = int.Parse(numC);
            stringNum = prod3 * 3;
            return stringNum;
        }
    }
}
