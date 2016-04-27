using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Car : Vehicle
    {
        int totalNumberOfCars;

        public void AddCar(string make,string model,int salePrice)
        {
            AddVehicle(make, model, salePrice);
            totalNumberOfCars++;
        }

        public void SellCar(int salePrice,bool sold)
        {
            VehicleSold(salePrice, sold);
            totalNumberOfCars--;
        }
    }
}
