using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.MMSA_of_N_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            uint N = uint.Parse(Console.ReadLine());
            double min = double.MaxValue;
            double max = double.MinValue;
            double sum = 0;
            double avg = 0;

            for (int i = 0; i < N; i++)
            {
                double number = double.Parse(Console.ReadLine());
                if (number < min)
                {
                    min = number;
                }
                if (number > max)
                {
                    max = number;
                }
                sum += number;
                
            }
            avg = sum / N;
            Console.WriteLine("min={0:f2}", min);
            Console.WriteLine("max={0:f2}", max);
            Console.WriteLine("sum={0:f2}", sum);
            Console.WriteLine("avg={0:f2}", avg);
        }
    }
}
