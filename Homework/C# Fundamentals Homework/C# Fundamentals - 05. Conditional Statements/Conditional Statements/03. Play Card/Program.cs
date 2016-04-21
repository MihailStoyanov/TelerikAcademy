using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Play_Card
{
    class Program
    {
        static void Main(string[] args)
        {
            string Card = Console.ReadLine();

            if (Card == "2" || Card == "3" || Card == "4" || Card == "5" || Card == "6" || Card == "7" || Card == "8" || Card == "9" || Card == "10" || Card == "J" || Card == "Q" || Card == "K" || Card == "A")
            {
                Console.WriteLine("yes {0}", Card);
            }
            else
            {
                Console.WriteLine("no {0}", Card);
            }
        }
    }
}
