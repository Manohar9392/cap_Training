using System;
public class Program
{
    public enum Semisters
    {
        Semister1,
        Semister2,
        Semister3,
        Semister4,
        Semister5,
        Semister6
    }

    public enum Subjects
    {
        Maths=1,
        Science=2,
        c=3,
        Python=4,
        Dsa=5
    }
    public static void Main(string[] args)
    {
        int[,] arr1=new int[6,5];
        for(int i=0;i<6;i++)
        {
            for(int j=0;j<5;j++)
            {
                arr1[i,j]=j+1;
            }
        }
        
         for(int i=0;i<6;i++)
        {
            Semisters s1;
            s1=(Semisters)i;
            Console.WriteLine($"Semister {s1}:");
            for(int j=0;j<5;j++)
            {
                Subjects S1;
                S1=(Subjects)arr1[i,j];
                Console.WriteLine($"subject{arr1[i,j]}:{S1}");
                
            }
            Console.WriteLine("---------------------------------------------------------");
            
        }
        
    }
}