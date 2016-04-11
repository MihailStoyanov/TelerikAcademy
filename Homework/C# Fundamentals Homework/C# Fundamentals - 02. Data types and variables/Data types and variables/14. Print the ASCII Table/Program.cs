using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Print_the_ASCII_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.OutputEncoding = Encoding.ASCII;
            for (int i = 33; i <= 126; i++)
            {                                
                Console.Write((char)i);
            }
            Console.WriteLine();
        }
    }
}
