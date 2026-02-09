using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce_discount
{
    public abstract class DiscountPloicy
    {
        public abstract void GetFinalAmount(decimal amount);
    }
    public class FestivalDiscount : DiscountPloicy
    {
        public override void GetFinalAmount(decimal amount)
        {
            if (amount > 5000)
            {
                Console.WriteLine("Festival Discount 10%: " + (0.9m * amount));
            }
            else
            {
                Console.WriteLine("Festival Discount 5%: " + 0.95m*amount);
            }
        }
    }
    public class MemberDiscount : DiscountPloicy
    {
        public override void GetFinalAmount(decimal amount)
        {
            if (amount >= 2000)
            {
                Console.WriteLine("Member Discount : " +(amount-300));
            }
            else
            {
                Console.WriteLine("No Discount : " + amount);
            }
        }
    }
}
