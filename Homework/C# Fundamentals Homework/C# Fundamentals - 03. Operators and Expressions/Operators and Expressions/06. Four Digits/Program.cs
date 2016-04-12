using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Four_Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            string stringNumber = Convert.ToString(number);
            char[] stringChar = stringNumber.ToCharArray();
            char a = stringChar[0];
            char b = stringChar[1];
            char c = stringChar[2];
            char d = stringChar[3];
            string Sa = a.ToString();
            string Sb = b.ToString();
            string Sc = c.ToString();
            string Sd = d.ToString();
            int A = Convert.ToInt32(Sa);
            int B = Convert.ToInt32(Sb);
            int C = Convert.ToInt32(Sc);
            int D = Convert.ToInt32(Sd);
            int Result = A + B + C + D;
            Console.WriteLine("{0}",Result);
            Console.WriteLine("{0}{1}{2}{3}",d,c,b,a);
            Console.WriteLine("{0}{1}{2}{3}", d, a, b, c);
            Console.WriteLine("{0}{1}{2}{3}", a, c, b, d);
        }
    }
}
