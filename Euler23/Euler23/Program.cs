using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
A perfect number is a number for which the sum of its proper divisors is exactly equal to the number.
For example, the sum of the proper divisors of 28 would be 1 + 2 + 4 + 7 + 14 = 28, which means that 28 is a perfect number.

A number n is called deficient if the sum of its proper divisors is less than n and it is called abundant if this sum exceeds n.

As 12 is the smallest abundant number, 1 + 2 + 3 + 4 + 6 = 16, the smallest number that can be written as the sum of two abundant numbers is 24.
By mathematical analysis, it can be shown that all integers greater than 28123 can be written as the sum of two abundant numbers.
However, this upper limit cannot be reduced any further by analysis even though it is known that the greatest number that cannot be expressed
as the sum of two abundant numbers is less than this limit.

Find the sum of all the positive integers which cannot be written as the sum of two abundant numbers.

Dan Purcell 26/10/15
*/

namespace Euler23
{
    class Program
    {
        static int limit = 28123;
        static long ProperDivisorSum(long n)
        {
            long total = 0;
            for (long k = 1; k < (n / 2) + 1; k++)
            {
                total += (n % k == 0) ? k : 0;
            }
            return total;
        }

        static bool CanBeSumOf2Abuntants(long n)
        {
            for (long i = 1; i < (n/2)+1; i++)
            {
                if (IsAbundant(i) && IsAbundant(n - i))
                    return true;
            }
            return false;
        }

        static bool IsAbundant(long n)
        {
            return (ProperDivisorSum(n) > n) ? true : false;
        }

        static void Main(string[] args)
        {
            long total = 0;

            for (int i = 1; i < limit; i++)
            {
                if (!CanBeSumOf2Abuntants(i))
                {
                    Console.WriteLine(i);
                    total += i;
                }
            }

            Console.WriteLine(total);
            Console.ReadKey();
        }
    }
}
