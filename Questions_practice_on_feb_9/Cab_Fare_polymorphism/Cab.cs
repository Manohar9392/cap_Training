using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cab_Fare_polymorphism
{
    public class Cab
    {
       

        public virtual void CalculateFare(int distance)
        {
            Console.WriteLine($" Total fare for cab :{distance * 10} "); // Base fare calculation
        }

        
    }

    public class Mini : Cab
    {
        public override void CalculateFare(int distance)
        {
            Console.WriteLine($" Total fare for Mini Cab :{distance * 12} "); // Mini cab fare calculation
        }
    }
    public class Sedan : Cab
    {
               public override void CalculateFare(int distance)
        {
            Console.WriteLine($" Total fare for Sedan Cab :{distance * 15+50} "); // Sedan cab fare calculation
        }
    }

    public class SUV : Cab
    {
        public override void CalculateFare(int distance)
        {
            Console.WriteLine($" Total fare for SUV Cab :{distance * 18+100} "); // SUV cab fare calculation
        }
    }
}
