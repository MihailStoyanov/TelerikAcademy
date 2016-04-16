using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Point__Circle__Rect
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());

            double radius = 1.5;
            double diagonal = Math.Sqrt(Math.Abs((x - 1) * (x - 1)) + Math.Abs((y - 1) * (y - 1)));

            if (diagonal <= radius)
            {
                Console.Write("inside circle ");
            }
            else
            {
                Console.Write("outside circle ");
            }
            if (x >= -1 && x <= 6 && y <= 1 && y >= -1)
            {
                Console.WriteLine("inside rectangle");
            }
            else
            {
                Console.WriteLine("outside rectangle");
            }
        }
    }
}
