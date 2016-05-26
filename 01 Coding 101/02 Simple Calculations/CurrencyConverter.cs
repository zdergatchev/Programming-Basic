using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            var BGN = double.Parse(Console.ReadLine());
            var USD = double.Parse(Console.ReadLine());
            var EUR = double.Parse(Console.ReadLine());
            var GBP = double.Parse(Console.ReadLine());

            var value = double.Parse(Console.ReadLine()); 

            var inputCurrency = Console.ReadLine();   //променлива, която съдържа входящата валута
            var outputCurrency = Console.ReadLine();  //променлива, за изходящата валута

            if (inputCurrency == "USD" && outputCurrency == "BGN")
                if (q == "1")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Результат умножения = {0}", a * b);
            }
            if (q == "2")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Результат деления = {0}", a / b);
            }
            if (q == "3")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Результат сложения = {0}", a + b);
            }
            if (q == "4")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Результат вычитания = {0}", a - b);
            }
            if (q == "5")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Результат возведения числа в степень = {0}", Math.Pow(a, b));
            }

            var fixing = 1.79549;
            var convertBGN = USD * fixing;
            Console.WriteLine(Math.Round(convertBGN, 2));
        }
    }
}
