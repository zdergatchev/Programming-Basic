using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.TriangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var x1 = double.Parse(Console.ReadLine());
            var y1 = double.Parse(Console.ReadLine());
            var x2 = double.Parse(Console.ReadLine());
            var y2 = double.Parse(Console.ReadLine()); 
            var x3 = double.Parse(Console.ReadLine());
            var y3 = double.Parse(Console.ReadLine());

            //if (x1 <= 1000 && x1 >= -1000 && x2 <= 1000 && x2 >= -1000 &&
            //    x3 <= 1000 && x3 >= -1000 && y1 <= 1000 && y1 >= -1000 &&
            //    y2 <= 1000 && y2 >= -1000)
            {
                double a = Math.Abs(x2 - x3);
                double h = Math.Abs(y1 - y3);
                var area = (a * h) / 2.0;
                Console.WriteLine(area);
            }                      
        }
    }
}
