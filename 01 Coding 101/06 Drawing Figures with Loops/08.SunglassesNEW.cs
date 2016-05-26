using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.SunglassesNEW
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            string star = new string('*', (2 * n));
            string space = new string(' ', n);
            string dash = new string('/', (2 * n) - 2);
            string bridge = new string('|', n);
            Console.WriteLine(star + space + star);
            for (int i = 0; i < n - 2; i++)
            {
                if (i % 2 != 0 && i == ((n - 2) - 1) / 2)
                {
                    Console.WriteLine('*' + dash + '*' + bridge + '*' + dash + '*');
                }
                else if (i %2 == 0 && i == ((n - 2) - 1) / 2)
                {
                    Console.WriteLine('*' + dash + '*' + bridge + '*' + dash + '*');
                }
                else
                {
                    Console.WriteLine('*' + dash + '*' + space + '*' + dash + '*');
                }
            }
            Console.WriteLine(star + space + star);
            Console.WriteLine();
        }
    }
}
