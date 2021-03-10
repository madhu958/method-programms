using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class summethods
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Sumdigit(123));
        }
        private static int Sumdigit(int num)
        {
            int sum = 0;

            while(num>0)
            {
                int digit = num % 10;
                sum = sum + digit;
                num = num / 10;
            }
            return sum;
        }
    }
}
