
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Rextester
{
    public class Program
    {

        public static void Main(string[] args)
        {
            long sum = 0;
            for(int i = 2; i < 2000000; i ++)
                if (isPrime(i))
                    sum += i;
            Console.WriteLine(sum);
            Console.ReadLine();
        }
        static bool isPrime(int n)
        {
            for(int i = 2; i <= Math.Sqrt(n); i++)
                if (n % i == 0)
                    return false;
            return true;
        }

    }
}