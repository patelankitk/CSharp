using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionBook
{
    class books
    {
        public string title;
        public string author;
        public int ISBN;
        public double price;

        public books()
        {

        }
        

        public books(string title, string author, int ISBN, double price)
        {
            this.title = title;
            this.author = author;
            this.ISBN = ISBN;
            this.price = price;
        }

        

        public static void ListBook(List<books> b1)
        {
            foreach (books b in b1)
            {
                Console.WriteLine("\nBook List is as follows :\nTitle : {0} \nAuthor :{1} \nISBN :{2} \nPrice :{3}", b.title, b.author, b.ISBN, b.price);
            }
        } 

        public static void AddBook(string title, string author, int ISBN, double price,List<books> b1)
        {
            books b = new books();
            b.title = title;
            b.author = author;
            b.ISBN = ISBN;
            b.price = price;
            b1.Add(b);

        }

       
        public static void RemoveBooks(List<books> b1)
        {
            Console.WriteLine("Please Enter the Book title you wish to remove.");
            string bookRemove = Console.ReadLine();

            for (int i = 0; i < b1.Count; i++)
            {
                if (b1[i].title.ToLower() == bookRemove.ToLower())
                {
                    b1.RemoveAt(i);
                    Console.WriteLine("\nYour book with title {0} has been removed.", bookRemove);
                }
            }
        }


    }
}
