using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Multiplication_Sign
{
    class Program
    {
        static void Main(string[] args)
        {
            double i1 = double.Parse(Console.ReadLine());
            double i2 = double.Parse(Console.ReadLine());
            double i3 = double.Parse(Console.ReadLine());

            if (i1 > 0 && i2 > 0 && i3 > 0)
            {
                Console.WriteLine("+");
            }
            else if (i1 > 0 && i2 > 0 && i3 < 0)
            {
                Console.WriteLine("-");
            }
            else if (i1 > 0 && i2 < 0 && i3 > 0)
            {
                Console.WriteLine("-");
            }
            else if (i1 < 0 && i2 > 0 && i3 > 0)
            {
                Console.WriteLine("-");
            }
            else if (i1 < 0 && i2 < 0 && i3 < 0)
            {
                Console.WriteLine("-");
            }
            else if (i1 > 0 && i2 < 0 && i3 < 0)
            {
                Console.WriteLine("+");
            }
            else if (i1 < 0 && i2 < 0 && i3 > 0)
            {
                Console.WriteLine("+");
            }
            else if (i1 < 0 && i2 > 0 && i3 < 0)
            {
                Console.WriteLine("+");
            }
            else if (i1 == 0 || i2 == 0 || i3 == 0)
            {
                Console.WriteLine(0);
            }
        }
    }
}
