using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace Iprintable{


public interface Isprintable
{
    public void Print();
     void GetPrint();
       
}

public interface Scanable
    {
        public void Scan();
         void GetPrint();
        
    }
public class Printer : Isprintable,Scanable
    {
        public void Print()
        {
            Console.WriteLine("this is from Printer ");
            
        }
        public void Scan()
        {
            Console.WriteLine("This is from Scanner");
        }
         void Isprintable.GetPrint()
        {
            Console.WriteLine("This is from Isprintable class ");
        }
         void  Scanable.GetPrint()
        {
            Console.WriteLine("This is from Scanble  interface");
        }



    }
}
