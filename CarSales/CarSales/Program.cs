using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CarSales
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car { make = "audi", model = "A4", milage = 15000, salePrize = 20000 };
            Car car2 = new Car { make = "BMW", model = "X5", milage = 20000, salePrize = 24000 };
            Car car3 = new Car { make = "Range Rover", model = "Autobiography", milage = 15000, salePrize = 35000 };

            Console.WriteLine("Make = {0}, Model = {1}, Milage = {2}, Sale Prize = {3}, Total Number of Cars = {4}", car1.make, car1.model, car1.milage, car1.salePrize,Car.totalNumberOfCars);
            Console.WriteLine("Make = {0}, Model = {1}, Milage = {2}, Sale Prize = {3}", car2.make, car2.model, car1.milage, car2.salePrize);
            Console.WriteLine("Make = {0}, Model = {1}, Milage = {2}, Sale Prize = {3}", car3.make, car3.model, car1.milage, car3.salePrize);


        }

        
           
    }
    

    public class Car
    {
        public string make { get; set; }
        public string model { get; set; }
        public int salePrize { get; set; }
        public int milage { get; set; }
        public static int totalNumberOfCars = 3;
    }



}
