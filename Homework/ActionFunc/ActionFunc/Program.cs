using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActionFunc
{
    class Program
    {
        static void blabla(int number)
        {
            Console.WriteLine(number + 10);
        }
        static void po(int number)
        {
            int result = 25 * number;
            Console.WriteLine(result);
        }
        static void Main(string[] args)
        {
            Action<int> fas = Console.WriteLine;
            fas = blabla;
            fas += po;
            fas(5);
        }
    }
}
