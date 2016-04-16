using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Prime_Check
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            if (N <= 1)
            {
                Console.WriteLine("false");
            }
            else
            {
                int Remainder;
                for (int i = 2; i <= N; i++)
                {
                    Remainder = N % i;
                    if (Remainder == 0 && i  == N)
                    {
                        Console.WriteLine("true");
                        break;
                    }
                    if (Remainder == 0 && i != N)
                    {
                        Console.WriteLine("false");
                        break;
                    }
                }
            }
        }
    }
}
