using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaOfFigures
{
    class Program
    {
        static void Main(string[] args)
        {
            string menu = Console.ReadLine();
            string figureSquare = "square";
            string figureRectangle = "rectangle";
            string figureCircle = "circle";
            string figureTriangle = "triangle";

            if (menu == figureSquare)
            {
                var side = double.Parse(Console.ReadLine());
                var area = side * side;
                Console.WriteLine(Math.Round(area, 3));
            }
            else if (menu == figureRectangle)
            {
                var sideOne = double.Parse(Console.ReadLine());
                var sideSecond = double.Parse(Console.ReadLine());
                var area = sideOne * sideSecond;
                Console.WriteLine(Math.Round(area, 3));
            }
            else if (menu == figureCircle)
            {
                var radius = double.Parse(Console.ReadLine());
                var area = Math.PI * (radius * radius);
                Console.WriteLine(Math.Round(area, 3));
            }
            else if (menu == figureTriangle)
            {
                var side = double.Parse(Console.ReadLine());
                var height = double.Parse(Console.ReadLine());
                var area = (side * height) / 2;
                Console.WriteLine(Math.Round(area, 3));
            }
        }
    }
}
