using System;
using System.Collections.Generic;
using System.Numerics;
namespace ProjectEuler
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger fibonaci = new BigInteger();
            BigInteger firstNum = 1, secondNum = 1;
            long index = 2;
            while(true)
            {
                fibonaci = BigInteger.Add(firstNum, secondNum);
                firstNum = secondNum;
                secondNum = fibonaci;
                index++;
                int count = 0;
                while(fibonaci >= 1)
                {
                    fibonaci /= 10;
                    count++;
                }
                if (count >= 1000)
                    break;
            }
            Console.WriteLine(index);
            Console.ReadLine();
        }
    }
}
