using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayOneDS1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random guessNumber = new Random();
            int guessNumber1 = guessNumber.Next(0, 101);
            
            int userGuess;
            do
            { 
            Console.WriteLine("Please Enter a Number.");
            userGuess = int.Parse(Console.ReadLine());
                 
                if (userGuess > guessNumber1 )
                {
                    Console.WriteLine("Please guess a lower number.\n");
                }
                else if (userGuess < guessNumber1)
                {
                    Console.WriteLine("Please guess a higher number.\n");
                }
            } while (userGuess != guessNumber1);

            Console.WriteLine("You Guessed it, the correct guess is {0}.\n", userGuess);
            Console.ReadLine();

        }
    }
}
