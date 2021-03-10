using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class AveregeofFactors
    {
        static void Main(string[] args)
        {
            AveregeofFactors a = new AveregeofFactors();
            Console.WriteLine(a.AveregeofFactor(12));
        }
        public int AveregeofFactor(int num)
        {
            int count = 0;
            int sum = 0;
            for (int i = 1; i <= 12; i++)
            {
                if (num % i == 0)
                {
                    sum = sum + i;
                    count++;
                }
            }
            int avg = sum / count;
            return avg;
        }
    }
}

