using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
A palindromic number reads the same both ways. The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.

Find the largest palindrome made from the product of two 3-digit numbers.

Dan P 30/9/15
*/

namespace Euler4
{
    class Program
    {
        static bool isPalindrome(long n)
        {
            string s = Convert.ToString(n);
            if (s == new string(s.Reverse().ToArray()))
                return true;
            return false;
            
        }
        static void Main(string[] args)
        {
            long best = 0;
            for (int x = 100; x < 1000; x++)
            {
                for (int y = 100; y < 1000; y++)
                {
                    long i = x * y;
                    if ((i > best) && (isPalindrome(i)))
                        best = i;
                }
            }
            Console.WriteLine(best);
            Console.ReadKey();
        }
    }
}
