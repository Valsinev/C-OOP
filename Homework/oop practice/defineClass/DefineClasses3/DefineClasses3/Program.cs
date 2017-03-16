
namespace DefineClasses3
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    

    class Program
    {
        static void Main()
        {
            Library biblioteka = new Library("Izgrev");
            Book thousandNights = new Book("1001 noshti", "Alibaba");
            Book karibskiPirati = new Book("Karibski pirati", "Kiro");
            Book cheverme = new Book("Cheverme", "Stanoi");
            Book banicaSKasmeti = new Book("Banica s kasmeti", "Kiro");
            Book karamba = new Book("Karamba", "Kosta");

            biblioteka.AddBook(thousandNights);
            biblioteka.AddBook(karibskiPirati);
            biblioteka.AddBook(cheverme);
            biblioteka.AddBook(banicaSKasmeti);
            biblioteka.AddBook(karamba);
            biblioteka.FindAuthor("Kiro");

            Console.WriteLine(biblioteka);
            
          
        }
    }
}
