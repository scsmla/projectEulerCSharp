using System;
namespace ProjectEuler
{
    class Program
    {
        static void Main(string[] args)
        {
            bool[] numCanWriitenBy2Abundant = new bool[28123];
            bool[] boolAbundant = new bool[28123];
            for (int index = 0; index < 28123; index++)
                if (isAbundant(index))
                    boolAbundant[index] = true;
            for(int num1 = 1; num1 < 28123; num1 ++)
            {
                for(int num2 = num1; num2 < 28123 && num2 + num1 < 28123; num2 ++)
                {
                    if(boolAbundant[num1] && boolAbundant[num2])
                    {
                        numCanWriitenBy2Abundant[num1 + num2] = true;
                    }
                }
            }
            int result = 0;
            for(int index = 0; index < 28123; index ++)
            {
                if (!numCanWriitenBy2Abundant[index])
                    result += index;
            }
            Console.WriteLine(result);
            Console.ReadLine();
        }

        static bool isAbundant(int num)
        {
            int sumProperDivisor = 0;
            for(int divisor = 1; divisor <= num/2; divisor ++)
            {
                if (num % divisor == 0)
                    sumProperDivisor += divisor;
                if(sumProperDivisor > num)
                        return true;
            }
            return false;
        }
    }
}
