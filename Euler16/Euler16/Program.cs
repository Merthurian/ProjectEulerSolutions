using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

/*
2^15 = 32768 and the sum of its digits is 3 + 2 + 7 + 6 + 8 = 26.

What is the sum of the digits of the number 2^1000?
*/

namespace Euler16
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger big = (BigInteger)Math.Pow(2, 1000);

            string s = big.ToString();

            Console.WriteLine(s);

            long total = 0;

            for (int i = 0; i < s.Length; i++)
            {
                total += (int)Char.GetNumericValue(s[i]);
            }

            Console.WriteLine(total);
            Console.ReadKey();
        }
    }
}
