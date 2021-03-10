using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class reversmethod
    {
        static void Main(string[] args)
        {
            Console.WriteLine(rev(1234));
        }
        private static int rev(int num)
        {

            int rev = 0;
            while (num > 0)
            {
                int digit = num % 10;
                rev = rev * 10 + digit;
                num = num / 10;
            }
            return rev;
        }
    }
}
