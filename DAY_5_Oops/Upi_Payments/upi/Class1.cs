using Payments;
namespace upi{

public class UpiPayment:Payment
{
    public string Upi{get;}  // Virtual Payment Address

    /// <summary>
    /// Constructor for UpiPayment class.
    /// </summary>
    /// <param name="amount"></param>
    /// <param name="vpa"></param>
    public UpiPayment(decimal amount,string vpa):base(amount)
        {
            Upi=vpa;
        }

    /// <summary>
    /// Processes the UPI payment.
    /// </summary>
    public override void pay()
        {
            Console.WriteLine($"Processed UPI payment of {Amount} from VPA: {Upi}");
        }


}
}
