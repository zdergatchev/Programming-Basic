using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Моля въведетер брой числе n =");
            Console.Write("n = ");
            var n = int.Parse(Console.ReadLine());
            var min = int.MaxValue;
            for (var i = 1; i <= n; i++)
            {
                var num = int.Parse(Console.ReadLine());
                if (num < min)
                    min = num ;
            }
            Console.WriteLine("min = " + min);
        }
    }
}
