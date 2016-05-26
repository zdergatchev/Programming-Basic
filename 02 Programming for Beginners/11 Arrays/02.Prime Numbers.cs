﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Prime_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            bool[] primes = new bool[n + 1];

            for (int i = 0; i <= n; i++)
            {
                primes[i] = true;
            }
            primes[0] = primes[1] = false;

            for (int p = 2; p <= n; p++)
            {
                if (primes[p])
                {
                    FillPrimes(primes, p);
                }
            }
            Console.WriteLine();
        }
                
        static void FillPrimes(bool[] primes, int step)
        {
            for (int i = 2 * step; i < primes.Length; i += step)
            {
                primes[i] = false;
            }                   
        }
    }
}

