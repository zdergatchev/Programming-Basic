using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointInTheFigure
{
    class Program
    {
        static void Main(string[] args)
        {
            var h = int.Parse(Console.ReadLine());
            var x = int.Parse(Console.ReadLine());
            var y = int.Parse(Console.ReadLine());
           
            var insideBase =
                (x > 0) && (x < 3 * h) &&
                (y > 0) && (y < h);
            var insideTower =
                (x > h) && (x < 2 * h) &&
                (y > 0) && (y < 4 * h);

            var borderBaseDown = (y == 0) && (x >= 0) && (x <= 3 * h);
            var borderBaseUp = (y == h) && (x >= 0) && (x <= 3 * h);
            var borderBaseRight = (x == 3 * h) && (y >= 0) && (y <= h);
            var borderBaseLeft = (x == 0) && (y >= 0) && (y <= h);
            var borderTowerDown = (y == 0) && (x >= h) && (x <= 2 * h);
            var borderTowerUp = (y == 4 * h) && (x >= h) && (x <= 2 * h);
            var borderTowerRight = (x == 2 * h) && (y >= 0) && (y <= 4 * h);
            var borderTowerLeft = (x == h) && (y >= 0) && (y <= 4 * h);

            if (insideBase || insideTower)
            {
                Console.WriteLine("inside");
            }
            else if (borderBaseDown || borderBaseUp || borderBaseRight || borderBaseLeft ||
                     borderTowerDown || borderTowerUp || borderTowerRight || borderTowerLeft)
            {
                Console.WriteLine("border");
            }
            else
            {
                Console.WriteLine("outside");
            }
        }
    }
}
