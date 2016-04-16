using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Modify_Bit
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong n = ulong.Parse(Console.ReadLine());
            byte p = byte.Parse(Console.ReadLine());
            ulong v = ulong.Parse(Console.ReadLine());
            // Output
            n &= ~(1U << p);    // Clear bit p (set to 0)
            n |= (v << p);      // Set to v in bit p
            Console.WriteLine(n);
        }
    }
}
