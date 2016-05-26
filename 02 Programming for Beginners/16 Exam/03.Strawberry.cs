using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Strawberry
{
    class Program
    {
        static void Main(string[] args)
        {
            //Draw first part
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("\\{0}|{0}/", new string('-', n));

            //Draw second part
            for (int i = 1; i <= n / 2 - 1; i++)
            {
                int middle = n - 2;
                Console.WriteLine("{0}\\{1}|{1}/{0}",
                    new string('-', 2 * i),
                    new string('-', n - 2 * i));
            }

            //Draw third part
            Console.WriteLine("{0}#.#{0}", new string('-', n));

            //Draw four part
            //for (int i = 1; i <= n / 2 - 1; i++)
            for (int i = 0; i < n / 2; i++)
            {
                int middle = 5 + 4 * i;
                Console.WriteLine("{0}#{1}#{0}",
                    new string('-', n - 2 * i - 2),
                    //new string('-', n / 2 - 2 - 2 * i),
                    //new string('-', n / 2 + 1 - 2 * i + 1),
                    // new string('-', ((n * 2 - 1) + (i * 2) + 2)),
                    new string('.', middle));
            }

            //Draw fift part
            Console.WriteLine("#{0}#", new string('.', 2 * n + 1));

            //Draw six part
            for (int i = 1; i <= n - 1; i++)//4TH PART
            {
                //int middle = 5 + 4 * i;
                Console.WriteLine("{0}#{1}#{0}",
                    new string('-', i),
                  //  new string('.', middle));
                new string('.', ((n * 2 - 1) - (i * 2) + 2)));
                //middle = middle - 2;
                    
            }

            //Draw seven part
            Console.WriteLine("{0}#.#{0}", new string('-', n));
        }
    }
}
