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



            if (N >= 2)
            {
                if (N == 2)
                {
                    Console.WriteLine("true");
                }
                else
                {
                    for (int i = 2; i < N; i++)
                    {
                        if (N % i != 0 && N % i == 0)
                        {
                            Console.WriteLine("true");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("false");
                            break;
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("false");
            }

        }
    }
}
