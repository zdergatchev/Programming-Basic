using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.RectangleOf10x10Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            // for (int i = 0; i < 10; i++)
            //  {
            //     Console.WriteLine(new string('*', 10));
            // } 
            var n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                if (i % 2 == 0)
                {
                    for (int row = 0; row < n; row++)
                    {
                        Console.Write('-');
                    }
                }
                else
                    for (int col = 0; col < n; col++)
                    {
                        Console.Write('*');
                    }
                Console.WriteLine();
            }
        }
    }
}
