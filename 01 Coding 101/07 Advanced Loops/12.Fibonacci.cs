using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var firstNumber = 1;
            var secondNumber = 1;
            for (var i = 0; i < n - 1; i++)
            {
                var fNext = firstNumber + secondNumber;
                firstNumber = secondNumber;
                secondNumber = fNext;
            }
            Console.WriteLine(secondNumber);
        }
    }
}
