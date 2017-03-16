using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{
    class LMB
    {
        public static void Main()
        {
            Func<int, int, string> lambda = (x, n) => (x + n).ToString();
            Console.WriteLine(lambda(4,5));
        }
    }
}
