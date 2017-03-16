using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodsDelegatesLambdaLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[]{ 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18,21,42 };
            var devBy3And7 = array.Where(x => x % 3 == 0 && x % 7 == 0).ToArray();
            foreach (var item in devBy3And7)
            {
                Console.WriteLine(item);
            }
        }
    }
}
