using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.PointOnSegmentNEW1
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstEnd = int.Parse(Console.ReadLine());
            var secondEnd = int.Parse(Console.ReadLine());
            var point = int.Parse(Console.ReadLine());

            var left = Math.Min(firstEnd, secondEnd);
            var right = Math.Max(firstEnd, secondEnd);
            var pointOnSegment = (point >= left) && (point <= right);

            var leftDistance = Math.Abs(point - left);
            var rightDistance = Math.Abs(point - right);
            var distance = Math.Min(leftDistance, rightDistance);

            if(pointOnSegment)
            {
                Console.WriteLine("in");
                Console.WriteLine(distance);
            }
            else
            {
                Console.WriteLine("out");
                Console.WriteLine(distance);
            }
        }
    }
}
