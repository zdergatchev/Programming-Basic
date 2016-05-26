using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.SumAdjacentEqualNumbersNEW
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            int pos = 0;
            // 2 1 1 5 5
            while (pos < nums.Count - 1)
            {
                if (nums[pos] == nums[pos + 1])
                {
                    nums[pos] = nums[pos] + nums[pos + 1];
                    nums.RemoveAt(pos + 1);
                    pos--; // TODO: ensure the position is non-negative
                    if (pos < 0) pos = 0;
                }
                else
                {
                    pos++;
                }
            }
            Console.WriteLine(string.Join(" ", nums));
        }
    }
}
