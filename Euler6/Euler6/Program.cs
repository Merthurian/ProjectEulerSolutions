using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
The sum of the squares of the first ten natural numbers is,
1^2 + 2^2 + ... + 10^2 = 385
 * 
The square of the sum of the first ten natural numbers is,
(1 + 2 + ... + 10)^2 = 55^2 = 3025

Hence the difference between the sum of the squares of the first ten natural numbers and the square of the sum is 3025 − 385 = 2640.

Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.

Dan P 30/9/15
*/

namespace Euler6
{
    class Program
    {
        static void Main(string[] args)
        {
            long susq = 0;
            for (int i = 1; i < 101; i++)
            {
                susq += i * i;
            }

            long jT = 0;
            for (int j = 1; j < 101; j++)
            {
                jT += j;
            }
            long sqsu = jT * jT;

            Console.WriteLine(sqsu - susq);
            Console.ReadKey();
        }
    }
}
