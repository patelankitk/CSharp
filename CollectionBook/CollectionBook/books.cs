using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionBook
{
    class books
    {
        public static string title;
        public static string author;
        public static int ISBN;
        public static double price;

        public books()
        {

        }
        

        public void AddBooks(string title1, string author1, int ISBN1, double price1)
        {
            title = title1;
            author = author1;
            ISBN = ISBN1;
            price = price1;
        }

        public static void AddNewBooks (string title1, string author1, int ISBN1, double price1)
        {
            title = title1;
            author = author1;
            ISBN = ISBN1;
            price = price1;

           // List<books> BookList = new List<books>();
            

        }


    }
}
