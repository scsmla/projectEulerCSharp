using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ProjectEuler
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dayInWeek = new int[7] { 0, 1, 2, 3, 4, 5, 6 };
            //0 is Monday, 1 is Tuesday and...
            int[] daysOfMonth = new int[12] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};
            int daysIntheCentury = 0;
            int firstDayOf1901 = 365 % 7 + dayInWeek[0];
            int count = 0;
            for(int year = 1901; year <= 2000; year ++)
            {
                for(int month = 1; month <= 12; month ++)
                {
                    daysIntheCentury += daysOfMonth[month - 1];
                    if (year % 4 == 0 && month == 2)
                        daysIntheCentury++;
                    if (daysIntheCentury % 7 == (dayInWeek[6] - firstDayOf1901))
                        count++ ;
                }
            }
            Console.WriteLine(count);
            Console.ReadLine();

        }
    }
}
