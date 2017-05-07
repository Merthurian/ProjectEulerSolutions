using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.
Find the sum of all the multiples of 3 or 5 below 1000.

Dan P
30/9/15
*/

namespace Euler1
{
    class Program
    {
        static void Main(string[] args)
        {
            int total = 0;
            for (int i = 0; i < 1000; i++)
            {
                if (i % 3 == 0 | i % 5 == 0)
                    total += i;
            }
            Console.Write(total);
            Console.ReadKey();
        }
    }
}
