using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetricConverter2
{
    class Program
    {
        static void Main(string[] args)
        {
            // http://www.endmemo.com/sconvert/cmmm.php
            // http://www.endmemo.com/convert/length%20and%20distance.php

            var value = double.Parse(Console.ReadLine());
            var inputDimension = Console.ReadLine();
            var outputDimension = Console.ReadLine();

            switch (inputDimension)
            {
                case "mm": value = value / 1000; break;
                case "cm": value = value / 100; break;
                case "mi": value = value / 0.000621371192; break;
                case "in": value = value / 39.3700787; break;
                case "km": value = value / 0.001; break;
                case "ft": value = value / 3.2808399; break;
                case "yd": value = value / 1.0936133; break;
            }

            switch (outputDimension)
            {
                case "mm": value = value * 1000; break;
                case "cm": value = value * 100; break;
                case "mi": value = value * 0.000621371192; break;
                case "in": value = value * 39.3700787; break;
                case "km": value = value * 0.001; break;
                case "ft": value = value * 3.2808399; break;
                case "yd": value = value * 1.0936133; break;
            }         
            
            Console.WriteLine(value + " " + outputDimension);
        }
    }
}
