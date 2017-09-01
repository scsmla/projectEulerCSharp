using System;
using System.Linq;
using System.Numerics;

namespace ProjectEuler
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger bigSumSquare = new BigInteger();
            int sum = 0;
            long sumOfSquare = 0;
            for (int i = 1; i <= 100; i++)
            {
                sum += i;
                sumOfSquare += i * i;
            }
            bigSumSquare = BigInteger.Pow(sum, 2);
            Console.WriteLine(bigSumSquare - sumOfSquare);
            Console.ReadLine();
        }
    }
}
