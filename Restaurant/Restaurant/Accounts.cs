using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public class Accounts
    {

        
        public static decimal TotalBill(Meal meal, decimal balance)

        {
            balance = balance + meal.price;
            balance = balance - meal.cost;

            return balance;

        }
    
    }
}
