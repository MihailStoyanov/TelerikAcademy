using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Not_Divisible_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            uint N = uint.Parse(Console.ReadLine());
            for (int i = 1; i <= N; i++)
            {
                if (i % 3 == 0 || i % 7 == 0)
                {
                    
                }
                else
                {
                    Console.Write("{0} ", i);
                }
            }
        }
    }
}
