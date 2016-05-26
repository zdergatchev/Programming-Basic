using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.GameOfNames
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int maxSum = int.MinValue;
            string newName = string.Empty;
            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                int score = int.Parse(Console.ReadLine());
                int sum = score;
                for (int j = 0; j < name.Length; j++)
                {
                    if (name[j] % 2 == 0)
                    {
                        sum += name[j];
                    }
                    else
                    {
                        sum -= name[j];
                    }
                }
                if (sum > maxSum)
                {
                    maxSum = sum;
                    newName = name;
                }
            }
            Console.WriteLine("The winner is {0} - {1} points", newName, maxSum);
        }
    }
}
