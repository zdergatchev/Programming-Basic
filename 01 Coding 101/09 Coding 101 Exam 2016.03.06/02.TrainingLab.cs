using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.TrainingLab
{
    class Program
    {
        static void Main(string[] args)
        {
            var width = double.Parse(Console.ReadLine()) * 100;    // in centimeters
            var height = double.Parse(Console.ReadLine()) * 100;   // in centimeters

            var cols = Math.Truncate((height - 100) / 70);      // subtract coridore and devide by single place  
            var rows = Math.Truncate(width / 120);      // devided by single place width
            var seats = rows * cols - 3;
            Console.WriteLine(seats);
        }
    }
}
