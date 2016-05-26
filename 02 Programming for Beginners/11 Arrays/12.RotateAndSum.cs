using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.RotateAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var shiftStep = int.Parse(Console.ReadLine());
            
            int[] arrayTemp = new int[arr.Length];
            int[] resultArr = new int[arr.Length];

            for (int i = 0; i < shiftStep; i++)
            {
                int lastElement = arr[arr.Length - 1];           // save the last element
                for (int j = arr.Length - 1; j >= 1; j--)
                {
                    arr[j] = arr[j - 1];        // shift the elements
                }
                arr[0] = lastElement;
                for (int k = 0; k < arr.Length; k++)
                {
                    resultArr[k] = resultArr[k] + arr[k];   // current iteration array
                }               
            }
            Console.WriteLine(string.Join(" ", resultArr));
        }
    }
}
