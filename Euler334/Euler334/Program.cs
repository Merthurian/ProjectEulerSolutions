using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*
https://projecteuler.net/problem=334
*/

namespace Euler334
{
    class Program
    {
        static int[] getSequence(int size)
        {
            int[] sequence = new int[size];

            int t = 123456;

            for (int i = 0; i < size; i++)
            {
                t = (t % 2 == 0) ? t / 2 : ((int)Math.Floor(t / 2.0) ^ 926252);
                sequence[i] = (t%2048)+1;
            }

            return sequence;
        }
        static void Main(string[] args)
        {
            int[] seq = getSequence(1500);

            //int[] seq = { 3, 2 };

            int total = 0;

            foreach (int beans in seq)
            {
                total += beans;
            }

            long steps = 0;

            int[] bowls = new int[total * 2];

            for (int i = 0; i < seq.Length; i++)
            {
                bowls[i + (int)(total / 2)] = seq[i];
            }

            int take, a, b, c = 0;

            while (bowls.Max() > 1)
            {
                for (int i = 1; i < bowls.Length-1; i++)
                {
                    a = bowls[i - 1];
                    b = bowls[i];
                    c = bowls[i + 1];

                    if (b < 2)
                    {
                        continue;
                    }

                    if (b > 1 && (a < b || c < b))
                    {
                        take = (b % 2 == 0) ? b : b-1;
                       
                        bowls[i] -= take;
                        bowls[i - 1] += take/2;
                        bowls[i + 1] += take/2;

                        steps += take/2;
                    }
                }
                Console.WriteLine(steps.ToString("n0") + " " + bowls.Max());
            }

            /*
                              
            List<int> bowls = new List<int>();
                        
            for (int i = 0; i < seq.Length; i++)
            {
                bowls.Add(seq[i]);
            }

            while (bowls.Max() > 1)
            {
                int previousBowl = 0;
                int nextBowl = 0;

                for (int i = 0; i < bowls.Count; i++)
                {
                    if (i == bowls.Count - 1)
                    {
                        nextBowl = 0;
                    }
                    else
                        nextBowl = bowls[i + 1];                    
                    
                    if (bowls[i] > 1 && previousBowl < bowls[i] && nextBowl < bowls[i])
                    {
                        if (i == 0)
                        {
                            bowls.Insert(0, 0);
                            break;
                        }

                        if (i == bowls.Count - 1)
                        {
                            bowls.Add(0);
                            break;
                        }

                        steps++;
                        bowls[i] -= 2;

                        bowls[i - 1]++;
                        bowls[i + 1]++;
                    }
                }
            }
            */

            Console.WriteLine(steps);
            Console.ReadKey();
        }
    }
}
