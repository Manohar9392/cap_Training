namespace MyLibrary;

public class Calculator
{
    public int Add(int a, int b) => a + b;

    public double Divide(double a, double b)
    {
        if (b == 0) throw new DivideByZeroException("Cannot divide by zero.");
        return a / b;
    }

    public string GetGreeting(string name) => $"Hello, {name}!";
}
public class MultiExcept
{

    public int getval(int val)
    {
        if (val == 0) throw new DivideByZeroException("Value should be more than zero");
        if (val == 1) throw new Exception("val should more than one");
        return val;

    }

}
