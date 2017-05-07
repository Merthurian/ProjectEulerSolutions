using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Euler26
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(RepeatingDecimals(287476,7));
            Console.ReadKey();
        }

        static int RepeatingDecimals(int numerator, int divisor)
        {
            string s = numerator.ToString();

            int depth = 4;
            int n = int.Parse(numerator.ToString().Substring(0,depth));

            return n;
        }

        static int[] QuoRem(int numerator, int divisor)
        {
            return new int[2] { numerator / divisor, numerator % divisor };
        }
    }
}
