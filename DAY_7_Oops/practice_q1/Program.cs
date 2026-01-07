using System;


using q1;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Calculating Robot Hazard Risk...\n");
        Console.Write("Enter armPrecision (0.0 - 1.0): ");
        double armPrecision = double.TryParse(Console.ReadLine(),out armPrecision)? armPrecision : -1.0;
        Console.Write("Enter workerDensity (1 - 20): ");
        int workerDensity = int.TryParse(Console.ReadLine(),out workerDensity)? workerDensity : -1;
        Console.Write("Enter machineryState (Worn, Faulty, Critical): ");
        string? machineryState = Console.ReadLine().ToLower; 

        RobotHazardAuditor auditor = new RobotHazardAuditor();
        try
        {
            double risk = auditor.CalculateHazardRisk(armPrecision, workerDensity, machineryState);
            Console.WriteLine("Calculated Hazard Risk: " + risk);
        }
        catch (RobotSafetyException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}