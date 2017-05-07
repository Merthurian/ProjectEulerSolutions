using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
The sum of the primes below 10 is 2 + 3 + 5 + 7 = 17.

Find the sum of all the primes below two million.
 
Dan Purcell 7/10/15
*/

namespace Euler10
{
    class Program
    {
        static bool isPrime(long n)
        {
            if (n < 2)
                return false;
            for (int i = 2; i * i <= n; i++)
            {
                if (n % i == 0)
                    return false;
            }
            return true;
        }
        static void Main(string[] args)
        {
            long t = 0;
            for (int i = 0; i < 2000000; i++)
            {
                if (isPrime(i)) 
                {
                    t += i;
                }
            }
            Console.WriteLine(t);
            Console.ReadKey();
        }
    }
}
