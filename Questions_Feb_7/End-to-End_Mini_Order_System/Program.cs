using System;
using System.Collections.Generic;
using System.Linq;

#region ENTITIES

public class Customer
{
    public string CustomerId { get; set; }
    public string Name { get; set; }
}

public class Product
{
    public string ProductId { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
    public int Stock { get; set; }
}

public class OrderItem
{
    public Product Product { get; set; }
    public int Quantity { get; set; }

    public decimal TotalPrice =>
        Product.Price * Quantity;
}

public class Order
{
    public string OrderId { get; set; }
    public Customer Customer { get; set; }
    public List<OrderItem> Items { get; set; }
        = new List<OrderItem>();

    public decimal Discount { get; set; }
    public string InvoiceNumber { get; set; }

    public decimal TotalAmount =>
        Items.Sum(i => i.TotalPrice) - Discount;
}

public class Payment
{
    public decimal Amount { get; set; }
    public bool IsSuccessful { get; set; }
}

#endregion

#region CUSTOM EXCEPTIONS

public class OutOfStockException : Exception
{
    public OutOfStockException(string msg) : base(msg) { }
}

public class InvalidCouponException : Exception
{
    public InvalidCouponException(string msg) : base(msg) { }
}

public class PaymentFailedException : Exception
{
    public PaymentFailedException(string msg) : base(msg) { }
}

public class OrderValidationException : Exception
{
    public OrderValidationException(string msg) : base(msg) { }
}

#endregion

#region SERVICES

// Handles cart operations
public class CartService
{
    public void AddToCart(Order order, Product product, int qty)
    {
        if (qty <= 0)
            throw new OrderValidationException("Quantity must be positive");

        order.Items.Add(new OrderItem
        {
            Product = product,
            Quantity = qty
        });
    }
}

// Handles inventory with atomic stock deduction
public class InventoryService
{
    private readonly object stockLock = new object();

    public void DeductStock(Product product, int qty)
    {
        lock (stockLock)
        {
            if (product.Stock < qty)
                throw new OutOfStockException(
                    $"Insufficient stock for {product.Name}");

            product.Stock -= qty;
        }
    }
}

// Coupon rules
public class CouponService
{
    public decimal ApplyCoupon(string couponCode, decimal orderTotal)
    {
        if (couponCode == "SAVE10" && orderTotal >= 500)
            return 100;

        throw new InvalidCouponException("Invalid coupon");
    }
}

// Invoice generation
public class InvoiceService
{
    public string GenerateInvoice()
    {
        return "INV-" + DateTime.UtcNow.Ticks;
    }
}

// Order placement logic
public class OrderService
{
    private InventoryService inventoryService = new InventoryService();
    private InvoiceService invoiceService = new InvoiceService();

    public void PlaceOrder(Order order)
    {
        if (order.Items.Count == 0)
            throw new OrderValidationException("Cart is empty");

        // Validate & deduct stock atomically
        foreach (var item in order.Items)
        {
            inventoryService.DeductStock(
                item.Product, item.Quantity);
        }

        // Generate invoice
        order.InvoiceNumber = invoiceService.GenerateInvoice();
    }
}

// Payment handling
public class PaymentService
{
    public Payment MakePayment(decimal amount)
    {
        if (amount <= 0)
            throw new PaymentFailedException("Invalid payment amount");

        return new Payment
        {
            Amount = amount,
            IsSuccessful = true
        };
    }
}

#endregion

#region PROGRAM (DEMO)

class Program
{
    //int a = DateTime.DaysInMonth(2004, 2);
    DateTime a = DateTime.Now;
    
    static void Main()
    {
        try
        {
            // Setup
            Customer customer = new Customer
            {
                CustomerId = "C1",
                Name = "Manu"
            };

            Product product = new Product
            {
                ProductId = "P1",
                Name = "Laptop",
                Price = 600,
                Stock = 5
            };

            Order order = new Order
            {
                OrderId = "O1",
                Customer = customer
            };

            CartService cartService = new CartService();
            CouponService couponService = new CouponService();
            OrderService orderService = new OrderService();
            PaymentService paymentService = new PaymentService();

            // Add to cart
            cartService.AddToCart(order, product, 1);

            // Apply coupon
            order.Discount =
                couponService.ApplyCoupon("SAVE10", order.TotalAmount);

            // Place order
            orderService.PlaceOrder(order);

            // Make payment
            Payment payment =
                paymentService.MakePayment(order.TotalAmount);

            Console.WriteLine("ORDER SUCCESSFUL");
            Console.WriteLine($"Invoice : {order.InvoiceNumber}");
            Console.WriteLine($"Amount  : {order.TotalAmount}");
            Console.WriteLine($"Stock Left: {product.Stock}");
        }
        catch (Exception ex)
        {
            Console.WriteLine("ORDER FAILED");
            Console.WriteLine(ex.Message);
        }
    }
}

#endregion
