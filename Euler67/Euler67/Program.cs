using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.IO;
using System.Text.RegularExpressions;

/*
By starting at the top of the triangle below and moving to adjacent numbers on the row below, the maximum total from top to bottom is 23.

3
7 4
2 4 6
8 5 9 3

That is, 3 + 7 + 4 + 9 = 23.

Find the maximum total from top to bottom in triangle.txt (right click and 'Save Link/Target As...'), a 15K text file containing a triangle with one-hundred rows.

NOTE: This is a much more difficult version of Problem 18. It is not possible to try every route to solve this problem, as there are 2^99 altogether! 
If you could check one trillion (1012) routes every second it would take over twenty billion years to check them all. There is an efficient algorithm to solve it. ;o)

Dan Purcell 13/10/15 
*/

namespace Euler67
{
    class Program
    {
        static void Main(string[] args)
        {
            var assembly = Assembly.GetExecutingAssembly();

            string[] t = assembly.GetManifestResourceNames();

            var resourceName = "Euler67.triangle.txt";

            string triangle;

            using (Stream stream = assembly.GetManifestResourceStream(resourceName))
            {
                using (StreamReader reader = new StreamReader(stream))
                {
                    triangle = reader.ReadToEnd();
                }
            }

            string[] lines = Regex.Split(triangle, "\r\n");

            Array.Reverse(lines);

            int[] iBottom = Array.ConvertAll(lines[0].Split(' '), int.Parse);

            for (int i = 1; i < lines.Length; i++)
            {
                int[] iNumbers = Array.ConvertAll(lines[i].Split(' '), int.Parse);

                for (int j = 0; j < iNumbers.Length; j++)
                {
                    iNumbers[j] = (iBottom[j] > iBottom[j + 1]) ? iNumbers[j] + iBottom[j] : iNumbers[j] + iBottom[j + 1];
                }
                iBottom = iNumbers;
            }
            Console.WriteLine(iBottom[0]);
            Console.ReadKey();
        }
    }
}
