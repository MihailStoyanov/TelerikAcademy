using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Exchange_If_Greater
{
    class Program
    {
        static void Main(string[] args)
        {
            double A = double.Parse(Console.ReadLine());
            double B = double.Parse(Console.ReadLine());

            if (A >= B)
            {
                Console.WriteLine("{0} {1}", B, A);
            }
            else
            {
                Console.WriteLine("{0} {1}", A, B);
            }
        }
    }
}
