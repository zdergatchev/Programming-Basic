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

            var inputCurrency = Console.ReadLine();   //����������, ����� ������� ��������� ������
            var outputCurrency = Console.ReadLine();  //����������, �� ���������� ������

            if (inputCurrency == "USD" && outputCurrency == "BGN")
                if (q == "1")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("��������� ��������� = {0}", a * b);
            }
            if (q == "2")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("��������� ������� = {0}", a / b);
            }
            if (q == "3")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("��������� �������� = {0}", a + b);
            }
            if (q == "4")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("��������� ��������� = {0}", a - b);
            }
            if (q == "5")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("��������� ���������� ����� � ������� = {0}", Math.Pow(a, b));
            }

            var fixing = 1.79549;
            var convertBGN = USD * fixing;
            Console.WriteLine(Math.Round(convertBGN, 2));
        }
    }
}
