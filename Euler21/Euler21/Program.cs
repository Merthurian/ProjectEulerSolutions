using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
Let d(n) be defined as the sum of proper divisors of n (numbers less than n which divide evenly into n).
If d(a) = b and d(b) = a, where a ≠ b, then a and b are an amicable pair and each of a and b are called amicable numbers.

For example, the proper divisors of 220 are 1, 2, 4, 5, 10, 11, 20, 22, 44, 55 and 110; therefore d(220) = 284. The proper divisors of 284 are 1, 2, 4, 71 and 142; so d(284) = 220.

Evaluate the sum of all the amicable numbers under 10000.

Dan Purcell 23/10/15
*/

namespace Euler21
{
    class Program
    {
        static long ProperDivisorSum(long n)
        {
            long total = 0;
            for (long k = 1; k < (n/2)+1; k++)
            {
                total += (n%k == 0) ? k : 0;
            }
            return total;
        }

        static void Main(string[] args)
        {
            int total = 0;
            for (int i = 1; i < 10000; i++)
            {
                long iPDSum = ProperDivisorSum(i);

                if (ProperDivisorSum(iPDSum) == i && i != iPDSum)
                {
                    total += i;
                }
                    
                
            }
            Console.WriteLine(total);
            Console.ReadKey();
        }
    }
}
