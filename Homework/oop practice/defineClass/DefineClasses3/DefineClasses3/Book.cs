using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DefineClasses3
{
    public class Book 
    {
        
        public Book(string title, string author)
        {
            this.Author = author;
            this.Title = title;
        }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public int YearPublished { get; set; }
        public int ISBNNumber { get; set; }
        public override string ToString()
        {
                return this.Author + " " + this.Title + "\n" +
                    this.Publisher + "\n" + this.YearPublished + "\n" + this.ISBNNumber;
            
        }
        
        

    }
}
