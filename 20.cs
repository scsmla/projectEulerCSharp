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
            BigInteger result = new BigInteger();
            result = 1;
            for(int i = 2; i <= 100; i ++)
            {
                result = BigInteger.Multiply(result, i);
            }
            BigInteger sumDigits = new BigInteger();
            sumDigits = 0;
            while(result >= 1)
            {
                sumDigits += result % 10;
                result /= 10;
            }
            Console.WriteLine(sumDigits);
            Console.ReadLine();
        }
    }
}
