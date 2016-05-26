using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.FoldAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] arrMiddle = new int[arr.Length / 2];
            int[] arrLeft = new int[arr.Length / 4];
            int[] arrRight = new int[arr.Length / 4];
                       
            for (int i = 0; i < arr.Length / 4; i++)
            {
                arrLeft[i] = arr[i];
            }
            for (int i = (3 * arr.Length) / 4; i <= arr.Length - 1; i++)
            {
                arrRight[i - (3 * arr.Length) / 4] = arr[i];
            }
            for (int i = arr.Length / 4; i <= ((3 * arr.Length) / 4) - 1; i++)
            {
                arrMiddle[i - arr.Length / 4] = arr[i];
            }
           // Console.WriteLine(string.Join(" ", arrMiddle));

            Array.Reverse(arrLeft);
           // Console.WriteLine(string.Join(" ", arrLeft));

            for (int i = 0; i < arr.Length / 4; i++)
            {
                arrMiddle[i] += arrLeft[i];
            }
            Array.Reverse(arrRight);
           // Console.WriteLine(string.Join(" ", arrRight));

            for (int i = arrMiddle.Length / 2; i < arrMiddle.Length; i++)
            {
                arrMiddle[i] += arrRight[i - arrMiddle.Length / 2];
            }
            Console.WriteLine(string.Join(" ", arrMiddle));

        }
    }
}
