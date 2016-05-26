using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElementEqualtoSumOfOthers
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            int max = int.MinValue;
            int sum = 0;

            for (var i = 1; i <= n; i++)
            {
                var num = int.Parse(Console.ReadLine());
                sum = sum + num;
                if (num > max)
                {
                    max = num;
                }
            }
            
            if (sum - (2 * max) == 0)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = {0}", max);
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine("Diff = {0}", Math.Abs(max - (sum - max)));
            }                   
         }
    }
}
