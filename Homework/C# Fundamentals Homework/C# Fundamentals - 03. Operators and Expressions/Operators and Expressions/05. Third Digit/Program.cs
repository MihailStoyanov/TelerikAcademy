using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Third_Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            uint N = uint.Parse(Console.ReadLine());
            if (N >= 700)
            {
                if ((N / 100) % 10 == 7)
                {
                    Console.WriteLine("true");
                }
                else
                {
                    uint Result = (N / 100) % 10;
                    Console.WriteLine("false {0}", Result);
                }
            }
            else
            {
                uint Result = (N / 100) % 10;
                Console.WriteLine("false {0}", Result);
            }
        }
    }
}
