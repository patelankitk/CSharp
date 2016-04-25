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
            string toContinue;
            int guess = 0;
            int score = 0;
            Console.WriteLine("Riddle Game.\n\n\n");
            
                do
                {
                    Console.WriteLine("What has a face and two hands but no arms or legs?\n ");
                    riddle1 = Console.ReadLine().ToLower();
                    if (riddle1 == "clock")
                    {
                        Console.WriteLine("\nThats correct.");
                    score ++;
                    guess = 0;
                    }
                    else
                    {
                        Console.WriteLine("\nSorry Wrong Answer, please guess again.\n");
                    guess++;
                        
                    }
                    

            } while (riddle1 != "clock" && guess !=2);
            
                do
                {
                    Console.WriteLine("What has a thumb and four fingers but is not alive?\n ");
                    riddle2 = Console.ReadLine().ToLower();
                    if (riddle2 == "glove")
                    {
                        Console.WriteLine("\nThats correct.");
                    }
                    else
                    {
                        Console.WriteLine("\nSorry Wrong Answer, please guess again.");
                    }
                    Console.WriteLine("Do you want to continue..? Y or N");
                    toContinue = Console.ReadLine().ToLower();
            } while (riddle2 != "glove" && toContinue!="n");

            

        }
    }
}
