using System;
using System.Linq;
using System.Numerics;

namespace ProjectEuler
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            long[] arr = new long [n];
            for (int i = 1; i <= n ; i++)
                arr[i - 1] = i + 1;
            Console.WriteLine(lcmarr(arr, n));
            Console.ReadLine();
        }
      
        static long gcd(long a,long b)
        {
            while(a * b != 0)
            {
                if (a > b)
                    a = a % b;
                else
                    b = b % a;
            }
            return a + b;
        }
        static long gcdarr(long[]arr,int n)
        {
            if (n == 2) return gcd(arr[0], arr[1]);
            else return gcd(arr[n - 1], gcdarr(arr, n - 1));
        }

        static long lcm(long a,long b)
        {
            return a * b / gcd(a, b);
        }

        static long lcmarr(long[]a,long n)
        {
            if (n == 2) return lcm(a[0], a[1]);
            else return lcm(a[n - 1], lcmarr(a, n - 1));
        }
    }
}
