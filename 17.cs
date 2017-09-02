using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ProjectEuler
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int numberOfLetters = 0;

            for (int number = 1; number < 1001; number++)
                numberOfLetters += CountLetters(number);

            Console.WriteLine("Number of letters: " + numberOfLetters);

            Console.ReadKey();

        }

        static int CountLetters(int number)
        {
            string[] units = new string[] { "", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            string[] units10 = new string[] { "", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
            string[] tens = new string[] { "", "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };

            if (number == 1000)
                return "onethousand".Length;
            string numberString = "";
            int[] digits = new int[3];

            digits[0] = number / 100;
            digits[1] = (number / 10) % 10;
            digits[2] = number % 10;

            if (digits[0] > 0)
            {
                numberString += units[digits[0]] + "hundred";
                if (digits[1] != 0 || digits[2] != 0)
                    numberString += "and";
            }

            if (digits[1] == 1)
            {
                if (digits[2] == 0)
                    numberString += tens[digits[1]];
                else
                    numberString += units10[digits[2]];
            }
            else
                numberString += tens[digits[1]] + units[digits[2]];

            return numberString.Length;

        }
    }
}