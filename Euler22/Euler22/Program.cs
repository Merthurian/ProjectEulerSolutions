using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.IO;
using System.Text.RegularExpressions;

/*
Using names.txt (right click and 'Save Link/Target As...'), a 46K text file containing over five-thousand first names, begin by sorting it into alphabetical order.
Then working out the alphabetical value for each name, multiply this value by its alphabetical position in the list to obtain a name score.

For example, when the list is sorted into alphabetical order, COLIN, which is worth 3 + 15 + 12 + 9 + 14 = 53, is the 938th name in the list. So, COLIN would obtain a score of 938 × 53 = 49714.

What is the total of all the name scores in the file?

Dan Purcell 23/10/15 
*/

namespace Euler22
{
    class Program
    {
        static void Main(string[] args)
        {
            var assembly = Assembly.GetExecutingAssembly();

            string[] t = assembly.GetManifestResourceNames();

            var resourceName = "Euler22.names.txt";

            int size = 5163;

            string[] names = new string[size];

            using (Stream stream = assembly.GetManifestResourceStream(resourceName))
            {
                using (StreamReader reader = new StreamReader(stream))
                {
                    string all = reader.ReadToEnd();

                    string[] ntemp = new string[size];

                    /*
                    int count = 0;

                    foreach (char c in all)
                    {
                        if (c == ',')
                            count++;
                    }
                    Console.WriteLine(count);
                    */
                    
                    ntemp = all.Split(',');
                    for (int i = 0; i < size; i++)
                    {
                        names[i] = ntemp[i].Substring(1, ntemp[i].Length - 2);
                    }
                }
            }

            Array.Sort(names);

            long total = 0;

            for (int i = 0; i < size; i++)
            {
                int nValue = 0;
                for (int j = 0; j < names[i].Length; j++)
                {
                    nValue += char.ToUpper(names[i][j]) - 64;                    
                }
                       
                total += nValue * (i + 1);
            }

            Console.WriteLine(total);
            
            Console.ReadKey();
        }
    }
}
