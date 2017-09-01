
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
namespace ProjectEuler
{
    public class Program
    {

        public static void Main(string[] args)
        {
            int num = 200;
            while (countDivisors(num * (num + 1) / 2) < 500)
            {
                num++;
            }
            Console.WriteLine(num * (num + 1) / 2);


            Console.ReadLine();

        }
        //The efficient algorithm to count the divisor of the number 
        //Analysis num to prime divisor 
        static int countDivisors(long num)
        {
            int[] coefficientAnalysPrime = new int[100];
            long tempNum = num;
            for (int i = 0; i < 100; i++)
                coefficientAnalysPrime[i] = 0;
            int indexPrime = 0;
            int result = 1;
            bool dividedPrime = false;
            for (int divisorPrime = 2; divisorPrime < tempNum; divisorPrime++)
            {
                while (num % divisorPrime == 0)
                {
                    num /= divisorPrime;
                    dividedPrime = true;
                    coefficientAnalysPrime[indexPrime]++;

                }
                if (num == 1)
                    break;
                if (dividedPrime)
                {
                    indexPrime++;
                    dividedPrime = false;
                }
            }
            for (int i = 0; i <= indexPrime; i++)
            {
                result *= (coefficientAnalysPrime[i] + 1);
            }
            return result;
        }

    }
}