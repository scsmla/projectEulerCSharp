
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
            BigInteger resultOf2Exponential1000 = new BigInteger();
            resultOf2Exponential1000 = BigInteger.Pow(2, 1000);
            long sumDigit = 0;
            string stringDigits = resultOf2Exponential1000.ToString();
            for(int index = 0; index < stringDigits.Length; index ++)
            {
                sumDigit += stringDigits[index] - 48;
            }
            Console.WriteLine(sumDigit);
            Console.ReadLine();
        }
    }
}
