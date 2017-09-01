
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace ProjectEuler
{
    public class Program
    {

        public static void Main(string[] args)
        {
            bool finded = false;
           for(int a = 1; a < 1000; a ++)
            {
                for(int b = 1; b < 1000; b ++)
                {
                    int c = 1000 - a - b;
                    if(a * a + b * b == c * c)
                    {
                        finded = true;
                        Console.WriteLine(a * b * c);
                        break;
                    }
                }
                if (finded == true)
                    break;
            }
            Console.ReadLine();
        }

    }
}