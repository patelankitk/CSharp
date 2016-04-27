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
            List<Vehicle> VehicleList = new List<Vehicle>();



            Motorcycle M1 = new Motorcycle();
            M1.AddBike("A", "Model1", 10000);
            VehicleList.Add(M1);
            

            Motorcycle M2 = new Motorcycle();
            M2.AddBike("B", "Model2", 11000);
            VehicleList.Add(M2);

            Car C1 = new Car();
            C1.AddCar("Car1", "Model1", 15000);
            VehicleList.Add(C1);


            Car C2 = new Car();
            C2.AddCar("Car2", "Model2", 16000);
            VehicleList.Add(C2);

            M1.SellBike(9500, true);
            C1.SellCar(14500, true);

            Vehicle.ValueOfSale(VehicleList);
            Vehicle.ValueOfStock(VehicleList);

            Vehicle.ListAllVehicle(VehicleList);

            
                                  
            Console.WriteLine("Total Vehicle in Stock is {0}.", Vehicle.totalNumberOfVehicle);

        }
    }
}
