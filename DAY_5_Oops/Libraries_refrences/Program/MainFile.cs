using System;
using MathsLib;
using ScienceLib;
public class Program
{
    /// <summary>
    /// Main method - Entry point of the program.
    /// </summary>
    /// <param name="args"></param>
    public static void Main(String[] args)
    {
        /// <summary>
        /// Demonstrates the use of MathsLib and ScienceLib libraries.
        Alzebra math = new Alzebra();
        int sum = math.Add(10, 20);
        int difference = math.Subtract(30, 15);
        Console.WriteLine("Sum: " + sum);
        Console.WriteLine("Difference: " + difference);

        AeroScience science = new AeroScience();
        double speedOfSound = science.SpeedOfSoundAtSeaLevel();
        Console.WriteLine("Speed of Sound at Sea Level: " + speedOfSound + " m/s");
        double force = science.Force(5.0, 9.8);
        Console.WriteLine("Force: " + force + " N");
    }
}