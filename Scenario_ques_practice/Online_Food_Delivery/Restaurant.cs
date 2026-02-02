using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Food_Delivery
{
    public  class Restaurant
    {
        public int Id { get; set; }
        public string Name { get; set; }
        
        public string CuisineType { get; set; }
        public string Location { get; set; }

        public double DeliveryCharge { get; set; }

        /// <summary>
        /// Initializes a new instance of the Restaurant class with the specified identifier, name, cuisine type,
        /// location, and delivery charge.
        /// </summary>
        /// <param name="Id">The unique identifier for the restaurant.</param>
        /// <param name="name">The name of the restaurant. Cannot be null or empty.</param>
        /// <param name="cuisine">The type of cuisine served by the restaurant. Cannot be null or empty.</param>
        /// <param name="location">The location of the restaurant. Cannot be null or empty.</param>
        /// <param name="charge">The delivery charge for orders from the restaurant. Must be greater than or equal to 0.</param>

        public Restaurant(int Id,string name,string cuisine,string location,double charge)
        {
            this.Id = Id;
            this.Name = name;
            this.CuisineType = cuisine;
            this.Location = location;
            this.DeliveryCharge = charge;
        }
       


    }
}
