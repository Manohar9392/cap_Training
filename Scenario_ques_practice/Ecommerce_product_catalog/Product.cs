using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ecommerce_product_catalog1;

namespace Ecommerce_product_catalog
{
    public  class Product
    {
        public string ProductCode = "P";
        public string ProductName { get; set; }
        public string Category { get; set; }
        public double Price {  get; set; }
        public int StockQuantity { get; set; }

        public Product(string name,string category,double price,int quantity )
        {
            ProductCode +=InventoryManager.products.Count+1 ;
            ProductName = name;
            Category = category;
            Price = price;
            StockQuantity = quantity;

        }
       

    }
}
