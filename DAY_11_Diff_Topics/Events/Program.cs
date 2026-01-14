using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharp
{
    public class EventExample
    {
        public delegate void Notify();  // delegate
        public static event Notify Reached500; // event
        public static void Main()
        {
            

            while (true)
            {
                Console.WriteLine("Enter a number (or 'exit' to quit): ");
                string input = Console.ReadLine();
                if (input.ToLower() == "exit")
                    break;
                try
                {
                    Console.WriteLine("Enter value a Value ");
                    var num = int.Parse(Console.ReadLine());
                    if (num > 500)
                    {
                        Reached500 += ValueReached500Plus; //event calling 
                    }
                    // if(num%4==0)
                    // {
                    //     Reached500+=ValueReached1000Plus;
                    // }
                    
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }

                if(Reached500!=null)
                {
                    Reached500();
                }
     
                Reached500=null;

                
            }
        }

        private static void ValueReached500Plus()
        {
            Console.WriteLine("Yes Reached 500 or 500 plus please note");
        }
        private static void ValueReached1000Plus()
        {
            Console.WriteLine("Yes you are diving by 4 Note");
        }

        
    }
}