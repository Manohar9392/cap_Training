using System;

public ref struct MyRefStruct
{
    public int Value;

    public MyRefStruct(int value)
    {
        Value = value;
    }

    public void Display()
    {
        Console.WriteLine($"Value: {Value}");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        using MyRefStruct myStruct = new MyRefStruct(10);//by using it will act as disposable it will keep track variable upto last usage then it will dispose it
        myStruct.Display();
    }
}