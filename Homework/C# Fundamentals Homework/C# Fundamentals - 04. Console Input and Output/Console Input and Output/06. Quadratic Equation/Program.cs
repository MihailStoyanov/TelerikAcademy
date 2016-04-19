using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Quadratic_Equation
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            double D;
            double x1;
            double x2;

            D = b * b - (4 * a * c);

            if (D < 0)
            {
                Console.WriteLine("no real roots");
            }
            if (D == 0)
            {
                x1 = -b/(2*a);
                Console.WriteLine("{0:f2}",x1);
            }
            if (D > 0)
            {
                x1 = (-b + Math.Sqrt(D)) / (2 * a);
                x2 = (-b - Math.Sqrt(D)) / (2 * a);
                double MinX = Math.Min(x1, x2);
                double MaxX = Math.Max(x1, x2);
                Console.WriteLine("{0:f2}", MinX);
                Console.WriteLine("{0:f2}", MaxX);
            }
        }
    }
}
