using System;
using System.Linq.Expressions;

class OrderProcessor
{
    static void Main()
    {
        int[] orders = { 101, -1, 103 };

        foreach(var orderid in orders)
        {
            try
            {
                if (orderid < 0)                                                    
                {
                    throw new Exception("Invalid order id");                   
                }
                else
                {
                    Console.WriteLine($"order with id {orderid} processed");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        // TODO:
        // 1. Process each order
        // 2. Throw exception for invalid order ID
        // 3. Ensure one failure does not stop processing
    }
}