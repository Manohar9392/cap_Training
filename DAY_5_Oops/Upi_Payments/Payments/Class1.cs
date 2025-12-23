namespace Payments{

public  abstract class Payment
{
    public decimal Amount{get;}

    // Constructor
    protected  Payment(decimal amount)
        {
            this.Amount=amount;
            
        }
    /// <summary>
    /// Generates a receipt for the payment.
    /// </summary>
    public void Receipt()
        {
            
            Console.WriteLine($"Payment of {Amount} received.");
        }
    /// <summary>
    /// Abstract method to process the payment.
    /// </summary>
    public abstract void pay();

}

}
