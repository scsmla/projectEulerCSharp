using System;
using System.Linq;
using System.Numerics;

namespace ProjectEuler
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            for(int i = 2;; i++)
            {
                if (isPrime(i)) count++;
                if (count == 10001)
                {
                    Console.WriteLine(i);
                    break;
                }
            }
            Console.ReadLine();
        }
        static bool isPrime(int n)
        {
            for(int i = 2; i < n; i++)
            {
                if (n % i == 0)
                    return false;
            }
            return true;
        }
    }
}
