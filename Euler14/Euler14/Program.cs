using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
The following iterative sequence is defined for the set of positive integers:

n → n/2 (n is even)
n → 3n + 1 (n is odd)

Using the rule above and starting with 13, we generate the following sequence:

13 → 40 → 20 → 10 → 5 → 16 → 8 → 4 → 2 → 1
It can be seen that this sequence (starting at 13 and finishing at 1) contains 10 terms. Although it has not been proved yet (Collatz Problem), it is thought that all starting numbers finish at 1.

Which starting number, under one million, produces the longest chain?

NOTE: Once the chain starts the terms are allowed to go above one million.
 
Dan Purcell 9/10/15
*/

namespace Euler14
{
    class Program
    {
        static void Main(string[] args)
        {
            int longest = 0;
            int champ = 0;
            for (int i = 1; i < 1000000; i++)
            {
                //Console.WriteLine(i);
                long n = i;
                int chain = 1;
                while (n != 1)
                {
                    if (n % 2 == 0)
                        n /= 2;
                    else
                        n = (3 * n) + 1;

                    chain++;
                    //Console.Write(".");
                }
                if (chain > longest)
                {
                    longest = chain;
                    champ = i;
                    Console.WriteLine(champ + " : " + longest);
                }
            }

            Console.WriteLine("Winner: " + champ + " : " + longest);
            Console.ReadKey();
        }
    }
}
