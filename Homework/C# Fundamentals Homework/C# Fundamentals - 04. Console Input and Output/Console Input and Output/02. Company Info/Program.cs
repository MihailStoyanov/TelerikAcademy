using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Company_Info
{
    class Program
    {
        static void Main(string[] args)
        {
            string CompanyName = Console.ReadLine();
            string CompanyAdress = Console.ReadLine();
            string PhoneNumber = Console.ReadLine();
            string FaxNumber = Console.ReadLine();
            string Website = Console.ReadLine();
            string ManagerFirstName = Console.ReadLine();
            string ManagerLastName = Console.ReadLine();
            string ManagerAge = Console.ReadLine();
            string ManagerPhone = Console.ReadLine();

            Console.WriteLine(CompanyName);
            Console.WriteLine("Address: {0}",CompanyAdress);
            Console.WriteLine("Tel. {0}", PhoneNumber);
            if (string.IsNullOrEmpty(FaxNumber) == true || string.IsNullOrWhiteSpace(FaxNumber) == true)
            {
                Console.WriteLine("Fax: (no fax)");
            }
            else
            {
                Console.WriteLine("Fax: {0}",FaxNumber);
            }
            Console.WriteLine("Web site: {0}", Website);
            Console.WriteLine("Manager: {0} {1} (age: {2}, tel. {3})", ManagerFirstName, ManagerLastName, ManagerAge, ManagerPhone);
        }
    }
}
