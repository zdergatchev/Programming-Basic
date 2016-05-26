using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenOrOdd
{
    class Program
    {
        static void Main(string[] args)
        {
            var numum = double.Parse(Console.ReadLine());
            if (numum % 2 == 0)
            {
                Console.WriteLine("evenum");
            }
            else
            {
                Console.WriteLine("odd");
            }
        }
    }
}
