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
            //Creating a List for CAR class //
            List<Car> CarList = new List<Car>();

            
            // Creating an instance of Car called Car1 //
            Car car1 = new Car();

            //Calling ADDCAR Method from Car Class and adding new car to the stock //
            car1.AddCar("Audi","A4",15000,16000);

            //Adding Car1 to the list //
            CarList.Add(car1);

            // Creating an instance of Car called Car2 //
            Car car2 = new Car();

            //Calling ADDCAR Method from Car Class and adding new car to the stock //
            car2.AddCar("BMW", "X5", 20000, 23000);

            //Adding Car2 to the list //
            CarList.Add(car2);

            // Creating an instance of Car called Car3//
            Car car3 = new Car();

            //Calling ADDCAR Method from Car Class and adding new car to the stock //
            car3.AddCar("Range Rover", "Autobiograpy", 35000, 15000);

            //Adding Car3 to the list //
            CarList.Add(car3);

            // Creating an instance of Car called Car4 //
            Car car4 = new Car();

            //Calling ADDCAR Method from Car Class and adding new car to the stock //
            car4.AddCar("Tesla", "S", 35000, 100);

            //Adding Car4 to the list //
            CarList.Add(car4);

            // Creating an instance of Car called Car5 //
            Car car5 = new Car();

            //Calling ADDCAR Method from Car Class and adding new car to the stock //
            car5.AddCar("Bentley", "Continental", 180000, 10000);

            //Adding Car5 to the list //
            CarList.Add(car5);

            // Creating an instance of Car called Car6 //
            Car car6 = new Car();

            //Calling ADDCAR Method from Car Class and adding new car to the stock //
            car6.AddCar("Infinity", "Q30", 30000, 8000);

            //Adding Car1 to the list //
            CarList.Add(car6);

            // listing car 1-6 using the ListCar Method of Car
            car1.ListCar();
            car2.ListCar();
            car3.ListCar();
            car4.ListCar();
            car5.ListCar();
            car6.ListCar();


            // Writing the total number of car in stock //
            Console.WriteLine("Total Number of car in stock is {0}.", Car.totalNumberOfCars);


            //Selling the car5 using CarSold Method, with sale price and Sold = True  //
            car5.CarSold(175000,true);

            //Selling the car6 using CarSold Method,with sale price and Sold = True  //
            car6.CarSold(29500, true);
            
            // Listing all cars including if they are sold or not //
            Car.ListAllCar(CarList);

            // displaying the total value of total sale //
            Car.ValueOfSale(CarList);

            // displaying the total value of stock //
            Car.ValueOfStock(CarList);

            //displaying the total number of car in stock after selling cars //
            Console.WriteLine("Total Number of car in stock is {0}.", Car.totalNumberOfCars);

        }
    }
}
