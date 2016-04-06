using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Age
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime Birthdate = DateTime.Parse(Console.ReadLine());
            TimeSpan AgeToday = DateTime.Today - Birthdate;
            
            int AgeTodayDays = AgeToday.Days;
            double AgeTodayYears = AgeTodayDays / 365.25;
            Console.WriteLine((int)AgeTodayYears);
            int Age10YearsAhead = (int)AgeTodayYears + 10;
            Console.WriteLine(Age10YearsAhead);            
        }
    }
}
