using System;
using System.Linq;
using System.Numerics;

namespace ProjectEuler
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 999;
            //Predicate the number need to find between 9 * 10 ^ 6 and 10 * 10 ^ 6
            for(int i = num; i >= 900; i --)
            {
                char[] arrRemain = i.ToString().ToCharArray();
                Array.Reverse(arrRemain);
                string remaindPart  = new string(arrRemain);
                int palindromeNum = Convert.ToInt32(i.ToString() + remaindPart);
                for (int j = 990; j >= 900; j -= 11)
                {
                    if (palindromeNum % j == 0 && palindromeNum / j < 1000)
                    {
                        Console.WriteLine(palindromeNum);
                        break;
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
