using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadiansToDegrees
{
    class Program
    {
        static void Main(string[] args)
        {
            var angleInRadian = double.Parse(Console.ReadLine());
            var angleInDeg = angleInRadian * (180.0 / Math.PI);
            Console.WriteLine("Angle in degree: = " + angleInDeg);
        }
    }
}
