using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleOf55Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 10;
            for (int i = 0; i <= n; i++)
            {
                string asterisks = new string('*', i);
                string spaces = new string(' ', n - i);
                Console.Write(asterisks);
                Console.WriteLine(spaces);
            }
        }
    }
}
