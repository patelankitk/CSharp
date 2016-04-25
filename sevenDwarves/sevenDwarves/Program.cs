using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sevenDwarves
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Dwarves = { "Happy", "Doc", "Sleepy", "Sneezy", "Dopey", "Bashful", "Grumpy" };

            string[] choices = new string[7];

           

            for (int i = 0; i < Dwarves.Length; i++)
            {
                Console.WriteLine("{0} Please enter your choice for dinner and drink.\n",Dwarves[i]);
                choices[i]=Console.ReadLine();
            }

            Console.ReadLine();

            for (int i = 0; i < Dwarves.Length; i++)
            {
                Console.WriteLine("{0} your dinner choice of {1} is ready.", Dwarves[i], choices[i]);
            }
            

        }
    }
}
