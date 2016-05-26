using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.DressPatternNEW
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int totalWidth = 12 * n + 2;
            int horizontalWidth = 3 * n;

            //Draw first part
            Console.WriteLine("{0}.{0}.{0}", new string('_', 4 * n));
            //Console.WriteLine();

            //Draw second part
            for (int i = 2; i <= (totalWidth - 4) / 2; i += 3)            
            {
                int middleWith = (totalWidth - 2 * i - 4) / 3;
                int sleev = i;
                Console.WriteLine("{0}.{1}.{0}.{1}.{0}",
                    new string('_', middleWith),
                    new string('*', sleev));
                //Console.WriteLine();                
            }

            //Draw third part            
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(".{0}.",
                    new string('*', totalWidth - 2));
                //Console.WriteLine();
            }

            //Draw four part
            Console.WriteLine("{0}{1}{0}",
                    new string('.', horizontalWidth),
                    new string('*', totalWidth - 2 * horizontalWidth));
            //Console.WriteLine();

            //Draw five part            
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}{1}{0}",
                    new string('_', horizontalWidth),
                    new string('o', totalWidth - 2 * horizontalWidth));
               // Console.WriteLine();
            }

            //Draw five part
            for (int i = 0; i < 3 * n; i++)
            {
                int dress = 6 * n;
                Console.WriteLine("{0}.{1}.{0}",
                    new string('_', horizontalWidth - i),
                    new string('*', dress + 2 * i));
                //Console.WriteLine();                
            }

            //Draw sixt part           
            Console.WriteLine("{0}", new string('.', totalWidth));            
        }
    }
}
