using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.HouseNEW
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int star = 1;
            if (n % 2 == 0)
            {
                star = 2;
            }

            for (int i = 1; i < (n + 1) / 2; i++)
            {
                int dash = (n - star) / 2;
                Console.WriteLine("{0}{1}{0}",
                    new string('-', dash),
                    new string('*', star));
                star = star + 2;
            }

            Console.WriteLine("{0}", new string('*', n));

            for (int i = 0; i < n / 2; i++)
            {
                Console.WriteLine("{0}{1}{0}",
                    new string('|', 1),
                    new string('*', n - 2));
            }
        }
    }
}


