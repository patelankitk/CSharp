using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSales
{
    class Car
    {
        public string make { get; set; }
        public string model { get; set; }
        public int salePrice { get; set; }
        public int milage { get; set; }
        public static int totalNumberOfCars=0;
        public bool sold;

        public void AddCar(string make, string model, int Price, int milage)
        {
            this.make = make;
            this.model = model;
            this.salePrice = Price;
            this.milage = milage;
            totalNumberOfCars++;
        }

        public void ListCar()
        {
            Console.WriteLine("The car details are as follows:- \n 1.Make -{0} \n 2.Model -{1}\n 3.Price -{2}\n 4.Milage -{3}", make, model, salePrice, milage);
        }

        public void CarSold(int price,bool sold)
        {
            this.sold = sold;
            this.salePrice = price;
            Console.WriteLine("Details for the car sold is \n 1.Make -{0} \n 2.Model -{1}\n 3.Price -{2}\n 4.Milage -{3}", make, model, salePrice, milage);
            totalNumberOfCars--;
        }

        public static void ListAllCar(List<Car> CarList)
        {
            foreach (Car item in CarList)
            {
                Console.WriteLine("The Car Details are as follows:- {0},{1},{2},{3}",item.make,item.model,item.salePrice,item.milage);
            }
        }
    }
}
