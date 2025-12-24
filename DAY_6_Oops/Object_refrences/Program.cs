using System;
using Inheritance;
class Program
{
    static void Main(string[] args)
    {
        Person p1 = new Man(); // Upcasting
        p1.Name = "John";
        p1.Age = 30;
        ((Man)p1).Display(); // Downcasting to access Display method
    }
}