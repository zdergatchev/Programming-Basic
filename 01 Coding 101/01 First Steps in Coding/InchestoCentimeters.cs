﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InchestoCentimeters
{
    class Program
    {
        static void Main(string[] args)
        {        
                Console.Write("Inches = ");
                var inches = double.Parse(Console.ReadLine());
                var centimeters = inches * 2.54;
                Console.Write("centimeters = ");
                Console.WriteLine(centimeters);
         }
     }
}

