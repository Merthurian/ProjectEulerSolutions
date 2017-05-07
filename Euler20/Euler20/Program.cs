using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

/*
n! means n × (n − 1) × ... × 3 × 2 × 1

For example, 10! = 10 × 9 × ... × 3 × 2 × 1 = 3628800,
and the sum of the digits in the number 10! is 3 + 6 + 2 + 8 + 8 + 0 + 0 = 27.

Find the sum of the digits in the number 100!
 
Dan Purcell 14/10/15
*/

namespace Euler20
{
    class Program
    {
        static BigInteger Factorial(long n)
        {
            BigInteger x = 1;
            for (long i = n; i > 0; i--)
            {
                x *= i;
            }
            return x;
        }
        static void Main(string[] args)
        {
            BigInteger f = Factorial(100);

            string s = f.ToString();

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
