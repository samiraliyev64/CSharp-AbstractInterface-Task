using System;
using System.Collections.Generic;
using System.Text;

namespace Book_Task.Models
{
    class Book:Product
    {
        public string Genre;

        public Book(string Genre, int No, string Name, int Price):base(No,Name,Price)
        {
            this.Genre = Genre;
        }

        public Book()
        {

        }
    }
}
