using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class avgmethod
    {
        static void Main(string[] args)
        {
            Console.WriteLine(avg(123));
        }
        private static int avg(int num)
        {
            int count = 0;
            int sum = 0;
            int avg = 0;
            while (num > 0)
            {
                int digit = num % 10;
                sum = sum + digit;
                count++;
                num = num / 10;
            }
            avg = sum / count;
            return avg;
        }
    }
}