using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

/*
What is the index of the first term in the Fibonacci sequence to contain 1000 digits?
 
Dan Purcell 28/10/15
*/

namespace Euler25
{
    class Program
    {           
        static BigInteger Fib(long n)
        {
            BigInteger c = 0;

            BigInteger a = 1;
            BigInteger b = 1;

            if (n == 1)
                return 1;

            if (n == 2)
                return 1;

            while (n > 2)
            {
                c = a + b;
                a = b;
                b = c;

                n--;
            }
            return c;
        }
        static void Main(string[] args)
        {
            long i = 0;
            int l = 0;
            while (l < 1000)
            {
                i++;
                l = Fib(i).ToString().Length;
            }

            Console.WriteLine(i);

            Console.ReadKey();
        }
    }
}
