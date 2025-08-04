using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ULernC_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(LeapYear(315,1864));
        }

        static int LeapYear(int year1, int year2)
        {
            int years = (year2/4) - ((year1-1)/4);
            int hundyears = year2 / 100 - year1 / 100;
            int leap = years - (hundyears - (hundyears / 4));
            return leap;
        }
    }
}
