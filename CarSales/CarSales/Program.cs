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
            //Car car1 = new Car { make = "audi", model = "A4", milage = 15000, salePrice = 20000 };
            //Car.totalNumberOfCars++;
            //Car car2 = new Car { make = "BMW", model = "X5", milage = 20000, salePrice = 24000 };
            //Car.totalNumberOfCars++;
            //Car car3 = new Car { make = "Range Rover", model = "Autobiography", milage = 15000, salePrice = 35000 };
            //Car.totalNumberOfCars++;

            //Console.WriteLine("Total Number of car in stock is {0}.",Car.totalNumberOfCars);
            //Console.WriteLine("Make = {0}, Model = {1}, Milage = {2}, Sale Prize = £{3}", car1.make, car1.model, car1.milage, car1.salePrice);
            //Console.WriteLine("Make = {0}, Model = {1}, Milage = {2}, Sale Prize = £{3}", car2.make, car2.model, car1.milage, car2.salePrice);
            //Console.WriteLine("Make = {0}, Model = {1}, Milage = {2}, Sale Prize = £{3}", car3.make, car3.model, car1.milage, car3.salePrice);
            Car car4 = new Car();
            car4.AddCar("Tesla", "S", 35000, 100);
            Car car5 = new Car();
            car5.AddCar("Bentley", "Continental", 180000, 10000);
            Car car6 = new Car();
            car6.AddCar("Infinity", "Q30", 30000, 8000);
            car4.ListCar();
            car5.ListCar();
            car6.ListCar();
            Console.WriteLine("Total Number of car in stock is {0}.", Car.totalNumberOfCars);
            car6.CarSold(29500, true);
            Console.WriteLine("Total Number of car in stock is {0}.", Car.totalNumberOfCars);



        }
    }
}
