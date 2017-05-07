using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
If the numbers 1 to 5 are written out in words: one, two, three, four, five, then there are 3 + 3 + 5 + 4 + 4 = 19 letters used in total.

If all the numbers from 1 to 1000 (one thousand) inclusive were written out in words, how many letters would be used?


NOTE: Do not count spaces or hyphens. For example, 342 (three hundred and forty-two) contains 23 letters and 115 (one hundred and fifteen) contains 20 letters. The use of "and" when writing out numbers is in compliance with British usage.

Dan Purcell 13/10/15
*/

namespace Euler17
{
    class Program
    {
        static string intToWords(int i)
        {
            if (i == 0)
                return "zero";

            string[] setA = {
                                "",
                                "one",
                                "two",
                                "three",
                                "four",
                                "five",
                                "six",
                                "seven",
                                "eight",
                                "nine"
                            };

            string[] setB = {
                                "ten",
                                "eleven",
                                "twelve",
                                "thirteen",
                                "fourteen",
                                "fifteen",
                                "sixteen",
                                "seventeen",
                                "eighteen",
                                "nineteen"
                            };

            string[] setC = {
                                "",
                                "",
                                "twenty",
                                "thirty",
                                "forty",
                                "fifty",
                                "sixty",
                                "seventy",
                                "eighty",
                                "ninety"
                            };

            string[] setD = {
                                "",
                                "",
                                "hundred",
                                "thousand"
                            };

            string s = i.ToString();

            string ans = "";

            while (s.Length > 0)
            {
                switch (s.Length)
                {
                    case 4:
                        ans += setA[(int)Char.GetNumericValue(s[0])];
                        ans += "thousand";
                        if ((int)Char.GetNumericValue(s[1]) == 0 && (int)Char.GetNumericValue(s[2]) == 0 && (int)Char.GetNumericValue(s[3]) == 0)
                        {
                            s = "";
                            break;
                        }

                        s = s.Substring(1);
                        break;

                    case 3:
                        if ((int)Char.GetNumericValue(s[0]) != 0)
                        {
                            ans += setA[(int)Char.GetNumericValue(s[0])];
                            ans += "hundred";
                            if ((int)Char.GetNumericValue(s[1]) == 0 && (int)Char.GetNumericValue(s[2]) == 0)
                            {
                                s = "";
                                break;
                            }
                            ans += "and";
                            s = s.Substring(1);
                            break;
                        }
                        else
                        {
                            ans += "and";
                            s = s.Substring(1);
                            break;
                        }
                        break;

                    case 2:
                        if ((int)Char.GetNumericValue(s[0]) == 0)
                        {
                            s = s.Substring(1);
                            break;
                        }
                        if ((int)Char.GetNumericValue(s[0]) == 1)
                        {
                            ans += setB[(int)Char.GetNumericValue(s[1])];
                            s = "";
                        }
                        else
                        {
                            ans += setC[(int)Char.GetNumericValue(s[0])];
                            s = s.Substring(1);
                        }
                        break;

                    case 1:
                        ans += setA[(int)Char.GetNumericValue(s[0])];
                        s = "";
                        break;

                    default:
                        break;
                }
            }

            return ans;
        }
        static void Main(string[] args)
        {
            string ans = "";
            for (int i = 1; i < 1001; i++)
            {
                ans += intToWords(i);
            }
            Console.WriteLine(ans.Length);
            Console.ReadKey();
        }
    }
}
