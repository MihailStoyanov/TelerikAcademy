using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Odd_or_Even
{
    class Program
    {
        static void Main(string[] args)
        {
            int integer = int.Parse(Console.ReadLine());
            if (integer >= -30 && integer <= 30)
            {
                if (integer % 2 == 0)
                {
                    Console.WriteLine("even {0}", integer);
                }
                else
                {
                    Console.WriteLine("odd {0}", integer);
                }
            }            
        }
    }
}
