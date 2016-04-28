using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Motorcycle : Vehicle
    {
        //static variable to store total number of bike //
        public static int totalNumberOfBike;
        //Method to add Bike //
        public void AddBike(string type,string make, string model, int saleprice)
        {
            //feeding the Add bike method to Add vehicle method //
            AddVehicle(type,make, model, saleprice);
            // increamenting the Bike as its been added to the stock //
            totalNumberOfBike++;
        }

        //method to sell the bike//
        public void SellBike(int price, bool sold)
        {
            //feeding the parameters received to Vehicle Sold Method in Vehicle Class //
            VehicleSold(price,sold);
            //decrement total bike //
            totalNumberOfBike--;
        }

        public override void NoOfWheels()
        {
            wheels=2;
            Console.WriteLine("Motorcycle has got:-{0} wheels.", wheels);
        }
    }

    
}
