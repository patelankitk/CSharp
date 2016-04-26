
// Creating a List of Books, you can add, delete, sort and list.//

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookList
{
    class Program
    {
        // starting point of program //
        static void Main(string[] args)
        {
            // defining a list called books //
            List<string> books = new List<string>();
            // adding books name to the list book //
            books.Add("book1");
            books.Add("book2");
            books.Add("book3");
            books.Add("book4");
            books.Add("book5");

            // creating a variable which can be used to store the response from user for their action //
            string userChoice="";
            // creating a variable which can be used to store the response from user to find the book //
            string userFind = "";
            // creating a variable which can be used to store the response from user to find the book //
            string userEdit = "";
            // creating a variable which can be used to store the response from user to find the book //
            string userEdit1 = "";
            // printing book list on console //
            Console.WriteLine("Book List.");

            // creating a Do While Loop for user to keep in loop till they decide to Quit.//
            do
            {

                // printing the options for user to take some action.//
                Console.WriteLine("\n\nPlease Enter (L or A or D or S or Q or F or E)\n \n L for List of all the Books.\n A for adding a Book. \n D if you want to delete a book \n S to sort the book list. \n Q to Quit.\n F to search a book. \n E to Edit.");
                // storing the response from user in variable userChoice and converting it to Upper Case //
                userChoice = Console.ReadLine().ToUpper();

                // creating a Switch Statement to switch to relevent  action as per user wish.//
                switch (userChoice)
                {
                    // Displays the list using following code //
                    case "L":
                        Console.WriteLine("\nList of Books is as follows:-\n");
                        foreach (string book in books)
                        {
                            Console.Write("\t{0}",book);
                        }
                        break;

                        // method to add the book //
                    case "A":

                        Console.WriteLine("Please advise the name of the book to be added.");
                        string addBook = Console.ReadLine();
                        
                        books.Add(addBook);
                        break;
                        // method to delete the book //
                    case "D":

                        Console.WriteLine("Please advise the name of the book to be deleted.");
                        string deleteBook = Console.ReadLine();
                        books.Remove(deleteBook);
                        break;
                        //method to sort the book //
                    case "S":
                        books.Sort();
                        Console.WriteLine("The sorted List is as follows:-");
                        foreach (string book in books)
                        {
                            Console.Write("\t{0}", book);
                        }
                        break;

                        //method to search the book //
                    case "F":
                        //asking user for book name to be searched. //
                        Console.WriteLine("Please enter the book  name to find from the list.\n");
                        //storing the user input for book search in to var userFind //
                        userFind= Console.ReadLine().ToLower();
                        //checking if the book is present or not and if present display the message //
                        if(books.Contains(userFind))
                        {
                            Console.WriteLine("\nThe book {0} you searched is in the list.", userFind);
                        }
                        else
                        {
                            Console.WriteLine("\nThe book {0} you searched is not in the list. Please try again.", userFind);
                        }

                        break;
                    case "E":
                        // Edit method //
                        //asking user to enter the book name to be edited //
                        Console.WriteLine("Please enter the book name you wish to edit.\n");
                        //storing the user response for the book to be edited in var userEdit //
                        userEdit = Console.ReadLine().ToLower();

                        // if book to be edited is present then ask user to enter the new name 
                        //  then remove the old book name and replace it with new name and display the message //
                        if (books.Contains(userEdit))
                        {
                            Console.WriteLine("Please enter the new name of the book.\n");
                            userEdit1 = Console.ReadLine().ToLower();
                            books.Remove(userEdit);
                            books.Add(userEdit1);
                            Console.WriteLine("\nYour book has been edited from {0} to {1}", userEdit, userEdit1);
                        }
                        // if the book to be edited is not present then display below message //
                        else
                        {
                            Console.WriteLine("\nThe book {0} you searched is not in the list. Please try again.", userFind);
                        }

                        break;

                    default:
                        break;
                }
            } while (userChoice != "Q"); // iterating through loop till user decide to Quit //

  
        }
    }
}
