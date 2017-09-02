using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Numerics;
namespace ProjectEuler
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = 0;
            int[] properDivisorArr = new int[10000];
            for (int index = 1; index < 10000; index++)
                properDivisorArr[index] = sumProperDivisors(index);
            for (int num1 = 220; num1 < 10000; num1++)
            {
                for (int num2 = num1 + 2; num2 < 10000; num2+= 2)
                {
                    if (properDivisorArr[num1] == num2 && properDivisorArr[num2] == num1)
                        result += num1 + num2;
                }
            }
            Console.WriteLine(result);
      
            Console.ReadLine();
        }

        static int sumProperDivisors(int num)
        {
            int result = 0;
            for(int index = 1; index <= num / 2;index ++)
            {
                if(num % index == 0)
                    result += index;
            }
            return result;
        }
    }
}
