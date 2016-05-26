using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.RectangleWithStarsNEW
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int space = 2 * n - 2;
            int spaceBridge = n - 2;

            Console.WriteLine(new string('%', n * 2));

            for (int i = 0; i < (n - 1) / 2; i++)
            {
                Console.WriteLine("%{0}%", new string(' ', space));
            }

            Console.WriteLine("%{0}**{0}%", new string(' ', spaceBridge));

            for (int i = 0; i < (n - 1) / 2; i++)
            {
                Console.WriteLine("%{0}%", new string(' ', space));
            }

            Console.WriteLine(new string('%', n * 2));
        }
    }
}
