using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.ClosestTwoPoints
{
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public override string ToString()
        {
            return "Point(" + X + ", " + Y + ")";
        }
    }

    class ClosestsTwoPoints
    {
        public Point p1 { get; set; }
        public Point p2 { get; set; }

        public double Distance { get; set; }
       
    }
    class Program
    {
        static void Main()
        {
            Point[] points = ReadPoints();
            var closestsTwoPoints = FindClosestTwoPoints(points);
            Console.WriteLine("{0:f3}", closestsTwoPoints.Distance);
            Console.WriteLine(closestsTwoPoints.p1);
            Console.WriteLine(closestsTwoPoints.p2);
        }       

        static ClosestsTwoPoints FindClosestTwoPoints(Point[] points)
        {
            var minDist = double.MaxValue;
            ClosestsTwoPoints result = null;
            for(int i = 0; i < points.Length; i++)
            {
                for (int j = i + 1; j < points.Length; j++)
                {
                    var dist = CalcDistance(points[i], points[j]);
                    if (dist < minDist)
                    {
                        minDist = dist;
                        result = new ClosestsTwoPoints();
                        {
                            p1 = points[i],
                            p2 = points[j],
                            Distance = dist
                        };
                    }
                }
            }
            return result;
        }

        static Point ReadPoint()
        {
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Point p = new Point() { X = nums[0], Y = nums[1] };
            return p;
           // var points = new Point[n];
           // for (int i = 0; i < n; i++)
          //  {
           //     points[i] = ReadPoint();
          //  }
         //   return points;
        }

        static double CalcDistance(Point p1, Point p2)
        {
            var deltaX = p1.X - p2.X;
            var deltaY = p1.Y - p2.Y;
            var d = Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
        }

        static Point[] ReadPoints()
        {
            var n = int.Parse(Console.ReadLine());
            var points = new Point[n];
            for (int i = 0; i < n; i++)
                points[i] = ReadPoint();
            return points;
        }
    }
}
