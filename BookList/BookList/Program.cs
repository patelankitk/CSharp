using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookList
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> books = new List<string>();
            books.Add("book1");
            books.Add("book2");
            books.Add("book3");
            books.Add("book4");
            books.Add("book5");

            string userChoice="";
           
            Console.WriteLine("Book List.");
            do
            {


                Console.WriteLine("\n\nPlease Enter (L or A or D or S or Q)\n \n L for List of all the Books.\n A for adding a Book. \n D if you want to delete a book \n S to sort the book list. \n Q to Quit.");
                userChoice = Console.ReadLine().ToUpper();

                switch (userChoice)
                {

                    case "L":
                        Console.WriteLine("\nList of Books is as follows:-\n");
                        foreach (string book in books)
                        {
                            Console.Write("\t{0}",book);
                        }
                        break;
                    case "A":

                        Console.WriteLine("Please advise the name of the book to be added.");
                        string addBook = Console.ReadLine();
                        
                        books.Add(addBook);
                        break;

                    case "D":

                        Console.WriteLine("Please advise the name of the book to be deleted.");
                        string deleteBook = Console.ReadLine();
                        books.Remove(deleteBook);
                        break;

                    case "S":
                        books.Sort();
                        Console.WriteLine("The sorted List is as follows:-");
                        foreach (string book in books)
                        {
                            Console.Write("\t{0}", book);
                        }



                        break;

                    default:
                        break;
                }
            } while (userChoice != "Q");

  
        }
    }
}
