using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArmstrongNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CountOfArmstrongNumbers(5));
            Console.ReadKey();
        }

        static int CountOfArmstrongNumbers(int pow)
        {
            int counter = 0, startIndex = (int)Math.Pow(10, pow - 1), endIndex = (int)Math.Pow(10, pow) - 1;
            for (int i = startIndex; i < endIndex; i++)
            {
                if (SumOfNums(i, pow) == i) 
                    counter += i;                
            }
            return counter;
        }
        static int SumOfNums(int number, int pow)
        {
            int count = 0;
            for (int i = 0; i < pow; i++)
            {
                int a = number % 10;
                count += (int)Math.Pow(a, pow);
                number = number / 10;
            }
            return count;
        }
    }
}
