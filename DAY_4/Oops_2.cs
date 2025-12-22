using System;


namespace Oops_2
{
    public class Addition
    {
        public int Num1{get; set;}
        public int Num2{get; set;}
        public int Result {get; }


        public Addition(int num1,int num2)
        {
            this.Num1=num1;
            this.Num2=num2;
            this.Result= Num1+Num2;
        }

        public void Display()
        {
            Console.WriteLine("Addition is: "+Result);
        }
    }
    
}