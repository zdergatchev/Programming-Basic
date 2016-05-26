using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareFrame
{
    class Program
    {     
         static void Main(string[] args)
            {
                var n = int.Parse(Console.ReadLine());

                for (int j = 0; j < n; j++)
                {
                    for (int i = 0; i < n; i++)
                    {
                        if (j == 0 || j == n - 1)           
                            Console.Write("*");
                        else if (i == 0 || i == n - 1)      
                            Console.Write("*");
                        else
                            Console.Write(" ");            
                    }
                    Console.WriteLine();
                }

            }

        }
    }

