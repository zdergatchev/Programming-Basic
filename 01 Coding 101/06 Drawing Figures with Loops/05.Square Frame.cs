using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Square_Frame
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            string firstLast = "+";
            for (int i = 0; i < 2 * (n - 2) + 1; i++)     // Draw First and Last row
            {
                if (i % 2 == 0)
                {
                    firstLast += " ";
                }
                else
                {
                    firstLast += "-";
                }
            }
            firstLast += "+";
            Console.WriteLine(firstLast);

            for (int i = 1; i < n - 1; i++)     // Draw Inside row
            {
                string internalLine = "|";      // first simbol of the row
                for (int j = 0; j < 2 * (n - 2) + 1; j++)
                {
                    if (j % 2 == 0)
                    {
                        internalLine += " ";
                    }
                    else
                    {
                        internalLine += "-";    // last simbol of the row
                    }                   
                }
                internalLine += "|";
                Console.WriteLine(internalLine);
            }
            Console.WriteLine(firstLast);  
        }
    }
}


