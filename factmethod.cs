﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class factmethod
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsStrong(145));
        }
        public static bool IsStrong(int num)
        {
            return num == Sum(num);
        }
        public static int Factorial(int digit)
        {
            int fact = 1;
            for (int i = 1; i <= digit; i++)
            {
                fact = fact * i;
            }
            return fact;
        }
        public static int Sum(int num)
        {
            int sum = 0;
            while (num != 0)
            {
                int digit = num % 10;
                sum = sum + Factorial(digit);
                num = num / 10;
            }
            return sum;
        }

    }
}
