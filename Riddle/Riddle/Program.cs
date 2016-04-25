using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Riddle
{
    class Program
    {
        static void Main(string[] args)
        {
            string riddle1;
            string riddle2;
            int guess = 0;
            int score = 0;
            Console.WriteLine("Riddle Game.\n\n\n");
            
                do
                {
                    Console.WriteLine("What has a face and two hands but no arms or legs?\n ");
                    riddle1 = Console.ReadLine().ToLower();
                    if (riddle1 == "clock")
                    {
                        guess = 0;
                        Console.WriteLine("\nThats correct.\n");
                        score++;
                    }
    
                    else
                    {
                        Console.WriteLine("\nSorry Wrong Answer, please guess again.\n");
                        guess++;
                    }
                } while (riddle1 != "clock" && guess !=3);

            guess = 0;
            
                do
                {
                    Console.WriteLine("What has a thumb and four fingers but is not alive?\n ");
                    riddle2 = Console.ReadLine().ToLower();

                    if (riddle2 == "glove")
                    {
                        guess = 0;
                        Console.WriteLine("\nThats correct.\n");
                        score++;
                        
                    }
                    else
                    {
                        
                        Console.WriteLine("\nSorry Wrong Answer, please guess again.");
                        guess++;
                        
                    }
                  
                 } while (riddle2 != "glove" && guess!=3);
            Console.WriteLine("Your Score is :- {0}", score);
            guess = 0;
            score = 0;

        }
    }
}
