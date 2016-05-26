using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CelsiusFahrenheitConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            var temperatureCelsius = double.Parse(Console.ReadLine());
            var temperatureFahrenheit = (temperatureCelsius * 9 / 5) + 32;
            Console.WriteLine("temperature in Fahrenheit = " + Math.Round(temperatureFahrenheit, 2));
        }
    }
}

