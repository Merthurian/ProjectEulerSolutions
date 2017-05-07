using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
You are given the following information, but you may prefer to do some research for yourself.

1 Jan 1900 was a Monday.

Thirty days has September,
April, June and November.
All the rest have thirty-one,
Saving February alone,
Which has twenty-eight, rain or shine.
And on leap years, twenty-nine.

A leap year occurs on any year evenly divisible by 4, but not on a century unless it is divisible by 400.

How many Sundays fell on the first of the month during the twentieth century (1 Jan 1901 to 31 Dec 2000)?

Dan Purcell 14/10/15 
*/

namespace Euler19
{
    class Program
    {
        static void Main(string[] args)
        {   
            DateTime date = new DateTime(1901, 1, 1);
            DateTime end = new DateTime(2000, 12, 31);

            int total = 0;

            while (DateTime.Equals(date, end) != true)
            {   
                if (date.DayOfWeek == DayOfWeek.Sunday && date.Day == 1)
                {
                    total++;
                }
                date = date.AddDays(1.0);
            }

            Console.WriteLine(total);
            Console.ReadKey();
        }
    }
}
