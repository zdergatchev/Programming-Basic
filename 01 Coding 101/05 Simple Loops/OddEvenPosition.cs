using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddEvenPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = double.Parse(Console.ReadLine());
            
            var sumOdd = 0.0;
            var maxOdd = double.MinValue;     //double.MinValue
            var minOdd = double.MaxValue;      //double.MaxValue
            var sumEven = 0.0;
            var maxEven = double.MinValue;    //double.MinValue
            var minEven = double.MaxValue;     //double.MaxValue


            // count only odd values of n
            for (int i = 1; i <= n; i++)
            {
                var number = double.Parse(Console.ReadLine());
                if (i % 2 != 0)
                {
                    sumOdd = sumOdd + number;
                    if (number > maxOdd)
                    {
                        maxOdd = number;
                    }
                    if (number < minOdd)
                    {
                        minOdd = number;
                    }
                }
                else
                {
                    sumEven = sumEven + number;
                    if (number > maxEven)
                    {
                        maxEven = number;
                    }
                    if (number < minEven)
                    {
                        minEven = number;
                    }

                }
            }
            if (n == 0)
            {
                Console.WriteLine("OddSum = 0, OddMin = No, OddMax = No, EvenSum = 0, EvenMin = No, EvenMax = No");
            }
            else if (n == 1)
            {
                Console.WriteLine("OddSum = {0}, OddMin = {1}, OddMax = {2}, EvenSum = 0, EvenMin = No, EvenMax = No", sumOdd, minOdd, maxOdd);
            }
            else
            {
                Console.WriteLine("OddSum = {0}, OddMin = {1}, OddMax = {2}, EvenSum = {3}, EvenMin = {4}, EvenMax = {5}", sumOdd, minOdd, maxOdd, sumEven, minEven, maxEven);
            }                
        }     
    }
}






