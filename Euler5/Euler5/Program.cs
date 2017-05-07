using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.

What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?

Dan P 30/9/15
*/

namespace Euler5
{
    class Program
    {
        static void Main(string[] args)
        {
            long i = 2520;


            while (true)
            {
                if (i % 20 == 0)
                {
                    if (i % 19 == 0)
                    {
                        if (i % 18 == 0)
                        {
                            if (i % 17 == 0)
                            {
                                if (i % 16 == 0)
                                {
                                    if (i % 15 == 0)
                                    {
                                        if (i % 14 == 0)
                                        {
                                            if (i % 13 == 0)
                                            {
                                                if (i % 12 == 0)
                                                {
                                                    if (i % 11 == 0) // No need to go further
                                                    {
                                                        Console.WriteLine(i);
                                                        break;
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                i += 20;
            }
            Console.ReadKey();                                                 
                                                            
        }
    }
}
