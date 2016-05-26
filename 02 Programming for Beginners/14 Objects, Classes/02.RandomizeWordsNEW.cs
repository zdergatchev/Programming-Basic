using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.RandomizeWordsNEW
{
    class Program
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine().Split(' ').ToArray();
            Random rnd = new Random();

            for (int pos = 0; pos < words.Length; pos++)
            {
                var randomPos = rnd.Next(words.Length);
                var oldWord = words[pos];
                words[pos] = words[randomPos];
                words[randomPos] = oldWord;
            }
            
            Console.WriteLine(string.Join("\r\n", words));
        }
    }
}
