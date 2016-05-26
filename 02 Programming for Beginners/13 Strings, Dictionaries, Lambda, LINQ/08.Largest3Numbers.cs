using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Largest3Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new int[] { 10, 30, 50, 20, 40 };
            Console.WriteLine(string.Join(" ",arr.OrderBy(x => -x).Take(3)));
        }
    }
}
