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
            book1.title = "C#";
            book1.author = "A";
            book1.ISBN = 12345;
            book1.price = 12.35;
            BookList.Add(book1);

            books book2 = new books();
            book2.title = "Java";
            book2.author = "B";
            book2.ISBN = 123456;
            book2.price = 25;
            BookList.Add(book2);

            books book3 = new books();
            book3.title = "Java Script";  
            book3.author = "C";
            book3.ISBN = 1234567;
            book3.price = 30;
            BookList.Add(book3);

            string UserChoice;
            do
            {
                Console.WriteLine("\nPlease Enter 1.List(L) 2.Add(A) 3.Remove(R) 4.Quit(Q)");
                UserChoice = Console.ReadLine().ToUpper();

                switch (UserChoice)
                {
                    case "L":

                        foreach (books b in BookList)
                        {
                            Console.WriteLine("\nBook List is as follows :\nTitle : {0} \nAuthor :{1} \nISBN :{2} \nPrice :{3}", b.title, b.author, b.ISBN, b.price);
                        }
                        break;

                    case "A":

                        break;

                    case "R":

                        Console.WriteLine("Please Enter the Book title you wish to remove.");
                        string bookRemove =Console.ReadLine();

                        for (int i = 0; i < BookList.Count; i++)
                        {
                            if (BookList[i].title.ToLower() == bookRemove.ToLower() )
                            {
                                BookList.RemoveAt(i);
                                Console.WriteLine("\nYour book with title {0} has been removed.", bookRemove);
                            }                       
                        }

                        
                        break;

                    default:
                        break;
                }
            } while (UserChoice!="Q");


        }
    }
}
