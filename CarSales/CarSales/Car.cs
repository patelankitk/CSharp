using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSales
{
    class Car
    { 
        // field for Car Class //
        public string make;
        public string model;
        public int salePrice;
        
        public int mileage;
        public static int totalNumberOfCars;
        public bool sold;

        public  static int saleValue;

        public static int stockValue;

        // Method to add new car to the stock  using input parameters //
        public void AddCar(string make, string model, int Price, int milage)
        {
            this.make = make;
            this.model = model;
            this.salePrice = Price;
            this.mileage = milage;
            // increamenting the car as its been added to the stock //
            totalNumberOfCars++;
        }
        
        //Method to list a particular car details and also advising if its sold or not //
        public void ListCar()
        {
            Console.WriteLine("The car details are as follows:- \n 1.Make -{0} \n 2.Model -{1}\n 3.Price -{2}\n 4.Milage -{3}", make, model, salePrice, mileage);

            // if statement if the car is sold or not //
            if (!sold)
            {
                Console.WriteLine("This Car is still available for sale.");
            }
            else
            {
                Console.WriteLine("Sorry this Car is sold.");
            }

        }

        // Method to sell a car, using paraments sale price and if sold or not //
        public void CarSold(int price,bool sold)
        {
            this.sold = sold;
            this.salePrice = price;
            Console.WriteLine("Details for the car sold is \n 1.Make -{0} \n 2.Model -{1}\n 3.Price -{2}\n 4.Milage -{3}", make, model, salePrice, mileage);
            // decrementing the total number of cars as its sold now //
            totalNumberOfCars--;
        }

        //Method to List all car with their details and also to display if they are sold or not //
        public static void ListAllCar(List<Car> CarList)
        {
            // foreach loop to loop through Car List and displaying the details of the car //
            foreach (Car item in CarList)
            {
                Console.WriteLine("The Car Details are as follows:- {0},{1},{2},{3}",item.make,item.model,item.salePrice,item.mileage);
                if (!item.sold)
                {
                    Console.WriteLine("Still available for sale.");
                }
                else
                {
                    Console.WriteLine("Sorry this car is sold out.");
                }
            }
        }

        //Method to calculate the total sale value //
        public static void ValueOfSale(List<Car> CarList)
        {
            // using foreach loop to iterate through  car list and adding the sale price of all the car sold //
            foreach (Car item in CarList)
            {            
                if (item.sold)
                {
                    saleValue = item.salePrice + saleValue; 
                }
                else
                {
                    continue;
                }
               
            }
            // displaying the total sale value //
            Console.WriteLine("\nThe sale value is £{0}.",saleValue);
        }

        // Method to calculate the total value of the remaining stock //
        public static void ValueOfStock(List<Car> CarList)
        {
            // iterating through list of Car and calculating the total stock value for unsold car //
            foreach (Car item in CarList)
            {
                if (!item.sold)
                {
                    stockValue = item.salePrice + stockValue;
                }
                else
                {
                    continue;
                }

            }

            //displaying the stock value calculated to user //
            Console.WriteLine("\nThe stock value is £{0}.", stockValue);
        }
    }
}
