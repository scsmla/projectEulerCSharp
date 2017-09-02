
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text.RegularExpressions;
namespace ProjectEuler
{
    public class Program
    {
        //Use the DP instead of recursion to reduce the time complexity
        public static void Main(string[] args)
        {
            long[,] countRouteArr = new long[21, 21];
            countRouteArr[0, 0] = 0;
            for(int index = 0; index <= 20; index ++)
            {
                countRouteArr[0, index] = 1;
                countRouteArr[index, 0] = 1;
            }
            
            for(int row = 1; row <= 20; row ++)
            {
                for(int column = 1; column <= 20; column ++)
                {
                    countRouteArr[row, column] = countRouteArr[row - 1, column] + countRouteArr[row, column - 1];
                }
            }
            Console.WriteLine(countRouteArr[20, 20]);
           
            Console.ReadLine();
        }


    }
}