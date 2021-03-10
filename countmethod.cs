using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
  public  class countmethods
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CountDigit(123));
        }

        private static int CountDigit(int num)
        {
            int count = 0;
            while(num>0)
            {
                int digit = num % 10;
                count++;
                num = num / 10;
            }
            return count;
        }
    }
}
