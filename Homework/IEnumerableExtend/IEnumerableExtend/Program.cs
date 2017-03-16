using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerableExtend
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] blabla = new int[2] { 5, 3 };
            var result = blabla.Average();
            Console.WriteLine(result);
        }
    }
}
