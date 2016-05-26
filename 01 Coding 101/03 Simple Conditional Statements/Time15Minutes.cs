using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
//using System.Threading;


namespace Time15Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputHours = int.Parse(Console.ReadLine());
            var imputMinutes = int.Parse(Console.ReadLine());
            int minuteOffset = 15;
            var minutes = imputMinutes + minuteOffset;
            var hours = inputHours;

            if (minutes > 59)
            {
                hours = hours + 1;
                minutes = minutes - 60;
            }
            if (hours > 23)
            {
                hours = 0;
            }
            if (minutes < 10)
            {
                Console.WriteLine("{0}:0{1}", hours, minutes);
            }
            else
            {
                Console.WriteLine("{0}:{1}", hours, minutes);
            }

        }
    }
}
