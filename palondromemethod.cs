using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class palondromemethod
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsPalondrome(121));
        }
        public static bool IsPalondrome(int num)
        {
            int copy = num;
            int rev = 0;
            while(num!=0)
            {
                int digit = num % 10;
                num = num / 10;
                rev = rev * 10 + digit;
            }
            return copy == rev ;
        }
    }
}
