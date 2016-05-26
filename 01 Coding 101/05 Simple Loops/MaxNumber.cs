using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Моля въведетер брой числе n =");
            Console.Write("n = ");
            var n = int.Parse(Console.ReadLine());
            var max = -10000000000000; // var max = int.MinValue
            for (var i = 1; i <= n; i++)
            {
                var num = int.Parse(Console.ReadLine());
                if (num > max)
                    max = num;
            }
            Console.WriteLine("max = " + max);
        }
    }
}
