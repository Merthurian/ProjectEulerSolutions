using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Euler7
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
            int n = 1;
            long i = 0;

            while (n < 10002)
            {
                i++;
                if (isPrime(i))
                {
                    n++;
                }
            }
            Console.WriteLine(i);
            Console.ReadKey();
        }
    }
}
