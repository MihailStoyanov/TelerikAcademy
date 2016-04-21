using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Sort_3_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double i1 = double.Parse(Console.ReadLine());
            double i2 = double.Parse(Console.ReadLine());
            double i3 = double.Parse(Console.ReadLine());
            double Biggest = 0;
            double Medium = 0;
            double Smallest = 0;

            if (i1 >= i2 && i1 >= i3)
            {
                Biggest = i1;
            }
            if (i2 >= i1 && i2 >= i3)
            {
                Biggest = i2;
            }
            if (i3 >= i1 && i3 >= i2)
            {
                Biggest = i3;
            }

            if ((i1 >= i2 && i1 <= i3)|| (i1 <= i2 && i1 >= i3))
            {
                Medium = i1;
            }
            if ((i2 >= i1 && i1 <= i3) || (i2 <= i1 && i2 >= i3))
            {
                Medium = i2;
            }
            if ((i3 >= i2 && i3 <= i1) || (i3 <= i2 && i3 >= i1))
            {
                Medium = i3;
            }

            if (i1 <= i2 && i1 <= i3)
            {
                Smallest = i1;
            }
            if (i2 <= i1 && i2 <= i3)
            {
                Smallest = i2;
            }
            if (i3 <= i1 && i3 <= i2)
            {
                Smallest = i3;
            }

            Console.WriteLine("{0} {1} {2}", Biggest, Medium, Smallest);
        }
    }
}
