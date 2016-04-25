using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NextPresident
{
    class Program
    {
        static void Main(string[] args)
        {
            string guess = "Y";
            string guess1 = "";

            do
            {
                Console.WriteLine("Please Select the candidate of your choice who you think will win be the next U.S President.\n \n 1.Donald Trump. \n 2.Hillary Clinton. \n 3.Ted Cruz \n 4.Ben Sanders\n");
                string userCandidate = Console.ReadLine().ToLower();

                switch (userCandidate)
                {
                    case "donald trump":
                        Console.WriteLine("Sorry doesnt look like Donald Trump will win.");
                        break;
                    case "hillary clinton":
                        Console.WriteLine("There are good chances of Hillary Clinton to win.");
                        break;
                    case "ted cruz":
                        Console.WriteLine("Ted Cruz will be a republican candidate, but think he wont be winning.");
                        break;
                    case "ben sanders":
                        Console.WriteLine("Ben Sanders may win and would be a good president.");
                        break;
                    default:
                        break;
                }

                Console.WriteLine("Do you want to continue.? Y or N");
                guess1 = Console.ReadLine().ToUpper();
            } while (guess == guess1);
        }
    }
}
