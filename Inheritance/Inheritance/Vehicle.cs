using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Vehicle
    {
        public string type;
        public string make;
        public string model;
        public int salePrice;


        public static int totalNumberOfVehicle;

        public bool vehicleIsSold;

        public static int saleValue;

        public static int stockValue;


        // Method to add new vehicle to the stock  using input parameters //
        public void AddVehicle(string type,string make, string model, int Price)
        {
            this.type = type;
            this.make = make;
            this.model = model;
            this.salePrice = Price;

            // increamenting the car as its been added to the stock //
            totalNumberOfVehicle++;
        }




        // Method to sell a vehicle, using paraments sale price and if sold or not //
        public void VehicleSold(int price, bool sold)
        {
            this.vehicleIsSold = sold;
            this.salePrice = price;
            Console.WriteLine("Details for the vehicle sold is \n\n1.Make -{0} Model-{1} Price -{2} Vehicle Type -{3}.\n", make, model, salePrice,type);
            // decrementing the total number of vehicle as its sold now //
            totalNumberOfVehicle--;
        }

        //Method to List all car with their details and also to display if they are sold or not //
        public static void DisplayAllVehicle(List<Vehicle> VehicleList)
        {
            // foreach loop to loop through Car List and displaying the details of the car //
            foreach (Vehicle item in VehicleList)
            {
                Console.WriteLine("--------------------------------------------------------------------------------");
                Console.WriteLine("The Vehicle Details are as follows:- {0},{1},{2},{3}", item.make, item.model, item.salePrice,item.type);
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


        ////Method to calculate the total sale value //
        public static void ValueOfSale(List<Vehicle> VehicleList)
        {
            // using foreach loop to iterate through  car list and adding the sale price of all the car sold //
            foreach (Vehicle item in VehicleList)
            {
                if (item.vehicleIsSold)
                {
                    saleValue = item.salePrice + saleValue;
                }
                else
                {
                    continue;
                }

            }
            // displaying the total sale value //
            Console.WriteLine("\nThe sale value is £{0}.", saleValue);
        }

        // Method to calculate the total value of the remaining stock //
        public static void ValueOfStock(List<Vehicle> VehicleList)
        {
            // iterating through list of Car and calculating the total stock value for unsold car //
            foreach (Vehicle item in VehicleList)
            {
                if (!item.vehicleIsSold)
                {
                    stockValue = item.salePrice + stockValue;
                }
                else
                {
                    continue;
                }

            }

            //    //displaying the stock value calculated to user //
            Console.WriteLine("\nThe stock value is £{0}.", stockValue);


        }
    }
}
