﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.MatrixOfPalindromesNEW
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter numbers of row and col of matrix:");
            //int n = int.Parse(Console.ReadLine());
            //int m = int.Parse(Console.ReadLine());
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int n = arr[0];
            int m = arr[1];

            int[,] arrayMatrix = new int[n, m];
            char firstLetter = 'a';
            for (char i = 'a'; i <= firstLetter + n - 1; i++)
            {
                for (char j = i; j < i + m; j++)
                {
                    string letters = i.ToString() + j.ToString() + i.ToString();
                    Console.Write("{0} ", letters);
                }
                Console.WriteLine();

            }
        }
    }
}
