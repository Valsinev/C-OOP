
namespace DefineClasses3
{
    using System.Collections.Generic;
    using System.Text;
    public class Library
    {
        
        private List<Book> books ;
        public Library(string name)
        {
            this.Name = name;
            this.books = new List<Book>();
        }
        public string Name { get; set; }
        public void AddBook(Book newBook)
        {
           this.books.Add(newBook);
        }
        public List<Book> FindAuthor(string author)
        {
            foreach (Book book in this.books)
            {
                if (book.Author == author)
                {
                    System.Console.WriteLine(book);
                    books.Remove(book);
                }
            }
            return this.books;
        }
        public override string ToString()
        {
            var sb = new StringBuilder();
            foreach (Book book in this.books)
            {

                sb.Append(book);
            }
                return this.Name + "\n" + sb.ToString();
        }
        
    }
}
