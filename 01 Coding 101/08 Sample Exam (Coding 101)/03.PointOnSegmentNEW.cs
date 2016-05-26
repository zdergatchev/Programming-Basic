using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.PointOnSegmentNEW
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstEnd = int.Parse(Console.ReadLine());
            var secondEnd = int.Parse(Console.ReadLine());
            var point = int.Parse(Console.ReadLine());
                       
            if((point >= firstEnd) && (point <= secondEnd) ||
               (point <= firstEnd) && (point >= secondEnd))
            {
                Console.WriteLine("in");
                Console.WriteLine(Math.Min(Math.Abs(point - firstEnd), Math.Abs(point - secondEnd)));
            }
            else
            {
                Console.WriteLine("out");
                Console.WriteLine(Math.Min(Math.Abs(point - firstEnd), Math.Abs(point - secondEnd)));
            }
        }
    }
}
