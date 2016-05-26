﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.SequenceOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            //string inputArrayOne = Console.ReadLine();
            //char[] delimiter = new char[] {' '};
            //string[] inputOne = inputArrayOne.Split(delimiter, StringSplitOptions.RemoveEmptyEntries);
            string[] inputOne = Console.ReadLine().Split(' ').ToArray();
            int[] arr = new int[inputOne.Length];
            for (int i = 0; i < inputOne.Length; i++)
            {
                arr[i] = int.Parse(inputOne[i]);
            }
            int counter = 0;
            int maxSequence = 0;
            int index = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                counter = 0;
                int j = i;

                while (arr[i] == arr[j])
                {
                    counter++;
                    j++;
                    if (j >= arr.Length)
                    {
                        break;
                    }
                }

                if (counter > maxSequence)
                {
                    maxSequence = counter;
                    index = i;
                }
            }

            for (int i = index; i <= index + maxSequence - 1; i++)
            {
                if (i != index + maxSequence - 1)
                {
                    Console.Write(arr[i] + " ");
                }
                else
                {
                    Console.WriteLine(arr[i]);
                }
            }
        }
    }
}
