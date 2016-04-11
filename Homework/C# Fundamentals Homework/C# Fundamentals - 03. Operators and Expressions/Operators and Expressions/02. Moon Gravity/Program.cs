using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Moon_Gravity
{
    class Program
    {
        static void Main(string[] args)
        {
            double W = double.Parse(Console.ReadLine());
            double EarthGravity = 1;
            double MoonGravity = EarthGravity * 17 / 100;

            double Wmoon = W * MoonGravity;
            if (W >=0 && W <= 1000)
            {
                Console.WriteLine("{0:F3}",Wmoon);
            }
        }
    }
}
