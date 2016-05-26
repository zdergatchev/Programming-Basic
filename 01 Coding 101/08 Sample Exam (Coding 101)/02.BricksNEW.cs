using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.BricksNEW
{
    class Program
    {
        static void Main(string[] args)
        {
            var bricks = double.Parse(Console.ReadLine());
            var workers = double.Parse(Console.ReadLine());
            var bricksPerWorkers = double.Parse(Console.ReadLine());

            var bricksPerCourse = workers * bricksPerWorkers;

            var courseCount = Math.Ceiling(bricks / bricksPerCourse);
            Console.WriteLine(courseCount);
        }
    }
}
