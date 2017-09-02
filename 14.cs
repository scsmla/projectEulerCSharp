
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text.RegularExpressions;
namespace ProjectEuler
{
    public class Program
    {

        public static void Main(string[] args)
        {
            int position = 0;
            long maxLength = 0;

            for (int i = 1; i < 1000000; i++)
            {
                long tempLength = LengthCollatz(i);
                if (tempLength > maxLength)
                {
                    maxLength = tempLength;
                    position = i;
                   
                }
            }
            Console.WriteLine("Max Length is : {0} at position : {1} ", maxLength, position);

            Console.ReadLine();
        }

        static long LengthCollatz(long num)
        {
            if (num == 1) return 0;
            if (num % 2 == 0)
                return LengthCollatz(num / 2) + 1;
            else
                return LengthCollatz(num * 3 + 1) + 1;
        }

    }
}