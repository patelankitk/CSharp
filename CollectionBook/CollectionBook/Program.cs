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

            string UserChoice;
            do
            {
            Console.WriteLine("Please Enter 1.List(L) 2.Add(A) 3.Remove(R) 4.Quit(Q)");
            UserChoice = Console.ReadLine().ToUpper();

            switch (UserChoice)
            {
                case "L":
                        foreach (books b in BookList)
                        {
                            Console.WriteLine("Book List is Title -{0},Author -{1},ISBN -{2},Price -{3}.", b.title, b.author, b.ISBN, b.price);
                        }
                    
                    break;

                case "A":

                    break;

                case "R":

                    Console.WriteLine("Please Enter the Book you wish to remove.");
                    string bookRemove =Console.ReadLine();
                    //BookList.Contains()
                    break;

                default:
                    break;
            }
            } while (UserChoice!="Q");


        }
    }
}
