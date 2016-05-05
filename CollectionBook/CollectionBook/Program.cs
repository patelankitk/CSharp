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
            Console.WriteLine("\n\n\n\t\t\tBook Collection.");


            List<books> BookList = new List<books>();

            books book1 = new books("C#","A",12345,12.35);
            books book2 = new books("Java", "B", 123456, 25);
            books book3 = new books("Java Script", "C", 1234567, 30);

            BookList.Add(book1);         
            BookList.Add(book2);
            BookList.Add(book3);

            string UserChoice;
            do
            {
                Console.WriteLine("\nPlease Enter 1.List(L) 2.Add(A) 3.Remove(R) 4.Quit(Q)");
                UserChoice = Console.ReadLine().ToUpper();

                switch (UserChoice)
                {
                    case "L":
                        books.ListBook(BookList);                        
                        break;

                    case "A":

                        Console.WriteLine("Please enter a the Name of new book:");
                        string BookName = Console.ReadLine();

                        Console.WriteLine("Please enter a the Author of new book:");
                        string BookAuthor = Console.ReadLine();

                        Console.WriteLine("Please enter a the ISBN of new book:");
                        int BookISBN = int.Parse(Console.ReadLine());

                        Console.WriteLine("Please enter a the Price of new book:");
                        double BookPrice = double.Parse(Console.ReadLine());

                        books.AddBook(BookName, BookAuthor, BookISBN, BookPrice, BookList);


                        //    BookList.AddNewBooks(BookName,BookAuthor,BookISBN,BookPrice);
                        //    BookList.All(books.AddNewBooks(BookName, BookAuthor, BookISBN, BookPrice));
                        break;

                    case "R":
                        books.RemoveBooks(BookList);
                        break;

                    default:
                        break;
                }
            } while (UserChoice!="Q");


        }
    }
}
