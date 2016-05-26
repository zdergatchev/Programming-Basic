using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USDtoBGN
{
    class Program
    {
        static void Main(string[] args)
        {
            var USD = double.Parse(Console.ReadLine());
            var fixing = 1.79549;
            var convertBGN = USD * fixing;
            Console.WriteLine( Math.Round(convertBGN,2));
        }
    }
}
