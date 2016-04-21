using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Int_Double_and_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            switch (type)
            {
                case "integer":
                    int Data1 = int.Parse(Console.ReadLine());
                    Console.WriteLine(1 + Data1);
                    break;
                case "real":
                    double Data2 = double.Parse(Console.ReadLine());
                    Console.WriteLine("{0:f2}", (1 + Data2));
                    break;
                default:
                    string Data3 = Console.ReadLine();
                    Console.WriteLine("{0}*", Data3);
                    break;
            }
        }
    }
}
