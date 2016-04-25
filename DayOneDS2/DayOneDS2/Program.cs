using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayOneDS2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool guess;
            int number;
            Console.WriteLine("Please enter a data");
            string userData = Console.ReadLine();
            guess = int.TryParse(userData, out number);

          

            if (guess)
            {
                Console.WriteLine("Your Guess is an Integer.");
            }
            else
            {
                Console.WriteLine("Your Guess is a String");
            }

           

            

           
        }
    }
}
