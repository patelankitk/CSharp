using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFBookList
{
    class books
    {
        public string title;
        public string author;
        public int ISBN;
        public double price;

        public void AddBooks(string title, string author, int ISBN, double price)
        {
            this.title = title;
            this.author = author;
            this.ISBN = ISBN;
            this.price = price;
        }
    }
}
