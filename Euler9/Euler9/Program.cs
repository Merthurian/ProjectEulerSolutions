using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
A Pythagorean triplet is a set of three natural numbers, a < b < c, for which,

a2 + b2 = c2
For example, 32 + 42 = 9 + 16 = 25 = 52.

There exists exactly one Pythagorean triplet for which a + b + c = 1000.
Find the product abc.

Dan P 6/10/15
*/

namespace Euler9
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int a = 1; a < 1000; a++)
            {
                for (int b = 1; b < 1000; b++)
                {
                    for (int c = 1; c < 1000; c++)
                    {
                        if (a + b + c == 1000)
                        {
                            if (a * a + b * b == c * c)
                            {
                                if ((a < b) && (b < c)){
                                    Console.WriteLine(a * b * c);
                                    break;
                                }
                            }
                        }
                    }
                }
                
            }
            Console.ReadKey();
        }
    }
}
