using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethodsAssignment
{
    public class MathOperators
    {
        public static int AddItem(int userNum)
        {
            int sum;
            int numA = userNum;
            sum =  8 + numA;
            return sum;
        }
        public static int SubItem(int userNum)
        {
            int diff;
            int numB = userNum;
            diff = 8 - numB;
            return diff;
        }
        public static int MultItem(int userNum)
        {
            int prod;
            int numC = userNum;
            prod = 8 * numC;
            return prod;
        }
    }
}
