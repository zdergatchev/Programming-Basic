using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.BlurFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            int blurAmount = int.Parse(Console.ReadLine());
            //int blurAmount = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] matrixSize = Console.ReadLine().Split(new char[] { ' ' },
                    StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int rows = matrixSize[0];
            int cols = matrixSize[1];
            var matrix = new long[rows, cols];
            //var matrix = new int[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                //int[] num = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                int[] num = Console.ReadLine().Split(new char[] { ' ' }, 
                    StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = num[col];
                }
            }

            int[] coordinateElement = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int coordinateRow = coordinateElement[0];
            int coordinateCol = coordinateElement[1];

            for (int row = coordinateRow - 1; row <= coordinateRow + 1; row++)
            {
                for (int col = coordinateCol - 1; col <= coordinateCol + 1; col++)
                {
                    bool isValid = ValidPosition(row, col, rows, cols);
                    if (isValid)
                    {
                        matrix[row, col] = matrix[row, col] + blurAmount;
                    }
                    //if (row == coordinateRow && col == coordinateCol)
                    //{
                    //    matrix[row - 1, col - 1] = matrix[row - 1, col - 1] + blurAmount;
                    //    matrix[row - 1, col] = matrix[row - 1, col] + blurAmount;
                    //    matrix[row - 1, col + 1] = matrix[row - 1, col + 1] + blurAmount;
                    //    matrix[row, col - 1] = matrix[row, col - 1] + blurAmount;
                    //    matrix[row, col] = matrix[row, col] + blurAmount;
                    //    matrix[row, col + 1] = matrix[row, col + 1] + blurAmount;
                    //    matrix[row + 1, col - 1] = matrix[row + 1, col - 1] + blurAmount;
                    //    matrix[row + 1, col] = matrix[row + 1, col] + blurAmount;
                    //    matrix[row + 1, col + 1] = matrix[row + 1, col + 1] + blurAmount;
                    //}
                }
            }
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols - 1; col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine(matrix[row, cols - 1]);
            }
        }     
 
        public static bool ValidPosition(int row, int col, int matrixRows, int matrixCols)
        {
            if(row >= 0 && col >= 0 && row < matrixRows && col < matrixCols)
            {
                return true;
            }
        return false;
        }           
    }
}





