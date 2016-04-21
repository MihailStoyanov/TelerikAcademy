using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Biggest_of_5
{
    class Program
    {
        static void Main(string[] args)
        {
            double i1 = double.Parse(Console.ReadLine());
            double i2 = double.Parse(Console.ReadLine());
            double i3 = double.Parse(Console.ReadLine());
            double i4 = double.Parse(Console.ReadLine());
            double i5 = double.Parse(Console.ReadLine());

            double bigger = 0;

            if (i1 >= i2 && i1 >= i3 && i1 >= i4 && i1 >= i5)
            {
                bigger = i1;
            }
            if (i2 >= i1 && i2 >= i3 && i2 >= i4 && i2 >= i5)
            {
                bigger = i2;
            }
            if (i3 >= i2 && i3 >= i1 && i3 >= i4 && i3 >= i5)
            {
                bigger = i3;
            }
            if (i4 >= i2 && i4 >= i3 && i4 >= i1 && i4 >= i5)
            {
                bigger = i4;
            }
            if (i5 >= i2 && i5 >= i3 && i5 >= i4 && i5 >= i1)
            {
                bigger = i5;
            }
            Console.WriteLine(bigger);
        }
    }
}
