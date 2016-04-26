//Creating a Dictionary Program. //

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionaries
{ 
    class Program
    {
        //start of the programm //
        static void Main(string[] args)
        {
            // defining variable userAction to store the user action //
            string userAction = "";
            //creating a dictionary  and adding key and description to it. //
            Dictionary<int, string> dictionarylanguage = new Dictionary<int, string>();
            dictionarylanguage.Add(1, "c#");
            dictionarylanguage.Add(2, "Java Script");
            dictionarylanguage.Add(3, "ASP.net");
            Console.WriteLine("Dictionary.\n\n");

            // start of do while loop till user decides to quit.//
            do
            {
                //displaying the list of action a user can perform on dictionary //
                Console.WriteLine("Please enter if you wish to Edit (E)  or ADD (A) or Remove (R) or Display List (L) from Dictionary. or Search (S) or To Quit (Q) \n");
                // storing user response into userAction and converting it into UpperCase //
                userAction = Console.ReadLine().ToUpper();
                // if statement to  List all the items in dictionary. //
                if (userAction == "L")
                {
                    foreach (KeyValuePair<int, string> kvp in dictionarylanguage)
                    {
                        Console.WriteLine("\nYour Dictionary List is as follows:-\n");
                        Console.WriteLine("Key is {0} and Description is {1}", kvp.Key, kvp.Value);
                        Console.WriteLine("----------------------------------------------------");
                    }
                }
                // statement so that user can add to the dictionary. //
                else if (userAction == "A")
                {
                    //asking user to enter key //
                    Console.WriteLine("Please enter the Key  for the language first.");
                    // storing the key in userkey //
                    int userkey = int.Parse(Console.ReadLine());
                    //asking user to enter the discription for the key. //
                    Console.WriteLine("Please enter the Description of the language.");
                    //storing the description for the key to be added.//
                    string Description = Console.ReadLine();
                    //adding to dictionary //
                    dictionarylanguage.Add(userkey, Description);
                    //displaying the message that new key is added//
                    Console.WriteLine("Your {0} and {1} are added to the Dictionary.", userkey, Description);

                }

                //Else If statement for user to edit the dictionary. //
                else if (userAction == "E")
                {
                    // asking user for the key to be edited //
                    Console.WriteLine("Please enter the Key for the language you want to edit.");
                    // storing the key after converting it in integer in userEdit //
                    int userEdit = int.Parse(Console.ReadLine());
                    // removing the key from dictionary.//
                    dictionarylanguage.Remove(userEdit);
                    // asking user for the new key // 
                    Console.WriteLine("Please enter the new Key.");
                    // storing the key in userkey1 after converting it to integer //
                    int userkey1 = int.Parse(Console.ReadLine());
                    //asking user to enter the description //
                    Console.WriteLine("Please enter the new Description.");
                    // storing the value from user in Description1 //
                    string Description1 = Console.ReadLine();
                    // adding to dictionary using key and descrition we got from user //
                    dictionarylanguage.Add(userkey1, Description1);
                    //displaying the message to user with their new key and discription.//
                    Console.WriteLine("Your key {0} has been edited with new key {1} and {2} description to the Dictionary.",userEdit, userkey1, Description1);

                }
                //statement for removing from discription. //
                else if (userAction == "R")
                {
                    //asking user to key to be removed. //
                    Console.WriteLine("Please enter the Key you want to remove.");
                    //displaying the list for user to get the key //
                    foreach (KeyValuePair<int, string> kvp in dictionarylanguage)
                    {
                        Console.WriteLine("\nYour Dictionary List is as follows:-\n");
                        Console.WriteLine("Key is {0} and Description is {1}", kvp.Key, kvp.Value);
                        Console.WriteLine("----------------------------------------------------");
                    }
                    //storing the value from user for the key to be removed and converting it into integer //
                    int userRemove = int.Parse(Console.ReadLine());
                    //removing from dictionary as per user input of key //
                    dictionarylanguage.Remove(userRemove);
                    Console.WriteLine("Your key {0} has been deleted.", userRemove);

                }
                // statement for Search in dictionary //
                else if(userAction == "S")
                    {
                    // asking user to input the key to be searched //
                    Console.WriteLine("Please enter the key you want to search.");
                    //storing the user input in userSearch after converting it into integer //
                    int userSearch = int.Parse(Console.ReadLine());
                    //searching the dictionary based on user input //
                    dictionarylanguage.ContainsKey(userSearch);
                    // if the input from user is in the list then display the message and if not then display message as well //
                    if (dictionarylanguage.ContainsKey(userSearch))
                    {
                        Console.WriteLine("Your search key {0}  and Description {1} is in the list.", userSearch, dictionarylanguage[userSearch]);
                    }
                    else
                    {
                        Console.WriteLine("Your search {0} is not in the list, please try again.", userSearch);
                    }
                    }
            } while (userAction != "Q");  // till user wants to quit continue with the code //
            // end of do while loop 
        }
    }

    
}
