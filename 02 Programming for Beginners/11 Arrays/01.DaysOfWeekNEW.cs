using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.DaysOfWeekNEW
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] days = { "Monday", "Tuesday", "Wednesday",
                              "Thursday", "Friday",
                              "Saturday", "Sunday" };

           // int day = int.Parse(Console.ReadLine());
            for (int i = 0; i < days.Length; i++)
            {
                Console.WriteLine(days[i]);
            }
        }
    }
}
