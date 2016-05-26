using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.PointOnSegment
{
    class Program
    {
        static void Main(string[] args)
        {
            var first = double.Parse(Console.ReadLine());
            var second = double.Parse(Console.ReadLine());
            var point = double.Parse(Console.ReadLine());


            if (first <= 1000 && first >= -1000 && second <= 1000 && second >= -1000 &&
                point <= 1000 && point >= -1000)
            {
                var middle = Math.Abs(first + second) / 2;
                if (first > second)
                {
                    var inSide = (second <= point) && (point <= first);
                    if (inSide)
                    {
                        Console.WriteLine("in");
                    }
                    else
                    {
                        Console.WriteLine("out");
                    }
                    if (point < middle)
                    {
                        var distance = Math.Abs(point - second);
                        Console.WriteLine(distance);
                    }
                    else
                    {
                        var distance = Math.Abs(first - point);
                        Console.WriteLine(distance);
                    }
                }
                //var outSide = (second > point) && (point > first);
                else
                {
                    var inSide = (first <= point) && (point <= second);

                    if (inSide)
                    {
                        Console.WriteLine("in");
                    }
                    else
                    {
                        Console.WriteLine("out");
                    }
                    if (point < middle)
                    {
                        var distance = Math.Abs(point - first);
                        Console.WriteLine(distance);
                    }
                    else
                    {
                        var distance = Math.Abs(second - point);
                        Console.WriteLine(distance);
                    }
                }
            }
        }
    }
}

