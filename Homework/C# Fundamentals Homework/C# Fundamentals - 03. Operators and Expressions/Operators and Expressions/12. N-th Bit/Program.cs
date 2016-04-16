using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.N_th_Bit
{
    class Program
    {
        static void Main(string[] args)
        {
            int P = int.Parse(Console.ReadLine());
            int N = int.Parse(Console.ReadLine());

            int mask = 1 << N;
            int nAndMask = P & mask;
            int bit = nAndMask >> N;
            Console.WriteLine(bit);

        }
    }
}
