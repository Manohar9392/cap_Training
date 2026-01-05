namespace model{

public abstract class Payment
{
    public static int Balance{get;protected set;}=1000;

    public abstract void Make_Payment(int amount);
        

}

public class Upi : Payment
    {
        public override void Make_Payment(int amount)
        {
            if(amount<=Payment.Balance)
            {
                Console.WriteLine($"payment Successful {amount} debited through UPI method.");
                Payment.Balance-=amount;
            }
            else
            {
                Console.WriteLine("Insufficient Balance");
            }
        }
    }
public class Credit : Payment
    {
        public override void Make_Payment(int amount)
        {
            if(amount<=Payment.Balance)
            {
                Console.WriteLine($"payment Successful {amount} debited through Credit method.");
                Payment.Balance-=amount;
            }
            else
            {
                Console.WriteLine("Insufficient Balance");
            }
        }
    }
    public class NetBanking : Payment
    {
        public override void Make_Payment(int amount)
        {
            if(amount<=Payment.Balance)
            {
                Console.WriteLine($"payment Successful {amount} debited through NetBanking  method.");
                Payment.Balance-=amount;
            }
            else
            {
                Console.WriteLine("Insufficient Balance");
            }
        }
    }
}
