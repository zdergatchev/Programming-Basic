using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.DateAfter5Days
{
    class Program
    {
        static void Main(string[] args)
        {
            var day = int.Parse(Console.ReadLine());
            var month = int.Parse(Console.ReadLine());

            var daysInMonth = 31;
            if (month == 4 || month == 6 || month == 9 || month == 11)
            {
                day = 30;
            }
            else if (month == 2)
            {
                day = 28;
            }

            day = day + 5;

            if (day > daysInMonth)
            {
                day = day - daysInMonth;
                month++;

                if (month == 13)
                {
                    month = 1;
                }
            }
            if (month < 10)
            {
                Console.WriteLine("{0}.0{1}", day, month);
            }
            else
            {
                Console.WriteLine("{0}.{1}", day, month);
            }
        }
    }
}
