using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Food_Delivery
{
    public  class Order
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public List<FoodItem> FoodItems { get; set; }

        public DateTime OrderDate { get; set; }
        public string Status { get; set; }
        public double TotalAmount { get; set; }

        /// <summary>
        /// Initializes a new instance of the Order class with the specified order ID, customer ID, list of food items,
        /// and total amount.
        /// </summary>
        /// <param name="id">The unique identifier for the order.</param>
        /// <param name="customerid">The identifier of the customer placing the order.</param>
        /// <param name="items">The list of food items included in the order. Cannot be null.</param>
        /// <param name="amount">The total monetary amount for the order.</param>

        public Order(int id,int customerid,List<FoodItem> items,double amount)
        {
            Id = id;
            CustomerId = customerid;
            FoodItems = items;
            OrderDate = DateTime.Now;
            Status = "Placed";
            TotalAmount = amount;

        }

    }
}
