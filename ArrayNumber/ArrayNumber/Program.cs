using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayNumber
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] numbers = new int[5];

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("Please enter your {0} number", i + 1);
                numbers[i]=int.Parse(Console.ReadLine());

            }

            Console.ReadLine();


            int number1 = 0;
            foreach  (int number in numbers)
            {
                number1 = number + number1;
            }

            Console.WriteLine("The average of all the elements in the array is {0}", number1 / numbers.Length);
        }
    }
}
