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
            prod = numA * 1;
            return prod;
        }

        public int MainOperator(decimal userInt)
        {
            int wholeNum;
            decimal numB = userInt;
            wholeNum = Convert.ToInt32(numB);
            return wholeNum;
        }

        public int MainOperator(string userStr)
        {
            int stringNum;
            string numC = userStr;
            stringNum = int.Parse(numC);
            return stringNum;
        }
    }
}
