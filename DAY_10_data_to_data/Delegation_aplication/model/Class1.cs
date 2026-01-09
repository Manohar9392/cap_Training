namespace model{

public delegate string PrintMessage(string message );

public class PrintProgram
{
    public PrintMessage CustomerChoice{get;set;}

    public void prints(string message)
    {
        string messagetoprint=CustomerChoice(message);
        Console.WriteLine(messagetoprint);
    }

}
}
