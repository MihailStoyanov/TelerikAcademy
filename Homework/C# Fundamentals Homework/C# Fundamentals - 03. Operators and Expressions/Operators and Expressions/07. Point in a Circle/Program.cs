using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Point_in_a_Circle
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double radius = 2.0;
            double diagonal = Math.Sqrt( Math.Abs(x * x) + Math.Abs(y * y));

            if (diagonal <= radius)
            {
                Console.WriteLine("yes {0:f2}", Math.Abs(diagonal));
            }
            else
            {
                Console.WriteLine("no {0:f2}", Math.Abs(diagonal));
            }
        }
    }
}