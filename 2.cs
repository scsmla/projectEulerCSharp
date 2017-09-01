using System;
namespace ProjectEuler
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int n = 1;
            while(fib(n) < 4000000)
            {
                if (fib(n) % 2 == 0)
                    sum += fib(n);
                n++;
            }
            Console.WriteLine(sum);
            Console.ReadLine();
        }
        static int fib(int n)
        {
            if (n == 1) return 1;
            if (n == 2) return 2;
            return fib(n - 1) + fib(n - 2);
        }
    }
}
