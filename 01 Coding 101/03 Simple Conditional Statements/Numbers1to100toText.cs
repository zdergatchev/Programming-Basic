using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbers1to100toText
{
    class Program
    {
        static void Main(string[] args)
        {
            //var n = int.Parse(Console.ReadLine());

            //Console.WriteLine("Please enter an integer number [0..99] and press Enter.");
            uint num = uint.Parse(Console.ReadLine());

            uint hundred = num / 100;
            uint tenth = (num / 10) % 10;
            uint unit = num % 10;
            string str = null;

            string[] units = { null, "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "sventeen", "eightteen", "nineteen" };
            string[] uintsCaps = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eightteen", "nineteen" };
            string[] tenths = { null, "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };
            string[] tenthsCaps = { null, "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };

            if ((num >= 0) && (num <= 19))
            {
                str = uintsCaps[num];
            }

            if ((num >= 20) && (num <= 99))
            {
                str = tenthsCaps[tenth] + " " + units[unit];
            }


            if ((num >= 100) && (tenth == 0) && (unit == 0))
            {
                str = uintsCaps[hundred] + " hundred " + units[unit];
            }

            // if ((num >= 100) && (tenth != 0))
            //  {
            //     str = uintsCaps[hundred] + " hundred and " + tenths[tenth] + " " + units[unit];
            //  }

            Console.WriteLine(str);
        }
    }
}
