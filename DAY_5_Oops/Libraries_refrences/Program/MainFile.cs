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
        Console.WriteLine("Enter Option for Maths_Library enter 1, for Science_library enter 2");
        int input=int.TryParse(Console.ReadLine(),out input)?input:0;
        Console.WriteLine("enter the username and id to validate: ");
        String? username=Console.ReadLine();
        int id=int.TryParse(Console.ReadLine(),out id)?id:0;

        switch(input){
        
        /// <summary>
        /// Demonstrates the use of MathsLib and ScienceLib libraries.
        case(1):
        Alzebra math = new Alzebra();
        Console.WriteLine(math.Login(username,id));
        int sum = math.Add(10, 20);
        int difference = math.Subtract(30, 15);
        Console.WriteLine("Sum: " + sum);
        Console.WriteLine("Difference: " + difference);
        Console.WriteLine(math.Logout());
        break;

        case(2):

        AeroScience science = new AeroScience();
        Console.WriteLine(science.Login("manu",3));
       
        double speedOfSound = science.SpeedOfSoundAtSeaLevel();
        Console.WriteLine("Speed of Sound at Sea Level: " + speedOfSound + " m/s");
        double force = science.Force(5.0, 9.8);
        Console.WriteLine("Force: " + force + " N");
        Console.WriteLine(science.Logout());
        break;

        default:
            break;
        }
        

    }
}