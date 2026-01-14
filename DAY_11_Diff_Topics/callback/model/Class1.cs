namespace model{
    public delegate void Notify(string message);

public class OrderService
{

    public void IsPlaced(string order,Notify call)
        {
            Console.WriteLine($"order with id {order} placed");
            call?.Invoke($"Order with id {order} confirmed sent ");
        }

}
}
