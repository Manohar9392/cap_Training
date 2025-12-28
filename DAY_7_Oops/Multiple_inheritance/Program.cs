using System;
using Birds;

public class Program
{
    /// <summary>
    /// The main entry point of the program
    /// </summary>
    /// <param name="args"></param>
    public static void Main(string[] args)
    {
        Hybrid_Bird Bird = new Hybrid_Bird();// Creating an instance of Hybrid_Bird

        Bird.Fly();
        Bird.Swim();
        Bird.Sing();
        Bird.Dance();

        Bird1 b1=new Hybrid_Bird();// Upcasting to Bird1 interface
        
        b1.Walk();
        Bird2 b2=new Hybrid_Bird();//
        b2.Walk();  

        
    }
}