using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string projectionType = Console.ReadLine();
            var rows = int.Parse(Console.ReadLine());
            var columns = int.Parse(Console.ReadLine());
            double sum = 0.0;
            int places = rows * columns;

            switch (projectionType)
            {
                case "Premiere": sum = 12.00 * places; break;
                case "Normal": sum = 7.50 * places; break;
                case "Discount": sum = 5.00 * places; break;
            }
            Console.WriteLine("{0:f2} leva", sum);
        }
    }
}
