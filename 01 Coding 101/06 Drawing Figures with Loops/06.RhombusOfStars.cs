using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.RhombusOfStars
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n - 1; i++)
            {                   
                // Display spaces
                for (int spaces = 0; spaces < (n - i) - 2; spaces++)
                {
                    Console.Write(" ");
                }
                // Display stars
                for (int stars = 0; stars <= i; stars++)
                {
                    Console.Write(" ");
                    Console.Write("*");
                }
                // Newline
                Console.WriteLine();
            }

            for (int i = 0; i < n; i++)
            {
                Console.Write("*");
                Console.Write(" ");
            }
            Console.WriteLine();
            

            for (int i = n - 1; i > 0; i--)
            {                   
                // Display spaces
                for (int spaces = (n - i) - 1; spaces > 0; spaces--)
                {
                    Console.Write(" ");
                }
                // Display stars
                for (int stars = i - 1; stars >= 0; stars--)
                {
                    Console.Write(" ");
                    Console.Write("*");
                }
                // Newline
                Console.WriteLine();
            }            
        }        
    }
}



