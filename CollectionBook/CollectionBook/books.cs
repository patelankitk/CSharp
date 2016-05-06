using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionBook
{
    class books
    {
        //Creating properties of book //
        private string title;
        private string author;
        private int ISBN;
        private double price;
        private static int bookCounter = 0; // Counter to count number of books in our collection //

        // Constructor without any parameters //
        public books()
        {

        }
        
        // Constructor with different parameters to set the value of properties //
        public books(string title, string author, int ISBN, double price)
        {
            this.title = title;
            this.author = author;
            this.ISBN = ISBN;
            this.price = price;
        }

        
        // Method to List all the books in the List with List with object books as Parameter//
        public static void ListBook(List<books> b1)
        {
            Console.WriteLine("\n\tThere are '{0}' Book in our Book Collection.",bookCounter); // Displaying the number of books we have in collection //
            foreach (books b in b1) // fpreach loop to iterate through the list of our books //
            {
                Console.WriteLine("\n\tBook List is as follows : \n\tTitle    : {0} \n\tAuthor   : {1} \n\tISBN     : {2} \n\tPrice    : {3}", b.title, b.author, b.ISBN, b.price);
            }
        } 

        // AddBook Method to add new book to our list using paraments //
        public static void AddBook(string title, string author, int ISBN, double price,List<books> b1)
        {
            books b = new books(); // creating an instance of a book //
            b.title = title;
            b.author = author;
            b.ISBN = ISBN;
            b.price = price;
            b1.Add(b);
            bookCounter++;
            Console.WriteLine("\n\t The Book '{0}' has been added to your list.\n",b.title);
                  

        }

       //RemoveBooks Method to remove the item from the list as per users input //
        public static void RemoveBooks(List<books> b1)
        {
            Console.Write("\n\tPlease Enter the Book title you wish to remove :  "); // Asking user to input the title of book to be removed //
            string bookRemove = Console.ReadLine(); //user input //

            for (int i = 0; i < b1.Count; i++) // for Loop to loop through the list and matching the title with put list //
            {
                if (b1[i].title.ToLower() == bookRemove.ToLower()) // if title matches the list then remove the complete book //
                {
                    b1.RemoveAt(i);
                    Console.WriteLine("\n\tYour book with title '{0}' has been removed.", bookRemove);
                }
                else // if title not found in out list then ask user to check the details again //
                {
                    Console.WriteLine("\n\tYour book with title '{0}'cannot be found, please enter a correct Book Title.",bookRemove);
                    break;

                }
            }
        }


    }
}
