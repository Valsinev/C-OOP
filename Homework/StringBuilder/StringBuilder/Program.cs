using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SB
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Pesho");
            var cut = sb.SubString(1, 3);
            Console.WriteLine(cut);
        }
    }
}
