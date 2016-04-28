using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Car : Vehicle
    {
        // static variable to store the total number of cars //
        public static int totalNumberOfCars;
        //method to add car //
        public void AddCar(string type,string make,string model,int salePrice)
        {
            //feeding the paraments received to ADD Vehicle method of Vehicle class //
            AddVehicle(type,make, model, salePrice);
            //increament the total number of car //
            totalNumberOfCars++;
        }
        //method to sell the car //
        public void SellCar(int salePrice,bool sold)
        {
            //using the method  Vehiclesold of Vehicle Class by passing the parameters received //
            VehicleSold(salePrice, sold);
            //decrementing the number of car //
            totalNumberOfCars--;
        }
        public static void DisplayCar(List<Car> CarList)
        {


            // foreach loop to loop through Car List and displaying the details of the car //
            foreach (Car item in CarList)
            {
                Console.WriteLine("--------------------------------------------------------------------------------");
                Console.WriteLine("The Car Details are as follows:- {0},{1},{2}", item.make, item.model, item.salePrice);
                if (!item.vehicleIsSold)
                {
                    Console.WriteLine("Still available for sale.");
                }
                else
                {
                    Console.WriteLine("Sorry this Vehicle is sold out.");
                }

                Console.WriteLine("--------------------------------------------------------------------------------");
            }
        }
    }
}
