﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.ReverseArray
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            for (int i = 0; i < nums.Length / 2; i++)
            {
                SwapElements(nums, i, nums.Length - 1 - i);
            }
            Console.WriteLine(string.Join(" ", nums));
        }

        static void SwapElements(int[] arr, int i, int j)
        {
            var oldElement = arr[i];
            arr[i] = arr[j];
            arr[j] = oldElement;
        }
    }
}

