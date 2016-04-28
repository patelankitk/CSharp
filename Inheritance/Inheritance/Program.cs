using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // creating a list for vehicle to be stored //
            List<Vehicle> VehicleList = new List<Vehicle>();

            List<Motorcycle> BikeList = new List<Motorcycle>();
            List<Car> CarList = new List<Car>();


            // creating object of motorcycle //
            Motorcycle M1 = new Motorcycle();
            //adding new bike //
            M1.AddBike("Bike","A", "Model1", 10000);
            //adding bike to vehicle list //
            VehicleList.Add(M1);
            BikeList.Add(M1);

            // creating object of motorcycle //
            Motorcycle M2 = new Motorcycle();
            //adding new bike //
            M2.AddBike("Bike","B", "Model2", 11000);
            //adding bike to vehicle list //
            VehicleList.Add(M2);
            BikeList.Add(M2);

            // creating object of car //
            Car C1 = new Car();
            //adding new car //
            C1.AddCar("Car","Audi", "Model1", 15000);
            //adding car to vehicle list //
            VehicleList.Add(C1);
            CarList.Add(C1);

            // creating object of car //
            Car C2 = new Car();
            //adding new car //
            C2.AddCar("Car","BMW", "Model2", 16000);
            //adding car to vehicle list //
            VehicleList.Add(C2);
            CarList.Add(C2);

            //selling bike using sellbike method //
            M1.SellBike(9500, true);

            //selling car using sellcar method //
            C1.SellCar(14500, true);

            //displaying the value of sold vehicles using value of sale method in vehicle class //
            Vehicle.ValueOfSale(VehicleList);

            //displaying the value of total stock remaining using value of stock method in vehicle class //
            Vehicle.ValueOfStock(VehicleList);

            //listing all the vehicle using list all vehicle method //
            Vehicle.DisplayAllVehicle(VehicleList);


            // displaying the total number of vehicles //                     
            Console.WriteLine("Total Vehicle in Stock is {0}.\n", Vehicle.totalNumberOfVehicle);
            //displaying total number of cars //
            Console.WriteLine("Cars in Stock is {0}.\n", Car.totalNumberOfCars);
            //displaying total number of bikes //
            Console.WriteLine("Motorcycle in Stock is {0}.\n", Motorcycle.totalNumberOfBike);





        }
    }
}
