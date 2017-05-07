using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

/*
Starting in the top left corner of a 2×2 grid, and only being able to move to the right and down, there are exactly 6 routes to the bottom right corner.

How many such routes are there through a 20×20 grid?


Brute forcing was useless so I looked up the sequence of answers for smaller grids. Turns out it's the 'Central Binomial Coefficients' i.e the central numbers of pascals triangle.
So the answer is (2*n)!(n!)^2 .. easy

Dan Purcell 12/10/15
*/

namespace Euler15
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
            int size = 20;
            BigInteger fs = Factorial(size);
            BigInteger ans = Factorial(2 * size) / (fs*fs);
            Console.WriteLine(ans);
            Console.ReadKey();
        }
    }
}
