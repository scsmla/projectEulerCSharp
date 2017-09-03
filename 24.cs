using System;
using System.Collections.Generic;

namespace ProjectEuler
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 9;
            long limit = 999999;//represent the millionth lexicographic permutation
            int[] addedToEachDigit = new int[9];//Array to determine the the ith of order
            long[] factorialArr = new long[10];
            
            for (int index = 0; index < 10; index++)
                factorialArr[index] = factorial(index + 1);
            while(limit != 0)
            {
                if ( factorialArr[num] > limit)
                    num--;
                else
                {
                    limit -= factorialArr[num];
                    addedToEachDigit[8 - num] ++;
                }
            }
            int[] digitArr = new int[10];//Represeent the digits in the order
            for (int index = 0; index < 10; index++)
                digitArr[index] = index;
                        
            for(int index = 0; index < 9; index ++)
            {
                if(addedToEachDigit[index] != 0)
                {
                    int temp;
                    temp = digitArr[index];
                    digitArr[index] = digitArr[index + addedToEachDigit[index]];
                    digitArr[index + addedToEachDigit[index]] = temp;
                    Array.Sort(digitArr, index + 1, 9 - index);
                }
            }
            for (int i = 0; i < 10; i++)
                Console.Write(digitArr[i]);
            Console.ReadLine();
        }
        static long factorial(int n)
        {
            long result = 1;
            for (int index = 1; index <= n; index++)
                result *= index;
            return result;
        }
    }
}
