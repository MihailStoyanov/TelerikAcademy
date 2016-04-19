using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Sum_of_N_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int Sum = 0;

            for (int i = 0; i < N; i++)
            {
                int Number = int.Parse(Console.ReadLine());
                Sum += Number;
            }
            Console.WriteLine(Sum);
        }
    }
}
