using System;
using System.Numerics;

namespace ProjectEuler
{
    class Program
    {
        static void Main(string[] args)
        {
            long num = 600851475143;
            long tempNum = num;
            for(int i = 3; i < Math.Sqrt(tempNum); i += 2)
            {
                if(num % i == 0)
                {
                    if(num / i == 1)
                    {
                        Console.WriteLine(i);
                        break;
                    }
                    while(num % i == 0)
                    {
                        num = num / i;
                        
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
