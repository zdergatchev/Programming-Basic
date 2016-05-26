using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConverterNEW
{
    class Program
    {
        static void Main(string[] args)
        {
            var value = double.Parse(Console.ReadLine());
            if (value <= 0)
            {
                Console.WriteLine("Incorrect correct input data  = " + Math.Round(value, 2));
                return;
            }

            var FirstCurrency = Console.ReadLine();    
            var SecondCurrency = Console.ReadLine();
            
                if (FirstCurrency == "USD")
                {
                if (SecondCurrency == "BGN")
                {
                    var dolartoBGN = value * 1.7955;
                    Console.WriteLine(Math.Round(dolartoBGN, 2));
                }
                else if (SecondCurrency == "EUR")
                {
                    var dolartoEUR = (value * 1.7955) / 1.95583;
                    Console.WriteLine(Math.Round(dolartoEUR, 2));
                }
                else if (SecondCurrency == "GBP")
                {
                    var dolartoGBP = (value * 1.79549) / 2.53405;
                    Console.WriteLine(Math.Round(dolartoGBP, 2));
                }
            }

            else if (FirstCurrency == "BGN")
            {
                if (SecondCurrency == "USD")
                {
                    var levatoUSD = value / 1.79549; ;
                    Console.WriteLine(Math.Round(levatoUSD, 2));
                }
                else if (SecondCurrency == "EUR")
                {
                    var levatoEUR = value / 1.95583;
                    Console.WriteLine(Math.Round(levatoEUR, 2));
                }
                else if (SecondCurrency == "GBP")
                {
                    var levatoGBP = value / 2.53405;
                    Console.WriteLine(Math.Round(levatoGBP, 2));
                }
            }

            else if (FirstCurrency == "EUR")
            {
                if (SecondCurrency == "BGN")
                {
                    var eurotoBGN = value * 1.95583;
                    Console.WriteLine(Math.Round(eurotoBGN, 2));
                }
                else if (SecondCurrency == "USD")
                {
                    var eurotoUSD = (value * 1.95583) / 1.79549;
                    Console.WriteLine(Math.Round(eurotoUSD, 2));
                }
                else if (SecondCurrency == "GBP")
                {
                    var eurotoGBP = (value * 1.95583) / 2.53405;
                    Console.WriteLine(Math.Round(eurotoGBP, 2));
                }
            }

            else if (FirstCurrency == "GBP")
            {
                if (SecondCurrency == "BGN")
                {
                    var poundtoBGN = value * 2.53405;
                    Console.WriteLine(Math.Round(poundtoBGN, 2));
                }
                else if (SecondCurrency == "USD")
                {
                    var poundtoUSD = (value * 2.53405) / 1.79549;
                    Console.WriteLine(Math.Round(poundtoUSD, 2));
                }
                else if (SecondCurrency == "EUR")
                {
                    var poundtoEUR = (value * 2.53405) / 1.95583;
                    Console.WriteLine(Math.Round(poundtoEUR, 2));
                }
            }
        }            
    }
}

