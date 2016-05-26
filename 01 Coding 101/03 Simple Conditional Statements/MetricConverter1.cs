using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetricConverter1
{
    class Program
    {
        static void Main(string[] args)
        {
            var value = double.Parse(Console.ReadLine());
            var inputDimension = Console.ReadLine();
            var outputDimension = Console.ReadLine();

            if (inputDimension == "mm")
            {
                value = value / 1000;
            }
            else if (inputDimension == "cm")
            {
                value = value / 100;
            }
            else if (inputDimension == "mi")
            {
                value = value / 0.000621371192;
            }
            else if (inputDimension == "in")
            {
                value = value / 39.3700787;
            }
            else if (inputDimension == "km")
            {
                value = value / 0.001;
            }
            else if (inputDimension == "ft")
            {
                value = value / 3.2808399;
            }
            else if (inputDimension == "yd")
            {
                value = value / 1.0936133;
            }

           
            if (outputDimension == "mm")
            {
                value = value * 1000;
            }
            else if (outputDimension == "cm")
            {
                value = value * 100;
            }
            else if (outputDimension == "mi")
            {
                value = value * 0.000621371192;
            }
            else if (outputDimension == "in")
            {
                value = value * 39.3700787;
            }
            else if (outputDimension == "km")
            {
                value = value * 0.001;
            }
            else if (outputDimension == "ft")
            {
                value = value * 3.2808399;
            }
            else if (outputDimension == "yd")
            {
                value = value * 1.0936133;
            }
            Console.WriteLine(value + " " + outputDimension);

        }
    }
}
