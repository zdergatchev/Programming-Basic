using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.GenerateRectangles
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var minArea = int.Parse(Console.ReadLine());
            var count = 0;

            for (int left = -n; left <= n; left++)
            {
                for (int top = -n; top <= n; top++)
                {
                    for (int right = left + 1; right <= n; right++)
                    {
                        for (int bottom = top + 1; bottom <= n; bottom++)
                        {
                            var with = right - left;
                            var height = bottom - top;
                            var area = with * height;
                            if (area >= minArea)
                            {
                                Console.WriteLine("({0}, {1}) ({2}, {3}) -> {4}", left, top, right, bottom, area);
                                count++;
                            }                           
                        }
                    }
                }
            }
            if (count == 0)
                Console.WriteLine("No");
        }
    }
}
