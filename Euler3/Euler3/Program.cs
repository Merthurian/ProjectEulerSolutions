using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
The prime factors of 13195 are 5, 7, 13 and 29.

What is the largest prime factor of the number 600851475143 ?

Dan P 30/9/15
*/
namespace Euler3
{
    class Program
    {
        static bool isPrime(long n)
        {
            for (int i = 2; i * i <= n; i++)
            {                
                if (n % i == 0)
                    return false;
            }
            return true;
        }
        static void Main(string[] args)
        {
            long s = Convert.ToInt64(Math.Sqrt(600851475143)); // Made sense to start here and work backwards
            for (long i = s; i > 0; i--)
            {
                if (600851475143 % i == 0)
                {
                    if (isPrime(i))
                    {
                        Console.WriteLine(i);
                        break;
                    }
                }
            }
                
            Console.ReadKey();
        }
    }
}
