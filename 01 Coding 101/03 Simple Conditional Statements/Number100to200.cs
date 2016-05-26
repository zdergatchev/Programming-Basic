using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number100to200
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputnumber = int.Parse(Console.ReadLine());

            if (inputnumber < 100)
            {
                Console.WriteLine("Less than 100");
            }
            else if (inputnumber > 200)
            {
                Console.WriteLine("Greater than 200");
            }
            else
            {
                Console.WriteLine("Between 100 and 200");
            }
        }
    }
}
