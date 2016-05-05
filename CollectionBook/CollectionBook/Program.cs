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
            Console.WriteLine("\n\n\n\t\t\tBooks Collection.\n");


            List<books> BookList = new List<books>();

            //books book1 = new books("C#","A",12345,12.35);
            //books book2 = new books("Java", "B", 123456, 25);
            //books book3 = new books("Java Script", "C", 1234567, 30);

            //BookList.Add(book1);         
            //BookList.Add(book2);
            //BookList.Add(book3);

            String UserChoice;
            do
            {
                Console.WriteLine("\n\tYou have got following option for books.\n\n\tList(L) \t2.Add(A) \t3.Remove(R) \t4.Quit(Q)\n");
                Console.Write("\tYour Option : ");
                UserChoice = Console.ReadLine().ToUpper();
                Console.WriteLine("\n");

                switch (UserChoice)
                {
                    case "L":
                        books.ListBook(BookList);                        
                        break;

                    case "A":

                        Console.Write("\tPlease enter the Name of new book:  ");
                        string BookName = Console.ReadLine();

                        Console.Write("\n\tPlease enter the Author name of the new book:  ");
                        string BookAuthor = Console.ReadLine();

                        Console.Write("\n\tPlease enter the ISBN of new book:  ");
                        int BookISBN = int.Parse(Console.ReadLine());

                        Console.Write("\n\tPlease enter the Price of new book:  ");
                        double BookPrice = double.Parse(Console.ReadLine());

                        books.AddBook(BookName, BookAuthor, BookISBN, BookPrice, BookList);
                      
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
