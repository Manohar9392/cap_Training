using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ecommerce_product_catalog;

namespace Ecommerce_product_catalog1
{
    public static  class InventoryManager
    {

        public static List<Product> products=new List<Product>();


        public static void AddProduct(string name,string category,double price,int quantity)
        {
            Product p=new Product(name,category,price,quantity);
            products.Add(p);


        }

        public static SortedDictionary<string, List<Product>> GroupProductsByCategory()
        {
           SortedDictionary<string,List<Product>> categorizebooks=new SortedDictionary<string,List<Product>>();

            foreach (Product p in products)
            {
                if(!categorizebooks.ContainsKey(p.Category))
                {
                    categorizebooks[p.Category]=new List<Product>();
                }
                categorizebooks[p.Category].Add(p);
            }

            return categorizebooks;
        }


        public static bool UpdateStock(string productCode, int quantity)
        {
            foreach (Product p in products)
            {
                if (p.ProductCode == productCode)
                {
                    p.StockQuantity = quantity;
                    return true;
                }
            }
            return false;
        }


        public static List<Product> GetProductsBelowPrice(double maxPrice)
        {
            List<Product> belowproducts = new List<Product>();

            belowproducts=products.Where(s=>s.Price<maxPrice).ToList();

            return belowproducts;
        }

        public static Dictionary<string, int> GetCategoryStockSummary()
        {
            Dictionary<string, int> stocksummary=new Dictionary<string, int>();

            foreach(var v in products)
            {
                if (!stocksummary.ContainsKey(v.Category))
                {
                    stocksummary[v.Category]=0;
                }
                stocksummary[v.Category] += 1;
            }
            return stocksummary;

        }



    }
}
