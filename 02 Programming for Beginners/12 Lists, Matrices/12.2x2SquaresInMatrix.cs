using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12._2x2SquaresInMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int rows = arr[0];
            int cols = arr[1];

            var matrix = new string[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                var num = Console.ReadLine().Split(' ').ToArray();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = num[col];
                }
            }
            
            int arrCounter = 0;
            
            for (int row = 0; row < rows - 1; row++)
            {
                for (int col = 0; col < cols - 1; col++)
                {
                    if (matrix[row, col] == matrix[row, col + 1] &&
                            matrix[row, col] == matrix[row + 1, col + 1] &&
                            matrix[row, col] == matrix[row + 1, col])
                    {                     
                         arrCounter++;                       
                    }
                }
            }
            Console.WriteLine("{0}", arrCounter);
        }
    }
}
