using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
A permutation is an ordered arrangement of objects. For example, 3124 is one possible permutation of the digits 1, 2, 3 and 4.
If all of the permutations are listed numerically or alphabetically, we call it lexicographic order. The lexicographic permutations of 0, 1 and 2 are:

012   021   102   120   201   210

What is the millionth lexicographic permutation of the digits 0, 1, 2, 3, 4, 5, 6, 7, 8 and 9?

Dan Purcell 27/10/15 
*/

namespace Euler24
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            for (long i = 123456789; i < 9876543210; i++)
            {
                string s = i.ToString("D10");
                if (s.Contains('0') &&
                    s.Contains('1') &&
                    s.Contains('2') &&
                    s.Contains('3') &&
                    s.Contains('4') &&
                    s.Contains('5') &&
                    s.Contains('6') &&
                    s.Contains('7') &&
                    s.Contains('8') &&
                    s.Contains('9'))
                {
                    n++;
                    Console.WriteLine(n + " " + i.ToString("D8"));
                    if (n == 1000000)
                    {                        
                        break;
                    }
                }                
            }
            Console.ReadKey();
        }
    }
}
