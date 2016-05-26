using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.CountLettersInString
{
    class Program
    {
        static void Main(string[] args)
        {
           string str = Console.ReadLine().ToLower();
           int[] counts = new int[char.MaxValue + 1]; //1, zashtoto pochvat ot 0
           foreach(var letter in str)
            {
                counts[letter]++; // char-a se tretira kato chislo
            }
            for (int i = 0; i < counts.Length; i++)
            {
                if(counts[i] > 0)
                {
                    var letter = (char)i;
                    var occurences = counts[i];
                    Console.WriteLine("{0} -> {1}", letter, occurences);
                }
            }
        }
    }
}
