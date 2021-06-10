using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            string st1 = "We iz... ";
            string st2 = "Goin' to... ";
            string st3 = "waaaaaaaagh!!!";

            st3 = st3.ToUpper();

            StringBuilder ork = new StringBuilder();

            ork.Append("I'm da hand of Gork and Mork, dey sent me to rouse up da boyz to crush and kill ‘cos da boyz forgot what dere ‘ere for. ");
            ork.Append("I woz one of da boyz till da godz smashed me in da ‘ead an’ I ‘membered dat Orks is meant to conquer and make slaves of everyfing they don’t kill. ");
            ork.Append("I’m death to anyfing dat walks or crawls, where I go nothin’ stands in my way. ");

            Console.WriteLine(ork + st1 + st2 + st3);
            Console.ReadLine();
        }
    }
}
