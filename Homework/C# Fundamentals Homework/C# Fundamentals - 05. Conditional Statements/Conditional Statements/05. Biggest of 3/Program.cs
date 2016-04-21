using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Biggest_of_3
{
    class Program
    {
        static void Main(string[] args)
        {
            double i1 = double.Parse(Console.ReadLine());
            double i2 = double.Parse(Console.ReadLine());
            double i3 = double.Parse(Console.ReadLine());

            double bigger = Math.Max(i1, i2);
            double biggest = Math.Max(i3, bigger);
            Console.WriteLine(biggest);
        }
    }
}
