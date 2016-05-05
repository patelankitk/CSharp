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

            books new book;

            //books book1 = new books();
            //book1.title1 = "C#";
            //book1.author1 = "A";
            //book1.ISBN1 = 12345;
            //book1.price1 = 12.35;
            //BookList.Add(book1);

            //books book2 = new books();
            //book2.title = "Java";
            //book2.author = "B";
            //book2.ISBN = 123456;
            //book2.price = 25;
            //BookList.Add(book2);

            //books book3 = new books();
            //book3.title = "Java Script";  
            //book3.author = "C";
            //book3.ISBN = 1234567;
            //book3.price = 30;
            //BookList.Add(book3);

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
                        Console.WriteLine("Please enter a the Name of new book:");
                        string BookName =Console.ReadLine();

                        Console.WriteLine("Please enter a the Author of new book:");
                        string BookAuthor = Console.ReadLine();

                        Console.WriteLine("Please enter a the ISBN of new book:");
                        int BookISBN = int.Parse(Console.ReadLine());

                        Console.WriteLine("Please enter a the Price of new book:");
                        double BookPrice =double.Parse(Console.ReadLine());

                        
                            BookList.AddNewBooks(BookName,BookAuthor,BookISBN,BookPrice);
                            BookList.All(books.AddNewBooks(BookName, BookAuthor, BookISBN, BookPrice));
                        



                        break;

                    case "R":

                        Console.WriteLine("Please Enter the Book title you wish to remove.");
                        string bookRemove =Console.ReadLine();

                        //for (int i = 0; i < BookList.Count; i++)
                        //{
                        //    if (BookList[i].title.ToLower() == bookRemove.ToLower() )
                        //    {
                        //        BookList.RemoveAt(i);
                        //        Console.WriteLine("\nYour book with title {0} has been removed.", bookRemove);
                        //    }                       
                        //}

                        
                        break;

                    default:
                        break;
                }
            } while (UserChoice!="Q");


        }
    }
}
