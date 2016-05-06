using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// PROGRAM FOR BOOK COLLECTION //

namespace CollectionBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\n\n\t\t\tBooks Collection.\n");

            // Creating a List for user to store books in the List //
            List<books> BookList = new List<books>();

            //Creating a Variable to store user option to navigate through our Book Collection //
            String UserChoice;

            // Creating a Do While Loop for user to iterate through the option till they decide to exit the program //
            do
            {
                Console.WriteLine("--------------------------------------------------------------------------------");
                Console.WriteLine("\n\tYou have got following option for books.\n\n\tList(L) \t2.Add(A) \t3.Remove(R) \t4.Quit(Q)\n"); //Options for User //
                Console.Write("\tYour Option : ");
                UserChoice = Console.ReadLine().ToUpper(); //Getting the user choice and converting it to Uppercase //
                Console.WriteLine("\n");

                switch (UserChoice) // Start of a Switch statement to navigate through different option as per user requirement //
                {
                    case "L":
                        books.ListBook(BookList);     // Calling Method ListBook from Book Class //                    
                        break;

                    case "A": // To Add Book to our List //
                        Console.Write("\tPlease enter the Name of new book:  "); // Asking user for book details//
                        string BookName = Console.ReadLine(); // Storing result in variables //

                        Console.Write("\n\tPlease enter the Author name of the new book:  ");
                        string BookAuthor = Console.ReadLine();

                        Console.Write("\n\tPlease enter the ISBN of new book:  ");
                        int BookISBN = int.Parse(Console.ReadLine());

                        Console.Write("\n\tPlease enter the Price of new book:  ");
                        double BookPrice = double.Parse(Console.ReadLine());

                        books.AddBook(BookName, BookAuthor, BookISBN, BookPrice, BookList); // Calling AddBook Method from Book Class to add books to our List //
                      
                        break;

                    case "R":
                        books.RemoveBooks(BookList); // Calling RemoveBooks Method from Books Class to remove the book //
                        break;

                    default:
                        break;

                }
            } while (UserChoice!="Q"); // End of Do While Loop when user input Q to quit//


        }
    }
}
