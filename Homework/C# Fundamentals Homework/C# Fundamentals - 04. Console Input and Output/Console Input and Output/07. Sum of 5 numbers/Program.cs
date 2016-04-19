using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Sum_of_5_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int i1 = int.Parse(Console.ReadLine());
            int i2 = int.Parse(Console.ReadLine());
            int i3 = int.Parse(Console.ReadLine());
            int i4 = int.Parse(Console.ReadLine());
            int i5 = int.Parse(Console.ReadLine());

            int sum = i1 + i2 + i3 + i4 + i5;

            Console.WriteLine(sum);

        }
    }
}
