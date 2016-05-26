using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.House
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            int star = 1;
            if (n % 2 == 0)
            {
                star = 2;
            }

            for (int i = 0; i < (n + 1) / 2; i++)
            {
                var dash = (n - star) / 2;
                Console.Write(new string('-', dash));
                Console.Write(new string('*', star));
                Console.Write(new string('-', dash));
                Console.WriteLine();
                star = star + 2;
            }

            var body = n / 2;
            for (int i = 0; i < body; i++)
            {
                Console.Write('|');
                Console.Write(new string('*', n - 2));
                Console.WriteLine('|');
            }
        }
    }
}
