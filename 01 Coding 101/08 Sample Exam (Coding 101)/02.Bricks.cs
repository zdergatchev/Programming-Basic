using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Bricks
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int w = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());

            if (x <= 1000 && x >= 1 && w <= 1000 && w >= 1 && m <= 1000 && m >= 1)
            {               
                int remain = x % (w * m);
                if (remain == 0)
                {
                    int courses = x / (w * m);
                    Console.WriteLine(courses);
                }
                else if(remain != 0 && remain < (w * m))
                {
                    int courses = x / (w * m) + 1;
                    Console.WriteLine(courses);
                }
                else if (remain != 0 && remain < 1)
                {
                    int courses = 1;
                    Console.WriteLine(courses);
                }
            }
        }
    }
}
