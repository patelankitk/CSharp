using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Motorcycle : Vehicle
    {
        
        public static int totalNumberOfBike;

        public void AddBike(string make, string model, int saleprice)
        {
            AddVehicle(make, model, saleprice);
            // increamenting the Bike as its been added to the stock //
            totalNumberOfBike++;
        }

        public void SellBike(int price, bool sold)
        {
            VehicleSold(price,sold);

            totalNumberOfBike--;
        }
    }
}
