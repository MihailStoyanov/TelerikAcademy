using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Trapezoids
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            double Area = (a + b) * h / 2;
            //if (a >= -500 && a <= 500 && b >= -500 && b <= 500 && h >= -500 && h <= 500)
            //{
                Console.WriteLine("{0:f7}", Area);
            //}
        }
    }
}
