using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\n\n*********************************************Book Collection.***************************************************");

            List<books> BookList = new List<books>();

            books book1 = new books();
            book1.title = "a";
            book1.author = "ankit";
            book1.ISBN = 12345;
            book1.price = 12.35;
            BookList.Add(book1);

            books book2 = new books();
            book2.title = "b";
            book2.author = "patel";
            book2.ISBN = 1234567;
            book2.price = 20;
            BookList.Add(book2);

            foreach (books b in BookList)
            {
                Console.WriteLine("{0}{1}{2}{3}",b.title,b.author,b.ISBN,b.price);
            }
        }
    }
}
