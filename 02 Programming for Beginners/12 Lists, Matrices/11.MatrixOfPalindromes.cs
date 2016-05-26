using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.MatrixOfPalindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            //string inputArrayOne = Console.ReadLine();
            //char[] delimiter = new char[] {' '};
            //string[] inputOne = inputArrayOne.Split(delimiter, StringSplitOptions.RemoveEmptyEntries);
            //int[] arr = new int[inputOne.Length];
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int matrixRows = arr[0];
            int matrixCols = arr[1];

            string[,] polidromesMatrix = new string[matrixRows, matrixCols];

            for (int row = 0; row < matrixRows; row++)
            {
                for (int col = 0; col < matrixCols; col++)
                {
                    polidromesMatrix[row, col] = "" + (char)('a' + row) + (char)('a' + row + col) + (char)('a' + row);
                }
            }

            for (int row = 0; row < matrixRows; row++)
            {
                for (int col = 0; col < matrixCols; col++)
                {
                    Console.Write(polidromesMatrix[row, col] + " ");
                }
                Console.WriteLine();
            }
        }
                              
    }
}
