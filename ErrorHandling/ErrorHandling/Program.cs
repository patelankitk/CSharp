//Error Handling Program //

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErrorHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // asking user to input an array //
            Console.WriteLine("Please enter a number to be inserted in an array.");
            
            //storing the userinput into userNumber  //
            int userNumber = int.Parse(Console.ReadLine());

            // creating an array //
            int[] Numbers = new int[5];
           

            try
            {
                for (int i = 0; i < userNumber; i++)
                {
                    Numbers[i] = 2 * (i + 2);
                    
                }

                foreach (int number  in Numbers)
                {
                    Console.WriteLine(number);
                }
            }
            catch(IndexOutOfRangeException ioor)
            {
                Console.WriteLine(ioor.Message);
                Console.ReadLine();
            }
            

        }
    }
}
