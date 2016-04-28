using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> Vehicles = new List<Vehicle>();
            Vehicles.Add(new Vehicle());
            Vehicles.Add(new Car());
            Vehicles.Add(new Motorcycle());

            foreach (Vehicle v in Vehicles)
            {
                v.wheels();
            }

            Car car1 = new Car();
            car1.wheels();
        }
    }

    class Vehicle
    {
        public virtual void wheels()
        {
            Console.WriteLine("The Vehicle has Many Wheels.");
        }
    }

    class Car : Vehicle
    {
        public override void wheels()
        {
            Console.WriteLine("The Car has 4 Wheels.");
        }
    }

    class Motorcycle : Vehicle
    {
        public override void wheels()
        {
            Console.WriteLine("The Motorcycle has 2 Wheels.");
        }
    }
}
