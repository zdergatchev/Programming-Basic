﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int mid = -1;
            if (n % 2 == 0)
            {
                mid = 0;
            }

            for (int i = 1; i <= (n + 1) / 2; i++)
            {
                int leftRight = (n - 2 - mid) / 2;
                Console.Write(new string('-', leftRight));
                Console.Write('*');
                if (mid >= 0)
                {
                    Console.Write(new string('-', mid));
                    Console.Write('*');
                }
                Console.Write(new string('-', leftRight));
                Console.WriteLine();
                mid = mid + 2;
            }

            mid = n - 4;
            for (int i = 1; i < (n + 1) / 2; i++)
            {
                int leftRight = (n - 2 - mid) / 2;
                Console.Write(new string('-', leftRight));
                Console.Write('*');
                if (mid >= 0)
                {
                    Console.Write(new string('-', mid));
                    Console.Write('*');
                }
                Console.Write(new string('-', leftRight));
                Console.WriteLine();
                mid = mid - 2;
            }           
        }
    }
}
