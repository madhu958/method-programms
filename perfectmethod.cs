using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class perfectmethod
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsPerfect(28));
        }
            public static bool IsPerfect(int num)
            {
                return num == Factors(num);
            }

            public static int Factors(int num)
            {
                int sum = 0;
                for (int i = 1; i < num; i++)
                {
                    if (num % i == 0)
                    {
                        sum = sum + i;
                    }
                }
                return sum;
            }
        }

    }
