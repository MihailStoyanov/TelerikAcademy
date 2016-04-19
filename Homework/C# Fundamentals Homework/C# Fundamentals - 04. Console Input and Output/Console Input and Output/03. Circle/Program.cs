using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Circle
{
    class Program
    {
        static void Main(string[] args)
        {
            double r = double.Parse(Console.ReadLine());
            double p = 2 * Math.PI * r;
            double a = Math.PI * Math.Pow(r, 2);

            Console.WriteLine("{0:f2} {1:f2}", p, a);
        }
    }
}
