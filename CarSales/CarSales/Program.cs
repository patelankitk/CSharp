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
            List<Car> CarList = new List<Car>();


            Car car1 = new Car();
            car1.AddCar("Audi","A4",15000,16000);
            CarList.Add(car1);

            Car car2 = new Car();
            car2.AddCar("BMW", "X5", 20000, 23000);
            CarList.Add(car2);

            Car car3 = new Car();
            car3.AddCar("Range Rover", "Autobiograpy", 35000, 15000);
            CarList.Add(car3);

            Car car4 = new Car();
            car4.AddCar("Tesla", "S", 35000, 100);
            CarList.Add(car4);

            Car car5 = new Car();
            car5.AddCar("Bentley", "Continental", 180000, 10000);
            CarList.Add(car5);

            Car car6 = new Car();
            car6.AddCar("Infinity", "Q30", 30000, 8000);
            CarList.Add(car6);


            car1.ListCar();
            car2.ListCar();
            car3.ListCar();
            car4.ListCar();
            car5.ListCar();
            car6.ListCar();

            Console.WriteLine("Total Number of car in stock is {0}.", Car.totalNumberOfCars);

            Car.ListAllCar(CarList);

            //car6.CarSold(29500, true);
            //Console.WriteLine("Total Number of car in stock is {0}.", Car.totalNumberOfCars);



        }
    }
}
