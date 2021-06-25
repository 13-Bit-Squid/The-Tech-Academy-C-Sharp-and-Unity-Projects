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
            wholeNum = prod2 * 5;
            return wholeNum;
        }

        public int WordNumberToInt(string number) //I used the majority of this code from user @Kevin on stack overflow.com and just modified the bottom to suit the end purpose of this assignment. URL: https://stackoverflow.com/questions/11278081/convert-words-string-to-int
        {
            string[] ones = {
              "one", "two", "three", "four", "five", "six",
              "seven", "eight", "nine"
            };
            string[] teens = {
              "eleven", "twelve", "thirteen", "fourteen", "fifteen",
              "sixteen", "seventeen", "eighteen", "nineteen"
            };
            string[] tens = {
              "ten", "twenty", "thirty", "forty", "fifty", "sixty",
              "seventy", "eighty", "ninety"
            };
            var bigscales = new Dictionary<string, int>() {
              {"hundred", 100}, {"hundreds", 100}, {"thousand", 1000},
              {"million", 1000000}, {"billion", 1000000000},
            };
            string[] minusWords = { "minus", "negative" };
            var splitchars = new char[] { ' ', '-', ',' };

            var lowercase = number.ToLower();
            var inputwords = lowercase.Split(splitchars, StringSplitOptions.RemoveEmptyEntries);

            int result = 0;
            int currentResult = 0;
            int bigMultiplierValue = 1;
            bool bigMultiplierIsActive = false;
            bool minusFlag = false;

            foreach (string curword in inputwords)
            {
                if (bigscales.ContainsKey(curword))
                {
                    bigMultiplierValue *= bigscales[curword];
                    bigMultiplierIsActive = true;
                }
                else
                {
                    if (bigMultiplierIsActive)
                    {
                        result += currentResult * bigMultiplierValue;
                        currentResult = 0;
                        bigMultiplierValue = 1; 
                        bigMultiplierIsActive = false; 
                    }

                    int n;
                    if ((n = Array.IndexOf(ones, curword) + 1) > 0)
                    {
                        currentResult += n;
                    }
                    else if ((n = Array.IndexOf(teens, curword) + 1) > 0)
                    {
                        currentResult += n + 10;
                    }
                    else if ((n = Array.IndexOf(tens, curword) + 1) > 0)
                    {
                        currentResult += n * 10;
                    }
                    else if (minusWords.Contains(curword))
                    {
                        minusFlag = true;
                    }
                    else if (curword == "zero")
                    {
                        continue;
                    }
                    else if (int.TryParse(curword, out int tmp))
                    {
                        currentResult += tmp;
                    }
                    else if (curword != "and")
                    {
                        throw new ApplicationException("Expected a number: " + curword);
                    }
                }
            }
            int stringNum;
            var final = result + currentResult * bigMultiplierValue;
            if (minusFlag)
                final *= -1;
            stringNum = final * 3;
            return stringNum;
        }
    }
}
