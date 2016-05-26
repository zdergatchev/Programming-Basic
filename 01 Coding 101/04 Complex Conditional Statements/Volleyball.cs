using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            string yearType = Console.ReadLine();
            int numHolidays = int.Parse(Console.ReadLine());
            int numHomeWeekends = int.Parse(Console.ReadLine());
            int weekends = 48;
            int playWeekends = weekends - numHomeWeekends;      
            double weekendInSofia = (playWeekends * 3.0) / 4;     
            double holydaysInSofia = (numHolidays * 2.0) / 3;     
            double totalPlays = 0.0;
            double result = 0.0;
            totalPlays += holydaysInSofia + weekendInSofia + numHomeWeekends;

            if (yearType == "leap")
            {
                result = totalPlays + (totalPlays * 0.15);
            }
            else if (yearType == "normal")
            {
                result = totalPlays;
            }            
            Console.WriteLine(Math.Truncate(result));   
        }
    }
}
