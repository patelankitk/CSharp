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
            int guessNumber = 46;
            int userGuess;
            do
            { 
            Console.WriteLine("Please Enter a Number.");
            userGuess = int.Parse(Console.ReadLine());
                 
                if (userGuess > guessNumber )
                {
                    Console.WriteLine("Please guess a lower number.\n");
                }
                else if (userGuess < guessNumber)
                {
                    Console.WriteLine("Please guess a higher number.\n");
                }
            } while (userGuess != guessNumber);

            Console.WriteLine("You Guessed it, the correct guess is {0}.\n", userGuess);

        }
    }
}
