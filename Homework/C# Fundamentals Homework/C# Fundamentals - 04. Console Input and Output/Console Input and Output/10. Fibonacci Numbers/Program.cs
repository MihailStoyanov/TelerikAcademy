using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _10.Fibonacci_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            if (N <= 0 || N > 50)
            {
                Console.WriteLine();
            }
            else if (N == 1)
            {
                Console.WriteLine(0);
            }
            else if (N == 2)
            {
                Console.WriteLine("{0}, {1}", 0, 1);
            }
            else if (N == 3)
            {
                Console.WriteLine("{0}, {1}, {2}", 0, 1, 1);
            }
            else
            {
                BigInteger first = 0;
                BigInteger second = 1;
                BigInteger third = 0;
                Console.Write("{0}, {1}", 0, 1);
                for (int i = 3; i <= N; i++)
                {
                    
                    third = first + second;
                    Console.Write(", " + third);
                    first = second;
                    second = third;
                }
                Console.WriteLine();
            }
        }
    }
}
